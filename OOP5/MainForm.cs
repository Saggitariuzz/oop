using OOP5.Interpreter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP5
{
    public partial class MainForm : Form
    {

        private List<IExpression> commands = new List<IExpression> ();

        public MainForm()
        {
            InitializeComponent();
            labelError.Visible = false;
            AcceptButton = btnSend;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                labelError.Visible = false;
                IExpression command = Parser.Parse(tbCommand.Text);
                Context context = new Context();
                context.Input = tbCommand.Text;
                command.Interpret(context);
                commands.Add(command);
                lbCommands.Items.Add(string.Join(" ", context.Output));
            }
            catch (WrongCommandException ex)
            {
                labelError.Text = ex.Message;
                labelError.Visible = true;
            }
        }

        private void lbCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDescription.Text = commands[lbCommands.SelectedIndex].ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
