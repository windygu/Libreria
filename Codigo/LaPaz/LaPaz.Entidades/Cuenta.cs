//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaPaz.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cuenta
    {
        public Cuenta()
        {
            this.CuentasMovimientos = new HashSet<CuentasMovimiento>();
            this.OrdenesPagoTransferencias = new HashSet<OrdenesPagoTransferencia>();
        }
    
        public int Id { get; set; }
        public int TipoCuentaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> BancoPropioId { get; set; }
        public Nullable<System.Guid> OperadorId { get; set; }
        public string Titular { get; set; }
        public System.DateTime FechaApertura { get; set; }
        public Nullable<System.DateTime> FechaCierre { get; set; }
        public Nullable<decimal> Debitos { get; set; }
        public Nullable<decimal> Creditos { get; set; }
        public Nullable<decimal> DebitosConciliado { get; set; }
        public Nullable<decimal> CreditosConciliado { get; set; }
        public int SucursalAltaId { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public System.Guid OperadorAltaId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public bool Activo { get; set; }
        public Nullable<int> EstadoId { get; set; }
    
        public virtual BancoPropio BancosPropio { get; set; }
        public virtual Operador Operadore { get; set; }
        public virtual Operador Operadore1 { get; set; }
        public virtual Operador Operadore2 { get; set; }
        public virtual Sucursal Sucursale { get; set; }
        public virtual Sucursal Sucursale1 { get; set; }
        public virtual TiposCuenta TiposCuenta { get; set; }
        public virtual ICollection<CuentasMovimiento> CuentasMovimientos { get; set; }
        public virtual ICollection<OrdenesPagoTransferencia> OrdenesPagoTransferencias { get; set; }
    }
}
