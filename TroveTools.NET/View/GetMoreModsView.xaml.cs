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
using TroveTools.NET.ViewModel;

namespace TroveTools.NET.View
{
    /// <summary>
    /// Interaction logic for GetMoreModsView.xaml
    /// </summary>
    public partial class GetMoreModsView : UserControl
    {
        public GetMoreModsView()
        {
            InitializeComponent();
        }

        public void ListBoxItem_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            Control control = sender as Control;
            TroveModViewModel vm = control.DataContext as TroveModViewModel;
            vm.InstallCommand.Execute(null);
        }
    }
}