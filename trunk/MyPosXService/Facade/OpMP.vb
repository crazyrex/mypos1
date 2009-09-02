Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade

Namespace Facade



    Public Class OpMP

        Public Shared Sub FillFT_MP_MP_SELECT_CLIENT_SALES_REPORT( _
            ByVal fromTime As DateTime, _
            ByVal toTime As DateTime, _
            ByRef list As MyPosXAuto.FTs.FT_MP_MP_SELECT_CLIENT_SALES_REPORT)

            Dim MPDataLayer As MyPosXAuto.DataLayer.EDLMP = MyPosXAuto.DataLayer.EDLMP.GetInstance()

            MPDataLayer.FillFT_MP_MP_SELECT_CLIENT_SALES_REPORT( _
                fromTime, _
                toTime, _
                list)

        End Sub

        Public Shared Sub FillFT_MP_MP_SELECT_WARE_SALES_REPORT( _
           ByVal fromTime As DateTime, _
           ByVal toTime As DateTime, _
           ByRef list As MyPosXAuto.FTs.FT_MP_MP_SELECT_WARE_SALES_REPORT)

            Dim MPDataLayer As MyPosXAuto.DataLayer.EDLMP = MyPosXAuto.DataLayer.EDLMP.GetInstance()

            MPDataLayer.FillFT_MP_MP_SELECT_WARE_SALES_REPORT( _
                fromTime, _
                toTime, _
                list)

        End Sub

        Public Shared Sub FillFT_MP_MP_SELECT_POS_PERIOD_WARE_IO_TOTAL( _
           ByVal posID As String, _
           ByVal fromTime As DateTime, _
           ByVal toTime As DateTime, _
           ByRef list As MyPosXAuto.FTs.FT_MP_MP_SELECT_POS_PERIOD_WARE_IO_TOTAL)

            Dim MPDataLayer As MyPosXAuto.DataLayer.EDLMP = MyPosXAuto.DataLayer.EDLMP.GetInstance()

            MPDataLayer.FillFT_MP_MP_SELECT_POS_PERIOD_WARE_IO_TOTAL( _
                posID, _
                fromTime, _
                toTime, _
                list)

        End Sub

        Public Shared Sub FillFT_MP_MP_SELECT_STAFF_COMMISSION_TOTAL( _
           ByVal fromTime As DateTime, _
           ByVal toTime As DateTime, _
           ByRef list As MyPosXAuto.FTs.FT_MP_MP_SELECT_STAFF_COMMISSION_TOTAL)

            Dim MPDataLayer As MyPosXAuto.DataLayer.EDLMP = MyPosXAuto.DataLayer.EDLMP.GetInstance()

            MPDataLayer.FillFT_MP_MP_SELECT_STAFF_COMMISSION_TOTAL( _
                fromTime, _
                toTime, _
                list)

        End Sub

        Public Shared Sub FillFT_MP_MP_SELECT_POS_PERIOD_WARE_TURNOVER_STYLE_TOTAL( _
            ByVal fromTime As DateTime, _
            ByVal toTime As DateTime, _
            ByVal posID As String, _
            ByRef list As MyPosXAuto.FTs.FT_MP_MP_SELECT_POS_PERIOD_WARE_TURNOVER_STYLE_TOTAL)

            Dim MPDataLayer As MyPosXAuto.DataLayer.EDLMP = MyPosXAuto.DataLayer.EDLMP.GetInstance()

            MPDataLayer.FillFT_MP_MP_SELECT_POS_PERIOD_WARE_TURNOVER_STYLE_TOTAL( _
                 posID, _
                fromTime, _
                toTime, _
                list)

        End Sub

        Public Shared Sub FillFT_MP_MP_SELECT_PERIOD_POINT_WARE_EXCHANGE_TOTAL( _
           ByVal fromDate As DateTime, _
           ByVal toDate As DateTime, _
           ByVal posID As String, _
           ByRef list As MyPosXAuto.FTs.FT_MP_MP_SELECT_PERIOD_POINT_WARE_EXCHANGE_TOTAL)

            Dim MPDataLayer As MyPosXAuto.DataLayer.EDLMP = MyPosXAuto.DataLayer.EDLMP.GetInstance()

            MPDataLayer.FillFT_MP_MP_SELECT_PERIOD_POINT_WARE_EXCHANGE_TOTAL( _
                fromDate, _
                toDate, _
                posID, _
                list)

        End Sub




        Public Shared Sub ExecuteMP_MP_EXECUTE_FINISH_TURNOVER_PAYMENT_BALANCE()

            Dim MPDataLayer As MyPosXAuto.DataLayer.EDLMP = MyPosXAuto.DataLayer.EDLMP.GetInstance()


            MPDataLayer.ExecuteMP_MP_EXECUTE_FINISH_TURNOVER_PAYMENT_BALANCE()

        End Sub

        Public Shared Sub ExecuteMP_MP_EXECUTE_FINISH_TURNOVER_CONSIGN_BALANCE()

            Dim MPDataLayer As MyPosXAuto.DataLayer.EDLMP = MyPosXAuto.DataLayer.EDLMP.GetInstance()


            MPDataLayer.ExecuteMP_MP_EXECUTE_FINISH_TURNOVER_CONSIGN_BALANCE()

        End Sub

        Public Shared Sub ExecuteMP_MP_EXECUTE_DELETE_POINT_GAIN_USE_IO_WITH_NO_TURNOVER()

            Dim MPDataLayer As MyPosXAuto.DataLayer.EDLMP = MyPosXAuto.DataLayer.EDLMP.GetInstance()


            MPDataLayer.ExecuteMP_MP_EXECUTE_DELETE_POINT_GAIN_USE_IO_WITH_NO_TURNOVER()

        End Sub

        Public Shared Sub ExecuteMP_MP_EXECUTE_DELETE_REDUNDANCY_POS_SET_WARE()

            Dim MPDataLayer As MyPosXAuto.DataLayer.EDLMP = MyPosXAuto.DataLayer.EDLMP.GetInstance()


            MPDataLayer.ExecuteMP_MP_EXECUTE_DELETE_REDUNDANCY_POS_SET_WARE()

        End Sub
    End Class

End Namespace
