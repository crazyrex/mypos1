﻿
'===========================================================
'Code generated by Softlands Solution
'-----------------------------------------------------------
'业务操作, 零售简单操作
'
'===========================================================
Imports XL.Common
Imports XL.Common.Utils

Public Class S_02_01001        
    Inherits XL.DB.Utils.BaseService

    Public Shared Function GetInstance() As S_02_01001                                           

        Dim result As S_02_01001                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting Then

            result = CType(Activator.GetObject(GetType(S_02_01001), _                            
                String.Format("tcp://{0}/S_02_01001.remote", _                                
                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                S_02_01001)                                                                      

            If result.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)                  
                ex.SetMessage(CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED)                                
                Throw ex                                                                            
            End If                                                                                  

        Else

            result = New S_02_01001                                                              
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


    Public Function ServBizUtld0001( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0002( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0003( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0004( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0005( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0006( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0007( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0008( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0009( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0010( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0011( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0012( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0013( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0014( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0015( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0016( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0017( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0018( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0019( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    Public Function ServBizUtld0020( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

            If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTH_AUTH_DENIED

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

        Return string.Empty

    End Function


    End Class

