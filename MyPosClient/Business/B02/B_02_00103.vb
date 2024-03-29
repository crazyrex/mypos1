Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade

Namespace Business


    Public Class B_02_00103
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
        Private _manifest As Manifest.M_02_00103
        Private _service As MyPosXService.S_02_00103

        Public Enum Affairs
            InitDisplay
            LoadWareByBatchCode
            SaveInfo
            LoadInfo
            UpdateCalculation
            LoadWareByCode
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

            Me._manifest = CType(theManifest, Manifest.M_02_00103)
            Try

                Me._service = MyPosXService.S_02_00103.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_02_00103.GetInstance()
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


                Case Affairs.LoadWareByBatchCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadWareByBatchCode)

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

                Case Affairs.UpdateCalculation

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoUpdateCalculation)

                Case Affairs.LoadWareByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadWareByCode)
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

                Dim chooseTurnoverBookStatuslist As New MyPosXAuto.FTs.FT_CIV_TURNOVER_BOOK_STATUS
                Dim svWareArriveConfirm As Boolean
                Dim svWareArriveByRecipient As Boolean
                Dim svTurnoverMode As Integer
                Dim svHideFinancials As Boolean

                Me._service.ServInitDisplay( _
                    CommDecl.CURRENT_LANGUAGE_OPTION, _
                    chooseTurnoverBookStatuslist, _
                    svWareArriveConfirm, _
                    svWareArriveByRecipient, _
                    svTurnoverMode, _
                    svHideFinancials)

                Me._manifest.LookUpEdit_TurnoverBookStatus.Properties.DataSource = chooseTurnoverBookStatuslist
                Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_BOOK

                If svWareArriveConfirm = False Then
                    Me._manifest.Panel_BookStatus.Visible = False
                    Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND
                ElseIf svWareArriveByRecipient = True Then
                    Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_BOOK
                End If


                If Me._manifest.ButtonEdit_WareCode.Text.Trim.Length > 0 Then

                    Dim result As String = Me.DoLoadWareByCode
                    If result.Length > 0 Then
                        Me._manifest.Enabled = False
                        Return result
                    End If

                End If

                Dim userCostHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_COST_HIDDEN"))
                Dim userPriceHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_PRICE_HIDDEN"))


                Select Case Me._manifest.SVLM_TURNOVER_TYPE
                    Case MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN

                        If Me._manifest.SVLM_TURNOVER_STYLE <> MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RETURNS OrElse _
                            svTurnoverMode = MyPosXService.Decls.WARE_TURNOVER_MODE_NORMAL Then
                            '收货状态或普通出入模式下, 输入货品号

                            Me._manifest.Panel_BatchPart.Visible = False
                            Me._manifest.ButtonEdit_WareCode.Select()
                            Me._manifest.Panel_PricePart.Visible = False
                            Me._manifest.Panel_Sellpart.Visible = False

                            If userCostHidden = True Then
                                Me._manifest.Panel_FinancialPart.Visible = False
                            End If

                        ElseIf Me._manifest.SVLM_TURNOVER_STYLE = MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RETURNS Then
                            '退货时仍然需输入批号
                            Me._manifest.ButtonEdit_WareCode.Properties.ReadOnly = True
                            Me._manifest.ButtonEdit_BatchCode.Select()
                            Me._manifest.FormInputGuarder.SetValidate(Me._manifest.ButtonEdit_BatchCode, InputGuarder.ValidateClassify.Required, Nothing)
                            Me._manifest.FormInputGuarder.RemoveRequiredField(Me._manifest.ButtonEdit_WareCode)

                            If userPriceHidden = True Then
                                Me._manifest.Panel_PricePart.Visible = False
                                Me._manifest.Panel_Sellpart.Visible = False
                            End If

                            If userCostHidden = True Then
                                Me._manifest.Panel_CostPart.Visible = False
                            End If

                        End If

                    Case MyPosXAuto.Decls.CIVALUE_IO_TYPE_OUT

                        Select Case svTurnoverMode
                            Case MyPosXService.Decls.WARE_TURNOVER_MODE_NORMAL
                                Me._manifest.Panel_BatchPart.Visible = False
                                Me._manifest.ButtonEdit_WareCode.Select()

                            Case MyPosXService.Decls.WARE_TURNOVER_MODE_BATCH
                                Me._manifest.ButtonEdit_WareCode.Properties.ReadOnly = True
                                Me._manifest.ButtonEdit_BatchCode.Select()
                                Me._manifest.FormInputGuarder.SetValidate(Me._manifest.ButtonEdit_BatchCode, InputGuarder.ValidateClassify.Required, Nothing)
                                Me._manifest.FormInputGuarder.RemoveRequiredField(Me._manifest.ButtonEdit_WareCode)
                        End Select


                        If userPriceHidden = True Then
                            Me._manifest.Panel_PricePart.Visible = False
                            Me._manifest.Panel_Sellpart.Visible = False
                        End If

                        If userCostHidden = True Then
                            Me._manifest.Panel_CostPart.Visible = False
                        End If

                End Select

                If svHideFinancials = True Then
                    Me._manifest.Panel_FinancialPart.Visible = False
                End If

                If CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_UNIT_PRICE_DISABLED_IN_IO)) = True Then
                    Me._manifest.CalcEdit_UnitPrice.Enabled = False
                End If

                'Me._manifest.SVFT_CHOOSE_TURNOVER_BOOK_STATUS_LIST.Clear()
                'MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_BOOK_STATUSList(String.Empty, Me._manifest.SVFT_CHOOSE_TURNOVER_BOOK_STATUS_LIST, False)
                'Me._manifest.LookUpEdit_TurnoverBookStatus.Properties.DataSource = Me._manifest.SVFT_CHOOSE_TURNOVER_BOOK_STATUS_LIST
                'Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_BOOK

                'If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_ARRIVE_CONFIRM)) = False Then
                '    Me._manifest.Panel_BookStatus.Visible = False
                '    Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_ON_HAND
                'ElseIf CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_ARRIVE_BY_RECIPIENT)) = True Then
                '    Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue = MyPosXAuto.Decls.CIVALUE_TURNOVER_BOOK_STATUS_BOOK
                'End If

                'If Me._manifest.ButtonEdit_WareCode.Text.Trim.Length > 0 Then

                '    Dim result As String = Me.DoLoadWareByCode
                '    If result.Length > 0 Then
                '        Me._manifest.Enabled = False
                '        Return result
                '    End If

                'End If

                'Dim turnoverMode As Integer = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_TURNOVER_MODE))

                'Select Case Me._manifest.SVLM_TURNOVER_TYPE
                '    Case MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN

                '        If Me._manifest.SVLM_TURNOVER_STYLE <> MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RETURNS OrElse _
                '            turnoverMode = MyPosXService.Decls.WARE_TURNOVER_MODE_NORMAL Then
                '            '收货状态或普通出入模式下, 输入货品号

                '            Me._manifest.Panel_BatchPart.Visible = False
                '            Me._manifest.ButtonEdit_WareCode.Select()

                '            Me._manifest.Panel_Sellpart.Visible = False
                '        ElseIf Me._manifest.SVLM_TURNOVER_STYLE = MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_RETURNS Then
                '            '退货时仍然需输入批号
                '            Me._manifest.ButtonEdit_WareCode.Properties.ReadOnly = True
                '            Me._manifest.ButtonEdit_BatchCode.Select()
                '            Me._manifest.FormInputGuarder.SetValidate(Me._manifest.ButtonEdit_BatchCode, InputGuarder.ValidateClassify.Required, Nothing)
                '            Me._manifest.FormInputGuarder.RemoveRequiredField(Me._manifest.ButtonEdit_WareCode)

                '        End If

                '    Case MyPosXAuto.Decls.CIVALUE_IO_TYPE_OUT

                '        Select Case turnoverMode
                '            Case MyPosXService.Decls.WARE_TURNOVER_MODE_NORMAL
                '                Me._manifest.Panel_BatchPart.Visible = False
                '                Me._manifest.ButtonEdit_WareCode.Select()

                '            Case MyPosXService.Decls.WARE_TURNOVER_MODE_BATCH
                '                Me._manifest.ButtonEdit_WareCode.Properties.ReadOnly = True
                '                Me._manifest.ButtonEdit_BatchCode.Select()
                '                Me._manifest.FormInputGuarder.SetValidate(Me._manifest.ButtonEdit_BatchCode, InputGuarder.ValidateClassify.Required, Nothing)
                '                Me._manifest.FormInputGuarder.RemoveRequiredField(Me._manifest.ButtonEdit_WareCode)
                '        End Select

                'End Select

                'If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_HIDE_FINANCIALS)) = True Then
                '    Me._manifest.Panel_FinancialPart.Visible = False
                'End If

                'If CommTK.FBoolean(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_UNIT_PRICE_DISABLED_IN_IO)) = True Then
                '    Me._manifest.CalcEdit_UnitPrice.Enabled = False
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
        Private Function DoLoadWareByBatchCode() As String


            Try

                If Me._manifest.SV_CURRENT_BATCH_CODE = Me._manifest.ButtonEdit_BatchCode.Text Then
                    Me._manifest.CalcEdit_WareAmount.Value += 1
                    Me.DoUpdateCalculation()
                    Return String.Empty
                End If

                Me._manifest.SV_CURRENT_BATCH_CODE = Me._manifest.ButtonEdit_BatchCode.Text

                Dim currentStock As Double
                Dim origionPrice As Decimal

                Dim turnoverDtlRowSEntity As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRowSEntity
                Me._service.ServLoadWareByBatchCode( _
                    Me._manifest.SV_POS_ID, _
                    Me._manifest.ButtonEdit_BatchCode.Text, _
                    turnoverDtlRowSEntity, _
                    currentStock, _
                    origionPrice)

                Me._manifest.ButtonEdit_WareCode.Text = turnoverDtlRowSEntity.WARE_CODE
                Me._manifest.Label_WareID.Text = CommTK.FString(turnoverDtlRowSEntity.WARE_ID)
                Me._manifest.Label_UnitCost.Text = CommTK.FString(turnoverDtlRowSEntity.UNIT_COST)


                Me._manifest.Label_CurrentStock.Text = CommTK.FString(currentStock)
                Me._manifest.CalcEdit_UnitPrice.Value = turnoverDtlRowSEntity.UNIT_PRICE
                Me._manifest.CalcEdit_WareAmount.Value = 1
                Me._manifest.Label_OrigionSinglePrice.Text = CommTK.FString(origionPrice, False, "0.00")

                Me._manifest.CalcEdit_WareAmount.Properties.ReadOnly = turnoverDtlRowSEntity.PRACT_CODE_REQUIRED

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

                Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow = _
                  MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(Me._manifest.Label_WareID.Text)

                If IsNothing(wareRow) = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00010
                End If

                Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                Dim turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow

                If Me._manifest.SV_REVISING_ROW_ID > 0 Then

                    turnoverDtlConditions.Add( _
                        AfXV.XV_H_MP_TURNOVER_DTLColumns.WARE_IDColumn, _
                        "=", _
                        Me._manifest.Label_WareID.Text)

                    turnoverDtlConditions.Add( _
                        AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_BOOK_STATUSColumn, _
                        "=", _
                        Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue)

                    turnoverDtlRow = Me._manifest.SVFT_EDITING_LIST.FindRowByCondition(turnoverDtlConditions)

                    If IsNothing(turnoverDtlRow) = False AndAlso _
                         turnoverDtlRow.ROW_ID <> Me._manifest.SV_REVISING_ROW_ID Then

                        Return MyPosXService.Decls.MSG_ALERT_00020
                    End If


                    turnoverDtlRow = Me._manifest.SVFT_EDITING_LIST.FindRowByRowID(Me._manifest.SV_REVISING_ROW_ID)
                    turnoverDtlRow.WARE_CODE = wareRow.WARE_CODE
                    turnoverDtlRow.CUSTOM_CODE = wareRow.CUSTOM_CODE
                    turnoverDtlRow.WARE_NAME = wareRow.WARE_NAME
                    turnoverDtlRow.SPEC = wareRow.SPEC
                    turnoverDtlRow.MODEL = wareRow.MODEL
                    turnoverDtlRow.SPEC_EN = wareRow.SPEC_EN
                    turnoverDtlRow.MODEL_EN = wareRow.MODEL_EN
                    turnoverDtlRow.ATTRIBUTE1 = wareRow.ATTRIBUTE1
                    turnoverDtlRow.ATTRIBUTE2 = wareRow.ATTRIBUTE2
                    turnoverDtlRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                    turnoverDtlRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                    turnoverDtlRow.WARE_NAME = wareRow.WARE_NAME
                    turnoverDtlRow.WARE_ID = wareRow.WARE_ID
                    turnoverDtlRow.WARE_AMOUNT = Me._manifest.CalcEdit_WareAmount.Value
                    turnoverDtlRow.TURNOVER_BOOK_STATUS = CommTK.FInteger(Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue)
                    turnoverDtlRow.ORIGION_UNIT_PRICE = CommTK.FDecimal(Me._manifest.Label_OrigionSinglePrice.Text)

                    If Me._manifest.SVLM_TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN Then

                        turnoverDtlRow.UNIT_PRICE = turnoverDtlRow.ORIGION_UNIT_PRICE
                        turnoverDtlRow.UNIT_COST = CommTK.FDecimal(Me._manifest.Label_UnitCost.Text)
                        turnoverDtlRow.UNIT_DISCOUNT = 0

                    Else
                        turnoverDtlRow.UNIT_PRICE = Me._manifest.CalcEdit_UnitPrice.Value
                        turnoverDtlRow.UNIT_DISCOUNT = CommTK.FDecimal(Me._manifest.Label_UnitDiscount.Text)
                        turnoverDtlRow.UNIT_COST = CommTK.FDecimal(Me._manifest.Label_UnitCost.Text)
                    End If

                    Return String.Empty

                End If

                turnoverDtlConditions.Add( _
                    AfXV.XV_H_MP_TURNOVER_DTLColumns.WARE_IDColumn, _
                    "=", _
                    Me._manifest.Label_WareID.Text)

                turnoverDtlConditions.Add( _
                    AfXV.XV_H_MP_TURNOVER_DTLColumns.TURNOVER_BOOK_STATUSColumn, _
                    "=", _
                    Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue)

                turnoverDtlRow = Me._manifest.SVFT_EDITING_LIST.FindRowByCondition(turnoverDtlConditions)

                If IsNothing(turnoverDtlRow) = True Then

                    turnoverDtlRow = Me._manifest.SVFT_EDITING_LIST.NewXV_H_MP_TURNOVER_DTLRow
                    Me._manifest.SVFT_EDITING_LIST.AddXV_H_MP_TURNOVER_DTLRow(turnoverDtlRow)

                    turnoverDtlRow.BATCH_CODE = Me._manifest.ButtonEdit_BatchCode.Text
                    turnoverDtlRow.WARE_CODE = wareRow.WARE_CODE
                    turnoverDtlRow.CUSTOM_CODE = wareRow.CUSTOM_CODE
                    turnoverDtlRow.WARE_NAME = wareRow.WARE_NAME
                    turnoverDtlRow.SPEC = wareRow.SPEC
                    turnoverDtlRow.MODEL = wareRow.MODEL
                    turnoverDtlRow.SPEC_EN = wareRow.SPEC_EN
                    turnoverDtlRow.MODEL_EN = wareRow.MODEL_EN
                    turnoverDtlRow.ATTRIBUTE1 = wareRow.ATTRIBUTE1
                    turnoverDtlRow.ATTRIBUTE2 = wareRow.ATTRIBUTE2
                    turnoverDtlRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                    turnoverDtlRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                    turnoverDtlRow.WARE_NAME = wareRow.WARE_NAME
                    turnoverDtlRow.WARE_ID = wareRow.WARE_ID
                    turnoverDtlRow.WARE_AMOUNT = Me._manifest.CalcEdit_WareAmount.Value
                    turnoverDtlRow.TURNOVER_BOOK_STATUS = CommTK.FInteger(Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue)
                    turnoverDtlRow.ORIGION_UNIT_PRICE = CommTK.FDecimal(Me._manifest.Label_OrigionSinglePrice.Text)
                Else
                    turnoverDtlRow.WARE_AMOUNT += Me._manifest.CalcEdit_WareAmount.Value
                End If


                If Me._manifest.SVLM_TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN Then

                    turnoverDtlRow.UNIT_PRICE = turnoverDtlRow.ORIGION_UNIT_PRICE
                    turnoverDtlRow.UNIT_COST = CommTK.FDecimal(Me._manifest.Label_UnitCost.Text)
                    turnoverDtlRow.UNIT_DISCOUNT = 0

                Else
                    turnoverDtlRow.UNIT_PRICE = Me._manifest.CalcEdit_UnitPrice.Value
                    turnoverDtlRow.UNIT_DISCOUNT = CommTK.FDecimal(Me._manifest.Label_UnitDiscount.Text)
                    turnoverDtlRow.UNIT_COST = CommTK.FDecimal(Me._manifest.Label_UnitCost.Text)
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

                If Me._manifest.SV_REVISING_ROW_ID < 0 Then
                    Return String.Empty
                End If


                Dim turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow = _
                    Me._manifest.SVFT_EDITING_LIST.FindRowByRowID(Me._manifest.SV_REVISING_ROW_ID)

                Me._manifest.ButtonEdit_BatchCode.Text = turnoverDtlRow.BATCH_CODE
                Me._manifest.ButtonEdit_WareCode.Text = turnoverDtlRow.WARE_CODE
                Me._manifest.Label_CustomCode.Text = turnoverDtlRow.CUSTOM_CODE
                Me._manifest.Label_WareID.Text = CommTK.FString(turnoverDtlRow.WARE_ID)
                Me._manifest.Label_OrigionSinglePrice.Text = CommTK.FString(turnoverDtlRow.ORIGION_UNIT_PRICE, True)
                Me._manifest.CalcEdit_WareAmount.Value = CommTK.FDecimal(turnoverDtlRow.WARE_AMOUNT)
                Me._manifest.CalcEdit_UnitPrice.Value = turnoverDtlRow.UNIT_PRICE
                Me._manifest.Label_UnitCost.Text = CommTK.FString(turnoverDtlRow.UNIT_COST, True)
                Me._manifest.LookUpEdit_TurnoverBookStatus.EditValue = turnoverDtlRow.TURNOVER_BOOK_STATUS

                Dim currentStockAmount As Double

                Me._service.ServLoadInfo( _
                    Me._manifest.SV_POS_ID, _
                    Me._manifest.Label_WareID.Text, _
                    currentStockAmount)

                Me._manifest.Label_CurrentStock.Text = CommTK.FString(currentStockAmount)

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

                Dim origionPrice As Decimal = CommTK.FDecimal(Me._manifest.Label_OrigionSinglePrice.Text)
                Me._manifest.Label_UnitDiscount.Text = CommTK.FString(origionPrice - Me._manifest.CalcEdit_UnitPrice.Value)
                Me._manifest.Label_SumPrice.Text = _
                    CommTK.FString( _
                        Me._manifest.CalcEdit_WareAmount.Value * Me._manifest.CalcEdit_UnitPrice.Value)
                Me._manifest.Label_TotalDiscount.Text = _
                    CommTK.FString( _
                        CommTK.FDecimal(Me._manifest.Label_UnitDiscount.Text) * Me._manifest.CalcEdit_WareAmount.Value)



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
                Dim currentStockAmount As Double

                Dim priceNoDiscount As Decimal

                Dim servResult As String = _
                    Me._service.ServLoadWareByCode( _
                        Me._manifest.SV_POS_ID, _
                        Me._manifest.ButtonEdit_WareCode.Text, _
                        setDtlRowSEntity, _
                        Me._manifest.SVLM_TURNOVER_STYLE, _
                        currentStockAmount, _
                        priceNoDiscount)

                If servResult.Length > 0 Then
                    Return servResult
                End If

                Me._manifest.ButtonEdit_WareCode.Text = setDtlRowSEntity.WARE_CODE
                Me._manifest.Label_CustomCode.Text = setDtlRowSEntity.CUSTOM_CODE
                Me._manifest.Label_WareID.Text = CommTK.FString(setDtlRowSEntity.WARE_ID)
                Me._manifest.Label_UnitCost.Text = CommTK.FString(setDtlRowSEntity.UNIT_COST)

                Me._manifest.Label_CurrentStock.Text = CommTK.FString(currentStockAmount)

                'Me._manifest.Label_OrigionSinglePrice.Text = CommTK.FString(setDtlRowSEntity.UNIT_PRICE, False, "#,##0.00")
                Me._manifest.CalcEdit_UnitPrice.Value = setDtlRowSEntity.UNIT_PRICE

                Me._manifest.Label_OrigionSinglePrice.Text = CommTK.FString(priceNoDiscount, True, "0.00")
                Me._manifest.CalcEdit_WareAmount.Properties.ReadOnly = setDtlRowSEntity.PRACT_CODE_REQUIRED

                Me.DoUpdateCalculation()

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
