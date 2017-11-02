# toofz Telemetry

[![Build status](https://ci.appveyor.com/api/projects/status/180jggt6xnfkyfht/branch/master?svg=true)](https://ci.appveyor.com/project/leonard-thieu/toofz-telemetry/branch/master)
[![codecov](https://codecov.io/gh/leonard-thieu/toofz-telemetry/branch/master/graph/badge.svg)](https://codecov.io/gh/leonard-thieu/toofz-telemetry)
[![MyGet](https://img.shields.io/myget/toofz/v/toofz.Telemetry.svg)](https://www.myget.org/feed/toofz/package/nuget/toofz.Telemetry)

## Getting started

### Installation

Create `NuGet.Config` in your **solution folder**.

`NuGet.Config`

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="toofz" value="https://www.myget.org/F/toofz/api/v3/index.json" />
  </packageSources>
</configuration>
```

Restart Visual Studio. `toofz` will now show up as a package source in NuGet Package Manager. Select `toofz` as the package source. Search for and install the `toofz.Telemetry` package.

![Installing toofz.Telemetry](https://user-images.githubusercontent.com/5265970/29636122-78baab74-881d-11e7-8f8a-f033b32462d4.png)

### Usage

#### CloudRoleNameTelemetryInitializer

`CloudRoleNameTelemetryInitializer` configures the name of a component in a multi-component application. The name can be used to filter telemetry and is displayed on the component in a multi-component Application map.

`ApplicationInsights.config`

```xml
<?xml version="1.0" encoding="utf-8"?>
<ApplicationInsights xmlns="http://schemas.microsoft.com/ApplicationInsights/2013/Settings">
  <TelemetryInitializers>
    <Add Type="toofz.Telemetry.CloudRoleNameTelemetryInitializer, toofz.Telemetry">
      <CloudRoleName>My Cloud Role Name</CloudRoleName>
    </Add>
  </TelemetryInitializers>
</ApplicationInsights>
```

`toofz` and `toofz API` are components in a multi-component application.

![App map](https://user-images.githubusercontent.com/5265970/29636238-e67320ec-881d-11e7-909e-750cee9a0242.png)

#### ServiceTelemetryInitializer

`ServiceTelemetryInitializer` adds the version of the calling assembly and a session ID to telemetry.

`ApplicationInsights.config`

```xml
<?xml version="1.0" encoding="utf-8"?>
<ApplicationInsights xmlns="http://schemas.microsoft.com/ApplicationInsights/2013/Settings">
  <TelemetryInitializers>
    <Add Type="toofz.Telemetry.ServiceTelemetryInitializer, toofz.Telemetry" />
  </TelemetryInitializers>
</ApplicationInsights>
```
