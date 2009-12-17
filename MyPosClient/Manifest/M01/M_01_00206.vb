
'===========================================================
'Code generated by Softlands Solution
'-----------------------------------------------------------
'基本信息, 商品BOM管理
'
'Programmed by:
'    Henry Qu
'
'Created at:
'    2009/12/03
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

    Partial Public Class M_01_00206

#Region "Prerequested Inits"

#Region "Shared values"
        '
        'Shared Value, 用于与其它窗体交换数值的情况下, 需要自己根据需要更改命名
        '原则上所有UTLD的变量不能出现在成品中, 在确定不需要的情况下应删除UTLD
        '-------------------------------------------------------------------
        Public SV_ADDING_WARE_IDS As New ArrayList
        Public SV_EDITING_WARE_ID As String = String.Empty
        'Public SV_UTLD_0002 As String = "SV_UTLD_0002"
        ''Public SV_UTLD_0003 As String ="SV_UTLD_0003"
        ''Public SV_UTLD_0004 As String ="SV_UTLD_0004"
        ''Public SV_UTLD_0005 As String ="SV_UTLD_0005"
        ''Public SV_RPTOPT_EXCEL As XForm.ReportOption = Nothing
        ''Public SV_RPTOPT_LABEL As XForm.ReportOption = Nothing

        ''读取,显示数据的条件值变量
        'Public SVLM_UTLD_0002 As String ="SVLM_UTLD_0002"

        '数据列表变量
        Public SVFT_BINDING_COMPONENT_LIST As New MyPosXAuto.FTs.FT_S_MP_BOM_COMPONENT
        Public SVFT_BINDING_OPTION_LIST As New MyPosXAuto.FTs.FT_XV_S_MP_BOM_COMP_WARE_OPT
        'Public SVFT_CHOOSE_XXX_LIST As New XAuto.FTs.FT_

        Public SVFR_SELECTING_COMPONENT_ROW As MyPosXAuto.FTs.FT_S_MP_BOM_COMPONENTRow
        Public SVFR_SELECTING_COMPONENT_WARE_OPT_ROW As MyPosXAuto.FTs.FT_XV_S_MP_BOM_COMP_WARE_OPTRow


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

        Public LAUNCH_CONDITION As MyPosXService.S_01_00206.LCs

        Public Overrides Sub SetLC(ByVal LCName As String)

            Me._launchCondition = LCName
            Me.LAUNCH_CONDITION = CType(System.Enum.Parse(GetType(MyPosXService.S_01_00206.LCs), LCName), MyPosXService.S_01_00206.LCs)

        End Sub

        Public Sub InvokeBizRequest(ByVal affair As Business.B_01_00206.Affairs, ByVal sychronized As Boolean)

            Me._bizAgent.DoRequest(affair, sychronized)

        End Sub

        Private WithEvents _bizAgent As Business.B_01_00206

        Public Sub New(ByVal transactRequestHandle As TransactRequest, ByVal formID As Integer)

            MyBase.New(transactRequestHandle, formID)

            '该调用是 Windows 窗体设计器所必需的。
            InitializeComponent()


            '在 InitializeComponent() 调用之后添加任何初始化
            Me.SetAuthorName("Henry Qu")

            Me.InitializeMe(New Business.B_01_00206(Me), "基本信息", "商品BOM管理", False)
            Me._bizAgent = CType(Me.BizAgent, Business.B_01_00206)

        End Sub

#End Region

