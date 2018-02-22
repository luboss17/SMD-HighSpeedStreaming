namespace WindowsFormsApplication1
{
    partial class Form_setForceAutoClear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_setForceAutoClear));
            this.label1 = new System.Windows.Forms.Label();
            this.interval_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto Clear Interval";
            // 
            // interval_txt
            // 
            this.interval_txt.Location = new System.Drawing.Point(112, 74);
            this.interval_txt.Name = "interval_txt";
            this.interval_txt.Size = new System.Drawing.Size(100, 20);
            this.interval_txt.TabIndex = 1;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(31, 129);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 23);
            this.submit_btn.TabIndex = 2;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "s";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(137, 129);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note: This will force Auto Clear regardless of Auto Clear Setting within Tester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "To avoid conflict, please make sure Auto Clear Setting within Tester is set to OF" +
    "F";
            // 
            // Form_setForceAutoClear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 177);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.interval_txt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_setForceAutoClear";
            this.Text = "Set Auto Clear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox interval_txt;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}