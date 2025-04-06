using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace OOP6
{
    internal class TimeAsync
    {

        private static bool isrunning = false;

        public async static Task SystemTimeAsync(TextBox tb)
        {
            if (isrunning)
            {
                return;
            }
            isrunning = true;
            await Task.Run( () =>
            {
                while (true)
                {
                    tb.Invoke((MethodInvoker)(() => { tb.Text = DateTime.Now.ToString("HH:mm:ss"); }));
                }
            });
        }
    }
}