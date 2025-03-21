using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6
{
    public class VectorAsync
    {

        private static List<double> list = new List<double> { 4.2, 6.8, 9.6, 7.1 };

        public async static Task VectorMedianAsync(TextBox tb)
        {
            await Task.Run(async () =>
            {
                await Task.Delay(2000);
                if (list.Count == 0)
                {
                    tb.Invoke((MethodInvoker)(() =>
                        { tb.Text = string.Empty; }));
                }
                list.Sort();
                if (list.Count % 2 == 1)
                {
                    tb.Invoke((MethodInvoker)(() =>
                        { tb.Text = list[list.Count / 2].ToString("F2"); }));
                }
                else
                {
                    tb.Invoke((MethodInvoker)(() =>
                    {
                        tb.Text =
                            (0.5 * (list[list.Count / 2 - 1] + list[list.Count / 2])).ToString("F2");
                    }));
                }
            });
        }
    }
}
