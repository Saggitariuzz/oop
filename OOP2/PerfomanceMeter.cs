using OOP1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class PerfomanceMeter
    {
        private static Stopwatch stopwatch = new Stopwatch();

        private static Random rnd = new Random();

        private const int size = 100000;

        //Для сохранения выборки
        public static List<TelephoneExchange> TelephoneExchangeList { get; private set; } = new List<TelephoneExchange>();

        private static TelephoneExchangeQueue telephoneExchangeQueue = new TelephoneExchangeQueue();

        private static TelephoneExchange[] telephoneExchanges = new TelephoneExchange[size];

        public static int InsertInQueue()
        {
            stopwatch.Reset();
            stopwatch.Start();
            for(int i = 0; i < size; i++)
            {
                telephoneExchangeQueue.Enqueue(RandomValuesGenerator.CreateRandomTelephoneExchange());
            }
            stopwatch.Stop();
            return (int)stopwatch.ElapsedMilliseconds;
        }

        public static int InsertInArray()
        {
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < size; i++)
            {
                telephoneExchanges[i] = RandomValuesGenerator.CreateRandomTelephoneExchange();
            }
            stopwatch.Stop();
            return (int)stopwatch.ElapsedMilliseconds;
        }
        
        public static int QueueSelectSequential()
        {
            TelephoneExchangeList.Clear();
            stopwatch.Reset();
            stopwatch.Start();
            while(telephoneExchangeQueue.Queue.Count > 0)
            {
                TelephoneExchangeList.Add(telephoneExchangeQueue.Dequeue());
            }
            stopwatch.Stop();
            return (int)stopwatch.ElapsedMilliseconds;
        }

        public static int ArraySelectSequential()
        {
            TelephoneExchangeList.Clear();
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < size; i++)
            {
                TelephoneExchangeList.Add(telephoneExchanges[i]);
            }
            stopwatch.Stop();
            return (int)stopwatch.ElapsedMilliseconds;
        }

        //Очередь не поддерживает случайную выборку
        public static int QueueSelectRandom()
        {
            TelephoneExchangeList.Clear();
            InsertInQueue();
            stopwatch.Reset();
            stopwatch.Start();
            var queueArray = telephoneExchangeQueue.Queue.ToArray();
            for(int i = 0; i < size; i++)
            {
                TelephoneExchangeList.Add(queueArray[rnd.Next(size - 1)]);
            }
            stopwatch.Stop();
            return (int)stopwatch.ElapsedMilliseconds;
        }

        public static int ArraySelectRandom()
        {
            TelephoneExchangeList.Clear();
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < size; i++)
            {
                TelephoneExchangeList.Add(telephoneExchanges[rnd.Next(size - 1)]);
            }
            stopwatch.Stop();
            return (int)stopwatch.ElapsedMilliseconds;
        }
    }
}
