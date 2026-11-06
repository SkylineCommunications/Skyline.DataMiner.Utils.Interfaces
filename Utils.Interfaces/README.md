# Skyline.DataMiner.Utils.Interfaces

## About

### About Skyline.DataMiner.Utils.Interfaces

Skyline.DataMiner.Utils.Interfaces is a package available in the public [nuget store](https://www.nuget.org/) that contain assemblies that handle logic related to data source interfaces (e.g. Switch Ports, Router Ethernet, ...).

These can be used for example, to calculate Utilizations on a port from a provided bitrate.

### About DataMiner

DataMiner is a transformational platform that provides vendor-independent control and monitoring of devices and services. Out of the box and by design, it addresses key challenges such as security, complexity, multi-cloud, and much more. It has a pronounced open architecture and powerful capabilities enabling users to evolve easily and continuously.

The foundation of DataMiner is its powerful and versatile data acquisition and control layer. With DataMiner, there are no restrictions to what data users can access. Data sources may reside on premises, in the cloud, or in a hybrid setup.

A unique catalog of 7000+ connectors already exist. In addition, you can leverage DataMiner Development Packages to build you own connectors (also known as "protocols" or "drivers").

> [!TIP]
> See also: [About DataMiner](https://aka.dataminer.services/about-dataminer)

### About Skyline Communications

At Skyline Communications, we deal in world-class solutions that are deployed by leading companies around the globe. Check out [our proven track record](https://aka.dataminer.services/about-skyline) and see how we make our customers' lives easier by empowering them to take their operations to the next level.

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
