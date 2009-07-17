﻿
'===========================================================
'Code generated by Softlands Solution
'-----------------------------------------------------------
'业务操作, 零售简单操作
'
'Programmed by:
'    Henry Qu
'
'Created at:
'    2009/07/02
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

    Partial Public Class M_02_01001

#Region"Prerequested Inits"

        #Region"Shared values"
        '
        'Shared Value, 用于与其它窗体交换数值的情况下, 需要自己根据需要更改命名
        '原则上所有UTLD的变量不能出现在成品中, 在确定不需要的情况下应删除UTLD
        '-------------------------------------------------------------------
        Public SV_POS_SET_ROWSE As New MyPosXAuto.FTs.FT_S_MP_POS_SETRowSEntity
        Public SV_UTLD_0002 As String ="SV_UTLD_0002"
        'Public SV_UTLD_0003 As String ="SV_UTLD_0003"
        'Public SV_UTLD_0004 As String ="SV_UTLD_0004"
        'Public SV_UTLD_0005 As String ="SV_UTLD_0005"
        'Public SV_RPTOPT_EXCEL As XForm.ReportOption = Nothing
        'Public SV_RPTOPT_LABEL As XForm.ReportOption = Nothing

        '读取,显示数据的条件值变量
        'Public SVLM_UTLD_0001 As String ="SVLM_UTLD_0001"
        'Public SVLM_UTLD_0002 As String ="SVLM_UTLD_0002"

        '数据列表变量
        Public SVFT_REF_SALE_TEMPLATE_WARE_LIST As New MyPosXAuto.FTs.FT_XV_T_MP_SALE_TEMPLATE_WARE
        Public SVFT_BINDING_TURNOVER_DTL_LIST As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL

        Public SVFT_CACHE_DATA_TURNOVER_LIST As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER
        Public SVFT_CACHE_DATE_TURNOVER_DTL_LIST As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL

        'Public SVFT_CHOOSE_XXX_LIST As New XAuto.FTs.FT_

        Public SVFR_BINDING_TURNOVER_DTL_ROW As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow

        #End Region


        #Region"Private values"

        'Private PV_UTLD_0001 As String =""
        'Private PV_UTLD_0002 As String =""
        'Private PV_UTLD_0003 As String =""
        'Private PV_UTLD_0004 As String =""
        'Private PV_UTLD_0005 As String =""

        #End Region
        'Launch Conditions
        '-------------------------------------------------------------------

        Public LAUNCH_CONDITION As MyPosXService.S_02_01001.LCs

        Public Overrides Sub SetLC(ByVal LCName As String)

            Me._launchCondition = LCName
            Me.LAUNCH_CONDITION = CType(System.Enum.Parse(GetType(MyPosXService.S_02_01001.LCs), LCName), MyPosXService.S_02_01001.LCs)

        End Sub

        Public Sub InvokeBizRequest(ByVal affair As Business.B_02_01001.Affairs, ByVal sychronized As Boolean)

            Me._bizAgent.DoRequest(affair, sychronized)

        End Sub

        Private WithEvents _bizAgent As Business.B_02_01001

        Public Sub New(ByVal transactRequestHandle As TransactRequest, ByVal formID As Integer)

            MyBase.New(transactRequestHandle, formID)

            '该调用是 Windows 窗体设计器所必需的。
            InitializeComponent()


            '在 InitializeComponent() 调用之后添加任何初始化
            Me.SetAuthorName("Henry Qu")

            Me.InitializeMe(New Business.B_02_01001(Me), "业务操作", "零售简单操作", False)
            Me._bizAgent = CType(Me.BizAgent, Business.B_02_01001)

        End Sub

#End Region

