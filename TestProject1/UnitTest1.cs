using Helloworld.Controllers;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_Should_Return_Hello_World()
        {
            // Arrange
            //var controller = new HomeController();
            var controller = new HomeController();
            // Act
            var result = controller.Get();

            // Assert
            Assert.AreEqual("Hello, world!", result);
        }
    }
}