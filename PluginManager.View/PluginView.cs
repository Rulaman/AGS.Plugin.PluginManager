using AGS.Types;
using PluginManager.View.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace PluginManager.View
{
    public partial class PluginView : EditorContentPanel
    {
        public PluginView()
        {
            InitializeComponent();

            var x1 = new XY();
            x1.InstalledVersion = "0.9.0";
            x1.NewestVersion = "1.0";
            x1.NewerVersionAvailable = true;
            x1.Deprecated = false;
            x1.Description = "Description";
            x1.Installed = true;
            x1.Name = "Name";
            x1.Icon = new Bitmap(32, 32);
            var g = Graphics.FromImage(x1.Icon);
            g.FillRectangle(new SolidBrush(Color.Red), 0, 0, 32, 32);

            pluginInfoView1.DataContext = x1;


            var x2 = new XY();
            x2.InstalledVersion = "1.0.0";
            x2.NewestVersion = "1.0";
            x2.NewerVersionAvailable = false;
            x2.Deprecated = false;
            x2.Description = "Description 2";
            x2.Installed = false;
            x2.Name = "Name 2";
            x2.Icon = new Bitmap(32, 32);
            var g2 = Graphics.FromImage(x2.Icon);
            g2.FillRectangle(new SolidBrush(Color.Blue), 0, 0, 32, 32);

            pluginInfoView2.DataContext = x2;
        }
    }

    internal class XY : IPluginInfo
    {
        public Bitmap Icon { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string InstalledVersion { get; set; }

        public string NewestVersion { get; set; }

        public bool Deprecated { get; set; }

        public bool Installed { get; set; }

        public bool NewerVersionAvailable { get; set; }

        public event EventHandler OnDownload;
        public event EventHandler OnDelete;
        public event EventHandler OnUpdate;
    }
}
