namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelSubscriber = new System.Windows.Forms.Label();
            this.labelDateCall = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDayNight = new System.Windows.Forms.Label();
            this.textBoxSubscriber = new System.Windows.Forms.TextBox();
            this.textBoxDateCall = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.textBoxDayNight = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(58, 9);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(212, 22);
            this.textBoxCity.TabIndex = 0;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(3, 12);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(49, 16);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "Город:";
            // 
            // labelSubscriber
            // 
            this.labelSubscriber.AutoSize = true;
            this.labelSubscriber.Location = new System.Drawing.Point(295, 12);
            this.labelSubscriber.Name = "labelSubscriber";
            this.labelSubscriber.Size = new System.Drawing.Size(66, 16);
            this.labelSubscriber.TabIndex = 2;
            this.labelSubscriber.Text = "Абонент:";
            // 
            // labelDateCall
            // 
            this.labelDateCall.AutoSize = true;
            this.labelDateCall.Location = new System.Drawing.Point(3, 56);
            this.labelDateCall.Name = "labelDateCall";
            this.labelDateCall.Size = new System.Drawing.Size(92, 16);
            this.labelDateCall.TabIndex = 3;
            this.labelDateCall.Text = "Дата звонка:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(295, 56);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(61, 16);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Минуты:";
            // 
            // labelDayNight
            // 
            this.labelDayNight.AutoSize = true;
            this.labelDayNight.Location = new System.Drawing.Point(477, 56);
            this.labelDayNight.Name = "labelDayNight";
            this.labelDayNight.Size = new System.Drawing.Size(91, 16);
            this.labelDayNight.TabIndex = 5;
            this.labelDayNight.Text = "Время суток:";
            // 
            // textBoxSubscriber
            // 
            this.textBoxSubscriber.Location = new System.Drawing.Point(367, 9);
            this.textBoxSubscriber.Name = "textBoxSubscriber";
            this.textBoxSubscriber.Size = new System.Drawing.Size(225, 22);
            this.textBoxSubscriber.TabIndex = 6;
            // 
            // textBoxDateCall
            // 
            this.textBoxDateCall.Location = new System.Drawing.Point(101, 56);
            this.textBoxDateCall.Name = "textBoxDateCall";
            this.textBoxDateCall.Size = new System.Drawing.Size(169, 22);
            this.textBoxDateCall.TabIndex = 7;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Location = new System.Drawing.Point(362, 56);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(100, 22);
            this.textBoxMinute.TabIndex = 8;
            // 
            // textBoxDayNight
            // 
            this.textBoxDayNight.Location = new System.Drawing.Point(574, 56);
            this.textBoxDayNight.Name = "textBoxDayNight";
            this.textBoxDayNight.Size = new System.Drawing.Size(100, 22);
            this.textBoxDayNight.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(607, 9);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(67, 32);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "x";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxDayNight);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.textBoxDateCall);
            this.Controls.Add(this.textBoxSubscriber);
            this.Controls.Add(this.labelDayNight);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDateCall);
            this.Controls.Add(this.labelSubscriber);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(685, 88);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlCall_Paint);
            this.Click += new System.EventHandler(this.UserControlCall_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelSubscriber;
        private System.Windows.Forms.Label labelDateCall;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDayNight;
        private System.Windows.Forms.TextBox textBoxSubscriber;
        private System.Windows.Forms.TextBox textBoxDateCall;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.TextBox textBoxDayNight;
        private System.Windows.Forms.Button buttonDelete;
    }
}
