
'===========================================================
'Code generated by Highsoft Solution
'-----------------------------------------------------------
'业务操作, 出入管理
'
'Programmed by:
'    Darlin
'
'Created at:
'    2008-05-09
'
'Function summarize:
'
'
'
'===========================================================
Imports System.Xml
Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports DevExpress.XtraPrinting

Namespace Manifest

    Partial Public Class M_02_00101

#Region "Prerequested Inits"

#Region "Shared values"
        '
        'Shared Value, 用于与其它窗体交换数值的情况下, 需要自己根据需要更改命名
        '原则上所有UTLD的变量不能出现在成品中, 在确定不需要的情况下应删除UTLD
        '-------------------------------------------------------------------
        Public SV_EXCEL_FILENAME As String = String.Empty
        Public SV_TURNOVER_TYPE As Integer = -1

        Public SV_REPORT_PRINTER_NAME As String = String.Empty

        'Public  As String ="SV_UTLD_0003"
        'Public SV_UTLD_0004 As String ="SV_UTLD_0004"
        'Public SV_UTLD_0005 As String ="SV_UTLD_0005"

        '读取,显示数据的条件值变量
        Public SVLM_VIEWING_PAYMENT_CLIENT_ID As String = String.empty
        Public SVLM_VIEWING_PAYMENT_SUPPLIER_ID As String = String.empty
        'Public SVLM_UTLD_0002 As String ="SVLM_UTLD_0002"

        '数据列表变量
        Public SVFT_BINDING_LIST As New MyPosXAuto.FTs.FT_MV_MP_TURNOVER
        Public SVFT_CHOOSE_TURNOVER_STYLE_LIST As New MyPosXAuto.FTs.FT_CIV_TURNOVER_STYLE

        Public SVFR_SELECTING_ROW As MyPosXAuto.FTs.FT_MV_MP_TURNOVERRow
        'Public SVFR_SELECTING_TURNOVER_DTL_ROW As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow

#End Region


#Region "Private values"

        'Private PV_UTLD_0001 As String =""
        'Private PV_UTLD_0002 As String =""
        'Private PV_UTLD_0003 As String =""
        'Private PV_UTLD_0004 As String =""
        'Private PV_UTLD_0005 As String =""

#End Region
        'Launch Conditions
        '-------------------------------------------------------------------

        Public LAUNCH_CONDITION As MyPosXService.S_02_00101.LCs


        Public Overrides Sub SetLC(ByVal LCName As String)

            Me._launchCondition = LCName
            Me.LAUNCH_CONDITION = CType(System.Enum.Parse(GetType(MyPosXService.S_02_00101.LCs), LCName), MyPosXService.S_02_00101.LCs)

        End Sub

        Public Sub InvokeBizRequest(ByVal affair As Business.B_02_00101.Affairs, ByVal sychronized As Boolean)

            Me._bizAgent.DoRequest(affair, sychronized)

        End Sub

        Private WithEvents _bizAgent As Business.B_02_00101

        Public Sub New(ByVal transactRequestHandle As TransactRequest, ByVal formID As Integer)

            MyBase.New(transactRequestHandle, formID)

            '该调用是 Windows 窗体设计器所必需的。
            InitializeComponent()


            '在 InitializeComponent() 调用之后添加任何初始化
            Me.SetAuthorName("QDF")

            Me.InitializeMe(New Business.B_02_00101(Me), "业务操作", "出入管理", False)
            Me._bizAgent = CType(Me.BizAgent, Business.B_02_00101)

        End Sub

#End Region

