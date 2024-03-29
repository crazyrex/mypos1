Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports Microsoft.Office.Interop
Imports System.Drawing.Imaging

Namespace Utils

    Public Class TK

        Public Shared Sub InitImageParameter()


            'Get the list of available encoders
            Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()

            'find the encoder with the image/jpeg mime-type
            For Each codec As ImageCodecInfo In codecs
                If codec.MimeType = "image/jpeg" Then
                    Utils.Decls.IMAGE_CODE_INFO = codec
                End If
            Next

            'Create a collection of encoder parameters (we only need one in the collection)
            Utils.Decls.ENCODER_PARAMETER.Param(0) = New EncoderParameter(Encoder.Quality, 100)

        End Sub

        Public Shared Function GetUserOptionsBox() As XL.Win.Component.OptionsBox

            Return New UserOptionsBox

        End Function

        Public Shared Function GetSecureOptionsBox() As XL.Win.Component.OptionsBox

            Return New SecureOptionsBox

        End Function

 
#Region "Print"

        Public Shared Sub PrintWareLabel( _
            ByVal wareRow As MyPosXAuto.FTs.FT_XV_M_MP_WARERow, _
            ByVal barTenderFilePath As String, _
            ByVal copies As Integer)

            If IO.File.Exists(barTenderFilePath) = False Then
                Return
            End If

            If copies = 0 Then
                Return
            End If

            Dim btApp As New BarTender.Application
            btApp = New BarTender.ApplicationClass

            Dim btFormat As BarTender.Format = btApp.Formats.Open(barTenderFilePath)
            Dim btVarNames As New List(Of String)
            For Each namedSubString As BarTender.SubString In btFormat.NamedSubStrings
                btVarNames.Add(namedSubString.Name)
            Next

            For Each wareColumns As DataColumn In wareRow.Table.Columns
                If btVarNames.Contains(wareColumns.ColumnName) = True Then
                    btFormat.SetNamedSubStringValue(wareColumns.ColumnName, CommTK.FString(wareRow.Item(wareColumns)))
                End If
            Next

            For counter As Integer = 1 To copies
                btFormat.PrintOut()
            Next

            btFormat.Close()

        End Sub

        Public Shared Sub PrintLocationLabel(ByVal locationRow As MyPosXAuto.FTs.FT_M_MP_POS_LOCATIONRow)

            locationRow.ROW_REMARK = MyPosXService.Facade.OpBizMaster.GetShelfLocationInfoString(locationRow.LOCATION_ID)

            Select Case CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_LABEL_SOLUTION))
                Case 0

                Case 1
                    'Dim labelReport As New Reports.R_01_00201WareLabel01
                    'labelReport.Label_WareInfo.Text = String.Format("{0}, {1} {2} {3}", wareRow.CUSTOM_CODE, wareRow.WARE_NAME, wareRow.SPEC, wareRow.MODEL)
                    'labelReport.XrBarCode_WareBarcode.Text = wareRow.WARE_CODE

                    'For counter As Integer = 1 To copies
                    '    labelReport.Print()
                    'Next

                Case 2

                    'Dim labelReport As New Reports.R_01_00201WareLabel02

                    'labelReport.xrLabel_WareInfo.Text = String.Format("{0} {1} {2}", wareRow.WARE_NAME, wareRow.SPEC, wareRow.MODEL)
                    'labelReport.XrLabel_CustomCode.Text = wareRow.CUSTOM_CODE
                    'labelReport.xrLabel_WareInfoEN.Text = wareRow.WARE_NAME_EN
                    'labelReport.XrLabel_Cash.Text = String.Format("RMB:{0:#,##0.00}", Facade.OpBizMaster.GetPosWarePrice(wareRow.WARE_ID, utils.Decls.CURRENT_POS_ROW.POS_ID, wareRow.UNIT_PRICE))
                    'labelReport.XrBarCode_WareBarcode.Text = wareRow.WARE_CODE

                    'For counter As Integer = 1 To copies
                    '    labelReport.Print()
                    'Next

                Case 3

                    Dim theBarCodeKit As New XL.Win.Utils.BarCodeKit(String.Empty)

                    theBarCodeKit.Darkness = CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_PRINT_BARCODE_DARKNESS))
                    theBarCodeKit.Backfeed = 0


                    theBarCodeKit.AddBarCode( _
                        18, _
                        16, _
                        BarCodeKit.Orintations.Ang0, _
                        2, _
                        4, _
                        30, _
                        BarCodeKit.BarCodeType.CODE128, _
                        False, _
                        locationRow.ROW_REMARK)

                    theBarCodeKit.AddTrueTypeText( _
                        18, _
                        4, _
                        25, _
                        "Century Gothic", _
                        BarCodeKit.Orintations.Ang0, _
                        BarCodeKit.FontWeights.Weight100, _
                        BarCodeKit.FontStyles.Regular, _
                        locationRow.ROW_REMARK)

                    theBarCodeKit.DoPrint(1)

                Case 4



                    Dim theBarCodeKit As New XL.Win.Utils.BarCodeKit(String.Empty)

                    theBarCodeKit.Darkness = CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_PRINT_BARCODE_DARKNESS))
                    theBarCodeKit.Backfeed = 0

                    theBarCodeKit.AddBarCode( _
                        18, _
                        68, _
                        BarCodeKit.Orintations.Ang0, _
                        1, _
                        2, _
                        60, _
                        BarCodeKit.BarCodeType.CODE128, _
                         True, _
                        locationRow.ROW_REMARK)


                    theBarCodeKit.DoPrint(1)

            End Select
        End Sub

        Public Shared Sub PrintPractLabel()

        End Sub

#End Region

