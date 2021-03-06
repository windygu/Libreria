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
    
    public partial class ClienteMontoFavor
    {
        public ClienteMontoFavor()
        {
            this.ClientesMontosFavorDetalles = new HashSet<ClientesMontosFavorDetalle>();
            this.VentasDetalles = new HashSet<VentaDetalle>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> VentaId { get; set; }
        public System.Guid ClienteId { get; set; }
        public System.DateTime FechaComprobante { get; set; }
        public LaPaz.Entidades.Enums.TipoComprobanteEnum TipoComprobanteId { get; set; }
        public string LCN { get; set; }
        public string Concepto { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<decimal> ImpOcupado { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public Nullable<System.Guid> OperadorAutoriza { get; set; }
        public string Observaciones { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
    
        public virtual Operador OperadorAlta { get; set; }
        public virtual Operador OperadoreModificacion { get; set; }
        public virtual Sucursal SucursalAlta { get; set; }
        public virtual Sucursal SucursalModificacion { get; set; }
        public virtual TipoComprobante TiposComprobante { get; set; }
        public virtual ICollection<ClientesMontosFavorDetalle> ClientesMontosFavorDetalles { get; set; }
        public virtual ICollection<VentaDetalle> VentasDetalles { get; set; }
    }
}
