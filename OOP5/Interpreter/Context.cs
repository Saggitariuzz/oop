using System.Collections.Generic;

namespace OOP5.Interpreter
{
    public class Context
    {
        public string Input { get; set; } = string.Empty;

        public List<string> Output { get; set; } = new List<string>();

    }
}
