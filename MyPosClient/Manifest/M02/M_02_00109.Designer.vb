Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00109
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
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00109))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.ButtonEdit_EmployeeCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_ShareDtl = New DevExpress.XtraGrid.GridControl
            Me.GridView_ShareDtl = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_EmployeeCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EmployeeName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SharePercent = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemSpinEdit_SharePercent = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.ButtonEdit_EmployeeCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_ShareDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ShareDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSpinEdit_SharePercent, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Save, Me.ToolStripButton_Refresh, Me.ToolStripButton_Remove, Me.ToolStripButton_Close})
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
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.AccessibleDescription = Nothing
            Me.ToolStripButton_Save.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Save, "ToolStripButton_Save")
            Me.ToolStripButton_Save.BackgroundImage = Nothing
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.AccessibleDescription = Nothing
            Me.ToolStripButton_Refresh.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            Me.ToolStripButton_Refresh.BackgroundImage = Nothing
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.AccessibleDescription = Nothing
            Me.ToolStripButton_Remove.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Remove, "ToolStripButton_Remove")
            Me.ToolStripButton_Remove.BackgroundImage = Nothing
            Me.ToolStripButton_Remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
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
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.AccessibleDescription = Nothing
            Me.PanelControl_Filter.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.Controls.Add(Me.ButtonEdit_EmployeeCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            'ButtonEdit_EmployeeCode
            '
            resources.ApplyResources(Me.ButtonEdit_EmployeeCode, "ButtonEdit_EmployeeCode")
            Me.ButtonEdit_EmployeeCode.BackgroundImage = Nothing
            Me.ButtonEdit_EmployeeCode.EditValue = Nothing
            Me.ButtonEdit_EmployeeCode.Name = "ButtonEdit_EmployeeCode"
            Me.ButtonEdit_EmployeeCode.Properties.AccessibleDescription = Nothing
            Me.ButtonEdit_EmployeeCode.Properties.AccessibleName = Nothing
            Me.ButtonEdit_EmployeeCode.Properties.AutoHeight = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.AutoHeight"), Boolean)
            Me.ButtonEdit_EmployeeCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_EmployeeCode.Properties.Mask.AutoComplete = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.BeepOnError = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.BeepOnError"), Boolean)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.EditMask = resources.GetString("ButtonEdit_EmployeeCode.Properties.Mask.EditMask")
            Me.ButtonEdit_EmployeeCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.MaskType = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.PlaceHolder"), Char)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag2.ParentControl = Me.ButtonEdit_EmployeeCode
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_EmployeeCode.Tag = CTag2
            '
            'Label2
            '
            Me.Label2.AccessibleDescription = Nothing
            Me.Label2.AccessibleName = Nothing
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
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
            CTag3.ParentControl = Me.Label2
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag3
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.BackgroundImage = Nothing
            Me.TextEdit_Search.Name = "TextEdit_Search"
            Me.TextEdit_Search.Properties.AccessibleDescription = Nothing
            Me.TextEdit_Search.Properties.AccessibleName = Nothing
            Me.TextEdit_Search.Properties.AutoHeight = CType(resources.GetObject("TextEdit_Search.Properties.AutoHeight"), Boolean)
            Me.TextEdit_Search.Properties.Mask.AutoComplete = CType(resources.GetObject("TextEdit_Search.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.TextEdit_Search.Properties.Mask.BeepOnError = CType(resources.GetObject("TextEdit_Search.Properties.Mask.BeepOnError"), Boolean)
            Me.TextEdit_Search.Properties.Mask.EditMask = resources.GetString("TextEdit_Search.Properties.Mask.EditMask")
            Me.TextEdit_Search.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TextEdit_Search.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.TextEdit_Search.Properties.Mask.MaskType = CType(resources.GetObject("TextEdit_Search.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.TextEdit_Search.Properties.Mask.PlaceHolder = CType(resources.GetObject("TextEdit_Search.Properties.Mask.PlaceHolder"), Char)
            Me.TextEdit_Search.Properties.Mask.SaveLiteral = CType(resources.GetObject("TextEdit_Search.Properties.Mask.SaveLiteral"), Boolean)
            Me.TextEdit_Search.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TextEdit_Search.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.TextEdit_Search.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TextEdit_Search.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag4.ParentControl = Me.TextEdit_Search
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag4
            '
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
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
            '
            'GridControl_ShareDtl
            '
            Me.GridControl_ShareDtl.AccessibleDescription = Nothing
            Me.GridControl_ShareDtl.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_ShareDtl, "GridControl_ShareDtl")
            Me.GridControl_ShareDtl.BackgroundImage = Nothing
            Me.GridControl_ShareDtl.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_ShareDtl.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_ShareDtl.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_ShareDtl.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_ShareDtl.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_ShareDtl.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_ShareDtl.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_ShareDtl.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_ShareDtl.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_ShareDtl.EmbeddedNavigator.Name = ""
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
            CTag7.ParentControl = Me.GridControl_ShareDtl.EmbeddedNavigator
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_ShareDtl.EmbeddedNavigator.Tag = CTag7
            Me.GridControl_ShareDtl.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_ShareDtl.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_ShareDtl.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_ShareDtl.EmbeddedNavigator.ToolTip")
            Me.GridControl_ShareDtl.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_ShareDtl.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_ShareDtl.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_ShareDtl.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_ShareDtl.Font = Nothing
            Me.GridControl_ShareDtl.MainView = Me.GridView_ShareDtl
            Me.GridControl_ShareDtl.Name = "GridControl_ShareDtl"
            Me.GridControl_ShareDtl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit_SharePercent})
            Me.GridControl_ShareDtl.TabStop = False
            Me.GridControl_ShareDtl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ShareDtl})
            '
            'GridView_ShareDtl
            '
            resources.ApplyResources(Me.GridView_ShareDtl, "GridView_ShareDtl")
            Me.GridView_ShareDtl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_EmployeeCode, Me.GridColumn_EmployeeName, Me.GridColumn_SharePercent, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_ShareDtl.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_ShareDtl.GridControl = Me.GridControl_ShareDtl
            Me.GridView_ShareDtl.Name = "GridView_ShareDtl"
            Me.GridView_ShareDtl.OptionsView.ColumnAutoWidth = False
            Me.GridView_ShareDtl.OptionsView.ShowFooter = True
            Me.GridView_ShareDtl.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_EmployeeCode
            '
            resources.ApplyResources(Me.GridColumn_EmployeeCode, "GridColumn_EmployeeCode")
            Me.GridColumn_EmployeeCode.FieldName = "SHARE_STAFF__STAFF_CODE"
            Me.GridColumn_EmployeeCode.Name = "GridColumn_EmployeeCode"
            Me.GridColumn_EmployeeCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_EmployeeCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_EmployeeCode.SummaryItem.DisplayFormat")
            Me.GridColumn_EmployeeCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_EmployeeName
            '
            resources.ApplyResources(Me.GridColumn_EmployeeName, "GridColumn_EmployeeName")
            Me.GridColumn_EmployeeName.FieldName = "SHARE_STAFF__STAFF_NAME"
            Me.GridColumn_EmployeeName.Name = "GridColumn_EmployeeName"
            Me.GridColumn_EmployeeName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SharePercent
            '
            resources.ApplyResources(Me.GridColumn_SharePercent, "GridColumn_SharePercent")
            Me.GridColumn_SharePercent.ColumnEdit = Me.RepositoryItemSpinEdit_SharePercent
            Me.GridColumn_SharePercent.FieldName = "SHARE_PERCENT"
            Me.GridColumn_SharePercent.Name = "GridColumn_SharePercent"
            '
            'RepositoryItemSpinEdit_SharePercent
            '
            Me.RepositoryItemSpinEdit_SharePercent.AccessibleDescription = Nothing
            Me.RepositoryItemSpinEdit_SharePercent.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemSpinEdit_SharePercent, "RepositoryItemSpinEdit_SharePercent")
            Me.RepositoryItemSpinEdit_SharePercent.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.RepositoryItemSpinEdit_SharePercent.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemSpinEdit_SharePercent.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemSpinEdit_SharePercent.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemSpinEdit_SharePercent.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemSpinEdit_SharePercent.Mask.EditMask = resources.GetString("RepositoryItemSpinEdit_SharePercent.Mask.EditMask")
            Me.RepositoryItemSpinEdit_SharePercent.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemSpinEdit_SharePercent.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemSpinEdit_SharePercent.Mask.MaskType = CType(resources.GetObject("RepositoryItemSpinEdit_SharePercent.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemSpinEdit_SharePercent.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemSpinEdit_SharePercent.Mask.PlaceHolder"), Char)
            Me.RepositoryItemSpinEdit_SharePercent.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemSpinEdit_SharePercent.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemSpinEdit_SharePercent.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemSpinEdit_SharePercent.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemSpinEdit_SharePercent.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemSpinEdit_SharePercent.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemSpinEdit_SharePercent.Name = "RepositoryItemSpinEdit_SharePercent"
            '
            'GridColumn_RowHighlight
            '
            resources.ApplyResources(Me.GridColumn_RowHighlight, "GridColumn_RowHighlight")
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            '
            'M_02_00109
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_ShareDtl)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_00109"
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
            CType(Me.ButtonEdit_EmployeeCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_ShareDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ShareDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSpinEdit_SharePercent, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_EmployeeCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GridControl_ShareDtl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ShareDtl As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_EmployeeCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_EmployeeName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SharePercent As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemSpinEdit_SharePercent As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace
