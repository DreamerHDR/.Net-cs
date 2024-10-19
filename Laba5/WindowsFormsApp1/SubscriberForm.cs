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
        public Subscriber subscriber { get; private set; }

        public SubscriberForm(Subscriber _subscriber)
        {
            InitializeComponent();
            subscriber = _subscriber;
            txtPhoneNumber.Text = subscriber.PhoneNumber;
            txtINN.Text = subscriber.INN;
            txtAddress.Text = subscriber.Address;

        }

        private void SubscriberForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем объект абонента на основе введенных данных
            subscriber = new Subscriber(
                txtPhoneNumber.Text,
                txtINN.Text,
                txtAddress.Text
            );

            // Закрываем форму с результатом OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
