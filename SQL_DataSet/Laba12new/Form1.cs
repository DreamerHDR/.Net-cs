using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Laba12new
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument = new PrintDocument();

        public Form1()
        {
            InitializeComponent();
            nameTextBox.Validating += nameTextBox_Validating;
            countryTextBox.Validating += countryTextBox_Validating;
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobileStore1DataSet.Manufacturers". При необходимости она может быть перемещена или удалена.
            this.manufacturersTableAdapter.Fill(this.mobileStore1DataSet.Manufacturers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobileStore1DataSet.Phones". При необходимости она может быть перемещена или удалена.
            this.phonesTableAdapter.Fill(this.mobileStore1DataSet.Phones);

        }

        private void phonesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phonesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mobileStore1DataSet);
        }

        private void загрузитьТаблицу1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.phonesTableAdapter.Fill(this.mobileStore1DataSet.Phones);
        }

        private void загрузитьТаблицу2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.manufacturersTableAdapter.Fill(this.mobileStore1DataSet.Manufacturers);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mobileStore1DataSet);
        }

        private void загрузитьИзображениеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)phonesBindingSource.Current;
            MobileStore1DataSet.PhonesRow pr = (MobileStore1DataSet.PhonesRow)(drw.Row);

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = System.Drawing.Image.FromFile(ofd.FileName);
                toolStripStatusLabel1.Text = "Фотография загружена успешно";
            }
        }

        private void сохранитьИзображениеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)phonesBindingSource.Current;
            MobileStore1DataSet.PhonesRow pr = (MobileStore1DataSet.PhonesRow)(drw.Row);

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (imagePictureBox.Image != null)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    imagePictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                    toolStripStatusLabel1.Text = "Фотография успешно сохранена";
                }
            }
        }

        private void свойстваToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = imagePictureBox;
        }

        private void nameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                // Установить ошибку
                errorProvider1.SetError(nameTextBox, "Поле 'Название' не может быть пустым.");
                e.Cancel = true; // Отменить переход к следующему элементу
            }
            else
            {
                // Удалить ошибку
                errorProvider1.SetError(nameTextBox, string.Empty);
            }
        }

        private void countryTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                // Установить ошибку
                errorProvider1.SetError(countryTextBox, "Поле 'Страна' не может быть пустым.");
                e.Cancel = true; // Отменить переход к следующему элементу
            }
            else
            {
                // Удалить ошибку
                errorProvider1.SetError(countryTextBox, string.Empty);
            }
        }

        private void SaveImageToPdf(string filePath)
        {
            Document pdfDoc = new Document();
            try
            {
                PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                pdfDoc.Open();

                if (imagePictureBox.Image != null)
                {
                    // Преобразование изображения в iTextSharp формат
                    iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(imagePictureBox.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    pdfImage.ScaleToFit(pdfDoc.PageSize.Width - 20, pdfDoc.PageSize.Height - 20);
                    pdfDoc.Add(pdfImage);
                }
                else
                {
                    pdfDoc.Add(new Paragraph("Нет изображения для сохранения в PDF."));
                }

                // Получение данных из текущей строки
                DataRowView drw = (DataRowView)phonesBindingSource.Current;
                MobileStore1DataSet.PhonesRow pr = (MobileStore1DataSet.PhonesRow)(drw.Row);

                // Добавление текста
                string model = pr.Model; // Предполагаем, что это свойство модели
                string price = pr.Price.ToString(); // Предполагаем, что это свойство цены

                pdfDoc.Add(new Paragraph($"Модель: {model}"));
                pdfDoc.Add(new Paragraph($"Цена: {price} руб."));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании PDF: " + ex.Message);
            }
            finally
            {
                pdfDoc.Close();
            }
        }


        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Получение данных из текущей строки
            DataRowView drw = (DataRowView)phonesBindingSource.Current;
            MobileStore1DataSet.PhonesRow pr = (MobileStore1DataSet.PhonesRow)(drw.Row);

            // Позиции для рисования
            float x = 10; // отступ от левого края
            float y = 10; // отступ от верхнего края

            // Рисуем изображение из PictureBox
            if (imagePictureBox.Image != null)
            {
                e.Graphics.DrawImage(imagePictureBox.Image, x, y);
                y += imagePictureBox.Image.Height + 100; // обновляем y для следующего текста
            }
            else
            {
                e.Graphics.DrawString("Нет изображения для печати", new System.Drawing.Font("Arial", 20), Brushes.Black, new PointF(100, 100));
                y += 50; // отступ, если изображения нет
            }

            // Рисуем текст (модель и цена)
            string model = pr.Model; // Предполагаем, что это свойство модели
            string price = pr.Price.ToString(); // Предполагаем, что это свойство цены

            e.Graphics.DrawString($"Модель: {model}", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(x, y));
            y += 25; // отступ между строками
            e.Graphics.DrawString($"Цена: {price} руб.", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(x, y));
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Окно предварительного просмотра
            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            // Сохранение в PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Сохранить как PDF"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveImageToPdf(saveFileDialog.FileName);
            }

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
