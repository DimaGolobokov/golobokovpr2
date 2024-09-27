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
using System.Windows.Shapes;

namespace golobokov_pr2
{
    public partial class Task1Window : Window
    {
        public Task1Window()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Получение и проверка введенного числа n
            if (!int.TryParse(NInputTextBox.Text, out int n) || n <= 0 || n > 100)
            {
                MessageBox.Show("Введите корректное натуральное число n (1 <= n <= 100).", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int result = CalculateFactorialTimesTwo(n);

            ResultTextBlock.Text = $"2 * {n}! = {result}";
        }

        private int CalculateFactorialTimesTwo(int n)
        {
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return 2 * factorial;
        }
    }
}
