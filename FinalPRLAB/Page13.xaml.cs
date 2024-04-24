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
    /// Логика взаимодействия для Page13.xaml
    /// </summary>
    public partial class Page13 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page13()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Cheque.ToList();
        }
        private void Button_Create(object sender, RoutedEventArgs e)
        {
            Cheque A = new Cheque();
            A.Adres = TBX1.Text;
            A.Date_ = TBX2.Text;
            A.Account_ID = int.TryParse(TBX3.Text, out int result) ? (int)result : 0;
            A.Donate_ID = int.TryParse(TBX4.Text, out int result1) ? (int)result1 : 0;
            bd.Cheque.Add(A);
            bd.SaveChanges();
            DG.ItemsSource = bd.Cheque.ToList();
        }

        private void Button_Deleate(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                bd.Cheque.Remove(DG.SelectedItem as Cheque);
                bd.SaveChanges();
                DG.ItemsSource = bd.Cheque.ToList();
            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                var selected = DG.SelectedItem as Cheque;
                selected.Adres = TBX7.Text;
                bd.SaveChanges();
                DG.ItemsSource = bd.Cheque.ToList();
            }
        }
    }
}
