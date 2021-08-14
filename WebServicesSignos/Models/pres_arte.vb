Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class pres_arte
    Public Property IdSV As Integer?

    <Key>
    Public Property IdPA As Integer

    <StringLength(30)>
    Public Property Nivel_presi As String

    <Required>
    <StringLength(30)>
    Public Property Estado As String

    <Column(TypeName:="date")>
    Public Property Fecha_regpa As Date

    Public Property Hora_regpa As TimeSpan
End Class
