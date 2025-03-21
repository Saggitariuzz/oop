using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace OOP6
{
    internal class TimeAsync
    {
        public async static Task SystemTimeAsync(TextBox tb)
        {
            await Task.Run(async () =>
            {
                await Task.Delay(3000);
                tb.Invoke((MethodInvoker)(() => { tb.Text = DateTime.Now.ToString("HH:mm:ss"); }));
            });
        }
    }
}