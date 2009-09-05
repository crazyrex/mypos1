
Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade
Imports System.Collections

Namespace Facade

    Public Class OpBizConfig

        Public Shared Function GetCurrencyValueToRMB( _
            ByVal currencyType As Integer, _
            ByVal currencyValue As Decimal, _
            ByRef currencyRate As Double) As Decimal

            If currencyType = MyPosXService.Decls.DEFAULT_CI_CURRENCY_TYPE_VALUE_RMB Then
                currencyRate = 1
                Return currencyValue
            End If
            Dim currencyRateConditions As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_CURRENCY_RATE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            currencyRateConditions.Add(AfBizConfig.S_MP_CURRENCY_RATEColumns.CURRENCY_TYPEColumn, "=", currencyType)

            Dim currencyRateRow As MyPosXAuto.FTs.FT_S_MP_CURRENCY_RATERow = _
                MyPosXAuto.Facade.AfBizConfig.GetS_MP_CURRENCY_RATERow(currencyRateConditions)

            If IsNothing(currencyRateRow) = True Then
                currencyRate = 0
                Return 0
            End If

            currencyRate = currencyRateRow.RATE
            Return CommTK.FDecimal(currencyRateRow.RATE * currencyValue)

        End Function

        Public Shared Function SavePosSetWareList( _
            ByVal posSetID As String, _
            ByVal posSetWareList As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARE) As Boolean

            Dim result As Boolean = True

            Dim dbCondition As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_POS_SET_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            dbCondition.Add(AfBizConfig.S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", posSetID)
            Dim dbList As New MyPosXAuto.FTs.FT_S_MP_POS_SET_WARE
            MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_POS_SET_WARE(dbCondition, dbList)

            Dim dbRow As MyPosXAuto.FTs.FT_S_MP_POS_SET_WARERow
            Dim existingDetailIDs As New ArrayList

            For Each bindingRow As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERow In posSetWareList.FindRowsUndeleted

                dbCondition.Clear()
                dbCondition.Add(AfBizConfig.S_MP_POS_SET_WAREColumns.WARE_IDColumn, "=", bindingRow.WARE_ID)

                dbRow = dbList.FindRowByCondition(dbCondition)

                If IsNothing(dbRow) = False Then

                    If dbRow.DETAIL_ID <> bindingRow.DETAIL_ID Then
                        dbList.AddNewS_MP_POS_SET_WARERow( _
                            bindingRow.DETAIL_ID, _
                            bindingRow.INDIVIDUAL_DISCOUNT, _
                            bindingRow.LOWER_LIMIT, _
                            bindingRow.SET_ID, _
                            bindingRow.UNIT_COST, _
                            bindingRow.UNIT_PRICE, _
                            bindingRow.WARE_ID)
                        existingDetailIDs.Add(bindingRow.DETAIL_ID)
                    Else
                        existingDetailIDs.Add(dbRow.DETAIL_ID)
                        dbRow.CloneDataRow(bindingRow)
                    End If
                Else
                    dbList.AddNewS_MP_POS_SET_WARERow( _
                        bindingRow.DETAIL_ID, _
                        bindingRow.INDIVIDUAL_DISCOUNT, _
                        bindingRow.LOWER_LIMIT, _
                        bindingRow.SET_ID, _
                        bindingRow.UNIT_COST, _
                        bindingRow.UNIT_PRICE, _
                        bindingRow.WARE_ID)
                    existingDetailIDs.Add(bindingRow.DETAIL_ID)

                End If

            Next

            MyPosXAuto.Facade.AfBizConfig.SaveBatchS_MP_POS_SET_WAREData(dbList)

            dbCondition.Add(AfBizConfig.S_MP_POS_SET_WAREColumns.WARE_IDColumn, False, existingDetailIDs)
            MyPosXAuto.Facade.AfBizConfig.DeleteS_MP_POS_SET_WAREData(dbCondition)


        End Function
    End Class
End Namespace