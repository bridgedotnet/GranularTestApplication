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

namespace GranularTestApplication
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

        private int count = 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = $"Clicked {count} times";

            // Write a message to Console 
            // on first Button click.
            if (count == 1)
            {
                var msg = "Welcome to Granular!";

                System.Console.WriteLine(msg);
            }

            count++;
        }
    }
}
