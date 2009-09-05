Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade
Imports System.Collections
Imports System.Data

Namespace Facade

    Public Class OpBizManage

        Public Shared Function ValidatePosAffairConflict( _
            ByVal affairID As String, _
            ByVal beginDate As DateTime, _
            ByVal endDate As DateTime, _
            ByVal affairPosList As MyPosXAuto.FTs.FT_M_MP_POS) As Boolean

            beginDate = CommTK.GetBeginOfDate(beginDate)
            endDate = CommTK.GetEndOfDate(endDate)

            Dim affairPosCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_SALE_AFFAIR_POS(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            Dim dateRangeCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_SALE_AFFAIR_POS(XL.DB.Utils.Condition.LogicOperators.Logic_Or)

            Dim beginCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_SALE_AFFAIR_POS(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            Dim endCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_SALE_AFFAIR_POS(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            Dim includingCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_SALE_AFFAIR_POS(XL.DB.Utils.Condition.LogicOperators.Logic_And)


            beginCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.BEGIN_DATEColumn, ">", beginDate)
            beginCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.BEGIN_DATEColumn, "<", endDate)

            endCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.END_DATEColumn, ">", beginDate)
            endCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.END_DATEColumn, "<", endDate)

            includingCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.BEGIN_DATEColumn, "<", beginDate)
            includingCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.END_DATEColumn, ">", endDate)

            dateRangeCondition.Add(beginCondition, True)
            dateRangeCondition.Add(endCondition, True)
            dateRangeCondition.Add(includingCondition, True)
            affairPosCondition.Add(dateRangeCondition, True)
            affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.AFFAIR_IDColumn, "<>", affairID)

            Dim otherAffairPosList As New MyPosXAuto.FTs.FT_XV_T_MP_SALE_AFFAIR_POS
            MyPosXAuto.Facade.AfXV.FillFT_XV_T_MP_SALE_AFFAIR_POS(affairPosCondition, otherAffairPosList)

            If otherAffairPosList.Count = 0 Then
                Return True
            End If

            Dim result As Boolean = True
            Dim otherAffairPosRow As MyPosXAuto.FTs.FT_XV_T_MP_SALE_AFFAIR_POSRow
            For Each selectedPosRow As MyPosXAuto.FTs.FT_M_MP_POSRow In affairPosList.FindRowsSelecting(True)

                affairPosCondition.Clear()
                affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.POS_IDColumn, "=", selectedPosRow.POS_ID)

                otherAffairPosRow = otherAffairPosList.FindRowByCondition(affairPosCondition)
                If IsNothing(otherAffairPosRow) = False Then
                    selectedPosRow.ROW_HIGHLIGHT = Decls.ROW_HIGHLIGHT_EXIST
                    selectedPosRow.ROW_REMARK = CommTK.GetTranslatedString(Decls.ROW_REMARK_0005, otherAffairPosRow.AFFAIR_NAME, otherAffairPosRow.TEMPLATE_CODE)
                    result = False
                End If
            Next

            Return result
        End Function

        Public Shared Sub FillPosCurrentAffairInfo( _
            ByVal posID As String, _
            ByRef affairTemplateWareList As MyPosXAuto.FTs.FT_XV_T_MP_SALE_TEMPLATE_WARE, _
            ByRef affairDescription As String)

            affairTemplateWareList.Clear()

            Dim affairPosCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_SALE_AFFAIR_POS(XL.DB.Utils.Condition.LogicOperators.Logic_And)

            affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.POS_IDColumn, "=", posID)
            affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.BEGIN_DATEColumn, "<=", CommTK.GetSyncServerTime)
            affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.END_DATEColumn, ">=", CommTK.GetSyncServerTime)
            Dim affairPosRow = MyPosXAuto.Facade.AfXV.GetXV_T_MP_SALE_AFFAIR_POSRow(affairPosCondition)

            If IsNothing(affairPosRow) = True Then
                Return
            End If

            Dim affairTemplateWareCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_SALE_TEMPLATE_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            affairTemplateWareCondition.Add(AfXV.XV_T_MP_SALE_TEMPLATE_WAREColumns.TEMPLATE_IDColumn, "=", affairPosRow.TEMPLATE_ID)

            Dim affairTemplateRow = MyPosXAuto.Facade.AfBizManage.GetT_MP_SALE_TEMPLATERow(affairPosRow.TEMPLATE_ID)

            Dim descriptionBuilder As New LineStrBuilder
            descriptionBuilder.AppendLine("名称{0}:", affairPosRow.AFFAIR_NAME)
            descriptionBuilder.AppendLine("起始: {0:yyyy-MM-dd}", affairPosRow.BEGIN_DATE)
            descriptionBuilder.AppendLine("截止: {0:yyyy-MM-dd}", affairPosRow.END_DATE)
            descriptionBuilder.AppendLine("优惠模板: <{0}>{1}", affairTemplateRow.TEMPLATE_CODE, affairTemplateRow.TEMPLATE_NAME)

            affairDescription = descriptionBuilder.ToString

            MyPosXAuto.Facade.AfXV.FillFT_XV_T_MP_SALE_TEMPLATE_WARE(affairTemplateWareCondition, affairTemplateWareList)
        End Sub
    End Class

End Namespace
