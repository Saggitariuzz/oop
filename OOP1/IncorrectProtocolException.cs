using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class IncorrectProtocolException : ArrayTypeMismatchException
    {
        public IncorrectProtocolException():base("Некорректное название протокола!"){ }

        public IncorrectProtocolException(int index) : base($"Некорректное название протокола! Ошибка в протоколе номер {index}.") { }
    }
}
