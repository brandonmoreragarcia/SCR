Imports System.Windows.Forms

Public Class Main_Menu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Entrada_Datos.Click
        My.Forms.Frm_Entrada.MdiParent = Me
        Frm_Entrada.Show()
        Frm_Entrada.Location = New Point(0, 180)

    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Forms.Frm_Login.MdiParent = Me
        Frm_Login.Show()
        Frm_Login.Location = New Point(200, 200)
        Btn_Entrada_Datos.Visible = False
        Lbl_Entrada_Datos.Visible = False
    End Sub
End Class