#Region "Basic overrides"

        Protected Overrides Sub IA_InitBeforeRC()

            Me.SetKeyJumpCycle(Keys.Enter, True)
            Me.SetValueEditControls()
            'Me.SetToolStripButtonFunctionKey(Me.ToolStripButton_Close, Keys.F12)

            'Me.FormInputGuarder.SetValidate(Me.TextEdit_Input, InputGuarder.ValidateClassify.Required, Nothing)

            Me.FormInputGuarder.SetInputLinkedLabel(Me.ButtonEdit_WareCode, Me.Label_WareInfo, Me.Label_WareID)
            Me.FormInputGuarder.SetInputLinkedLabel(Me.TextEdit_ClientCode, Me.Label_ClientName, Me.Label_ClientID)

            'Me._bizAgent.SetDisableControlUnderRequest(Me.DisableControlUnderRequest)

            'me._bizAgent.SetRequestActionTitle(action, title)
            'Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_XXX, AddressOf Me.TbActionXXXX

            '指定需要备份值的控件
            'Me.SetValueBackupControl(Me.ControlToBeBackup)

            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Create, AddressOf Me.TbActionCreate)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Save, AddressOf Me.TbActionSave)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Remove, AddressOf Me.TbActionRemove)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Close, AddressOf Me.TbActionClose)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_PurchaseList, AddressOf Me.TbActionPurchaseList)
            Me.SetToolStripButtonTransactionHandle(Me.ToolStripButton_Return, AddressOf Me.TbActionReturn)
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

            Me.GridControl_TurnoverDtl.DataSource = Me.SVFT_BINDING_TURNOVER_DTL_LIST
            Me._bizAgent.DoRequest(Business.B_02_01001.Affairs.InitDisplay, False)

            'Me.LookupEdit_.Properties.DataSource = Me.SVFT_CHOOSE_

        End Sub


        Protected Overrides Sub IA_ClearContent(Optional ByVal clearFields As Boolean = False)


            'Initialize option list controls which value source is from the edit form content

            Me.ButtonEdit_WareCode.Select()

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

                Case "ButtonEdit_WareCode_ButtonClick"
                    Dim chooseForm As M_01_00201 = CType(popupForm, M_01_00201)
                    Me.ButtonEdit_WareCode.Text = chooseForm.SVFR_SELECTING_WARE_ROW.WARE_CODE
                    Me._bizAgent.DoRequest(Business.B_02_01001.Affairs.AddWare, False)


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
            Select Case e.KeyCode
                Case Keys.F4
                    Me.DoPrivateFocusToAmount()
            End Select
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

            Me._bizAgent.DoRequest(Business.B_02_01001.Affairs.SaveInfo, False)


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

                Case Business.B_02_01001.Affairs.InitDisplay
                    Me._bizAgent.DoRequest(Business.B_02_01001.Affairs.UpdateSummary, False)
                    Me.GridView_TurnoverDtl.BestFitColumns()
                    Me.DoPrivateSelectRowByWareCode()
                    Me.DoPrivateUpdateCacheStatus()

                Case Business.B_02_01001.Affairs.AddWare
                    Me.ButtonEdit_WareCode.SelectAll()
                    Me._bizAgent.DoRequest(Business.B_02_01001.Affairs.UpdateSummary, False)
                    Me.GridView_TurnoverDtl.BestFitColumns()
                    Me.DoPrivateSelectRowByWareCode()
                    Me.DoPrivateUpdateCacheStatus()

            End Select
        End Sub

        Private Sub Timer_Surveillant_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Surveillant.Tick

        End Sub

        Private Sub ButtonEdit_WareCode_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit_WareCode.ButtonClick
            Dim inputForm As New M_01_00201(Me.TransactRequestHandle, Me.FormID)
            inputForm.LAUNCH_CONDITION = MyPosXService.S_01_00201.LCs.Choose
            Me.PopupForm(inputForm, "ButtonEdit_WareCode_ButtonClick", False)
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

        Private Sub ButtonEdit_WareCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ButtonEdit_WareCode.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me._bizAgent.DoRequest(Business.B_02_01001.Affairs.AddWare, False)
            End If
        End Sub

        Private Sub CheckEdit_IsClient_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit_IsClient.CheckedChanged
            Me.TextEdit_ClientCode.Enabled = Me.CheckEdit_IsClient.Checked
            If Me.TextEdit_ClientCode.Enabled = True Then
                Me.TextEdit_ClientCode.Select()
                Me.FormInputGuarder.SetValidate(Me.TextEdit_ClientCode, InputGuarder.ValidateClassify.Required, Nothing)
            Else
                Me.TextEdit_ClientCode.ResetText()
                Me.FormInputGuarder.RemoveRequiredField(Me.TextEdit_ClientCode)
            End If
        End Sub

        Private Sub TextEdit_ClientCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit_ClientCode.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me._bizAgent.DoRequest(Business.B_02_01001.Affairs.LoadClientInfoByCode, False)
            End If
        End Sub

        Private Sub SpinEdit_WareAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SpinEdit_WareAmount.KeyDown

            If IsNothing(Me.SVFR_BINDING_TURNOVER_DTL_ROW) = False Then

                Me.SVFR_BINDING_TURNOVER_DTL_ROW.WARE_AMOUNT = Me.SpinEdit_WareAmount.Value
                Me.SVFR_BINDING_TURNOVER_DTL_ROW.SUM_PRICE = _
                    CommTK.FDecimal(Me.SVFR_BINDING_TURNOVER_DTL_ROW.WARE_AMOUNT * Me.SVFR_BINDING_TURNOVER_DTL_ROW.UNIT_PRICE)
                Me.SVFR_BINDING_TURNOVER_DTL_ROW.SUM_DISCOUNT = _
                    CommTK.FDecimal(Me.SVFR_BINDING_TURNOVER_DTL_ROW.WARE_AMOUNT * Me.SVFR_BINDING_TURNOVER_DTL_ROW.UNIT_DISCOUNT)
                Me.SVFR_BINDING_TURNOVER_DTL_ROW.SUM_COST = _
                    CommTK.FDecimal(Me.SVFR_BINDING_TURNOVER_DTL_ROW.WARE_AMOUNT * Me.SVFR_BINDING_TURNOVER_DTL_ROW.UNIT_COST)

            End If

            Me.ButtonEdit_WareCode.SelectAll()
            Me.ButtonEdit_WareCode.Select()
        End Sub

        Private Sub CalcEdit_Payment_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcEdit_Payment.EditValueChanged
            Me.Label_Change.Text = CommTK.FString(Me.CalcEdit_Payment.Value - CommTK.FDecimal(Me.Label_Payable.Text), False, "#,##0.00")

        End Sub
