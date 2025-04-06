using System.Text.RegularExpressions;

namespace OOP7.Models
{
    public class Call
    {
        private static int _idcount;

        public int Id { get; private set; }

        private string _phonefrom;

        public string PhoneFrom
        {
            get { return _phonefrom; }
            set
            {
                ValidatePhoneNumbers(value, _phoneto);
                _phonefrom = value;
            }
        }

        private string _phoneto;

        public string PhoneTo
        {
            get { return _phoneto; }
            set
            {
                ValidatePhoneNumbers(_phonefrom, value);
                _phoneto = value;
            }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value < new DateTime(2000, 1, 1) || value > DateTime.Now)
                {
                    throw new ArgumentException("Введена некорректная дата");
                }
                _date = value;
            }
        }

        private const string pattern =
            @"^(?:\+7\d{10}|\+7\(\d{3}\)\d{3}-\d{2}-\d{2}|8\d{10}|8\(\d{3}\)\d{7}|\d{6}|\d{2}-\d{2}-\d{2})$";

        public Call()
        {
            _idcount++;
            Id = _idcount;
            _phonefrom = string.Empty;
            _phoneto = string.Empty;
            _date = DateTime.MinValue;
        }

        public Call(string phonefrom, string phoneto, DateTime date)
        {
            ValidatePhoneNumbers(phonefrom, phoneto);
            _phonefrom = phonefrom;
            _phoneto = phoneto;
            Date = date;
            _idcount++;
            Id = _idcount;
        }

        private void ValidatePhoneNumbers(string phonefrom, string phoneto)
        {
            if (!Regex.IsMatch(phoneto, pattern) || !Regex.IsMatch(phonefrom, pattern))
            {
                throw new ArgumentException("Введны некорректные номера телефонов.");
            }
            if (phonefrom == phoneto)
            {
                throw new ArgumentException("Номера не могут совпадать.");
            }
        }
    }
}
