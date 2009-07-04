
'===========================================================
'Code generated by Highsoft Solution
'-----------------------------------------------------------
'查询, 应收帐款查询
'
'Programmed by:
'    Darlin
'
'Created at:
'    2008-05-12
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

Namespace Manifest

    Partial Public Class M_03_00501

#Region "Prerequested Inits"

#Region "Shared values"
        '
        'Shared Value, 用于与其它窗体交换数值的情况下, 需要自己根据需要更改命名
        '原则上所有UTLD的变量不能出现在成品中, 在确定不需要的情况下应删除UTLD
        '-------------------------------------------------------------------
        Public SV_EXCEL_FILENAME As String = String.Empty
        Public SV_UTLD_0002 As String = "SV_UTLD_0002"
        'Public SV_UTLD_0003 As String ="SV_UTLD_0003"
        'Public SV_UTLD_0004 As String ="SV_UTLD_0004"
        'Public SV_UTLD_0005 As String ="SV_UTLD_0005"

        '读取,显示数据的条件值变量
        'Public SVLM_UTLD_0001 As String ="SVLM_UTLD_0001"
        'Public SVLM_UTLD_0002 As String ="SVLM_UTLD_0002"

        '数据列表变量
        Public SVFT_BINDING_RECEIVABLE_LIST As New MyPosXAuto.FTs.FT_MV_MP_CLIENT_RECEIVABLES
        Public SVFT_BINDING_PAYABLE_LIST As New MyPosXAuto.FTs.FT_MV_MP_SUPPLIER_PAYABLES
        'Public SVFT_CHOOSE_XXX_LIST As New FreeTable

        Public SVFR_SELECTING_RECEIVABLE_ROW As MyPosXAuto.FTs.FT_MV_MP_CLIENT_RECEIVABLESRow
        Public SVFR_SELECTING_PAYABLE_ROW As MyPosXAuto.FTs.FT_MV_MP_SUPPLIER_PAYABLESRow

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

        Public LAUNCH_CONDITION As MyPosXService.S_03_00501.LCs


        Public Overrides Sub SetLC(ByVal LCName As String)

            Me._launchCondition = LCName
            Me.LAUNCH_CONDITION = CType(System.Enum.Parse(GetType(MyPosXService.S_03_00501.LCs), LCName), MyPosXService.S_03_00501.LCs)

        End Sub

        Public Sub InvokeBizRequest(ByVal affair As Business.B_03_00501.Affairs, ByVal sychronized As Boolean)

            Me._bizAgent.DoRequest(affair, sychronized)

        End Sub

        Private WithEvents _bizAgent As Business.B_03_00501

        Public Sub New(ByVal transactRequestHandle As TransactRequest, ByVal formID As Integer)

            MyBase.New(transactRequestHandle, formID)

            '该调用是 Windows 窗体设计器所必需的。
            InitializeComponent()


            '在 InitializeComponent() 调用之后添加任何初始化
            Me.SetAuthorName("Darlin")

            Me.InitializeMe(New Business.B_03_00501(Me), "查询", "应收-应付", False)
            Me._bizAgent = CType(Me.BizAgent, Business.B_03_00501)

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
            'Me.SetValueBackupControl(Me.ControlToBeBackup)

            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Refresh, AddressOf Me.TbActionRefresh)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Close, AddressOf Me.TbActionClose)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_ExportExcel, AddressOf Me.TbActionExportExcel)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Details, AddressOf Me.TbActionView)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0003, AddressOf Me.TbActionUtld0003)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0004, AddressOf Me.TbActionUtld0004)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0005, AddressOf Me.TbActionUtld0005)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0006, AddressOf Me.TbActionUtld0006)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0007, AddressOf Me.TbActionUtld0007)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0008, AddressOf Me.TbActionUtld0008)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0009, AddressOf Me.TbActionUtld0009)
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


            '做根据LaunchCondition判断分支的相关动作, 如控件的显示不显示, 必填不必填

            Select Case Me.LAUNCH_CONDITION

            End Select

            'Initialize option list controls which value source isn't from the edit form content

            Me._bizAgent.DoRequest(Business.B_03_00501.Affairs.InitDisplay, False)

            'Me.GridControl_.DataSource = Me.SVFT_BINDING_
            'Me.LookupEdit_.Properties.DataSource = Me.SVFT_CHOOSE_

        End Sub


        Protected Overrides Sub IA_ClearContent(Optional ByVal clearKeyFields As Boolean = False)


            'Initialize option list controls which value source is from the edit form content


            'Me.TextEdit_Input.ResetText()



            'Me.TextBox_FirstInput.Select


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
                Case "ResponseTitleName1"


                Case "ResponseTitleName2"

                Case "ResponseTitleName3"


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
                XL.Win.Window.XLMessageBox.ShowMessage(validateInputResult, Window.XLMessageBox.MessageType.Wrong, MessageBoxButtons.OK)
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

            Me._bizAgent.DoRequest(Business.B_03_00501.Affairs.LoadList, False)

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

                Case Business.B_03_00501.Affairs.ExportExcel
                    If XL.Win.Window.XLMessageBox.ShowMessage( _
                        MyPosXService.Decls.MSG_CONFIRM_00003, _
                        Window.XLMessageBox.MessageType.Information, _
                        MessageBoxButtons.YesNo) = DialogResult.No Then
                        Return
                    End If

                    CommTK.LaunchApplication(Nothing, Me.SV_EXCEL_FILENAME, False)

                Case Business.B_03_00501.Affairs.LoadList
                    Me.GridView_PayableList.BestFitColumns()
                    Me.GridView_ReceivableList.BestFitColumns()
                    Me.DoPrivateUpdateSelectingValues()

            End Select
        End Sub

        Private Sub Timer_Surveillant_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Surveillant.Tick

        End Sub

        Private Sub TextEdit_Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit_Search.KeyDown
            If e.KeyCode = Keys.Enter Then
                'WinTK.SearchGridText(Me.GridView_TurnoverDtl, Me.TextEdit_Search.Text, True)
                Me.TextEdit_Search.SelectAll()
            End If
        End Sub

