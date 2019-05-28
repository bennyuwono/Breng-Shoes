﻿Imports System.Data
Imports System.Data.SqlClient

Public Class BulananPembelian

    Private Sub BulananPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New CRMingguanPembelian()
        Dim myConnection As SqlConnection
        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New DataSet()
        Dim LokasiDB As String

        Try

            LokasiDB = "data source = DESKTOP-S4FC3MP; initial catalog = UAS_PBD; integrated security = true"
            myConnection = New SqlConnection(LokasiDB)
            myDA = New SqlDataAdapter("SELECT * from Pembelian", myConnection)
            myDS = New DataSet
            myDA.Fill(myDS, "Pembelian")
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class