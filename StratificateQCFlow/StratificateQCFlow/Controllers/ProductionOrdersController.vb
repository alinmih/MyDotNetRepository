Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports PagedList
Imports StratificateQCFlow.Models

Namespace Controllers
    Public Class ProductionOrdersController
        Inherits System.Web.Mvc.Controller

        Private db As New ProductionOrderDbContext

        ' GET: ProductionOrders
        Function Index(ByVal orderDate As String, ByVal searchOrder As String, ByVal sortOrder As String, currentFilter As String, page As Integer?, ByVal searchBatch As String) As ActionResult
            ' send params to sort by them in the index view
            ViewBag.OrderSortParm = If(String.IsNullOrEmpty(sortOrder), "name_desc", String.Empty)
            ViewBag.DateSortParm = If(sortOrder = "Date", "date_desc", "Date")
            ViewBag.BatchSortParm = If(sortOrder = "Number", "number_desc", "Number")
            ViewBag.UserSortParm = If(sortOrder = "User", "user_desc", "User")

            'pagination verifi
            If Not searchOrder Is Nothing Then
                page = 1
            Else
                searchOrder = currentFilter
            End If

            ViewBag.CurrentFilter = searchOrder

            ' set search by datetime and order name and batch
            'set a list o dates from orders
            Dim searchDateList = New List(Of DateTime)
            Dim searchQuerry = From m In db.Orders Order By m.ReleaseDate Select m.ReleaseDate

            searchDateList.AddRange(searchQuerry.Distinct)

            ViewBag.orderDate = New SelectList(searchDateList.OrderByDescending(Function(s) s.Date))

            Dim orders = From m In db.Orders Select m
            'search by order
            If Not String.IsNullOrEmpty(searchOrder) Then
                orders = orders.Where(Function(order) order.Order.Contains(searchOrder))
            End If
            'search by batch
            If Not String.IsNullOrEmpty(searchBatch) Then
                orders = orders.Where(Function(order) order.Batch.Contains(searchBatch))
            End If

            If Not String.IsNullOrEmpty(orderDate) Then
                orders = orders.Where(Function(order) order.ReleaseDate = orderDate)
            End If

            ' order by value set by params
            Select Case sortOrder
                Case "name_desc"
                    orders = orders.OrderByDescending(Function(s) s.Order)
                Case "Date"
                    orders = orders.OrderBy(Function(s) s.ReleaseDate)
                Case "date_desc"
                    orders = orders.OrderByDescending(Function(s) s.ReleaseDate)
                Case "Number"
                    orders = orders.OrderBy(Function(s) s.Batch)
                Case "number_desc"
                    orders = orders.OrderByDescending(Function(s) s.Batch)
                Case "User"
                    orders = orders.OrderBy(Function(s) s.User)
                Case "user_desc"
                    orders = orders.OrderByDescending(Function(s) s.User)
                Case Else
                    orders = orders.OrderBy(Function(s) s.Order)
            End Select

            'set pagination size and number
            Dim pageSize As Integer = 5
            Dim pageNumber As Integer = If(page, 1)

            Return View(orders.ToPagedList(pageNumber, pageSize))
        End Function

        ' GET: ProductionOrders/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim productionOrder As ProductionOrder = db.Orders.Find(id)
            If IsNothing(productionOrder) Then
                Return HttpNotFound()
            End If
            Return View(productionOrder)
        End Function

        ' GET: ProductionOrders/Create
        Function Create() As ActionResult
            Return View(New ProductionOrder())
        End Function

        ' POST: ProductionOrders/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Order,ReleaseDate,QuantityOK,QuantityNOK,Batch,User")> ByVal productionOrder As ProductionOrder) As ActionResult
            If ModelState.IsValid Then
                db.Orders.Add(productionOrder)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(productionOrder)
        End Function

        ' GET: ProductionOrders/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim productionOrder As ProductionOrder = db.Orders.Find(id)
            If IsNothing(productionOrder) Then
                Return HttpNotFound()
            End If
            Return View(productionOrder)
        End Function

        ' POST: ProductionOrders/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Order,ReleaseDate,QuantityOK,QuantityNOK,Batch,User")> ByVal productionOrder As ProductionOrder) As ActionResult
            If ModelState.IsValid Then
                db.Entry(productionOrder).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(productionOrder)
        End Function

        ' GET: ProductionOrders/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim productionOrder As ProductionOrder = db.Orders.Find(id)
            If IsNothing(productionOrder) Then
                Return HttpNotFound()
            End If
            Return View(productionOrder)
        End Function

        ' POST: ProductionOrders/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim productionOrder As ProductionOrder = db.Orders.Find(id)
            db.Orders.Remove(productionOrder)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
