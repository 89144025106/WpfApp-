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

namespace WpfApp_Калькулятор_ГКР
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

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button14_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button19_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void Button18_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
             }

        private void Button16_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void Button17_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "=";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
