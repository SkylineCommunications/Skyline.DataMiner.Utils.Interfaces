# Skyline.DataMiner.Utils.Interfaces

## About

Skyline.DataMiner.Utils.Interfaces is a package available in the public [nuget store](https://www.nuget.org/) that contain assemblies that handle logic related to data source interfaces (e.g. Switch Ports, Router Ethernet, ...).

These can be used for example, to calculate Utilizations on a port from a provided bitrate.

## Requirements

The "DataMiner Integration Studio" Visual Studio extension is required for development of connectors and Automation scripts using NuGets.

See [Installing DataMiner Integration Studio](https://aka.dataminer.services/DisInstallation)

> [!IMPORTANT]
> NuGets are mandatory to be installed with PackageReferences. DIS was redesigned to work with PackageReferences and be future-proof. 
>
> For more information on how to migrate from packages.config to PackageReferences, see [docs.microsoft.com](https://docs.microsoft.com/en-us/nuget/consume-packages/migrate-packages-config-to-package-reference).

## Getting started

Calls to Interfaces are currently static and can be accessed through the Interface class.

```cs
double result = Interface.CalculateUtilization(1500, 2000, 5000, DuplexStatus.FullDuplex);
```
