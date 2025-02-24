using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.FactoryMethod
{
    public class AnalogTelephoneExchange: TelephoneExchange
    {
        public string SwitchingTechnology { get; set; }

        public int MaxLineLength { get; set; }

        public AnalogTelephoneExchange() : base() { }

        public AnalogTelephoneExchange(string address, int numberofusers,
            decimal payment, bool isworking, DateTime date, string switchingtechnology, int maxlinelength):
            base(address, numberofusers, payment, isworking, date)
        {
            SwitchingTechnology = switchingtechnology;
            MaxLineLength = maxlinelength;
        }

        public override string ToString()
        {
            return
                "Аналоговая АТС" + Environment.NewLine + base.ToString() +
                $"Технология коммутация: {SwitchingTechnology}" + Environment.NewLine +
                $"Максимальная длина абонентской линии (м): {MaxLineLength}" + Environment.NewLine;
        }
    }
}
