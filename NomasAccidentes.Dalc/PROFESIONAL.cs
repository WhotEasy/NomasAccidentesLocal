//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NomasAccidentes.Dalc
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROFESIONAL
    {
        public PROFESIONAL()
        {
            this.INFORME = new HashSet<INFORME>();
            this.REGISTRO_ACTIVIDADES = new HashSet<REGISTRO_ACTIVIDADES>();
        }
    
        public int RUT_PROFESIONAL { get; set; }
        public string NOMBRE_PROFESIONAL { get; set; }
        public int ID_USUARIO { get; set; }
    
        public virtual ICollection<INFORME> INFORME { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<REGISTRO_ACTIVIDADES> REGISTRO_ACTIVIDADES { get; set; }
    }
}
