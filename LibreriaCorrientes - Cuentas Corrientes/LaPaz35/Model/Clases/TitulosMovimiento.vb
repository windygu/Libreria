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

Partial Public Class TitulosMovimiento
    Public Property Id As Integer
    Public Property TituloId As System.Guid
    Public Property TipoComprobanteId As Nullable(Of Integer)
    Public Property ComprobanteId As Nullable(Of System.Guid)
    Public Property SucursalComprobante As Nullable(Of Integer)
    Public Property Fecha As Nullable(Of Date)
    Public Property CntAntPr As Nullable(Of Integer)
    Public Property CntAntCn As Nullable(Of Integer)
    Public Property CntAddPr As Nullable(Of Integer)
    Public Property CntAddCn As Nullable(Of Integer)
    Public Property CntMinPr As Integer
    Public Property CntMinCn As Nullable(Of Integer)
    Public Property PC As String
    Public Property FechaAlta As Nullable(Of Date)
    Public Property SucursalAltaId As Nullable(Of Integer)
    Public Property OperadorAltaId As Nullable(Of System.Guid)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property SucursalModificacionId As Nullable(Of Integer)
    Public Property OperadorModificacionId As Nullable(Of System.Guid)

End Class
