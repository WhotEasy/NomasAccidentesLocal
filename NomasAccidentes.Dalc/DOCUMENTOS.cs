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
    
    public partial class DOCUMENTOS
    {
        public DOCUMENTOS()
        {
            this.DETALLES_DOCUMENTOS = new HashSet<DETALLES_DOCUMENTOS>();
        }
    
        public int ID_DOCUMENTOS { get; set; }
        public string DESCRIPCION { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_VENCIMIENTO { get; set; }
        public int ID_MOROSIDAD { get; set; }
        public int ID_TIPO_DOCUMENTO { get; set; }
        public int ID_PAGOS { get; set; }
    
        public virtual ICollection<DETALLES_DOCUMENTOS> DETALLES_DOCUMENTOS { get; set; }
        public virtual PAGOS PAGOS { get; set; }
        public virtual MOROSIDAD MOROSIDAD { get; set; }
        public virtual TIPO_DOCUMENTO TIPO_DOCUMENTO { get; set; }
    }
}
