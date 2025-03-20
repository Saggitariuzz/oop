using OOP5.Interpreter;
using OOP5;
using OOP5.Interpreter.Commands;
namespace CommandsTest
{
    [TestClass]
    public sealed class CommandsTest
    {
        [TestMethod]
        [ExpectedException(typeof(WrongCommandException))]
        public void HelpCommandTest()
        {
            
        }
    }
}
