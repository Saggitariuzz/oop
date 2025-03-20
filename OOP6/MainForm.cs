using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OOP6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            pbComputing.Visible = false;
            labelProgress.Visible = false;
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                pbComputing.Visible = true;
                labelProgress.Visible = true;
                Progress<int> progress = new Progress<int>(value =>
                {
                    pbComputing.Value = value;
                });
                labelProgress.Text = "Вычисление системного времени";
                tbTime.Text = await TimeAsync.SystemTimeAsync(progress);
                labelProgress.Text = "Загрузка вектора";
                List<double> list = await VectorAsync.FillVectorFromFileAsync(@"D:\OOP\oop_labs\oop\OOP6\Vector.txt", progress);
                tbVector.Text = string.Join(", ", list);
                labelProgress.Text = "Вычисление медианы";
                double median = await VectorAsync.VectorMedianAsync(list, progress);
                tbMedian.Text = median.ToString("F2");
                pbComputing.Visible = false;
                labelProgress.Visible = false;
            }
            catch(IOException ex)
            {
                pbComputing.Visible = false;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
