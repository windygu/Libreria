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

Partial Public Class CategoriasOperadores
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Abreviatura As String
    Public Property Descripcion As String
    Public Property Prioridad As Nullable(Of Integer)
    Public Property FechaAlta As Nullable(Of Date)
    Public Property SucursalAltaId As Nullable(Of Integer)
    Public Property OperadorAltaId As Nullable(Of System.Guid)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property SucursalModificacionId As Nullable(Of Integer)
    Public Property OperadorModificacionId As Nullable(Of System.Guid)

    Public Overridable Property Personal As ICollection(Of Personal) = New HashSet(Of Personal)

End Class
