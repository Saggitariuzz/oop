using System;
using System.Data;
using System.Linq;

namespace OOP1
{
    public class TelephoneExchange
    {
        //Адрес АТС
        private string address;

        //Число абонентов
        private int numberOfUsers;

        //Абонентская плата за месяц
        private decimal payment;

        //Тип АТС
        private string type;

        //Оператор связи АТС
        private string[] protocols;

        //Дата ввода АТС в эксплуатацию
        private DateTime date;

        //Активна или не активна в данный момент
        private bool isWorking;

        //Подсчет количества созданных объектов
        private static int count = 0;

        public string Address { get => address; set => address = value; }

        public int NumberOfUsers
        {
            get => numberOfUsers;
            set
            {
                if (value < 0) throw new ArgumentException("Количество абонентов не может быть меньше 0");
                numberOfUsers = value;
            }
        }

        public decimal Payment
        {
            get => payment;
            set
            {
                if (value < 0) throw new ArgumentException("Абонентская плата не может быть меньше 0");
                payment = value;
            }
        }
        public string Type { get => type; set => type = value; }

        public string[] Protocols
        {
            get => protocols;
            set
            {
                string incorrectprotocol = value.FirstOrDefault(item => string.IsNullOrWhiteSpace(item));
                if (incorrectprotocol != null)
                    throw new IncorrectProtocolException(Array.IndexOf(value, incorrectprotocol) + 1);
                protocols = value;
            }
        }

        public DateTime Date
        {
            get => date;
            set
            {
                DateTime now = DateTime.Now;
                DateTime end = new DateTime(1891, 6, 10);
                if (value > now || value < end) throw new DateException(end, now);
                date = value;
            }
        }

        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public static int Count { get => count; }

        //Конструктор без параметров
        public TelephoneExchange()
        {
            count++;
        }

        //Конструктор с одним параметром
        public TelephoneExchange(string _address) : this()
        {
            Address = _address;
        }

        //Конструктор с двумя параметрами
        public TelephoneExchange(string _address, decimal _payment) : this(_address)
        {
            Payment = _payment;
        }

        //Конструктор с количеством параметров, равным количеству полей класса
        public TelephoneExchange(string _address, int _numberOfUsers, decimal _payment, string _type,
            string[] _protocols, DateTime _date, bool _isWorking) : this(_address, _payment)
        {
            NumberOfUsers = _numberOfUsers;
            Type = _type;
            Protocols = _protocols;
            Date = _date;
            IsWorking = _isWorking;
        }

        //Переопределение метода ToString()
        public override string ToString()
        {
            return
                "Автоматическая телефонная станция" + Environment.NewLine +
                $"Адрес: {Address}" + Environment.NewLine +
                $"Число абонентов: {NumberOfUsers}. " +
                $"В шестнадцатиричной форме: {GetHexNumberOfUsers()}" + Environment.NewLine +
                $"Абонентская плата за месяц: {Payment.ToString("F2")}" + Environment.NewLine +
                $"Тип АТС: {Type}" + Environment.NewLine +
                $"Протоколы, используемые АТС: {string.Join(", ", Protocols)}" + Environment.NewLine +
                $"Дата ввода АТС в эксплуатацию: {Date.ToString("dd.MM.yyyy")}" + Environment.NewLine +
                $"Активна ли АТС в данный момент: {(IsWorking ? "Да" : "Нет")}" + Environment.NewLine +
                $"Количество созданных объектов класса: {Count}" + Environment.NewLine;
        }

        //Перевод числа абонентов в шестнадцатиричный вид
        public string GetHexNumberOfUsers()
        {
            return NumberOfUsers.ToString("X");
        }
    }
}
