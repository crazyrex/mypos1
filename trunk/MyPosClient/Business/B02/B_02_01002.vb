﻿
'===========================================================
'Code generated by Softlands Solution
'-----------------------------------------------------------
'业务操作, 零售退货单号确认
'
'===========================================================
Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils

Namespace Business


    Public Class B_02_01002  
        Inherits XL.Win.Component.BaseAgent

#Region" 组件设计器生成的代码"

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


#Region"Prerequested Inits"

        '
        '本代理所对应的表现层实例
        '
        Private _manifest As Manifest.M_02_01002     
        Private _service As MyPosXService.S_02_01002     

        Public Enum Affairs
            InitDisplay
            LoadReliefTurnoverInfoByCode
            SaveInfo
            LoadList
        End Enum

        Public Sub New(ByVal theManifest As XL.Win.Component.BaseForm)
            Me.New()

            Me._manifest = CType(theManifest, Manifest.M_02_01002)

            Try

                Me._service = MyPosXService.S_02_01002.GetInstance()

            Catch ex As Exception

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

                Case Affairs.LoadReliefTurnoverInfoByCode

                    '                                                                             
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包                      
                    '-------------------------------------------------------------------          
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadReliefTurnoverInfoByCode)

                Case Affairs.SaveInfo

                    '                                                                             
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包                      
                    '-------------------------------------------------------------------          
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSaveInfo)

                Case Affairs.LoadList

                    '                                                                             
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包                      
                    '-------------------------------------------------------------------          
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadList)

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




                'Dim choosePurchaseWayList As New MyPosXAuto.FTs.FT_CIV_PURCHASE_WAY                                       
                'Dim chooseAssetAbsentTypeList As New MyPosXAuto.FTs.FT_CIV_ASSET_ABSENT_TYPE                              
                'Dim chooseAssetConformationList As New MyPosXAuto.FTs.FT_CIV_ASSET_CONFORMATION                           
                'Dim chooseEliminateWayList As New MyPosXAuto.FTs.FT_CIV_ELIMINATE_WAY                                     
                'Dim chooseInAccountCredenceTextList As New MyPosXAuto.FTs.FT_CIV_IN_ACCOUNT_CREDENCE_TEXT                 
                '                                                                                                     
                'Dim sysManageFormMustConfirm As Boolean                                                              
                '                                                                                                     
                'Me._service.ServInitDisplay( _                                                                       
                '    CommDecl.CURRENT_LANGUAGE_OPTION, _                                                              
                '    choosePurchaseWayList, _                                                                         
                '    chooseAssetAbsentTypeList, _                                                                     
                '    chooseAssetConformationList, _                                                                   
                '    chooseEliminateWayList, _                                                                        
                '    chooseInAccountCredenceTextList, _                                                               
                '    sysManageFormMustConfirm)                                                                        
                '                                                                                                     
                'Me._manifest.LookUpEdit_AssetAbsentType.Properties.DataSource = chooseAssetAbsentTypeList            
                'Me._manifest.LookUpEdit_Conformation.Properties.DataSource = chooseAssetConformationList             
                'Me._manifest.LookUpEdit_EliminateWay.Properties.DataSource = chooseEliminateWayList                  
                'Me._manifest.LookUpEdit_PurchaseWay.Properties.DataSource = choosePurchaseWayList                    
                'Me._manifest.LookUpEdit_InAccountCredenceText.Properties.DataSource = chooseInAccountCredenceTextList
                '                                                                                                     
                'Me._manifest.LookUpEdit_AssetAbsentType.EditValue = XAuto.Decls.CIVALUE_ASSET_ABSENT_TYPE_NONE       
                'Me._manifest.LookUpEdit_EliminateWay.EditValue = MyPosXService.Decls.DEFAULT_CI_ELIMINATE_WAY_VALUE_NONE  
                '                                                                                                     
                'If Me._manifest.SV_EDITING_ASSET_ID < 0 Then                                                         
                '			xxxx                                                                                            
                'End If                                                                                               
                '                                                                                                     
                'If sysManageFormMustConfirm = True Then                                                              
                '    Me._manifest.ButtonEdit_CurrentDepartmentCode.Enabled = False                                    
                'End If                                                                                               


                'Me._manifest.SV_RPTOPT_LABEL = New XForm.ReportOption(MyPosXService.Decls.RPT_NAME_0001, XForm.ReportOption.PrintType.Label, True)
                'Me._manifest.SV_RPTOPT_LABEL.DefaultFileName = SysInfo.ReadLocalSysInfo(XService.Decls.LVN_ASSET_LABEL_FILE_PATH)            

                'Me._manifest.SV_RPTOPT_PRINTER = New XForm.ReportOption(XService.Decls.RPT_NAME_0001, XForm.ReportOption.PrintType.Print, True)
                '                                                                                                                             
                'Me._manifest.SV_RPTOPT_EXCEL = New XForm.ReportOption(XService.Decls.RPT_NAME_0002, XForm.ReportOption.PrintType.Excel, True)


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
        Private Function DoLoadReliefTurnoverInfoByCode() As String


            Try

                Dim turnoverCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
                turnoverCondition.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVERColumns.TURNOVER_CODEColumn, "=", Me._manifest.TextEdit_ReliefTurnoverCode.Text)

                Dim turnoverRowSEntity As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVERRowSEntity
                MyPosXAuto.Facade.AfXV.FillXV_H_MP_TURNOVERRowSEntity( _
                    turnoverRowSEntity, _
                    turnoverCondition)


                If turnoverRowSEntity.IsNull = False Then
                    If turnoverRowSEntity.TURNOVER_STYLE <> MyPosXAuto.Decls.CIVALUE_TURNOVER_STYLE_SOLD Then
                        Return MyPosXService.Decls.MSG_ALERT_00063
                    End If
                    Me._manifest.CheckEdit_IsCacheData.Checked = False
                Else
                    Dim cacheDataTurnoverCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
                    Dim cacheDataTurnoverList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER
                    Dim cacheDataTurnoverRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVERRow

                    cacheDataTurnoverList.SaveXml( _
                        WinTK.GetResourceFilePath( _
                            ResourceType.Data, _
                            Utils.Decls.CACHE_DATA_FILE_TURNOVER))

                    cacheDataTurnoverRow = cacheDataTurnoverList.FindRowByCondition(cacheDataTurnoverCondition)
                    If IsNothing(cacheDataTurnoverRow) = True Then
                        Return MyPosXService.Decls.MSG_ALERT_00062
                    End If

                    cacheDataTurnoverRow.FillSEntity(turnoverRowSEntity)
                    Me._manifest.CheckEdit_IsCacheData.Checked = True

                End If

                If turnoverRowSEntity.IsNull = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00062
                End If

                Me._manifest.Label_ReliefTurnoverID.Text = turnoverRowSEntity.TURNOVER_ID
                Me._manifest.Label_ReliefTurnoverInfo.Text = _
                    String.Format("开单时间: {0:yyyy-MM-dd}", turnoverRowSEntity.TURNOVER_TIME)

                'Dim servResult As String = _                             
                '    Me._service.ServLoadReliefTurnoverInfoByCode()

                'If servResult.Length > 0 Then                 
                '    Return servResult
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
        Private Function DoSaveInfo() As String


            Try


                'Dim servResult As String = _                                       
                '    Me._service.ServSaveInfo()                                     

                'If servResult.Length > 0 Then                                      
                '    Return servResult                                              
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


                'Dim servResult As String = _                                       
                '    Me._service.ServLoadList()                                     

                'If servResult.Length > 0 Then                                      
                '    Return servResult                                              
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