#Region "Basic overrides"

        Protected Overrides Sub IA_InitBeforeRC()

            Me.SetKeyJumpCycle(Keys.Enter, True)
            Me.SetValueEditControls()
            'Me.SetToolStripButtonFunctionKey(Me.ToolStripButton_Close, Keys.F12)

            'Me.FormInputGuarder.SetValidate(Me.TextEdit_Input, InputGuarder.ValidateClassify.Required, Nothing)

            'Me.FormInputGuarder.SetInputLinkedLabel(Me.ButtonEdit_Code, Me.Label_Name, Me.Label_ID)

            'Me._bizAgent.SetDisableControlUnderRequest(Me.DisableControlUnderRequest)

            'me._bizAgent.SetRequestActionTitle(action, title)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_XXX, AddressOf Me.TbActionXXXX

            '指定需要备份值的控件
            Me.SetValueBackupControl(Me.DateEdit_FromDate)
            Me.SetValueBackupControl(Me.LookUpEdit_TurnoverType)
            ''''Me.ToolStrip_Form.ButtonSize = New Size(1, 1)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Create, AddressOf Me.TbActionCreate)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Revise, AddressOf Me.TbActionEdit)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Delete, AddressOf Me.TbActionDelete)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Refresh, AddressOf Me.TbActionRefresh)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Close, AddressOf Me.TbActionClose)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Choose, AddressOf Me.TbActionChoose)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_ExportExcel, AddressOf Me.TbActionExportExcel)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_ConsignQuery, AddressOf Me.TbActionConsignQuery)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_DeliveryQuery, AddressOf Me.TbActionDeliveryQuery)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_PaymentQuery, AddressOf Me.TbActionPaymentQuery)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_StaffCommission, AddressOf Me.TbActionStaffCommission)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Print, AddressOf Me.TbActionPrint)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0010, AddressOf Me.TbActionUtld0010)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0011, AddressOf Me.TbActionUtld0011)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0012, AddressOf Me.TbActionUtld0012)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0013, AddressOf Me.TbActionUtld0013)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0014, AddressOf Me.TbActionUtld0014)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0015, AddressOf Me.TbActionUtld0015)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0016, AddressOf Me.TbActionUtld0016)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0017, AddressOf Me.TbActionUtld0017)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0018, AddressOf Me.TbActionUtld0018)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0019, AddressOf Me.TbActionUtld0019)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0020, AddressOf Me.TbActionUtld0020)


        End Sub


        Protected Overrides Sub IA_InitAfterRC()

            Me.DateEdit_FromDate.DateTime = CommTK.GetSyncServerTime
            Me.DateEdit_ToDate.DateTime = CommTK.GetSyncServerTime


            '做根据LaunchCondition判断分支的相关动作, 如控件的显示不显示, 必填不必填

            Select Case Me.LAUNCH_CONDITION
                Case MyPosXService.S_02_00101.LCs.Choose
                    Me.ToolStripButton_Choose.Visible = True

            End Select

            'Initialize option list controls which value source isn't from the edit form content

            Me.DoPrivateUpdateSelectingValues()

            ''''Me.ToolStrip_Form.ButtonSize = New Size(1, 1)
            Me._bizAgent.DoRequest(Business.B_02_00101.Affairs.InitDisplay, False)

            'Me.GridControl_.DataSource = Me.SVFT_BINDING_
            'Me.LookupEdit_.Properties.DataSource = Me.SVFT_CHOOSE_

        End Sub


        Protected Overrides Sub IA_ClearContent(Optional ByVal clearKeyFields As Boolean = False)


            'Initialize option list controls which value source is from the edit form content


            'Me.TextEdit_Input.ResetText()



            Me.TextEdit_Search.Select()


            '做根据LaunchCondition判断分支的相关动作





            '清空编辑模式, 避免在清空操作后发生类似"数据以改变, 是否要求存盘"的这类询问。
            '所有的控件相关操作不要写到这句话下面去
            '如果有DoRequest相关的控件操作, 要把下面这句话复制到操作结束的成功反应动作中去
            Me.ResetSaveMode()

        End Sub



        '
        '窗体内显示业务数据操作
        '-------------------------------------------------------------------
        Protected Overrides Sub IA_AfterFormLoad()


            '
            '对于列表画面
            '-------------------------------------------------------------------

            Me.UpdateDisplay()


        End Sub


        Public Overrides Sub IA_RespDialog(ByVal responseTitle As String, ByVal popupForm As XL.Win.Component.BaseForm)

            Select Case responseTitle
                Case "TbActionCreate", "TbActionEdit", "TbActionTurnoverConsign"
                    Me.UpdateDisplay()
                    Me.GridView_Turnover.BestFitColumns()

                Case "TbActionConsignQuery"
                    Dim queryForm As M_02_00111 = CType(popupForm, M_02_00111)
                    If queryForm.SV_NEW_CONSIGN_CREATED = True Then
                        Me.UpdateDisplay()
                    End If

                Case "TbActionPrint"

                    Dim optionForm As XForm.Manifest.M_ReportOptions = CType(popupForm, XForm.Manifest.M_ReportOptions)
                    Select Case optionForm.SV_SELECTING_OPTION.Name
                        Case MyPosXService.Decls.REPORT_NAME_TURNOVER_INFO
                            Me.SV_REPORT_PRINTER_NAME = optionForm.SV_PRINTER_NAME
                            Me._bizAgent.DoRequest(Business.B_02_00101.Affairs.PrintTurnoverView, False)
                        Case MyPosXService.Decls.REPORT_NAME_TURNOVER_LIST
                            Dim printableComponentLink1 As New PrintableComponentLink(New PrintingSystem())
                            printableComponentLink1.Component = Me.GridControl_Turnover
                            printableComponentLink1.CreateDocument()
                            printableComponentLink1.Print(optionForm.SV_PRINTER_NAME)
                            Me.GridControl_Turnover.Print()
                    End Select


            End Select
        End Sub


        Protected Overrides Sub IA_SavedModeChanged(ByVal savedMode As Boolean)


        End Sub


        Public Overrides Sub KeyDownProcess(ByVal e As System.Windows.Forms.KeyEventArgs)
            'If e.KeyCode = Keys.XXXX Then

            'End If
        End Sub


        Public Overrides Function SaveInfo(ByVal doConfirm As Boolean) As Boolean


            Dim validateInputResult As String = Me.ValidateInput()

            If validateInputResult.Length > 0 Then
                Me.ShowStatusMessage(StatusMessageIcon.Alert, validateInputResult)
                Return False
            End If

            '
            '判断输入内容的合法性, 如果不合法就提醒后终止保存
            '-------------------------------------------------------------------
            If Me.DoInputValidate(True) = False Then
                Return False
            End If


            '
            '进行保存操作
            '-------------------------------------------------------------------

            'me._bizAgent.DoRequest(


            '
            '保存操作结束后重置保存状态
            '-------------------------------------------------------------------

        End Function


        Public Overrides Sub UpdateDisplay()

            Me._bizAgent.DoRequest(Business.B_02_00101.Affairs.LoadList, False)

        End Sub

        Public Overrides Function IA_BeforeClose() As Boolean



            'Me.SVDS_UTLD.Dispose
            'Me.SVFT_UTLD.Dispose

            Return True

        End Function

        Public Overrides Function ValidateInput() As String

            Return String.Empty

        End Function

