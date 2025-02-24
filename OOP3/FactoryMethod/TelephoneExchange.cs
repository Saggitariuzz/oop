using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.FactoryMethod
{
    public abstract class TelephoneExchange : ITelephoneExchange
    {
        public string Address { get; set; }

        public int NumberOfUsers { get; set; }

        public decimal Payment { get; set; }

        public bool IsWorking { get; set; }

        public DateTime Date { get; set; }

        protected TelephoneExchange(){}

        protected TelephoneExchange(string address, int numberofusers,
            decimal payment, bool isworking, DateTime date) {
            Address = address;
            NumberOfUsers = numberofusers;
            Payment = payment;
            IsWorking = isworking;
            Date = date;
        }

        public string GetHexNumberOfUsers()
        {
            return NumberOfUsers.ToString("X");
        }

        public override string ToString()
        {
            return
                $"Адрес: {Address}" + Environment.NewLine +
                $"Число абонентов: {NumberOfUsers}. " +
                $"В шестнадцатиричной форме: {GetHexNumberOfUsers()}" + Environment.NewLine +
                $"Абонентская плата за месяц: {Payment.ToString("F2")}" + Environment.NewLine +
                $"Дата ввода АТС в эксплуатацию: {Date.ToString("dd.MM.yyyy")}" + Environment.NewLine +
                $"Активна ли АТС в данный момент: {(IsWorking ? "Да" : "Нет")}" + Environment.NewLine;
        }
    }
}
