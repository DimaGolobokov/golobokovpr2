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
    public partial class Task4Window : Window
    {
        public Task4Window()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text.Trim();

            if (!int.TryParse(BInputTextBox.Text, out int b))
            {
                MessageBox.Show("Введите корректное целое число для b.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(input))
            {
                try
                {
                    int[] array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

                    int[] rearrangedArray = RearrangeArray(array, b);

                    ResultTextBlock.Text = $"Результат: {string.Join(" ", rearrangedArray)}";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректный ввод. Убедитесь, что введены целые числа для массива.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите элементы массива", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private int[] RearrangeArray(int[] array, int b)
        {
            var left = array.Where(x => x <= b).ToArray();
            var right = array.Where(x => x > b).ToArray();

            return left.Concat(right).ToArray();
        }
    }
}