#End Region

#Region "Event Processes"

        Private Sub _bizAgent_Responded(ByVal responseResult As XL.Win.Component.BaseAgent.AgentResponse) Handles _bizAgent.Responded

            Dim operResult As String = CommTK.FString(responseResult.GetValue(WinDecl.RVN_SUCCEED))

            '
            '操作不成功的情况下, 用出对话框报告操作不成功的原因
            '-------------------------------------------------------------------
            Me._bizAgent.EnableControlsUnderRequest(Me._bizAgent.AffairOf(responseResult.ResponseTitle))

            If operResult.Length > 0 Then

                Select Case Me._bizAgent.AffairOf(responseResult.ResponseTitle)              'transaction cases under error


                End Select

                XL.Win.Window.XLMessageBox.ShowMessage(operResult, Window.XLMessageBox.MessageType.Wrong, MessageBoxButtons.OK)

                Return
            End If

            '
            '操作成功的情况下, 继续下面的成功后处理
            '-------------------------------------------------------------------

            Select Case Me._bizAgent.AffairOf(responseResult.ResponseTitle)
                Case Business.B_02_00101.Affairs.LoadList
                    Me.GridView_Turnover.BestFitColumns()

                Case Business.B_02_00101.Affairs.DeleteInfo
                    Me.UpdateDisplay()

                Case Business.B_02_00101.Affairs.ExportExcel
                    If XL.Win.Window.XLMessageBox.ShowMessage( _
                            MyPosXService.Decls.MSG_CONFIRM_00003, _
                            Window.XLMessageBox.MessageType.Information, _
                            MessageBoxButtons.YesNo) = DialogResult.No Then
                        Return
                    End If

                    CommTK.LaunchApplication(Nothing, Me.SV_EXCEL_FILENAME, False)

            End Select
        End Sub

        Private Sub Timer_Surveillant_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Surveillant.Tick

        End Sub

        Private Sub TextEdit_Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit_Search.KeyDown
            If e.KeyCode = Keys.Enter Then
                WinTK.SearchGridViewText(Me.GridView_Turnover, Me.TextEdit_Search.Text, True)
                Me.TextEdit_Search.SelectAll()
            End If
        End Sub

        Private Sub GridView_Turnover_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView_Turnover.FocusedRowChanged
            Me.DoPrivateUpdateSelectingValues()
        End Sub

        Private Sub GridView_Turnover_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView_Turnover.DoubleClick
            Me.TbActionEdit()
        End Sub

        Private Sub LookUpEdit_TurnoverType_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookUpEdit_TurnoverType.EditValueChanged

            If Me.FormStatus <> Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded Then
                Return
            End If

            Me._bizAgent.DoRequest(Business.B_02_00101.Affairs.UpdateTurnoverStyleFilter, True)

        End Sub

        Private Sub ToolStripMenuItem_CopyTurnoverCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_CopyTurnoverCode.Click

            If IsNothing(Me.SVFR_SELECTING_ROW) = False Then
                Clipboard.SetText(Me.SVFR_SELECTING_ROW.TURNOVER_CODE)
            End If

        End Sub

