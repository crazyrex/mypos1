Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_01401
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
        Friend WithEvents ToolStripButton_ShowFilter As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_ShowFilter = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.LookUpEdit_Pos = New DevExpress.XtraEditors.LookUpEdit
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label_WareID = New System.Windows.Forms.Label
            Me.Label_WareName = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.ButtonEdit_WareCode = New DevExpress.XtraEditors.ButtonEdit
            Me.GridControl_TurnoverDtl = New DevExpress.XtraGrid.GridControl
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridView_TurnoverDtl = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_StockingOrigionUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_StockingUnitCost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CurrentAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitCost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_OrigionalPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_TurnoverDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverBookStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_TurnoverDtl, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_ShowFilter, Me.ToolStripButton_Close})
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
            'ToolStripButton_ShowFilter
            '
            Me.ToolStripButton_ShowFilter.Name = "ToolStripButton_ShowFilter"
            Me.ToolStripButton_ShowFilter.Size = New System.Drawing.Size(57, 22)
            Me.ToolStripButton_ShowFilter.Text = "筛选条件"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Close.Text = "关闭"
            '
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.Controls.Add(Me.ButtonEdit_WareCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label3)
            Me.PanelControl_Filter.Controls.Add(Me.Label_WareName)
            Me.PanelControl_Filter.Controls.Add(Me.Label_WareID)
            Me.PanelControl_Filter.Controls.Add(Me.LookUpEdit_Pos)
            Me.PanelControl_Filter.Controls.Add(Me.Label5)
            Me.PanelControl_Filter.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl_Filter.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
            Me.PanelControl_Filter.Size = New System.Drawing.Size(700, 78)
            Me.PanelControl_Filter.TabIndex = 10001
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
            CTag7.ParentControl = Me.PanelControl_Filter
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag7
            '
            'LookUpEdit_Pos
            '
            Me.LookUpEdit_Pos.Location = New System.Drawing.Point(73, 12)
            Me.LookUpEdit_Pos.Name = "LookUpEdit_Pos"
            Me.LookUpEdit_Pos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LookUpEdit_Pos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Pos.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_Pos.Properties.NullText = ""
            Me.LookUpEdit_Pos.Properties.ValueMember = "POS_ID"
            Me.LookUpEdit_Pos.Size = New System.Drawing.Size(134, 21)
            Me.LookUpEdit_Pos.TabIndex = 10008
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
            CTag5.ParentControl = Me.LookUpEdit_Pos
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_Pos.Tag = CTag5
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.White
            Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label5.Location = New System.Drawing.Point(12, 15)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(31, 15)
            Me.Label5.TabIndex = 10007
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
            CTag6.ParentControl = Me.Label5
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label5.Tag = CTag6
            Me.Label5.Text = "地点"
            '
            'Label_WareID
            '
            Me.Label_WareID.BackColor = System.Drawing.Color.White
            Me.Label_WareID.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_WareID.ForeColor = System.Drawing.Color.Black
            Me.Label_WareID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_WareID.Location = New System.Drawing.Point(396, 46)
            Me.Label_WareID.Name = "Label_WareID"
            Me.Label_WareID.Size = New System.Drawing.Size(31, 15)
            Me.Label_WareID.TabIndex = 10009
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
            CTag4.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag4.IsButtonCustomed = False
            CTag4.IsTextValid = True
            CTag4.KeyValueAbsentable = False
            CTag4.LeagleText = ""
            CTag4.NumericButtonTextBox = Nothing
            CTag4.ParentControl = Me.Label_WareID
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareID.Tag = CTag4
            Me.Label_WareID.Text = "ID"
            Me.Label_WareID.Visible = False
            '
            'Label_WareName
            '
            Me.Label_WareName.BackColor = System.Drawing.Color.White
            Me.Label_WareName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_WareName.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_WareName.ForeColor = System.Drawing.Color.Black
            Me.Label_WareName.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_WareName.Location = New System.Drawing.Point(208, 46)
            Me.Label_WareName.Name = "Label_WareName"
            Me.Label_WareName.Size = New System.Drawing.Size(182, 15)
            Me.Label_WareName.TabIndex = 10010
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
            CTag3.ParentControl = Me.Label_WareName
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareName.Tag = CTag3
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label3.Location = New System.Drawing.Point(12, 46)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 15)
            Me.Label3.TabIndex = 10011
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
            CTag2.ParentControl = Me.Label3
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag2
            Me.Label3.Text = "货品代码"
            '
            'ButtonEdit_WareCode
            '
            Me.ButtonEdit_WareCode.Location = New System.Drawing.Point(73, 43)
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_WareCode.Size = New System.Drawing.Size(132, 21)
            Me.ButtonEdit_WareCode.TabIndex = 10012
            '
            'GridControl_TurnoverDtl
            '
            Me.GridControl_TurnoverDtl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_TurnoverDtl.EmbeddedNavigator.Name = ""
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
            CTag8.ParentControl = Me.GridControl_TurnoverDtl.EmbeddedNavigator
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_TurnoverDtl.EmbeddedNavigator.Tag = CTag8
            Me.GridControl_TurnoverDtl.Location = New System.Drawing.Point(0, 103)
            Me.GridControl_TurnoverDtl.MainView = Me.GridView_TurnoverDtl
            Me.GridControl_TurnoverDtl.Name = "GridControl_TurnoverDtl"
            Me.GridControl_TurnoverDtl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select, Me.RepositoryItemLookUpEdit_TurnoverBookStatus})
            Me.GridControl_TurnoverDtl.Size = New System.Drawing.Size(700, 397)
            Me.GridControl_TurnoverDtl.TabIndex = 10002
            Me.GridControl_TurnoverDtl.TabStop = False
            Me.GridControl_TurnoverDtl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_TurnoverDtl})
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AutoHeight = False
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'RepositoryItemLookUpEdit_TurnoverBookStatus
            '
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.AutoHeight = False
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.Name = "RepositoryItemLookUpEdit_TurnoverBookStatus"
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.NullText = ""
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.ValueMember = "ITEM_VALUE"
            '
            'GridView_TurnoverDtl
            '
            Me.GridView_TurnoverDtl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_CurrentAmount, Me.GridColumn_StockingUnitCost, Me.GridColumn_StockingOrigionUnitPrice, Me.GridColumn_WareCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_WareAmount, Me.GridColumn_SumPrice, Me.GridColumn_UnitName, Me.GridColumn_UnitPrice, Me.GridColumn_UnitCost, Me.GridColumn_OrigionalPrice, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "ROW_HIGHLIGHT_OUT_OF_STOCK"
            Me.GridView_TurnoverDtl.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.GridView_TurnoverDtl.GridControl = Me.GridControl_TurnoverDtl
            Me.GridView_TurnoverDtl.Name = "GridView_TurnoverDtl"
            Me.GridView_TurnoverDtl.OptionsView.ColumnAutoWidth = False
            Me.GridView_TurnoverDtl.OptionsView.ShowFooter = True
            Me.GridView_TurnoverDtl.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_WareCode
            '
            Me.GridColumn_WareCode.Caption = "货品代码"
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_WareCode.Visible = True
            Me.GridColumn_WareCode.VisibleIndex = 0
            Me.GridColumn_WareCode.Width = 60
            '
            'GridColumn_StockingOrigionUnitPrice
            '
            Me.GridColumn_StockingOrigionUnitPrice.Caption = "单位原价"
            Me.GridColumn_StockingOrigionUnitPrice.FieldName = "STOCKING_ORIGION_UNIT_PRICE"
            Me.GridColumn_StockingOrigionUnitPrice.Name = "GridColumn_StockingOrigionUnitPrice"
            Me.GridColumn_StockingOrigionUnitPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_StockingOrigionUnitPrice.Visible = True
            Me.GridColumn_StockingOrigionUnitPrice.VisibleIndex = 1
            Me.GridColumn_StockingOrigionUnitPrice.Width = 60
            '
            'GridColumn_WareName
            '
            Me.GridColumn_WareName.Caption = "货品名称"
            Me.GridColumn_WareName.FieldName = "WARE_NAME"
            Me.GridColumn_WareName.Name = "GridColumn_WareName"
            Me.GridColumn_WareName.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareName.Visible = True
            Me.GridColumn_WareName.VisibleIndex = 2
            Me.GridColumn_WareName.Width = 60
            '
            'GridColumn_StockingUnitCost
            '
            Me.GridColumn_StockingUnitCost.Caption = "单位成本"
            Me.GridColumn_StockingUnitCost.FieldName = "STOCKING_UNIT_COST"
            Me.GridColumn_StockingUnitCost.Name = "GridColumn_StockingUnitCost"
            Me.GridColumn_StockingUnitCost.Visible = True
            Me.GridColumn_StockingUnitCost.VisibleIndex = 3
            Me.GridColumn_StockingUnitCost.Width = 60
            '
            'GridColumn_Spec
            '
            Me.GridColumn_Spec.Caption = "货品规格"
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            Me.GridColumn_Spec.Visible = True
            Me.GridColumn_Spec.VisibleIndex = 4
            Me.GridColumn_Spec.Width = 60
            '
            'GridColumn_Model
            '
            Me.GridColumn_Model.Caption = "货品型号"
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            Me.GridColumn_Model.Visible = True
            Me.GridColumn_Model.VisibleIndex = 5
            Me.GridColumn_Model.Width = 60
            '
            'GridColumn_Attribute1
            '
            Me.GridColumn_Attribute1.Caption = "属性1"
            Me.GridColumn_Attribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_Attribute1.Name = "GridColumn_Attribute1"
            Me.GridColumn_Attribute1.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute1.Visible = True
            Me.GridColumn_Attribute1.VisibleIndex = 6
            Me.GridColumn_Attribute1.Width = 43
            '
            'GridColumn_Attribute2
            '
            Me.GridColumn_Attribute2.Caption = "属性2"
            Me.GridColumn_Attribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_Attribute2.Name = "GridColumn_Attribute2"
            Me.GridColumn_Attribute2.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute2.Visible = True
            Me.GridColumn_Attribute2.VisibleIndex = 7
            Me.GridColumn_Attribute2.Width = 43
            '
            'GridColumn_Attribute3
            '
            Me.GridColumn_Attribute3.Caption = "属性3"
            Me.GridColumn_Attribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_Attribute3.Name = "GridColumn_Attribute3"
            Me.GridColumn_Attribute3.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute3.Visible = True
            Me.GridColumn_Attribute3.VisibleIndex = 8
            Me.GridColumn_Attribute3.Width = 43
            '
            'GridColumn_Attribute4
            '
            Me.GridColumn_Attribute4.Caption = "属性4"
            Me.GridColumn_Attribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_Attribute4.Name = "GridColumn_Attribute4"
            Me.GridColumn_Attribute4.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute4.Visible = True
            Me.GridColumn_Attribute4.VisibleIndex = 9
            Me.GridColumn_Attribute4.Width = 43
            '
            'GridColumn_WareAmount
            '
            Me.GridColumn_WareAmount.Caption = "Qty."
            Me.GridColumn_WareAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_WareAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_WareAmount.FieldName = "WARE_AMOUNT"
            Me.GridColumn_WareAmount.Name = "GridColumn_WareAmount"
            Me.GridColumn_WareAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridColumn_WareAmount.Width = 36
            '
            'GridColumn_SumPrice
            '
            Me.GridColumn_SumPrice.Caption = "Extend"
            Me.GridColumn_SumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SumPrice.FieldName = "SUM_PRICE"
            Me.GridColumn_SumPrice.Name = "GridColumn_SumPrice"
            Me.GridColumn_SumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_SumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridColumn_SumPrice.Width = 36
            '
            'GridColumn_CurrentAmount
            '
            Me.GridColumn_CurrentAmount.Caption = "当前数量"
            Me.GridColumn_CurrentAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_CurrentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_CurrentAmount.FieldName = "CURRENT_AMOUNT"
            Me.GridColumn_CurrentAmount.Name = "GridColumn_CurrentAmount"
            Me.GridColumn_CurrentAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_CurrentAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridColumn_CurrentAmount.Visible = True
            Me.GridColumn_CurrentAmount.VisibleIndex = 10
            Me.GridColumn_CurrentAmount.Width = 84
            '
            'GridColumn_UnitName
            '
            Me.GridColumn_UnitName.Caption = "单位名称"
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitName.Visible = True
            Me.GridColumn_UnitName.VisibleIndex = 11
            Me.GridColumn_UnitName.Width = 36
            '
            'GridColumn_UnitPrice
            '
            Me.GridColumn_UnitPrice.Caption = "出货价"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitPrice.FieldName = "UNIT_PRICE"
            Me.GridColumn_UnitPrice.Name = "GridColumn_UnitPrice"
            Me.GridColumn_UnitPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitPrice.Visible = True
            Me.GridColumn_UnitPrice.VisibleIndex = 12
            Me.GridColumn_UnitPrice.Width = 48
            '
            'GridColumn_UnitCost
            '
            Me.GridColumn_UnitCost.Caption = "成本"
            Me.GridColumn_UnitCost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitCost.FieldName = "UNIT_COST"
            Me.GridColumn_UnitCost.Name = "GridColumn_UnitCost"
            Me.GridColumn_UnitCost.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitCost.Visible = True
            Me.GridColumn_UnitCost.VisibleIndex = 13
            Me.GridColumn_UnitCost.Width = 36
            '
            'GridColumn_OrigionalPrice
            '
            Me.GridColumn_OrigionalPrice.Caption = "原单价"
            Me.GridColumn_OrigionalPrice.FieldName = "ORIGION_UNIT_PRICE"
            Me.GridColumn_OrigionalPrice.Name = "GridColumn_OrigionalPrice"
            Me.GridColumn_OrigionalPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_OrigionalPrice.Visible = True
            Me.GridColumn_OrigionalPrice.VisibleIndex = 14
            '
            'GridColumn_Remarks
            '
            Me.GridColumn_Remarks.Caption = "备注"
            Me.GridColumn_Remarks.FieldName = "REMARK"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            Me.GridColumn_Remarks.Visible = True
            Me.GridColumn_Remarks.VisibleIndex = 15
            Me.GridColumn_Remarks.Width = 36
            '
            'GridColumn_RowHighlight
            '
            Me.GridColumn_RowHighlight.Caption = "高亮显示"
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            Me.GridColumn_RowHighlight.Width = 60
            '
            'M_03_01401
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.GridControl_TurnoverDtl)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_03_01401"
            Me.Size = New System.Drawing.Size(700, 500)
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
            CTag9.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag9.IsButtonCustomed = False
            CTag9.IsTextValid = True
            CTag9.KeyValueAbsentable = False
            CTag9.LeagleText = ""
            CTag9.NumericButtonTextBox = Nothing
            CTag9.ParentControl = Me
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag9
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_TurnoverDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverBookStatus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_TurnoverDtl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents ButtonEdit_WareCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label_WareName As System.Windows.Forms.Label
        Friend WithEvents Label_WareID As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_Pos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents GridControl_TurnoverDtl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_TurnoverDtl As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_StockingOrigionUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_StockingUnitCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverBookStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CurrentAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_OrigionalPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

#End Region

    End Class

End Namespace

