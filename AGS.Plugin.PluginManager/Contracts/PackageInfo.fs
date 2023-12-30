namespace AGS.Plugin.PluginManager

open System

type RepositoryState =
    | Unknown = 0
    | Active = 1
    | Unmaintained = 2
    | Deprecated = 3
    | Blocked = 4

type PluginState = Unknown = 0 | Normal = 1 | Preliminary = 2 | Deprecated = 3

type Repository = {
    Name: string
    State: RepositoryState
    Url: string
}

type VersionInfo = {
    Version: string
    State: PluginState
    Url: string
    Author: string
    License: string
    ReleaseDate: DateTime
}

type Plugin = {
    Name: string
    Description: String
    ProjectUrl: string
    Versions: VersionInfo list
}

type PackageInfo = {
    Repositories: Repository list
    Plugins: Plugin list
}

type RepositoryInfo = {
    Repositories: Repository list
}

type PluginInfo = {
    Plugins: Plugin list
}