#End Region

#Region "ToolStrip Actions"


        Private Sub TbActionCreate()

            Dim inputForm As New M_02_00102(Me.TransactRequestHandle, Me.FormID)
            Me.PopupForm(inputForm, "TbActionCreate", True)

        End Sub

        Private Sub TbActionEdit()

            Dim inputForm As New M_02_00102(Me.TransactRequestHandle, Me.FormID)
            If Me.SVFR_SELECTING_ROW.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN Then
                inputForm.LAUNCH_CONDITION = MyPosXService.S_02_00102.LCs.Deposit
            ElseIf Me.SVFR_SELECTING_ROW.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_IO_TYPE_OUT Then
                inputForm.LAUNCH_CONDITION = MyPosXService.S_02_00102.LCs.Withdraw
            End If
            inputForm.SVLM_TURNOVER_TYPE = Me.SVFR_SELECTING_ROW.TURNOVER_TYPE
            inputForm.SVLM_EDITING_TURNOVER_STYLE = Me.SVFR_SELECTING_ROW.TURNOVER_STYLE

            inputForm.SV_EDITING_TURNOVER_ID = Me.SVFR_SELECTING_ROW.TURNOVER_ID
            Me.PopupForm(inputForm, "TbActionEdit", True)

        End Sub

        Private Sub TbActionDelete()

            If Window.XLMessageBox.ShowMessage( _
                 MyPosXService.Decls.MSG_CONFIRM_00002, _
                 Window.XLMessageBox.MessageType.Warning, _
                 MessageBoxButtons.OKCancel) = _
                 DialogResult.Cancel Then
                Return
            End If

            Me._bizAgent.DoRequest(Business.B_02_00101.Affairs.DeleteInfo, False)

        End Sub

        Private Sub TbActionRefresh()

            Me.UpdateDisplay()

        End Sub

        Private Sub TbActionView()

            Dim inputForm As New M_02_00102(Me.TransactRequestHandle, Me.FormID)

            inputForm.SVLM_TURNOVER_TYPE = Me.SVFR_SELECTING_ROW.TURNOVER_TYPE
            inputForm.SV_EDITING_TURNOVER_ID = Me.SVFR_SELECTING_ROW.TURNOVER_ID
            inputForm.LAUNCH_CONDITION = MyPosXService.S_02_00102.LCs.View

            Me.PopupForm(inputForm, "TbActionView", True)


        End Sub

        Private Sub TbActionClose()

            Me.CloseForm()

        End Sub


        Private Sub TbActionChoose()

            If Me.GridView_Turnover.RowCount = 0 Then
                Return
            End If

            Me.ResponseToParentForm()
            Me.CloseForm()

        End Sub


        Private Sub TbActionExportExcel()

            If Me.SaveFileDialog_ExportExcel.ShowDialog = DialogResult.Cancel Then
                Return
            End If

            Me.SV_EXCEL_FILENAME = Me.SaveFileDialog_ExportExcel.FileName
            Me._bizAgent.DoRequest(Business.B_02_00101.Affairs.ExportExcel, False)

        End Sub




        'Private Sub TbActionTurnoverConsign()
        '    Dim inputForm As New M_02_00104(Me.TransactRequestHandle, Me.FormID)
        '    inputForm.SV_SELECTING_TURNOVER_ID = Me.SVFR_SELECTING_ROW.TURNOVER_ID
        '    Me.PopupForm(inputForm, "TbActionTurnoverConsign", False)
        'End Sub


        Private Sub TbActionConsignQuery()

            Dim queryForm As New M_02_00111(Me.TransactRequestHandle, Me.FormID)
            queryForm.SV_TURNOVER_ID = Me.SVFR_SELECTING_ROW.TURNOVER_ID
            Me.PopupForm(queryForm, "TbActionConsignQuery", True)

        End Sub


        Private Sub TbActionDeliveryQuery()

            Dim inputForm As New M_02_00107(Me.TransactRequestHandle, Me.FormID)
            inputForm.SV_TURNOVER_ID = Me.SVFR_SELECTING_ROW.TURNOVER_ID
            Me.PopupForm(inputForm, "TbActionDeliveryQuery", True)

        End Sub


        Private Sub TbActionPaymentQuery()

            Dim inputForm As New M_02_00105(Me.TransactRequestHandle, Me.FormID)
            inputForm.SV_TURNOVER_ID = Me.SVFR_SELECTING_ROW.TURNOVER_ID
            Me.PopupForm(inputForm, "TbActionPaymentQuery", True)


        End Sub

        Private Sub TbActionStaffCommission()

            Dim inputForm As New M_02_00109(Me.TransactRequestHandle, Me.FormID)
            inputForm.SV_TURNOVER_ID = Me.SVFR_SELECTING_ROW.TURNOVER_ID
            Me.PopupForm(inputForm, "TbActionStaffCommission", True)

        End Sub


        Private Sub TbActionPrint()

            Dim optionForm As New XForm.Manifest.M_ReportOptions(Me.TransactRequestHandle, Me.FormID)
            optionForm.SV_OPTIONS.Add(New XForm.ReportOption(MyPosXService.Decls.REPORT_NAME_TURNOVER_INFO, XForm.ReportOption.PrintType.Print, True))
            optionForm.SV_OPTIONS.Add(New XForm.ReportOption(MyPosXService.Decls.REPORT_NAME_TURNOVER_LIST, XForm.ReportOption.PrintType.Print, True))
            Me.PopupForm(optionForm, "TbActionPrint", False)


        End Sub


        Private Sub TbActionUtld0010()

        End Sub


        Private Sub TbActionUtld0011()

        End Sub


        Private Sub TbActionUtld0012()

        End Sub


        Private Sub TbActionUtld0013()

        End Sub


        Private Sub TbActionUtld0014()

        End Sub


        Private Sub TbActionUtld0015()

        End Sub


        Private Sub TbActionUtld0016()

        End Sub


        Private Sub TbActionUtld0017()

        End Sub


        Private Sub TbActionUtld0018()

        End Sub


        Private Sub TbActionUtld0019()

        End Sub


        Private Sub TbActionUtld0020()

        End Sub


