namespace SkypeSignal
{
    partial class FlashForm
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
            this.btn_Flash = new System.Windows.Forms.Button();
            this.fbd_FirmwareBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Flash
            // 
            this.btn_Flash.Location = new System.Drawing.Point(268, 73);
            this.btn_Flash.Name = "btn_Flash";
            this.btn_Flash.Size = new System.Drawing.Size(75, 23);
            this.btn_Flash.TabIndex = 0;
            this.btn_Flash.Text = "Flash";
            this.btn_Flash.UseVisualStyleBackColor = true;
            // 
            // fbd_FirmwareBrowse
            // 
            this.fbd_FirmwareBrowse.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.fbd_FirmwareBrowse.ShowNewFolderButton = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(268, 11);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            // 
            // FlashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 108);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Flash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlashForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Flash Skype Signal Firwmare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Flash;
        private System.Windows.Forms.FolderBrowserDialog fbd_FirmwareBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Browse;
    }
}