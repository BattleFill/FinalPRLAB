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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page10();
        }

        private void Armor_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page11();
        }

        private void Armor_on_akk_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page12();
        }

        private void Cheque_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page13();
        }

        private void Donate_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page14();
        }

        private void Fraction_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page15();
        }

        private void Guns_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page16();
        }

        private void Gun_on_akk_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page17();
        }

        private void Roles_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page18();
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page19();
        }
    }
}
