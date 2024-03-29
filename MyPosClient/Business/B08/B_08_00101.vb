Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade

Namespace Business


    Public Class B_08_00101
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
        Private _manifest As Manifest.M_08_00101
        Private _service As MyPosXService.S_08_00101

        Public Enum Affairs
            InitDisplay
            LoadPosList
            SaveInfo
            LoadInfo
            UpdateEnable
            AutomateWareCodes
            SaveMobileWareList
            LoadRecpTypeBarcodeList
            SaveMobileLocationList
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

            Me._manifest = CType(theManifest, Manifest.M_08_00101)
            Try

                Me._service = MyPosXService.S_08_00101.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_08_00101.GetInstance()
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

                Case Affairs.LoadPosList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadPosList)

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

                Case Affairs.UpdateEnable

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoUpdateEnable)

                Case Affairs.AutomateWareCodes

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoAutomateWareCodes)

                Case Affairs.SaveMobileWareList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSaveMobileWareList)

                Case Affairs.LoadRecpTypeBarcodeList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadRecpTypeBarcodeList)

                Case Affairs.SaveMobileLocationList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSaveMobileLocationList)

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

                Me._manifest.SVFT_CHOOSE_POS_LIST.Clear()

                Me._manifest.SVFT_BINDING_RECP_TYPE_BARCODE_LIST.Clear()

                Me._service.ServInitDisplay( _
                    CommDecl.CURRENT_LANGUAGE_OPTION, _
                    Me._manifest.SVFT_CHOOSE_POS_LIST, _
                    Me._manifest.SVFT_BINDING_RECP_TYPE_BARCODE_LIST)

                Me._manifest.GridControl_RecipientTypeBarcode.DataSource = Me._manifest.SVFT_BINDING_RECP_TYPE_BARCODE_LIST
                Me._manifest.LookUpEdit_CurrentPOS.Properties.DataSource = Me._manifest.SVFT_CHOOSE_POS_LIST


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
        Private Function DoLoadPosList() As String


            Try

                'Dim posConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_POS(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                'posConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_POSColumns.POS_CODEColumn, "=", Me._manifest.LookUpEdit_CurrentPOS.EditValue)

                Me._manifest.SVFT_CHOOSE_POS_LIST.Clear()
                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, Me._manifest.SVFT_CHOOSE_POS_LIST)
                Me._manifest.LookUpEdit_CurrentPOS.Properties.DataSource = Me._manifest.SVFT_CHOOSE_POS_LIST

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

                SysInfo.WriteLocalSysInfo(MyPosXService.Decls.LVN_CURRENT_POS_ID, CommTK.FString(Me._manifest.LookUpEdit_CurrentPOS.EditValue))
                'SysInfo.WriteLocalSysInfo(CommDecl.XLSLVN_MOBILE_SWAP_PATH, CommTK.FString(Me._manifest.TextEdit_MobileSmapPath.Text))
                SysInfo.WriteLocalSysInfo(MyPosXService.Decls.LVN_SHOW_DELIVERY_FIELDS_IN_TURNOVER, CommTK.FString(Me._manifest.CheckEdit_ShowDeliveryFieldsInTurnover.Checked))
                SysInfo.WriteLocalSysInfo(MyPosXService.Decls.LVN_PRINT_SHOPPING_LIST, CommTK.FString(Me._manifest.CheckEdit_PrintShoppingList.Checked))
                SysInfo.WriteLocalSysInfo(MyPosXService.Decls.LVN_POS_SET_SYNC_EXPORT_ALLOWED, CommTK.FString(Me._manifest.CheckEdit_AllowPosSetSyncExport.Checked))
                SysInfo.WriteLocalSysInfo(MyPosXService.Decls.LVN_LABEL_PRINTING_DISABLED, CommTK.FString(Me._manifest.CheckEdit_LabelPrintingDisabled.Checked))
                SysInfo.WriteLocalSysInfo(MyPosXService.Decls.LVN_OPERATION_LIMITED_HERE, CommTK.FString(Me._manifest.CheckEdit_OperationLimitedHere.Checked))
                SysInfo.WriteLocalSysInfo(MyPosXService.Decls.LVN_LABEL_WITH_PRICE, CommTK.FString(Me._manifest.CheckEdit_LabelWithPrice.Checked))

                Me._service.ServSaveInfo( _
                    Me._manifest.TextEdit_CompanyTitle.Text, _
                    Me._manifest.TextEdit_ServiceTel.Text, _
                    Me._manifest.TextEdit_CompanyAddress.Text, _
                    CommTK.FString(Me._manifest.CheckEdit_ShowCustomWareCode.Checked), _
                    CommTK.FString(Me._manifest.CheckEdit_WareArriveConfirm.Checked), _
                    CommTK.FString(Me._manifest.CheckEdit_WareArriveByRecipient.Checked), _
                    CommTK.FString(Me._manifest.CheckEdit_MoneyArriveConfirm.Checked), _
                    CommTK.FString(Me._manifest.CheckEdit_HideFinancials.Checked), _
                    Me._manifest.TextEdit_ConsignCodePrefix.Text, _
                    Me._manifest.TextEdit_TransferTurnoverCodePrefix.Text, _
                    Me._manifest.TextEdit_TurnoverCodePrefix.Text, _
                    Me._manifest.TextEdit_ClientCodePrefix.Text, _
                    Me._manifest.TextEdit_SupplierCodePrefix.Text, _
                    CommTK.FString(Me._manifest.RadioGroup_WareTurnoverMode.EditValue), _
                    Me._manifest.TextEdit_WareBatchPrefix.Text, _
                    CommTK.FString(Me._manifest.CheckEdit_AllowExtraConsign.Checked), _
                    CommTK.FString(Me._manifest.CheckEdit_AllowMinusStock.Checked), _
                    Me._manifest.ComboBoxEdit_WareLabelSolution.SelectedIndex, _
                    Me._manifest.ComboBoxEdit_BatchLabelSolution.SelectedIndex, _
                    Me._manifest.ComboBoxEdit_PractWareLabelSolution.SelectedIndex, _
                    CommTK.FString(Me._manifest.CheckEdit_QuickCustomerCreatingAllowed.Checked), _
                    CommTK.FString(Me._manifest.CheckEdit_WareSpecModelDiscard.Checked), _
                    CommTK.FString(Me._manifest.CheckEdit_ShowEnItemName.Checked), _
                    Me._manifest.TextEdit_CustomAttribute1.Text, _
                    Me._manifest.TextEdit_CustomAttribute2.Text, _
                    Me._manifest.TextEdit_CustomAttribute3.Text, _
                    Me._manifest.TextEdit_CustomAttribute4.Text, _
                    CommTK.FString(Me._manifest.CheckEdit_WareAttribute1Hidden.Checked), _
                    CommTK.FString(Me._manifest.CheckEdit_WareAttribute2Hidden.Checked), _
                    CommTK.FString(Me._manifest.CheckEdit_WareAttribute3Hidden.Checked), _
                    CommTK.FString(Me._manifest.CheckEdit_WareAttribute4Hidden.Checked), _
                    Me._manifest.TextEdit_ClientAttr1.Text, _
                    Me._manifest.TextEdit_ClientAttr2.Text, _
                    Me._manifest.TextEdit_ClientAttr3.Text, _
                    Me._manifest.TextEdit_ClientAttr4.Text, _
                    Me._manifest.TextEdit_ClientAttr5.Text, _
                    Me._manifest.TextEdit_ClientAttr6.Text, _
                    Me._manifest.SVFT_BINDING_RECP_TYPE_BARCODE_LIST, _
                    Me._manifest.TextEdit_PractWareCodePrefix.Text, _
                    Me._manifest.CheckEdit_PractWareCodeHasYearMonth.Checked, _
                    Me._manifest.CheckEdit_PractWareCodeHasDay.Checked, _
                    Me._manifest.CheckEdit_AutoWareCodeHyphon.Checked, _
                    Me._manifest.CheckEdit_AutoWareCodeSupplierCode.Checked, _
                    Me._manifest.CheckEdit_AutoWareCodeSurfix.Checked, _
                    CommTK.FInteger(Me._manifest.SpinEdit_PractWareCodeDigitLength.Value), _
                    CommTK.FInteger(Me._manifest.SpinEdit_AutoWareCodeIDLenth.Value), _
                    CommTK.FInteger(Me._manifest.SpinEdit_PurchasaeListCopies.Value), _
                    CommTK.FString(Me._manifest.CheckEdit_CanPointsToRMB.Checked), _
                    CommTK.FString(Me._manifest.CalcEdit_PointsToRMBRate.Value), _
                    CommTK.FString(Me._manifest.CheckEdit_CanRMBToPoints.Checked), _
                    CommTK.FString(Me._manifest.CalcEdit_RMBToPointsRate.Value))

                If CommTK.FString(Me._manifest.LookUpEdit_CurrentPOS.EditValue).Length > 0 Then
                    Dim posConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_M_MP_POS(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                    Utils.Decls.CURRENT_POS_ROW = MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(CommTK.FString(Me._manifest.LookUpEdit_CurrentPOS.EditValue))
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
        Private Function DoLoadInfo() As String


            Try

                Me._manifest.LookUpEdit_CurrentPOS.EditValue = SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_CURRENT_POS_ID)
                'Me._manifest.TextEdit_MobileSmapPath.Text = SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_MOBILE_SWAP_PATH)
                Me._manifest.CheckEdit_ShowDeliveryFieldsInTurnover.Checked = CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_SHOW_DELIVERY_FIELDS_IN_TURNOVER))
                Me._manifest.CheckEdit_PrintShoppingList.Checked = CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_PRINT_SHOPPING_LIST))
                Me._manifest.CheckEdit_AllowPosSetSyncExport.Checked = CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_POS_SET_SYNC_EXPORT_ALLOWED))
                Me._manifest.CheckEdit_LabelPrintingDisabled.Checked = CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_LABEL_PRINTING_DISABLED))
                Me._manifest.CheckEdit_OperationLimitedHere.Checked = CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_OPERATION_LIMITED_HERE))
                Me._manifest.CheckEdit_LabelWithPrice.Checked = CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_LABEL_WITH_PRICE))

                Dim companyTitle As String = String.Empty
                Dim serviceTel As String = String.Empty
                Dim companyAddress As String = String.Empty
                Dim showCustomWareCode As Boolean
                Dim wareArriveConfirm As Boolean
                Dim wareArriveByRecipient As Boolean
                Dim moneyArriveConfirm As Boolean
                Dim hideFinancials As Boolean
                Dim consignCodePrefix As String = String.Empty
                Dim transferTovrPrefix As String = String.Empty
                Dim turnoverPrefix As String = String.Empty
                Dim autoClientCodePrefix As String = String.Empty
                Dim autoSupplierCodePrefix As String = String.Empty
                Dim wareTurnoverMode As Integer = 0
                Dim wareBatchPrefix As String = String.Empty
                Dim allowExtraConsign As Boolean
                Dim allowMinusStock As Boolean
                Dim wareLabelSolution As Integer = 0
                Dim batchLabelSolution As Integer = 0
                Dim practWareLabelSolution As Integer = 0
                Dim quickClientCreatingAllowed As Boolean
                Dim wareSpecModelDiscard As Boolean
                Dim showEnglishItemName As Boolean
                Dim customAttribute1 As String = String.Empty
                Dim customAttribute2 As String = String.Empty
                Dim customAttribute3 As String = String.Empty
                Dim customAttribute4 As String = String.Empty
                Dim customAttribute1Hidden As Boolean
                Dim customAttribute2Hidden As Boolean
                Dim customAttribute3Hidden As Boolean
                Dim customAttribute4Hidden As Boolean
                Dim clientAttr1 As String = String.Empty
                Dim clientAttr2 As String = String.Empty
                Dim clientAttr3 As String = String.Empty
                Dim clientAttr4 As String = String.Empty
                Dim clientAttr5 As String = String.Empty
                Dim clientAttr6 As String = String.Empty
                Dim practWareCodePrefix As String = String.Empty
                Dim practWareCodeHasYearMonth As Boolean
                Dim practWareCodeHasDay As Boolean
                Dim autoWareCodeHyphon As Boolean
                Dim autoWareCodeSupplierCode As Boolean
                Dim autoWareCodeSurfix As Boolean
                Dim practWareCodeDigitLength As Integer
                Dim autoWareCodeIDLenth As Integer
                Dim purchasaeListCopies As Integer
                Dim canPointsToRMB As Boolean
                Dim pointsToRMBRate As Integer = 0
                Dim canRMBToPoints As Boolean
                Dim RMBToPointsRate As Integer = 0


                Me._service.ServLoadInfo( _
                    CommTK.FString(Me._manifest.LookUpEdit_CurrentPOS.EditValue), _
                    companyTitle, _
                    serviceTel, _
                    companyAddress, _
                    showCustomWareCode, _
                    wareArriveConfirm, _
                    wareArriveByRecipient, _
                    moneyArriveConfirm, _
                    hideFinancials, _
                    consignCodePrefix, _
                    transferTovrPrefix, _
                    turnoverPrefix, _
                    autoClientCodePrefix, _
                    autoSupplierCodePrefix, _
                    wareTurnoverMode, _
                    wareBatchPrefix, _
                    allowExtraConsign, _
                    allowMinusStock, _
                    wareLabelSolution, _
                    batchLabelSolution, _
                    practWareLabelSolution, _
                    quickClientCreatingAllowed, _
                    wareSpecModelDiscard, _
                    showEnglishItemName, _
                    customAttribute1, _
                    customAttribute2, _
                    customAttribute3, _
                    customAttribute4, _
                    customAttribute1Hidden, _
                    customAttribute2Hidden, _
                    customAttribute3Hidden, _
                    customAttribute4Hidden, _
                    clientAttr1, _
                    clientAttr2, _
                    clientAttr3, _
                    clientAttr4, _
                    clientAttr5, _
                    clientAttr6, _
                    practWareCodePrefix, _
                    practWareCodeHasYearMonth, _
                    practWareCodeHasDay, _
                    autoWareCodeHyphon, _
                    autoWareCodeSupplierCode, _
                    autoWareCodeSurfix, _
                    practWareCodeDigitLength, _
                    autoWareCodeIDLenth, _
                    purchasaeListCopies, _
                    canPointsToRMB, _
                    pointsToRMBRate, _
                    canRMBToPoints, _
                    RMBToPointsRate)



                Me._manifest.TextEdit_CompanyTitle.Text = companyTitle
                Me._manifest.TextEdit_ServiceTel.Text = serviceTel
                Me._manifest.TextEdit_CompanyAddress.Text = companyAddress
                Me._manifest.CheckEdit_ShowCustomWareCode.Checked = showCustomWareCode
                Me._manifest.CheckEdit_WareArriveConfirm.Checked = wareArriveConfirm
                Me._manifest.CheckEdit_WareArriveByRecipient.Checked = wareArriveByRecipient
                Me._manifest.CheckEdit_MoneyArriveConfirm.Checked = moneyArriveConfirm
                Me._manifest.CheckEdit_HideFinancials.Checked = hideFinancials
                Me._manifest.TextEdit_ConsignCodePrefix.Text = consignCodePrefix
                Me._manifest.TextEdit_TransferTurnoverCodePrefix.Text = transferTovrPrefix
                Me._manifest.TextEdit_TurnoverCodePrefix.Text = turnoverPrefix
                Me._manifest.TextEdit_ClientCodePrefix.Text = autoClientCodePrefix
                Me._manifest.TextEdit_SupplierCodePrefix.Text = autoSupplierCodePrefix
                Me._manifest.RadioGroup_WareTurnoverMode.EditValue = wareTurnoverMode
                Me._manifest.TextEdit_WareBatchPrefix.Text = wareBatchPrefix
                Me._manifest.CheckEdit_AllowExtraConsign.Checked = allowExtraConsign
                Me._manifest.CheckEdit_AllowMinusStock.Checked = allowMinusStock
                Me._manifest.ComboBoxEdit_WareLabelSolution.SelectedIndex = wareLabelSolution
                Me._manifest.CheckEdit_QuickCustomerCreatingAllowed.Checked = quickClientCreatingAllowed
                Me._manifest.CheckEdit_WareSpecModelDiscard.Checked = wareSpecModelDiscard
                Me._manifest.CheckEdit_ShowEnItemName.Checked = showEnglishItemName

                Me._manifest.ComboBoxEdit_BatchLabelSolution.SelectedIndex = batchLabelSolution

                Me._manifest.TextEdit_CustomAttribute1.Text = customAttribute1
                Me._manifest.TextEdit_CustomAttribute2.Text = customAttribute2
                Me._manifest.TextEdit_CustomAttribute3.Text = customAttribute3
                Me._manifest.TextEdit_CustomAttribute4.Text = customAttribute4
                Me._manifest.CheckEdit_WareAttribute1Hidden.Checked = customAttribute1Hidden
                Me._manifest.CheckEdit_WareAttribute2Hidden.Checked = customAttribute2Hidden
                Me._manifest.CheckEdit_WareAttribute3Hidden.Checked = customAttribute3Hidden
                Me._manifest.CheckEdit_WareAttribute4Hidden.Checked = customAttribute4Hidden
                Me._manifest.CheckEdit_CustomWareAttribute1.Checked = (Me._manifest.TextEdit_CustomAttribute1.Text.Trim.Length > 0)
                Me._manifest.CheckEdit_CustomWareAttribute2.Checked = (Me._manifest.TextEdit_CustomAttribute2.Text.Trim.Length > 0)
                Me._manifest.CheckEdit_CustomWareAttribute3.Checked = (Me._manifest.TextEdit_CustomAttribute3.Text.Trim.Length > 0)
                Me._manifest.CheckEdit_CustomWareAttribute4.Checked = (Me._manifest.TextEdit_CustomAttribute4.Text.Trim.Length > 0)

                Me._manifest.TextEdit_ClientAttr1.Text = clientAttr1
                Me._manifest.TextEdit_ClientAttr2.Text = clientAttr2
                Me._manifest.TextEdit_ClientAttr3.Text = clientAttr3
                Me._manifest.TextEdit_ClientAttr4.Text = clientAttr4
                Me._manifest.TextEdit_ClientAttr5.Text = clientAttr5
                Me._manifest.TextEdit_ClientAttr6.Text = clientAttr6
                Me._manifest.CheckEdit_ClientAttr1.Checked = (Me._manifest.TextEdit_ClientAttr1.Text.Trim.Length > 0)
                Me._manifest.CheckEdit_ClientAttr2.Checked = (Me._manifest.TextEdit_ClientAttr2.Text.Trim.Length > 0)
                Me._manifest.CheckEdit_ClientAttr3.Checked = (Me._manifest.TextEdit_ClientAttr3.Text.Trim.Length > 0)
                Me._manifest.CheckEdit_ClientAttr4.Checked = (Me._manifest.TextEdit_ClientAttr4.Text.Trim.Length > 0)
                Me._manifest.CheckEdit_ClientAttr5.Checked = (Me._manifest.TextEdit_ClientAttr5.Text.Trim.Length > 0)
                Me._manifest.CheckEdit_ClientAttr6.Checked = (Me._manifest.TextEdit_ClientAttr6.Text.Trim.Length > 0)

                Me._manifest.TextEdit_PractWareCodePrefix.Text = practWareCodePrefix
                Me._manifest.CheckEdit_PractWareCodeHasYearMonth.Checked = practWareCodeHasYearMonth
                Me._manifest.CheckEdit_PractWareCodeHasDay.Checked = practWareCodeHasDay
                Me._manifest.CheckEdit_AutoWareCodeHyphon.Checked = autoWareCodeHyphon
                Me._manifest.CheckEdit_AutoWareCodeSupplierCode.Checked = autoWareCodeSupplierCode
                Me._manifest.CheckEdit_AutoWareCodeSurfix.Checked = autoWareCodeSurfix
                Me._manifest.SpinEdit_PractWareCodeDigitLength.Value = practWareCodeDigitLength
                Me._manifest.SpinEdit_AutoWareCodeIDLenth.Value = autoWareCodeIDLenth
                Me._manifest.SpinEdit_PurchasaeListCopies.Value = purchasaeListCopies

                Me._manifest.CheckEdit_CanPointsToRMB.Checked = canPointsToRMB
                Me._manifest.CalcEdit_PointsToRMBRate.Value = pointsToRMBRate
                Me._manifest.CheckEdit_CanRMBToPoints.Checked = canRMBToPoints
                Me._manifest.CalcEdit_RMBToPointsRate.Value = RMBToPointsRate

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
        Private Function DoUpdateEnable() As String


            Try
                Me._manifest.CheckEdit_WareArriveByRecipient.Visible = Me._manifest.CheckEdit_WareArriveConfirm.Checked


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
        Private Function DoAutomateWareCodes() As String


            Try

                Me._service.ServAutomateWareCodes( _
                    Me._manifest.CheckEdit_KeepOrigionWareCodeToRemark.Checked)



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
        Private Function DoSaveMobileWareList() As String


            Try


                Dim wareList As New MyPosXAuto.FTs.FT_M_MP_WARE

                Dim currentPosID As String = String.Empty

                If IsNothing(Utils.Decls.CURRENT_POS_ROW) = False Then
                    currentPosID = Utils.Decls.CURRENT_POS_ROW.POS_ID
                End If

                Me._service.ServSaveMobileWareList( _
                    currentPosID, _
                    wareList)


                'wareList.SaveXml(IO.Path.Combine(Me._manifest.TextEdit_MobileSmapPath.Text, MyPosXService.Decls.CTBN_WARE_LIST))

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
        Private Function DoLoadRecpTypeBarcodeList() As String


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
        Private Function DoSaveMobileLocationList() As String


            Try

                'If IO.Directory.Exists(Me._manifest.TextEdit_MobileSmapPath.Text) = False Then
                '    Me._manifest.TextEdit_MobileSmapPath.Select()
                '    Me._manifest.TextEdit_MobileSmapPath.SelectAll()
                '    Return MyPosXService.Decls.MSG_ALERT_00040
                'End If

                'Dim locationList As New MyPosXAuto.FTs.FT_M_MP_POS_LOCATION
                'MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS_LOCATION(Nothing, locationList)

                'locationList.SaveXml(IO.Path.Combine(Me._manifest.TextEdit_MobileSmapPath.Text, MyPosXService.Decls.CTBN_LOCATION_LIST))


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
