﻿namespace PluginManager.Host
{
    partial class Form1
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
            this.pluginView1 = new PluginManager.View.PluginView();
            this.SuspendLayout();
            // 
            // pluginView1
            // 
            this.pluginView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pluginView1.ContentDocument = null;
            this.pluginView1.DockingContainer = null;
            this.pluginView1.Location = new System.Drawing.Point(12, 12);
            this.pluginView1.Name = "pluginView1";
            this.pluginView1.Size = new System.Drawing.Size(1073, 513);
            this.pluginView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 537);
            this.Controls.Add(this.pluginView1);
            this.Name = "Form1";
            this.Text = "PluginManager-Standalone";
            this.ResumeLayout(false);

        }

        #endregion

        private View.PluginView pluginView1;
    }
}

