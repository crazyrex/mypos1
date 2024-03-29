Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade
Imports Microsoft.Office.Interop
Imports MyPosClient.Utils

Namespace Business


    Public Class B_03_00601
        Inherits XL.Win.Component.BaseAgent

#Region " 组件设计器生成的代码"

        Public Sub New(ByVal Container As System.ComponentModel.IContainer)
            MyClass.New()

            'Windows.Forms 类撰写设计器支持所必需的
            Container.Add(Me)
        End Sub

        Public Sub New()
            MyBase.New()

            '该调用是组件设计器所必需的。
            InitializeComponent()

            '在 InitializeComponent() 调用之后添加任何初始化

        End Sub


        '组件重写 dispose 以清理组件列表。
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (Components Is Nothing) Then
                    Components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        '组件设计器所必需的
        Private Components As System.ComponentModel.IContainer

        '注意: 以下过程是组件设计器所必需的
        '可以使用组件设计器修改此过程。
        '不要使用代码编辑器修改它。
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Components = New System.ComponentModel.Container
        End Sub

#End Region


#Region "Prerequested Inits"

        '
        '本代理所对应的表现层实例
        '
        Private _manifest As Manifest.M_03_00601
        Private _service As MyPosXService.S_03_00601

        Public Enum Affairs
            InitDisplay
            LoadList
            ExportSalesReport
            LoadEmployeeByCode
            LoadItemClassifyByCode
            BizUtld0005
            BizUtld0006
            BizUtld0007
            BizUtld0008
            BizUtld0009
            BizUtld0010
            BizUtld0011
            BizUtld0012
            BizUtld0013
            BizUtld0014
            BizUtld0015
            BizUtld0016
            BizUtld0017
            BizUtld0018
            BizUtld0019
            BizUtld0020
        End Enum

        Public Sub New(ByVal theManifest As XL.Win.Component.BaseForm)
            Me.New()

            Me._manifest = CType(theManifest, Manifest.M_03_00601)
            Try

                Me._service = MyPosXService.S_03_00601.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_03_00601.GetInstance()
                    Return
                End If

                Window.XLMessageBox.ShowMessage( _
                    ex.Message, _
                    Window.XLMessageBox.MessageType.Wrong, _
                    MessageBoxButtons.OK)
                Me._manifest.Enabled = False

            End Try
        End Sub


        Public ReadOnly Property AffairOf(ByVal affairObject As Object) As Affairs
            Get
                Return CType(affairObject, Affairs)
            End Get
        End Property


        Public Sub SetRequestActionTitle(ByVal action As Affairs, ByVal title As String)

            Me._requestActionTitles(action) = title
        End Sub

        Public Overloads Sub SetDisableControlUnderRequest(ByVal affair As Affairs, ByVal disabledControl As Object)

            MyBase.SetDisableControlUnderRequest(affair, disabledControl)

        End Sub

        Public Overloads Sub EnableControlsUnderRequest(ByVal affair As Affairs)

            MyBase.EnableControlsUnderRequest(affair)

        End Sub

        Public Overloads Sub DisableControlsUnderRequest(ByVal affair As Affairs)

            MyBase.DisableControlsUnderRequest(affair)

        End Sub


        Public Sub DoRequest(ByVal affair As Affairs, ByVal sychronized As Boolean)
            Dim result As New AgentResponse(affair)


            Dim operResult As String
            Dim functionHandle As XL.Win.StringFunctionTransaction = Nothing

            Select Case affair
                Case Affairs.InitDisplay

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoInitDisplay)
                Case Affairs.LoadList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadList)

                Case Affairs.ExportSalesReport

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoExportSalesReport)

                Case Affairs.LoadEmployeeByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadEmployeeByCode)

                Case Affairs.LoadItemClassifyByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadItemClassifyByCode)

                Case Affairs.BizUtld0005

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0005)

                Case Affairs.BizUtld0006

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0006)

                Case Affairs.BizUtld0007

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0007)

                Case Affairs.BizUtld0008

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0008)

                Case Affairs.BizUtld0009

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0009)

                Case Affairs.BizUtld0010

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0010)

                Case Affairs.BizUtld0011

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0011)

                Case Affairs.BizUtld0012

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0012)

                Case Affairs.BizUtld0013

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0013)

                Case Affairs.BizUtld0014

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0014)

                Case Affairs.BizUtld0015

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0015)

                Case Affairs.BizUtld0016

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0016)

                Case Affairs.BizUtld0017

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0017)

                Case Affairs.BizUtld0018

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0018)

                Case Affairs.BizUtld0019

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0019)

                Case Affairs.BizUtld0020

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0020)

            End Select

            If XL.Win.Component.BaseAgent.SYCHRONIZED_FORCED = False AndAlso sychronized = False Then

                Me.DisableControlsUnderRequest(affair)
                Me.MountRequestActionTitle(affair)
                functionHandle.BeginInvoke(New AsyncCallback(AddressOf Me.RequestCallback), affair)
                Return

            End If

            operResult = functionHandle.Invoke()

            result.SetValue(WinDecl.RVN_SUCCEED, operResult)

            Me.DoResponse(result)

        End Sub


        Public Sub RequestCallback(ByVal ar As IAsyncResult)

            Dim affair As Affairs = CType(ar.AsyncState, Affairs)
            Dim result As New AgentResponse(affair)

            Dim operResult As String

            Dim aResult As System.Runtime.Remoting.Messaging.AsyncResult = CType(ar, System.Runtime.Remoting.Messaging.AsyncResult)
            Dim functionHandle As XL.Win.StringFunctionTransaction = CType(aResult.AsyncDelegate, StringFunctionTransaction)

            operResult = functionHandle.EndInvoke(ar)

            result.SetValue(WinDecl.RVN_SUCCEED, operResult)
            Me.UnmountRequestActionTitle(affair)

            Me.DoResponse(result)

        End Sub