#End Region

#Region "ToolStrip Actions"


        Private Sub TbActionCreate()

            If Me.IsSaved = False AndAlso _
                Window.XLMessageBox.ShowMessage( _
                    MyPosXService.Decls.MSG_CONFIRM_00021, _
                    Window.XLMessageBox.MessageType.Warning, _
                     MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                Return
            End If

            Me.IA_ClearContent(True)
        End Sub

        Private Sub TbActionSave()

            Me.SaveInfo(True)

        End Sub

        Private Sub TbActionRemove()

            If IsNothing(Me.SVFR_BINDING_TURNOVER_DTL_ROW) = True Then
                Return
            End If

            Me.SVFR_BINDING_TURNOVER_DTL_ROW.Delete()
            Me.DoPrivateUpdateSelectingRow()

            Me._bizAgent.DoRequest(Business.B_02_01001.Affairs.UpdateSummary, False)

            Me.SVFT_CACHE_DATE_TURNOVER_DTL_LIST.SaveXml( _
                WinTK.GetResourceFilePath( _
                    ResourceType.Data, _
                    Utils.Decls.CACHE_DATA_FILE_TURNOVER_DETAIL))
            Me.DoPrivateUpdateCacheStatus()

        End Sub

        Private Sub TbActionClose()

            Me.CloseForm()

        End Sub


        Private Sub TbActionPurchaseList()

        End Sub


        Private Sub TbActionReturn()

            Dim inputForm As New M_02_01002(Me.TransactRequestHandle, Me.FormID)
            Me.PopupForm(inputForm, "TbActionReturn", False)

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


        Private Sub DoPrivateFocusToAmount()
            If Me.Label_WareID.Text.Length = 0 Then
                Me.ShowStatusMessage(StatusMessageIcon.Alert, MyPosXService.Decls.MSG_STATUS_0020)
                Me.ButtonEdit_WareCode.Select()
                Return
            End If

            Me.SpinEdit_WareAmount.Select()

        End Sub


        Private Sub DoPrivateSelectRowByWareCode()

            Me.ButtonEdit_WareCode.Text = Me.ButtonEdit_WareCode.Text.Trim.ToUpper
            For rowIndex As Integer = 0 To Me.GridView_TurnoverDtl.RowCount - 1
                If Me.GridView_TurnoverDtl.GetRowCellDisplayText(rowIndex, Me.GridColumn_WareCode).ToUpper = Me.ButtonEdit_WareCode.Text Then
                    Me.GridView_TurnoverDtl.FocusedRowHandle = rowIndex
                    Exit For
                End If
            Next

        End Sub


        Private Sub DoPrivateUpdateCacheStatus()

            Me.Label_CacheStatus.Text = CommTK.GetTranslatedString("缓存中有^张销售单", Me.SVFT_CACHE_DATA_TURNOVER_LIST.UndeletedRowCount)

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


        Public Sub DoPublicDisableOperations()
            Me.Enabled = False
            Me.ToolStripButton_Create.Enabled = False
            Me.ToolStripButton_Remove.Enabled = False
            Me.ToolStripButton_Save.Enabled = False

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

        Private Sub LinkLabel_UploadCacheData_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_UploadCacheData.LinkClicked
            Me._bizAgent.DoRequest(Business.B_02_01001.Affairs.UploadCacheData, False)
        End Sub

        Private Sub CalcEdit_ExtraDiscount_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcEdit_ExtraDiscount.EditValueChanged
            Me._bizAgent.DoRequest(Business.B_02_01001.Affairs.UpdateSummary, False)
        End Sub
    End Class



End Namespace

