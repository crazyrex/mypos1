Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade
Imports System.Collections
Imports System.Data

Namespace Facade

    Public Class OpManage

        Public Shared Function ValidatePosAffairConflict(ByVal affairID As String, ByVal affairPosList As MyPosXAuto.FTs.FT_T_MP_SALE_AFFAIR_POS) As Boolean


            Dim affairPosCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_SALE_AFFAIR_POS(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            Dim otherAffairPosList As New MyPosXAuto.FTs.FT_XV_T_MP_SALE_AFFAIR_POS
            Dim otherAffairPosRow As MyPosXAuto.FTs.FT_XV_T_MP_SALE_AFFAIR_POSRow
            affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.BEGIN_DATEColumn, "<=", CommTK.GetSyncServerTime)
            affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.BEGIN_DATEColumn, "<=", CommTK.GetSyncServerTime)
            affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.AFFAIR_IDColumn, "<>", affairID)
            MyPosXAuto.Facade.AfXV.FillFT_XV_T_MP_SALE_AFFAIR_POS(affairPosCondition, otherAffairPosList)

            If otherAffairPosList.Count = 0 Then
                Return True
            End If

            Dim result As Boolean = True
            For Each selectedAffairPosRow As MyPosXAuto.FTs.FT_T_MP_SALE_AFFAIR_POSRow In affairPosList.FindRowsSelecting(True)

                affairPosCondition.Clear()
                affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.POS_IDColumn, "=", selectedAffairPosRow.POS_ID)

                otherAffairPosRow = otherAffairPosList.FindRowByCondition(affairPosCondition)
                If IsNothing(otherAffairPosRow) = False Then
                    selectedAffairPosRow.ROW_HIGHLIGHT = Decls.ROW_HIGHLIGHT_EXIST
                    selectedAffairPosRow.ROW_REMARK = CommTK.GetTranslatedString(Decls.ROW_REMARK_0005, otherAffairPosRow.AFFAIR_NAME, otherAffairPosRow.TEMPLATE_CODE)
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

            Dim affairPosCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_SALE_AFFAIR_POS(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.POS_IDColumn, "=", posID)
            affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.BEGIN_DATEColumn, "<=", CommTK.GetSyncServerTime)
            affairPosCondition.Add(AfXV.XV_T_MP_SALE_AFFAIR_POSColumns.END_DATEColumn, ">=", CommTK.GetSyncServerTime)
            Dim affairPosRow = MyPosXAuto.Facade.AfXV.GetXV_T_MP_SALE_AFFAIR_POSRow(affairPosCondition)

            If IsNothing(affairPosRow) = False Then
                Return
            End If

            Dim affairTemplateWareCondition As New MyPosXAuto.Facade.AfBizManage.ConditionOfT_MP_SALE_TEMPLATE_WARE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            affairTemplateWareCondition.Add(AfBizManage.T_MP_SALE_TEMPLATE_WAREColumns.TEMPLATE_IDColumn, "=", affairPosRow.TEMPLATE_ID)

            Dim affairTemplateRow = _
                          MyPosXAuto.Facade.AfBizManage.GetT_MP_SALE_TEMPLATERow(affairPosRow.TEMPLATE_ID)

            Dim descriptionBuilder As New LineStrBuilder
            descriptionBuilder.AppendLine("名称{0}:", affairPosRow.AFFAIR_NAME)
            descriptionBuilder.AppendLine("起始: {0:yyyy-MM-dd}", affairPosRow.BEGIN_DATE)
            descriptionBuilder.AppendLine("截止: {0:yyyy-MM-dd}", affairPosRow.END_DATE)
            descriptionBuilder.AppendLine("优惠模板: {0}", affairTemplateRow.TEMPLATE_NAME)
        End Sub
    End Class

End Namespace
