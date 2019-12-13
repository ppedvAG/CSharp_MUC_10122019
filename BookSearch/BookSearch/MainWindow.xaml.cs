using HalloBooks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace BookSearch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Suche(object sender, RoutedEventArgs e)
        {
            //suchTb.Background = new SolidColorBrush(Colors.Red);
            if (string.IsNullOrWhiteSpace(suchTb.Text))
            {
                MessageBox.Show("Bitte Suchbegriff eingeben.");
                return;
            }

            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var txt = wc.DownloadString($"https://www.googleapis.com/books/v1/volumes?q={suchTb.Text}");
            jsonTb.Text = txt;

            var br = JsonConvert.DeserializeObject<BooksResults>(txt);

            grid.ItemsSource = br.items.Select(x => x.volumeInfo).ToList();
        }
    }
}
