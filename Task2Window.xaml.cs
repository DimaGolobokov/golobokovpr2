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
    public partial class Task2Window : Window
    {
        public Task2Window()
        {
            InitializeComponent();
        }

        private void ReverseWords_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(input))
            {
                string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string reversedWords = string.Join(" ", words.Reverse());

                ResultTextBlock.Text = reversedWords;
            }
            else
            {
                MessageBox.Show("Введите строку", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
