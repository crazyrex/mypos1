Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00101
        'Inherits System.Windows.Forms.UserControl
        Inherits XL.Win.Component.BaseForm

#Region" Windows 窗体设计器生成的代码"

        Public Sub New()
            MyBase.New()

            '该调用是 Windows 窗体设计器所必需的。
            InitializeComponent()

            '在 InitializeComponent() 调用之后添加任何初始化

        End Sub

        '窗体重写 dispose 以清理组件列表。
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Windows 窗体设计器所必需的
        Private components As System.ComponentModel.IContainer

        '注意: 以下过程是 Windows 窗体设计器所必需的
        '可以使用 Windows 窗体设计器修改此过程。
        '不要使用代码编辑器修改它。
        Friend WithEvents ToolStrip_Form As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButton_Create As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Choose As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00101))
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag18 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Choose = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ConsignQuery = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_DeliveryQuery = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_PaymentQuery = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_StaffCommission = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Print = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.Panel_DateRange = New System.Windows.Forms.Panel
            Me.Label2 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.Panel_Options = New System.Windows.Forms.Panel
            Me.LookUpEdit_Pos = New DevExpress.XtraEditors.LookUpEdit
            Me.LookUpEdit_TurnoverStyle = New DevExpress.XtraEditors.LookUpEdit
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.LookUpEdit_TurnoverType = New DevExpress.XtraEditors.LookUpEdit
            Me.Label5 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_Turnover = New DevExpress.XtraGrid.GridControl
            Me.ContextMenuStrip_Grid = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItem_CopyTurnoverCode = New System.Windows.Forms.ToolStripMenuItem
            Me.GridView_Turnover = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_TurnoverCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverTime = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PosCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PosName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EmployeeName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TurnoverType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_TurnoverStyle = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TurnoverStyle = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_TurnoverConsignStatus = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_ConsignStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_BalanceStatus = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_BalanceStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_PayAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomerName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.GridColumn_RMBToPointRAte = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PointToRMBRate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PointGain = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PointUse = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            Me.Panel_DateRange.SuspendLayout()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel_Options.SuspendLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_TurnoverStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_TurnoverType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_Turnover, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStrip_Grid.SuspendLayout()
            CType(Me.GridView_Turnover, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverType, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverStyle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_ConsignStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_BalanceStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DefaultLookAndFeel_Form
            '
            Me.DefaultLookAndFeel_Form.LookAndFeel.SkinName = ""
            '
            'Timer_Surveillant
            '
            '
            'ToolStrip_Form
            '
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Choose, Me.ToolStripButton_Create, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_ConsignQuery, Me.ToolStripButton_DeliveryQuery, Me.ToolStripButton_PaymentQuery, Me.ToolStripButton_StaffCommission, Me.ToolStripButton_Refresh, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_Print, Me.ToolStripButton_Close})
            resources.ApplyResources(Me.ToolStrip_Form, "ToolStrip_Form")
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
            CTag1.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag1.CalculatorRequired = True
            CTag1.ComboValueTextBox = Nothing
            CTag1.ControlRelatedCode = Nothing
            CTag1.DateButtonTextBox = Nothing
            CTag1.DateTimeButtonTextBox = Nothing
            CTag1.DisplayLinkControl = Nothing
            CTag1.DisplayLinkDisplayFieldName = Nothing
            CTag1.DisplayLinkKeyFieldName = Nothing
            CTag1.DisplayLinkTable = Nothing
            CTag1.FlexgridEditItem = ""
            CTag1.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag1.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag1.IsButtonCustomed = False
            CTag1.IsTextValid = True
            CTag1.KeyValueAbsentable = False
            CTag1.LeagleText = ""
            CTag1.NumericButtonTextBox = Nothing
            CTag1.ParentControl = Me.ToolStrip_Form
            CTag1.SkipValidate = False
            CTag1.TimeButtonTextBox = Nothing
            CTag1.ToolTip = ""
            CTag1.ValueType = XL.Common.ControlValueType.Character
            Me.ToolStrip_Form.Tag = CTag1
            '
            'ToolStripButton_Choose
            '
            Me.ToolStripButton_Choose.Name = "ToolStripButton_Choose"
            resources.ApplyResources(Me.ToolStripButton_Choose, "ToolStripButton_Choose")
            '
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            resources.ApplyResources(Me.ToolStripButton_Create, "ToolStripButton_Create")
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            resources.ApplyResources(Me.ToolStripButton_Revise, "ToolStripButton_Revise")
            '
            'ToolStripButton_Delete
            '
            Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
            resources.ApplyResources(Me.ToolStripButton_Delete, "ToolStripButton_Delete")
            '
            'ToolStripButton_ConsignQuery
            '
            Me.ToolStripButton_ConsignQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_ConsignQuery, "ToolStripButton_ConsignQuery")
            Me.ToolStripButton_ConsignQuery.Name = "ToolStripButton_ConsignQuery"
            '
            'ToolStripButton_DeliveryQuery
            '
            Me.ToolStripButton_DeliveryQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_DeliveryQuery, "ToolStripButton_DeliveryQuery")
            Me.ToolStripButton_DeliveryQuery.Name = "ToolStripButton_DeliveryQuery"
            '
            'ToolStripButton_PaymentQuery
            '
            Me.ToolStripButton_PaymentQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_PaymentQuery, "ToolStripButton_PaymentQuery")
            Me.ToolStripButton_PaymentQuery.Name = "ToolStripButton_PaymentQuery"
            '
            'ToolStripButton_StaffCommission
            '
            Me.ToolStripButton_StaffCommission.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_StaffCommission.Name = "ToolStripButton_StaffCommission"
            resources.ApplyResources(Me.ToolStripButton_StaffCommission, "ToolStripButton_StaffCommission")
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            '
            'ToolStripButton_ExportExcel
            '
            Me.ToolStripButton_ExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_ExportExcel, "ToolStripButton_ExportExcel")
            Me.ToolStripButton_ExportExcel.Name = "ToolStripButton_ExportExcel"
            '
            'ToolStripButton_Print
            '
            Me.ToolStripButton_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_Print, "ToolStripButton_Print")
            Me.ToolStripButton_Print.Name = "ToolStripButton_Print"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            resources.ApplyResources(Me.ToolStripButton_Close, "ToolStripButton_Close")
            '
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.Controls.Add(Me.Panel_DateRange)
            Me.PanelControl_Filter.Controls.Add(Me.Panel_Options)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
            CTag16.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag16.CalculatorRequired = True
            CTag16.ComboValueTextBox = Nothing
            CTag16.ControlRelatedCode = Nothing
            CTag16.DateButtonTextBox = Nothing
            CTag16.DateTimeButtonTextBox = Nothing
            CTag16.DisplayLinkControl = Nothing
            CTag16.DisplayLinkDisplayFieldName = Nothing
            CTag16.DisplayLinkKeyFieldName = Nothing
            CTag16.DisplayLinkTable = Nothing
            CTag16.FlexgridEditItem = ""
            CTag16.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag16.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag16.IsButtonCustomed = False
            CTag16.IsTextValid = True
            CTag16.KeyValueAbsentable = False
            CTag16.LeagleText = ""
            CTag16.NumericButtonTextBox = Nothing
            CTag16.ParentControl = Me.PanelControl_Filter
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag16
            '
            'Panel_DateRange
            '
            Me.Panel_DateRange.Controls.Add(Me.Label2)
            Me.Panel_DateRange.Controls.Add(Me.DateEdit_FromDate)
            Me.Panel_DateRange.Controls.Add(Me.DateEdit_ToDate)
            Me.Panel_DateRange.Controls.Add(Me.Label3)
            resources.ApplyResources(Me.Panel_DateRange, "Panel_DateRange")
            Me.Panel_DateRange.Name = "Panel_DateRange"
            CTag6.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag6.CalculatorRequired = True
            CTag6.ComboValueTextBox = Nothing
            CTag6.ControlRelatedCode = Nothing
            CTag6.DateButtonTextBox = Nothing
            CTag6.DateTimeButtonTextBox = Nothing
            CTag6.DisplayLinkControl = Nothing
            CTag6.DisplayLinkDisplayFieldName = Nothing
            CTag6.DisplayLinkKeyFieldName = Nothing
            CTag6.DisplayLinkTable = Nothing
            CTag6.FlexgridEditItem = ""
            CTag6.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag6.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag6.IsButtonCustomed = False
            CTag6.IsTextValid = True
            CTag6.KeyValueAbsentable = False
            CTag6.LeagleText = ""
            CTag6.NumericButtonTextBox = Nothing
            CTag6.ParentControl = Me.Panel_DateRange
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Panel_DateRange.Tag = CTag6
            '
            'Label2
            '
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
            CTag2.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag2.CalculatorRequired = True
            CTag2.ComboValueTextBox = Nothing
            CTag2.ControlRelatedCode = Nothing
            CTag2.DateButtonTextBox = Nothing
            CTag2.DateTimeButtonTextBox = Nothing
            CTag2.DisplayLinkControl = Nothing
            CTag2.DisplayLinkDisplayFieldName = Nothing
            CTag2.DisplayLinkKeyFieldName = Nothing
            CTag2.DisplayLinkTable = Nothing
            CTag2.FlexgridEditItem = ""
            CTag2.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag2.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag2.IsButtonCustomed = False
            CTag2.IsTextValid = True
            CTag2.KeyValueAbsentable = False
            CTag2.LeagleText = ""
            CTag2.NumericButtonTextBox = Nothing
            CTag2.ParentControl = Me.Label2
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag2
            '
            'DateEdit_FromDate
            '
            Me.DateEdit_FromDate.EditValue = Nothing
            resources.ApplyResources(Me.DateEdit_FromDate, "DateEdit_FromDate")
            Me.DateEdit_FromDate.Name = "DateEdit_FromDate"
            Me.DateEdit_FromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_FromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            CTag3.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag3.CalculatorRequired = True
            CTag3.ComboValueTextBox = Nothing
            CTag3.ControlRelatedCode = Nothing
            CTag3.DateButtonTextBox = Nothing
            CTag3.DateTimeButtonTextBox = Nothing
            CTag3.DisplayLinkControl = Nothing
            CTag3.DisplayLinkDisplayFieldName = Nothing
            CTag3.DisplayLinkKeyFieldName = Nothing
            CTag3.DisplayLinkTable = Nothing
            CTag3.FlexgridEditItem = ""
            CTag3.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag3.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag3.IsButtonCustomed = False
            CTag3.IsTextValid = True
            CTag3.KeyValueAbsentable = False
            CTag3.LeagleText = ""
            CTag3.NumericButtonTextBox = Nothing
            CTag3.ParentControl = Me.DateEdit_FromDate
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_FromDate.Tag = CTag3
            '
            'DateEdit_ToDate
            '
            Me.DateEdit_ToDate.EditValue = Nothing
            resources.ApplyResources(Me.DateEdit_ToDate, "DateEdit_ToDate")
            Me.DateEdit_ToDate.Name = "DateEdit_ToDate"
            Me.DateEdit_ToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_ToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            CTag4.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag4.CalculatorRequired = True
            CTag4.ComboValueTextBox = Nothing
            CTag4.ControlRelatedCode = Nothing
            CTag4.DateButtonTextBox = Nothing
            CTag4.DateTimeButtonTextBox = Nothing
            CTag4.DisplayLinkControl = Nothing
            CTag4.DisplayLinkDisplayFieldName = Nothing
            CTag4.DisplayLinkKeyFieldName = Nothing
            CTag4.DisplayLinkTable = Nothing
            CTag4.FlexgridEditItem = ""
            CTag4.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag4.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag4.IsButtonCustomed = False
            CTag4.IsTextValid = True
            CTag4.KeyValueAbsentable = False
            CTag4.LeagleText = ""
            CTag4.NumericButtonTextBox = Nothing
            CTag4.ParentControl = Me.DateEdit_ToDate
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_ToDate.Tag = CTag4
            '
            'Label3
            '
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
            CTag5.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag5.CalculatorRequired = True
            CTag5.ComboValueTextBox = Nothing
            CTag5.ControlRelatedCode = Nothing
            CTag5.DateButtonTextBox = Nothing
            CTag5.DateTimeButtonTextBox = Nothing
            CTag5.DisplayLinkControl = Nothing
            CTag5.DisplayLinkDisplayFieldName = Nothing
            CTag5.DisplayLinkKeyFieldName = Nothing
            CTag5.DisplayLinkTable = Nothing
            CTag5.FlexgridEditItem = ""
            CTag5.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag5.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag5.IsButtonCustomed = False
            CTag5.IsTextValid = True
            CTag5.KeyValueAbsentable = False
            CTag5.LeagleText = ""
            CTag5.NumericButtonTextBox = Nothing
            CTag5.ParentControl = Me.Label3
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag5
            '
            'Panel_Options
            '
            Me.Panel_Options.Controls.Add(Me.LookUpEdit_Pos)
            Me.Panel_Options.Controls.Add(Me.LookUpEdit_TurnoverStyle)
            Me.Panel_Options.Controls.Add(Me.Label4)
            Me.Panel_Options.Controls.Add(Me.Label6)
            Me.Panel_Options.Controls.Add(Me.LookUpEdit_TurnoverType)
            Me.Panel_Options.Controls.Add(Me.Label5)
            resources.ApplyResources(Me.Panel_Options, "Panel_Options")
            Me.Panel_Options.Name = "Panel_Options"
            CTag13.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag13.CalculatorRequired = True
            CTag13.ComboValueTextBox = Nothing
            CTag13.ControlRelatedCode = Nothing
            CTag13.DateButtonTextBox = Nothing
            CTag13.DateTimeButtonTextBox = Nothing
            CTag13.DisplayLinkControl = Nothing
            CTag13.DisplayLinkDisplayFieldName = Nothing
            CTag13.DisplayLinkKeyFieldName = Nothing
            CTag13.DisplayLinkTable = Nothing
            CTag13.FlexgridEditItem = ""
            CTag13.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag13.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag13.IsButtonCustomed = False
            CTag13.IsTextValid = True
            CTag13.KeyValueAbsentable = False
            CTag13.LeagleText = ""
            CTag13.NumericButtonTextBox = Nothing
            CTag13.ParentControl = Me.Panel_Options
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.Panel_Options.Tag = CTag13
            '
            'LookUpEdit_Pos
            '
            resources.ApplyResources(Me.LookUpEdit_Pos, "LookUpEdit_Pos")
            Me.LookUpEdit_Pos.Name = "LookUpEdit_Pos"
            Me.LookUpEdit_Pos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_Pos.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_Pos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Pos.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_Pos.Properties.ValueMember = "POS_ID"
            CTag7.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag7.CalculatorRequired = True
            CTag7.ComboValueTextBox = Nothing
            CTag7.ControlRelatedCode = Nothing
            CTag7.DateButtonTextBox = Nothing
            CTag7.DateTimeButtonTextBox = Nothing
            CTag7.DisplayLinkControl = Nothing
            CTag7.DisplayLinkDisplayFieldName = Nothing
            CTag7.DisplayLinkKeyFieldName = Nothing
            CTag7.DisplayLinkTable = Nothing
            CTag7.FlexgridEditItem = ""
            CTag7.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag7.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag7.IsButtonCustomed = False
            CTag7.IsTextValid = True
            CTag7.KeyValueAbsentable = False
            CTag7.LeagleText = ""
            CTag7.NumericButtonTextBox = Nothing
            CTag7.ParentControl = Me.LookUpEdit_Pos
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_Pos.Tag = CTag7
            '
            'LookUpEdit_TurnoverStyle
            '
            resources.ApplyResources(Me.LookUpEdit_TurnoverStyle, "LookUpEdit_TurnoverStyle")
            Me.LookUpEdit_TurnoverStyle.Name = "LookUpEdit_TurnoverStyle"
            Me.LookUpEdit_TurnoverStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_TurnoverStyle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_TurnoverStyle.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_TurnoverStyle.Properties.ValueMember = "ITEM_VALUE"
            CTag8.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag8.CalculatorRequired = True
            CTag8.ComboValueTextBox = Nothing
            CTag8.ControlRelatedCode = Nothing
            CTag8.DateButtonTextBox = Nothing
            CTag8.DateTimeButtonTextBox = Nothing
            CTag8.DisplayLinkControl = Nothing
            CTag8.DisplayLinkDisplayFieldName = Nothing
            CTag8.DisplayLinkKeyFieldName = Nothing
            CTag8.DisplayLinkTable = Nothing
            CTag8.FlexgridEditItem = ""
            CTag8.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag8.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag8.IsButtonCustomed = False
            CTag8.IsTextValid = True
            CTag8.KeyValueAbsentable = False
            CTag8.LeagleText = ""
            CTag8.NumericButtonTextBox = Nothing
            CTag8.ParentControl = Me.LookUpEdit_TurnoverStyle
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_TurnoverStyle.Tag = CTag8
            '
            'Label4
            '
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.BackColor = System.Drawing.Color.White
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Name = "Label4"
            CTag9.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag9.CalculatorRequired = True
            CTag9.ComboValueTextBox = Nothing
            CTag9.ControlRelatedCode = Nothing
            CTag9.DateButtonTextBox = Nothing
            CTag9.DateTimeButtonTextBox = Nothing
            CTag9.DisplayLinkControl = Nothing
            CTag9.DisplayLinkDisplayFieldName = Nothing
            CTag9.DisplayLinkKeyFieldName = Nothing
            CTag9.DisplayLinkTable = Nothing
            CTag9.FlexgridEditItem = ""
            CTag9.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag9.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag9.IsButtonCustomed = False
            CTag9.IsTextValid = True
            CTag9.KeyValueAbsentable = False
            CTag9.LeagleText = ""
            CTag9.NumericButtonTextBox = Nothing
            CTag9.ParentControl = Me.Label4
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag9
            '
            'Label6
            '
            resources.ApplyResources(Me.Label6, "Label6")
            Me.Label6.BackColor = System.Drawing.Color.White
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.Name = "Label6"
            CTag10.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag10.CalculatorRequired = True
            CTag10.ComboValueTextBox = Nothing
            CTag10.ControlRelatedCode = Nothing
            CTag10.DateButtonTextBox = Nothing
            CTag10.DateTimeButtonTextBox = Nothing
            CTag10.DisplayLinkControl = Nothing
            CTag10.DisplayLinkDisplayFieldName = Nothing
            CTag10.DisplayLinkKeyFieldName = Nothing
            CTag10.DisplayLinkTable = Nothing
            CTag10.FlexgridEditItem = ""
            CTag10.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag10.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag10.IsButtonCustomed = False
            CTag10.IsTextValid = True
            CTag10.KeyValueAbsentable = False
            CTag10.LeagleText = ""
            CTag10.NumericButtonTextBox = Nothing
            CTag10.ParentControl = Me.Label6
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Label6.Tag = CTag10
            '
            'LookUpEdit_TurnoverType
            '
            resources.ApplyResources(Me.LookUpEdit_TurnoverType, "LookUpEdit_TurnoverType")
            Me.LookUpEdit_TurnoverType.Name = "LookUpEdit_TurnoverType"
            Me.LookUpEdit_TurnoverType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_TurnoverType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_TurnoverType.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_TurnoverType.Properties.ValueMember = "ITEM_VALUE"
            CTag11.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag11.CalculatorRequired = True
            CTag11.ComboValueTextBox = Nothing
            CTag11.ControlRelatedCode = Nothing
            CTag11.DateButtonTextBox = Nothing
            CTag11.DateTimeButtonTextBox = Nothing
            CTag11.DisplayLinkControl = Nothing
            CTag11.DisplayLinkDisplayFieldName = Nothing
            CTag11.DisplayLinkKeyFieldName = Nothing
            CTag11.DisplayLinkTable = Nothing
            CTag11.FlexgridEditItem = ""
            CTag11.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag11.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag11.IsButtonCustomed = False
            CTag11.IsTextValid = True
            CTag11.KeyValueAbsentable = False
            CTag11.LeagleText = ""
            CTag11.NumericButtonTextBox = Nothing
            CTag11.ParentControl = Me.LookUpEdit_TurnoverType
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_TurnoverType.Tag = CTag11
            '
            'Label5
            '
            resources.ApplyResources(Me.Label5, "Label5")
            Me.Label5.BackColor = System.Drawing.Color.White
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.Name = "Label5"
            CTag12.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag12.CalculatorRequired = True
            CTag12.ComboValueTextBox = Nothing
            CTag12.ControlRelatedCode = Nothing
            CTag12.DateButtonTextBox = Nothing
            CTag12.DateTimeButtonTextBox = Nothing
            CTag12.DisplayLinkControl = Nothing
            CTag12.DisplayLinkDisplayFieldName = Nothing
            CTag12.DisplayLinkKeyFieldName = Nothing
            CTag12.DisplayLinkTable = Nothing
            CTag12.FlexgridEditItem = ""
            CTag12.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag12.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag12.IsButtonCustomed = False
            CTag12.IsTextValid = True
            CTag12.KeyValueAbsentable = False
            CTag12.LeagleText = ""
            CTag12.NumericButtonTextBox = Nothing
            CTag12.ParentControl = Me.Label5
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Label5.Tag = CTag12
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.Name = "TextEdit_Search"
            CTag14.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag14.CalculatorRequired = True
            CTag14.ComboValueTextBox = Nothing
            CTag14.ControlRelatedCode = Nothing
            CTag14.DateButtonTextBox = Nothing
            CTag14.DateTimeButtonTextBox = Nothing
            CTag14.DisplayLinkControl = Nothing
            CTag14.DisplayLinkDisplayFieldName = Nothing
            CTag14.DisplayLinkKeyFieldName = Nothing
            CTag14.DisplayLinkTable = Nothing
            CTag14.FlexgridEditItem = ""
            CTag14.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag14.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag14.IsButtonCustomed = False
            CTag14.IsTextValid = True
            CTag14.KeyValueAbsentable = False
            CTag14.LeagleText = ""
            CTag14.NumericButtonTextBox = Nothing
            CTag14.ParentControl = Me.TextEdit_Search
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag14
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
            CTag15.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag15.CalculatorRequired = True
            CTag15.ComboValueTextBox = Nothing
            CTag15.ControlRelatedCode = Nothing
            CTag15.DateButtonTextBox = Nothing
            CTag15.DateTimeButtonTextBox = Nothing
            CTag15.DisplayLinkControl = Nothing
            CTag15.DisplayLinkDisplayFieldName = Nothing
            CTag15.DisplayLinkKeyFieldName = Nothing
            CTag15.DisplayLinkTable = Nothing
            CTag15.FlexgridEditItem = ""
            CTag15.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag15.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag15.IsButtonCustomed = False
            CTag15.IsTextValid = True
            CTag15.KeyValueAbsentable = False
            CTag15.LeagleText = ""
            CTag15.NumericButtonTextBox = Nothing
            CTag15.ParentControl = Me.Label1
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag15
            '
            'GridControl_Turnover
            '
            Me.GridControl_Turnover.ContextMenuStrip = Me.ContextMenuStrip_Grid
            resources.ApplyResources(Me.GridControl_Turnover, "GridControl_Turnover")
            Me.GridControl_Turnover.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_Turnover.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_Turnover.EmbeddedNavigator.Name = ""
            CTag17.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag17.CalculatorRequired = True
            CTag17.ComboValueTextBox = Nothing
            CTag17.ControlRelatedCode = Nothing
            CTag17.DateButtonTextBox = Nothing
            CTag17.DateTimeButtonTextBox = Nothing
            CTag17.DisplayLinkControl = Nothing
            CTag17.DisplayLinkDisplayFieldName = Nothing
            CTag17.DisplayLinkKeyFieldName = Nothing
            CTag17.DisplayLinkTable = Nothing
            CTag17.FlexgridEditItem = ""
            CTag17.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag17.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag17.IsButtonCustomed = False
            CTag17.IsTextValid = True
            CTag17.KeyValueAbsentable = False
            CTag17.LeagleText = ""
            CTag17.NumericButtonTextBox = Nothing
            CTag17.ParentControl = Me.GridControl_Turnover.EmbeddedNavigator
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Turnover.EmbeddedNavigator.Tag = CTag17
            Me.GridControl_Turnover.MainView = Me.GridView_Turnover
            Me.GridControl_Turnover.Name = "GridControl_Turnover"
            Me.GridControl_Turnover.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_TurnoverType, Me.RepositoryItemLookUpEdit_TurnoverStyle, Me.RepositoryItemLookUpEdit_ConsignStatus, Me.RepositoryItemLookUpEdit_BalanceStatus})
            Me.GridControl_Turnover.TabStop = False
            Me.GridControl_Turnover.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Turnover})
            '
            'ContextMenuStrip_Grid
            '
            Me.ContextMenuStrip_Grid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_CopyTurnoverCode})
            Me.ContextMenuStrip_Grid.Name = "ContextMenuStrip_Grid"
            resources.ApplyResources(Me.ContextMenuStrip_Grid, "ContextMenuStrip_Grid")
            '
            'ToolStripMenuItem_CopyTurnoverCode
            '
            Me.ToolStripMenuItem_CopyTurnoverCode.Name = "ToolStripMenuItem_CopyTurnoverCode"
            resources.ApplyResources(Me.ToolStripMenuItem_CopyTurnoverCode, "ToolStripMenuItem_CopyTurnoverCode")
            '
            'GridView_Turnover
            '
            Me.GridView_Turnover.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_TurnoverCode, Me.GridColumn_TurnoverTime, Me.GridColumn_PosCode, Me.GridColumn_PosName, Me.GridColumn_EmployeeName, Me.GridColumn_TurnoverType, Me.GridColumn_TurnoverStyle, Me.GridColumn_TurnoverConsignStatus, Me.GridColumn_BalanceStatus, Me.GridColumn_PayAmount, Me.GridColumn_SumPrice, Me.GridColumn_CustomerName, Me.GridColumn_PointUse, Me.GridColumn_PointGain, Me.GridColumn_PointToRMBRate, Me.GridColumn_RMBToPointRAte, Me.GridColumn_SupplierName, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "TURNOVER_CONSIGN_NOT_YET"
            StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.White
            StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.Blue
            StyleFormatCondition3.Appearance.Options.UseBackColor = True
            StyleFormatCondition3.ApplyToRow = True
            StyleFormatCondition3.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition3.Value1 = "BALANCE_NOT_YET"
            StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Red
            StyleFormatCondition4.Appearance.BackColor2 = System.Drawing.Color.Blue
            StyleFormatCondition4.Appearance.Options.UseBackColor = True
            StyleFormatCondition4.ApplyToRow = True
            StyleFormatCondition4.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition4.Value1 = "ALL_NOT_YET"
            Me.GridView_Turnover.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4})
            Me.GridView_Turnover.GridControl = Me.GridControl_Turnover
            Me.GridView_Turnover.Name = "GridView_Turnover"
            Me.GridView_Turnover.OptionsView.ColumnAutoWidth = False
            Me.GridView_Turnover.OptionsView.ShowFooter = True
            Me.GridView_Turnover.OptionsView.ShowGroupPanel = False
            Me.GridView_Turnover.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn_TurnoverCode, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'GridColumn_TurnoverCode
            '
            resources.ApplyResources(Me.GridColumn_TurnoverCode, "GridColumn_TurnoverCode")
            Me.GridColumn_TurnoverCode.FieldName = "TURNOVER_CODE"
            Me.GridColumn_TurnoverCode.Name = "GridColumn_TurnoverCode"
            Me.GridColumn_TurnoverCode.OptionsColumn.ReadOnly = True
            Me.GridColumn_TurnoverCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_TurnoverTime
            '
            resources.ApplyResources(Me.GridColumn_TurnoverTime, "GridColumn_TurnoverTime")
            Me.GridColumn_TurnoverTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm"
            Me.GridColumn_TurnoverTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.GridColumn_TurnoverTime.FieldName = "TURNOVER_TIME"
            Me.GridColumn_TurnoverTime.Name = "GridColumn_TurnoverTime"
            Me.GridColumn_TurnoverTime.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PosCode
            '
            resources.ApplyResources(Me.GridColumn_PosCode, "GridColumn_PosCode")
            Me.GridColumn_PosCode.FieldName = "POS_CODE"
            Me.GridColumn_PosCode.Name = "GridColumn_PosCode"
            Me.GridColumn_PosCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PosName
            '
            resources.ApplyResources(Me.GridColumn_PosName, "GridColumn_PosName")
            Me.GridColumn_PosName.FieldName = "POS_NAME"
            Me.GridColumn_PosName.Name = "GridColumn_PosName"
            Me.GridColumn_PosName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_EmployeeName
            '
            resources.ApplyResources(Me.GridColumn_EmployeeName, "GridColumn_EmployeeName")
            Me.GridColumn_EmployeeName.FieldName = "STAFF_NAME"
            Me.GridColumn_EmployeeName.Name = "GridColumn_EmployeeName"
            Me.GridColumn_EmployeeName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TurnoverType
            '
            resources.ApplyResources(Me.GridColumn_TurnoverType, "GridColumn_TurnoverType")
            Me.GridColumn_TurnoverType.ColumnEdit = Me.RepositoryItemLookUpEdit_TurnoverType
            Me.GridColumn_TurnoverType.FieldName = "TURNOVER_TYPE"
            Me.GridColumn_TurnoverType.Name = "GridColumn_TurnoverType"
            Me.GridColumn_TurnoverType.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_TurnoverType
            '
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_TurnoverType, "RepositoryItemLookUpEdit_TurnoverType")
            Me.RepositoryItemLookUpEdit_TurnoverType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_TurnoverType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TurnoverType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_TurnoverType.Name = "RepositoryItemLookUpEdit_TurnoverType"
            Me.RepositoryItemLookUpEdit_TurnoverType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_TurnoverStyle
            '
            resources.ApplyResources(Me.GridColumn_TurnoverStyle, "GridColumn_TurnoverStyle")
            Me.GridColumn_TurnoverStyle.ColumnEdit = Me.RepositoryItemLookUpEdit_TurnoverStyle
            Me.GridColumn_TurnoverStyle.FieldName = "TURNOVER_STYLE"
            Me.GridColumn_TurnoverStyle.Name = "GridColumn_TurnoverStyle"
            Me.GridColumn_TurnoverStyle.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_TurnoverStyle
            '
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_TurnoverStyle, "RepositoryItemLookUpEdit_TurnoverStyle")
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TurnoverStyle.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Name = "RepositoryItemLookUpEdit_TurnoverStyle"
            Me.RepositoryItemLookUpEdit_TurnoverStyle.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_TurnoverConsignStatus
            '
            resources.ApplyResources(Me.GridColumn_TurnoverConsignStatus, "GridColumn_TurnoverConsignStatus")
            Me.GridColumn_TurnoverConsignStatus.ColumnEdit = Me.RepositoryItemLookUpEdit_ConsignStatus
            Me.GridColumn_TurnoverConsignStatus.FieldName = "TURNOVER_CONSIGN_STATUS"
            Me.GridColumn_TurnoverConsignStatus.Name = "GridColumn_TurnoverConsignStatus"
            Me.GridColumn_TurnoverConsignStatus.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_ConsignStatus
            '
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_ConsignStatus, "RepositoryItemLookUpEdit_ConsignStatus")
            Me.RepositoryItemLookUpEdit_ConsignStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_ConsignStatus.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_ConsignStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_ConsignStatus.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_ConsignStatus.Name = "RepositoryItemLookUpEdit_ConsignStatus"
            Me.RepositoryItemLookUpEdit_ConsignStatus.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_BalanceStatus
            '
            resources.ApplyResources(Me.GridColumn_BalanceStatus, "GridColumn_BalanceStatus")
            Me.GridColumn_BalanceStatus.ColumnEdit = Me.RepositoryItemLookUpEdit_BalanceStatus
            Me.GridColumn_BalanceStatus.FieldName = "BALANCE_STATUS"
            Me.GridColumn_BalanceStatus.Name = "GridColumn_BalanceStatus"
            Me.GridColumn_BalanceStatus.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_BalanceStatus
            '
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_BalanceStatus, "RepositoryItemLookUpEdit_BalanceStatus")
            Me.RepositoryItemLookUpEdit_BalanceStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_BalanceStatus.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_BalanceStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_BalanceStatus.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_BalanceStatus.Name = "RepositoryItemLookUpEdit_BalanceStatus"
            Me.RepositoryItemLookUpEdit_BalanceStatus.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_PayAmount
            '
            resources.ApplyResources(Me.GridColumn_PayAmount, "GridColumn_PayAmount")
            Me.GridColumn_PayAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_PayAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_PayAmount.FieldName = "PAY_AMOUNT"
            Me.GridColumn_PayAmount.Name = "GridColumn_PayAmount"
            Me.GridColumn_PayAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_PayAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_PayAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_PayAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_SumPrice
            '
            resources.ApplyResources(Me.GridColumn_SumPrice, "GridColumn_SumPrice")
            Me.GridColumn_SumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SumPrice.FieldName = "SUM_PRICE"
            Me.GridColumn_SumPrice.Name = "GridColumn_SumPrice"
            Me.GridColumn_SumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_SumPrice.SummaryItem.DisplayFormat = resources.GetString("GridColumn_SumPrice.SummaryItem.DisplayFormat")
            Me.GridColumn_SumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_CustomerName
            '
            resources.ApplyResources(Me.GridColumn_CustomerName, "GridColumn_CustomerName")
            Me.GridColumn_CustomerName.FieldName = "CLIENT_NAME"
            Me.GridColumn_CustomerName.Name = "GridColumn_CustomerName"
            Me.GridColumn_CustomerName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SupplierName
            '
            resources.ApplyResources(Me.GridColumn_SupplierName, "GridColumn_SupplierName")
            Me.GridColumn_SupplierName.FieldName = "SUPPLIER_NAME"
            Me.GridColumn_SupplierName.Name = "GridColumn_SupplierName"
            Me.GridColumn_SupplierName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowHighlight
            '
            resources.ApplyResources(Me.GridColumn_RowHighlight, "GridColumn_RowHighlight")
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'GridColumn_RMBToPointRAte
            '
            resources.ApplyResources(Me.GridColumn_RMBToPointRAte, "GridColumn_RMBToPointRAte")
            Me.GridColumn_RMBToPointRAte.FieldName = "RMB_TO_POINT_RATE"
            Me.GridColumn_RMBToPointRAte.Name = "GridColumn_RMBToPointRAte"
            Me.GridColumn_RMBToPointRAte.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PointToRMBRate
            '
            resources.ApplyResources(Me.GridColumn_PointToRMBRate, "GridColumn_PointToRMBRate")
            Me.GridColumn_PointToRMBRate.FieldName = "POINT_TO_RMB_RATE"
            Me.GridColumn_PointToRMBRate.Name = "GridColumn_PointToRMBRate"
            Me.GridColumn_PointToRMBRate.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PointGain
            '
            resources.ApplyResources(Me.GridColumn_PointGain, "GridColumn_PointGain")
            Me.GridColumn_PointGain.FieldName = "POINT_GAIN"
            Me.GridColumn_PointGain.Name = "GridColumn_PointGain"
            Me.GridColumn_PointGain.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PointUse
            '
            resources.ApplyResources(Me.GridColumn_PointUse, "GridColumn_PointUse")
            Me.GridColumn_PointUse.FieldName = "POINT_USE"
            Me.GridColumn_PointUse.Name = "GridColumn_PointUse"
            Me.GridColumn_PointUse.OptionsColumn.AllowFocus = False
            '
            'M_02_00101
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.GridControl_Turnover)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_00101"
            CTag18.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag18.CalculatorRequired = True
            CTag18.ComboValueTextBox = Nothing
            CTag18.ControlRelatedCode = Nothing
            CTag18.DateButtonTextBox = Nothing
            CTag18.DateTimeButtonTextBox = Nothing
            CTag18.DisplayLinkControl = Nothing
            CTag18.DisplayLinkDisplayFieldName = Nothing
            CTag18.DisplayLinkKeyFieldName = Nothing
            CTag18.DisplayLinkTable = Nothing
            CTag18.FlexgridEditItem = ""
            CTag18.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag18.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag18.IsButtonCustomed = False
            CTag18.IsTextValid = True
            CTag18.KeyValueAbsentable = False
            CTag18.LeagleText = ""
            CTag18.NumericButtonTextBox = Nothing
            CTag18.ParentControl = Me
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag18
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            Me.Panel_DateRange.ResumeLayout(False)
            Me.Panel_DateRange.PerformLayout()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel_Options.ResumeLayout(False)
            Me.Panel_Options.PerformLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_TurnoverStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_TurnoverType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_Turnover, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStrip_Grid.ResumeLayout(False)
            CType(Me.GridView_Turnover, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverType, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverStyle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_ConsignStatus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_BalanceStatus, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_TurnoverType As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_ToDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_FromDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_TurnoverStyle As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_Pos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents GridControl_Turnover As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Turnover As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_SumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PayAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverTime As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PosCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PosName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_EmployeeName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverStyle As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverConsignStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BalanceStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverStyle As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_ConsignStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_CustomerName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_BalanceStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents ToolStripButton_ConsignQuery As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_DeliveryQuery As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_PaymentQuery As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents Panel_DateRange As System.Windows.Forms.Panel
        Friend WithEvents Panel_Options As System.Windows.Forms.Panel
        Friend WithEvents ToolStripButton_StaffCommission As System.Windows.Forms.ToolStripButton
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ContextMenuStrip_Grid As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ToolStripMenuItem_CopyTurnoverCode As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripButton_Print As System.Windows.Forms.ToolStripButton
        Friend WithEvents GridColumn_PointUse As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PointGain As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PointToRMBRate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RMBToPointRAte As DevExpress.XtraGrid.Columns.GridColumn

#End Region

    End Class

End Namespace