#End Region

#Region "Private Methods"


        Private Sub DoPrivateUpdateSelectingValues()

            Me.SVFR_SELECTING_ROW = Nothing

            If Me.GridView_Turnover.RowCount > 0 Then
                Me.SVFR_SELECTING_ROW = CType( _
                    Me.GridView_Turnover.GetDataRow( _
                    Me.GridView_Turnover.FocusedRowHandle),  _
                    MyPosXAuto.FTs.FT_MV_MP_TURNOVERRow)
            End If

            Me.ToolStripButton_Choose.Enabled = False
            Me.ToolStripButton_Revise.Enabled = False
            Me.ToolStripButton_Delete.Enabled = False
            Me.ToolStripButton_ConsignQuery.Enabled = False
            Me.ToolStripButton_DeliveryQuery.Enabled = False
            Me.ToolStripButton_PaymentQuery.Enabled = False
            Me.ToolStripButton_StaffCommission.Enabled = False
            Me.ToolStripButton_Print.Enabled = False

            If IsNothing(Me.SVFR_SELECTING_ROW) = True Then
                Return
            End If

            Me.ToolStripButton_Choose.Enabled = True
            Me.ToolStripButton_Print.Enabled = True
            If Me.SVFR_SELECTING_ROW.TURNOVER_STYLE <> MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_CHECK_REPLACE Then
                Me.ToolStripButton_Revise.Enabled = True
                Me.ToolStripButton_Delete.Enabled = True
            End If

            If Me.SVFR_SELECTING_ROW.TURNOVER_STYLE <> MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_CHECK_REPLACE Then
                Me.ToolStripButton_ConsignQuery.Enabled = True
                Me.ToolStripButton_DeliveryQuery.Enabled = True
                Me.ToolStripButton_PaymentQuery.Enabled = True
                Me.ToolStripButton_StaffCommission.Enabled = True
            End If


        End Sub


        Private Sub DoPrivateUtld0002()

        End Sub


        Private Sub DoPrivateUtld0003()

        End Sub


        Private Sub DoPrivateUtld0004()

        End Sub


        Private Sub DoPrivateUtld0005()

        End Sub


        Private Sub DoPrivateUtld0006()

        End Sub


        Private Sub DoPrivateUtld0007()

        End Sub


        Private Sub DoPrivateUtld0008()

        End Sub


        Private Sub DoPrivateUtld0009()

        End Sub


        Private Sub DoPrivateUtld0010()

        End Sub


        Private Sub DoPrivateUtld0011()

        End Sub


        Private Sub DoPrivateUtld0012()

        End Sub


        Private Sub DoPrivateUtld0013()

        End Sub


        Private Sub DoPrivateUtld0014()

        End Sub


        Private Sub DoPrivateUtld0015()

        End Sub


        Private Sub DoPrivateUtld0016()

        End Sub


        Private Sub DoPrivateUtld0017()

        End Sub


        Private Sub DoPrivateUtld0018()

        End Sub


        Private Sub DoPrivateUtld0019()

        End Sub


        Private Sub DoPrivateUtld0020()

        End Sub


