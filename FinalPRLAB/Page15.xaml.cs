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
    /// Логика взаимодействия для Page15.xaml
    /// </summary>
    public partial class Page15 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page15()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Fraction.ToList();
        }
        private void Button_Create(object sender, RoutedEventArgs e)
        {
            Fraction A = new Fraction();
            A.Fraction_Name = TBX1.Text;
            bd.Fraction.Add(A);
            bd.SaveChanges();
            DG.ItemsSource = bd.Fraction.ToList();
        }

        private void Button_Deleate(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                bd.Fraction.Remove(DG.SelectedItem as Fraction);
                bd.SaveChanges();
                DG.ItemsSource = bd.Fraction.ToList();
            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                var selected = DG.SelectedItem as Fraction;
                selected.Fraction_Name = TBX7.Text;
                bd.SaveChanges();
                DG.ItemsSource = bd.Fraction.ToList();
            }
        }
    }
}
