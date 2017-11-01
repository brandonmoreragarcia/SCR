
Imports System.Data.Sql
Imports System.Data.SqlClient
Module Conexion

    Public cxnc As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public enun As SqlCommand
    Public enun2 As SqlCommand
    Public respu As SqlDataReader
    Public respu2 As SqlDataReader
    Public v_usuario As String
    Public Num_Boleta As Long
    Public consul_cliente As Boolean
    Public CONSULTA_CLIENTE As String
    Public CONSUTA_REP As String
    Public T_Busqueda_Cliente As Short
    Public Num_Queja As String
    Public T_busqueda_Queja As Short
    Public num_rep As Long
    Public numero_reparacion As Long 'se usa en la clase Frm_Entrada y Frm_Impresion_Entrada
    Public numero_telefono_cliente_1 As String
    Public numero_telefono_cliente_2 As String

    Sub abrir()
        Try
            cxnc = New SqlConnection("Data Source=SERVER;Initial Catalog=ExactusERP;Persist Security Info=True;User ID=sa;Password=B1@dm1n")
            cxnc.Open()
            MsgBox("La Aplicacion se ha iniciado correctamente")
            cxnc.Close()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from SCR_Usuario_P where Usuario='" & nombreUsuario & "'", cxnc)
            cxnc.Open()
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("SELECT dbo.fnLeeClave(passwd) as passwd FROM SCR_Usuario_P WHERE DBO.SCR_Usuario_P.usuario ='" & nombreUsuario & "'", cxnc)
            cxnc.Open()
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("passwd")
            End If
            respuesta.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function numero_rep(ByVal rep_numero As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("Select * from SCR_DATOS_REPARACION where REPARACION_NUMERO='" & rep_numero & "'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function estado_rep(ByVal rep_estado As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun2 = New SqlCommand("Select * from SCR_ACTUALIZACION_REPARADA WHERE NUMERO_REPARACION='" & rep_estado & "'", cxnc)
            cxnc.Open()
            respu2 = enun2.ExecuteReader
            If respu2.Read Then
                resultado = True
            End If
            respu2.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function rep_cerrada(ByVal rep_estado As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun2 = New SqlCommand("Select * from SCR_REPS_CERRADA where REPARACION_NUMERO='" & rep_estado & "'", cxnc)
            cxnc.Open()
            respu2 = enun2.ExecuteReader
            If respu2.Read Then
                resultado = True
            End If
            respu2.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function impre_rep(ByVal rep_impre As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun2 = New SqlCommand("Select * from SCR_CONTROL_IMPR_REP where REPARACION_NUMERO='" & rep_impre & "'", cxnc)
            cxnc.Open()
            respu2 = enun2.ExecuteReader
            If respu2.Read Then
                resultado = True
            End If
            respu2.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function impre_rep_consumo(ByVal rep_impre As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun2 = New SqlCommand("Select * from SCR_CONTROL_IMPR_REP_CON where REPARACION_NUMERO='" & rep_impre & "'", cxnc)
            cxnc.Open()
            respu2 = enun2.ExecuteReader
            If respu2.Read Then
                resultado = True
            End If
            respu2.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function impre_rep_sal(ByVal rep_impre As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun2 = New SqlCommand("Select * from SCR_CONTORL_IMPR_ETQ_SAL where REPARACION_NUMERO='" & rep_impre & "'", cxnc)
            cxnc.Open()
            respu2 = enun2.ExecuteReader
            If respu2.Read Then
                resultado = True
            End If
            respu2.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function


    Function cliente_existe(ByVal existe_cliente As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("Select * from DIS86.CLIENTE where CLIENTE='" & existe_cliente & "'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function factu_exist(ByVal exist_factu As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun2 = New SqlCommand("SELECT * FROM DIS86.FACTURA WHERE DIS86.FACTURA.FACTURA='" & exist_factu & "'", cxnc)
            cxnc.Open()
            respu2 = enun2.ExecuteReader
            If respu2.Read Then
                resultado = True
            End If
            respu2.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function factu_exist2(ByVal exist_factu As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun2 = New SqlCommand("SELECT * FROM SOLOBICI.FACTURA WHERE SOLOBICI.FACTURA.FACTURA='" & exist_factu & "'", cxnc)
            cxnc.Open()
            respu2 = enun2.ExecuteReader
            If respu2.Read Then
                resultado = True
            End If
            respu2.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function Queja_Procesada(ByVal procesada_queja As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun2 = New SqlCommand("SELECT * FROM DBO.SCR_QUEJAS_PROCESADAS WHERE DBO.SCR_QUEJAS_PROCESADAS.NUMERO_QUEJA='" & procesada_queja & "'", cxnc)
            cxnc.Open()
            respu2 = enun2.ExecuteReader
            If respu2.Read Then
                resultado = True
            End If
            respu2.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function Queja_Proces(ByVal proces_queja As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun2 = New SqlCommand("SELECT * FROM DBO.SCR_QUEJAS_PROCES WHERE DBO.SCR_QUEJAS_PROCES.NUMERO_QUEJA='" & proces_queja & "'", cxnc)
            cxnc.Open()
            respu2 = enun2.ExecuteReader
            If respu2.Read Then
                resultado = True
            End If
            respu2.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function Queja_Solucionada(ByVal solucionada_queja As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun2 = New SqlCommand("SELECT * FROM DBO.SCR_QUEJAS_SOLUCIONADAS WHERE DBO.SCR_QUEJAS_SOLUCIONADAS.NUMERO_QUEJA='" & solucionada_queja & "'", cxnc)
            cxnc.Open()
            respu2 = enun2.ExecuteReader
            If respu2.Read Then
                resultado = True
            End If
            respu2.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function privilegio_master(ByVal master_privilegio As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("SELECT * FROM DBO.SCR_Usuario_P WHERE DBO.SCR_Usuario_P.usuario='" & master_privilegio & "'and DBO.SCR_Usuario_P.master=N'1'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function privilegio_entrada_rep(ByVal entrada_rep_privilegio As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("SELECT * FROM DBO.SCR_Usuario_P WHERE DBO.SCR_Usuario_P.usuario='" & entrada_rep_privilegio & "'and DBO.SCR_Usuario_P.entrada_rep=N'1'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function privilegio_actua_rep(ByVal actua_rep_privilegio As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("SELECT * FROM DBO.SCR_Usuario_P WHERE DBO.SCR_Usuario_P.usuario='" & actua_rep_privilegio & "'and DBO.SCR_Usuario_P.actua_rep=N'1'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function privilegio_trans_rep(ByVal trans_rep_privilegio As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("SELECT * FROM DBO.SCR_Usuario_P WHERE DBO.SCR_Usuario_P.usuario='" & trans_rep_privilegio & "'and DBO.SCR_Usuario_P.trans_rep=N'1'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function privilegio_busqueda_boleta(ByVal busqueda_boleta_privilegio As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("SELECT * FROM DBO.SCR_Usuario_P WHERE DBO.SCR_Usuario_P.usuario='" & busqueda_boleta_privilegio & "'and DBO.SCR_Usuario_P.busqueda_boleta=N'1'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function privilegio_entrada_queja(ByVal entrada_queja_privilegio As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("SELECT * FROM DBO.SCR_Usuario_P WHERE DBO.SCR_Usuario_P.usuario='" & entrada_queja_privilegio & "'and DBO.SCR_Usuario_P.entrada_queja=N'1'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function privilegio_actua_queja(ByVal actua_queja_privilegio As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("SELECT * FROM DBO.SCR_Usuario_P WHERE DBO.SCR_Usuario_P.usuario='" & actua_queja_privilegio & "'and DBO.SCR_Usuario_P.actua_queja=N'1'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function privilegio_reportes(ByVal reportes_privilegio As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("SELECT * FROM DBO.SCR_Usuario_P WHERE DBO.SCR_Usuario_P.usuario='" & reportes_privilegio & "'and DBO.SCR_Usuario_P.reportes=N'1'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function privilegio_mantenimiento(ByVal mantenimiento_privilegio As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enun = New SqlCommand("SELECT * FROM DBO.SCR_Usuario_P WHERE DBO.SCR_Usuario_P.usuario='" & mantenimiento_privilegio & "'and DBO.SCR_Usuario_P.mantenimiento=N'1'", cxnc)
            cxnc.Open()
            respu = enun.ExecuteReader
            If respu.Read Then
                resultado = True
            End If
            respu.Close()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
End Module
