using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP6
{
    public partial class MainForm : Form
    {
        private List<int> list;

        private const int SIZE = 1000;

        private const int MIN = 0;

        private const int MAX = 200000;

        private const double X = 10;

        private const string FUNCTION = "f(x) = eˣ";

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void buttonFunction_Click_1(object sender, EventArgs e)
        {
            buttonFunction.Enabled = false;
            buttonFunction.Text = "Вычисление...";
            tbFunction.Text = FUNCTION + Environment.NewLine + $"x = {X}" + Environment.NewLine;
            await FunctionAsync.Exponent(X, tbFunction);
            buttonFunction.Text = "Рассчитать функцию";
            buttonFunction.Enabled = true;
        }

        private async void buttonMinvalue_Click(object sender, EventArgs e)
        {
            buttonMinvalue.Enabled = false;
            buttonMinvalue.Text = "Создание вектора случайных чисел...";
            list = await VectorAsync.CreateRandomVector(SIZE, MIN, MAX);
            tbMinvalue.Text = "Вектор: " + string.Join(" ", list) + Environment.NewLine;
            buttonMinvalue.Text = "Поиск минимального...";
            await VectorAsync.MinimumAsync(list, tbMinvalue);
            buttonMinvalue.Text = "Рассчитать минимальное значение";
            buttonMinvalue.Enabled = true;
        }

        private async void buttonTime_Click(object sender, EventArgs e)
        {
            buttonTime.Enabled = false;
            buttonTime.Text = "Время отображено";
            await TimeAsync.SystemTimeAsync(tbTime);
            buttonTime.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbFunction.Text = FUNCTION + Environment.NewLine + $"x = {X}" + Environment.NewLine;
        }
    }
}