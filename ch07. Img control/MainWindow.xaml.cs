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

namespace ch07._Img_control
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

        private ImageSource backupURL = null;
        private void Img_OnMouseEnter(object sender, MouseEventArgs e)
        {
            backupURL = img.Source;
            img.Source = new BitmapImage(new Uri("https://cdn4.iconfinder.com/data/icons/world-cup-2014-cogged-wheel-style/512/flat_world_cup_icon_512_C._do_Sul.png"));
        }

        private void Img_OnMouseLeave(object sender, MouseEventArgs e)
        {
            img.Source = backupURL;
        }
    }
}
