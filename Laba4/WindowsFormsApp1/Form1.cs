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
        public Form1()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var city = new City();
            CityForm formCity = new CityForm(city);
            if (formCity.ShowDialog() == DialogResult.OK)
            {
                Storage.Cities[city.Name] = city;  // Используйте название города как ключ
                UpdateCitiesList();
            }
        }


        private void changepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var city = listViewCity.SelectedItems[0].Tag as City;
            CityForm formCity = new CityForm(city);
            if (formCity.ShowDialog() == DialogResult.OK)
            {
                UpdateCitiesList();
            }
        }

        private void UpdateCitiesList()
        {
            listViewCity.Items.Clear();
            foreach (var city in Storage.Cities.Values)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = city,
                    Text = city.ToString()
                };
                listViewCity.Items.Add(listViewItem);
            }
        }

        private void createcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var subscriber = new Subscriber();
            SubscriberForm formSubscriber = new SubscriberForm(subscriber);
            if (formSubscriber.ShowDialog() == DialogResult.OK)
            {
                Storage.Subscribers[subscriber.INN] = subscriber;  // Используйте ИНН как ключ
                UpdateSubscribersList();
            }
        }


        private void changecToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var subscriber = listViewSubscriber.SelectedItems[0].Tag as Subscriber;
            SubscriberForm formSubscriber = new SubscriberForm(subscriber);
            if (formSubscriber.ShowDialog() == DialogResult.OK)
            {
                UpdateSubscribersList();
            }
        }

        private void UpdateSubscribersList()
        {
            listViewSubscriber.Items.Clear();
            foreach (var subscriber in Storage.Subscribers.Values)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = subscriber,
                    Text = subscriber.ToString()
                };
                listViewSubscriber.Items.Add(listViewItem);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var call = new Call();
            CallForm callForm = new CallForm(call);
            if (callForm.ShowDialog() == DialogResult.OK)
            {
                Storage.Calls.Add(call);
                UpdateCallList();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var call = listViewCall.SelectedItems[0].Tag as Call;
            CallForm callForm = new CallForm(call);
            if (callForm.ShowDialog() == DialogResult.OK)
            {
                UpdateCallList();
            }
        }

        private void UpdateCallList()
        {
            listViewCall.Items.Clear();
            foreach (var call in Storage.Calls)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = call,
                    Text = call.Subscriber.ToString()
                };
                listViewItem.SubItems.Add(call.City.Name);
                listViewItem.SubItems.Add(call.CallDate.ToShortDateString());
                listViewItem.SubItems.Add(call.Minutes.ToString());
                listViewItem.SubItems.Add(call.TimeOfDay.ToString());

                listViewCall.Items.Add(listViewItem);
            }
        }

        private void listViewCall_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageCity_Click(object sender, EventArgs e)
        {

        }

        private void listViewCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
