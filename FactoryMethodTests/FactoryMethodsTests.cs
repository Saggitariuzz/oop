using OOP3.FactoryMethod;

namespace FactoryMethodTests
{
    [TestClass]
    public class FactoryMethodsTests
    {
        [TestMethod]
        public void AnalogFactoryTypeTest()
        {
            var analogFactory = new AnalogTelephoneExchangeCompany();
            Assert.IsInstanceOfType(analogFactory.CreateEmptyTelephoneExchange(), typeof(AnalogTelephoneExchange));
        }

        [TestMethod]
        public void DigitalFactoryTypeTest()
        {
            var digitalFactory = new DigitalTelephoneExchangeCompany();
            Assert.IsInstanceOfType(digitalFactory.CreateEmptyTelephoneExchange(), typeof (DigitalTelephoneExchange));
        }
    }
}