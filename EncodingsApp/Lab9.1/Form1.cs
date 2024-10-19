using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавляем популярные кодировки в ComboBox
            comboBoxEncoding.Items.Add("UTF-8");
            comboBoxEncoding.Items.Add("Windows-1251");
            comboBoxEncoding.Items.Add("ISO-8859-1");
            comboBoxEncoding.Items.Add("ASCII");

            // Устанавливаем UTF-8 как кодировку по умолчанию
            comboBoxEncoding.SelectedIndex = 0;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Открываем диалог выбора файла
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Получаем выбранную кодировку из ComboBox
                        string selectedEncoding = comboBoxEncoding.SelectedItem.ToString();
                        Encoding encoding = Encoding.GetEncoding(selectedEncoding);

                        // Читаем содержимое файла с выбранной кодировкой
                        string content = File.ReadAllText(openFileDialog.FileName, encoding);

                        // Отображаем содержимое в TextBox
                        textBoxContent.Text = content;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Открываем диалог сохранения файла
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Получаем выбранную кодировку из ComboBox
                        string selectedEncoding = comboBoxEncoding.SelectedItem.ToString();
                        Encoding encoding = Encoding.GetEncoding(selectedEncoding);

                        // Сохраняем содержимое TextBox в файл с выбранной кодировкой
                        File.WriteAllText(saveFileDialog.FileName, textBoxContent.Text, encoding);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
                    }
                }
            }
        }
    }
}
