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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text3.Clear();
            if (!int.TryParse(Text1.Text, out int N))
            {
                MessageBox.Show("Введите число!");
            }
            if (!int.TryParse(Text2.Text, out int K))
            {
                MessageBox.Show("Введите число!");
            }

            double answer = 0;

            for (int i = 1; i <= N; i++)
            {
                answer += Pow(i, K);
            }

            Text3.Text += $"{answer:f2}\n";
        }
    }
}
