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
    
    public partial class TempComparacionStock
    {
        public System.Guid Libro_Id { get; set; }
        public int CodSuc { get; set; }
        public Nullable<short> StkPr { get; set; }
        public Nullable<short> StkCn { get; set; }
        public Nullable<short> StkAud { get; set; }
        public Nullable<System.DateTime> FeGr { get; set; }
        public Nullable<System.DateTime> FeGrAud { get; set; }
    }
}