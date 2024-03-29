Imports XL.Common
Imports XL.Common.Utils
Imports System.Collections
Imports System.Data
Imports MyPosXAuto.Facade



Public Class S_02_00102
    Inherits MarshalByRefObject

    Public Sub New()

    End Sub

    Public Shared Function GetInstance() As S_02_00102

        Dim result As S_02_00102
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_02_00102), _
                                String.Format("tcp://{0}/S_02_00102.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_02_00102)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_02_00102
        End If

        Return result

    End Function


    Public Enum LCs
        None
        View
        Deposit
        Withdraw
        Utld0005
    End Enum


    Public Function ServPrintPurchaseList( _
        ByVal valPosID As String, _
        ByRef refCompanyTitle As String, _
        ByRef refServiceTel As String, _
        ByVal valTurnoverID As String, _
        ByRef refTurnoverDtlList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        refCompanyTitle = CommTK.FString(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_COMPANY_TITLE))
        refServiceTel = CommTK.FString(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SERVICE_TEL))

        Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        turnoverDtlConditions.Add( _
            MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, _
            "=", _
            valTurnoverID)

        MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_DTL(turnoverDtlConditions, refTurnoverDtlList)

        For Each turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In refTurnoverDtlList
            turnoverDtlRow.ROW_REMARK = Facade.OpBizMaster.GetWareInfoString(turnoverDtlRow.WARE_ID, valPosID, False)
        Next

        Return result

    End Function


    Public Function ServInitDisplay( _
        ByVal valLanguagOption As Integer, _
        ByVal valLaunchCondition As LCs, _
        ByRef refEditingTurnoverStyle As Integer, _
        ByRef refSvWareTurnoverMode As Integer, _
        ByRef refChooseTurnoverStyleList As MyPosXAuto.FTs.FT_CIV_TURNOVER_STYLE, _
        ByVal valLoginStaffID As String, _
        ByRef refWareBatchPrefix As String, _
        ByRef refStaffRowSE As MyPosXAuto.FTs.FT_M_STAFFRowSEntity, _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByRef refSysHideFinancials As Boolean, _
        ByRef refSysShowCustomWareCode As Boolean, _
        ByRef refSysWareArriveConfirm As Boolean, _
        ByRef refSysClientCreatingAllowed As Boolean, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        Dim result As String = String.Empty

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        refWareBatchPrefix = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_BATCH_PREFIX)
        refSvWareTurnoverMode = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_TURNOVER_MODE))
        'MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, refChoosePosList)
        'MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_BOOK_STATUSList(valLanguagOption, String.Empty, refChooseTurnoverBookStatusList, False)

        MyPosXAuto.Facade.AfBizMaster.FillM_STAFFRowSEntity(refStaffRowSE, valLoginStaffID)

        If refEditingTurnoverStyle = MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_MOVE Then
            MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList( _
                valLanguagOption, _
                String.Empty, _
                refChooseTurnoverStyleList, _
                False, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_OTHERS, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_SAMPLES, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RECEIVINGS, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RETURNS, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_SOLD, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_CHECK_REPLACE)

        ElseIf refEditingTurnoverStyle = MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_CHECK_REPLACE Then
            MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList( _
                valLanguagOption, _
                String.Empty, _
                refChooseTurnoverStyleList, _
                False, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_OTHERS, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_SAMPLES, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_MOVE, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RECEIVINGS, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RETURNS, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_SOLD)

        Else
            If valLaunchCondition = LCs.Deposit Then

                MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList( _
                    valLanguagOption, _
                    String.Empty, _
                    refChooseTurnoverStyleList, _
                    False, _
                    MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_MOVE, _
                    MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_SOLD, _
                    MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_CHECK_REPLACE)
                refEditingTurnoverStyle = MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RECEIVINGS

            ElseIf valLaunchCondition = LCs.Withdraw Then

                MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList( _
                    valLanguagOption, _
                    String.Empty, _
                    refChooseTurnoverStyleList, _
                    False, _
                    MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_MOVE, _
                    MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RECEIVINGS, _
                    MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_CHECK_REPLACE)

                refEditingTurnoverStyle = MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_SOLD

            ElseIf valLaunchCondition = LCs.View Then

                MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList( _
                    valLanguagOption, _
                    String.Empty, _
                    refChooseTurnoverStyleList, _
                    False)

            End If

        End If

        refSysWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_SPEC_MODEL_DISCARD))
        refSysHideFinancials = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_HIDE_FINANCIALS))
        refSysShowCustomWareCode = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE))

        refSysWareArriveConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_ARRIVE_CONFIRM))

        refSysClientCreatingAllowed = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_QUICK_CLIENT_CREATING_ALLOWED))

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

        Return result

    End Function


    Public Function ServSaveInfo( _
        ByVal valTurnoverType As Integer, _
        ByRef refTurnoverBatchIndex As Integer, _
        ByVal valPosID As String, _
        ByRef refEditingTurnoverID As String, _
        ByVal valCustomerID As String, _
        ByRef valTurnoverStyle As Integer, _
        ByVal valDeliveryCharge As Decimal, _
        ByVal valDeliveryDetail As String, _
        ByVal valExtraDiscount As Decimal, _
        ByVal valStaffShareRate As Double, _
        ByVal valSupplierID As String, _
        ByVal valRemarks As String, _
        ByVal valEmployeeID As String, _
        ByVal valManualCode As Boolean, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL, _
        ByRef refTurnoverCode As String, _
        ByRef refValidateResult As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        If refEditingTurnoverID.Length <= 0 Then

            Me.ServUpdateCurrentAmount(valPosID, refBindingList)
            refValidateResult = Me.ServValidateAvailableAmount(valTurnoverType, valPosID, refBindingList, refValidateResult)

            If refValidateResult.Length > 0 Then
                Return refValidateResult
            End If

        End If


        If refBindingList.FindRowsHighlight(MyPosXService.Decls.ROW_HIGHLIGHT_OUT_OF_STOCK).Count > 0 Then
            Return MyPosXService.Decls.MSG_ALERT_00019
        End If

        Dim turnoverList As New MyPosXAuto.FTs.FT_H_MP_TURNOVER_DTL

        Dim turnoverConditions As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)

        Dim turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow
        Dim turnoverDtlList As New MyPosXAuto.FTs.FT_H_MP_TURNOVER_DTL

        If valManualCode = False Then
            refTurnoverCode = Facade.OpBizTurnover.GetAutoTurnoverCode(False, valTurnoverType, valPosID)
        End If

        '保存操作
        If refEditingTurnoverID.Length = 0 Then

            If valTurnoverType = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN AndAlso _
                valTurnoverStyle <> MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RETURNS Then

                refTurnoverBatchIndex = Facade.OpBizTurnover.GetTurnoverBatchIndex

            End If
            refEditingTurnoverID = Guid.NewGuid.ToString
            MyPosXAuto.Facade.AfBizTurnover.CreateH_MP_TURNOVERInfo( _
                MyPosXAuto.Decls.CIVALUE_BALANCE_STATUS_NOT_YET, _
                refTurnoverBatchIndex, _
                valCustomerID, _
                CommDecl.NULL_DATETIME, _
                valDeliveryCharge, _
                valDeliveryDetail, _
                valExtraDiscount, _
                String.Empty, _
                0, _
                0, _
                0, _
                valPosID, _
                String.Empty, _
                valRemarks, _
                String.Empty, _
                0, _
                valEmployeeID, _
                valStaffShareRate, _
                valSupplierID, _
                refTurnoverCode, _
                MyPosXAuto.Decls.CIVALUE_TURNOVER_CONSIGN_STATUS_NOT_YET, _
                refEditingTurnoverID, _
                valTurnoverStyle, _
                CommTK.GetSyncServerTime, _
                valTurnoverType)

            For Each turnoverDtlRow In refBindingList
                If turnoverDtlRow.RowState <> DataRowState.Deleted Then
                    turnoverDtlRow.TURNOVER_ID = refEditingTurnoverID
                    If turnoverDtlRow.DETAIL_ID.Length = 0 Then
                        turnoverDtlRow.DETAIL_ID = Guid.NewGuid.ToString
                    End If
                End If
            Next

            If valTurnoverStyle <> MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RETURNS Then
                Facade.OpBizTurnover.SetAutoWareBatchCode( _
                    refTurnoverCode, _
                    refBindingList, _
                    refTurnoverBatchIndex)
            End If

            MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_DTLData(refBindingList)

            Return String.Empty

        End If

        '修改父货品列表
        MyPosXAuto.Facade.AfBizTurnover.ReviseH_MP_TURNOVERInfo( _
            refEditingTurnoverID, _
            CommDecl.NULL_INTEGER, _
            CommDecl.NULL_INTEGER, _
            valCustomerID, _
            CommDecl.NULL_DATETIME, _
            valDeliveryCharge, _
            valDeliveryDetail, _
            valExtraDiscount, _
            String.Empty, _
            0, _
            0, _
            0, _
            valPosID, _
            Nothing, _
            valRemarks, _
            Nothing, _
            0, _
            valEmployeeID, _
            valStaffShareRate, _
            valSupplierID, _
            Nothing, _
            CommDecl.NULL_INTEGER, _
            valTurnoverStyle, _
            CommDecl.NULL_DATE, _
            valTurnoverType)


        For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In refBindingList
            If bindingRow.RowState <> DataRowState.Deleted Then
                bindingRow.TURNOVER_ID = refEditingTurnoverID
            End If
        Next

        If valTurnoverType = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN Then
            Facade.OpBizTurnover.SetAutoWareBatchCode( _
                refTurnoverCode, _
                refBindingList, _
                refTurnoverBatchIndex)
        End If

        MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_DTLData(refBindingList)

        Dim turnoverRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow = _
            MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVERRow(refEditingTurnoverID)

        If valTurnoverStyle = MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_MOVE Then
            Facade.OpBizTurnover.SycronizeMoveTurnoverDtls(turnoverRow.TURNOVER_ID, turnoverRow.RELIEF_PAIR_ID)
        End If

        Return String.Empty
    End Function


    Public Function ServValidateAvailableAmount( _
        ByVal valTurnoverType As Integer, _
        ByVal valPosID As String, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL, _
        ByRef refValidateResult As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        refBindingList.ResetRowHighlighting()

        '当为进货状态时, 不需要判断库存可用
        If valTurnoverType = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN Then
            Return String.Empty
        End If

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
        stockCondition.Add(MyPosXAuto.Facade.AfMV.MV_MP_POS_WARE_TOTALColumns.POS_IDColumn, "=", valPosID)
        stockCondition.Add(MyPosXAuto.Facade.AfMV.MV_MP_POS_WARE_TOTALColumns.WARE_IDColumn, True, wareIDs)

        Dim stockList As New MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTAL
        Dim stockRow As MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTALRow

        MyPosXAuto.Facade.AfMV.FillFT_MV_MP_POS_WARE_TOTAL(stockCondition, stockList)

        Dim currentAmount As Double = 0
        For Each bindingRow In refBindingList.FindRowsByCondition(turnoverDtlCondition)

            stockCondition.Clear()
            stockCondition.Add(MyPosXAuto.Facade.AfMV.MV_MP_POS_WARE_TOTALColumns.WARE_IDColumn, "=", bindingRow.WARE_ID)
            stockRow = stockList.FindRowByCondition(stockCondition)

            currentAmount = 0

            If IsNothing(stockRow) = False Then
                currentAmount = stockRow.CURRENT_AMOUNT
            End If

            If currentAmount < bindingRow.WARE_AMOUNT Then
                bindingRow.ROW_REMARK = CommTK.GetTranslatedString(MyPosXService.Decls.ROW_REMARK_0001, CommTK.FString(currentAmount))
                bindingRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_OUT_OF_STOCK
                refValidateResult = MyPosXService.Decls.MSG_ALERT_00007
            End If

        Next

        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServLoadWareByCode( _
        ByVal valPosID As String, _
        ByVal valWareCode As String, _
        ByRef refSetDtlRowSEntity As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERowSEntity, _
        ByVal valShowDetailInput As Boolean, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL, _
        ByVal valTurnoverType As Integer, _
        ByVal valTurnoverStyle As Integer) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
            MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(valPosID)

        If IsNothing(posRow) = True Then
            Return MyPosXService.Decls.MSG_ALERT_00027
        End If

        Dim setDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_POS_SET_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        setDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_POS_SET_WAREColumns.WARE_CODEColumn, "=", valWareCode)
        setDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", posRow.POS_SET_ID)


        MyPosXAuto.Facade.AfXV.FillXV_S_MP_POS_SET_WARERowSEntity(refSetDtlRowSEntity, setDtlConditions)

        If refSetDtlRowSEntity.IsNull = True Then
            Return MyPosXService.Decls.MSG_ALERT_00004
        End If

        Dim priceNoDiscount As Decimal

        If valShowDetailInput = False Then

            Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            turnoverDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.WARE_IDColumn, "=", refSetDtlRowSEntity.WARE_ID)

            Dim bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow = _
                refBindingList.FindRowByCondition(turnoverDtlConditions)

            If IsNothing(bindingRow) = False Then
                If bindingRow.TURNOVER_BOOK_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND Then
                    bindingRow.WARE_AMOUNT += 1
                End If
            Else
                bindingRow = refBindingList.NewXV_H_MP_TURNOVER_DTLRow
                refBindingList.AddXV_H_MP_TURNOVER_DTLRow(bindingRow)

                bindingRow.WARE_CODE = refSetDtlRowSEntity.WARE_CODE
                bindingRow.WARE_NAME = refSetDtlRowSEntity.WARE_NAME
                bindingRow.WARE_ID = refSetDtlRowSEntity.WARE_ID
                bindingRow.SPEC = refSetDtlRowSEntity.SPEC
                bindingRow.MODEL = refSetDtlRowSEntity.MODEL
                bindingRow.UNIT_NAME = refSetDtlRowSEntity.UNIT_NAME
                'bindingRow.REMARK = refSetDtlRowSEntity.REMARK
                bindingRow.WARE_AMOUNT = 1
                bindingRow.TURNOVER_BOOK_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND
                bindingRow.CUSTOM_CODE = refSetDtlRowSEntity.CUSTOM_CODE
                bindingRow.ATTRIBUTE1 = refSetDtlRowSEntity.ATTRIBUTE1
                bindingRow.ATTRIBUTE2 = refSetDtlRowSEntity.ATTRIBUTE2
                bindingRow.ATTRIBUTE3 = refSetDtlRowSEntity.ATTRIBUTE3
                bindingRow.ATTRIBUTE4 = refSetDtlRowSEntity.ATTRIBUTE4

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


    Public Function ServNewCustomer( _
        ByRef refCustomerCode As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        refCustomerCode = Facade.OpBizMaster.GetAutoCustomerCode(False)

        Return result

    End Function


    Public Function ServLoadCustomerByCode( _
        ByVal valClientCode As String, _
        ByRef refClientRowSEntity As MyPosXAuto.FTs.FT_M_MP_CLIENTRowSEntity _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim clientConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_CLIENT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        clientConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_CLIENTColumns.CLIENT_CODEColumn, "=", valClientCode)

        MyPosXAuto.Facade.AfBizMaster.FillM_MP_CLIENTRowSEntity(refClientRowSEntity, clientConditions)



        Return String.Empty

    End Function


    Public Function ServLoadInfo( _
        ByVal valEditingTurnoverID As String, _
        ByRef refTurnoverRowSEntity As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVERRowSEntity, _
        ByRef refClientRowSEntity As MyPosXAuto.FTs.FT_M_MP_CLIENTRowSEntity, _
        ByRef refSupplierRowSEntity As MyPosXAuto.FTs.FT_M_MP_SUPPLIERRowSEntity, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim turnoverConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        turnoverConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVERColumns.TURNOVER_IDColumn, "=", valEditingTurnoverID)

        MyPosXAuto.Facade.AfXV.FillXV_H_MP_TURNOVERRowSEntity(refTurnoverRowSEntity, turnoverConditions)

        If refTurnoverRowSEntity.IsNull = True Then
            Return Decls.MSG_ALERT_00022
        End If

        MyPosXAuto.Facade.AfBizMaster.FillM_MP_CLIENTRowSEntity(refClientRowSEntity, refTurnoverRowSEntity.CLIENT_ID)
        MyPosXAuto.Facade.AfBizMaster.FillM_MP_SUPPLIERRowSEntity(refSupplierRowSEntity, refTurnoverRowSEntity.SUPPLIER_ID)

        Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        turnoverDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, "=", valEditingTurnoverID)
        MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_DTL(turnoverDtlConditions, refBindingList)

        Return String.Empty

    End Function


    Public Function ServExportExcel( _
        ByVal valEditingTurnoverID As String, _
        ByRef refTurnoverRowSEntity As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVERRowSEntity, _
        ByRef refTurnoverDtlList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL, _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByRef refSysHideFinancials As Boolean, _
        ByVal valLoginStaffID As String, _
        ByRef refStaffRowSE As MyPosXAuto.FTs.FT_M_STAFFRowSEntity, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        Dim turnoverConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        turnoverConditions.Add( _
            MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVERColumns.TURNOVER_IDColumn, _
            "=", _
            valEditingTurnoverID)

        MyPosXAuto.Facade.AfXV.FillXV_H_MP_TURNOVERRowSEntity(refTurnoverRowSEntity, turnoverConditions)

        If refTurnoverRowSEntity.IsNull = True Then
            Return MyPosXService.Decls.MSG_ALERT_00022
        End If

        Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        turnoverDtlConditions.Add( _
            MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, _
            "=", _
            valEditingTurnoverID)

        MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_DTL(turnoverDtlConditions, refTurnoverDtlList)

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

        Return result


    End Function


    Public Function ServGenerateDefaultConsignAndPayment( _
        ByVal valEditingTurnoverID As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Facade.OpBizTurnover.GenerateDefaultTurnoverConsign(valEditingTurnoverID)

        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_MONEY_ARRIVE_CONFIRM)) = False Then
            Facade.OpBizTurnover.GenerateDefaultTurnoverPayment(valEditingTurnoverID)
        End If


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServLoadCommissionRate( _
        ByVal valPosID As String, _
        ByRef refPosRowSE As MyPosXAuto.FTs.FT_M_MP_POSRowSEntity, _
        ByRef refPosSetRowSE As MyPosXAuto.FTs.FT_S_MP_POS_SETRowSEntity) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        MyPosXAuto.Facade.AfBizMaster.FillM_MP_POSRowSEntity(refPosRowSE, valPosID)

        If refPosRowSE.IsNull = False Then
            MyPosXAuto.Facade.AfBizConfig.FillS_MP_POS_SETRowSEntity(refPosSetRowSE, refPosRowSE.POS_SET_ID)
        End If

        Return result

    End Function


    Public Function ServUpdateCurrentAmount( _
        ByVal valPosID As String, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        Dim wareTotalConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_POS_WARE_TOTAL(XL.DB.Utils.Condition.LogicOperators.Logic_And)

        Dim wareTotalRow As MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTALRow

        For Each turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In refBindingList

            wareTotalConditions.Clear()
            wareTotalConditions.Add( _
                AfMV.MV_MP_POS_WARE_TOTALColumns.WARE_IDColumn, _
                "=", _
                turnoverDtlRow.WARE_ID)

            wareTotalConditions.Add( _
                AfMV.MV_MP_POS_WARE_TOTALColumns.POS_IDColumn, _
                "=", _
                valPosID)

            wareTotalRow = MyPosXAuto.Facade.AfMV.GetMV_MP_POS_WARE_TOTALRow(wareTotalConditions)

            turnoverDtlRow.CURRENT_AMOUNT = 0
            If IsNothing(wareTotalRow) = False Then
                turnoverDtlRow.CURRENT_AMOUNT = wareTotalRow.CURRENT_AMOUNT
            End If

        Next

        For Each turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In refBindingList

            wareTotalConditions.Clear()
            wareTotalConditions.Add( _
                AfMV.MV_MP_POS_WARE_TOTALColumns.WARE_IDColumn, _
                "=", _
                turnoverDtlRow.WARE_ID)

            wareTotalConditions.Add( _
                AfMV.MV_MP_POS_WARE_TOTALColumns.POS_IDColumn, _
                "=", _
                valPosID)

            wareTotalRow = MyPosXAuto.Facade.AfMV.GetMV_MP_POS_WARE_TOTALRow(wareTotalConditions)

            If IsNothing(wareTotalRow) = False AndAlso _
                turnoverDtlRow.CURRENT_AMOUNT < wareTotalRow.LOWER_LIMIT Then
                Return MyPosXService.Decls.MSG_ALERT_00009
            End If

        Next

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
