//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class preferenciaHorario
    {
        public int idHorario { get; set; }
        public int idCandidato { get; set; }
        public int idPreferenciaHorario { get; set; }
    
        public virtual candidato candidato { get; set; }
        public virtual horario horario { get; set; }
    }
}
