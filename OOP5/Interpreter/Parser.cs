using OOP5.Interpreter.Commands;
using System.Text.RegularExpressions;

namespace OOP5.Interpreter
{
    public class Parser
    {
        private const string pattern =
            @"^(?:\+7\d{10}|\+7\(\d{3}\)\d{3}-\d{2}-\d{2}|8\d{10}|8\(\d{3}\)\d{7}|\d{6}|\d{2}-\d{2}-\d{2})$";

        public static IExpression Parse(string line)
        {
            string[] args = line.Split(' ');
            if(args.Length == 0)
            {
                throw new WrongCommandException("Сначала введите команду!");
            }
            switch(args[0])
            {
                case "HELP":
                    if(args.Length != 1)
                    {
                        throw new WrongCommandException(
                            "Неверное количество аргументов у команды HELP. Требуется аргументов: 0");
                    }
                    return new HelpCommand(
                            new TerminalExpression(args[0])
                        );
                case "HOLD":
                    if(args.Length != 2)
                    {
                        throw new WrongCommandException(
                            "Неверное количество аргументов у команды HOLD. Требуется аргументов: 1");
                    }
                    if (!Regex.IsMatch(args[1], pattern))
                    {
                        throw new WrongCommandException("Неправильно введен номер");
                    }
                    return new HoldCommand(
                            new TerminalExpression(args[0]),
                            new TerminalExpression(args[1])
                        );
                case "CALL":
                    if (args.Length != 2)
                    {
                        throw new WrongCommandException(
                            "Неверное количество аргументов у команды CALL. Требуется аргументов: 1");
                    }
                    if (!Regex.IsMatch(args[1], pattern))
                    {
                        throw new WrongCommandException("Неправильно введен номер");
                    }
                    return new CallCommand(
                            new TerminalExpression(args[0]),
                            new TerminalExpression(args[1])
                        );
                case "TRANSFER":
                    if (args.Length != 3)
                    {
                        throw new WrongCommandException(
                            "Неверное количество аргументов у команды TRANSFER. Требуется аргументов: 2");
                    }
                    if (!Regex.IsMatch(args[1], pattern) || !Regex.IsMatch(args[2], pattern))
                    {
                        throw new WrongCommandException("Неправильно введен номер");
                    }
                    return new TransferCommand(
                            new TerminalExpression(args[0]),
                            new TerminalExpression(args[1]),
                            new TerminalExpression(args[2])
                        );
                default:
                    throw new WrongCommandException();
            }
        }

    }
}
