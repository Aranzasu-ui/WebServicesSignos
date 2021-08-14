Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class Temperatura_corporal
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Temperatura_corporal")
    End Sub

    Public Overridable Property tem_cor As DbSet(Of tem_cor)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of tem_cor)() _
            .Property(Function(e) e.Estado) _
            .IsUnicode(False)
    End Sub
End Class
