namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changecToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createpToolStripMenuItem,
            this.createToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createpToolStripMenuItem
            // 
            this.createpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addpToolStripMenuItem,
            this.changepToolStripMenuItem});
            this.createpToolStripMenuItem.Name = "createpToolStripMenuItem";
            this.createpToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.createpToolStripMenuItem.Text = "Создать абонента";
            this.createpToolStripMenuItem.Click += new System.EventHandler(this.создатьАбонентаToolStripMenuItem_Click);
            // 
            // addpToolStripMenuItem
            // 
            this.addpToolStripMenuItem.Name = "addpToolStripMenuItem";
            this.addpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addpToolStripMenuItem.Text = "Добавить";
            this.addpToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // changepToolStripMenuItem
            // 
            this.changepToolStripMenuItem.Name = "changepToolStripMenuItem";
            this.changepToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changepToolStripMenuItem.Text = "Редактировать";
            this.changepToolStripMenuItem.Click += new System.EventHandler(this.changepToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addcToolStripMenuItem,
            this.changecToolStripMenuItem1});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.createToolStripMenuItem.Text = "Создать город";
            // 
            // addcToolStripMenuItem
            // 
            this.addcToolStripMenuItem.Name = "addcToolStripMenuItem";
            this.addcToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addcToolStripMenuItem.Text = "Добавить";
            this.addcToolStripMenuItem.Click += new System.EventHandler(this.createcToolStripMenuItem_Click);
            // 
            // changecToolStripMenuItem1
            // 
            this.changecToolStripMenuItem1.Name = "changecToolStripMenuItem1";
            this.changecToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.changecToolStripMenuItem1.Text = "Редактировать";
            this.changecToolStripMenuItem1.Click += new System.EventHandler(this.changecToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changecToolStripMenuItem1;
    }
}

