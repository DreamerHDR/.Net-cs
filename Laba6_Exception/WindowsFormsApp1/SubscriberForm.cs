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
        private Subscriber _subscriber;

        // Свойство для передачи данных обратно
        public Subscriber Subscriber
        {
            get { return _subscriber; }
            set
            {
                _subscriber = value;
                txtPhoneNumber.Text = _subscriber.PhoneNumber;
                txtINN.Text = _subscriber.INN;
                txtAddress.Text = _subscriber.Address;
            }
        }

        // Конструктор формы
        public SubscriberForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Обновляем данные абонента на основе введенных значений
            _subscriber.PhoneNumber = txtPhoneNumber.Text;
            _subscriber.INN = txtINN.Text;
            _subscriber.Address = txtAddress.Text;

            // Закрываем форму с результатом OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SubscriberForm_Load(object sender, EventArgs e)
        {
            // Здесь можно выполнять дополнительные действия при загрузке формы
        }
    }
}
