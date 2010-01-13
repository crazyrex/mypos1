Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade
Imports System.Collections

Namespace Facade


    Public Class OpBizInventory

        Public Shared Function CheckInventory(ByVal inventoryID As String) As String


            Dim inventoryRow As MyPosXAuto.FTs.FT_T_MP_INVENTORYRow = _
                MyPosXAuto.Facade.AfBizInventory.GetT_MP_INVENTORYRow(inventoryID)

            If IsNothing(inventoryRow) = True Then
                Return MyPosXService.Decls.MSG_ALERT_00015
            End If


            Dim draftList As New MyPosXAuto.FTs.FT_T_MP_INVENTORY_DRAFT
            Dim draftRow As MyPosXAuto.FTs.FT_T_MP_INVENTORY_DRAFTRow
            Dim draftConditions As New MyPosXAuto.Facade.AfBizInventory.ConditionOfT_MP_INVENTORY_DRAFT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            draftConditions.Add(AfBizInventory.T_MP_INVENTORY_DRAFTColumns.INVENTORY_IDColumn, "=", inventoryID)
            MyPosXAuto.Facade.AfBizInventory.FillFT_T_MP_INVENTORY_DRAFT(draftConditions, draftList)

            Dim wareTotalList As New MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTAL
            Dim wareTotalConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_POS_WARE_TOTAL(XL.DB.Utils.Condition.LogicOperators.Logic_And)

            If inventoryRow.CHECK_ALL_ITEM = False Then
                Dim draftWareIDs As New ArrayList
                For Each draftRow In draftList
                    draftWareIDs.Add(draftRow.WARE_ID)
                Next
                wareTotalConditions.Add(AfMV.MV_MP_POS_WARE_TOTALColumns.WARE_IDColumn, True, draftWareIDs)

            End If

            wareTotalConditions.Add(AfMV.MV_MP_POS_WARE_TOTALColumns.POS_IDColumn, "=", inventoryRow.POS_ID)
            MyPosXAuto.Facade.AfMV.FillFT_MV_MP_POS_WARE_TOTAL(wareTotalConditions, wareTotalList)

            Dim resultList As New MyPosXAuto.FTs.FT_T_MP_INVENTORY_RESULT
            Dim resultCondition As New MyPosXAuto.Facade.AfBizInventory.ConditionOfT_MP_INVENTORY_RESULT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            resultCondition.Add(AfBizInventory.T_MP_INVENTORY_RESULTColumns.INVENTORY_IDColumn, "=", inventoryID)
            MyPosXAuto.Facade.AfBizInventory.FillFT_T_MP_INVENTORY_RESULT(resultCondition, resultList)

            Dim wareTotalRow As MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTALRow
            Dim resultRow As MyPosXAuto.FTs.FT_T_MP_INVENTORY_RESULTRow


            Dim involvedWareIDs As New ArrayList
            Dim involvedResultRowIDs As New ArrayList
            Dim systemAmount As Double

            Dim rowCounter As Integer = 0

            For Each draftRow In draftList


                wareTotalConditions.Clear()
                wareTotalConditions.Add(AfMV.MV_MP_POS_WARE_TOTALColumns.WARE_IDColumn, "=", draftRow.WARE_ID)
                wareTotalRow = wareTotalList.FindRowByCondition(wareTotalConditions)

                systemAmount = 0
                If IsNothing(wareTotalRow) = False Then
                    systemAmount = (wareTotalRow.CURRENT_AMOUNT - wareTotalRow.CONSIGN_IN_LACK_AMOUNT + wareTotalRow.CONSIGN_OUT_LACK_AMOUNT)
                End If

                If draftRow.INVENTORY_AMOUNT <> systemAmount Then

                    resultCondition.Clear()
                    resultCondition.Add(AfBizInventory.T_MP_INVENTORY_RESULTColumns.WARE_IDColumn, "=", draftRow.WARE_ID)
                    resultRow = resultList.FindRowByCondition(resultCondition)
                    If IsNothing(resultRow) = True Then
                        resultRow = resultList.NewT_MP_INVENTORY_RESULTRow()
                        resultList.AddT_MP_INVENTORY_RESULTRow(resultRow)
                        resultRow.WARE_ID = draftRow.WARE_ID
                        resultRow.INVENTORY_ID = inventoryID
                        resultRow.RESULT_ID = System.Guid.NewGuid.ToString
                    End If

                    resultRow.INVENTORY_AMOUNT = draftRow.INVENTORY_AMOUNT
                    resultRow.SYSTEM_AMOUNT = systemAmount
                    involvedResultRowIDs.Add(resultRow.ROW_ID)

                End If

                involvedWareIDs.Add(draftRow.WARE_ID)
                rowCounter += 1

            Next

            wareTotalConditions.Clear()
            wareTotalConditions.Add(AfMV.MV_MP_POS_WARE_TOTALColumns.WARE_IDColumn, False, involvedWareIDs)

            Dim wareTotalRows = wareTotalList.FindRowsByCondition(wareTotalConditions)

            For Each wareTotalRow In wareTotalRows

                resultCondition.Clear()
                resultCondition.Add(AfBizInventory.T_MP_INVENTORY_RESULTColumns.WARE_IDColumn, "=", wareTotalRow.WARE_ID)

                resultRow = resultList.FindRowByCondition(resultCondition)
                If IsNothing(resultRow) = True Then
                    resultRow = resultList.NewT_MP_INVENTORY_RESULTRow()
                    resultList.AddT_MP_INVENTORY_RESULTRow(resultRow)
                    resultRow.WARE_ID = wareTotalRow.WARE_ID
                    resultRow.INVENTORY_ID = inventoryID
                    resultRow.RESULT_ID = System.Guid.NewGuid.ToString
                End If

                resultRow.INVENTORY_AMOUNT = 0
                resultRow.SYSTEM_AMOUNT = wareTotalRow.CURRENT_AMOUNT
                involvedResultRowIDs.Add(resultRow.ROW_ID)

            Next

            For Each resultRow In resultList
                If involvedResultRowIDs.Contains(resultRow.ROW_ID) = True Then
                    resultRow.OFFSET_AMOUNT = resultRow.INVENTORY_AMOUNT - resultRow.SYSTEM_AMOUNT
                Else
                    resultRow.Delete()
                End If

            Next

            MyPosXAuto.Facade.AfBizInventory.SaveBatchT_MP_INVENTORY_RESULTData(resultList)
            MyPosXAuto.Facade.AfBizInventory.ReviseT_MP_INVENTORYRow( _
                inventoryID, _
                AfBizInventory.T_MP_INVENTORYColumns.INVENTORY_STATUSColumn, _
                MyPosXAuto.Decls.CIVALUE_INVENTORY_STATUS_REVIEW)

            Return String.Empty

        End Function

        Public Shared Function CreateInventoryReplaceTurnover(ByVal inventoryID As String) As String

            Dim resultConditions As New MyPosXAuto.Facade.AfBizInventory.ConditionOfT_MP_INVENTORY_RESULT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            resultConditions.Add( _
                AfBizInventory.T_MP_INVENTORY_RESULTColumns.INVENTORY_IDColumn, _
                "=", _
                inventoryID)


            Dim resultList As New MyPosXAuto.FTs.FT_T_MP_INVENTORY_RESULT
            MyPosXAuto.Facade.AfBizInventory.FillFT_T_MP_INVENTORY_RESULT(resultConditions, resultList)

            Dim inventoryRow As MyPosXAuto.FTs.FT_T_MP_INVENTORYRow = _
                MyPosXAuto.Facade.AfBizInventory.GetT_MP_INVENTORYRow(inventoryID)


            If IsNothing(inventoryRow) = True Then
                Return MyPosXService.Decls.MSG_ALERT_00015
            End If

            If inventoryRow.INVENTORY_STATUS <> MyPosXAuto.Decls.CIVALUE_INVENTORY_STATUS_REVIEW Then
                Return MyPosXService.Decls.MSG_ALERT_00011
            End If


            Dim increaseDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL
            Dim decreaseDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL
            Dim turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow = Nothing


            For Each resultRow As MyPosXAuto.FTs.FT_T_MP_INVENTORY_RESULTRow In resultList


                If resultRow.SYSTEM_AMOUNT < resultRow.INVENTORY_AMOUNT Then

                    turnoverDtlRow = increaseDtlList.NewXV_H_MP_TURNOVER_DTLRow
                    increaseDtlList.AddXV_H_MP_TURNOVER_DTLRow(turnoverDtlRow)
                    turnoverDtlRow.WARE_AMOUNT = CommTK.FDecimal(resultRow.INVENTORY_AMOUNT - resultRow.SYSTEM_AMOUNT)
                    turnoverDtlRow.WARE_ID = resultRow.WARE_ID

                ElseIf resultRow.SYSTEM_AMOUNT > resultRow.INVENTORY_AMOUNT Then
                    turnoverDtlRow = decreaseDtlList.NewXV_H_MP_TURNOVER_DTLRow
                    decreaseDtlList.AddXV_H_MP_TURNOVER_DTLRow(turnoverDtlRow)
                    turnoverDtlRow.WARE_AMOUNT = CommTK.FDecimal(resultRow.SYSTEM_AMOUNT - resultRow.INVENTORY_AMOUNT)
                    turnoverDtlRow.WARE_ID = resultRow.WARE_ID
                End If

                turnoverDtlRow.UNIT_COST = Facade.OpBizMaster.GetPosWareCost(resultRow.WARE_ID, inventoryRow.POS_ID)
                turnoverDtlRow.UNIT_PRICE = turnoverDtlRow.UNIT_COST
                turnoverDtlRow.TURNOVER_BOOK_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND
                turnoverDtlRow.SUM_COST = CommTK.FDecimal(turnoverDtlRow.UNIT_COST * turnoverDtlRow.WARE_AMOUNT)
                turnoverDtlRow.SUM_PRICE = CommTK.FDecimal(turnoverDtlRow.UNIT_PRICE * turnoverDtlRow.WARE_AMOUNT)

            Next



            Dim turnoverID = Guid.NewGuid.ToString
            Dim batchIndex As Integer
            Dim turnoverCode As String
            If increaseDtlList.Count > 0 Then
                batchIndex = OpBizTurnover.GetTurnoverBatchIndex
                turnoverCode = OpBizTurnover.GetAutoTurnoverCode(False, MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN, inventoryRow.POS_ID)

                MyPosXAuto.Facade.AfBizTurnover.CreateH_MP_TURNOVERInfo( _
                    MyPosXAuto.Decls.CIVALUE_BALANCE_STATUS_NOT_YET, _
                    batchIndex, _
                    String.Empty, _
                    CommDecl.NULL_DATE, _
                    0, _
                    String.Empty, _
                    0, _
                    String.Empty, _
                    0, _
                    0, _
                    0, _
                    inventoryRow.POS_ID, _
                    String.Empty, _
                    String.Empty, _
                    inventoryID, _
                    0, _
                    inventoryRow.CREATOR, _
                    0, _
                    String.Empty, _
                    turnoverCode, _
                    MyPosXAuto.Decls.CIVALUE_TURNOVER_CONSIGN_STATUS_NOT_YET, _
                    turnoverID, _
                    MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_CHECK_REPLACE, _
                    CommTK.GetSyncServerTime, _
                    MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN)

                For Each turnoverDtlRow In increaseDtlList
                    turnoverDtlRow.TURNOVER_ID = turnoverID
                Next

                OpBizTurnover.SetAutoWareBatchCode( _
                    turnoverCode, _
                    increaseDtlList, _
                    batchIndex)

                MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_DTLData(increaseDtlList)

                Facade.OpBizTurnover.GenerateDefaultTurnoverConsign(turnoverID)
                Facade.OpBizTurnover.GenerateDefaultTurnoverPayment(turnoverID)
            End If

            If decreaseDtlList.Count > 0 Then
                batchIndex = Facade.OpBizTurnover.GetTurnoverBatchIndex
                turnoverCode = Facade.OpBizTurnover.GetAutoTurnoverCode(False, MyPosXAuto.Decls.CIVALUE_IO_TYPE_OUT, inventoryRow.POS_ID)

                MyPosXAuto.Facade.AfBizTurnover.CreateH_MP_TURNOVERInfo( _
                    MyPosXAuto.Decls.CIVALUE_BALANCE_STATUS_NOT_YET, _
                    batchIndex, _
                    String.Empty, _
                    CommDecl.NULL_DATE, _
                    0, _
                    String.Empty, _
                    0, _
                    String.Empty, _
                    0, _
                    0, _
                    0, _
                    inventoryRow.POS_ID, _
                    String.Empty, _
                    String.Empty, _
                    inventoryID, _
                    0, _
                    inventoryRow.CREATOR, _
                    0, _
                    String.Empty, _
                    turnoverCode, _
                    MyPosXAuto.Decls.CIVALUE_TURNOVER_CONSIGN_STATUS_NOT_YET, _
                    turnoverID, _
                    MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_CHECK_REPLACE, _
                    CommTK.GetSyncServerTime, _
                    MyPosXAuto.Decls.CIVALUE_IO_TYPE_OUT)

                For Each turnoverDtlRow In decreaseDtlList
                    turnoverDtlRow.TURNOVER_ID = turnoverID
                Next

                Facade.OpBizTurnover.SetAutoWareBatchCode( _
                    turnoverCode, _
                    decreaseDtlList, _
                    batchIndex)

                MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_DTLData(decreaseDtlList)

                Facade.OpBizTurnover.GenerateDefaultTurnoverConsign(turnoverID)
                Facade.OpBizTurnover.GenerateDefaultTurnoverPayment(turnoverID)

            End If
            MyPosXAuto.Facade.AfBizInventory.ReviseT_MP_INVENTORYRow( _
                inventoryID, _
                AfBizInventory.T_MP_INVENTORYColumns.INVENTORY_STATUSColumn, _
                MyPosXAuto.Decls.CIVALUE_INVENTORY_STATUS_FINISH)

            Return String.Empty

        End Function


    End Class

End Namespace