#Region "Basic overrides"

        Protected Overrides Sub IA_InitBeforeRC()

            Me.SetKeyJumpCycle(Keys.Enter, True)

            Me.SetValueEditControls()

            'Me.SetToolStripButtonFunctionKey(Me.ToolStripButton_Close, Keys.F12)

            'WinTK.RelateTreeListTabControl(Me.TreeList_, Me.XtraTabControl_

            'Me.FormInputGuarder.SetValidate(Me.TextEdit_Input, InputGuarder.ValidateClassify.Required, Nothing)

            'Me.FormInputGuarder.SetInputLinkedLabel(Me.ButtonEdit_Code, Me.Label_Name, Me.Label_ID)

            'Me._bizAgent.SetDisableControlUnderRequest(Me.DisableControlUnderRequest)

            'me._bizAgent.SetRequestActionTitle(action, title)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_XXX, AddressOf Me.TbActionXXXX

            '指定需要备份值的控件
            'Me.SetValueBackupControl(Me.ControlToBeBackup)

            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_AddComponent, AddressOf Me.TbActionAddComponent)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_AddOptions, AddressOf Me.TbActionAddOptions)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_RemoveComponent, AddressOf Me.TbActionRemoveComponent)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_RemoveOptions, AddressOf Me.TbActionRemoveOptions)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Refresh, AddressOf Me.TbActionRefresh)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Close, AddressOf Me.TbActionClose)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_SaveComponents, AddressOf Me.TbActionSaveComponents)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_SaveOptions, AddressOf Me.TbActionSaveOptions)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Utld0002, AddressOf Me.TbActionUtld0002)
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

            Me._bizAgent.DoRequest(Business.B_01_00206.Affairs.InitDisplay, False)

            'Me.GridControl_.DataSource = Me.SVFT_BINDING_
            'Me.LookupEdit_.Properties.DataSource = Me.SVFT_CHOOSE_

        End Sub


        Protected Overrides Sub IA_ClearContent(Optional ByVal clearFields As Boolean = False)


            'Initialize option list controls which value source is from the edit form content

            'Me.TextBox_FirstInput.Select

            If clearFields = False Then
                Return
            End If

            'Me.TextEdit_Input.ResetText()


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
                'Case "TbActionCreate", "TbActionRevise"
                '    Me.UpdateDisplay()                 

                'Case "ButtonEdit_BranchCode_ButtonClick"                                         
                '    Dim chooseForm As M_01_00101 = CType(popupForm, M_01_00101)                    
                '    Me.ButtonEdit_BranchCode.Text = chooseForm.SVFR_SELECTING_ROW.BRANCH_CODE      
                '    Me._bizAgent.DoRequest(Business.B_01_00X01.Affairs.LoadBranchInfoByCode, False)


                'Case "TbActionReport"                                                                                

                'Dim optionForm As XForm.Manifest.M_ReportOptions = CType(popupForm, XForm.Manifest.M_ReportOptions)
                'Select Case optionForm.SV_SELECTING_OPTION.Type                                                    
                '    Case XForm.ReportOption.PrintType.Label                                                        
                '        Me._bizAgent.DoRequest(Business.B_02_00X01.Affairs.PrintLabels, False)                     
                '    Case XForm.ReportOption.PrintType.Excel                                                        
                '        Select Case optionForm.SV_SELECTING_OPTION.Name                                            
                '            Case MyPosXService.Decls.RPT_NAME_0002                                                      
                '                Me._bizAgent.DoRequest(Business.B_02_00X01.Affairs.ExportXXXListExcel, False)    
                '        End Select                                                                                 
                'End Select                                                                                         

                Case "TbActionAdd"
                    Dim chooseForm = TryCast(popupForm, M_01_00201)
                    Me.TreeList_WareBomList.DataSource = Nothing
                    For Each wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow In chooseForm.SVFT_BINDING_WARE_LIST.FindRowsSelecting(True)
                        Me.SV_ADDING_WARE_IDS.Add(wareRow.WARE_ID)

                    Next
                    Me._bizAgent.DoRequest(Business.B_01_00206.Affairs.AddWare, False)
                Case "ResponseTitleName2"

                Case "ResponseTitleName3"


            End Select
        End Sub


        Protected Overrides Sub IA_SavedModeChanged(ByVal savedMode As Boolean)
            'Me.ToolStripButton_Save.Visible = Not savedMode
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

            'Me._bizAgent.DoRequest(Business.B_0X_00XXX.Affairs.SaveInfo, False)


            '
            '保存操作结束后重置保存状态
            '-------------------------------------------------------------------

            Return True

        End Function


        Public Overrides Sub UpdateDisplay()

            'Me._bizAgent.DoRequest(Business.B_0X_00XXX.Affairs.LoadInfo, False)
            Me._bizAgent.DoRequest(Business.B_01_00206.Affairs.LoadList, False)

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

                Me.ShowStatusMessage(StatusMessageIcon.Alert, operResult)

                Return
            End If

            '
            '操作成功的情况下, 继续下面的成功后处理
            '-------------------------------------------------------------------

            Select Case Me._bizAgent.AffairOf(responseResult.ResponseTitle)

                'Case Business.B_01_00201.Affairs.DeleteInfo
                '    Me.UpdateDisplay()                     

                Case Business.B_01_00206.Affairs.LoadList
                    Me.ResetSaveMode()
                    Me.DoPrivateUpdateSelectingRow()
                    Me.TreeList_WareBomList.BestFitColumns()
                    Me.TreeList_WareBomList.ExpandAll()

                    'Case Business.B_02_00202.Affairs.SaveInfo             
                    'Window.XLMessageBox.ShowMessage( _                
                    '    MyPosXService.Decls.MSG_OK_00001, _                
                    '    Window.XLMessageBox.MessageType.Information, _
                    '    MessageBoxButtons.OK)                         
                    'Me.ResponseToParentForm()                         

                    'If Me.SV_EDITING_TRANSFER_ID > 0 Then            
                    '    Me.ResetSaveMode()                            
                    '    Me.CloseForm()                                
                    'Else                                              
                    '    Me.IA_ClearContent()                          
                    'End If                                            

                Case Business.B_01_00206.Affairs.AddWare
                    'Me.TreeList_WareBomList.DataSource = Me.SVFT_BINDING_LIST
                    'Me.TreeList_WareBomList.ExpandAll()
                    'Me.TreeList_Component.BestFitColumns()
                    'Me.IsSaved = False
                Case Business.B_01_00206.Affairs.InitDisplay
                    Me.TreeList_Component.BestFitColumns()
                Case Business.B_01_00206.Affairs.SaveInfo
                    Me.UpdateDisplay()
            End Select
        End Sub

        Private Sub Timer_Surveillant_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Surveillant.Tick

        End Sub


        'Private Sub RepositoryItemCheckEdit_Select_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit_Select.EditValueChanged

        '    Dim checkEdit As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)                                                                 
        '    Me.SVFR_SELECTING_ROW.ROW_SELECTED = checkEdit.Checked                                                                                                              

        'End Sub                                                                                                                                                                 

        'Private Sub GridView_List_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView_List.FocusedRowChanged
        '    Me.DoPrivateUpdateSelectingRow()                                                                                                                                          
        'End Sub                                                                                                                                                                          


        'Private Sub GridView_List_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView_List.DoubleClick                                                     

        '    If IsNothing(Me.SVFR_SELECTING_ROW) = True Then             
        '        Return                                                  
        '    End If                                                      
        '    If Me.LAUNCH_CONDITION = MyPosXService.S_0X_00X01.LCs.Choose Then
        '        Me.TbActionChoose()                                     
        '    Else                                                        
        '        Me.TbActionRevise()                                     
        '    End If                                                      

        'End Sub                                                                                                                                                                                      


        'Private Sub ButtonEdit_BranchCode_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit_BranchCode.ButtonClick
        '    Dim chooseForm As New M_01_00101(Me.TransactRequestHandle, Me.FormID)                                                                                                         
        '    Me.PopupForm(chooseForm, "ButtonEdit_BranchCode_ButtonClick", False)                                                                                                        
        'End Sub                                                                                                                                                                           

        'Private Sub ButtonEdit_BranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ButtonEdit_BranchCode.KeyDown                             
        '    If e.KeyCode = Keys.Enter Then                                                                                                                                                
        '        Me._bizAgent.DoRequest(Business.B_01_00201.Affairs.LoadBranchInfoByCode, False)                                                                                           
        '    End If                                                                                                                                                                        
        'End Sub                                                                                                                                                                           

