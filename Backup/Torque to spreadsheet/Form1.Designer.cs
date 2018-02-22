namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button_Serial = new System.Windows.Forms.Button();
            this.Button_Aquire = new System.Windows.Forms.Button();
            this.Label_Data = new System.Windows.Forms.Label();
            this.Label_Units = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SpreadSheetModeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableSoundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMinimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.includeDateStampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.includeTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.includeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reading_Only_Box = new System.Windows.Forms.CheckBox();
            this.RowCountMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Tester_Type_Label = new System.Windows.Forms.Label();
            this.checkBox_millivolt = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RowCountMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Serial
            // 
            this.Button_Serial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Serial.Location = new System.Drawing.Point(19, 117);
            this.Button_Serial.Name = "Button_Serial";
            this.Button_Serial.Size = new System.Drawing.Size(113, 61);
            this.Button_Serial.TabIndex = 1;
            this.Button_Serial.Text = "Open/Close Serial Link";
            this.Button_Serial.UseVisualStyleBackColor = true;
            this.Button_Serial.Click += new System.EventHandler(this.Button_Serial_Click);
            // 
            // Button_Aquire
            // 
            this.Button_Aquire.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Aquire.Location = new System.Drawing.Point(192, 117);
            this.Button_Aquire.Name = "Button_Aquire";
            this.Button_Aquire.Size = new System.Drawing.Size(109, 61);
            this.Button_Aquire.TabIndex = 2;
            this.Button_Aquire.Text = "Activate Spreadsheet Transfer";
            this.Button_Aquire.UseVisualStyleBackColor = true;
            this.Button_Aquire.Click += new System.EventHandler(this.Button_Aquire_Click);
            // 
            // Label_Data
            // 
            this.Label_Data.AutoSize = true;
            this.Label_Data.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Data.Location = new System.Drawing.Point(12, 54);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(178, 39);
            this.Label_Data.TabIndex = 3;
            this.Label_Data.Text = "No Data";
            // 
            // Label_Units
            // 
            this.Label_Units.AutoSize = true;
            this.Label_Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Units.Location = new System.Drawing.Point(234, 68);
            this.Label_Units.Name = "Label_Units";
            this.Label_Units.Size = new System.Drawing.Size(81, 24);
            this.Label_Units.TabIndex = 4;
            this.Label_Units.Text = "No Units";
            this.Label_Units.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.SpreadSheetModeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 228);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(474, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel1.Text = "Port: ";
            this.toolStripStatusLabel1.MouseHover += new System.EventHandler(this.toolStripStatusLabel1_MouseHover);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 20);
            this.toolStripDropDownButton1.MouseHover += new System.EventHandler(this.toolStripDropDownButton1_MouseHover);
            this.toolStripDropDownButton1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDropDownButton1_DropDownItemClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel2.Text = " Status: Closed";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel3.Text = " Spreadsheet Mode:";
            // 
            // SpreadSheetModeLabel
            // 
            this.SpreadSheetModeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpreadSheetModeLabel.Name = "SpreadSheetModeLabel";
            this.SpreadSheetModeLabel.Size = new System.Drawing.Size(75, 17);
            this.SpreadSheetModeLabel.Text = "Deactivated";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableSoundsToolStripMenuItem,
            this.autoConnectToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem,
            this.includeDateStampToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // enableSoundsToolStripMenuItem
            // 
            this.enableSoundsToolStripMenuItem.CheckOnClick = true;
            this.enableSoundsToolStripMenuItem.Name = "enableSoundsToolStripMenuItem";
            this.enableSoundsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.enableSoundsToolStripMenuItem.Text = "Enable Sounds";
            this.enableSoundsToolStripMenuItem.Click += new System.EventHandler(this.enableSoundsToolStripMenuItem_Click);
            // 
            // autoConnectToolStripMenuItem
            // 
            this.autoConnectToolStripMenuItem.CheckOnClick = true;
            this.autoConnectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMinimizedToolStripMenuItem});
            this.autoConnectToolStripMenuItem.Name = "autoConnectToolStripMenuItem";
            this.autoConnectToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.autoConnectToolStripMenuItem.Text = "Auto Connect";
            this.autoConnectToolStripMenuItem.Click += new System.EventHandler(this.autoConnectToolStripMenuItem_Click);
            // 
            // startMinimizedToolStripMenuItem
            // 
            this.startMinimizedToolStripMenuItem.CheckOnClick = true;
            this.startMinimizedToolStripMenuItem.Enabled = false;
            this.startMinimizedToolStripMenuItem.Name = "startMinimizedToolStripMenuItem";
            this.startMinimizedToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.startMinimizedToolStripMenuItem.Text = "Start Minimized";
            this.startMinimizedToolStripMenuItem.EnabledChanged += new System.EventHandler(this.startMinimizedToolStripMenuItem_EnabledChanged);
            this.startMinimizedToolStripMenuItem.Click += new System.EventHandler(this.startMinimizedToolStripMenuItem_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // includeDateStampToolStripMenuItem
            // 
            this.includeDateStampToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.includeTimeToolStripMenuItem,
            this.includeDateToolStripMenuItem});
            this.includeDateStampToolStripMenuItem.Name = "includeDateStampToolStripMenuItem";
            this.includeDateStampToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.includeDateStampToolStripMenuItem.Text = "Time/Date Stamp";
            // 
            // includeTimeToolStripMenuItem
            // 
            this.includeTimeToolStripMenuItem.Name = "includeTimeToolStripMenuItem";
            this.includeTimeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.includeTimeToolStripMenuItem.Text = "Include Time";
            this.includeTimeToolStripMenuItem.Click += new System.EventHandler(this.includeTimeToolStripMenuItem_Click);
            // 
            // includeDateToolStripMenuItem
            // 
            this.includeDateToolStripMenuItem.Name = "includeDateToolStripMenuItem";
            this.includeDateToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.includeDateToolStripMenuItem.Text = "Include Date";
            this.includeDateToolStripMenuItem.Click += new System.EventHandler(this.includeDateToolStripMenuItem_Click);
            // 
            // Reading_Only_Box
            // 
            this.Reading_Only_Box.AutoSize = true;
            this.Reading_Only_Box.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reading_Only_Box.Location = new System.Drawing.Point(192, 185);
            this.Reading_Only_Box.Name = "Reading_Only_Box";
            this.Reading_Only_Box.Size = new System.Drawing.Size(139, 20);
            this.Reading_Only_Box.TabIndex = 7;
            this.Reading_Only_Box.Text = "Send Reading Only";
            this.Reading_Only_Box.UseVisualStyleBackColor = true;
            this.Reading_Only_Box.CheckedChanged += new System.EventHandler(this.Reading_Only_Box_CheckedChanged);
            // 
            // RowCountMax
            // 
            this.RowCountMax.Location = new System.Drawing.Point(350, 135);
            this.RowCountMax.Name = "RowCountMax";
            this.RowCountMax.Size = new System.Drawing.Size(57, 20);
            this.RowCountMax.TabIndex = 8;
            this.RowCountMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowCountMax.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Readings Per Row";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start New Row";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tester_Type_Label
            // 
            this.Tester_Type_Label.AutoSize = true;
            this.Tester_Type_Label.Location = new System.Drawing.Point(515, 182);
            this.Tester_Type_Label.Name = "Tester_Type_Label";
            this.Tester_Type_Label.Size = new System.Drawing.Size(65, 14);
            this.Tester_Type_Label.TabIndex = 11;
            this.Tester_Type_Label.Text = "Tester Type";
            this.Tester_Type_Label.Visible = false;
            // 
            // checkBox_millivolt
            // 
            this.checkBox_millivolt.AutoSize = true;
            this.checkBox_millivolt.Location = new System.Drawing.Point(529, 145);
            this.checkBox_millivolt.Name = "checkBox_millivolt";
            this.checkBox_millivolt.Size = new System.Drawing.Size(120, 18);
            this.checkBox_millivolt.TabIndex = 12;
            this.checkBox_millivolt.Text = "Show Millivolts only";
            this.checkBox_millivolt.UseVisualStyleBackColor = true;
            this.checkBox_millivolt.Visible = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Torque to Spreadsheet is Active";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Torque to Spreadsheet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(31, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 71);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select fields to send to spreadsheet";
            this.groupBox1.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.checkBox5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(488, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(89, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 18);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(175, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 18);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(261, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 18);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(347, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 18);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(474, 250);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_millivolt);
            this.Controls.Add(this.Tester_Type_Label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RowCountMax);
            this.Controls.Add(this.Reading_Only_Box);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Label_Units);
            this.Controls.Add(this.Label_Data);
            this.Controls.Add(this.Button_Aquire);
            this.Controls.Add(this.Button_Serial);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AWS Torque to Spreadsheet";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RowCountMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Serial;
        private System.Windows.Forms.Button Button_Aquire;
        private System.Windows.Forms.Label Label_Data;
        private System.Windows.Forms.Label Label_Units;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox Reading_Only_Box;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel SpreadSheetModeLabel;
        private System.Windows.Forms.NumericUpDown RowCountMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Tester_Type_Label;
        private System.Windows.Forms.CheckBox checkBox_millivolt;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableSoundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startMinimizedToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem includeDateStampToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem includeTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem includeDateToolStripMenuItem;
    }
}

