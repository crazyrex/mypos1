Namespace Utils


    Public Class Decls

        Public Shared LOGIN_STAFF_ROW_SE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity
        Public Shared CURRENT_POS_ROW As MyPosXAuto.FTs.FT_M_MP_POSRow

        Public Shared IMAGE_CODE_INFO As System.Drawing.Imaging.ImageCodecInfo = Nothing
        Public Shared ENCODER_PARAMETER As New System.Drawing.Imaging.EncoderParameters

        Public Const CACHE_DATA_FILE_TURNOVER As String = "CACHE_DATA_FILE_TURNOVER"
        Public Const CACHE_DATA_FILE_TURNOVER_DETAIL As String = "CACHE_DATA_FILE_TURNOVER_DETAIL"
        Public Const CACHE_DATA_FILE_TURNOVER_SHARE_DTL As String = "CACHE_DATA_FILE_TURNOVER_SHARE_DTL"
        Shared Sub New()
            Utils.TK.InitImageParameter()
        End Sub
    End Class

End Namespace
