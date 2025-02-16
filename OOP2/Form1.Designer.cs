namespace OOP2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbObjects = new System.Windows.Forms.TextBox();
            this.tbEvents = new System.Windows.Forms.TextBox();
            this.lbObjects = new System.Windows.Forms.Label();
            this.lbEvents = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lvMeasure = new System.Windows.Forms.ListView();
            this.chCollectionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeInsert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRandomAccessTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSeqAccessTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbMeasure = new System.Windows.Forms.Label();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbObjects
            // 
            this.tbObjects.Location = new System.Drawing.Point(22, 41);
            this.tbObjects.MaxLength = 2147483647;
            this.tbObjects.Multiline = true;
            this.tbObjects.Name = "tbObjects";
            this.tbObjects.ReadOnly = true;
            this.tbObjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObjects.Size = new System.Drawing.Size(408, 246);
            this.tbObjects.TabIndex = 0;
            // 
            // tbEvents
            // 
            this.tbEvents.Location = new System.Drawing.Point(468, 41);
            this.tbEvents.MaxLength = 2147483647;
            this.tbEvents.Multiline = true;
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.ReadOnly = true;
            this.tbEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEvents.Size = new System.Drawing.Size(411, 246);
            this.tbEvents.TabIndex = 1;
            // 
            // lbObjects
            // 
            this.lbObjects.AutoSize = true;
            this.lbObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbObjects.Location = new System.Drawing.Point(200, 22);
            this.lbObjects.Name = "lbObjects";
            this.lbObjects.Size = new System.Drawing.Size(72, 16);
            this.lbObjects.TabIndex = 2;
            this.lbObjects.Text = "Объекты";
            // 
            // lbEvents
            // 
            this.lbEvents.AutoSize = true;
            this.lbEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEvents.Location = new System.Drawing.Point(661, 22);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(70, 16);
            this.lbEvents.TabIndex = 3;
            this.lbEvents.Text = "События";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить объект в очередь";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(355, 344);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(199, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Показать объекты из очереди";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(700, 344);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(179, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Удалить объект из очереди";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lvMeasure
            // 
            this.lvMeasure.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCollectionName,
            this.chTimeInsert,
            this.chRandomAccessTime,
            this.chSeqAccessTime});
            this.lvMeasure.HideSelection = false;
            this.lvMeasure.Location = new System.Drawing.Point(33, 418);
            this.lvMeasure.Name = "lvMeasure";
            this.lvMeasure.Size = new System.Drawing.Size(862, 97);
            this.lvMeasure.TabIndex = 7;
            this.lvMeasure.UseCompatibleStateImageBehavior = false;
            // 
            // chCollectionName
            // 
            this.chCollectionName.Text = "Коллекция";
            this.chCollectionName.Width = 185;
            // 
            // chTimeInsert
            // 
            this.chTimeInsert.Text = "Время вставки";
            this.chTimeInsert.Width = 225;
            // 
            // chRandomAccessTime
            // 
            this.chRandomAccessTime.Text = "Время случайной выборки";
            this.chRandomAccessTime.Width = 225;
            // 
            // chSeqAccessTime
            // 
            this.chSeqAccessTime.Text = "Время последовательной выборки";
            this.chSeqAccessTime.Width = 225;
            // 
            // lbMeasure
            // 
            this.lbMeasure.AutoSize = true;
            this.lbMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMeasure.Location = new System.Drawing.Point(342, 388);
            this.lbMeasure.Name = "lbMeasure";
            this.lbMeasure.Size = new System.Drawing.Size(226, 16);
            this.lbMeasure.TabIndex = 8;
            this.lbMeasure.Text = "Замеры производительности";
            // 
            // btnMeasure
            // 
            this.btnMeasure.Location = new System.Drawing.Point(355, 527);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(199, 23);
            this.btnMeasure.TabIndex = 9;
            this.btnMeasure.Text = "Измерить";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(796, 549);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 595);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMeasure);
            this.Controls.Add(this.lbMeasure);
            this.Controls.Add(this.lvMeasure);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbEvents);
            this.Controls.Add(this.lbObjects);
            this.Controls.Add(this.tbEvents);
            this.Controls.Add(this.tbObjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Лабораторная работа 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbObjects;
        private System.Windows.Forms.TextBox tbEvents;
        private System.Windows.Forms.Label lbObjects;
        private System.Windows.Forms.Label lbEvents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView lvMeasure;
        private System.Windows.Forms.ColumnHeader chCollectionName;
        private System.Windows.Forms.ColumnHeader chTimeInsert;
        private System.Windows.Forms.ColumnHeader chRandomAccessTime;
        private System.Windows.Forms.ColumnHeader chSeqAccessTime;
        private System.Windows.Forms.Label lbMeasure;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Button btnClose;
    }
}

