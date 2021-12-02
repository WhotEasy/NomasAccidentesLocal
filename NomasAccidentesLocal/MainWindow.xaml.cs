using NomasAccidentes.Dalc;
using NomasAccidentes.Negocio;
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

namespace NomasAccidentesLocal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var usr = txtusuario.Text;
            var contra = txtcontrasena.Text;
            //int rut;
            Usuario u = new Usuario().found(usr);
            if (u == null)
            {
                MessageBox.Show("\n\nUsuario no existe", "Error");
            }
            else { 
            
            if (u.Nombre == usr && u.Contrasena == contra && u.Id_rol == 3 && u.Id_estado == 1)
            {
                    prof p = new prof().found(u.Id);
                    //rut = p.rut_profesional;
                    Profesional pr = new Profesional();

                this.Close();
                pr.ShowDialog();
            }
            else {
                MessageBox.Show("\n\n Credenciales y/o Rol inccorectos");
            }
            }
        }
    }
}
