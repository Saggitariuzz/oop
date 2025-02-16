using OOP1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP2
{
    public partial class Form1 : Form
    {
     
        private TelephoneExchangeQueue telephoneExchangeQueue;

        private QueueEventsListener queueEventsListener;

        public Form1()
        {
            InitializeComponent();
            telephoneExchangeQueue = new TelephoneExchangeQueue();
            queueEventsListener = new QueueEventsListener(telephoneExchangeQueue, tbEvents);
            lvMeasure.View = View.Details;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tbObjects.Clear();
            foreach(TelephoneExchange i in telephoneExchangeQueue.Queue)
            {
                tbObjects.Text += i.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            telephoneExchangeQueue.Enqueue(RandomValuesGenerator.CreateRandomTelephoneExchange());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            telephoneExchangeQueue.Dequeue();
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            lvMeasure.Items.Clear();
            ListViewItem listViewItemQueue = new ListViewItem("Очередь");
            listViewItemQueue.SubItems.Add(PerfomanceMeter.InsertInQueue().ToString());
            listViewItemQueue.SubItems.Add(PerfomanceMeter.QueueSelectSequential().ToString());
            listViewItemQueue.SubItems.Add(PerfomanceMeter.QueueSelectRandom().ToString());
            lvMeasure.Items.Add(listViewItemQueue);
            ListViewItem listViewItemArray = new ListViewItem("Массив");
            listViewItemArray.SubItems.Add(PerfomanceMeter.InsertInArray().ToString());
            listViewItemArray.SubItems.Add(PerfomanceMeter.ArraySelectSequential().ToString());
            listViewItemArray.SubItems.Add(PerfomanceMeter.ArraySelectRandom().ToString());
            lvMeasure.Items.Add(listViewItemArray);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
