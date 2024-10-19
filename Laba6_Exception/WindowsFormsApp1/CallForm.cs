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
    public partial class CallForm : Form
    {

        private Call _call;
        public Call Call
        {
            get { return _call; }
            set
            {
                _call = value;
                SubscriberBox.SelectedItem = _call.Subscriber;
                CityBox.SelectedItem = _call.City;
                DateCall.Value = _call.CallDate;
                MinuteNum.Value = _call.Minutes;
                ButtonDay.Checked = (_call.TimeOfDay == TimeOfDay.Day);
                ButtonNight.Checked = (_call.TimeOfDay == TimeOfDay.Night);
            }
        }
        private readonly Storage _storage = Storage.Instance;
        public CallForm()
        {
            InitializeComponent();
            _storage.SubscriberAdded += _storage_SubscriberAdded;
            _storage.SubscriberRemoved += _storage_SubscriberRemoved;
            _storage.CityAdded += _storage_CityAdded;
            _storage.CityRemoved += _storage_CityRemoved;

            foreach (var subscriber in _storage.Subscribers)
            {
                SubscriberBox.Items.Add(subscriber);
            }
            foreach (var city in _storage.Cities)
            {
                CityBox.Items.Add(city);
            }
        }

        private void _storage_SubscriberAdded(object sender, EventArgs e)
        {
            SubscriberBox.Items.Add(sender);
        }

        private void _storage_SubscriberRemoved(object sender, EventArgs e)
        {
            string key = (string)sender;
            for (int i = 0; i < SubscriberBox.Items.Count; i++)
            {
                var room = SubscriberBox.Items[i] as Subscriber;
                if (room?.INN == key)
                {
                    SubscriberBox.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _storage_CityAdded(object sender, EventArgs e)
        {
            CityBox.Items.Add(sender);
        }

        private void _storage_CityRemoved(object sender, EventArgs e)
        {
            string key = (string)sender;
            for (int i = 0; i < CityBox.Items.Count; i++)
            {
                var room = CityBox.Items[i] as City;
                if (room?.Name == key)
                {
                    CityBox.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _call.Subscriber = SubscriberBox.SelectedItem as Subscriber;
            _call.City = CityBox.SelectedItem as City;
            _call.CallDate = DateCall.Value;
            _call.Minutes = (int)MinuteNum.Value;
            _call.TimeOfDay = ButtonDay.Checked ? TimeOfDay.Day : TimeOfDay.Night;

            // Закрываем форму с результатом OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

