using System;
using System.Drawing;

namespace PluginManager.View.Interfaces
{
    public interface IPluginInfo
    {
        Bitmap Icon { get; }
        string Name { get; }
        string Description { get; }
        string InstalledVersion { get; }
        string NewestVersion { get; }
        bool Deprecated { get; }
        bool Installed {  get; }
        bool NewerVersionAvailable { get; }

        event EventHandler OnDownload;
        event EventHandler OnDelete;
        event EventHandler OnUpdate;
    }
}
