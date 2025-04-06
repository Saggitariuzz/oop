using OOP7.Controllers;
using OOP7.Models;

namespace OOP7
{
    public partial class MainForm : Form
    {

        private readonly CallController callController;

        public MainForm(CallController _callController)
        {
            InitializeComponent();
            callController = _callController;
            bindingSource.DataSource = callController.calls;
            dgvMainTable.DataSource = bindingSource;
            dgvMainTable.Columns[0].HeaderText = "ID";
            dgvMainTable.Columns[1].HeaderText = "Исходящий номер";
            dgvMainTable.Columns[2].HeaderText = "Входящий номер";
            dgvMainTable.Columns[3].HeaderText = "Время совершения звонка";
            dgvMainTable.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!callController.AddRecord(tbPhoneFrom.Text, tbPhoneTo.Text, dtpDate.Value))
                {
                    MessageBox.Show("Такая запись уже была добавлена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMainTable.SelectedRows.Count > 0)
                {
                    if (!callController.EditRecord(
                        (Call)bindingSource.Current,
                        tbPhoneFrom.Text,
                        tbPhoneTo.Text,
                        dtpDate.Value
                    ))
                    {
                        MessageBox.Show("Такая запись уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvMainTable.Refresh();
                }
                else
                {
                    MessageBox.Show("Сначала выберите запись.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMainTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMainTable.SelectedRows.Count > 0)
            {
                Call current = (Call)bindingSource.Current;
                tbPhoneFrom.Text = current.PhoneFrom;
                tbPhoneTo.Text = current.PhoneTo;
                dtpDate.Value = current.Date;
            }
            else
            {
                tbPhoneFrom.Text = string.Empty;
                tbPhoneTo.Text = string.Empty;
                dtpDate.Value = DateTime.Now;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvMainTable.SelectedRows.Count > 0)
            {
                callController.RemoveRecord((Call)bindingSource.Current);
            }
            else
            {
                MessageBox.Show("Сначала выберите запись.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (!dgvMainTable.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                dgvMainTable.ClearSelection();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            callController.Clear();
        }
    }
}