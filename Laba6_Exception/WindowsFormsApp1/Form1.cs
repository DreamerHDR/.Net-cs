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
        private readonly Storage _storage = Storage.Instance;
        private readonly CityForm _cityForm = new CityForm();
        private readonly SubscriberForm _subscriberForm = new SubscriberForm();
        private readonly CallForm _callForm = new CallForm();

        public Form1()
        {
            InitializeComponent();
            _storage.CityAdded += _storage_CityAdded;
            _storage.CityRemoved += _storage_CityRemoved;
            _storage.SubscriberAdded += _storage_SubscriberAdded;
            _storage.SubscriberRemoved += _storage_SubscriberRemoved;
            _storage.CallAdded += _storage_CallAdded;
            _storage.CallRemoved += _storage_CallRemoved;
        }

        private void _storage_CityRemoved(object sender, EventArgs e)
        {
            string city = (string)sender;
            for (int i = 0; i < listViewCity.Items.Count; i++)
            {
                if (((City)listViewCity.Items[i].Tag).Name == city)
                {
                    listViewCity.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _storage_CityAdded(object sender, EventArgs e)
        {
            var city = sender as City;
            if (city != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = city,
                    Text = city.ToString()
                };
                listViewCity.Items.Add(listViewItem);
            }
        }

        private void _storage_SubscriberRemoved(object sender, EventArgs e)
        {
            string subscriber = (string)sender;
            for (int i = 0; i < listViewSubscriber.Items.Count; i++)
            {
                if (((Subscriber)listViewSubscriber.Items[i].Tag).INN == subscriber)
                {
                    listViewSubscriber.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _storage_SubscriberAdded(object sender, EventArgs e)
        {
            var subscriber = sender as Subscriber;
            if (subscriber != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = subscriber,
                    Text = subscriber.ToString()
                };
                listViewSubscriber.Items.Add(listViewItem);
            }
        }

        private void _storage_CallRemoved(object sender, EventArgs e)
        {
            var call = sender as Call;
            if (call != null)
            {
                for (int i = 0; i < listViewCall.Items.Count; i++)
                {
                    if ((Call)listViewCall.Items[i].Tag == call)
                    {
                        listViewCall.Items.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void _storage_CallAdded(object sender, EventArgs e)
        {
            var call = sender as Call;
            if (call != null)
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

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var city = new City();
            _cityForm.City = city;
            if (_cityForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.AddCity(city);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении города: {ex.Message}");
                }
            }
        }

        private void changepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var city = listViewCity.SelectedItems[0].Tag as City;
                if (city != null)
                {
                    _cityForm.City = city;
                    if (_cityForm.ShowDialog() == DialogResult.OK)
                    {
                        listViewCity.SelectedItems[0].Text = city.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при изменении города: {ex.Message}");
            }
        }

        private void createcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var subscriber = new Subscriber();
            _subscriberForm.Subscriber = subscriber;
            if (_subscriberForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.AddSubscriber(subscriber);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении абонента: {ex.Message}");
                }
            }
        }

        private void changecToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var subscriber = listViewSubscriber.SelectedItems[0].Tag as Subscriber;
                if (subscriber != null)
                {
                    _subscriberForm.Subscriber = subscriber;
                    if (_subscriberForm.ShowDialog() == DialogResult.OK)
                    {
                        listViewSubscriber.SelectedItems[0].Text = subscriber.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при изменении абонента: {ex.Message}");
            }
        }

        private void добавитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var call = new Call();
            _callForm.Call = call;
            if (_callForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.AddCall(call);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении звонка: {ex.Message}");
                }
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var call = listViewCall.SelectedItems[0].Tag as Call;
                if (call != null)
                {
                    _callForm.Call = call;
                    if (_callForm.ShowDialog() == DialogResult.OK)
                    {
                        var listViewItem = listViewCall.SelectedItems[0];
                        listViewItem.Text = call.Subscriber.ToString();
                        listViewItem.SubItems[1].Text = call.City.Name;
                        listViewItem.SubItems[2].Text = call.CallDate.ToShortDateString();
                        listViewItem.SubItems[3].Text = call.Minutes.ToString();
                        listViewItem.SubItems[4].Text = call.TimeOfDay.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при изменении звонка: {ex.Message}");
            }
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listViewCity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var city = listViewCity.SelectedItems[0].Tag as City;
                    if (city != null)
                    {
                        _storage.RemoveCity(city.Name);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Не выбрана строка с номером");
                }
            }
        }

        private void listViewSubscriber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var subsciber = listViewSubscriber.SelectedItems[0].Tag as Subscriber;
                    if (subsciber != null)
                    {
                        _storage.RemoveSubscriber(subsciber.INN);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Не выбрана строка с номером");
                }
            }
        }

        private void listViewCall_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var call = listViewCall.SelectedItems[0].Tag as Call;
                    if (call != null)
                    {
                        _storage.RemoveCall(call);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Не выбрана строка с номером");
                }
            }
        }
    }
}

