﻿Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class Form1
    Public oAnimales As New SYS_CL_Animal
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Try
            SYS_FO_AMostrar.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim sNombre As String = Trim(txtNombre.Text.ToUpper)
        Dim sSexo As String = cmbSexo.SelectedItem

        Dim existeNombreMacho As Boolean = listAnimales.Any(Function(a) a._Nombre = sNombre AndAlso a._Sexo = "MACHO")
        Dim existeNombreHembra As Boolean = listAnimales.Any(Function(a) a._Nombre = sNombre AndAlso a._Sexo = "HEMBRA")

        Try
            If ValidarCampos() And ValidarAnimalJson(sNombre) Then
                If existeNombreMacho And Not existeNombreHembra Then

                    MsgBox("Ya existen animales con el mismo nombre y ambos sexos.", MsgBoxStyle.Exclamation, "Error")

                Else

                    oAnimales.crearAnimal(sNombre, sSexo)

                    txtNombre.Clear()
                    txtNombre.Focus()

                    cmbSexo.SelectedIndex = -1

                End If
            ElseIf Not ValidarAnimalJson(sNombre) Then

                MsgBox("No existe Animal")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function ValidarCampos() As Boolean

        Try
            If String.IsNullOrWhiteSpace(txtNombre.Text) Then

                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtNombre.Clear()
                txtNombre.Focus()

                Return False

            ElseIf cmbSexo.SelectedIndex = -1 Then

                MessageBox.Show("Debes seleccionar una opción en el campo Sexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                cmbSexo.Focus()

                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return True

    End Function

    Public Function ValidarAnimalJson(nombre As String) As Boolean

        Dim webClient As New WebClient()
        Dim sJson As String
        Dim bAnimal As Boolean = False

        Try

            sJson = webClient.DownloadString("https://www.desdelaweb.com.mx/god/animales.json")

            Dim animales As Newtonsoft.Json.Linq.JArray = JsonConvert.DeserializeObject(sJson)
            'MsgBox($"Total animales: {animales.Count}")

            For Each animal As JObject In animales
                'MsgBox(animal.GetValue("nombre").ToString.ToUpper())
                If animal.GetValue("nombre").ToString.ToUpper.Equals(nombre) Then
                    bAnimal = True
                    Exit For
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return bAnimal

    End Function

End Class
