using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using System.Security.Principal;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Solution_Scoping_Tool
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();

            //Set Solution Engineer TextBox to current display name
            try
            {
                textBoxSolutionEngineerName.Text = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName.ToString();
            }
            catch
            {
                //Do nothing
            }
            
            //Load Solution Scoping Tool Configuration Settings
            LoadConfigSettings();
        }

        private void LoadConfigSettings()
        {
            try
            {
                //Get default ConfigSettings.json filepath and name
                string oldString = "\\bin\\x86\\debug";
                string newString = "";
                string strFilename = System.Windows.Forms.Application.StartupPath.ToString().ToLower().Replace(oldString, newString) + "\\Settings\\ConfigSettings.json";

                backgroundWorkerLoadConfigSettings.RunWorkerAsync(strFilename);
            }
            catch
            {
                MessageBox.Show("Configuration Settings Load Error");
            }
        }

        private void backgroundWorkerLoadConfigSettings_DoWork(object sender, DoWorkEventArgs e)
        {
            string strFilename = e.Argument as string;

            var inputJSON = File.ReadAllText(strFilename);
            var JSONData = JsonConvert.DeserializeObject<RootObject>(inputJSON);

            //Details Tab
            textBoxCustomerName.Text = "";
            textBoxProjectName.Text = "";
            textBoxDesignIteration.Text = "1";
            textBoxDesignOption.Text = "a";

            //Input Tab
            var inputTab = JSONData.InputTab;

            //Primary Support Segment
            foreach (var listItem in inputTab.PrimarySupportSegment)
            {
                comboBoxPrimarySupportSegment.Items.Add(listItem);
            }
            comboBoxPrimarySupportSegment.SelectedIndex = 1;

            //Default Backup Retention
            foreach (var listItem in inputTab.DefaultBackupRetention)
            {
                comboBoxDefaultBackupRetention.Items.Add(listItem);
            }
            comboBoxDefaultBackupRetention.SelectedIndex = 1;

            //VM Snapshot Overhead
            maskedTextBoxVMSnapshotOverhead.Text = inputTab.VMSnapshotOverhead.ToString();

            //Default Maximum Utilisation
            maskedTextBoxDefaultMaximumUtilisation.Text = inputTab.DefaultMaximumUtilisation.ToString();

            //Source MHz Per Core
            maskedTextBoxSourceMHzPerCore.Text = inputTab.SourceMHzPerCore.ToString();

            //Rackconnect
            foreach (var listItem in inputTab.RackConnect)
            {
                comboBoxRackConnect.Items.Add(listItem);
            }
            comboBoxRackConnect.SelectedIndex = 0;

            //DDoS Prevention
            foreach (var listItem in inputTab.DDoSPrevention)
            {
                comboBoxDDoSPrevention.Items.Add(listItem);
            }
            comboBoxDDoSPrevention.SelectedIndex = 0;

            //Tier 1 Firewall
            foreach (var listItem in inputTab.Tier1Firewall)
            {
                comboBoxTier1Firewall.Items.Add(listItem);
            }
            comboBoxTier1Firewall.SelectedIndex = 2;
            checkBoxLoadBalancerHighAvailability.Checked = false;

            //Tier 2 Firewall
            foreach (var listItem in inputTab.Tier2Firewall)
            {
                comboBoxTier2Firewall.Items.Add(listItem);
            }
            comboBoxTier2Firewall.SelectedIndex = 0;
            checkBoxTier2FirewallHighAvailability.Checked = false;

            //Load Balancer
            foreach (var listItem in inputTab.LoadBalancer)
            {
                comboBoxLoadBalancer.Items.Add(listItem);
            }
            comboBoxLoadBalancer.SelectedIndex = 0;
            checkBoxLoadBalancerHighAvailability.Checked = false;

            //IDS ThreatManager
            foreach (var listItem in inputTab.IDSThreatManager)
            {
                comboBoxIDSThreatManager.Items.Add(listItem);
            }
            comboBoxIDSThreatManager.SelectedIndex = 0;

            //LogManager
            foreach (var listItem in inputTab.LogManager)
            {
                comboBoxLogManager.Items.Add(listItem);
            }
            comboBoxLogManager.SelectedIndex = 0;

            //Web Application Firewall
            foreach (var listItem in inputTab.WebApplicationFirewall)
            {
                comboBoxWebApplicationFirewall.Items.Add(listItem);
            }
            comboBoxWebApplicationFirewall.SelectedIndex = 0;
            checkBoxWebApplicationFirewallHighAvailability.Checked = false;

            //Global Traffic Manager
            foreach (var listItem in inputTab.GlobalTrafficManager)
            {
                comboBoxGlobalTrafficManager.Items.Add(listItem);
            }
            comboBoxGlobalTrafficManager.SelectedIndex = 0;

            //Server Tab
            var serverTab = JSONData.ServerTab;

            //Store Server Tab Datagrid Column Configuration
            int intColumnCount = dataGridViewServers.ColumnCount;
            string[] strColumnNames = new string[intColumnCount];
            for (int i = 0; i < (intColumnCount); i++)
            {
                strColumnNames[i] = dataGridViewServers.Columns[i].Name.ToString();
            }           

            //Remove Combobox Columns
            int[] intColumnArray = new int[10];

            string[] ColumnNameArray = new string[10];
            ColumnNameArray[0] = "ServerType";
            ColumnNameArray[1] = "OperatingSystem";
            ColumnNameArray[2] = "HDD1Type";
            ColumnNameArray[3] = "HDD2Type";
            ColumnNameArray[4] = "HDD3Type";
            ColumnNameArray[5] = "HDD4Type";
            ColumnNameArray[6] = "HDD5Type";
            ColumnNameArray[7] = "vHostCluster";
            ColumnNameArray[8] = "Datacentre";
            ColumnNameArray[9] = "Database";

            for (int i = 0; i < 10; i++)
            {
                intColumnArray[i] = Convert.ToInt32(dataGridViewServers.Columns[ColumnNameArray[i]].DisplayIndex.ToString());
            }

            for (int i = 9; i >= 0; i--)
            {
                dataGridViewServers.Columns.RemoveAt(intColumnArray[i]);
            }

            //Add Server Type Column
            DataGridViewComboBoxColumn cmbCol = new DataGridViewComboBoxColumn();
            cmbCol.HeaderText = "Server Type";
            cmbCol.Name = "ServerType";
            cmbCol.Resizable = DataGridViewTriState.False;
            cmbCol.SortMode = DataGridViewColumnSortMode.Automatic;
            cmbCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (var listItem in serverTab.ServerType)
            {
                cmbCol.Items.Add(listItem);
            }
            dataGridViewServers.Columns.Add(cmbCol);

            //Add Operating System Column
            cmbCol = new DataGridViewComboBoxColumn();
            cmbCol.HeaderText = "Operating System";
            cmbCol.Name = "OperatingSystem";
            cmbCol.Resizable = DataGridViewTriState.False;
            cmbCol.SortMode = DataGridViewColumnSortMode.Automatic;
            cmbCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (var listItem in serverTab.OperatingSystem.DedicatedOS)
            {
                cmbCol.Items.Add(listItem);
            }
            dataGridViewServers.Columns.Add(cmbCol);

            //Add HDD Columns
            for (int i = 1; i < 6; i++)
            {
                cmbCol = new DataGridViewComboBoxColumn();
                cmbCol.HeaderText = "HDD " + i.ToString() + "Type";
                cmbCol.Name = "HDD" + i.ToString() + "Type";
                cmbCol.Resizable = DataGridViewTriState.False;
                cmbCol.SortMode = DataGridViewColumnSortMode.Automatic;
                cmbCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                foreach (var listItem in serverTab.HDDType)
                {
                    cmbCol.Items.Add(listItem);
                }
                dataGridViewServers.Columns.Add(cmbCol);
            }

            //Add vHost Cluster Column
            cmbCol = new DataGridViewComboBoxColumn();
            cmbCol.HeaderText = "vHost Cluster";
            cmbCol.Name = "vHostCluster";
            cmbCol.Resizable = DataGridViewTriState.False;
            cmbCol.SortMode = DataGridViewColumnSortMode.Automatic;
            cmbCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (var listItem in serverTab.vHostCluster)
            {
                cmbCol.Items.Add(listItem);
            }
            dataGridViewServers.Columns.Add(cmbCol);

            //Add Datacentre Column
            cmbCol = new DataGridViewComboBoxColumn();
            cmbCol.HeaderText = "Datacentre";
            cmbCol.Name = "Datacentre";
            cmbCol.Resizable = DataGridViewTriState.False;
            cmbCol.SortMode = DataGridViewColumnSortMode.Automatic;
            cmbCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (var listItem in serverTab.Datacentre)
            {
                cmbCol.Items.Add(listItem);
            }
            dataGridViewServers.Columns.Add(cmbCol);

            //Add Database Column
            cmbCol = new DataGridViewComboBoxColumn();
            cmbCol.HeaderText = "Database";
            cmbCol.Name = "Database";
            cmbCol.Resizable = DataGridViewTriState.False;
            cmbCol.SortMode = DataGridViewColumnSortMode.Automatic;
            cmbCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (var listItem in serverTab.Database)
            {
                cmbCol.Items.Add(listItem);
            }
            dataGridViewServers.Columns.Add(cmbCol);

            //Restore Column Order
            for (int i = 0; i < intColumnCount ; i++)
            {
                dataGridViewServers.Columns[strColumnNames[i].ToString()].DisplayIndex = i;
            }

            //Set Default Values
            dataGridViewServers.Rows[0].Cells["Utilisation"].Value = inputTab.DefaultMaximumUtilisation.ToString();
            dataGridViewServers.Rows[0].Cells["RequiredMHz"].Value = inputTab.SourceMHzPerCore.ToString();
            dataGridViewServers.Rows[0].Cells["Include"].Value = true;
        }

        private void FormMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            DialogResult dialogFormClosingResult = MessageBox.Show("Save customer configuration before closing?", "Save configuration?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogFormClosingResult == DialogResult.Yes)
            {
                saveCustomerSettings();
            }
            else if (dialogFormClosingResult == DialogResult.No)
            {
                e.Cancel = false;
            }
            else if (dialogFormClosingResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            saveCustomerSettings();
        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            //string strFileName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON (*.json)|*.json";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strFileName = openFileDialog.FileName.ToString();

                string inputJSON = File.ReadAllText(strFileName);
                CustomerSettings JSONData = JsonConvert.DeserializeObject<CustomerSettings>(inputJSON);
                try
                {
                    //Detail Tab
                    textBoxCustomerName.Text = JSONData.CustomerName;
                    textBoxProjectName.Text = JSONData.ProjectName;
                    textBoxDesignIteration.Text = JSONData.DesignIteration;
                    textBoxDesignOption.Text = JSONData.DesignOption;

                    //Input Tab
                    comboBoxPrimarySupportSegment.SelectedItem = JSONData.PrimarySupportSegment;
                    comboBoxDefaultBackupRetention.SelectedItem = JSONData.DefaultBackupRetention;
                    maskedTextBoxVMSnapshotOverhead.Text = JSONData.VMSnapshotOverhead;
                    maskedTextBoxDefaultMaximumUtilisation.Text = JSONData.DefaultMaximumUtilisation;
                    maskedTextBoxSourceMHzPerCore.Text = JSONData.SourceMHzPerCore;
                    comboBoxRackConnect.SelectedItem = JSONData.RackConnect;
                    comboBoxDDoSPrevention.SelectedItem = JSONData.DDoSPrevention;
                    comboBoxTier1Firewall.SelectedItem = JSONData.Tier1Firewall;
                    checkBoxTier1FirewallHighAvailability.Checked = Convert.ToBoolean(JSONData.Tier1FirewallHA);
                    comboBoxTier2Firewall.SelectedItem = JSONData.Tier2Firewall;
                    checkBoxTier2FirewallHighAvailability.Checked = Convert.ToBoolean(JSONData.Tier2FirewallHA);
                    comboBoxLoadBalancer.SelectedItem = JSONData.LoadBalancer;
                    checkBoxLoadBalancerHighAvailability.Checked = Convert.ToBoolean(JSONData.LoadBalancerHA);
                    comboBoxIDSThreatManager.SelectedItem = JSONData.IDSThreatManager;
                    comboBoxLogManager.SelectedItem = JSONData.LogManager;
                    comboBoxWebApplicationFirewall.SelectedItem = JSONData.WebApplicationFirewall;
                    checkBoxWebApplicationFirewallHighAvailability.Checked = Convert.ToBoolean(JSONData.WebApplicationFirewallHA);
                    comboBoxGlobalTrafficManager.SelectedItem = JSONData.GlobalTrafficManager;

                    //Server Tab

                    dataGridViewServers.Rows.Clear();

                    int customerServerRecords = 0;

                    DataGridViewRow[] rowArray = new DataGridViewRow[customerServerRecords];
                    DataGridViewRow r = new DataGridViewRow();

                    int intCustomerServerItem = 0;
                    CustomerServerTab customerServerList = new CustomerServerTab();
                    List<CustomerServerTab> customerServerTab = new List<CustomerServerTab>();
                    customerServerTab = JSONData.CustomerServerTab;

                    foreach (CustomerServerTab customerServerItem in customerServerTab)
                    {
                        dataGridViewServers.Rows.Add();
                        DataGridViewRow row = dataGridViewServers.Rows[intCustomerServerItem];
                        customerServerList = new CustomerServerTab();

                        //MessageBox.Show(customerServerTab[intCustomerServerItem].ServerName.ToString());

                        customerServerList = customerServerItem;
                        //MessageBox.Show(customerServerList.ServerName.ToString() + dataGridViewServers.RowCount.ToString());

                        row.Cells["ServerName"].Value = customerServerList.ServerName;
                        row.Cells["Qty"].Value = customerServerList.Qty;
                        row.Cells["ServerType"].Value = customerServerList.ServerType;
                        row.Cells["OperatingSystem"].Value = customerServerList.OperatingSystem;
                        row.Cells["LogicalProcessors"].Value = customerServerList.LogicalProcessors;
                        row.Cells["Utilisation"].Value = customerServerList.Utilisation;
                        row.Cells["RAM"].Value = customerServerList.RAM;
                        row.Cells["HDD1"].Value = customerServerList.HDD1;
                        row.Cells["HDD1Type"].Value = customerServerList.HDD1Type;
                        row.Cells["HDD2"].Value = customerServerList.HDD2;
                        row.Cells["HDD2Type"].Value = customerServerList.HDD2Type;
                        row.Cells["HDD3"].Value = customerServerList.HDD3;
                        row.Cells["HDD3Type"].Value = customerServerList.HDD3Type;
                        row.Cells["HDD4"].Value = customerServerList.HDD4;
                        row.Cells["HDD4Type"].Value = customerServerList.HDD4Type;
                        row.Cells["HDD5"].Value = customerServerList.HDD5;
                        row.Cells["HDD5Type"].Value = customerServerList.HDD5Type;
                        row.Cells["vHostCluster"].Value = customerServerList.vHostCluster;
                        row.Cells["VLAN"].Value = customerServerList.VLAN;
                        row.Cells["Bandwidth"].Value = customerServerList.Bandwidth;
                        row.Cells["LBPool"].Value = customerServerList.LBPool;
                        row.Cells["Datacentre"].Value = customerServerList.Datacentre;
                        row.Cells["Database"].Value = customerServerList.Database;
                        row.Cells["DatabaseCluster"].Value = customerServerList.DatabaseCluster;
                        row.Cells["Notes"].Value = customerServerList.Notes;
                        row.Cells["Include"].Value = customerServerList.Include;

                        intCustomerServerItem++;
                    }

                    dataGridViewServers.Rows.RemoveAt(dataGridViewServers.RowCount - 2);
                    updateRequiredMHzColumn();

                    MessageBox.Show("Customer configuration file loaded.", "Load complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception excep)
                {
                    MessageBox.Show("Customer confiugration file could not be loaded. Defaults will be loaded \n\n" + excep.Message, "Load incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridViewServers.Rows.Clear();
                    LoadConfigSettings();
                }
            }
        }

        private void saveCustomerSettings()
        {
            string strFilename = "";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JSON File (*.json)|*.json";
            saveFileDialog1.FileName = textBoxCustomerName.Text.ToString() + " " + textBoxDesignIteration.Text.ToString() + textBoxDesignOption.Text.ToString();

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strFilename = saveFileDialog1.FileName.ToString();

                CustomerSettings JSONData = new CustomerSettings();
                
                //Details Tab
                JSONData.CustomerName = textBoxCustomerName.Text.ToString();
                JSONData.ProjectName = textBoxProjectName.Text.ToString();
                JSONData.DesignIteration = textBoxDesignIteration.Text.ToString();
                JSONData.DesignOption = textBoxDesignOption.Text.ToString();

                //Input Tab
                JSONData.PrimarySupportSegment = comboBoxPrimarySupportSegment.SelectedItem.ToString();
                JSONData.DefaultBackupRetention = comboBoxDefaultBackupRetention.SelectedItem.ToString();
                JSONData.VMSnapshotOverhead = maskedTextBoxVMSnapshotOverhead.Text.ToString().Replace(" %", "");
                JSONData.DefaultMaximumUtilisation = maskedTextBoxDefaultMaximumUtilisation.Text.ToString().Replace(" %", "");
                JSONData.SourceMHzPerCore = maskedTextBoxSourceMHzPerCore.Text.ToString().Replace(" MHz", "");
                JSONData.RackConnect = comboBoxRackConnect.SelectedItem.ToString();
                JSONData.DDoSPrevention = Convert.ToBoolean(comboBoxDDoSPrevention.SelectedItem.ToString());
                JSONData.Tier1Firewall = comboBoxTier1Firewall.SelectedItem.ToString();
                JSONData.Tier1FirewallHA = Convert.ToBoolean(checkBoxTier1FirewallHighAvailability.Checked.ToString());
                JSONData.Tier2Firewall = comboBoxTier2Firewall.SelectedItem.ToString();
                JSONData.Tier2FirewallHA = Convert.ToBoolean(checkBoxTier2FirewallHighAvailability.Checked.ToString());
                JSONData.LoadBalancer = comboBoxLoadBalancer.SelectedItem.ToString();
                JSONData.LoadBalancerHA = Convert.ToBoolean(checkBoxLoadBalancerHighAvailability.Checked.ToString());
                JSONData.IDSThreatManager = comboBoxIDSThreatManager.SelectedItem.ToString();
                JSONData.LogManager = Convert.ToBoolean(comboBoxLogManager.SelectedItem.ToString());
                JSONData.WebApplicationFirewall = comboBoxWebApplicationFirewall.SelectedItem.ToString();
                JSONData.WebApplicationFirewallHA = Convert.ToBoolean(checkBoxLoadBalancerHighAvailability.Checked.ToString());
                JSONData.GlobalTrafficManager = comboBoxGlobalTrafficManager.SelectedItem.ToString();

                //Servers Tab

                CustomerServerTab customerServerItem = new CustomerServerTab();

                List<CustomerServerTab> customerServerTab = new List<CustomerServerTab>();

                foreach (DataGridViewRow r in dataGridViewServers.Rows)
                {
                    customerServerItem = new CustomerServerTab();

                    object[] objCustomerServerTab = new object[27];

                    int[] intColumn = new int[26];
                    for (int i = 0; i < r.DataGridView.ColumnCount; i++)
                    {
                        if (i < 4)
                        {
                            intColumn[i] = i;
                        }
                        else if (i == 4)
                        {
                            //do nothing
                        }
                        else if (i > 4)
                        {
                            intColumn[i - 1] = i;
                        }
                    }

                    for (int i = 0; i < 26; i++)
                    {
                        if (r.Cells[intColumn[i]].Value == null)
                        {
                            if (intColumn[i] == r.DataGridView.Columns["Include"].Index)
                            {
                                objCustomerServerTab[i] = false;
                            }
                            else
                            {
                                objCustomerServerTab[i] = "";
                            }
                        }
                        else
                        {
                            objCustomerServerTab[i] = r.Cells[intColumn[i]].Value.ToString();
                        }
                    }

                    customerServerItem.ServerName = objCustomerServerTab[0].ToString();
                    customerServerItem.Qty = objCustomerServerTab[1].ToString();
                    customerServerItem.ServerType = objCustomerServerTab[16].ToString();
                    customerServerItem.OperatingSystem = objCustomerServerTab[17].ToString();
                    customerServerItem.LogicalProcessors = objCustomerServerTab[2].ToString();
                    customerServerItem.Utilisation = objCustomerServerTab[3].ToString();
                    customerServerItem.RAM = objCustomerServerTab[4].ToString();
                    customerServerItem.HDD1 = objCustomerServerTab[5].ToString();
                    customerServerItem.HDD1Type = objCustomerServerTab[18].ToString();
                    customerServerItem.HDD2 = objCustomerServerTab[6].ToString();
                    customerServerItem.HDD2Type = objCustomerServerTab[19].ToString();
                    customerServerItem.HDD3 = objCustomerServerTab[7].ToString();
                    customerServerItem.HDD3Type = objCustomerServerTab[20].ToString();
                    customerServerItem.HDD4 = objCustomerServerTab[8].ToString();
                    customerServerItem.HDD4Type = objCustomerServerTab[21].ToString();
                    customerServerItem.HDD5 = objCustomerServerTab[9].ToString();
                    customerServerItem.HDD5Type = objCustomerServerTab[22].ToString();
                    customerServerItem.vHostCluster = objCustomerServerTab[23].ToString();
                    customerServerItem.VLAN = objCustomerServerTab[10].ToString();
                    customerServerItem.Bandwidth = objCustomerServerTab[11].ToString();
                    customerServerItem.LBPool = objCustomerServerTab[12].ToString();
                    customerServerItem.Datacentre = objCustomerServerTab[24].ToString();
                    customerServerItem.Database = objCustomerServerTab[25].ToString();
                    customerServerItem.DatabaseCluster = objCustomerServerTab[13].ToString();
                    customerServerItem.Notes = objCustomerServerTab[14].ToString();
                    customerServerItem.Include = Convert.ToBoolean(objCustomerServerTab[15].ToString());

                    customerServerTab.Add(customerServerItem);
                }

                JSONData.CustomerServerTab = customerServerTab;

                string outputJSON = JsonConvert.SerializeObject(JSONData);
                File.WriteAllText(strFilename, outputJSON);
            }
        }

        private void backgroundWorkerLoadConfigSettings_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Load Complete");
        }

        private void dataGridViewServers_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Utilisation"].Value = maskedTextBoxDefaultMaximumUtilisation.Text.ToString().Replace(" %","");
            e.Row.Cells["RequiredMHz"].Value = maskedTextBoxSourceMHzPerCore.Text.ToString().Replace(" MHz", "");
            e.Row.Cells["Include"].Value = true;

            foreach (DataGridViewRow r in dataGridViewServers.Rows)
            {
                dataGridViewServers.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
            }
        }

        private void dataGridViewServers_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewColumn col = dataGridViewServers.Columns[e.ColumnIndex] as DataGridViewColumn;
            DataGridViewRow row = dataGridViewServers.Rows[e.RowIndex] as DataGridViewRow;

            //Validate Data Input
            string[] ColumnNameArray = new string[11];
            ColumnNameArray[0] = "Qty";
            ColumnNameArray[1] = "LogicalProcessors";
            ColumnNameArray[2] = "Utilisation";
            ColumnNameArray[3] = "RequiredMHz";
            ColumnNameArray[4] = "RAM";
            ColumnNameArray[5] = "HDD1";
            ColumnNameArray[6] = "HDD2";
            ColumnNameArray[7] = "HDD3";
            ColumnNameArray[8] = "HDD4";
            ColumnNameArray[9] = "HDD5";
            ColumnNameArray[10] = "Bandwidth";

            for (int i = 0; i < ColumnNameArray.Length; i++)
            {
                if (col.Name == ColumnNameArray[i])
                {
                    DataGridViewCell cell = dataGridViewServers[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;
                    if (cell != null)
                    {
                        char[] chars = e.FormattedValue.ToString().ToCharArray();
                        foreach (char c in chars)
                        {
                            if (char.IsDigit(c) == false)
                            {
                                MessageBox.Show("You have entered an invalid character in\n\n" +
                                    "Column: " + col.HeaderText.ToString() + "\n" +
                                    "Row: " + row.HeaderCell.Value.ToString(),
                                    "Server Input Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                                e.Cancel = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void dataGridViewServers_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string[] ColumnNameArray = new string[2];
            ColumnNameArray[0] = "LogicalProcessors";
            ColumnNameArray[1] = "Utilisation";

            for (int i = 0; i < ColumnNameArray.Length; i++)
            {
                DataGridViewRow row = dataGridViewServers.Rows[e.RowIndex];
                if (e.RowIndex > -1 &&
                    e.ColumnIndex == dataGridViewServers.Columns[ColumnNameArray[i]].Index &&
                    row.Cells[LogicalProcessors.Index].Value != null &&
                    row.Cells[Utilisation.Index].Value != null)
                {
                    decimal decimalLogicalProcessors = Convert.ToDecimal(row.Cells[LogicalProcessors.Index].Value.ToString());
                    decimal decimalUtilisation = Convert.ToDecimal(row.Cells[Utilisation.Index].Value.ToString());
                    decimal decimalSourceMHzPerCore = Convert.ToDecimal(maskedTextBoxSourceMHzPerCore.Text.ToString().Replace(" MHz", ""));

                    row.Cells[RequiredMHz.Index].Value = Math.Truncate(decimalLogicalProcessors * decimalSourceMHzPerCore * (decimalUtilisation / 100)).ToString();
                }
            }
        }

        private void updateRequiredMHzColumn()
        {
            string[] ColumnNameArray = new string[2];
            ColumnNameArray[0] = "LogicalProcessors";
            ColumnNameArray[1] = "Utilisation";

            for (int i = 0; i < ColumnNameArray.Length; i++)
            {
                foreach (DataGridViewRow row in dataGridViewServers.Rows)
                {
                    if (row.Index > -1 &&
                        row.Cells[LogicalProcessors.Index].Value != null &&
                        row.Cells[Utilisation.Index].Value != null)
                    {
                        decimal decimalLogicalProcessors = Convert.ToDecimal(row.Cells[LogicalProcessors.Index].Value.ToString());
                        decimal decimalUtilisation = Convert.ToDecimal(row.Cells[Utilisation.Index].Value.ToString());
                        decimal decimalSourceMHzPerCore = Convert.ToDecimal(maskedTextBoxSourceMHzPerCore.Text.ToString().Replace(" MHz", ""));

                        row.Cells[RequiredMHz.Index].Value = Math.Truncate(decimalLogicalProcessors * decimalSourceMHzPerCore * (decimalUtilisation / 100)).ToString();
                    }
                }
            }
        }

        private void buttonShowHideHDDs_Click(object sender, EventArgs e)
        {
            string[] strColumnNameArrayHDD = new string[5];
            string[] strColumnNameArrayHDDType = new string[5];

            bool boolColour = true;

            if (buttonShowHideHDDs.BackColor == Color.Lime)
            {
                boolColour = false;
                buttonShowHideHDDs.BackColor = Color.Red;
            }
            else if (buttonShowHideHDDs.BackColor == Color.Red)
            {
                boolColour = true;
                buttonShowHideHDDs.BackColor = Color.Lime;
            }

            for (int i = 1; i < 6; i++)
                {
                    strColumnNameArrayHDD[i - 1] = "HDD" + i.ToString();
                    strColumnNameArrayHDDType[i - 1] = "HDD" + i.ToString() + "Type";
                }

            for (int i = 1; i < 6; i++)
            {
                dataGridViewServers.Columns[strColumnNameArrayHDD[i - 1]].Visible = boolColour;
                dataGridViewServers.Columns[strColumnNameArrayHDDType[i - 1]].Visible = boolColour;
            }
        }

        private void buttonShowHideDatabases_Click(object sender, EventArgs e)
        {
            bool boolColour = true;

            if (buttonShowHideDatabases.BackColor == Color.Lime)
            {
                boolColour = false;
                buttonShowHideDatabases.BackColor = Color.Red;
            }
            else if (buttonShowHideDatabases.BackColor == Color.Red)
            {
                boolColour = true;
                buttonShowHideDatabases.BackColor = Color.Lime;
            }
            
            dataGridViewServers.Columns["Database"].Visible = boolColour;
            dataGridViewServers.Columns["DatabaseCluster"].Visible = boolColour;
        }

        private void dataGridViewServers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Include.Index && e.RowIndex != -1)
            {

            }

            //if (e.ColumnIndex == HDD1.Index && dataGridViewServers[e.RowIndex, HDD1Type.Index].Value == null &&  e.RowIndex != -1)
            //{
            //    //dataGridViewServers[e.RowIndex, HDD1Type.Index].Style.BackColor = Color.Red;
            //    MessageBox.Show("Drive type empty");
            //}
            //else if (e.ColumnIndex == HDD2.Index)
            //{

            //}
            //else if (e.ColumnIndex == HDD3.Index)
            //{

            //}
            //else if (e.ColumnIndex == HDD4.Index)
            //{

            //}
            //else if (e.ColumnIndex == HDD5.Index)
            //{

            //}
        }

        private void dataGridViewServers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Include.Index && e.RowIndex != -1)
            {
                if (Convert.ToBoolean(dataGridViewServers.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue) == true)
                {
                    dataGridViewServers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
                    dataGridViewServers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Empty;
                    dataGridViewServers.Rows[e.RowIndex].DefaultCellStyle.Font = new System.Drawing.Font(dataGridViewServers.Font, FontStyle.Regular);
                }
                else if (Convert.ToBoolean(dataGridViewServers.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue) == false)
                {
                    dataGridViewServers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DimGray;
                    dataGridViewServers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    dataGridViewServers.Rows[e.RowIndex].DefaultCellStyle.Font = new System.Drawing.Font(dataGridViewServers.Font, FontStyle.Italic);
                }
            }
        }

        private void dataGridViewServers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Include.Index && e.RowIndex != -1)
            {
                dataGridViewServers.EndEdit();
            }            
        }

        private void dataGridViewServers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //dataGridViewServers.EndEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void buttonImportXLSX_Click(object sender, EventArgs e)
        {

        }
    }
}
