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
using System.Windows.Shapes;

namespace MasterPol
{
    /// <summary>
    /// Логика взаимодействия для SalesHistoryWindow.xaml
    /// </summary>
    public partial class SalesHistoryWindow : Window
    {
        public SalesHistoryWindow(int partnerId)
        {
            InitializeComponent();
            LoadSalesHistory(partnerId);
        }
        private void LoadSalesHistory(int partnerId)
        {
            using (var context = new MasterPolModel())
            {
                var salesHistory = context.SalesHistory
                    .Where(s => s.PartnerID == partnerId)
                    .Select(s => new
                    {
                        s.SaleID,
                        s.PartnerID,
                        s.ProductID,
                        s.SaleDate,
                        s.Quantity,
                        s.SaleAmount
                    })
                    .ToList();

                SalesHistoryDataGrid.ItemsSource = salesHistory;
            }
        }
    }
}
