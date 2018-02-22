namespace WindowsFormsApplication1
{
    partial class Form_DualDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DualDelete));
            this.cancel_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.runNameList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(68, 164);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(68, 114);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // runNameList
            // 
            this.runNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runNameList.FormattingEnabled = true;
            this.runNameList.Location = new System.Drawing.Point(68, 68);
            this.runNameList.Name = "runNameList";
            this.runNameList.Size = new System.Drawing.Size(121, 21);
            this.runNameList.TabIndex = 5;
            this.runNameList.SelectedIndexChanged += new System.EventHandler(this.runNameList_SelectedIndexChanged);
            // 
            // Form_DualDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.runNameList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DualDelete";
            this.Text = "Delete Run";
            this.Load += new System.EventHandler(this.Form_DualDelete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ComboBox runNameList;
    }
}