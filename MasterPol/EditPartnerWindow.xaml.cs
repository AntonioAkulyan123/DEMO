using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace MasterPol
{
    /// <summary>
    /// Логика взаимодействия для EditPartnerWindow.xaml
    /// </summary>
    public partial class EditPartnerWindow : Window
    {
        private MasterPolModel _dbContext;
        private Partners _partner;
        public EditPartnerWindow(int partnerId)
        {
            InitializeComponent();

            _dbContext = new MasterPolModel();

            // Загрузка партнера по ID
            _partner = _dbContext.Partners.Find(partnerId);

            if (_partner != null)
            {
                DataContext = _partner;
                CompanyNameTextBox.Text = _partner.CompanyName;
                PartnerTypeTextBox.Text = _partner.PartnerType;
                LegalAddressTextBox.Text = _partner.LegalAddress;
                InnTextBox.Text = _partner.INN;
                DirectorNameTextBox.Text = _partner.DirectorName;
                PhoneTextBox.Text = _partner.Phone;
                EmailTextBox.Text = _partner.Email;
                LogoTextBox.Text = _partner.Logo;
                RatingTextBox.Text = _partner.Rating?.ToString();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Обновление информации о партнёре
            _partner.CompanyName = CompanyNameTextBox.Text;
            _partner.PartnerType = PartnerTypeTextBox.Text;
            _partner.LegalAddress = LegalAddressTextBox.Text;
            _partner.INN = InnTextBox.Text;
            _partner.DirectorName = DirectorNameTextBox.Text;
            _partner.Phone = PhoneTextBox.Text;
            _partner.Email = EmailTextBox.Text;
            _partner.Logo = LogoTextBox.Text;

            // Преобразование рейтинга в целое число, если поле не пустое
            if (int.TryParse(RatingTextBox.Text, out int rating))
                _partner.Rating = rating;
            else
                _partner.Rating = null;

            // Сохранение изменений в базе данных
            _dbContext.SaveChanges();

            MessageBox.Show("Изменения сохранены.");
            this.Close();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == "")
            {
                var placeholder = FindPlaceholder(textBox);
                if (placeholder != null) placeholder.Visibility = Visibility.Collapsed;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == "")
            {
                var placeholder = FindPlaceholder(textBox);
                if (placeholder != null) placeholder.Visibility = Visibility.Visible;
            }
        }

        private TextBlock FindPlaceholder(TextBox textBox)
        {
            // Ищем связанный TextBlock для placeholder
            var grid = (Grid)textBox.Parent;
            foreach (var child in grid.Children)
            {
                if (child is TextBlock textBlock)
                    return textBlock;
            }
            return null;
        }
    }
}
