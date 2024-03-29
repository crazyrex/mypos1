Imports XL.Common
Imports XL.Common.Utils



Public Class S_02_00103        
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_02_00103                                           
                                                                                                 
        Dim result As S_02_00103                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_02_00103), _
                                String.Format("tcp://{0}/S_02_00103.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_02_00103)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_02_00103
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
        ByRef refChooseTurnoverBookStatusList As MyPosXAuto.FTs.FT_CIV_TURNOVER_BOOK_STATUS, _
        ByRef refSvWareArriveConfirm As Boolean, _
        ByRef refSvWareArriveByRecipient As Boolean, _
        ByRef refSvTurnoverMode As Integer, _
        ByRef refSvHideFinancials As Boolean) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_BOOK_STATUSList(valLanguagOption, String.Empty, refChooseTurnoverBookStatusList, False)
        refSvWareArriveConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_ARRIVE_CONFIRM))
        refSvWareArriveByRecipient = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_ARRIVE_BY_RECIPIENT))
        refSvTurnoverMode = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_TURNOVER_MODE))
        refSvHideFinancials = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_HIDE_FINANCIALS))

        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0002( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServLoadWareByCode( _
        ByVal valPosID As String, _
        ByVal valWareCode As String, _
        ByRef setDtlRowSEntity As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERowSEntity, _
        ByVal valTurnoverStyle As Integer, _
        ByRef refCurrentStockAmount As Double, _
        ByRef refPriceNoDiscount As Decimal _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
                    MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(valPosID)

        If IsNothing(posRow) = True Then
            Return MyPosXService.Decls.MSG_ALERT_00027
        End If


        Dim setDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_POS_SET_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        setDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_POS_SET_WAREColumns.WARE_CODEColumn, "=", valWareCode)
        setDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", posRow.POS_SET_ID)

        MyPosXAuto.Facade.AfXV.FillXV_S_MP_POS_SET_WARERowSEntity(setDtlRowSEntity, setDtlConditions)

        If setDtlRowSEntity.IsNull = True Then
            Return MyPosXService.Decls.MSG_ALERT_00004
        End If

        refCurrentStockAmount = Facade.OpBizTurnover.GetPosWareStockAmount(valPosID, setDtlRowSEntity.WARE_ID)

        setDtlRowSEntity.UNIT_COST = _
            Facade.OpBizMaster.GetPosWareCost( _
                setDtlRowSEntity.WARE_ID, _
                valPosID)

        setDtlRowSEntity.UNIT_PRICE = _
                Facade.OpBizMaster.GetPosWarePrice( _
                    setDtlRowSEntity.WARE_ID, _
                     valPosID, _
                     refPriceNoDiscount)

        Return String.Empty

    End Function


    Public Function ServLoadInfo( _
        ByVal valPosID As String, _
        ByVal valWareID As String, _
        ByRef refCurrentStockAmount As Double _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        refCurrentStockAmount = Facade.OpBizTurnover.GetPosWareStockAmount(valPosID, valWareID)

        Return String.Empty

    End Function


    Public Function ServUtld0005( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServLoadWareByBatchCode( _
        ByVal valPosID As String, _
        ByVal valBatchCode As String, _
        ByRef refTurnoverDtlRowSEntity As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRowSEntity, _
        ByRef refCurrentStock As Double, _
        ByRef refOrigionPrice As Decimal) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        turnoverDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.BATCH_CODEColumn, "=", valBatchCode)
        turnoverDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_TYPEColumn, "=", MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN)
        turnoverDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_STYLEColumn, "=", MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RECEIVINGS)


        MyPosXAuto.Facade.AfXV.FillXV_H_MP_TURNOVER_DTLRowSEntity(refTurnoverDtlRowSEntity, turnoverDtlConditions)

        If refTurnoverDtlRowSEntity.IsNull = True Then
            Return MyPosXService.Decls.MSG_ALERT_00032
        End If

        refCurrentStock = Facade.OpBizTurnover.GetPosBatchWareStockAmount( _
                valPosID, _
                valBatchCode)

        refTurnoverDtlRowSEntity.UNIT_PRICE = Facade.OpBizMaster.GetPosWarePrice( _
                refTurnoverDtlRowSEntity.WARE_ID, _
                valPosID, _
                refOrigionPrice)

        Return String.Empty

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
