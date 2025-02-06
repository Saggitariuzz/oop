using System;
using System.Windows.Forms;

namespace OOP1
{
    public partial class MainForm : Form
    {

        private TelephoneExchange telephoneExchange;

        private WelcomeForm welcomeForm;

        public MainForm(WelcomeForm _welcomeForm, TelephoneExchange _telephoneExchange)
        {
            InitializeComponent();
            welcomeForm = _welcomeForm;
            telephoneExchange = _telephoneExchange;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            controlPanel.Controls.Clear();
            labelSaved.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tbInfo.Text = telephoneExchange.ToString();
        }

        private void cbWhatToChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            switch (cbWhatToChange.SelectedIndex)
            {
                case 0:
                    ShowTextBox();
                    (controlPanel.Controls[0] as TextBox).Text = telephoneExchange.Address;
                    break;
                case 1:
                    ShowNumericUpDown();
                    (controlPanel.Controls[0] as NumericUpDown).Value = telephoneExchange.NumberOfUsers;
                    break;
                case 2:
                    ShowNumericUpDown();
                    (controlPanel.Controls[0] as NumericUpDown).Value = telephoneExchange.Payment;
                    break;
                case 3:
                    ShowComboBox();
                    (controlPanel.Controls[0] as ComboBox).Text = telephoneExchange.Type;
                    break;
                case 4:
                    ShowTextBox();
                    (controlPanel.Controls[0] as TextBox).Text = string.Join(",", telephoneExchange.Protocols);
                    break;
                case 5:
                    ShowDateTimePicker();
                    (controlPanel.Controls[0] as DateTimePicker).Value = telephoneExchange.Date;
                    break;
                case 6:
                    ShowComboBox();
                    (controlPanel.Controls[0] as ComboBox).Text = telephoneExchange.IsWorking ? "Да" : "Нет";
                    break;
                default:
                    ExceptionHandler.MessageBox(0, "Неизвестная ошибка", "Ошибка", 16);
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                labelSaved.Visible = false;
                switch (cbWhatToChange.SelectedIndex)
                {
                    case 0:
                        telephoneExchange.Address = (controlPanel.Controls[0] as TextBox).Text;
                        break;
                    case 1:
                        telephoneExchange.NumberOfUsers = (int)(controlPanel.Controls[0] as NumericUpDown).Value;
                        break;
                    case 2:
                        telephoneExchange.Payment = (controlPanel.Controls[0] as NumericUpDown).Value;
                        break;
                    case 3:
                        telephoneExchange.Type = (controlPanel.Controls[0] as ComboBox).SelectedItem.ToString();
                        break;
                    case 4:
                        telephoneExchange.Protocols = (controlPanel.Controls[0] as TextBox).Text.Split(',');
                        break;
                    case 5:
                        telephoneExchange.Date = (controlPanel.Controls[0] as DateTimePicker).Value;
                        break;
                    case 6:
                        telephoneExchange.IsWorking = (controlPanel.Controls[0] as ComboBox).SelectedItem.ToString() == "Да";
                        break;
                    default:
                        ExceptionHandler.MessageBox(0, "Неизвестная ошибка", "Ошибка", 16);
                        break;
                }
                labelSaved.Visible = true;
            }
            catch(DateException ex)
            {
                ExceptionHandler.MessageBox(0, ex.Message, "Ошибка", 16);
            }
            catch(ArgumentException ex)
            {
                ExceptionHandler.MessageBox(0, ex.Message, "Ошибка", 16);
            }
            catch(IncorrectProtocolException ex)
            {
                ExceptionHandler.MessageBox(0, ex.Message, "Ошибка", 16);
            }

        }

        private void ShowTextBox()
        {
            TextBox textBox = new TextBox();
            textBox.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(textBox);
        }

        private void ShowNumericUpDown()
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Dock = DockStyle.Fill;
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = int.MaxValue;
            if(cbWhatToChange.SelectedIndex == 1)
            {
                numericUpDown.DecimalPlaces = 0;
            }
            else
            {
                numericUpDown.DecimalPlaces = 2;
            }
            controlPanel.Controls.Add(numericUpDown);
        }

        private void ShowComboBox()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Dock = DockStyle.Fill;
            if (cbWhatToChange.SelectedIndex == 3)
            {
                comboBox.Items.Add("Машинная");
                comboBox.Items.Add("Декадно-шаговая");
                comboBox.Items.Add("Координатная");
                comboBox.Items.Add("Квазиэлектронная");
                comboBox.Items.Add("Электронная аналоговая");
                comboBox.Items.Add("Электронная цифровая");
                comboBox.Items.Add("Интернет-АТС");
                comboBox.Items.Add("Программная");
            }
            else
            {
                comboBox.Items.Add("Да");
                comboBox.Items.Add("Нет");
            }
            controlPanel.Controls.Add(comboBox);
        }

        private void ShowDateTimePicker()
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(dateTimePicker);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            welcomeForm.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            welcomeForm.Show();
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
