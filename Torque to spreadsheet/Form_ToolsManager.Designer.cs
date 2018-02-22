namespace WindowsFormsApplication1
{
    partial class Form_ToolsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ToolsManager));
            this.testSetup_groupBox = new System.Windows.Forms.GroupBox();
            this.testManager_btn = new System.Windows.Forms.Button();
            this.testID_comboBox = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.limitEngPercent_comboBox = new System.Windows.Forms.ComboBox();
            this.sampleNum_txt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.maxPoint_txt = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.highLimit_txt = new System.Windows.Forms.TextBox();
            this.lowLimit_txt = new System.Windows.Forms.TextBox();
            this.FS_txt = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.FSTarget_label = new System.Windows.Forms.Label();
            this.testType_comboBox = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ch2Mode_comboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ch1Mode_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveAsTool_btn = new System.Windows.Forms.Button();
            this.saveTool_btn = new System.Windows.Forms.Button();
            this.pauseTool_chk = new System.Windows.Forms.CheckBox();
            this.scanOperator_chk = new System.Windows.Forms.CheckBox();
            this.lotID_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SN_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.manufacture_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.equipment_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.model_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolID_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scan2_chk = new System.Windows.Forms.CheckBox();
            this.scan1_chk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchSubject_comboBox = new System.Windows.Forms.ComboBox();
            this.newTool_btn = new System.Windows.Forms.Button();
            this.searchResult_listBox = new System.Windows.Forms.ListBox();
            this.toolDelete_btn = new System.Windows.Forms.Button();
            this.searchField_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolsModel_comboBox = new System.Windows.Forms.ComboBox();
            this.testSetup_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testSetup_groupBox
            // 
            this.testSetup_groupBox.Controls.Add(this.testManager_btn);
            this.testSetup_groupBox.Controls.Add(this.testID_comboBox);
            this.testSetup_groupBox.Controls.Add(this.label27);
            this.testSetup_groupBox.Controls.Add(this.limitEngPercent_comboBox);
            this.testSetup_groupBox.Controls.Add(this.sampleNum_txt);
            this.testSetup_groupBox.Controls.Add(this.label30);
            this.testSetup_groupBox.Controls.Add(this.label31);
            this.testSetup_groupBox.Controls.Add(this.maxPoint_txt);
            this.testSetup_groupBox.Controls.Add(this.label33);
            this.testSetup_groupBox.Controls.Add(this.highLimit_txt);
            this.testSetup_groupBox.Controls.Add(this.lowLimit_txt);
            this.testSetup_groupBox.Controls.Add(this.FS_txt);
            this.testSetup_groupBox.Controls.Add(this.label35);
            this.testSetup_groupBox.Controls.Add(this.label36);
            this.testSetup_groupBox.Controls.Add(this.FSTarget_label);
            this.testSetup_groupBox.Controls.Add(this.testType_comboBox);
            this.testSetup_groupBox.Controls.Add(this.label37);
            this.testSetup_groupBox.Location = new System.Drawing.Point(514, 12);
            this.testSetup_groupBox.Name = "testSetup_groupBox";
            this.testSetup_groupBox.Size = new System.Drawing.Size(266, 324);
            this.testSetup_groupBox.TabIndex = 28;
            this.testSetup_groupBox.TabStop = false;
            this.testSetup_groupBox.Text = "Test Set up";
            // 
            // testManager_btn
            // 
            this.testManager_btn.Location = new System.Drawing.Point(94, 278);
            this.testManager_btn.Name = "testManager_btn";
            this.testManager_btn.Size = new System.Drawing.Size(93, 23);
            this.testManager_btn.TabIndex = 63;
            this.testManager_btn.Text = "Test Managers";
            this.testManager_btn.UseVisualStyleBackColor = true;
            this.testManager_btn.Click += new System.EventHandler(this.testManager_btn_Click);
            // 
            // testID_comboBox
            // 
            this.testID_comboBox.FormattingEnabled = true;
            this.testID_comboBox.Location = new System.Drawing.Point(127, 23);
            this.testID_comboBox.Name = "testID_comboBox";
            this.testID_comboBox.Size = new System.Drawing.Size(133, 21);
            this.testID_comboBox.TabIndex = 60;
            this.testID_comboBox.SelectedIndexChanged += new System.EventHandler(this.testID_comboBox_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 227);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 13);
            this.label27.TabIndex = 59;
            this.label27.Text = "% or Eng. Unit *";
            // 
            // limitEngPercent_comboBox
            // 
            this.limitEngPercent_comboBox.Enabled = false;
            this.limitEngPercent_comboBox.FormattingEnabled = true;
            this.limitEngPercent_comboBox.Items.AddRange(new object[] {
            "%",
            "Eng. Unit"});
            this.limitEngPercent_comboBox.Location = new System.Drawing.Point(127, 224);
            this.limitEngPercent_comboBox.Name = "limitEngPercent_comboBox";
            this.limitEngPercent_comboBox.Size = new System.Drawing.Size(133, 21);
            this.limitEngPercent_comboBox.TabIndex = 9;
            // 
            // sampleNum_txt
            // 
            this.sampleNum_txt.Enabled = false;
            this.sampleNum_txt.Location = new System.Drawing.Point(127, 146);
            this.sampleNum_txt.Name = "sampleNum_txt";
            this.sampleNum_txt.Size = new System.Drawing.Size(133, 20);
            this.sampleNum_txt.TabIndex = 6;
            this.sampleNum_txt.Text = "1";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(6, 149);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(109, 13);
            this.label30.TabIndex = 51;
            this.label30.Text = "# Samples/point *";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(6, 95);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(69, 13);
            this.label31.TabIndex = 49;
            this.label31.Text = "# of Points";
            // 
            // maxPoint_txt
            // 
            this.maxPoint_txt.Enabled = false;
            this.maxPoint_txt.Location = new System.Drawing.Point(127, 92);
            this.maxPoint_txt.Name = "maxPoint_txt";
            this.maxPoint_txt.Size = new System.Drawing.Size(133, 20);
            this.maxPoint_txt.TabIndex = 3;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(6, 26);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(58, 13);
            this.label33.TabIndex = 46;
            this.label33.Text = "Test ID *";
            // 
            // highLimit_txt
            // 
            this.highLimit_txt.Enabled = false;
            this.highLimit_txt.Location = new System.Drawing.Point(127, 198);
            this.highLimit_txt.Name = "highLimit_txt";
            this.highLimit_txt.Size = new System.Drawing.Size(133, 20);
            this.highLimit_txt.TabIndex = 8;
            // 
            // lowLimit_txt
            // 
            this.lowLimit_txt.Enabled = false;
            this.lowLimit_txt.Location = new System.Drawing.Point(127, 172);
            this.lowLimit_txt.Name = "lowLimit_txt";
            this.lowLimit_txt.Size = new System.Drawing.Size(133, 20);
            this.lowLimit_txt.TabIndex = 7;
            // 
            // FS_txt
            // 
            this.FS_txt.Enabled = false;
            this.FS_txt.Location = new System.Drawing.Point(127, 120);
            this.FS_txt.Name = "FS_txt";
            this.FS_txt.Size = new System.Drawing.Size(133, 20);
            this.FS_txt.TabIndex = 4;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(8, 201);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 13);
            this.label35.TabIndex = 33;
            this.label35.Text = "High Limit *";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(6, 175);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 13);
            this.label36.TabIndex = 32;
            this.label36.Text = "Low Limit *";
            // 
            // FSTarget_label
            // 
            this.FSTarget_label.AutoSize = true;
            this.FSTarget_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSTarget_label.Location = new System.Drawing.Point(6, 123);
            this.FSTarget_label.Name = "FSTarget_label";
            this.FSTarget_label.Size = new System.Drawing.Size(109, 13);
            this.FSTarget_label.TabIndex = 31;
            this.FSTarget_label.Text = "Target Full Scale*";
            // 
            // testType_comboBox
            // 
            this.testType_comboBox.Enabled = false;
            this.testType_comboBox.FormattingEnabled = true;
            this.testType_comboBox.Items.AddRange(new object[] {
            "Single Channel Test",
            "Dual Channel Test"});
            this.testType_comboBox.Location = new System.Drawing.Point(127, 61);
            this.testType_comboBox.Name = "testType_comboBox";
            this.testType_comboBox.Size = new System.Drawing.Size(133, 21);
            this.testType_comboBox.TabIndex = 2;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(6, 64);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(73, 13);
            this.label37.TabIndex = 12;
            this.label37.Text = "Test Type *";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ch2Mode_comboBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ch1Mode_comboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.saveAsTool_btn);
            this.groupBox2.Controls.Add(this.saveTool_btn);
            this.groupBox2.Controls.Add(this.pauseTool_chk);
            this.groupBox2.Controls.Add(this.scanOperator_chk);
            this.groupBox2.Controls.Add(this.lotID_txt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SN_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.manufacture_txt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.equipment_txt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.model_txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.toolID_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 324);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // ch2Mode_comboBox
            // 
            this.ch2Mode_comboBox.FormattingEnabled = true;
            this.ch2Mode_comboBox.Items.AddRange(new object[] {
            "Track",
            "Peak",
            "1st Peak",
            "Trough"});
            this.ch2Mode_comboBox.Location = new System.Drawing.Point(148, 198);
            this.ch2Mode_comboBox.Name = "ch2Mode_comboBox";
            this.ch2Mode_comboBox.Size = new System.Drawing.Size(93, 21);
            this.ch2Mode_comboBox.TabIndex = 63;
            this.ch2Mode_comboBox.SelectedIndexChanged += new System.EventHandler(this.ch2Mode_comboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Ch2 Mode";
            // 
            // ch1Mode_comboBox
            // 
            this.ch1Mode_comboBox.FormattingEnabled = true;
            this.ch1Mode_comboBox.Items.AddRange(new object[] {
            "Track",
            "Peak",
            "1st Peak",
            "Trough"});
            this.ch1Mode_comboBox.Location = new System.Drawing.Point(12, 198);
            this.ch1Mode_comboBox.Name = "ch1Mode_comboBox";
            this.ch1Mode_comboBox.Size = new System.Drawing.Size(93, 21);
            this.ch1Mode_comboBox.TabIndex = 61;
            this.ch1Mode_comboBox.SelectedIndexChanged += new System.EventHandler(this.ch1Mode_comboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ch1 Mode";
            // 
            // saveAsTool_btn
            // 
            this.saveAsTool_btn.Location = new System.Drawing.Point(148, 293);
            this.saveAsTool_btn.Name = "saveAsTool_btn";
            this.saveAsTool_btn.Size = new System.Drawing.Size(75, 23);
            this.saveAsTool_btn.TabIndex = 15;
            this.saveAsTool_btn.Text = "Save As";
            this.saveAsTool_btn.UseVisualStyleBackColor = true;
            this.saveAsTool_btn.Click += new System.EventHandler(this.saveAsTool_btn_Click);
            // 
            // saveTool_btn
            // 
            this.saveTool_btn.Location = new System.Drawing.Point(30, 293);
            this.saveTool_btn.Name = "saveTool_btn";
            this.saveTool_btn.Size = new System.Drawing.Size(75, 23);
            this.saveTool_btn.TabIndex = 14;
            this.saveTool_btn.Text = "Save";
            this.saveTool_btn.UseVisualStyleBackColor = true;
            this.saveTool_btn.Click += new System.EventHandler(this.saveTool_btn_Click);
            // 
            // pauseTool_chk
            // 
            this.pauseTool_chk.AutoSize = true;
            this.pauseTool_chk.Location = new System.Drawing.Point(12, 256);
            this.pauseTool_chk.Name = "pauseTool_chk";
            this.pauseTool_chk.Size = new System.Drawing.Size(126, 17);
            this.pauseTool_chk.TabIndex = 13;
            this.pauseTool_chk.Text = "Pause for Tool Setup";
            this.pauseTool_chk.UseVisualStyleBackColor = true;
            // 
            // scanOperator_chk
            // 
            this.scanOperator_chk.AutoSize = true;
            this.scanOperator_chk.Location = new System.Drawing.Point(12, 228);
            this.scanOperator_chk.Name = "scanOperator_chk";
            this.scanOperator_chk.Size = new System.Drawing.Size(95, 17);
            this.scanOperator_chk.TabIndex = 12;
            this.scanOperator_chk.Text = "Scan Operator";
            this.scanOperator_chk.UseVisualStyleBackColor = true;
            // 
            // lotID_txt
            // 
            this.lotID_txt.Location = new System.Drawing.Point(94, 149);
            this.lotID_txt.Name = "lotID_txt";
            this.lotID_txt.Size = new System.Drawing.Size(147, 20);
            this.lotID_txt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lot/ID:";
            // 
            // SN_txt
            // 
            this.SN_txt.Location = new System.Drawing.Point(94, 45);
            this.SN_txt.Name = "SN_txt";
            this.SN_txt.Size = new System.Drawing.Size(147, 20);
            this.SN_txt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Serial Number:";
            // 
            // manufacture_txt
            // 
            this.manufacture_txt.Location = new System.Drawing.Point(94, 123);
            this.manufacture_txt.Name = "manufacture_txt";
            this.manufacture_txt.Size = new System.Drawing.Size(147, 20);
            this.manufacture_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manufacture:";
            // 
            // equipment_txt
            // 
            this.equipment_txt.Location = new System.Drawing.Point(94, 97);
            this.equipment_txt.Name = "equipment_txt";
            this.equipment_txt.Size = new System.Drawing.Size(147, 20);
            this.equipment_txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Equipment:";
            // 
            // model_txt
            // 
            this.model_txt.Location = new System.Drawing.Point(94, 71);
            this.model_txt.Name = "model_txt";
            this.model_txt.Size = new System.Drawing.Size(147, 20);
            this.model_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // toolID_txt
            // 
            this.toolID_txt.Location = new System.Drawing.Point(94, 19);
            this.toolID_txt.Name = "toolID_txt";
            this.toolID_txt.Size = new System.Drawing.Size(147, 20);
            this.toolID_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tool ID/Name:";
            // 
            // scan2_chk
            // 
            this.scan2_chk.AutoSize = true;
            this.scan2_chk.Location = new System.Drawing.Point(329, 383);
            this.scan2_chk.Name = "scan2_chk";
            this.scan2_chk.Size = new System.Drawing.Size(106, 17);
            this.scan2_chk.TabIndex = 14;
            this.scan2_chk.Text = "Require Humidity";
            this.scan2_chk.UseVisualStyleBackColor = true;
            this.scan2_chk.Visible = false;
            // 
            // scan1_chk
            // 
            this.scan1_chk.AutoSize = true;
            this.scan1_chk.Location = new System.Drawing.Point(329, 360);
            this.scan1_chk.Name = "scan1_chk";
            this.scan1_chk.Size = new System.Drawing.Size(126, 17);
            this.scan1_chk.TabIndex = 13;
            this.scan1_chk.Text = "Require Temperature";
            this.scan1_chk.UseVisualStyleBackColor = true;
            this.scan1_chk.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchSubject_comboBox);
            this.groupBox1.Controls.Add(this.newTool_btn);
            this.groupBox1.Controls.Add(this.searchResult_listBox);
            this.groupBox1.Controls.Add(this.toolDelete_btn);
            this.groupBox1.Controls.Add(this.searchField_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.toolsModel_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 324);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // searchSubject_comboBox
            // 
            this.searchSubject_comboBox.FormattingEnabled = true;
            this.searchSubject_comboBox.Location = new System.Drawing.Point(15, 57);
            this.searchSubject_comboBox.Name = "searchSubject_comboBox";
            this.searchSubject_comboBox.Size = new System.Drawing.Size(80, 21);
            this.searchSubject_comboBox.TabIndex = 0;
            this.searchSubject_comboBox.SelectedIndexChanged += new System.EventHandler(this.searchSubject_comboBox_SelectedIndexChanged);
            // 
            // newTool_btn
            // 
            this.newTool_btn.Location = new System.Drawing.Point(32, 278);
            this.newTool_btn.Name = "newTool_btn";
            this.newTool_btn.Size = new System.Drawing.Size(75, 23);
            this.newTool_btn.TabIndex = 3;
            this.newTool_btn.Text = "New";
            this.newTool_btn.UseVisualStyleBackColor = true;
            this.newTool_btn.Click += new System.EventHandler(this.newTool_btn_Click);
            // 
            // searchResult_listBox
            // 
            this.searchResult_listBox.FormattingEnabled = true;
            this.searchResult_listBox.Location = new System.Drawing.Point(15, 83);
            this.searchResult_listBox.Name = "searchResult_listBox";
            this.searchResult_listBox.Size = new System.Drawing.Size(204, 186);
            this.searchResult_listBox.TabIndex = 2;
            this.searchResult_listBox.SelectedIndexChanged += new System.EventHandler(this.tools_listBox_SelectedIndexChanged);
            // 
            // toolDelete_btn
            // 
            this.toolDelete_btn.Location = new System.Drawing.Point(130, 278);
            this.toolDelete_btn.Name = "toolDelete_btn";
            this.toolDelete_btn.Size = new System.Drawing.Size(75, 23);
            this.toolDelete_btn.TabIndex = 4;
            this.toolDelete_btn.Text = "Delete";
            this.toolDelete_btn.UseVisualStyleBackColor = true;
            this.toolDelete_btn.Click += new System.EventHandler(this.toolDelete_btn_Click);
            // 
            // searchField_txt
            // 
            this.searchField_txt.Location = new System.Drawing.Point(101, 57);
            this.searchField_txt.Name = "searchField_txt";
            this.searchField_txt.Size = new System.Drawing.Size(118, 20);
            this.searchField_txt.TabIndex = 1;
            this.searchField_txt.TextChanged += new System.EventHandler(this.toolSearch_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search: ";
            // 
            // toolsModel_comboBox
            // 
            this.toolsModel_comboBox.FormattingEnabled = true;
            this.toolsModel_comboBox.Items.AddRange(new object[] {
            "Tool",
            "Model"});
            this.toolsModel_comboBox.Location = new System.Drawing.Point(15, 9);
            this.toolsModel_comboBox.Name = "toolsModel_comboBox";
            this.toolsModel_comboBox.Size = new System.Drawing.Size(111, 21);
            this.toolsModel_comboBox.TabIndex = 5;
            this.toolsModel_comboBox.Visible = false;
            this.toolsModel_comboBox.SelectedIndexChanged += new System.EventHandler(this.toolsModel_comboBox_SelectedIndexChanged);
            // 
            // Form_ToolsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 418);
            this.Controls.Add(this.testSetup_groupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scan2_chk);
            this.Controls.Add(this.scan1_chk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ToolsManager";
            this.Text = "Tools Manager";
            this.testSetup_groupBox.ResumeLayout(false);
            this.testSetup_groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox testSetup_groupBox;
        private System.Windows.Forms.ComboBox testID_comboBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox limitEngPercent_comboBox;
        private System.Windows.Forms.TextBox sampleNum_txt;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox maxPoint_txt;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox highLimit_txt;
        private System.Windows.Forms.TextBox lowLimit_txt;
        private System.Windows.Forms.TextBox FS_txt;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label FSTarget_label;
        private System.Windows.Forms.ComboBox testType_comboBox;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveAsTool_btn;
        private System.Windows.Forms.Button saveTool_btn;
        private System.Windows.Forms.CheckBox pauseTool_chk;
        private System.Windows.Forms.CheckBox scan2_chk;
        private System.Windows.Forms.CheckBox scan1_chk;
        private System.Windows.Forms.CheckBox scanOperator_chk;
        private System.Windows.Forms.TextBox lotID_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SN_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox manufacture_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox equipment_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox model_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toolID_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button toolDelete_btn;
        private System.Windows.Forms.TextBox searchField_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox toolsModel_comboBox;
        private System.Windows.Forms.ListBox searchResult_listBox;
        private System.Windows.Forms.Button testManager_btn;
        private System.Windows.Forms.Button newTool_btn;
        private System.Windows.Forms.ComboBox searchSubject_comboBox;
        private System.Windows.Forms.ComboBox ch1Mode_comboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ch2Mode_comboBox;
        private System.Windows.Forms.Label label9;
    }
}