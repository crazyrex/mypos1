Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosClient.Utils
Imports MyPosXAuto.Facade
Imports Microsoft.Office.Interop

Namespace Business


    Public Class B_03_00101
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
        Private _manifest As Manifest.M_03_00101
        Private _service As MyPosXService.S_03_00101

        Public Enum Affairs
            InitDisplay
            LoadList
            ShowHighLight
            ExportExcel
            PrintReport
            LoadShelfStockDifferenceList
            LoadLocationStockList
            AddAllWares
            AddWareByCode
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

            Me._manifest = CType(theManifest, Manifest.M_03_00101)

            Try

                Me._service = MyPosXService.S_03_00101.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_03_00101.GetInstance()
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

                Case Affairs.LoadList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadList)

                Case Affairs.ShowHighLight

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoShowHighLight)

                Case Affairs.ExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoExportExcel)

                Case Affairs.PrintReport

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoPrintReport)

                Case Affairs.LoadShelfStockDifferenceList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadShelfStockDifferenceList)

                Case Affairs.LoadLocationStockList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadLocationStockList)

                Case Affairs.AddAllWares

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoAddAllWares)

                Case Affairs.AddWareByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoAddWareByCode)

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
                Dim sysHideFinancials As Boolean
                Dim sysShowCustomWareCode As Boolean
                Dim arriveConfirm As Boolean
                Dim turnoverMode As Integer
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Me._manifest.SVFT_CHOOSE_POS_LIST.Clear()

                Me._service.ServInitDisplay( _
                    sysWareSpecModelDiscard, _
                    sysHideFinancials, _
                    sysShowCustomWareCode, _
                    arriveConfirm, _
                    turnoverMode, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, Me._manifest.SVFT_CHOOSE_POS_LIST)
                Me._manifest.LookUpEdit_Pos.Properties.DataSource = Me._manifest.SVFT_CHOOSE_POS_LIST

                If IsNothing(Utils.Decls.CURRENT_POS_ROW) = False Then
                    Me._manifest.LookUpEdit_Pos.EditValue = Utils.Decls.CURRENT_POS_ROW.POS_ID
                End If

                If arriveConfirm = False Then
                    Me._manifest.GridColumn_ConsignInRemains.Visible = False
                    Me._manifest.GridColumn_ConsignOutRemains.Visible = False
                End If

                If turnoverMode = MyPosXService.Decls.WARE_TURNOVER_MODE_NORMAL Then
                    Me._manifest.XtraTabPage_BatchList.PageVisible = False
                End If

                Dim userCostHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_COST_HIDDEN"))

                If userCostHidden = True Then
                    Me._manifest.GridColumn_CurrentCost.Visible = False
                Else
                    Me._manifest.GridColumn_CurrentCost.Visible = True
                End If

                If sysHideFinancials = True Then
                    Me._manifest.GridColumn_CurrentCost.Visible = False
                End If

                Me._manifest.GridColumn_Attribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_ShelfAttribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_SAttribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_BAtrribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_Attribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_ShelfAttribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_SAttribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_BAtrribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_Attribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_ShelfAttribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_SAttribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_BAtrribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_Attribute4.Caption = sysAttribute4
                Me._manifest.GridColumn_ShelfAttribute4.Caption = sysAttribute4
                Me._manifest.GridColumn_SAttribute4.Caption = sysAttribute4
                Me._manifest.GridColumn_BAtrribute4.Caption = sysAttribute4

                If sysAttribute1.Length = 0 Then
                    Me._manifest.GridColumn_Attribute1.Visible = False
                    Me._manifest.GridColumn_ShelfAttribute1.Visible = False
                    Me._manifest.GridColumn_SAttribute1.Visible = False
                    Me._manifest.GridColumn_BAtrribute1.Visible = False
                End If

                If sysAttribute2.Length = 0 Then
                    Me._manifest.GridColumn_Attribute2.Visible = False
                    Me._manifest.GridColumn_ShelfAttribute2.Visible = False
                    Me._manifest.GridColumn_SAttribute2.Visible = False
                    Me._manifest.GridColumn_BAtrribute2.Visible = False

                End If

                If sysAttribute3.Length = 0 Then
                    Me._manifest.GridColumn_Attribute3.Visible = False
                    Me._manifest.GridColumn_ShelfAttribute3.Visible = False
                    Me._manifest.GridColumn_SAttribute3.Visible = False
                    Me._manifest.GridColumn_BAtrribute3.Visible = False

                End If

                If sysAttribute4.Length = 0 Then
                    Me._manifest.GridColumn_Attribute4.Visible = False
                    Me._manifest.GridColumn_ShelfAttribute4.Visible = False
                    Me._manifest.GridColumn_SAttribute4.Visible = False
                    Me._manifest.GridColumn_BAtrribute4.Visible = False

                End If

                If sysWareSpecModelDiscard = True Then
                    Me._manifest.GridColumn_Spec.Visible = False
                    Me._manifest.GridColumn_Model.Visible = False

                    Me._manifest.GridColumn_ShelfSpec.Visible = False
                    Me._manifest.GridColumn_ShelfModel.Visible = False

                    Me._manifest.GridColumn_SSpec.Visible = False
                    Me._manifest.GridColumn_SModel.Visible = False

                    Me._manifest.GridColumn_BSpec.Visible = False
                    Me._manifest.GridColumn_BModel.Visible = False

                End If

                Me._manifest.SV_DISPLAYING_WARE_IDS = CommTK.StrToAL(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_M_03_00101_DISPLAYING_WAREIDS))
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

                Me._manifest.SVFT_BINDING_WARE_TOTAL_LIST.Clear()
                Me._manifest.SVFT_BINDING_BATCH_WARE_TOTAL_LIST.Clear()

                Dim readingWareTotalList As New MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTAL
                Dim readingBatchWareTotalList As New MyPosXAuto.FTs.FT_MV_MP_POS_BATCH_WARE_TOTAL
                Dim wareIDs As New ArrayList

                Dim wareCount As Integer = 0
                For Each wareID In Me._manifest.SV_DISPLAYING_WARE_IDS
                    wareCount += 1
                    wareIDs.Add(wareID)
                    Me._manifest.ShowStatusMessage(StatusMessageIcon.Alert, MyPosXService.Decls.MSG_STATUS_0030, wareCount, Me._manifest.SV_DISPLAYING_WARE_IDS.Count)
                    If wareIDs.Count > 30 Then

                        readingWareTotalList.Clear()
                        readingBatchWareTotalList.Clear()

                        Me._service.ServLoadList( _
                            CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue), _
                            CommTK.ALToStr(wareIDs), _
                            readingWareTotalList, _
                            readingBatchWareTotalList)

                        wareIDs.Clear()

                        Me._manifest.SVFT_BINDING_WARE_TOTAL_LIST.ImportTable(readingWareTotalList, Nothing)
                        Me._manifest.SVFT_BINDING_BATCH_WARE_TOTAL_LIST.ImportTable(readingBatchWareTotalList, Nothing)
                    End If

                Next

                If wareIDs.Count > 0 Then

                    readingWareTotalList.Clear()
                    readingBatchWareTotalList.Clear()

                    Me._service.ServLoadList( _
                        CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue), _
                        CommTK.ALToStr(wareIDs), _
                        readingWareTotalList, _
                        readingBatchWareTotalList)

                    wareIDs.Clear()

                    Me._manifest.SVFT_BINDING_WARE_TOTAL_LIST.ImportTable(readingWareTotalList, Nothing)
                    Me._manifest.SVFT_BINDING_BATCH_WARE_TOTAL_LIST.ImportTable(readingBatchWareTotalList, Nothing)
                End If

                SysInfo.WriteLocalSysInfo(MyPosXService.Decls.LVN_M_03_00101_DISPLAYING_WAREIDS, CommTK.ALToStr(Me._manifest.SV_DISPLAYING_WARE_IDS))
                Me._manifest.ShowStatusMessage(StatusMessageIcon.Okay, MyPosXService.Decls.MSG_STATUS_0028)


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
        Private Function DoShowHighLight() As String


            Try


                For Each posWareTotalRow As MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTALRow In Me._manifest.SVFT_BINDING_WARE_TOTAL_LIST

                    If posWareTotalRow.LACK_AMOUNT > 0 Then
                        posWareTotalRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_CURRENT_AMOUNT
                    End If
                Next


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
                Dim sysHideFinancials As Boolean
                Dim sysShowCustomWareCode As Boolean
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity

                Me._service.ServExportExcel( _
                    sysWareSpecModelDiscard, _
                    sysHideFinancials, _
                    sysShowCustomWareCode, _
                    Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID, _
                    staffRowSE, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                If IO.File.Exists(Me._manifest.SV_EXPORT_EXCEL_FILENAME) = True Then
                    IO.File.Delete(Me._manifest.SV_EXPORT_EXCEL_FILENAME)
                End If

                Dim toExcel As New Utils.ExcelTK(Me._manifest.SV_EXPORT_EXCEL_FILENAME)

                If Me._manifest.XtraTabControl_Lists.SelectedTabPage Is Me._manifest.XtraTabPage_NormalList Then

                    toExcel.MergeCell(1, 1, 1, 19)
                    toExcel.SetRowHeight(1, 35)

                    toExcel.SetColumnWidth(1, 10)
                    toExcel.SetColumnWidth(2, 10)
                    toExcel.SetColumnWidth(3, 10)
                    toExcel.SetColumnWidth(4, 20)
                    toExcel.SetColumnWidth(5, 10)
                    toExcel.SetColumnWidth(6, 10)
                    toExcel.SetColumnWidth(7, 10)
                    toExcel.SetColumnWidth(8, 10)
                    toExcel.SetColumnWidth(9, 10)
                    toExcel.SetColumnWidth(10, 10)
                    toExcel.SetColumnWidth(11, 10)
                    toExcel.SetColumnWidth(12, 10)
                    toExcel.SetColumnWidth(13, 12)
                    toExcel.SetColumnWidth(14, 12)
                    toExcel.SetColumnWidth(15, 10)
                    toExcel.SetColumnWidth(16, 12)
                    toExcel.SetColumnWidth(17, 12)
                    toExcel.SetColumnWidth(18, 10)
                    toExcel.SetColumnWidth(19, 10)

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

                    If sysHideFinancials = True Then
                        toExcel.SetColumnWidth(13, 0)
                        toExcel.SetColumnWidth(15, 0)
                        toExcel.SetColumnWidth(16, 0)
                        toExcel.SetColumnWidth(17, 0)
                    End If

                    Dim cellFont As Font = New Font("Arial", 16, FontStyle.Bold)
                    toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("在库货品表"), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 10, FontStyle.Bold)
                    toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("地点名称:"), cellFont, Color.Black, Color.White)
                    toExcel.MergeCell(3, 2, 3, 18)

                    toExcel.SetCellText(3, 2, Me._manifest.LookUpEdit_Pos.Text, cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)
                    toExcel.SetCellText(6, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 2, CommTK.GetTranslatedString("货品类别"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 3, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 4, CommTK.GetTranslatedString("自定货号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 5, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 6, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 7, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 8, sysAttribute1, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 9, sysAttribute2, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 10, sysAttribute3, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 11, sysAttribute4, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 12, CommTK.GetTranslatedString("当前数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 13, CommTK.GetTranslatedString("当前成本"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 14, CommTK.GetTranslatedString("原价"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 15, CommTK.GetTranslatedString("最低库存限制"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 16, CommTK.GetTranslatedString("缺货数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 17, CommTK.GetTranslatedString("出货缺交货量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 18, CommTK.GetTranslatedString("入货缺交货量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 19, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)

                    Dim rowCounter As Integer = 7
                    Dim counter As Integer = 1
                    Dim totalCurrentAmount As Double = 0
                    Dim totalCurrentCost As Double = 0
                    Dim totalLowerLimit As Double = 0
                    Dim totalLackAmount As Double = 0
                    Dim totalOutAmount As Double = 0
                    Dim totalInAmount As Double = 0
                    Dim totalCurrentOrigionSumPrice As Double = 0

                    XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_WARE_TOTAL_LIST.Count + rowCounter, 400, False)

                    cellFont = New Font("Arial", 10, FontStyle.Regular)

                    For Each bindingRow As MyPosXAuto.FTs.FT_MV_MP_POS_WARE_TOTALRow In Me._manifest.SVFT_BINDING_WARE_TOTAL_LIST

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
                        toExcel.SetCellText(rowCounter, 12, CommTK.FString(bindingRow.CURRENT_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 13, CommTK.FString(bindingRow.CURRENT_COST), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 14, CommTK.FString(bindingRow.CURRENT_ORIGION_SUM_PRICE), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 15, CommTK.FString(bindingRow.LOWER_LIMIT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 16, CommTK.FString(bindingRow.LACK_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 17, CommTK.FString(bindingRow.CONSIGN_OUT_LACK_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 18, CommTK.FString(bindingRow.CONSIGN_IN_LACK_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 19, bindingRow.UNIT_NAME, cellFont, Color.Black, Color.White)

                        rowCounter += 1
                        counter += 1

                        totalCurrentAmount = totalCurrentAmount + bindingRow.CURRENT_AMOUNT
                        totalCurrentCost = totalCurrentCost + bindingRow.CURRENT_COST
                        totalLowerLimit = totalLowerLimit + bindingRow.LOWER_LIMIT
                        totalLackAmount = totalLackAmount + bindingRow.LACK_AMOUNT
                        totalOutAmount = totalOutAmount + bindingRow.CONSIGN_OUT_LACK_AMOUNT
                        totalInAmount = totalInAmount + bindingRow.CONSIGN_IN_LACK_AMOUNT
                        totalCurrentOrigionSumPrice = totalCurrentOrigionSumPrice + bindingRow.CURRENT_ORIGION_SUM_PRICE

                        XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.WARE_NAME)

                    Next

                    XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                    toExcel.SetFrameLine(6, 1, rowCounter - 1, 19, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)
                    toExcel.SetFrameLine(5, 1, rowCounter - 1, 19, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)

                    toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 12, CommTK.FString(totalCurrentAmount), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 14, CommTK.FString(totalCurrentOrigionSumPrice), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 15, CommTK.FString(totalLowerLimit), cellFont, Color.Black, Color.White)

                    If sysHideFinancials = True Then

                        toExcel.SetCellText(rowCounter, 13, CommTK.FString(totalCurrentCost), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 16, CommTK.FString(totalLackAmount), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 17, CommTK.FString(totalOutAmount), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 18, CommTK.FString(totalInAmount), cellFont, Color.Black, Color.White)

                    End If

                    cellFont = New Font("Arial", 10, FontStyle.Bold)

                    If staffRowSE.IsNull = False Then
                        toExcel.SetCellText(rowCounter + 2, 18, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                    End If

                    If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                        toExcel.SetCellText(rowCounter + 3, 19, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                    Else
                        toExcel.SetCellText(rowCounter + 3, 19, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
                    End If

                ElseIf Me._manifest.XtraTabControl_Lists.SelectedTabPage Is Me._manifest.XtraTabPage_ShelfPosDifference Then

                    toExcel.MergeCell(1, 1, 1, 15)
                    toExcel.SetRowHeight(1, 35)

                    toExcel.SetColumnWidth(1, 10)
                    toExcel.SetColumnWidth(2, 10)
                    toExcel.SetColumnWidth(3, 10)
                    toExcel.SetColumnWidth(4, 20)
                    toExcel.SetColumnWidth(5, 10)
                    toExcel.SetColumnWidth(6, 10)
                    toExcel.SetColumnWidth(7, 10)
                    toExcel.SetColumnWidth(8, 10)
                    toExcel.SetColumnWidth(9, 10)
                    toExcel.SetColumnWidth(10, 10)
                    toExcel.SetColumnWidth(11, 10)
                    toExcel.SetColumnWidth(12, 10)
                    toExcel.SetColumnWidth(13, 12)
                    toExcel.SetColumnWidth(14, 10)
                    toExcel.SetColumnWidth(15, 12)

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


                    Dim cellFont As Font = New Font("Arial", 16, FontStyle.Bold)
                    toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("储位在库货品差异"), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 10, FontStyle.Bold)
                    toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("地点名称:"), cellFont, Color.Black, Color.White)
                    toExcel.MergeCell(3, 2, 3, 18)

                    toExcel.SetCellText(3, 2, Me._manifest.LookUpEdit_Pos.Text, cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)
                    toExcel.SetCellText(6, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 2, CommTK.GetTranslatedString("货品类别"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 3, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 4, CommTK.GetTranslatedString("自定货号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 5, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 6, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 7, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 8, sysAttribute1, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 9, sysAttribute2, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 10, sysAttribute3, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 11, sysAttribute4, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 12, CommTK.GetTranslatedString("储位货品数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 13, CommTK.GetTranslatedString("当前数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 14, CommTK.GetTranslatedString("偏差数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 15, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)

                    Dim rowCounter As Integer = 7
                    Dim counter As Integer = 1
                    Dim totalShelfAmount As Double = 0
                    Dim totalPosAmount As Double = 0
                    Dim totalDifferenceAmount As Double = 0

                    XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_SHELF_STOCK_DIFFERENCE_LIST.Count + rowCounter, 400, False)

                    cellFont = New Font("Arial", 10, FontStyle.Regular)

                    For Each bindingRow As MyPosXAuto.FTs.FT_MV_MP_POS_SHELF_STOCK_DIFFERENCERow In Me._manifest.SVFT_BINDING_SHELF_STOCK_DIFFERENCE_LIST

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
                        toExcel.SetCellText(rowCounter, 12, CommTK.FString(bindingRow.SHELF_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 13, CommTK.FString(bindingRow.POS_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 14, CommTK.FString(bindingRow.DIFFERENCE_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 15, bindingRow.UNIT_NAME, cellFont, Color.Black, Color.White)

                        rowCounter += 1
                        counter += 1

                        totalShelfAmount = totalShelfAmount + bindingRow.SHELF_AMOUNT
                        totalPosAmount = totalPosAmount + bindingRow.POS_AMOUNT
                        totalDifferenceAmount = totalDifferenceAmount + bindingRow.DIFFERENCE_AMOUNT

                        XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.WARE_NAME)

                    Next

                    XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                    toExcel.SetFrameLine(6, 1, rowCounter - 1, 15, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)
                    toExcel.SetFrameLine(5, 1, rowCounter - 1, 15, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)

                    toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 12, CommTK.FString(totalShelfAmount), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 13, CommTK.FString(totalPosAmount), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 14, CommTK.FString(totalDifferenceAmount), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 10, FontStyle.Bold)

                    If staffRowSE.IsNull = False Then
                        toExcel.SetCellText(rowCounter + 2, 15, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                    End If

                    If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                        toExcel.SetCellText(rowCounter + 3, 15, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                    Else
                        toExcel.SetCellText(rowCounter + 3, 15, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
                    End If

                ElseIf Me._manifest.XtraTabControl_Lists.SelectedTabPage Is Me._manifest.XtraTabPage_BatchList Then

                    toExcel.MergeCell(1, 1, 1, 9)
                    toExcel.SetRowHeight(1, 35)

                    toExcel.SetColumnWidth(1, 10)
                    toExcel.SetColumnWidth(2, 10)
                    toExcel.SetColumnWidth(3, 10)
                    toExcel.SetColumnWidth(4, 10)
                    toExcel.SetColumnWidth(5, 20)
                    toExcel.SetColumnWidth(6, 10)
                    toExcel.SetColumnWidth(7, 10)
                    toExcel.SetColumnWidth(8, 10)
                    toExcel.SetColumnWidth(9, 10)

                    If sysWareSpecModelDiscard = True Then
                        toExcel.SetColumnWidth(6, 0)
                        toExcel.SetColumnWidth(7, 0)
                    End If

                    Dim cellFont As Font = New Font("Arial", 16, FontStyle.Bold)
                    toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("在库货品表"), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 10, FontStyle.Bold)
                    toExcel.SetCellText(2, 1, CommTK.GetTranslatedString("地点:"), cellFont, Color.Black, Color.White)
                    toExcel.MergeCell(2, 2, 2, 4)
                    toExcel.SetCellText(2, 5, CommTK.GetTranslatedString("打印时间:"), cellFont, Color.Black, Color.White)
                    toExcel.MergeCell(2, 6, 2, 9)

                    toExcel.SetCellText(2, 2, Me._manifest.LookUpEdit_Pos.Text, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(2, 6, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)
                    toExcel.SetCellText(4, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 2, CommTK.GetTranslatedString("批号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 3, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 4, CommTK.GetTranslatedString("自定货号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 5, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 6, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 7, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 8, CommTK.GetTranslatedString("当前数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 9, CommTK.GetTranslatedString("当前成本"), cellFont, Color.Black, Color.White)

                    Dim rowCounter As Integer = 5
                    Dim counter As Integer = 1
                    Dim totalCurrentAmount As Double = 0
                    Dim totalCurrentCost As Double = 0

                    XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_WARE_TOTAL_LIST.Count + rowCounter, 400, False)

                    cellFont = New Font("Arial", 10, FontStyle.Regular)

                    For Each bindingRow As MyPosXAuto.FTs.FT_MV_MP_POS_BATCH_WARE_TOTALRow In Me._manifest.SVFT_BINDING_BATCH_WARE_TOTAL_LIST

                        toExcel.SetCellText(rowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 2, bindingRow.BATCH_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 3, bindingRow.WARE_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 4, bindingRow.CUSTOM_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 5, bindingRow.WARE_NAME, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 6, bindingRow.SPEC, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 7, bindingRow.MODEL, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 8, CommTK.FString(bindingRow.CURRENT_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 9, CommTK.FString(bindingRow.CURRENT_COST), cellFont, Color.Black, Color.White)

                        rowCounter += 1
                        counter += 1

                        totalCurrentAmount = totalCurrentAmount + bindingRow.CURRENT_AMOUNT
                        totalCurrentCost = totalCurrentCost + bindingRow.CURRENT_COST

                        XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.WARE_NAME)

                    Next

                    XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                    toExcel.SetFrameLine(4, 1, rowCounter - 1, 9, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)
                    toExcel.SetFrameLine(3, 1, rowCounter - 1, 9, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)

                    toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 8, CommTK.FString(totalCurrentAmount), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 9, CommTK.FString(totalCurrentCost), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 10, FontStyle.Bold)

                    If staffRowSE.IsNull = False Then
                        toExcel.SetCellText(rowCounter + 2, 9, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                    End If

                    If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                        toExcel.SetCellText(rowCounter + 3, 9, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                    Else
                        toExcel.SetCellText(rowCounter + 3, 9, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
                    End If

                ElseIf Me._manifest.XtraTabControl_Lists.SelectedTabPage Is Me._manifest.XtraTabPage_ShelfAmount Then

                    toExcel.MergeCell(1, 1, 1, 16)
                    toExcel.SetRowHeight(1, 35)

                    toExcel.SetColumnWidth(1, 10)
                    toExcel.SetColumnWidth(2, 10)
                    toExcel.SetColumnWidth(3, 10)
                    toExcel.SetColumnWidth(4, 20)
                    toExcel.SetColumnWidth(5, 10)
                    toExcel.SetColumnWidth(6, 10)
                    toExcel.SetColumnWidth(7, 10)
                    toExcel.SetColumnWidth(8, 10)
                    toExcel.SetColumnWidth(9, 10)
                    toExcel.SetColumnWidth(10, 10)
                    toExcel.SetColumnWidth(11, 10)
                    toExcel.SetColumnWidth(12, 10)
                    toExcel.SetColumnWidth(13, 12)
                    toExcel.SetColumnWidth(14, 10)
                    toExcel.SetColumnWidth(15, 10)
                    toExcel.SetColumnWidth(16, 10)

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

                    Dim cellFont As Font = New Font("Arial", 16, FontStyle.Bold)
                    toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("储位在库量"), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 10, FontStyle.Bold)

                    toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("地点名称:"), cellFont, Color.Black, Color.White)
                    toExcel.MergeCell(3, 2, 3, 16)
                    toExcel.SetCellText(3, 2, Me._manifest.LookUpEdit_Pos.Text, cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)
                    toExcel.SetCellText(6, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 2, CommTK.GetTranslatedString("货品类别"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 3, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 4, CommTK.GetTranslatedString("自定货号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 5, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 6, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 7, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 8, sysAttribute1, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 9, sysAttribute2, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 10, sysAttribute3, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 11, sysAttribute4, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 12, CommTK.GetTranslatedString("货区编码"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 13, CommTK.GetTranslatedString("货架编码"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 14, CommTK.GetTranslatedString("货架位置编码"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 15, CommTK.GetTranslatedString("储位货品数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(6, 16, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)

                    Dim rowCounter As Integer = 7
                    Dim counter As Integer = 1
                    Dim totalStockAmount As Double = 0

                    XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_WARE_TOTAL_LIST.Count + rowCounter, 400, False)

                    cellFont = New Font("Arial", 10, FontStyle.Regular)

                    For Each bindingRow As MyPosXAuto.FTs.FT_MV_MP_POS_LOCATION_STOCK_AMOUNTRow In Me._manifest.SVFT_BINDING_POS_LOCATION_STOCK_AMOUNT

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
                        toExcel.SetCellText(rowCounter, 12, bindingRow.AREA_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 13, bindingRow.SHELF_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 14, bindingRow.LOCATION_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 15, CommTK.FString(bindingRow.LOCATION_STOCK_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 16, bindingRow.UNIT_NAME, cellFont, Color.Black, Color.White)

                        rowCounter += 1
                        counter += 1

                        totalStockAmount = totalStockAmount + bindingRow.LOCATION_STOCK_AMOUNT

                        XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.WARE_NAME)

                    Next

                    XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                    toExcel.SetFrameLine(6, 1, rowCounter - 1, 16, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)
                    toExcel.SetFrameLine(5, 1, rowCounter - 1, 16, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)

                    toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 15, CommTK.FString(totalStockAmount), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 10, FontStyle.Bold)

                    If staffRowSE.IsNull = False Then
                        toExcel.SetCellText(rowCounter + 2, 16, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                    End If

                    If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                        toExcel.SetCellText(rowCounter + 3, 16, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                    Else
                        toExcel.SetCellText(rowCounter + 3, 16, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
                    End If

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
        Private Function DoPrintReport() As String


            Try

                'Dim report As New Reports.R_03_00101

                'report.XrLabel_PosName.Text = Me._manifest.LookUpEdit_Pos.Text
                'report.XrLabel_PrintTime.Text = String.Format("{0:yyyy-MM-dd}", CommTK.GetsyncServerTime)

                'report.DataSource = Me._manifest.SVFT_BINDING_WARE_TOTAL_LIST.ReportBindList

                'report.CreateDataBindings()

                'report.ShowPreview()


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
        Private Function DoLoadShelfStockDifferenceList() As String


            Try


                Dim shelfStockDifferenceConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_POS_SHELF_STOCK_DIFFERENCE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                shelfStockDifferenceConditions.Add( _
                    AfMV.MV_MP_POS_SHELF_STOCK_DIFFERENCEColumns.POS_IDColumn, _
                    "=", _
                    CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue))
                shelfStockDifferenceConditions.Add( _
                    AfMV.MV_MP_POS_SHELF_STOCK_DIFFERENCEColumns.WARE_IDColumn, _
                    True, _
                    Me._manifest.SV_DISPLAYING_WARE_IDS)

                Me._manifest.SVFT_BINDING_SHELF_STOCK_DIFFERENCE_LIST.Clear()
                MyPosXAuto.Facade.AfMV.FillFT_MV_MP_POS_SHELF_STOCK_DIFFERENCE(shelfStockDifferenceConditions, Me._manifest.SVFT_BINDING_SHELF_STOCK_DIFFERENCE_LIST)
                Me._manifest.GridControl_ShelfStockDifference.DataSource = Me._manifest.SVFT_BINDING_SHELF_STOCK_DIFFERENCE_LIST


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
        Private Function DoLoadLocationStockList() As String


            Try


                'Shelf list
                Dim shelfConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_POS_LOCATION_STOCK_AMOUNT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                shelfConditions.Add( _
                    AfMV.MV_MP_POS_LOCATION_STOCK_AMOUNTColumns.POS_IDColumn, _
                    "=", _
                    CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue))

                If Me._manifest.CheckEdit_SingleWareLocations.Checked = True AndAlso _
                    IsNothing(Me._manifest.SVFR_SELECTING_SHELF_STOCK_DIFFERENCE_ROW) = False Then
                    shelfConditions.Add(AfMV.MV_MP_POS_LOCATION_STOCK_AMOUNTColumns.WARE_IDColumn, "=", Me._manifest.SVFR_SELECTING_SHELF_STOCK_DIFFERENCE_ROW.WARE_ID)
                End If

                Me._manifest.SVFT_BINDING_POS_LOCATION_STOCK_AMOUNT.Clear()
                MyPosXAuto.Facade.AfMV.FillFT_MV_MP_POS_LOCATION_STOCK_AMOUNT(shelfConditions, Me._manifest.SVFT_BINDING_POS_LOCATION_STOCK_AMOUNT)

                Me._manifest.GridControl_ShelfAmount.DataSource = Me._manifest.SVFT_BINDING_POS_LOCATION_STOCK_AMOUNT



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
        Private Function DoAddAllWares() As String


            Try

                Dim wareList As New MyPosXAuto.FTs.FT_M_MP_WARE
                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_WARE(Nothing, wareList)

                Me._manifest.SV_DISPLAYING_WARE_IDS.Clear()
                For Each wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow In wareList
                    Me._manifest.SV_DISPLAYING_WARE_IDS.Add(wareRow.WARE_ID)
                Next


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
        Private Function DoAddWareByCode() As String


            Try

                Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                wareCondition.Add(AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", Me._manifest.ButtonEdit_WareCode.Text)

                Dim wareRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareCondition)
                If IsNothing(wareRow) = False Then
                    Me._manifest.ButtonEdit_WareCode.Text = wareRow.WARE_CODE
                    Me._manifest.Label_CustomCode.Text = wareRow.CUSTOM_CODE
                    Me._manifest.Label_WareID.Text = wareRow.WARE_ID
                    If Me._manifest.SV_DISPLAYING_WARE_IDS.Contains(wareRow.WARE_ID) = False Then
                        Me._manifest.SV_DISPLAYING_WARE_IDS.Add(wareRow.WARE_ID)
                    End If
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
