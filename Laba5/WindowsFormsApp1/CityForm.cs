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

    public partial class CityForm : Form
    {
        // Свойство для передачи данных обратно
        public City city { get; private set; }

        public CityForm(City _city)
        {
            InitializeComponent();
            city = _city;
            txtCityName.Text = city.Name;
            numDayRate.Value = city.DayRate;
            numNightRate.Value = city.NightRate;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем объект города на основе введенных данных
            city = new City(
                txtCityName.Text,
                numDayRate.Value,
                numNightRate.Value
            );

            // Закрываем форму с результатом OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
