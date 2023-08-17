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

Install-Package ParusRx.Data.Core -Version 1.0.0-preview.2.5807923165.4

```

#### .NET CLI

```bash

dotnet add package ParusRx.Data.Core --version 1.0.0-preview.2.5807923165.4

```

#### PackageReference

```xml

<PackageReference Include="ParusRx.Data.Core" Version="1.0.0-preview.2.5807923165.4" />

```

#### Paket CLI

```bash

paket add ParusRx.Data.Core --version 1.0.0-preview.2.5807923165.4

```


## Contributing

This repo builds the following NuGet packages:

| Package | Description | NuGet |
| ------- | ----------- | ----- |
| [ParusRx.Data.Core](https://www.nuget.org/packages/ParusRx.Data.Core/) | The core implementation for data access providers in Parus RX. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Data.Core?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Data.Core/) |
| [ParusRx.Data.Oracle](https://www.nuget.org/packages/ParusRx.Data.Oracle/) | Provider for Oracle Database in Parus RX. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Data.Oracle?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Data.Oracle/) |
| [ParusRx.Data.PostgreSql](https://www.nuget.org/packages/ParusRx.Data.PostgreSQL/) | Provider for PostgreSQL Database in Parus RX. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Data.PostgreSql?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Data.PostgreSql/) |
| [ParusRx.EventBus.Abstractions](https://www.nuget.org/packages/ParusRx.EventBus.Abstractions/) | Provides Event Bus abstractions for Parus RX. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.EventBus.Abstractions?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.EventBus.Abstractions/) |
| [ParusRx.EventBus](https://www.nuget.org/packages/ParusRx.EventBus/) | Provides Event Bus for Parus RX. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.EventBus?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.EventBus/) |
| [ParusRx.EventBus.Dapr](https://www.nuget.org/packages/ParusRx.EventBus.Dapr/) | The implementation of the Event Bus for Parus RX by Dapr. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.EventBus.Dapr?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.EventBus.Dapr/) |
| [ParusRx.EventBus.MultiTenancy](https://www.nuget.org/packages/ParusRx.EventBus.MultiTenancy/) | Provides Event Bus with Multi-Tenancy for Parus RX. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.EventBus.MultiTenancy?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.EventBus.MultiTenancy/) |
| [ParusRx.MultiTenancy](https://www.nuget.org/packages/ParusRx.MultiTenancy/) | Provides Multi-Tenancy for Parus RX. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.MultiTenancy?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.MultiTenancy/) |
| [ParusRx.Storage.Abstractions](https://www.nuget.org/packages/ParusRx.Storage.Abstractions/) | Storage abstractions for Parus RX. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Storage.Abstractions?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Storage.Abstractions/) |
| [ParusRx.Storage.Oracle](https://www.nuget.org/packages/ParusRx.Storage.Oracle/) | Provides Storage for Oracle Database to Parus RX. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Storage.Oracle?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Storage.Oracle/) |
| [ParusRx.Storage.PostgreSql](https://www.nuget.org/packages/ParusRx.Storage.PostgreSql/) | PostgreSQL storage implementation | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Storage.PostgreSql?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Storage.Postgres/) |
| [ParusRx.Xml](https://www.nuget.org/packages/ParusRx.Xml/) | Provides classes for working with XML for Parus RX. | [![NuGet Info](https://buildstats.info/nuget/ParusRx.Xml?includePreReleases=true)](https://www.nuget.org/packages/ParusRx.Xml/) |

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
| [ParusRx.Storage.PostgreSql](https://www.nuget.org/packages/ParusRx.Storage.Postgres/) | ✔ | ✔ | ✔ | ✔ | ✔ |
| [ParusRx.Xml](https://www.nuget.org/packages/ParusRx.Xml/) | ✔ | ✔ | ✔ | ✔ | ✔ |

> **Note:** 
> **The Parus RX SDK for .NET is currently in preview.**