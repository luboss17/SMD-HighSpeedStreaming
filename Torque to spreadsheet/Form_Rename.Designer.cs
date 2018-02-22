namespace WindowsFormsApplication1
{
    partial class FormRename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRename));
            this.runNameList = new System.Windows.Forms.ComboBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.newName_text = new System.Windows.Forms.TextBox();
            this.error_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runNameList
            // 
            this.runNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runNameList.FormattingEnabled = true;
            this.runNameList.Location = new System.Drawing.Point(114, 46);
            this.runNameList.Name = "runNameList";
            this.runNameList.Size = new System.Drawing.Size(121, 21);
            this.runNameList.TabIndex = 0;
            this.runNameList.SelectedIndexChanged += new System.EventHandler(this.runNameList_SelectedIndexChanged);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(31, 173);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 2;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(160, 173);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // newName_text
            // 
            this.newName_text.Location = new System.Drawing.Point(114, 93);
            this.newName_text.Name = "newName_text";
            this.newName_text.Size = new System.Drawing.Size(121, 20);
            this.newName_text.TabIndex = 1;
            this.newName_text.TextChanged += new System.EventHandler(this.newName_text_TextChanged);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(53, 133);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 13);
            this.error_label.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Run";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Name";
            // 
            // FormRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.newName_text);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.runNameList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRename";
            this.Text = "Rename Run";
            this.Load += new System.EventHandler(this.Form_Rename_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox runNameList;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox newName_text;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}