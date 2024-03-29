Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade


Public Class S_08_00101
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_08_00101

        Dim result As S_08_00101
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_08_00101), _
                                String.Format("tcp://{0}/S_08_00101.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_08_00101)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_08_00101
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
        ByRef refChoosePosList As MyPosXAuto.FTs.FT_M_MP_POS, _
        ByRef refRecpTypeBarcodeList As MyPosXAuto.FTs.FT_XV_S_MP_RECP_TYPE_BARCODE _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow
        posRow = refChoosePosList.NewM_MP_POSRow
        refChoosePosList.AddM_MP_POSRow(posRow)

        MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, refChoosePosList)


        Dim recipientTypeList As New MyPosXAuto.FTs.FT_CIV_RECIPIENT_TYPE
        MyPosXAuto.Facade.AfCIV.FillCI_RECIPIENT_TYPEList(valLanguagOption, String.Empty, recipientTypeList, False)

        Dim recipientTypeRow As MyPosXAuto.FTs.FT_CIV_RECIPIENT_TYPERow

        Dim ruleConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_RECP_TYPE_BARCODE( _
            XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim ruleID As String

        MyPosXAuto.Facade.AfXV.FillFT_XV_S_MP_RECP_TYPE_BARCODE(Nothing, refRecpTypeBarcodeList)

        For Each recipientTypeRow In recipientTypeList

            ruleConditions.Clear()
            ruleConditions.Add( _
                MyPosXAuto.Facade.AfXV.XV_S_MP_RECP_TYPE_BARCODEColumns.RECIPIENT_TYPEColumn, _
                "=", _
                recipientTypeRow.ITEM_VALUE)


            If refRecpTypeBarcodeList.FindRowsByCondition(ruleConditions).Count <= 0 Then

                ruleID = Guid.NewGuid.ToString
                MyPosXAuto.Facade.AfBizConfig.CreateS_MP_RECP_TYPE_BARCODEInfo( _
                     String.Empty, _
                     recipientTypeRow.ITEM_VALUE, _
                     ruleID)

            End If

        Next

        refRecpTypeBarcodeList.Clear()
        MyPosXAuto.Facade.AfXV.FillFT_XV_S_MP_RECP_TYPE_BARCODE(Nothing, refRecpTypeBarcodeList)


        MyPosXAuto.Facade.AfXV.FillFT_XV_S_MP_RECP_TYPE_BARCODE(Nothing, refRecpTypeBarcodeList)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServSaveInfo( _
        ByVal valCompanyTitle As String, _
        ByVal valServiceTel As String, _
        ByVal valCompanyAddress As String, _
        ByVal valShowCustomWareCode As String, _
        ByVal valWareArriveConfirm As String, _
        ByVal valWareArriveByRecipient As String, _
        ByVal valMoneyArriveConfirm As String, _
        ByVal valHideFinancials As String, _
        ByVal valConsignCodePrefix As String, _
        ByVal valTransferTovrPrefix As String, _
        ByVal valTurnoverPrefix As String, _
        ByVal valAutoClientCodePrefix As String, _
        ByVal valAutoSupplierCodePrefix As String, _
        ByVal valWareTurnoverMode As String, _
        ByVal valWareBatchPrefix As String, _
        ByVal valAllowExtraConsign As String, _
        ByVal valAllowMinusStock As String, _
        ByVal valWareLabelSolution As Integer, _
        ByVal valBatchLabelSolution As Integer, _
        ByRef valPractWareLabelSolution As Integer, _
        ByVal valQuickClientCreatingAllowed As String, _
        ByVal valWareSpecModelDiscard As String, _
        ByVal valShowEnglishItemName As String, _
        ByVal valCustomAttribute1 As String, _
        ByVal valCustomAttribute2 As String, _
        ByVal valCustomAttribute3 As String, _
        ByVal valCustomAttribute4 As String, _
        ByVal valCustomAttribute1Hidden As String, _
        ByVal valCustomAttribute2Hidden As String, _
        ByVal valCustomAttribute3Hidden As String, _
        ByVal valCustomAttribute4Hidden As String, _
        ByVal valClientAttr1 As String, _
        ByVal valClientAttr2 As String, _
        ByVal valClientAttr3 As String, _
        ByVal valClientAttr4 As String, _
        ByVal valClientAttr5 As String, _
        ByVal valClientAttr6 As String, _
        ByRef refRecpTypeBarcodeList As MyPosXAuto.FTs.FT_XV_S_MP_RECP_TYPE_BARCODE, _
        ByRef valPractWareCodePrefix As String, _
        ByVal valPractWareCodeHasYearMonth As Boolean, _
        ByVal valPractWareCodeHasDay As Boolean, _
        ByVal valAutoWareCodeHyphon As Boolean, _
        ByVal valAutoWareCodeSupplierCode As Boolean, _
        ByVal valAutoWareCodeSurfix As Boolean, _
        ByVal valPractWareCodeDigitLength As Integer, _
        ByVal valAutoWareCodeIDLenth As Integer, _
        ByRef valPurchasaeListCopies As Integer, _
        ByVal valCanPointsToRMB As String, _
        ByVal valPointsToRMBRate As String, _
        ByVal valCanRMBToPoints As String, _
        ByVal valRMBToPointsRate As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_COMPANY_TITLE, valCompanyTitle)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_SERVICE_TEL, valServiceTel)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_COMPANY_ADDRESS, valCompanyAddress)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE, valShowCustomWareCode)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_WARE_ARRIVE_CONFIRM, valWareArriveConfirm)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_WARE_ARRIVE_BY_RECIPIENT, valWareArriveByRecipient)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_MONEY_ARRIVE_CONFIRM, valMoneyArriveConfirm)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_HIDE_FINANCIALS, valHideFinancials)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CONSIGN_CODE_PREFIX, valConsignCodePrefix)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_TRANSFER_TOVR_PREFIX, valTransferTovrPrefix)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_TURNOVER_PREFIX, valTurnoverPrefix)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_AUTO_CLIENT_CODE_PREFIX, valAutoClientCodePrefix)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_AUTO_SUPPLIER_CODE_PREFIX, valAutoSupplierCodePrefix)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_WARE_TURNOVER_MODE, valWareTurnoverMode)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_WARE_BATCH_PREFIX, valWareBatchPrefix)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_ALLOW_EXTRA_CONSIGN, valAllowExtraConsign)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_ALLOW_MINUS_STOCK, valAllowMinusStock)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_WARE_LABEL_SOLUTION, CommTK.FString(valWareLabelSolution))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_PURCHASE_LIST_COPIES, CommTK.FString(valPurchasaeListCopies))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_BATCH_LABEL_SOLUTION, CommTK.FString(valBatchLabelSolution))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_PRACT_WARE_LABEL_SOLUTION, CommTK.FString(valBatchLabelSolution))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_QUICK_CLIENT_CREATING_ALLOWED, valQuickClientCreatingAllowed)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_WARE_SPEC_MODEL_DISCARD, valWareSpecModelDiscard)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_SHOW_ENGLISH_ITEM_NAME, valShowEnglishItemName)

        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1, valCustomAttribute1)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2, valCustomAttribute2)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3, valCustomAttribute3)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4, valCustomAttribute4)

        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1_HIDDEN, valCustomAttribute1Hidden)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2_HIDDEN, valCustomAttribute2Hidden)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3_HIDDEN, valCustomAttribute3Hidden)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4_HIDDEN, valCustomAttribute4Hidden)

        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR1, valClientAttr1)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR2, valClientAttr2)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR3, valClientAttr3)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR4, valClientAttr4)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR5, valClientAttr5)
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR6, valClientAttr6)

        MyPosXAuto.Facade.AfBizConfig.SaveBatchS_MP_RECP_TYPE_BARCODEData(refRecpTypeBarcodeList)

        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_PRACT_WARE_CODE_PREFIX, CommTK.FString(valPractWareCodePrefix))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_PRACT_WARE_CODE_HAS_YEAR_MONTH, CommTK.FString(valPractWareCodeHasYearMonth))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_PRACT_WARE_CODE_HAS_DAY, CommTK.FString(valPractWareCodeHasDay))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_PRACT_WARE_CODE_DIGIT_LENGTH, CommTK.FString(valPractWareCodeDigitLength))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_ID_LENTH, CommTK.FString(valAutoWareCodeIDLenth))

        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_HYPHON, CommTK.FString(valAutoWareCodeHyphon))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_SUPPLIER_CODE, CommTK.FString(valAutoWareCodeSupplierCode))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_SURFIX, CommTK.FString(valAutoWareCodeSurfix))

        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CAN_POINTS_TO_RMB, CommTK.FString(valCanPointsToRMB))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_POINTS_TO_RMB_RATE, CommTK.FString(valPointsToRMBRate))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_CAN_RMB_TO_POINTS, CommTK.FString(valCanRMBToPoints))
        SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_RMB_TO_POINTS_RATE, CommTK.FString(valRMBToPointsRate))

        Return result

    End Function


    Public Function ServLoadInfo( _
        ByVal valPosID As String, _
        ByRef refCompanyTitle As String, _
        ByRef refServiceTel As String, _
        ByRef refCompanyAddress As String, _
        ByRef refShowCustomWareCode As Boolean, _
        ByRef refWareArriveConfirm As Boolean, _
        ByRef refWareArriveByRecipient As Boolean, _
        ByRef refMoneyArriveConfirm As Boolean, _
        ByRef refHideFinancials As Boolean, _
        ByRef refConsignCodePrefix As String, _
        ByRef refTransferTovrPrefix As String, _
        ByRef refTurnoverPrefix As String, _
        ByRef refAutoClientCodePrefix As String, _
        ByRef refAutoSupplierCodePrefix As String, _
        ByRef refWareTurnoverMode As Integer, _
        ByRef refWareBatchPrefix As String, _
        ByRef refAllowExtraConsign As Boolean, _
        ByRef refAllowMinusStock As Boolean, _
        ByRef refWareLabelSolution As Integer, _
        ByRef refBatchLabelSolution As Integer, _
        ByRef refPractWareLabelSolution As Integer, _
        ByRef refQuickClientCreatingAllowed As Boolean, _
        ByRef refWareSpecModelDiscard As Boolean, _
        ByRef refShowEnglishItemName As Boolean, _
        ByRef refCustomAttribute1 As String, _
        ByRef refCustomAttribute2 As String, _
        ByRef refCustomAttribute3 As String, _
        ByRef refCustomAttribute4 As String, _
        ByRef refCustomAttribute1Hidden As Boolean, _
        ByRef refCustomAttribute2Hidden As Boolean, _
        ByRef refCustomAttribute3Hidden As Boolean, _
        ByRef refCustomAttribute4Hidden As Boolean, _
        ByRef refClientAttr1 As String, _
        ByRef refClientAttr2 As String, _
        ByRef refClientAttr3 As String, _
        ByRef refClientAttr4 As String, _
        ByRef refClientAttr5 As String, _
        ByRef refClientAttr6 As String, _
        ByRef refPractWareCodePrefix As String, _
        ByRef refPractWareCodeHasYearMonth As Boolean, _
        ByRef refPractWareCodeHasDay As Boolean, _
        ByRef refAutoWareCodeHyphon As Boolean, _
        ByRef refAutoWareCodeSupplierCode As Boolean, _
        ByRef refAutoWareCodeSurfix As Boolean, _
        ByRef refPractWareCodeDigitLength As Integer, _
        ByRef refAutoWareCodeIDLenth As Integer, _
        ByRef refPurchasaeListCopies As Integer, _
        ByRef refCanPointsToRMB As Boolean, _
        ByRef refPointsToRMBRate As Integer, _
        ByRef refCanRMBToPoints As Boolean, _
        ByRef refRMBToPointsRate As Integer _
         ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty


        refCompanyTitle = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_COMPANY_TITLE)
        refServiceTel = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SERVICE_TEL)
        refCompanyAddress = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_COMPANY_ADDRESS)
        refShowCustomWareCode = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE))
        refWareArriveConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_ARRIVE_CONFIRM))
        refWareArriveByRecipient = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_ARRIVE_BY_RECIPIENT))
        refMoneyArriveConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_MONEY_ARRIVE_CONFIRM))
        refHideFinancials = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_HIDE_FINANCIALS))
        refConsignCodePrefix = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CONSIGN_CODE_PREFIX)
        refTransferTovrPrefix = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_TRANSFER_TOVR_PREFIX)
        refTurnoverPrefix = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_TURNOVER_PREFIX)
        refAutoClientCodePrefix = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_CLIENT_CODE_PREFIX)
        refAutoSupplierCodePrefix = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_SUPPLIER_CODE_PREFIX)
        refWareTurnoverMode = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_TURNOVER_MODE))
        refWareBatchPrefix = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_BATCH_PREFIX)
        refAllowExtraConsign = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_ALLOW_EXTRA_CONSIGN))
        refAllowMinusStock = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_ALLOW_MINUS_STOCK))
        refQuickClientCreatingAllowed = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_QUICK_CLIENT_CREATING_ALLOWED))
        refWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_SPEC_MODEL_DISCARD))
        refShowEnglishItemName = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_ENGLISH_ITEM_NAME))

        refWareLabelSolution = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_LABEL_SOLUTION))
        refBatchLabelSolution = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_BATCH_LABEL_SOLUTION))
        refPractWareLabelSolution = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_PRACT_WARE_LABEL_SOLUTION))

        refCustomAttribute1 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1)
        refCustomAttribute2 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2)
        refCustomAttribute3 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3)
        refCustomAttribute4 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4)
        refCustomAttribute1Hidden = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1_HIDDEN))
        refCustomAttribute2Hidden = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2_HIDDEN))
        refCustomAttribute3Hidden = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3_HIDDEN))
        refCustomAttribute4Hidden = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4_HIDDEN))

        refClientAttr1 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR1)
        refClientAttr2 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR2)
        refClientAttr3 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR3)
        refClientAttr4 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR4)
        refClientAttr5 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR5)
        refClientAttr6 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR6)

        refPractWareCodePrefix = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_PRACT_WARE_CODE_PREFIX)
        refPractWareCodeHasYearMonth = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_PRACT_WARE_CODE_HAS_YEAR_MONTH))
        refPractWareCodeHasDay = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_PRACT_WARE_CODE_HAS_DAY))
        refAutoWareCodeHyphon = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_HYPHON))
        refAutoWareCodeSupplierCode = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_SUPPLIER_CODE))
        refAutoWareCodeSurfix = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_SURFIX))
        refPractWareCodeDigitLength = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_PRACT_WARE_CODE_DIGIT_LENGTH))
        refAutoWareCodeIDLenth = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_ID_LENTH))
        refPurchasaeListCopies = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_PURCHASE_LIST_COPIES))

        refCanPointsToRMB = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CAN_POINTS_TO_RMB))
        refPointsToRMBRate = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_POINTS_TO_RMB_RATE))
        refCanRMBToPoints = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CAN_RMB_TO_POINTS))
        refRMBToPointsRate = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_RMB_TO_POINTS_RATE))

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


    Public Function ServSaveMobileWareList( _
        ByVal valPosID As String, _
        ByRef refWareList As MyPosXAuto.FTs.FT_M_MP_WARE _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow
        MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_WARE(Nothing, refWareList)

        For Each wareRow In refWareList
            wareRow.ROW_REMARK = Facade.OpBizMaster.GetWareInfoString(wareRow.WARE_ID, valPosID, False)
        Next

        Return String.Empty

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


    Public Function ServAutomateWareCodes( _
        ByVal valKeepOrigionWareCodeToRemark As Boolean _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim wareList As New MyPosXAuto.FTs.FT_M_MP_WARE
        Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow
        MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_WARE(Nothing, wareList)

        Dim counter As Integer = 0
        For Each wareRow In wareList

            If (Facade.OpBizMaster.IsAutoWareCode(wareRow.WARE_CLASSIFY_ID, wareRow.WARE_CODE) = False AndAlso _
                wareRow.CUSTOM_CODE = wareRow.WARE_CODE) OrElse wareRow.CUSTOM_CODE = String.Empty Then

                If valKeepOrigionWareCodeToRemark = True OrElse wareRow.CUSTOM_CODE = String.Empty Then

                    MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_WARERow( _
                        wareRow.WARE_ID, _
                        MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.CUSTOM_CODEColumn, _
                        wareRow.WARE_CODE)

                End If

                Dim supplierRowSE As New MyPosXAuto.FTs.FT_M_MP_SUPPLIERRowSEntity
                MyPosXAuto.Facade.AfBizMaster.FillM_MP_SUPPLIERRowSEntity(supplierRowSE, wareRow.SUPPLIER_ID)

                MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_WARERow( _
                    wareRow.WARE_ID, _
                    MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, _
                    Facade.OpBizMaster.GetAutoWareCode( _
                        False, _
                        wareRow.WARE_CLASSIFY_ID, _
                        supplierRowSE.SUPPLIER_CODE, _
                        String.Empty))

            End If
            counter += 1

        Next

        Return String.Empty

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
