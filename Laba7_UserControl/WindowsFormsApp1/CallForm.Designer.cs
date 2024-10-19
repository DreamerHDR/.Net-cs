namespace WindowsFormsApp1
{
    partial class CallForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubscriberBox = new System.Windows.Forms.ComboBox();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateCall = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.MinuteNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonDay = new System.Windows.Forms.RadioButton();
            this.ButtonNight = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNum)).BeginInit();
            this.SuspendLayout();
            // 
            // SubscriberBox
            // 
            this.SubscriberBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubscriberBox.FormattingEnabled = true;
            this.SubscriberBox.Location = new System.Drawing.Point(112, 35);
            this.SubscriberBox.Name = "SubscriberBox";
            this.SubscriberBox.Size = new System.Drawing.Size(388, 24);
            this.SubscriberBox.TabIndex = 1;
            // 
            // CityBox
            // 
            this.CityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityBox.FormattingEnabled = true;
            this.CityBox.Location = new System.Drawing.Point(112, 91);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(388, 24);
            this.CityBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Абонент";
            // 
            // DateCall
            // 
            this.DateCall.Location = new System.Drawing.Point(147, 146);
            this.DateCall.Name = "DateCall";
            this.DateCall.Size = new System.Drawing.Size(171, 22);
            this.DateCall.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата звонка";
            // 
            // MinuteNum
            // 
            this.MinuteNum.Location = new System.Drawing.Point(147, 187);
            this.MinuteNum.Name = "MinuteNum";
            this.MinuteNum.Size = new System.Drawing.Size(171, 22);
            this.MinuteNum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество минут";
            // 
            // ButtonDay
            // 
            this.ButtonDay.AutoSize = true;
            this.ButtonDay.Location = new System.Drawing.Point(386, 148);
            this.ButtonDay.Name = "ButtonDay";
            this.ButtonDay.Size = new System.Drawing.Size(60, 20);
            this.ButtonDay.TabIndex = 8;
            this.ButtonDay.TabStop = true;
            this.ButtonDay.Text = "День";
            this.ButtonDay.UseVisualStyleBackColor = true;
            // 
            // ButtonNight
            // 
            this.ButtonNight.AutoSize = true;
            this.ButtonNight.Location = new System.Drawing.Point(385, 189);
            this.ButtonNight.Name = "ButtonNight";
            this.ButtonNight.Size = new System.Drawing.Size(61, 20);
            this.ButtonNight.TabIndex = 9;
            this.ButtonNight.TabStop = true;
            this.ButtonNight.Text = "Ночь";
            this.ButtonNight.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonNight);
            this.Controls.Add(this.ButtonDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MinuteNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateCall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.SubscriberBox);
            this.Name = "CallForm";
            this.Text = "CallForm";
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SubscriberBox;
        private System.Windows.Forms.ComboBox CityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateCall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MinuteNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton ButtonDay;
        private System.Windows.Forms.RadioButton ButtonNight;
        private System.Windows.Forms.Button button1;
    }
}