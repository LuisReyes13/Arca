Public Class SYS_CL_Animal
    Public Property _Nombre As String
    Public Property _Sexo As String

    Public Sub crearAnimal(nombre As String, sexo As String)

        Try

            listAnimales.Add(New SYS_CL_Animal() With {
            ._Nombre = nombre,
            ._Sexo = sexo
            })

        Catch ex As Exception
            MsgBox($"Error.crearAnimal: {ex.Message}")
        End Try

    End Sub

End Class
