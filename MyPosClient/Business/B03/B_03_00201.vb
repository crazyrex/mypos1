Imports XL.Common
Imports XL.Common.Utils
Imports MyPosClient.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade
Imports Microsoft.Office.Interop

Namespace Business


    Public Class B_03_00201
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
        Private _manifest As Manifest.M_03_00201
        Private _service As MyPosXService.S_03_00201

        Public Enum Affairs
            InitDisplay
            ExportExcel
            LoadWareIOTotalList
            PrintReport
            LoadPosWareList
            BizUtld0005
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

            Me._manifest = CType(theManifest, Manifest.M_03_00201)

            Try

                Me._service = MyPosXService.S_03_00201.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_03_00201.GetInstance()
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

                Case Affairs.ExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoExportExcel)

                Case Affairs.LoadWareIOTotalList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadWareIOTotalList)

                Case Affairs.PrintReport

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoPrintReport)

                Case Affairs.LoadPosWareList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadPosWareList)

                Case Affairs.BizUtld0005

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0005)

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

                Me._manifest.DateEdit_ToDate.DateTime = CommTK.GetSyncServerTime

                Me._manifest.SVFT_CHOOSE_POS_LIST.Clear()
                Me._manifest.SVFT_CHOOSE_TURNOVER_TYPE_LIST.Clear()
                Me._manifest.SVFT_CHOOSE_TURNOVER_STYLE_LIST.Clear()

                Dim sysSpecModelDiscard As Boolean
                Dim sysHideFinancial As Boolean

                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Me._service.ServInitDisplay( _
                    sysHideFinancial, _
                    sysSpecModelDiscard, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, Me._manifest.SVFT_CHOOSE_POS_LIST)
                MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_TYPEList(CommDecl.CURRENT_LANGUAGE_OPTION, String.Empty, Me._manifest.SVFT_CHOOSE_TURNOVER_TYPE_LIST, False)
                MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList(CommDecl.CURRENT_LANGUAGE_OPTION, String.Empty, Me._manifest.SVFT_CHOOSE_TURNOVER_STYLE_LIST, True)

                Me._manifest.LookUpEdit_Pos.Properties.DataSource = Me._manifest.SVFT_CHOOSE_POS_LIST
                Me._manifest.LookUpEdit_Pos.EditValue = SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_CURRENT_POS_ID)

                Me._manifest.RepositoryItemLookUpEdit_TurnoverType.DataSource = Me._manifest.SVFT_CHOOSE_TURNOVER_TYPE_LIST
                Me._manifest.RepositoryItemLookUpEdit_TurnoverStyle.DataSource = Me._manifest.SVFT_CHOOSE_TURNOVER_STYLE_LIST

                If sysHideFinancial = True Then
                    Me._manifest.GridColumn_BeginCost.Visible = False
                    Me._manifest.GridColumn_EndCost.Visible = False
                    Me._manifest.GridColumn_InCost.Visible = False
                    Me._manifest.GridColumn_OutCost.Visible = False

                    Me._manifest.GridColumn_TotalSumCost.Visible = False
                    Me._manifest.GridColumn_TotalSumPrice.Visible = False
                End If

                Me._manifest.GridColumn_Attribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_Attribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_Attribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_Attribute4.Caption = sysAttribute4
                Me._manifest.GridColumn_PAttribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_PAttribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_PAttribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_PAttribute4.Caption = sysAttribute4

                If sysAttribute1.Length = 0 Then
                    Me._manifest.GridColumn_Attribute1.Visible = False
                    Me._manifest.GridColumn_PAttribute1.Visible = False
                End If

                If sysAttribute2.Length = 0 Then
                    Me._manifest.GridColumn_Attribute2.Visible = False
                    Me._manifest.GridColumn_PAttribute2.Visible = False
                End If

                If sysAttribute3.Length = 0 Then
                    Me._manifest.GridColumn_Attribute3.Visible = False
                    Me._manifest.GridColumn_PAttribute3.Visible = False
                End If

                If sysAttribute4.Length = 0 Then
                    Me._manifest.GridColumn_Attribute4.Visible = False
                    Me._manifest.GridColumn_PAttribute4.Visible = False
                End If

                If sysSpecModelDiscard = True Then
                    Me._manifest.GridColumn_Spec.Visible = False
                    Me._manifest.GridColumn_Model.Visible = False

                    Me._manifest.GridColumn_PModel.Visible = False
                    Me._manifest.GridColumn_PSpec.Visible = False
                End If

                Dim userCostHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_COST_HIDDEN"))

                If userCostHidden = True Then
                    Me._manifest.GridColumn_BeginCost.Visible = False
                    Me._manifest.GridColumn_EndCost.Visible = False
                    Me._manifest.GridColumn_InCost.Visible = False
                    Me._manifest.GridColumn_OutCost.Visible = False
                    Me._manifest.GridColumn_TotalSumCost.Visible = False
                Else
                    Me._manifest.GridColumn_BeginCost.Visible = True
                    Me._manifest.GridColumn_EndCost.Visible = True
                    Me._manifest.GridColumn_InCost.Visible = True
                    Me._manifest.GridColumn_OutCost.Visible = True
                    Me._manifest.GridColumn_TotalSumCost.Visible = True
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
                Dim sysHideFinancials As Boolean
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity

                Me._service.ServExportExcel( _
                    sysWareSpecModelDiscard, _
                    sysHideFinancials, _
                    Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID, _
                    staffRowSE, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                If IO.File.Exists(Me._manifest.SV_EXCEL_FILENAME) = True Then
                    IO.File.Delete(Me._manifest.SV_EXCEL_FILENAME)
                End If

                Dim toExcel As New Utils.ExcelTK(Me._manifest.SV_EXCEL_FILENAME)

                Dim cellFont As Font

                If Me._manifest.XtraTabControl1.SelectedTabPage Is Me._manifest.XtraTabPage_WithdrawDtl Then

                    toExcel.MergeCell(1, 1, 1, 23)
                    toExcel.SetRowHeight(1, 35.25)

                    toExcel.SetColumnWidth(1, 10)
                    toExcel.SetColumnWidth(2, 15)
                    toExcel.SetColumnWidth(3, 15)
                    toExcel.SetColumnWidth(4, 10)
                    toExcel.SetColumnWidth(5, 10)
                    toExcel.SetColumnWidth(6, 10)
                    toExcel.SetColumnWidth(7, 10)
                    toExcel.SetColumnWidth(8, 10)
                    toExcel.SetColumnWidth(9, 10)
                    toExcel.SetColumnWidth(10, 10)
                    toExcel.SetColumnWidth(11, 10)
                    toExcel.SetColumnWidth(12, 10)
                    toExcel.SetColumnWidth(13, 10)
                    toExcel.SetColumnWidth(14, 10)
                    toExcel.SetColumnWidth(15, 10)
                    toExcel.SetColumnWidth(16, 10)
                    toExcel.SetColumnWidth(17, 10)
                    toExcel.SetColumnWidth(18, 10)
                    toExcel.SetColumnWidth(19, 10)
                    toExcel.SetColumnWidth(20, 10)
                    toExcel.SetColumnWidth(21, 10)
                    toExcel.SetColumnWidth(22, 10)
                    toExcel.SetColumnWidth(23, 10)

                    If sysAttribute1.Length <= 0 Then
                        toExcel.SetColumnWidth(7, 0)
                    End If

                    If sysAttribute2.Length <= 0 Then
                        toExcel.SetColumnWidth(8, 0)
                    End If

                    If sysAttribute3.Length <= 0 Then
                        toExcel.SetColumnWidth(9, 0)
                    End If

                    If sysAttribute4.Length <= 0 Then
                        toExcel.SetColumnWidth(10, 0)
                    End If

                    If sysWareSpecModelDiscard = True Then
                        toExcel.SetColumnWidth(5, 0)
                        toExcel.SetColumnWidth(6, 0)
                    End If

                    If sysHideFinancials = True Then
                        toExcel.SetColumnWidth(15, 0)
                        toExcel.SetColumnWidth(16, 0)
                        toExcel.SetColumnWidth(17, 0)
                        toExcel.SetColumnWidth(18, 0)
                    End If

                    cellFont = New Font("Arial", 16, FontStyle.Bold)
                    toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("货品出入查询"), cellFont, Color.Black, Color.White)

                    toExcel.MergeCell(3, 1, 3, 23)
                    cellFont = New Font("Arial", 10, FontStyle.Bold)
                    toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("日期从:") + String.Format("   {0:yyyy-MM-dd}   ", Me._manifest.DateEdit_FromDate.DateTime) + CommTK.GetTranslatedString("至:") + String.Format("   {0:yyyy-MM-dd}", Me._manifest.DateEdit_ToDate.DateTime), cellFont, Color.Black, Color.White)

                    toExcel.SetCellText(4, 1, CommTK.GetTranslatedString("地点名称:"), cellFont, Color.Black, Color.White)
                    toExcel.MergeCell(4, 2, 4, 23)
                    toExcel.SetCellText(4, 2, Me._manifest.LookUpEdit_Pos.Text, cellFont, Color.Black, Color.White)

                    toExcel.SetCellText(7, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 2, CommTK.GetTranslatedString("货品类别"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 3, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 4, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 5, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 6, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 7, sysAttribute1, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 8, sysAttribute2, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 9, sysAttribute3, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 10, sysAttribute4, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 11, CommTK.GetTranslatedString("期初数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 12, CommTK.GetTranslatedString("入货数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 13, CommTK.GetTranslatedString("出货数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 14, CommTK.GetTranslatedString("期末数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 15, CommTK.GetTranslatedString("期初原价"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 16, CommTK.GetTranslatedString("期初成本"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 17, CommTK.GetTranslatedString("出货原价"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 18, CommTK.GetTranslatedString("出货成本"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 19, CommTK.GetTranslatedString("入货原价"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 20, CommTK.GetTranslatedString("入货成本"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 21, CommTK.GetTranslatedString("期末原价"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 22, CommTK.GetTranslatedString("期末成本"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 23, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)

                    Dim rowCounter As Integer = 8
                    Dim counter As Integer = 1
                    Dim totalBeginAmount As Double = 0
                    Dim totalInAmount As Double = 0
                    Dim totalOutAmount As Double = 0
                    Dim totalEndAmount As Double = 0
                    Dim totalBeginOrigionSumPrice As Double = 0
                    Dim totalBeginCost As Double = 0
                    Dim totalOutOrigionSumPrice As Double = 0
                    Dim totalOutCost As Double = 0
                    Dim totalInOrigionSumPrice As Double = 0
                    Dim totalInCost As Double = 0
                    Dim totalEndOrigionSumPrice As Double = 0
                    Dim totalEndCost As Double = 0

                    cellFont = New Font("Arial", 10, FontStyle.Regular)

                    XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_WARE_IO_TOTAL_LIST.Count + rowCounter, 400, False)

                    For Each wareIOTOTalRow As MyPosXAuto.FTs.FT_MP_MP_SELECT_POS_PERIOD_WARE_IO_TOTALRow In Me._manifest.SVFT_BINDING_WARE_IO_TOTAL_LIST

                        toExcel.SetCellText(rowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 2, wareIOTOTalRow.WARE_CLASSIFY_NAME, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 3, wareIOTOTalRow.WARE_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 4, wareIOTOTalRow.WARE_NAME, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 5, wareIOTOTalRow.MODEL, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 6, wareIOTOTalRow.SPEC, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 7, wareIOTOTalRow.ATTRIBUTE1, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 8, wareIOTOTalRow.ATTRIBUTE2, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 9, wareIOTOTalRow.ATTRIBUTE3, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 10, wareIOTOTalRow.ATTRIBUTE4, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 11, CommTK.FString(wareIOTOTalRow.BEGIN_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 12, CommTK.FString(wareIOTOTalRow.IN_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 13, CommTK.FString(wareIOTOTalRow.OUT_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 14, CommTK.FString(wareIOTOTalRow.END_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 15, CommTK.FString(wareIOTOTalRow.BEGIN_ORIGION_SUM_PRICE), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 16, CommTK.FString(wareIOTOTalRow.BEGIN_COST), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 17, CommTK.FString(wareIOTOTalRow.OUT_ORIGION_SUM_PRICE), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 18, CommTK.FString(wareIOTOTalRow.OUT_COST), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 19, CommTK.FString(wareIOTOTalRow.IN_ORIGION_SUM_PRICE), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 20, CommTK.FString(wareIOTOTalRow.IN_COST), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 21, CommTK.FString(wareIOTOTalRow.END_ORIGION_SUM_PRICE), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 22, CommTK.FString(wareIOTOTalRow.END_COST), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 23, wareIOTOTalRow.UNIT_NAME, cellFont, Color.Black, Color.White)

                        rowCounter += 1
                        counter += 1

                        totalBeginAmount = totalBeginAmount + wareIOTOTalRow.BEGIN_AMOUNT
                        totalInAmount = totalInAmount + wareIOTOTalRow.IN_AMOUNT
                        totalOutAmount = totalOutAmount + wareIOTOTalRow.OUT_AMOUNT
                        totalEndAmount = totalEndAmount + wareIOTOTalRow.END_AMOUNT
                        totalBeginOrigionSumPrice = totalBeginOrigionSumPrice + wareIOTOTalRow.BEGIN_ORIGION_SUM_PRICE
                        totalBeginCost = totalBeginCost + wareIOTOTalRow.BEGIN_COST
                        totalOutOrigionSumPrice = totalOutOrigionSumPrice + wareIOTOTalRow.OUT_ORIGION_SUM_PRICE
                        totalOutCost = totalOutCost + wareIOTOTalRow.OUT_COST
                        totalInOrigionSumPrice = totalInOrigionSumPrice + wareIOTOTalRow.IN_ORIGION_SUM_PRICE
                        totalInCost = totalInCost + wareIOTOTalRow.IN_COST
                        totalEndOrigionSumPrice = totalEndOrigionSumPrice + wareIOTOTalRow.END_ORIGION_SUM_PRICE
                        totalEndCost = totalEndCost + wareIOTOTalRow.END_COST

                        XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, wareIOTOTalRow.WARE_NAME)

                    Next

                    XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                    toExcel.SetFrameLine(7, 1, rowCounter - 1, 23, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)
                    toExcel.SetFrameLine(6, 1, rowCounter - 1, 23, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)

                    toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 11, CommTK.FString(totalBeginAmount), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 12, CommTK.FString(totalInAmount), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 13, CommTK.FString(totalOutAmount), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 14, CommTK.FString(totalEndAmount), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 15, CommTK.FString(totalBeginOrigionSumPrice), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 16, CommTK.FString(totalBeginCost), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 17, CommTK.FString(totalOutOrigionSumPrice), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 18, CommTK.FString(totalOutCost), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 19, CommTK.FString(totalInOrigionSumPrice), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 20, CommTK.FString(totalInCost), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 21, CommTK.FString(totalEndOrigionSumPrice), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 22, CommTK.FString(totalEndCost), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 10, FontStyle.Bold)

                    If staffRowSE.IsNull = False Then
                        toExcel.SetCellText(rowCounter + 2, 23, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                    End If

                    If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                        toExcel.SetCellText(rowCounter + 3, 23, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                    Else
                        toExcel.SetCellText(rowCounter + 3, 23, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
                    End If

                ElseIf Me._manifest.XtraTabControl1.SelectedTabPage Is Me._manifest.XtraTabPage_PosWare Then

                    toExcel.SetColumnWidth(1, 10)
                    toExcel.SetColumnWidth(2, 15)
                    toExcel.SetColumnWidth(3, 15)
                    toExcel.SetColumnWidth(4, 10)
                    toExcel.SetColumnWidth(5, 10)
                    toExcel.SetColumnWidth(6, 10)
                    toExcel.SetColumnWidth(7, 10)
                    toExcel.SetColumnWidth(8, 10)
                    toExcel.SetColumnWidth(9, 10)
                    toExcel.SetColumnWidth(10, 10)
                    toExcel.SetColumnWidth(11, 10)
                    toExcel.SetColumnWidth(12, 10)
                    toExcel.SetColumnWidth(13, 10)
                    toExcel.SetColumnWidth(14, 10)
                    toExcel.SetColumnWidth(15, 10)
                    toExcel.SetColumnWidth(16, 10)
                    toExcel.SetColumnWidth(17, 10)

                    If sysAttribute1.Length <= 0 Then
                        toExcel.SetColumnWidth(10, 0)
                    End If

                    If sysAttribute2.Length <= 0 Then
                        toExcel.SetColumnWidth(11, 0)
                    End If

                    If sysAttribute3.Length <= 0 Then
                        toExcel.SetColumnWidth(12, 0)
                    End If

                    If sysAttribute4.Length <= 0 Then
                        toExcel.SetColumnWidth(13, 0)
                    End If

                    If sysWareSpecModelDiscard = True Then
                        toExcel.SetColumnWidth(8, 0)
                        toExcel.SetColumnWidth(9, 0)
                    End If

                    If sysHideFinancials = True Then
                        toExcel.SetColumnWidth(15, 0)
                        toExcel.SetColumnWidth(16, 0)
                    End If

                    toExcel.MergeCell(1, 1, 1, 17)
                    toExcel.SetRowHeight(1, 35.25)

                    cellFont = New Font("Arial", 16, FontStyle.Bold)
                    toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("货品出入形式查询"), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 10, FontStyle.Bold)
                    toExcel.MergeCell(3, 1, 3, 17)
                    toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("日期从:") + String.Format("   {0:yyyy-MM-dd}   ", Me._manifest.DateEdit_FromDate.DateTime) + CommTK.GetTranslatedString("至:") + String.Format("   {0:yyyy-MM-dd}", Me._manifest.DateEdit_ToDate.DateTime), cellFont, Color.Black, Color.White)

                    toExcel.SetCellText(4, 1, CommTK.GetTranslatedString("地点名称:"), cellFont, Color.Black, Color.White)
                    toExcel.MergeCell(4, 2, 4, 17)
                    toExcel.SetCellText(4, 2, Me._manifest.LookUpEdit_Pos.Text, cellFont, Color.Black, Color.White)

                    toExcel.SetCellText(7, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 2, CommTK.GetTranslatedString("出入类型"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 3, CommTK.GetTranslatedString("出入库形式"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 4, CommTK.GetTranslatedString("货品类别"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 5, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 6, CommTK.GetTranslatedString("自定货号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 7, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 8, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 9, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 10, sysAttribute1, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 11, sysAttribute2, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 12, sysAttribute3, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 13, sysAttribute4, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 14, CommTK.GetTranslatedString("数量"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 15, CommTK.GetTranslatedString("成本"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 16, CommTK.GetTranslatedString("售价"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(7, 17, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)

                    Dim rowCounter As Integer = 8
                    Dim counter As Integer = 1
                    Dim totalAmount As Double = 0
                    Dim totalCost As Double = 0
                    Dim totalSumPrice As Double = 0

                    Dim wareID As String = Guid.NewGuid.ToString

                    cellFont = New Font("Arial", 10, FontStyle.Regular)

                    XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_POS_WARE_LIST.Count + rowCounter, 400, False)

                    For Each bindingRow As MyPosXAuto.FTs.FT_MP_MP_SELECT_POS_PERIOD_WARE_TURNOVER_STYLE_TOTALRow In Me._manifest.SVFT_BINDING_POS_WARE_LIST

                        'If wareID <> 0 AndAlso _
                        '    wareID <> bindingRow.WARE_ID Then
                        '    rowCounter += 1
                        'End If

                        toExcel.SetCellText(rowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 2, MyPosXAuto.Facade.AfCIV.GetCI_TURNOVER_TYPEText(CommDecl.CURRENT_LANGUAGE_OPTION, bindingRow.TURNOVER_TYPE, String.Empty), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 3, MyPosXAuto.Facade.AfCIV.GetCI_TURNOVER_STYLEText(CommDecl.CURRENT_LANGUAGE_OPTION, bindingRow.TURNOVER_STYLE, String.Empty), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 4, bindingRow.WARE_CLASSIFY_NAME, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 5, bindingRow.WARE_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 6, bindingRow.CUSTOM_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 7, bindingRow.WARE_NAME, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 8, bindingRow.SPEC, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 9, bindingRow.MODEL, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 10, bindingRow.ATTRIBUTE1, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 11, bindingRow.ATTRIBUTE2, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 12, bindingRow.ATTRIBUTE3, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 13, bindingRow.ATTRIBUTE4, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 14, CommTK.FString(bindingRow.TOTAL_AMOUNT), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 15, CommTK.FString(bindingRow.TOTAL_SUM_COST), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 16, CommTK.FString(bindingRow.TOTAL_SUM_PRICE), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 17, bindingRow.UNIT_NAME, cellFont, Color.Black, Color.White)

                        rowCounter += 1
                        counter += 1

                        totalAmount = totalAmount + bindingRow.TOTAL_AMOUNT
                        totalCost = totalCost + bindingRow.TOTAL_SUM_COST
                        totalSumPrice = totalSumPrice + bindingRow.TOTAL_SUM_PRICE

                        wareID = bindingRow.WARE_ID

                        XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.WARE_NAME)

                    Next

                    XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                    toExcel.SetFrameLine(7, 1, rowCounter - 1, 17, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)
                    toExcel.SetFrameLine(6, 1, rowCounter - 1, 17, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)

                    toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 14, CommTK.FString(totalAmount), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 15, CommTK.FString(totalCost), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 16, CommTK.FString(totalSumPrice), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 10, FontStyle.Bold)

                    If staffRowSE.IsNull = False Then
                        toExcel.SetCellText(rowCounter + 2, 17, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                    End If

                    If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                        toExcel.SetCellText(rowCounter + 3, 17, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                    Else
                        toExcel.SetCellText(rowCounter + 3, 17, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
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
        Private Function DoLoadWareIOTotalList() As String


            Try

                Me._manifest.SVFT_BINDING_WARE_IO_TOTAL_LIST.Clear()

                Me._service.ServLoadWareIOTotalList( _
                    CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue), _
                    CommTK.GetBeginOfDate(Me._manifest.DateEdit_FromDate.DateTime), _
                    CommTK.GetEndOfDate(Me._manifest.DateEdit_ToDate.DateTime), _
                    Me._manifest.SVFT_BINDING_WARE_IO_TOTAL_LIST)

                Me._manifest.GridControl_WithdrawDtl.DataSource = Me._manifest.SVFT_BINDING_WARE_IO_TOTAL_LIST

                Return String.Empty

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

                'Dim report As New Reports.R_03_00201

                'report.XrLabel_FromDate.Text = Me._manifest.DateEdit_FromDate.Text
                'report.XrLabel_ToDate.Text = Me._manifest.DateEdit_ToDate.Text

                'report.DataSource = Me._manifest.SVFT_BINDING_WARE_IO_TOTAL_LIST.ReportBindList

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
        Private Function DoLoadPosWareList() As String


            Try

                Me._manifest.SVFT_BINDING_POS_WARE_LIST.Clear()

                Me._service.ServLoadPosWareList( _
                    CommTK.GetBeginOfDate(Me._manifest.DateEdit_FromDate.DateTime), _
                    CommTK.GetEndOfDate(Me._manifest.DateEdit_ToDate.DateTime), _
                    CommTK.FString(Me._manifest.LookUpEdit_Pos.EditValue), _
                    Me._manifest.SVFT_BINDING_POS_WARE_LIST _
                    )

                Me._manifest.GridControl_PosWare.DataSource = Me._manifest.SVFT_BINDING_POS_WARE_LIST


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
        Private Function DoBizUtld0005() As String


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
