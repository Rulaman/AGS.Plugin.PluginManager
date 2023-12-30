using PluginManager.View.Interfaces;
using System;
using System.Windows.Forms;

namespace PluginManager.View
{
    public partial class PluginInfoView : UserControl
    {
        public PluginInfoView()
        {
            InitializeComponent();

            AddMouseMethods(Controls);
        }

        private IPluginInfo dataContext;
        public IPluginInfo DataContext
        {
            set
            {
                if (dataContext != null)
                {
                    Icon.DataBindings.Clear();
                    PackageName.DataBindings.Clear();
                    Description.DataBindings.Clear();
                    InstalledVersion.DataBindings.Clear();
                    NewestVersion.DataBindings.Clear();

                    Deprecated.DataBindings.Clear();
                    DownloadPackage.DataBindings.Clear();
                    UpdatePackage.DataBindings.Clear();
                    DeletePackage.DataBindings.Clear();
                }

                dataContext = value;

                if (dataContext != null)
                {
                    var iconBind = new Binding("BackgroundImage", dataContext, nameof(IPluginInfo.Icon), false, DataSourceUpdateMode.Never, null);
                    Icon.DataBindings.Add(iconBind);

                    var nameBind = new Binding("Text", dataContext, nameof(IPluginInfo.Name), false, DataSourceUpdateMode.Never, null);
                    PackageName.DataBindings.Add(nameBind);

                    var descBind = new Binding("Text", dataContext, nameof(IPluginInfo.Description), false, DataSourceUpdateMode.Never, null);
                    Description.DataBindings.Add(descBind);

                    var instBind = new Binding("Text", dataContext, nameof(IPluginInfo.InstalledVersion), false, DataSourceUpdateMode.Never, null);
                    InstalledVersion.DataBindings.Add(instBind);

                    var newBind = new Binding("Text", dataContext, nameof(IPluginInfo.NewestVersion), false, DataSourceUpdateMode.Never, null);
                    NewestVersion.DataBindings.Add(newBind);


                    var deprecatedBind = new Binding("Visible", dataContext, nameof(IPluginInfo.Deprecated), false, DataSourceUpdateMode.Never, null);
                    Deprecated.DataBindings.Add(deprecatedBind);

                    var downBind = new Binding("Visible", dataContext, nameof(IPluginInfo.Installed), false, DataSourceUpdateMode.Never, null);
                    downBind.Format += (sender, e) => e.Value = !((bool)e.Value); // invert the checked value
                    DownloadPackage.DataBindings.Add(downBind);

                    var updateBind = new Binding("Visible", dataContext, nameof(IPluginInfo.NewerVersionAvailable), false, DataSourceUpdateMode.Never, null);
                    UpdatePackage.DataBindings.Add(updateBind);

                    var deleteBind = new Binding("Visible", dataContext, nameof(IPluginInfo.Installed), false, DataSourceUpdateMode.Never, null);
                    DeletePackage.DataBindings.Add(deleteBind);

                    var isInstalledBind = new Binding("Visible", dataContext, nameof(IPluginInfo.Installed), false, DataSourceUpdateMode.Never, null);
                    IsInstalled.DataBindings.Add(isInstalledBind);
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            flowLayoutPanel4.Visible = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            flowLayoutPanel4.Visible = false;
        }


        private void Child_MouseLeave(object sender, EventArgs e)
        {
            if (!IsChild((Control)sender))
            {
                flowLayoutPanel4.Visible = false;
                Console.WriteLine($"{((Control)sender).Name} Leave");
            }
        }

        private void Child_MouseEnter(object sender, EventArgs e)
        {
            flowLayoutPanel4.Visible = true;
            Console.WriteLine($"{((Control)sender).Name} Enter");
        }

        private void AddMouseMethods(ControlCollection collection)
        {
            foreach (Control child in collection)
            {
                if (child.Controls != null && child.Controls.Count > 0)
                {
                    AddMouseMethods(child.Controls);
                }

                child.MouseEnter += Child_MouseEnter;
                child.MouseLeave += Child_MouseLeave;
            }
        }

        private bool IsChild(Control control)
        {
            return control.IsChildOf(this);
        }
    }

    public static class ControlExtension
    {
        public static bool IsChildOf(this Control c, Control parent)
        {
            return ((c.Parent != null && c.Parent == parent) || (c.Parent != null ? c.Parent.IsChildOf(parent) : false));
        }
    }
}
