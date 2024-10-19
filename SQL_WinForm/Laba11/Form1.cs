using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Laba11.Models;

namespace Laba11
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection _connection;
        public Form1()
        {
            InitializeComponent();
            _connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MobileStore;Integrated Security=True;");

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var phones = MobilePhone.List(_connection);
            listViewPhones.Items.Clear();
            foreach (var phone in phones)
            {
                var listViewItem = listViewPhones.Items.Add(phone.PhoneID.ToString());
                listViewItem.Tag = phone;
                listViewItem.SubItems.Add(phone.Model);
                listViewItem.SubItems.Add(phone.Price.ToString("F2"));
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormMobile formMobile = new FormMobile
            {
                MobilePhone = new MobilePhone()
            };
            if (formMobile.ShowDialog() == DialogResult.OK)
            {
                MobilePhone.Insert(_connection, formMobile.MobilePhone);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (listViewPhones.SelectedItems.Count > 0)
            {
                FormMobile formMobile = new FormMobile
                {
                    MobilePhone = (MobilePhone)listViewPhones.SelectedItems[0].Tag
                };
                if (formMobile.ShowDialog() == DialogResult.OK)
                {
                    MobilePhone.Update(_connection, formMobile.MobilePhone);
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MobilePhone.Delete(_connection, ((MobilePhone)listViewPhones.SelectedItems[0].Tag).PhoneID);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // Получаем список производителей
            var makers = Maker.List(_connection);
            listViewMakers.Items.Clear(); // Очищаем список

            // Заполняем ListView данными производителей
            foreach (var maker in makers)
            {
                var listViewItem = listViewMakers.Items.Add(maker.ManufacturerID.ToString());
                listViewItem.Tag = maker;
                listViewItem.SubItems.Add(maker.Name);
                listViewItem.SubItems.Add(maker.Country);
                listViewItem.SubItems.Add(maker.PhoneID.ToString());
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e) // Добавить нового производителя
        {
            FormMaker formMaker = new FormMaker
            {
                Maker = new Maker() // Создаем новый объект Maker
            };
            if (formMaker.ShowDialog() == DialogResult.OK)
            {
                Maker.Insert(_connection, formMaker.Maker); // Метод для вставки нового производителя
                toolStripButton5_Click(sender, e); // Обновляем список производителей
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e) // Редактировать выбранного производителя
        {
            if (listViewMakers.SelectedItems.Count > 0)
            {
                FormMaker formMaker = new FormMaker
                {
                    Maker = (Maker)listViewMakers.SelectedItems[0].Tag // Получаем выбранного производителя
                };
                if (formMaker.ShowDialog() == DialogResult.OK)
                {
                    Maker.Update(_connection, formMaker.Maker); // Метод для обновления производителя
                    toolStripButton5_Click(sender, e); // Обновляем список производителей
                }
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Maker.Delete(_connection, ((Maker)listViewMakers.SelectedItems[0].Tag).ManufacturerID); // Метод для удаления производителя
            toolStripButton5_Click(sender, e); // Обновляем список производителей
        }
    }
}
