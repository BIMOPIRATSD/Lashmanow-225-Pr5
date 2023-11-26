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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text2.Clear();
            if (!double.TryParse(Text1.Text, out double p))
            {
                MessageBox.Show("Введите число!");
            }
            double answer = 1;
            double a0 = 1;
            double a1 = 1;
            double ai;

            for (int i = 2; i <= p; i++)
            {
                ai = a0 + a1 / Pow(2, i - 1);
                a0 = a1;
                a1 = ai;
                answer *= ai;
            }

            Text2.Text += $"{answer:f2}\n";
        }
    }
}
