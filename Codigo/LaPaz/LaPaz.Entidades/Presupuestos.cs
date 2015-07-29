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
    
    public partial class Presupuestos
    {
        public System.Guid Id { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Concepto { get; set; }
        public string LCN { get; set; }
        public Nullable<System.Guid> ClienteId { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<System.Guid> VentaId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}