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
using System.IO;

namespace HaromszogekWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Haromszog> haromszoglista = new List<Haromszog>();
        public MainWindow()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("haromszogek2.csv");
            while (!sr.EndOfStream) 
            {
                Haromszog h = new Haromszog(sr.ReadLine());
                haromszoglista.Add(h);
            }
            sr.Close();

            // DataGrid feltöltése a haromszogek2.csv fájlból!!

            tablazat.ItemsSource = haromszoglista;
        }

        private void hozzaad_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(atextbox.Text);
            int b = Convert.ToInt32(btextbox.Text);
            int c = Convert.ToInt32(ctextbox.Text);

            if(a<b && b<c)
            {
                string peldanystring = a + " " + b + " " + c;
                haromszoglista.Add(new Haromszog(peldanystring));
                tablazat.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Nem megfelelő értékek!");
            }
        }

        private void mentes_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("mentes.txt");
            foreach(var item in haromszoglista) 
            {
                sw.WriteLine(item.A +" "+ item.B +" " + item.C);
            }
            sw.Close();
            MessageBox.Show("Mentés sikeres.");
        }
    }
}
