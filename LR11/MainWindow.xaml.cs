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

namespace LR11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigationButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string message = $"Натиснули кнопку {button.Content}";
                MessageBox.Show(message, "Інформація", MessageBoxButton.OK, MessageBoxImage.Information);


                if (button.Content.ToString() == "Вийти")
                {
                    Application.Current.Shutdown();
                }
            }
        }
    }
}
