using OOP1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public delegate void QueueChanged(string message);

    public class TelephoneExchangeQueue
    {

        public Queue<TelephoneExchange> Queue { get; private set; }

        public event QueueChanged ItemAdded;

        public event QueueChanged ItemRemoved;

        public TelephoneExchangeQueue()
        {
            Queue = new Queue<TelephoneExchange>();
        }

        public TelephoneExchangeQueue(Queue<TelephoneExchange> queue)
        {
            Queue = queue;
        }

        public void Enqueue(TelephoneExchange item)
        {
            Queue.Enqueue(item);
            ItemAdded?.Invoke($"Элемент добавлен на позицию {Queue.Count - 1}" + Environment.NewLine);
        }

        public TelephoneExchange Dequeue()
        {
            if(Queue.Count > 0 )
            {
                ItemRemoved?.Invoke($"Элемент с позиции {Queue.Count} удален" + Environment.NewLine);
                return Queue.Dequeue();
            }
            return null;
        }
    }
}
