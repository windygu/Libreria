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
    
    public partial class OperadoresFuncione
    {
        public System.Guid Id { get; set; }
        public System.Guid OperadorId { get; set; }
        public int FuncionId { get; set; }
        public Nullable<bool> Permitido { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual Funcion Funcion { get; set; }
        public virtual Operador Operador { get; set; }
    }
}
