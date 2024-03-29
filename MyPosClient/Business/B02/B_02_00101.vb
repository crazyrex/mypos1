Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade

Namespace Business


    Public Class B_02_00101
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
        Private _manifest As Manifest.M_02_00101
        Private _service As MyPosXService.S_02_00101

        Public Enum Affairs
            InitDisplay
            LoadList
            DeleteInfo
            ExportExcel
            PrintTurnoverDtl
            PrintTurnoverView
            UpdateTurnoverStyleFilter
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

            Me._manifest = CType(theManifest, Manifest.M_02_00101)

            Try

                Me._service = MyPosXService.S_02_00101.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_02_00101.GetInstance()
                    Return
                End If

                Window.XLMessageBox.ShowMessage( _
                    ex.Message, _
                    Window.XLMessageBox.MessageType.Wrong, _
                    MessageBoxButtons.OK)
                Me._manifest.Enabled = False

            End Try

            Me._service = MyPosXService.S_02_00101.GetInstance()

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

                Case Affairs.DeleteInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoDeleteInfo)

                Case Affairs.ExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoExportExcel)

                Case Affairs.PrintTurnoverDtl

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoPrintTurnoverDtl)

                Case Affairs.PrintTurnoverView

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoPrintTurnoverView)

                Case Affairs.UpdateTurnoverStyleFilter

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoUpdateTurnoverStyleFilter)


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

                Me._manifest.DateEdit_ToDate.DateTime = CommTK.GetSyncServerTime

                Dim chooseTurnoverTypeList As New MyPosXAuto.FTs.FT_CIV_TURNOVER_TYPE
                Dim choosePosList As New MyPosXAuto.FTs.FT_M_MP_POS
                Dim chooseBalanceStatuslist As New MyPosXAuto.FTs.FT_CIV_BALANCE_STATUS
                Dim chooseTurnoverConsignStatusList As New MyPosXAuto.FTs.FT_CIV_TURNOVER_CONSIGN_STATUS

                Dim sysWareArriveConfirm As Boolean
                Dim sysMoneyArriveConfirm As Boolean
                Dim sysHideFinancials As Boolean
                Dim sysOperationLimitedHere As Boolean = CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_OPERATION_LIMITED_HERE))


                Me._service.ServInitDisplay( _
                    CommDecl.CURRENT_LANGUAGE_OPTION, _
                    sysWareArriveConfirm, _
                    sysMoneyArriveConfirm, _
                    sysHideFinancials)

                MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_TYPEList(CommDecl.CURRENT_LANGUAGE_OPTION, String.Empty, chooseTurnoverTypeList, True)
                MyPosXAuto.Facade.AfCIV.FillCI_BALANCE_STATUSList(CommDecl.CURRENT_LANGUAGE_OPTION, String.Empty, chooseBalanceStatuslist, False)
                MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_CONSIGN_STATUSList(CommDecl.CURRENT_LANGUAGE_OPTION, String.Empty, chooseTurnoverConsignStatusList, False)

                Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = choosePosList.NewM_MP_POSRow
                choosePosList.AddM_MP_POSRow(posRow)
                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, choosePosList)

                Me._manifest.RepositoryItemLookUpEdit_TurnoverType.DataSource = chooseTurnoverTypeList
                Me._manifest.LookUpEdit_TurnoverType.Properties.DataSource = chooseTurnoverTypeList
                Me._manifest.RepositoryItemLookUpEdit_TurnoverStyle.DataSource = Me._manifest.SVFT_CHOOSE_TURNOVER_STYLE_LIST
                Me._manifest.RepositoryItemLookUpEdit_BalanceStatus.DataSource = chooseBalanceStatuslist
                Me._manifest.RepositoryItemLookUpEdit_ConsignStatus.DataSource = chooseTurnoverConsignStatusList
                Me._manifest.LookUpEdit_Pos.Properties.DataSource = choosePosList

                If IsNothing(Utils.Decls.CURRENT_POS_ROW) = False Then
                    Me._manifest.LookUpEdit_Pos.EditValue = Utils.Decls.CURRENT_POS_ROW.POS_ID
                End If

                If sysOperationLimitedHere = True Then
                    Me._manifest.LookUpEdit_Pos.Enabled = False
                End If

                If sysWareArriveConfirm = False Then
                    Me._manifest.ToolStripButton_ConsignQuery.Visible = False
                    Me._manifest.ToolStripButton_DeliveryQuery.Visible = False
                    Me._manifest.GridColumn_TurnoverConsignStatus.Visible = False
                End If

                Me.DoUpdateTurnoverStyleFilter()

                If sysMoneyArriveConfirm = False Then
                    Me._manifest.GridColumn_PayAmount.Visible = False
                    Me._manifest.GridColumn_BalanceStatus.Visible = False
                    Me._manifest.ToolStripButton_PaymentQuery.Visible = False
                End If

                If sysHideFinancials = True Then
                    Me._manifest.ToolStripButton_StaffCommission.Visible = False
                    Me._manifest.GridColumn_SumPrice.Visible = False
                End If

                Dim userFinacialForbiddened As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_FINANCIAL_FORBIDDENED"))

                If userFinacialForbiddened = True Then
                    Me._manifest.ToolStripButton_PaymentQuery.Visible = False
                    Me._manifest.ToolStripButton_StaffCommission.Visible = False
                End If


                '-------------------------------------------
                'Me._manifest.SVFT_CHOOSE_TURNOVER_TYPE_LIST.Clear()
                'MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_TYPEList(String.Empty, Me._manifest.SVFT_CHOOSE_TURNOVER_TYPE_LIST, True)

                'Me._manifest.RepositoryItemLookUpEdit_TurnoverType.DataSource = Me._manifest.SVFT_CHOOSE_TURNOVER_TYPE_LIST
                'Me._manifest.LookUpEdit_TurnoverType.Properties.DataSource = Me._manifest.SVFT_CHOOSE_TURNOVER_TYPE_LIST


                'Dim turnoverStyleList As New MyPosXAuto.FTs.FT_CIV_TURNOVER_STYLE
                'MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList(String.Empty, turnoverStyleList, False)
                'Me._manifest.RepositoryItemLookUpEdit_TurnoverStyle.DataSource = turnoverStyleList

                'Dim balanceStatuslist As New MyPosXAuto.FTs.FT_CIV_BALANCE_STATUS
                'MyPosXAuto.Facade.AfCIV.FillCI_BALANCE_STATUSList(String.Empty, balanceStatuslist, False)
                'Me._manifest.RepositoryItemLookUpEdit_BalanceStatus.DataSource = balanceStatuslist

                'Dim turnoverConsignStatusList As New MyPosXAuto.FTs.FT_CIV_TURNOVER_CONSIGN_STATUS
                'MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_CONSIGN_STATUSList(String.Empty, turnoverConsignStatusList, False)
                'Me._manifest.RepositoryItemLookUpEdit_ConsignStatus.DataSource = turnoverConsignStatusList

                'Me._manifest.DateEdit_ToDate.DateTime = CommTK.GetsyncServerTime

                'Me._manifest.SVFT_CHOOSE_POS_LIST.Clear()
                'Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = Me._manifest.SVFT_CHOOSE_POS_LIST.NewM_MP_POSRow
                'Me._manifest.SVFT_CHOOSE_POS_LIST.AddM_MP_POSRow(posRow)

                'MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, Me._manifest.SVFT_CHOOSE_POS_LIST)
                'Me._manifest.LookUpEdit_Pos.Properties.DataSource = Me._manifest.SVFT_CHOOSE_POS_LIST

                'If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_ARRIVE_CONFIRM)) = False Then
                '    Me._manifest.ToolStripButton_ConsignQuery.Visible = False
                '    Me._manifest.ToolStripButton_DeliveryQuery.Visible = False
                '    Me._manifest.GridColumn_TurnoverConsignStatus.Visible = False
                'End If

                'Me.DoUpdateTurnoverStyleFilter()

                'If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_MONEY_ARRIVE_CONFIRM)) = False Then
                '    Me._manifest.GridColumn_PayAmount.Visible = False
                '    Me._manifest.GridColumn_BalanceStatus.Visible = False
                '    Me._manifest.ToolStripButton_PaymentQuery.Visible = False
                'End If

                'If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_HIDE_FINANCIALS)) = True Then
                '    Me._manifest.ToolStripButton_StaffCommission.Visible = False
                '    Me._manifest.GridColumn_SumPrice.Visible = False
                'End If


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
                Dim turnoverConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                If Me._manifest.SVLM_VIEWING_PAYMENT_CLIENT_ID.Length <= 0 AndAlso Me._manifest.SVLM_VIEWING_PAYMENT_SUPPLIER_ID.Length <= 0 Then
                    turnoverConditions.Add( _
                        AfMV.MV_MP_TURNOVERColumns.TURNOVER_TIMEColumn, _
                        ">=", _
                        CommTK.GetBeginOfDate(Me._manifest.DateEdit_FromDate.DateTime))

                    turnoverConditions.Add( _
                        AfMV.MV_MP_TURNOVERColumns.TURNOVER_TIMEColumn, _
                        "<=", _
                        CommTK.GetEndOfDate(Me._manifest.DateEdit_ToDate.DateTime))

                    If CommTK.FInteger(Me._manifest.LookUpEdit_TurnoverType.EditValue) > 0 Then
                        turnoverConditions.Add( _
                            AfMV.MV_MP_TURNOVERColumns.TURNOVER_TYPEColumn, _
                            "=", _
                            CommTK.FInteger(Me._manifest.LookUpEdit_TurnoverType.EditValue))
                    End If

                    If CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue).Length > 0 Then
                        turnoverConditions.Add( _
                             AfMV.MV_MP_TURNOVERColumns.POS_IDColumn, _
                            "=", _
                            CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue))

                    End If

                    If CommTK.FString(Me._manifest.LookUpEdit_TurnoverStyle.EditValue).Length > 0 Then
                        turnoverConditions.Add( _
                            AfMV.MV_MP_TURNOVERColumns.TURNOVER_STYLEColumn, _
                            "=", _
                            CommTK.FInteger(Me._manifest.LookUpEdit_TurnoverStyle.EditValue))
                    End If

                Else

                    Me._manifest.Panel_Options.Visible = False
                    Me._manifest.Panel_DateRange.Visible = False

                    If Me._manifest.SVLM_VIEWING_PAYMENT_CLIENT_ID.Length > 0 Then
                        turnoverConditions.Add(AfMV.MV_MP_TURNOVERColumns.CLIENT_IDColumn, "=", Me._manifest.SVLM_VIEWING_PAYMENT_CLIENT_ID)
                    Else
                        turnoverConditions.Add(AfMV.MV_MP_TURNOVERColumns.SUPPLIER_IDColumn, "=", Me._manifest.SVLM_VIEWING_PAYMENT_SUPPLIER_ID)
                    End If

                End If


                Me._manifest.SVFT_BINDING_LIST.Clear()
                MyPosXAuto.Facade.AfMV.FillFT_MV_MP_TURNOVER(turnoverConditions, Me._manifest.SVFT_BINDING_LIST)

                Me._manifest.GridControl_Turnover.DataSource = Me._manifest.SVFT_BINDING_LIST

                For Each bindingRow As MyPosXAuto.FTs.FT_MV_MP_TURNOVERRow In Me._manifest.SVFT_BINDING_LIST
                    If bindingRow.TURNOVER_CONSIGN_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_CONSIGN_STATUS_NOT_YET AndAlso _
                        bindingRow.BALANCE_STATUS = MyPosXAuto.Decls.CIVALUE_BALANCE_STATUS_NOT_YET Then
                        bindingRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_ALL_NOT_YET
                    ElseIf bindingRow.TURNOVER_CONSIGN_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_CONSIGN_STATUS_NOT_YET Then
                        bindingRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_TURNOVER_CONSIGN_NOT_YET
                    ElseIf bindingRow.BALANCE_STATUS = MyPosXAuto.Decls.CIVALUE_BALANCE_STATUS_NOT_YET Then
                        bindingRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_BALANCE_NOT_YET
                    End If
                Next




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
        Private Function DoDeleteInfo() As String


            Try

                If CommTK.FBoolean(SysInfo.LoginUserOptions.Options( _
                       Utils.UserOptionsBox.OPN_DELETE_WARE_ALLOWED)) = False Then
                    Return MyPosXService.Decls.MSG_ALERT_00073
                End If

                Dim turnoverRowSE As New MyPosXAuto.FTs.FT_MV_MP_TURNOVERRowSEntity
                Me._manifest.SVFR_SELECTING_ROW.FillSEntity(turnoverRowSE)
                Me._service.ServDeleteInfo( _
                    turnoverRowSE)

                'If Me._manifest.SVFR_SELECTING_ROW.RELIEF_PAIR_ID.Length > 0 Then

                '    If turnoverRowSE.IsNull = False Then

                '        WinTK.OutputLog( _
                '            MyPosXService.Decls.LOG_TITLE_00001, _
                '            String.Format("Bill {0} deleted by By [{1}] at {2:yyyy-MM-dd HH:mm}", _
                '                Me._manifest.SVFR_SELECTING_ROW.TURNOVER_CODE, _
                '                SysInfo.LoginAccount, _
                '                DateTime.Now))

                '    End If

                'End If

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
                        Utils.TK.ExportTurnoverCASA(Me._manifest.SV_EXCEL_FILENAME, Me._manifest.SVFR_SELECTING_ROW.TURNOVER_ID)

                    Case Else
                        Utils.TK.ExportTurnover(Me._manifest.SV_EXCEL_FILENAME, Me._manifest.SVFR_SELECTING_ROW.TURNOVER_ID)
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
        Private Function DoPrintTurnoverDtl() As String


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
        Private Function DoPrintTurnoverView() As String


            Try


                'If Me._manifest.LookUpEdit_TurnoverType.Text = String.Empty Then
                '    Return MyPosXService.Decls.MSG_CONFIRM_00004
                'End If

                Dim turnoverDtlreport As New Reports.R_02_00201
                turnoverDtlreport.PrinterName = Me._manifest.SV_REPORT_PRINTER_NAME

                Dim turnoverDtlRowSE As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRowSEntity
                Dim turnoverDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL

                Dim servResult As String

                servResult = _
                      Me._service.ServPrintTurnoverView( _
                            Me._manifest.SVFR_SELECTING_ROW.TURNOVER_ID, _
                            turnoverDtlRowSE, _
                            turnoverDtlList)

                If servResult.Length > 0 Then
                    Return servResult
                End If

                turnoverDtlreport.XrLabel_Client.Text = Me._manifest.SVFR_SELECTING_ROW.CLIENT_NAME
                turnoverDtlreport.XrLabel_Pos.Text = Me._manifest.SVFR_SELECTING_ROW.POS_NAME
                turnoverDtlreport.XrLabel_Remark.Text = Me._manifest.SVFR_SELECTING_ROW.REMARK
                turnoverDtlreport.XrLabel_Staff.Text = Me._manifest.SVFR_SELECTING_ROW.STAFF_NAME
                turnoverDtlreport.XrLabel_Supplier.Text = Me._manifest.SVFR_SELECTING_ROW.SUPPLIER_NAME

                If Me._manifest.SVFR_SELECTING_ROW.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN Then
                    turnoverDtlreport.XrLabel_Title.Text = "入库单"
                Else
                    turnoverDtlreport.XrLabel_Title.Text = "出库单"
                End If

                turnoverDtlreport.XrLabel_TurnoverCode.Text = Me._manifest.SVFR_SELECTING_ROW.TURNOVER_CODE
                turnoverDtlreport.XrLabel_TurnoverStyle.Text = Me._manifest.SVFR_SELECTING_ROW.TURNOVER_STYLE_TEXT
                turnoverDtlreport.XrLabel_TurnoverTime.Text = CommTK.FString(Me._manifest.SVFR_SELECTING_ROW.TURNOVER_TIME, False, "yyyy-MM-dd")

                Dim sumAmount As Double
                Dim sumCost As Double
                Dim sumPrice As Double

                For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In turnoverDtlList
                    sumAmount += bindingRow.WARE_AMOUNT
                    sumCost += bindingRow.UNIT_COST
                    sumPrice += bindingRow.UNIT_PRICE
                Next

                turnoverDtlreport.XrLabel_TAmount.Text = CommTK.FString(sumAmount)
                turnoverDtlreport.XrLabel_TCost.Text = CommTK.FString(sumCost, False, "#.##")
                turnoverDtlreport.XrLabel_TPrice.Text = CommTK.FString(sumPrice, False, "#.##")

                turnoverDtlreport.DataSource = turnoverDtlList.ReportBindList
                turnoverDtlreport.CreateDataBindings()
                turnoverDtlreport.Print()



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
        Private Function DoUpdateTurnoverStyleFilter() As String


            Try

                Me._manifest.SVFT_CHOOSE_TURNOVER_STYLE_LIST.Clear()
                Me._service.ServUpdateTurnoverStyleFilter( _
                    CommDecl.CURRENT_LANGUAGE_OPTION, _
                    CommTK.FInteger(Me._manifest.LookUpEdit_TurnoverType.EditValue), _
                    Me._manifest.SVFT_CHOOSE_TURNOVER_STYLE_LIST)

                Me._manifest.LookUpEdit_TurnoverStyle.Properties.DataSource = Me._manifest.SVFT_CHOOSE_TURNOVER_STYLE_LIST

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
