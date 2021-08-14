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
    Public Class fre_cardController
        Inherits System.Web.Http.ApiController

        Private db As New Model1

        ' GET: api/fre_card
        Function Getfre_card() As IQueryable(Of fre_card)
            Return db.fre_card
        End Function

        ' GET: api/fre_card/5
        <ResponseType(GetType(fre_card))>
        Function Getfre_card(ByVal id As Integer) As IHttpActionResult
            Dim fre_card As fre_card = db.fre_card.Find(id)
            If IsNothing(fre_card) Then
                Return NotFound()
            End If

            Return Ok(fre_card)
        End Function

        ' PUT: api/fre_card/5
        <ResponseType(GetType(Void))>
        Function Putfre_card(ByVal id As Integer, ByVal fre_card As fre_card) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = fre_card.IdFC Then
                Return BadRequest()
            End If

            db.Entry(fre_card).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (fre_cardExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/fre_card
        <ResponseType(GetType(fre_card))>
        Function Postfre_card(ByVal fre_card As fre_card) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.fre_card.Add(fre_card)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = fre_card.IdFC}, fre_card)
        End Function

        ' DELETE: api/fre_card/5
        <ResponseType(GetType(fre_card))>
        Function Deletefre_card(ByVal id As Integer) As IHttpActionResult
            Dim fre_card As fre_card = db.fre_card.Find(id)
            If IsNothing(fre_card) Then
                Return NotFound()
            End If

            db.fre_card.Remove(fre_card)
            db.SaveChanges()

            Return Ok(fre_card)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function fre_cardExists(ByVal id As Integer) As Boolean
            Return db.fre_card.Count(Function(e) e.IdFC = id) > 0
        End Function
    End Class
End Namespace