Public Class SYS_CL_Animal
    Inherits SYS_CL_Servivo
    'Public Property sANombre As String
    Public Property sASexo As String
    Public Property sAEspecie As String

    Public listaEspecies As List(Of SYS_CL_Especie) = New List(Of SYS_CL_Especie)()
    Public Sub Crear()
        'listaEspecies.Add()
    End Sub
    Public Sub crearAnimal(nombre As String, sexo As String)

        Try

            listAnimales.Add(New SYS_CL_Animal() With {
            .sSNombre = nombre,
            .sASexo = sexo
            })

        Catch ex As Exception
            MsgBox($"Error.crearAnimal: {ex.Message}")
        End Try

    End Sub

End Class
