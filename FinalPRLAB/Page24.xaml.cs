﻿using System;
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
    /// Логика взаимодействия для Page24.xaml
    /// </summary>
    public partial class Page24 : Page
    {
        private StalCraftEntities bd = new StalCraftEntities();
        public Page24()
        {
            InitializeComponent();
            DG.ItemsSource = bd.Guns.ToList();
        }
    }
}
