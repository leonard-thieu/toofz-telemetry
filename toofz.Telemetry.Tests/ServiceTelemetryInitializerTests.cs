using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace toofz.Telemetry.Tests
{
    class ServiceTelemetryInitializerTests
    {
        [TestClass]
        public class Initialize
        {
            [TestMethod]
            public void SetsVersion()
            {
                // Arrange
                var eventTelemetry = new EventTelemetry("name");
                var telemetryInitializer = new ServiceTelemetryInitializer();

                // Act
                telemetryInitializer.Initialize(eventTelemetry);

                // Assert
                Assert.IsNotNull(eventTelemetry.Context.Component.Version);
            }

            [TestMethod]
            public void SetsSessionId()
            {
                // Arrange
                var eventTelemetry = new EventTelemetry("name");
                var telemetryInitializer = new ServiceTelemetryInitializer();

                // Act
                telemetryInitializer.Initialize(eventTelemetry);

                // Assert
                Assert.IsNotNull(eventTelemetry.Context.Session.Id);
            }
        }
    }
}
