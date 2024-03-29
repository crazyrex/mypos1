Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade
Imports MyPosClient.Utils
Imports Microsoft.Office.Interop

Namespace Business


    Public Class B_02_00203
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
        Private _manifest As Manifest.M_02_00203
        Private _service As MyPosXService.S_02_00203

        Public Enum Affairs
            InitDisplay
            LoadList
            UpdateAllMakeups
            BizUtle0002
            ExportExcel
            ReInventory
            Replace
            LoadWareInfoByCode
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

            Me._manifest = CType(theManifest, Manifest.M_02_00203)

            Try

                Me._service = MyPosXService.S_02_00203.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_02_00203.GetInstance()
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

                Case Affairs.UpdateAllMakeups

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoUpdateAllMakeups)

                Case Affairs.BizUtle0002

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtle0002)

                Case Affairs.ExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoExportExcel)

                Case Affairs.ReInventory

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoReInventory)

                Case Affairs.Replace

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoReplace)

                Case Affairs.LoadWareInfoByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadWareInfoByCode)

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

                Dim sysWareSpecModelDiscard As Boolean
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Me._service.ServInitDisplay( _
                    sysWareSpecModelDiscard, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

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
        Private Function DoLoadList() As String


            Try

                Me._manifest.SVFT_BINDING_INVENTORY_RESULT_LIST.Clear()
                Dim resultConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_INVENTORY_RESULT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                resultConditions.Add(MyPosXAuto.Facade.AfXV.XV_T_MP_INVENTORY_RESULTColumns.INVENTORY_IDColumn, "=", Me._manifest.SV_EDIT_INVENTORY_ID)

                MyPosXAuto.Facade.AfXV.FillFT_XV_T_MP_INVENTORY_RESULT(resultConditions, Me._manifest.SVFT_BINDING_INVENTORY_RESULT_LIST)
                Me._manifest.GridControl_WareList.DataSource = Me._manifest.SVFT_BINDING_INVENTORY_RESULT_LIST

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
        Private Function DoUpdateAllMakeups() As String


            Try

                'For Each bindingRow As MyPosXAuto.FTs.FT_XV_T_MP_INVENTORY_RESULTRow In Me._manifest.SVFT_BINDING_INVENTORY_RESULT_LIST

                '    If bindingRow.ROW_HIGHLIGHT <> MyPosXService.Decls.ROW_HIGHLIGHT_DESIDED Then
                '        bindingRow.MAKEUP_STATUS = CommTK.FInteger(Me._manifest.LookUpEdit_UpdateAllMakeup.EditValue)
                '    End If

                'Next


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
        Private Function DoExportExcel() As String


            Try

                Dim sysWareSpecModelDiscard As Boolean
                Dim sysHideFinancials As Boolean
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity
                Dim inventoryRowSE As New MyPosXAuto.FTs.FT_XV_T_MP_INVENTORYRowSEntity

                Dim wareList As New MyPosXAuto.FTs.FT_XV_M_MP_WARE

                Me._service.ServExportExcel( _
                    sysWareSpecModelDiscard, _
                    sysHideFinancials, _
                    Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID, _
                    staffRowSE, _
                    Me._manifest.SV_EDIT_INVENTORY_ID, _
                    inventoryRowSE, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                If IO.File.Exists(Me._manifest.SV_EXPORT_EXCEL_FILENAME) = True Then
                    IO.File.Delete(Me._manifest.SV_EXPORT_EXCEL_FILENAME)
                End If

                Dim toExcel As New Utils.ExcelTK(Me._manifest.SV_EXPORT_EXCEL_FILENAME)

                toExcel.MergeCell(1, 1, 1, 15)
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
                toExcel.SetColumnWidth(14, 10)
                toExcel.SetColumnWidth(15, 10)

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

                toExcel.MergeCell(2, 1, 2, 15)

                cellFont = New Font("Arial", 10, FontStyle.Bold)
                toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("盘点日期:"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 1, CommTK.GetTranslatedString("地点名称:"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 1, CommTK.GetTranslatedString("盘点号:"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(6, 1, CommTK.GetTranslatedString("创建者:"), cellFont, Color.Black, Color.White)

                toExcel.SetCellText(3, 2, String.Format("{0:yyyy/MM/dd}", inventoryRowSE.CREATE_DATE), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 2, inventoryRowSE.POS_NAME, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(5, 2, inventoryRowSE.INVENTORY_CODE, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(6, 2, inventoryRowSE.CREATOR__STAFF_NAME, cellFont, Color.Black, Color.White)

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
                toExcel.SetCellText(9, 12, CommTK.GetTranslatedString("帐面数量"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 13, CommTK.GetTranslatedString("盘得数量"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 14, CommTK.GetTranslatedString("偏差数量"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(9, 15, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)

                Dim rowCounter As Integer = 10
                Dim counter As Integer = 1
                Dim totalSystemAmount As Double = 0
                Dim totalInventoryAmount As Double = 0
                Dim totalOffsetAmount As Double = 0

                XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_INVENTORY_RESULT_LIST.Count + rowCounter, 400, False)

                cellFont = New Font("Arial", 10, FontStyle.Regular)

                For Each bindingRow As MyPosXAuto.FTs.FT_XV_T_MP_INVENTORY_RESULTRow In Me._manifest.SVFT_BINDING_INVENTORY_RESULT_LIST

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
                    toExcel.SetCellText(rowCounter, 12, CommTK.FString(bindingRow.SYSTEM_AMOUNT), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 13, CommTK.FString(bindingRow.INVENTORY_AMOUNT), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 14, CommTK.FString(bindingRow.OFFSET_AMOUNT), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 15, bindingRow.UNIT_NAME, cellFont, Color.Black, Color.White)

                    rowCounter += 1
                    counter += 1

                    totalSystemAmount = totalSystemAmount + bindingRow.SYSTEM_AMOUNT
                    totalInventoryAmount = totalInventoryAmount + bindingRow.INVENTORY_AMOUNT
                    totalOffsetAmount = totalOffsetAmount + bindingRow.OFFSET_AMOUNT

                    XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.WARE_NAME)

                Next

                XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                toExcel.SetFrameLine(9, 1, rowCounter - 1, 15, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)

                toExcel.SetFrameLine(8, 1, rowCounter - 1, 15, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                cellFont = New Font("Arial", 12, FontStyle.Bold)

                toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 12, CommTK.FString(totalSystemAmount), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 13, CommTK.FString(totalInventoryAmount), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 14, CommTK.FString(totalOffsetAmount), cellFont, Color.Black, Color.White)

                cellFont = New Font("Arial", 10, FontStyle.Bold)

                If staffRowSE.IsNull = False Then
                    toExcel.SetCellText(rowCounter + 2, 15, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                End If

                If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                    toExcel.SetCellText(rowCounter + 3, 15, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                Else
                    toExcel.SetCellText(rowCounter + 3, 15, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
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
        Private Function DoReInventory() As String


            Try

                Me._manifest.ShowStatusMessage(StatusMessageIcon.Progressing, MyPosXService.Decls.MSG_STATUS_0001)

                Dim inventoryResult As String = String.Empty
                Me._service.ServReInventory(Me._manifest.SV_EDIT_INVENTORY_ID, inventoryResult)

                Me._manifest.ShowStatusMessage(StatusMessageIcon.None, String.Empty)

                Return inventoryResult

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
        Private Function DoReplace() As String


            Try
                Me._manifest.ShowStatusMessage(StatusMessageIcon.Progressing, MyPosXService.Decls.MSG_STATUS_0003)

                Dim replaceResult As String = String.Empty
                Me._service.ServReplace(Me._manifest.SV_EDIT_INVENTORY_ID, replaceResult)

                Me._manifest.ShowStatusMessage(StatusMessageIcon.None, String.Empty)

                Return replaceResult

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
        Private Function DoLoadWareInfoByCode() As String


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
