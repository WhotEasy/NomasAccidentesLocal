using NomasAccidentes.Dalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomasAccidentes.Negocio
{
    public class prof
    {

        public int rut_profesional { get; set; }
        public string nombre_profesional { get; set; }
        public int id_usuario { get; set; }

        Entities db = new Entities();
        public prof found(int idusr)
        {
            return this.db.PROFESIONAL.Select(u => new prof()
            {
                rut_profesional = u.RUT_PROFESIONAL,
                nombre_profesional = u.NOMBRE_PROFESIONAL,
                id_usuario = u.ID_USUARIO
            }).Where(u => u.id_usuario == idusr).FirstOrDefault();

        }
    }
}
