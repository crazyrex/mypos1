Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade
Imports Microsoft.Office.Interop
Imports MyPosClient.Utils

Namespace Business


    Public Class B_01_00101
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
        Private _manifest As Manifest.M_01_00101
        Private _service As MyPosXService.S_01_00101

        Public Enum Affairs
            InitDisplay
            LoadList
            DeleteInfo
            ExportExcel
            ImportFromExcel
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

            Me._manifest = CType(theManifest, Manifest.M_01_00101)

            Try

                Me._service = MyPosXService.S_01_00101.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_01_00101.GetInstance()
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

                Case Affairs.ExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoExportExcel)

                Case Affairs.ImportFromExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoImportFromExcel)

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
                Me._manifest.SVFT_BINDING_STAFF_LIST.Clear()
                MyPosXAuto.Facade.AfBizMaster.FillFT_M_STAFF(Nothing, Me._manifest.SVFT_BINDING_STAFF_LIST)

                Me._manifest.GridControl_Employee.DataSource = Me._manifest.SVFT_BINDING_STAFF_LIST

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

                MyPosXAuto.Facade.AfBizMaster.DeleteM_STAFFInfo(Me._manifest.SVFR_SELECTING_STAFF_ROW.STAFF_ID)

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

                If IO.File.Exists(Me._manifest.SV_EXPORT_EXCEL_FILENAME) = True Then
                    IO.File.Delete(Me._manifest.SV_EXPORT_EXCEL_FILENAME)
                End If

                Dim toExcel As New Utils.ExcelTK(Me._manifest.SV_EXPORT_EXCEL_FILENAME)

                toExcel.MergeCell(1, 1, 1, 16)
                toExcel.SetRowHeight(1, 35)

                toExcel.SetColumnWidth(1, 10)
                toExcel.SetColumnWidth(2, 10)
                toExcel.SetColumnWidth(3, 10)
                toExcel.SetColumnWidth(4, 10)
                toExcel.SetColumnWidth(5, 10)
                toExcel.SetColumnWidth(6, 10)
                toExcel.SetColumnWidth(7, 10)
                toExcel.SetColumnWidth(8, 12)
                toExcel.SetColumnWidth(9, 10)
                toExcel.SetColumnWidth(10, 10)
                toExcel.SetColumnWidth(11, 10)
                toExcel.SetColumnWidth(12, 10)
                toExcel.SetColumnWidth(13, 10)
                toExcel.SetColumnWidth(14, 12)
                toExcel.SetColumnWidth(15, 10)
                toExcel.SetColumnWidth(16, 10)

                Dim cellFont As Font = New Font("Arial", 16, FontStyle.Bold)
                toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("职员信息表"), cellFont, Color.Black, Color.White)

                cellFont = New Font("Arial", 12, FontStyle.Bold)

                toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 2, CommTK.GetTranslatedString("职员工号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 3, CommTK.GetTranslatedString("职员姓名"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 4, CommTK.GetTranslatedString("职位"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 5, CommTK.GetTranslatedString("部门"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 6, CommTK.GetTranslatedString("工作电话"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 7, CommTK.GetTranslatedString("手机"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 8, CommTK.GetTranslatedString("家庭电话"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 9, CommTK.GetTranslatedString("传真"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 10, CommTK.GetTranslatedString("电子邮件"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 11, CommTK.GetTranslatedString("地址"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 12, CommTK.GetTranslatedString("城市"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 13, CommTK.GetTranslatedString("省/州"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 14, CommTK.GetTranslatedString("邮编"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 15, CommTK.GetTranslatedString("国家"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(3, 16, CommTK.GetTranslatedString("备注"), cellFont, Color.Black, Color.White)

                Dim rowCounter As Integer = 4
                Dim counter As Integer = 1

                XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_STAFF_LIST.Count + rowCounter, 400, False)
                cellFont = New Font("Arial", 10, FontStyle.Regular)

                For Each bindingRow As MyPosXAuto.FTs.FT_M_STAFFRow In Me._manifest.SVFT_BINDING_STAFF_LIST

                    toExcel.SetCellText(rowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 2, bindingRow.STAFF_CODE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 3, bindingRow.STAFF_NAME, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 4, bindingRow.TITLE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 5, bindingRow.DEPARTMENT, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 6, bindingRow.WORK_PHONE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 7, bindingRow.CELL_PHONE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 8, bindingRow.HOME_PHONE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 9, bindingRow.FAX, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 10, bindingRow.EMAIL, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 11, bindingRow.ADDRESS, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 12, bindingRow.CITY, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 13, bindingRow.STATE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 14, bindingRow.POST_CODE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 15, bindingRow.COUNTRY, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 16, bindingRow.REMARKS, cellFont, Color.Black, Color.White)

                    rowCounter += 1
                    counter += 1

                    XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.STAFF_NAME)

                Next

                XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                toExcel.SetFrameLine(3, 1, rowCounter - 1, 16, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)

                toExcel.SetFrameLine(2, 1, rowCounter - 1, 16, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                cellFont = New Font("Arial", 10, FontStyle.Bold)



                If Utils.Decls.LOGIN_STAFF_ROW_SE.IsNull = False Then
                    toExcel.SetCellText(rowCounter + 2, 16, Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_NAME, cellFont, Color.Black, Color.White)
                End If

                If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                    toExcel.SetCellText(rowCounter + 3, 16, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                Else
                    toExcel.SetCellText(rowCounter + 3, 16, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
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
        Private Function DoImportFromExcel() As String


            Try

                Dim excelApp As New Excel.Application
                Dim excelBook As Excel.Workbook = excelApp.Workbooks.Open(Me._manifest.OpenFileDialog_ImportFile.FileName)
                Dim excelSheet As Excel.Worksheet = CType(excelBook.Worksheets.Item("Sheet1"), Excel.Worksheet)
                Dim rowCounter As Integer = 2

                Dim staffCode As String
                Dim staffName As String
                Dim address As String
                Dim cellPhone As String
                Dim city As String
                Dim country As String
                Dim department As String
                Dim email As String
                Dim fax As String
                Dim homePhone As String
                Dim postCode As String
                Dim remarks As String
                Dim state As String
                Dim title As String
                Dim workPhone As String

                Dim staffConditions As New  _
                    MyPosXAuto.Facade.AfBizMaster.ConditionOfM_STAFF(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                Dim staffRow As MyPosXAuto.FTs.FT_M_STAFFRow

                XL.Win.Window.XLProgressBox.SetProgressRange(rowCounter, 500, False)

                Do
                    staffCode = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 1), excelSheet.Cells(rowCounter, 1)).Value)
                    staffName = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 2), excelSheet.Cells(rowCounter, 2)).Value)
                    address = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 3), excelSheet.Cells(rowCounter, 3)).Value)
                    city = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 4), excelSheet.Cells(rowCounter, 4)).Value)
                    country = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 5), excelSheet.Cells(rowCounter, 5)).Value)
                    department = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 6), excelSheet.Cells(rowCounter, 6)).Value)
                    postCode = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 7), excelSheet.Cells(rowCounter, 7)).Value)
                    homePhone = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 8), excelSheet.Cells(rowCounter, 8)).Value)
                    workPhone = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 9), excelSheet.Cells(rowCounter, 9)).Value)
                    cellPhone = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 10), excelSheet.Cells(rowCounter, 10)).Value)
                    fax = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 11), excelSheet.Cells(rowCounter, 11)).Value)
                    email = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 12), excelSheet.Cells(rowCounter, 12)).Value)
                    state = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 13), excelSheet.Cells(rowCounter, 13)).Value)
                    title = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 14), excelSheet.Cells(rowCounter, 14)).Value)
                    remarks = CommTK.FString(excelSheet.Range(excelSheet.Cells(rowCounter, 15), excelSheet.Cells(rowCounter, 15)).Value)

                    If staffCode = String.Empty OrElse staffName = String.Empty Then
                        Exit Do
                    End If


                    staffConditions.Clear()

                    staffConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_STAFFColumns.STAFF_CODEColumn, "=", staffCode)

                    staffConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_STAFFColumns.STAFF_NAMEColumn, "=", staffName)

                    staffRow = MyPosXAuto.Facade.AfBizMaster.GetM_STAFFRow(staffConditions)

                    If IsNothing(staffRow) = True Then

                        Dim staffID = Guid.NewGuid.ToString

                        MyPosXAuto.Facade.AfBizMaster.CreateM_STAFFInfo( _
                         address, _
                         cellPhone, _
                         city, _
                         country, _
                         department, _
                         email, _
                         fax, _
                         homePhone, _
                         postCode, _
                         remarks, _
                         staffCode, _
                         staffID, _
                         staffName, _
                         state, _
                         title, _
                         workPhone)

                    End If

                    rowCounter += 1

                    XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0004, rowCounter, staffName)

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
