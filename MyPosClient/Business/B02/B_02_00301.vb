Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade

Namespace Business


    Public Class B_02_00301
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
        Private _manifest As Manifest.M_02_00301
        Private _service As MyPosXService.S_02_00301

        Public Enum Affairs
            InitDisplay
            LoadWareByCode
            LoadToPosByCode
            LoadFromPosByCode
            LoadEmployeeByCode
            RemoveInfo
            SaveInfo
            ImportFromMobile
            ValidateAvailableAmount
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

            Me._manifest = CType(theManifest, Manifest.M_02_00301)
            Me._service = MyPosXService.S_02_00301.GetInstance()
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

                Case Affairs.LoadWareByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadWareByCode)

                Case Affairs.LoadToPosByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadToPosByCode)

                Case Affairs.LoadFromPosByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadFromPosByCode)

                Case Affairs.LoadEmployeeByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadEmployeeByCode)

                Case Affairs.RemoveInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoRemoveInfo)

                Case Affairs.SaveInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSaveInfo)

                Case Affairs.ImportFromMobile

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoImportFromMobile)

                Case Affairs.ValidateAvailableAmount

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoValidateAvailableAmount)

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
                Me._manifest.SVFT_CHOOSE_TURNOVER_BOOK_STATUS_LIST.Clear()
                Dim sysWareArriveConfirm As Boolean
                Dim sysHideFinancial As Boolean
                Dim sysSpecModelDiscard As Boolean
                Dim sysOperationLimitedHere As Boolean = CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_OPERATION_LIMITED_HERE))

                Dim staffRowSEntity As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity

                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Me._service.ServInitDisplay( _
                    CommDecl.CURRENT_LANGUAGE_OPTION, _
                    Utils.Decls.LOGIN_STAFF_ID, _
                    Me._manifest.SVFT_CHOOSE_POS_LIST, _
                    staffRowSEntity, _
                    Me._manifest.SVFT_CHOOSE_TURNOVER_BOOK_STATUS_LIST, _
                    sysWareArriveConfirm, _
                    sysHideFinancial, _
                    sysSpecModelDiscard, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                Me._manifest.LookUpEdit_FromLocation.Properties.DataSource = Me._manifest.SVFT_CHOOSE_POS_LIST
                Me._manifest.LookUpEdit_ToLocation.Properties.DataSource = Me._manifest.SVFT_CHOOSE_POS_LIST

                Me._manifest.RepositoryItemLookUpEdit_TurnoverBookStatus.DataSource = Me._manifest.SVFT_CHOOSE_TURNOVER_BOOK_STATUS_LIST

                If IsNothing(Utils.Decls.CURRENT_POS_ROW) = False Then
                    Me._manifest.LookUpEdit_FromLocation.EditValue = Utils.Decls.CURRENT_POS_ROW.POS_ID
                End If

                If sysOperationLimitedHere = True Then
                    Me._manifest.LookUpEdit_FromLocation.Enabled = False
                End If


                If staffRowSEntity.IsNull = True Then
                    Me._manifest.ButtonEdit_EmployeeCode.Text = staffRowSEntity.STAFF_CODE
                    Me._manifest.Label_EmployeeName.Text = staffRowSEntity.STAFF_NAME
                    Me._manifest.Label_EmployeeID.Text = CommTK.FString(staffRowSEntity.STAFF_ID)
                End If


                If sysWareArriveConfirm = False Then
                    Me._manifest.Panel_ArrivalPart.Visible = False
                    Me._manifest.CheckEdit_ConfirmArrivalDone.Checked = True
                    Me._manifest.LinkLabel_AllBooking.Visible = False
                    Me._manifest.LinkLabel_AllOnhand.Visible = False
                    Me._manifest.GroupControl_Info.Height -= Me._manifest.Panel_ArrivalPart.Height
                    Me._manifest.GridColumn_TurnoverBookStatus.Visible = False

                End If

                If sysHideFinancial = True Then
                    Me._manifest.CheckEdit_ConfirmPaymentDone.Visible = False
                    Me._manifest.CheckEdit_ConfirmPaymentDone.Checked = True
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

                If sysSpecModelDiscard = True Then
                    Me._manifest.GridColumn_Spec.Visible = False
                    Me._manifest.GridColumn_Model.Visible = False
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
        Private Function DoLoadWareByCode() As String


            Try

                Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
                wareCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", Me._manifest.ButtonEdit_WareCode.Text)

                Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow = _
                    MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareCondition)

                If IsNothing(wareRow) = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00004
                End If

                Me._manifest.ButtonEdit_WareCode.Text = wareRow.WARE_CODE
                Me._manifest.Label_CustomCode.Text = wareRow.CUSTOM_CODE
                Me._manifest.Label_WareID.Text = CommTK.FString(wareRow.WARE_ID)

                If Me._manifest.CheckEdit_ShowDetailInput.Checked = False Then

                    Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
                    turnoverDtlConditions.Add(AfXV.XV_H_MP_TURNOVER_DTLColumns.WARE_IDColumn, "=", wareRow.WARE_ID)

                    Dim bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow = _
                        Me._manifest.SVFT_BINDING_LIST.FindRowByCondition(turnoverDtlConditions)

                    If IsNothing(bindingRow) = False Then
                        If bindingRow.TURNOVER_BOOK_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND Then
                            bindingRow.WARE_AMOUNT += 1
                        End If
                    Else
                        bindingRow = Me._manifest.SVFT_BINDING_LIST.NewXV_H_MP_TURNOVER_DTLRow
                        Me._manifest.SVFT_BINDING_LIST.AddXV_H_MP_TURNOVER_DTLRow(bindingRow)

                        bindingRow.WARE_CODE = Me._manifest.ButtonEdit_WareCode.Text
                        bindingRow.CUSTOM_CODE = wareRow.CUSTOM_CODE
                        bindingRow.WARE_NAME = wareRow.WARE_NAME
                        bindingRow.WARE_ID = CommTK.FString(Me._manifest.Label_WareID.Text)
                        bindingRow.SPEC = wareRow.SPEC
                        bindingRow.MODEL = wareRow.MODEL
                        bindingRow.ATTRIBUTE1 = wareRow.ATTRIBUTE1
                        bindingRow.ATTRIBUTE2 = wareRow.ATTRIBUTE2
                        bindingRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                        bindingRow.ATTRIBUTE4 = wareRow.ATTRIBUTE4
                        bindingRow.UNIT_NAME = wareRow.UNIT_NAME
                        bindingRow.REMARK = wareRow.REMARK
                        bindingRow.WARE_AMOUNT = 1
                        bindingRow.TURNOVER_BOOK_STATUS = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND

                    End If

                End If


                'Dim setDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_POS_SET_WARE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
                ''setDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_POS_SET_WAREColumns.WARE_CODEColumn, "=", Me._manifest.ButtonEdit_WareCode.Text)
                'setDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", CommTK.FInteger(Me._manifest.Label_ToPosID.Text))

                'Dim setDtlRow As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERow = _
                '    MyPosXAuto.Facade.AfXV.GetXV_S_MP_POS_SET_WARERow(setDtlConditions)

                'If IsNothing(setDtlRow) = True Then
                '    Return MyPosXService.Decls.MSG_ALERT_00004
                'End If

                ''Me._manifest.ButtonEdit_WareCode.Text = setDtlRow.WARE_CODE
                ''Me._manifest.Label_WareName.Text = setDtlRow.WARE_NAME
                ''Me._manifest.Label_WareID.Text = CommTK.FString(setDtlRow.WARE_ID)

                'Dim turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow = _
                '    Me._manifest.SVFT_BINDING_LIST.NewXV_H_MP_TURNOVER_DTLRow
                'Me._manifest.SVFT_BINDING_LIST.AddXV_H_MP_TURNOVER_DTLRow(turnoverDtlRow)

                'turnoverDtlRow.WARE_CODE = setDtlRow.WARE_CODE
                'turnoverDtlRow.WARE_NAME = setDtlRow.WARE_NAME
                'turnoverDtlRow.SPEC = setDtlRow.SPEC
                'turnoverDtlRow.MODEL = setDtlRow.MODEL
                'turnoverDtlRow.UNIT_NAME = setDtlRow.UNIT_NAME
                'turnoverDtlRow.UNIT_PRICE = setDtlRow.UNIT_PRICE
                'turnoverDtlRow.WARE_ID = setDtlRow.WARE_ID
                'turnoverDtlRow.WARE_AMOUNT = 1
                'turnoverDtlRow.SUM_PRICE = CommTK.FInteger(turnoverDtlRow.UNIT_PRICE * turnoverDtlRow.WARE_AMOUNT)


                'Me._manifest.GridControl_TurnoverDtl.DataSource = Me._manifest.SVFT_BINDING_LIST


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
        Private Function DoLoadToPosByCode() As String


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
        Private Function DoLoadFromPosByCode() As String


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
        Private Function DoLoadEmployeeByCode() As String


            Try

                Dim staffConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_STAFF(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
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
        Private Function DoRemoveInfo() As String


            Try

                Me._manifest.SVFR_SELECTING_ROW.Delete()

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

                Dim validateResult As String = String.Empty
                Dim inTurnoverCode As String = Me._manifest.TextEdit_InTurnoverCode.Text
                Dim outTurnoverCode As String = Me._manifest.TextEdit_OutTurnoverCode.Text

                Dim servResult As String = _
                   Me._service.ServSaveInfo( _
                        CommTK.FString(Me._manifest.LookUpEdit_FromLocation.EditValue), _
                        CommTK.FString(Me._manifest.LookUpEdit_ToLocation.EditValue), _
                        Me._manifest.DateEdit_ConsignDueDate.DateTime, _
                        Me._manifest.Label_EmployeeID.Text, _
                        Me._manifest.CheckEdit_ConfirmArrivalDone.Checked, _
                        Me._manifest.CheckEdit_ConfirmPaymentDone.Checked, _
                        inTurnoverCode, _
                        outTurnoverCode, _
                        Me._manifest.SVFT_BINDING_LIST, _
                        validateResult)

                Me._manifest.GridControl_TurnoverDtl.DataSource = Me._manifest.SVFT_BINDING_LIST

                If validateResult.Length > 0 Then
                    Return validateResult
                End If

                If servResult.Length > 0 Then
                    Return servResult
                End If

                Me._manifest.TextEdit_InTurnoverCode.Text = inTurnoverCode
                Me._manifest.TextEdit_OutTurnoverCode.Text = outTurnoverCode

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

                Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
                    MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(CommTK.FString(Me._manifest.LookUpEdit_FromLocation.EditValue))

                If IsNothing(posRow) = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00027
                End If

                Dim readTurnoverDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL
                Dim turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow
                Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

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
                        CommTK.FString(Me._manifest.LookUpEdit_FromLocation.EditValue), _
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
        Private Function DoValidateAvailableAmount() As String


            Try


                Dim validateResult As String = String.Empty

                Me._manifest.SVFT_BINDING_LIST.ResetRowHighlighting()

                Dim servResult As String = _
                    Me._service.ServValidateAvailableAmount( _
                        CommTK.FString(Me._manifest.LookUpEdit_FromLocation.EditValue), _
                        Me._manifest.SVFT_BINDING_LIST, _
                        validateResult)

                If servResult.length > 0 Then
                    Return servResult
                End If

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
