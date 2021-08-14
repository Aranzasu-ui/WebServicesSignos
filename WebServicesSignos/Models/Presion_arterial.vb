Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class Presion_arterial
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Presion_cardiaca")
    End Sub

    Public Overridable Property pres_arte As DbSet(Of pres_arte)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of pres_arte)() _
            .Property(Function(e) e.Nivel_presi) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of pres_arte)() _
            .Property(Function(e) e.Estado) _
            .IsUnicode(False)
    End Sub
End Class
