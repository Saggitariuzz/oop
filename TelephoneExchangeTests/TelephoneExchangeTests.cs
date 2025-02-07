using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP1;
using System;

namespace TelephoneExchangeTests
{
    [TestClass]
    public class TelephoneExchangeTests
    {

        private TelephoneExchange telephoneExchange;

        [TestMethod]
        public void OneParameterConstructorTest()
        {
            string expected = "test";
            telephoneExchange = new TelephoneExchange(expected);
            Assert.AreEqual(expected, telephoneExchange.Address);
        }

        [TestMethod]
        public void TwoParametersConstructorTest()
        {
            string strexpected = "test";
            decimal decexpected = 780.5m;
            telephoneExchange = new TelephoneExchange(strexpected, decexpected);
            Assert.AreEqual(strexpected, telephoneExchange.Address);
            Assert.AreEqual(decexpected, telephoneExchange.Payment);
        }

        [TestMethod]
        public void AllParametersConstructorTest()
        {
            string addressexpected = "address_test";
            decimal payexpected = 780.5m;
            string typeexpected = "type_test";
            int numberofusersexpected = 100;
            string[] protocolsexpected = new string[] { "1_test", "2_test" };
            DateTime dateexpected = new DateTime(2025, 1, 1);
            bool isworkingexpected = true;
            telephoneExchange = new TelephoneExchange(
                addressexpected, numberofusersexpected, payexpected, typeexpected, protocolsexpected, dateexpected, isworkingexpected);
            Assert.AreEqual(addressexpected, telephoneExchange.Address);
            Assert.AreEqual(payexpected, telephoneExchange.Payment);
            Assert.AreEqual(typeexpected, telephoneExchange.Type);
            Assert.AreEqual(protocolsexpected, telephoneExchange.Protocols);
            Assert.AreEqual(numberofusersexpected, telephoneExchange.NumberOfUsers);
            Assert.AreEqual(dateexpected, telephoneExchange.Date);
            Assert.AreEqual(isworkingexpected, telephoneExchange.IsWorking);
        }

        [TestMethod]
        public void CountTest()
        {
            var telephoneEchange1 = new TelephoneExchange();
            var telephoneExchange2 = new TelephoneExchange("test");
            Assert.AreEqual(2, TelephoneExchange.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNumberOfUsersTest()
        {
            telephoneExchange = new TelephoneExchange();
            telephoneExchange.NumberOfUsers = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativePaymentTest()
        {
            telephoneExchange = new TelephoneExchange();
            telephoneExchange.Payment = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectProtocolException))]
        public void IncorrectProtocolsTest()
        {
            telephoneExchange = new TelephoneExchange();
            telephoneExchange.Protocols = new string[] { "123", " ", "" };
        }

        [TestMethod]
        [ExpectedException(typeof(DateException))]
        public void IncorrectDateTest()
        {
            telephoneExchange = new TelephoneExchange();
            telephoneExchange.Date = DateTime.Now.AddDays(1);
        }

        [TestMethod]
        public void HexNumberTest()
        {
            int num = 255;
            string expected = num.ToString("X");
            telephoneExchange = new TelephoneExchange();
            telephoneExchange.NumberOfUsers = num;
            Assert.AreEqual(expected, telephoneExchange.GetHexNumberOfUsers());
        }

        [TestMethod]
        public void ToStringTest()
        {
            string address = "Test Address";
            int numberOfUsers = 100;
            decimal payment = 50.5m;
            string type = "Машинная";
            string[] protocols = { "Protocol1", "Protocol2" };
            DateTime date = new DateTime(2000, 1, 1);
            bool isWorking = true;
            telephoneExchange = new TelephoneExchange(address, numberOfUsers, payment, type, protocols, date, isWorking);
            string expected = "Автоматическая телефонная станция" + Environment.NewLine +
                              $"Адрес: {address}" + Environment.NewLine +
                              $"Число абонентов: {numberOfUsers}. В шестнадцатиричной форме: {numberOfUsers.ToString("X")}" + Environment.NewLine +
                              $"Абонентская плата за месяц: {payment:F2}" + Environment.NewLine +
                              $"Тип АТС: {type}" + Environment.NewLine +
                              $"Протоколы, используемые АТС: Protocol1, Protocol2" + Environment.NewLine +
                              $"Дата ввода АТС в эксплуатацию: {date:dd.MM.yyyy}" + Environment.NewLine +
                              $"Активна ли АТС в данный момент: Да" + Environment.NewLine +
                              $"Количество созданных объектов класса: 1" + Environment.NewLine;
            Assert.AreEqual(expected, telephoneExchange.ToString());
        }
    }
}
