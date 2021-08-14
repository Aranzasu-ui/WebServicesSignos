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
    Public Class sat_oxiController
        Inherits System.Web.Http.ApiController

        Private db As New Saturacion_oxigeno

        ' GET: api/sat_oxi
        Function Getsat_oxi() As IQueryable(Of sat_oxi)
            Return db.sat_oxi
        End Function

        ' GET: api/sat_oxi/5
        <ResponseType(GetType(sat_oxi))>
        Function Getsat_oxi(ByVal id As Integer) As IHttpActionResult
            Dim sat_oxi As sat_oxi = db.sat_oxi.Find(id)
            If IsNothing(sat_oxi) Then
                Return NotFound()
            End If

            Return Ok(sat_oxi)
        End Function

        ' PUT: api/sat_oxi/5
        <ResponseType(GetType(Void))>
        Function Putsat_oxi(ByVal id As Integer, ByVal sat_oxi As sat_oxi) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = sat_oxi.IdSO Then
                Return BadRequest()
            End If

            db.Entry(sat_oxi).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (sat_oxiExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/sat_oxi
        <ResponseType(GetType(sat_oxi))>
        Function Postsat_oxi(ByVal sat_oxi As sat_oxi) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.sat_oxi.Add(sat_oxi)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = sat_oxi.IdSO}, sat_oxi)
        End Function

        ' DELETE: api/sat_oxi/5
        <ResponseType(GetType(sat_oxi))>
        Function Deletesat_oxi(ByVal id As Integer) As IHttpActionResult
            Dim sat_oxi As sat_oxi = db.sat_oxi.Find(id)
            If IsNothing(sat_oxi) Then
                Return NotFound()
            End If

            db.sat_oxi.Remove(sat_oxi)
            db.SaveChanges()

            Return Ok(sat_oxi)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function sat_oxiExists(ByVal id As Integer) As Boolean
            Return db.sat_oxi.Count(Function(e) e.IdSO = id) > 0
        End Function
    End Class
End Namespace