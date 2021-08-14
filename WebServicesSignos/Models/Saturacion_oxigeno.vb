Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class Saturacion_oxigeno
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Saturacion_oxigeno")
    End Sub

    Public Overridable Property sat_oxi As DbSet(Of sat_oxi)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of sat_oxi)() _
            .Property(Function(e) e.Nivel_oxi) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of sat_oxi)() _
            .Property(Function(e) e.Estado) _
            .IsUnicode(False)
    End Sub
End Class
