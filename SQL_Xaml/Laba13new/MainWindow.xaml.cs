using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba13new
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Laba13new.MobileStore1DataSet mobileStore1DataSet = ((Laba13new.MobileStore1DataSet)(this.FindResource("mobileStore1DataSet")));
            // Загрузить данные в таблицу Phones. Можно изменить этот код как требуется.
            Laba13new.MobileStore1DataSetTableAdapters.PhonesTableAdapter mobileStore1DataSetPhonesTableAdapter = new Laba13new.MobileStore1DataSetTableAdapters.PhonesTableAdapter();
            mobileStore1DataSetPhonesTableAdapter.Fill(mobileStore1DataSet.Phones);
            System.Windows.Data.CollectionViewSource phonesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("phonesViewSource")));
            phonesViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Manufacturers. Можно изменить этот код как требуется.
            Laba13new.MobileStore1DataSetTableAdapters.ManufacturersTableAdapter mobileStore1DataSetManufacturersTableAdapter = new Laba13new.MobileStore1DataSetTableAdapters.ManufacturersTableAdapter();
            mobileStore1DataSetManufacturersTableAdapter.Fill(mobileStore1DataSet.Manufacturers);
            System.Windows.Data.CollectionViewSource manufacturersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("manufacturersViewSource")));
            manufacturersViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем DataSet из ресурсов окна
                Laba13new.MobileStore1DataSet mobileStore1DataSet = ((Laba13new.MobileStore1DataSet)(this.FindResource("mobileStore1DataSet")));

                // Создаем адаптер для сохранения данных
                Laba13new.MobileStore1DataSetTableAdapters.PhonesTableAdapter phonesTableAdapter = new Laba13new.MobileStore1DataSetTableAdapters.PhonesTableAdapter();

                // Сохраняем изменения в базе данных
                phonesTableAdapter.Update(mobileStore1DataSet.Phones);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (phonesDataGrid.SelectedItem != null)
            {
                // Удаляем выбранную строку из DataGrid и DataSet
                var selectedRow = ((DataRowView)phonesDataGrid.SelectedItem).Row;
                selectedRow.Delete();

                // Адаптер для работы с базой данных
                Laba13new.MobileStore1DataSet mobileStore1DataSet = ((Laba13new.MobileStore1DataSet)(this.FindResource("mobileStore1DataSet")));
                Laba13new.MobileStore1DataSetTableAdapters.PhonesTableAdapter phonesTableAdapter = new Laba13new.MobileStore1DataSetTableAdapters.PhonesTableAdapter();

                // Сохраняем изменения
                phonesTableAdapter.Update(mobileStore1DataSet.Phones);
                MessageBox.Show("Запись удалена!");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.");
            }
        }

        private void UploadImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Открываем диалоговое окно для выбора изображения
                Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == true)
                {
                    // Получаем путь к выбранному файлу
                    string filePath = openFileDialog.FileName;

                    // Находим текущую выбранную строку в DataGrid
                    if (phonesDataGrid.SelectedItem is DataRowView selectedRow)
                    {
                        // Загружаем изображение в колонку "Image" как массив байтов
                        selectedRow["Image"] = File.ReadAllBytes(filePath);

                        // (Если у вас есть адаптер, вы можете сохранить изменения в базе данных)
                        Laba13new.MobileStore1DataSet mobileStore1DataSet = ((Laba13new.MobileStore1DataSet)(this.FindResource("mobileStore1DataSet")));
                        Laba13new.MobileStore1DataSetTableAdapters.PhonesTableAdapter phonesTableAdapter = new Laba13new.MobileStore1DataSetTableAdapters.PhonesTableAdapter();
                        phonesTableAdapter.Update(mobileStore1DataSet.Phones);

                        MessageBox.Show("Изображение загружено и сохранено в базе данных!");
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, выберите запись для загрузки изображения.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке изображения: " + ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем доступ к DataSet и адаптеру
                MobileStore1DataSet mobileStore1DataSet = ((MobileStore1DataSet)(this.FindResource("mobileStore1DataSet")));
                MobileStore1DataSetTableAdapters.ManufacturersTableAdapter manufacturersTableAdapter = new MobileStore1DataSetTableAdapters.ManufacturersTableAdapter();

                // Сохраняем изменения в базе данных
                manufacturersTableAdapter.Update(mobileStore1DataSet.Manufacturers);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message);
            }
        }


        private void phonesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                // Находим текущую выбранную строку в DataGrid
                if (manufacturersDataGrid.SelectedItem is DataRowView selectedRow)
                {
                    // Удаляем выбранную строку
                    selectedRow.Delete();

                    // Получаем доступ к DataSet и адаптеру
                    MobileStore1DataSet mobileStore1DataSet = ((MobileStore1DataSet)(this.FindResource("mobileStore1DataSet")));
                    MobileStore1DataSetTableAdapters.ManufacturersTableAdapter manufacturersTableAdapter = new MobileStore1DataSetTableAdapters.ManufacturersTableAdapter();

                    // Сохраняем изменения в базе данных
                    manufacturersTableAdapter.Update(mobileStore1DataSet.Manufacturers);
                    MessageBox.Show("Производитель удалён!");
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите производителя для удаления.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении производителя: " + ex.Message);
            }
        }
    }
    
}
