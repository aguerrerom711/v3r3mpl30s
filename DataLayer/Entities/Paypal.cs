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
    
    public partial class Paypal
    {
        public int Identificador { get; set; }
        public Nullable<int> id { get; set; }
        public string texto { get; set; }
        public System.DateTime fecha { get; set; }
        public string Transaccion { get; set; }
        public System.Guid GUID { get; set; }
        public string IP { get; set; }
        public string Observaciones { get; set; }
        public bool Activado { get; set; }
        public string Correo { get; set; }
        public Nullable<System.DateTime> FechaActivacion { get; set; }
        public string IPActivacion { get; set; }
        public string UsuarioActivado { get; set; }
        public string ContrasenioActivada { get; set; }
        public Nullable<System.DateTime> FechaDesactivacion { get; set; }
        public int IdUsuario { get; set; }
    }
}
