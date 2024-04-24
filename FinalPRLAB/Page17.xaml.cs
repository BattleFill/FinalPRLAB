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
    /// Логика взаимодействия для Page17.xaml
    /// </summary>
    public partial class Page17 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page17()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Gun_on_akk.ToList();
        }
        private void Button_Create(object sender, RoutedEventArgs e)
        {
            Gun_on_akk A = new Gun_on_akk();
            A.Account_ID = int.TryParse(TBX1.Text, out int result) ? (int)result : 0;
            A.Gun_ID = A.Account_ID = int.TryParse(TBX1.Text, out int result1) ? (int)result1 : 0;
            bd.Gun_on_akk.Add(A);
            bd.SaveChanges();
            DG.ItemsSource = bd.Gun_on_akk.ToList();
        }

        private void Button_Deleate(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                bd.Gun_on_akk.Remove(DG.SelectedItem as Gun_on_akk);
                bd.SaveChanges();
                DG.ItemsSource = bd.Gun_on_akk.ToList();
            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            bd.SaveChanges();
            DG.ItemsSource = bd.Gun_on_akk.ToList();
        }
    }
}
