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

namespace LeBonCoinReader
{
    /// <summary>
    /// Logique d'interaction pour SearchResultControl.xaml
    /// </summary>
    public partial class SearchResultControl : UserControl
    {
        public SearchResultControl()
        {
            InitializeComponent();
        }

        public SearchResultControl(string productName, string previewImageUri, string category, string price)
        {
            InitializeComponent();
            this.title.Content = productName;
            this.category.Content = category;
            this.price.Content = (price != "" ? price : "");
            //this.image.Source = new BitmapImage(new Uri(previewImageUri));
        }

        public SearchResultControl(string productName, BitmapImage bitmap, string category, string price)
        {
            InitializeComponent();
            this.title.Content = productName;
            this.category.Content = category;
            this.price.Content = (price != "" ? price : "");
            this.image.Source = bitmap;
        }
    }
}
