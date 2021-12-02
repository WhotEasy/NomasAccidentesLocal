using NomasAccidentes.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NomasAccidentesLocal
{
    /// <summary>
    /// Lógica de interacción para RevisionInforme.xaml
    /// </summary>
    public partial class RevisionInforme : Window
    {
        public RevisionInforme()
        {
            InitializeComponent();
            Informe usr = new Informe();
            dataRevision.ItemsSource = usr.ReadAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Profesional pr = new Profesional();
            this.Close();
            pr.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RevisionInforme rv = new RevisionInforme();
            this.Close();
            rv.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RegistroActivity ra = new RegistroActivity();
            this.Close();
            ra.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            this.Close();
            mn.ShowDialog();
        }


    }
}
