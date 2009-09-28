Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade
Imports System.Collections
Imports System.Data
Imports System.Collections.Generic

Namespace Facade

    Public Class OpBizTurnover

        Public Shared Sub SycronizeMoveTurnoverDtls(ByVal fromTurnoverID As String, ByVal reliefPareID As String)

            Dim turnoverCondition As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            turnoverCondition.Add(AfBizTurnover.H_MP_TURNOVERColumns.TURNOVER_IDColumn, "<>", fromTurnoverID)
            turnoverCondition.Add(AfBizTurnover.H_MP_TURNOVERColumns.RELIEF_PAIR_IDColumn, "=", reliefPareID)

            Dim turnoverRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow = _
                 MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVERRow(turnoverCondition)
            Dim toTurnoverID As String = turnoverRow.TURNOVER_ID

            Dim fromTurnoverDtlList As New MyPosXAuto.FTs.FT_H_MP_TURNOVER_DTL
            Dim toTurnoverDtlList As New MyPosXAuto.FTs.FT_H_MP_TURNOVER_DTL

            Dim turnoverDtlCondition As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            turnoverDtlCondition.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, "=", fromTurnoverID)

            MyPosXAuto.Facade.AfBizTurnover.FillFT_H_MP_TURNOVER_DTL(turnoverDtlCondition, fromTurnoverDtlList)

            turnoverDtlCondition.Clear()
            turnoverDtlCondition.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, "=", toTurnoverID)

            MyPosXAuto.Facade.AfBizTurnover.FillFT_H_MP_TURNOVER_DTL(turnoverDtlCondition, toTurnoverDtlList)

            Dim fromTurnoverDtlRow As MyPosXAuto.FTs.FT_H_MP_TURNOVER_DTLRow
            Dim toTurnoverDtlRow As MyPosXAuto.FTs.FT_H_MP_TURNOVER_DTLRow
            Dim involvedToTurnoverDtlIDs As New ArrayList

            For Each fromTurnoverDtlRow In fromTurnoverDtlList

                turnoverDtlCondition.Clear()
                turnoverDtlCondition.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.WARE_IDColumn, "=", fromTurnoverDtlRow.WARE_ID)
                turnoverDtlCondition.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.TURNOVER_BOOK_STATUSColumn, "=", fromTurnoverDtlRow.TURNOVER_BOOK_STATUS)

                toTurnoverDtlRow = toTurnoverDtlList.FindRowByCondition(turnoverDtlCondition)

                If IsNothing(toTurnoverDtlRow) = True Then
                    toTurnoverDtlRow = toTurnoverDtlList.NewH_MP_TURNOVER_DTLRow()
                    toTurnoverDtlList.AddH_MP_TURNOVER_DTLRow(toTurnoverDtlRow)
                    toTurnoverDtlRow.QuotateH_MP_TURNOVER_DTLRow(fromTurnoverDtlRow)
                    toTurnoverDtlRow.TURNOVER_ID = toTurnoverID
                End If

                toTurnoverDtlRow.WARE_AMOUNT = fromTurnoverDtlRow.WARE_AMOUNT

                involvedToTurnoverDtlIDs.Add(toTurnoverDtlRow.DETAIL_ID)
            Next

            turnoverDtlCondition.Clear()
            turnoverDtlCondition.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.DETAIL_IDColumn, False, involvedToTurnoverDtlIDs)
            toTurnoverDtlList.RemoveFT_H_MP_TURNOVER_DTLRows(turnoverDtlCondition)

            MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_DTLData(toTurnoverDtlList)

            Facade.OpBizTurnover.GenerateDefaultTurnoverConsign(fromTurnoverID)
            Facade.OpBizTurnover.GenerateDefaultTurnoverConsign(toTurnoverID)

        End Sub

        Public Shared Sub GenerateDefaultTurnoverPayment(ByVal turnoverID As String)

            Dim turnoverRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow = _
                MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVERRow(turnoverID)
            If IsNothing(turnoverRow) = True Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(MyPosXService.Decls.MSG_ALERT_00022)
                Throw ex
            End If

            Dim paymentSituationCondition As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_TURNOVER_PAYMENT_SITUATION(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            paymentSituationCondition.Add(AfMV.MV_MP_TURNOVER_PAYMENT_SITUATIONColumns.TURNOVER_IDColumn, "=", turnoverID)

            Dim paymentSituationRow As MyPosXAuto.FTs.FT_MV_MP_TURNOVER_PAYMENT_SITUATIONRow = _
                MyPosXAuto.Facade.AfMV.GetMV_MP_TURNOVER_PAYMENT_SITUATIONRow(paymentSituationCondition)

            Dim logID As String

            logID = Guid.NewGuid.ToString
            MyPosXAuto.Facade.AfBizTurnover.CreateH_MP_TURNOVER_PAY_LOGInfo( _
                CommTK.FDecimal(paymentSituationRow.SUM_PRICE - paymentSituationRow.PAY_AMOUNT), _
                1, _
                MyPosXService.Decls.DEFAULT_CI_CURRENCY_TYPE_VALUE_RMB, _
                turnoverRow.STAFF_ID, _
                logID, _
                paymentSituationRow.SUM_PRICE - paymentSituationRow.PAY_AMOUNT, _
                turnoverRow.TURNOVER_TIME, _
                "Default Payment", MyPosXAuto.Decls.CIVALUE_PAY_TYPE_CASH, _
                turnoverID)

            Facade.OpMP.ExecuteMP_MP_EXECUTE_FINISH_TURNOVER_PAYMENT_BALANCE()

        End Sub

        Public Shared Sub GenerateDefaultTurnoverConsign(ByVal turnoverID As String)

            Dim turnoverRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow = _
                MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVERRow(turnoverID)
            If IsNothing(turnoverRow) = True Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(MyPosXService.Decls.MSG_ALERT_00022)
                Throw ex
            End If

            Dim turnoverDtlList As New MyPosXAuto.FTs.FT_H_MP_TURNOVER_DTL
            Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            turnoverDtlConditions.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, "=", turnoverID)
            turnoverDtlConditions.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.TURNOVER_BOOK_STATUSColumn, "=", MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND)

            MyPosXAuto.Facade.AfBizTurnover.FillFT_H_MP_TURNOVER_DTL(turnoverDtlConditions, turnoverDtlList)

            If turnoverDtlList.Count = 0 Then
                Return
            End If

            Dim consignConditions As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER_CONSIGN(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            consignConditions.Add(AfBizTurnover.H_MP_TURNOVER_CONSIGNColumns.TURNOVER_IDColumn, "=", turnoverID)
            consignConditions.Add(AfBizTurnover.H_MP_TURNOVER_CONSIGNColumns.IS_DEFAULTColumn, "=", True)

            Dim consignRow As MyPosXAuto.FTs.FT_H_MP_TURNOVER_CONSIGNRow = _
                MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVER_CONSIGNRow(consignConditions)

            Dim consignDtlList As New MyPosXAuto.FTs.FT_H_MP_TURNOVER_CONSIGN_DTL
            Dim consignDtlRow As MyPosXAuto.FTs.FT_H_MP_TURNOVER_CONSIGN_DTLRow

            Dim consignID As String
            Dim consignDtlConditions As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER_CONSIGN_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)

            If IsNothing(consignRow) = True Then

                consignID = Guid.NewGuid.ToString
                MyPosXAuto.Facade.AfBizTurnover.CreateH_MP_TURNOVER_CONSIGNInfo( _
                    Facade.OpBizTurnover.GetAutoConsignCode(False, turnoverRow.TURNOVER_ID), _
                    turnoverRow.TURNOVER_TIME, _
                    consignID, _
                    turnoverRow.STAFF_ID, _
                    True, _
                    True, _
                    turnoverRow.TURNOVER_ID)

            Else

                consignID = consignRow.CONSIGN_ID
                consignDtlConditions.Add( _
                    AfBizTurnover.H_MP_TURNOVER_CONSIGN_DTLColumns.CONSIGN_IDColumn, _
                    "=", _
                    consignID)

                MyPosXAuto.Facade.AfBizTurnover.FillFT_H_MP_TURNOVER_CONSIGN_DTL(consignDtlConditions, consignDtlList)

            End If

            For Each consignDtlRow In consignDtlList
                consignDtlRow.WARE_AMOUNT = 0
            Next



            For Each turnoverDtlRow As MyPosXAuto.FTs.FT_H_MP_TURNOVER_DTLRow In turnoverDtlList

                consignDtlConditions.Clear()
                consignDtlConditions.Add(AfBizTurnover.H_MP_TURNOVER_CONSIGN_DTLColumns.WARE_IDColumn, "=", turnoverDtlRow.WARE_ID)

                consignDtlRow = consignDtlList.FindRowByCondition(consignDtlConditions)

                If IsNothing(consignDtlRow) = True Then

                    consignDtlRow = consignDtlList.NewH_MP_TURNOVER_CONSIGN_DTLRow
                    consignDtlList.AddH_MP_TURNOVER_CONSIGN_DTLRow(consignDtlRow)
                    consignDtlRow.DETAIL_ID = Guid.NewGuid.ToString
                    consignDtlRow.WARE_ID = turnoverDtlRow.WARE_ID
                    consignDtlRow.CONSIGN_ID = consignID
                End If

                consignDtlRow.WARE_AMOUNT += turnoverDtlRow.WARE_AMOUNT
                consignDtlRow.ROW_SELECTED = True
            Next

            For Each consignDtlRow In consignDtlList.FindRowsSelecting(False)
                consignDtlRow.Delete()
            Next


            MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_CONSIGN_DTLData(consignDtlList)

            OpMP.ExecuteMP_MP_EXECUTE_FINISH_TURNOVER_CONSIGN_BALANCE()
        End Sub

        Public Shared Function GetPosBatchWareStockAmount(ByVal posID As String, ByVal batchCode As String) As Double

            Dim posBatchWareTotalCondition As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_POS_BATCH_WARE_TOTAL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            posBatchWareTotalCondition.Add(AfMV.MV_MP_POS_BATCH_WARE_TOTALColumns.BATCH_CODEColumn, "=", batchCode)
            posBatchWareTotalCondition.Add(AfMV.MV_MP_POS_BATCH_WARE_TOTALColumns.POS_IDColumn, "=", posID)

            Dim posBatchWareTotalRow As MyPosXAuto.FTs.FT_MV_MP_POS_BATCH_WARE_TOTALRow = _
                MyPosXAuto.Facade.AfMV.GetMV_MP_POS_BATCH_WARE_TOTALRow(posBatchWareTotalCondition)

            If IsNothing(posBatchWareTotalRow) = True Then
                Return 0
            End If

            Return posBatchWareTotalRow.CURRENT_AMOUNT

        End Function

        Public Shared Function GetPosWareStockAmount(ByVal posID As String, ByVal wareID As String) As Double


            Dim posWareTotalConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_POS_WARE_TOTAL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            posWareTotalConditions.Add(AfMV.MV_MP_POS_WARE_TOTALColumns.WARE_IDColumn, "=", wareID)
            posWareTotalConditions.Add(AfMV.MV_MP_POS_WARE_TOTALColumns.POS_IDColumn, "=", posID)

            Dim wareTotalRow As MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTALRow = _
                MyPosXAuto.Facade.AfMV.GetMV_MP_POS_WARE_TOTALRow(posWareTotalConditions)

            If IsNothing(wareTotalRow) = True Then
                Return 0
            End If

            Return wareTotalRow.CURRENT_AMOUNT

        End Function

        Public Shared Sub SycronizePractTurnoverDtl(ByVal turnoverID As String)

            '''XV_H_MP_TURNOVER_DTL_PRACT_WARE条件TURNOVER_IDColumn改为H_MP_TURNOVER_TURNOVER_IDColumn
            Dim practDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARE

            Dim practDtlCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL_PRACT_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            practDtlCondition.Add(AfXV.XV_H_MP_TURNOVER_DTL_PRACT_WAREColumns.H_MP_TURNOVER_TURNOVER_IDColumn, "=", turnoverID)

            MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_DTL_PRACT_WARE(practDtlCondition, practDtlList)

            Dim turnoverRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow = _
                MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVERRow(turnoverID)

            Dim turnoverDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL
            Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)

            turnoverDtlConditions.Add(AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, "=", turnoverID)
            turnoverDtlConditions.Add(AfXV.XV_H_MP_TURNOVER_DTLColumns.PRACT_CODE_REQUIREDColumn, "=", True)

            MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_DTL(turnoverDtlConditions, turnoverDtlList)

            Dim turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow = Nothing

            For Each turnoverDtlRow In turnoverDtlList
                turnoverDtlRow.WARE_AMOUNT = 0
            Next
            Dim practDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARERow = Nothing

            Dim origionPrice As Decimal
            Dim involvedTurnoverDtlIDs As New ArrayList
            For Each practDtlRow In practDtlList

                turnoverDtlConditions.Clear()
                turnoverDtlConditions.Add(AfXV.XV_H_MP_TURNOVER_DTLColumns.WARE_IDColumn, "=", practDtlRow.WARE_ID)

                turnoverDtlRow = turnoverDtlList.FindRowByCondition(turnoverDtlConditions)

                If IsNothing(turnoverDtlRow) = True Then

                    turnoverDtlRow = turnoverDtlList.NewXV_H_MP_TURNOVER_DTLRow
                    turnoverDtlList.AddXV_H_MP_TURNOVER_DTLRow(turnoverDtlRow)
                    turnoverDtlRow.WARE_ID = practDtlRow.WARE_ID
                    turnoverDtlRow.TURNOVER_ID = turnoverID
                    turnoverDtlRow.UNIT_PRICE = Facade.OpBizMaster.GetPosWarePrice(practDtlRow.WARE_ID, turnoverRow.POS_ID, origionPrice)
                    turnoverDtlRow.UNIT_COST = Facade.OpBizMaster.GetPosWareCost(practDtlRow.WARE_ID, turnoverRow.POS_ID)
                End If

                turnoverDtlRow.WARE_AMOUNT += 1
                turnoverDtlRow.SUM_COST = CommTK.FDecimal(turnoverDtlRow.UNIT_COST * turnoverDtlRow.WARE_AMOUNT)
                turnoverDtlRow.SUM_PRICE = CommTK.FDecimal(turnoverDtlRow.UNIT_PRICE * turnoverDtlRow.WARE_AMOUNT)
                turnoverDtlRow.TURNOVER_BOOK_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND
            Next

            MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_DTLData(turnoverDtlList)

            turnoverDtlConditions.Clear()
            turnoverDtlConditions.Add(AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, "=", turnoverID)


            turnoverDtlList.Clear()
            MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_DTL(turnoverDtlConditions, turnoverDtlList)

            For Each turnoverDtlRow In turnoverDtlList

                If turnoverDtlRow.PRACT_CODE_REQUIRED = False Then
                    involvedTurnoverDtlIDs.Add(turnoverDtlRow.DETAIL_ID)
                    Continue For
                End If

                practDtlCondition.Clear()
                practDtlCondition.Add(AfXV.XV_H_MP_TURNOVER_DTL_PRACT_WAREColumns.WARE_IDColumn, "=", turnoverDtlRow.WARE_ID)

                practDtlRow = practDtlList.FindRowByCondition(practDtlCondition)

                If IsNothing(practDtlRow) = False AndAlso involvedTurnoverDtlIDs.Contains(turnoverDtlRow.DETAIL_ID) = False Then
                    involvedTurnoverDtlIDs.Add(turnoverDtlRow.DETAIL_ID)
                End If

            Next

            Dim turnoverDtlCondition As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            turnoverDtlCondition.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.DETAIL_IDColumn, False, involvedTurnoverDtlIDs)
            turnoverDtlCondition.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, "=", turnoverID)

            MyPosXAuto.Facade.AfBizTurnover.DeleteH_MP_TURNOVER_DTLData(turnoverDtlCondition)

        End Sub

        Public Shared Function ValidateTurnoverCode(ByVal turnoverCode As String) As Boolean

            Dim turnoverConditions As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            turnoverConditions.Add(AfBizTurnover.H_MP_TURNOVERColumns.TURNOVER_CODEColumn, "=", turnoverCode)

            Dim turnoverRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow = _
                MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVERRow(turnoverConditions)

            Dim result As Boolean

            If IsNothing(turnoverRow) = True Then
                result = False
            Else
                result = True
            End If


            Return result

        End Function

#Region "Auto code"

        Public Shared Function GetAutoLocalTurnoverCode(ByVal preview As Boolean, ByVal turnoverType As Integer, ByVal posID As String) As String

            Dim codeBuilder As New LineStrBuilder

            Dim codeType As String

            codeType = SysInfo.ReadLocalSysInfo(MyPosXService.Decls.SVN_TURNOVER_PREFIX)
            If turnoverType = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN Then
                codeType &= "I"
            Else
                codeType &= "O"
            End If


            Dim seedName As String = String.Format("TURNOVER_{0}", codeType)

            'Dim turnoverDate As String = String.Format("{0:yyyyMMdd}", CommTK.GetsyncServerTime)

            Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(posID)

            If IsNothing(posRow) = True Then
                Return CommTK.GetTranslatedString(MyPosXService.Decls.MSG_ALERT_00003)
            End If

            Dim result As String = String.Empty

            Dim labelPrintSet As String = SysInfo.ReadShareSysInfo(CommDecl.XLSSVN_LABEL_PRINT_SET).ToUpper

            Select Case labelPrintSet
                Case "POWER LEGEND"

                    If preview = True Then

                        result = String.Format("{0}XXXXXX", _
                            codeType)

                    Else

                        Dim locationSeedValue As Integer = _
                            Facade.OpSysConfig.GetNewSeedID(seedName)

                        result = String.Format("{0}{1:000000}", _
                            codeType, _
                            locationSeedValue)

                    End If

                Case Else

                    If preview = True Then

                        result = String.Format("{0}{1}-XXXXXXXXXXXXXX", _
                            codeType, _
                            posRow.POS_CODE)

                    Else

                        result = String.Format("{0}{1}{2:yyyyMMddHHmmss}", _
                            codeType, _
                            posRow.POS_CODE, _
                            CommTK.GetSyncServerTime)

                    End If

            End Select
            Return result



        End Function


        Public Shared Function GetAutoTurnoverCode(ByVal preview As Boolean, ByVal turnoverType As Integer, ByVal posID As String) As String

            Dim codeBuilder As New LineStrBuilder

            Dim codeType As String

            codeType = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_TURNOVER_PREFIX)
            If turnoverType = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN Then
                codeType &= "I"
            Else
                codeType &= "O"
            End If


            Dim seedName As String = String.Format("TURNOVER_{0}", codeType)

            'Dim turnoverDate As String = String.Format("{0:yyyyMMdd}", CommTK.GetsyncServerTime)



            Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(posID)

            If IsNothing(posRow) = True Then
                Return CommTK.GetTranslatedString(MyPosXService.Decls.MSG_ALERT_00003)
            End If

            Dim result As String = String.Empty

            Dim labelPrintSet As String = SysInfo.ReadShareSysInfo(CommDecl.XLSSVN_LABEL_PRINT_SET).ToUpper

            Select Case labelPrintSet
                Case "POWER LEGEND"

                    If preview = True Then

                        result = String.Format("{0}XXXXXX", _
                            codeType)

                    Else

                        Dim locationSeedValue As Integer = _
                            Facade.OpSysConfig.GetNewSeedID(seedName)

                        result = String.Format("{0}{1:000000}", _
                            codeType, _
                            locationSeedValue)

                    End If

                Case Else

                    If preview = True Then

                        result = String.Format("{0}{1}-XXXXXX", _
                            codeType, _
                            posRow.POS_CODE)

                    Else

                        Dim locationSeedValue As Integer = _
                            Facade.OpSysConfig.GetNewSeedID(seedName)

                        result = String.Format("{0}{1}{2:000000}", _
                            codeType, _
                            posRow.POS_CODE, _
                            locationSeedValue)

                    End If

            End Select
            Return result



        End Function

        Public Shared Function GetAutoTransferCode(ByVal preview As Boolean, ByVal posID As String, ByVal turnoverType As Integer) As String

            Dim codeBuilder As New LineStrBuilder

            Dim codeType As String

            codeType = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_TRANSFER_TOVR_PREFIX)
            If turnoverType = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN Then
                codeType &= "I"
            Else
                codeType &= "O"
            End If


            Dim seedName As String = String.Format("{0}", turnoverType)

            Dim turnoverDate As String = String.Format("{0:yyyyMMdd}", CommTK.GetSyncServerTime)

            Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(posID)

            If IsNothing(posRow) = True Then
                Return MyPosXService.Decls.MSG_ALERT_00003
            End If

            Dim result As String
            If preview = True Then

                result = String.Format("{0}{1}{2:yyMM}-XXXXX", _
                    codeType, _
                    posRow.POS_CODE, _
                    turnoverDate)

            Else

                Dim locationSeedValue As Integer = _
                    Facade.OpSysConfig.GetNewSeedID(seedName)

                result = String.Format("{0}{1}{2:yyMM}-{3:00000}", _
                    codeType, _
                    posRow.POS_CODE, _
                    turnoverDate, _
                    locationSeedValue)

            End If

            Return result

        End Function

        Public Shared Function GetTurnoverBatchIndex() As Integer

            Dim seedName As String = String.Empty

            Select Case Decls.TURNOVER_BATCH_INDEX_TYPE
                Case MyPosXService.Decls.TurnoverBatchIndexType.YYYYMM
                    seedName = CommTK.GetSyncServerTime().ToString("yyyyMM")
                Case MyPosXService.Decls.TurnoverBatchIndexType.YYYYMMDD
                    seedName = CommTK.GetSyncServerTime().ToString("yyyyMMdd")
            End Select
            Return Facade.OpSysConfig.GetNewSeedID(String.Format("TURNOVER_BATCH_INDEX_{0}", seedName))

        End Function

        Public Shared Sub SetAutoWareBatchCode( _
            ByVal turnoverCode As String, _
            ByVal turnoverDtlList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL, _
            ByVal turnoverBatchIndex As Integer)

            Dim headBuilder As New LineStrBuilder
            headBuilder.AppendFormat(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_BATCH_PREFIX))
            headBuilder.AppendFormat("{0:yyMMdd}", CommTK.GetSyncServerTime)

            Dim emptyRows As New ArrayList
            Dim currentCodes As New ArrayList
            For Each row As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In turnoverDtlList
                If row.RowState <> DataRowState.Deleted Then

                    If row.BATCH_CODE.Length > 0 Then
                        currentCodes.Add(row.BATCH_CODE)
                    Else
                        emptyRows.Add(row)
                    End If
                End If
            Next

            Dim availableCode As String
            Dim availableCodes As New Queue
            For counter As Integer = 1 To turnoverDtlList.Count

                availableCode = String.Format("{0}-{1:00}{2:000}", headBuilder, turnoverBatchIndex, counter)
                If currentCodes.Contains(availableCode) = False Then
                    availableCodes.Enqueue(availableCode)
                End If

            Next

            For Each emptyRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In emptyRows
                emptyRow.BATCH_CODE = CommTK.FString(availableCodes.Dequeue())
            Next

        End Sub


        Public Shared Function GetAutoConsignCode(ByVal preview As Boolean, ByVal turnoverID As String) As String

            Dim turnoverRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow = _
                MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVERRow(turnoverID)

            If IsNothing(turnoverRow) = True Then
                Return String.Empty
            End If

            Dim resultBuilder As New LineStrBuilder
            resultBuilder.AppendFormat(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CONSIGN_CODE_PREFIX))
            resultBuilder.AppendFormat(turnoverRow.TURNOVER_CODE)

            If preview = True Then
                resultBuilder.AppendFormat("XX")
                Return resultBuilder.ToString
            End If

            Dim seedName As String = String.Format("{0}_{1}", MyPosXService.Decls.SPX_CONSIGN_CODE, turnoverID)
            Dim seedValue As Integer = Facade.OpSysConfig.GetNewSeedID(seedName)

            resultBuilder.AppendFormat("{0:00}", seedValue)
            Return resultBuilder.ToString

        End Function

        Public Shared Function GetAutoPractWareCode(ByVal preview As Boolean, ByVal wareID As String) As String

            Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareID)

            If IsNothing(wareRow) = True Then
                Return String.Empty
            End If

            Dim codeBuilder As New LineStrBuilder
            codeBuilder.AppendFormat("{0}-{1}-", SysInfo.ReadShareSysInfo(Decls.SVN_PRACT_WARE_CODE_PREFIX), wareRow.WARE_CODE)
            Dim seedNameBuilder As New LineStrBuilder
            seedNameBuilder.AppendFormat("{0}-", Decls.SPX_PRACT_WARE_CODE)
            seedNameBuilder.AppendFormat("{0}-", wareRow.WARE_CODE)
            Dim serverTime As DateTime = OpSysConfig.GetServerTime

            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_PRACT_WARE_CODE_HAS_YEAR_MONTH)) = True Then
                codeBuilder.AppendFormat("{0:yyMM}", serverTime)
                seedNameBuilder.AppendFormat("{0:yyMM}", serverTime)
            End If

            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_PRACT_WARE_CODE_HAS_DAY)) = True Then
                codeBuilder.AppendFormat("{0:dd}", serverTime)
                seedNameBuilder.AppendFormat("{0:dd}", serverTime)
            End If


            Dim digitLength As Integer = CommTK.FInteger(SysInfo.ReadShareSysInfo(Decls.SVN_PRACT_WARE_CODE_DIGIT_LENGTH))

            If preview = True Then
                codeBuilder.AppendFormat(StrDup(digitLength, "X"))
                Return codeBuilder.ToString
            Else
                Dim digitFormat As String = String.Format("{{0:{0}}}", StrDup(digitLength, "0"))
                codeBuilder.AppendFormat(digitFormat, OpSysConfig.GetNewSeedID(seedNameBuilder.ToString))
            End If

            Return codeBuilder.ToString

        End Function
#End Region

        Public Shared Sub ImportTurnoverCacheData( _
            ByVal turnoverCacheDataList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER, _
            ByVal turnoverDtlCacheDataList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL)


            Dim turnoverDetailIDs As New Dictionary(Of String, ArrayList)
            Dim detailIDs As ArrayList


            Dim turnoverDtlCacheDataRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow
            Dim turnoverDtlDBDataRow As MyPosXAuto.FTs.FT_H_MP_TURNOVER_DTLRow

            Dim turnoverDtlCondition As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            For Each turnoverDtlCacheDataRow In turnoverDtlCacheDataList.FindRowsByCondition(Nothing)

                If turnoverDtlCacheDataRow.WARE_AMOUNT = 0 Then
                    Continue For
                End If

                If turnoverDtlCacheDataRow.DETAIL_ID.Length = 0 Then
                    turnoverDtlCacheDataRow.DETAIL_ID = Guid.NewGuid.ToString()
                End If

                turnoverDtlCondition.Clear()
                turnoverDtlCondition.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.DETAIL_IDColumn, "=", turnoverDtlCacheDataRow.DETAIL_ID)
                turnoverDtlDBDataRow = MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVER_DTLRow(turnoverDtlCondition)
                If IsNothing(turnoverDtlDBDataRow) = True Then
                    MyPosXAuto.Facade.AfBizTurnover.CreateH_MP_TURNOVER_DTLInfoByRow(turnoverDtlCacheDataRow)
                Else
                    MyPosXAuto.Facade.AfBizTurnover.ReviseH_MP_TURNOVER_DTLInfoByRow(turnoverDtlCacheDataRow)
                End If

                If turnoverDetailIDs.ContainsKey(turnoverDtlCacheDataRow.TURNOVER_ID) = False Then
                    detailIDs = New ArrayList
                    turnoverDetailIDs.Add(turnoverDtlCacheDataRow.TURNOVER_ID, detailIDs)
                Else
                    detailIDs = turnoverDetailIDs.Item(turnoverDtlCacheDataRow.TURNOVER_ID)
                End If
                detailIDs.Add(turnoverDtlCacheDataRow.DETAIL_ID)
            Next

            Dim turnoverDBDataRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow
            Dim turnoverCacheDataRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVERRow

            Dim turnoverCondition As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            For Each turnoverCacheDataRow In turnoverCacheDataList

                If turnoverCacheDataRow.TURNOVER_ID.Length = 0 Then
                    Continue For
                End If

                turnoverCondition.Clear()
                turnoverCondition.Add(AfBizTurnover.H_MP_TURNOVERColumns.TURNOVER_IDColumn, "=", turnoverCacheDataRow.TURNOVER_ID)
                turnoverDBDataRow = MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVERRow(turnoverCondition)
                If IsNothing(turnoverDBDataRow) = True Then
                    MyPosXAuto.Facade.AfBizTurnover.CreateH_MP_TURNOVERInfoByRow(turnoverCacheDataRow)
                Else
                    MyPosXAuto.Facade.AfBizTurnover.ReviseH_MP_TURNOVERInfoByRow(turnoverCacheDataRow)
                End If

                If turnoverDetailIDs.ContainsKey(turnoverCacheDataRow.TURNOVER_ID) = True Then
                    detailIDs = turnoverDetailIDs.Item(turnoverCacheDataRow.TURNOVER_ID)
                    turnoverDtlCondition.Clear()
                    turnoverDtlCondition.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.DETAIL_IDColumn, False, detailIDs)
                    turnoverDtlCondition.Add(AfBizTurnover.H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, "=", turnoverCacheDataRow.TURNOVER_ID)

                    MyPosXAuto.Facade.AfBizTurnover.DeleteH_MP_TURNOVER_DTLData(turnoverDtlCondition)
                Else
                    MyPosXAuto.Facade.AfBizTurnover.DeleteH_MP_TURNOVERInfo(turnoverCacheDataRow.TURNOVER_ID)
                End If

                OpBizTurnover.GenerateDefaultTurnoverConsign(turnoverCacheDataRow.TURNOVER_ID)
                OpBizTurnover.GenerateDefaultTurnoverPayment(turnoverCacheDataRow.TURNOVER_ID)

            Next
        End Sub

        Public Shared Sub UpdateTurnoverPointsIO()

            Facade.OpMP.ExecuteMP_MP_EXECUTE_DELETE_POINT_GAIN_USE_IO_WITH_NO_TURNOVER()

            Dim gainingPointsList As New MyPosXAuto.FTs.FT_MV_MP_TURNOVER_SHOULD_GAIN_POINT
            Dim usingPointsList As New MyPosXAuto.FTs.FT_MV_MP_TURNOVER_SHOULD_USE_POINT
            Dim gainingPointsRow As MyPosXAuto.FTs.FT_MV_MP_TURNOVER_SHOULD_GAIN_POINTRow
            Dim usingPointsRow As MyPosXAuto.FTs.FT_MV_MP_TURNOVER_SHOULD_USE_POINTRow
            Dim dbPointIOList As New MyPosXAuto.FTs.FT_H_MP_CLIENT_POINT_IO

            Dim shouldGainPointCondition As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_TURNOVER_SHOULD_GAIN_POINT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            shouldGainPointCondition.Add(AfMV.MV_MP_TURNOVER_SHOULD_GAIN_POINTColumns.TURNOVER_TYPEColumn, "=", MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN)
            MyPosXAuto.Facade.AfMV.FillFT_MV_MP_TURNOVER_SHOULD_GAIN_POINT(shouldGainPointCondition, gainingPointsList)

            For Each gainingPointsRow In gainingPointsList
                dbPointIOList.AddNewH_MP_CLIENT_POINT_IORow( _
                    gainingPointsRow.CLIENT_ID, _
                    Guid.NewGuid.ToString, _
                    gainingPointsRow.TURNOVER_TIME, _
                    CommTK.FDecimal(gainingPointsRow.RMB_TO_POINT_RATE * gainingPointsRow.POINT_GAIN), _
                    gainingPointsRow.POINT_GAIN, _
                    MyPosXAuto.Decls.CIVALUE_POINT_IO_TYPE_IN_ACCUMULATE, _
                    String.Empty, _
                    gainingPointsRow.TURNOVER_ID)

            Next

            shouldGainPointCondition.Clear()
            gainingPointsList.Clear()
            shouldGainPointCondition.Add(AfMV.MV_MP_TURNOVER_SHOULD_GAIN_POINTColumns.TURNOVER_TYPEColumn, "=", MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_OUT)
            MyPosXAuto.Facade.AfMV.FillFT_MV_MP_TURNOVER_SHOULD_GAIN_POINT(shouldGainPointCondition, gainingPointsList)

            For Each gainingPointsRow In gainingPointsList
                dbPointIOList.AddNewH_MP_CLIENT_POINT_IORow( _
                    gainingPointsRow.CLIENT_ID, _
                    Guid.NewGuid.ToString, _
                    gainingPointsRow.TURNOVER_TIME, _
                    -CommTK.FDecimal(gainingPointsRow.RMB_TO_POINT_RATE * gainingPointsRow.POINT_GAIN), _
                    -gainingPointsRow.POINT_GAIN, _
                    MyPosXAuto.Decls.CIVALUE_POINT_IO_TYPE_IN_ACCUMULATE, _
                    String.Empty, _
                    gainingPointsRow.TURNOVER_ID)

            Next


            Dim shouldUsePointCondition As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_TURNOVER_SHOULD_USE_POINT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            shouldUsePointCondition.Add(AfMV.MV_MP_TURNOVER_SHOULD_USE_POINTColumns.TURNOVER_TYPEColumn, "=", MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_OUT)
            MyPosXAuto.Facade.AfMV.FillFT_MV_MP_TURNOVER_SHOULD_USE_POINT(shouldUsePointCondition, usingPointsList)

            For Each usingPointsRow In usingPointsList
                dbPointIOList.AddNewH_MP_CLIENT_POINT_IORow( _
                    usingPointsRow.CLIENT_ID, _
                    Guid.NewGuid.ToString, _
                    usingPointsRow.TURNOVER_TIME, _
                    CommTK.FDecimal(usingPointsRow.POINT_TO_RMB_RATE * usingPointsRow.POINT_USE), _
                    usingPointsRow.POINT_USE, _
                    MyPosXAuto.Decls.CIVALUE_POINT_IO_TYPE_OUT_CONSUME, _
                    String.Empty, _
                    usingPointsRow.TURNOVER_ID)

            Next

            shouldUsePointCondition.Clear()
            usingPointsList.Clear()
            shouldUsePointCondition.Add(AfMV.MV_MP_TURNOVER_SHOULD_USE_POINTColumns.TURNOVER_TYPEColumn, "=", MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN)
            MyPosXAuto.Facade.AfMV.FillFT_MV_MP_TURNOVER_SHOULD_USE_POINT(shouldUsePointCondition, usingPointsList)

            For Each usingPointsRow In usingPointsList
                dbPointIOList.AddNewH_MP_CLIENT_POINT_IORow( _
                    usingPointsRow.CLIENT_ID, _
                    Guid.NewGuid.ToString, _
                    usingPointsRow.TURNOVER_TIME, _
                    -CommTK.FDecimal(usingPointsRow.POINT_TO_RMB_RATE * usingPointsRow.POINT_USE), _
                    -usingPointsRow.POINT_USE, _
                    MyPosXAuto.Decls.CIVALUE_POINT_IO_TYPE_OUT_CONSUME, _
                    String.Empty, _
                    usingPointsRow.TURNOVER_ID)

            Next

            MyPosXAuto.Facade.AfBizManage.SaveBatchH_MP_CLIENT_POINT_IOData(dbPointIOList)

        End Sub
    End Class

End Namespace
