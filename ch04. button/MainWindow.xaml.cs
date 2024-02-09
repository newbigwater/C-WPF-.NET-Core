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

namespace ch04._button
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

        private void Btn_OnClick(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "버튼이 클릭되었습니다.";
        }

        private void Btn_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtBlock.Background = Brushes.Salmon;
            txtBlock.Foreground = Brushes.White;
        }

        private void Btn_OnMouseEnter(object sender, MouseEventArgs e)
        {
            btn.Foreground = Brushes.Red;
        }

        private void Btn_OnMouseLeave(object sender, MouseEventArgs e)
        {
            btn.Foreground = Brushes.Black;
        }
    }
}
