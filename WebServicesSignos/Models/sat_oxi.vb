Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class sat_oxi
    Public Property IdSV As Integer?

    <Key>
    Public Property IdSO As Integer

    <StringLength(30)>
    Public Property Nivel_oxi As String

    <Required>
    <StringLength(30)>
    Public Property Estado As String

    <Column(TypeName:="date")>
    Public Property Fecha_regso As Date

    Public Property Hora_regso As TimeSpan
End Class
