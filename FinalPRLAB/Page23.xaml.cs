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

namespace FinalPRLAB
{
    /// <summary>
    /// Логика взаимодействия для Page23.xaml
    /// </summary>
    public partial class Page23 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page23()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Fraction.ToList();
            ClearCBX.ItemsSource = bd.Account.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = bd.Fraction.ToList().Where(item  => item.Fraction_Name.Contains(SearchTBX.Text)).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = bd.Fraction.ToList();
        }

        private void ClearCBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ClearCBX.SelectedItem != null)
            {
                var selected = ClearCBX.SelectedItem as Account;
                DG.ItemsSource = bd.Fraction.ToList().Where(item => item == selected.Fraction);
            }
        }
    }
}
