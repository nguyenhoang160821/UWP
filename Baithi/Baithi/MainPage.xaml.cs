﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Baithi.Model;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Baithi.Model;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Baithi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
        public sealed partial class MainPage : Page
        {
            private List<Icon> Icons;
            //private List<Contact> Contacts;
            private ObservableCollection<Product> Products;
            public MainPage()
            {
                this.InitializeComponent();

                Icons = new List<Icon>();
                Icons.Add(new Icon { IconPath = "Assets/bundau.png" });
                Icons.Add(new Icon { IconPath = "Assets/đồnghồ.png" });
                Icons.Add(new Icon { IconPath = "Assets/trangdiem.png" });


            Products = new ObservableCollection<Product>();
            }

            private void NewContactButton_Click(object sender, RoutedEventArgs e)
            {
                string avatar = ((Icon)Image.SelectedValue).IconPath;
                Products.Add(new Product { Name = FirstNameTextBox.Text, Description = LastNameTextBox.Text, Image = avatar });

                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                Image.SelectedIndex = -1;

                FirstNameTextBox.Focus(FocusState.Programmatic);
            }
        }
      
}
