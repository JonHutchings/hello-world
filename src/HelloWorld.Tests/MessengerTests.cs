using System;
using NUnit.Framework;
// ReSharper disable ObjectCreationAsStatement

namespace HelloWorld.Tests
{
  [TestFixture]
  public class MessengerTests
  {
    [Test]
    public void Constructor_GivenNullMessage_ShouldThrowException()
    {
      // Arrange
      // Act
      // Assert
      Assert.Throws<ArgumentNullException>(() => new StockMessenger(null));
    }
  }
}