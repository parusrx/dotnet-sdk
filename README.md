# Parus RX SDK for .NET

[![Build](https://github.com/parusrx/dotnet-sdk/actions/workflows/build.yml/badge.svg)](https://github.com/parusrx/dotnet-sdk/actions/workflows/build.yml)
[![License](https://img.shields.io/github/license/parusrx/dotnet-sdk?logo=apache&style=flat-square&color=blue)](LICENSE)

Parus RX SDK for .NET is a project that provides a set of tools for Parus RX.

## Getting started

### Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/preview/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

The Parus RX SDK for .NET is available on [NuGet](https://www.nuget.org/packages?q=ParusRx).

#### Package Manager

```powershell

Install-Package ParusRx.Data.Core -Version 1.0.0-Preview1

```

#### .NET CLI

```bash

dotnet add package ParusRx.Data.Core --version 1.0.0-Preview1

```

#### PackageReference

```xml

<PackageReference Include="ParusRx.Data.Core" Version="1.0.0-Preview1" />

```

#### Paket CLI

```bash

paket add ParusRx.Data.Core --version 1.0.0-Preview1

```


## Contributing

This repo builds the following NuGet packages:

| Package | Description | NuGet |
| ------- | ----------- | ----- |
| [ParusRx.Data.Core](https://www.nuget.org/packages/ParusRx.Data.Core/) | Core data access library | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Data.Core?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Data.Core/) |
| [ParusRx.Data.Oracle](https://www.nuget.org/packages/ParusRx.Data.Oracle/) | Oracle data access library | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Data.Oracle?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Data.Oracle/) |
| [ParusRx.Data.PostgreSql](https://www.nuget.org/packages/ParusRx.Data.PostgreSQL/) | PostgreSQL data access library | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Data.PostgreSql?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Data.PostgreSql/) |
| [ParusRx.EventBus.Abstractions](https://www.nuget.org/packages/ParusRx.EventBus.Abstractions/) | Event bus abstractions | [![NuGet Info](https://buildstats.info/nuget/ParusRx.EventBus.Abstractions?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.EventBus.Abstractions/) |
| [ParusRx.EventBus](https://www.nuget.org/packages/ParusRx.EventBus/) | Event bus implementation | [![NuGet Info](https://buildstats.info/nuget/ParusRx.EventBus?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.EventBus/) |
| [ParusRx.EventBus.Dapr](https://www.nuget.org/packages/ParusRx.EventBus.Dapr/) | Dapr event bus implementation | [![NuGet Info](https://buildstats.info/nuget/ParusRx.EventBus.Dapr?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.EventBus.Dapr/) |
| [ParusRx.EventBus.MultiTenancy](https://www.nuget.org/packages/ParusRx.EventBus.MultiTenancy/) | Multi-tenancy event bus implementation | [![NuGet Info](https://buildstats.info/nuget/ParusRx.EventBus.MultiTenancy?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.EventBus.MultiTenancy/) |
| [ParusRx.MultiTenancy](https://www.nuget.org/packages/ParusRx.MultiTenancy/) | Multi-tenancy library | [![NuGet Info](https://buildstats.info/nuget/ParusRx.MultiTenancy?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.MultiTenancy/) |
| [ParusRx.Storage.Abstractions](https://www.nuget.org/packages/ParusRx.Storage.Abstractions/) | Storage abstractions | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Storage.Abstractions?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Storage.Abstractions/) |
| [ParusRx.Storage.Oracle](https://www.nuget.org/packages/ParusRx.Storage.Oracle/) | Oracle storage implementation | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Storage.Oracle?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Storage.Oracle/) |
| [ParusRx.Storage.Postgres](https://www.nuget.org/packages/ParusRx.Storage.Postgres/) | PostgreSQL storage implementation | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Storage.Postgres?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Storage.Postgres/) |
| [ParusRx.Xml](https://www.nuget.org/packages/ParusRx.Xml/) | XML library | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Xml?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Xml/) |

## Compatability matrix

The following table shows the compatability matrix for the Parus RX SDK v1.0.0-* for .NET.

| Package | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| ------- | -------- | -------- | -------- | 
| [ParusRx.Data.Core](https://www.nuget.org/packages/ParusRx.Data.Core/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.Data.Oracle](https://www.nuget.org/packages/ParusRx.Data.Oracle/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.Data.PostgreSql](https://www.nuget.org/packages/ParusRx.Data.PostgreSql/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.EventBus.Abstractions](https://www.nuget.org/packages/ParusRx.EventBus.Abstractions/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.EventBus](https://www.nuget.org/packages/ParusRx.EventBus/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.EventBus.Dapr](https://www.nuget.org/packages/ParusRx.EventBus.Dapr/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.EventBus.MultiTenancy](https://www.nuget.org/packages/ParusRx.EventBus.MultiTenancy/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.MultiTenancy](https://www.nuget.org/packages/ParusRx.MultiTenancy/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.Storage.Abstractions](https://www.nuget.org/packages/ParusRx.Storage.Abstractions/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.Storage.Oracle](https://www.nuget.org/packages/ParusRx.Storage.Oracle/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.Storage.Postgres](https://www.nuget.org/packages/ParusRx.Storage.Postgres/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.Xml](https://www.nuget.org/packages/ParusRx.Xml/) | ✔ | ✔ | ✔ | ✔ | ✔ |

> **Note:** 
> **The Parus RX SDK for .NET is currently in preview.**