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
    
    public partial class PARTICIPANTE_CAPACITACION
    {
        public PARTICIPANTE_CAPACITACION()
        {
            this.CAPACITACION = new HashSet<CAPACITACION>();
        }
    
        public int ID_PARTICIPANTE_CAPACITACION { get; set; }
        public string CONFIRMA_ASISTENCIA { get; set; }
        public int RUT_PARTICIPANTE { get; set; }
    
        public virtual ICollection<CAPACITACION> CAPACITACION { get; set; }
        public virtual PARTICIPANTES PARTICIPANTES { get; set; }
    }
}
