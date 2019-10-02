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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fourth
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        List<string> products;

        public MainWindow()
        {
            InitializeComponent(); 
            products = new List<string>();
        }


        private void FirstButtonClick(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation(200, TimeSpan.FromSeconds(0.2));
            doubleAnimation.AutoReverse = true;
            firstButton.BeginAnimation(WidthProperty, doubleAnimation);
            if (!string.IsNullOrWhiteSpace(firstTextBox.Text))
            {
                products.Add(firstTextBox.Text);
                firstTextBox.Text = "";
            }
        }

        private void SecondButtonClick(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation(200, TimeSpan.FromSeconds(0.2));
            doubleAnimation.AutoReverse = true;
            secondButton.BeginAnimation(WidthProperty, doubleAnimation);
            if (!string.IsNullOrWhiteSpace(secondTextBox.Text))
            {
                products.Add(secondTextBox.Text);
                secondTextBox.Text = "";
            }
        }

        private void ThirdButtonClick(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation(200, TimeSpan.FromSeconds(0.2));
            doubleAnimation.AutoReverse = true;
            thirdButton.BeginAnimation(WidthProperty, doubleAnimation);
            if (!string.IsNullOrWhiteSpace(thirdTextBox.Text))
            {
                products.Add(thirdTextBox.Text);
                thirdTextBox.Text = "";
            }
        }

        private void FourthButtonClick(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation(200, TimeSpan.FromSeconds(0.2));
            doubleAnimation.AutoReverse = true;
            fourthButton.BeginAnimation(WidthProperty, doubleAnimation);
            if (!string.IsNullOrWhiteSpace(fourthTextBox.Text))
            {
                products.Add(fourthTextBox.Text);
                fourthTextBox.Text = "";
            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation(100, TimeSpan.FromSeconds(0.2));
            doubleAnimation.AutoReverse = true;
            showCartButton.BeginAnimation(HeightProperty, doubleAnimation);

            string productsString = "";
            foreach (var product in products)
            {
                productsString += product + ", ";
            }
            MessageBox.Show(productsString);
        } 
    }
}
