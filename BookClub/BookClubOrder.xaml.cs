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

namespace BookClub
{
    /// <summary>
    /// Логика взаимодействия для BookClubOrder.xaml
    /// </summary>
    public partial class BookClubOrder : Window
    {
      
        //private Product _temp = new Product();
        public BookClubOrder()
        {
            InitializeComponent();
            //if (selectedProduct != null) { _temp = selectedProduct; }
            //DataContext = _temp;
        }
    }
}
