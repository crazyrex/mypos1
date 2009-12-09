Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00206
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
        Friend WithEvents ToolStripButton_Add As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.MemoEdit_WareCodes = New DevExpress.XtraEditors.MemoEdit
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.TreeListColumn_RowHighLight = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.TreeList_WareBomList = New DevExpress.XtraTreeList.TreeList
            Me.TreeListColumn_BelongWareCode = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.TreeListColumn_BelongWareName = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.TreeListColumn_BelongQty = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.RepositoryItemCalcEdit_BelongQty = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.TreeListColumn_WareBomType = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.RepositoryItemLookUpEdit_WareBomType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.MemoEdit_WareCodes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TreeList_WareBomList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_BelongQty, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_WareBomType, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Save, Me.ToolStripButton_Add, Me.ToolStripButton_Remove, Me.ToolStripButton_Refresh, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
            Me.ToolStrip_Form.Size = New System.Drawing.Size(530, 25)
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
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            Me.ToolStripButton_Save.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Save.Text = "保存"
            '
            'ToolStripButton_Add
            '
            Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
            Me.ToolStripButton_Add.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Add.Text = "添加"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.Name = "ToolStripButton_Remove"
            Me.ToolStripButton_Remove.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Remove.Text = "去除"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            Me.ToolStripButton_Refresh.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Refresh.Text = "刷新"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Close.Text = "关闭"
            '
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.Controls.Add(Me.MemoEdit_WareCodes)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl_Filter.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
            Me.PanelControl_Filter.Size = New System.Drawing.Size(530, 92)
            Me.PanelControl_Filter.TabIndex = 10001
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
            CTag6.ParentControl = Me.PanelControl_Filter
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag6
            '
            'MemoEdit_WareCodes
            '
            Me.MemoEdit_WareCodes.Location = New System.Drawing.Point(85, 8)
            Me.MemoEdit_WareCodes.Name = "MemoEdit_WareCodes"
            Me.MemoEdit_WareCodes.Size = New System.Drawing.Size(172, 77)
            Me.MemoEdit_WareCodes.TabIndex = 10001
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
            CTag2.ParentControl = Me.MemoEdit_WareCodes
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.MemoEdit_WareCodes.Tag = CTag2
            '
            'TextEdit_Search
            '
            Me.TextEdit_Search.EditValue = ""
            Me.TextEdit_Search.Location = New System.Drawing.Point(324, 64)
            Me.TextEdit_Search.Name = "TextEdit_Search"
            Me.TextEdit_Search.Size = New System.Drawing.Size(184, 21)
            Me.TextEdit_Search.TabIndex = 10000
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
            CTag3.ParentControl = Me.TextEdit_Search
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label2.Location = New System.Drawing.Point(24, 7)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(55, 15)
            Me.Label2.TabIndex = 10000
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
            CTag4.ParentControl = Me.Label2
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag4
            Me.Label2.Text = "商品条码"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(276, 67)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(31, 15)
            Me.Label1.TabIndex = 10000
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
            CTag5.ParentControl = Me.Label1
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag5
            Me.Label1.Text = "搜索"
            '
            'TreeListColumn_RowHighLight
            '
            Me.TreeListColumn_RowHighLight.Caption = "高亮显示"
            Me.TreeListColumn_RowHighLight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.TreeListColumn_RowHighLight.Name = "TreeListColumn_RowHighLight"
            '
            'TreeList_WareBomList
            '
            Me.TreeList_WareBomList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn_BelongWareCode, Me.TreeListColumn_BelongWareName, Me.TreeListColumn_BelongQty, Me.TreeListColumn_WareBomType, Me.TreeListColumn_RowHighLight})
            Me.TreeList_WareBomList.Dock = System.Windows.Forms.DockStyle.Fill
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.Appearance.Options.UseFont = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.TreeListColumn_RowHighLight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "ROW_HIGHLIGHT_BOM_ROOT"
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.Appearance.Options.UseForeColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.TreeListColumn_RowHighLight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "ROW_HIGHLIGHT_MODIFIED"
            Me.TreeList_WareBomList.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.TreeList_WareBomList.KeyFieldName = "BELONG_WARE__WARE_ID"
            Me.TreeList_WareBomList.Location = New System.Drawing.Point(0, 117)
            Me.TreeList_WareBomList.Name = "TreeList_WareBomList"
            Me.TreeList_WareBomList.OptionsView.AutoWidth = False
            Me.TreeList_WareBomList.ParentFieldName = "OWNING_WARE__WARE_ID"
            Me.TreeList_WareBomList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_WareBomType, Me.RepositoryItemCalcEdit_BelongQty})
            Me.TreeList_WareBomList.Size = New System.Drawing.Size(530, 383)
            Me.TreeList_WareBomList.TabIndex = 10002
            Me.TreeList_WareBomList.TabStop = False
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
            CTag7.ParentControl = Me.TreeList_WareBomList
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.TreeList_WareBomList.Tag = CTag7
            '
            'TreeListColumn_BelongWareCode
            '
            Me.TreeListColumn_BelongWareCode.Caption = "货号"
            Me.TreeListColumn_BelongWareCode.FieldName = "BELONG_WARE__WARE_CODE"
            Me.TreeListColumn_BelongWareCode.Name = "TreeListColumn_BelongWareCode"
            Me.TreeListColumn_BelongWareCode.OptionsColumn.AllowFocus = False
            Me.TreeListColumn_BelongWareCode.Visible = True
            Me.TreeListColumn_BelongWareCode.VisibleIndex = 0
            Me.TreeListColumn_BelongWareCode.Width = 37
            '
            'TreeListColumn_BelongWareName
            '
            Me.TreeListColumn_BelongWareName.Caption = "品名"
            Me.TreeListColumn_BelongWareName.FieldName = "BELONG_WARE__WARE_NAME"
            Me.TreeListColumn_BelongWareName.Name = "TreeListColumn_BelongWareName"
            Me.TreeListColumn_BelongWareName.OptionsColumn.AllowEdit = False
            Me.TreeListColumn_BelongWareName.OptionsColumn.AllowFocus = False
            Me.TreeListColumn_BelongWareName.Visible = True
            Me.TreeListColumn_BelongWareName.VisibleIndex = 1
            Me.TreeListColumn_BelongWareName.Width = 37
            '
            'TreeListColumn_BelongQty
            '
            Me.TreeListColumn_BelongQty.Caption = "组成数量"
            Me.TreeListColumn_BelongQty.ColumnEdit = Me.RepositoryItemCalcEdit_BelongQty
            Me.TreeListColumn_BelongQty.FieldName = "BELONG_QTY"
            Me.TreeListColumn_BelongQty.Name = "TreeListColumn_BelongQty"
            Me.TreeListColumn_BelongQty.Visible = True
            Me.TreeListColumn_BelongQty.VisibleIndex = 3
            Me.TreeListColumn_BelongQty.Width = 61
            '
            'RepositoryItemCalcEdit_BelongQty
            '
            Me.RepositoryItemCalcEdit_BelongQty.AutoHeight = False
            Me.RepositoryItemCalcEdit_BelongQty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_BelongQty.Name = "RepositoryItemCalcEdit_BelongQty"
            '
            'TreeListColumn_WareBomType
            '
            Me.TreeListColumn_WareBomType.Caption = "BOM类型"
            Me.TreeListColumn_WareBomType.ColumnEdit = Me.RepositoryItemLookUpEdit_WareBomType
            Me.TreeListColumn_WareBomType.FieldName = "WARE_BOM_TYPE"
            Me.TreeListColumn_WareBomType.Name = "TreeListColumn_WareBomType"
            Me.TreeListColumn_WareBomType.Visible = True
            Me.TreeListColumn_WareBomType.VisibleIndex = 2
            Me.TreeListColumn_WareBomType.Width = 62
            '
            'RepositoryItemLookUpEdit_WareBomType
            '
            Me.RepositoryItemLookUpEdit_WareBomType.AutoHeight = False
            Me.RepositoryItemLookUpEdit_WareBomType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_WareBomType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_WareBomType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_WareBomType.Name = "RepositoryItemLookUpEdit_WareBomType"
            Me.RepositoryItemLookUpEdit_WareBomType.ValueMember = "ITEM_VALUE"
            '
            'M_01_00206
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.TreeList_WareBomList)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_01_00206"
            Me.Size = New System.Drawing.Size(530, 500)
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
            CTag8.ParentControl = Me
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag8
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.MemoEdit_WareCodes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TreeList_WareBomList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_BelongQty, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_WareBomType, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TreeList_WareBomList As DevExpress.XtraTreeList.TreeList
        Friend WithEvents TreeListColumn_BelongQty As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents TreeListColumn_WareBomType As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents TreeListColumn_BelongWareName As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents TreeListColumn_RowHighLight As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents MemoEdit_WareCodes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents ToolStripButton_Save As System.Windows.Forms.ToolStripButton
        Friend WithEvents RepositoryItemLookUpEdit_WareBomType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents TreeListColumn_BelongWareCode As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents RepositoryItemCalcEdit_BelongQty As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

#End Region

    End Class

End Namespace

