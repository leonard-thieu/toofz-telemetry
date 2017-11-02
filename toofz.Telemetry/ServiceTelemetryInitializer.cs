using System;
using System.Reflection;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace toofz.Telemetry
{
    public sealed class ServiceTelemetryInitializer : ITelemetryInitializer
    {
        private static readonly string Version = Assembly.GetCallingAssembly().GetName().Version.ToString();
        private static readonly string SessionId = Guid.NewGuid().ToString();

        public void Initialize(ITelemetry telemetry)
        {
            var context = telemetry.Context;

            context.Component.Version = Version;
            context.Session.Id = SessionId;
        }
    }
}
