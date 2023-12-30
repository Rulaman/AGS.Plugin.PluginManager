namespace AGS.Plugin.PluginManager

open AGS.Types
open System.Drawing


type Manager (host: IAGSEditor) as this =
    let COMPONENT_ID = "Manager-Plugin"
    let COMPONENT_MENU_COMMAND = "Manager-MenuCommand"
    let CONTROL_ID_ROOT_NODE = "Manager-Root"
    let ICON_KEY = "Manager-Icon"
    let TREE_ROOT_NAME = "PluginManager"

    let assembly = System.Reflection.Assembly.GetExecutingAssembly()
    let stream = assembly.GetManifestResourceStream("AGS.Plugin.PluginManager.Resources.icon-16.ico")
    let icon = new Icon(stream)

    let _ = host.GUIController.RegisterIcon(ICON_KEY, icon)
    let _ = host.GUIController.ProjectTree.AddTreeRoot(this, CONTROL_ID_ROOT_NODE, TREE_ROOT_NAME, ICON_KEY)
    let _ = host.GUIController.ProjectTree.add_BeforeShowContextMenu(fun(evArgs) -> this.ProjectTree_BeforeShowContextMenu(evArgs))

    let pane = new PluginManager.View.PluginView()
    let document = new ContentDocument(pane, "Plugin manager", this, ICON_KEY)

    interface IEditorComponent with
        member _.BeforeSaveGame(): unit =
            ()

        member _.CommandClick(controlID: string): unit =
            if CONTROL_ID_ROOT_NODE = controlID then
                host.GUIController.AddOrShowPane(document)
                ()
            else
                ()


        member _.ComponentID: string = COMPONENT_ID

        member _.EditorShutdown(): unit =
            ()

        member _.FromXml(node: System.Xml.XmlNode): unit =
            ()

        member _.GameSettingsChanged(): unit =
            ()

        member _.GetContextMenu(controlID: string): System.Collections.Generic.IList<MenuCommand> =
            null

        member _.PropertyChanged(propertyName: string, oldValue: obj): unit =
            ()

        member _.RefreshDataFromGame(): unit =
            ()

        member _.ToXml(writer: System.Xml.XmlTextWriter): unit =
            ()


    member _.LocalHost = host

    member _.ProjectTree_BeforeShowContextMenu(evArgs: BeforeShowContextMenuEventArgs) =
        //let nodeId = evArgs.SelectedNodeID;
        ()

    member this.MenuCommand = host.GUIController.CreateMenuCommand(this, COMPONENT_MENU_COMMAND, "Manage plugins")


[<RequiredAGSVersion("3.0.0.0")>]
type PluginLoader (host: IAGSEditor) =
    let myplugin = new Manager(host)
    let _ = host.AddComponent(myplugin)

    interface IAGSEditorPlugin with
        member _.Dispose(): unit = ()
