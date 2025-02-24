using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.FactoryMethod
{
    public class DigitalTelephoneExchangeCompany: Company
    {
        public override ITelephoneExchange CreateEmptyTelephoneExchange()
        {
            return new DigitalTelephoneExchange();
        }

        public override ITelephoneExchange CreateRandomTelephoneExchange()
        {
            return new DigitalTelephoneExchange(
                RandomValuesGenerator.GetRandomAddress(),
                RandomValuesGenerator.GetRandomNumberOfUsers(),
                RandomValuesGenerator.GetRandomPayment(),
                RandomValuesGenerator.GetRandomIsWorking(),
                RandomValuesGenerator.GetRandomDateTime(),
                RandomValuesGenerator.GetRandomDataTransferRate(),
                RandomValuesGenerator.GetRandomProtocol()
            );
        }
    }
}
