namespace WindowsFormsApplication1
{
    partial class getSaveAsTestSetupNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(getSaveAsTestSetupNameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.newTestName_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.error_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Test Name";
            // 
            // newTestName_txt
            // 
            this.newTestName_txt.Location = new System.Drawing.Point(114, 17);
            this.newTestName_txt.Name = "newTestName_txt";
            this.newTestName_txt.Size = new System.Drawing.Size(100, 20);
            this.newTestName_txt.TabIndex = 1;
            this.newTestName_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(newTestName_txt_KeyDown);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(15, 54);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(139, 54);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Location = new System.Drawing.Point(220, 20);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(28, 13);
            this.error_lbl.TabIndex = 4;
            this.error_lbl.Text = "error";
            // 
            // getSaveAsTestSetupNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 89);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.newTestName_txt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "getSaveAsTestSetupNameForm";
            this.Text = "Save As New Test Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newTestName_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label error_lbl;
    }
}