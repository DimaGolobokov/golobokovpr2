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
    public partial class Task3Window : Window
    {
        public Task3Window()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(input))
            {
                try
                {
                    int[] array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

                    int maxCount = GetMaxCountOfSameElements(array);

                    ResultTextBlock.Text = $"Максимальное количество одинаковых элементов: {maxCount}";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректный ввод. Убедитесь, что введены целые числа, разделенные пробелами.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите элементы массива", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private int GetMaxCountOfSameElements(int[] array)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            return frequencyMap.Values.Max();
        }
    }
}
