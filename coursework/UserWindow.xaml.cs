using System.Windows;
using System.Windows.Controls;


namespace coursework;

public partial class UserWindow
{
    public UserWindow()
    {
        InitializeComponent();
    }
    

    //инпуты
    private void LoginTextBox_GotFocus(object sender, RoutedEventArgs e)
    {
        TextBox textBox = sender as TextBox;
        if (textBox != null)
        {
            if (textBox.Text == "Введите логин")
            {
                textBox.Text = "";
            }
        }
    }

    private void LoginTextBox_LostFocus(object sender, RoutedEventArgs e)
    {
        TextBox textBox = sender as TextBox;
        if (textBox != null)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Введите логин";
            }
        }
    }
    
    private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
    {
        TextBox textBox = sender as TextBox;
        if (textBox != null)
        {
            if (textBox.Text == "Введите пароль")
            {
                textBox.Text = "";
            }
        }
    }

    private void PasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
    {
        TextBox textBox = sender as TextBox;
        if (textBox != null)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Введите пароль";
            }
        }
    }
}