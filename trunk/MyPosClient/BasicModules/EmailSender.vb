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

        Public _emailFrom As String = String.Empty
        Public _password As String = String.Empty
        Public _SMTPServer As String = String.Empty
        Public _SMTPPort As Integer
        Public _user As String = String.Empty

        Public Sub New( _
           ByVal iEmailFrom As String, _
           ByVal iPassword As String, _
           ByVal iSMTPServer As String, _
           ByVal iSMTPPort As Integer, _
           ByVal iUser As String)

            Me._EmailFrom = iEmailFrom
            Me._password = iPassword
            Me._SMTPServer = iSMTPServer
            Me._SMTPPort = iSMTPPort
            Me._user = iUser

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

            Dim clint As New SmtpClient(SMTPServer, Me._SMTPPort)
            '发送邮件的服务器
            clint.Credentials = New System.Net.NetworkCredential(EmailFrom, Password)
            clint.EnableSsl = True
            clint.Timeout = 15000
            clint.Send(onemail)

        End Function

        Public ReadOnly Property EmailFrom() As String Implements XL.Common.Interfaces.IEmailSender.EmailFrom
            Get
                Return Me._emailFrom
            End Get
        End Property

        Public ReadOnly Property Password() As String Implements XL.Common.Interfaces.IEmailSender.Password
            Get
                Return Me._password
            End Get
        End Property

        Public ReadOnly Property SMTPServer() As String Implements XL.Common.Interfaces.IEmailSender.SMTPServer
            Get
                Return Me._SMTPServer
            End Get
        End Property

        Public ReadOnly Property User() As String Implements XL.Common.Interfaces.IEmailSender.User
            Get
                Return Me._user
            End Get
        End Property
    End Class

End Namespace

