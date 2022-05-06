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
    /// Логика взаимодействия для WaiterWindow.xaml
    /// </summary>
    public partial class WaiterWindow : Window
    {
        public WaiterWindow()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            OrdersDGrid.ItemsSource = Helper.db.Orders.Where(q=>q.StatusOrderId <= 2).Include(w=>w.StatusOrder).Include(e=>e.User).ToList();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddOrderWindow().Show();
            this.Close();
        }

        private void EditOrderBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            Order selectedOrder = OrdersDGrid.SelectedItem as Order;

            if (selectedOrder != null)
            {
                Helper.db.Orders.Remove(selectedOrder);
                Helper.db.SaveChanges();
                LoadData();

                MessageBox.Show("Заказ удален");
            }
        }

        private void OrdersDGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Order selectedOrder = OrdersDGrid.SelectedItem as Order;

            if (selectedOrder != null)
            {
                if (selectedOrder.StatusOrderId == 1)
                {
                    selectedOrder.StatusOrderId = 2;
                    Helper.db.SaveChanges();
                    LoadData();
                }
                else
                {
                    selectedOrder.StatusOrderId = 1;
                    Helper.db.SaveChanges();
                    LoadData();
                }

                MessageBox.Show(
                    "Статус заказа изменен",
                    "Info",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }

            OrdersDGrid.SelectedItem = null;
        }
    }
}
