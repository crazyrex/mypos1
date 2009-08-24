﻿
'===========================================================
'Code generated by Softlands Solution
'-----------------------------------------------------------
'业务操作, 零售退货单号确认
'
'Programmed by:
'    Henry Qu
'
'Created at:
'    2009/07/17
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

    Partial Public Class M_02_01002

#Region "Prerequested Inits"

#Region "Shared values"
        '
        'Shared Value, 用于与其它窗体交换数值的情况下, 需要自己根据需要更改命名
        '原则上所有UTLD的变量不能出现在成品中, 在确定不需要的情况下应删除UTLD
        '-------------------------------------------------------------------
        Public SV_IS_ONLINE As Boolean = False
        'Public SV_UTLD_0003 As String ="SV_UTLD_0003"
        'Public SV_UTLD_0004 As String ="SV_UTLD_0004"
        'Public SV_UTLD_0005 As String ="SV_UTLD_0005"
        'Public SV_RPTOPT_EXCEL As XForm.ReportOption = Nothing
        'Public SV_RPTOPT_LABEL As XForm.ReportOption = Nothing

        '读取,显示数据的条件值变量
        'Public SVLM_UTLD_0001 As String ="SVLM_UTLD_0001"
        'Public SVLM_UTLD_0002 As String ="SVLM_UTLD_0002"

        '数据列表变量
        'Public SVFT_BINDING_XXX_LIST As New XAuto.FTs.FT_
        'Public SVFT_CHOOSE_XXX_LIST As New XAuto.FTs.FT_

        'Public SVFR_SELECTING_XXX_ROW As XAuto.FTs.FT_ Row

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

        Public LAUNCH_CONDITION As MyPosXService.S_02_01002.LCs

        Public Overrides Sub SetLC(ByVal LCName As String)

            Me._launchCondition = LCName
            Me.LAUNCH_CONDITION = CType(System.Enum.Parse(GetType(MyPosXService.S_02_01002.LCs), LCName), MyPosXService.S_02_01002.LCs)

        End Sub

        Public Sub InvokeBizRequest(ByVal affair As Business.B_02_01002.Affairs, ByVal sychronized As Boolean)

            Me._bizAgent.DoRequest(affair, sychronized)

        End Sub

        Private WithEvents _bizAgent As Business.B_02_01002

        Public Sub New(ByVal transactRequestHandle As TransactRequest, ByVal formID As Integer)

            MyBase.New(transactRequestHandle, formID)

            '该调用是 Windows 窗体设计器所必需的。
            InitializeComponent()


            '在 InitializeComponent() 调用之后添加任何初始化
            Me.SetAuthorName("Henry Qu")

            Me.InitializeMe(New Business.B_02_01002(Me), "业务操作", "零售退货单号确认", False)
            Me._bizAgent = CType(Me.BizAgent, Business.B_02_01002)

        End Sub

#End Region

