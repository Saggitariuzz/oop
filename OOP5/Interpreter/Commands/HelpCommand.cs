using System;

namespace OOP5.Interpreter.Commands
{
    public class HelpCommand: IExpression
    {

        private readonly IExpression expression;

        public HelpCommand(IExpression expression)
        {
            this.expression = expression;
        }

        public void Interpret(Context context)
        {
            expression.Interpret(context);  
        }

        public override string ToString()
        {
            return "СПИСОК КОМАНД:" + Environment.NewLine +
                "HOLD НОМЕР_ТЕЛЕФОНА - удержать звонок;" + Environment.NewLine +
                "TRANSFER НОМЕР_ТЕЛЕФОНА НОМЕР_ТЕЛЕФОНА - перевести звонок;" + Environment.NewLine +
                "CALL НОМЕР_ТЕЛЕФОНА - прозвонить номер.";
        }
    }
}
