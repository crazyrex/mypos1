Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade
Imports MyPosClient.Utils
Imports Microsoft.Office.Interop

Namespace Business


    Public Class B_02_00202
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
        Private _manifest As Manifest.M_02_00202
        Private _service As MyPosXService.S_02_00202

        Public Enum Affairs
            InitDisplay
            BizUtle0002
            AddWareInfo
            SaveInfo
            Remove
            ExportExcel
            LoadInfo
            ImportFromMobile
            LoadEmployeeByCode
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

            Me._manifest = CType(theManifest, Manifest.M_02_00202)

            Try

                Me._service = MyPosXService.S_02_00202.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_02_00202.GetInstance()
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

                Case Affairs.BizUtle0002

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtle0002)

                Case Affairs.AddWareInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoAddWareInfo)

                Case Affairs.SaveInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSaveInfo)

                Case Affairs.Remove

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoRemove)

                Case Affairs.ExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoExportExcel)

                Case Affairs.LoadInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadInfo)

                Case Affairs.ImportFromMobile

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoImportFromMobile)

                Case Affairs.LoadEmployeeByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadEmployeeByCode)


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

                Dim sysWareSpecModelDiscard As Boolean
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity

                Dim wareList As New MyPosXAuto.FTs.FT_XV_M_MP_WARE

                Me._manifest.SVFT_CHOOSE_POS_LIST.Clear()

                Me._service.ServInitDisplay( _
                    sysWareSpecModelDiscard, _
                    Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID, _
                    staffRowSE, _
                    Me._manifest.SVFT_CHOOSE_POS_LIST, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                If staffRowSE.IsNull = False Then
                    Me._manifest.ButtonEdit_EmployeeCode.Text = staffRowSE.STAFF_CODE
                    Me._manifest.Label_EmployeeName.Text = staffRowSE.STAFF_NAME
                    Me._manifest.Label_EmployeeID.Text = CommTK.FString(staffRowSE.STAFF_ID)
                End If

                Me._manifest.LookUpEdit_PosList.Properties.DataSource = Me._manifest.SVFT_CHOOSE_POS_LIST

                If IsNothing(Utils.Decls.CURRENT_POS_ROW) = False Then
                    Me._manifest.LookUpEdit_PosList.EditValue = Utils.Decls.CURRENT_POS_ROW.POS_ID
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

                If sysWareSpecModelDiscard = True Then
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
        Private Function DoBizUtle0002() As String


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
        Private Function DoAddWareInfo() As String


            Try
                Dim wareCode As String
                Dim wareQty As Integer

                Dim lines As String() = Me._manifest.ButtonEdit_WareCode.Text.Trim.Split(","c)
                wareCode = lines(0)
                If lines.Length > 1 Then
                    wareQty = CommTK.FInteger(lines(1))
                Else
                    wareQty = 1
                End If


                Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE( _
                        XL.DB.Utils.Condition.LogicOperators.Logic_And)
                wareCondition.Add( _
                    AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, _
                    "=", _
                    wareCode)

                Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow = _
                    MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareCondition)

                If IsNothing(wareRow) = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00008
                End If

                Me._manifest.ButtonEdit_WareCode.Text = wareRow.WARE_CODE
                Me._manifest.Label_CustomCode.Text = wareRow.CUSTOM_CODE
                Me._manifest.Label_WareID.Text = CommTK.FString(wareRow.WARE_ID)

                Dim inverteryDraftConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_INVENTORY_DRAFT( _
                    XL.DB.Utils.Condition.LogicOperators.Logic_And)
                inverteryDraftConditions.Add( _
                    AfXV.XV_T_MP_INVENTORY_DRAFTColumns.WARE_IDColumn, _
                    "=", _
                    wareRow.WARE_ID)

                Dim bindingRow As MyPosXAuto.FTs.FT_XV_T_MP_INVENTORY_DRAFTRow _
                    = Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST.FindRowByCondition(inverteryDraftConditions)

                If IsNothing(bindingRow) = False Then
                    bindingRow.INVENTORY_AMOUNT += wareQty
                    Return String.Empty
                End If

                bindingRow = Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST.NewXV_T_MP_INVENTORY_DRAFTRow
                Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST.AddXV_T_MP_INVENTORY_DRAFTRow(bindingRow)

                bindingRow.WARE_ID = wareRow.WARE_ID
                bindingRow.WARE_CODE = wareRow.WARE_CODE
                bindingRow.CUSTOM_CODE = wareRow.CUSTOM_CODE
                bindingRow.WARE_NAME = wareRow.WARE_NAME
                bindingRow.UNIT_NAME = wareRow.UNIT_NAME
                bindingRow.SPEC = wareRow.SPEC
                bindingRow.MODEL = wareRow.MODEL
                bindingRow.UNIT_NAME = wareRow.UNIT_NAME
                bindingRow.CUSTOM_CODE = wareRow.CUSTOM_CODE
                bindingRow.ATTRIBUTE1 = wareRow.ATTRIBUTE1
                bindingRow.ATTRIBUTE2 = wareRow.ATTRIBUTE2
                bindingRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                bindingRow.ATTRIBUTE4 = wareRow.ATTRIBUTE4
                bindingRow.INVENTORY_AMOUNT = wareQty
                bindingRow.REMARK = wareRow.REMARK


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


                If Me._manifest.SV_EDIT_INVENTORY_ID.Length <= 0 Then

                    Dim inventoryID As String = Guid.NewGuid.ToString

                    MyPosXAuto.Facade.AfBizInventory.CreateT_MP_INVENTORYInfo( _
                        Me._manifest.CheckEdit_CheckingAll.Checked, _
                        Me._manifest.DateEdit_CreateDate.DateTime, _
                        Me._manifest.Label_EmployeeID.Text, _
                        Me._manifest.TextEdit_InventoryCode.Text, _
                        inventoryID, _
                        MyPosXAuto.Decls.CIVALUE_INVENTORY_STATUS_DRAFT, _
                        CommTK.FString(Me._manifest.LookUpEdit_PosList.EditValue))

                    For Each bingdingsRow As MyPosXAuto.FTs.FT_XV_T_MP_INVENTORY_DRAFTRow In Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST
                        If bingdingsRow.RowState <> DataRowState.Deleted Then
                            'bingdingsRow.INVENTORY_CODE = Me._manifest.TextEdit_InventoryCode.Text
                            bingdingsRow.INVENTORY_ID = inventoryID
                            bingdingsRow.DRAFT_ID = System.Guid.NewGuid.ToString
                        End If
                    Next

                    MyPosXAuto.Facade.AfBizInventory.SaveBatchT_MP_INVENTORY_DRAFTData(Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST)

                    Return String.Empty

                End If

                MyPosXAuto.Facade.AfBizInventory.ReviseT_MP_INVENTORYInfo( _
                    Me._manifest.SV_EDIT_INVENTORY_ID, _
                    Me._manifest.CheckEdit_CheckingAll.Checked, _
                    Me._manifest.DateEdit_CreateDate.DateTime, _
                    Me._manifest.Label_EmployeeID.Text, _
                    Me._manifest.TextEdit_InventoryCode.Text, _
                    MyPosXAuto.Decls.CIVALUE_INVENTORY_STATUS_DRAFT, _
                    CommTK.FString(Me._manifest.LookUpEdit_PosList.EditValue))

                For Each bingdingRow As MyPosXAuto.FTs.FT_XV_T_MP_INVENTORY_DRAFTRow In Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST
                    If bingdingRow.RowState <> DataRowState.Deleted Then
                        bingdingRow.INVENTORY_ID = Me._manifest.SV_EDIT_INVENTORY_ID
                        If bingdingRow.RowState = DataRowState.Added Then
                            bingdingRow.DRAFT_ID = System.Guid.NewGuid.ToString
                        End If
                    End If
                Next

                MyPosXAuto.Facade.AfBizInventory.SaveBatchT_MP_INVENTORY_DRAFTData(Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST)


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
        Private Function DoRemove() As String


            Try

                If IsNothing(Me._manifest.SVFR_SELECTING_INVENTORY_DRAFT_ROW) = False Then
                    Me._manifest.SVFR_SELECTING_INVENTORY_DRAFT_ROW.Delete()
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
        Private Function DoExportExcel() As String


            Try

                Dim sysWareSpecModelDiscard As Boolean
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity

                Me._service.ServExportExcel( _
                    sysWareSpecModelDiscard, _
                    Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID, _
                    staffRowSE, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                Dim toExcel As New Utils.ExcelTK(Me._manifest.SV_EXPORT_EXCEL_FILENAME)

                toExcel.MergeCell(1, 1, 1, 13)
                toExcel.SetRowHeight(1, 35)

                Dim cellFont As Font = New Font("Arial", 16, FontStyle.Bold)

                toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("在库盘点"), cellFont, Color.Black, Color.White)

                toExcel.SetColumnWidth(1, 15)
                toExcel.SetColumnWidth(2, 15)
                toExcel.SetColumnWidth(3, 12)
                toExcel.SetColumnWidth(4, 20)
                toExcel.SetColumnWidth(5, 10)
                toExcel.SetColumnWidth(6, 10)
                toExcel.SetColumnWidth(7, 10)
                toExcel.SetColumnWidth(8, 10)
                toExcel.SetColumnWidth(9, 10)
                toExcel.SetColumnWidth(10, 10)
                toExcel.SetColumnWidth(11, 10)
                toExcel.SetColumnWidth(12, 10)
                toExcel.SetColumnWidth(13, 10)

                If sysAttribute1.Length <= 0 Then
                    toExcel.SetColumnWidth(8, 0)
                End If

                If sysAttribute2.Length <= 0 Then
                    toExcel.SetColumnWidth(9, 0)
                End If

                If sysAttribute3.Length <= 0 Then
                    toExcel.SetColumnWidth(10, 0)
                End If

                If sysAttribute4.Length <= 0 Then
                    toExcel.SetColumnWidth(11, 0)
                End If

                If sysWareSpecModelDiscard = True Then
                    toExcel.SetColumnWidth(6, 0)
                    toExcel.SetColumnWidth(7, 0)
                End If

                toExcel.MergeCell(2, 1, 2, 13)

                cellFont = New Font("Arial", 10, FontStyle.Bold)
                toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("盘点日期:"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 1, CommTK.GetTranslatedString("地点名称:"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 1, CommTK.GetTranslatedString("盘点号:"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(6, 1, CommTK.GetTranslatedString("创建者:"), cellFont, Color.Black, Color.White)

                toExcel.SetCellText(3, 2, String.Format("{0:yyyy/MM/dd}", Me._manifest.DateEdit_CreateDate.DateTime), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 2, Me._manifest.LookUpEdit_PosList.Text, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 2, Me._manifest.TextEdit_InventoryCode.Text, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(6, 2, Me._manifest.Label_EmployeeName.Text, cellFont, Color.Black, Color.White)

                cellFont = New Font("Arial", 12, FontStyle.Bold)

                toExcel.SetCellText(9, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 2, CommTK.GetTranslatedString("货品类别"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 3, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 4, CommTK.GetTranslatedString("自定货号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 5, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 6, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 7, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 8, sysAttribute1, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 9, sysAttribute2, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 10, sysAttribute3, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 11, sysAttribute4, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 12, CommTK.GetTranslatedString("在库数量"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 13, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)

                Dim rowCounter As Integer = 10
                Dim counter As Integer = 1
                Dim totalInventoryAmount As Double = 0

                XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST.Count + rowCounter, 400, False)

                cellFont = New Font("Arial", 10, FontStyle.Regular)

                For Each bindingRow As MyPosXAuto.FTs.FT_XV_T_MP_INVENTORY_DRAFTRow In Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST

                    toExcel.SetCellText(rowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 2, bindingRow.WARE_CLASSIFY_NAME, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 3, bindingRow.WARE_CODE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 4, bindingRow.CUSTOM_CODE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 5, bindingRow.WARE_NAME, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 6, bindingRow.SPEC, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 7, bindingRow.MODEL, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 8, bindingRow.ATTRIBUTE1, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 9, bindingRow.ATTRIBUTE2, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 10, bindingRow.ATTRIBUTE3, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 11, bindingRow.ATTRIBUTE4, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 12, CommTK.FString(bindingRow.INVENTORY_AMOUNT), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 13, bindingRow.UNIT_NAME, cellFont, Color.Black, Color.White)

                    rowCounter += 1
                    counter += 1

                    totalInventoryAmount = totalInventoryAmount + bindingRow.INVENTORY_AMOUNT

                    XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.WARE_NAME)

                Next

                XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                toExcel.SetFrameLine(9, 1, rowCounter - 1, 13, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)

                toExcel.SetFrameLine(8, 1, rowCounter - 1, 13, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                cellFont = New Font("Arial", 12, FontStyle.Bold)

                toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 12, CommTK.FString(totalInventoryAmount), cellFont, Color.Black, Color.White)

                cellFont = New Font("Arial", 10, FontStyle.Bold)

                If staffRowSE.IsNull = False Then
                    toExcel.SetCellText(rowCounter + 2, 13, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                End If

                If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                    toExcel.SetCellText(rowCounter + 3, 13, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                Else
                    toExcel.SetCellText(rowCounter + 3, 13, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
                End If

                toExcel.SaveAndClose()






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
                If Me._manifest.SV_EDIT_INVENTORY_ID.Length <= 0 Then
                    Return String.Empty
                End If

                Dim inventoryRowSE As New MyPosXAuto.FTs.FT_XV_T_MP_INVENTORYRowSEntity

                Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST.Clear()

                Me._service.ServLoadInfo( _
                    Me._manifest.SV_EDIT_INVENTORY_ID, _
                    inventoryRowSE, _
                    Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST)

                Me._manifest.DateEdit_CreateDate.DateTime = inventoryRowSE.CREATE_DATE
                Me._manifest.TextEdit_InventoryCode.Text = inventoryRowSE.INVENTORY_CODE
                Me._manifest.LookUpEdit_PosList.EditValue = inventoryRowSE.POS_ID
                Me._manifest.ButtonEdit_EmployeeCode.Text = inventoryRowSE.CREATOR__STAFF_CODE
                Me._manifest.Label_EmployeeName.Text = inventoryRowSE.CREATOR__STAFF_NAME
                Me._manifest.Label_EmployeeID.Text = CommTK.FString(inventoryRowSE.CREATOR__STAFF_ID)
                Me._manifest.CheckEdit_CheckingAll.Checked = inventoryRowSE.CHECK_ALL_ITEM

                Me._manifest.GridControl_WareList.DataSource = Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST


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



                Dim readTurnoverDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL
                Dim turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow
                Dim turnoverDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)


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
                         CommTK.FString(Me._manifest.LookUpEdit_PosList.EditValue), _
                         readTurnoverDtlList, _
                         Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST)

                Me._manifest.GridControl_WareList.DataSource = Me._manifest.SVFT_BINDING_INVENTORY_DRAFT_LIST
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
        Private Function DoLoadEmployeeByCode() As String


            Try

                Dim staffConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_STAFF(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                staffConditions.Add(AfBizMaster.M_STAFFColumns.STAFF_CODEColumn, "=", Me._manifest.ButtonEdit_EmployeeCode.Text)

                Dim staffRow As MyPosXAuto.FTs.FT_M_STAFFRow = MyPosXAuto.Facade.AfBizMaster.GetM_STAFFRow(staffConditions)

                If IsNothing(staffRow) = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00030
                End If

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
