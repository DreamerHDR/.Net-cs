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
        private City _city;

        // Свойство для передачи данных обратно
        public City City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                txtCityName.Text = _city.Name;
                numDayRate.Value = _city.DayRate;
                numNightRate.Value = _city.NightRate;
            }
        }

        public CityForm()
        {
            InitializeComponent();
        }

        public CityForm(City city) : this()
        {
            City = city;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _city.Name = txtCityName.Text;
            _city.DayRate = numDayRate.Value;
            _city.NightRate = numNightRate.Value;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CityForm_Load(object sender, EventArgs e)
        {

        }
    }
}

