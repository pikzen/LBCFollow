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
using Parser = LBCParser.LBCParser;
using LBCParser;
using System.Drawing;
using System.IO;
using System.Net;

namespace LeBonCoinReader
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Parser parser;
        private List<SearchResult> searchResults;
        private List<Post> posts;
        public MainWindow()
        {
            parser = new Parser();
            searchResults = new List<SearchResult>();
            posts = new List<Post>();

            InitializeComponent();
            categorySelector.ItemsSource = SearchQuery.Categories;
            regionSelector.ItemsSource = SearchQuery.Regions;
        }

        private void onLoaded(object sender, RoutedEventArgs e)
        {
        }

        private void onSearchClicked(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text != "")
            {
                adList.Items.Clear();
                searchResults.Clear();
                posts.Clear();
                LBCParser.SearchQuery query = new LBCParser.SearchQuery(searchBox.Text)
                {
                    Category = SearchQuery.Categories[categorySelector.Text],
                    Region = SearchQuery.Regions[regionSelector.Text],
                    InTitle = (bool)inTitleOpt.IsChecked
                };

                foreach (var res in parser.Search(query))
                {
                    var status = (Label)(statusBar.Items[0]);
                    status.Content = "Downloading " + res.Link;
                    adList.Items.Add(new SearchResultControl(res.Title,
                                                             res.PreviewImage != null ? GetBitmapFromURI(res.PreviewImage).ToBitmapImage() : (BitmapImage)Resources["NoImage"],
                                                             res.Category,
                                                             res.Price));
                    searchResults.Add(res);
                }
            }
        }

        private void onListElementSelected(object sender, SelectionChangedEventArgs e)
        {
            var result = searchResults[((ListBox)(sender)).SelectedIndex];
            if (!posts.Any(p => p.Id == result.Id))
            {
                var post = parser.GetSinglePost(result);
                postPresenter.Update(post);
                posts.Add(post);
            }
            else
            {
                postPresenter.Update(posts.First(p => p.Id == result.Id));
            }
        }

        private Bitmap GetBitmapFromURI(string uri)
        {
            HttpWebRequest webreq = (HttpWebRequest)HttpWebRequest.Create(uri);
            var resStream = webreq.GetResponse().GetResponseStream();

            Bitmap bmp = new Bitmap(resStream);

            return bmp;
        }
      
    }
}
