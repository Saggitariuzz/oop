using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6
{
    class FunctionAsync
    {
        public async static Task f(double x, TextBox tb)
        {
            await Task.Run( async () =>
            {
                await Task.Delay(3000);
                tb.Invoke((MethodInvoker)(() => { tb.Text += (x * x * x - 2 * x * x + 3 * x - 5).ToString("F2"); }));
            });
        }
    }
}
