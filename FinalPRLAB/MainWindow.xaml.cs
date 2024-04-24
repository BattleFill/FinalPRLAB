using FinalPRLAB.StalCraftDataSetTableAdapters;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AccountTableAdapter Acc = new AccountTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void IN_Click(object sender, RoutedEventArgs e)
        {   
            var allLogin = Acc.GetData().Rows;
            for (int i = 0; i < allLogin.Count; i++)
            {
                if (allLogin[i][2].ToString() == LoginTBX.Text &&
                allLogin[i][3].ToString() == PasswordTBX.Password) 
                { 
                    int roleid = (int)allLogin[i][6];
                    switch (roleid)
                    {
                        case 1:
                            AdminWindow admin = new AdminWindow();
                            admin.Show();
                            Close();
                            break;
                        case 2:
                            UserWindow user = new UserWindow();
                            user.Show();
                            Close();
                            break;
                    }
                }
            }
        }
    }
}
