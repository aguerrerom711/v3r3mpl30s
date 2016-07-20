﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class prueba_verempleosEntities : DbContext
    {
        public prueba_verempleosEntities()
            : base("name=prueba_verempleosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alerta> Alerta { get; set; }
        public virtual DbSet<AplicacionesIngles> AplicacionesIngles { get; set; }
        public virtual DbSet<AplicacionesLPC> AplicacionesLPC { get; set; }
        public virtual DbSet<AplicacionesMEOL> AplicacionesMEOL { get; set; }
        public virtual DbSet<AplicacionesPsicoweb> AplicacionesPsicoweb { get; set; }
        public virtual DbSet<area> area { get; set; }
        public virtual DbSet<candidato> candidato { get; set; }
        public virtual DbSet<candidatoIdioma> candidatoIdioma { get; set; }
        public virtual DbSet<candidatoLicencia> candidatoLicencia { get; set; }
        public virtual DbSet<candidatoPrograma> candidatoPrograma { get; set; }
        public virtual DbSet<candidatoTitulo> candidatoTitulo { get; set; }
        public virtual DbSet<candidatoVacante> candidatoVacante { get; set; }
        public virtual DbSet<ciudad> ciudad { get; set; }
        public virtual DbSet<configuracion> configuracion { get; set; }
        public virtual DbSet<CuentaPremium> CuentaPremium { get; set; }
        public virtual DbSet<DatosDePW> DatosDePW { get; set; }
        public virtual DbSet<empresa> empresa { get; set; }
        public virtual DbSet<empresaVeCurriculum> empresaVeCurriculum { get; set; }
        public virtual DbSet<envioCurriculum> envioCurriculum { get; set; }
        public virtual DbSet<estado> estado { get; set; }
        public virtual DbSet<experienciaLaboral> experienciaLaboral { get; set; }
        public virtual DbSet<giroEmpresa> giroEmpresa { get; set; }
        public virtual DbSet<horario> horario { get; set; }
        public virtual DbSet<idioma> idioma { get; set; }
        public virtual DbSet<MembresiaEmpresa> MembresiaEmpresa { get; set; }
        public virtual DbSet<NotificacionPruebas> NotificacionPruebas { get; set; }
        public virtual DbSet<pais> pais { get; set; }
        public virtual DbSet<preferencia> preferencia { get; set; }
        public virtual DbSet<preferenciaArea> preferenciaArea { get; set; }
        public virtual DbSet<preferenciaHorario> preferenciaHorario { get; set; }
        public virtual DbSet<preferenciaPuesto> preferenciaPuesto { get; set; }
        public virtual DbSet<pregunta> pregunta { get; set; }
        public virtual DbSet<PreguntasIngles> PreguntasIngles { get; set; }
        public virtual DbSet<PreguntasOpcionesIngles> PreguntasOpcionesIngles { get; set; }
        public virtual DbSet<PrivilegiosCandidato> PrivilegiosCandidato { get; set; }
        public virtual DbSet<PrivilegiosEmpresa> PrivilegiosEmpresa { get; set; }
        public virtual DbSet<programa> programa { get; set; }
        public virtual DbSet<puesto> puesto { get; set; }
        public virtual DbSet<referencia> referencia { get; set; }
        public virtual DbSet<referenciaPregunta> referenciaPregunta { get; set; }
        public virtual DbSet<RespuestasIngles> RespuestasIngles { get; set; }
        public virtual DbSet<subArea> subArea { get; set; }
        public virtual DbSet<TipoCuentaCandidato> TipoCuentaCandidato { get; set; }
        public virtual DbSet<TipoCuentaEmpresa> TipoCuentaEmpresa { get; set; }
        public virtual DbSet<tipoLicencia> tipoLicencia { get; set; }
        public virtual DbSet<titulo> titulo { get; set; }
        public virtual DbSet<ubicacion> ubicacion { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<usuarioFacebook> usuarioFacebook { get; set; }
        public virtual DbSet<vacante> vacante { get; set; }
        public virtual DbSet<vacanteEducacion> vacanteEducacion { get; set; }
        public virtual DbSet<vacanteIdioma> vacanteIdioma { get; set; }
        public virtual DbSet<vacanteNivelEducacion> vacanteNivelEducacion { get; set; }
        public virtual DbSet<vacanteNivelIdioma> vacanteNivelIdioma { get; set; }
        public virtual DbSet<vacanteStatusEducacion> vacanteStatusEducacion { get; set; }
        public virtual DbSet<vacanteTipoPuesto> vacanteTipoPuesto { get; set; }
        public virtual DbSet<AlertaVacante> AlertaVacante { get; set; }
        public virtual DbSet<Geolocalizacion> Geolocalizacion { get; set; }
        public virtual DbSet<Paypal> Paypal { get; set; }
    }
}