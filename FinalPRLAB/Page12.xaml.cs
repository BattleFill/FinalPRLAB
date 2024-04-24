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
    /// Логика взаимодействия для Page12.xaml
    /// </summary>
    public partial class Page12 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page12()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Armor_on_akk.ToList();
        }
        private void Button_Create(object sender, RoutedEventArgs e)
        {
            Armor_on_akk A = new Armor_on_akk();
            A.Account_ID = int.TryParse(TBX1.Text, out int result) ? (int)result : 0;
            A.Armor_ID = int.TryParse(TBX2.Text, out int result1) ? (int)result1 : 0;
            bd.Armor_on_akk.Add(A);
            bd.SaveChanges();
            DG.ItemsSource = bd.Armor_on_akk.ToList();
        }

        private void Button_Deleate(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                bd.Armor_on_akk.Remove(DG.SelectedItem as Armor_on_akk);
                bd.SaveChanges();
                DG.ItemsSource = bd.Armor_on_akk.ToList();
            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            bd.SaveChanges();
            DG.ItemsSource = bd.Armor_on_akk.ToList();
        }
    }
}
