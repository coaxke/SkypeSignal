namespace SkypeSignal
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_PartyTime = new System.Windows.Forms.Button();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.llbl_ResdevOps = new System.Windows.Forms.LinkLabel();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.Logo_PictureBox);
            this.LogoPanel.Location = new System.Drawing.Point(3, 4);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(210, 314);
            this.LogoPanel.TabIndex = 0;
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Logo_PictureBox.Image")));
            this.Logo_PictureBox.Location = new System.Drawing.Point(3, 3);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(204, 308);
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(426, 266);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(73, 27);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_PartyTime
            // 
            this.btn_PartyTime.Location = new System.Drawing.Point(308, 266);
            this.btn_PartyTime.Name = "btn_PartyTime";
            this.btn_PartyTime.Size = new System.Drawing.Size(112, 27);
            this.btn_PartyTime.TabIndex = 2;
            this.btn_PartyTime.Text = "Party Time!!!";
            this.btn_PartyTime.UseVisualStyleBackColor = true;
            this.btn_PartyTime.Click += new System.EventHandler(this.btn_PartyTime_Click);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(223, 9);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(83, 13);
            this.lbl_ProductName.TabIndex = 3;
            this.lbl_ProductName.Text = "{Product Name}";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(223, 31);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(50, 13);
            this.lbl_Version.TabIndex = 4;
            this.lbl_Version.Text = "{Version}";
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.AutoSize = true;
            this.lbl_Copyright.Location = new System.Drawing.Point(223, 54);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(293, 13);
            this.lbl_Copyright.TabIndex = 5;
            this.lbl_Copyright.Text = "Copyright © 2016 Patrick S (ResdevOps). All rights reserved.";
            // 
            // llbl_ResdevOps
            // 
            this.llbl_ResdevOps.AutoSize = true;
            this.llbl_ResdevOps.Location = new System.Drawing.Point(223, 250);
            this.llbl_ResdevOps.Name = "llbl_ResdevOps";
            this.llbl_ResdevOps.Size = new System.Drawing.Size(142, 13);
            this.llbl_ResdevOps.TabIndex = 6;
            this.llbl_ResdevOps.TabStop = true;
            this.llbl_ResdevOps.Text = "https://www.resdevops.com";
            this.llbl_ResdevOps.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_ResdevOps_LinkClicked);
            // 
            // tb_Description
            // 
            this.tb_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Description.Location = new System.Drawing.Point(226, 86);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.ReadOnly = true;
            this.tb_Description.Size = new System.Drawing.Size(273, 161);
            this.tb_Description.TabIndex = 7;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 290);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.llbl_ResdevOps);
            this.Controls.Add(this.lbl_Copyright);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.btn_PartyTime);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.LogoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About ResevOps SkypeSignal";
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_PartyTime;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Copyright;
        private System.Windows.Forms.LinkLabel llbl_ResdevOps;
        private System.Windows.Forms.TextBox tb_Description;
    }
}

