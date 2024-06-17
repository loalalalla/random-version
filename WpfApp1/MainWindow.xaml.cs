using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void GenerateRandomNumber_Click(object sender, RoutedEventArgs e)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101); // Генерация случайного числа от 1 до 100

        randomNumberText.Text = $"Случайное число: {randomNumber}";
    }
}
