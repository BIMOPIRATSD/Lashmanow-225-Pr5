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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(Text1.Text, out int A))
            {
                MessageBox.Show("Введите число!");
            }
            if(!int.TryParse(Text2.Text, out int B))
            {
                MessageBox.Show("Введите число!");
            }
            int max = 1;
            for (int i = A; i <= B; i += 1)
            {
                max *= 1 * i;
            }
            Text3.Text += $"{max}\n";
        }
    }
}
