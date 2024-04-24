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
    /// Логика взаимодействия для Page19.xaml
    /// </summary>
    public partial class Page19 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page19()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Users.ToList();
        }
        private void Button_Create(object sender, RoutedEventArgs e)
        {
            Users A = new Users();
            A.Name_ = TBX1.Text;
            A.MiddleName = TBX2.Text;
            A.Email = TBX3.Text;
            A.Card_Number = int.TryParse(TBX4.Text, out int result) ? (int)result : 0;
            A.CVV = int.TryParse(TBX5.Text, out int result1) ? (int)result1 : 0;
            bd.Users.Add(A);
            bd.SaveChanges();
            DG.ItemsSource = bd.Users.ToList();
        }

        private void Button_Deleate(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                bd.Users.Remove(DG.SelectedItem as Users);
                bd.SaveChanges();
                DG.ItemsSource = bd.Users.ToList();
            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                var selected = DG.SelectedItem as Users;
                selected.Email = TBX7.Text;
                bd.SaveChanges();
                DG.ItemsSource = bd.Users.ToList();
            }
        }
    }
}
