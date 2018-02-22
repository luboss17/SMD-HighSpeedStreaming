namespace WindowsFormsApplication1
{
    partial class FormAddDualRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDualRun));
            this.label1 = new System.Windows.Forms.Label();
            this.chan1Name_Label = new System.Windows.Forms.Label();
            this.runNameText = new System.Windows.Forms.TextBox();
            this.chan1NameText = new System.Windows.Forms.TextBox();
            this.chan2NameText = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.chan2Name_Label = new System.Windows.Forms.Label();
            this.runNameError = new System.Windows.Forms.Label();
            this.Chan1NameError = new System.Windows.Forms.Label();
            this.Chan2NameError = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Run Name";
            // 
            // chan1Name_Label
            // 
            this.chan1Name_Label.AutoSize = true;
            this.chan1Name_Label.Location = new System.Drawing.Point(15, 55);
            this.chan1Name_Label.Name = "chan1Name_Label";
            this.chan1Name_Label.Size = new System.Drawing.Size(73, 13);
            this.chan1Name_Label.TabIndex = 1;
            this.chan1Name_Label.Text = "blah blah blah";
            // 
            // runNameText
            // 
            this.runNameText.Location = new System.Drawing.Point(152, 12);
            this.runNameText.Name = "runNameText";
            this.runNameText.Size = new System.Drawing.Size(100, 20);
            this.runNameText.TabIndex = 3;
            this.runNameText.TextChanged += new System.EventHandler(this.runNameText_TextChanged);
            // 
            // chan1NameText
            // 
            this.chan1NameText.Location = new System.Drawing.Point(152, 52);
            this.chan1NameText.Name = "chan1NameText";
            this.chan1NameText.Size = new System.Drawing.Size(100, 20);
            this.chan1NameText.TabIndex = 4;
            // 
            // chan2NameText
            // 
            this.chan2NameText.Location = new System.Drawing.Point(152, 111);
            this.chan2NameText.Name = "chan2NameText";
            this.chan2NameText.Size = new System.Drawing.Size(100, 20);
            this.chan2NameText.TabIndex = 5;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(164, 177);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 23);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_Click);
            // 
            // chan2Name_Label
            // 
            this.chan2Name_Label.AutoSize = true;
            this.chan2Name_Label.Location = new System.Drawing.Point(15, 114);
            this.chan2Name_Label.Name = "chan2Name_Label";
            this.chan2Name_Label.Size = new System.Drawing.Size(73, 13);
            this.chan2Name_Label.TabIndex = 2;
            this.chan2Name_Label.Text = "blah blah blah";
            // 
            // runNameError
            // 
            this.runNameError.AutoSize = true;
            this.runNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runNameError.ForeColor = System.Drawing.Color.Red;
            this.runNameError.Location = new System.Drawing.Point(258, 16);
            this.runNameError.Name = "runNameError";
            this.runNameError.Size = new System.Drawing.Size(51, 16);
            this.runNameError.TabIndex = 8;
            this.runNameError.Text = "label2";
            // 
            // Chan1NameError
            // 
            this.Chan1NameError.AutoSize = true;
            this.Chan1NameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chan1NameError.ForeColor = System.Drawing.Color.Red;
            this.Chan1NameError.Location = new System.Drawing.Point(258, 56);
            this.Chan1NameError.Name = "Chan1NameError";
            this.Chan1NameError.Size = new System.Drawing.Size(51, 16);
            this.Chan1NameError.TabIndex = 9;
            this.Chan1NameError.Text = "label3";
            // 
            // Chan2NameError
            // 
            this.Chan2NameError.AutoSize = true;
            this.Chan2NameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chan2NameError.ForeColor = System.Drawing.Color.Red;
            this.Chan2NameError.Location = new System.Drawing.Point(258, 115);
            this.Chan2NameError.Name = "Chan2NameError";
            this.Chan2NameError.Size = new System.Drawing.Size(51, 16);
            this.Chan2NameError.TabIndex = 10;
            this.Chan2NameError.Text = "label4";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(164, 215);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // FormAddDualRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 261);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.Chan2NameError);
            this.Controls.Add(this.Chan1NameError);
            this.Controls.Add(this.runNameError);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.chan2NameText);
            this.Controls.Add(this.chan1NameText);
            this.Controls.Add(this.runNameText);
            this.Controls.Add(this.chan2Name_Label);
            this.Controls.Add(this.chan1Name_Label);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddDualRun";
            this.Text = "Add New Run";
            this.Load += new System.EventHandler(this.FormAddDualRun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chan1Name_Label;
        private System.Windows.Forms.TextBox runNameText;
        private System.Windows.Forms.TextBox chan1NameText;
        private System.Windows.Forms.TextBox chan2NameText;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label chan2Name_Label;
        private System.Windows.Forms.Label runNameError;
        private System.Windows.Forms.Label Chan1NameError;
        private System.Windows.Forms.Label Chan2NameError;
        private System.Windows.Forms.Button cancel_btn;
    }
}