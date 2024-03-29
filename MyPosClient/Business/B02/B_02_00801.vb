Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils

Namespace Business


    Public Class B_02_00801  
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
        Private _manifest As Manifest.M_02_00801     
        Private _service As MyPosXService.S_02_00801

        Public Enum Affairs
            InitDisplay
            LoadTurnoverInfoByCode
            ImportFromMobile
            AddPractWareByCode
            LoadPractWareList
            BizUtld0004
            SaveInfo
            AddPractWareByCodes
            PrintLabel
            UpdatePractWareRow
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

            Me._manifest = CType(theManifest, Manifest.M_02_00801)
            Try

                Me._service = MyPosXService.S_02_00801.GetInstance()

            Catch ex As Exception

                If ex.Message = CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE AndAlso _
                    CommDecl.SYSTEM_SHOULD_BE_ONLINE = False AndAlso _
                        Window.XLMessageBox.ShowMessage( _
                            "Remoting connection fail, switch into offline mode?", _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    CommDecl.SYSTEM_IS_ONLINE = False
                    Me._service = MyPosXService.S_02_00801.GetInstance()
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

                Case Affairs.LoadTurnoverInfoByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadTurnoverInfoByCode)

                Case Affairs.ImportFromMobile

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoImportFromMobile)

                Case Affairs.AddPractWareByCode

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoAddPractWareByCode)

                Case Affairs.LoadPractWareList

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoLoadPractWareList)

                Case Affairs.BizUtld0004

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoBizUtld0004)

                Case Affairs.SaveInfo

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoSaveInfo)

                Case Affairs.AddPractWareByCodes

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoAddPractWareByCodes)

                Case Affairs.PrintLabel

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoPrintLabel)

                Case Affairs.UpdatePractWareRow

                    '
                    '取到处理函数的结果，传入返回给Manifest的AgentResponse包
                    '-------------------------------------------------------------------
                    functionHandle = New XL.Win.StringFunctionTransaction(AddressOf Me.DoUpdatePractWareRow)

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
                Dim sysAttribute1 As String = String.Empty
                Dim sysAttribute2 As String = String.Empty
                Dim sysAttribute3 As String = String.Empty
                Dim sysAttribute4 As String = String.Empty

                Dim turnoverBookStatusList As New MyPosXAuto.FTs.FT_CIV_TURNOVER_BOOK_STATUS

                Me._service.ServInitDisplay( _
                    CommDecl.CURRENT_LANGUAGE_OPTION, _
                    sysWareSpecModelDiscard, _
                    sysHideFinancials, _
                    sysShowCustomWareCode, _
                    sysAttribute1, _
                    sysAttribute2, _
                    sysAttribute3, _
                    sysAttribute4, _
                    turnoverBookStatusList)

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

                Me._manifest.RepositoryItemLookUpEdit_TurnoverBookStatus.DataSource = turnoverBookStatusList

                If sysShowCustomWareCode = False Then
                    Me._manifest.GridColumn_CustomCode.Visible = False
                End If

                Dim userCostHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_COST_HIDDEN"))
                Dim userPriceHidden As Boolean = CommTK.FBoolean(SysInfo.LoginUserOptions.Options("OPN_PRICE_HIDDEN"))





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
        Private Function DoLoadTurnoverInfoByCode() As String


            Try

                If Me._manifest.TextEdit_TurnoverCode.Text.Length <= 0 Then
                    Return String.Empty
                End If


                Dim servResult As String = _
                    Me._service.ServLoadTurnoverInfoByCode( _
                        Me._manifest.SV_EDITING_TURNOVER_CODE, _
                        Me._manifest.SV_TURNOVER_ROW_SE, _
                        Me._manifest.SVFT_BINDING_PRACT_WARE_LIST)

                If servResult.Length > 0 Then
                    Return servResult
                End If

                Me._manifest.Label_TurnoverInfo.Text = String.Format("出入类型:{0} 出入形式:{1} 当前地点:{2}", Me._manifest.SV_TURNOVER_ROW_SE.TURNOVER_TYPE_TEXT, Me._manifest.SV_TURNOVER_ROW_SE.TURNOVER_STYLE_TEXT, Me._manifest.SV_TURNOVER_ROW_SE.POS_NAME)
                Me._manifest.Label_TurnoverID.Text = CommTK.FString(Me._manifest.SV_TURNOVER_ROW_SE.TURNOVER_ID)

                If Me._manifest.SV_TURNOVER_ROW_SE.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_OUT Then
                    Me._manifest.LinkLabel_NewPractWare.Visible = False
                Else
                    Me._manifest.LinkLabel_NewPractWare.Visible = True
                End If

                Me._manifest.GridControl_PratcWare.DataSource = Me._manifest.SVFT_BINDING_PRACT_WARE_LIST

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


                Dim readPractDtlList As New MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARE
                Dim practDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARERow
                Dim practDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL_PRACT_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)

                Select Case CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_COLLECTOR_DEVICE_TYPE))


                    Case CommDecl.MOBILE_DEVICE_TYPE_CPT

                        Dim readLines As ArrayList = BarCodeKit.ReadCPT80Data()
                        If IsNothing(readLines) = True Then
                            Return MyPosXService.Decls.MSG_ALERT_00008
                        End If

                        Dim practBarcode As String


                        For Each lineData As ArrayList In readLines

                            practBarcode = CommTK.FString(lineData(0))
                            practDtlConditions.Clear()
                            practDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTL_PRACT_WAREColumns.PRACT_BARCODEColumn, "=", practBarcode)

                            practDtlRow = readPractDtlList.FindRowByCondition(practDtlConditions)

                            If IsNothing(practDtlRow) = True Then
                                practDtlRow = readPractDtlList.NewXV_H_MP_TURNOVER_DTL_PRACT_WARERow
                                readPractDtlList.AddXV_H_MP_TURNOVER_DTL_PRACT_WARERow(practDtlRow)
                                practDtlRow.PRACT_BARCODE = practBarcode
                            End If

                        Next


                    Case CommDecl.MOBILE_DEVICE_TYPE_WINCE

                        If BarCodeKit.ReadWinCETable(IO.Path.Combine( _
                                SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_MOBILE_SWAP_PATH), _
                                MyPosXService.Decls.CTBN_PRACT_WARE_DTL_LIST), _
                            CType(readPractDtlList, DataTable)) = False Then

                            Return String.Empty

                        End If

                End Select


                Dim servResult As String = _
                    Me._service.ServImportFromMobile( _
                        Me._manifest.SV_TURNOVER_ROW_SE, _
                        readPractDtlList, _
                        Me._manifest.SVFT_BINDING_PRACT_WARE_LIST)

                Me._manifest.GridControl_PratcWare.DataSource = Me._manifest.SVFT_BINDING_PRACT_WARE_LIST

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
        Private Function DoAddPractWareByCode() As String


            Try

                'Dim practWareRowSE As New MyPosXAuto.FTs.FT_XV_T_MP_PRACT_WARERowSEntity
                Dim practWareRowSE As New MyPosXAuto.FTs.FT_XV_T_MP_PRACT_WARERowSEntity
                Dim servResult As String

                servResult = _
                    Me._service.ServAddPractWareByCode( _
                         Me._manifest.TextEdit_PractWareCode.Text, _
                         practWareRowSE)

                'Dim servResult As String = _
                '    Me._service.ServAddPractWareByCode()

                If servResult.Length > 0 Then
                    Return servResult
                End If

                '如果货品已添加
                For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARERow In Me._manifest.SVFT_BINDING_PRACT_WARE_LIST
                    If bindingRow.PRACT_BARCODE = practWareRowSE.PRACT_BARCODE AndAlso bindingRow.RowState <> DataRowState.Deleted Then
                        Return MyPosXService.Decls.MSG_ALERT_00005
                    End If
                Next

                '货品未添加
                Dim addPractWareRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARERow
                addPractWareRow = Me._manifest.SVFT_BINDING_PRACT_WARE_LIST.NewXV_H_MP_TURNOVER_DTL_PRACT_WARERow
                Me._manifest.SVFT_BINDING_PRACT_WARE_LIST.AddXV_H_MP_TURNOVER_DTL_PRACT_WARERow(addPractWareRow)

                addPractWareRow.PRACT_BARCODE = practWareRowSE.PRACT_BARCODE
                addPractWareRow.PRACT_CODE_REQUIRED = practWareRowSE.PRACT_CODE_REQUIRED
                addPractWareRow.PARENT_ID = practWareRowSE.PARENT_ID
                addPractWareRow.MODEL = practWareRowSE.MODEL
                addPractWareRow.MODEL_EN = practWareRowSE.MODEL_EN
                addPractWareRow.ATTRIBUTE1 = practWareRowSE.ATTRIBUTE1
                addPractWareRow.ATTRIBUTE2 = practWareRowSE.ATTRIBUTE2
                addPractWareRow.ATTRIBUTE3 = practWareRowSE.ATTRIBUTE3
                addPractWareRow.ATTRIBUTE4 = practWareRowSE.ATTRIBUTE4
                addPractWareRow.CURRENT_POS = Utils.Decls.CURRENT_POS_ROW.POS_ID
                addPractWareRow.CUSTOM_CODE = practWareRowSE.CUSTOM_CODE
                addPractWareRow.GUARANTEE_DAYS = practWareRowSE.GUARANTEE_DAYS
                addPractWareRow.LABEL_COPIES = practWareRowSE.LABEL_COPIES
                addPractWareRow.PRACT_REMARKS = practWareRowSE.PRACT_REMARKS
                addPractWareRow.REMARK = practWareRowSE.REMARK
                addPractWareRow.SPEC = practWareRowSE.SPEC
                addPractWareRow.SPEC_EN = practWareRowSE.SPEC_EN
                addPractWareRow.H_MP_TURNOVER_TURNOVER_ID = CommTK.FString(Me._manifest.Label_TurnoverID.Text)
                addPractWareRow.UNIT_COST = practWareRowSE.UNIT_COST
                addPractWareRow.UNIT_NAME = practWareRowSE.UNIT_NAME
                addPractWareRow.UNIT_PRICE = practWareRowSE.UNIT_PRICE
                addPractWareRow.WARE_CLASSIFY_NAME = practWareRowSE.WARE_CLASSIFY_NAME
                addPractWareRow.WARE_CODE = practWareRowSE.WARE_CODE
                addPractWareRow.WARE_ID = practWareRowSE.WARE_ID
                addPractWareRow.WARE_NAME = practWareRowSE.WARE_NAME
                addPractWareRow.WARE_NAME_EN = practWareRowSE.WARE_NAME_EN


                Me._manifest.GridControl_PratcWare.DataSource = Me._manifest.SVFT_BINDING_PRACT_WARE_LIST



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
        Private Function DoLoadPractWareList() As String


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
        Private Function DoBizUtld0004() As String


            Try

                'Me._service.ServBizUtld0004( _
                '    CommTK.FInteger(Me._manifest.Label_TurnoverID.Text), _
                '    Me._manifest.SVFT_BINDING_PRACT_WARE_LIST)





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

                Me._service.ServSaveInfo( _
                    Me._manifest.Label_TurnoverID.Text, _
                    Me._manifest.SVFT_BINDING_PRACT_WARE_LIST)



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
        Private Function DoAddPractWareByCodes() As String


            Try

                If Me._manifest.SV_PRACT_BARCODES.Count > 0 Then

                    For Each barcode As String In Me._manifest.SV_PRACT_BARCODES
                        Me._manifest.TextEdit_PractWareCode.Text = barcode
                        Me.DoAddPractWareByCode()
                    Next

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
        Private Function DoPrintLabel() As String


            Try
                Dim barCodeGenerateFile As New LineStrBuilder

                For Each row As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARERow In Me._manifest.SVFT_BINDING_PRACT_WARE_LIST
                    barCodeGenerateFile.AppendLine(row.PRACT_BARCODE)
                Next

                CommTK.WriteTextToFile( _
                    IO.Path.Combine(SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_MOBILE_SWAP_PATH), "PRACT_BARCODE_LABELS.TXT"), _
                    barCodeGenerateFile.ToString, _
                    False, _
                    CommTK.GetTranslatedString("实际货品条码"), _
                    System.Text.Encoding.Default.WebName)

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
        Private Function DoUpdatePractWareRow() As String


            Try

                Dim practWareRowSE As New MyPosXAuto.FTs.FT_XV_T_MP_PRACT_WARERowSEntity
                Dim servResult As String

                servResult = _
                    Me._service.ServAddPractWareByCode( _
                         Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.PRACT_BARCODE, _
                         practWareRowSE)

                'Dim servResult As String = _
                '    Me._service.ServAddPractWareByCode()

                If servResult.Length > 0 Then
                    Return servResult
                End If

                ''如果货品已添加
                'For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARERow In Me._manifest.SVFT_BINDING_PRACT_WARE_LIST
                '    If bindingRow.PRACT_BARCODE = practWareRowSE.PRACT_BARCODE AndAlso bindingRow.RowState <> DataRowState.Deleted Then
                '        Return MyPosXService.Decls.MSG_ALERT_00005
                '    End If
                'Next

                ''货品未添加
                'Dim addPractWareRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARERow
                'addPractWareRow = Me._manifest.SVFT_BINDING_PRACT_WARE_LIST.NewXV_H_MP_TURNOVER_DTL_PRACT_WARERow
                'Me._manifest.SVFT_BINDING_PRACT_WARE_LIST.AddXV_H_MP_TURNOVER_DTL_PRACT_WARERow(addPractWareRow)

                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.PRACT_BARCODE = practWareRowSE.PRACT_BARCODE
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.PRACT_CODE_REQUIRED = practWareRowSE.PRACT_CODE_REQUIRED
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.PARENT_ID = practWareRowSE.PARENT_ID
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.MODEL = practWareRowSE.MODEL
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.MODEL_EN = practWareRowSE.MODEL_EN
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.ATTRIBUTE1 = practWareRowSE.ATTRIBUTE1
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.ATTRIBUTE2 = practWareRowSE.ATTRIBUTE2
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.ATTRIBUTE3 = practWareRowSE.ATTRIBUTE3
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.ATTRIBUTE4 = practWareRowSE.ATTRIBUTE4
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.CURRENT_POS = practWareRowSE.CURRENT_POS
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.CUSTOM_CODE = practWareRowSE.CUSTOM_CODE
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.GUARANTEE_DAYS = practWareRowSE.GUARANTEE_DAYS
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.LABEL_COPIES = practWareRowSE.LABEL_COPIES
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.PRACT_REMARKS = practWareRowSE.PRACT_REMARKS
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.REMARK = practWareRowSE.REMARK
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.SPEC = practWareRowSE.SPEC
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.SPEC_EN = practWareRowSE.SPEC_EN
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.TURNOVER_ID = practWareRowSE.TURNOVER_ID
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.UNIT_COST = practWareRowSE.UNIT_COST
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.UNIT_NAME = practWareRowSE.UNIT_NAME
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.UNIT_PRICE = practWareRowSE.UNIT_PRICE
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.WARE_CLASSIFY_NAME = practWareRowSE.WARE_CLASSIFY_NAME
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.WARE_CODE = practWareRowSE.WARE_CODE
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.WARE_ID = practWareRowSE.WARE_ID
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.WARE_NAME = practWareRowSE.WARE_NAME
                Me._manifest.SVFR_SELECTING_PRACT_WARE_ROW.WARE_NAME_EN = practWareRowSE.WARE_NAME_EN


                Me._manifest.GridControl_PratcWare.DataSource = Me._manifest.SVFT_BINDING_PRACT_WARE_LIST



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
