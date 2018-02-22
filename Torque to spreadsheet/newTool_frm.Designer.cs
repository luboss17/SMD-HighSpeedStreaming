namespace WindowsFormsApplication1
{
    partial class newTool_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newTool_frm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.model_radioBtn = new System.Windows.Forms.RadioButton();
            this.tool_radioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Controls.Add(this.ok_btn);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.model_radioBtn);
            this.groupBox1.Controls.Add(this.tool_radioBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Tool/Model";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(94, 94);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(6, 94);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 4;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(69, 56);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // model_radioBtn
            // 
            this.model_radioBtn.AutoSize = true;
            this.model_radioBtn.Location = new System.Drawing.Point(115, 19);
            this.model_radioBtn.Name = "model_radioBtn";
            this.model_radioBtn.Size = new System.Drawing.Size(54, 17);
            this.model_radioBtn.TabIndex = 1;
            this.model_radioBtn.TabStop = true;
            this.model_radioBtn.Text = "Model";
            this.model_radioBtn.UseVisualStyleBackColor = true;
            this.model_radioBtn.Visible = false;
            // 
            // tool_radioBtn
            // 
            this.tool_radioBtn.AutoSize = true;
            this.tool_radioBtn.Location = new System.Drawing.Point(6, 19);
            this.tool_radioBtn.Name = "tool_radioBtn";
            this.tool_radioBtn.Size = new System.Drawing.Size(46, 17);
            this.tool_radioBtn.TabIndex = 0;
            this.tool_radioBtn.TabStop = true;
            this.tool_radioBtn.Text = "Tool";
            this.tool_radioBtn.UseVisualStyleBackColor = true;
            // 
            // newTool_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 154);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newTool_frm";
            this.Text = "New Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton model_radioBtn;
        private System.Windows.Forms.RadioButton tool_radioBtn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
    }
}