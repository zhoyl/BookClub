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

namespace BookClub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int kol = 0;
        public MainWindow()
        {
            InitializeComponent();
            dgTov.ItemsSource = bookClubEntities.GetContext().Product.ToList();
        }

        private void cmToTemp_Click(object sender, RoutedEventArgs e)
        {
            kol++;
            lblKol.Content = kol.ToString();
            btnTemp.Visibility = Visibility.Visible;
            btnTemp.IsEnabled = true;
           
        }

        private void btnTemp_Click(object sender, RoutedEventArgs e)
        {
            
            BookClubOrder bko = new BookClubOrder();
            bko.Show();
            this.Close();

        }
    }
}
