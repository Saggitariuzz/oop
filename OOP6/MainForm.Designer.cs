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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pbComputing = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVector
            // 
            this.labelVector.AutoSize = true;
            this.labelVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVector.Location = new System.Drawing.Point(12, 13);
            this.labelVector.Name = "labelVector";
            this.labelVector.Size = new System.Drawing.Size(231, 20);
            this.labelVector.TabIndex = 0;
            this.labelVector.Text = "Вектор, считанный из файла";
            // 
            // labelMedian
            // 
            this.labelMedian.AutoSize = true;
            this.labelMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedian.Location = new System.Drawing.Point(269, 13);
            this.labelMedian.Name = "labelMedian";
            this.labelMedian.Size = new System.Drawing.Size(78, 20);
            this.labelMedian.TabIndex = 1;
            this.labelMedian.Text = "Медиана";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(529, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(124, 20);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Текущее время";
            // 
            // tbVector
            // 
            this.tbVector.Location = new System.Drawing.Point(13, 37);
            this.tbVector.Multiline = true;
            this.tbVector.Name = "tbVector";
            this.tbVector.ReadOnly = true;
            this.tbVector.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbVector.Size = new System.Drawing.Size(250, 376);
            this.tbVector.TabIndex = 3;
            // 
            // tbMedian
            // 
            this.tbMedian.Location = new System.Drawing.Point(273, 36);
            this.tbMedian.Multiline = true;
            this.tbMedian.Name = "tbMedian";
            this.tbMedian.ReadOnly = true;
            this.tbMedian.Size = new System.Drawing.Size(250, 377);
            this.tbMedian.TabIndex = 4;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(533, 36);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(250, 377);
            this.tbTime.TabIndex = 5;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(273, 479);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(250, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(665, 479);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(118, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Выйти";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pbComputing
            // 
            this.pbComputing.Location = new System.Drawing.Point(273, 450);
            this.pbComputing.Name = "pbComputing";
            this.pbComputing.Size = new System.Drawing.Size(250, 23);
            this.pbComputing.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbComputing.TabIndex = 8;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(270, 427);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(179, 13);
            this.labelProgress.TabIndex = 9;
            this.labelProgress.Text = "Вычисление системного времени";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.pbComputing);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbMedian);
            this.Controls.Add(this.tbVector);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMedian);
            this.Controls.Add(this.labelVector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 6";
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
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ProgressBar pbComputing;
        private System.Windows.Forms.Label labelProgress;
    }
}

