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
    public partial class Form1 : Form
    {
        private City _city;
        private Call _call;
        private Subscriber _subscriber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void создатьАбонентаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _city = new City();
            CityForm cityForm = new CityForm(_city);
            if (cityForm.ShowDialog() == DialogResult.OK)
            {
                _city = cityForm.city;
                MessageBox.Show($"Город {_city.Name} добавлен!");
            }
        }


        private void changepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new CityForm(_city);

            if (cityForm.ShowDialog() == DialogResult.OK)
            {
                _city = cityForm.city;
                MessageBox.Show($"Город {_city.Name} изменен!");
            }
        }
        private void createcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _subscriber = new Subscriber();
            SubscriberForm subscriberForm = new SubscriberForm(_subscriber);
            if (subscriberForm.ShowDialog() == DialogResult.OK)
            {
                _subscriber = subscriberForm.subscriber;
                MessageBox.Show($"Данные добавлены");
            }
        }

        private void changecToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SubscriberForm subscriberForm = new SubscriberForm(_subscriber);

            if (subscriberForm.ShowDialog() ==DialogResult.OK)
            {
                _subscriber = subscriberForm.subscriber;
                MessageBox.Show($"Данные обновлены");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
