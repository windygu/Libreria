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

Partial Public Class Liquidaciones
    Public Property Id As System.Guid
    Public Property LiquidacionId As System.Guid
    Public Property Importe As Nullable(Of Single)
    Public Property Total As Nullable(Of Single)
    Public Property Comentario As String
    Public Property FechaAlta As Date
    Public Property OperadorAltaId As System.Guid
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property OperadorModificacionId As Nullable(Of System.Guid)

    Public Overridable Property LiquidacionPersonal As ICollection(Of LiquidacionPersonal) = New HashSet(Of LiquidacionPersonal)

End Class