using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6
{
    class FunctionAsync
    {

        private static double e = 0.0000000000000000000001;

        public async static Task Exponent(double x, TextBox tb)
        {
            await Task.Run(() =>
            {
                double u = 1;
                double sum = u;
                int i = 1;
                tb.Invoke((MethodInvoker)(() => {
                    tb.Text += $"Член ряда: {u.ToString("F2")}" + Environment.NewLine +
                    $"Сумма ряда: {sum.ToString("F2")}" +
                    Environment.NewLine;
                }));
                while (Math.Abs(u) >= e)
                {
                    Task.Delay(50).Wait();
                    u = (x / i) * u;
                    sum += u;
                    i++;
                    tb.Invoke((MethodInvoker)(() => { 
                        tb.Text += $"Член ряда: {u.ToString("F2")}" + Environment.NewLine +
                        $"Сумма ряда: {sum.ToString("F2")}" +
                        Environment.NewLine; }));
                }
                tb.Invoke((MethodInvoker)(() => {
                    tb.Text = $"Значение функции: {sum.ToString("F2")}" + Environment.NewLine + tb.Text;
                }));
            });
        }
    }
}
