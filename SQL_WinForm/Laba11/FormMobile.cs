using Laba11.Models;
using System;
using System.Windows.Forms;

namespace Laba11
{
    public partial class FormMobile : Form
    {
        private MobilePhone _mobilePhone;
        public MobilePhone MobilePhone
        {
            get { return _mobilePhone; }
            set
            {
                _mobilePhone = value;
                textBox1.Text = _mobilePhone.Model;
                numericUpDown1.Value = _mobilePhone.Price;
            }
        }

        public FormMobile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MobilePhone.Model = textBox1.Text;
            MobilePhone.Price = numericUpDown1.Value;
            // Установим результат диалога
            this.DialogResult = DialogResult.OK;
            this.Close(); // Закрываем форму
        }

    }
}
