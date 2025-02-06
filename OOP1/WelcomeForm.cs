using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class WelcomeForm : Form
    {

        private TelephoneExchange telephoneExchange;

        public WelcomeForm()
        {
            InitializeComponent();
            telephoneExchange = new TelephoneExchange(
                "г.Пенза, ул. Клары Цеткин, 63А",
                17641,
                780.5m,
                "Программная",
                new string[] { "SIP", "PRI" },
                new DateTime(1999, 2, 6),
                true
                );
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(this, telephoneExchange);
            mainForm.Show();
            Hide();
        }
    }
}
