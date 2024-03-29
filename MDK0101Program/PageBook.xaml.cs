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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MDK0101Program
{
    /// <summary>
    /// Логика взаимодействия для PageBook.xaml
    /// </summary>
    public partial class PageBook : Page
    {
        Book book = new Book();
        
        public PageBook()
        {
            InitializeComponent();
            LVBook.ItemsSource = book.book.ToList();
        }

        private void BackBtn_AMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMenuAdminGlav());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button sp = (Button)sender;
            int id = Convert.ToInt32(sp.Uid);
            Books bookRed = Base.dataBase.Books.FirstOrDefault(x => x.ID_Books == id);
            new WinRedDob(bookRed).ShowDialog();

        }
    }
}
