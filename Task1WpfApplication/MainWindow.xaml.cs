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

namespace Task1WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Double a, b, c, d, v, x1, x2;
            a = Double.Parse(texta.Text);
            b = Double.Parse(textb.Text);
            c = Double.Parse(textc.Text);
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (b * (-1) - Math.Sqrt(d)) / (2 * a);
                x2 = (b * (-1) + Math.Sqrt(d)) / (2 * a);
                label1.Content = ("D="+d+"\nx1=" + x1 + "\nx2=" + x2);
            }
            else
                if (d == 0)
                {
                    x1 = (b * (-1)) / (2 * a);
                    label1.Content = ("D=" + d + "\nx1=" + x1);
                }
                else
                {
                    label1.Content = ("Немає розв'язків");
                }
        }

        private void textc_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
