using System;

namespace OOP5.Interpreter.Commands
{
    public class HoldCommand: IExpression
    {
        private readonly IExpression expression;

        private readonly IExpression callid;

        public HoldCommand(IExpression expression, IExpression callid)
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
            return "Выполнено: HOLD." + Environment.NewLine +
                $"Удержано {callid}";
        }
    }
}
