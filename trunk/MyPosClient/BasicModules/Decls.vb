Namespace Utils


    Public Class Decls

        Public Shared LOGIN_STAFF_ID As String
        Public Shared CURRENT_POS_ROW As MyPosXAuto.FTs.FT_XV_M_MP_POSRow

        Public Shared IMAGE_CODE_INFO As System.Drawing.Imaging.ImageCodecInfo = Nothing
        Public Shared ENCODER_PARAMETER As New System.Drawing.Imaging.EncoderParameters

        Shared Sub New()
            Utils.TK.InitImageParameter()
        End Sub
    End Class

End Namespace
