using Microsoft.AspNetCore.Mvc;
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
using System.Windows.Shapes;

namespace NomasAccidentesLocal
{
    /// <summary>
    /// Lógica de interacción para Modal.xaml
    /// </summary>
    public partial class Modal :  Window
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Informe informe = new Informe();
            int validaciones=0;
            // db.SPP_CREAR_INFORME(this.descri, this.estado, this.rutprof, this.rutcliente, this.planilla);
            int estado = 0;
            int rutprof = 0;
            int rutcliente = 0;
            rutprof = comboProfesional.SelectedIndex;
            rutcliente = comboCliente.SelectedIndex;
            estado = comboEstado.SelectedIndex;
            informe.ID_ESTADO_INFO = 1;
            informe.Rut_profesional = 245124512;
            informe.Rut_cliente = 123123;





            if (descipcion.Text.Length != 0 && descipcion.Text.Length >= 5 && estado > 0 && rutprof > 0 && rutcliente > 0 && ID_PLANILLA.Text.Length == 1) {
                informe.DESCRIPCION = descipcion.Text;
                informe.ID_PLANILLA = Convert.ToInt32(ID_PLANILLA.Text);
                validaciones = validaciones + 5;
            } 
            else {
                MessageBox.Show("\n\n No ha rellenado todos los campos");
            }

            if (validaciones == 5)
            {
                    try
                    {
                        informe.Save();
                        MessageBox.Show("\n\n Guardado con éxito");
                         DialogResult = false;
                         Close();
                }
                    catch
                    {
                        MessageBox.Show("\n\n no se ha guardado");
                    }
            }
            else
            {
                MessageBox.Show("\n\n No se han completado todos los campos");
            }
             
        }

        
    }


    }

