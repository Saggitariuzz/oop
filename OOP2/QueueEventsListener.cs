using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public class QueueEventsListener
    {
        private TextBox tb;

        public QueueEventsListener(TelephoneExchangeQueue queue, TextBox _tb) 
        {
            tb = _tb;
            queue.ItemAdded += (message) => { tb.Text += message; };
            queue.ItemRemoved += (message) => { tb.Text += message; };
        }
    }
}
