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
    /// Логика взаимодействия для Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page10()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Account.ToList();
        }
        private void Button_Create(object sender, RoutedEventArgs e)
        {
            Account A = new Account();
            A.Account_Name = TBX1.Text;
            A.Login_ = TBX2.Text;
            A.Password_ = TBX3.Text;
            A.Users_ID = int.TryParse(TBX4.Text, out int result) ? (int?)result : null;
            A.Fraction_ID = int.TryParse(TBX5.Text, out int result1) ? (int?)result1 : null;
            A.Role_ID = int.TryParse(TBX6.Text, out int result2) ? (int)result2 : 0;
            bd.Account.Add(A);
            bd.SaveChanges();
            DG.ItemsSource = bd.Account.ToList();
        }

        private void Button_Deleate(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                bd.Account.Remove(DG.SelectedItem as Account);
                bd.SaveChanges();
                DG.ItemsSource = bd.Account.ToList();
            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                var selected = DG.SelectedItem as Account;
                selected.Account_Name = TBX7.Text;
                bd.SaveChanges();
                DG.ItemsSource = bd.Account.ToList();
            }
        }
    }
}
