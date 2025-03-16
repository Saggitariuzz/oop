using System;

namespace OOP5.Interpreter.Commands
{
    public class CallCommand: IExpression
    {

        private readonly IExpression expression;

        private readonly IExpression callid;

        public CallCommand(IExpression expression, IExpression callid)
        {
            this.expression = expression;
            this.callid = callid;
        }

        public void Interpret(Context context)
        {
            expression.Interpret(context);
            callid.Interpret(context);
        }

        public override string ToString()
        {
            return "Выполнено: CALL." + Environment.NewLine +
                $"Вызван {callid}";
        }
    }
}
