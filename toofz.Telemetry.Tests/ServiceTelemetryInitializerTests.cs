using Microsoft.ApplicationInsights.DataContracts;
using Xunit;

namespace toofz.Telemetry.Tests
{
    public class ServiceTelemetryInitializerTests
    {
        public class Initialize
        {
            [Fact]
            public void SetsVersion()
            {
                // Arrange
                var eventTelemetry = new EventTelemetry("name");
                var telemetryInitializer = new ServiceTelemetryInitializer();

                // Act
                telemetryInitializer.Initialize(eventTelemetry);

                // Assert
                Assert.NotNull(eventTelemetry.Context.Component.Version);
            }

            [Fact]
            public void SetsSessionId()
            {
                // Arrange
                var eventTelemetry = new EventTelemetry("name");
                var telemetryInitializer = new ServiceTelemetryInitializer();

                // Act
                telemetryInitializer.Initialize(eventTelemetry);

                // Assert
                Assert.NotNull(eventTelemetry.Context.Session.Id);
            }
        }
    }
}
