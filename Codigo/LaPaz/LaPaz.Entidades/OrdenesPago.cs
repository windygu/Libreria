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
    
    public partial class OrdenesPago
    {
        public OrdenesPago()
        {
            this.OrdenesPagoComprobantes = new HashSet<OrdenesPagoComprobante>();
            this.OrdenesPagoDetalles = new HashSet<OrdenesPagoDetalle>();
            this.OrdenesPagoTransferencias = new HashSet<OrdenesPagoTransferencia>();
        }
    
        public System.Guid Id { get; set; }
        public int SucursalId { get; set; }
        public System.DateTime Fecha { get; set; }
        public string LCN { get; set; }
        public string LetraComprobante { get; set; }
        public string NumeroComprobante { get; set; }
        public Nullable<int> TipoGastoId { get; set; }
        public System.Guid ProveedorId { get; set; }
        public string Concepto { get; set; }
        public Nullable<bool> RegistraIVACompra { get; set; }
        public Nullable<int> SucursalGastoId { get; set; }
        public Nullable<int> CentroCostoId { get; set; }
        public LaPaz.Entidades.Enums.TipoComprobanteEnum TipoComprobanteId { get; set; }
        public Nullable<System.DateTime> FechaImputacion { get; set; }
        public decimal SubTotal { get; set; }
        public Nullable<decimal> Recargo { get; set; }
        public decimal Importe { get; set; }
        public Nullable<decimal> ImportePagado { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public Nullable<System.Guid> RemitoAnticipadoId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual Operador OperadorAlta { get; set; }
        public virtual Operador OperadorModificacion { get; set; }
        public virtual TipoComprobante TiposComprobante { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual Sucursal SucursalAlta { get; set; }
        public virtual Sucursal SucursalGasto { get; set; }
        public virtual Sucursal SucursalModificacion { get; set; }
        public virtual ICollection<OrdenesPagoComprobante> OrdenesPagoComprobantes { get; set; }
        public virtual ICollection<OrdenesPagoDetalle> OrdenesPagoDetalles { get; set; }
        public virtual CentrosCosto CentrosCosto { get; set; }
        public virtual TiposGasto TiposGasto { get; set; }
        public virtual ICollection<OrdenesPagoTransferencia> OrdenesPagoTransferencias { get; set; }
    }
}
