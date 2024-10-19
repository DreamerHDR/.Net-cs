using Laba4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SubscriberForm : Form
    {
        // Свойство для передачи данных обратно
        public Subscriber Subscriber { get; private set; }

        public SubscriberForm(Subscriber subscriber)
        {
            InitializeComponent();
            Subscriber = subscriber;
            txtPhoneNumber.Text = Subscriber.PhoneNumber;
            txtINN.Text = Subscriber.INN;
            txtAddress.Text = Subscriber.Address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Обновляем данные абонента на основе введенных значений
            Subscriber.PhoneNumber = txtPhoneNumber.Text;
            Subscriber.INN = txtINN.Text;
            Subscriber.Address = txtAddress.Text;

            // Закрываем форму с результатом OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
