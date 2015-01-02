﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket.Core")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyDescriptionAttribute("A package dependency manager for .NET with support for NuGet packages and GitHub repositories.")>]
[<assembly: AssemblyVersionAttribute("0.20.15")>]
[<assembly: AssemblyFileVersionAttribute("0.20.15")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.20.15"
