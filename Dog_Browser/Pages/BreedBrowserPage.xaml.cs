﻿using Dog_Browser.Models;
using Dog_Browser.Services;
using Dog_Browser.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Dog_Browser.Pages
{
    /// <summary>
    /// Interaction logic for DogBrowserPage.xaml
    /// </summary>
    public partial class BreedBrowserPage : Page
    {
        public BreedBrowserPage()
        {
            InitializeComponent();
        }

        private void GroupingButton_Checked(object sender, RoutedEventArgs e)
        {
            var description = new PropertyGroupDescription("PrimaryBreed");
            BreedsListView.Items.GroupDescriptions.Add(description);
        }

        private void GroupingButton_Unchecked(object sender, RoutedEventArgs e)
        {
            BreedsListView.Items.GroupDescriptions.Clear();
        }
    }
}
