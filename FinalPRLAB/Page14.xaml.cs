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
    /// Логика взаимодействия для Page14.xaml
    /// </summary>
    public partial class Page14 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page14()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Donate.ToList();
        }
        private void Button_Create(object sender, RoutedEventArgs e)
        {
            Donate A = new Donate();
            A.Donate_Name = TBX1.Text;
            A.Donate_Cost = int.TryParse(TBX2.Text, out int result) ? (int)result : 0;
            bd.Donate.Add(A);
            bd.SaveChanges();
            DG.ItemsSource = bd.Donate.ToList();
        }

        private void Button_Deleate(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                bd.Donate.Remove(DG.SelectedItem as Donate);
                bd.SaveChanges();
                DG.ItemsSource = bd.Donate.ToList();
            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            bd.SaveChanges();
            DG.ItemsSource = bd.Donate.ToList();
        }
    }
}
