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
    
    public partial class Email
    {
        public int Id { get; set; }
        public System.Guid ClienteId { get; set; }
        public Nullable<System.DateTime> FechaEmail { get; set; }
        public string Email1 { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
    }
}
