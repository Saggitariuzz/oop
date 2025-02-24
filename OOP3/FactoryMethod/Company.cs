using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.FactoryMethod
{
    public abstract class Company
    {
        public abstract ITelephoneExchange CreateRandomTelephoneExchange();

        public abstract ITelephoneExchange CreateEmptyTelephoneExchange();
    }
}
