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
    
    public partial class MATERIALES
    {
        public MATERIALES()
        {
            this.MATERIALES_EN_CAPACITACION = new HashSet<MATERIALES_EN_CAPACITACION>();
        }
    
        public int ID_MATERIALES { get; set; }
        public string NOMBRE_MATERIAL { get; set; }
    
        public virtual ICollection<MATERIALES_EN_CAPACITACION> MATERIALES_EN_CAPACITACION { get; set; }
    }
}
