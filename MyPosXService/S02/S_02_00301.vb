Imports XL.Common
Imports XL.Common.Utils
Imports System.Collections
Imports System.Data



Public Class S_02_00301
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_02_00301

        Dim result As S_02_00301
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then
            Try

                result = CType(Activator.GetObject(GetType(S_02_00301), _
                                String.Format("tcp://{0}/S_02_00301.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_02_00301)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_02_00301
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
        ByVal valLoginStaffID As String, _
        ByRef refChoosePosList As MyPosXAuto.FTs.FT_M_MP_POS, _
        ByRef refStaffRowSEntity As MyPosXAuto.FTs.FT_M_STAFFRowSEntity, _
        ByRef refChooseTurnoverBookStatus As MyPosXAuto.FTs.FT_CIV_TURNOVER_BOOK_STATUS, _
        ByRef refSysWareArriveConfirm As Boolean, _
        ByRef refSysHideFinancial As Boolean, _
        ByRef refSysSpecModelDiscard As Boolean, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        MyPosXAuto.Facade.AfBizMaster.FillM_STAFFRowSEntity(refStaffRowSEntity, valLoginStaffID)

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, refChoosePosList)
        MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_BOOK_STATUSList( _
            valLanguagOption, _
            String.Empty, _
            refChooseTurnoverBookStatus, _
            False)

        refSysWareArriveConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_ARRIVE_CONFIRM))
        refSysHideFinancial = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_HIDE_FINANCIALS))
        refSysSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_SPEC_MODEL_DISCARD))

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

        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServLoadWareByCode( _
        ByVal valWareCode As String, _
        ByVal valShowDetailInput As Boolean, _
        ByVal valPosID As String, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL, _
        ByRef refWareRowSE As MyPosXAuto.FTs.FT_M_MP_WARERowSEntity _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        wareCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", valWareCode)

        MyPosXAuto.Facade.AfBizMaster.FillM_MP_WARERowSEntity(refWareRowSE, wareCondition)

        If refWareRowSE.IsNull = True Then
            Return MyPosXService.Decls.MSG_ALERT_00004
        End If

        Dim priceNoDiscount As Decimal
        If valShowDetailInput = False Then

            Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            turnoverDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.WARE_IDColumn, "=", refWareRowSE.WARE_ID)

            Dim bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow = _
                refBindingList.FindRowByCondition(turnoverDtlConditions)

            If IsNothing(bindingRow) = False Then
                If bindingRow.TURNOVER_BOOK_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND Then
                    bindingRow.WARE_AMOUNT += 1
                End If
            Else
                bindingRow = refBindingList.NewXV_H_MP_TURNOVER_DTLRow
                refBindingList.AddXV_H_MP_TURNOVER_DTLRow(bindingRow)

                bindingRow.WARE_CODE = valWareCode
                bindingRow.CUSTOM_CODE = refWareRowSE.CUSTOM_CODE
                bindingRow.WARE_NAME = refWareRowSE.WARE_NAME
                bindingRow.WARE_ID = refWareRowSE.WARE_ID
                bindingRow.SPEC = refWareRowSE.SPEC
                bindingRow.MODEL = refWareRowSE.MODEL
                bindingRow.ATTRIBUTE1 = refWareRowSE.ATTRIBUTE1
                bindingRow.ATTRIBUTE2 = refWareRowSE.ATTRIBUTE2
                bindingRow.ATTRIBUTE3 = refWareRowSE.ATTRIBUTE3
                bindingRow.ATTRIBUTE4 = refWareRowSE.ATTRIBUTE4
                bindingRow.UNIT_NAME = refWareRowSE.UNIT_NAME
                bindingRow.REMARK = refWareRowSE.REMARK
                bindingRow.WARE_AMOUNT = 1
                bindingRow.TURNOVER_BOOK_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND

                bindingRow.UNIT_PRICE = _
                    Facade.OpBizMaster.GetPosWarePrice( _
                        bindingRow.WARE_ID, _
                        valPosID, _
                        priceNoDiscount)

                bindingRow.UNIT_COST = _
                    Facade.OpBizMaster.GetPosWareCost( _
                        bindingRow.WARE_ID, _
                        valPosID)

                bindingRow.ORIGION_UNIT_PRICE = priceNoDiscount

            End If

        End If

        Return String.Empty

    End Function


    Public Function ServUtld0003( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0004( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


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


    Public Function ServImportFromMobile( _
        ByVal valPosID As String, _
        ByVal valReadTurnoverList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
            MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(valPosID)

        If IsNothing(posRow) = True Then
            Return MyPosXService.Decls.MSG_ALERT_00027
        End If

        Dim wareCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_M_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow
        Dim wareRow As MyPosXAuto.FTs.FT_XV_M_MP_WARERow
        Dim origionPrice As Decimal

        For Each turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In valReadTurnoverList

            turnoverDtlConditions.Clear()
            turnoverDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.WARE_CODEColumn, "=", turnoverDtlRow.WARE_CODE)
            bindingRow = refBindingList.FindRowByCondition(turnoverDtlConditions)

            If IsNothing(bindingRow) = True Then

                wareCondition.Clear()
                wareCondition.Add(MyPosXAuto.Facade.AfXV.XV_M_MP_WAREColumns.WARE_CODEColumn, "=", turnoverDtlRow.WARE_CODE)
                wareRow = MyPosXAuto.Facade.AfXV.GetXV_M_MP_WARERow(wareCondition)
                If IsNothing(wareRow) = False Then

                    bindingRow = refBindingList.NewXV_H_MP_TURNOVER_DTLRow
                    refBindingList.AddXV_H_MP_TURNOVER_DTLRow(bindingRow)
                    bindingRow.WARE_ID = wareRow.WARE_ID
                    bindingRow.WARE_NAME = wareRow.WARE_NAME
                    bindingRow.SPEC = wareRow.SPEC
                    bindingRow.MODEL = wareRow.MODEL
                    bindingRow.UNIT_NAME = wareRow.UNIT_NAME
                    bindingRow.ATTRIBUTE1 = wareRow.ATTRIBUTE1
                    bindingRow.ATTRIBUTE2 = wareRow.ATTRIBUTE2
                    bindingRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                    bindingRow.ATTRIBUTE4 = wareRow.ATTRIBUTE4
                    bindingRow.REMARK = wareRow.REMARK
                    bindingRow.WARE_AMOUNT = turnoverDtlRow.WARE_AMOUNT
                    bindingRow.WARE_CODE = wareRow.WARE_CODE
                    bindingRow.CUSTOM_CODE = wareRow.CUSTOM_CODE
                    bindingRow.UNIT_COST = Facade.OpBizMaster.GetPosWareCost(wareRow.WARE_ID, posRow.POS_ID)
                    bindingRow.UNIT_PRICE = Facade.OpBizMaster.GetPosWarePrice(wareRow.WARE_ID, posRow.POS_ID, origionPrice)
                    bindingRow.UNIT_DISCOUNT = origionPrice - bindingRow.UNIT_PRICE
                    bindingRow.TURNOVER_BOOK_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND
                End If
            Else
                bindingRow.WARE_AMOUNT += turnoverDtlRow.WARE_AMOUNT
            End If

        Next


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


    Public Function ServSaveInfo( _
        ByVal valFromLocation As String, _
        ByVal valToLocation As String, _
        ByVal valConsignDueDate As DateTime, _
        ByVal valEmployeeID As String, _
        ByVal valConfirmArrivalDone As Boolean, _
        ByVal valConfirmPaymentDone As Boolean, _
        ByRef refInTurnoverCode As String, _
        ByRef refOutTurnoverCode As String, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL, _
        ByRef refValidateResult As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        refValidateResult = Me.ServValidateAvailableAmount(valFromLocation, refBindingList)

        If refValidateResult.Length > 0 Then
            Return String.Empty
        End If

        refInTurnoverCode = Facade.OpBizTurnover.GetAutoTransferCode(False, valToLocation, MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN)
        refOutTurnoverCode = Facade.OpBizTurnover.GetAutoTransferCode(False, valFromLocation, MyPosXAuto.Decls.CIVALUE_IO_TYPE_OUT)

        Dim reliefPairID = Guid.NewGuid.ToString
        Dim currentTime As DateTime = CommTK.GetSyncServerTime
        Dim fromTurnoverID = Guid.NewGuid.ToString

        Dim turnoverList As New MyPosXAuto.FTs.FT_H_MP_TURNOVER
        Dim turnoverRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow
        Dim moveTurnoverBackList As New MyPosXAuto.FTs.FT_H_MP_MOVE_TURNOVER_BAK
        Dim moveTurnoverBackRow As MyPosXAuto.FTs.FT_H_MP_MOVE_TURNOVER_BAKRow
        Dim moveTurnoverBackDtlList As New MyPosXAuto.FTs.FT_H_MP_MOVE_TURNOVER_DTL_BAK
        Dim moveTurnoverDtlBackRow As MyPosXAuto.FTs.FT_H_MP_MOVE_TURNOVER_DTL_BAKRow

        'MyPosXAuto.Facade.AfBizTurnover.CreateH_MP_TURNOVERInfo( _

        turnoverRow = turnoverList.AddNewH_MP_TURNOVERRow( _
            MyPosXAuto.Decls.CIVALUE_BALANCE_STATUS_DONE, _
            0, _
            String.Empty, _
            valConsignDueDate, _
            0, _
            String.Empty, _
            0, _
            String.Empty, _
            0, _
            0, _
            0, _
            valFromLocation, _
            reliefPairID, _
            String.Empty, _
            String.Empty, _
            0, _
            valEmployeeID, _
            0, _
            String.Empty, _
            refOutTurnoverCode, _
            MyPosXAuto.Decls.CIVALUE_TURNOVER_CONSIGN_STATUS_NOT_YET, _
            fromTurnoverID, _
            MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_MOVE, _
            currentTime, _
            MyPosXAuto.Decls.CIVALUE_IO_TYPE_OUT)

        moveTurnoverBackRow = moveTurnoverBackList.NewH_MP_MOVE_TURNOVER_BAKRow
        moveTurnoverBackList.AddH_MP_MOVE_TURNOVER_BAKRow(moveTurnoverBackRow)
        moveTurnoverBackRow.CloneDataRow(turnoverRow)

        For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In refBindingList
            If bindingRow.RowState <> DataRowState.Deleted Then
                bindingRow.TURNOVER_ID = fromTurnoverID
                bindingRow.DETAIL_ID = Guid.NewGuid.ToString
                moveTurnoverDtlBackRow = moveTurnoverBackDtlList.NewH_MP_MOVE_TURNOVER_DTL_BAKRow
                moveTurnoverBackDtlList.AddH_MP_MOVE_TURNOVER_DTL_BAKRow(moveTurnoverDtlBackRow)
                moveTurnoverDtlBackRow.CloneDataRow(bindingRow)
            End If
        Next

        MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_DTLData(refBindingList)

        Dim toTurnoverID = Guid.NewGuid.ToString

        turnoverRow = turnoverList.AddNewH_MP_TURNOVERRow( _
            MyPosXAuto.Decls.CIVALUE_BALANCE_STATUS_DONE, _
            0, _
            String.Empty, _
            valConsignDueDate, _
            0, _
            String.Empty, _
            0, _
            String.Empty, _
            0, _
            0, _
            0, _
            valToLocation, _
            reliefPairID, _
            String.Empty, _
            String.Empty, _
            0, _
            valEmployeeID, _
            0, _
            String.Empty, _
            refInTurnoverCode, _
            MyPosXAuto.Decls.CIVALUE_TURNOVER_CONSIGN_STATUS_NOT_YET, _
            toTurnoverID, _
            MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_MOVE, _
            currentTime, _
            MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN)

        moveTurnoverBackRow = moveTurnoverBackList.NewH_MP_MOVE_TURNOVER_BAKRow
        moveTurnoverBackList.AddH_MP_MOVE_TURNOVER_BAKRow(moveTurnoverBackRow)
        moveTurnoverBackRow.CloneDataRow(turnoverRow)

        For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In refBindingList
            If bindingRow.RowState <> DataRowState.Deleted Then
                bindingRow.TURNOVER_ID = toTurnoverID
                bindingRow.DETAIL_ID = Guid.NewGuid.ToString
                If valConfirmArrivalDone = False Then
                    bindingRow.TURNOVER_BOOK_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_BOOK
                End If
                moveTurnoverDtlBackRow = moveTurnoverBackDtlList.NewH_MP_MOVE_TURNOVER_DTL_BAKRow
                moveTurnoverBackDtlList.AddH_MP_MOVE_TURNOVER_DTL_BAKRow(moveTurnoverDtlBackRow)
                moveTurnoverDtlBackRow.CloneDataRow(bindingRow)
            End If
        Next

        MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_MOVE_TURNOVER_BAKData(moveTurnoverBackList)
        MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_MOVE_TURNOVER_DTL_BAKData(moveTurnoverBackDtlList)

        MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVERData(turnoverList)
        MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_DTLData(refBindingList)

        Facade.OpBizTurnover.GenerateDefaultTurnoverConsign(fromTurnoverID)
        Facade.OpBizTurnover.GenerateDefaultTurnoverConsign(toTurnoverID)

        If valConfirmPaymentDone = True Then
            Facade.OpBizTurnover.GenerateDefaultTurnoverPayment(fromTurnoverID)
            Facade.OpBizTurnover.GenerateDefaultTurnoverPayment(toTurnoverID)
        End If

        CommTK.OutputLog( _
            String.Format("Relief pair id {0} created", reliefPairID), _
            String.Format("turnoverIDFrom: {0}, turnoverIDTo: {1}", fromTurnoverID, toTurnoverID))

        Return String.Empty

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


    Public Function ServValidateAvailableAmount( _
        ByVal valFromLocation As String, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        '当允许负库存时, 不需要判断库存可用
        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_ALLOW_MINUS_STOCK)) = True Then
            Return String.Empty
        End If

        Dim turnoverDtlCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        turnoverDtlCondition.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_BOOK_STATUSColumn, "=", MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND)
        Dim wareIDs As New ArrayList
        Dim bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow
        For Each bindingRow In refBindingList.FindRowsByCondition(turnoverDtlCondition)
            wareIDs.Add(bindingRow.WARE_ID)
        Next

        Dim stockCondition As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_POS_WARE_TOTAL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        stockCondition.Add(MyPosXAuto.Facade.AfMV.MV_MP_POS_WARE_TOTALColumns.POS_IDColumn, "=", valFromLocation)
        stockCondition.Add(MyPosXAuto.Facade.AfMV.MV_MP_POS_WARE_TOTALColumns.WARE_IDColumn, True, wareIDs)

        Dim stockList As New MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTAL
        Dim stockRow As MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTALRow

        MyPosXAuto.Facade.AfMV.FillFT_MV_MP_POS_WARE_TOTAL(stockCondition, stockList)

        Dim currentAmount As Decimal
        For Each bindingRow In refBindingList.FindRowsByCondition(turnoverDtlCondition)

            stockCondition.Clear()
            stockCondition.Add(MyPosXAuto.Facade.AfMV.MV_MP_POS_WARE_TOTALColumns.WARE_IDColumn, "=", bindingRow.WARE_ID)
            stockRow = stockList.FindRowByCondition(stockCondition)


            currentAmount = 0
            If IsNothing(stockRow) = False Then
                currentAmount = stockRow.CURRENT_AMOUNT
            End If
            If currentAmount < bindingRow.WARE_AMOUNT Then
                bindingRow.ROW_REMARK = CommTK.GetTranslatedString(MyPosXService.Decls.ROW_REMARK_0001, currentAmount)
                bindingRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_OUT_OF_STOCK
                Return MyPosXService.Decls.MSG_ALERT_00007
            End If

        Next

        Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
            MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(valFromLocation)

        If IsNothing(posRow) = True Then
            Return MyPosXService.Decls.MSG_ALERT_00026
        End If

        Dim posSetWareConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_POS_SET_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        posSetWareConditions.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", posRow.POS_SET_ID)
        Dim posSetWareList As New MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARE
        MyPosXAuto.Facade.AfXV.FillFT_XV_S_MP_POS_SET_WARE(posSetWareConditions, posSetWareList)

        turnoverDtlCondition.Clear()
        For Each bindingRow In refBindingList.FindRowsByCondition(turnoverDtlCondition)

            posSetWareConditions.Clear()
            posSetWareConditions.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_POS_SET_WAREColumns.WARE_IDColumn, "=", bindingRow.WARE_ID)
            If posSetWareList.FindRowsByCondition(posSetWareConditions).Count = 0 Then
                bindingRow.ROW_REMARK = CommTK.GetTranslatedString(MyPosXService.Decls.ROW_REMARK_0002)
                bindingRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_OUT_WARE_OF_POS_MANAGEMENT

                Return MyPosXService.Decls.MSG_ALERT_00004

            End If

        Next

        Return String.Empty

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
