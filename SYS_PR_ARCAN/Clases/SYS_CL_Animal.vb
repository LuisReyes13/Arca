Public Class SYS_CL_Animal
    Inherits SYS_CL_Especie
    Public Property sNombre As String
    Public Property sSexo As String

    Public listaAnimales As List(Of SYS_CL_Especie) = New List(Of SYS_CL_Especie)()

    Public Sub crearAnimal(sNombre As String, sSexo As String)

        Try

            listAnimales.Add(New SYS_CL_Animal() With {
            .sNombre = sNombre,
            .sSexo = sSexo
            })

        Catch ex As Exception
            MsgBox($"Error.crearAnimal: {ex.Message}")
        End Try

    End Sub

End Class
