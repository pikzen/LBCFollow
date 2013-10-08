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
using Bitmap = System.Drawing.Bitmap;
using System.Net;

namespace LeBonCoinReader
{
    /// <summary>
    /// Logique d'interaction pour PostPresenter.xaml
    /// </summary>
    public partial class PostPresenter : UserControl
    {
        public PostPresenter()
        {
            InitializeComponent();            
        }

        public void Update(LBCParser.Post p) 
        {
            this.title.Content = p.Title;
            this.price.Content = p.Price;
            this.desc.Text = p.Description;
            imagePanel.Children.Clear();
            var bmps = p.ImagePreviews;

            for (int i = 0; i < p.ImagePreviews.Count; i++)
            {
                var bmp = p.ImagePreviews[i];
                Image im = new Image();
                Bitmap bitmap = GetBitmapFromURI(bmp);
                
                im.Height = imagePanel.Height;
                im.Width = (bitmap.Width / bitmap.Height) * im.Height;
                im.Source = bitmap.ToBitmapImage();

                im.MouseDown += (sender, e) =>
                {
                    ImagePresenter imagePreview = new ImagePresenter();
                    imagePreview.Content = GetBitmapFromURI(p.Images[i - 1]).ToBitmapImage();
                    imagePreview.ShowDialog();
                };
                imagePanel.Children.Add(im);
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
