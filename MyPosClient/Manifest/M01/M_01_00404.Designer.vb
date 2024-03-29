Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00404
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
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_01_00404))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Import = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.ButtonEdit_FileName = New DevExpress.XtraEditors.ButtonEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridControl_WarePriceSetDtl = New DevExpress.XtraGrid.GridControl
            Me.GridView_WarePriceSetDtl = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_RowSelected = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_RowSelected = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Unitcost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.RepositoryItemCalcEdit_LowerLimit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.RepositoryItemCalcEdit_IndividualDiscount = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.OpenFileDialog_ImportFile = New System.Windows.Forms.OpenFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.ButtonEdit_FileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_WarePriceSetDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_WarePriceSetDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_RowSelected, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_LowerLimit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_IndividualDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.AccessibleDescription = Nothing
            Me.ToolStrip_Form.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStrip_Form, "ToolStrip_Form")
            Me.ToolStrip_Form.BackgroundImage = Nothing
            Me.ToolStrip_Form.Font = Nothing
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Import, Me.ToolStripButton_Remove, Me.ToolStripButton_Close})
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
            'ToolStripButton_Import
            '
            Me.ToolStripButton_Import.AccessibleDescription = Nothing
            Me.ToolStripButton_Import.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Import, "ToolStripButton_Import")
            Me.ToolStripButton_Import.BackgroundImage = Nothing
            Me.ToolStripButton_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Import.Name = "ToolStripButton_Import"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.AccessibleDescription = Nothing
            Me.ToolStripButton_Remove.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Remove, "ToolStripButton_Remove")
            Me.ToolStripButton_Remove.BackgroundImage = Nothing
            Me.ToolStripButton_Remove.Name = "ToolStripButton_Remove"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.AccessibleDescription = Nothing
            Me.ToolStripButton_Close.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Close, "ToolStripButton_Close")
            Me.ToolStripButton_Close.BackgroundImage = Nothing
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            '
            'PanelControl1
            '
            Me.PanelControl1.AccessibleDescription = Nothing
            Me.PanelControl1.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl1, "PanelControl1")
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.Controls.Add(Me.ButtonEdit_FileName)
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Name = "PanelControl1"
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
            'ButtonEdit_FileName
            '
            resources.ApplyResources(Me.ButtonEdit_FileName, "ButtonEdit_FileName")
            Me.ButtonEdit_FileName.BackgroundImage = Nothing
            Me.ButtonEdit_FileName.EditValue = Nothing
            Me.ButtonEdit_FileName.Name = "ButtonEdit_FileName"
            Me.ButtonEdit_FileName.Properties.AccessibleDescription = Nothing
            Me.ButtonEdit_FileName.Properties.AccessibleName = Nothing
            Me.ButtonEdit_FileName.Properties.AutoHeight = CType(resources.GetObject("ButtonEdit_FileName.Properties.AutoHeight"), Boolean)
            Me.ButtonEdit_FileName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_FileName.Properties.Mask.AutoComplete = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.ButtonEdit_FileName.Properties.Mask.BeepOnError = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.BeepOnError"), Boolean)
            Me.ButtonEdit_FileName.Properties.Mask.EditMask = resources.GetString("ButtonEdit_FileName.Properties.Mask.EditMask")
            Me.ButtonEdit_FileName.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.ButtonEdit_FileName.Properties.Mask.MaskType = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.ButtonEdit_FileName.Properties.Mask.PlaceHolder = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.PlaceHolder"), Char)
            Me.ButtonEdit_FileName.Properties.Mask.SaveLiteral = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.SaveLiteral"), Boolean)
            Me.ButtonEdit_FileName.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.ButtonEdit_FileName.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag2.ParentControl = Me.ButtonEdit_FileName
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_FileName.Tag = CTag2
            '
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.Font = Nothing
            Me.Label1.Name = "Label1"
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
            CTag3.ParentControl = Me.Label1
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag3
            '
            'GridColumn_RowHighlight
            '
            resources.ApplyResources(Me.GridColumn_RowHighlight, "GridColumn_RowHighlight")
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'GridControl_WarePriceSetDtl
            '
            Me.GridControl_WarePriceSetDtl.AccessibleDescription = Nothing
            Me.GridControl_WarePriceSetDtl.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_WarePriceSetDtl, "GridControl_WarePriceSetDtl")
            Me.GridControl_WarePriceSetDtl.BackgroundImage = Nothing
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_WarePriceSetDtl.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_WarePriceSetDtl.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_WarePriceSetDtl.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.Name = ""
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_WarePriceSetDtl.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_WarePriceSetDtl.EmbeddedNavigator.ToolTip")
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_WarePriceSetDtl.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_WarePriceSetDtl.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_WarePriceSetDtl.Font = Nothing
            Me.GridControl_WarePriceSetDtl.MainView = Me.GridView_WarePriceSetDtl
            Me.GridControl_WarePriceSetDtl.Name = "GridControl_WarePriceSetDtl"
            Me.GridControl_WarePriceSetDtl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select, Me.RepositoryItemCalcEdit_LowerLimit, Me.RepositoryItemCalcEdit_IndividualDiscount, Me.RepositoryItemCheckEdit_RowSelected})
            Me.GridControl_WarePriceSetDtl.TabStop = False
            Me.GridControl_WarePriceSetDtl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_WarePriceSetDtl})
            '
            'GridView_WarePriceSetDtl
            '
            resources.ApplyResources(Me.GridView_WarePriceSetDtl, "GridView_WarePriceSetDtl")
            Me.GridView_WarePriceSetDtl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_RowSelected, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_UnitName, Me.GridColumn_UnitPrice, Me.GridColumn_Unitcost, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_WarePriceSetDtl.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_WarePriceSetDtl.GridControl = Me.GridControl_WarePriceSetDtl
            Me.GridView_WarePriceSetDtl.Name = "GridView_WarePriceSetDtl"
            Me.GridView_WarePriceSetDtl.OptionsView.ColumnAutoWidth = False
            Me.GridView_WarePriceSetDtl.OptionsView.ShowFooter = True
            Me.GridView_WarePriceSetDtl.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_RowSelected
            '
            resources.ApplyResources(Me.GridColumn_RowSelected, "GridColumn_RowSelected")
            Me.GridColumn_RowSelected.ColumnEdit = Me.RepositoryItemCheckEdit_RowSelected
            Me.GridColumn_RowSelected.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_RowSelected.Name = "GridColumn_RowSelected"
            '
            'RepositoryItemCheckEdit_RowSelected
            '
            Me.RepositoryItemCheckEdit_RowSelected.AccessibleDescription = Nothing
            Me.RepositoryItemCheckEdit_RowSelected.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCheckEdit_RowSelected, "RepositoryItemCheckEdit_RowSelected")
            Me.RepositoryItemCheckEdit_RowSelected.Name = "RepositoryItemCheckEdit_RowSelected"
            '
            'GridColumn_WareCode
            '
            resources.ApplyResources(Me.GridColumn_WareCode, "GridColumn_WareCode")
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_WareCode.SummaryItem.DisplayFormat")
            Me.GridColumn_WareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
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
            'GridColumn_Unitcost
            '
            resources.ApplyResources(Me.GridColumn_Unitcost, "GridColumn_Unitcost")
            Me.GridColumn_Unitcost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Unitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Unitcost.FieldName = "UNIT_COST"
            Me.GridColumn_Unitcost.Name = "GridColumn_Unitcost"
            Me.GridColumn_Unitcost.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Remarks
            '
            resources.ApplyResources(Me.GridColumn_Remarks, "GridColumn_Remarks")
            Me.GridColumn_Remarks.FieldName = "REMARK"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AccessibleDescription = Nothing
            Me.RepositoryItemCheckEdit_Select.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCheckEdit_Select, "RepositoryItemCheckEdit_Select")
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'RepositoryItemCalcEdit_LowerLimit
            '
            Me.RepositoryItemCalcEdit_LowerLimit.AccessibleDescription = Nothing
            Me.RepositoryItemCalcEdit_LowerLimit.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCalcEdit_LowerLimit, "RepositoryItemCalcEdit_LowerLimit")
            Me.RepositoryItemCalcEdit_LowerLimit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_LowerLimit.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_LowerLimit.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemCalcEdit_LowerLimit.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemCalcEdit_LowerLimit.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemCalcEdit_LowerLimit.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemCalcEdit_LowerLimit.Mask.EditMask = resources.GetString("RepositoryItemCalcEdit_LowerLimit.Mask.EditMask")
            Me.RepositoryItemCalcEdit_LowerLimit.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemCalcEdit_LowerLimit.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemCalcEdit_LowerLimit.Mask.MaskType = CType(resources.GetObject("RepositoryItemCalcEdit_LowerLimit.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemCalcEdit_LowerLimit.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemCalcEdit_LowerLimit.Mask.PlaceHolder"), Char)
            Me.RepositoryItemCalcEdit_LowerLimit.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemCalcEdit_LowerLimit.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemCalcEdit_LowerLimit.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemCalcEdit_LowerLimit.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemCalcEdit_LowerLimit.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemCalcEdit_LowerLimit.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemCalcEdit_LowerLimit.Name = "RepositoryItemCalcEdit_LowerLimit"
            '
            'RepositoryItemCalcEdit_IndividualDiscount
            '
            Me.RepositoryItemCalcEdit_IndividualDiscount.AccessibleDescription = Nothing
            Me.RepositoryItemCalcEdit_IndividualDiscount.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCalcEdit_IndividualDiscount, "RepositoryItemCalcEdit_IndividualDiscount")
            Me.RepositoryItemCalcEdit_IndividualDiscount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_IndividualDiscount.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_IndividualDiscount.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemCalcEdit_IndividualDiscount.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemCalcEdit_IndividualDiscount.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemCalcEdit_IndividualDiscount.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemCalcEdit_IndividualDiscount.Mask.EditMask = resources.GetString("RepositoryItemCalcEdit_IndividualDiscount.Mask.EditMask")
            Me.RepositoryItemCalcEdit_IndividualDiscount.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemCalcEdit_IndividualDiscount.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemCalcEdit_IndividualDiscount.Mask.MaskType = CType(resources.GetObject("RepositoryItemCalcEdit_IndividualDiscount.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemCalcEdit_IndividualDiscount.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemCalcEdit_IndividualDiscount.Mask.PlaceHolder"), Char)
            Me.RepositoryItemCalcEdit_IndividualDiscount.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemCalcEdit_IndividualDiscount.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemCalcEdit_IndividualDiscount.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemCalcEdit_IndividualDiscount.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemCalcEdit_IndividualDiscount.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemCalcEdit_IndividualDiscount.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemCalcEdit_IndividualDiscount.Name = "RepositoryItemCalcEdit_IndividualDiscount"
            '
            'OpenFileDialog_ImportFile
            '
            resources.ApplyResources(Me.OpenFileDialog_ImportFile, "OpenFileDialog_ImportFile")
            '
            'M_01_00404
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_WarePriceSetDtl)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_01_00404"
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
            CTag5.ParentControl = Me
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag5
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.ButtonEdit_FileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_WarePriceSetDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_WarePriceSetDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_RowSelected, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_LowerLimit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_IndividualDiscount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents GridControl_WarePriceSetDtl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_WarePriceSetDtl As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Unitcost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents RepositoryItemCalcEdit_LowerLimit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents RepositoryItemCalcEdit_IndividualDiscount As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents ButtonEdit_FileName As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ToolStripButton_Import As System.Windows.Forms.ToolStripButton
        Friend WithEvents OpenFileDialog_ImportFile As System.Windows.Forms.OpenFileDialog
        Friend WithEvents GridColumn_RowSelected As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_RowSelected As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

#End Region

    End Class

End Namespace