#End Region

#Region "Transaction Modules"
        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoInitDisplay() As String


            Try

                Dim sysWareSpecModelDiscard As Boolean
                Dim sysHideFinancials As Boolean
                Dim sysShowCustomWareCode As Boolean
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty


                Me._service.ServInitDisplay( _
                    sysWareSpecModelDiscard, _
                    sysHideFinancials, _
                    sysShowCustomWareCode, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = Me._manifest.SVFT_CHOOSE_POS_LIST.NewM_MP_POSRow
                Me._manifest.SVFT_CHOOSE_POS_LIST.AddM_MP_POSRow(posRow)
                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, Me._manifest.SVFT_CHOOSE_POS_LIST)

                posRow.POS_ID = String.Empty

                Me._manifest.LookUpEdit_Pos.Properties.DataSource = Me._manifest.SVFT_CHOOSE_POS_LIST

                Me._manifest.GridColumn_Attribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_Attribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_Attribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_Attribute4.Caption = sysAttribute4

                If sysAttribute1.Length = 0 Then
                    Me._manifest.GridColumn_Attribute1.Visible = False
                End If

                If sysAttribute2.Length = 0 Then
                    Me._manifest.GridColumn_Attribute2.Visible = False
                End If

                If sysAttribute3.Length = 0 Then
                    Me._manifest.GridColumn_Attribute3.Visible = False
                End If

                If sysAttribute4.Length = 0 Then
                    Me._manifest.GridColumn_Attribute4.Visible = False
                End If

                If sysWareSpecModelDiscard = True Then
                    Me._manifest.GridColumn_Spec.Visible = False
                    Me._manifest.GridColumn_Model.Visible = False
                End If

                If sysHideFinancials = True Then
                    Me._manifest.GridColumn_UnitCost.Visible = False
                    Me._manifest.GridColumn_UnitPrice.Visible = False
                End If

                If sysShowCustomWareCode = False Then
                    Me._manifest.GridColumn_CustomCode.Visible = False
                End If

                Dim userCostHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_COST_HIDDEN"))
                Dim userPriceHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_PRICE_HIDDEN"))

                If userCostHidden = False Then
                    Me._manifest.GridColumn_UnitCost.Visible = True
                    Me._manifest.GridColumn_TotalSumCost.Visible = True
                    Me._manifest.GridColumn_GrossProfit.Visible = True
                Else
                    Me._manifest.GridColumn_UnitCost.Visible = False
                    Me._manifest.GridColumn_TotalSumCost.Visible = False
                    Me._manifest.GridColumn_GrossProfit.Visible = False
                End If

                If userPriceHidden = False Then
                    Me._manifest.GridColumn_UnitPrice.Visible = True
                Else
                    Me._manifest.GridColumn_UnitPrice.Visible = False
                End If


            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoLoadList() As String


            Try

                Dim salesConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_SALES_REPORT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                salesConditions.Add(AfMV.MV_MP_SALES_REPORTColumns.TURNOVER_TIMEColumn, ">=", CommTK.GetBeginOfDate(Me._manifest.DateEdit_FromDate.DateTime))
                salesConditions.Add(AfMV.MV_MP_SALES_REPORTColumns.TURNOVER_TIMEColumn, "<=", CommTK.GetEndOfDate(Me._manifest.DateEdit_ToDate.DateTime))

                If CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue).Length > 0 Then
                    salesConditions.Add(AfMV.MV_MP_SALES_REPORTColumns.POS_IDColumn, "=", CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue))
                End If

                If Me._manifest.Label_ItemClassifyID.Text.Length > 0 Then
                    salesConditions.Add(AfMV.MV_MP_SALES_REPORTColumns.WARE_CLASSIFY_IDColumn, "=", Me._manifest.Label_ItemClassifyID.Text)
                End If

                If Me._manifest.Label_EmployeeID.Text.Length > 0 Then
                    Dim turnoverShareDtlCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_SHARE_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                    turnoverShareDtlCondition.Add(AfXV.XV_H_MP_TURNOVER_SHARE_DTLColumns.SHARE_STAFF__STAFF_IDColumn, "=", Me._manifest.Label_EmployeeID.Text)
                    Dim turnoverIDs = MyPosXAuto.Facade.AfXV.GetXV_H_MP_TURNOVER_SHARE_DTL_CVListDistinct(turnoverShareDtlCondition, AfXV.XV_H_MP_TURNOVER_SHARE_DTLColumns.TURNOVER_IDColumn)
                    salesConditions.Add(AfMV.MV_MP_SALES_REPORTColumns.TURNOVER_IDColumn, True, turnoverIDs)
                End If

                Me._manifest.SVFT_BINDING_SALES_REPORT_LIST.Clear()
                MyPosXAuto.Facade.AfMV.FillFT_MV_MP_SALES_REPORT( _
                    salesConditions, Me._manifest.SVFT_BINDING_SALES_REPORT_LIST, _
                    MyPosXAuto.Facade.AfMV.MV_MP_SALES_REPORTColumns.TURNOVER_TIMEColumn, _
                    MyPosXAuto.Facade.AfMV.MV_MP_SALES_REPORTColumns.TURNOVER_CODEColumn)

                Me._manifest.GridControl_Sales.DataSource = Me._manifest.SVFT_BINDING_SALES_REPORT_LIST

            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoExportSalesReport() As String


            Try


                If IO.Path.GetExtension(Me._manifest.SV_EXCEL_FILENAME).ToUpper <> "XLS" AndAlso _
                    IO.Path.GetExtension(Me._manifest.SV_EXCEL_FILENAME).ToUpper <> "XLSX" Then
                    Me._manifest.SV_EXCEL_FILENAME = String.Format("{0}.xls", Me._manifest.SV_EXCEL_FILENAME)
                End If

                If IO.File.Exists(Me._manifest.SV_EXCEL_FILENAME) = True Then
                    IO.File.Delete(Me._manifest.SV_EXCEL_FILENAME)
                End If

                Dim toExcel As New Utils.ExcelTK(Me._manifest.SV_EXCEL_FILENAME)
                Dim cellFont As Font

                Dim userCostHidden = CommTK.FBoolean(SysInfo.LoginUserOptions.Options(Utils.UserOptionsBox.OPN_COST_HIDDEN))

                toExcel.MergeCell(1, 1, 1, 9)
                toExcel.SetRowHeight(1, 35.25)

                cellFont = New Font("Arial", 16, FontStyle.Bold)
                toExcel.SetCellText(1, 1, "Sales Report", cellFont, Color.Black, Color.White)

                cellFont = New Font("Arial", 12, FontStyle.Bold)
                toExcel.MergeCell(3, 1, 3, 9)
                toExcel.SetCellText(3, 1, String.Format("{0:yyyy-MM-dd} - {1:yyyy-MM-dd}", Me._manifest.DateEdit_FromDate.DateTime, Me._manifest.DateEdit_ToDate.DateTime), cellFont, Color.Black, Color.White)

                toExcel.SetColumnWidth(1, 5)
                toExcel.SetColumnWidth(2, 25)
                toExcel.SetColumnWidth(3, 10)
                toExcel.SetColumnWidth(4, 5)
                toExcel.SetColumnWidth(5, 10)
                toExcel.SetColumnWidth(6, 12)
                toExcel.SetColumnWidth(7, 7)
                toExcel.SetColumnWidth(8, 7)
                toExcel.SetColumnWidth(9, 7)
                toExcel.SetColumnWidth(10, 7)
                toExcel.SetColumnWidth(11, 7)
                toExcel.SetColumnWidth(12, 7)
                toExcel.SetColumnWidth(13, 7)
                toExcel.SetColumnWidth(14, 7)
                toExcel.SetColumnWidth(15, 10)
                toExcel.SetColumnWidth(16, 10)
                toExcel.SetColumnWidth(17, 7)
                toExcel.SetColumnWidth(18, 7)
                toExcel.SetColumnWidth(19, 7)
                toExcel.SetColumnWidth(20, 7)
                toExcel.SetColumnWidth(21, 7)
                toExcel.SetColumnWidth(22, 7)
                toExcel.SetColumnWidth(23, 7)
                toExcel.SetColumnWidth(24, 10)
                toExcel.SetColumnWidth(25, 15)
                toExcel.SetColumnWidth(26, 15)

                toExcel.MergeCell(5, 1, 6, 1)
                toExcel.MergeCell(5, 2, 6, 2)
                toExcel.MergeCell(5, 3, 6, 3)
                toExcel.MergeCell(5, 4, 6, 4)
                toExcel.MergeCell(5, 5, 6, 5)
                toExcel.MergeCell(5, 6, 6, 6)
                toExcel.MergeCell(5, 7, 6, 7)
                toExcel.MergeCell(5, 8, 6, 8)
                toExcel.MergeCell(5, 9, 6, 9)
                toExcel.MergeCell(5, 10, 6, 10)
                toExcel.MergeCell(5, 11, 6, 11)
                toExcel.MergeCell(5, 12, 6, 12)
                toExcel.MergeCell(5, 13, 6, 13)
                toExcel.MergeCell(5, 14, 6, 14)
                toExcel.MergeCell(5, 15, 6, 15)
                toExcel.MergeCell(5, 16, 6, 16)
                toExcel.MergeCell(5, 17, 6, 17)
                toExcel.MergeCell(5, 18, 5, 21)
                toExcel.MergeCell(5, 22, 6, 22)
                toExcel.MergeCell(5, 23, 6, 23)
                toExcel.MergeCell(5, 24, 6, 24)
                toExcel.MergeCell(5, 25, 6, 25)
                toExcel.MergeCell(5, 26, 6, 26)
                cellFont = New Font("Arial", 10, FontStyle.Bold)

                toExcel.SetCellText(5, 1, "No./序号", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 2, "CIN/订单号", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 3, "DATE/日期", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 4, "Item No./号码", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 5, "Barcode /条码", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 6, "Pro. Code/货号", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 7, "Description/描述", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 8, "Qty./数量", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 9, "Ori. Price/原价", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 10, "Unit Price/出货价", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 11, "Discount/折扣", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 12, "Price Amounts /出货总价", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 13, "E.D./额外折扣", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 14, "Total/收款总额", cellFont, Color.Black, Color.White)

                toExcel.SetCellText(5, 15, "Unit cost /成本单价", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 16, "Cost Amounts /总成本", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 17, "Gross Profit /毛利", cellFont, Color.Black, Color.White)

                toExcel.SetCellText(5, 18, "Delivery fee /运费", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 19, "Down payment　订金", cellFont, Color.Black, Color.White)

                toExcel.SetCellText(6, 19, "CC (拉卡)", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(6, 20, "CASH (现金)", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(6, 21, "TT (电汇)", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(6, 22, "其它", cellFont, Color.Black, Color.White)

                toExcel.SetCellText(5, 23, "Remaining/余额", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 24, "Formal Invoice/发票", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 25, "Sales/销售", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 26, "Commission/提成", cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 27, "Remarks/备注", cellFont, Color.Black, Color.White)

                If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE)) = False Then
                    toExcel.SetColumnWidth(6, 0)
                End If

                cellFont = New Font("Arial", 10, FontStyle.Regular)

                Dim rowCounter As Integer = 7
                Dim turnoverNO As Integer = 0
                Dim prevTurnoverID As String = String.Empty
                Dim itemNO As Integer = 1
                Dim turnoverBeginRows As New Hashtable
                Dim turnoverBeginRowIndexes As New ArrayList

                Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow
                Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_SALES_REPORT_LIST.Count + rowCounter, 400, False)
                Dim wareCode As String
                Dim shareEmployeeListBuilder As New LineStrBuilder

                For Each salesRow As MyPosXAuto.FTs.FT_MV_MP_SALES_REPORTRow In Me._manifest.SVFT_BINDING_SALES_REPORT_LIST


                    If prevTurnoverID <> salesRow.TURNOVER_ID Then
                        prevTurnoverID = salesRow.TURNOVER_ID
                        turnoverBeginRows.Add(prevTurnoverID, rowCounter)
                        turnoverBeginRowIndexes.Add(prevTurnoverID)
                        turnoverNO += 1
                        itemNO = 0
                    End If

                    itemNO += 1

                    If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE)) = True Then
                        wareCode = salesRow.CUSTOM_CODE
                    Else
                        wareCode = salesRow.WARE_CODE
                    End If

                    wareCondition.Clear()
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", salesRow.WARE_CODE)
                    wareRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareCondition)

                    shareEmployeeListBuilder.Clear()
                    Dim sareDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_SHARE_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                    sareDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_SHARE_DTLColumns.TURNOVER_IDColumn, "=", salesRow.TURNOVER_ID)
                    Dim shareEmployees As ArrayList = MyPosXAuto.Facade.AfXV.GetXV_H_MP_TURNOVER_SHARE_DTL_CVListDistinct(sareDtlConditions, MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_SHARE_DTLColumns.SHARE_STAFF__STAFF_NAMEColumn)
                    For Each shareEmployee As String In shareEmployees
                        shareEmployeeListBuilder.AppendFormat("{0},", shareEmployee)
                    Next
                    If shareEmployeeListBuilder.Length > 0 Then
                        shareEmployeeListBuilder.Remove(shareEmployeeListBuilder.Length - 1, 1)
                    End If

                    salesRow.SALES = shareEmployeeListBuilder.ToString

                    salesRow.INVOICE = salesRow.TURNOVER_CODE.Substring(salesRow.TURNOVER_CODE.Length - 5, 5)

                    toExcel.SetCellText(rowCounter, 1, CommTK.FString(turnoverNO), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 2, salesRow.TURNOVER_CODE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 3, CommTK.FString(salesRow.TURNOVER_TIME), cellFont, Color.Black, Color.White, "yyyy-mm-dd")
                    toExcel.SetCellText(rowCounter, 4, CommTK.FString(itemNO), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 5, salesRow.WARE_CODE, cellFont, Color.Black, Color.White, "@")
                    toExcel.SetCellText(rowCounter, 6, wareCode, cellFont, Color.Black, Color.White, "@")
                    toExcel.SetCellText(rowCounter, 7, String.Format("{0} {1} / {2} {3} ", wareRow.WARE_NAME, wareRow.SPEC, wareRow.WARE_NAME_EN, wareRow.SPEC_EN), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 8, CommTK.FString(salesRow.WARE_AMOUNT), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 9, CommTK.FString(salesRow.ORIGION_UNIT_PRICE), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                    toExcel.SetCellText(rowCounter, 10, CommTK.FString(salesRow.UNIT_PRICE), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                    toExcel.SetCellText(rowCounter, 11, String.Format("{0:#,##0.00}({1:#.##}%)", salesRow.UNIT_DISCOUNT, salesRow.UNIT_DISCOUNT_PERCENT), cellFont, Color.Black, Color.White, "#,##0_ ")
                    toExcel.SetCellText(rowCounter, 12, CommTK.FString(salesRow.SUM_PRICE), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                    toExcel.SetCellText(rowCounter, 13, CommTK.FString(salesRow.EXTRA_DISCOUNT), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                    toExcel.SetCellText(rowCounter, 14, CommTK.FString(salesRow.TOTAL), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                    If userCostHidden = False Then
                        toExcel.SetCellText(rowCounter, 15, CommTK.FString(salesRow.UNIT_COST), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                        toExcel.SetCellText(rowCounter, 16, CommTK.FString(salesRow.SUM_COST), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                        toExcel.SetCellText(rowCounter, 17, CommTK.FString(salesRow.GROSS_PROFIT), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                    End If
                    If Me._manifest.CheckEdit_ExcelIncludeSalesRelated.Checked = True Then
                        toExcel.SetCellText(rowCounter, 18, CommTK.FString(salesRow.DELIVERY_CHARGE), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                        toExcel.SetCellText(rowCounter, 19, CommTK.FString(salesRow.CREDIT_CARD_AMOUNT), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                        toExcel.SetCellText(rowCounter, 20, CommTK.FString(salesRow.CASH_AMOUNT), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                        toExcel.SetCellText(rowCounter, 21, CommTK.FString(salesRow.TELE_TRANSPORT_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 22, CommTK.FString(salesRow.OTHER_AMOUNT), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                        toExcel.SetCellText(rowCounter, 23, CommTK.FString(salesRow.REMAINING), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                        toExcel.SetCellText(rowCounter, 24, salesRow.INVOICE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 25, salesRow.SALES, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 26, CommTK.FString(salesRow.COMMISSION), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                        toExcel.SetCellText(rowCounter, 27, CommTK.FString(salesRow.REMARK), cellFont, Color.Black, Color.White, "#,##0.00_ ")
                    End If

                    XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, salesRow.TURNOVER_CODE)
                    rowCounter += 1


                Next

                XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                Dim row As Integer
                Dim prevRow As Integer = 0
                For Each turnoverID As String In turnoverBeginRowIndexes

                    row = CommTK.FInteger(turnoverBeginRows(turnoverID))
                    If prevRow > 0 Then

                        toExcel.ClearRegion(prevRow + 1, 1, row - 1, 3)
                        toExcel.MergeCell(prevRow, 1, row - 1, 1)
                        toExcel.MergeCell(prevRow, 2, row - 1, 2)
                        toExcel.MergeCell(prevRow, 3, row - 1, 3)

                        toExcel.ClearRegion(prevRow + 1, 13, row - 1, 14)
                        toExcel.MergeCell(prevRow, 13, row - 1, 13)
                        toExcel.MergeCell(prevRow, 14, row - 1, 14)

                        toExcel.ClearRegion(prevRow + 1, 17, row - 1, 26)
                        toExcel.MergeCell(prevRow, 17, row - 1, 17)
                        toExcel.MergeCell(prevRow, 18, row - 1, 18)
                        toExcel.MergeCell(prevRow, 19, row - 1, 19)
                        toExcel.MergeCell(prevRow, 20, row - 1, 20)
                        toExcel.MergeCell(prevRow, 21, row - 1, 21)
                        toExcel.MergeCell(prevRow, 22, row - 1, 22)
                        toExcel.MergeCell(prevRow, 23, row - 1, 23)
                        toExcel.MergeCell(prevRow, 24, row - 1, 24)
                        toExcel.MergeCell(prevRow, 25, row - 1, 25)
                        toExcel.MergeCell(prevRow, 26, row - 1, 26)
                        toExcel.MergeCell(prevRow, 27, row - 1, 27)

                    End If
                    prevRow = row

                Next



                If prevRow < rowCounter - 1 Then
                    toExcel.ClearRegion(prevRow + 1, 1, rowCounter - 1, 3)
                End If
                toExcel.MergeCell(prevRow, 1, rowCounter - 1, 1)
                toExcel.MergeCell(prevRow, 2, rowCounter - 1, 2)
                toExcel.MergeCell(prevRow, 3, rowCounter - 1, 3)

                If prevRow < rowCounter - 1 Then
                    'toExcel.ClearRegion(prevRow + 1, 1, rowCounter - 1, 3)
                    toExcel.ClearRegion(prevRow + 1, 13, rowCounter - 1, 14)
                End If
                toExcel.MergeCell(prevRow, 13, rowCounter - 1, 13)
                toExcel.MergeCell(prevRow, 14, rowCounter - 1, 14)

                If prevRow < rowCounter - 1 Then
                    toExcel.ClearRegion(prevRow + 1, 17, rowCounter - 1, 27)
                End If
                toExcel.MergeCell(prevRow, 17, rowCounter - 1, 17)
                toExcel.MergeCell(prevRow, 18, rowCounter - 1, 18)
                toExcel.MergeCell(prevRow, 19, rowCounter - 1, 19)
                toExcel.MergeCell(prevRow, 20, rowCounter - 1, 20)
                toExcel.MergeCell(prevRow, 21, rowCounter - 1, 21)
                toExcel.MergeCell(prevRow, 22, rowCounter - 1, 22)
                toExcel.MergeCell(prevRow, 23, rowCounter - 1, 23)
                toExcel.MergeCell(prevRow, 24, rowCounter - 1, 24)
                toExcel.MergeCell(prevRow, 25, rowCounter - 1, 25)
                toExcel.MergeCell(prevRow, 26, rowCounter - 1, 26)
                toExcel.MergeCell(prevRow, 27, rowCounter - 1, 27)

                'toExcel.FreezeColumn(2)

                toExcel.SetFrameLine(5, 1, rowCounter - 1, 27, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or Utils.ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right Or ExcelTK.BorderPart.Horizonal Or ExcelTK.BorderPart.Vertical, Color.Black, Excel.XlLineStyle.xlContinuous)
                toExcel.SetFrameLine(7, 1, rowCounter - 1, 27, ExcelTK.BorderPart.Horizonal, Color.Black, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlHairline)
                toExcel.SetFrameLine(5, 1, rowCounter - 1, 27, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Left Or ExcelTK.BorderPart.Right, Color.Black, , Excel.XlBorderWeight.xlThick)

                toExcel.SetCellText(rowCounter + 2, 27, Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_NAME, cellFont, Color.Black, Color.White)
                
                If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                    toExcel.SetCellText(rowCounter + 3, 27, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                Else
                    toExcel.SetCellText(rowCounter + 3, 27, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
                End If

                If userCostHidden = True Then
                    toExcel.SetColumnWidth(15, 0)
                    toExcel.SetColumnWidth(16, 0)
                    toExcel.SetColumnWidth(17, 0)
                End If

                If Me._manifest.CheckEdit_ExcelIncludeSalesRelated.Checked = False Then
                    toExcel.SetColumnWidth(18, 0)
                    toExcel.SetColumnWidth(19, 0)
                    toExcel.SetColumnWidth(20, 0)
                    toExcel.SetColumnWidth(21, 0)
                    toExcel.SetColumnWidth(22, 0)
                    toExcel.SetColumnWidth(23, 0)
                    toExcel.SetColumnWidth(24, 0)
                    toExcel.SetColumnWidth(25, 0)
                    toExcel.SetColumnWidth(26, 0)
                    toExcel.SetColumnWidth(27, 0)
                End If

                toExcel.SaveAndClose()




            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoLoadEmployeeByCode() As String


            Try

                If Me._manifest.ButtonEdit_EmployeeCode.Text.Trim.Length > 0 Then

                    Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity
                    Dim servResult As String = _
                        Me._service.ServLoadEmployeeByCode( _
                            Me._manifest.ButtonEdit_EmployeeCode.Text.Trim, _
                            staffRowSE)

                    If servResult.Length > 0 Then
                        Return servResult
                    End If

                    Me._manifest.ButtonEdit_EmployeeCode.Text = staffRowSE.STAFF_CODE
                    Me._manifest.Label_EmployeeName.Text = staffRowSE.STAFF_NAME
                    Me._manifest.Label_EmployeeID.Text = staffRowSE.STAFF_ID

                End If




            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoLoadItemClassifyByCode() As String


            Try

                If Me._manifest.ButtonEdit_ItemClassifyCode.Text.Trim.Length > 0 Then

                    Dim itemClassifyRowSE As New MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRowSEntity
                    Dim servResult As String = _
                        Me._service.ServLoadItemClassifyByCode( _
                            Me._manifest.ButtonEdit_ItemClassifyCode.Text.Trim, _
                            itemClassifyRowSE)

                    If servResult.Length > 0 Then
                        Return servResult
                    End If

                    Me._manifest.ButtonEdit_ItemClassifyCode.Text = itemClassifyRowSE.WARE_CLASSIFY_CODE
                    Me._manifest.Label_ItemClassifyName.Text = itemClassifyRowSE.WARE_CLASSIFY_NAME
                    Me._manifest.Label_ItemClassifyID.Text = itemClassifyRowSE.WARE_CLASSIFY_ID

                End If



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0005() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0006() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0007() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0008() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0009() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0010() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0011() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0012() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0013() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0014() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0015() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0016() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0017() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0018() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0019() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

        '''Function remark:
        '''
        '''
        '''-------------------------------------------------------------------
        Private Function DoBizUtld0020() As String


            Try



            Catch ex As XL.Common.Utils.XLException

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

                Return ex.Message

            Catch ex As Exception

                Dim logContentBuilder As New LineStrBuilder
                logContentBuilder.AppendLine("Message: {0}", ex.Message)
                logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

                WinTK.OutputLog("Exception occured", logContentBuilder.ToString())

                XL.Win.Window.XLMessageBox.UseSmallFont = True
                Return ex.Message & vbNewLine & ex.StackTrace.ToString()

            End Try

            Return String.Empty

        End Function

#End Region


    End Class

End Namespace