#End Region


    End Class

End Namespace




'Code Samples Below ------------------------

        ''''Function remark:                                                                                                            
        ''''                                                                                                                            
        ''''                                                                                                                            
        ''''-------------------------------------------------------------------                                                         
        'Private Function DoLoadXXXByCode() As String                                                                                   
        '                                                                                                                               
        '                                                                                                                               
        '    Try                                                                                                                        
        '        If Me._manifest.ButtonEdit_XXXCode.Text.Trim.Length = 0 Then                                                           
        '            Return String.Empty                                                                                                
        '        End If                                                                                                                 
        '                                                                                                                               
        '        Dim SSCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_SSS(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
        '        SSCondition.Add(XAuto.Facade.AfBizMaster.M_SSSColumns.SS_CODEColumn, "=", Me._manifest.ButtonEdit_XXXCode.Text)      
        '                                                                                                                               
        '        Dim SSRow As XAuto.FTs.FT_M_SSSRow = _                                                                                 
        '            XAuto.Facade.AfBizMaster.GetM_SSSRow(SSCondition)                                                                  
        '                                                                                                                               
        '        If IsNothing(SSRow) = True Then                                                                                        
        '            Return XService.Decls.MSG_ALERT_00001                                                                              
        '        End If                                                                                                                 
        '                                                                                                                               
        '        Me._manifest.ButtonEdit_XXXCode.Text = SSRow.SS_CODE                                                                   
        '        Me._manifest.Label_XXXName.Text = SSRow.SS_NAME                                                                        
        '        Me._manifest.Label_XXXID.Text = CommTK.FString(SSRow.SS_ID)                                                            
        '                                                                                                                               
        '        'Dim servResult As String = _                                                                                          
        '        '    Me._service.ServLoadXXXByCode()                                                                                   
        '                                                                                                                               
        '        'If servResult.Length > 0 Then                                                                                         
        '        '    Return servResult                                                                                                 
        '        'End If                                                                                                                
        '                                                                                                                               
        '    Catch ex As XL.Common.Utils.XLException                                                                                    
        '                                                                                                                               
        '        Dim logContentBuilder As New LineStrBuilder                                                                            
        '        logContentBuilder.AppendLine("Message: {0}", ex.Message)                                                           
        '        logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)                                                    
        '                                                                                                                               
        '        WinTK.OutputLog("XL Exception", logContentBuilder.ToString())                                                        
        '                                                                                                                               
        '        Return ex.Message                                                                                                      
        '                                                                                                                               
        '    Catch ex As Exception                                                                                                      
        '                                                                                                                               
        '        Dim logContentBuilder As New LineStrBuilder                                                                            
        '        logContentBuilder.AppendLine("Message: {0}", ex.Message)                                                           
        '        logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)                                                    
        '                                                                                                                               
        '        WinTK.OutputLog("Exception occured", logContentBuilder.ToString())                                                   
        '                                                                                                                               
        '        XL.Win.Window.XLMessageBox.UseSmallFont = True                                                                         
        '        Return ex.Message & vbNewLine & ex.StackTrace.ToString()                                                               
        '                                                                                                                               
        '    End Try                                                                                                                    
        '                                                                                                                               
        '    Return String.Empty                                                                                                        
        '                                                                                                                               
        'End Function                                                                                                                   


