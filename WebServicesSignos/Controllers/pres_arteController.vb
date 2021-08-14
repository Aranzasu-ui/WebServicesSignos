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
    Public Class pres_arteController
        Inherits System.Web.Http.ApiController

        Private db As New Presion_arterial

        ' GET: api/pres_arte
        Function Getpres_arte() As IQueryable(Of pres_arte)
            Return db.pres_arte
        End Function

        ' GET: api/pres_arte/5
        <ResponseType(GetType(pres_arte))>
        Function Getpres_arte(ByVal id As Integer) As IHttpActionResult
            Dim pres_arte As pres_arte = db.pres_arte.Find(id)
            If IsNothing(pres_arte) Then
                Return NotFound()
            End If

            Return Ok(pres_arte)
        End Function

        ' PUT: api/pres_arte/5
        <ResponseType(GetType(Void))>
        Function Putpres_arte(ByVal id As Integer, ByVal pres_arte As pres_arte) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = pres_arte.IdPA Then
                Return BadRequest()
            End If

            db.Entry(pres_arte).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (pres_arteExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/pres_arte
        <ResponseType(GetType(pres_arte))>
        Function Postpres_arte(ByVal pres_arte As pres_arte) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.pres_arte.Add(pres_arte)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = pres_arte.IdPA}, pres_arte)
        End Function

        ' DELETE: api/pres_arte/5
        <ResponseType(GetType(pres_arte))>
        Function Deletepres_arte(ByVal id As Integer) As IHttpActionResult
            Dim pres_arte As pres_arte = db.pres_arte.Find(id)
            If IsNothing(pres_arte) Then
                Return NotFound()
            End If

            db.pres_arte.Remove(pres_arte)
            db.SaveChanges()

            Return Ok(pres_arte)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function pres_arteExists(ByVal id As Integer) As Boolean
            Return db.pres_arte.Count(Function(e) e.IdPA = id) > 0
        End Function
    End Class
End Namespace