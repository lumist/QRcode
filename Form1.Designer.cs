namespace qrcode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateButton = new System.Windows.Forms.Button();
            this.RootPanel = new System.Windows.Forms.Panel();
            this.QrcodePanel = new System.Windows.Forms.Panel();
            this.GenerateText = new System.Windows.Forms.TextBox();
            this.RootPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(227, 16);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(109, 32);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "RandomGenerate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // RootPanel
            // 
            this.RootPanel.Controls.Add(this.QrcodePanel);
            this.RootPanel.Controls.Add(this.GenerateText);
            this.RootPanel.Controls.Add(this.GenerateButton);
            this.RootPanel.Location = new System.Drawing.Point(12, 12);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.Size = new System.Drawing.Size(437, 464);
            this.RootPanel.TabIndex = 1;
            // 
            // QrcodePanel
            // 
            this.QrcodePanel.Location = new System.Drawing.Point(19, 55);
            this.QrcodePanel.Name = "QrcodePanel";
            this.QrcodePanel.Size = new System.Drawing.Size(400, 400);
            this.QrcodePanel.TabIndex = 2;
            // 
            // GenerateText
            // 
            this.GenerateText.Location = new System.Drawing.Point(22, 23);
            this.GenerateText.Name = "GenerateText";
            this.GenerateText.Size = new System.Drawing.Size(189, 21);
            this.GenerateText.TabIndex = 1;
            this.GenerateText.Text = "       <Generate Text>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 488);
            this.Controls.Add(this.RootPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RootPanel.ResumeLayout(false);
            this.RootPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Panel RootPanel;
        private System.Windows.Forms.TextBox GenerateText;
        private System.Windows.Forms.Panel QrcodePanel;
    }
}

