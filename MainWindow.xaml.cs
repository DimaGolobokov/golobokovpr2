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

namespace golobokov_pr2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            Task1Window task1Window = new Task1Window();
            task1Window.Show();
        }

        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            Task2Window task2Window = new Task2Window();
            task2Window.Show();
        }

        private void Task3_Click(object sender, RoutedEventArgs e)
        {
            Task3Window task3Window = new Task3Window();
            task3Window.Show();
        }

        private void Task4_Click(object sender, RoutedEventArgs e)
        {
            Task4Window task4Window = new Task4Window();
            task4Window.Show();
        }

        private void Task5_Click(object sender, RoutedEventArgs e)
        {
            Task5Window task5Window = new Task5Window();
            task5Window.Show();
        }
    }
}
