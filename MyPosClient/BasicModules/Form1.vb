Imports XL.Common
Imports System.Drawing.Drawing2D
Imports System.Net.Mail

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        Dim a As Image = Image.FromFile(Me.OpenFileDialog1.FileName)
        Me.PictureBox1.Image = CommTK.GetThumbnail(a, 200, 200)

    End Sub

    
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        SendMail("henryqu01@gmail.com", "果然如此", "是不是内容太少了 ？")
    End Sub

    Public Shared Function SendMail(ByVal StrTo As String, ByVal StrBody As String, ByVal strSubjec As String) As String

        Dim onemail As New MailMessage()

        '发送邮件的邮箱地址
        Dim myEmail As String = "yu.jianjun.cn@gmail.com"
        '发送邮件的邮箱密码
        Dim myPwd As String = ""

        onemail.BodyEncoding = System.Text.Encoding.UTF8
        onemail.IsBodyHtml = True
        onemail.From = New MailAddress(myEmail)
        onemail.[To].Add(New MailAddress(StrTo))
        onemail.Subject = strSubjec
        onemail.Body = StrBody

        Dim clint As New SmtpClient("smtp.gmail.com", 587)
        '发送邮件的服务器
        clint.Credentials = New System.Net.NetworkCredential(myEmail, myPwd)
        clint.EnableSsl = True
        clint.Timeout = 15000
        Try
            clint.Send(onemail)
        Catch ex As Exception
            Return ex.Message
        End Try
        Return ""
    End Function
End Class