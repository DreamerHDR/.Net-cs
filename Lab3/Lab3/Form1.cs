using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Настройка диапазона для NumericUpDown
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 100;

            // Привязка обработчика события
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Очистка TextBox
            textBox1.Clear();

            // Получение значения из NumericUpDown
            int maxValue = (int)numericUpDown1.Value;

            // Создание строки с числами от 1 до maxValue
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= maxValue; i++)
            {
                sb.Append(i);
                if (i < maxValue)
                {
                    sb.Append(" ");
                }
            }

            // Заполнение TextBox
            textBox1.Text = sb.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                comboBox1.Items.Add(textBox2.Text);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox4.Text, out double num1) &&
                double.TryParse(textBox5.Text, out double num2))
            {
                // Сложение чисел и вывод результата в TextBox3
                textBox6.Text = (num1 + num2).ToString();
            }
            else
            {
                // Обработка ошибок при вводе нечисловых значений
                MessageBox.Show("Пожалуйста, введите корректные вещественные числа в оба TextBox.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox4.Text, out double num1) &&
                double.TryParse(textBox5.Text, out double num2))
            {
                // Сложение чисел и вывод результата в TextBox3
                textBox6.Text = (num1 - num2).ToString();
            }
            else
            {
                // Обработка ошибок при вводе нечисловых значений
                MessageBox.Show("Пожалуйста, введите корректные вещественные числа в оба TextBox.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox4.Text, out double num1) &&
                double.TryParse(textBox5.Text, out double num2))
            {
                // Сложение чисел и вывод результата в TextBox3
                textBox6.Text = (num1 * num2).ToString();
            }
            else
            {
                // Обработка ошибок при вводе нечисловых значений
                MessageBox.Show("Пожалуйста, введите корректные вещественные числа в оба TextBox.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox4.Text, out double num1) &&
                double.TryParse(textBox5.Text, out double num2))
            {
                // Сложение чисел и вывод результата в TextBox3
                textBox6.Text = (num1 / num2).ToString();
            }
            else
            {
                // Обработка ошибок при вводе нечисловых значений
                MessageBox.Show("Пожалуйста, введите корректные вещественные числа в оба TextBox.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Очищаем ComboBox перед обработкой
            comboBox2.Items.Clear();

            // Получаем текст из TextBox и разбиваем его на строки
            string[] lines = textBox7.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                // Проверяем, является ли строка вещественным числом
                if (double.TryParse(line, out double number))
                {
                    // Если да, добавляем число в ComboBox
                    comboBox2.Items.Add(number);
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            // Очищаем TextBox перед выводом результатов
            textBox8.Clear();
            decimal x = 1;

            decimal f = numericUpDown2.Value;

            // Инициализация переменной суммы
            decimal sum = 0;
            int n = 1; // Начальное значение для n (число в знаменателе)

            // Расчет суммы ряда
            while (true)
            {
                // Вычисление текущего члена ряда
                decimal term = 1 / (n * x);

                // Добавляем член ряда к сумме
                sum += term;

                // Вывод промежуточного значения в TextBox
                textBox8.AppendText($"Сумма для n={n}: {sum}  \n\n");
                string str = "\n";
                textBox8.AppendText(str);
                //textBox8.AppendText(sum.ToString());
                //Проверка условия выхода из цикла
                if (term < f)
                {
                    break;
                }
                n++; // Переход к следующему члену ряда
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox10.Clear();

            // Получаем все строки из TextBox № 1
            string[] lines = textBox9.Lines;

            // Список для хранения строк, которые не являются вещественными числами
            List<string> nonNumericLines = new List<string>();

            // Проверяем каждую строку
            foreach (string line in lines)
            {
                // Проверяем, является ли строка вещественным числом
                if (!decimal.TryParse(line, out _))
                {
                    // Если не является, добавляем в список
                    nonNumericLines.Add(line);
                }
            }

            // Добавляем строки в TextBox № 2 в обратном порядке
            for (int i = nonNumericLines.Count - 1; i >= 0; i--)
            {
                textBox10.AppendText(nonNumericLines[i] + Environment.NewLine);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Очищаем TextBox №4 перед выводом результатов
            textBox14.Clear();

            try
            {
                // Получаем значения a, b и h из текстовых полей
                double a = double.Parse(textBox11.Text);
                double b = double.Parse(textBox12.Text);
                double h = double.Parse(textBox13.Text);

                // Проверяем, чтобы шаг не был равен нулю и a было меньше b
                if (h <= 0)
                {
                    MessageBox.Show("Шаг h должен быть положительным числом.");
                    return;
                }

                if (a >= b)
                {
                    MessageBox.Show("Начальное значение a должно быть меньше конечного значения b.");
                    return;
                }

                // Табулируем функцию f(x) = sin(x) / (|x| + 1)
                for (double x = a; x <= b; x += h)
                {
                    double fx = Math.Sin(x) / (Math.Abs(x) + 1);
                    textBox14.AppendText($"x={x};   f(x)={fx}\r\n   ");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для a, b и h.");
            }
        }
    }
}
