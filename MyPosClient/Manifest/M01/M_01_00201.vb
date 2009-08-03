
'===========================================================
'Code generated by Highsoft Solution
'-----------------------------------------------------------
'基本信息, 货品信息
'
'Programmed by:
'    Darlin
'
'Created at:
'    2008-05-07
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

    Partial Public Class M_01_00201

#Region "Prerequested Inits"

#Region "Shared values"
        '
        'Shared Value, 用于与其它窗体交换数值的情况下, 需要自己根据需要更改命名
        '原则上所有UTLD的变量不能出现在成品中, 在确定不需要的情况下应删除UTLD
        '-------------------------------------------------------------------
        Public SV_EXPORT_EXCEL_FILENAME As String = String.Empty
        Public SV_SETTING_IMAGE_FILENAME As String = String.Empty
        Public SV_READING_TXT_FILENAME As String = String.Empty
        Public SV_SELECTING_WARE_CLASSIFY_DEPTH As Integer = -1
        Public SV_WARE_LIST_SELECTING As Boolean
        'Public SV_WARE_CODE_ARRAY As New ArrayList
        'Public SV_UTLD_0003 As String ="SV_UTLD_0003"
        'Public SV_UTLD_0004 As String ="SV_UTLD_0004"
        'Public SV_UTLD_0005 As String ="SV_UTLD_0005"

        '读取,显示数据的条件值变量
        Public SVLM_MULTI_CHOICE As Boolean = False
        Public SVLM_STAY_AFTER_CHOOSE As Boolean = False
        Public SVLM_SHOW_PRACT_TRACE As Boolean = False
        Public SVLM_CHOOSE_CLASSIFY As Boolean = False
        'Public SVLM_UTLD_0002 As String ="SVLM_UTLD_0002"

        '数据列表变量
        Public SVFT_BINDING_WARE_CLASSIFY_LIST As New MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFY
        Public SVFT_BINDING_WARE_LIST As New MyPosXAuto.FTs.FT_XV_M_MP_WARE
        'Public SVFT_BINDING_WARE_ROW As MyPosXAuto.FTs.FT_M_MP_WARERow

        'Public SVFT_CHOOSE_XXX_LIST As New FreeTable

        Public SVFR_SELECTING_WARE_ROW As MyPosXAuto.FTs.FT_XV_M_MP_WARERow
        Public SVFR_SELECTING_CLASSIFY_ROW As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow

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

        Public LAUNCH_CONDITION As MyPosXService.S_01_00201.LCs


        Public Overrides Sub SetLC(ByVal LCName As String)

            Me._launchCondition = LCName
            Me.LAUNCH_CONDITION = CType(System.Enum.Parse(GetType(MyPosXService.S_01_00201.LCs), LCName), MyPosXService.S_01_00201.LCs)

        End Sub

        Public Sub InvokeBizRequest(ByVal affair As Business.B_01_00201.Affairs, ByVal sychronized As Boolean)

            Me._bizAgent.DoRequest(affair, sychronized)

        End Sub

        Private WithEvents _bizAgent As Business.B_01_00201

        Public Sub New(ByVal transactRequestHandle As TransactRequest, ByVal formID As Integer)

            MyBase.New(transactRequestHandle, formID)

            '该调用是 Windows 窗体设计器所必需的。
            InitializeComponent()


            '在 InitializeComponent() 调用之后添加任何初始化
            Me.SetAuthorName("QDF")

            Me.InitializeMe(New Business.B_01_00201(Me), "基本信息", "货品信息", False)
            Me._bizAgent = CType(Me.BizAgent, Business.B_01_00201)

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

            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_CreateWareClassify, AddressOf Me.TbActionCreateWareClassify)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_CreateWare, AddressOf Me.TbActionCreateWare)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Revise, AddressOf Me.TbActionEdit)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Delete, AddressOf Me.TbActionDelete)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Refresh, AddressOf Me.TbActionRefresh)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_View, AddressOf Me.TbActionView)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Close, AddressOf Me.TbActionClose)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Choose, AddressOf Me.TbActionChoose)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_ImportFromExcel, AddressOf Me.TbActionImportFromExcel)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_ImportFromTxt, AddressOf Me.TbActionImportFromTxt)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_PrintLabel, AddressOf Me.TbActionPrintLabel)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_ExportExcel, AddressOf Me.TbActionExportExcel)
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
                Case MyPosXService.S_01_00201.LCs.Choose
                    Me.ToolStripButton_Choose.Visible = True
                    Me.ToolStripButton_CreateWare.Visible = False
                    Me.ToolStripButton_CreateWareClassify.Visible = False
                    Me.ToolStripButton_Revise.Visible = False
                    Me.ToolStripButton_Delete.Visible = False
                    Me.ToolStripButton_View.Visible = False
                    Me.ToolStripButton_ExportExcel.Visible = False
                    Me.ToolStripButton_PrintLabel.Visible = False
                    Me.ToolStripButton_ImportFromExcel.Visible = False
                    'Me.ToolStripButton_ImportFromTxt.Visible = False
                    If Me.SVLM_CHOOSE_CLASSIFY = True Then
                        Me.SplitContainerControl_Left.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                        Me.SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                    ElseIf Me.SVLM_MULTI_CHOICE = False Then
                        Me.GridColumn_RowSelect.Visible = False
                    End If

            End Select

            'Initialize option list controls which value source isn't from the edit form content

            Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.InitDisplay, False)

            Me.TreeListColumn_WareClassifyName.OptionsColumn.AllowFocus = False
            Me.TreeListColumn_WareClassifyCode.OptionsColumn.AllowFocus = False
            Me.TreeListColumn_Remark.OptionsColumn.AllowFocus = False

            Me.GridControl_Ware.DataSource = Me.SVFT_BINDING_WARE_LIST
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
                Case "TbActionCreateWareClassify", "TbActionEdit"
                    Me.UpdateDisplay()

                Case "TbActionCreateWare", "TbActionEditWare"
                    Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.LoadWareList, False)

                Case "TbActionImportFromExcel"
                    Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.LoadWareList, False)

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

            Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.LoadWareClassifyList, True)

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

                Case Business.B_01_00201.Affairs.LoadWareClassifyList
                    Me.TreeListColumn_WareClassifyCode.Visible = True
                    Me.TreeListColumn_Remark.Visible = True

                    Me.TreeList_WareClassify.ExpandAll()
                    Me.TreeList_WareClassify.BestFitColumns()
                    Me.TreeList_WareClassify.Refresh()
                    Me.TreeList_WareClassify.Dock = DockStyle.Fill

                Case Business.B_01_00201.Affairs.DeleteWareClassifyInfo
                    Me.UpdateDisplay()

                Case Business.B_01_00201.Affairs.LoadWareList
                    Me.GridView_Ware.BestFitColumns()
                    Me.DoPrivateUpdateSelectingValues()

                Case Business.B_01_00201.Affairs.DeleteWare
                    Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.LoadWareList, False)

                Case Business.B_01_00201.Affairs.AllWareExportExcel
                    If XL.Win.Window.XLMessageBox.ShowMessage( _
                        MyPosXService.Decls.MSG_CONFIRM_00003, _
                        Window.XLMessageBox.MessageType.Information, _
                        MessageBoxButtons.YesNo) = DialogResult.No Then
                        Return
                    End If

                    CommTK.LaunchApplication(Nothing, Me.SV_EXPORT_EXCEL_FILENAME, False)

                Case Business.B_01_00201.Affairs.LoadAllWareList
                    Me.GridView_Ware.BestFitColumns()

                Case Business.B_01_00201.Affairs.SingalClassifyExportExcel
                    If XL.Win.Window.XLMessageBox.ShowMessage( _
                        MyPosXService.Decls.MSG_CONFIRM_00003, _
                        Window.XLMessageBox.MessageType.Information, _
                        MessageBoxButtons.YesNo) = DialogResult.No Then
                        Return
                    End If

                    CommTK.LaunchApplication(Nothing, Me.SV_EXPORT_EXCEL_FILENAME, False)


            End Select
        End Sub

        Private Sub Timer_Surveillant_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Surveillant.Tick

        End Sub

        Private Sub TreeList_WareClassify_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList_WareClassify.FocusedNodeChanged
            Me.DoPrivateUpdateSelectingClassifyValues()
            Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.LoadWareList, False)
        End Sub

        Private Sub TreeList_WareClassify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeList_WareClassify.Click
            Me.SV_WARE_LIST_SELECTING = False
        End Sub

        Private Sub GridView_Ware_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView_Ware.Click
            Me.SV_WARE_LIST_SELECTING = True
        End Sub

        Private Sub GridView_Ware_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView_Ware.FocusedRowChanged
            Me.DoPrivateUpdateSelectingValues()
        End Sub

        Private Sub GridView_Ware_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView_Ware.DoubleClick
            If Me.LAUNCH_CONDITION = MyPosXService.S_01_00201.LCs.Choose Then
                Me.TbActionChoose()
            Else
                Me.TbActionEdit()
            End If

        End Sub

        Private Sub TextEdit_Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit_Search.KeyDown
            If e.KeyCode = Keys.Enter Then
                WinTK.SearchGridViewText(Me.GridView_Ware, Me.TextEdit_Search.Text, True)
            End If
        End Sub


        Private Sub RepositoryItemCheckEdit_Select_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit_Select.EditValueChanged
            Dim bindingRow As MyPosXAuto.FTs.FT_XV_M_MP_WARERow = _
                CType(Me.GridView_Ware.GetDataRow( _
                    Me.GridView_Ware.FocusedRowHandle), MyPosXAuto.FTs.FT_XV_M_MP_WARERow)

            Dim checkEdit As DevExpress.XtraEditors.CheckEdit = _
                CType(sender, DevExpress.XtraEditors.CheckEdit)

            bindingRow.ROW_SELECTED = checkEdit.Checked

        End Sub

        Private Sub LinkLabel_SelectAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_SelectAll.LinkClicked
            Me.SVFT_BINDING_WARE_LIST.SelectAllRows()
        End Sub

        Private Sub LinkLabel_UnselectedAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_CancelAll.LinkClicked
            Me.SVFT_BINDING_WARE_LIST.UnselectAllRows()
        End Sub

        Private Sub LinkLabel_AllWareList_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_AllWareList.LinkClicked
            Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.LoadAllWareList, False)
        End Sub

        Private Sub LinkLabel_AllWareExportExcel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_AllWareExportExcel.LinkClicked
            If Me.SaveFileDialog_ExportExcel.ShowDialog = DialogResult.Cancel Then
                Return
            End If

            Me.SV_EXPORT_EXCEL_FILENAME = Me.SaveFileDialog_ExportExcel.FileName

            Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.AllWareExportExcel, False)
        End Sub

