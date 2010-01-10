Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_01304
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
        Friend WithEvents ToolStripButton_Save As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label6 = New System.Windows.Forms.Label
            Me.GridControl_Ware = New DevExpress.XtraGrid.GridControl
            Me.GridView_Ware = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_RowSelect = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ApplyQuantity = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_Quantity = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_UnitPrice = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_Unitcost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_UnitCost = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_SupplierID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_SupplierID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_MinQty = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_Ware, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Ware, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_UnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_UnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_SupplierID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_MinQty, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Add, Me.ToolStripButton_Remove, Me.ToolStripButton_Save, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
            Me.ToolStrip_Form.Size = New System.Drawing.Size(700, 25)
            Me.ToolStrip_Form.TabIndex = 10000
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
            'ToolStripButton_Add
            '
            Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
            Me.ToolStripButton_Add.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_Add.Text = "添加"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.Name = "ToolStripButton_Remove"
            Me.ToolStripButton_Remove.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_Remove.Text = "去除"
            '
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            Me.ToolStripButton_Save.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_Save.Text = "保存"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_Close.Text = "关闭"
            '
            'PanelControl1
            '
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl1.Controls.Add(Me.Label6)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl1.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(700, 53)
            Me.PanelControl1.TabIndex = 10001
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
            CTag4.ParentControl = Me.PanelControl1
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag4
            '
            'TextEdit_Search
            '
            Me.TextEdit_Search.Location = New System.Drawing.Point(82, 18)
            Me.TextEdit_Search.Name = "TextEdit_Search"
            Me.TextEdit_Search.Size = New System.Drawing.Size(172, 21)
            Me.TextEdit_Search.TabIndex = 10000
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
            CTag2.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag2.IsButtonCustomed = False
            CTag2.IsTextValid = True
            CTag2.KeyValueAbsentable = False
            CTag2.LeagleText = ""
            CTag2.NumericButtonTextBox = Nothing
            CTag2.ParentControl = Me.TextEdit_Search
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag2
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.White
            Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.Location = New System.Drawing.Point(21, 20)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(31, 15)
            Me.Label6.TabIndex = 10000
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
            CTag3.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag3.IsButtonCustomed = False
            CTag3.IsTextValid = True
            CTag3.KeyValueAbsentable = False
            CTag3.LeagleText = ""
            CTag3.NumericButtonTextBox = Nothing
            CTag3.ParentControl = Me.Label6
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label6.Tag = CTag3
            Me.Label6.Text = "查找"
            '
            'GridControl_Ware
            '
            Me.GridControl_Ware.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_Ware.EmbeddedNavigator.Name = ""
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
            CTag5.ParentControl = Me.GridControl_Ware.EmbeddedNavigator
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Ware.EmbeddedNavigator.Tag = CTag5
            Me.GridControl_Ware.Location = New System.Drawing.Point(0, 78)
            Me.GridControl_Ware.MainView = Me.GridView_Ware
            Me.GridControl_Ware.Name = "GridControl_Ware"
            Me.GridControl_Ware.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select, Me.RepositoryItemLookUpEdit_SupplierID, Me.RepositoryItemCalcEdit_UnitPrice, Me.RepositoryItemCalcEdit_UnitCost, Me.RepositoryItemCalcEdit_MinQty, Me.RepositoryItemCalcEdit_Quantity})
            Me.GridControl_Ware.Size = New System.Drawing.Size(700, 422)
            Me.GridControl_Ware.TabIndex = 10002
            Me.GridControl_Ware.TabStop = False
            Me.GridControl_Ware.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Ware})
            '
            'GridView_Ware
            '
            Me.GridView_Ware.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_RowSelect, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_ApplyQuantity, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_UnitName, Me.GridColumn_UnitPrice, Me.GridColumn_Unitcost, Me.GridColumn_SupplierID, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_Ware.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_Ware.GridControl = Me.GridControl_Ware
            Me.GridView_Ware.Name = "GridView_Ware"
            Me.GridView_Ware.OptionsView.ColumnAutoWidth = False
            Me.GridView_Ware.OptionsView.ShowFooter = True
            Me.GridView_Ware.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_RowSelect
            '
            Me.GridColumn_RowSelect.Caption = "选择"
            Me.GridColumn_RowSelect.ColumnEdit = Me.RepositoryItemCheckEdit_Select
            Me.GridColumn_RowSelect.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_RowSelect.Name = "GridColumn_RowSelect"
            Me.GridColumn_RowSelect.Visible = True
            Me.GridColumn_RowSelect.VisibleIndex = 0
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AutoHeight = False
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'GridColumn_WareCode
            '
            Me.GridColumn_WareCode.Caption = "货品代码"
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_WareCode.Visible = True
            Me.GridColumn_WareCode.VisibleIndex = 2
            '
            'GridColumn_CustomCode
            '
            Me.GridColumn_CustomCode.Caption = "自定货号"
            Me.GridColumn_CustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_CustomCode.Name = "GridColumn_CustomCode"
            Me.GridColumn_CustomCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomCode.Visible = True
            Me.GridColumn_CustomCode.VisibleIndex = 3
            '
            'GridColumn_ApplyQuantity
            '
            Me.GridColumn_ApplyQuantity.Caption = "数量"
            Me.GridColumn_ApplyQuantity.ColumnEdit = Me.RepositoryItemCalcEdit_Quantity
            Me.GridColumn_ApplyQuantity.FieldName = "APPLY_QUANTITY"
            Me.GridColumn_ApplyQuantity.Name = "GridColumn_ApplyQuantity"
            Me.GridColumn_ApplyQuantity.Visible = True
            Me.GridColumn_ApplyQuantity.VisibleIndex = 1
            '
            'RepositoryItemCalcEdit_Quantity
            '
            Me.RepositoryItemCalcEdit_Quantity.AutoHeight = False
            Me.RepositoryItemCalcEdit_Quantity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_Quantity.Name = "RepositoryItemCalcEdit_Quantity"
            '
            'GridColumn_WareName
            '
            Me.GridColumn_WareName.Caption = "货品名称"
            Me.GridColumn_WareName.FieldName = "WARE_NAME"
            Me.GridColumn_WareName.Name = "GridColumn_WareName"
            Me.GridColumn_WareName.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareName.Visible = True
            Me.GridColumn_WareName.VisibleIndex = 4
            '
            'GridColumn_Spec
            '
            Me.GridColumn_Spec.Caption = "货品规格"
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            Me.GridColumn_Spec.Visible = True
            Me.GridColumn_Spec.VisibleIndex = 5
            '
            'GridColumn_Model
            '
            Me.GridColumn_Model.Caption = "货品型号"
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            Me.GridColumn_Model.Visible = True
            Me.GridColumn_Model.VisibleIndex = 6
            '
            'GridColumn_Attribute1
            '
            Me.GridColumn_Attribute1.Caption = "属性1"
            Me.GridColumn_Attribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_Attribute1.Name = "GridColumn_Attribute1"
            Me.GridColumn_Attribute1.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute1.Visible = True
            Me.GridColumn_Attribute1.VisibleIndex = 7
            '
            'GridColumn_Attribute2
            '
            Me.GridColumn_Attribute2.Caption = "属性2"
            Me.GridColumn_Attribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_Attribute2.Name = "GridColumn_Attribute2"
            Me.GridColumn_Attribute2.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute2.Visible = True
            Me.GridColumn_Attribute2.VisibleIndex = 8
            '
            'GridColumn_Attribute3
            '
            Me.GridColumn_Attribute3.Caption = "属性3"
            Me.GridColumn_Attribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_Attribute3.Name = "GridColumn_Attribute3"
            Me.GridColumn_Attribute3.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute3.Visible = True
            Me.GridColumn_Attribute3.VisibleIndex = 9
            '
            'GridColumn_Attribute4
            '
            Me.GridColumn_Attribute4.Caption = "属性4"
            Me.GridColumn_Attribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_Attribute4.Name = "GridColumn_Attribute4"
            Me.GridColumn_Attribute4.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute4.Visible = True
            Me.GridColumn_Attribute4.VisibleIndex = 10
            '
            'GridColumn_UnitName
            '
            Me.GridColumn_UnitName.Caption = "单位"
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitName.Visible = True
            Me.GridColumn_UnitName.VisibleIndex = 11
            '
            'GridColumn_UnitPrice
            '
            Me.GridColumn_UnitPrice.Caption = "单价"
            Me.GridColumn_UnitPrice.ColumnEdit = Me.RepositoryItemCalcEdit_UnitPrice
            Me.GridColumn_UnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitPrice.FieldName = "UNIT_PRICE"
            Me.GridColumn_UnitPrice.Name = "GridColumn_UnitPrice"
            Me.GridColumn_UnitPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitPrice.Visible = True
            Me.GridColumn_UnitPrice.VisibleIndex = 12
            '
            'RepositoryItemCalcEdit_UnitPrice
            '
            Me.RepositoryItemCalcEdit_UnitPrice.AutoHeight = False
            Me.RepositoryItemCalcEdit_UnitPrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_UnitPrice.Name = "RepositoryItemCalcEdit_UnitPrice"
            '
            'GridColumn_Unitcost
            '
            Me.GridColumn_Unitcost.Caption = "成本"
            Me.GridColumn_Unitcost.ColumnEdit = Me.RepositoryItemCalcEdit_UnitCost
            Me.GridColumn_Unitcost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Unitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Unitcost.FieldName = "UNIT_COST"
            Me.GridColumn_Unitcost.Name = "GridColumn_Unitcost"
            Me.GridColumn_Unitcost.OptionsColumn.AllowFocus = False
            Me.GridColumn_Unitcost.Visible = True
            Me.GridColumn_Unitcost.VisibleIndex = 13
            '
            'RepositoryItemCalcEdit_UnitCost
            '
            Me.RepositoryItemCalcEdit_UnitCost.AutoHeight = False
            Me.RepositoryItemCalcEdit_UnitCost.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_UnitCost.Name = "RepositoryItemCalcEdit_UnitCost"
            '
            'GridColumn_SupplierID
            '
            Me.GridColumn_SupplierID.Caption = "供应商名称"
            Me.GridColumn_SupplierID.ColumnEdit = Me.RepositoryItemLookUpEdit_SupplierID
            Me.GridColumn_SupplierID.FieldName = "SUPPLIER_ID"
            Me.GridColumn_SupplierID.Name = "GridColumn_SupplierID"
            Me.GridColumn_SupplierID.OptionsColumn.AllowFocus = False
            Me.GridColumn_SupplierID.Visible = True
            Me.GridColumn_SupplierID.VisibleIndex = 14
            '
            'RepositoryItemLookUpEdit_SupplierID
            '
            Me.RepositoryItemLookUpEdit_SupplierID.AutoHeight = False
            Me.RepositoryItemLookUpEdit_SupplierID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_SupplierID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIER_NAME", "Name1", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_SupplierID.DisplayMember = "SUPPLIER_NAME"
            Me.RepositoryItemLookUpEdit_SupplierID.Name = "RepositoryItemLookUpEdit_SupplierID"
            Me.RepositoryItemLookUpEdit_SupplierID.NullText = ""
            Me.RepositoryItemLookUpEdit_SupplierID.ValueMember = "SUPPLIER_ID"
            '
            'GridColumn_Remarks
            '
            Me.GridColumn_Remarks.Caption = "备注"
            Me.GridColumn_Remarks.FieldName = "REMARK"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            Me.GridColumn_Remarks.Visible = True
            Me.GridColumn_Remarks.VisibleIndex = 15
            '
            'GridColumn_RowHighlight
            '
            Me.GridColumn_RowHighlight.Caption = "高亮显示"
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemCalcEdit_MinQty
            '
            Me.RepositoryItemCalcEdit_MinQty.AutoHeight = False
            Me.RepositoryItemCalcEdit_MinQty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_MinQty.Name = "RepositoryItemCalcEdit_MinQty"
            '
            'M_02_01304
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.GridControl_Ware)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_02_01304"
            Me.Size = New System.Drawing.Size(700, 500)
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
            CTag6.ParentControl = Me
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag6
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_Ware, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Ware, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_UnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_UnitCost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_SupplierID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_MinQty, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents GridControl_Ware As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Ware As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_RowSelect As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ApplyQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_Quantity As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents RepositoryItemCalcEdit_MinQty As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_UnitPrice As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_Unitcost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_UnitCost As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_SupplierID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_SupplierID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ToolStripButton_Add As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace

