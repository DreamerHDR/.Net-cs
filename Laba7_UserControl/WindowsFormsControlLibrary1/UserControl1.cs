using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba4;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        private readonly Storage _storage = Storage.Instance;
        public Call Call { get; }

        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (value)
                {
                    var controls = Parent?.Controls;
                    if (controls != null)
                    {
                        foreach (var control in controls)
                        {
                            if (!(control is UserControl1)) continue;
                            var userControlCall = control as UserControl1;
                            if (userControlCall != this)
                            {
                                userControlCall.Selected = false;
                            }
                        }
                    }
                }
                _selected = value;
                Refresh(); // Перерисовка элемента управления при изменении выделения
            }
        }

        public UserControl1(Call call)
        {
            InitializeComponent();
            Call = call;
        }

        private void UserControlCall_Paint(object sender, PaintEventArgs e)
        {
            textBoxCity.Text = Call.City.Name;
            textBoxSubscriber.Text = $@"{Call.Subscriber.PhoneNumber} {Call.Subscriber.INN}.{Call.Subscriber.Address}.";
            textBoxDateCall.Text = Call.CallDate.ToShortDateString();
            textBoxMinute.Text = Call.Minutes.ToString();
            textBoxDayNight.Text = Call.TimeOfDay.ToString();

            // Пример изменения цвета в зависимости от времени суток звонка
            textBoxDayNight.BackColor = Call.TimeOfDay == TimeOfDay.Day ? Color.Yellow : Color.Blue;

            // Устанавливаем цвет фона, если элемент выбран
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;
        }

        private void UserControlCall_Click(object sender, EventArgs e)
        {
            Selected = true;
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _storage.RemoveCall(Call); // Удаляем звонок из хранилища
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о звонке");
            }
        }
    }
}
