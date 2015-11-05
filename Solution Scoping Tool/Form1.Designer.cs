namespace Solution_Scoping_Tool
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.groupBoxSolutionScopingToolDetails = new System.Windows.Forms.GroupBox();
            this.textBoxDesignOption = new System.Windows.Forms.TextBox();
            this.labelDesignOption = new System.Windows.Forms.Label();
            this.textBoxDesignIteration = new System.Windows.Forms.TextBox();
            this.labelDesignIteration = new System.Windows.Forms.Label();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelSolutionEngineerName = new System.Windows.Forms.Label();
            this.textBoxSolutionEngineerName = new System.Windows.Forms.TextBox();
            this.labelScopingToolVersion = new System.Windows.Forms.Label();
            this.textBoxScopingToolVersion = new System.Windows.Forms.TextBox();
            this.tabPageNotes = new System.Windows.Forms.TabPage();
            this.tabPageInput = new System.Windows.Forms.TabPage();
            this.groupBoxBasicNetwork = new System.Windows.Forms.GroupBox();
            this.checkBoxWebApplicationFirewallHighAvailability = new System.Windows.Forms.CheckBox();
            this.checkBoxLoadBalancerHighAvailability = new System.Windows.Forms.CheckBox();
            this.checkBoxTier2FirewallHighAvailability = new System.Windows.Forms.CheckBox();
            this.checkBoxTier1FirewallHighAvailability = new System.Windows.Forms.CheckBox();
            this.comboBoxGlobalTrafficManager = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxWebApplicationFirewall = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLogManager = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxIDSThreatManager = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLoadBalancer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTier2Firewall = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTier1Firewall = new System.Windows.Forms.ComboBox();
            this.labelTier1Firewall = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxSourceMHzPerCore = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDefaultMaximumUtilisation = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxVMSnapshotOverhead = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDDoSPrevention = new System.Windows.Forms.ComboBox();
            this.labelDDoSPrevention = new System.Windows.Forms.Label();
            this.comboBoxRackConnect = new System.Windows.Forms.ComboBox();
            this.labelRackConnect = new System.Windows.Forms.Label();
            this.labelSourceMHzPerCore = new System.Windows.Forms.Label();
            this.labelDefaultMaximumUtilisation = new System.Windows.Forms.Label();
            this.labelVMSnapshotOverhead = new System.Windows.Forms.Label();
            this.comboBoxDefaultBackupRetention = new System.Windows.Forms.ComboBox();
            this.labelDefaultBackupRetention = new System.Windows.Forms.Label();
            this.comboBoxPrimarySupportSegment = new System.Windows.Forms.ComboBox();
            this.labelPrimarySupportSegment = new System.Windows.Forms.Label();
            this.tabPageServers = new System.Windows.Forms.TabPage();
            this.dataGridViewServers = new System.Windows.Forms.DataGridView();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OperatingSystem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LogicalProcessors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredMHz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HDD1Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HDD2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HDD2Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HDD3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HDD3Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HDD4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HDD4Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HDD5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HDD5Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vHostCluster = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VLAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bandwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBPool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datacentre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Database = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DatabaseCluster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Include = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.groupBoxConfiguration = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorkerLoadConfigSettings = new System.ComponentModel.BackgroundWorker();
            this.tabControlMain.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            this.groupBoxSolutionScopingToolDetails.SuspendLayout();
            this.tabPageInput.SuspendLayout();
            this.groupBoxBasicNetwork.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageServers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).BeginInit();
            this.tabPageConfig.SuspendLayout();
            this.groupBoxConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageDetails);
            this.tabControlMain.Controls.Add(this.tabPageNotes);
            this.tabControlMain.Controls.Add(this.tabPageInput);
            this.tabControlMain.Controls.Add(this.tabPageServers);
            this.tabControlMain.Controls.Add(this.tabPageConfig);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(984, 705);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.groupBoxSolutionScopingToolDetails);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(976, 679);
            this.tabPageDetails.TabIndex = 0;
            this.tabPageDetails.Text = "Details";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // groupBoxSolutionScopingToolDetails
            // 
            this.groupBoxSolutionScopingToolDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.textBoxDesignOption);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.labelDesignOption);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.textBoxDesignIteration);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.labelDesignIteration);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.buttonSaveConfig);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.buttonLoadConfig);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.textBoxProjectName);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.labelProjectName);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.textBoxCustomerName);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.labelCustomerName);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.labelSolutionEngineerName);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.textBoxSolutionEngineerName);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.labelScopingToolVersion);
            this.groupBoxSolutionScopingToolDetails.Controls.Add(this.textBoxScopingToolVersion);
            this.groupBoxSolutionScopingToolDetails.Location = new System.Drawing.Point(6, 6);
            this.groupBoxSolutionScopingToolDetails.Name = "groupBoxSolutionScopingToolDetails";
            this.groupBoxSolutionScopingToolDetails.Size = new System.Drawing.Size(964, 667);
            this.groupBoxSolutionScopingToolDetails.TabIndex = 2;
            this.groupBoxSolutionScopingToolDetails.TabStop = false;
            this.groupBoxSolutionScopingToolDetails.Text = "Solution Scoping Tool Details";
            // 
            // textBoxDesignOption
            // 
            this.textBoxDesignOption.Location = new System.Drawing.Point(239, 149);
            this.textBoxDesignOption.Name = "textBoxDesignOption";
            this.textBoxDesignOption.Size = new System.Drawing.Size(250, 20);
            this.textBoxDesignOption.TabIndex = 6;
            this.textBoxDesignOption.Text = "a";
            this.textBoxDesignOption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDesignOption
            // 
            this.labelDesignOption.AutoSize = true;
            this.labelDesignOption.Location = new System.Drawing.Point(6, 152);
            this.labelDesignOption.Name = "labelDesignOption";
            this.labelDesignOption.Size = new System.Drawing.Size(77, 13);
            this.labelDesignOption.TabIndex = 14;
            this.labelDesignOption.Text = "Design Option:";
            // 
            // textBoxDesignIteration
            // 
            this.textBoxDesignIteration.Location = new System.Drawing.Point(239, 123);
            this.textBoxDesignIteration.Name = "textBoxDesignIteration";
            this.textBoxDesignIteration.Size = new System.Drawing.Size(250, 20);
            this.textBoxDesignIteration.TabIndex = 5;
            this.textBoxDesignIteration.Text = "1";
            this.textBoxDesignIteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDesignIteration
            // 
            this.labelDesignIteration.AutoSize = true;
            this.labelDesignIteration.Location = new System.Drawing.Point(6, 126);
            this.labelDesignIteration.Name = "labelDesignIteration";
            this.labelDesignIteration.Size = new System.Drawing.Size(84, 13);
            this.labelDesignIteration.TabIndex = 12;
            this.labelDesignIteration.Text = "Design Iteration:";
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Location = new System.Drawing.Point(334, 175);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveConfig.TabIndex = 7;
            this.buttonSaveConfig.Text = "Save Config";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // buttonLoadConfig
            // 
            this.buttonLoadConfig.Location = new System.Drawing.Point(415, 175);
            this.buttonLoadConfig.Name = "buttonLoadConfig";
            this.buttonLoadConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadConfig.TabIndex = 8;
            this.buttonLoadConfig.Text = "Load Config";
            this.buttonLoadConfig.UseVisualStyleBackColor = true;
            this.buttonLoadConfig.Click += new System.EventHandler(this.buttonLoadConfig_Click);
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(239, 97);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProjectName.TabIndex = 4;
            this.textBoxProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Location = new System.Drawing.Point(6, 100);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(74, 13);
            this.labelProjectName.TabIndex = 6;
            this.labelProjectName.Text = "Project Name:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(239, 71);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(250, 20);
            this.textBoxCustomerName.TabIndex = 3;
            this.textBoxCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(6, 74);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(85, 13);
            this.labelCustomerName.TabIndex = 4;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // labelSolutionEngineerName
            // 
            this.labelSolutionEngineerName.AutoSize = true;
            this.labelSolutionEngineerName.Location = new System.Drawing.Point(6, 48);
            this.labelSolutionEngineerName.Name = "labelSolutionEngineerName";
            this.labelSolutionEngineerName.Size = new System.Drawing.Size(124, 13);
            this.labelSolutionEngineerName.TabIndex = 3;
            this.labelSolutionEngineerName.Text = "Solution Engineer Name:";
            // 
            // textBoxSolutionEngineerName
            // 
            this.textBoxSolutionEngineerName.Location = new System.Drawing.Point(239, 45);
            this.textBoxSolutionEngineerName.Name = "textBoxSolutionEngineerName";
            this.textBoxSolutionEngineerName.Size = new System.Drawing.Size(250, 20);
            this.textBoxSolutionEngineerName.TabIndex = 2;
            this.textBoxSolutionEngineerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelScopingToolVersion
            // 
            this.labelScopingToolVersion.AutoSize = true;
            this.labelScopingToolVersion.Location = new System.Drawing.Point(6, 22);
            this.labelScopingToolVersion.Name = "labelScopingToolVersion";
            this.labelScopingToolVersion.Size = new System.Drawing.Size(111, 13);
            this.labelScopingToolVersion.TabIndex = 0;
            this.labelScopingToolVersion.Text = "Scoping Tool Version:";
            // 
            // textBoxScopingToolVersion
            // 
            this.textBoxScopingToolVersion.Enabled = false;
            this.textBoxScopingToolVersion.Location = new System.Drawing.Point(239, 19);
            this.textBoxScopingToolVersion.Name = "textBoxScopingToolVersion";
            this.textBoxScopingToolVersion.Size = new System.Drawing.Size(250, 20);
            this.textBoxScopingToolVersion.TabIndex = 1;
            this.textBoxScopingToolVersion.Text = "0.001";
            this.textBoxScopingToolVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPageNotes
            // 
            this.tabPageNotes.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotes.Name = "tabPageNotes";
            this.tabPageNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotes.Size = new System.Drawing.Size(976, 679);
            this.tabPageNotes.TabIndex = 1;
            this.tabPageNotes.Text = "Notes";
            this.tabPageNotes.UseVisualStyleBackColor = true;
            // 
            // tabPageInput
            // 
            this.tabPageInput.Controls.Add(this.groupBoxBasicNetwork);
            this.tabPageInput.Controls.Add(this.groupBox1);
            this.tabPageInput.Location = new System.Drawing.Point(4, 22);
            this.tabPageInput.Name = "tabPageInput";
            this.tabPageInput.Size = new System.Drawing.Size(976, 679);
            this.tabPageInput.TabIndex = 2;
            this.tabPageInput.Text = "Input";
            this.tabPageInput.UseVisualStyleBackColor = true;
            // 
            // groupBoxBasicNetwork
            // 
            this.groupBoxBasicNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBasicNetwork.Controls.Add(this.checkBoxWebApplicationFirewallHighAvailability);
            this.groupBoxBasicNetwork.Controls.Add(this.checkBoxLoadBalancerHighAvailability);
            this.groupBoxBasicNetwork.Controls.Add(this.checkBoxTier2FirewallHighAvailability);
            this.groupBoxBasicNetwork.Controls.Add(this.checkBoxTier1FirewallHighAvailability);
            this.groupBoxBasicNetwork.Controls.Add(this.comboBoxGlobalTrafficManager);
            this.groupBoxBasicNetwork.Controls.Add(this.label6);
            this.groupBoxBasicNetwork.Controls.Add(this.comboBoxWebApplicationFirewall);
            this.groupBoxBasicNetwork.Controls.Add(this.label5);
            this.groupBoxBasicNetwork.Controls.Add(this.comboBoxLogManager);
            this.groupBoxBasicNetwork.Controls.Add(this.label4);
            this.groupBoxBasicNetwork.Controls.Add(this.comboBoxIDSThreatManager);
            this.groupBoxBasicNetwork.Controls.Add(this.label3);
            this.groupBoxBasicNetwork.Controls.Add(this.comboBoxLoadBalancer);
            this.groupBoxBasicNetwork.Controls.Add(this.label2);
            this.groupBoxBasicNetwork.Controls.Add(this.comboBoxTier2Firewall);
            this.groupBoxBasicNetwork.Controls.Add(this.label1);
            this.groupBoxBasicNetwork.Controls.Add(this.comboBoxTier1Firewall);
            this.groupBoxBasicNetwork.Controls.Add(this.labelTier1Firewall);
            this.groupBoxBasicNetwork.Location = new System.Drawing.Point(411, 3);
            this.groupBoxBasicNetwork.Name = "groupBoxBasicNetwork";
            this.groupBoxBasicNetwork.Size = new System.Drawing.Size(562, 212);
            this.groupBoxBasicNetwork.TabIndex = 1;
            this.groupBoxBasicNetwork.TabStop = false;
            this.groupBoxBasicNetwork.Text = "Besic Network";
            // 
            // checkBoxWebApplicationFirewallHighAvailability
            // 
            this.checkBoxWebApplicationFirewallHighAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxWebApplicationFirewallHighAvailability.AutoSize = true;
            this.checkBoxWebApplicationFirewallHighAvailability.Location = new System.Drawing.Point(396, 156);
            this.checkBoxWebApplicationFirewallHighAvailability.Name = "checkBoxWebApplicationFirewallHighAvailability";
            this.checkBoxWebApplicationFirewallHighAvailability.Size = new System.Drawing.Size(100, 17);
            this.checkBoxWebApplicationFirewallHighAvailability.TabIndex = 19;
            this.checkBoxWebApplicationFirewallHighAvailability.Text = "High Availability";
            this.checkBoxWebApplicationFirewallHighAvailability.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoadBalancerHighAvailability
            // 
            this.checkBoxLoadBalancerHighAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLoadBalancerHighAvailability.AutoSize = true;
            this.checkBoxLoadBalancerHighAvailability.Location = new System.Drawing.Point(396, 75);
            this.checkBoxLoadBalancerHighAvailability.Name = "checkBoxLoadBalancerHighAvailability";
            this.checkBoxLoadBalancerHighAvailability.Size = new System.Drawing.Size(100, 17);
            this.checkBoxLoadBalancerHighAvailability.TabIndex = 18;
            this.checkBoxLoadBalancerHighAvailability.Text = "High Availability";
            this.checkBoxLoadBalancerHighAvailability.UseVisualStyleBackColor = true;
            // 
            // checkBoxTier2FirewallHighAvailability
            // 
            this.checkBoxTier2FirewallHighAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTier2FirewallHighAvailability.AutoSize = true;
            this.checkBoxTier2FirewallHighAvailability.Location = new System.Drawing.Point(396, 48);
            this.checkBoxTier2FirewallHighAvailability.Name = "checkBoxTier2FirewallHighAvailability";
            this.checkBoxTier2FirewallHighAvailability.Size = new System.Drawing.Size(100, 17);
            this.checkBoxTier2FirewallHighAvailability.TabIndex = 17;
            this.checkBoxTier2FirewallHighAvailability.Text = "High Availability";
            this.checkBoxTier2FirewallHighAvailability.UseVisualStyleBackColor = true;
            // 
            // checkBoxTier1FirewallHighAvailability
            // 
            this.checkBoxTier1FirewallHighAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTier1FirewallHighAvailability.AutoSize = true;
            this.checkBoxTier1FirewallHighAvailability.Location = new System.Drawing.Point(396, 22);
            this.checkBoxTier1FirewallHighAvailability.Name = "checkBoxTier1FirewallHighAvailability";
            this.checkBoxTier1FirewallHighAvailability.Size = new System.Drawing.Size(100, 17);
            this.checkBoxTier1FirewallHighAvailability.TabIndex = 16;
            this.checkBoxTier1FirewallHighAvailability.Text = "High Availability";
            this.checkBoxTier1FirewallHighAvailability.UseVisualStyleBackColor = true;
            // 
            // comboBoxGlobalTrafficManager
            // 
            this.comboBoxGlobalTrafficManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGlobalTrafficManager.FormattingEnabled = true;
            this.comboBoxGlobalTrafficManager.Location = new System.Drawing.Point(139, 181);
            this.comboBoxGlobalTrafficManager.Name = "comboBoxGlobalTrafficManager";
            this.comboBoxGlobalTrafficManager.Size = new System.Drawing.Size(251, 21);
            this.comboBoxGlobalTrafficManager.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Global Traffic Manager:";
            // 
            // comboBoxWebApplicationFirewall
            // 
            this.comboBoxWebApplicationFirewall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWebApplicationFirewall.FormattingEnabled = true;
            this.comboBoxWebApplicationFirewall.Location = new System.Drawing.Point(139, 154);
            this.comboBoxWebApplicationFirewall.Name = "comboBoxWebApplicationFirewall";
            this.comboBoxWebApplicationFirewall.Size = new System.Drawing.Size(251, 21);
            this.comboBoxWebApplicationFirewall.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Web Application Firewall:";
            // 
            // comboBoxLogManager
            // 
            this.comboBoxLogManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLogManager.FormattingEnabled = true;
            this.comboBoxLogManager.Location = new System.Drawing.Point(139, 127);
            this.comboBoxLogManager.Name = "comboBoxLogManager";
            this.comboBoxLogManager.Size = new System.Drawing.Size(251, 21);
            this.comboBoxLogManager.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Log Manager:";
            // 
            // comboBoxIDSThreatManager
            // 
            this.comboBoxIDSThreatManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxIDSThreatManager.FormattingEnabled = true;
            this.comboBoxIDSThreatManager.Location = new System.Drawing.Point(139, 100);
            this.comboBoxIDSThreatManager.Name = "comboBoxIDSThreatManager";
            this.comboBoxIDSThreatManager.Size = new System.Drawing.Size(251, 21);
            this.comboBoxIDSThreatManager.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IDS ThreatManager:";
            // 
            // comboBoxLoadBalancer
            // 
            this.comboBoxLoadBalancer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLoadBalancer.FormattingEnabled = true;
            this.comboBoxLoadBalancer.Location = new System.Drawing.Point(139, 73);
            this.comboBoxLoadBalancer.Name = "comboBoxLoadBalancer";
            this.comboBoxLoadBalancer.Size = new System.Drawing.Size(251, 21);
            this.comboBoxLoadBalancer.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Load Balancer:";
            // 
            // comboBoxTier2Firewall
            // 
            this.comboBoxTier2Firewall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTier2Firewall.FormattingEnabled = true;
            this.comboBoxTier2Firewall.Location = new System.Drawing.Point(139, 46);
            this.comboBoxTier2Firewall.Name = "comboBoxTier2Firewall";
            this.comboBoxTier2Firewall.Size = new System.Drawing.Size(251, 21);
            this.comboBoxTier2Firewall.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tier 2 Firewall:";
            // 
            // comboBoxTier1Firewall
            // 
            this.comboBoxTier1Firewall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTier1Firewall.FormattingEnabled = true;
            this.comboBoxTier1Firewall.Location = new System.Drawing.Point(139, 19);
            this.comboBoxTier1Firewall.Name = "comboBoxTier1Firewall";
            this.comboBoxTier1Firewall.Size = new System.Drawing.Size(251, 21);
            this.comboBoxTier1Firewall.TabIndex = 8;
            // 
            // labelTier1Firewall
            // 
            this.labelTier1Firewall.AutoSize = true;
            this.labelTier1Firewall.Location = new System.Drawing.Point(6, 22);
            this.labelTier1Firewall.Name = "labelTier1Firewall";
            this.labelTier1Firewall.Size = new System.Drawing.Size(75, 13);
            this.labelTier1Firewall.TabIndex = 2;
            this.labelTier1Firewall.Text = "Tier 1 Firewall:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxSourceMHzPerCore);
            this.groupBox1.Controls.Add(this.maskedTextBoxDefaultMaximumUtilisation);
            this.groupBox1.Controls.Add(this.maskedTextBoxVMSnapshotOverhead);
            this.groupBox1.Controls.Add(this.comboBoxDDoSPrevention);
            this.groupBox1.Controls.Add(this.labelDDoSPrevention);
            this.groupBox1.Controls.Add(this.comboBoxRackConnect);
            this.groupBox1.Controls.Add(this.labelRackConnect);
            this.groupBox1.Controls.Add(this.labelSourceMHzPerCore);
            this.groupBox1.Controls.Add(this.labelDefaultMaximumUtilisation);
            this.groupBox1.Controls.Add(this.labelVMSnapshotOverhead);
            this.groupBox1.Controls.Add(this.comboBoxDefaultBackupRetention);
            this.groupBox1.Controls.Add(this.labelDefaultBackupRetention);
            this.groupBox1.Controls.Add(this.comboBoxPrimarySupportSegment);
            this.groupBox1.Controls.Add(this.labelPrimarySupportSegment);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default Vaues";
            // 
            // maskedTextBoxSourceMHzPerCore
            // 
            this.maskedTextBoxSourceMHzPerCore.Location = new System.Drawing.Point(155, 127);
            this.maskedTextBoxSourceMHzPerCore.Mask = "0000 MHz";
            this.maskedTextBoxSourceMHzPerCore.Name = "maskedTextBoxSourceMHzPerCore";
            this.maskedTextBoxSourceMHzPerCore.Size = new System.Drawing.Size(238, 20);
            this.maskedTextBoxSourceMHzPerCore.TabIndex = 5;
            // 
            // maskedTextBoxDefaultMaximumUtilisation
            // 
            this.maskedTextBoxDefaultMaximumUtilisation.Location = new System.Drawing.Point(155, 100);
            this.maskedTextBoxDefaultMaximumUtilisation.Mask = "00%";
            this.maskedTextBoxDefaultMaximumUtilisation.Name = "maskedTextBoxDefaultMaximumUtilisation";
            this.maskedTextBoxDefaultMaximumUtilisation.Size = new System.Drawing.Size(238, 20);
            this.maskedTextBoxDefaultMaximumUtilisation.TabIndex = 4;
            // 
            // maskedTextBoxVMSnapshotOverhead
            // 
            this.maskedTextBoxVMSnapshotOverhead.Location = new System.Drawing.Point(155, 72);
            this.maskedTextBoxVMSnapshotOverhead.Mask = "00%";
            this.maskedTextBoxVMSnapshotOverhead.Name = "maskedTextBoxVMSnapshotOverhead";
            this.maskedTextBoxVMSnapshotOverhead.Size = new System.Drawing.Size(238, 20);
            this.maskedTextBoxVMSnapshotOverhead.TabIndex = 3;
            // 
            // comboBoxDDoSPrevention
            // 
            this.comboBoxDDoSPrevention.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDDoSPrevention.FormattingEnabled = true;
            this.comboBoxDDoSPrevention.Location = new System.Drawing.Point(155, 181);
            this.comboBoxDDoSPrevention.Name = "comboBoxDDoSPrevention";
            this.comboBoxDDoSPrevention.Size = new System.Drawing.Size(238, 21);
            this.comboBoxDDoSPrevention.TabIndex = 7;
            // 
            // labelDDoSPrevention
            // 
            this.labelDDoSPrevention.AutoSize = true;
            this.labelDDoSPrevention.Location = new System.Drawing.Point(6, 184);
            this.labelDDoSPrevention.Name = "labelDDoSPrevention";
            this.labelDDoSPrevention.Size = new System.Drawing.Size(93, 13);
            this.labelDDoSPrevention.TabIndex = 12;
            this.labelDDoSPrevention.Text = "DDoS Prevention:";
            // 
            // comboBoxRackConnect
            // 
            this.comboBoxRackConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRackConnect.FormattingEnabled = true;
            this.comboBoxRackConnect.Location = new System.Drawing.Point(155, 154);
            this.comboBoxRackConnect.Name = "comboBoxRackConnect";
            this.comboBoxRackConnect.Size = new System.Drawing.Size(238, 21);
            this.comboBoxRackConnect.TabIndex = 6;
            // 
            // labelRackConnect
            // 
            this.labelRackConnect.AutoSize = true;
            this.labelRackConnect.Location = new System.Drawing.Point(6, 157);
            this.labelRackConnect.Name = "labelRackConnect";
            this.labelRackConnect.Size = new System.Drawing.Size(76, 13);
            this.labelRackConnect.TabIndex = 10;
            this.labelRackConnect.Text = "RackConnect:";
            // 
            // labelSourceMHzPerCore
            // 
            this.labelSourceMHzPerCore.AutoSize = true;
            this.labelSourceMHzPerCore.Location = new System.Drawing.Point(6, 130);
            this.labelSourceMHzPerCore.Name = "labelSourceMHzPerCore";
            this.labelSourceMHzPerCore.Size = new System.Drawing.Size(116, 13);
            this.labelSourceMHzPerCore.TabIndex = 8;
            this.labelSourceMHzPerCore.Text = "(source) MHz per Core:";
            // 
            // labelDefaultMaximumUtilisation
            // 
            this.labelDefaultMaximumUtilisation.AutoSize = true;
            this.labelDefaultMaximumUtilisation.Location = new System.Drawing.Point(6, 103);
            this.labelDefaultMaximumUtilisation.Name = "labelDefaultMaximumUtilisation";
            this.labelDefaultMaximumUtilisation.Size = new System.Drawing.Size(144, 13);
            this.labelDefaultMaximumUtilisation.TabIndex = 6;
            this.labelDefaultMaximumUtilisation.Text = "Default (maximum) Utilisation:";
            // 
            // labelVMSnapshotOverhead
            // 
            this.labelVMSnapshotOverhead.AutoSize = true;
            this.labelVMSnapshotOverhead.Location = new System.Drawing.Point(6, 76);
            this.labelVMSnapshotOverhead.Name = "labelVMSnapshotOverhead";
            this.labelVMSnapshotOverhead.Size = new System.Drawing.Size(124, 13);
            this.labelVMSnapshotOverhead.TabIndex = 4;
            this.labelVMSnapshotOverhead.Text = "VM Snapshot Overhead:";
            // 
            // comboBoxDefaultBackupRetention
            // 
            this.comboBoxDefaultBackupRetention.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDefaultBackupRetention.FormattingEnabled = true;
            this.comboBoxDefaultBackupRetention.Location = new System.Drawing.Point(155, 46);
            this.comboBoxDefaultBackupRetention.Name = "comboBoxDefaultBackupRetention";
            this.comboBoxDefaultBackupRetention.Size = new System.Drawing.Size(238, 21);
            this.comboBoxDefaultBackupRetention.TabIndex = 2;
            // 
            // labelDefaultBackupRetention
            // 
            this.labelDefaultBackupRetention.AutoSize = true;
            this.labelDefaultBackupRetention.Location = new System.Drawing.Point(6, 49);
            this.labelDefaultBackupRetention.Name = "labelDefaultBackupRetention";
            this.labelDefaultBackupRetention.Size = new System.Drawing.Size(133, 13);
            this.labelDefaultBackupRetention.TabIndex = 2;
            this.labelDefaultBackupRetention.Text = "Default Backup Retention:";
            // 
            // comboBoxPrimarySupportSegment
            // 
            this.comboBoxPrimarySupportSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPrimarySupportSegment.FormattingEnabled = true;
            this.comboBoxPrimarySupportSegment.Location = new System.Drawing.Point(155, 19);
            this.comboBoxPrimarySupportSegment.Name = "comboBoxPrimarySupportSegment";
            this.comboBoxPrimarySupportSegment.Size = new System.Drawing.Size(238, 21);
            this.comboBoxPrimarySupportSegment.TabIndex = 1;
            // 
            // labelPrimarySupportSegment
            // 
            this.labelPrimarySupportSegment.AutoSize = true;
            this.labelPrimarySupportSegment.Location = new System.Drawing.Point(6, 22);
            this.labelPrimarySupportSegment.Name = "labelPrimarySupportSegment";
            this.labelPrimarySupportSegment.Size = new System.Drawing.Size(129, 13);
            this.labelPrimarySupportSegment.TabIndex = 0;
            this.labelPrimarySupportSegment.Text = "Primary Support Segment:";
            // 
            // tabPageServers
            // 
            this.tabPageServers.Controls.Add(this.dataGridViewServers);
            this.tabPageServers.Location = new System.Drawing.Point(4, 22);
            this.tabPageServers.Name = "tabPageServers";
            this.tabPageServers.Size = new System.Drawing.Size(976, 679);
            this.tabPageServers.TabIndex = 4;
            this.tabPageServers.Text = "Servers";
            this.tabPageServers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewServers
            // 
            this.dataGridViewServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServerName,
            this.Qty,
            this.ServerType,
            this.OperatingSystem,
            this.LogicalProcessors,
            this.Utilisation,
            this.RequiredMHz,
            this.RAM,
            this.HDD1,
            this.HDD1Type,
            this.HDD2,
            this.HDD2Type,
            this.HDD3,
            this.HDD3Type,
            this.HDD4,
            this.HDD4Type,
            this.HDD5,
            this.HDD5Type,
            this.vHostCluster,
            this.VLAN,
            this.Bandwidth,
            this.LBPool,
            this.Datacentre,
            this.Database,
            this.DatabaseCluster,
            this.Notes,
            this.Include});
            this.dataGridViewServers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewServers.Name = "dataGridViewServers";
            this.dataGridViewServers.Size = new System.Drawing.Size(970, 673);
            this.dataGridViewServers.TabIndex = 0;
            // 
            // ServerName
            // 
            this.ServerName.HeaderText = "Server Name";
            this.ServerName.Name = "ServerName";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // ServerType
            // 
            this.ServerType.HeaderText = "ServerType";
            this.ServerType.Name = "ServerType";
            this.ServerType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServerType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OperatingSystem
            // 
            this.OperatingSystem.HeaderText = "OperatingSystem";
            this.OperatingSystem.Name = "OperatingSystem";
            this.OperatingSystem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OperatingSystem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LogicalProcessors
            // 
            this.LogicalProcessors.HeaderText = "Logical Processors";
            this.LogicalProcessors.Name = "LogicalProcessors";
            // 
            // Utilisation
            // 
            this.Utilisation.HeaderText = "Utilisation";
            this.Utilisation.Name = "Utilisation";
            // 
            // RequiredMHz
            // 
            this.RequiredMHz.HeaderText = "Required MHz";
            this.RequiredMHz.Name = "RequiredMHz";
            // 
            // RAM
            // 
            this.RAM.HeaderText = "RAM (GB)";
            this.RAM.Name = "RAM";
            // 
            // HDD1
            // 
            this.HDD1.HeaderText = "HDD - OS (GB)";
            this.HDD1.Name = "HDD1";
            this.HDD1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDD1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HDD1Type
            // 
            this.HDD1Type.HeaderText = "Type";
            this.HDD1Type.Name = "HDD1Type";
            this.HDD1Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDD1Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HDD2
            // 
            this.HDD2.HeaderText = "Volume 2 (GB)";
            this.HDD2.Name = "HDD2";
            this.HDD2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDD2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HDD2Type
            // 
            this.HDD2Type.HeaderText = "Type";
            this.HDD2Type.Name = "HDD2Type";
            this.HDD2Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDD2Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HDD3
            // 
            this.HDD3.HeaderText = "Volume 3 (GB)";
            this.HDD3.Name = "HDD3";
            this.HDD3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDD3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HDD3Type
            // 
            this.HDD3Type.HeaderText = "Type";
            this.HDD3Type.Name = "HDD3Type";
            this.HDD3Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDD3Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HDD4
            // 
            this.HDD4.HeaderText = "Volume 4 (GB)";
            this.HDD4.Name = "HDD4";
            this.HDD4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDD4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HDD4Type
            // 
            this.HDD4Type.HeaderText = "Type";
            this.HDD4Type.Name = "HDD4Type";
            this.HDD4Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDD4Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HDD5
            // 
            this.HDD5.HeaderText = "Volume 5 (GB)";
            this.HDD5.Name = "HDD5";
            this.HDD5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDD5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HDD5Type
            // 
            this.HDD5Type.HeaderText = "Type";
            this.HDD5Type.Name = "HDD5Type";
            this.HDD5Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDD5Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // vHostCluster
            // 
            this.vHostCluster.HeaderText = "vHost Cluster";
            this.vHostCluster.Name = "vHostCluster";
            this.vHostCluster.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vHostCluster.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // VLAN
            // 
            this.VLAN.HeaderText = "VLAN";
            this.VLAN.Name = "VLAN";
            // 
            // Bandwidth
            // 
            this.Bandwidth.HeaderText = "Bandwidth";
            this.Bandwidth.Name = "Bandwidth";
            // 
            // LBPool
            // 
            this.LBPool.HeaderText = "LBPool";
            this.LBPool.Name = "LBPool";
            // 
            // Datacentre
            // 
            this.Datacentre.HeaderText = "Datacentre";
            this.Datacentre.Name = "Datacentre";
            this.Datacentre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Datacentre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Database
            // 
            this.Database.HeaderText = "Database";
            this.Database.Name = "Database";
            this.Database.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Database.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DatabaseCluster
            // 
            this.DatabaseCluster.HeaderText = "Database Cluster";
            this.DatabaseCluster.Name = "DatabaseCluster";
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            // 
            // Include
            // 
            this.Include.HeaderText = "Include";
            this.Include.Name = "Include";
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.groupBoxConfiguration);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Size = new System.Drawing.Size(976, 679);
            this.tabPageConfig.TabIndex = 3;
            this.tabPageConfig.Text = "Configuration";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // groupBoxConfiguration
            // 
            this.groupBoxConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConfiguration.Controls.Add(this.button5);
            this.groupBoxConfiguration.Controls.Add(this.button6);
            this.groupBoxConfiguration.Controls.Add(this.button7);
            this.groupBoxConfiguration.Controls.Add(this.button8);
            this.groupBoxConfiguration.Controls.Add(this.button4);
            this.groupBoxConfiguration.Controls.Add(this.textBox4);
            this.groupBoxConfiguration.Controls.Add(this.label10);
            this.groupBoxConfiguration.Controls.Add(this.button3);
            this.groupBoxConfiguration.Controls.Add(this.textBox3);
            this.groupBoxConfiguration.Controls.Add(this.label9);
            this.groupBoxConfiguration.Controls.Add(this.button2);
            this.groupBoxConfiguration.Controls.Add(this.textBox2);
            this.groupBoxConfiguration.Controls.Add(this.label8);
            this.groupBoxConfiguration.Controls.Add(this.button1);
            this.groupBoxConfiguration.Controls.Add(this.textBox1);
            this.groupBoxConfiguration.Controls.Add(this.label7);
            this.groupBoxConfiguration.Location = new System.Drawing.Point(3, 3);
            this.groupBoxConfiguration.Name = "groupBoxConfiguration";
            this.groupBoxConfiguration.Size = new System.Drawing.Size(970, 673);
            this.groupBoxConfiguration.TabIndex = 0;
            this.groupBoxConfiguration.TabStop = false;
            this.groupBoxConfiguration.Text = "Solution Scoping Tool Configuration";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(889, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(889, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(889, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(889, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(808, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(198, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(604, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Visio Stencil File:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(808, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(198, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(604, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Solution Document File:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(808, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(198, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(604, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Customer Settings File";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(808, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(198, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(604, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Configuration Settings File:";
            // 
            // backgroundWorkerLoadConfigSettings
            // 
            this.backgroundWorkerLoadConfigSettings.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadConfigSettings_DoWork);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 732);
            this.Controls.Add(this.tabControlMain);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FormMain";
            this.Text = "Solution Scoping Tool:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageDetails.ResumeLayout(false);
            this.groupBoxSolutionScopingToolDetails.ResumeLayout(false);
            this.groupBoxSolutionScopingToolDetails.PerformLayout();
            this.tabPageInput.ResumeLayout(false);
            this.groupBoxBasicNetwork.ResumeLayout(false);
            this.groupBoxBasicNetwork.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageServers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).EndInit();
            this.tabPageConfig.ResumeLayout(false);
            this.groupBoxConfiguration.ResumeLayout(false);
            this.groupBoxConfiguration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.TabPage tabPageNotes;
        private System.Windows.Forms.TextBox textBoxScopingToolVersion;
        private System.Windows.Forms.Label labelScopingToolVersion;
        private System.Windows.Forms.GroupBox groupBoxSolutionScopingToolDetails;
        private System.Windows.Forms.Label labelSolutionEngineerName;
        private System.Windows.Forms.TextBox textBoxSolutionEngineerName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Button buttonLoadConfig;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.TextBox textBoxDesignIteration;
        private System.Windows.Forms.Label labelDesignIteration;
        private System.Windows.Forms.TextBox textBoxDesignOption;
        private System.Windows.Forms.Label labelDesignOption;
        private System.Windows.Forms.TabPage tabPageInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPrimarySupportSegment;
        private System.Windows.Forms.ComboBox comboBoxPrimarySupportSegment;
        private System.Windows.Forms.ComboBox comboBoxDDoSPrevention;
        private System.Windows.Forms.Label labelDDoSPrevention;
        private System.Windows.Forms.ComboBox comboBoxRackConnect;
        private System.Windows.Forms.Label labelRackConnect;
        private System.Windows.Forms.Label labelSourceMHzPerCore;
        private System.Windows.Forms.Label labelDefaultMaximumUtilisation;
        private System.Windows.Forms.Label labelVMSnapshotOverhead;
        private System.Windows.Forms.ComboBox comboBoxDefaultBackupRetention;
        private System.Windows.Forms.Label labelDefaultBackupRetention;
        private System.Windows.Forms.GroupBox groupBoxBasicNetwork;
        private System.Windows.Forms.ComboBox comboBoxTier1Firewall;
        private System.Windows.Forms.Label labelTier1Firewall;
        private System.Windows.Forms.ComboBox comboBoxGlobalTrafficManager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxWebApplicationFirewall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLoadBalancer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTier2Firewall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTier1FirewallHighAvailability;
        private System.Windows.Forms.CheckBox checkBoxWebApplicationFirewallHighAvailability;
        private System.Windows.Forms.CheckBox checkBoxLoadBalancerHighAvailability;
        private System.Windows.Forms.CheckBox checkBoxTier2FirewallHighAvailability;
        private System.Windows.Forms.ComboBox comboBoxLogManager;
        private System.Windows.Forms.ComboBox comboBoxIDSThreatManager;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.GroupBox groupBoxConfiguration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVMSnapshotOverhead;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDefaultMaximumUtilisation;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSourceMHzPerCore;
        private System.Windows.Forms.TabPage tabPageServers;
        private System.Windows.Forms.DataGridView dataGridViewServers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewComboBoxColumn ServerType;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatingSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogicalProcessors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredMHz;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewComboBoxColumn HDD1;
        private System.Windows.Forms.DataGridViewComboBoxColumn HDD1Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn HDD2;
        private System.Windows.Forms.DataGridViewComboBoxColumn HDD2Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn HDD3;
        private System.Windows.Forms.DataGridViewComboBoxColumn HDD3Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn HDD4;
        private System.Windows.Forms.DataGridViewComboBoxColumn HDD4Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn HDD5;
        private System.Windows.Forms.DataGridViewComboBoxColumn HDD5Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn vHostCluster;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bandwidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn LBPool;
        private System.Windows.Forms.DataGridViewComboBoxColumn Datacentre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Database;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatabaseCluster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Include;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadConfigSettings;
    }
}

