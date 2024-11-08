using System;
using System.Collections.Generic;
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
using MasterPol;

namespace MasterPol
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MasterPolModel _dbContext;
        public MainWindow()
        {
            InitializeComponent();
            _dbContext = new MasterPolModel();
            LoadPartners();
        }
        // Загрузка данных партнёров в список
        private void LoadPartners()
        {
            PartnersListView.ItemsSource = _dbContext.Partners.ToList();
        }

        // Добавление нового партнёра
        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            var addPartnerWindow = new AddPartnerWindow(_dbContext);
            if (addPartnerWindow.ShowDialog() == true)
            {
                LoadPartners();
            }
        }

        // Редактирование выбранного партнёра
        private void EditPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            if (PartnersListView.SelectedItem is Partners selectedPartner)
            {
                // Передаем PartnerId партнера вместо Id
                var editWindow = new EditPartnerWindow(selectedPartner.PartnerID);
                editWindow.ShowDialog();

                // Обновляем данные списка после редактирования
                LoadPartners();
            }
            else
            {
                MessageBox.Show("Выберите партнёра для редактирования.");
            }
        }

        // Удаление выбранного партнёра
        private void DeletePartnerButton_Click(object sender, RoutedEventArgs e)
        {
            if (PartnersListView.SelectedItem is Partners selectedPartner)
            {
                _dbContext.Partners.Remove(selectedPartner);
                _dbContext.SaveChanges();
                LoadPartners();
            }
            else
            {
                MessageBox.Show("Выберите партнёра для удаления.");
            }
        }

        // Обработчик события SelectionChanged для PartnersListView
        private void PartnersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Логика для обработки события выбора элемента в ListView
            var selectedPartner = PartnersListView.SelectedItem as Partners; // Здесь Partner — это тип данных
            if (selectedPartner != null)
            {
                Console.WriteLine("Выбран партнёр: " + selectedPartner.CompanyName);
            }
        }



        private void ShowSalesHistory_Click(object sender, RoutedEventArgs e)
        {
            int selectedPartnerId = (PartnersListView.SelectedItem as Partners)?.PartnerID ?? 0;
            if (selectedPartnerId != 0)
            {
                var salesHistoryWindow = new SalesHistoryWindow(selectedPartnerId);
                salesHistoryWindow.Show();
            }
            else
            {
                MessageBox.Show("Выберите партнёра для просмотра истории продаж.");
            }
        }


        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                var textBlock = (TextBlock)textBox.Tag;
                if (textBlock != null)
                {
                    textBlock.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                var textBlock = (TextBlock)textBox.Tag;
                if (textBlock != null && string.IsNullOrEmpty(textBox.Text))
                {
                    textBlock.Visibility = Visibility.Visible;
                }
            }
        }
    }
}