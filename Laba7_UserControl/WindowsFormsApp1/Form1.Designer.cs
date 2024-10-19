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
            this.звонкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCity = new System.Windows.Forms.TabPage();
            this.listViewCity = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageSubscriber = new System.Windows.Forms.TabPage();
            this.listViewSubscriber = new System.Windows.Forms.ListView();
            this.columnHeaderSub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageCall = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageCity.SuspendLayout();
            this.tabPageSubscriber.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createpToolStripMenuItem,
            this.createToolStripMenuItem,
            this.звонкиToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createpToolStripMenuItem
            // 
            this.createpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addpToolStripMenuItem,
            this.changepToolStripMenuItem});
            this.createpToolStripMenuItem.Name = "createpToolStripMenuItem";
            this.createpToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.createpToolStripMenuItem.Text = "Город";
            // 
            // addpToolStripMenuItem
            // 
            this.addpToolStripMenuItem.Name = "addpToolStripMenuItem";
            this.addpToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addpToolStripMenuItem.Text = "Добавить";
            this.addpToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // changepToolStripMenuItem
            // 
            this.changepToolStripMenuItem.Name = "changepToolStripMenuItem";
            this.changepToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.changepToolStripMenuItem.Text = "Редактировать";
            this.changepToolStripMenuItem.Click += new System.EventHandler(this.changepToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addcToolStripMenuItem,
            this.changecToolStripMenuItem1});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.createToolStripMenuItem.Text = "Абонент";
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
            this.changecToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.changecToolStripMenuItem1.Text = "Редактировать";
            this.changecToolStripMenuItem1.Click += new System.EventHandler(this.changecToolStripMenuItem1_Click);
            // 
            // звонкиToolStripMenuItem
            // 
            this.звонкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.звонкиToolStripMenuItem.Name = "звонкиToolStripMenuItem";
            this.звонкиToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.звонкиToolStripMenuItem.Text = "Звонки";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click_1);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCity);
            this.tabControlMain.Controls.Add(this.tabPageSubscriber);
            this.tabControlMain.Controls.Add(this.tabPageCall);
            this.tabControlMain.Location = new System.Drawing.Point(0, 31);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(986, 469);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageCity
            // 
            this.tabPageCity.Controls.Add(this.listViewCity);
            this.tabPageCity.Location = new System.Drawing.Point(4, 25);
            this.tabPageCity.Name = "tabPageCity";
            this.tabPageCity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCity.Size = new System.Drawing.Size(978, 440);
            this.tabPageCity.TabIndex = 0;
            this.tabPageCity.Text = "Город";
            this.tabPageCity.UseVisualStyleBackColor = true;
            // 
            // listViewCity
            // 
            this.listViewCity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCity.FullRowSelect = true;
            this.listViewCity.GridLines = true;
            this.listViewCity.HideSelection = false;
            this.listViewCity.Location = new System.Drawing.Point(3, 3);
            this.listViewCity.Name = "listViewCity";
            this.listViewCity.Size = new System.Drawing.Size(972, 434);
            this.listViewCity.TabIndex = 0;
            this.listViewCity.UseCompatibleStateImageBehavior = false;
            this.listViewCity.View = System.Windows.Forms.View.Details;
            this.listViewCity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewCity_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название города";
            this.columnHeader1.Width = 456;
            // 
            // tabPageSubscriber
            // 
            this.tabPageSubscriber.Controls.Add(this.listViewSubscriber);
            this.tabPageSubscriber.Location = new System.Drawing.Point(4, 25);
            this.tabPageSubscriber.Name = "tabPageSubscriber";
            this.tabPageSubscriber.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubscriber.Size = new System.Drawing.Size(978, 440);
            this.tabPageSubscriber.TabIndex = 1;
            this.tabPageSubscriber.Text = "Абонент";
            this.tabPageSubscriber.UseVisualStyleBackColor = true;
            // 
            // listViewSubscriber
            // 
            this.listViewSubscriber.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSub});
            this.listViewSubscriber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSubscriber.FullRowSelect = true;
            this.listViewSubscriber.GridLines = true;
            this.listViewSubscriber.HideSelection = false;
            this.listViewSubscriber.Location = new System.Drawing.Point(3, 3);
            this.listViewSubscriber.Name = "listViewSubscriber";
            this.listViewSubscriber.Size = new System.Drawing.Size(972, 434);
            this.listViewSubscriber.TabIndex = 0;
            this.listViewSubscriber.UseCompatibleStateImageBehavior = false;
            this.listViewSubscriber.View = System.Windows.Forms.View.Details;
            this.listViewSubscriber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewSubscriber_KeyUp);
            // 
            // columnHeaderSub
            // 
            this.columnHeaderSub.Text = "Номер телефона";
            this.columnHeaderSub.Width = 456;
            // 
            // tabPageCall
            // 
            this.tabPageCall.Location = new System.Drawing.Point(4, 25);
            this.tabPageCall.Name = "tabPageCall";
            this.tabPageCall.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCall.Size = new System.Drawing.Size(978, 440);
            this.tabPageCall.TabIndex = 2;
            this.tabPageCall.Text = "Звонки";
            this.tabPageCall.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 515);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCity.ResumeLayout(false);
            this.tabPageSubscriber.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem звонкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCity;
        private System.Windows.Forms.TabPage tabPageSubscriber;
        private System.Windows.Forms.TabPage tabPageCall;
        private System.Windows.Forms.ListView listViewSubscriber;
        private System.Windows.Forms.ListView listViewCity;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeaderSub;
    }
}

