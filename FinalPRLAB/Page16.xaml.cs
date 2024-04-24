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
    /// Логика взаимодействия для Page16.xaml
    /// </summary>
    public partial class Page16 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page16()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Guns.ToList();
        }
        private void Button_Create(object sender, RoutedEventArgs e)
        {
            Guns A = new Guns();
            A.Name_gun = TBX1.Text;
            bd.Guns.Add(A);
            bd.SaveChanges();
            DG.ItemsSource = bd.Guns.ToList();
        }

        private void Button_Deleate(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                bd.Guns.Remove(DG.SelectedItem as Guns);
                bd.SaveChanges();
                DG.ItemsSource = bd.Guns.ToList();
            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                var selected = DG.SelectedItem as Guns;
                selected.Name_gun = TBX7.Text;
                bd.SaveChanges();
                DG.ItemsSource = bd.Guns.ToList();
            }
        }
    }
}
