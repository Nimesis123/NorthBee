namespace NorthBee.CustomControl
{
    partial class GuestUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FioLab = new System.Windows.Forms.Label();
            this.GenderLab = new System.Windows.Forms.Label();
            this.DateBirthdayLab = new System.Windows.Forms.Label();
            this.CountLab = new System.Windows.Forms.Label();
            this.StatusLab = new System.Windows.Forms.Label();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FioLab
            // 
            this.FioLab.AutoSize = true;
            this.FioLab.Location = new System.Drawing.Point(21, 13);
            this.FioLab.Name = "FioLab";
            this.FioLab.Size = new System.Drawing.Size(18, 13);
            this.FioLab.TabIndex = 0;
            this.FioLab.Text = "fio";
            this.FioLab.Click += new System.EventHandler(this.FioLab_Click);
            // 
            // GenderLab
            // 
            this.GenderLab.AutoSize = true;
            this.GenderLab.Location = new System.Drawing.Point(21, 39);
            this.GenderLab.Name = "GenderLab";
            this.GenderLab.Size = new System.Drawing.Size(40, 13);
            this.GenderLab.TabIndex = 1;
            this.GenderLab.Text = "gender";
            this.GenderLab.Click += new System.EventHandler(this.FioLab_Click);
            // 
            // DateBirthdayLab
            // 
            this.DateBirthdayLab.AutoSize = true;
            this.DateBirthdayLab.Location = new System.Drawing.Point(21, 64);
            this.DateBirthdayLab.Name = "DateBirthdayLab";
            this.DateBirthdayLab.Size = new System.Drawing.Size(65, 13);
            this.DateBirthdayLab.TabIndex = 2;
            this.DateBirthdayLab.Text = "datebirthday";
            this.DateBirthdayLab.Click += new System.EventHandler(this.FioLab_Click);
            // 
            // CountLab
            // 
            this.CountLab.AutoSize = true;
            this.CountLab.Location = new System.Drawing.Point(21, 90);
            this.CountLab.Name = "CountLab";
            this.CountLab.Size = new System.Drawing.Size(54, 13);
            this.CountLab.TabIndex = 2;
            this.CountLab.Text = "countstop";
            this.CountLab.Click += new System.EventHandler(this.FioLab_Click);
            // 
            // StatusLab
            // 
            this.StatusLab.AutoSize = true;
            this.StatusLab.Location = new System.Drawing.Point(356, 13);
            this.StatusLab.Name = "StatusLab";
            this.StatusLab.Size = new System.Drawing.Size(35, 13);
            this.StatusLab.TabIndex = 0;
            this.StatusLab.Text = "status";
            this.StatusLab.Click += new System.EventHandler(this.FioLab_Click);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.HistoryBtn.Location = new System.Drawing.Point(615, 85);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.HistoryBtn.TabIndex = 3;
            this.HistoryBtn.Text = "История";
            this.HistoryBtn.UseVisualStyleBackColor = false;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // GuestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.HistoryBtn);
            this.Controls.Add(this.CountLab);
            this.Controls.Add(this.DateBirthdayLab);
            this.Controls.Add(this.GenderLab);
            this.Controls.Add(this.StatusLab);
            this.Controls.Add(this.FioLab);
            this.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.Name = "GuestUserControl";
            this.Size = new System.Drawing.Size(715, 118);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FioLab;
        private System.Windows.Forms.Label GenderLab;
        private System.Windows.Forms.Label DateBirthdayLab;
        private System.Windows.Forms.Label CountLab;
        private System.Windows.Forms.Label StatusLab;
        private System.Windows.Forms.Button HistoryBtn;
    }
}
