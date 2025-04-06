using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6
{
    public class VectorAsync
    {
        public static async Task<List<int>> CreateRandomVector(int size, int min, int max)
        {
            return await Task.Run(() =>
            {
                Random rnd = new Random();
                List<int> list = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    list.Add(rnd.Next(min, max));
                }
                return list;
            });

        }
        public async static Task MinimumAsync(List<int> list, TextBox tb)
        {
            await Task.Run( () =>
            {
                int min = list[0];
                string vector = tb.Text;
                tb.Invoke((MethodInvoker)(() => {
                    tb.Text = $"Текущее минимальное: {min}" + Environment.NewLine + vector;
                }));
                Task.Delay(10).Wait();
                for (int i = 1; i < list.Count; i++)
                {
                    Task.Delay(1).Wait();
                    if (list[i] < min)
                    {
                        min = list[i];
                        tb.Invoke((MethodInvoker)(() => {
                            tb.Text = $"Текущее минимальное: {min}" + Environment.NewLine + vector;
                        }));
                    }
                }
                tb.Invoke((MethodInvoker)(() => {
                    tb.Text = $"Минимальное значение: {min}" + Environment.NewLine + vector;
                }));
            });
        }
    }
}
