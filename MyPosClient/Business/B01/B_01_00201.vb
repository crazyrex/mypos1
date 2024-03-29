Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade
Imports Microsoft.Office.Interop
Imports MyPosClient.Utils

Namespace Business


    Public Class B_01_00201
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
        Private _manifest As Manifest.M_01_00201
        Private _service As MyPosXService.S_01_00201

        Public Enum Affairs
            InitDisplay
            LoadWareClassifyList
            DeleteWareClassifyInfo
            LoadWareList
            DeleteWare
            AllWareExportExcel
            SetImage
            LoadAllWareList
            SingalClassifyExportExcel
            RemoveImage
            LoadWareImage
            SaveCostPriceModify
            DownloadWareImages
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

            Me._manifest = CType(theManifest, Manifest.M_01_00201)

            Try

                Me._service = MyPosXService.S_01_00201.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_01_00201.GetInstance()
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


                Case Affairs.LoadWareClassifyList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadWareClassifyList)

                Case Affairs.DeleteWareClassifyInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoDeleteWareClassifyInfo)

                Case Affairs.LoadWareList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadWareList)

                Case Affairs.DeleteWare

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoDeleteWare)

                Case Affairs.AllWareExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoAllWareExportExcel)

                Case Affairs.SetImage

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSetImage)

                Case Affairs.LoadAllWareList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadAllWareList)

                Case Affairs.SingalClassifyExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSingalClassifyExportExcel)

                Case Affairs.RemoveImage

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoRemoveImage)

                Case Affairs.LoadWareImage

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadWareImage)

                Case Affairs.SaveCostPriceModify

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSaveCostPriceModify)

                Case Affairs.DownloadWareImages

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoDownloadWareImages)

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
                Dim supplierList As New MyPosXAuto.FTs.FT_M_MP_SUPPLIER
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Me._service.ServInitDisplay( _
                    sysWareSpecModelDiscard, _
                    sysHideFinancials, _
                    sysShowCustomWareCode, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                Me._manifest.GridColumn_Attribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_Attribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_Attribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_Attribute4.Caption = sysAttribute4

                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_SUPPLIER(Nothing, supplierList)

                Me._manifest.RepositoryItemLookUpEdit_SupplierID.DataSource = supplierList

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

                If sysHideFinancials = True Then
                    Me._manifest.GridColumn_Unitcost.Visible = False
                    Me._manifest.GridColumn_UnitPrice.Visible = False
                End If

                If sysShowCustomWareCode = False Then
                    Me._manifest.GridColumn_CustomCode.Visible = False
                End If

                Dim userCostHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_COST_HIDDEN"))
                Dim userPriceHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_PRICE_HIDDEN"))

                If userCostHidden = True Then
                    Me._manifest.GridColumn_Unitcost.Visible = False
                End If

                If userPriceHidden = True Then
                    Me._manifest.GridColumn_UnitPrice.Visible = False
                End If

                If MyPosXAuto.Decls.CURRENT_DB_TYPE <> XL.DB.DBDecl.DBType.Remoting Then
                    Me._manifest.CheckEdit_RemotingMode.Visible = False
                    Me._manifest.CheckEdit_RemotingMode.Checked = True
                    Me._manifest.LinkLabel_DownloadImages.Visible = False
                    Me._manifest.ComboBoxEdit_DownloadImageMode.Visible = False
                Else
                    Me._manifest.CheckEdit_RemotingMode.Visible = True
                    Me._manifest.CheckEdit_RemotingMode.Checked = False
                    Me._manifest.LinkLabel_DownloadImages.Visible = True
                    Me._manifest.ComboBoxEdit_DownloadImageMode.Visible = False
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
        Private Function DoLoadWareClassifyList() As String


            Try

                Me._manifest.TreeList_WareClassify.DataSource = Nothing
                Me._manifest.SVFT_BINDING_WARE_CLASSIFY_LIST.Clear()

                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_WARE_CLASSIFY( _
                    Nothing, _
                    Me._manifest.SVFT_BINDING_WARE_CLASSIFY_LIST, _
                    MyPosXAuto.Facade.AfBizMaster.M_MP_WARE_CLASSIFYColumns.WARE_CLASSIFY_IDColumn)

                Me._manifest.TreeList_WareClassify.DataSource = Me._manifest.SVFT_BINDING_WARE_CLASSIFY_LIST



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
        Private Function DoDeleteWareClassifyInfo() As String


            Try

                Dim classifyConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE_CLASSIFY(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                classifyConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WARE_CLASSIFYColumns.PARENT_IDColumn, "=", Me._manifest.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_ID)

                Dim classifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARE_CLASSIFYRow(classifyConditions)

                If IsNothing(classifyRow) = False Then
                    Return MyPosXService.Decls.MSG_ALERT_00001
                End If

                MyPosXAuto.Facade.AfBizMaster.DeleteM_MP_WARE_CLASSIFYInfo(Me._manifest.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_ID)



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
        Private Function DoLoadWareList() As String


            Try

                If IsNothing(Me._manifest.SVFR_SELECTING_CLASSIFY_ROW) = True Then
                    Return String.Empty
                End If

                Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                wareCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_CLASSIFY_IDColumn, "=", Me._manifest.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_ID)

                If Me._manifest.LAUNCH_CONDITION = MyPosXService.S_01_00201.LCs.Choose Then
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.PRACT_CODE_REQUIREDColumn, "=", Me._manifest.SVLM_SHOW_PRACT_TRACE)
                End If

                wareCondition.Add(AfBizMaster.M_MP_WAREColumns.IS_RETIREDColumn, "=", Me._manifest.CheckEdit_ShowRetired.Checked)

                Me._manifest.SVFT_BINDING_WARE_LIST.Clear()

                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_WARE(wareCondition, Me._manifest.SVFT_BINDING_WARE_LIST, MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn)
                Me._manifest.GridControl_Ware.DataSource = Me._manifest.SVFT_BINDING_WARE_LIST



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
        Private Function DoDeleteWare() As String


            Try

                If CommTK.FBoolean(SysInfo.LoginUserOptions.Options( _
                        Utils.UserOptionsBox.OPN_DELETE_WARE_ALLOWED)) = False Then
                    Return MyPosXService.Decls.MSG_ALERT_00016
                End If
                MyPosXAuto.Facade.AfBizMaster.DeleteM_MP_WAREInfo(Me._manifest.SVFR_SELECTING_WARE_ROW.WARE_ID)

                MyPosXService.Facade.OpSysConfig.CreateLog( _
                    MyPosXService.Decls.LOG_TITLE_00003, _
                    String.Format( _
                        "Item barcode:{0}  Code:{1} Deleted by {2} ", _
                        Me._manifest.SVFR_SELECTING_WARE_ROW.WARE_CODE, _
                        Me._manifest.SVFR_SELECTING_WARE_ROW.CUSTOM_CODE, _
                        SysInfo.LoginAccount))

                Me._manifest.SVFR_SELECTING_WARE_ROW.Delete()

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
        Private Function DoAllWareExportExcel() As String


            Try

                Dim sysWareSpecModelDiscard As Boolean
                Dim sysHideFinancials As Boolean
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity

                Dim allWareList As New MyPosXAuto.FTs.FT_M_MP_WARE

                Me._service.ServAllWareExportExcel( _
                    sysWareSpecModelDiscard, _
                    sysHideFinancials, _
                    Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID, _
                    staffRowSE, _
                    allWareList, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                If IO.File.Exists(Me._manifest.SV_EXPORT_EXCEL_FILENAME) = True Then
                    IO.File.Delete(Me._manifest.SV_EXPORT_EXCEL_FILENAME)
                End If

                Dim toExcel As New Utils.ExcelTK(Me._manifest.SV_EXPORT_EXCEL_FILENAME)

                Dim cellFont As Font

                Dim rowCounter As Integer = 3
                Dim classifyCounter As Integer = 1
                Dim counter As Integer = 1
                Dim totalCost As Double = 0
                Dim totalPrice As Double = 0

                Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                Dim classifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow

                For Each classifyRow In Me._manifest.SVFT_BINDING_WARE_CLASSIFY_LIST

                    cellFont = New Font("Arial", 16, FontStyle.Bold)

                    toExcel.AddSheet(classifyRow.WARE_CLASSIFY_NAME)

                    toExcel.SetColumnWidth(1, 10)
                    toExcel.SetColumnWidth(2, 10)
                    toExcel.SetColumnWidth(3, 20)
                    toExcel.SetColumnWidth(4, 10)
                    toExcel.SetColumnWidth(5, 10)
                    toExcel.SetColumnWidth(6, 10)
                    toExcel.SetColumnWidth(7, 10)
                    toExcel.SetColumnWidth(8, 12)
                    toExcel.SetColumnWidth(9, 10)
                    toExcel.SetColumnWidth(10, 20)
                    toExcel.SetColumnWidth(11, 10)
                    toExcel.SetColumnWidth(12, 10)
                    toExcel.SetColumnWidth(13, 10)
                    toExcel.SetColumnWidth(14, 10)
                    toExcel.SetColumnWidth(15, 10)

                    toExcel.MergeCell(1, 1, 1, 15)

                    toExcel.SetRowHeight(1, 35)

                    If sysAttribute1.Length <= 0 Then
                        toExcel.SetColumnWidth(11, 0)
                    End If

                    If sysAttribute2.Length <= 0 Then
                        toExcel.SetColumnWidth(12, 0)
                    End If

                    If sysAttribute3.Length <= 0 Then
                        toExcel.SetColumnWidth(13, 0)
                    End If

                    If sysAttribute4.Length <= 0 Then
                        toExcel.SetColumnWidth(14, 0)
                    End If

                    If sysWareSpecModelDiscard = True Then
                        toExcel.SetColumnWidth(4, 0)
                        toExcel.SetColumnWidth(5, 0)
                    End If

                    If sysHideFinancials = True Then
                        toExcel.SetColumnWidth(13, 0)
                        toExcel.SetColumnWidth(14, 0)
                    End If

                    toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("货品信息表"), cellFont, Color.Black, Color.White)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)

                    toExcel.SetCellText(4, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 2, CommTK.GetTranslatedString("货品类别"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 3, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 4, CommTK.GetTranslatedString("自定货号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 5, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 6, sysAttribute1, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 7, sysAttribute2, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 8, sysAttribute3, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 9, sysAttribute4, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 10, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 11, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 12, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 13, CommTK.GetTranslatedString("成本价"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 14, CommTK.GetTranslatedString("出货价"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(4, 15, CommTK.GetTranslatedString("备注"), cellFont, Color.Black, Color.White)

                    rowCounter = 5

                    wareCondition.Clear()
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.WARE_CLASSIFY_IDColumn, _
                        "=", _
                        classifyRow.WARE_CLASSIFY_ID)

                    XL.Win.Window.XLProgressBox.SetProgressRange(allWareList.FindRowsByCondition(wareCondition).Count + rowCounter, 400, False)

                    cellFont = New Font("Arial", 10, FontStyle.Regular)

                    Dim classifyCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE_CLASSIFY(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                    For Each bindingRow As MyPosXAuto.FTs.FT_M_MP_WARERow In allWareList.FindRowsByCondition(wareCondition)

                        classifyCondition.Clear()
                        classifyCondition.Add(AfBizMaster.M_MP_WARE_CLASSIFYColumns.WARE_CLASSIFY_IDColumn, "=", bindingRow.WARE_CLASSIFY_ID)
                        classifyRow = Me._manifest.SVFT_BINDING_WARE_CLASSIFY_LIST.FindRowByCondition(classifyCondition)

                        toExcel.SetCellText(rowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 2, classifyRow.WARE_CLASSIFY_NAME, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 3, bindingRow.WARE_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 4, bindingRow.CUSTOM_CODE, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 5, bindingRow.WARE_NAME, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 6, bindingRow.ATTRIBUTE1, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 7, bindingRow.ATTRIBUTE2, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 8, bindingRow.ATTRIBUTE3, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 9, bindingRow.ATTRIBUTE4, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 10, bindingRow.SPEC, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 11, bindingRow.MODEL, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 12, bindingRow.UNIT_NAME, cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 13, CommTK.FString(bindingRow.UNIT_COST), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 14, CommTK.FString(bindingRow.UNIT_PRICE), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 15, bindingRow.REMARK, cellFont, Color.Black, Color.White)

                        XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, counter, bindingRow.CUSTOM_CODE)

                        rowCounter += 1
                        counter += 1

                        totalCost = totalCost + bindingRow.UNIT_COST
                        totalPrice = totalCost + bindingRow.UNIT_PRICE

                    Next

                    XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                    classifyCounter += 1

                    toExcel.SetFrameLine(4, 1, rowCounter - 1, 15, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)

                    toExcel.SetFrameLine(3, 1, rowCounter - 1, 15, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                    cellFont = New Font("Arial", 12, FontStyle.Bold)

                    If sysHideFinancials = False Then
                        toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 13, CommTK.FString(totalCost), cellFont, Color.Black, Color.White)
                        toExcel.SetCellText(rowCounter, 14, CommTK.FString(totalPrice), cellFont, Color.Black, Color.White)
                    End If

                    cellFont = New Font("Arial", 10, FontStyle.Bold)

                    If staffRowSE.IsNull = False Then
                        toExcel.SetCellText(rowCounter + 2, 15, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                    End If

                    If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                        toExcel.SetCellText(rowCounter + 3, 15, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                    Else
                        toExcel.SetCellText(rowCounter + 3, 15, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
                    End If

                    totalCost = 0
                    totalPrice = 0

                    counter = 1

                Next

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
        Private Function DoSetImage() As String


            Try

                Dim wareImage As Image = CommTK.GetThumbnail(Image.FromFile(Me._manifest.SV_SETTING_IMAGE_FILENAME), 200, 200)
                If IsNothing(wareImage) = True Then
                    Me._manifest.ShowStatusMessage(StatusMessageIcon.Alert, MyPosXService.Decls.MSG_STATUS_0012)
                    Return String.Empty
                End If


                Dim servResult As String = _
                    Me._service.ServSetImage( _
                        Me._manifest.SVFR_SELECTING_WARE_ROW.WARE_ID, _
                        CommTK.ImageToBytes(wareImage))

                If servResult.Length > 0 Then
                    Return servResult
                End If

                Me._manifest.PictureBox_Item.Image = wareImage

                'Dim wareList As String = _
                '    CommTK.ReadTextFromFile(Me._manifest.SV_READING_TXT_FILENAME, System.Text.Encoding.Default)

                'Dim lines As String() = wareList.Split(Chr(10))

                'Dim items As String()

                'Dim defaultClassifyCode As String = "00000"

                'Dim classifyConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE_CLASSIFY(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                'classifyConditions.Add( _
                '    AfBizMaster.M_MP_WARE_CLASSIFYColumns.WARE_CLASSIFY_CODEColumn, _
                '    "=", _
                '    defaultClassifyCode)

                'Dim classifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow = _
                '    MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARE_CLASSIFYRow(classifyConditions)

                'If IsNothing(classifyRow) = True Then

                '    Dim classifyID As string
                '    Dim classifyDepth As Integer

                '    MyPosXAuto.Facade.AfBizMaster.CreateM_MP_WARE_CLASSIFYInfo( _
                '        classifyID, _
                '        0, _
                '        0, _
                '        String.Empty, _
                '        defaultClassifyCode, _
                '        String.Empty, _
                '        "无分类")

                '    MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_WARE_CLASSIFYInfo( _
                '        classifyID, _
                '        classifyDepth, _
                '        0, _
                '        Nothing, _
                '        Nothing, _
                '        MyPosXService.facade.OpBizMaster.GetWareClassifyIDPath(classifyID, classifyDepth), _
                '        Nothing)

                'End If


                'Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                'Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow

                'Dim rowCounter As Integer = 1

                'XL.Win.Window.XLProgressBox.SetProgressRange(lines.Length + rowCounter, 400, False)

                'For Each line As String In lines

                '    items = line.Split(vbTab.ToCharArray)


                '    wareCondition.Clear()

                '    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", items(0).Trim)

                '    'wareCondition.Add(AfBizMaster.M_MP_WAREColumns.WARE_NAMEColumn, "=", items(1).Trim)

                '    wareRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareCondition)

                '    If IsNothing(wareRow) = True Then

                '        'MyPosXAuto.Facade.AfBizMaster.CreateM_MP_WAREInfo( _
                '        '        items(4), _
                '        '        String.Empty, _
                '        '        String.Empty, _
                '        '        String.Empty, _
                '        '        items(2), _
                '        '        String.Empty, _
                '        '        items(3), _
                '        '        defaultClassifyCode, _
                '        '        items(0), _
                '        '        items(1), _
                '        '        0)

                '    End If

                '    rowCounter += 1

                '    If items.Length >= 5 Then
                '        XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0004, rowCounter, items(1).Trim)
                '    End If

                'Next

                'XL.Win.Window.XLProgressBox.CloseXLProgressBox()


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
        Private Function DoLoadAllWareList() As String


            Try

                Me._manifest.SVFT_BINDING_WARE_LIST.Clear()

                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_WARE(Nothing, Me._manifest.SVFT_BINDING_WARE_LIST)
                Me._manifest.GridControl_Ware.DataSource = Me._manifest.SVFT_BINDING_WARE_LIST

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
        Private Function DoSingalClassifyExportExcel() As String


            Try

                Dim sysWareSpecModelDiscard As Boolean
                Dim sysHideFinancials As Boolean
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Dim staffRowSE As New MyPosXAuto.FTs.FT_M_STAFFRowSEntity

                Me._service.ServSingalClassifyExportExcel( _
                    sysWareSpecModelDiscard, _
                    sysHideFinancials, _
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

                toExcel.SetColumnWidth(1, 10)
                toExcel.SetColumnWidth(2, 10)
                toExcel.SetColumnWidth(3, 20)
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
                toExcel.SetColumnWidth(14, 10)
                toExcel.SetColumnWidth(15, 10)

                If sysAttribute1.Length <= 0 Then
                    toExcel.SetColumnWidth(6, 0)
                End If

                If sysAttribute2.Length <= 0 Then
                    toExcel.SetColumnWidth(7, 0)
                End If

                If sysAttribute3.Length <= 0 Then
                    toExcel.SetColumnWidth(8, 0)
                End If

                If sysAttribute4.Length <= 0 Then
                    toExcel.SetColumnWidth(9, 0)
                End If

                If sysWareSpecModelDiscard = True Then
                    toExcel.SetColumnWidth(10, 0)
                    toExcel.SetColumnWidth(11, 0)
                End If

                If sysHideFinancials = True Then
                    toExcel.SetColumnWidth(13, 0)
                    toExcel.SetColumnWidth(14, 0)
                End If

                Dim cellFont As Font

                Dim rowCounter As Integer = 3
                Dim classifyCounter As Integer = 1
                Dim counter As Integer = 1
                Dim totalCost As Double = 0
                Dim totalPrice As Double = 0

                cellFont = New Font("Arial", 16, FontStyle.Bold)

                toExcel.MergeCell(1, 1, 1, 15)
                toExcel.SetRowHeight(1, 35)

                Dim userCostHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_COST_HIDDEN"))

                toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("货品信息表"), cellFont, Color.Black, Color.White)

                cellFont = New Font("Arial", 12, FontStyle.Bold)

                toExcel.SetCellText(4, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 2, CommTK.GetTranslatedString("货品类别"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 3, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 4, CommTK.GetTranslatedString("自定货号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 5, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 6, sysAttribute1, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 7, sysAttribute2, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 8, sysAttribute3, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 9, sysAttribute4, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 10, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 11, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 12, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 13, CommTK.GetTranslatedString("成本价"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 14, CommTK.GetTranslatedString("出货价"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(4, 15, CommTK.GetTranslatedString("备注"), cellFont, Color.Black, Color.White)
                If Me._manifest.CheckEdit_ExportPictureToExcel.Checked = True Then
                    toExcel.SetCellText(4, 16, CommTK.GetTranslatedString("图片"), cellFont, Color.Black, Color.White)
                End If

                rowCounter = 5


                cellFont = New Font("Arial", 10, FontStyle.Regular)

                Dim wareRows As List(Of MyPosXAuto.FTs.FT_M_MP_WARERow)
                Dim wareImageRow As MyPosXAuto.FTs.FT_S_MP_WARE_IMAGERow

                If Me._manifest.SVFT_BINDING_WARE_LIST.FindRowsSelecting(True).Count > 0 Then
                    XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_WARE_LIST.FindRowsSelecting(True).Count + rowCounter, 400, False)
                    wareRows = Me._manifest.SVFT_BINDING_WARE_LIST.FindRowsSelecting(True)
                Else
                    XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_WARE_LIST.Count + rowCounter, 400, False)
                    wareRows = Me._manifest.SVFT_BINDING_WARE_LIST.FindRowsByCondition(Nothing)
                End If

                Dim classifyCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE_CLASSIFY(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                Dim classifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow

                For Each bindingRow As MyPosXAuto.FTs.FT_M_MP_WARERow In wareRows

                    classifyCondition.Clear()
                    classifyCondition.Add(AfBizMaster.M_MP_WARE_CLASSIFYColumns.WARE_CLASSIFY_IDColumn, "=", bindingRow.WARE_CLASSIFY_ID)
                    classifyRow = Me._manifest.SVFT_BINDING_WARE_CLASSIFY_LIST.FindRowByCondition(classifyCondition)

                    toExcel.SetCellText(rowCounter, 1, CommTK.FString(counter), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 2, classifyRow.WARE_CLASSIFY_NAME, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 3, bindingRow.WARE_CODE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 4, bindingRow.CUSTOM_CODE, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 5, bindingRow.WARE_NAME, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 6, bindingRow.ATTRIBUTE1, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 7, bindingRow.ATTRIBUTE2, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 8, bindingRow.ATTRIBUTE3, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 9, bindingRow.ATTRIBUTE4, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 10, bindingRow.SPEC, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 11, bindingRow.MODEL, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 12, bindingRow.UNIT_NAME, cellFont, Color.Black, Color.White)
                    If userCostHidden = False Then
                        toExcel.SetCellText(rowCounter, 13, CommTK.FString(bindingRow.UNIT_COST), cellFont, Color.Black, Color.White)
                    End If
                    toExcel.SetCellText(rowCounter, 14, CommTK.FString(bindingRow.UNIT_PRICE), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 15, bindingRow.REMARK, cellFont, Color.Black, Color.White)


                    If Me._manifest.CheckEdit_ExportPictureToExcel.Checked = True Then

                        wareImageRow = MyPosXAuto.Facade.AfBizConfig.GetS_MP_WARE_IMAGERow(bindingRow.WARE_ID)
                        If IsNothing(wareImageRow) = False Then
                            toExcel.SetRowHeight(rowCounter, 100)
                            toExcel.InsertPicture(rowCounter, 16, wareImageRow.WARE_IMAGE, 0, 0, 100, 100)
                        End If

                    End If
                    XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, counter, bindingRow.CUSTOM_CODE)

                    rowCounter += 1
                    counter += 1

                    totalCost = totalCost + bindingRow.UNIT_COST
                    totalPrice = totalCost + bindingRow.UNIT_PRICE

                Next

                XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                classifyCounter += 1

                toExcel.SetFrameLine(4, 1, rowCounter - 1, 15, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)

                toExcel.SetFrameLine(3, 1, rowCounter - 1, 15, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                cellFont = New Font("Arial", 12, FontStyle.Bold)

                If sysHideFinancials = False Then
                    toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 13, CommTK.FString(totalCost), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 14, CommTK.FString(totalPrice), cellFont, Color.Black, Color.White)
                End If

                cellFont = New Font("Arial", 10, FontStyle.Bold)

                If staffRowSE.IsNull = False Then
                    toExcel.SetCellText(rowCounter + 2, 15, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                End If

                If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                    toExcel.SetCellText(rowCounter + 3, 15, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                Else
                    toExcel.SetCellText(rowCounter + 3, 15, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
                End If

                If userCostHidden = True Then
                    toExcel.SetColumnWidth(13, 0)
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
        Private Function DoRemoveImage() As String


            Try

                MyPosXAuto.Facade.AfBizConfig.DeleteS_MP_WARE_IMAGEInfo(Me._manifest.SVFR_SELECTING_WARE_ROW.WARE_ID)

                Me._manifest.PictureBox_Item.Image = Nothing


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
        Private Function DoLoadWareImage() As String


            Try

                Dim imageRow = MyPosXAuto.Facade.AfBizConfig.GetS_MP_WARE_IMAGERow(Me._manifest.SVFR_SELECTING_WARE_ROW.WARE_ID)
                If IsNothing(imageRow) = True Then
                    Me._manifest.PictureBox_Item.Image = Nothing
                    Return String.Empty
                End If

                Me._manifest.PictureBox_Item.Image = imageRow.WARE_IMAGE
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
        Private Function DoSaveCostPriceModify() As String


            Try

                Dim servResult = _
                    Me._service.ServSaveCostPriceModify(Me._manifest.SVFT_BINDING_WARE_LIST)

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
        Private Function DoDownloadWareImages() As String


            Try

                Dim localWareImageList As New MyPosXAuto.FTs.FT_S_MP_WARE_IMAGE
                Dim readWareImageList As New MyPosXAuto.FTs.FT_S_MP_WARE_IMAGE
                Dim wareImageCondition As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_WARE_IMAGE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                Dim wareIDs As New ArrayList
                Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_WARE_IMAGE(Nothing, localWareImageList)


                Select Case Me._manifest.ComboBoxEdit_DownloadImageMode.SelectedIndex
                    Case 0

                        For Each classifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow In Me._manifest.SVFT_BINDING_WARE_CLASSIFY_LIST
                            Me._manifest.ShowStatusMessage(StatusMessageIcon.Progressing, MyPosXService.Decls.MSG_STATUS_0016, classifyRow.WARE_CLASSIFY_NAME)

                            wareCondition.Clear()
                            readWareImageList.Clear()
                            MyPosXAuto.Facade.AfBizConfig.ReadS_MP_WARE_IMAGEDataStyle = XL.DB.DBDecl.DataReadStyle.OnceRemote
                            MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_WARE_IMAGE(wareImageCondition, readWareImageList)

                            wareIDs.Clear()

                            wareCondition.Add(AfBizMaster.M_MP_WAREColumns.WARE_CLASSIFY_IDColumn, "=", classifyRow.WARE_CLASSIFY_ID)
                            wareIDs = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARE_CVListDistinct(wareCondition, AfBizMaster.M_MP_WAREColumns.WARE_IDColumn)

                            wareImageCondition.Clear()
                            wareImageCondition.Add(AfBizConfig.S_MP_WARE_IMAGEColumns.WARE_IDColumn, True, wareIDs)


                            localWareImageList.RemoveFT_S_MP_WARE_IMAGERows(wareImageCondition)
                            localWareImageList.ImportTable(readWareImageList, Nothing)
                        Next

                    Case 1

                        Me._manifest.ShowStatusMessage(StatusMessageIcon.Progressing, MyPosXService.Decls.MSG_STATUS_0016, Me._manifest.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_NAME)
                        wareIDs.Clear()

                        wareCondition.Add(AfBizMaster.M_MP_WAREColumns.WARE_CLASSIFY_IDColumn, "=", Me._manifest.SVFR_SELECTING_CLASSIFY_ROW.WARE_CLASSIFY_ID)
                        wareIDs = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARE_CVListDistinct(wareCondition, AfBizMaster.M_MP_WAREColumns.WARE_IDColumn)

                        wareImageCondition.Add(AfBizConfig.S_MP_WARE_IMAGEColumns.WARE_IDColumn, True, wareIDs)

                        MyPosXAuto.Facade.AfBizConfig.ReadS_MP_WARE_IMAGEDataStyle = XL.DB.DBDecl.DataReadStyle.OnceRemote
                        MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_WARE_IMAGE(wareImageCondition, readWareImageList)

                        localWareImageList.RemoveFT_S_MP_WARE_IMAGERows(wareImageCondition)
                        localWareImageList.ImportTable(readWareImageList, Nothing)

                    Case 2

                        Me._manifest.ShowStatusMessage(StatusMessageIcon.Progressing, MyPosXService.Decls.MSG_STATUS_0016, Me._manifest.SVFR_SELECTING_WARE_ROW.WARE_NAME)
                        wareImageCondition.Add(AfBizConfig.S_MP_WARE_IMAGEColumns.WARE_IDColumn, "=", Me._manifest.SVFR_SELECTING_WARE_ROW.WARE_ID)


                        MyPosXAuto.Facade.AfBizConfig.ReadS_MP_WARE_IMAGEDataStyle = XL.DB.DBDecl.DataReadStyle.OnceRemote
                        MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_WARE_IMAGE(wareImageCondition, readWareImageList)

                        localWareImageList.RemoveFT_S_MP_WARE_IMAGERows(wareImageCondition)
                        localWareImageList.ImportTable(readWareImageList, Nothing)

                End Select

                MyPosXAuto.DataCache.DCHBizConfig.OverwriteS_MP_WARE_IMAGEFromDB(localWareImageList)
                Me._manifest.ShowStatusMessage(StatusMessageIcon.Okay, MyPosXService.Decls.MSG_STATUS_0010, localWareImageList.Count)


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
