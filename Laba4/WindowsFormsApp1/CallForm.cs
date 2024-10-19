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
        // Свойство для хранения объекта Call
        public Call Call { get; }

        // Конструктор формы с параметром Call
        public CallForm(Call call)
        {
            InitializeComponent();
            Call = call;

            // Заполняем ComboBox для абонентов
            foreach (var item in Storage.Subscribers)
            {
                var subscriber = item.Value;
                SubscriberBox.Items.Add(subscriber);
            }

            // Заполняем ComboBox для городов
            foreach (var item in Storage.Cities)
            {
                var city = item.Value;
                CityBox.Items.Add(city);
            }

            // Устанавливаем начальные значения, если это редактирование
            SubscriberBox.SelectedItem = call.Subscriber;
            CityBox.SelectedItem = call.City;
            DateCall.Value = call.CallDate;
            MinuteNum.Value = call.Minutes;
            ButtonDay.Checked = (call.TimeOfDay == TimeOfDay.Day);
            ButtonNight.Checked = (call.TimeOfDay == TimeOfDay.Night);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Call.Subscriber = SubscriberBox.SelectedItem as Subscriber;
            Call.City = CityBox.SelectedItem as City;
            Call.CallDate = DateCall.Value;
            Call.Minutes = (int)MinuteNum.Value;
            Call.TimeOfDay = ButtonDay.Checked ? TimeOfDay.Day : TimeOfDay.Night;

            // Закрываем форму с результатом OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
