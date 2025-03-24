using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6
{
    public class VectorAsync
    {
        public static List<int> CreateRandomVector(int size, int min, int max)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for(int i = 0; i < size; i++)
            {
                list.Add(rnd.Next(min, max));
            }
            return list;
        }
        public async static Task VectorMedianAsync(TextBox tb, List<int> list)
        {
            await Task.Run(async () =>
            {
                await Task.Delay(2000);
                if (list.Count == 0)
                {
                    tb.Invoke((MethodInvoker)(() =>
                        { tb.Text += string.Empty; }));
                }
                list.Sort();
                if (list.Count % 2 == 1)
                {
                    tb.Invoke((MethodInvoker)(() =>
                        { tb.Text += list[list.Count / 2].ToString("F2"); }));
                }
                else
                {
                    tb.Invoke((MethodInvoker)(() =>
                    {
                        tb.Text +=
                            (0.5 * (list[list.Count / 2 - 1] + list[list.Count / 2])).ToString("F2");
                    }));
                }
            });
        }
    }
}
