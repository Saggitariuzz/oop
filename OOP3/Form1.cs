using OOP3.FactoryMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    public partial class MainForm : Form
    {
        private List<ITelephoneExchange> telephoneExchanges = new List<ITelephoneExchange>();

        private AnalogTelephoneExchangeCompany analogTelephoneExchangeCompany = new AnalogTelephoneExchangeCompany();

        private DigitalTelephoneExchangeCompany digitalTelephoneExchangeCompany = new DigitalTelephoneExchangeCompany();

        public MainForm()
        {
            InitializeComponent();
            cbListOfTypes.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (cbListOfTypes.SelectedIndex)
            {
                case 0:
                    telephoneExchanges.Add(analogTelephoneExchangeCompany.CreateRandomTelephoneExchange());
                    break;
                case 1:
                    telephoneExchanges.Add(digitalTelephoneExchangeCompany.CreateRandomTelephoneExchange());
                    break;
                default:
                    MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            tbListOfObjects.Clear();
            foreach(ITelephoneExchange i in telephoneExchanges)
            {
                tbListOfObjects.Text += i.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            telephoneExchanges.Clear();
            tbListOfObjects.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
