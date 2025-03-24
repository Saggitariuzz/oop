using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP6
{
    public partial class MainForm : Form
    {
        private List<int> list;

        private const int SIZE = 9;

        private const int MIN = 5;

        private const int MAX = 20;

        private const double X = 7.3;

        private const string FUNCTION = "f(x) = x³ - 2x² + 3x - 5";

        public MainForm()
        {
            InitializeComponent();
            list = VectorAsync.CreateRandomVector(SIZE, MIN, MAX);
            tbMedian.Text = "Вектор: " + string.Join(" ", list) + Environment.NewLine;
            tbVector.Text = FUNCTION + Environment.NewLine + $"x = {X}" + Environment.NewLine;
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
            await FunctionAsync.f(X, tbVector);
        }

        private async void buttonMedian_Click(object sender, EventArgs e)
        {
            await VectorAsync.VectorMedianAsync(tbMedian, list);
        }

        private async void buttonTime_Click(object sender, EventArgs e)
        {
            await TimeAsync.SystemTimeAsync(tbTime);
        }
    }
}
