Public Class SYS_CL_Animal
    Inherits SYS_CL_Especie

    Private sNombre As String
    Private sSexo As String

    Public Sub New()

        sNombre = String.Empty
        sSexo = String.Empty

    End Sub

    Public Property Nombre() As String

        Get
            Return sNombre
        End Get

        Set(ByVal value As String)
            sNombre = value
        End Set

    End Property

    Public Property Sexo() As String

        Get
            Return sSexo
        End Get

        Set(ByVal value As String)
            sSexo = value
        End Set

    End Property

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
