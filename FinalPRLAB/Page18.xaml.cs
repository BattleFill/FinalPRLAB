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
    /// Логика взаимодействия для Page18.xaml
    /// </summary>
    public partial class Page18 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page18()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Roles.ToList();
        }
        private void Button_Create(object sender, RoutedEventArgs e)
        {
            Roles A = new Roles();
            A.Role_Name = TBX1.Text;
            bd.Roles.Add(A);
            bd.SaveChanges();
            DG.ItemsSource = bd.Roles.ToList();
        }

        private void Button_Deleate(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                bd.Roles.Remove(DG.SelectedItem as Roles);
                bd.SaveChanges();
                DG.ItemsSource = bd.Roles.ToList();
            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                var selected = DG.SelectedItem as Roles;
                selected.Role_Name = TBX7.Text;
                bd.SaveChanges();
                DG.ItemsSource = bd.Roles.ToList();
            }
        }
    }
}
