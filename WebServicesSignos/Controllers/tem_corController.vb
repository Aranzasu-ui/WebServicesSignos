Imports System.Data
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Http.Description
Imports WebServicesSignos

Namespace Controllers
    Public Class tem_corController
        Inherits System.Web.Http.ApiController

        Private db As New Temperatura_corporal

        ' GET: api/tem_cor
        Function Gettem_cor() As IQueryable(Of tem_cor)
            Return db.tem_cor
        End Function

        ' GET: api/tem_cor/5
        <ResponseType(GetType(tem_cor))>
        Function Gettem_cor(ByVal id As Integer) As IHttpActionResult
            Dim tem_cor As tem_cor = db.tem_cor.Find(id)
            If IsNothing(tem_cor) Then
                Return NotFound()
            End If

            Return Ok(tem_cor)
        End Function

        ' PUT: api/tem_cor/5
        <ResponseType(GetType(Void))>
        Function Puttem_cor(ByVal id As Integer, ByVal tem_cor As tem_cor) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = tem_cor.IdTC Then
                Return BadRequest()
            End If

            db.Entry(tem_cor).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (tem_corExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/tem_cor
        <ResponseType(GetType(tem_cor))>
        Function Posttem_cor(ByVal tem_cor As tem_cor) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.tem_cor.Add(tem_cor)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = tem_cor.IdTC}, tem_cor)
        End Function

        ' DELETE: api/tem_cor/5
        <ResponseType(GetType(tem_cor))>
        Function Deletetem_cor(ByVal id As Integer) As IHttpActionResult
            Dim tem_cor As tem_cor = db.tem_cor.Find(id)
            If IsNothing(tem_cor) Then
                Return NotFound()
            End If

            db.tem_cor.Remove(tem_cor)
            db.SaveChanges()

            Return Ok(tem_cor)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function tem_corExists(ByVal id As Integer) As Boolean
            Return db.tem_cor.Count(Function(e) e.IdTC = id) > 0
        End Function
    End Class
End Namespace