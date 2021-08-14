Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class fre_card
    Public Property IdSV As Integer?

    <Key>
    Public Property IdFC As Integer

    Public Property Nivel_frecard As Integer

    <Required>
    <StringLength(30)>
    Public Property Estado As String

    <Column(TypeName:="date")>
    Public Property Fecha_regfc As Date

    Public Property Hora_regfc As TimeSpan
End Class
