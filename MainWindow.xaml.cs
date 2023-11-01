using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Abstraction_and_polimo
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int cityo = Convert.ToInt32(City_out.Text);
                int villo = Convert.ToInt32(Village_out.Text);
                int n_o = Convert.ToInt32(N_out.Text);
                var arr = new Settlement[n_o * 2];

                if (n_o <= 0)                
                    throw new ArgumentOutOfRangeException("The number of repetitions was entered incorrectly");   
                
                int minv = 1, maxv = 200;
                if (minv > villo || villo > maxv)                
                    throw new ArgumentOutOfRangeException("The number of houses is too (small/large) for the village");
                
                int minc = 20000, maxc = 10000000;
                if (minc > cityo || cityo > maxc)                
                    throw new ArgumentOutOfRangeException("the number of people is too small/large for the city");
                
                //
                double minValue = 20.0, maxValue = 850.0, minvil = 0.01, maxvil = 8.0;
                int poplemin = 1, poplemax = 8;

                Random random = new Random();
                //
                for (int i = 0; i < arr.Length; i += 2)
                {
                    arr[i] = new City(cityo, random.NextDouble() * (maxValue - minValue) + minValue);
                    arr[i + 1] = new Village(villo, Convert.ToInt32(random.NextDouble() * (poplemax - poplemin) + poplemin), random.NextDouble() * (maxvil - minvil) + minvil);
                }

                double resc, resv;
                listBox.Items.Clear();

                resc = arr[0].Density();
                resv = arr[1].Density();

                listBox.Items.Add(arr[0].Show() + " result : " + Math.Round(arr[0].Density(), 3).ToString());
                listBox.Items.Add(arr[1].Show() + " result : " + Math.Round(arr[1].Density(), 3).ToString());
                if (n_o > 1)
                {
                    for (int i = 2; i < arr.Length; i++)
                    {
                        listBox.Items.Add(arr[i].Show() + " result : " + Math.Round(arr[i].Density(), 3).ToString());
                        if (resc > arr[i].Density() && i % 2 == 0)
                            resc = arr[i].Density();
                        else if (resv > arr[i].Density() && i % 2 == 1)
                            resv = arr[i].Density();
                    }
                    VilRes.Content = Math.Round(resv, 3);
                    CitRes.Content = Math.Round(resc, 3);
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
