﻿
'===========================================================
'Code generated by Softlands Solution
'-----------------------------------------------------------
'查询, 地点成本原价区分在库
'
'===========================================================
Imports XL.Common
Imports XL.Common.Utils

Public Class S_03_01401        
    Inherits XL.DB.Utils.BaseService

    Public Shared Function GetInstance() As S_03_01401                                           

        Dim result As S_03_01401                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_03_01401), _
                    String.Format("tcp://{0}/S_03_01401.remote", _
                        SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                    S_03_01401)

                If result.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then
                    Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                    ex.SetMessage(CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED)
                    Throw ex
                End If

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try

        Else

            result = New S_03_01401
        End If

        Return result

    End Function

    Public Enum LCs
        None
        Utld0002
        Utld0003
        Utld0004
        Utld0005
    End Enum


    'Public Function ServInitDisplay( _
    '    ByVal valLanguagOption As Integer, _
    '    ByRef refPurchaseWayList As XAuto.FTs.FT_CIV_PURCHASE_WAY, _
    '    ByRef refAssetAbsentTypeList As XAuto.FTs.FT_CIV_ASSET_ABSENT_TYPE, _
    '    ByRef refAssetConformationList As XAuto.FTs.FT_CIV_ASSET_CONFORMATION, _
    '    ByRef refEliminateWayList As XAuto.FTs.FT_CIV_ELIMINATE_WAY, _
    '    ByRef refInAccountCredenceTextList As XAuto.FTs.FT_CIV_IN_ACCOUNT_CREDENCE_TEXT, _
    '    ByRef refSysManageFormMustConfirm As Boolean _
    '    ) As String
    '
    '    XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)
    '
    '    MyPosXAuto.Facade.AfCIV.FillCI_ASSET_CONFORMATIONList(valLanguagOption, String.Empty, refAssetConformationList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_ASSET_ABSENT_TYPEList(valLanguagOption, String.Empty, refAssetAbsentTypeList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_ELIMINATE_WAYList(valLanguagOption, String.Empty, refEliminateWayList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_PURCHASE_WAYList(valLanguagOption, String.Empty, refPurchaseWayList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_IN_ACCOUNT_CREDENCE_TEXTList(valLanguagOption, String.Empty, refInAccountCredenceTextList, False)
    '
    '    refSysManageFormMustConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_MANAGE_FORM_MUST_CONFIRM))
    '
    '    Return String.Empty
    '
    'End Function


    'Public Function ServInitDisplay( _
    '    ByVal valLanguagOption As Integer, _
    '    ByRef refPurchaseWayList As XAuto.FTs.FT_CIV_PURCHASE_WAY, _
    '    ByRef refAssetAbsentTypeList As XAuto.FTs.FT_CIV_ASSET_ABSENT_TYPE, _
    '    ByRef refAssetConformationList As XAuto.FTs.FT_CIV_ASSET_CONFORMATION, _
    '    ByRef refEliminateWayList As XAuto.FTs.FT_CIV_ELIMINATE_WAY, _
    '    ByRef refInAccountCredenceTextList As XAuto.FTs.FT_CIV_IN_ACCOUNT_CREDENCE_TEXT, _
    '    ByRef refSysManageFormMustConfirm As Boolean _
    '    ) As String
    '
    '    XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)
    '
    '    MyPosXAuto.Facade.AfCIV.FillCI_ASSET_CONFORMATIONList(valLanguagOption, String.Empty, refAssetConformationList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_ASSET_ABSENT_TYPEList(valLanguagOption, String.Empty, refAssetAbsentTypeList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_ELIMINATE_WAYList(valLanguagOption, String.Empty, refEliminateWayList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_PURCHASE_WAYList(valLanguagOption, String.Empty, refPurchaseWayList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_IN_ACCOUNT_CREDENCE_TEXTList(valLanguagOption, String.Empty, refInAccountCredenceTextList, False)
    '
    '    refSysManageFormMustConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_MANAGE_FORM_MUST_CONFIRM))
    '
    '    Return String.Empty
    '
    'End Function


    Public Function ServLoadPosInfoByCode( _
        ByVal valPosCode As String, _
        ByRef refPosRowSE As MyPosXAuto.FTs.FT_M_MP_POSRowSEntity _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try

            Dim posConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_POS(XL.DB.Utils.Condition.LogicOperators.Logic_Or)
            posConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_POSColumns.POS_CODEColumn, "=", valPosCode)
            posConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_POSColumns.POS_NAMEColumn, "=", valPosCode)

            MyPosXAuto.Facade.AfBizMaster.FillM_MP_POSRowSEntity(refPosRowSE, posConditions)

            If refPosRowSE.IsNull = True Then
                Return MyPosXService.Decls.MSG_ALERT_00008
            End If

        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0002( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0003( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0004( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0005( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0006( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0007( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0008( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0009( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0010( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0011( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0012( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0013( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0014( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0015( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0016( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0017( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0018( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0019( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServBizUtld0020( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    End Class

