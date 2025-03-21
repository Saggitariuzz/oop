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
            this.labelVector = new System.Windows.Forms.Label();
            this.labelMedian = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.tbVector = new System.Windows.Forms.TextBox();
            this.tbMedian = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.buttonFunction = new System.Windows.Forms.Button();
            this.buttonMedian = new System.Windows.Forms.Button();
            this.buttonTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVector
            // 
            this.labelVector.AutoSize = true;
            this.labelVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVector.Location = new System.Drawing.Point(18, 20);
            this.labelVector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVector.Name = "labelVector";
            this.labelVector.Size = new System.Drawing.Size(235, 29);
            this.labelVector.TabIndex = 0;
            this.labelVector.Text = "Значение функции";
            // 
            // labelMedian
            // 
            this.labelMedian.AutoSize = true;
            this.labelMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedian.Location = new System.Drawing.Point(404, 20);
            this.labelMedian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMedian.Name = "labelMedian";
            this.labelMedian.Size = new System.Drawing.Size(117, 29);
            this.labelMedian.TabIndex = 1;
            this.labelMedian.Text = "Медиана";
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
            // tbVector
            // 
            this.tbVector.Location = new System.Drawing.Point(20, 57);
            this.tbVector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVector.Multiline = true;
            this.tbVector.Name = "tbVector";
            this.tbVector.ReadOnly = true;
            this.tbVector.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbVector.Size = new System.Drawing.Size(373, 576);
            this.tbVector.TabIndex = 3;
            // 
            // tbMedian
            // 
            this.tbMedian.Location = new System.Drawing.Point(410, 55);
            this.tbMedian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMedian.Multiline = true;
            this.tbMedian.Name = "tbMedian";
            this.tbMedian.ReadOnly = true;
            this.tbMedian.Size = new System.Drawing.Size(373, 578);
            this.tbMedian.TabIndex = 4;
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
            // buttonMedian
            // 
            this.buttonMedian.Location = new System.Drawing.Point(409, 657);
            this.buttonMedian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMedian.Name = "buttonMedian";
            this.buttonMedian.Size = new System.Drawing.Size(374, 35);
            this.buttonMedian.TabIndex = 8;
            this.buttonMedian.Text = "Рассчитать медиану";
            this.buttonMedian.UseVisualStyleBackColor = true;
            this.buttonMedian.Click += new System.EventHandler(this.buttonMedian_Click);
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
            this.Controls.Add(this.buttonMedian);
            this.Controls.Add(this.buttonFunction);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbMedian);
            this.Controls.Add(this.tbVector);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMedian);
            this.Controls.Add(this.labelVector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVector;
        private System.Windows.Forms.Label labelMedian;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox tbVector;
        private System.Windows.Forms.TextBox tbMedian;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button buttonFunction;
        private System.Windows.Forms.Button buttonMedian;
        private System.Windows.Forms.Button buttonTime;
    }
}

