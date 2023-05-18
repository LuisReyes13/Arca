Public Class SYS_FO_AMostrar
    Private Sub SYS_FO_AMostrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nombresMostrados As New HashSet(Of String)()

        Try
            grdAnimales.Rows.Clear()
            grdAnimales.Columns.Clear()

            grdAnimales.Columns.Add("Nombre", "Nombre")
            grdAnimales.Columns.Add("Sexo", "Sexo")


            For Each c As SYS_CL_Animal In listAnimales.OrderBy(Function(x) x.sNombre)
                If Not nombresMostrados.Contains(c.sNombre) Then
                    grdAnimales.Rows.Add(c.sNombre, c.sSexo)
                    nombresMostrados.Add(c.sNombre)

                Else
                    grdAnimales.Rows.Add("", c.sSexo)

                End If
            Next

        Catch ex As Exception
            MsgBox($"Error.SYS_FO_AMostrar_Load: {ex.Message}")
        End Try

    End Sub

End Class