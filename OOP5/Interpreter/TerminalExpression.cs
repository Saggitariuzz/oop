using System;

namespace OOP5.Interpreter
{
    public class TerminalExpression: IExpression
    {

        private readonly string token;

        public TerminalExpression(string token)
        {
            this.token = token;
        }

        public void Interpret(Context context)
        {
            if(context.Input.StartsWith(token, StringComparison.OrdinalIgnoreCase))
            {
                context.Output.Add(token);
                context.Input = context.Input.Substring(token.Length).Trim();
            }
        }

        public override string ToString()
        {
            return token;
        }
    }
}
