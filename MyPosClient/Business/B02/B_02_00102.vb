Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade

Namespace Business


    Public Class B_02_00102
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
        Private _manifest As Manifest.M_02_00102
        Private _service As MyPosXService.S_02_00102

        Public Enum Affairs
            InitDisplay
            PrintPurchaseList
            RemoveInfo
            LoadEmployeeByCode
            SaveInfo
            LoadInfo
            LoadWareByCode
            PrintBatchLabel
            ValidateAvailableAmount
            UpdateCurrentAmount
            BizUtld0005
            LoadCustomerByCode
            LoadSupplierByCode
            GenerateDefaultConsignAndPayment
            CalculateExtraDiscount
            NewList
            UpdateCalculation
            NewCustomer
            ExportExcel
            ImportFromMobile
            LoadCommissionRate
        End Enum

        Public Sub New(ByVal theManifest As XL.Win.Component.BaseForm)
            Me.New()

            Me._manifest = CType(theManifest, Manifest.M_02_00102)

            Try

                Me._service = MyPosXService.S_02_00102.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_02_00102.GetInstance()
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

                Case Affairs.PrintPurchaseList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoPrintPurchaseList)

                Case Affairs.RemoveInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoRemoveInfo)

                Case Affairs.LoadEmployeeByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadEmployeeByCode)

                Case Affairs.SaveInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSaveInfo)

                Case Affairs.LoadInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadInfo)

                Case Affairs.LoadWareByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadWareByCode)

                Case Affairs.PrintBatchLabel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoPrintBatchLabel)

                Case Affairs.ValidateAvailableAmount

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoValidateAvailableAmount)

                Case Affairs.UpdateCurrentAmount

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoUpdateCurrentAmount)

                Case Affairs.BizUtld0005

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0005)

                Case Affairs.LoadCustomerByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadCustomerByCode)

                Case Affairs.LoadSupplierByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadSupplierByCode)

                Case Affairs.GenerateDefaultConsignAndPayment

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoGenerateDefaultConsignAndPayment)

                Case Affairs.CalculateExtraDiscount

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoCalculateExtraDiscount)

                Case Affairs.NewList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoNewList)

                Case Affairs.UpdateCalculation

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoUpdateCalculation)

                Case Affairs.NewCustomer

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoNewCustomer)

                Case Affairs.ExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoExportExcel)

                Case Affairs.ImportFromMobile

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoImportFromMobile)

                Case Affairs.LoadCommissionRate

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadCommissionRate)

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

                Dim choosePosList As New MyPosXAuto.FTs.FT_M_MP_POS
                Me._manifest.SVFT_CHOOSE_TURNOVER_BOOK_STATUS_LIST.Clear()
                Me._manifest.SVFT_CHOOSE_TURNOVER_STYLE_LIST.Clear()

                Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity

                Dim sysWareSpecModelDiscard As Boolean
                Dim sysHideFinancials As Boolean
                Dim sysShowCustomWareCode As Boolean
                Dim sysWareArriveConfirm As Boolean
                Dim sysClientCreatingAllowed As Boolean

                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Dim wareBatchPrefix As String = String.Empty

                Me._service.ServInitDisplay( _
                    CommDecl.CURRENT_LANGUAGE_OPTION, _
                    Me._manifest.LAUNCH_CONDITION, _
                    Me._manifest.SVLM_EDITING_TURNOVER_STYLE, _
                    Me._manifest.SV_WARE_TURNOVER_MODE, _
                    Me._manifest.SVFT_CHOOSE_TURNOVER_STYLE_LIST, _
                    Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID, _
                    wareBatchPrefix, _
                    staffRowSE, _
                    sysWareSpecModelDiscard, _
                    sysHideFinancials, _
                    sysShowCustomWareCode, _
                    sysWareArriveConfirm, _
                    sysClientCreatingAllowed, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                If Me._manifest.LAUNCH_CONDITION = MyPosXService.S_02_00102.LCs.Deposit Then
                    Me._manifest.SVLM_TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN
                ElseIf Me._manifest.LAUNCH_CONDITION = MyPosXService.S_02_00102.LCs.Withdraw Then
                    Me._manifest.SVLM_TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_IO_TYPE_OUT
                End If

                'Dim staffRow As MyPosXAuto.FTs.FT_M_STAFFRow = _
                '    MyPosXAuto.Facade.AfBasicMaster.GetM_STAFFRow(Utils.Decls.LOGIN_STAFF_ID)

                If staffRowSE.IsNull = False Then
                    Me._manifest.ButtonEdit_EmployeeCode.Text = staffRowSE.STAFF_CODE
                    Me._manifest.Label_EmployeeName.Text = staffRowSE.STAFF_NAME
                    Me._manifest.Label_EmployeeID.Text = CommTK.FString(staffRowSE.STAFF_ID)
                End If

                Me._manifest.DateEdit_DepositTime.DateTime = CommTK.GetSyncServerTime

                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, choosePosList)
                Me._manifest.LookUpEdit_Pos.Properties.DataSource = choosePosList

                If Me._manifest.SV_EDITING_TURNOVER_ID.Length <= 0 Then

                    If IsNothing(Utils.Decls.CURRENT_POS_ROW) = True Then
                        Me._manifest.GroupControl_Turnover.Enabled = False
                        Me._manifest.GroupControl_Details.Enabled = False
                        Return MyPosXService.Decls.MSG_ALERT_00054
                    End If

                    Me._manifest.LookUpEdit_Pos.EditValue = Utils.Decls.CURRENT_POS_ROW.POS_ID
                    Me._manifest.GridColumn_CurrentAmount.Visible = True
                    Me.DoLoadCommissionRate()
                Else
                    Me._manifest.GridColumn_CurrentAmount.Visible = False
                End If

                If Me._manifest.SV_WARE_TURNOVER_MODE = MyPosXService.Decls.WARE_TURNOVER_MODE_BATCH AndAlso _
                    wareBatchPrefix.Trim.Length = 0 Then

                    Me._manifest.ToolStripButton_Add.Enabled = False
                    Window.XLMessageBox.ShowMessage(MyPosXService.Decls.MSG_ALERT_00033, Window.XLMessageBox.MessageType.Warning, MessageBoxButtons.OK)

                End If

                '=================
                MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_BOOK_STATUSList(CommDecl.CURRENT_LANGUAGE_OPTION, String.Empty, Me._manifest.SVFT_CHOOSE_TURNOVER_BOOK_STATUS_LIST, False)

                Me._manifest.RepositoryItemLookUpEdit_TurnoverBookStatus.DataSource = Me._manifest.SVFT_CHOOSE_TURNOVER_BOOK_STATUS_LIST
                Me._manifest.LookUpEdit_TurnoverStyle.EditValue = Me._manifest.SVLM_EDITING_TURNOVER_STYLE
                Me._manifest.LookUpEdit_TurnoverStyle.Properties.DataSource = Me._manifest.SVFT_CHOOSE_TURNOVER_STYLE_LIST


                If sysWareArriveConfirm = False Then
                    Me._manifest.GridColumn_TurnoverBookStatus.Visible = False
                    Me._manifest.ToolStripButton_ConsignLog.Visible = False
                End If

                If Me._manifest.SV_WARE_TURNOVER_MODE = MyPosXService.Decls.WARE_TURNOVER_MODE_NORMAL Then
                    Me._manifest.GridColumn_BatchCode.Visible = False
                End If

                Me._manifest.SV_NEW_CLIENT_SHORT_CUT_ALLOWED = sysClientCreatingAllowed

                If CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_PRINT_SHOPPING_LIST)) = True AndAlso _
                    Me._manifest.SVLM_TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN Then
                    Me._manifest.ToolStripButton_PrintPurchaseLabel.Visible = False
                End If

                If sysHideFinancials = True Then
                    Me._manifest.Panel_FinancialPart.Visible = False
                    Me._manifest.ToolStripButton_ShareDtl.Visible = False
                    Me._manifest.ToolStripButton_PayLog.Visible = False
                    Me._manifest.GridColumn_UnitCost.Visible = False
                    Me._manifest.GridColumn_UnitPrice.Visible = False
                    Me._manifest.GridColumn_SumPrice.Visible = False
                    Me._manifest.Label_DeliveryCharge.Visible = False
                    Me._manifest.CalcEdit_DeliveryCharge.Visible = False
                End If

                If CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_SHOW_DELIVERY_FIELDS_IN_TURNOVER)) = False Then
                    Me._manifest.Panel_Delivery.Visible = False
                End If

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

                If sysShowCustomWareCode = False Then
                    Me._manifest.GridColumn_CustomCode.Visible = False
                End If

                Dim userCostHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_COST_HIDDEN"))
                Dim userPriceHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_PRICE_HIDDEN"))
                Dim userFinacialForbiddened As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_FINANCIAL_FORBIDDENED"))

                If userCostHidden = True Then
                    Me._manifest.GridColumn_UnitCost.Visible = False
                End If

                If userPriceHidden = True Then
                    Me._manifest.GridColumn_UnitPrice.Visible = False
                    Me._manifest.GridColumn_SumPrice.Visible = False
                    Me._manifest.Panel_FinancialPart.Visible = False
                End If

                If userFinacialForbiddened = True Then
                    Me._manifest.ToolStripButton_PayLog.Visible = False
                    Me._manifest.ToolStripButton_ShareDtl.Visible = False
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
        Private Function DoPrintPurchaseList() As String


            Try

                Dim companyTitle As String = String.Empty
                Dim serviceTel As String = String.Empty
                Dim turnoverDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL

                Me._service.ServPrintPurchaseList( _
                    CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue), _
                    companyTitle, _
                    serviceTel, _
                    Me._manifest.SV_EDITING_TURNOVER_ID, _
                     turnoverDtlList)

                If CommTK.FInteger(Me._manifest.LookUpEdit_TurnoverStyle.EditValue) <> MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_SOLD OrElse _
                    CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_PRINT_SHOPPING_LIST)) = False Then
                    Return String.Empty
                End If

                Dim littleListReport As New Reports.R_02_00102LittleList_05

                littleListReport.XrLabel_DepositTime.Text = String.Format("{0:yyyy/MM/dd HH:mm}", Me._manifest.DateEdit_DepositTime.DateTime)
                littleListReport.XrLabel_Pos.Text = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_COMPANY_TITLE)
                littleListReport.XrLabel_NEmployee.Text = CommTK.GetTranslatedString("操作员:")
                littleListReport.XrLabel_Employee.Text = Me._manifest.Label_EmployeeName.Text
                littleListReport.XrLabel_TurnoverCode.Text = Me._manifest.TextEdit_TurnoverCode.Text


                littleListReport.XrLabel_NTel.Text = CommTK.GetTranslatedString("服务热线:")
                littleListReport.XrLabel_ServiceTel.Text = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SERVICE_TEL)
                'littleListReport.XrLabel_Address.Text = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_COMPANY_ADDRESS)
                littleListReport.XrLabel_CompanyTitle.Text = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_COMPANY_TITLE)

                littleListReport.DataSource = turnoverDtlList.ReportBindList
                littleListReport.CreateDataBindings()
                littleListReport.XrLabel_TotalAmount.Text = CommTK.FString(turnoverDtlList.Compute("sum(WARE_AMOUNT)", String.Empty))
                littleListReport.XrLabel_TotalMoney.Text = String.Format("{0:0.00}", turnoverDtlList.Compute("sum(SUM_PRICE)", String.Empty))
                littleListReport.Print()



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
        Private Function DoRemoveInfo() As String


            Try

                Me._manifest.SVFR_SELECTING_TURNOVER_DTL_ROW.Delete()

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

                Dim staffConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_STAFF(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                staffConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_STAFFColumns.STAFF_CODEColumn, "=", Me._manifest.ButtonEdit_EmployeeCode.Text)

                Dim staffRow As MyPosXAuto.FTs.FT_M_STAFFRow = MyPosXAuto.Facade.AfBizMaster.GetM_STAFFRow(staffConditions)

                If IsNothing(staffRow) = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00003
                End If

                Me._manifest.ButtonEdit_EmployeeCode.Text = staffRow.STAFF_CODE
                Me._manifest.Label_EmployeeName.Text = staffRow.STAFF_NAME
                Me._manifest.Label_EmployeeID.Text = CommTK.FString(staffRow.STAFF_ID)


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
        Private Function DoSaveInfo() As String


            Try

                Dim turnoverDtlCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                turnoverDtlCondition.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_BOOK_STATUSColumn, "=", MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_BOOK)

                Dim bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow = _
                    Me._manifest.SVFT_BINDING_LIST.FindRowByCondition(turnoverDtlCondition)

                If IsNothing(bindingRow) = False Then
                    If Me._manifest.SVLM_TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN AndAlso _
                        Me._manifest.Label_SupplierID.Text.Length = 0 Then
                        Return MyPosXService.Decls.MSG_ALERT_00052
                    ElseIf Me._manifest.SVLM_TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_OUT AndAlso _
                        Me._manifest.Label_CustomerID.Text.Length = 0 Then
                        Return MyPosXService.Decls.MSG_ALERT_00053
                    End If

                End If

                Dim turnoverCode As String = Me._manifest.TextEdit_TurnoverCode.Text
                Dim validateResult As String = String.Empty

                Dim servResult As String = _
                    Me._service.ServSaveInfo( _
                        Me._manifest.SVLM_TURNOVER_TYPE, _
                        Me._manifest.SV_CURRENT_TURNOVER_BATCH_INDEX, _
                        CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue), _
                        Me._manifest.SV_EDITING_TURNOVER_ID, _
                        Me._manifest.Label_CustomerID.Text, _
                        CommTK.FInteger(Me._manifest.LookUpEdit_TurnoverStyle.EditValue), _
                        Me._manifest.CalcEdit_DeliveryCharge.Value, _
                        Me._manifest.TextEdit_DeliveryDetail.Text, _
                        Me._manifest.CalcEdit_ExtraDiscount.Value, _
                        Me._manifest.SV_STAFF_SHARE_RATE, _
                        Me._manifest.Label_SupplierID.Text, _
                        Me._manifest.TextEdit_Remarks.Text, _
                        Me._manifest.Label_EmployeeID.Text, _
                        Me._manifest.CheckEdit_ManualCode.Checked, _
                        Me._manifest.SVFT_BINDING_LIST, _
                        turnoverCode, _
                        validateResult)

                Me._manifest.GridControl_TurnoverDtl.DataSource = Me._manifest.SVFT_BINDING_LIST

                If servResult.Length > 0 Then
                    Return servResult
                End If

                If validateResult.Length > 0 Then
                    Return validateResult
                End If


                'Me._manifest.GridControl_TurnoverDtl.DataSource = Me._manifest.SVFT_BINDING_LIST
                Me._manifest.TextEdit_TurnoverCode.Text = turnoverCode


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
        Private Function DoLoadInfo() As String


            Try
                If Me._manifest.SV_EDITING_TURNOVER_ID.Length <= 0 Then
                    Return String.Empty
                End If

                Dim turnoverRowSEntity As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVERRowSEntity
                Dim clientRowSEntity As New MyPosXAuto.FTs.FT_M_MP_CLIENTRowSEntity
                Dim supplierRowSEntity As New MyPosXAuto.FTs.FT_M_MP_SUPPLIERRowSEntity
                Me._manifest.SVFT_BINDING_LIST.Clear()

                Dim servResult As String = _
                    Me._service.ServLoadInfo( _
                        Me._manifest.SV_EDITING_TURNOVER_ID, _
                        turnoverRowSEntity, _
                        clientRowSEntity, _
                        supplierRowSEntity, _
                        Me._manifest.SVFT_BINDING_LIST)

                If servResult.Length > 0 Then
                    Return servResult
                End If

                Me._manifest.TextEdit_TurnoverCode.Text = turnoverRowSEntity.TURNOVER_CODE
                Me._manifest.DateEdit_DepositTime.EditValue = turnoverRowSEntity.TURNOVER_TIME
                Me._manifest.CalcEdit_DeliveryCharge.Value = turnoverRowSEntity.DELIVERY_CHARGE
                Me._manifest.CalcEdit_ExtraDiscount.Value = turnoverRowSEntity.EXTRA_DISCOUNT
                Me._manifest.TextEdit_DeliveryDetail.Text = turnoverRowSEntity.DELIVERY_DETAIL
                Me._manifest.TextEdit_Remarks.Text = turnoverRowSEntity.REMARK
                Me._manifest.ButtonEdit_EmployeeCode.Text = turnoverRowSEntity.STAFF_CODE
                Me._manifest.LookUpEdit_Pos.EditValue = turnoverRowSEntity.POS_ID
                Me._manifest.Label_EmployeeName.Text = turnoverRowSEntity.STAFF_NAME
                Me._manifest.Label_EmployeeID.Text = CommTK.FString(turnoverRowSEntity.STAFF_ID)
                Me._manifest.SV_STAFF_SHARE_RATE = turnoverRowSEntity.STAFF_SHARE_RATE


                Me._manifest.LookUpEdit_TurnoverStyle.EditValue = turnoverRowSEntity.TURNOVER_STYLE
                Me._manifest.SV_CURRENT_TURNOVER_BATCH_INDEX = turnoverRowSEntity.BATCH_INDEX


                If clientRowSEntity.IsNull = False Then
                    Me._manifest.ButtonEdit_CustomerCode.Text = clientRowSEntity.CLIENT_CODE
                    Me.DoLoadCustomerByCode()
                End If

                If supplierRowSEntity.IsNull = False Then
                    Me._manifest.ButtonEdit_SupplierCode.Text = supplierRowSEntity.SUPPLIER_CODE
                    Me.DoLoadSupplierByCode()
                End If

                Me._manifest.LookUpEdit_Pos.EditValue = turnoverRowSEntity.POS_ID
                Me._manifest.GridControl_TurnoverDtl.DataSource = Me._manifest.SVFT_BINDING_LIST


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
        Private Function DoLoadWareByCode() As String


            Try

                Dim setDtlRowSEntity As New MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERowSEntity

                Dim servResult As String = _
                    Me._service.ServLoadWareByCode( _
                        CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue), _
                        Me._manifest.ButtonEdit_WareCode.Text, _
                        setDtlRowSEntity, _
                        Me._manifest.CheckEdit_ShowDetailInput.Checked, _
                        Me._manifest.SVFT_BINDING_LIST, _
                        Me._manifest.SVLM_TURNOVER_TYPE, _
                        CommTK.FInteger(Me._manifest.LookUpEdit_TurnoverStyle.EditValue))

                If servResult.Length > 0 Then
                    Return servResult
                End If

                Me._manifest.ButtonEdit_WareCode.Text = setDtlRowSEntity.WARE_CODE
                Me._manifest.Label_CustomCode.Text = setDtlRowSEntity.CUSTOM_CODE
                Me._manifest.Label_WareID.Text = CommTK.FString(setDtlRowSEntity.WARE_ID)

                Me._manifest.GridControl_TurnoverDtl.DataSource = Me._manifest.SVFT_BINDING_LIST

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
        Private Function DoPrintBatchLabel() As String


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
        Private Function DoValidateAvailableAmount() As String


            Try

                Dim validateResult As String = String.Empty

                Me._service.ServValidateAvailableAmount( _
                    Me._manifest.SVLM_TURNOVER_TYPE, _
                    CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue), _
                    Me._manifest.SVFT_BINDING_LIST, _
                    validateResult)

                Me._manifest.GridControl_TurnoverDtl.DataSource = Me._manifest.SVFT_BINDING_LIST

                Return validateResult


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
        Private Function DoUpdateCurrentAmount() As String


            Try

                Me._service.ServUpdateCurrentAmount( _
                    Utils.Decls.CURRENT_POS_ROW.POS_ID, _
                    Me._manifest.SVFT_BINDING_LIST)

                Me._manifest.GridControl_TurnoverDtl.DataSource = Me._manifest.SVFT_BINDING_LIST


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
        Private Function DoLoadCustomerByCode() As String


            Try

                Dim clientRowSEntity As New MyPosXAuto.FTs.FT_M_MP_CLIENTRowSEntity

                Me._service.ServLoadCustomerByCode( _
                    Me._manifest.ButtonEdit_CustomerCode.Text, _
                    clientRowSEntity)


                If clientRowSEntity.IsNull = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00003
                End If

                Me._manifest.ButtonEdit_CustomerCode.Text = clientRowSEntity.CLIENT_CODE
                Me._manifest.Label_CustomerName.Text = clientRowSEntity.CLIENT_NAME
                Me._manifest.Label_CustomerID.Text = CommTK.FString(clientRowSEntity.CLIENT_ID)
                Me._manifest.SV_SELL_DISCOUNT = clientRowSEntity.SELL_DISCOUNT

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
        Private Function DoLoadSupplierByCode() As String


            Try

                Dim supplierConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_SUPPLIER(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                supplierConditions.Add(AfBizMaster.M_MP_SUPPLIERColumns.SUPPLIER_CODEColumn, "=", Me._manifest.ButtonEdit_SupplierCode.Text)

                Dim supplierRow As MyPosXAuto.FTs.FT_M_MP_SUPPLIERRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_SUPPLIERRow(supplierConditions)

                If IsNothing(supplierRow) = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00008
                End If

                Me._manifest.ButtonEdit_SupplierCode.Text = supplierRow.SUPPLIER_CODE
                Me._manifest.Label_SupplierName.Text = supplierRow.SUPPLIER_NAME
                Me._manifest.Label_SupplierID.Text = CommTK.FString(supplierRow.SUPPLIER_ID)

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
        Private Function DoGenerateDefaultConsignAndPayment() As String


            Try

                Me._service.ServGenerateDefaultConsignAndPayment( _
                    Me._manifest.SV_EDITING_TURNOVER_ID)

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
        '''判断可用库存
        '''
        '''-------------------------------------------------------------------
        Private Function DoCalculateExtraDiscount() As String


            Try
                Dim extraDiscount As Double
                Dim totalSumPrice As Double

                For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In Me._manifest.SVFT_BINDING_LIST
                    If bindingRow.RowState <> DataRowState.Deleted Then
                        totalSumPrice += bindingRow.SUM_PRICE

                    End If
                Next

                If Me._manifest.SV_SELL_DISCOUNT >= 0 Then
                    extraDiscount = totalSumPrice * Me._manifest.SV_SELL_DISCOUNT

                    Me._manifest.CalcEdit_ExtraDiscount.Value = CommTK.FDecimal(extraDiscount)

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
        Private Function DoNewList() As String


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
        Private Function DoUpdateCalculation() As String


            Try

                Dim totalPrice As Decimal

                For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In Me._manifest.SVFT_BINDING_LIST
                    If bindingRow.RowState <> DataRowState.Deleted Then
                        bindingRow.SUM_COST = CommTK.FDecimal(bindingRow.UNIT_COST * bindingRow.WARE_AMOUNT)
                        bindingRow.SUM_PRICE = CommTK.FDecimal(bindingRow.UNIT_PRICE * bindingRow.WARE_AMOUNT)
                        bindingRow.ORIGION_SUM_PRICE = CommTK.FDecimal(bindingRow.ORIGION_UNIT_PRICE * bindingRow.WARE_AMOUNT)
                        bindingRow.SUM_DISCOUNT = CommTK.FDecimal(bindingRow.UNIT_DISCOUNT * bindingRow.WARE_AMOUNT)
                        totalPrice = totalPrice + bindingRow.SUM_PRICE

                    End If
                Next

                totalPrice -= Me._manifest.CalcEdit_ExtraDiscount.Value
                totalPrice += Me._manifest.CalcEdit_DeliveryCharge.Value

                Me._manifest.Label_SumPrice.Text = CommTK.FString(totalPrice, False, "#,##0.00")
                Me._manifest.Label_Change.Text = String.Format("{0:0.00}", Me._manifest.CalcEdit_Pay.Value - CommTK.FDecimal(Me._manifest.Label_SumPrice.Text))

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
        Private Function DoNewCustomer() As String


            Try

                Dim customerCode As String = String.Empty

                Me._service.ServNewCustomer(customerCode)

                Me._manifest.ButtonEdit_CustomerCode.Text = customerCode

                Dim clientID = Guid.NewGuid.ToString
                MyPosXAuto.Facade.AfBizMaster.CreateM_MP_CLIENTInfo( _
                    clientID, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    Me._manifest.ButtonEdit_CustomerCode.Text, _
                    MyPosXService.Decls.DEFAULT_CI_VALUE_CLIENT_LEVEL_DEFAULT, _
                    Me._manifest.ButtonEdit_CustomerCode.Text, _
                    MyPosXAuto.Decls.CIVALUE_CLIENT_TYPE_WHOLESALE, _
                     String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    0, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty)

                Me._manifest.Label_CustomerName.Text = Me._manifest.ButtonEdit_CustomerCode.Text
                Me._manifest.Label_CustomerID.Text = CommTK.FString(clientID)


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
        Private Function DoExportExcel() As String


            Try

                Select Case SysInfo.ReadShareSysInfo(CommDecl.XLSSVN_LABEL_PRINT_SET).ToUpper

                    Case "CASA"
                        Utils.TK.ExportTurnoverCASA(Me._manifest.SV_EXCEL_FILENAME, Me._manifest.SV_EDITING_TURNOVER_ID)

                    Case Else
                        'Utils.TK.ExportTurnover(Me._manifest.SV_EXCEL_Me._manifest.SV_EXCEL_FILENAME, Me._manifest.SV_EDITING_TURNOVER_ID)



                        Dim sysWareSpecModelDiscard As Boolean
                        Dim sysHideFinancials As Boolean
                        Dim sysAttribute1 As String = String.Empty
                        Dim sysAttribute2 As String = String.Empty
                        Dim sysAttribute3 As String = String.Empty
                        Dim sysAttribute4 As String = String.Empty
                        Dim turnoverRowSEntity As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVERRowSEntity
                        Dim turnoverDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL

                        Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity

                        Me._service.ServExportExcel( _
                            Me._manifest.SV_EDITING_TURNOVER_ID, _
                            turnoverRowSEntity, _
                            turnoverDtlList, _
                            sysWareSpecModelDiscard, _
                            sysHideFinancials, _
                            Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID, _
                            staffRowSE, _
                            sysAttribute1, _
                            sysAttribute2, _
                            sysAttribute3, _
                            sysAttribute4)

                        If IO.File.Exists(Me._manifest.SV_EXCEL_FILENAME) = True Then
                            IO.File.Delete(Me._manifest.SV_EXCEL_FILENAME)
                        End If

                        Dim toExcel As New Utils.ExcelTK(Me._manifest.SV_EXCEL_FILENAME)

                        Dim cellFont As Font

                        toExcel.MergeCell(1, 1, 1, 15)
                        toExcel.SetRowHeight(1, 35)

                        toExcel.SetColumnWidth(1, 10)
                        toExcel.SetColumnWidth(2, 10)
                        toExcel.SetColumnWidth(3, 10)
                        toExcel.SetColumnWidth(4, 10)
                        toExcel.SetColumnWidth(5, 10)
                        toExcel.SetColumnWidth(6, 10)
                        toExcel.SetColumnWidth(7, 10)
                        toExcel.SetColumnWidth(8, 12)
                        toExcel.SetColumnWidth(9, 10)
                        toExcel.SetColumnWidth(10, 10)
                        toExcel.SetColumnWidth(11, 10)
                        toExcel.SetColumnWidth(12, 10)
                        toExcel.SetColumnWidth(13, 10)
                        toExcel.SetColumnWidth(14, 10)
                        toExcel.SetColumnWidth(15, 10)

                        If sysAttribute1.Length <= 0 Then
                            toExcel.SetColumnWidth(8, 0)
                        End If

                        If sysAttribute2.Length <= 0 Then
                            toExcel.SetColumnWidth(9, 0)
                        End If

                        If sysAttribute3.Length <= 0 Then
                            toExcel.SetColumnWidth(10, 0)
                        End If

                        If sysAttribute4.Length <= 0 Then
                            toExcel.SetColumnWidth(11, 0)
                        End If

                        If sysWareSpecModelDiscard = True Then
                            toExcel.SetColumnWidth(6, 0)
                            toExcel.SetColumnWidth(7, 0)
                        End If

                        If sysHideFinancials = True Then
                            toExcel.SetColumnWidth(13, 0)
                            If turnoverRowSEntity.TURNOVER_STYLE <> MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_SOLD Then
                                toExcel.SetColumnWidth(14, 0)
                            End If
                        End If

                        If CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_SHOW_DELIVERY_FIELDS_IN_TURNOVER)) = False Then
                            toExcel.SetRowHeight(11, 0)
                            toExcel.SetRowHeight(12, 0)
                        End If

                        cellFont = New Font("Arial", 16, FontStyle.Bold)

                        If turnoverRowSEntity.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN Then
                            toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("入库单"), cellFont, Color.Black, Color.White)
                        ElseIf turnoverRowSEntity.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_OUT Then
                            toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("出库单"), cellFont, Color.Black, Color.White)
                        End If

                        cellFont = New Font("Arial", 10, FontStyle.Bold)

                        toExcel.MergeCell(3, 1, 3, 2)
                        toExcel.MergeCell(4, 1, 4, 2)
                        toExcel.MergeCell(5, 1, 5, 2)
                        toExcel.MergeCell(6, 1, 6, 2)
                        toExcel.MergeCell(7, 1, 7, 2)
                        toExcel.MergeCell(8, 1, 8, 2)
                        toExcel.MergeCell(9, 1, 9, 2)
                        toExcel.MergeCell(10, 1, 10, 2)
                        toExcel.MergeCell(11, 1, 11, 2)
                        toExcel.MergeCell(12, 1, 12, 2)

                        toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("出入库时间"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(4, 1, CommTK.GetTranslatedString("地点名称:"), cellFont, Color.Black, Color.White)

                        If turnoverRowSEntity.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN Then
                            toExcel.SetCellText(5, 1, CommTK.GetTranslatedString("入库单号"), cellFont, Color.Black, Color.White)
                        ElseIf turnoverRowSEntity.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_OUT Then
                            toExcel.SetCellText(5, 1, CommTK.GetTranslatedString("出库单号"), cellFont, Color.Black, Color.White)
                        End If

                        If turnoverRowSEntity.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN Then
                            toExcel.SetCellText(6, 1, CommTK.GetTranslatedString("入库形式"), cellFont, Color.Black, Color.White)
                        ElseIf turnoverRowSEntity.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_OUT Then
                            toExcel.SetCellText(6, 1, CommTK.GetTranslatedString("出库形式"), cellFont, Color.Black, Color.White)
                        End If

                        toExcel.SetCellText(7, 1, CommTK.GetTranslatedString("客户名"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(8, 1, CommTK.GetTranslatedString("供应商名称"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(9, 1, CommTK.GetTranslatedString("操作人"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(10, 1, CommTK.GetTranslatedString("备注"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(11, 1, CommTK.GetTranslatedString("送货细节:"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(12, 1, CommTK.GetTranslatedString("送货费用:"), cellFont, Color.Black, Color.White)

                        toExcel.MergeCell(3, 3, 3, 5)
                        toExcel.MergeCell(4, 3, 4, 5)
                        toExcel.MergeCell(5, 3, 5, 5)
                        toExcel.MergeCell(6, 3, 6, 5)
                        toExcel.MergeCell(7, 3, 7, 5)
                        toExcel.MergeCell(8, 3, 8, 5)
                        toExcel.MergeCell(9, 3, 9, 5)
                        toExcel.MergeCell(10, 3, 10, 5)
                        toExcel.MergeCell(11, 3, 11, 5)
                        toExcel.MergeCell(12, 3, 12, 5)

                        toExcel.SetCellText(3, 3, CommTK.FString(turnoverRowSEntity.TURNOVER_TIME), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                        toExcel.SetCellText(4, 3, turnoverRowSEntity.POS_NAME, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(5, 3, turnoverRowSEntity.TURNOVER_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(6, 3, MyPosXAuto.Facade.AfCIV.GetCI_TURNOVER_STYLEText(CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)), turnoverRowSEntity.TURNOVER_STYLE, String.Empty), cellFont, Color.Black, Color.White)

                        Dim customerRow As MyPosXAuto.FTs.FT_M_MP_CLIENTRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_CLIENTRow(turnoverRowSEntity.CLIENT_ID)

                        If IsNothing(customerRow) = False Then
                            toExcel.SetCellText(7, 3, customerRow.CLIENT_NAME, cellFont, Color.Black, Color.White)
                        Else
                            toExcel.SetCellText(7, 3, "-", cellFont, Color.Black, Color.White)
                        End If

                        Dim supplierRow As MyPosXAuto.FTs.FT_M_MP_SUPPLIERRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_SUPPLIERRow(turnoverRowSEntity.SUPPLIER_ID)

                        If IsNothing(supplierRow) = False Then
                            toExcel.SetCellText(8, 3, supplierRow.SUPPLIER_NAME, cellFont, Color.Black, Color.White)
                        Else
                            toExcel.SetCellText(8, 3, "-", cellFont, Color.Black, Color.White)
                        End If

                        toExcel.SetCellText(9, 3, turnoverRowSEntity.STAFF_NAME, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(10, 3, turnoverRowSEntity.REMARK, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(11, 3, turnoverRowSEntity.DELIVERY_DETAIL, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(12, 3, String.Format("{0:0.00}", turnoverRowSEntity.DELIVERY_CHARGE), cellFont, Color.Black, Color.White)


                        cellFont = New Font("Arial", 12, FontStyle.Bold)
                        toExcel.SetCellText(15, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 2, CommTK.GetTranslatedString("货品类别"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 3, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 4, CommTK.GetTranslatedString("自定货号"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 5, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 6, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 7, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 8, sysAttribute1, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 9, sysAttribute2, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 10, sysAttribute3, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 11, sysAttribute4, cellFont, Color.Black, Color.White)

                        If turnoverRowSEntity.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN Then
                            toExcel.SetCellText(15, 12, CommTK.GetTranslatedString("入货数量"), cellFont, Color.Black, Color.White)
                        ElseIf turnoverRowSEntity.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_OUT Then
                            toExcel.SetCellText(15, 12, CommTK.GetTranslatedString("出货数量"), cellFont, Color.Black, Color.White)
                        End If

                        toExcel.SetCellText(15, 13, CommTK.GetTranslatedString("成本"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 14, CommTK.GetTranslatedString("单价"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(15, 15, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)

                        Dim rowCounter As Integer = 16
                        Dim counter As Integer = 1
                        Dim totalAmount As Double = 0

                        XL.Win.Window.XLProgressBox.SetProgressRange(turnoverDtlList.Count + rowCounter, 400, False)

                        cellFont = New Font("Arial", 10, FontStyle.Regular)

                        For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In turnoverDtlList

                            toExcel.SetCellText(rowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 2, bindingRow.WARE_CLASSIFY_NAME, cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 3, bindingRow.WARE_CODE, cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 4, bindingRow.CUSTOM_CODE, cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 5, bindingRow.WARE_NAME, cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 6, bindingRow.SPEC, cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 7, bindingRow.MODEL, cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 8, bindingRow.ATTRIBUTE1, cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 9, bindingRow.ATTRIBUTE2, cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 10, bindingRow.ATTRIBUTE3, cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 11, bindingRow.ATTRIBUTE4, cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 12, CommTK.FString(bindingRow.WARE_AMOUNT), cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 13, CommTK.FString(bindingRow.UNIT_COST), cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 14, CommTK.FString(bindingRow.UNIT_PRICE), cellFont, Color.Black, Color.White)
                            toExcel.SetCellText(rowCounter, 15, bindingRow.UNIT_NAME, cellFont, Color.Black, Color.White)

                            rowCounter += 1
                            counter += 1

                            totalAmount = totalAmount + bindingRow.WARE_AMOUNT

                            XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.WARE_NAME)

                        Next

                        XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                        toExcel.SetFrameLine(15, 1, rowCounter - 1, 15, Utils.ExcelTK.BorderPart.Bottom Or Utils.ExcelTK.BorderPart.Horizonal, Color.Black, , Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline)
                        toExcel.SetFrameLine(14, 1, rowCounter - 1, 15, Utils.ExcelTK.BorderPart.Top Or Utils.ExcelTK.BorderPart.Bottom, Color.Black, , Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick)

                        cellFont = New Font("Arial", 12, FontStyle.Bold)

                        toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 12, CommTK.FString(totalAmount), cellFont, Color.Black, Color.White)

                        cellFont = New Font("Arial", 10, FontStyle.Bold)

                        If staffRowSE.IsNull = False Then
                            toExcel.SetCellText(rowCounter + 2, 15, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                        End If

                        If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                            toExcel.SetCellText(rowCounter + 3, 15, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                        Else
                            toExcel.SetCellText(rowCounter + 3, 15, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
                        End If

                        toExcel.SaveAndClose()


                End Select


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
        Private Function DoImportFromMobile() As String


            Try


                Dim readTurnoverDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL
                Dim turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow
                Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                Select Case CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_COLLECTOR_DEVICE_TYPE))


                    Case CommDecl.MOBILE_DEVICE_TYPE_CPT

                        Dim readLines As ArrayList = BarCodeKit.ReadCPT80Data()
                        If IsNothing(readLines) = True Then
                            Return MyPosXService.Decls.MSG_ALERT_00008
                        End If

                        Dim wareCode As String
                        Dim wareAmount As Decimal


                        For Each lineData As ArrayList In readLines

                            wareCode = CommTK.FString(lineData(0))
                            wareAmount = CommTK.FDecimal(lineData(1))

                            turnoverDtlConditions.Clear()
                            turnoverDtlConditions.Add(AfXV.XV_H_MP_TURNOVER_DTLColumns.WARE_CODEColumn, "=", wareCode)

                            turnoverDtlRow = readTurnoverDtlList.FindRowByCondition(turnoverDtlConditions)

                            If IsNothing(turnoverDtlRow) = False Then
                                turnoverDtlRow.WARE_AMOUNT += wareAmount
                            Else
                                turnoverDtlRow = readTurnoverDtlList.NewXV_H_MP_TURNOVER_DTLRow
                                readTurnoverDtlList.AddXV_H_MP_TURNOVER_DTLRow(turnoverDtlRow)
                                turnoverDtlRow.WARE_CODE = wareCode
                                turnoverDtlRow.WARE_AMOUNT = wareAmount
                            End If

                        Next


                    Case CommDecl.MOBILE_DEVICE_TYPE_WINCE

                        If BarCodeKit.ReadWinCETable(IO.Path.Combine( _
                                SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_MOBILE_SWAP_PATH), _
                                MyPosXService.Decls.CTBN_WARE_TURNOVER_DTL_LIST), _
                            CType(readTurnoverDtlList, DataTable)) = False Then
                            Return String.Empty
                        End If

                End Select

                Dim servResult As String = _
                    Me._service.ServImportFromMobile( _
                        CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue), _
                        readTurnoverDtlList, _
                        Me._manifest.SVFT_BINDING_LIST)

                Me._manifest.GridControl_TurnoverDtl.DataSource = Me._manifest.SVFT_BINDING_LIST

                Return servResult

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
        Private Function DoLoadCommissionRate() As String


            Try

                Dim posRowSE As New MyPosXAuto.FTs.FT_M_MP_POSRowSEntity

                Dim posSetRowSE As New MyPosXAuto.FTs.FT_S_MP_POS_SETRowSEntity

                Me._service.ServLoadCommissionRate( _
                    CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue), _
                    posRowSE, _
                    posSetRowSE)

                If posSetRowSE.IsNull = True Then
                    Return String.Empty
                End If

                Me._manifest.SV_STAFF_SHARE_RATE = posSetRowSE.STAFF_SHARE_RATE


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
