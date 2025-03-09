namespace OOP4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tvAts = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.labelAtsHeader = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvAts
            // 
            this.tvAts.Location = new System.Drawing.Point(14, 29);
            this.tvAts.Name = "tvAts";
            this.tvAts.Size = new System.Drawing.Size(296, 409);
            this.tvAts.TabIndex = 0;
            this.tvAts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAts_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(331, 29);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(475, 378);
            this.tbInfo.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(592, 413);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(214, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // labelAtsHeader
            // 
            this.labelAtsHeader.AutoSize = true;
            this.labelAtsHeader.Location = new System.Drawing.Point(57, 9);
            this.labelAtsHeader.Name = "labelAtsHeader";
            this.labelAtsHeader.Size = new System.Drawing.Size(201, 13);
            this.labelAtsHeader.TabIndex = 4;
            this.labelAtsHeader.Text = "Автоматические телефонные станции";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(535, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(73, 13);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Информация";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelAtsHeader);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tvAts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа 4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvAts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label labelAtsHeader;
        private System.Windows.Forms.Label labelInfo;
    }
}

