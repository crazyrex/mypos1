Imports XL.Common
Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        Dim a As Image = Image.FromFile(Me.OpenFileDialog1.FileName)
        Me.PictureBox1.Image = CommTK.GetThumbnail(a, 200, 200)

    End Sub

    
End Class