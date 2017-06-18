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

namespace Lab9
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
        Double guessedNumber;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            guessedNumber = Convert.ToDouble(textBox1.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > Convert.ToDouble(textBox2.Text))
            {
                txtBlock.Text = "Enter a lower number.";
            }
            if (Convert.ToDouble(textBox1.Text) < Convert.ToDouble(textBox2.Text))
            {
                txtBlock.Text = "Enter a higher number.";
            }
            if (Convert.ToDouble(textBox1.Text) == Convert.ToDouble(textBox2.Text))
            {
                txtBlock.Text = "Player two has guessed the correct number.";
            }
        }
    }
}
