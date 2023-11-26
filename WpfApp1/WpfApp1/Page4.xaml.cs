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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Text1.Text, out int N))
            {
                MessageBox.Show("Введите число!");
            }
            double summ = 0;
            double factorial = 1;
            for (int i = 0; i <= N; i++)
            {
                if (i != 0)
                {
                    factorial *= i;
                }
                summ += 1 / factorial;
            }
            Text2.Text += $"{summ:f2}\n";
        }
    }
}
