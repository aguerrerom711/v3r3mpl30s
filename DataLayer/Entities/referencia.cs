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
    
    public partial class referencia
    {
        public int idReferencia { get; set; }
        public string emailReferencia { get; set; }
        public int tipoRelacion { get; set; }
        public System.DateTime fechaEnvio { get; set; }
        public string nombreReferencia { get; set; }
        public string apellidoReferencia { get; set; }
        public string telefono { get; set; }
        public bool mostrarReferencia { get; set; }
        public int idCandidato { get; set; }
        public string observacion { get; set; }
    }
}
