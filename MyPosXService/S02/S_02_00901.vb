Imports XL.Common
Imports XL.Common.Utils

Public Class S_02_00901        
    Inherits MarshalByRefObject
    Public Shared Function GetInstance() As S_02_00901                                           
                                                                                                 
        Dim result As S_02_00901                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_02_00901), _
                                String.Format("tcp://{0}/S_02_00901.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_02_00901)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_02_00901
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


    Public Function ServInitDisplay( _
        ByVal valLanguagOption As Integer, _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByRef refSysHideFinancials As Boolean, _
        ByRef refSysShowCustomWareCode As Boolean, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String, _
        ByRef refTurnoverBookStatusList As MyPosXAuto.FTs.FT_CIV_TURNOVER_BOOK_STATUS, _
        ByRef refChoosePosList As MyPosXAuto.FTs.FT_M_MP_POS _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = refChoosePosList.NewM_MP_POSRow
        refChoosePosList.AddM_MP_POSRow(posRow)

        posRow.POS_NAME = ""
        posRow.POS_ID = String.Empty

        posRow = refChoosePosList.NewM_MP_POSRow
        refChoosePosList.AddM_MP_POSRow(posRow)

        posRow.POS_NAME = CommTK.GetTranslatedString("在外")
        posRow.POS_ID = String.Empty

        MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, refChoosePosList)


        refSysWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_SPEC_MODEL_DISCARD))
        refSysHideFinancials = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_HIDE_FINANCIALS))

        refSysAttribute1 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1)
        refSysAttribute2 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2)
        refSysAttribute3 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3)
        refSysAttribute4 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4)

        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1_HIDDEN)) = True Then
            refSysAttribute1 = String.Empty
        End If
        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2_HIDDEN)) = True Then
            refSysAttribute2 = String.Empty
        End If
        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3_HIDDEN)) = True Then
            refSysAttribute3 = String.Empty
        End If
        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4_HIDDEN)) = True Then
            refSysAttribute4 = String.Empty
        End If

        refSysShowCustomWareCode = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE))

        MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_BOOK_STATUSList(valLanguagOption, String.Empty, refTurnoverBookStatusList, True)

        Return result

    End Function


    Public Function ServBizUtld0002( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0002(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0003( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0003(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServLoadareByCode( _
        ByVal valWareCode As String, _
        ByRef refWareRowSE As MyPosXAuto.FTs.FT_M_MP_WARERowSEntity _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim wareConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        wareConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", valWareCode)
        wareConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.PRACT_CODE_REQUIREDColumn, "=", 1)

        MyPosXAuto.Facade.AfBizMaster.FillM_MP_WARERowSEntity(refWareRowSE, wareConditions)

        If IsNothing(refWareRowSE) = True Then
            Return MyPosXService.Decls.MSG_ALERT_00008
        End If

        Return String.Empty


    End Function


    Public Function ServBizUtld0005( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0005(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0006( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0006(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0007( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0007(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0008( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0008(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0009( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0009(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0010( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0010(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0011( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0011(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0012( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0012(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0013( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0013(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0014( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0014(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0015( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0015(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0016( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0016(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0017( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0017(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0018( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0018(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0019( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0019(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0020( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0020(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


End Class
