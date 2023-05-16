Public Class SYS_FO_AMostrar
    Private Sub SYS_FO_AMostrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nombresMostrados As New HashSet(Of String)()

        Try
            grdAnimales.Rows.Clear()
            grdAnimales.Columns.Clear()

            grdAnimales.Columns.Add("Nombre", "Nombre")
            grdAnimales.Columns.Add("Sexo", "Sexo")


            For Each c As SYS_CL_Animal In listAnimales.OrderBy(Function(x) x._Nombre)
                If Not nombresMostrados.Contains(c._Nombre) Then
                    grdAnimales.Rows.Add(c._Nombre, c._Sexo)
                    nombresMostrados.Add(c._Nombre)

                Else
                    grdAnimales.Rows.Add("", c._Sexo)

                End If
            Next

        Catch ex As Exception
            MsgBox($"Error.SYS_FO_AMostrar_Load: {ex.Message}")
        End Try

    End Sub

End Class