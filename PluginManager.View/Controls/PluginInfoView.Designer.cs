namespace PluginManager.View
{
    partial class PluginInfoView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PackageName = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.InstalledVersion = new System.Windows.Forms.Label();
            this.NewestVersion = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Deprecated = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.DownloadPackage = new System.Windows.Forms.Button();
            this.DeletePackage = new System.Windows.Forms.Button();
            this.UpdatePackage = new System.Windows.Forms.Button();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.IsInstalled = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Deprecated)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsInstalled)).BeginInit();
            this.SuspendLayout();
            // 
            // PackageName
            // 
            this.PackageName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageName.Location = new System.Drawing.Point(3, 0);
            this.PackageName.Name = "PackageName";
            this.PackageName.Size = new System.Drawing.Size(60, 16);
            this.PackageName.TabIndex = 1;
            this.PackageName.Text = "Name";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(3, 16);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 26);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description\r\nnext line";
            // 
            // InstalledVersion
            // 
            this.InstalledVersion.AutoSize = true;
            this.InstalledVersion.Location = new System.Drawing.Point(3, 0);
            this.InstalledVersion.Name = "InstalledVersion";
            this.InstalledVersion.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.InstalledVersion.Size = new System.Drawing.Size(40, 18);
            this.InstalledVersion.TabIndex = 0;
            this.InstalledVersion.Text = "8.8.8.8";
            this.InstalledVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NewestVersion
            // 
            this.NewestVersion.AutoSize = true;
            this.NewestVersion.Location = new System.Drawing.Point(3, 18);
            this.NewestVersion.Name = "NewestVersion";
            this.NewestVersion.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.NewestVersion.Size = new System.Drawing.Size(40, 18);
            this.NewestVersion.TabIndex = 0;
            this.NewestVersion.Text = "8.8.8.8";
            this.NewestVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.PackageName);
            this.flowLayoutPanel1.Controls.Add(this.Description);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(610, 52);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.InstalledVersion);
            this.flowLayoutPanel2.Controls.Add(this.NewestVersion);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(679, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(51, 52);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.Deprecated);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(654, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(22, 52);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // Deprecated
            // 
            this.Deprecated.BackgroundImage = global::PluginManager.View.Resource.deprecated;
            this.Deprecated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deprecated.Location = new System.Drawing.Point(3, 3);
            this.Deprecated.Name = "Deprecated";
            this.Deprecated.Size = new System.Drawing.Size(16, 16);
            this.Deprecated.TabIndex = 9;
            this.Deprecated.TabStop = false;
            this.Deprecated.Visible = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel4.Controls.Add(this.DownloadPackage);
            this.flowLayoutPanel4.Controls.Add(this.DeletePackage);
            this.flowLayoutPanel4.Controls.Add(this.UpdatePackage);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(733, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(22, 86);
            this.flowLayoutPanel4.TabIndex = 8;
            this.flowLayoutPanel4.Visible = false;
            // 
            // DownloadPackage
            // 
            this.DownloadPackage.BackgroundImage = global::PluginManager.View.Resource.download;
            this.DownloadPackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownloadPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadPackage.ForeColor = System.Drawing.Color.Transparent;
            this.DownloadPackage.Location = new System.Drawing.Point(3, 3);
            this.DownloadPackage.Name = "DownloadPackage";
            this.DownloadPackage.Size = new System.Drawing.Size(16, 16);
            this.DownloadPackage.TabIndex = 0;
            this.DownloadPackage.UseVisualStyleBackColor = true;
            // 
            // DeletePackage
            // 
            this.DeletePackage.BackgroundImage = global::PluginManager.View.Resource.delete;
            this.DeletePackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeletePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePackage.ForeColor = System.Drawing.Color.Transparent;
            this.DeletePackage.Location = new System.Drawing.Point(3, 25);
            this.DeletePackage.Name = "DeletePackage";
            this.DeletePackage.Size = new System.Drawing.Size(16, 16);
            this.DeletePackage.TabIndex = 0;
            this.DeletePackage.UseVisualStyleBackColor = true;
            // 
            // UpdatePackage
            // 
            this.UpdatePackage.BackgroundImage = global::PluginManager.View.Resource.update;
            this.UpdatePackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdatePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePackage.ForeColor = System.Drawing.Color.Transparent;
            this.UpdatePackage.Location = new System.Drawing.Point(3, 47);
            this.UpdatePackage.Name = "UpdatePackage";
            this.UpdatePackage.Size = new System.Drawing.Size(16, 16);
            this.UpdatePackage.TabIndex = 1;
            this.UpdatePackage.UseVisualStyleBackColor = true;
            // 
            // Icon
            // 
            this.Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Icon.Location = new System.Drawing.Point(3, 13);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(32, 32);
            this.Icon.TabIndex = 0;
            this.Icon.TabStop = false;
            // 
            // IsInstalled
            // 
            this.IsInstalled.BackgroundImage = global::PluginManager.View.Resource.installed;
            this.IsInstalled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IsInstalled.Location = new System.Drawing.Point(24, 39);
            this.IsInstalled.Name = "IsInstalled";
            this.IsInstalled.Size = new System.Drawing.Size(16, 16);
            this.IsInstalled.TabIndex = 9;
            this.IsInstalled.TabStop = false;
            // 
            // PluginInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IsInstalled);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Icon);
            this.MinimumSize = new System.Drawing.Size(100, 58);
            this.Name = "PluginInfoView";
            this.Size = new System.Drawing.Size(758, 58);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Deprecated)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsInstalled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Label PackageName;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label InstalledVersion;
        private System.Windows.Forms.Label NewestVersion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button DownloadPackage;
        private System.Windows.Forms.Button DeletePackage;
        private System.Windows.Forms.Button UpdatePackage;
        private System.Windows.Forms.PictureBox Deprecated;
        private System.Windows.Forms.PictureBox IsInstalled;
    }
}
