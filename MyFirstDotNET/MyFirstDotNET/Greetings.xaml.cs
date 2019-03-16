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


namespace MyFirstDotNET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color blue, red;
        public MainWindow()
        {
            blue = (Color)ColorConverter.ConvertFromString("#FFDEDEFF");
            red = (Color)ColorConverter.ConvertFromString("#FFFCD1CF");
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RedButton.IsChecked == true)
            {
                BackPanel1.Background = new SolidColorBrush(red);
            }
            else if (BlueButton.IsChecked == true)
            {
                BackPanel1.Background = new SolidColorBrush(blue);
            }
        }
    }
}