#End Region

#Region "Public Methods"


        Public Sub DoPublicUtld0001()

        End Sub


        Public Sub DoPublicUtld0002()

        End Sub


        Public Sub DoPublicUtld0003()

        End Sub


        Public Sub DoPublicUtld0004()

        End Sub


        Public Sub DoPublicUtld0005()

        End Sub


        Public Sub DoPublicUtld0006()

        End Sub


        Public Sub DoPublicUtld0007()

        End Sub


        Public Sub DoPublicUtld0008()

        End Sub


        Public Sub DoPublicUtld0009()

        End Sub


        Public Sub DoPublicUtld0010()

        End Sub


        Public Sub DoPublicUtld0011()

        End Sub


        Public Sub DoPublicUtld0012()

        End Sub


        Public Sub DoPublicUtld0013()

        End Sub


        Public Sub DoPublicUtld0014()

        End Sub


        Public Sub DoPublicUtld0015()

        End Sub


        Public Sub DoPublicUtld0016()

        End Sub


        Public Sub DoPublicUtld0017()

        End Sub


        Public Sub DoPublicUtld0018()

        End Sub


        Public Sub DoPublicUtld0019()

        End Sub


        Public Sub DoPublicUtld0020()

        End Sub


#End Region



    End Class


End Namespace
