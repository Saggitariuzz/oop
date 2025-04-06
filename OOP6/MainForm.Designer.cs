namespace OOP6
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
            this.labelFunction = new System.Windows.Forms.Label();
            this.labelMinvalue = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.tbFunction = new System.Windows.Forms.TextBox();
            this.tbMinvalue = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.buttonFunction = new System.Windows.Forms.Button();
            this.buttonMinvalue = new System.Windows.Forms.Button();
            this.buttonTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFunction
            // 
            this.labelFunction.AutoSize = true;
            this.labelFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunction.Location = new System.Drawing.Point(18, 20);
            this.labelFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(235, 29);
            this.labelFunction.TabIndex = 0;
            this.labelFunction.Text = "Значение функции";
            // 
            // labelMinvalue
            // 
            this.labelMinvalue.AutoSize = true;
            this.labelMinvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinvalue.Location = new System.Drawing.Point(404, 20);
            this.labelMinvalue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinvalue.Name = "labelMinvalue";
            this.labelMinvalue.Size = new System.Drawing.Size(299, 29);
            this.labelMinvalue.TabIndex = 1;
            this.labelMinvalue.Text = "Минимальное значение";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(794, 14);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(193, 29);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Текущее время";
            // 
            // tbFunction
            // 
            this.tbFunction.Location = new System.Drawing.Point(20, 57);
            this.tbFunction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFunction.Multiline = true;
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.ReadOnly = true;
            this.tbFunction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFunction.Size = new System.Drawing.Size(373, 576);
            this.tbFunction.TabIndex = 3;
            // 
            // tbMinvalue
            // 
            this.tbMinvalue.Location = new System.Drawing.Point(410, 55);
            this.tbMinvalue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMinvalue.Multiline = true;
            this.tbMinvalue.Name = "tbMinvalue";
            this.tbMinvalue.ReadOnly = true;
            this.tbMinvalue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMinvalue.Size = new System.Drawing.Size(373, 578);
            this.tbMinvalue.TabIndex = 4;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(800, 55);
            this.tbTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(373, 578);
            this.tbTime.TabIndex = 5;
            // 
            // buttonFunction
            // 
            this.buttonFunction.Location = new System.Drawing.Point(23, 657);
            this.buttonFunction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFunction.Name = "buttonFunction";
            this.buttonFunction.Size = new System.Drawing.Size(370, 35);
            this.buttonFunction.TabIndex = 6;
            this.buttonFunction.Text = "Рассчитать функцию";
            this.buttonFunction.UseVisualStyleBackColor = true;
            this.buttonFunction.Click += new System.EventHandler(this.buttonFunction_Click_1);
            // 
            // buttonMinvalue
            // 
            this.buttonMinvalue.Location = new System.Drawing.Point(409, 657);
            this.buttonMinvalue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMinvalue.Name = "buttonMinvalue";
            this.buttonMinvalue.Size = new System.Drawing.Size(374, 35);
            this.buttonMinvalue.TabIndex = 8;
            this.buttonMinvalue.Text = "Рассчитать минимальное значение";
            this.buttonMinvalue.UseVisualStyleBackColor = true;
            this.buttonMinvalue.Click += new System.EventHandler(this.buttonMinvalue_Click);
            // 
            // buttonTime
            // 
            this.buttonTime.Location = new System.Drawing.Point(801, 657);
            this.buttonTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(372, 35);
            this.buttonTime.TabIndex = 9;
            this.buttonTime.Text = "Показать системное время";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 716);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.buttonMinvalue);
            this.Controls.Add(this.buttonFunction);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbMinvalue);
            this.Controls.Add(this.tbFunction);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMinvalue);
            this.Controls.Add(this.labelFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.Label labelMinvalue;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox tbFunction;
        private System.Windows.Forms.TextBox tbMinvalue;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button buttonFunction;
        private System.Windows.Forms.Button buttonMinvalue;
        private System.Windows.Forms.Button buttonTime;
    }
}

