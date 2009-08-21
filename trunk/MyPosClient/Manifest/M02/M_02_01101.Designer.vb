Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_01101
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
        Friend WithEvents ToolStripButton_Add As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag25 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag18 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag19 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag20 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag22 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag23 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag24 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag21 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag26 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.GroupControl_Details = New DevExpress.XtraEditors.GroupControl
            Me.GridControl_TurnoverDtl = New DevExpress.XtraGrid.GridControl
            Me.GridView_TurnoverDtl = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_BatchCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverBookStatus = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_WareAmount = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitDiscount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumDiscount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CurrentAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_OrigionUntPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_OrigionSumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.PanelControl_WareInput = New DevExpress.XtraEditors.PanelControl
            Me.LinkLabel_UploadCacheData = New System.Windows.Forms.LinkLabel
            Me.SpinEdit_WareAmount = New DevExpress.XtraEditors.SpinEdit
            Me.ButtonEdit_WareCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label_CacheStatus = New System.Windows.Forms.Label
            Me.Label_WareID = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label18 = New System.Windows.Forms.Label
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
            Me.Label_AffairDescription = New System.Windows.Forms.Label
            Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
            Me.Label_HintGainPoint = New System.Windows.Forms.Label
            Me.TextEdit_ClientCode = New DevExpress.XtraEditors.TextEdit
            Me.Label_AquiringPoints = New System.Windows.Forms.Label
            Me.Label_ClientID = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label_ClientName = New System.Windows.Forms.Label
            Me.Label_HoldingPoint = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label_OperationStatus = New System.Windows.Forms.Label
            Me.Label_UsePoint = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.GroupControl_Details, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl_Details.SuspendLayout()
            CType(Me.GridControl_TurnoverDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_TurnoverDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverBookStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_WareAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl_WareInput, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_WareInput.SuspendLayout()
            CType(Me.SpinEdit_WareAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl1.SuspendLayout()
            CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl2.SuspendLayout()
            CType(Me.TextEdit_ClientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Create, Me.ToolStripButton_Add, Me.ToolStripButton_Remove, Me.ToolStripButton_Close})
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
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            Me.ToolStripButton_Create.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Create.Text = "新建"
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
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Close.Text = "关闭"
            '
            'GroupControl_Details
            '
            Me.GroupControl_Details.Appearance.BackColor = System.Drawing.Color.White
            Me.GroupControl_Details.Appearance.Options.UseBackColor = True
            Me.GroupControl_Details.Controls.Add(Me.GridControl_TurnoverDtl)
            Me.GroupControl_Details.Controls.Add(Me.PanelControl_WareInput)
            Me.GroupControl_Details.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupControl_Details.Location = New System.Drawing.Point(0, 25)
            Me.GroupControl_Details.Name = "GroupControl_Details"
            Me.GroupControl_Details.Size = New System.Drawing.Size(509, 475)
            Me.GroupControl_Details.TabIndex = 10002
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
            CTag11.ParentControl = Me.GroupControl_Details
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.GroupControl_Details.Tag = CTag11
            Me.GroupControl_Details.Text = "购物明细"
            '
            'GridControl_TurnoverDtl
            '
            Me.GridControl_TurnoverDtl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_TurnoverDtl.EmbeddedNavigator.Name = ""
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
            CTag2.ParentControl = Me.GridControl_TurnoverDtl.EmbeddedNavigator
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_TurnoverDtl.EmbeddedNavigator.Tag = CTag2
            Me.GridControl_TurnoverDtl.Location = New System.Drawing.Point(2, 20)
            Me.GridControl_TurnoverDtl.MainView = Me.GridView_TurnoverDtl
            Me.GridControl_TurnoverDtl.Name = "GridControl_TurnoverDtl"
            Me.GridControl_TurnoverDtl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select, Me.RepositoryItemLookUpEdit_TurnoverBookStatus, Me.RepositoryItemCalcEdit_WareAmount})
            Me.GridControl_TurnoverDtl.Size = New System.Drawing.Size(505, 386)
            Me.GridControl_TurnoverDtl.TabIndex = 10000
            Me.GridControl_TurnoverDtl.TabStop = False
            Me.GridControl_TurnoverDtl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_TurnoverDtl})
            '
            'GridView_TurnoverDtl
            '
            Me.GridView_TurnoverDtl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_BatchCode, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_TurnoverBookStatus, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_UnitName, Me.GridColumn_WareAmount, Me.GridColumn_UnitPrice, Me.GridColumn_SumPrice, Me.GridColumn_UnitDiscount, Me.GridColumn_SumDiscount, Me.GridColumn_Remark, Me.GridColumn_CurrentAmount, Me.GridColumn_RowHighlight, Me.GridColumn_OrigionUntPrice, Me.GridColumn_OrigionSumPrice})
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
            StyleFormatCondition2.Value1 = "ROW_HIGHLIGHT_AMOUNT_EXCEED"
            Me.GridView_TurnoverDtl.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.GridView_TurnoverDtl.GridControl = Me.GridControl_TurnoverDtl
            Me.GridView_TurnoverDtl.Name = "GridView_TurnoverDtl"
            Me.GridView_TurnoverDtl.OptionsView.ColumnAutoWidth = False
            Me.GridView_TurnoverDtl.OptionsView.ShowFooter = True
            Me.GridView_TurnoverDtl.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_BatchCode
            '
            Me.GridColumn_BatchCode.Caption = "批号"
            Me.GridColumn_BatchCode.FieldName = "BATCH_CODE"
            Me.GridColumn_BatchCode.Name = "GridColumn_BatchCode"
            Me.GridColumn_BatchCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_BatchCode.Width = 36
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
            'GridColumn_CustomCode
            '
            Me.GridColumn_CustomCode.Caption = "自定货号"
            Me.GridColumn_CustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_CustomCode.Name = "GridColumn_CustomCode"
            Me.GridColumn_CustomCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomCode.Width = 60
            '
            'GridColumn_WareName
            '
            Me.GridColumn_WareName.Caption = "货品名称"
            Me.GridColumn_WareName.FieldName = "WARE_NAME"
            Me.GridColumn_WareName.Name = "GridColumn_WareName"
            Me.GridColumn_WareName.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareName.Visible = True
            Me.GridColumn_WareName.VisibleIndex = 1
            Me.GridColumn_WareName.Width = 60
            '
            'GridColumn_TurnoverBookStatus
            '
            Me.GridColumn_TurnoverBookStatus.Caption = "订货状态"
            Me.GridColumn_TurnoverBookStatus.ColumnEdit = Me.RepositoryItemLookUpEdit_TurnoverBookStatus
            Me.GridColumn_TurnoverBookStatus.FieldName = "TURNOVER_BOOK_STATUS"
            Me.GridColumn_TurnoverBookStatus.Name = "GridColumn_TurnoverBookStatus"
            Me.GridColumn_TurnoverBookStatus.OptionsColumn.AllowFocus = False
            Me.GridColumn_TurnoverBookStatus.Width = 60
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
            'GridColumn_Spec
            '
            Me.GridColumn_Spec.Caption = "货品规格"
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            Me.GridColumn_Spec.Visible = True
            Me.GridColumn_Spec.VisibleIndex = 2
            Me.GridColumn_Spec.Width = 60
            '
            'GridColumn_Model
            '
            Me.GridColumn_Model.Caption = "货品型号"
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            Me.GridColumn_Model.Visible = True
            Me.GridColumn_Model.VisibleIndex = 3
            Me.GridColumn_Model.Width = 60
            '
            'GridColumn_Attribute1
            '
            Me.GridColumn_Attribute1.Caption = "属性1"
            Me.GridColumn_Attribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_Attribute1.Name = "GridColumn_Attribute1"
            Me.GridColumn_Attribute1.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute1.Visible = True
            Me.GridColumn_Attribute1.VisibleIndex = 4
            Me.GridColumn_Attribute1.Width = 43
            '
            'GridColumn_Attribute2
            '
            Me.GridColumn_Attribute2.Caption = "属性2"
            Me.GridColumn_Attribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_Attribute2.Name = "GridColumn_Attribute2"
            Me.GridColumn_Attribute2.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute2.Visible = True
            Me.GridColumn_Attribute2.VisibleIndex = 5
            Me.GridColumn_Attribute2.Width = 43
            '
            'GridColumn_Attribute3
            '
            Me.GridColumn_Attribute3.Caption = "属性3"
            Me.GridColumn_Attribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_Attribute3.Name = "GridColumn_Attribute3"
            Me.GridColumn_Attribute3.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute3.Visible = True
            Me.GridColumn_Attribute3.VisibleIndex = 6
            Me.GridColumn_Attribute3.Width = 43
            '
            'GridColumn_Attribute4
            '
            Me.GridColumn_Attribute4.Caption = "属性4"
            Me.GridColumn_Attribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_Attribute4.Name = "GridColumn_Attribute4"
            Me.GridColumn_Attribute4.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute4.Visible = True
            Me.GridColumn_Attribute4.VisibleIndex = 7
            Me.GridColumn_Attribute4.Width = 43
            '
            'GridColumn_UnitName
            '
            Me.GridColumn_UnitName.Caption = "单位"
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitName.Visible = True
            Me.GridColumn_UnitName.VisibleIndex = 8
            Me.GridColumn_UnitName.Width = 36
            '
            'GridColumn_WareAmount
            '
            Me.GridColumn_WareAmount.Caption = "数量"
            Me.GridColumn_WareAmount.ColumnEdit = Me.RepositoryItemCalcEdit_WareAmount
            Me.GridColumn_WareAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_WareAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_WareAmount.FieldName = "WARE_AMOUNT"
            Me.GridColumn_WareAmount.Name = "GridColumn_WareAmount"
            Me.GridColumn_WareAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridColumn_WareAmount.Visible = True
            Me.GridColumn_WareAmount.VisibleIndex = 9
            Me.GridColumn_WareAmount.Width = 36
            '
            'RepositoryItemCalcEdit_WareAmount
            '
            Me.RepositoryItemCalcEdit_WareAmount.AutoHeight = False
            Me.RepositoryItemCalcEdit_WareAmount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_WareAmount.Name = "RepositoryItemCalcEdit_WareAmount"
            '
            'GridColumn_UnitPrice
            '
            Me.GridColumn_UnitPrice.Caption = "单价"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitPrice.FieldName = "UNIT_PRICE"
            Me.GridColumn_UnitPrice.Name = "GridColumn_UnitPrice"
            Me.GridColumn_UnitPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitPrice.Visible = True
            Me.GridColumn_UnitPrice.VisibleIndex = 10
            Me.GridColumn_UnitPrice.Width = 48
            '
            'GridColumn_SumPrice
            '
            Me.GridColumn_SumPrice.Caption = "小计"
            Me.GridColumn_SumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SumPrice.FieldName = "SUM_PRICE"
            Me.GridColumn_SumPrice.Name = "GridColumn_SumPrice"
            Me.GridColumn_SumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_SumPrice.SummaryItem.DisplayFormat = "{0:#,##0.00}"
            Me.GridColumn_SumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridColumn_SumPrice.Visible = True
            Me.GridColumn_SumPrice.VisibleIndex = 11
            Me.GridColumn_SumPrice.Width = 36
            '
            'GridColumn_UnitDiscount
            '
            Me.GridColumn_UnitDiscount.Caption = "单件折扣"
            Me.GridColumn_UnitDiscount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitDiscount.FieldName = "UNIT_DISCOUNT"
            Me.GridColumn_UnitDiscount.Name = "GridColumn_UnitDiscount"
            Me.GridColumn_UnitDiscount.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitDiscount.Visible = True
            Me.GridColumn_UnitDiscount.VisibleIndex = 12
            '
            'GridColumn_SumDiscount
            '
            Me.GridColumn_SumDiscount.Caption = "折扣小计"
            Me.GridColumn_SumDiscount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SumDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SumDiscount.FieldName = "SUM_DISCOUNT"
            Me.GridColumn_SumDiscount.Name = "GridColumn_SumDiscount"
            Me.GridColumn_SumDiscount.OptionsColumn.AllowFocus = False
            Me.GridColumn_SumDiscount.SummaryItem.DisplayFormat = "{0:#,##0.00}"
            Me.GridColumn_SumDiscount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridColumn_SumDiscount.Visible = True
            Me.GridColumn_SumDiscount.VisibleIndex = 13
            '
            'GridColumn_Remark
            '
            Me.GridColumn_Remark.Caption = "可退数量"
            Me.GridColumn_Remark.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Remark.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Remark.FieldName = "DSR_FT_ROW_REMARK"
            Me.GridColumn_Remark.Name = "GridColumn_Remark"
            Me.GridColumn_Remark.OptionsColumn.AllowFocus = False
            Me.GridColumn_Remark.Width = 36
            '
            'GridColumn_CurrentAmount
            '
            Me.GridColumn_CurrentAmount.Caption = "当前在库数量"
            Me.GridColumn_CurrentAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_CurrentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_CurrentAmount.FieldName = "CURRENT_AMOUNT"
            Me.GridColumn_CurrentAmount.Name = "GridColumn_CurrentAmount"
            Me.GridColumn_CurrentAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_CurrentAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridColumn_CurrentAmount.Width = 84
            '
            'GridColumn_RowHighlight
            '
            Me.GridColumn_RowHighlight.Caption = "高亮显示"
            Me.GridColumn_RowHighlight.FieldName = "ROW_HIGHLIGHT_RETURN_AMOUNT_EXCEED"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            Me.GridColumn_RowHighlight.Width = 60
            '
            'GridColumn_OrigionUntPrice
            '
            Me.GridColumn_OrigionUntPrice.Caption = "原单价"
            Me.GridColumn_OrigionUntPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_OrigionUntPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_OrigionUntPrice.FieldName = "ORIGION_UNIT_PRICE"
            Me.GridColumn_OrigionUntPrice.Name = "GridColumn_OrigionUntPrice"
            Me.GridColumn_OrigionUntPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_OrigionUntPrice.Visible = True
            Me.GridColumn_OrigionUntPrice.VisibleIndex = 14
            '
            'GridColumn_OrigionSumPrice
            '
            Me.GridColumn_OrigionSumPrice.Caption = "原小计"
            Me.GridColumn_OrigionSumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_OrigionSumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_OrigionSumPrice.FieldName = "ORIGION_SUM_PRICE"
            Me.GridColumn_OrigionSumPrice.Name = "GridColumn_OrigionSumPrice"
            Me.GridColumn_OrigionSumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_OrigionSumPrice.Visible = True
            Me.GridColumn_OrigionSumPrice.VisibleIndex = 15
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AutoHeight = False
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'PanelControl_WareInput
            '
            Me.PanelControl_WareInput.Controls.Add(Me.LinkLabel_UploadCacheData)
            Me.PanelControl_WareInput.Controls.Add(Me.SpinEdit_WareAmount)
            Me.PanelControl_WareInput.Controls.Add(Me.ButtonEdit_WareCode)
            Me.PanelControl_WareInput.Controls.Add(Me.Label_CacheStatus)
            Me.PanelControl_WareInput.Controls.Add(Me.Label_WareID)
            Me.PanelControl_WareInput.Controls.Add(Me.Label1)
            Me.PanelControl_WareInput.Controls.Add(Me.Label18)
            Me.PanelControl_WareInput.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PanelControl_WareInput.Location = New System.Drawing.Point(2, 406)
            Me.PanelControl_WareInput.Name = "PanelControl_WareInput"
            Me.PanelControl_WareInput.Size = New System.Drawing.Size(505, 67)
            Me.PanelControl_WareInput.TabIndex = 10000
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
            CTag10.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag10.IsButtonCustomed = False
            CTag10.IsTextValid = True
            CTag10.KeyValueAbsentable = False
            CTag10.LeagleText = ""
            CTag10.NumericButtonTextBox = Nothing
            CTag10.ParentControl = Me.PanelControl_WareInput
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_WareInput.Tag = CTag10
            '
            'LinkLabel_UploadCacheData
            '
            Me.LinkLabel_UploadCacheData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LinkLabel_UploadCacheData.AutoSize = True
            Me.LinkLabel_UploadCacheData.BackColor = System.Drawing.Color.White
            Me.LinkLabel_UploadCacheData.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.LinkLabel_UploadCacheData.ForeColor = System.Drawing.Color.Black
            Me.LinkLabel_UploadCacheData.Location = New System.Drawing.Point(430, 15)
            Me.LinkLabel_UploadCacheData.Name = "LinkLabel_UploadCacheData"
            Me.LinkLabel_UploadCacheData.Size = New System.Drawing.Size(55, 15)
            Me.LinkLabel_UploadCacheData.TabIndex = 10000
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
            CTag3.ParentControl = Me.LinkLabel_UploadCacheData
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_UploadCacheData.Tag = CTag3
            Me.LinkLabel_UploadCacheData.Text = "上传数据"
            '
            'SpinEdit_WareAmount
            '
            Me.SpinEdit_WareAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.SpinEdit_WareAmount.Location = New System.Drawing.Point(285, 11)
            Me.SpinEdit_WareAmount.Name = "SpinEdit_WareAmount"
            Me.SpinEdit_WareAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.SpinEdit_WareAmount.Size = New System.Drawing.Size(83, 20)
            Me.SpinEdit_WareAmount.TabIndex = 10000
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
            CTag4.ParentControl = Me.SpinEdit_WareAmount
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.SpinEdit_WareAmount.Tag = CTag4
            '
            'ButtonEdit_WareCode
            '
            Me.ButtonEdit_WareCode.Location = New System.Drawing.Point(87, 10)
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_WareCode.Size = New System.Drawing.Size(121, 20)
            Me.ButtonEdit_WareCode.TabIndex = 10000
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
            CTag5.ParentControl = Me.ButtonEdit_WareCode
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_WareCode.Tag = CTag5
            '
            'Label_CacheStatus
            '
            Me.Label_CacheStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label_CacheStatus.AutoSize = True
            Me.Label_CacheStatus.BackColor = System.Drawing.Color.White
            Me.Label_CacheStatus.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_CacheStatus.ForeColor = System.Drawing.Color.Black
            Me.Label_CacheStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_CacheStatus.Location = New System.Drawing.Point(310, 14)
            Me.Label_CacheStatus.Name = "Label_CacheStatus"
            Me.Label_CacheStatus.Size = New System.Drawing.Size(55, 15)
            Me.Label_CacheStatus.TabIndex = 10000
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
            CTag6.ParentControl = Me.Label_CacheStatus
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CacheStatus.Tag = CTag6
            Me.Label_CacheStatus.Text = "缓冲状态"
            '
            'Label_WareID
            '
            Me.Label_WareID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label_WareID.AutoSize = True
            Me.Label_WareID.BackColor = System.Drawing.Color.White
            Me.Label_WareID.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_WareID.ForeColor = System.Drawing.Color.Black
            Me.Label_WareID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_WareID.Location = New System.Drawing.Point(-138, 2)
            Me.Label_WareID.Name = "Label_WareID"
            Me.Label_WareID.Size = New System.Drawing.Size(43, 15)
            Me.Label_WareID.TabIndex = 10000
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
            CTag7.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag7.IsButtonCustomed = False
            CTag7.IsTextValid = True
            CTag7.KeyValueAbsentable = False
            CTag7.LeagleText = ""
            CTag7.NumericButtonTextBox = Nothing
            CTag7.ParentControl = Me.Label_WareID
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareID.Tag = CTag7
            Me.Label_WareID.Text = "货品ID"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(226, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(53, 15)
            Me.Label1.TabIndex = 10000
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
            CTag8.ParentControl = Me.Label1
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag8
            Me.Label1.Text = "数量(F2)"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.BackColor = System.Drawing.Color.White
            Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label18.ForeColor = System.Drawing.Color.Black
            Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label18.Location = New System.Drawing.Point(5, 12)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(77, 15)
            Me.Label18.TabIndex = 10000
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
            CTag9.ParentControl = Me.Label18
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label18.Tag = CTag9
            Me.Label18.Text = "货品代码(F1)"
            '
            'PanelControl1
            '
            Me.PanelControl1.Controls.Add(Me.GroupControl1)
            Me.PanelControl1.Controls.Add(Me.GroupControl2)
            Me.PanelControl1.Controls.Add(Me.Label_OperationStatus)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.PanelControl1.Location = New System.Drawing.Point(509, 25)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(191, 475)
            Me.PanelControl1.TabIndex = 10001
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
            CTag25.ParentControl = Me.PanelControl1
            CTag25.SkipValidate = False
            CTag25.TimeButtonTextBox = Nothing
            CTag25.ToolTip = ""
            CTag25.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag25
            '
            'GroupControl1
            '
            Me.GroupControl1.Controls.Add(Me.Label_AffairDescription)
            Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupControl1.FireScrollEventOnMouseWheel = True
            Me.GroupControl1.Location = New System.Drawing.Point(2, 17)
            Me.GroupControl1.Name = "GroupControl1"
            Me.GroupControl1.Size = New System.Drawing.Size(187, 150)
            Me.GroupControl1.TabIndex = 10000
            Me.GroupControl1.Text = "当前活动"
            '
            'Label_AffairDescription
            '
            Me.Label_AffairDescription.AutoSize = True
            Me.Label_AffairDescription.BackColor = System.Drawing.Color.White
            Me.Label_AffairDescription.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label_AffairDescription.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_AffairDescription.ForeColor = System.Drawing.Color.Black
            Me.Label_AffairDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_AffairDescription.Location = New System.Drawing.Point(2, 20)
            Me.Label_AffairDescription.Name = "Label_AffairDescription"
            Me.Label_AffairDescription.Size = New System.Drawing.Size(55, 15)
            Me.Label_AffairDescription.TabIndex = 10000
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
            CTag12.ParentControl = Me.Label_AffairDescription
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Label_AffairDescription.Tag = CTag12
            Me.Label_AffairDescription.Text = "活动内容"
            '
            'GroupControl2
            '
            Me.GroupControl2.Controls.Add(Me.Label_HintGainPoint)
            Me.GroupControl2.Controls.Add(Me.TextEdit_ClientCode)
            Me.GroupControl2.Controls.Add(Me.Label_AquiringPoints)
            Me.GroupControl2.Controls.Add(Me.Label_ClientID)
            Me.GroupControl2.Controls.Add(Me.Label2)
            Me.GroupControl2.Controls.Add(Me.Label7)
            Me.GroupControl2.Controls.Add(Me.Label8)
            Me.GroupControl2.Controls.Add(Me.Label_ClientName)
            Me.GroupControl2.Controls.Add(Me.Label_UsePoint)
            Me.GroupControl2.Controls.Add(Me.Label_HoldingPoint)
            Me.GroupControl2.Controls.Add(Me.Label6)
            Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.GroupControl2.FireScrollEventOnMouseWheel = True
            Me.GroupControl2.Location = New System.Drawing.Point(2, 167)
            Me.GroupControl2.Name = "GroupControl2"
            Me.GroupControl2.Size = New System.Drawing.Size(187, 306)
            Me.GroupControl2.TabIndex = 10000
            Me.GroupControl2.Text = "会员情况(F3)"
            '
            'Label_HintGainPoint
            '
            Me.Label_HintGainPoint.AutoSize = True
            Me.Label_HintGainPoint.BackColor = System.Drawing.Color.White
            Me.Label_HintGainPoint.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_HintGainPoint.ForeColor = System.Drawing.Color.Black
            Me.Label_HintGainPoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_HintGainPoint.Location = New System.Drawing.Point(5, 146)
            Me.Label_HintGainPoint.Name = "Label_HintGainPoint"
            Me.Label_HintGainPoint.Size = New System.Drawing.Size(55, 15)
            Me.Label_HintGainPoint.TabIndex = 10000
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
            CTag13.ParentControl = Me.Label_HintGainPoint
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.Label_HintGainPoint.Tag = CTag13
            Me.Label_HintGainPoint.Text = "获得点数"
            '
            'TextEdit_ClientCode
            '
            Me.TextEdit_ClientCode.Enabled = False
            Me.TextEdit_ClientCode.Location = New System.Drawing.Point(61, 26)
            Me.TextEdit_ClientCode.Name = "TextEdit_ClientCode"
            Me.TextEdit_ClientCode.Size = New System.Drawing.Size(119, 20)
            Me.TextEdit_ClientCode.TabIndex = 10000
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
            CTag14.ParentControl = Me.TextEdit_ClientCode
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_ClientCode.Tag = CTag14
            '
            'Label_AquiringPoints
            '
            Me.Label_AquiringPoints.BackColor = System.Drawing.Color.White
            Me.Label_AquiringPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_AquiringPoints.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_AquiringPoints.ForeColor = System.Drawing.Color.Black
            Me.Label_AquiringPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_AquiringPoints.Location = New System.Drawing.Point(61, 142)
            Me.Label_AquiringPoints.Name = "Label_AquiringPoints"
            Me.Label_AquiringPoints.Size = New System.Drawing.Size(121, 23)
            Me.Label_AquiringPoints.TabIndex = 10000
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
            CTag15.ParentControl = Me.Label_AquiringPoints
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.Label_AquiringPoints.Tag = CTag15
            Me.Label_AquiringPoints.Text = "0"
            Me.Label_AquiringPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label_ClientID
            '
            Me.Label_ClientID.AutoSize = True
            Me.Label_ClientID.BackColor = System.Drawing.Color.White
            Me.Label_ClientID.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_ClientID.ForeColor = System.Drawing.Color.Black
            Me.Label_ClientID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_ClientID.Location = New System.Drawing.Point(93, 57)
            Me.Label_ClientID.Name = "Label_ClientID"
            Me.Label_ClientID.Size = New System.Drawing.Size(43, 15)
            Me.Label_ClientID.TabIndex = 10000
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
            CTag16.ParentControl = Me.Label_ClientID
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.Label_ClientID.Tag = CTag16
            Me.Label_ClientID.Text = "会员ID"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.White
            Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label7.ForeColor = System.Drawing.Color.Black
            Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label7.Location = New System.Drawing.Point(5, 57)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(31, 15)
            Me.Label7.TabIndex = 10000
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
            CTag18.ParentControl = Me.Label7
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.Label7.Tag = CTag18
            Me.Label7.Text = "姓名"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.BackColor = System.Drawing.Color.White
            Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label8.ForeColor = System.Drawing.Color.Black
            Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label8.Location = New System.Drawing.Point(4, 97)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(55, 15)
            Me.Label8.TabIndex = 10000
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
            CTag19.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag19.IsButtonCustomed = False
            CTag19.IsTextValid = True
            CTag19.KeyValueAbsentable = False
            CTag19.LeagleText = ""
            CTag19.NumericButtonTextBox = Nothing
            CTag19.ParentControl = Me.Label8
            CTag19.SkipValidate = False
            CTag19.TimeButtonTextBox = Nothing
            CTag19.ToolTip = ""
            CTag19.ValueType = XL.Common.ControlValueType.Character
            Me.Label8.Tag = CTag19
            Me.Label8.Text = "持有点数"
            '
            'Label_ClientName
            '
            Me.Label_ClientName.BackColor = System.Drawing.Color.White
            Me.Label_ClientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_ClientName.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_ClientName.ForeColor = System.Drawing.Color.Black
            Me.Label_ClientName.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_ClientName.Location = New System.Drawing.Point(61, 53)
            Me.Label_ClientName.Name = "Label_ClientName"
            Me.Label_ClientName.Size = New System.Drawing.Size(119, 23)
            Me.Label_ClientName.TabIndex = 10000
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
            CTag20.ParentControl = Me.Label_ClientName
            CTag20.SkipValidate = False
            CTag20.TimeButtonTextBox = Nothing
            CTag20.ToolTip = ""
            CTag20.ValueType = XL.Common.ControlValueType.Character
            Me.Label_ClientName.Tag = CTag20
            Me.Label_ClientName.Text = "总额"
            Me.Label_ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label_HoldingPoint
            '
            Me.Label_HoldingPoint.BackColor = System.Drawing.Color.White
            Me.Label_HoldingPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_HoldingPoint.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_HoldingPoint.ForeColor = System.Drawing.Color.Black
            Me.Label_HoldingPoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_HoldingPoint.Location = New System.Drawing.Point(61, 93)
            Me.Label_HoldingPoint.Name = "Label_HoldingPoint"
            Me.Label_HoldingPoint.Size = New System.Drawing.Size(119, 23)
            Me.Label_HoldingPoint.TabIndex = 10000
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
            CTag22.ParentControl = Me.Label_HoldingPoint
            CTag22.SkipValidate = False
            CTag22.TimeButtonTextBox = Nothing
            CTag22.ToolTip = ""
            CTag22.ValueType = XL.Common.ControlValueType.Character
            Me.Label_HoldingPoint.Tag = CTag22
            Me.Label_HoldingPoint.Text = "0"
            Me.Label_HoldingPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.White
            Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label6.Location = New System.Drawing.Point(5, 122)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(55, 15)
            Me.Label6.TabIndex = 10000
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
            CTag23.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag23.IsButtonCustomed = False
            CTag23.IsTextValid = True
            CTag23.KeyValueAbsentable = False
            CTag23.LeagleText = ""
            CTag23.NumericButtonTextBox = Nothing
            CTag23.ParentControl = Me.Label6
            CTag23.SkipValidate = False
            CTag23.TimeButtonTextBox = Nothing
            CTag23.ToolTip = ""
            CTag23.ValueType = XL.Common.ControlValueType.Character
            Me.Label6.Tag = CTag23
            Me.Label6.Text = "使用点数"
            '
            'Label_OperationStatus
            '
            Me.Label_OperationStatus.BackColor = System.Drawing.Color.White
            Me.Label_OperationStatus.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label_OperationStatus.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_OperationStatus.ForeColor = System.Drawing.Color.Black
            Me.Label_OperationStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_OperationStatus.Location = New System.Drawing.Point(2, 2)
            Me.Label_OperationStatus.Name = "Label_OperationStatus"
            Me.Label_OperationStatus.Size = New System.Drawing.Size(187, 15)
            Me.Label_OperationStatus.TabIndex = 10000
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
            CTag24.ParentControl = Me.Label_OperationStatus
            CTag24.SkipValidate = False
            CTag24.TimeButtonTextBox = Nothing
            CTag24.ToolTip = ""
            CTag24.ValueType = XL.Common.ControlValueType.Character
            Me.Label_OperationStatus.Tag = CTag24
            Me.Label_OperationStatus.Visible = False
            '
            'Label_UsePoint
            '
            Me.Label_UsePoint.BackColor = System.Drawing.Color.White
            Me.Label_UsePoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_UsePoint.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_UsePoint.ForeColor = System.Drawing.Color.Black
            Me.Label_UsePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_UsePoint.Location = New System.Drawing.Point(61, 117)
            Me.Label_UsePoint.Name = "Label_UsePoint"
            Me.Label_UsePoint.Size = New System.Drawing.Size(119, 23)
            Me.Label_UsePoint.TabIndex = 10000
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
            CTag21.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag21.IsButtonCustomed = False
            CTag21.IsTextValid = True
            CTag21.KeyValueAbsentable = False
            CTag21.LeagleText = ""
            CTag21.NumericButtonTextBox = Nothing
            CTag21.ParentControl = Me.Label_UsePoint
            CTag21.SkipValidate = False
            CTag21.TimeButtonTextBox = Nothing
            CTag21.ToolTip = ""
            CTag21.ValueType = XL.Common.ControlValueType.Character
            Me.Label_UsePoint.Tag = CTag21
            Me.Label_UsePoint.Text = "0"
            Me.Label_UsePoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label2.Location = New System.Drawing.Point(5, 29)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(43, 15)
            Me.Label2.TabIndex = 10000
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
            CTag17.ParentControl = Me.Label2
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag17
            Me.Label2.Text = "会员号"
            '
            'M_02_01101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.GroupControl_Details)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_01101"
            Me.Size = New System.Drawing.Size(700, 500)
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
            CTag26.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag26.IsButtonCustomed = False
            CTag26.IsTextValid = True
            CTag26.KeyValueAbsentable = False
            CTag26.LeagleText = ""
            CTag26.NumericButtonTextBox = Nothing
            CTag26.ParentControl = Me
            CTag26.SkipValidate = False
            CTag26.TimeButtonTextBox = Nothing
            CTag26.ToolTip = ""
            CTag26.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag26
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.GroupControl_Details, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl_Details.ResumeLayout(False)
            CType(Me.GridControl_TurnoverDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_TurnoverDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverBookStatus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_WareAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl_WareInput, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_WareInput.ResumeLayout(False)
            Me.PanelControl_WareInput.PerformLayout()
            CType(Me.SpinEdit_WareAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl1.ResumeLayout(False)
            Me.GroupControl1.PerformLayout()
            CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl2.ResumeLayout(False)
            Me.GroupControl2.PerformLayout()
            CType(Me.TextEdit_ClientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupControl_Details As DevExpress.XtraEditors.GroupControl
        Friend WithEvents GridControl_TurnoverDtl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_TurnoverDtl As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_BatchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverBookStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverBookStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_WareAmount As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SumDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remark As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CurrentAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_OrigionUntPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_OrigionSumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents PanelControl_WareInput As DevExpress.XtraEditors.PanelControl
        Friend WithEvents LinkLabel_UploadCacheData As System.Windows.Forms.LinkLabel
        Friend WithEvents SpinEdit_WareAmount As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents ButtonEdit_WareCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label_CacheStatus As System.Windows.Forms.Label
        Friend WithEvents Label_WareID As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents Label_AffairDescription As System.Windows.Forms.Label
        Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents Label_HintGainPoint As System.Windows.Forms.Label
        Friend WithEvents TextEdit_ClientCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label_AquiringPoints As System.Windows.Forms.Label
        Friend WithEvents Label_ClientID As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label_ClientName As System.Windows.Forms.Label
        Friend WithEvents Label_HoldingPoint As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label_OperationStatus As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label_UsePoint As System.Windows.Forms.Label

#End Region

    End Class

End Namespace

