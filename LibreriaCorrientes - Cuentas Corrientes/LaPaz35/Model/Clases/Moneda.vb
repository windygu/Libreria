'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Moneda
    Public Property Id As Integer
    Public Property TipoMonedaId As Integer
    Public Property Cotizacion As Decimal
    Public Property FechaCotizacion As Date
    Public Property FechaAlta As Nullable(Of Date)
    Public Property OperadorAltaId As Nullable(Of System.Guid)
    Public Property SucursalAltaId As Nullable(Of Integer)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property OperadorModificacionId As Nullable(Of System.Guid)
    Public Property SucursalModificacionId As Nullable(Of Integer)

End Class
