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
    
    public partial class ESTADO_INFORME
    {
        public ESTADO_INFORME()
        {
            this.INFORME = new HashSet<INFORME>();
        }
    
        public int ID_ESTADO_INFO { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<INFORME> INFORME { get; set; }
    }
}
