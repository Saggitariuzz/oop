namespace OOP7
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelHeader = new Label();
            labelPhoneFrom = new Label();
            labelPhoneTo = new Label();
            labelDate = new Label();
            tbPhoneFrom = new TextBox();
            tbPhoneTo = new TextBox();
            dtpDate = new DateTimePicker();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            dgvMainTable = new DataGridView();
            bindingSource = new BindingSource(components);
            btnClearAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMainTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.Location = new Point(297, 26);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(204, 32);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Список звонков";
            // 
            // labelPhoneFrom
            // 
            labelPhoneFrom.AutoSize = true;
            labelPhoneFrom.Location = new Point(12, 77);
            labelPhoneFrom.Name = "labelPhoneFrom";
            labelPhoneFrom.Size = new Size(111, 15);
            labelPhoneFrom.TabIndex = 1;
            labelPhoneFrom.Text = "Исходящий номер";
            // 
            // labelPhoneTo
            // 
            labelPhoneTo.AutoSize = true;
            labelPhoneTo.Location = new Point(12, 113);
            labelPhoneTo.Name = "labelPhoneTo";
            labelPhoneTo.Size = new Size(103, 15);
            labelPhoneTo.TabIndex = 2;
            labelPhoneTo.Text = "Входящий номер";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 148);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(72, 15);
            labelDate.TabIndex = 3;
            labelDate.Text = "Дата звонка";
            // 
            // tbPhoneFrom
            // 
            tbPhoneFrom.Location = new Point(129, 74);
            tbPhoneFrom.Name = "tbPhoneFrom";
            tbPhoneFrom.Size = new Size(659, 23);
            tbPhoneFrom.TabIndex = 4;
            // 
            // tbPhoneTo
            // 
            tbPhoneTo.Location = new Point(129, 111);
            tbPhoneTo.Name = "tbPhoneTo";
            tbPhoneTo.Size = new Size(659, 23);
            tbPhoneTo.TabIndex = 5;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dtpDate.Location = new Point(129, 144);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(659, 23);
            dtpDate.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 194);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(221, 194);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(162, 23);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(427, 194);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(162, 23);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Удалить";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // dgvMainTable
            // 
            dgvMainTable.AllowUserToAddRows = false;
            dgvMainTable.AllowUserToDeleteRows = false;
            dgvMainTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMainTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainTable.Location = new Point(12, 233);
            dgvMainTable.MultiSelect = false;
            dgvMainTable.Name = "dgvMainTable";
            dgvMainTable.ReadOnly = true;
            dgvMainTable.RowTemplate.Height = 25;
            dgvMainTable.Size = new Size(776, 191);
            dgvMainTable.TabIndex = 10;
            dgvMainTable.SelectionChanged += dgvMainTable_SelectionChanged;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(626, 194);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(162, 23);
            btnClearAll.TabIndex = 11;
            btnClearAll.Text = "Очистить все";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearAll);
            Controls.Add(dgvMainTable);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dtpDate);
            Controls.Add(tbPhoneTo);
            Controls.Add(tbPhoneFrom);
            Controls.Add(labelDate);
            Controls.Add(labelPhoneTo);
            Controls.Add(labelPhoneFrom);
            Controls.Add(labelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Лабораторная работа 7";
            MouseDown += MainForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dgvMainTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private Label labelPhoneFrom;
        private Label labelPhoneTo;
        private Label labelDate;
        private TextBox tbPhoneFrom;
        private TextBox tbPhoneTo;
        private DateTimePicker dtpDate;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private DataGridView dgvMainTable;
        private BindingSource bindingSource;
        private Button btnClearAll;
    }
}