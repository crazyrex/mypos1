Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade
Imports Microsoft.Office.Interop
Imports MyPosClient.Utils

Namespace Business


    Public Class B_01_00801
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
        Private _manifest As Manifest.M_01_00801
        Private _service As MyPosXService.S_01_00801

        Public Enum Affairs
            InitDisplay
            LoadList
            DeleteInfo
            ImportFromExcel
            ExportExcel
            SendManagerSMS
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

            Me._manifest = CType(theManifest, Manifest.M_01_00801)

            Try

                Me._service = MyPosXService.S_01_00801.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_01_00801.GetInstance()
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

                Case Affairs.DeleteInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoDeleteInfo)

                Case Affairs.ImportFromExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoImportFromExcel)

                Case Affairs.ExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoExportExcel)

                Case Affairs.SendManagerSMS

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSendManagerSMS)

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

                Dim sysClientAttr1 As String = String.Empty
                Dim sysClientAttr2 As String = String.Empty
                Dim sysClientAttr3 As String = String.Empty
                Dim sysClientAttr4 As String = String.Empty
                Dim sysClientAttr5 As String = String.Empty
                Dim sysClientAttr6 As String = String.Empty

                Me._service.ServInitDisplay( _
                    sysClientAttr1, _
                    sysClientAttr2, _
                    sysClientAttr3, _
                    sysClientAttr4, _
                    sysClientAttr5, _
                    sysClientAttr6)

                Me._manifest.GridColumn_ClientAttr1.Caption = sysClientAttr1
                Me._manifest.GridColumn_ClientAttr2.Caption = sysClientAttr2
                Me._manifest.GridColumn_ClientAttr3.Caption = sysClientAttr3
                Me._manifest.GridColumn_ClientAttr4.Caption = sysClientAttr4
                Me._manifest.GridColumn_ClientAttr5.Caption = sysClientAttr5
                Me._manifest.GridColumn_ClientAttr6.Caption = sysClientAttr6

                If sysClientAttr1.Length = 0 Then
                    Me._manifest.GridColumn_ClientAttr1.Visible = False
                End If

                If sysClientAttr2.Length = 0 Then
                    Me._manifest.GridColumn_ClientAttr2.Visible = False
                End If

                If sysClientAttr3.Length = 0 Then
                    Me._manifest.GridColumn_ClientAttr3.Visible = False
                End If

                If sysClientAttr4.Length = 0 Then
                    Me._manifest.GridColumn_ClientAttr4.Visible = False
                End If

                If sysClientAttr5.Length = 0 Then
                    Me._manifest.GridColumn_ClientAttr5.Visible = False
                End If

                If sysClientAttr6.Length = 0 Then
                    Me._manifest.GridColumn_ClientAttr6.Visible = False
                End If


                Dim chooseClientType As New MyPosXAuto.FTs.FT_CIV_CLIENT_TYPE
                Dim LanguagOption As Integer

                MyPosXAuto.Facade.AfCIV.FillCI_CLIENT_TYPEList(LanguagOption, String.Empty, chooseClientType, False)
                If CommDecl.SYSTEM_IS_ONLINE = False Then
                    Me._manifest.CheckEdit_DownloadDataByRefresh.Visible = True
                End If
                Me._manifest.RepositoryItemLookUpEdit_ClientType.DataSource = chooseClientType

                Dim chooseClientLevel As New MyPosXAuto.FTs.FT_CIV_CLIENT_LEVEL

                MyPosXAuto.Facade.AfCIV.FillCI_CLIENT_LEVELList(LanguagOption, String.Empty, chooseClientLevel, False)
            
                Me._manifest.RepositoryItemLookUpEdit_ClientLevel.DataSource = chooseClientLevel



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

                MyPosXAuto.DataCache.DCHMV.OverwriteMV_MP_CLIENTFromDB()
                MyPosXAuto.DataCache.DCHBizMaster.OverwriteM_MP_CLIENTFromDB(, False)

                Me._manifest.SVFT_BINDING_CLIENT_LIST.Clear()
                MyPosXAuto.Facade.AfMV.FillFT_MV_MP_CLIENT( _
                    Nothing, _
                    Me._manifest.SVFT_BINDING_CLIENT_LIST, _
                    MyPosXAuto.Facade.AfMV.MV_MP_CLIENTColumns.CLIENT_CODEColumn)
                Me._manifest.GridControl_Customer.DataSource = Me._manifest.SVFT_BINDING_CLIENT_LIST

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
        Private Function DoDeleteInfo() As String


            Try

                MyPosXAuto.Facade.AfBizMaster.DeleteM_MP_CLIENTInfo(Me._manifest.SVFR_SELECTING_CLIENT_ROW.CLIENT_ID)


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
        Private Function DoImportFromExcel() As String


            Try

                Dim excelApp As New Excel.Application
                Dim excelBook As Excel.Workbook = excelApp.Workbooks.Open(Me._manifest.OpenFileDialog_ImportFile.FileName)
                Dim excelSheet As Excel.Worksheet = CType(excelBook.Worksheets.Item("Sheet1"), Excel.Worksheet)
                Dim rowCounter As Integer = 2

                Dim clientCode As String
                Dim clientName As String
                Dim address As String
                Dim cellPhone As String
                Dim city As String
                Dim country As String
                Dim department As String
                Dim linkMan As String
                Dim email As String
                Dim fax As String
                Dim homePhone As String
                Dim postCode As String
                Dim remarks As String
                Dim state As String
                Dim title As String
                Dim workPhone As String
                Dim webSite As String

                Dim clientConditions As New  _
                    MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_CLIENT(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                Dim clientRow As MyPosXAuto.FTs.FT_M_MP_CLIENTRow

                XL.Win.Window.XLProgressBox.SetProgressRange(rowCounter, 500, False)

                Do
                    clientCode = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 1), excelSheet.Cells(rowCounter, 1)).Value)
                    clientName = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 2), excelSheet.Cells(rowCounter, 2)).Value)
                    address = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 3), excelSheet.Cells(rowCounter, 3)).Value)
                    city = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 4), excelSheet.Cells(rowCounter, 4)).Value)
                    country = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 5), excelSheet.Cells(rowCounter, 5)).Value)
                    department = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 6), excelSheet.Cells(rowCounter, 6)).Value)
                    linkMan = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 7), excelSheet.Cells(rowCounter, 7)).Value)
                    webSite = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 8), excelSheet.Cells(rowCounter, 8)).Value)
                    postCode = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 9), excelSheet.Cells(rowCounter, 9)).Value)
                    homePhone = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 10), excelSheet.Cells(rowCounter, 10)).Value)
                    workPhone = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 11), excelSheet.Cells(rowCounter, 11)).Value)
                    cellPhone = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 12), excelSheet.Cells(rowCounter, 12)).Value)
                    fax = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 13), excelSheet.Cells(rowCounter, 13)).Value)
                    email = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 14), excelSheet.Cells(rowCounter, 14)).Value)
                    state = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 15), excelSheet.Cells(rowCounter, 15)).Value)
                    title = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 16), excelSheet.Cells(rowCounter, 16)).Value)
                    remarks = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 17), excelSheet.Cells(rowCounter, 17)).Value)

                    If clientCode = String.Empty OrElse clientName = String.Empty Then
                        Exit Do
                    End If


                    clientConditions.Clear()

                    clientConditions.Add(AfBizMaster.M_MP_CLIENTColumns.CLIENT_CODEColumn, "=", clientCode)

                    clientConditions.Add(AfBizMaster.M_MP_CLIENTColumns.CLIENT_NAMEColumn, "=", clientName)

                    clientRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_CLIENTRow(clientConditions)

                    If IsNothing(clientRow) = True Then

                        'Dim clientID As string

                        'MyPosXAuto.Facade.AfBizMaster.CreateM_MP_CLIENTInfo( _
                        '    clientID, _
                        '    address, _
                        '    cellPhone, _
                        '    city, _
                        '    clientCode, _
                        '    clientName, _
                        '    country, _
                        '    department, _
                        '    email, _
                        '    fax, _
                        '    homePhone, _
                        '    linkMan, _
                        '    postCode, _
                        '    remarks, _
                        '    state, _
                        '    title, _
                        '    webSite, _
                        '    workPhone)
                    End If

                    rowCounter += 1

                    XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0004, rowCounter, clientName)

                Loop

                XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                excelBook.Close()
                excelApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelSheet)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
                System.GC.Collect()

                XL.Win.Window.XLProgressBox.CloseXLProgressBox()



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

                Dim sysClientAttr1 As String = String.Empty
                Dim sysClientAttr2 As String = String.Empty
                Dim sysClientAttr3 As String = String.Empty
                Dim sysClientAttr4 As String = String.Empty
                Dim sysClientAttr5 As String = String.Empty
                Dim sysClientAttr6 As String = String.Empty

                Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity

                Me._service.ServExportExcel( _
                    Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID, _
                    staffRowSE, _
                    sysClientAttr1, _
                    sysClientAttr2, _
                    sysClientAttr3, _
                    sysClientAttr4, _
                    sysClientAttr5, _
                    sysClientAttr6)


                If IO.File.Exists(Me._manifest.SV_EXPORT_EXCEL_FILENAME) = True Then
                    IO.File.Delete(Me._manifest.SV_EXPORT_EXCEL_FILENAME)
                End If

                Dim toExcel As New Utils.ExcelTK(Me._manifest.SV_EXPORT_EXCEL_FILENAME)

                toExcel.MergeCell(1, 1, 1, 24)
                toExcel.SetRowHeight(1, 35)

                toExcel.SetColumnWidth(1, 10)
                toExcel.SetColumnWidth(2, 15)
                toExcel.SetColumnWidth(3, 20)
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
                toExcel.SetColumnWidth(24, 10)

                If sysClientAttr1.Length <= 0 Then
                    toExcel.SetColumnWidth(18, 0)
                End If

                If sysClientAttr2.Length <= 0 Then
                    toExcel.SetColumnWidth(19, 0)
                End If

                If sysClientAttr3.Length <= 0 Then
                    toExcel.SetColumnWidth(20, 0)
                End If

                If sysClientAttr4.Length <= 0 Then
                    toExcel.SetColumnWidth(21, 0)
                End If

                If sysClientAttr5.Length <= 0 Then
                    toExcel.SetColumnWidth(22, 0)
                End If

                If sysClientAttr6.Length <= 0 Then
                    toExcel.SetColumnWidth(23, 0)
                End If

                Dim cellFont As Font = New Font("Arial", 16, FontStyle.Bold)
                toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("客户信息表"), cellFont, Color.Black, Color.White)

                cellFont = New Font("Arial", 12, FontStyle.Bold)

                toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 2, CommTK.GetTranslatedString("客户编码"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 3, CommTK.GetTranslatedString("客户名"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 4, CommTK.GetTranslatedString("联系人"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 5, CommTK.GetTranslatedString("职位"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 6, CommTK.GetTranslatedString("部门"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 7, CommTK.GetTranslatedString("工作电话"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 8, CommTK.GetTranslatedString("手机"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 9, CommTK.GetTranslatedString("家庭电话"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 10, CommTK.GetTranslatedString("传真"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 11, CommTK.GetTranslatedString("电子邮件"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 12, CommTK.GetTranslatedString("网页"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 13, CommTK.GetTranslatedString("地址"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 14, CommTK.GetTranslatedString("城市"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 15, CommTK.GetTranslatedString("省/州"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 16, CommTK.GetTranslatedString("邮编"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 17, CommTK.GetTranslatedString("国家"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 18, sysClientAttr1, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 19, sysClientAttr2, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 20, sysClientAttr3, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 21, sysClientAttr4, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 22, sysClientAttr5, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 23, sysClientAttr6, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 24, CommTK.GetTranslatedString("备注"), cellFont, Color.Black, Color.White)

                Dim rowCounter As Integer = 4
                Dim counter As Integer = 1

                XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_CLIENT_LIST.Count + rowCounter, 400, False)

                cellFont = New Font("Arial", 10, FontStyle.Regular)

                For Each bindingRow As MyPosXAuto.FTs.FT_MV_MP_CLIENTRow In Me._manifest.SVFT_BINDING_CLIENT_LIST

                    toExcel.SetCellText(rowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 2, bindingRow.CLIENT_CODE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 3, bindingRow.CLIENT_NAME, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 4, bindingRow.LINKMAN, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 5, bindingRow.TITLE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 6, bindingRow.DEPARTMENT, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 7, bindingRow.WORK_PHONE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 8, bindingRow.CELL_PHONE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 9, bindingRow.HOME_PHONE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 10, bindingRow.FAX, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 11, bindingRow.EMAIL, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 12, bindingRow.WEB_SITE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 13, bindingRow.ADDRESS, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 14, bindingRow.CITY, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 15, bindingRow.STATE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 16, bindingRow.POST_CODE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 17, bindingRow.COUNTRY, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 18, bindingRow.CLIENT_ATTR1, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 19, bindingRow.CLIENT_ATTR2, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 20, bindingRow.CLIENT_ATTR3, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 21, bindingRow.CLIENT_ATTR4, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 22, bindingRow.CLIENT_ATTR5, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 23, bindingRow.CLIENT_ATTR6, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 24, bindingRow.REMARKS, cellFont, Color.Black, Color.White)

                    rowCounter += 1
                    counter += 1

                    XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.CLIENT_NAME)

                Next

                XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                toExcel.SetFrameLine(3, 1, rowCounter - 1, 24, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)

                toExcel.SetFrameLine(2, 1, rowCounter - 1, 24, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                cellFont = New Font("Arial", 10, FontStyle.Bold)

                If staffRowSE.IsNull = False Then
                    toExcel.SetCellText(rowCounter + 2, 24, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                End If

                If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                    toExcel.SetCellText(rowCounter + 3, 24, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                Else
                    toExcel.SetCellText(rowCounter + 3, 24, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
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
        Private Function DoSendManagerSMS() As String


            Try

                Dim smsContentParts As New List(Of String)
                Dim smsContent = Me._manifest.SV_SENDING_SMS_CONTENT
                Dim contentPart As String
                Do
                    contentPart = String.Empty
                    Do While System.Text.Encoding.Default.GetByteCount(contentPart) < 138 AndAlso smsContent.Length > 0
                        contentPart += smsContent.Substring(0, 1)
                        smsContent = smsContent.Remove(0, 1)
                    Loop
                    smsContentParts.Add(contentPart)
                Loop While System.Text.Encoding.Default.GetByteCount(smsContent) > 140

                For Each bindingRow As MyPosXAuto.FTs.FT_MV_MP_CLIENTRow In Me._manifest.SVFT_BINDING_CLIENT_LIST.FindRowsSelecting(True)

                    For Each contentPart In smsContentParts

                        MyPosXService.Facade.OpSysConfig.CreateInformMessage( _
                            CommTK.GetSyncServerTime, _
                            String.Empty, _
                            String.Empty, _
                            String.Empty, _
                            bindingRow.CELL_PHONE, _
                            contentPart, _
                            WinTK.GetCurrentMachineName)

                    Next

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
