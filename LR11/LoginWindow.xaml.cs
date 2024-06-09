using System.Windows;

namespace LR11
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (LoginTextBox.Text == "admin" && PasswordBox.Password == "admin")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close(); 
            else
            {
                MessageBox.Show("Неправильний логін або пароль!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
