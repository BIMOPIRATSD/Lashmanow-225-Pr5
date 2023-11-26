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
using static System.Math;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text3.Clear();
            if (!int.TryParse(Text1.Text, out int x)) // x - как будто бы бесконечность
            {
                MessageBox.Show("Введите число!");
            }
            if (!int.TryParse(Text2.Text, out int a)) // А-Е - выбор задания
            {
                MessageBox.Show("Введите число!");
            }

            double answer = 1;
            double Factorial(double n)
            {
                double result;
                if (n == 1)
                    return 1;
                result = Factorial(n - 1) * n;
                return result;
            }

            if (1 <= a && a <= 6)
            {
                switch (a)
                {
                    case 1:
                        for (int i = 1; i <= x; i++)
                        {
                            answer += 1 / Pow(x, i);
                        }
                        break;
                    case 2:
                        for (int i = 1; i <= x; i++)
                        {
                            answer += 1 / (i * (i + 1));
                        }
                        break;
                    case 3:
                        for (int i = 1; i <= x; i++)
                        {
                            answer += Pow(-1, i) / i;
                        }
                        break;
                    case 4:
                        for (int i = 1; i <= x; i++)
                        {
                            answer += Pow(-2, i) / i * Factorial(i);
                        }
                        break;
                    case 5:
                        for (int i = 1; i <= x; i++)
                        {
                            answer += Pow(-1, i + 1) / (i * (i + 1) * (i + 2));
                        }
                        break;
                    case 6:
                        for (int i = 0; i <= x; i++)
                        {
                            answer += 1 / (Pow(4, i) + Pow(5, i + 2));
                        }
                        break;
                }
                Text3.Text += $"{answer:f2}\n";
            }
            else
            {
                MessageBox.Show("Выберите от 1 до 6");
            }
        }
    }
}
