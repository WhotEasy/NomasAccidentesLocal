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
    
    public partial class DETALLE_ACCIDENTE
    {
        public DETALLE_ACCIDENTE()
        {
            this.REGISTRO_ACCIDENTES = new HashSet<REGISTRO_ACCIDENTES>();
        }
    
        public int ID_DETALLE_ACCIDENTE { get; set; }
        public string NOMBRE_ACCIDENTADO { get; set; }
        public string LUGAR_ACCIDENTE { get; set; }
        public string DESCRIPCION_ACCIDENTE { get; set; }
    
        public virtual ICollection<REGISTRO_ACCIDENTES> REGISTRO_ACCIDENTES { get; set; }
    }
}
