﻿Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Drawing

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    Public Function GetColor(ByVal dataItem As Object) As Color
        Dim row As DataRowView = TryCast(dataItem, DataRowView)
        If row IsNot Nothing Then
            Dim qty As Short = CShort(Math.Truncate(row("qty")))
            Return If(qty > 20, Color.Yellow, Color.Empty)
        End If
        Return Color.Empty
    End Function
End Class
