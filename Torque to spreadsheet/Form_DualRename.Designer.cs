namespace WindowsFormsApplication1
{
    partial class Form_DualRename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DualRename));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_runName = new System.Windows.Forms.Label();
            this.newRunName_text = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.runNameList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.error_chan1 = new System.Windows.Forms.Label();
            this.newChan1NameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.error_chan2 = new System.Windows.Forms.Label();
            this.newChan2NameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Run Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Run";
            // 
            // error_runName
            // 
            this.error_runName.AutoSize = true;
            this.error_runName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_runName.ForeColor = System.Drawing.Color.Red;
            this.error_runName.Location = new System.Drawing.Point(318, 81);
            this.error_runName.Name = "error_runName";
            this.error_runName.Size = new System.Drawing.Size(30, 13);
            this.error_runName.TabIndex = 6;
            this.error_runName.Text = "Run";
            // 
            // newRunName_text
            // 
            this.newRunName_text.Location = new System.Drawing.Point(164, 78);
            this.newRunName_text.Name = "newRunName_text";
            this.newRunName_text.Size = new System.Drawing.Size(121, 20);
            this.newRunName_text.TabIndex = 2;
            this.newRunName_text.TextChanged += new System.EventHandler(this.newRunName_text_TextChanged);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(164, 210);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(35, 210);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 5;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // runNameList
            // 
            this.runNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runNameList.FormattingEnabled = true;
            this.runNameList.Location = new System.Drawing.Point(164, 31);
            this.runNameList.Name = "runNameList";
            this.runNameList.Size = new System.Drawing.Size(121, 21);
            this.runNameList.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "New Channel1 Name";
            // 
            // error_chan1
            // 
            this.error_chan1.AutoSize = true;
            this.error_chan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_chan1.ForeColor = System.Drawing.Color.Red;
            this.error_chan1.Location = new System.Drawing.Point(318, 123);
            this.error_chan1.Name = "error_chan1";
            this.error_chan1.Size = new System.Drawing.Size(30, 13);
            this.error_chan1.TabIndex = 13;
            this.error_chan1.Text = "Run";
            // 
            // newChan1NameText
            // 
            this.newChan1NameText.Location = new System.Drawing.Point(164, 120);
            this.newChan1NameText.Name = "newChan1NameText";
            this.newChan1NameText.Size = new System.Drawing.Size(121, 20);
            this.newChan1NameText.TabIndex = 3;
            this.newChan1NameText.TextChanged += new System.EventHandler(this.newChan1NameText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "New Channel2 Name";
            // 
            // error_chan2
            // 
            this.error_chan2.AutoSize = true;
            this.error_chan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_chan2.ForeColor = System.Drawing.Color.Red;
            this.error_chan2.Location = new System.Drawing.Point(318, 163);
            this.error_chan2.Name = "error_chan2";
            this.error_chan2.Size = new System.Drawing.Size(30, 13);
            this.error_chan2.TabIndex = 16;
            this.error_chan2.Text = "Run";
            // 
            // newChan2NameText
            // 
            this.newChan2NameText.Location = new System.Drawing.Point(164, 160);
            this.newChan2NameText.Name = "newChan2NameText";
            this.newChan2NameText.Size = new System.Drawing.Size(121, 20);
            this.newChan2NameText.TabIndex = 4;
            this.newChan2NameText.TextChanged += new System.EventHandler(this.newChan2NameText_TextChanged);
            // 
            // Form_DualRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.error_chan2);
            this.Controls.Add(this.newChan2NameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.error_chan1);
            this.Controls.Add(this.newChan1NameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error_runName);
            this.Controls.Add(this.newRunName_text);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.runNameList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DualRename";
            this.Text = "Rename Dual Channel Run";
            this.Load += new System.EventHandler(this.Form_DualRename_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error_runName;
        private System.Windows.Forms.TextBox newRunName_text;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.ComboBox runNameList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error_chan1;
        private System.Windows.Forms.TextBox newChan1NameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label error_chan2;
        private System.Windows.Forms.TextBox newChan2NameText;
    }
}