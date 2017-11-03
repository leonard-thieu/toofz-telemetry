using Microsoft.ApplicationInsights.DataContracts;
using Xunit;

namespace toofz.Telemetry.Tests
{
    public class CloudRoleNameTelemetryInitializerTests
    {
        public class Initialize
        {
            [Fact]
            public void SetsCloudRoleName()
            {
                // Arrange
                var cloudRoleName = "myRole";

                var eventTelemetry = new EventTelemetry("name");
                var telemetryInitializer = new CloudRoleNameTelemetryInitializer() { CloudRoleName = cloudRoleName };

                // Act
                telemetryInitializer.Initialize(eventTelemetry);

                // Assert
                Assert.Equal(cloudRoleName, eventTelemetry.Context.Cloud.RoleName);
            }
        }
    }
}
