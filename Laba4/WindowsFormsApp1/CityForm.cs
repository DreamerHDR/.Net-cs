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
        public City City { get; private set; }

        public CityForm(City city)
        {
            InitializeComponent();
            City = city;
            txtCityName.Text = City.Name;
            numDayRate.Value = City.DayRate;
            numNightRate.Value = City.NightRate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Обновляем объект города на основе введенных данных
            City.Name = txtCityName.Text;
            City.DayRate = numDayRate.Value;
            City.NightRate = numNightRate.Value;

            // Закрываем форму с результатом OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
