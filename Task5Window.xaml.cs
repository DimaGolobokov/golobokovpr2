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
    public partial class Task5Window : Window
    {
        private Random random = new Random();

        public Task5Window()
        {
            InitializeComponent();
        }

        private void GenerateAndSort_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(MInputTextBox.Text, out int m) || m <= 0)
            {
                MessageBox.Show("Введите корректное целое число для количества столбцов M.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!int.TryParse(NInputTextBox.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Введите корректное целое число для количества строк N.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int[,] array = GenerateArray(m, n);

            int[] flatArray = FlattenArray(array);

            int[] sortedAsc = flatArray.OrderBy(x => x).ToArray();
            int[] sortedDesc = flatArray.OrderByDescending(x => x).ToArray();

            int maxElement = flatArray.Max();
            int minElement = flatArray.Min();

            string result = $"Исходный массив:\n{ArrayToString(array)}\n\n" +
                            $"Отсортировано по возрастанию:\n{ArrayToString(sortedAsc, m)}\n\n" +
                            $"Отсортировано по убыванию:\n{ArrayToString(sortedDesc, m)}\n\n" +
                            $"Максимальный элемент: {maxElement}\n" +
                            $"Минимальный элемент: {minElement}";

            ResultTextBlock.Text = result;
        }

        private int[,] GenerateArray(int m, int n)
        {
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(-10, 11);
                }
            }
            return array;
        }

        private int[] FlattenArray(int[,] array)
        {
            return array.Cast<int>().ToArray();
        }

        private string ArrayToString(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            string result = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += $"{array[i, j],3} ";
                }
                result += "\n";
            }
            return result;
        }

        private string ArrayToString(int[] array, int cols)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0 && i % cols == 0)
                    result += "\n";
                result += $"{array[i],3} ";
            }
            return result;
        }
    }
}
