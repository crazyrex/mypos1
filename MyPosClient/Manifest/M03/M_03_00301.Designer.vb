Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_00301
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
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_View As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_00301))
            Dim CTag29 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag18 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag19 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag20 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag21 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag22 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag23 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag24 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag25 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag26 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag27 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag28 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag30 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag31 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_General = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.Panel_ConsignStatus = New System.Windows.Forms.Panel
            Me.Label8 = New System.Windows.Forms.Label
            Me.LookUpEdit_ConsignStatus = New DevExpress.XtraEditors.LookUpEdit
            Me.LookUpEdit_TurnoverStyle = New DevExpress.XtraEditors.LookUpEdit
            Me.Label6 = New System.Windows.Forms.Label
            Me.LookUpEdit_TurnoverType = New DevExpress.XtraEditors.LookUpEdit
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label_CustomerID = New System.Windows.Forms.Label
            Me.Label_CustomerName = New System.Windows.Forms.Label
            Me.ButtonEdit_CustomerCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label_Customer = New System.Windows.Forms.Label
            Me.Label_SupplierID = New System.Windows.Forms.Label
            Me.Label_SupplierName = New System.Windows.Forms.Label
            Me.ButtonEdit_SupplierCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label_Supplier = New System.Windows.Forms.Label
            Me.Label_EmployeeID = New System.Windows.Forms.Label
            Me.Label_EmployeeName = New System.Windows.Forms.Label
            Me.ButtonEdit_EmployeeCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label5 = New System.Windows.Forms.Label
            Me.LookUpEdit_Pos = New DevExpress.XtraEditors.LookUpEdit
            Me.Label4 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.GridControl_TurnoverDtl = New DevExpress.XtraGrid.GridControl
            Me.ContextMenuStrip_Grid = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItem_CopyTurnoverCode = New System.Windows.Forms.ToolStripMenuItem
            Me.GridView_TurnoverDtl = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_TurnoverCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverTime = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PosName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TurnoverType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_TurnoverStyle = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TurnoverStyle = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_OrigionUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_OrigionSunPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            Me.Panel_ConsignStatus.SuspendLayout()
            CType(Me.LookUpEdit_ConsignStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_TurnoverStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_TurnoverType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_CustomerCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_SupplierCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_EmployeeCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_TurnoverDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStrip_Grid.SuspendLayout()
            CType(Me.GridView_TurnoverDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverType, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverStyle, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_General, Me.ToolStripButton_Refresh, Me.ToolStripButton_View, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_Close})
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
            'ToolStripButton_General
            '
            Me.ToolStripButton_General.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_General, "ToolStripButton_General")
            Me.ToolStripButton_General.Name = "ToolStripButton_General"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            '
            'ToolStripButton_View
            '
            Me.ToolStripButton_View.Name = "ToolStripButton_View"
            resources.ApplyResources(Me.ToolStripButton_View, "ToolStripButton_View")
            '
            'ToolStripButton_ExportExcel
            '
            Me.ToolStripButton_ExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_ExportExcel, "ToolStripButton_ExportExcel")
            Me.ToolStripButton_ExportExcel.Name = "ToolStripButton_ExportExcel"
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
            Me.PanelControl_Filter.Controls.Add(Me.Panel_ConsignStatus)
            Me.PanelControl_Filter.Controls.Add(Me.LookUpEdit_TurnoverStyle)
            Me.PanelControl_Filter.Controls.Add(Me.Label6)
            Me.PanelControl_Filter.Controls.Add(Me.LookUpEdit_TurnoverType)
            Me.PanelControl_Filter.Controls.Add(Me.Label7)
            Me.PanelControl_Filter.Controls.Add(Me.Label_CustomerID)
            Me.PanelControl_Filter.Controls.Add(Me.Label_CustomerName)
            Me.PanelControl_Filter.Controls.Add(Me.ButtonEdit_CustomerCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label_Customer)
            Me.PanelControl_Filter.Controls.Add(Me.Label_SupplierID)
            Me.PanelControl_Filter.Controls.Add(Me.Label_SupplierName)
            Me.PanelControl_Filter.Controls.Add(Me.ButtonEdit_SupplierCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label_Supplier)
            Me.PanelControl_Filter.Controls.Add(Me.Label_EmployeeID)
            Me.PanelControl_Filter.Controls.Add(Me.Label_EmployeeName)
            Me.PanelControl_Filter.Controls.Add(Me.ButtonEdit_EmployeeCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label5)
            Me.PanelControl_Filter.Controls.Add(Me.LookUpEdit_Pos)
            Me.PanelControl_Filter.Controls.Add(Me.Label4)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_ToDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label3)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_FromDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
            CTag29.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag29.CalculatorRequired = True
            CTag29.ComboValueTextBox = Nothing
            CTag29.ControlRelatedCode = Nothing
            CTag29.DateButtonTextBox = Nothing
            CTag29.DateTimeButtonTextBox = Nothing
            CTag29.DisplayLinkControl = Nothing
            CTag29.DisplayLinkDisplayFieldName = Nothing
            CTag29.DisplayLinkKeyFieldName = Nothing
            CTag29.DisplayLinkTable = Nothing
            CTag29.FlexgridEditItem = ""
            CTag29.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag29.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag29.IsButtonCustomed = False
            CTag29.IsTextValid = True
            CTag29.KeyValueAbsentable = False
            CTag29.LeagleText = ""
            CTag29.NumericButtonTextBox = Nothing
            CTag29.ParentControl = Me.PanelControl_Filter
            CTag29.SkipValidate = False
            CTag29.TimeButtonTextBox = Nothing
            CTag29.ToolTip = ""
            CTag29.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag29
            '
            'Panel_ConsignStatus
            '
            Me.Panel_ConsignStatus.Controls.Add(Me.Label8)
            Me.Panel_ConsignStatus.Controls.Add(Me.LookUpEdit_ConsignStatus)
            resources.ApplyResources(Me.Panel_ConsignStatus, "Panel_ConsignStatus")
            Me.Panel_ConsignStatus.Name = "Panel_ConsignStatus"
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
            CTag4.ParentControl = Me.Panel_ConsignStatus
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Panel_ConsignStatus.Tag = CTag4
            '
            'Label8
            '
            resources.ApplyResources(Me.Label8, "Label8")
            Me.Label8.Name = "Label8"
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
            CTag2.ParentControl = Me.Label8
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label8.Tag = CTag2
            '
            'LookUpEdit_ConsignStatus
            '
            resources.ApplyResources(Me.LookUpEdit_ConsignStatus, "LookUpEdit_ConsignStatus")
            Me.LookUpEdit_ConsignStatus.Name = "LookUpEdit_ConsignStatus"
            Me.LookUpEdit_ConsignStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_ConsignStatus.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_ConsignStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_ConsignStatus.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_ConsignStatus.Properties.ValueMember = "ITEM_VALUE"
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
            CTag3.ParentControl = Me.LookUpEdit_ConsignStatus
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_ConsignStatus.Tag = CTag3
            '
            'LookUpEdit_TurnoverStyle
            '
            resources.ApplyResources(Me.LookUpEdit_TurnoverStyle, "LookUpEdit_TurnoverStyle")
            Me.LookUpEdit_TurnoverStyle.Name = "LookUpEdit_TurnoverStyle"
            Me.LookUpEdit_TurnoverStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_TurnoverStyle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_TurnoverStyle.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_TurnoverStyle.Properties.ValueMember = "ITEM_VALUE"
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
            CTag5.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag5.IsButtonCustomed = False
            CTag5.IsTextValid = True
            CTag5.KeyValueAbsentable = False
            CTag5.LeagleText = ""
            CTag5.NumericButtonTextBox = Nothing
            CTag5.ParentControl = Me.LookUpEdit_TurnoverStyle
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_TurnoverStyle.Tag = CTag5
            '
            'Label6
            '
            resources.ApplyResources(Me.Label6, "Label6")
            Me.Label6.Name = "Label6"
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
            CTag6.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag6.IsButtonCustomed = False
            CTag6.IsTextValid = True
            CTag6.KeyValueAbsentable = False
            CTag6.LeagleText = ""
            CTag6.NumericButtonTextBox = Nothing
            CTag6.ParentControl = Me.Label6
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label6.Tag = CTag6
            '
            'LookUpEdit_TurnoverType
            '
            resources.ApplyResources(Me.LookUpEdit_TurnoverType, "LookUpEdit_TurnoverType")
            Me.LookUpEdit_TurnoverType.Name = "LookUpEdit_TurnoverType"
            Me.LookUpEdit_TurnoverType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_TurnoverType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_TurnoverType.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_TurnoverType.Properties.ValueMember = "ITEM_VALUE"
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
            CTag7.ParentControl = Me.LookUpEdit_TurnoverType
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_TurnoverType.Tag = CTag7
            '
            'Label7
            '
            resources.ApplyResources(Me.Label7, "Label7")
            Me.Label7.Name = "Label7"
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
            CTag8.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag8.IsButtonCustomed = False
            CTag8.IsTextValid = True
            CTag8.KeyValueAbsentable = False
            CTag8.LeagleText = ""
            CTag8.NumericButtonTextBox = Nothing
            CTag8.ParentControl = Me.Label7
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label7.Tag = CTag8
            '
            'Label_CustomerID
            '
            resources.ApplyResources(Me.Label_CustomerID, "Label_CustomerID")
            Me.Label_CustomerID.Name = "Label_CustomerID"
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
            CTag9.ParentControl = Me.Label_CustomerID
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomerID.Tag = CTag9
            '
            'Label_CustomerName
            '
            Me.Label_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            resources.ApplyResources(Me.Label_CustomerName, "Label_CustomerName")
            Me.Label_CustomerName.Name = "Label_CustomerName"
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
            CTag10.ParentControl = Me.Label_CustomerName
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomerName.Tag = CTag10
            '
            'ButtonEdit_CustomerCode
            '
            resources.ApplyResources(Me.ButtonEdit_CustomerCode, "ButtonEdit_CustomerCode")
            Me.ButtonEdit_CustomerCode.Name = "ButtonEdit_CustomerCode"
            Me.ButtonEdit_CustomerCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag11.ParentControl = Me.ButtonEdit_CustomerCode
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_CustomerCode.Tag = CTag11
            '
            'Label_Customer
            '
            resources.ApplyResources(Me.Label_Customer, "Label_Customer")
            Me.Label_Customer.Name = "Label_Customer"
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
            CTag12.ParentControl = Me.Label_Customer
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Label_Customer.Tag = CTag12
            '
            'Label_SupplierID
            '
            resources.ApplyResources(Me.Label_SupplierID, "Label_SupplierID")
            Me.Label_SupplierID.Name = "Label_SupplierID"
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
            CTag13.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag13.IsButtonCustomed = False
            CTag13.IsTextValid = True
            CTag13.KeyValueAbsentable = False
            CTag13.LeagleText = ""
            CTag13.NumericButtonTextBox = Nothing
            CTag13.ParentControl = Me.Label_SupplierID
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.Label_SupplierID.Tag = CTag13
            '
            'Label_SupplierName
            '
            Me.Label_SupplierName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            resources.ApplyResources(Me.Label_SupplierName, "Label_SupplierName")
            Me.Label_SupplierName.Name = "Label_SupplierName"
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
            CTag14.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag14.IsButtonCustomed = False
            CTag14.IsTextValid = True
            CTag14.KeyValueAbsentable = False
            CTag14.LeagleText = ""
            CTag14.NumericButtonTextBox = Nothing
            CTag14.ParentControl = Me.Label_SupplierName
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.Label_SupplierName.Tag = CTag14
            '
            'ButtonEdit_SupplierCode
            '
            resources.ApplyResources(Me.ButtonEdit_SupplierCode, "ButtonEdit_SupplierCode")
            Me.ButtonEdit_SupplierCode.Name = "ButtonEdit_SupplierCode"
            Me.ButtonEdit_SupplierCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag15.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag15.IsButtonCustomed = False
            CTag15.IsTextValid = True
            CTag15.KeyValueAbsentable = False
            CTag15.LeagleText = ""
            CTag15.NumericButtonTextBox = Nothing
            CTag15.ParentControl = Me.ButtonEdit_SupplierCode
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_SupplierCode.Tag = CTag15
            '
            'Label_Supplier
            '
            resources.ApplyResources(Me.Label_Supplier, "Label_Supplier")
            Me.Label_Supplier.Name = "Label_Supplier"
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
            CTag16.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag16.IsButtonCustomed = False
            CTag16.IsTextValid = True
            CTag16.KeyValueAbsentable = False
            CTag16.LeagleText = ""
            CTag16.NumericButtonTextBox = Nothing
            CTag16.ParentControl = Me.Label_Supplier
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.Label_Supplier.Tag = CTag16
            '
            'Label_EmployeeID
            '
            resources.ApplyResources(Me.Label_EmployeeID, "Label_EmployeeID")
            Me.Label_EmployeeID.Name = "Label_EmployeeID"
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
            CTag17.ParentControl = Me.Label_EmployeeID
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.Label_EmployeeID.Tag = CTag17
            '
            'Label_EmployeeName
            '
            Me.Label_EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            resources.ApplyResources(Me.Label_EmployeeName, "Label_EmployeeName")
            Me.Label_EmployeeName.Name = "Label_EmployeeName"
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
            CTag18.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag18.IsButtonCustomed = False
            CTag18.IsTextValid = True
            CTag18.KeyValueAbsentable = False
            CTag18.LeagleText = ""
            CTag18.NumericButtonTextBox = Nothing
            CTag18.ParentControl = Me.Label_EmployeeName
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.Label_EmployeeName.Tag = CTag18
            '
            'ButtonEdit_EmployeeCode
            '
            resources.ApplyResources(Me.ButtonEdit_EmployeeCode, "ButtonEdit_EmployeeCode")
            Me.ButtonEdit_EmployeeCode.Name = "ButtonEdit_EmployeeCode"
            Me.ButtonEdit_EmployeeCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            CTag19.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag19.CalculatorRequired = True
            CTag19.ComboValueTextBox = Nothing
            CTag19.ControlRelatedCode = Nothing
            CTag19.DateButtonTextBox = Nothing
            CTag19.DateTimeButtonTextBox = Nothing
            CTag19.DisplayLinkControl = Nothing
            CTag19.DisplayLinkDisplayFieldName = Nothing
            CTag19.DisplayLinkKeyFieldName = Nothing
            CTag19.DisplayLinkTable = Nothing
            CTag19.FlexgridEditItem = ""
            CTag19.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag19.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag19.IsButtonCustomed = False
            CTag19.IsTextValid = True
            CTag19.KeyValueAbsentable = False
            CTag19.LeagleText = ""
            CTag19.NumericButtonTextBox = Nothing
            CTag19.ParentControl = Me.ButtonEdit_EmployeeCode
            CTag19.SkipValidate = False
            CTag19.TimeButtonTextBox = Nothing
            CTag19.ToolTip = ""
            CTag19.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_EmployeeCode.Tag = CTag19
            '
            'Label5
            '
            resources.ApplyResources(Me.Label5, "Label5")
            Me.Label5.Name = "Label5"
            CTag20.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag20.CalculatorRequired = True
            CTag20.ComboValueTextBox = Nothing
            CTag20.ControlRelatedCode = Nothing
            CTag20.DateButtonTextBox = Nothing
            CTag20.DateTimeButtonTextBox = Nothing
            CTag20.DisplayLinkControl = Nothing
            CTag20.DisplayLinkDisplayFieldName = Nothing
            CTag20.DisplayLinkKeyFieldName = Nothing
            CTag20.DisplayLinkTable = Nothing
            CTag20.FlexgridEditItem = ""
            CTag20.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag20.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag20.IsButtonCustomed = False
            CTag20.IsTextValid = True
            CTag20.KeyValueAbsentable = False
            CTag20.LeagleText = ""
            CTag20.NumericButtonTextBox = Nothing
            CTag20.ParentControl = Me.Label5
            CTag20.SkipValidate = False
            CTag20.TimeButtonTextBox = Nothing
            CTag20.ToolTip = ""
            CTag20.ValueType = XL.Common.ControlValueType.Character
            Me.Label5.Tag = CTag20
            '
            'LookUpEdit_Pos
            '
            resources.ApplyResources(Me.LookUpEdit_Pos, "LookUpEdit_Pos")
            Me.LookUpEdit_Pos.Name = "LookUpEdit_Pos"
            Me.LookUpEdit_Pos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_Pos.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_Pos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Pos.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_Pos.Properties.NullText = resources.GetString("LookUpEdit_Pos.Properties.NullText")
            Me.LookUpEdit_Pos.Properties.ValueMember = "POS_ID"
            CTag21.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag21.CalculatorRequired = True
            CTag21.ComboValueTextBox = Nothing
            CTag21.ControlRelatedCode = Nothing
            CTag21.DateButtonTextBox = Nothing
            CTag21.DateTimeButtonTextBox = Nothing
            CTag21.DisplayLinkControl = Nothing
            CTag21.DisplayLinkDisplayFieldName = Nothing
            CTag21.DisplayLinkKeyFieldName = Nothing
            CTag21.DisplayLinkTable = Nothing
            CTag21.FlexgridEditItem = ""
            CTag21.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag21.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag21.IsButtonCustomed = False
            CTag21.IsTextValid = True
            CTag21.KeyValueAbsentable = False
            CTag21.LeagleText = ""
            CTag21.NumericButtonTextBox = Nothing
            CTag21.ParentControl = Me.LookUpEdit_Pos
            CTag21.SkipValidate = False
            CTag21.TimeButtonTextBox = Nothing
            CTag21.ToolTip = ""
            CTag21.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_Pos.Tag = CTag21
            '
            'Label4
            '
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.BackColor = System.Drawing.Color.White
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Name = "Label4"
            CTag22.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag22.CalculatorRequired = True
            CTag22.ComboValueTextBox = Nothing
            CTag22.ControlRelatedCode = Nothing
            CTag22.DateButtonTextBox = Nothing
            CTag22.DateTimeButtonTextBox = Nothing
            CTag22.DisplayLinkControl = Nothing
            CTag22.DisplayLinkDisplayFieldName = Nothing
            CTag22.DisplayLinkKeyFieldName = Nothing
            CTag22.DisplayLinkTable = Nothing
            CTag22.FlexgridEditItem = ""
            CTag22.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag22.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag22.IsButtonCustomed = False
            CTag22.IsTextValid = True
            CTag22.KeyValueAbsentable = False
            CTag22.LeagleText = ""
            CTag22.NumericButtonTextBox = Nothing
            CTag22.ParentControl = Me.Label4
            CTag22.SkipValidate = False
            CTag22.TimeButtonTextBox = Nothing
            CTag22.ToolTip = ""
            CTag22.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag22
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.Name = "TextEdit_Search"
            CTag23.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag23.CalculatorRequired = True
            CTag23.ComboValueTextBox = Nothing
            CTag23.ControlRelatedCode = Nothing
            CTag23.DateButtonTextBox = Nothing
            CTag23.DateTimeButtonTextBox = Nothing
            CTag23.DisplayLinkControl = Nothing
            CTag23.DisplayLinkDisplayFieldName = Nothing
            CTag23.DisplayLinkKeyFieldName = Nothing
            CTag23.DisplayLinkTable = Nothing
            CTag23.FlexgridEditItem = ""
            CTag23.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag23.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag23.IsButtonCustomed = False
            CTag23.IsTextValid = True
            CTag23.KeyValueAbsentable = False
            CTag23.LeagleText = ""
            CTag23.NumericButtonTextBox = Nothing
            CTag23.ParentControl = Me.TextEdit_Search
            CTag23.SkipValidate = False
            CTag23.TimeButtonTextBox = Nothing
            CTag23.ToolTip = ""
            CTag23.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag23
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
            CTag24.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag24.CalculatorRequired = True
            CTag24.ComboValueTextBox = Nothing
            CTag24.ControlRelatedCode = Nothing
            CTag24.DateButtonTextBox = Nothing
            CTag24.DateTimeButtonTextBox = Nothing
            CTag24.DisplayLinkControl = Nothing
            CTag24.DisplayLinkDisplayFieldName = Nothing
            CTag24.DisplayLinkKeyFieldName = Nothing
            CTag24.DisplayLinkTable = Nothing
            CTag24.FlexgridEditItem = ""
            CTag24.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag24.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag24.IsButtonCustomed = False
            CTag24.IsTextValid = True
            CTag24.KeyValueAbsentable = False
            CTag24.LeagleText = ""
            CTag24.NumericButtonTextBox = Nothing
            CTag24.ParentControl = Me.Label1
            CTag24.SkipValidate = False
            CTag24.TimeButtonTextBox = Nothing
            CTag24.ToolTip = ""
            CTag24.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag24
            '
            'DateEdit_ToDate
            '
            Me.DateEdit_ToDate.EditValue = Nothing
            resources.ApplyResources(Me.DateEdit_ToDate, "DateEdit_ToDate")
            Me.DateEdit_ToDate.Name = "DateEdit_ToDate"
            Me.DateEdit_ToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_ToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_ToDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            CTag25.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag25.CalculatorRequired = True
            CTag25.ComboValueTextBox = Nothing
            CTag25.ControlRelatedCode = Nothing
            CTag25.DateButtonTextBox = Nothing
            CTag25.DateTimeButtonTextBox = Nothing
            CTag25.DisplayLinkControl = Nothing
            CTag25.DisplayLinkDisplayFieldName = Nothing
            CTag25.DisplayLinkKeyFieldName = Nothing
            CTag25.DisplayLinkTable = Nothing
            CTag25.FlexgridEditItem = ""
            CTag25.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag25.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag25.IsButtonCustomed = False
            CTag25.IsTextValid = True
            CTag25.KeyValueAbsentable = False
            CTag25.LeagleText = ""
            CTag25.NumericButtonTextBox = Nothing
            CTag25.ParentControl = Me.DateEdit_ToDate
            CTag25.SkipValidate = False
            CTag25.TimeButtonTextBox = Nothing
            CTag25.ToolTip = ""
            CTag25.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_ToDate.Tag = CTag25
            '
            'Label3
            '
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
            CTag26.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag26.CalculatorRequired = True
            CTag26.ComboValueTextBox = Nothing
            CTag26.ControlRelatedCode = Nothing
            CTag26.DateButtonTextBox = Nothing
            CTag26.DateTimeButtonTextBox = Nothing
            CTag26.DisplayLinkControl = Nothing
            CTag26.DisplayLinkDisplayFieldName = Nothing
            CTag26.DisplayLinkKeyFieldName = Nothing
            CTag26.DisplayLinkTable = Nothing
            CTag26.FlexgridEditItem = ""
            CTag26.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag26.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag26.IsButtonCustomed = False
            CTag26.IsTextValid = True
            CTag26.KeyValueAbsentable = False
            CTag26.LeagleText = ""
            CTag26.NumericButtonTextBox = Nothing
            CTag26.ParentControl = Me.Label3
            CTag26.SkipValidate = False
            CTag26.TimeButtonTextBox = Nothing
            CTag26.ToolTip = ""
            CTag26.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag26
            '
            'DateEdit_FromDate
            '
            Me.DateEdit_FromDate.EditValue = Nothing
            resources.ApplyResources(Me.DateEdit_FromDate, "DateEdit_FromDate")
            Me.DateEdit_FromDate.Name = "DateEdit_FromDate"
            Me.DateEdit_FromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_FromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_FromDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            CTag27.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag27.CalculatorRequired = True
            CTag27.ComboValueTextBox = Nothing
            CTag27.ControlRelatedCode = Nothing
            CTag27.DateButtonTextBox = Nothing
            CTag27.DateTimeButtonTextBox = Nothing
            CTag27.DisplayLinkControl = Nothing
            CTag27.DisplayLinkDisplayFieldName = Nothing
            CTag27.DisplayLinkKeyFieldName = Nothing
            CTag27.DisplayLinkTable = Nothing
            CTag27.FlexgridEditItem = ""
            CTag27.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag27.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag27.IsButtonCustomed = False
            CTag27.IsTextValid = True
            CTag27.KeyValueAbsentable = False
            CTag27.LeagleText = ""
            CTag27.NumericButtonTextBox = Nothing
            CTag27.ParentControl = Me.DateEdit_FromDate
            CTag27.SkipValidate = False
            CTag27.TimeButtonTextBox = Nothing
            CTag27.ToolTip = ""
            CTag27.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_FromDate.Tag = CTag27
            '
            'Label2
            '
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
            CTag28.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag28.CalculatorRequired = True
            CTag28.ComboValueTextBox = Nothing
            CTag28.ControlRelatedCode = Nothing
            CTag28.DateButtonTextBox = Nothing
            CTag28.DateTimeButtonTextBox = Nothing
            CTag28.DisplayLinkControl = Nothing
            CTag28.DisplayLinkDisplayFieldName = Nothing
            CTag28.DisplayLinkKeyFieldName = Nothing
            CTag28.DisplayLinkTable = Nothing
            CTag28.FlexgridEditItem = ""
            CTag28.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag28.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag28.IsButtonCustomed = False
            CTag28.IsTextValid = True
            CTag28.KeyValueAbsentable = False
            CTag28.LeagleText = ""
            CTag28.NumericButtonTextBox = Nothing
            CTag28.ParentControl = Me.Label2
            CTag28.SkipValidate = False
            CTag28.TimeButtonTextBox = Nothing
            CTag28.ToolTip = ""
            CTag28.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag28
            '
            'GridControl_TurnoverDtl
            '
            Me.GridControl_TurnoverDtl.ContextMenuStrip = Me.ContextMenuStrip_Grid
            resources.ApplyResources(Me.GridControl_TurnoverDtl, "GridControl_TurnoverDtl")
            Me.GridControl_TurnoverDtl.EmbeddedNavigator.Name = ""
            CTag30.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag30.CalculatorRequired = True
            CTag30.ComboValueTextBox = Nothing
            CTag30.ControlRelatedCode = Nothing
            CTag30.DateButtonTextBox = Nothing
            CTag30.DateTimeButtonTextBox = Nothing
            CTag30.DisplayLinkControl = Nothing
            CTag30.DisplayLinkDisplayFieldName = Nothing
            CTag30.DisplayLinkKeyFieldName = Nothing
            CTag30.DisplayLinkTable = Nothing
            CTag30.FlexgridEditItem = ""
            CTag30.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag30.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag30.IsButtonCustomed = False
            CTag30.IsTextValid = True
            CTag30.KeyValueAbsentable = False
            CTag30.LeagleText = ""
            CTag30.NumericButtonTextBox = Nothing
            CTag30.ParentControl = Me.GridControl_TurnoverDtl.EmbeddedNavigator
            CTag30.SkipValidate = False
            CTag30.TimeButtonTextBox = Nothing
            CTag30.ToolTip = ""
            CTag30.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_TurnoverDtl.EmbeddedNavigator.Tag = CTag30
            Me.GridControl_TurnoverDtl.MainView = Me.GridView_TurnoverDtl
            Me.GridControl_TurnoverDtl.Name = "GridControl_TurnoverDtl"
            Me.GridControl_TurnoverDtl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_TurnoverType, Me.RepositoryItemLookUpEdit_TurnoverStyle})
            Me.GridControl_TurnoverDtl.TabStop = False
            Me.GridControl_TurnoverDtl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_TurnoverDtl})
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
            'GridView_TurnoverDtl
            '
            Me.GridView_TurnoverDtl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_TurnoverCode, Me.GridColumn_TurnoverTime, Me.GridColumn_PosName, Me.GridColumn_TurnoverType, Me.GridColumn_TurnoverStyle, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_WareAmount, Me.GridColumn_UnitName, Me.GridColumn_UnitPrice, Me.GridColumn_SumPrice, Me.GridColumn_OrigionUnitPrice, Me.GridColumn_OrigionSunPrice, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
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
            StyleFormatCondition2.Value1 = "CURRENT_AMOUNT"
            Me.GridView_TurnoverDtl.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.GridView_TurnoverDtl.GridControl = Me.GridControl_TurnoverDtl
            Me.GridView_TurnoverDtl.Name = "GridView_TurnoverDtl"
            Me.GridView_TurnoverDtl.OptionsView.ColumnAutoWidth = False
            Me.GridView_TurnoverDtl.OptionsView.ShowFooter = True
            Me.GridView_TurnoverDtl.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_TurnoverCode
            '
            resources.ApplyResources(Me.GridColumn_TurnoverCode, "GridColumn_TurnoverCode")
            Me.GridColumn_TurnoverCode.FieldName = "TURNOVER_CODE"
            Me.GridColumn_TurnoverCode.Name = "GridColumn_TurnoverCode"
            Me.GridColumn_TurnoverCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_TurnoverCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_TurnoverTime
            '
            resources.ApplyResources(Me.GridColumn_TurnoverTime, "GridColumn_TurnoverTime")
            Me.GridColumn_TurnoverTime.FieldName = "TURNOVER_TIME"
            Me.GridColumn_TurnoverTime.Name = "GridColumn_TurnoverTime"
            Me.GridColumn_TurnoverTime.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PosName
            '
            resources.ApplyResources(Me.GridColumn_PosName, "GridColumn_PosName")
            Me.GridColumn_PosName.FieldName = "POS_NAME"
            Me.GridColumn_PosName.Name = "GridColumn_PosName"
            Me.GridColumn_PosName.OptionsColumn.AllowFocus = False
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
            'GridColumn_WareCode
            '
            resources.ApplyResources(Me.GridColumn_WareCode, "GridColumn_WareCode")
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_CustomCode
            '
            resources.ApplyResources(Me.GridColumn_CustomCode, "GridColumn_CustomCode")
            Me.GridColumn_CustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_CustomCode.Name = "GridColumn_CustomCode"
            Me.GridColumn_CustomCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_WareName
            '
            resources.ApplyResources(Me.GridColumn_WareName, "GridColumn_WareName")
            Me.GridColumn_WareName.FieldName = "WARE_NAME"
            Me.GridColumn_WareName.Name = "GridColumn_WareName"
            Me.GridColumn_WareName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Spec
            '
            resources.ApplyResources(Me.GridColumn_Spec, "GridColumn_Spec")
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Model
            '
            resources.ApplyResources(Me.GridColumn_Model, "GridColumn_Model")
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute1
            '
            resources.ApplyResources(Me.GridColumn_Attribute1, "GridColumn_Attribute1")
            Me.GridColumn_Attribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_Attribute1.Name = "GridColumn_Attribute1"
            Me.GridColumn_Attribute1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute2
            '
            resources.ApplyResources(Me.GridColumn_Attribute2, "GridColumn_Attribute2")
            Me.GridColumn_Attribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_Attribute2.Name = "GridColumn_Attribute2"
            Me.GridColumn_Attribute2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute3
            '
            resources.ApplyResources(Me.GridColumn_Attribute3, "GridColumn_Attribute3")
            Me.GridColumn_Attribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_Attribute3.Name = "GridColumn_Attribute3"
            Me.GridColumn_Attribute3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute4
            '
            resources.ApplyResources(Me.GridColumn_Attribute4, "GridColumn_Attribute4")
            Me.GridColumn_Attribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_Attribute4.Name = "GridColumn_Attribute4"
            Me.GridColumn_Attribute4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_WareAmount
            '
            resources.ApplyResources(Me.GridColumn_WareAmount, "GridColumn_WareAmount")
            Me.GridColumn_WareAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_WareAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_WareAmount.FieldName = "WARE_AMOUNT"
            Me.GridColumn_WareAmount.Name = "GridColumn_WareAmount"
            Me.GridColumn_WareAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_UnitName
            '
            resources.ApplyResources(Me.GridColumn_UnitName, "GridColumn_UnitName")
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_UnitPrice
            '
            resources.ApplyResources(Me.GridColumn_UnitPrice, "GridColumn_UnitPrice")
            Me.GridColumn_UnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitPrice.FieldName = "UNIT_PRICE"
            Me.GridColumn_UnitPrice.Name = "GridColumn_UnitPrice"
            Me.GridColumn_UnitPrice.OptionsColumn.AllowFocus = False
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
            'GridColumn_OrigionUnitPrice
            '
            resources.ApplyResources(Me.GridColumn_OrigionUnitPrice, "GridColumn_OrigionUnitPrice")
            Me.GridColumn_OrigionUnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_OrigionUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_OrigionUnitPrice.FieldName = "ORIGION_UNIT_PRICE"
            Me.GridColumn_OrigionUnitPrice.Name = "GridColumn_OrigionUnitPrice"
            Me.GridColumn_OrigionUnitPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_OrigionUnitPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_OrigionSunPrice
            '
            resources.ApplyResources(Me.GridColumn_OrigionSunPrice, "GridColumn_OrigionSunPrice")
            Me.GridColumn_OrigionSunPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_OrigionSunPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_OrigionSunPrice.FieldName = "ORIGION_SUM_PRICE"
            Me.GridColumn_OrigionSunPrice.Name = "GridColumn_OrigionSunPrice"
            Me.GridColumn_OrigionSunPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_OrigionSunPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_Remarks
            '
            resources.ApplyResources(Me.GridColumn_Remarks, "GridColumn_Remarks")
            Me.GridColumn_Remarks.FieldName = "REMARK"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
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
            'M_03_00301
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.GridControl_TurnoverDtl)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_00301"
            CTag31.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag31.CalculatorRequired = True
            CTag31.ComboValueTextBox = Nothing
            CTag31.ControlRelatedCode = Nothing
            CTag31.DateButtonTextBox = Nothing
            CTag31.DateTimeButtonTextBox = Nothing
            CTag31.DisplayLinkControl = Nothing
            CTag31.DisplayLinkDisplayFieldName = Nothing
            CTag31.DisplayLinkKeyFieldName = Nothing
            CTag31.DisplayLinkTable = Nothing
            CTag31.FlexgridEditItem = ""
            CTag31.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag31.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag31.IsButtonCustomed = False
            CTag31.IsTextValid = True
            CTag31.KeyValueAbsentable = False
            CTag31.LeagleText = ""
            CTag31.NumericButtonTextBox = Nothing
            CTag31.ParentControl = Me
            CTag31.SkipValidate = False
            CTag31.TimeButtonTextBox = Nothing
            CTag31.ToolTip = ""
            CTag31.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag31
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            Me.Panel_ConsignStatus.ResumeLayout(False)
            Me.Panel_ConsignStatus.PerformLayout()
            CType(Me.LookUpEdit_ConsignStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_TurnoverStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_TurnoverType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_CustomerCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_SupplierCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_EmployeeCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_TurnoverDtl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStrip_Grid.ResumeLayout(False)
            CType(Me.GridView_TurnoverDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverType, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverStyle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ToolStripButton_General As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents LookUpEdit_Pos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_ToDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_FromDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GridControl_TurnoverDtl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_TurnoverDtl As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverTime As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PosName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverStyle As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverStyle As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents LookUpEdit_TurnoverType As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label_CustomerID As System.Windows.Forms.Label
        Friend WithEvents Label_CustomerName As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_CustomerCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label_Customer As System.Windows.Forms.Label
        Friend WithEvents Label_SupplierID As System.Windows.Forms.Label
        Friend WithEvents Label_SupplierName As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_SupplierCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label_Supplier As System.Windows.Forms.Label
        Friend WithEvents Label_EmployeeID As System.Windows.Forms.Label
        Friend WithEvents Label_EmployeeName As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_EmployeeCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_ConsignStatus As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_TurnoverStyle As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Panel_ConsignStatus As System.Windows.Forms.Panel
        Friend WithEvents ContextMenuStrip_Grid As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ToolStripMenuItem_CopyTurnoverCode As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GridColumn_OrigionUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_OrigionSunPrice As DevExpress.XtraGrid.Columns.GridColumn

#End Region

    End Class

End Namespace
