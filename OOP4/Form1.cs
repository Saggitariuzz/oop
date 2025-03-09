using OOP4.Composite;
using OOP4.Composite.Composites;
using OOP4.Composite.Leafs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelephoneExchange telephoneExchange = new TelephoneExchange();
            telephoneExchange.Add(new CallControlSystem());
            telephoneExchange.Add(new SwitchingSubsystem());
            telephoneExchange.Add(new BalanceSystem());
            telephoneExchange.Display(tvAts.Nodes);
        }

        private void tvAts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Tag is IATSComponent component)
            {
                tbInfo.Text = component.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(tvAts.Nodes.Count == 0)
            {
                MessageBox.Show("Невозможно удалить, поскольку список записей пуст!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tvAts.SelectedNode.Tag is IATSComponent component)
            {
                if(tvAts.SelectedNode.Tag is TelephoneExchange)
                {
                    tvAts.Nodes.Remove(tvAts.SelectedNode);
                }
                else
                {
                    TelephoneExchange tmp = tvAts.SelectedNode.Parent.Tag as TelephoneExchange;
                    tmp.Remove(tvAts.SelectedNode.Tag as IATSComponent);
                    tvAts.Nodes.Remove(tvAts.SelectedNode);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
