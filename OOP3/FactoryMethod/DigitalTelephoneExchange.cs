using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.FactoryMethod
{
    public class DigitalTelephoneExchange: TelephoneExchange
    {
        public int DataTransferRate { get;set; }

        public string Protocol { get; set; }

        public DigitalTelephoneExchange() : base() { }

        public DigitalTelephoneExchange(string address, int numberofusers,
            decimal payment, bool isworking, DateTime date, int datatransferrate, string protocol): 
            base(address, numberofusers, payment, isworking, date)
        {
            DataTransferRate = datatransferrate;
            Protocol = protocol;
        }

        public override string ToString()
        {
            return
                "Цифровая АТС" + Environment.NewLine + base.ToString() +
                $"Скорость передачи данных (Мбит/c): {DataTransferRate}" + Environment.NewLine +
                $"Используемый протокол: {Protocol}" + Environment.NewLine;

        }
    }
}