#End Region

#Region "ToolStrip Actions"

        Private Sub TbActionAddComponent()

            Dim parentComponentID = String.Empty
            If IsNothing(Me.SVFR_SELECTING_COMPONENT_ROW) = False Then
                parentComponentID = Me.SVFR_SELECTING_COMPONENT_ROW.COMPONENT_ID
            End If
            Dim componentRow = Me.SVFT_BINDING_COMPONENT_LIST.AddNewS_MP_BOM_COMPONENTRow( _
                Guid.NewGuid.ToString, _
                String.Empty, _
                Me.SV_EDITING_WARE_ID, _
                parentComponentID)
            componentRow.ROW_REMARK = "COMPONENT"
            Me.TreeList_Component.FocusedNode.ExpandAll()
            Me.TreeList_Component.BestFitColumns()

        End Sub

        Private Sub TbActionAddOptions()
            Dim choiceForm As New M_01_00201(Me.TransactRequestHandle, Me.FormID)
            choiceForm.LAUNCH_CONDITION = MyPosXService.S_01_00201.LCs.Choose
            choiceForm.SVLM_MULTI_CHOICE = True
            choiceForm.SVLM_STAY_AFTER_CHOOSE = True
            Me.PopupForm(choiceForm, "TbActionAdd", True)
        End Sub

        Private Sub TbActionRemoveComponent()
            Me.SVFR_SELECTING_COMPONENT_ROW.Delete()
            Me.IsSaved = False


        End Sub

        Private Sub TbActionRemoveOptions()

            Me.SVFR_SELECTING_COMPONENT_WARE_OPT_ROW.Delete()
            Me.IsSaved = False

        End Sub

        Private Sub TbActionRefresh()
            If Me.AttemptSaveBeforeWipeOut = False Then
                Return
            End If
            Me.UpdateDisplay()

        End Sub

        Private Sub TbActionClose()

            Me.CloseForm()

        End Sub

        Private Sub TbActionSaveComponents()
            Me._bizAgent.DoRequest(Business.B_01_00206.Affairs.SaveInfo, False)
        End Sub

        Private Sub TbActionSaveOptions()
            Me._bizAgent.DoRequest(Business.B_01_00206.Affairs.SaveInfo, False)
        End Sub


        Private Sub TbActionUtld0002()

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


        Private Sub DoPrivateUpdateSelectingRow()


            Me.SVFR_SELECTING_COMPONENT_ROW = Nothing

            Me.ToolStripButton_AddOptions.Enabled = False
            'Me.ToolStripButton_RemoveOptions.Enabled = False
            Me.ToolStripButton_RefreshOptions.Enabled = False
            Me.TreeListColumn_Component.OptionsColumn.AllowFocus = False

            If IsNothing(Me.TreeList_Component.FocusedNode) = False Then

                Me.SVFR_SELECTING_COMPONENT_ROW = _
                     CType(CType( _
                         Me.TreeList_Component.GetDataRecordByNode( _
                             Me.TreeList_Component.FocusedNode),  _
                         DataRowView).Row, MyPosXAuto.FTs.FT_S_MP_BOM_COMPONENTRow)

                If Me.SVFR_SELECTING_COMPONENT_ROW.COMPONENT_ID.Length > 0 Then
                    Me.TreeListColumn_Component.OptionsColumn.AllowFocus = True
                    Me.ToolStripButton_AddOptions.Enabled = True
                End If

                'Me.ToolStripButton_Remove.Enabled = True

            End If



        End Sub


        Private Sub DoPrivateUpdateBomSetupVisibles()
            Me.ToolStripButton_AddComponent.Visible = True
            Me.ToolStripButton_RemoveComponent.Visible = True
            Me.ToolStripButton_RefreshComponents.Visible = True
            Me.ToolStripButton_SaveComponents.Visible = True

            Me.ToolStripButton_AddOptions.Visible = True
            Me.ToolStripButton_RemoveOptions.Visible = True
            Me.ToolStripButton_RefreshOptions.Visible = True
            Me.ToolStripButton_SaveOptions.Visible = True

            If Me.SplitContainerControl_BomSetup.Panel2.Enabled = False Then
                Me.ToolStripButton_RefreshComponents.Visible = False
            Else
                Me.ToolStripButton_SaveComponents.Visible = False
            End If

            If Me.SplitContainerControl_BomSetup.Panel1.Enabled = False Then
                If IsNothing(Me.SVFR_SELECTING_COMPONENT_ROW) = False Then
                    Me.ToolStripButton_RefreshOptions.Visible = True
                End If
            Else
                Me.ToolStripButton_SaveOptions.Visible = True
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


        'Private Sub RepositoryItemLookUpEdit_WareBomType_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemLookUpEdit_WareBomType.EditValueChanged
        '    Dim lookupEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        '    Me.SVFR_SELECTING_ROW.WARE_BOM_TYPE = CommTK.FInteger(lookupEdit.EditValue)
        '    Me.SVFR_SELECTING_ROW.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_MODIFIED
        '    Me.IsSaved = False
        'End Sub

        'Private Sub RepositoryItemCalcEdit_BelongQty_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCalcEdit_BelongQty.EditValueChanged
        '    Dim calcEdit = TryCast(sender, DevExpress.XtraEditors.CalcEdit)
        '    'should not have commtk.finteger herer

        '    Me.SVFR_SELECTING_ROW.BELONG_QTY = CommTK.FInteger(calcEdit.Value)
        '    If Me.SVFR_SELECTING_ROW.BELONG_QTY <= 0 Then
        '        Me.SVFR_SELECTING_ROW.BELONG_QTY = 1
        '    End If
        '    Me.SVFR_SELECTING_ROW.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_MODIFIED
        '    Me.IsSaved = False
        'End Sub

        Private Sub TreeList_Component_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList_Component.FocusedNodeChanged
            Me.DoPrivateUpdateSelectingRow()
        End Sub

        Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

        End Sub

        Private Sub RepositoryItemTextEdit_ComponentName_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit_ComponentName.EditValueChanged
            Dim textEdit = TryCast(sender, DevExpress.XtraEditors.TextEdit)
            Me.SVFR_SELECTING_COMPONENT_ROW.COMPONENT_NAME = textEdit.Text
        End Sub
    End Class


End Namespace

