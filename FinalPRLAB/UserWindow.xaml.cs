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

namespace FinalPRLAB
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        private void Armor_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page21();
        }

        private void Donate_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page22();
        }

        private void Fraction_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page23();
        }

        private void Guns_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page24();
        }
    }
}
