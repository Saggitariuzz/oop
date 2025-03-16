using System;

namespace OOP5.Interpreter.Commands
{
    public class TransferCommand: IExpression
    {

        private readonly IExpression expression;

        private readonly IExpression from_callid;

        private readonly IExpression to_callid;

        public TransferCommand(IExpression expression, IExpression from_callid, IExpression to_callid)
        {
            this.expression = expression;
            this.from_callid = from_callid;
            this.to_callid = to_callid;
        }

        public void Interpret(Context context)
        {
            expression.Interpret(context);
            from_callid.Interpret(context);
            to_callid.Interpret(context);
        }

        public override string ToString()
        {
            return "Выполнено: TRANSFER." + Environment.NewLine +
                $"Звонок переведен от {from_callid} на {to_callid}";
        }
    }
}
