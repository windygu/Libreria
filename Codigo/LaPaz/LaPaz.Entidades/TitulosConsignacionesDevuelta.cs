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
    
    public partial class TitulosConsignacionesDevuelta
    {
        public TitulosConsignacionesDevuelta()
        {
            this.TitulosConsignacionesDevueltasDetalles = new HashSet<TitulosConsignacionesDevueltasDetalle>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ProveedorId { get; set; }
        public string LCN { get; set; }
        public string Observaciones { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public System.Guid OperadorAltaId { get; set; }
        public int SucursalAltaId { get; set; }
    
        public virtual Operador Operadore { get; set; }
        public virtual Proveedor Proveedore { get; set; }
        public virtual Sucursal Sucursale { get; set; }
        public virtual ICollection<TitulosConsignacionesDevueltasDetalle> TitulosConsignacionesDevueltasDetalles { get; set; }
    }
}
