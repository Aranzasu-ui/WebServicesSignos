Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class tem_cor
    Public Property IdSV As Integer?

    <Key>
    Public Property IdTC As Integer

    Public Property Nivel_temp As Integer

    <Required>
    <StringLength(30)>
    Public Property Estado As String

    <Column(TypeName:="date")>
    Public Property Fecha_regtc As Date

    Public Property Hora_regtc As TimeSpan
End Class
