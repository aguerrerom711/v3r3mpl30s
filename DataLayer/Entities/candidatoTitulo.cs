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
    
    public partial class candidatoTitulo
    {
        public int idCandidato { get; set; }
        public int idTitulo { get; set; }
        public int idCandidatoTitulo { get; set; }
        public string tituloObtenido { get; set; }
        public string institucion { get; set; }
    
        public virtual candidato candidato { get; set; }
        public virtual titulo titulo { get; set; }
    }
}
