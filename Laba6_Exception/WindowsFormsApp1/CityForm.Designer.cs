namespace WindowsFormsApp1
{
    partial class CityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.numDayRate = new System.Windows.Forms.NumericUpDown();
            this.numNightRate = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDayRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNightRate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название города";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дневной тариф";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ночной тариф";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(142, 33);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(142, 22);
            this.txtCityName.TabIndex = 3;
            // 
            // numDayRate
            // 
            this.numDayRate.DecimalPlaces = 2;
            this.numDayRate.Location = new System.Drawing.Point(142, 106);
            this.numDayRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDayRate.Name = "numDayRate";
            this.numDayRate.Size = new System.Drawing.Size(142, 22);
            this.numDayRate.TabIndex = 4;
            this.numDayRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numNightRate
            // 
            this.numNightRate.DecimalPlaces = 2;
            this.numNightRate.Location = new System.Drawing.Point(142, 173);
            this.numNightRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNightRate.Name = "numNightRate";
            this.numNightRate.Size = new System.Drawing.Size(142, 22);
            this.numNightRate.TabIndex = 5;
            this.numNightRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numNightRate);
            this.Controls.Add(this.numDayRate);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CityForm";
            this.Text = "CityForm";
            ((System.ComponentModel.ISupportInitialize)(this.numDayRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNightRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.NumericUpDown numDayRate;
        private System.Windows.Forms.NumericUpDown numNightRate;
        private System.Windows.Forms.Button button1;
    }
}