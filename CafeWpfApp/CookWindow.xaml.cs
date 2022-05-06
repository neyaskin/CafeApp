using Microsoft.EntityFrameworkCore;
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

namespace CafeWpfApp
{
    /// <summary>
    /// Логика взаимодействия для CookWindow.xaml
    /// </summary>
    public partial class CookWindow : Window
    {
        public CookWindow()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            OrdersDGrid.ItemsSource = Helper.db.Orders.Where(a => a.StatusOrderId >= 2).Include(q => q.User).Include(w => w.StatusOrder).ToList();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void OrdersDGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Order selectedOrder = OrdersDGrid.SelectedItem as Order;

            if (selectedOrder != null)
            {
                if (selectedOrder.StatusOrderId == 2)
                {
                    selectedOrder.StatusOrderId = 3;
                    MessageBox.Show("Статус блюда изменен");
                }
                else if (selectedOrder.StatusOrderId == 3)
                {
                    selectedOrder.StatusOrderId = 4;
                    MessageBox.Show("Статус блюда изменен");
                }
                else if (selectedOrder.StatusOrderId == 4)
                {
                    selectedOrder.StatusOrderId = 3;
                    MessageBox.Show("Статус блюда изменен");
                }
                Helper.db.SaveChanges();
                LoadData();
            }

            OrdersDGrid.SelectedItem = null;
        }
    }
}
