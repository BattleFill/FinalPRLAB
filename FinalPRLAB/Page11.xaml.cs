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
    /// Логика взаимодействия для Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page11()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Armor.ToList();
        }
        private void Button_Create(object sender, RoutedEventArgs e)
        {
            Armor A = new Armor();
            A.Name_armor = TBX1.Text;
            bd.Armor.Add(A);
            bd.SaveChanges();
            DG.ItemsSource = bd.Armor.ToList();
        }

        private void Button_Deleate(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                bd.Armor.Remove(DG.SelectedItem as Armor);
                bd.SaveChanges();
                DG.ItemsSource = bd.Armor.ToList();
            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                var selected = DG.SelectedItem as Armor;
                selected.Name_armor = TBX7.Text;
                bd.SaveChanges();
                DG.ItemsSource = bd.Armor.ToList();
            }
        }
    }
}
