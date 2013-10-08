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
using System.Windows.Shapes;

namespace LeBonCoinReader
{
    /// <summary>
    /// Logique d'interaction pour ImagePresenter.xaml
    /// </summary>
    public partial class ImagePresenter : Window
    {
        public ImageSource Content
        {
            get
            {
                return content.Source;
            }
            set
            {
                content.Source = value;
                this.Width = value.Width;
                this.Height = value.Height;
            }
        }
        public ImagePresenter()
        {
            InitializeComponent();
        }

       
    }
}
