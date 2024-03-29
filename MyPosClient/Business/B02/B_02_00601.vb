Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade
Imports MyPosClient.Utils
Imports Microsoft.Office.Interop

Namespace Business


    Public Class B_02_00601
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
        Private _manifest As Manifest.M_02_00601
        Private _service As MyPosXService.S_02_00601

        Public Enum Affairs
            InitDisplay
            LoadLocationInfoByID
            LoadWareByCode
            AddWare
            SaveInfo
            LoadLocationStockList
            ImportMobile
            BizUtld0012
            Remove
            LoadShelfStockDifferenceList
            ExportExcel
            ValidateAmountAvailable
            LoadLocationInfoByCode
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

            Me._manifest = CType(theManifest, Manifest.M_02_00601)


            Try

                Me._service = MyPosXService.S_02_00601.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_02_00601.GetInstance()
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

                Case Affairs.LoadLocationInfoByID

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadLocationInfoByID)

                Case Affairs.LoadWareByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadWareByCode)

                Case Affairs.AddWare

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoAddWare)

                Case Affairs.SaveInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSaveInfo)

                Case Affairs.LoadLocationStockList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadLocationStockList)

                Case Affairs.ImportMobile

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoImportMobile)

                Case Affairs.BizUtld0012

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0012)

                Case Affairs.Remove

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoRemove)

                Case Affairs.LoadShelfStockDifferenceList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadShelfStockDifferenceList)

                Case Affairs.ExportExcel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoExportExcel)

                Case Affairs.ValidateAmountAvailable

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoValidateAmountAvailable)

                Case Affairs.LoadLocationInfoByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadLocationInfoByCode)

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

                If IsNothing(Utils.Decls.CURRENT_POS_ROW) = False Then
                    Me._manifest.LookUpEdit_Pos.EditValue = Utils.Decls.CURRENT_POS_ROW.POS_ID
                End If

                Dim sysShowEnglishItemName As Boolean
                Dim sysSpecModelDiscard As Boolean
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Me._service.ServInitDisplay( _
                    CommDecl.CURRENT_LANGUAGE_OPTION, _
                    Me._manifest.SVFT_CHOOSE_POS_LIST, _
                    Me._manifest.SVFT_CHOOSE_IO_TYPE_LIST, _
                    sysShowEnglishItemName, _
                    sysSpecModelDiscard, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4)

                Me._manifest.LookUpEdit_Pos.Properties.DataSource = Me._manifest.SVFT_CHOOSE_POS_LIST
                Me._manifest.LookUpEdit_IOType.Properties.DataSource = Me._manifest.SVFT_CHOOSE_IO_TYPE_LIST

                If sysShowEnglishItemName = False Then

                    Me._manifest.GridColumn_WareNameEn.Visible = False
                    Me._manifest.GridColumn_ModelEn.Visible = False
                    Me._manifest.GridColumn_SpecEn.Visible = False
                    Me._manifest.GridColumn_VWareNameEn.Visible = False
                    Me._manifest.GridColumn_VModelEn.Visible = False
                    Me._manifest.GridColumn_VSpecEn.Visible = False

                End If


                Me._manifest.GridColumn_Attribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_Attribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_Attribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_Attribute4.Caption = sysAttribute4

                Me._manifest.GridColumn_VAttribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_VAttribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_VAttribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_VAttribute4.Caption = sysAttribute4

                Me._manifest.GridColumn_SAttribute1.Caption = sysAttribute1
                Me._manifest.GridColumn_SAttribute2.Caption = sysAttribute2
                Me._manifest.GridColumn_SAttribute3.Caption = sysAttribute3
                Me._manifest.GridColumn_SAttribute4.Caption = sysAttribute4


                If sysAttribute1.Length = 0 Then
                    Me._manifest.GridColumn_Attribute1.Visible = False
                    Me._manifest.GridColumn_VAttribute1.Visible = False
                    Me._manifest.GridColumn_SAttribute1.Visible = False
                End If

                If sysAttribute2.Length = 0 Then
                    Me._manifest.GridColumn_Attribute2.Visible = False
                    Me._manifest.GridColumn_VAttribute2.Visible = False
                    Me._manifest.GridColumn_SAttribute2.Visible = False
                End If

                If sysAttribute3.Length = 0 Then
                    Me._manifest.GridColumn_Attribute3.Visible = False
                    Me._manifest.GridColumn_VAttribute3.Visible = False
                    Me._manifest.GridColumn_SAttribute3.Visible = False
                End If

                If sysAttribute4.Length = 0 Then
                    Me._manifest.GridColumn_Attribute4.Visible = False
                    Me._manifest.GridColumn_VAttribute4.Visible = False
                    Me._manifest.GridColumn_SAttribute4.Visible = False
                End If

                If sysSpecModelDiscard = True Then
                    Me._manifest.GridColumn_Spec.Visible = False
                    Me._manifest.GridColumn_SpecEn.Visible = False

                    Me._manifest.GridColumn_Model.Visible = False
                    Me._manifest.GridColumn_ModelEn.Visible = False

                    Me._manifest.GridColumn_VSpec.Visible = False
                    Me._manifest.GridColumn_VSpecEn.Visible = False

                    Me._manifest.GridColumn_VModel.Visible = False
                    Me._manifest.GridColumn_VModelEn.Visible = False

                    Me._manifest.GridColumn_SSpec.Visible = False
                    Me._manifest.GridColumn_SModel.Visible = False

                End If

                If Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID.Length <= 0 Then
                    Me._manifest.Enabled = False
                    Return MyPosXService.Decls.MSG_ALERT_00029
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
        Private Function DoLoadLocationInfoByID() As String


            Try

                Dim locationRowSEntity As New MyPosXAuto.FTs.FT_M_MP_POS_LOCATIONRowSEntity
                Dim locationInfo As String = String.Empty
                Me._service.ServLoadLocationInfoByID( _
                    Me._manifest.Label_LocationID.Text, _
                    locationRowSEntity, _
                    locationInfo)

                If locationRowSEntity.IsNull = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00046
                End If

                Me._manifest.ButtonEdit_LocationCode.Text = locationRowSEntity.LOCATION_CODE
                Me._manifest.Label_StoringPlaceInfo.Text = locationInfo
                Me._manifest.Label_LocationID.Text = CommTK.FString(locationRowSEntity.LOCATION_ID)

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
        Private Function DoLoadWareByCode() As String


            Try

                Dim locationID As String

                Dim wareRowSEntity As New MyPosXAuto.FTs.FT_M_MP_WARERowSEntity
                Dim wareCode As String = Me._manifest.ButtonEdit_WareCode.Text


                Me._service.ServLoadWareByCode(wareCode, wareRowSEntity, locationID)

                '当货品代码中带有"/", 则代表储位编码
                If Me._manifest.ButtonEdit_WareCode.Text.IndexOf("/"c) >= 0 Then

                    Me._manifest.ButtonEdit_WareCode.ResetText()

                    If locationID.Length <= 0 Then
                        WinTK.PlayWavSound(WinTK.GetResourceFilePath(ResourceType.Sound, "NG.wav"))
                        Me._manifest.ShowStatusMessage(StatusMessageIcon.Progressing, MyPosXService.Decls.MSG_STATUS_0004)
                        Return String.Empty
                    End If

                    Me._manifest.SV_LOADING_LOCATION_ID = locationID
                    Me._manifest.DoPublicAlterLocationByID()

                    Return String.Empty
                End If


                If wareRowSEntity.IsNull = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00010
                End If

                Me._manifest.ButtonEdit_WareCode.Text = wareRowSEntity.WARE_CODE
                Me._manifest.Label_CustomCode.Text = wareRowSEntity.CUSTOM_CODE
                Me._manifest.Label_WareID.Text = CommTK.FString(wareRowSEntity.WARE_ID)

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
        Private Function DoAddWare() As String


            Try

                If Me._manifest.Label_WareID.Text.Trim.Length = 0 Then
                    Return String.Empty
                End If

                Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                wareCondition.Add(AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", Me._manifest.ButtonEdit_WareCode.Text)
                Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareCondition)

                If IsNothing(wareRow) = True Then
                    Return MyPosXService.Decls.MSG_ALERT_00010
                End If

                Dim iohistoryCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_POS_LOCATION_IO_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                iohistoryCondition.Add(AfXV.XV_H_MP_POS_LOCATION_IO_DTLColumns.WARE_IDColumn, "=", wareRow.WARE_ID)

                Dim bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_POS_LOCATION_IO_DTLRow = _
                    Me._manifest.SVFT_BINDING_IO_DTL_LIST.FindRowByCondition(iohistoryCondition)

                If IsNothing(bindingRow) = True OrElse bindingRow.RowState = DataRowState.Deleted Then
                    bindingRow = Me._manifest.SVFT_BINDING_IO_DTL_LIST.NewXV_H_MP_POS_LOCATION_IO_DTLRow
                    Me._manifest.SVFT_BINDING_IO_DTL_LIST.AddXV_H_MP_POS_LOCATION_IO_DTLRow(bindingRow)
                    bindingRow.WARE_ID = wareRow.WARE_ID
                    bindingRow.WARE_NAME = wareRow.WARE_NAME
                    bindingRow.WARE_CODE = wareRow.WARE_CODE
                    bindingRow.CUSTOM_CODE = wareRow.CUSTOM_CODE
                    bindingRow.SPEC = wareRow.SPEC
                    bindingRow.SPEC_EN = wareRow.SPEC_EN
                    bindingRow.MODEL = wareRow.MODEL
                    bindingRow.MODEL_EN = wareRow.MODEL_EN
                    bindingRow.UNIT_NAME = wareRow.UNIT_NAME
                    bindingRow.ATTRIBUTE1 = wareRow.ATTRIBUTE1
                    bindingRow.ATTRIBUTE2 = wareRow.ATTRIBUTE2
                    bindingRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                    bindingRow.ATTRIBUTE4 = wareRow.ATTRIBUTE4

                End If

                bindingRow.IO_AMOUNT += 1

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

                If Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID.Length <= 0 Then
                    Return MyPosXService.Decls.MSG_ALERT_00029
                End If

                Dim validateResult As String = _
                    Me.DoValidateAmountAvailable

                If validateResult.Length > 0 Then
                    WinTK.PlayWavSound(WinTK.GetResourceFilePath(ResourceType.Sound, "NG.wav"))
                    Return validateResult
                End If

                Me._service.ServSaveInfo( _
                    CommTK.FInteger(Me._manifest.LookUpEdit_IOType.EditValue), _
                    Me._manifest.Label_LocationID.Text, _
                    Utils.Decls.LOGIN_STAFF_ROW_SE.STAFF_ID, _
                    Me._manifest.SVFT_BINDING_IO_DTL_LIST)

                Me._manifest.SVFT_BINDING_IO_DTL_LIST.Clear()

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

                Dim locationStockCondition As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_POS_LOCATION_STOCK_AMOUNT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                locationStockCondition.Add(AfMV.MV_MP_POS_LOCATION_STOCK_AMOUNTColumns.LOCATION_IDColumn, "=", Me._manifest.Label_LocationID.Text)

                Me._manifest.SVFT_BINDING_LOCATION_STOCK_LIST.Clear()
                MyPosXAuto.Facade.AfMV.FillFT_MV_MP_POS_LOCATION_STOCK_AMOUNT( _
                    locationStockCondition, _
                    Me._manifest.SVFT_BINDING_LOCATION_STOCK_LIST)

                Me._manifest.GridControl_ViewCurrentStock.DataSource = Me._manifest.SVFT_BINDING_LOCATION_STOCK_LIST

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
        Private Function DoImportMobile() As String


            Try

                Dim wareRow As MyPosXAuto.FTs.FT_XV_M_MP_WARERow
                Dim wareCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_M_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                Dim ioDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_POS_LOCATION_IO_DTLRow

                Select Case CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_COLLECTOR_DEVICE_TYPE))


                    Case CommDecl.MOBILE_DEVICE_TYPE_CPT

                        Dim readLines As ArrayList = BarCodeKit.ReadCPT80Data()
                        If IsNothing(readLines) = True Then
                            Return MyPosXService.Decls.MSG_ALERT_00008
                        End If

                        Dim wareCode As String
                        Dim wareAmount As Double

                        For Each lineData As ArrayList In readLines

                            wareCode = CommTK.FString(lineData(0))
                            wareAmount = CommTK.FDouble(lineData(1))

                            wareCondition.Clear()
                            wareCondition.Add(AfXV.XV_M_MP_WAREColumns.WARE_CODEColumn, "=", wareCode)
                            wareRow = MyPosXAuto.Facade.AfXV.GetXV_M_MP_WARERow(wareCondition)

                            If IsNothing(wareRow) = False Then

                                ioDtlRow = Me._manifest.SVFT_BINDING_IO_DTL_LIST.NewXV_H_MP_POS_LOCATION_IO_DTLRow
                                Me._manifest.SVFT_BINDING_IO_DTL_LIST.AddXV_H_MP_POS_LOCATION_IO_DTLRow(ioDtlRow)

                                ioDtlRow.WARE_ID = wareRow.WARE_ID
                                ioDtlRow.WARE_NAME = wareRow.WARE_NAME
                                ioDtlRow.WARE_CODE = wareRow.WARE_CODE
                                ioDtlRow.CUSTOM_CODE = wareRow.CUSTOM_CODE
                                ioDtlRow.SPEC = wareRow.SPEC
                                ioDtlRow.SPEC_EN = wareRow.SPEC_EN
                                ioDtlRow.MODEL = wareRow.MODEL
                                ioDtlRow.MODEL_EN = wareRow.MODEL_EN
                                ioDtlRow.UNIT_NAME = wareRow.UNIT_NAME
                                ioDtlRow.ATTRIBUTE1 = wareRow.ATTRIBUTE1
                                ioDtlRow.ATTRIBUTE2 = wareRow.ATTRIBUTE2
                                ioDtlRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                                ioDtlRow.ATTRIBUTE4 = wareRow.ATTRIBUTE4
                                ioDtlRow.IO_AMOUNT = wareAmount

                            End If

                        Next


                    Case CommDecl.MOBILE_DEVICE_TYPE_WINCE


                        If BarCodeKit.ReadWinCETable(IO.Path.Combine( _
                                SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_MOBILE_SWAP_PATH), _
                                MyPosXService.Decls.CTBN_SHELF_LOCATION_IO_DTL), _
                            CType(Me._manifest.SVFT_BINDING_IO_DTL_LIST, DataTable)) = False Then
                            Return String.Empty
                        End If



                        For Each ioDtlRow In Me._manifest.SVFT_BINDING_IO_DTL_LIST


                            wareCondition.Clear()
                            wareCondition.Add(AfXV.XV_M_MP_WAREColumns.WARE_CODEColumn, "=", ioDtlRow.WARE_CODE)

                            wareRow = MyPosXAuto.Facade.AfXV.GetXV_M_MP_WARERow(wareCondition)
                            If IsNothing(wareRow) = True Then
                                ioDtlRow.Delete()
                            Else
                                ioDtlRow.WARE_ID = wareRow.WARE_ID
                                ioDtlRow.CUSTOM_CODE = wareRow.CUSTOM_CODE
                                ioDtlRow.WARE_NAME = wareRow.WARE_NAME
                                ioDtlRow.SPEC = wareRow.SPEC
                                ioDtlRow.MODEL = wareRow.MODEL
                                ioDtlRow.WARE_NAME_EN = wareRow.WARE_NAME_EN
                                ioDtlRow.SPEC_EN = wareRow.SPEC_EN
                                ioDtlRow.MODEL_EN = wareRow.MODEL_EN
                                ioDtlRow.ATTRIBUTE1 = wareRow.ATTRIBUTE1
                                ioDtlRow.ATTRIBUTE2 = wareRow.ATTRIBUTE2
                                ioDtlRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                                ioDtlRow.ATTRIBUTE4 = wareRow.ATTRIBUTE4
                            End If

                        Next


                End Select

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
        Private Function DoRemove() As String


            Try

                Me._manifest.SVFR_SELECTING_IO_DTL_ROW.Delete()



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
                    Me._manifest.LookUpEdit_Pos.EditValue)

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

                If IO.File.Exists(Me._manifest.SV_EXPORT_EXCEL_FILENAME) = True Then
                    IO.File.Delete(Me._manifest.SV_EXPORT_EXCEL_FILENAME)
                End If

                Dim toExcel As New Utils.ExcelTK(Me._manifest.SV_EXPORT_EXCEL_FILENAME)

                toExcel.MergeCell(1, 1, 1, 14)
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
                toExcel.SetCellText(1, 1, CommTK.GetTranslatedString("储位货品明细"), cellFont, Color.Black, Color.White)

                cellFont = New Font("Arial", 10, FontStyle.Bold)
                toExcel.SetCellText(3, 1, CommTK.GetTranslatedString("地点名称:"), cellFont, Color.Black, Color.White)
                toExcel.MergeCell(3, 2, 3, 14)
                toExcel.SetCellText(3, 2, Me._manifest.LookUpEdit_Pos.Text, cellFont, Color.Black, Color.White)

                toExcel.SetCellText(4, 1, CommTK.GetTranslatedString("储位信息:"), cellFont, Color.Black, Color.White)
                toExcel.MergeCell(4, 2, 4, 14)
                toExcel.SetCellText(4, 2, Me._manifest.Label_StoringPlaceInfo.Text, cellFont, Color.Black, Color.White)

                cellFont = New Font("Arial", 12, FontStyle.Bold)
                toExcel.SetCellText(7, 1, CommTK.GetTranslatedString("序号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 2, CommTK.GetTranslatedString("货品类别"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 3, CommTK.GetTranslatedString("货品代码"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 4, CommTK.GetTranslatedString("自定货号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 5, CommTK.GetTranslatedString("货品名称"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 6, CommTK.GetTranslatedString("货品规格"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 7, CommTK.GetTranslatedString("货品型号"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 8, sysAttribute1, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 9, sysAttribute2, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 10, sysAttribute3, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 11, sysAttribute4, cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 12, CommTK.GetTranslatedString("储位货品数量"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 13, CommTK.GetTranslatedString("备注"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(7, 14, CommTK.GetTranslatedString("单位名称"), cellFont, Color.Black, Color.White)

                Dim rowCounter As Integer = 8
                Dim counter As Integer = 1
                Dim totalStockAmount As Double = 0

                XL.Win.Window.XLProgressBox.SetProgressRange(Me._manifest.SVFT_BINDING_LOCATION_STOCK_LIST.Count + rowCounter, 400, False)

                cellFont = New Font("Arial", 10, FontStyle.Regular)

                For Each bindingRow As MyPosXAuto.FTs.FT_MV_MP_POS_LOCATION_STOCK_AMOUNTRow In Me._manifest.SVFT_BINDING_LOCATION_STOCK_LIST

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
                    toExcel.SetCellText(rowCounter, 12, CommTK.FString(bindingRow.LOCATION_STOCK_AMOUNT), cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 13, bindingRow.REMARK, cellFont, Color.Black, Color.White)
                    toExcel.SetCellText(rowCounter, 14, bindingRow.UNIT_NAME, cellFont, Color.Black, Color.White)

                    rowCounter += 1
                    counter += 1

                    totalStockAmount = totalStockAmount + bindingRow.LOCATION_STOCK_AMOUNT

                    XL.Win.Window.XLProgressBox.DisplayProgress(MyPosXService.Decls.MSG_PROGRESS_0001, rowCounter, bindingRow.WARE_NAME)

                Next

                XL.Win.Window.XLProgressBox.CloseXLProgressBox()

                toExcel.SetFrameLine(7, 1, rowCounter - 1, 14, ExcelTK.BorderPart.Bottom Or ExcelTK.BorderPart.Horizonal, Color.Black, , Excel.XlBorderWeight.xlHairline)
                toExcel.SetFrameLine(6, 1, rowCounter - 1, 14, ExcelTK.BorderPart.Top Or ExcelTK.BorderPart.Bottom, Color.Black, , Excel.XlBorderWeight.xlThick)

                cellFont = New Font("Arial", 12, FontStyle.Bold)

                toExcel.SetCellText(rowCounter, 1, CommTK.GetTranslatedString("总计"), cellFont, Color.Black, Color.White)
                toExcel.SetCellText(rowCounter, 12, CommTK.FString(totalStockAmount), cellFont, Color.Black, Color.White)

                cellFont = New Font("Arial", 10, FontStyle.Bold)

                If staffRowSE.IsNull = False Then
                    toExcel.SetCellText(rowCounter + 2, 14, staffRowSE.STAFF_NAME, cellFont, Color.Black, Color.White)
                End If

                If CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE)) = 1 Then
                    toExcel.SetCellText(rowCounter + 3, 14, CommTK.FString(CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White, "[$-409]yyyy-mmm-dd;@")
                Else
                    toExcel.SetCellText(rowCounter + 3, 14, String.Format("{0:yyyy-MM-dd}", CommTK.GetSyncServerTime), cellFont, Color.Black, Color.White)
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
        Private Function DoValidateAmountAvailable() As String


            Try

                Dim availableAmount As Double
                Dim result As String = String.Empty
                Me._manifest.GridColumn_RowRemark.Visible = False
                Me._manifest.SVFT_BINDING_IO_DTL_LIST.ResetRowHighlighting()

                Dim bindingCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_POS_LOCATION_IO_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
                If CommTK.FInteger(Me._manifest.LookUpEdit_IOType.EditValue) = MyPosXAuto.Decls.CIVALUE_IO_TYPE_IN Then

                    Dim shelfDifferenceList As New MyPosXAuto.FTs.FT_MV_MP_POS_SHELF_STOCK_DIFFERENCE
                    Dim shelfDifferenceConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_POS_SHELF_STOCK_DIFFERENCE(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                    shelfDifferenceConditions.Add(AfMV.MV_MP_POS_SHELF_STOCK_DIFFERENCEColumns.POS_IDColumn, "=", Me._manifest.LookUpEdit_Pos.EditValue)
                    MyPosXAuto.Facade.AfMV.FillFT_MV_MP_POS_SHELF_STOCK_DIFFERENCE(shelfDifferenceConditions, shelfDifferenceList)

                    Dim shelfDifferenceRow As MyPosXAuto.FTs.FT_MV_MP_POS_SHELF_STOCK_DIFFERENCERow


                    For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_POS_LOCATION_IO_DTLRow In Me._manifest.SVFT_BINDING_IO_DTL_LIST.FindRowsByCondition(bindingCondition)

                        shelfDifferenceConditions.Clear()
                        shelfDifferenceConditions.Add(AfMV.MV_MP_POS_SHELF_STOCK_DIFFERENCEColumns.WARE_IDColumn, "=", bindingRow.WARE_ID)

                        shelfDifferenceRow = shelfDifferenceList.FindRowByCondition(shelfDifferenceConditions)
                        availableAmount = 0
                        If IsNothing(shelfDifferenceRow) = False AndAlso shelfDifferenceRow.DIFFERENCE_AMOUNT > 0 Then
                            availableAmount = shelfDifferenceRow.DIFFERENCE_AMOUNT
                        End If

                        If bindingRow.IO_AMOUNT > availableAmount Then
                            bindingRow.ROW_REMARK = CommTK.GetTranslatedString(MyPosXService.Decls.ROW_REMARK_0001, CommTK.FString(availableAmount))
                            bindingRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_OUT_OF_STOCK
                            result = MyPosXService.Decls.MSG_ALERT_00007
                            Me._manifest.GridColumn_RowRemark.Visible = True
                        End If

                    Next
                Else

                    Dim locationStockList As New MyPosXAuto.FTs.FT_MV_MP_POS_LOCATION_STOCK_AMOUNT
                    Dim locationStockCondition As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_POS_LOCATION_STOCK_AMOUNT(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                    locationStockCondition.Add(AfMV.MV_MP_POS_LOCATION_STOCK_AMOUNTColumns.LOCATION_IDColumn, "=", Me._manifest.Label_LocationID.Text)
                    MyPosXAuto.Facade.AfMV.FillFT_MV_MP_POS_LOCATION_STOCK_AMOUNT(locationStockCondition, locationStockList)

                    Dim locationStockRow As MyPosXAuto.FTs.FT_MV_MP_POS_LOCATION_STOCK_AMOUNTRow
                    For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_POS_LOCATION_IO_DTLRow In Me._manifest.SVFT_BINDING_IO_DTL_LIST.FindRowsByCondition(bindingCondition)

                        locationStockCondition.Clear()
                        locationStockCondition.Add(AfMV.MV_MP_POS_LOCATION_STOCK_AMOUNTColumns.WARE_IDColumn, "=", bindingRow.WARE_ID)

                        availableAmount = 0
                        locationStockRow = locationStockList.FindRowByCondition(locationStockCondition)

                        If IsNothing(locationStockRow) = False Then
                            availableAmount = locationStockRow.LOCATION_STOCK_AMOUNT
                        End If

                        If bindingRow.IO_AMOUNT > availableAmount Then
                            bindingRow.ROW_REMARK = CommTK.GetTranslatedString(MyPosXService.Decls.ROW_REMARK_0001, CommTK.FString(availableAmount))
                            bindingRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_OUT_OF_STOCK
                            result = MyPosXService.Decls.MSG_ALERT_00007
                            Me._manifest.GridColumn_RowRemark.Visible = True
                        End If

                    Next
                End If


                Return result



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
        Private Function DoLoadLocationInfoByCode() As String


            Try


                Dim locationID As String
                Me._service.ServLoadLocationInfoByCode( _
                    Me._manifest.ButtonEdit_LocationCode.Text, _
                    locationID)

                If locationID.Length <= 0 Then
                    Return MyPosXService.Decls.MSG_ALERT_00046
                End If

                Me._manifest.Label_LocationID.Text = CommTK.FString(locationID)
                Me._manifest.InvokeBizRequest(Affairs.LoadLocationInfoByID, False)

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