#Region "Export"

        Public Shared Sub ExportTurnoverConsign(ByVal fileName As String, ByVal consignID As String)



        End Sub

        Public Shared Sub ExportTurnoverCASA(ByVal fileName As String, ByVal turnoverID As String)

            Dim turnoverConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            turnoverConditions.Add(MyPosXAuto.Facade.AfMV.MV_MP_TURNOVERColumns.TURNOVER_IDColumn, "=", turnoverID)
            Dim turnoverList As New MyPosXAuto.FTs.FT_MV_MP_TURNOVER
            MyPosXAuto.Facade.AfMV.FillFT_MV_MP_TURNOVER(turnoverConditions, turnoverList)

            If turnoverList.Count = 0 Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(MyPosXService.Decls.MSG_ALERT_00022)
                Throw ex
            End If

            Dim turnoverRow As MyPosXAuto.FTs.FT_MV_MP_TURNOVERRow = turnoverList(0)

            Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            turnoverDtlConditions.Add( _
                MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_IDColumn, _
                "=", _
                turnoverID)

            Dim turnoverDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL
            MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_DTL(turnoverDtlConditions, turnoverDtlList)

            If IO.File.Exists(fileName) = True Then
                IO.File.Delete(fileName)
            End If

            Dim toExcel As New Utils.ExcelTK(fileName)

            toExcel.AddSheet("Invoice")

            toExcel.SetColumnWidth(1, 2)
            toExcel.SetColumnWidth(2, 5)
            toExcel.SetColumnWidth(3, 6)
            toExcel.SetColumnWidth(4, 8)
            toExcel.SetColumnWidth(5, 8)
            toExcel.SetColumnWidth(6, 8)
            toExcel.SetColumnWidth(7, 8)
            toExcel.SetColumnWidth(8, 10)
            toExcel.SetColumnWidth(9, 8)
            toExcel.SetColumnWidth(10, 8)
            toExcel.SetColumnWidth(11, 9)
            toExcel.SetColumnWidth(12, 10)
            toExcel.SetColumnWidth(13, 11)

            toExcel.SetRowHeight(1, 35)

            Dim cellFont As Font = New Font("Verdana", 18, FontStyle.Regular)

            toExcel.SetFrameLine(1, 1, 5, 12, _
                ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Horizonal Or ExcelTK.BorderPart.Vertical, _
                Color.White, _
                Excel.XlLineStyle.xlLineStyleNone, Excel.XlBorderWeight.xlThin)

            toExcel.MergeCell(1, 2, 1, 12)

            toExcel.SetCellText(1, 2, "CASA PAGODA", cellFont, Color.Orange, Color.White)

            cellFont = New Font("Arial", 11, FontStyle.Regular)
            toExcel.MergeCell(2, 2, 2, 12)
            toExcel.SetCellText(2, 2, "HOME FURNISHING", cellFont, Color.Black, Color.White)


            toExcel.MergeCell(3, 2, 3, 12)

            cellFont = New Font("Arial", 10, FontStyle.Regular)
            toExcel.SetCellText(3, 2, "No.15-17 Taikang Road, Shanghai, 200025 China", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(4, 2, 4, 12)
            toExcel.SetCellText(4, 2, "中国上海泰康路15号-17号,邮编200025", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(5, 2, 5, 12)
            toExcel.SetCellText(5, 2, "Tel/电话: (86) 021 6466 75 21", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(6, 2, 6, 12)

            toExcel.MergeCell(7, 2, 7, 12)
            toExcel.SetCellText(7, 2, "1/F, Le passage, No.299 Fuxing xi lu (near Gaoyou lu),Shanghai, China", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(8, 2, 8, 12)
            toExcel.SetCellText(8, 2, "中国上海复兴西路299号一楼（近高邮路）", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(9, 2, 9, 12)
            toExcel.SetCellText(9, 2, "Tel/电话: (86) 021 6467 5608", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(10, 2, 10, 12)

            toExcel.SetRowHeight(10, 3)
            toExcel.MergeCell(11, 1, 11, 12)
            toExcel.MergeCell(12, 1, 12, 12)
            cellFont = New Font("Arial", 12, FontStyle.Regular)
            toExcel.SetCellText(12, 1, "Sales Slipt/Receipt", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(13, 1, 13, 12)
            toExcel.MergeCell(14, 1, 14, 12)
            toExcel.SetFrameLine(10, 2, 10, 12, ExcelTK.BorderPart.Bottom, Color.Black, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            toExcel.SetRowHeight(12, 20)
            toExcel.SetRowHeight(13, 20)
            toExcel.SetRowHeight(14, 20)
            toExcel.SetRowHeight(15, 20)
            toExcel.SetRowHeight(16, 20)
            toExcel.SetRowHeight(17, 20)
            toExcel.SetRowHeight(18, 20)

            Dim clientRow As MyPosXAuto.FTs.FT_M_MP_CLIENTRow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_CLIENTRow(turnoverRow.CLIENT_ID)

            toExcel.MergeCell(15, 2, 15, 4)
            cellFont = New Font("Arial", 11, FontStyle.Bold)
            toExcel.SetCellText(15, 2, "Customer's Name/ 姓名:", cellFont, Color.Black, Color.White)
            toExcel.SetCellTextFont(15, 2, 17, 4, cellFont, Color.Black)
            toExcel.MergeCell(15, 5, 15, 9)
            toExcel.SetFrameLine(15, 6, 15, 9, ExcelTK.BorderPart.Bottom, Color.Black)
            cellFont = New Font("Arial", 11, FontStyle.Regular)
            toExcel.SetCellText(15, 5, turnoverRow.CLIENT_NAME, cellFont, Color.Black, Color.White)


            cellFont = New Font("Arial", 11, FontStyle.Bold)
            toExcel.SetCellText(15, 11, "No/ 号码", cellFont, Color.Black, Color.White)
            toExcel.SetCellTextFont(15, 10, 4, 6, cellFont, Color.Black)
            toExcel.SetFrameLine(15, 11, 15, 12, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Horizonal Or ExcelTK.BorderPart.Vertical, Color.Black, Excel.XlLineStyle.xlContinuous)
            toExcel.SetCellText(15, 12, turnoverRow.TURNOVER_CODE.Substring(turnoverRow.TURNOVER_CODE.Length - 5, 5), cellFont, Color.Black, Color.White, "@")

            toExcel.MergeCell(16, 2, 16, 4)
            cellFont = New Font("Arial", 11, FontStyle.Bold)
            toExcel.SetCellText(16, 2, "Address/ 地址:", cellFont, Color.Black, Color.White)
            toExcel.SetCellTextFont(16, 2, 9, 5, cellFont, Color.Black)
            toExcel.MergeCell(16, 5, 16, 9)
            toExcel.SetFrameLine(16, 5, 16, 9, ExcelTK.BorderPart.Bottom, Color.Black)
            cellFont = New Font("Arial", 12, FontStyle.Regular)
            toExcel.SetCellText(16, 5, turnoverRow.CLIENT_ADDRESS, cellFont, Color.Black, Color.White)

            toExcel.MergeCell(17, 2, 17, 4)
            cellFont = New Font("Arial", 11, FontStyle.Bold)
            toExcel.SetCellText(17, 2, "Email/ 邮箱:", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(17, 5, 17, 9)
            toExcel.SetFrameLine(17, 5, 17, 9, ExcelTK.BorderPart.Bottom, Color.Black)
            cellFont = New Font("Arial", 12, FontStyle.Regular)
            toExcel.SetCellText(17, 5, turnoverRow.CLIENT_EMAIL, cellFont, Color.Black, Color.White)

            cellFont = New Font("Arial", 11, FontStyle.Bold)
            toExcel.SetCellText(17, 11, "Date/ 日期", cellFont, Color.Black, Color.White)
            toExcel.SetFrameLine(17, 11, 17, 12, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Horizonal Or ExcelTK.BorderPart.Vertical, Color.Black, Excel.XlLineStyle.xlContinuous)
            toExcel.SetCellText(17, 12, CommTK.FString(turnoverRow.TURNOVER_TIME, True, "yyyy-MM-dd"), cellFont, Color.Black, Color.White)

            toExcel.MergeCell(18, 2, 18, 4)
            cellFont = New Font("Arial", 11, FontStyle.Bold)
            toExcel.SetCellText(18, 2, "Tel No/ 电话:", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(18, 5, 18, 9)
            toExcel.SetFrameLine(18, 5, 18, 9, ExcelTK.BorderPart.Bottom, Color.Black)
            cellFont = New Font("Arial", 12, FontStyle.Regular)
            If IsNothing(clientRow) = False Then
                toExcel.SetCellText(18, 5, clientRow.CELL_PHONE, cellFont, Color.Black, Color.White)
            End If

            toExcel.SetRowHeight(19, 3)

            cellFont = New Font("Arial", 11, FontStyle.Bold)
            toExcel.MergeCell(20, 2, 21, 6)
            'toExcel.SetCellText(16, 2, "Order No.",  cellFont, Color.Black, Color.White)
            toExcel.MergeCell(20, 7, 20, 8)
            toExcel.SetCellText(20, 7, "Term of Payment", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(20, 9, 20, 10)
            toExcel.SetCellText(20, 9, "Due Date", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(20, 11, 20, 12)
            toExcel.SetCellText(20, 11, "Sales Employee", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(21, 7, 21, 8)
            toExcel.SetCellText(21, 7, "付款方式", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(21, 9, 21, 10)
            toExcel.SetCellText(21, 9, "到期时间", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(21, 11, 21, 12)
            toExcel.SetCellText(21, 11, "销售", cellFont, Color.Black, Color.White)

            Dim shareEmployeeListBuilder As New LineStrBuilder

            Dim payConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_PAY_LOG(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            payConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_PAY_LOGColumns.TURNOVER_IDColumn, "=", turnoverID)
            Dim paymentTypes As ArrayList = MyPosXAuto.Facade.AfXV.GetXV_H_MP_TURNOVER_PAY_LOG_CVListDistinct(payConditions, MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_PAY_LOGColumns.PAY_TYPE_TEXTColumn)
            Dim paymentTypeListBuilder As New LineStrBuilder
            For Each paymentType As String In paymentTypes
                paymentTypeListBuilder.AppendFormat("{0},", paymentType)
            Next
            If paymentTypeListBuilder.Length > 0 Then
                paymentTypeListBuilder.Remove(paymentTypeListBuilder.Length - 1, 1)
            End If

            Dim sareDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_SHARE_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            sareDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_SHARE_DTLColumns.TURNOVER_IDColumn, "=", turnoverID)
            Dim shareEmployees As ArrayList = MyPosXAuto.Facade.AfXV.GetXV_H_MP_TURNOVER_SHARE_DTL_CVListDistinct(sareDtlConditions, MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_SHARE_DTLColumns.SHARE_STAFF__STAFF_NAMEColumn)
            For Each shareEmployee As String In shareEmployees
                shareEmployeeListBuilder.AppendFormat("{0},", shareEmployee)
            Next
            If shareEmployeeListBuilder.Length > 0 Then
                shareEmployeeListBuilder.Remove(shareEmployeeListBuilder.Length - 1, 1)
            End If

            cellFont = New Font("Arial", 10, FontStyle.Regular)
            toExcel.MergeCell(22, 2, 22, 6)
            toExcel.SetCellText(22, 2, turnoverRow.TURNOVER_CODE, cellFont, Color.Black, Color.White)
            toExcel.MergeCell(22, 7, 22, 8)
            toExcel.SetCellText(22, 7, paymentTypeListBuilder.ToString, cellFont, Color.Black, Color.White)
            toExcel.MergeCell(22, 9, 22, 10)
            toExcel.SetCellText(22, 9, CommTK.FString(turnoverRow.CONSIGN_DUE_DATE, True, "yyyy-MM-dd"), cellFont, Color.Black, Color.White)
            toExcel.MergeCell(22, 11, 22, 12)
            toExcel.SetCellText(22, 11, shareEmployeeListBuilder.ToString, cellFont, Color.Black, Color.White)

            toExcel.SetFrameLine(20, 2, 22, 12, _
                             ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Vertical Or ExcelTK.BorderPart.Horizonal, _
                             Color.Black, Excel.XlLineStyle.xlContinuous)


            toExcel.SetRowHeight(23, 35)
            cellFont = New Font("Arial", 8, FontStyle.Bold)
            toExcel.SetCellText(23, 2, "No.", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(23, 5, 23, 7)
            toExcel.SetCellText(23, 5, "DESCRIPTION/ 描述", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(23, 8, "Color/颜色", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(23, 9, "QTY/数量", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(23, 11, "Discount/ 折扣", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(23, 12, "AMOUNT/ 总数", cellFont, Color.Black, Color.White)

            cellFont = New Font("Arial", 8, FontStyle.Bold)
            toExcel.SetCellText(23, 3, "Sys No./系统号码", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(23, 4, "Pro. Code/ 编号", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(23, 10, "Unit Price/单价", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(23, 13, "Location", cellFont, Color.Black, Color.White)

            Dim rowCounter As Integer = 24

            XL.Win.Window.XLProgressBox.SetProgressRange(turnoverDtlList.Count + rowCounter, 400, False)

            Dim wareCode As String
            For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In turnoverDtlList

                cellFont = New Font("Arial", 8, FontStyle.Bold)

                toExcel.SetCellText(rowCounter, 2, CommTK.FString(bindingRow.ROW_ID), cellFont, Color.Black, Color.White)

                If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE)) = True Then
                    wareCode = bindingRow.CUSTOM_CODE
                Else
                    wareCode = bindingRow.WARE_CODE
                End If
                toExcel.SetCellText(rowCounter, 3, bindingRow.WARE_CODE, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 4, wareCode, cellFont, Color.Black, Color.White)
                toExcel.MergeCell(rowCounter, 5, rowCounter, 7)
                toExcel.SetCellText(rowCounter, 5, String.Format("{0} {1} / {2} {3} ", bindingRow.WARE_NAME, bindingRow.SPEC, bindingRow.WARE_NAME_EN, bindingRow.SPEC_EN), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 8, String.Format("{0} / {1}", bindingRow.MODEL, bindingRow.MODEL_EN), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 9, CommTK.FString(bindingRow.WARE_AMOUNT), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 10, CommTK.FString(bindingRow.UNIT_PRICE + bindingRow.UNIT_DISCOUNT, False, "#,##0.00"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 11, CommTK.FString(bindingRow.UNIT_DISCOUNT, False, "#,##0.00"), cellFont, Color.Black, Color.White, "@")
                toExcel.SetCellText(rowCounter, 12, CommTK.FString(bindingRow.SUM_PRICE, False, "#,##0.00"), cellFont, Color.Black, Color.White)
                cellFont = New Font("Arial", 7, FontStyle.Regular)
                toExcel.SetCellText(rowCounter, 13, bindingRow.REMARK, cellFont, Color.Black, Color.White)

                rowCounter += 1

                XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.WARE_CODE)

            Next

            XL.Win.Window.XLProgressBox.CloseXLProgressBox()

            toExcel.SetFrameLine(20, 2, rowCounter - 1, 12, _
                 ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Vertical Or ExcelTK.BorderPart.Horizonal, _
                 Color.Black, Excel.XlLineStyle.xlContinuous)

            toExcel.MergeCell(rowCounter, 2, rowCounter, 9)
            cellFont = New Font("Arial", 12, FontStyle.Bold)
            toExcel.SetCellText(rowCounter, 2, "*REMARKS/ 备注:", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 1, 2, rowCounter + 3, 9)
            cellFont = New Font("Arial", 9, FontStyle.Regular)
            toExcel.SetCellText(rowCounter + 1, 2, turnoverRow.REMARK, cellFont, Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 4, 2, rowCounter + 4, 9)
            toExcel.SetFrameLine(rowCounter, 2, rowCounter + 3, 9, _
                             ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right, _
                             Color.Black, Excel.XlLineStyle.xlContinuous)

            cellFont = New Font("Arial", 12, FontStyle.Bold)
            toExcel.SetCellText(rowCounter + 4, 2, "*DELIVERY DETAILS /送货细节:", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 5, 2, rowCounter + 6, 9)
            cellFont = New Font("Arial", 9, FontStyle.Regular)
            toExcel.SetCellText(rowCounter + 5, 2, turnoverRow.DELIVERY_DETAIL, cellFont, Color.Black, Color.White)

            toExcel.SetFrameLine(rowCounter + 4, 2, rowCounter + 6, 9, _
                             ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right, _
                             Color.Black, Excel.XlLineStyle.xlContinuous)

            toExcel.MergeCell(rowCounter, 10, rowCounter + 1, 11)
            cellFont = New Font("Arial", 12, FontStyle.Bold)
            toExcel.SetCellText(rowCounter, 10, "Total/ 总计: ", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(rowCounter, 12, rowCounter + 1, 12)
            toExcel.SetCellText(rowCounter, 12, CommTK.FString(turnoverRow.SUM_PRICE - turnoverRow.DELIVERY_CHARGE + turnoverRow.EXTRA_DISCOUNT, False, "#,##0.00"), New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 2, 10, rowCounter + 2, 11)
            toExcel.SetCellText(rowCounter + 2, 10, "Extra discount/额外折扣:", New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.SetCellText(rowCounter + 2, 12, CommTK.FString(turnoverRow.EXTRA_DISCOUNT, False, "#,##0.00"), New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 3, 10, rowCounter + 3, 11)
            toExcel.SetCellText(rowCounter + 3, 10, "Delivery charge/ 运费:", New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.SetCellText(rowCounter + 3, 12, CommTK.FString(turnoverRow.DELIVERY_CHARGE, False, "#,##0.00"), New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)

            toExcel.SetFrameLine(rowCounter, 10, rowCounter + 6, 12, _
                 ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Horizonal Or ExcelTK.BorderPart.Vertical, _
                 Color.Black, Excel.XlLineStyle.xlContinuous)


            toExcel.MergeCell(rowCounter + 4, 10, rowCounter + 6, 11)
            toExcel.SetCellText(rowCounter + 4, 10, "SUBTOTAL/总额:", New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 4, 12, rowCounter + 6, 12)
            toExcel.SetCellText(rowCounter + 4, 12, CommTK.FString(turnoverRow.SUM_PRICE, False, "#,##0.00"), New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.SetRowHeight(rowCounter + 8, 9)
            toExcel.MergeCell(rowCounter, 13, rowCounter + 9, 13)
            toExcel.SetFrameLine(rowCounter, 13, rowCounter + 9, 13, _
                ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right, _
                Color.Black, Excel.XlLineStyle.xlContinuous)

            toExcel.SetFrameLine(20, 2, rowCounter - 1, 12, _
                             ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Vertical Or ExcelTK.BorderPart.Horizonal, _
                             Color.Black, Excel.XlLineStyle.xlContinuous)


            toExcel.SetFrameLine(rowCounter + 8, 3, rowCounter + 8, 8, _
                             ExcelTK.BorderPart.Bottom, _
                             Color.Black, _
                             Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            toExcel.MergeCell(rowCounter + 9, 2, rowCounter + 9, 9)
            toExcel.SetCellText(rowCounter + 9, 2, " Customer signature 客人签名( Please confirm the order/请确认定单 )", New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.SetCellTextFont(rowCounter + 9, 2, 27, 30, cellFont, Color.Black)

            toExcel.SetFrameLine(rowCounter + 7, 2, rowCounter + 9, 9, _
                 ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right, _
                 Color.Black, _
                 Excel.XlLineStyle.xlContinuous)

            toExcel.MergeCell(rowCounter + 7, 10, rowCounter + 8, 11)
            toExcel.SetCellText(rowCounter + 7, 10, "DOWNPAYMENT/预付:", New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 7, 12, rowCounter + 8, 12)
            toExcel.SetCellText(rowCounter + 7, 12, CommTK.FString(turnoverRow.PAY_AMOUNT, False, "#,##0.00"), New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 9, 10, rowCounter + 9, 11)
            toExcel.SetCellText(rowCounter + 9, 10, "REMAINING/ 余额:", New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.SetCellText(rowCounter + 9, 12, CommTK.FString(turnoverRow.SUM_PRICE - turnoverRow.PAY_AMOUNT, False, "#,##0.00"), New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)

            toExcel.SetFrameLine(rowCounter + 7, 10, rowCounter + 9, 12, _
                 ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Vertical Or ExcelTK.BorderPart.Horizonal, _
                 Color.Black, _
                 Excel.XlLineStyle.xlContinuous)

            toExcel.MergeCell(rowCounter + 10, 2, rowCounter + 10, 12)
            toExcel.SetCellText(rowCounter + 10, 2, "   Terms and Conditions:", New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)

            cellFont = New Font("Arial", 8, FontStyle.Regular)
            toExcel.MergeCell(rowCounter + 11, 3, rowCounter + 11, 12)
            toExcel.SetCellText(rowCounter + 11, 3, "1. All sales are final, no exchange possible.货物一经售出,谢绝调换.", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 12, 3, rowCounter + 12, 12)
            toExcel.SetCellText(rowCounter + 12, 3, "2. Return is acceptable only if items are damaged during delivery or not received in good condition, which will be replaced by similar item.", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 13, 3, rowCounter + 13, 12)
            toExcel.SetCellText(rowCounter + 13, 3, "   如货物在运送途中遭受损坏,我们将为客户调换同类货品.", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 14, 3, rowCounter + 14, 12)
            toExcel.SetCellText(rowCounter + 14, 3, "3. Free Delivery for amount of 4000 RMB+ within Shanghai Metropolitan area only, delivery fee will be applicable for other areas. And delivery has to be done within 30 days. After 30 days, storage fee of 50RMB/CBM per day will be applicable. After 90 days goods will be taken back without refund. Delivery has to be done within 10 days during the sales period. ", cellFont, Color.Black, Color.White)
            toExcel.SetRowHeight(rowCounter + 14, 40)
            toExcel.MergeCell(rowCounter + 15, 3, rowCounter + 15, 12)
            toExcel.SetCellText(rowCounter + 15, 3, "   货款满4000元,上海市区内免费送货; 货物若送往其它地区,我们将收取相应的运输。自本定单之日起，货物只能在本公司仓库免费存储30天(减价期间只能免费存储10天）。30天后，本公司将收取您每天每立方50元的储存费。90天后您若还未接受本公司的送货，本公司将视您放弃货物，不归还任何订金/货款。", cellFont, Color.Black, Color.White)
            toExcel.SetRowHeight(rowCounter + 15, 40)
            toExcel.MergeCell(rowCounter + 16, 3, rowCounter + 16, 12)
            toExcel.SetCellText(rowCounter + 16, 3, "4. If no elevator delivery up to 3rd floor only. If goods do not fit in elevator/stairways delivery to ground floor/entrance only.", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 17, 3, rowCounter + 17, 12)
            toExcel.SetCellText(rowCounter + 17, 3, "   如果走楼梯,3楼以下(包括3楼)免费送到,超过的楼层我们将收取相应的费用.如果电梯和楼梯都不能用,客人需提前通知并自行解决.", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 18, 3, rowCounter + 18, 12)
            toExcel.SetCellText(rowCounter + 18, 3, "5. Please measure elevator, doors and stairways before purchase. We do not refund or exchange if furniture does not fit. ", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(rowCounter + 19, 3, rowCounter + 19, 12)
            toExcel.SetCellText(rowCounter + 19, 3, "   请您在购物之前，准确测量您住所的所有电梯，门和楼道等的尺寸，以确保您所购买的物品可以通过它们。若因尺寸原因，物品不能进入您住所的，本公司将不接受任何退款退货以及调换。", cellFont, Color.Black, Color.White)
            toExcel.SetRowHeight(rowCounter + 19, 30)
            toExcel.MergeCell(rowCounter + 20, 3, rowCounter + 20, 12)
            toExcel.SetCellText(rowCounter + 20, 3, "6. Full payment in advance before delivery.送货前请付清货款.", cellFont, Color.Black, Color.White)

            toExcel.SetFrameLine(rowCounter + 10, 2, rowCounter + 20, 12, _
                 ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right, _
                 Color.Black, _
                 Excel.XlLineStyle.xlContinuous)

            toExcel.AddSheet("delivery")

            toExcel.SetColumnWidth(1, 7)
            toExcel.SetColumnWidth(2, 12)
            toExcel.SetColumnWidth(3, 12)
            toExcel.SetColumnWidth(4, 11)
            toExcel.SetColumnWidth(5, 10)
            toExcel.SetColumnWidth(6, 10)
            toExcel.SetColumnWidth(7, 10)
            toExcel.SetColumnWidth(8, 7)
            toExcel.SetColumnWidth(9, 12)

            toExcel.SetRowHeight(1, 35)
            toExcel.SetRowHeight(2, 40)

            toExcel.MergeCell(2, 1, 2, 8)
            toExcel.SetCellText(2, 1, "CASA PAGODA", New Font("Verdana", 26, FontStyle.Bold), Color.Orange, Color.White)

            toExcel.SetCellText(3, 8, "Sales: ", New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.SetCellText(3, 9, shareEmployeeListBuilder.ToString, New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.SetFrameLine(3, 9, 3, 9, ExcelTK.BorderPart.Bottom, Color.Black)

            toExcel.MergeCell(4, 1, 4, 3)
            toExcel.SetCellText(4, 1, "DELIVERY SHEET: ", New Font("Arial", 10, FontStyle.Bold), Color.Black, Color.White)
            toExcel.MergeCell(4, 5, 4, 9)
            toExcel.SetCellText(4, 5, "时间： ___月___号____点至___点 ", New Font("Arial", 10, FontStyle.Regular), Color.Black, Color.White)

            cellFont = New Font("Arial", 9, FontStyle.Regular)
            toExcel.MergeCell(6, 1, 7, 1)
            toExcel.SetCellText(6, 1, "No.", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(6, 2, 7, 2)
            toExcel.SetCellText(6, 2, "Sys No. 系统号码", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(6, 3, 7, 3)
            toExcel.SetCellText(6, 3, "Pro. Code", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(6, 4, 7, 6)
            toExcel.SetCellText(6, 4, "DESCRIPTION 描述", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(6, 7, 7, 7)
            toExcel.SetCellText(6, 7, "Color 颜色", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(6, 8, 7, 8)
            toExcel.SetCellText(6, 8, "Qty 数量", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(6, 9, 7, 9)
            toExcel.SetCellText(6, 9, "Remark 备注", cellFont, Color.Black, Color.White)

            Dim deliveryRowCounter As Integer = 8

            XL.Win.Window.XLProgressBox.SetProgressRange(turnoverDtlList.Count + deliveryRowCounter, 400, False)

            Dim counter As Integer = 1

            For Each turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In turnoverDtlList

                toExcel.SetCellText(deliveryRowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(deliveryRowCounter, 2, turnoverDtlRow.WARE_CODE, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(deliveryRowCounter, 3, turnoverDtlRow.CUSTOM_CODE, cellFont, Color.Black, Color.White)
                toExcel.MergeCell(deliveryRowCounter, 4, deliveryRowCounter, 6)
                toExcel.SetCellText(deliveryRowCounter, 4, turnoverDtlRow.WARE_NAME, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(deliveryRowCounter, 7, turnoverDtlRow.MODEL, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(deliveryRowCounter, 8, CommTK.FString(turnoverDtlRow.WARE_AMOUNT), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(deliveryRowCounter, 9, turnoverDtlRow.REMARK, cellFont, Color.Black, Color.White)

                deliveryRowCounter += 1

                counter += 1

                XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, deliveryRowCounter, turnoverDtlRow.TURNOVER_CODE)

            Next

            XL.Win.Window.XLProgressBox.CloseXLProgressBox()

            toExcel.SetFrameLine(6, 1, deliveryRowCounter - 1, 9, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Horizonal Or ExcelTK.BorderPart.Vertical, Color.Black)

            Dim underLineFont As Font = New Font("Arial", 9, FontStyle.Underline)

            toExcel.MergeCell(deliveryRowCounter + 1, 1, deliveryRowCounter + 1, 2)
            toExcel.SetCellText(deliveryRowCounter + 1, 1, "CUSTOMER/名字:", underLineFont, Color.Black, Color.White)
            toExcel.MergeCell(deliveryRowCounter + 1, 3, deliveryRowCounter + 1, 5)
            toExcel.SetCellText(deliveryRowCounter + 1, 3, turnoverRow.CLIENT_NAME, underLineFont, Color.Black, Color.White)

            toExcel.MergeCell(deliveryRowCounter + 2, 1, deliveryRowCounter + 2, 2)
            toExcel.SetCellText(deliveryRowCounter + 2, 1, "DELIVERY ADDRES:", underLineFont, Color.Black, Color.White)
            toExcel.MergeCell(deliveryRowCounter + 2, 3, deliveryRowCounter + 2, 5)
            toExcel.SetCellText(deliveryRowCounter + 2, 3, turnoverRow.CLIENT_ADDRESS, underLineFont, Color.Black, Color.White)
            toExcel.MergeCell(deliveryRowCounter + 3, 1, deliveryRowCounter + 3, 2)
            toExcel.MergeCell(deliveryRowCounter + 3, 3, deliveryRowCounter + 3, 5)

            toExcel.MergeCell(deliveryRowCounter + 4, 1, deliveryRowCounter + 4, 2)
            toExcel.SetCellText(deliveryRowCounter + 4, 1, "CONTACT NUMBER:", underLineFont, Color.Black, Color.White)
            toExcel.MergeCell(deliveryRowCounter + 4, 3, deliveryRowCounter + 4, 5)
            If IsNothing(clientRow) = False Then
                toExcel.SetCellText(deliveryRowCounter + 4, 3, clientRow.CELL_PHONE, underLineFont, Color.Black, Color.White)
            End If

            toExcel.SetFrameLine(deliveryRowCounter + 1, 3, deliveryRowCounter + 1, 3, ExcelTK.BorderPart.Bottom, Color.Black)
            toExcel.SetFrameLine(deliveryRowCounter + 2, 3, deliveryRowCounter + 2, 5, ExcelTK.BorderPart.Bottom, Color.Black)
            toExcel.SetFrameLine(deliveryRowCounter + 3, 3, deliveryRowCounter + 3, 5, ExcelTK.BorderPart.Bottom, Color.Black)
            toExcel.SetFrameLine(deliveryRowCounter + 4, 3, deliveryRowCounter + 4, 5, ExcelTK.BorderPart.Bottom, Color.Black)

            toExcel.SetCellText(deliveryRowCounter + 6, 1, "Remarks:", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(deliveryRowCounter + 6, 3, deliveryRowCounter + 6, 5)
            toExcel.SetCellText(deliveryRowCounter + 6, 3, "*Receive Balance/delivery fee:", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(deliveryRowCounter + 6, 6, deliveryRowCounter + 6, 7)
            toExcel.SetCellText(deliveryRowCounter + 6, 8, "Invoice:", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(deliveryRowCounter + 6, 9, turnoverRow.TURNOVER_CODE, cellFont, Color.Black, Color.White)

            toExcel.MergeCell(deliveryRowCounter + 7, 3, deliveryRowCounter + 7, 5)
            toExcel.SetCellText(deliveryRowCounter + 7, 3, "* 收现金或运费:", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(deliveryRowCounter + 7, 6, deliveryRowCounter + 7, 7)
            toExcel.SetCellText(deliveryRowCounter + 7, 8, "发票:", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(deliveryRowCounter + 7, 9, turnoverRow.TURNOVER_CODE, cellFont, Color.Black, Color.White)

            toExcel.SetFrameLine(deliveryRowCounter + 6, 3, deliveryRowCounter + 7, 9, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Horizonal Or ExcelTK.BorderPart.Vertical, Color.Black)

            toExcel.MergeCell(deliveryRowCounter + 9, 1, deliveryRowCounter + 9, 5)
            toExcel.SetCellText(deliveryRowCounter + 9, 1, "GOODS RECEIVED IN GOOD CONDITION BY:", underLineFont, Color.Black, Color.White)

            toExcel.SetCellText(deliveryRowCounter + 11, 1, "-", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(deliveryRowCounter + 11, 2, "NAME:", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(deliveryRowCounter + 16, 1, "-", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(deliveryRowCounter + 16, 2, "SIGNATURE:", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(deliveryRowCounter + 21, 1, "-", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(deliveryRowCounter + 21, 2, "DATE:", cellFont, Color.Black, Color.White)

            toExcel.MergeCell(deliveryRowCounter + 25, 1, deliveryRowCounter + 25, 8)
            toExcel.SetCellText(deliveryRowCounter + 25, 1, "Please note return is acceptable if items are damaged during delivery or not received in good condition,", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(deliveryRowCounter + 26, 1, deliveryRowCounter + 26, 3)
            toExcel.SetCellText(deliveryRowCounter + 26, 1, "which will be replaced by similar item.", cellFont, Color.Black, Color.White)


            toExcel.AddSheet("Inform warehouse")

            toExcel.SetColumnWidth(1, 12)
            toExcel.SetColumnWidth(2, 10)
            toExcel.SetColumnWidth(3, 25)
            toExcel.SetColumnWidth(4, 8)
            toExcel.SetColumnWidth(5, 10)

            toExcel.SetRowHeight(2, 20)
            toExcel.SetRowHeight(3, 20)
            toExcel.SetRowHeight(4, 20)
            toExcel.SetRowHeight(5, 20)

            toExcel.SetCellText(1, 3, "准备通知", New Font("Verdana", 26, FontStyle.Bold), Color.Black, Color.White)

            cellFont = New Font("Arial", 9, FontStyle.Regular)

            toExcel.SetCellText(2, 1, "发票号:", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(2, 2, turnoverRow.TURNOVER_CODE, cellFont, Color.Black, Color.White)
            toExcel.SetFrameLine(2, 2, 2, 2, ExcelTK.BorderPart.Bottom, Color.Black)
            toExcel.SetCellText(2, 4, "时间:", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(2, 5, String.Format("{0:yyyy-MM-dd}", turnoverRow.TURNOVER_TIME), cellFont, Color.Black, Color.White)
            toExcel.SetFrameLine(2, 5, 2, 5, ExcelTK.BorderPart.Bottom, Color.Black)

            toExcel.SetCellText(3, 1, "预计送货时间:", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(3, 2, CommTK.FString(turnoverRow.CONSIGN_DUE_DATE, True, "yyyy-MM-dd"), cellFont, Color.Black, Color.White)
            toExcel.SetFrameLine(3, 2, 3, 2, ExcelTK.BorderPart.Bottom, Color.Black)
            toExcel.SetCellText(3, 4, "销售:", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(3, 5, shareEmployeeListBuilder.ToString, cellFont, Color.Black, Color.White)
            toExcel.SetFrameLine(3, 5, 3, 5, ExcelTK.BorderPart.Bottom, Color.Black)

            toExcel.SetCellText(4, 1, "总件数:", cellFont, Color.Black, Color.White)
            toExcel.SetFrameLine(4, 2, 4, 2, ExcelTK.BorderPart.Bottom, Color.Black)

            toExcel.SetCellText(6, 1, "No.", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(6, 2, "Sys No.系统号码", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(6, 3, "Pro. Code/ 编号", cellFont, Color.Black, Color.White)
            toExcel.MergeCell(6, 4, 6, 6)
            toExcel.SetCellText(6, 4, "DESCRIPTION/ 描述", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(6, 7, "Color/颜色", cellFont, Color.Black, Color.White)
            toExcel.SetCellText(6, 8, "QTY/数量", cellFont, Color.Black, Color.White)

            Dim warehouseRowCounter As Integer = 7

            Dim warehouseCounter As Integer = 1

            XL.Win.Window.XLProgressBox.SetProgressRange(turnoverDtlList.Count + warehouseRowCounter, 400, False)

            For Each turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In turnoverDtlList

                toExcel.SetCellText(warehouseRowCounter, 1, CommTK.FString(warehouseCounter), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(warehouseRowCounter, 2, turnoverDtlRow.WARE_CODE, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(warehouseRowCounter, 3, turnoverDtlRow.CUSTOM_CODE, cellFont, Color.Black, Color.White)
                toExcel.MergeCell(warehouseRowCounter, 4, warehouseRowCounter, 6)
                toExcel.SetCellText(warehouseRowCounter, 4, turnoverDtlRow.WARE_NAME, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(warehouseRowCounter, 7, turnoverDtlRow.MODEL, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(warehouseRowCounter, 8, CommTK.FString(turnoverDtlRow.WARE_AMOUNT), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(warehouseRowCounter, 9, turnoverDtlRow.REMARK, cellFont, Color.Black, Color.White)

                warehouseRowCounter += 1

                warehouseCounter += 1

                XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, warehouseRowCounter, turnoverDtlRow.TURNOVER_CODE)

            Next

            XL.Win.Window.XLProgressBox.CloseXLProgressBox()

            toExcel.SetFrameLine(6, 1, warehouseRowCounter - 1, 8, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Horizonal Or ExcelTK.BorderPart.Vertical, Color.Black)

            toExcel.SaveAndClose()

        End Sub

        Public Shared Sub ExportTurnover(ByVal fileName As String, ByVal turnoverID As String)


        End Sub

        Public Shared Sub ExportSLog(ByVal fileName As String, ByVal fromDate As DateTime, ByVal toDate As DateTime)

            Dim SLogConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfS_LOG(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            SLogConditions.Add( _
                MyPosXAuto.Facade.AfSysConfig.S_LOGColumns.CREATE_TIMEColumn, _
                ">=", _
                CommTK.GetBeginOfDate(fromDate))

            SLogConditions.Add( _
                MyPosXAuto.Facade.AfSysConfig.S_LOGColumns.CREATE_TIMEColumn, _
                "<=", _
                CommTK.GetBeginOfDate(toDate))

            Dim SLogList As New MyPosXAuto.FTs.FT_S_LOG
            MyPosXAuto.Facade.AfSysConfig.FillFT_S_LOG(SLogConditions, SLogList)

            If SLogList.Count = 0 Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(MyPosXService.Decls.MSG_ALERT_00022)
                Throw ex
            End If

            If IO.File.Exists(fileName) = True Then
                IO.File.Delete(fileName)
            End If

            Dim toExcel As New Utils.ExcelTK(fileName)

            Dim cellFont As Font

            toExcel.MergeCell(1, 1, 1, 4)
            toExcel.SetRowHeight(1, 35.25)

            toExcel.SetColumnWidth(1, 10)
            toExcel.SetColumnWidth(2, 15)
            toExcel.SetColumnWidth(3, 15)
            toExcel.SetColumnWidth(4, 10)

            cellFont = New Font("Arial", 16, FontStyle.Bold)
            toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("日志管理"), cellFont, Color.Black, Color.White)

            toExcel.MergeCell(3, 1, 3, 4)
            cellFont = New Font("Arial", 10, FontStyle.Bold)
            toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("日期从:") + String.Format("   {0:yyyy-MM-dd}   ", fromDate) + CommTK.GetTranslatedString("至:") + String.Format("   {0:yyyy-MM-dd}", toDate), cellFont, Color.Black, Color.White)

            toExcel.SetCellText(6, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
            toExcel.SetCellText(6, 2, CommTK.GetTranslatedString("创建时间"), cellFont, Color.Black, Color.White)
            toExcel.SetCellText(6, 3, CommTK.GetTranslatedString("创建帐号"), cellFont, Color.Black, Color.White)
            toExcel.SetCellText(6, 4, CommTK.GetTranslatedString("日志内容"), cellFont, Color.Black, Color.White)

            Dim rowCounter As Integer = 7
            Dim counter As Integer = 1

            cellFont = New Font("Arial", 10, FontStyle.Regular)

            XL.Win.Window.XLProgressBox.SetProgressRange(SLogList.Count + rowCounter, 400, False)

            For Each SLogRow As MyPosXAuto.FTs.FT_S_LOGRow In SLogList

                toExcel.SetCellText(rowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 2, String.Format("{0:yyyy-MM-dd}", SLogRow.CREATE_TIME), cellFont, Color.Black, Color.White, )
                toExcel.SetCellText(rowCounter, 3, SLogRow.CREATE_ACCOUNT, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 4, SLogRow.CONTENT, cellFont, Color.Black, Color.White)

                rowCounter += 1
                counter += 1

                XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, SLogRow.CREATE_TIME.ToString("yyyy-MM-dd HH:mm"))

            Next

            XL.Win.Window.XLProgressBox.CloseXLProgressBox()

            toExcel.SetFrameLine(6, 1, rowCounter - 1, 4, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)
            toExcel.SetFrameLine(5, 1, rowCounter - 1, 4, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

            cellFont = New Font("Arial", 10, FontStyle.Bold)

            
            If Utils.Decls.LOGIN_STAFF_ROW_SE.IsNull = False Then
                toExcel.SetCellText(rowCounter + 2, 4, Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_NAME, cellFont, Color.Black, Color.White)
            End If

            If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                toExcel.SetCellText(rowCounter + 3, 4, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
            Else
                toExcel.SetCellText(rowCounter + 3, 4, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
            End If

            toExcel.SaveAndClose()


        End Sub

#End Region

        Public Shared Function WriteSolution(ByVal solutionID As String, ByVal fileName As String) As String

            Dim validateCode As String

            Dim solutionRow As MyPosXAuto.FTs.FT_S_MP_POS_SETRow = _
                MyPosXAuto.Facade.AfBizConfig.GetS_MP_POS_SETRow(solutionID)

            If IsNothing(solutionRow) = True Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(MyPosXService.Decls.MSG_ALERT_00047)
                Throw ex
            End If

            Dim solutionDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_POS_SET_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            solutionDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", solutionID)

            Dim solutionDtlList As New MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARE
            MyPosXAuto.Facade.AfXV.FillFT_XV_S_MP_POS_SET_WARE(solutionDtlConditions, solutionDtlList)

            Dim options As New XL.Common.Utils.XmlOptions
            options.Options("SET_CODE") = solutionRow.SET_CODE
            options.Options("POS_TYPE") = CommTK.FString(solutionRow.POS_TYPE)
            options.Options("PRICE_SCALE") = CommTK.FString(solutionRow.PRICE_SCALE)
            options.Options("REMARK") = CommTK.FString(solutionRow.REMARK)
            options.Options("STAFF_SHARE_RATE") = CommTK.FString(solutionRow.STAFF_SHARE_RATE)
            Dim tempFilename As String = WinTK.GetResourceFilePath(ResourceType.TempFile, "Temp.CTB")
            solutionDtlList.SaveXml(tempFilename)
            options.Options("DETAIL_CONTENT") = CommTK.ReadTextFromFile(tempFilename, System.Text.Encoding.UTF8)
            validateCode = String.Format("{0:0}{1}{2:0}", solutionDtlList.Compute("SUM(UNIT_COST)", String.Empty), solutionDtlList.Count, solutionDtlList.Compute("SUM(UNIT_PRICE)", String.Empty))
            options.Options("VALIDATE_CODE") = Security.Encrypt(validateCode)
            options.WriteToFile(fileName)

            Return validateCode
        End Function

        Public Shared Sub PrintPractWareLabel(ByVal practBarcode As String)


            'Dim labelReport As New Reports.R_02_00801PractWareLabel01
            'labelReport.XrBarCode1.Text = practBarcode
            'labelReport.Print()

        End Sub

        Public Shared Sub ReadSolution(ByVal toSolutionID As String, ByVal fileName As String, ByVal validateCode As String)

            Dim options As New XL.Common.Utils.XmlOptions

            options.ReadFromFile(fileName)

            Dim solutionCondition As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_POS_SET(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            solutionCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SETColumns.SET_CODEColumn, "=", options.Options("SET_CODE"))
            solutionCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SETColumns.SET_IDColumn, "<>", toSolutionID)
            Dim solutionRow As MyPosXAuto.FTs.FT_S_MP_POS_SETRow = MyPosXAuto.Facade.AfBizConfig.GetS_MP_POS_SETRow(solutionCondition)

            If IsNothing(solutionRow) = False Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(CommTK.GetStringSubstituted(MyPosXService.Decls.MSG_ALERT_00049, "^", solutionRow.SET_CODE))
                Throw ex
            End If

            If validateCode <> Security.Decrypt(options.Options("VALIDATE_CODE")) Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(MyPosXService.Decls.MSG_ALERT_00048)
                Throw ex
            End If

            Dim tempFilename As String = WinTK.GetResourceFilePath(ResourceType.TempFile, "Temp.CTB")

            CommTK.WriteTextToFile(tempFilename, options.Options("DETAIL_CONTENT"), False, String.Empty)
            Dim solutionDtlList As New MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARE
            solutionDtlList.ReadXml(tempFilename)

            If validateCode <> String.Format("{0:0}{1}{2:0}", solutionDtlList.Compute("SUM(UNIT_COST)", String.Empty), solutionDtlList.Count, solutionDtlList.Compute("SUM(UNIT_PRICE)", String.Empty)) Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(MyPosXService.Decls.MSG_ALERT_00048)
                Throw ex
            End If

            MyPosXAuto.Facade.AfBizConfig.ReviseS_MP_POS_SETInfo( _
                toSolutionID, _
                CommTK.FInteger(options.Options("POS_TYPE")), _
                CommTK.FInteger(options.Options("PRICE_SCALE")), _
                options.Options("REMARK"), _
                CommTK.FBoolean(options.Options("RETAIL_OPERATOR_SALES_SHARE")), _
                options.Options("SET_CODE"), _
                CommTK.FDouble(options.Options("STAFF_SHARE_RATE")))

            Dim wareConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow
            Dim wareID As String

            Dim wareClassifyConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE_CLASSIFY(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            Dim wareClassifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow
            Dim reviseSolutionDtlRow As MyPosXAuto.FTs.FT_S_MP_POS_SET_WARERow
            Dim detailID As String
            Dim involvedDetailIDs As New ArrayList

            Dim solutionDtlConditions As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_POS_SET_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            Window.XLProgressBox.SetProgressRange(solutionDtlList.Count, 400, False)

            Dim counter As Integer = 0

            For Each solutionDtlRow As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERow In solutionDtlList

                counter += 1
                If Math.Floor(counter / 100) = Math.Ceiling(counter / 100) Then
                    Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0004, counter, solutionDtlRow.CUSTOM_CODE)
                End If
                wareConditions.Clear()
                wareConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", solutionDtlRow.WARE_CODE)
                wareRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareConditions)


                If IsNothing(wareRow) = True Then

                    wareClassifyConditions.Clear()
                    wareClassifyConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WARE_CLASSIFYColumns.WARE_CLASSIFY_CODEColumn, "=", solutionDtlRow.WARE_CLASSIFY_CODE)
                    wareClassifyRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARE_CLASSIFYRow(wareClassifyConditions)
                    wareID = Guid.NewGuid.ToString

                    If IsNothing(wareClassifyRow) = False Then

                        MyPosXAuto.Facade.AfBizMaster.CreateM_MP_WAREInfo( _
                            solutionDtlRow.ATTRIBUTE1, _
                            solutionDtlRow.ATTRIBUTE2, _
                            solutionDtlRow.ATTRIBUTE3, _
                            solutionDtlRow.ATTRIBUTE4, _
                            solutionDtlRow.CUSTOM_CODE, _
                            solutionDtlRow.GUARANTEE_DAYS, _
                            False, _
                            0, _
                            solutionDtlRow.MODEL, _
                            solutionDtlRow.MODEL_EN, _
                            solutionDtlRow.PRACT_CODE_REQUIRED, _
                            solutionDtlRow.REMARK, _
                            solutionDtlRow.SPEC, _
                            solutionDtlRow.SPEC_EN, _
                            solutionDtlRow.SUPPLIER_ID, _
                            solutionDtlRow.UNIT_COST, _
                            solutionDtlRow.UNIT_NAME, _
                            solutionDtlRow.UNIT_PRICE, _
                            wareClassifyRow.WARE_CLASSIFY_ID, _
                            solutionDtlRow.WARE_CODE, _
                            wareID, _
                            Nothing, _
                            solutionDtlRow.WARE_NAME, _
                            solutionDtlRow.WARE_NAME_EN)
                    End If


                Else
                    wareID = wareRow.WARE_ID
                End If


                If wareID.Length > 0 Then

                    solutionDtlConditions.Clear()
                    solutionDtlConditions.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", toSolutionID)
                    solutionDtlConditions.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SET_WAREColumns.WARE_IDColumn, "=", wareID)
                    reviseSolutionDtlRow = MyPosXAuto.Facade.AfBizConfig.GetS_MP_POS_SET_WARERow(solutionDtlConditions)
                    detailID = Guid.NewGuid.ToString

                    If IsNothing(reviseSolutionDtlRow) = True Then
                        MyPosXAuto.Facade.AfBizConfig.CreateS_MP_POS_SET_WAREInfo( _
                            detailID, _
                            solutionDtlRow.INDIVIDUAL_DISCOUNT, _
                            solutionDtlRow.LOWER_LIMIT, _
                            toSolutionID, _
                            solutionDtlRow.UNIT_COST, _
                            solutionDtlRow.UNIT_PRICE, _
                            wareID)

                    Else
                        MyPosXAuto.Facade.AfBizConfig.ReviseS_MP_POS_SET_WAREInfo( _
                            reviseSolutionDtlRow.DETAIL_ID, _
                            solutionDtlRow.INDIVIDUAL_DISCOUNT, _
                            solutionDtlRow.LOWER_LIMIT, _
                            toSolutionID, _
                            solutionDtlRow.UNIT_COST, _
                            solutionDtlRow.UNIT_PRICE, _
                            wareID)

                        detailID = reviseSolutionDtlRow.DETAIL_ID

                    End If

                    involvedDetailIDs.Add(detailID)

                End If
            Next

            Dim deleteDtlList As New MyPosXAuto.FTs.FT_S_MP_POS_SET_WARE
            Dim deleteDtlRow As MyPosXAuto.FTs.FT_S_MP_POS_SET_WARERow

            solutionDtlConditions.Clear()
            solutionDtlConditions.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", toSolutionID)
            MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_POS_SET_WARE(solutionDtlConditions, deleteDtlList)

            counter = 0
            For Each deleteDtlRow In deleteDtlList

                counter += 1
                Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0006, counter, String.Empty)

                If involvedDetailIDs.Contains(deleteDtlRow) = False Then

                    MyPosXAuto.Facade.AfBizConfig.DeleteS_MP_POS_SET_WAREInfo(deleteDtlRow.DETAIL_ID)
                End If

            Next

            Window.XLProgressBox.CloseXLProgressBox()

        End Sub

        Public Shared Sub InitDefaultData()


            If CommDecl.SYSTEM_IS_ONLINE = False Then
                Return
            End If

            'Try

            Dim registerVersionLevelString As String = String.Empty

            Dim serviceTK = MyPosXService.ServiceTK.GetInstance()
            serviceTK.ServInitDefaultData( _
                MyPosXService.Decls.DEFAULT_CI_VALUE_CURRENCY_TYPE_RMB, _
                MyPosXService.Decls.DEFAULT_CI_VALUE_WARE_BOM_TYPE_NONE, _
                MyPosXService.Decls.DEFAULT_CI_VALUE_CLIENT_LEVEL_DEFAULT, _
                registerVersionLevelString)

            SysInfo.RegisterVersionLevel(CType(System.Enum.Parse(GetType(XL.Common.VersionLevel), registerVersionLevelString), XL.Common.VersionLevel))

            'Catch ex As Exception

            '    Throw ex

            'End Try


        End Sub


        Public Shared Sub MakupTransferPayment_Temp()

            Dim turnoverList As New MyPosXAuto.FTs.FT_H_MP_TURNOVER
            Dim turnoverConditions As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfH_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)

            turnoverConditions.Add(MyPosXAuto.Facade.AfBizTurnover.H_MP_TURNOVERColumns.TURNOVER_STYLEColumn, "=", MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_MOVE)
            MyPosXAuto.Facade.AfBizTurnover.FillFT_H_MP_TURNOVER(turnoverConditions, turnoverList)

            Window.XLProgressBox.SetProgressRange(turnoverList.Count, 400, False)
            Dim counter As Integer = 0
            For Each turnoverRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow In turnoverList

                Window.XLProgressBox.DisplayProgress("Making up... ", counter, turnoverRow.TURNOVER_CODE)
                counter += 1
                MyPosXService.Facade.OpBizTurnover.GenerateDefaultTurnoverPayment(turnoverRow.TURNOVER_ID)
            Next
            Window.XLProgressBox.CloseXLProgressBox()


        End Sub

        Public Shared Function CalcWareSaleUnitDiscount( _
            ByVal unitPrice As Decimal, _
            ByVal teplateWareRow As MyPosXAuto.FTs.FT_XV_T_MP_SALE_TEMPLATE_WARERow) As Decimal

            Dim result As Decimal = 0

            Select Case teplateWareRow.DISCOUNT_TYPE
                Case MyPosXAuto.Decls.CIVALUE_DISCOUNT_TYPE_BY_AMOUNT
                    result = teplateWareRow.DISCOUNT_AMOUNT
                Case MyPosXAuto.Decls.CIVALUE_DISCOUNT_TYPE_BY_PERCENT
                    result = CommTK.FDecimal(teplateWareRow.DISCOUNT_AMOUNT * unitPrice / 100)
            End Select

            Return result

        End Function

        Public Shared Function DownloadCacheData() As Boolean

            Try

                If MyPosXAuto.Decls.CURRENT_DB_TYPE <> XL.DB.DBDecl.DBType.Remoting Then
                    Return True
                End If

                Try

                    MyPosXAuto.Facade.AfBizMaster.SwitchDataReadStyles(XL.DB.DBDecl.DataReadStyle.Local)
                    MyPosXAuto.Facade.AfSysConfig.SwitchDataReadStyles(XL.DB.DBDecl.DataReadStyle.Local)
                    MyPosXAuto.Facade.AfCIV.SwitchDataReadStyles(XL.DB.DBDecl.DataReadStyle.Local)
                    MyPosXAuto.Facade.AfBizManage.SwitchDataReadStyles(XL.DB.DBDecl.DataReadStyle.Local)
                    MyPosXAuto.Facade.AfMV.ReadMV_USERDataStyle = XL.DB.DBDecl.DataReadStyle.Local
                    MyPosXAuto.Facade.AfMV.ReadMV_MP_CLIENTDataStyle = XL.DB.DBDecl.DataReadStyle.Local
                    MyPosXAuto.Facade.AfXV.ReadXV_S_MP_POS_SET_WAREDataStyle = XL.DB.DBDecl.DataReadStyle.Local
                    MyPosXAuto.Facade.AfXV.ReadXV_M_MP_POSDataStyle = XL.DB.DBDecl.DataReadStyle.Local
                    MyPosXAuto.Facade.AfBizConfig.ReadS_MP_WARE_IMAGEDataStyle = XL.DB.DBDecl.DataReadStyle.Local

                    Dim sw As New Stopwatch
                    sw.Start()
                    MyPosXAuto.DataCache.DCHBizMaster.OverwriteCacheFromDB()
                    sw.Stop()
                    Console.WriteLine("DCHBizMaster.OverwriteCacheFromDB : {0:ss}", sw.Elapsed)

                    sw.Start()
                    MyPosXAuto.DataCache.DCHSysConfig.OverwriteCacheFromDB()
                    sw.Stop()
                    Console.WriteLine("DCHSysConfig.OverwriteCacheFromDB : {0:ss}", sw.Elapsed)


                    sw.Start()
                    MyPosXAuto.DataCache.DCHCIV.OverwriteCacheFromDB()
                    sw.Stop()
                    Console.WriteLine("DCHCIV.OverwriteCacheFromDB : {0:ss}", sw.Elapsed)


                    MyPosXAuto.DataCache.DCHBizManage.OverwriteCacheFromDB()
                    MyPosXAuto.DataCache.DCHMV.OverwriteMV_USERFromDB(, False)
                    MyPosXAuto.DataCache.DCHMV.OverwriteMV_MP_CLIENTFromDB(, False)
                    MyPosXAuto.DataCache.DCHXV.OverwriteXV_S_MP_POS_SET_WAREFromDB(, False)
                    MyPosXAuto.DataCache.DCHXV.OverwriteXV_M_MP_POSFromDB(, False)


                Catch ex As Exception

                    Return False
                End Try

                Return True
            Catch ex As Exception

                MyPosXAuto.Facade.AfBizMaster.SwitchDataReadStyles(XL.DB.DBDecl.DataReadStyle.Local)
                MyPosXAuto.Facade.AfCIV.SwitchDataReadStyles(XL.DB.DBDecl.DataReadStyle.Local)
            End Try

            Return True
        End Function
    End Class

End Namespace
