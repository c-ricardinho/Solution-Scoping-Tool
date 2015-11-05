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
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace Solution_Scoping_Tool
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();

            //Set Solution Engineer TextBox to current display name
            textBoxSolutionEngineerName.Text = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName.ToString();

            //Load Solution Scoping Tool Configuration Settings
            LoadConfigSettings();
            
        }

        private void LoadConfigSettings()
        {
            string oldString = "\\bin\\debug";
            string newString = "";
            string strFilename = Application.StartupPath.ToString().ToLower().Replace(oldString, newString) + "\\Settings\\ConfigSettings.json";
            
            var inputJSON = File.ReadAllText(strFilename);
            var JSONData = JsonConvert.DeserializeObject<RootObject>(inputJSON);

            textBoxCustomerName.Text = "";
            textBoxProjectName.Text = "";
            textBoxDesignIteration.Text = "1";
            textBoxDesignOption.Text = "a";

            //Primary Support Segment
            foreach (var PrimarySupportSegment in JSONData.PrimarySupportSegment)
            {
                comboBoxPrimarySupportSegment.Items.Add(PrimarySupportSegment.ToString());
            }
            comboBoxPrimarySupportSegment.SelectedIndex = 1;

            //Default Backup Retention
            foreach (var DefaultBackupRetention in JSONData.DefaultBackupRetention)
            {
                comboBoxDefaultBackupRetention.Items.Add(DefaultBackupRetention.ToString());
            }
            comboBoxDefaultBackupRetention.SelectedIndex = 1;

            //VM Snapshot Overhead
            maskedTextBoxVMSnapshotOverhead.Text = JSONData.VMSnapshotOverhead.ToString();

            //Default Maximum Utilisation
            maskedTextBoxDefaultMaximumUtilisation.Text = JSONData.DefaultMaximumUtilisation.ToString();

            //Source MHz Per Core
            maskedTextBoxSourceMHzPerCore.Text = JSONData.SourceMHzPerCore.ToString();

            //Rackconnect
            foreach (var RackConnect in JSONData.RackConnect)
            {
                comboBoxRackConnect.Items.Add(RackConnect.ToString());
            }
            comboBoxRackConnect.SelectedIndex = 0;

            //DDoS Prevention
            foreach (var DDoSPrevention in JSONData.DDoSPrevention)
            {
                comboBoxDDoSPrevention.Items.Add(DDoSPrevention.ToString());
            }
            comboBoxDDoSPrevention.SelectedIndex = 0;

            //Tier 1 Firewall
            foreach (var Tier1Firewall in JSONData.Tier1Firewall)
            {
                comboBoxTier1Firewall.Items.Add(Tier1Firewall.ToString());
            }
            comboBoxTier1Firewall.SelectedIndex = 2;
            checkBoxLoadBalancerHighAvailability.Checked = false;

            //Tier 2 Firewall
            foreach (var Tier2Firewall in JSONData.Tier2Firewall)
            {
                comboBoxTier2Firewall.Items.Add(Tier2Firewall.ToString());
            }
            comboBoxTier2Firewall.SelectedIndex = 0;
            checkBoxTier2FirewallHighAvailability.Checked = false;

            //Load Balancer
            foreach (var LoadBalancer in JSONData.LoadBalancer)
            {
                comboBoxLoadBalancer.Items.Add(LoadBalancer.ToString());
            }
            comboBoxLoadBalancer.SelectedIndex = 0;
            checkBoxLoadBalancerHighAvailability.Checked = false;

            //IDS ThreatManager
            foreach (var IDSThreatManager in JSONData.IDSThreatManager)
            {
                comboBoxIDSThreatManager.Items.Add(IDSThreatManager.ToString());
            }
            comboBoxIDSThreatManager.SelectedIndex = 0;

            //LogManager
            foreach (var LogManager in JSONData.LogManager)
            {
                comboBoxLogManager.Items.Add(LogManager.ToString());
            }
            comboBoxLogManager.SelectedIndex = 0;

            //Web Application Firewall
            foreach (var WebApplicationFirewall in JSONData.WebApplicationFirewall)
            {
                comboBoxWebApplicationFirewall.Items.Add(WebApplicationFirewall.ToString());
            }
            comboBoxWebApplicationFirewall.SelectedIndex = 0;
            checkBoxWebApplicationFirewallHighAvailability.Checked = false;

            //Global Traffic Manager
            foreach (var GlobalTrafficManager in JSONData.GlobalTrafficManager)
            {
                comboBoxGlobalTrafficManager.Items.Add(GlobalTrafficManager.ToString());
            }
            comboBoxGlobalTrafficManager.SelectedIndex = 0;
        }

        private void FormMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            saveCustomerSettings();
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            saveCustomerSettings();
        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            //string strFileName = "";
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "XML (*.xml)|*.xml";
            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    strFileName = openFileDialog1.FileName.ToString();

            //    CustomerSettings details = new CustomerSettings();

            //    XmlSerializer deserializer = new XmlSerializer(typeof(CustomerSettings));
            //    TextReader reader = new StreamReader(strFileName);
            //    object obj = deserializer.Deserialize(reader);
            //    CustomerSettings XMLData = (CustomerSettings)obj;
            //    reader.Close();

            //    textBoxCustomerName.Text = XMLData.CustomerName;
            //    textBoxProjectName.Text = XMLData.ProjectName;
            //    textBoxDesignIteration.Text = XMLData.DesignIteration;
            //    textBoxDesignOption.Text = XMLData.DesignOption;
                
            //}

            string strFileName = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JSON (*.json)|*.json";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strFileName = openFileDialog1.FileName.ToString();

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
                    //checkBoxTier1FirewallHighAvailability.CheckState = (CheckState)Enum.Parse(typeof(CheckState), JSONData.Tier1FirewallHA);
                    comboBoxTier2Firewall.SelectedItem = JSONData.Tier2Firewall;
                    checkBoxTier2FirewallHighAvailability.CheckState = (CheckState)Enum.Parse(typeof(CheckState), JSONData.Tier2FirewallHA);
                    comboBoxLoadBalancer.SelectedItem = JSONData.LoadBalancer;
                    checkBoxLoadBalancerHighAvailability.CheckState = (CheckState)Enum.Parse(typeof(CheckState), JSONData.LoadBalancerHA);
                    comboBoxIDSThreatManager.SelectedItem = JSONData.IDSThreatManager;
                    comboBoxLogManager.SelectedItem = JSONData.LogManager;
                    comboBoxWebApplicationFirewall.SelectedItem = JSONData.WebApplicationFirewall;
                    checkBoxWebApplicationFirewallHighAvailability.CheckState = (CheckState)Enum.Parse(typeof(CheckState), JSONData.WebApplicationFirewallHA);
                    comboBoxGlobalTrafficManager.SelectedItem = JSONData.GlobalTrafficManager;

                    MessageBox.Show("Customer configuration file loaded.", "Load complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Customer confiugration file could not be loaded. Defaults will be loaded", "Load incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadConfigSettings();
                }
                
            }
        }

        private void saveCustomerSettings()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save the current configuration?", "Save configuration?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //string strFilename = "";
                //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //saveFileDialog1.Filter = "XML File (*.xml)|*.xml";
                //saveFileDialog1.FileName = textBoxCustomerName.Text.ToString() + " " + textBoxDesignIteration.Text.ToString() + textBoxDesignOption.Text.ToString();

                //if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    strFilename = saveFileDialog1.FileName.ToString();

                //    CustomerSettings XMLData = new CustomerSettings();
                //    XMLData.CustomerName = textBoxCustomerName.Text.ToString();
                //    XMLData.ProjectName = textBoxProjectName.Text.ToString();
                //    XMLData.DesignIteration = textBoxDesignIteration.Text.ToString();
                //    XMLData.DesignOption = textBoxDesignOption.Text.ToString();

                //    XmlSerializer serializer = new XmlSerializer(typeof(CustomerSettings));
                //    TextWriter writer = new StreamWriter(strFilename);
                //    serializer.Serialize(writer, XMLData);
                //    writer.Close();
                //}

                string strFilename = "";
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JSON File (*.json)|*.json";
                saveFileDialog1.FileName = textBoxCustomerName.Text.ToString() + " " + textBoxDesignIteration.Text.ToString() + textBoxDesignOption.Text.ToString();

                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    strFilename = saveFileDialog1.FileName.ToString();

                    CustomerSettings JSONData = new CustomerSettings
                    {
                        //Details Tab
                        CustomerName = textBoxCustomerName.Text.ToString(),
                        ProjectName = textBoxProjectName.Text.ToString(),
                        DesignIteration = textBoxDesignIteration.Text.ToString(),
                        DesignOption = textBoxDesignOption.Text.ToString(),

                        //Input Tab
                        PrimarySupportSegment = comboBoxPrimarySupportSegment.SelectedItem.ToString(),
                        DefaultBackupRetention = comboBoxDefaultBackupRetention.SelectedItem.ToString(),
                        VMSnapshotOverhead = maskedTextBoxVMSnapshotOverhead.Text.ToString().Replace("%",""),
                        DefaultMaximumUtilisation = maskedTextBoxDefaultMaximumUtilisation.Text.ToString().Replace("%",""),
                        SourceMHzPerCore = maskedTextBoxSourceMHzPerCore.Text.ToString().Replace(" MHz",""),
                        RackConnect = comboBoxRackConnect.SelectedItem.ToString(),
                        DDoSPrevention = comboBoxDDoSPrevention.SelectedItem.ToString(),
                        Tier1Firewall = comboBoxTier1Firewall.SelectedItem.ToString(),
                        Tier1FirewallHA = checkBoxTier1FirewallHighAvailability.CheckState.ToString(),
                        Tier2Firewall = comboBoxTier2Firewall.SelectedItem.ToString(),
                        Tier2FirewallHA = checkBoxTier2FirewallHighAvailability.CheckState.ToString(),
                        LoadBalancer = comboBoxLoadBalancer.SelectedItem.ToString(),
                        LoadBalancerHA = checkBoxLoadBalancerHighAvailability.CheckState.ToString(),
                        IDSThreatManager = comboBoxIDSThreatManager.SelectedItem.ToString(),
                        LogManager = comboBoxLogManager.SelectedItem.ToString(),
                        WebApplicationFirewall = comboBoxWebApplicationFirewall.SelectedItem.ToString(),
                        WebApplicationFirewallHA = checkBoxLoadBalancerHighAvailability.CheckState.ToString(),
                        GlobalTrafficManager = comboBoxGlobalTrafficManager.SelectedItem.ToString()
                    };

                    MessageBox.Show(checkBoxTier1FirewallHighAvailability.CheckState.ToString());

                    string outputJSON = JsonConvert.SerializeObject(JSONData);
                    File.WriteAllText(strFilename, outputJSON);
                }
            }
        }
    }
}
