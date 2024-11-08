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
    /// Логика взаимодействия для AddPartnerWindow.xaml
    /// </summary>
    public partial class AddPartnerWindow : Window
    {
        private MasterPolModel _dbContext;
        public AddPartnerWindow(MasterPolModel dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var newPartner = new Partners
            {
                CompanyName = CompanyNameTextBox.Text,
                PartnerType = PartnerTypeTextBox.Text,
                LegalAddress = LegalAddressTextBox.Text,
                INN = InnTextBox.Text,
                DirectorName = DirectorNameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Email = EmailTextBox.Text,
                Logo = null,
                Rating = int.TryParse(RatingTextBox.Text, out int rating) ? rating : (int?)null
            };

            _dbContext.Partners.Add(newPartner);
            _dbContext.SaveChanges();
            DialogResult = true;
            Close();
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
