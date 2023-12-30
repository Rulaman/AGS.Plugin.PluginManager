namespace PluginManager.View
{
    partial class PluginView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pluginInfoView2 = new PluginManager.View.PluginInfoView();
            this.pluginInfoView1 = new PluginManager.View.PluginInfoView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 57);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1337, 304);
            this.splitContainer1.SplitterDistance = 879;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pluginInfoView2);
            this.panel1.Controls.Add(this.pluginInfoView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 304);
            this.panel1.TabIndex = 3;
            // 
            // pluginInfoView2
            // 
            this.pluginInfoView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pluginInfoView2.Location = new System.Drawing.Point(0, 58);
            this.pluginInfoView2.MinimumSize = new System.Drawing.Size(100, 58);
            this.pluginInfoView2.Name = "pluginInfoView2";
            this.pluginInfoView2.Size = new System.Drawing.Size(879, 58);
            this.pluginInfoView2.TabIndex = 1;
            // 
            // pluginInfoView1
            // 
            this.pluginInfoView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pluginInfoView1.Location = new System.Drawing.Point(0, 0);
            this.pluginInfoView1.MinimumSize = new System.Drawing.Size(100, 58);
            this.pluginInfoView1.Name = "pluginInfoView1";
            this.pluginInfoView1.Size = new System.Drawing.Size(879, 58);
            this.pluginInfoView1.TabIndex = 1;
            // 
            // PluginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PluginView";
            this.Size = new System.Drawing.Size(1343, 647);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PluginInfoView pluginInfoView1;
        private PluginInfoView pluginInfoView2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
    }
}
