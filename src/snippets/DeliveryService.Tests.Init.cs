using NUnit.Framework;
using Twizzar.Fixture;
using PotionDeliveryService.Interfaces;
using PotionDeliveryService;
using System;

namespace PotionDeliveryService.Tests
{
    [TestFixture]
    public class DeliveryServiceTests
    {
        [Test]
        [TestSource(nameof(DeliveryService.Deliver))]
        public void Deliver_PotionIsAvailable_PackageIsSendToDestination()
        {
            // Arrange
            var sut = new ItemBuilder<DeliveryService>().Build();
            var potionName = new ItemBuilder<string>().Build();
            var destination = new ItemBuilder<IDestination>().Build();

            // Act
            sut.Deliver(potionName, destination);

            // Assert
            Assert.Fail();
        }
    }
}
