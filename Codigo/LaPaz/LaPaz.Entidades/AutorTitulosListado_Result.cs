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
    
    public partial class AutorTitulosListado_Result
    {
        public System.Guid Id { get; set; }
        public string Cod { get; set; }
        public string ISBN { get; set; }
        public string CodigoBarra { get; set; }
        public string NombreTitulo { get; set; }
        public Nullable<System.Guid> ProveedorId { get; set; }
        public string ProveedorDenominacion { get; set; }
        public string TemaNombre { get; set; }
        public string AutorNombre { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<decimal> PrecioVentaTitulo { get; set; }
        public Nullable<decimal> PrecioCompraTitulo { get; set; }
        public Nullable<int> TituloStockStkPr { get; set; }
        public Nullable<int> TituloStockStkCn { get; set; }
        public Nullable<int> TituloStockStkPrViejo { get; set; }
        public Nullable<int> TituloStockStkCnViejo { get; set; }
        public string OperadorModificacionUsuario { get; set; }
        public Nullable<long> Fila { get; set; }
    }
}
