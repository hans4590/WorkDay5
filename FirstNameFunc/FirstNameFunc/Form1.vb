﻿Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text.Trim()
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String
        Dim indexSpace As Integer = name.IndexOf(" ")

        Dim fstName As String
        fstName = name.Substring(0, indexSpace)

        Return fstName

    End Function

End Class
