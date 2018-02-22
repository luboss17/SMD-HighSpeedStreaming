namespace WindowsFormsApplication1
{
    partial class FormAddRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRun));
            this.label1 = new System.Windows.Forms.Label();
            this.runName_text = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Run Name";
            // 
            // runName_text
            // 
            this.runName_text.Location = new System.Drawing.Point(78, 71);
            this.runName_text.Name = "runName_text";
            this.runName_text.Size = new System.Drawing.Size(108, 20);
            this.runName_text.TabIndex = 1;
            this.runName_text.TextChanged += new System.EventHandler(this.runName_text_TextChanged);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(89, 147);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 2;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(89, 188);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(75, 107);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 13);
            this.error_label.TabIndex = 4;
            // 
            // FormAddRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.runName_text);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddRun";
            this.Text = "Add New Run";
            this.Load += new System.EventHandler(this.FormAddRun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox runName_text;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label error_label;
    }
}