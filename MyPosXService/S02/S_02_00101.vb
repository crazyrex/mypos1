Imports XL.Common
Imports XL.Common.Utils



Public Class S_02_00101        
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_02_00101                                           
                                                                                                 
        Dim result As S_02_00101                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_02_00101), _
                                String.Format("tcp://{0}/S_02_00101.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_02_00101)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_02_00101
        End If

        Return result

    End Function

    Public Enum LCs
        None
        Choose
        Utld0003
        Utld0004
        Utld0005
    End Enum




    Public Function ServInitDisplay( _
        ByVal valLanguagOption As Integer, _
        ByRef refSysWareArriveConfirm As Boolean, _
        ByRef refSysMoneyArriveConfirm As Boolean, _
        ByRef refSysHideFinancials As Boolean _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        'MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_TYPEList(valLanguagOption, String.Empty, refChooseTurnoverTypeList, True)
        'MyPosXAuto.Facade.AfCIV.FillCI_BALANCE_STATUSList(valLanguagOption, String.Empty, refChooseBalanceStatuslist, False)
        'MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_CONSIGN_STATUSList(valLanguagOption, String.Empty, refChooseTurnoverConsignStatusList, False)

        'Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = refChoosePosList.NewM_MP_POSRow
        'refChoosePosList.AddM_MP_POSRow(posRow)

        'MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, refChoosePosList)

        refSysWareArriveConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_ARRIVE_CONFIRM))
        refSysMoneyArriveConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_MONEY_ARRIVE_CONFIRM))
        refSysHideFinancials = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_HIDE_FINANCIALS))

        Return result

    End Function


    Public Function ServUpdateTurnoverStyleFilter( _
        ByVal valLanguagOption As Integer, _
        ByVal valTurnoverType As Integer, _
        ByRef refChooseTurnoverStyleList As MyPosXAuto.FTs.FT_CIV_TURNOVER_STYLE _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        If valTurnoverType = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN Then

            MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList( _
                valLanguagOption, _
                String.Empty, _
                refChooseTurnoverStyleList, _
                True, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_MOVE, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_SOLD, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_CHECK_REPLACE)

        ElseIf valTurnoverType = MyPosXAuto.Decls.CIVALUE_IO_TYPE_OUT Then

            MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList( _
                valLanguagOption, _
                String.Empty, _
                refChooseTurnoverStyleList, _
                True, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_MOVE, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RECEIVINGS, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_CHECK_REPLACE)

        Else
            MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList( _
                valLanguagOption, _
                String.Empty, _
                refChooseTurnoverStyleList, _
                True)

        End If


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServDeleteInfo( _
        ByVal valTurnoverRowSE As MyPosXAuto.FTs.FT_MV_MP_TURNOVERRowSEntity _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        If valTurnoverRowSE.RELIEF_PAIR_ID.Length > 0 Then
            Dim turnoverCondition As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            turnoverCondition.Add(MyPosXAuto.Facade.AfBizTurnover.H_MP_TURNOVERColumns.RELIEF_PAIR_IDColumn, "=", valTurnoverRowSE.RELIEF_PAIR_ID)
            MyPosXAuto.Facade.AfBizTurnover.DeleteH_MP_TURNOVERData(turnoverCondition)
        Else
            MyPosXAuto.Facade.AfBizTurnover.DeleteH_MP_TURNOVERInfo(valTurnoverRowSE.TURNOVER_ID)
        End If

        CommTK.OutputLog( _
            MyPosXService.Decls.LOG_TITLE_00001, _
            String.Format("Bill {0} deleted with ReliefPairID:'{3}', by [{1}] at {2:yyyy-MM-dd HH:mm}", _
                valTurnoverRowSE.TURNOVER_CODE, _
                SysInfo.LoginAccount, _
                DateTime.Now, _
                valTurnoverRowSE.RELIEF_PAIR_ID))

        Return result

    End Function


    Public Function ServPrintTurnoverView( _
        ByVal valTurnoverID As String, _
        ByRef refTurnoverDtlRowSE As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRowSEntity, _
        ByRef refTurnoverDtlList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL _
        ) As String


        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        turnoverDtlConditions.Add( _
            MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, _
            "=", _
            valTurnoverID)

        MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_DTL(turnoverDtlConditions, refTurnoverDtlList)

        'MyPosXAuto.Facade.AfXV.FillXV_H_MP_TURNOVER_DTLRowSEntity(refTurnoverDtlRowSE, turnoverDtlConditions)

        'If refTurnoverDtlRowSE.IsNull = True Then
        '    Return XService.Decls.MSG_ALERT_00008
        'End If

        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0005( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)



        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0006( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0007( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0008( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0009( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0010( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0011( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0012( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0013( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0014( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0015( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0016( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0017( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0018( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0019( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0020( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


End Class
