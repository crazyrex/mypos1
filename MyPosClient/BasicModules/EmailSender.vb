Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports System.Globalization
Imports System.Threading
Imports System.Diagnostics
Imports System.Text
Imports System.Net.Mail

Namespace Utils
    Public Class EmailSender
        Implements XL.Common.Interfaces.IEmailSender

        Public _iEmailFrom As String = String.Empty
        Public _iPassword As String = String.Empty
        Public _iSMTPServer As String = String.Empty
        Public _iUser As String = String.Empty

        Public Sub New( _
           ByVal iEmailFrom As String, _
           ByVal iPassword As String, _
           ByVal iSMTPServer As String, _
           ByVal iUser As String)

            Me._iEmailFrom = iEmailFrom
            Me._iPassword = iPassword
            Me._iSMTPServer = iSMTPServer
            Me._iUser = iUser

        End Sub

        Public Function SendEmail(ByVal toMailAddress As String, ByVal subject As String, ByVal body As String) As Boolean Implements XL.Common.Interfaces.IEmailSender.SendEmail
            Dim onemail As New MailMessage()

            ''发送邮件的邮箱地址
            'Dim myEmail As String = "yu.jianjun.cn@gmail.com"
            ''发送邮件的邮箱密码
            'Dim myPwd As String = ""

            onemail.BodyEncoding = System.Text.Encoding.UTF8
            onemail.IsBodyHtml = True
            onemail.From = New MailAddress(EmailFrom)
            onemail.[To].Add(New MailAddress(toMailAddress))
            onemail.Subject = subject
            onemail.Body = body

            Dim clint As New SmtpClient("smtp.gmail.com", 587)
            '发送邮件的服务器
            clint.Credentials = New System.Net.NetworkCredential(EmailFrom, Password)
            clint.EnableSsl = True
            clint.Timeout = 15000
            clint.Send(onemail)

        End Function

        Public ReadOnly Property EmailFrom() As String Implements XL.Common.Interfaces.IEmailSender.EmailFrom
            Get
                Return _iEmailFrom
            End Get
        End Property

        Public ReadOnly Property Password() As String Implements XL.Common.Interfaces.IEmailSender.Password
            Get
                Return _iPassword
            End Get
        End Property

        Public ReadOnly Property SMTPServer() As String Implements XL.Common.Interfaces.IEmailSender.SMTPServer
            Get
                Return _iSMTPServer
            End Get
        End Property

        Public ReadOnly Property User() As String Implements XL.Common.Interfaces.IEmailSender.User
            Get
                Return _iUser
            End Get
        End Property
    End Class

End Namespace