#Region "Basic overrides"

        Protected Overrides Sub IA_InitBeforeRC()

            Me.SetKeyJumpCycle(Keys.Enter, True)
            Me.SetValueEditControls()
            'Me.SetToolStripButtonFunctionKey(Me.ToolStripButton_Close, Keys.F12)

            Me.FormInputGuarder.SetValidate(Me.Label_ReliefTurnoverInfo, InputGuarder.ValidateClassify.Required, Nothing)

            Me.FormInputGuarder.SetInputLinkedLabel(Me.TextEdit_ReliefTurnoverCode, Me.Label_ReliefTurnoverInfo, Me.Label_ReliefTurnoverID)

            'Me._bizAgent.SetDisableControlUnderRequest(Me.DisableControlUnderRequest)

            'me._bizAgent.SetRequestActionTitle(action, title)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_XXX, AddressOf Me.TbActionXXXX

            '指定需要备份值的控件
            'Me.SetValueBackupControl(Me.ControlToBeBackup)

            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Save, AddressOf Me.TbActionSave)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Close, AddressOf Me.TbActionClose)


        End Sub


        Protected Overrides Sub IA_InitAfterRC()


            '做根据LaunchCondition判断分支的相关动作, 如控件的显示不显示, 必填不必填

            Select Case Me.LAUNCH_CONDITION

            End Select

            'Initialize option list controls which value source isn't from the edit form content

            Me._bizAgent.DoRequest(Business.B_02_01002.Affairs.InitDisplay, False)

            'Me.GridControl_.DataSource = Me.SVFT_BINDING_
            'Me.LookupEdit_.Properties.DataSource = Me.SVFT_CHOOSE_

        End Sub


        Protected Overrides Sub IA_ClearContent(Optional ByVal clearFields As Boolean = False)


            'Initialize option list controls which value source is from the edit form content

            Me.TextEdit_ReliefTurnoverCode.Select()

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

            If Me.Label_ReliefTurnoverID.Text.Length > 0 Then
                Me.ResponseToParentForm()
                Me.CloseForm()
            End If


            '
            '保存操作结束后重置保存状态
            '-------------------------------------------------------------------

            Return True

        End Function


        Public Overrides Sub UpdateDisplay()

            'Me._bizAgent.DoRequest(Business.B_0X_00XXX.Affairs.LoadInfo, False)
            'Me._bizAgent.DoRequest(Business.B_0X_00XXX.Affairs.LoadList, False)

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

                Case Business.B_02_01002.Affairs.LoadReliefTurnoverInfoByCode
                    Me.SaveInfo(False)
                    'Case Business.B_01_00201.Affairs.DeleteInfo
                    '    Me.UpdateDisplay()                     

                    'Case Business.B_02_00201.Affairs.LoadList             
                    '    Me.DoPrivateUpdateSelectingRow()               
                    '    Me.GridView_XXXXXList.BestFitColumns()         

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


        Private Sub TbActionSave()

            Me.SaveInfo(True)

        End Sub

        Private Sub TbActionClose()

            Me.CloseForm()

        End Sub


#End Region

#Region "Private Methods"


        Private Sub DoPrivateUpdateSelectingRow()


            'Me.SVFR_SELECTING_ROW = Nothing                          
            '                                                         
            'Me.ToolStripButton_Delete.Enabled = False                
            'Me.ToolStripButton_Revise.Enabled = False                
            '                                                         
            'If Me.GridView_BranchList.RowCount > 0 Then              
            '    Me.SVFR_SELECTING_ROW = _                            
            '        CType(Me.GridView_BindingList.GetDataRow( _      
            '            Me.GridView_BindingList.FocusedRowHandle),  _
            '            XAuto.FTs.FT_Row)                            
            '                                                         
            '    Me.ToolStripButton_Delete.Enabled = True             
            '    Me.ToolStripButton_Revise.Enabled = True             
            '                                                         
            'End If                                                   



            'If IsNothing(Me.TreeList_XXXX.FocusedNode) = False Then  
            '                                                         
            '    Me.SVFR_SELECTING_ROW = _                            
            '         CType(CType( _                                  
            '             Me.TreeList_XXXX.GetDataRecordByNode( _     
            '                 Me.TreeList_XXXX.FocusedNode),  _       
            '             DataRowView).Row, XAuto.FTs.FT_M_AV_XXXXRow)
            '                                                         
            '    If Me.SVFR_SELECTING_ROW.XXXX_ID > 0 Then            
            '        Me.ToolStripButton_Choose.Enabled = True         
            '    End If                                               
            '                                                         
            '    Me.ToolStripButton_DeleteXXXX.Enabled = True         
            '    Me.ToolStripButton_ReviseXXXX.Enabled = True         
            '                                                         
            'End If                                                   



        End Sub


#End Region

#Region "Public Methods"


#End Region

        Private Sub TextEdit_ReliefTurnoverCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit_ReliefTurnoverCode.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me._bizAgent.DoRequest(Business.B_02_01002.Affairs.LoadReliefTurnoverInfoByCode, False)
            End If
        End Sub
    End Class


End Namespace

