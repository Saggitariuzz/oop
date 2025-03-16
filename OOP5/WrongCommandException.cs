using System;

namespace OOP5
{
    public class WrongCommandException: Exception
    {
        public WrongCommandException(): base("Некорректная команда.") { }

        public WrongCommandException(string message) : base(message) { }
    }
}
