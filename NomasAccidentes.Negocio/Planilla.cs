using NomasAccidentes.Dalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomasAccidentes.Negocio
{
    public class Planilla
    {
        public int Id_planilla { get; set; }
        public string Descripcion { get; set; }
        public int rut_cliente { get; set; }
        public Cliente cliente { get; set; }

        Entities db = new Entities();
        public List<Planilla> ReadAll()
        {

            //return db.SPP_LISTAR_USUARIOS();
            return this.db.PLANILLA.Select(u => new Planilla()
            {
                Id_planilla = u.ID_PLANILLA,
                Descripcion = u.DESCRIPCION,

                cliente = new Cliente()
                {
                    rut = (int)u.RUT_CLIENTE,
                    nombreCliente = u.CLIENTE.NOMBRE_CLIENTE,
                    RazonSocial = u.CLIENTE.RAZON_SOCIAL,
                    CorreoElectronico = u.CLIENTE.CORREO_ELECTRONICO,
                    id_usuario = u.CLIENTE.ID_USUARIO
                }
            }).ToList();


        }
        public bool Save()
        {
            try
            {
                //Llamar SP almacenado
                db.SPP_CREAR_PLANILLA(this.Descripcion, this.rut_cliente);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Planilla find(int id)
        {
            return this.db.PLANILLA.Select(u => new Planilla()
            {
                Id_planilla = u.ID_PLANILLA,
                Descripcion = u.DESCRIPCION,

                cliente = new Cliente()
                {
                    rut = (int)u.RUT_CLIENTE,
                    nombreCliente = u.CLIENTE.NOMBRE_CLIENTE,
                    RazonSocial = u.CLIENTE.RAZON_SOCIAL,
                    CorreoElectronico = u.CLIENTE.CORREO_ELECTRONICO,
                    id_usuario = u.CLIENTE.ID_USUARIO
                }
            }).Where(u => u.Id_planilla == id).FirstOrDefault();

        }
        public bool Update()
        {
            try
            {
                //Llamar SP almacenado Update, Modificar
                db.SPP_MODIFICAR_PLANILLA(this.Id_planilla, this.Descripcion, this.rut_cliente);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                db.SPP_ELIMINAR_PLANILLA(id);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