#End Region

#Region "ToolStrip Actions"



        Private Sub TbActionShowFilter()

            'Me.PanelControl_Filter.Visible = Me.ToolStripButton_ShowFilter.Pressed

        End Sub

        Private Sub TbActionRefresh()

            Me.UpdateDisplay()

        End Sub

        Private Sub TbActionClose()

            Me.CloseForm()

        End Sub


        Private Sub TbActionExportExcel()

            If Me.SaveFileDialog_ExportExcel.ShowDialog = DialogResult.Cancel Then
                Return
            End If

            Me.SV_EXCEL_FILENAME = Me.SaveFileDialog_ExportExcel.FileName

            Me._bizAgent.DoRequest(Business.B_03_00501.Affairs.ExportExcel, False)

        End Sub


        Private Sub TbActionView()

            Dim inputForm As New M_02_00101(Me.TransactRequestHandle, Me.FormID)

            If Me.XtraTabControl1.SelectedTabPage Is Me.XtraTabPage_Payables Then
                inputForm.SVLM_VIEWING_PAYMENT_SUPPLIER_ID = Me.SVFR_SELECTING_PAYABLE_ROW.SUPPLIER_ID
            Else
                inputForm.SVLM_VIEWING_PAYMENT_CLIENT_ID = Me.SVFR_SELECTING_RECEIVABLE_ROW.CLIENT_ID
            End If

            Me.PopupForm(inputForm, "TbActionView", False)

        End Sub


        Private Sub TbActionUtld0003()

        End Sub


        Private Sub TbActionUtld0004()

        End Sub


        Private Sub TbActionUtld0005()

        End Sub


        Private Sub TbActionUtld0006()

        End Sub


        Private Sub TbActionUtld0007()

        End Sub


        Private Sub TbActionUtld0008()

        End Sub


        Private Sub TbActionUtld0009()

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

            Me.SVFR_SELECTING_PAYABLE_ROW = Nothing
            Me.SVFR_SELECTING_RECEIVABLE_ROW = Nothing

            Me.ToolStripButton_Details.Enabled = False


            If Me.GridView_PayableList.RowCount > 0 Then
                Me.SVFR_SELECTING_PAYABLE_ROW = _
                    CType( _
                        Me.GridView_PayableList.GetDataRow( _
                            Me.GridView_PayableList.FocusedRowHandle),  _
                            MyPosXAuto.FTs.FT_MV_MP_SUPPLIER_PAYABLESRow)

                If IsNothing(Me.SVFR_SELECTING_PAYABLE_ROW) = False Then
                    Me.ToolStripButton_Details.Enabled = True
                End If
            End If

            If Me.GridView_ReceivableList.RowCount > 0 Then
                Me.SVFR_SELECTING_RECEIVABLE_ROW = _
                    CType( _
                        Me.GridView_ReceivableList.GetDataRow( _
                            Me.GridView_ReceivableList.FocusedRowHandle),  _
                            MyPosXAuto.FTs.FT_MV_MP_CLIENT_RECEIVABLESRow)

                If IsNothing(Me.SVFR_SELECTING_RECEIVABLE_ROW) = False Then
                    Me.ToolStripButton_Details.Enabled = True
                End If
            End If


        End Sub


        Private Sub DoPrivateUtld0001()

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

        Private Sub GridView_PayableList_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView_PayableList.FocusedRowChanged
            Me.DoPrivateUpdateSelectingValues()
        End Sub

        Private Sub GridView_ReceivableList_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView_ReceivableList.FocusedRowChanged
            Me.DoPrivateUpdateSelectingValues()
        End Sub
    End Class

End Namespace
