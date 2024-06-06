using System.Windows;

namespace coursework;

public partial class StartWindow
{
    public StartWindow()
    {
        InitializeComponent();
    }

    private void Loading()
    {
        StartButton.Visibility = Visibility.Hidden;
        TextLoading.Visibility = Visibility.Visible;
    }
    
    //проверка подключения бд (вывод в консоль)
    private async void Auth()
    {
        await using(var db = new ConnectionDB())
        {
            var users = db.users.ToList();
    
            foreach (var user in users)
            {
                if (user.username == "Ruslan")
                {
                    Console.WriteLine("Успешное подключение!");
                }
            }
        }
    }

    private async void Button_Click(object sender, RoutedEventArgs e)
    { 
        
        Loading();
        await Task.Delay(2000);

        TextLoading.Text = "Соединение...";

        await Task.Delay(2000);
        
        Auth();

        UserWindow userWindow = new UserWindow();
        userWindow.Show();
        

        TextLoading.Text = "Ожидание авторизации...";
    }
}