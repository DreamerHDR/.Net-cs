using Laba11.Models;
using System;
using System.Windows.Forms;

namespace Laba11
{
    public partial class FormMaker : Form
    {
        private Maker _maker;
        public Maker Maker
        {
            get { return _maker; }
            set
            {
                _maker = value;
                textBox1.Text = _maker.Name;       // Поле для имени производителя
                textBox2.Text = _maker.Country;    // Поле для страны производителя
                textBox3.Text = _maker.PhoneID.ToString(); // Поле для PhoneID
            }
        }

        public FormMaker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Сохраняем изменения в объект Maker
            Maker.Name = textBox1.Text;
            Maker.Country = textBox2.Text;
            Maker.PhoneID = int.Parse(textBox3.Text); // Устанавливаем PhoneID из textBox3

            // Устанавливаем результат диалога как "ОК" и закрываем форму
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
