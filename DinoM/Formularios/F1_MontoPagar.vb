Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.ToolTips
Imports System.Drawing
Imports DevComponents.DotNetBar.Controls
Imports Logica.AccesoLogica
Public Class F1_MontoPagar

    Public TotalVenta As Double
    Public Bandera As Boolean = False
    Public TotalBs As Double = 0
    Public TotalSus As Double = 0
    Public TotalTarjeta As Double = 0
    Public Nit As String = ""
    Public RazonSocial As String = ""


    Private Sub F1_MontoPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbMontoBs.Focus()
        txtMontoPagado1.Text = "0.00"
        txtCambio1.Text = "0.00"
        tbMontoBs.Value = 0
        tbMontoDolar.Value = 0
        tbMontoTarej.Value = 0
        tbNit.Text = Nit
        tbRazonSocial.Text = RazonSocial

        tbNit.Focus()
    End Sub

    Private Sub tbMontoBs_ValueChanged(sender As Object, e As EventArgs) Handles tbMontoBs.ValueChanged
        tbMontoDolar.Value = 0
        tbMontoTarej.Value = 0

        Dim diferencia As Double = tbMontoBs.Value - TotalVenta
        If (diferencia >= 0) Then
            txtMontoPagado1.Text = TotalVenta.ToString
            txtCambio1.Text = diferencia.ToString

        Else
            txtMontoPagado1.Text = "0.00"
            txtCambio1.Text = "0.00"
        End If

    End Sub

    Private Sub tbMontoDolar_ValueChanged(sender As Object, e As EventArgs) Handles tbMontoDolar.ValueChanged
        tbMontoBs.Value = 0
        tbMontoTarej.Value = 0
        Dim diferencia As Double = (tbMontoDolar.Value * 6.96) - TotalVenta
        If (diferencia >= 0) Then
            txtMontoPagado1.Text = TotalVenta.ToString
            txtCambio1.Text = diferencia.ToString

        Else
            txtMontoPagado1.Text = "0.00"
            txtCambio1.Text = "0.00"
        End If
    End Sub

    Private Sub tbMontoTarej_ValueChanged(sender As Object, e As EventArgs) Handles tbMontoTarej.ValueChanged
        tbMontoDolar.Value = 0
        tbMontoBs.Value = 0

        Dim diferencia As Double = tbMontoTarej.Value - TotalVenta
        If (diferencia >= 0) Then
            txtMontoPagado1.Text = TotalVenta.ToString
            txtCambio1.Text = diferencia.ToString

        Else
            txtMontoPagado1.Text = "0.00"
            txtCambio1.Text = "0.00"
        End If
    End Sub

    Private Sub tbMontoBs_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMontoBs.KeyDown

        If (e.KeyData = Keys.Up) Then
            tbRazonSocial.Focus()
        End If
        If (e.KeyData = Keys.Right) Then
            tbMontoDolar.Focus()
        End If
        If (e.KeyData = Keys.Enter) Then
            tbMontoDolar.Focus()
        End If
        If (e.KeyData = Keys.Down) Then
            tbMontoTarej.Focus()
        End If
        If (e.KeyData = Keys.Escape) Then
            TotalBs = 0
            TotalSus = 0
            TotalTarjeta = 0
            Bandera = False
            Me.Close()


        End If
        If (e.KeyData = Keys.Control + Keys.S) Then
            If (tbMontoTarej.Value + tbMontoDolar.Value + tbMontoBs.Value >= TotalVenta) Then
                Bandera = True
                TotalBs = tbMontoBs.Value
                TotalSus = tbMontoDolar.Value
                TotalTarjeta = tbMontoTarej.Value
                Nit = tbNit.Text
                RazonSocial = tbRazonSocial.Text
                Me.Close()

            Else
                ToastNotification.Show(Me, "Debe Ingresar un Monto a Cobrar Valido igual o mayor A = " + Str(TotalVenta), My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If


        End If
    End Sub

    Private Sub tbMontoDolar_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMontoDolar.KeyDown
        If (e.KeyData = Keys.Left) Then
            tbMontoBs.Focus()
        End If
        If (e.KeyData = Keys.Enter) Then
            tbMontoTarej.Focus()
        End If
        If (e.KeyData = Keys.Down) Then
            tbMontoTarej.Focus()
        End If
        If (e.KeyData = Keys.Escape) Then
            TotalBs = 0
            TotalSus = 0
            TotalTarjeta = 0
            Bandera = False
            Me.Close()


        End If
        If (e.KeyData = Keys.Control + Keys.S) Then
            If (tbMontoTarej.Value + tbMontoDolar.Value + tbMontoBs.Value >= TotalVenta) Then
                Bandera = True
                TotalBs = tbMontoBs.Value
                TotalSus = tbMontoDolar.Value
                TotalTarjeta = tbMontoTarej.Value
                Nit = tbNit.Text
                RazonSocial = tbRazonSocial.Text
                Me.Close()

            Else
                ToastNotification.Show(Me, "Debe Ingresar un Monto a Cobrar Valido igual o mayor A = " + Str(TotalVenta), My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub

    Private Sub tbMontoTarej_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMontoTarej.KeyDown
        If (e.KeyData = Keys.Up) Then
            tbMontoBs.Focus()
        End If
        If (e.KeyData = Keys.Enter) Then
            btnContinuar.Focus()
        End If
        If (e.KeyData = Keys.Left) Then
            tbMontoDolar.Focus()
        End If

        If (e.KeyData = Keys.Escape) Then
            TotalBs = 0
            TotalSus = 0
            TotalTarjeta = 0
            Bandera = False
            Me.Close()


        End If
        If (e.KeyData = Keys.Control + Keys.S) Then
            If (tbMontoTarej.Value + tbMontoDolar.Value + tbMontoBs.Value >= TotalVenta) Then
                Bandera = True
                TotalBs = tbMontoBs.Value
                TotalSus = tbMontoDolar.Value
                TotalTarjeta = tbMontoTarej.Value
                Nit = tbNit.Text
                RazonSocial = tbRazonSocial.Text
                Me.Close()

            Else
                ToastNotification.Show(Me, "Debe Ingresar un Monto a Cobrar Valido igual o mayor A = " + Str(TotalVenta), My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub

    Private Sub tbNit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNit.Validating
        Dim nom1, nom2 As String
        nom1 = ""
        nom2 = ""
        If (tbNit.Text.Trim <> String.Empty) Then
            L_Validar_Nit(tbNit.Text.Trim, nom1, nom2)
            If nom1 = "" Then
                tbRazonSocial.Focus()
            Else
                tbRazonSocial.Text = nom1 + nom2

            End If
        End If
    End Sub

    Private Sub tbRazonSocial_KeyDown(sender As Object, e As KeyEventArgs) Handles tbRazonSocial.KeyDown
        If (e.KeyData = Keys.Up) Then
            tbNit.Focus()
        End If
        If (e.KeyData = Keys.Down) Then
            tbMontoBs.Focus()
        End If
        If (e.KeyData = Keys.Enter) Then
            tbMontoBs.Focus()
        End If

        If (e.KeyData = Keys.Control + Keys.S) Then
            If (tbMontoTarej.Value + tbMontoDolar.Value + tbMontoBs.Value >= TotalVenta) Then
                Bandera = True
                TotalBs = tbMontoBs.Value
                TotalSus = tbMontoDolar.Value
                TotalTarjeta = tbMontoTarej.Value
                Nit = tbNit.Text
                RazonSocial = tbRazonSocial.Text
                Me.Close()

            Else
                ToastNotification.Show(Me, "Debe Ingresar un Monto a Cobrar Valido igual o mayor A = " + Str(TotalVenta), My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub

    Private Sub tbNit_KeyDown(sender As Object, e As KeyEventArgs) Handles tbNit.KeyDown
        If (e.KeyData = Keys.Down) Then
            tbRazonSocial.Focus()
        End If
        If (e.KeyData = Keys.Enter) Then
            tbRazonSocial.Focus()
        End If
        If (e.KeyData = Keys.Control + Keys.S) Then
            If (tbMontoTarej.Value + tbMontoDolar.Value + tbMontoBs.Value >= TotalVenta) Then
                Bandera = True
                TotalBs = tbMontoBs.Value
                TotalSus = tbMontoDolar.Value
                TotalTarjeta = tbMontoTarej.Value
                Nit = tbNit.Text
                RazonSocial = tbRazonSocial.Text
                Me.Close()

            Else
                ToastNotification.Show(Me, "Debe Ingresar un Monto a Cobrar Valido igual o mayor A = " + Str(TotalVenta), My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If

    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If (tbMontoTarej.Value + tbMontoDolar.Value + tbMontoBs.Value >= TotalVenta) Then
            Bandera = True
            TotalBs = tbMontoBs.Value
            TotalSus = tbMontoDolar.Value
            TotalTarjeta = tbMontoTarej.Value
            Nit = tbNit.Text
            RazonSocial = tbRazonSocial.Text
            Me.Close()

        Else
            ToastNotification.Show(Me, "Debe Ingresar un Monto a Cobrar Valido igual o mayor A = " + Str(TotalVenta), My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
            tbMontoBs.Focus()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        TotalBs = 0
        TotalSus = 0
        TotalTarjeta = 0
        Bandera = False
        Me.Close()

    End Sub
End Class