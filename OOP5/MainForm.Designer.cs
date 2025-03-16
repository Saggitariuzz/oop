namespace OOP5
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
            this.labelCommand = new System.Windows.Forms.Label();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbCommands = new System.Windows.Forms.ListBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.labelListOfCommands = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommand.Location = new System.Drawing.Point(281, 24);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(230, 25);
            this.labelCommand.TabIndex = 0;
            this.labelCommand.Text = "Выполнить команду";
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(143, 65);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(493, 20);
            this.tbCommand.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(286, 107);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(225, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbCommands
            // 
            this.lbCommands.FormattingEnabled = true;
            this.lbCommands.Location = new System.Drawing.Point(12, 222);
            this.lbCommands.Name = "lbCommands";
            this.lbCommands.Size = new System.Drawing.Size(374, 173);
            this.lbCommands.TabIndex = 3;
            this.lbCommands.SelectedIndexChanged += new System.EventHandler(this.lbCommands_SelectedIndexChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(402, 222);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(386, 173);
            this.tbDescription.TabIndex = 4;
            // 
            // labelListOfCommands
            // 
            this.labelListOfCommands.AutoSize = true;
            this.labelListOfCommands.Location = new System.Drawing.Point(9, 206);
            this.labelListOfCommands.Name = "labelListOfCommands";
            this.labelListOfCommands.Size = new System.Drawing.Size(133, 13);
            this.labelListOfCommands.TabIndex = 5;
            this.labelListOfCommands.Text = "Выполненнные команды";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(399, 206);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(106, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Описание команды";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(610, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(8, 141);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 20);
            this.labelError.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelListOfCommands);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbCommands);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbCommand);
            this.Controls.Add(this.labelCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lbCommands;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label labelListOfCommands;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelError;
    }
}

