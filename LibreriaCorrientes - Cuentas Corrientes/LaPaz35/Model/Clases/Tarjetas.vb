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

Partial Public Class Tarjetas
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Cuenta As String
    Public Property Abreviatura As String
    Public Property ProvinciaId As Nullable(Of Integer)
    Public Property LocalidadId As Nullable(Of Integer)
    Public Property Direccion As String
    Public Property TelPart As String
    Public Property TelCel As String
    Public Property Fax As String
    Public Property FechaAlta As Nullable(Of Date)
    Public Property OperadorAltaId As Nullable(Of System.Guid)
    Public Property SucursalAltaId As Nullable(Of Integer)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property OperadorModificacionId As Nullable(Of System.Guid)
    Public Property SucursalModificacionId As Nullable(Of Integer)

    Public Overridable Property TarjetasMovimientos As ICollection(Of TarjetasMovimientos) = New HashSet(Of TarjetasMovimientos)

End Class
