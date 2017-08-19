﻿using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace toofz.Telemetry.Tests
{
    class CloudRoleNameTelemetryInitializerTests
    {
        [TestClass]
        public class Initialize
        {
            [TestMethod]
            public void SetsCloudRoleName()
            {
                // Arrange
                var cloudRoleName = "myRole";

                var eventTelemetry = new EventTelemetry("name");
                var telemetryInitializer = new CloudRoleNameTelemetryInitializer() { CloudRoleName = cloudRoleName };

                // Act
                telemetryInitializer.Initialize(eventTelemetry);

                // Assert
                Assert.AreEqual(cloudRoleName, eventTelemetry.Context.Cloud.RoleName);
            }
        }
    }
}
