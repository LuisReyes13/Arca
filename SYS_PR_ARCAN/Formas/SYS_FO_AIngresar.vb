Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class Form1
    Public oAnimales As New SYS_CL_Animal
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Try
            SYS_FO_AMostrar.ShowDialog()

        Catch ex As Exception
            MsgBox($"Error.btnMostrar_Click: {ex.Message}")
        End Try

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim sNombre As String = Trim(txtNombre.Text.ToUpper)
        Dim sSexo As String = cmbSexo.SelectedItem

        Dim bExixteAnimal As Boolean = listAnimales.Any(Function(a) a.sNombre = sNombre AndAlso a.sSexo = sSexo)

        Try
            If ValidarCampos() And ValidarAnimalJson(sNombre) Then
                If bExixteAnimal Then

                    MsgBox("Ya existe Animal de ese Sexo", MsgBoxStyle.Exclamation, "Error")

                Else

                    oAnimales.crearAnimal(sNombre, sSexo)

                    txtNombre.Clear()
                    txtNombre.Focus()

                    cmbSexo.SelectedIndex = -1

                End If
            End If

        Catch ex As Exception
            MsgBox($"Error.btnIngresar_Click: {ex.Message}")
        End Try

    End Sub

    Private Function ValidarCampos() As Boolean

        Dim bValidar As Boolean = False

        Try
            If String.IsNullOrWhiteSpace(txtNombre.Text) Then

                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtNombre.Clear()
                txtNombre.Focus()

            ElseIf cmbSexo.SelectedIndex = -1 Then

                MessageBox.Show("Debes seleccionar una opción en el campo Sexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                cmbSexo.Focus()

            Else
                bValidar = True

            End If

        Catch ex As Exception
            MsgBox($"Error.ValidarCampos: {ex.Message}")
        End Try

        Return bValidar

    End Function

    Public Function ValidarAnimalJson(nombre As String) As Boolean

        Dim webClient As New WebClient()

        Dim sJson As String

        Dim bAnimal As Boolean = False

        Dim animales As Newtonsoft.Json.Linq.JArray

        Try

            sJson = webClient.DownloadString("https://www.desdelaweb.com.mx/god/animales.json")
            animales = JsonConvert.DeserializeObject(sJson)

            'MsgBox($"Total animales: {animales.Count}")

            For Each animal As JObject In animales
                'MsgBox(animal.GetValue("nombre").ToString.ToUpper())
                If animal.GetValue("nombre").ToString.ToUpper.Equals(nombre) Then
                    bAnimal = True
                    Exit For

                Else
                    MsgBox("No existe el Animal ingresado")
                    txtNombre.Clear()
                    txtNombre.Focus()

                    cmbSexo.SelectedIndex = -1

                    Exit For

                End If
            Next

        Catch ex As Exception
            MsgBox($"Error.ValidarAnimalJson: {ex.Message}")
        End Try

        Return bAnimal

    End Function

End Class
