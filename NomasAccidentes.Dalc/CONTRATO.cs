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
    
    public partial class CONTRATO
    {
        public int ID_CONTRATO { get; set; }
        public System.DateTime FECHA_CONTRATO { get; set; }
        public System.DateTime FECHA_VENCIMIENTO { get; set; }
        public int MONTO_PACTADO { get; set; }
        public int RUT_CLIENTE { get; set; }
        public Nullable<int> ID_SERVICIOS_EN_CONTRATOS { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual SERVICIOS_EN_CONTRATOS SERVICIOS_EN_CONTRATOS { get; set; }
    }
}
