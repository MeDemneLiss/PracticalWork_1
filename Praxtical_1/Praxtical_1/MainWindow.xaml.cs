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
using Lib_1;

namespace Praxtical_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Decide_Click(object sender, RoutedEventArgs e)
        {
            bool Check = int.TryParse(this.NumberKtxt.Text, out int numberK);
            if (Check == true && numberK > 1)
            {
                Practical.Calculate(numberK, out string generateNumbers, out int sum, out int amountNambers);
                GenerateNumbers.Text = generateNumbers;
                Sumtxt.Text = Convert.ToString(sum);
                AmountNamberstxt.Text = Convert.ToString(amountNambers);
            }
           else MessageBox.Show("Введите целое число больше 1 ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Самсаков Андрей Александрович\nИСП-21\nЗадача:\nВычислить сумму целых случайных чисел, распределенных в диапазоне от 2 до 10, пока эта сумма не превышает некоторого числа K.Вывести на экрансгенерированные числа, значение суммы, и количество сгенерированных чисел.", "ИНФОРМАЦИЯ" , MessageBoxButton.OK , MessageBoxImage.Information);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            NumberKtxt.Clear();
            GenerateNumbers.Clear();
            Sumtxt.Clear();
            AmountNamberstxt.Clear();
        }

        private void numberK_TextChanged(object sender, TextChangedEventArgs e)
        {
            GenerateNumbers.Clear();
            Sumtxt.Clear();
            AmountNamberstxt.Clear();
        }
    }
}
