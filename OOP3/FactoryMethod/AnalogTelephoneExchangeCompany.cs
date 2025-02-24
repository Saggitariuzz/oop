using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3.FactoryMethod
{
    public class AnalogTelephoneExchangeCompany: Company
    {
        public override ITelephoneExchange CreateEmptyTelephoneExchange()
        {
            return new AnalogTelephoneExchange();
        }

        public override ITelephoneExchange CreateRandomTelephoneExchange()
        {
            return new AnalogTelephoneExchange(
                    RandomValuesGenerator.GetRandomAddress(),
                    RandomValuesGenerator.GetRandomNumberOfUsers(),
                    RandomValuesGenerator.GetRandomPayment(),
                    RandomValuesGenerator.GetRandomIsWorking(),
                    RandomValuesGenerator.GetRandomDateTime(),
                    RandomValuesGenerator.GetRandomSwitchingTechnology(),
                    RandomValuesGenerator.GetRandomMaxLineLength()
                );
        }
    }
}
