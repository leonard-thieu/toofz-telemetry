# toofz Telemetry [![Build status](https://ci.appveyor.com/api/projects/status/180jggt6xnfkyfht/branch/master?svg=true)](https://ci.appveyor.com/project/leonard-thieu/toofz-telemetry/branch/master) [![codecov](https://codecov.io/gh/leonard-thieu/toofz-telemetry/branch/master/graph/badge.svg)](https://codecov.io/gh/leonard-thieu/toofz-telemetry)

## Getting started

### Installation

Create `NuGet.Config` in your **solution folder**.

`NuGet.Config`

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="AppVeyor - toofz.Telemetry" value="https://ci.appveyor.com/nuget/toofz-telemetry-ic7g3nub6jx6" />
  </packageSources>
</configuration>
```

Restart Visual Studio. `AppVeyor - toofz.Telemetry` will now show up as a package source in NuGet Package Manager. Select `AppVeyor - toofz.Telemetry` as the package source. Install the `toofz.Telemetry` package.

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
