Imports System.Runtime.InteropServices
Public Class Form2
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Txtuser_Enter(sender As Object, e As EventArgs) Handles txtuser.Enter


    End Sub

    Private Sub gh(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub Btmlogin_Click(sender As Object, e As EventArgs) Handles btmlogin.Click
        If txtuser.Text() = "admin1" And
                txtpass.Text = "12345" Then
            Form3.Show()

        End If



    End Sub

    Private Sub Btminim_Click(sender As Object, e As EventArgs) Handles btminim.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btmcerrar1_Click(sender As Object, e As EventArgs) Handles btmcerrar1.Click
        Me.Close()
    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class