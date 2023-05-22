Public Class SYS_CL_Especie

    Private sReino As String
    Private sEspecie As String

    Public Sub New()

        sReino = String.Empty
        sEspecie = String.Empty

    End Sub

    Public Property Reino() As String

        Get
            Return sReino
        End Get

        Set(ByVal value As String)
            sReino = value
        End Set

    End Property
    Public Property Especie() As String

        Get
            Return sEspecie
        End Get

        Set(ByVal value As String)
            sEspecie = value
        End Set

    End Property

End Class
