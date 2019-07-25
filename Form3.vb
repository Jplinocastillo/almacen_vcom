Imports System.Runtime.InteropServices

Public Class Form3

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btmcerrar.Click
        Me.Close()
    End Sub

    Private Sub Btmrestaurar_Click(sender As Object, e As EventArgs) Handles btmrestaurar.Click
        btmrestaurar.Visible = False
        btmaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Btmaximizar_Click(sender As Object, e As EventArgs) Handles btmaximizar.Click
        btmaximizar.Visible = False
        btmrestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Btminimizar_Click(sender As Object, e As EventArgs) Handles btminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Btmsyscom_Click(sender As Object, e As EventArgs) Handles btmsyscom.Click
        WebBrowser1.Show()


    End Sub

    Private Sub Btmct_Click(sender As Object, e As EventArgs) Handles btmct.Click
        WebBrowser2.Show()

    End Sub

    Private Sub Btmproveedores_Click(sender As Object, e As EventArgs) Handles btmproveedores.Click
        btmct.Visible = True
        btmsyscom.Visible = True
        btmatras.Visible = True

    End Sub

    Private Sub Btmatras_Click(sender As Object, e As EventArgs) Handles btmatras.Click
        btmproveedores.Visible = True
        btmalmacen.Visible = True
        btmgarantias.Visible = True

        btmct.Visible = False
        btmsyscom.Visible = False
        btmatras.Visible = False

        WebBrowser1.Visible = False
        WebBrowser2.Visible = False







    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted



    End Sub
End Class