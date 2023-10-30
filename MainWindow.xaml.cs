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
            int cityo = Convert.ToInt32(City_out.Text);
            int villo = Convert.ToInt32(Village_out.Text);
            int n_o = Convert.ToInt32(N_out.Text);
            var arr = new Settlement[n_o*2];

            for (int i = 0; i < arr.Length; i+=2)
            {

            }
            double resc;
            double resv;
            listBox.Items.Clear();
            if(n_o > 0)
            {
                resc = arr[0].Density();
                resv = arr[1].Density();
                listBox.Items.Add(arr[0].Show() + " result : " + arr[0].Density().ToString());
                listBox.Items.Add(arr[0].Show() + " result : " + arr[0].Density().ToString());
                for (int i = 1; i < arr.Length; i++)
                {
                    listBox.Items.Add(arr[i].Show() + " result : " + arr[i].Density().ToString());
                    if (resc > arr[i].Density() && i % 2 == 0)
                        resc = arr[i].Density();
                    else if (resv > arr[i].Density() && i % 2 == 1)
                        resv = arr[i].Density();
                }
            }  
            

        }
    }
}
