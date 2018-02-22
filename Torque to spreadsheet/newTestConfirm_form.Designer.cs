namespace WindowsFormsApplication1
{
    partial class newTestConfirm_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newTestConfirm_form));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exportCertCSV_chkBox = new System.Windows.Forms.CheckBox();
            this.excelExport_chkbox = new System.Windows.Forms.CheckBox();
            this.yes_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All recorded Readings will be cleared. Proceed?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exportCertCSV_chkBox);
            this.groupBox1.Controls.Add(this.excelExport_chkbox);
            this.groupBox1.Location = new System.Drawing.Point(15, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perform before Clear all data";
            // 
            // exportCertCSV_chkBox
            // 
            this.exportCertCSV_chkBox.AutoSize = true;
            this.exportCertCSV_chkBox.Location = new System.Drawing.Point(6, 42);
            this.exportCertCSV_chkBox.Name = "exportCertCSV_chkBox";
            this.exportCertCSV_chkBox.Size = new System.Drawing.Size(130, 17);
            this.exportCertCSV_chkBox.TabIndex = 4;
            this.exportCertCSV_chkBox.Text = "Save to Cert Manager";
            this.exportCertCSV_chkBox.UseVisualStyleBackColor = true;
            // 
            // excelExport_chkbox
            // 
            this.excelExport_chkbox.AutoSize = true;
            this.excelExport_chkbox.Location = new System.Drawing.Point(6, 19);
            this.excelExport_chkbox.Name = "excelExport_chkbox";
            this.excelExport_chkbox.Size = new System.Drawing.Size(100, 17);
            this.excelExport_chkbox.TabIndex = 3;
            this.excelExport_chkbox.Text = "Export to Excel ";
            this.excelExport_chkbox.UseVisualStyleBackColor = true;
            // 
            // yes_btn
            // 
            this.yes_btn.Location = new System.Drawing.Point(15, 135);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(75, 23);
            this.yes_btn.TabIndex = 5;
            this.yes_btn.Text = "Yes";
            this.yes_btn.UseVisualStyleBackColor = true;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // no_btn
            // 
            this.no_btn.Location = new System.Drawing.Point(140, 135);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(75, 23);
            this.no_btn.TabIndex = 6;
            this.no_btn.Text = "No";
            this.no_btn.UseVisualStyleBackColor = true;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // newTestConfirm_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 175);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newTestConfirm_form";
            this.Text = "New Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox exportCertCSV_chkBox;
        private System.Windows.Forms.CheckBox excelExport_chkbox;
        private System.Windows.Forms.Button yes_btn;
        private System.Windows.Forms.Button no_btn;
    }
}