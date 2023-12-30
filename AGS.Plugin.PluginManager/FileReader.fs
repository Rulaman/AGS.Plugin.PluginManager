namespace AGS.Plugin.PluginManager

open Newtonsoft.Json
open System
open System.Net.Http
open System.Threading

module Reader =
    let getPackageInfoFromJsonContent(content) =
        let json = JsonConvert.DeserializeObject<PackageInfo>(content)
        json

    let getRepositoryInfoFromJsonContent(content) =
        let json = JsonConvert.DeserializeObject<RepositoryInfo>(content)
        json

    let getPluginInfoFromJsonContent(content) =
        let json = JsonConvert.DeserializeObject<PluginInfo>(content)
        json

    let getContentFromLocalFile (filePath) =
        System.IO.File.ReadAllText(filePath)

    let getContentFromWebLink(webLink: Uri, token: CancellationToken) =
        let client = new HttpClient()
        let result = client.GetAsync(webLink, token) |> Async.AwaitTask

        let content = result |> Async.RunSynchronously
        content.Content.ReadAsStringAsync() |> Async.AwaitTask |> Async.RunSynchronously
