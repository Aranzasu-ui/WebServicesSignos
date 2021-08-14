Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Model11")
    End Sub

    Public Overridable Property fre_card As DbSet(Of fre_card)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of fre_card)() _
            .Property(Function(e) e.Estado) _
            .IsUnicode(False)
    End Sub
End Class