#End Region

#Region "ToolStrip Actions"


        Private Sub TbActionCreateWareClassify()

            Dim inputForm As New M_01_00202(Me.TransactRequestHandle, Me.FormID)
            If IsNothing(Me.SVFR_SELECTING_CLASSIFY_ROW) = False Then
                inputForm.SV_DEFAULT_PARENT_CLASSIFY_ID = Me.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_ID
            End If
            Me.PopupForm(inputForm, "TbActionCreateWareClassify", False)

        End Sub

        Private Sub TbActionCreateWare()

            Dim inputForm As New M_01_00203(Me.TransactRequestHandle, Me.FormID)
            inputForm.SV_SELECTING_WARE_CLASSIFY_ID = Me.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_ID
            Me.PopupForm(inputForm, "TbActionCreateWare", False)

        End Sub

        Private Sub TbActionEdit()



            If Me.SV_WARE_LIST_SELECTING = False Then
                Dim inputForm As New M_01_00202(Me.TransactRequestHandle, Me.FormID)
                inputForm.LAUNCH_CONDITION = MyPosXService.S_01_00202.LCs.Edit
                inputForm.SV_REVISING_CLASSIFY_ID = Me.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_ID
                Me.PopupForm(inputForm, "TbActionEdit", False)
            End If

            If Me.SV_WARE_LIST_SELECTING = True Then

                Me.DoPrivateUpdateSelectingValues()

                If IsNothing(Me.SVFR_SELECTING_WARE_ROW) = True Then
                    Return
                End If

                Dim inputForm As New M_01_00203(Me.TransactRequestHandle, Me.FormID)
                inputForm.LAUNCH_CONDITION = MyPosXService.S_01_00203.LCs.Edit
                inputForm.SV_REVISING_WARE_ID = Me.SVFR_SELECTING_WARE_ROW.WARE_ID
                inputForm.SV_SELECTING_WARE_CLASSIFY_ID = Me.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_ID
                Me.PopupForm(inputForm, "TbActionEditWare", False)
            End If

        End Sub

        Private Sub TbActionDelete()

            If Me.SV_WARE_LIST_SELECTING = False Then
                If Me.GridView_Ware.RowCount > 0 Then
                    Window.XLMessageBox.ShowMessage( _
                        MyPosXService.Decls.MSG_ALERT_00002, _
                        Window.XLMessageBox.MessageType.Warning, _
                        MessageBoxButtons.OK)

                    Return

                End If

                If Window.XLMessageBox.ShowMessage( _
                   MyPosXService.Decls.MSG_CONFIRM_00002, _
                   Window.XLMessageBox.MessageType.Warning, _
                   MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                    Return
                End If

                Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.DeleteWareClassifyInfo, False)
            End If

            If Me.SV_WARE_LIST_SELECTING = True Then

                If Window.XLMessageBox.ShowMessage( _
                   MyPosXService.Decls.MSG_CONFIRM_00018, _
                   Window.XLMessageBox.MessageType.Warning, _
                   MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                    Return
                End If

                Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.DeleteWare, False)

            End If

        End Sub

        Private Sub TbActionRefresh()

            Me.UpdateDisplay()

        End Sub

        Private Sub TbActionView()

            If Me.GridView_Ware.RowCount = 0 Then
                Return
            End If

            Dim inputForm As New M_01_00203(Me.TransactRequestHandle, Me.FormID)
            inputForm.SV_REVISING_WARE_ID = Me.SVFR_SELECTING_WARE_ROW.WARE_ID
            inputForm.LAUNCH_CONDITION = MyPosXService.S_01_00203.LCs.View
            Me.PopupForm(inputForm, "TbActionView", False)

        End Sub

        Private Sub TbActionClose()

            Me.CloseForm()

        End Sub


        Private Sub TbActionChoose()

            If IsNothing(Me.SVFR_SELECTING_CLASSIFY_ROW) = True Then
                Return
            End If

            If Me.SVLM_CHOOSE_CLASSIFY = False AndAlso Me.GridView_Ware.RowCount = 0 Then
                Return
            End If

            Me.ResponseToParentForm()

            If Me.SVLM_STAY_AFTER_CHOOSE = False Then
                Me.CloseForm()
            End If

        End Sub


        Private Sub TbActionImportFromExcel()

            Dim importForm As New M_01_00205(Me.TransactRequestHandle, Me.FormID)
            importForm.SV_IMPORTING_WARE_CLASSIFY_ID = Me.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_ID
            Me.PopupForm(importForm, "TbActionImportFromExcel", True)

        End Sub





        Private Sub TbActionPrintLabel()

            Dim printForm As New M_01_00204(Me.TransactRequestHandle, Me.FormID)
            Dim printRow As MyPosXAuto.FTs.FT_XV_M_MP_WARERow

            For Each bindingRow As MyPosXAuto.FTs.FT_XV_M_MP_WARERow In Me.SVFT_BINDING_WARE_LIST.FindRowsSelecting(True)
                printRow = printForm.SVFT_PRINTING_LIST.NewXV_M_MP_WARERow
                printForm.SVFT_PRINTING_LIST.AddXV_M_MP_WARERow(printRow)
                printRow.CloneDataRow(bindingRow)
                printRow.LABEL_COPIES = 1
            Next

            Me.PopupForm(printForm, "TbActionPrintLabel", True)

        End Sub


        Private Sub TbActionExportExcel()

            If Me.SaveFileDialog_ExportExcel.ShowDialog = DialogResult.Cancel Then
                Return
            End If

            Me.SV_EXPORT_EXCEL_FILENAME = Me.SaveFileDialog_ExportExcel.FileName

            Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.SingalClassifyExportExcel, False)

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

            Me.SVFR_SELECTING_WARE_ROW = Nothing

            Me.LinkLabel_SetImage.Visible = False
            Me.LinkLabel_DeleteImage.Visible = False

            If Me.GridView_Ware.RowCount > 0 Then
                Me.SVFR_SELECTING_WARE_ROW = CType( _
                      Me.GridView_Ware.GetDataRow(Me.GridView_Ware.FocusedRowHandle),  _
                     MyPosXAuto.FTs.FT_XV_M_MP_WARERow)

                Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.LoadWareImage, False)
                If IsNothing(Me.PictureBox_Item.Image) = True Then
                    Me.LinkLabel_SetImage.Visible = True
                Else
                    Me.LinkLabel_DeleteImage.Visible = True
                End If
            End If


        End Sub


        Private Sub DoPrivateUpdateSelectingClassifyValues()

            Me.SVFR_SELECTING_CLASSIFY_ROW = Nothing

            Me.LinkLabel_AllWareList.Visible = False
            Me.LinkLabel_AllWareExportExcel.Visible = False
            Me.ToolStripButton_ExportExcel.Enabled = True

            If IsNothing(Me.TreeList_WareClassify.FocusedNode) = False Then

                Me.SVFR_SELECTING_CLASSIFY_ROW = _
                     CType(CType( _
                         Me.TreeList_WareClassify.GetDataRecordByNode( _
                             Me.TreeList_WareClassify.FocusedNode),  _
                         DataRowView).Row, MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow)

                If Me.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_ID.Length > 0 Then
                    Me.ToolStripButton_Choose.Enabled = True
                End If

                'If Me.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_CODE = "^^&*" Then
                '    Me.ToolStripButton_CreateWare.Enabled = False
                '    Me.ToolStripButton_Delete.Enabled = False
                '    Me.ToolStripButton_Revise.Enabled = False
                '    Me.ToolStripButton_View.Enabled = False
                '    Me.ToolStripButton_ImportFromExcel.Enabled = False
                '    'Me.ToolStripButton_ImportFromTxt.Enabled = False
                '    Me.ToolStripButton_PrintLabel.Enabled = False

                '    Me.LinkLabel_AllWareList.Visible = True
                '    Me.LinkLabel_AllWareExportExcel.Visible = True
                '    Me.ToolStripButton_ExportExcel.Enabled = False
                'Else
                '    Me.ToolStripButton_CreateWare.Enabled = True
                '    Me.ToolStripButton_Delete.Enabled = True
                '    Me.ToolStripButton_Revise.Enabled = True
                '    Me.ToolStripButton_View.Enabled = True
                '    Me.ToolStripButton_ImportFromExcel.Enabled = True
                '    'Me.ToolStripButton_ImportFromTxt.Enabled = True
                '    Me.ToolStripButton_PrintLabel.Enabled = True
                'End If
                'Me.ToolStripButton_Delete.Enabled = True
                'Me.ToolStripButton_Revise .Enabled = True

            End If

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

        Private Sub LinkLabel_SetImage_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_SetImage.LinkClicked
            If Me.OpenFileDialog_SetImage.ShowDialog = DialogResult.Cancel Then
                Return
            End If

            Me.SV_SETTING_IMAGE_FILENAME = Me.OpenFileDialog_SetImage.FileName
            Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.SetImage, False)

            'Dim wareImage As New Bitmap(CommTK.GetImageFromFile(Me.OpenFileDialog_SetImage.FileName))
            'Dim saveImage As New Bitmap(160, 120)
            'Dim saveImageGraphics As Graphics = Graphics.FromImage(saveImage)

            'Dim rangeWidth As Integer = saveImage.Width
            'Dim rangeHeight As Integer = saveImage.Height
            'Dim rangeTangle As Double = rangeHeight / rangeWidth

            'Dim imageOrigionWidth As Integer = wareImage.Width
            'Dim imageOrigionHeight As Integer = wareImage.Height
            'Dim imageOrigionTangle As Double = imageOrigionHeight / imageOrigionWidth

            'Dim imageFinalWidth As Integer = imageOrigionWidth
            'Dim imageFinalHeight As Integer = imageOrigionHeight

            'If rangeTangle <= imageOrigionTangle Then
            '    imageFinalWidth = rangeWidth
            '    imageFinalHeight = CommTK.FInteger(rangeWidth * imageOrigionTangle)
            'Else
            '    imageFinalHeight = rangeHeight
            '    imageFinalWidth = CommTK.FInteger(rangeHeight / imageOrigionTangle)
            'End If

            'saveImageGraphics.DrawImage(wareImage, 0, 0, imageFinalWidth, imageFinalHeight)
            'Dim savefileName As String = WinTK.GetResourceFilePath(ResourceType.Image, Me.SVFR_SELECTING_WARE_ROW.CUSTOM_CODE & ".JPG")
            'If IO.File.Exists(savefileName) = True Then
            '    IO.File.Delete(savefileName)
            'End If
            'saveImage.Save(savefileName, Utils.Decls.IMAGE_CODE_INFO, Utils.Decls.ENCODER_PARAMETER)
            'Me.DoPrivateUpdateSelectingValues()

        End Sub

        Private Sub LinkLabel_DeleteImage_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_DeleteImage.LinkClicked
            If Window.XLMessageBox.ShowMessage( _
                MyPosXService.Decls.MSG_CONFIRM_00020, _
                Window.XLMessageBox.MessageType.Warning, _
                MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                Return
            End If

            Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.RemoveImage, False)
            'Dim imageFilename As String = WinTK.GetResourceFilePath(ResourceType.Image, Me.SVFR_SELECTING_WARE_ROW.CUSTOM_CODE & ".JPG")
            'IO.File.Delete(imageFilename)
            'Me.DoPrivateUpdateSelectingValues()
        End Sub

        Private Sub GridControl_Ware_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl_Ware.Click

        End Sub
    End Class


End Namespace
