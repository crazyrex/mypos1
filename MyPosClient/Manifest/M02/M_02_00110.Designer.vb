Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00110
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
        Friend WithEvents ToolStripButton_Save As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00110))
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
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_ShowRecpList = New DevExpress.XtraEditors.CheckEdit
            Me.Label_ConsignSituation = New System.Windows.Forms.Label
            Me.TextEdit_RecipientCode = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_ConsignRecpWare = New DevExpress.XtraGrid.GridControl
            Me.GridView_ConsignRecpWare = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_RecipientBarcode = New DevExpress.XtraGrid.Columns.GridColumn
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
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.CheckEdit_ShowRecpList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_RecipientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_ConsignRecpWare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ConsignRecpWare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DefaultLookAndFeel_Form
            '
            Me.DefaultLookAndFeel_Form.LookAndFeel.SkinName = "Money Twins"
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Add, Me.ToolStripButton_Save, Me.ToolStripButton_Remove, Me.ToolStripButton_Close})
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
            'ToolStripButton_Add
            '
            Me.ToolStripButton_Add.AccessibleDescription = Nothing
            Me.ToolStripButton_Add.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Add, "ToolStripButton_Add")
            Me.ToolStripButton_Add.BackgroundImage = Nothing
            Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
            '
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.AccessibleDescription = Nothing
            Me.ToolStripButton_Save.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Save, "ToolStripButton_Save")
            Me.ToolStripButton_Save.BackgroundImage = Nothing
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
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
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.AccessibleDescription = Nothing
            Me.PanelControl_Filter.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_ShowRecpList)
            Me.PanelControl_Filter.Controls.Add(Me.Label_ConsignSituation)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_RecipientCode)
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
            'CheckEdit_ShowRecpList
            '
            resources.ApplyResources(Me.CheckEdit_ShowRecpList, "CheckEdit_ShowRecpList")
            Me.CheckEdit_ShowRecpList.BackgroundImage = Nothing
            Me.CheckEdit_ShowRecpList.Name = "CheckEdit_ShowRecpList"
            Me.CheckEdit_ShowRecpList.Properties.AccessibleDescription = Nothing
            Me.CheckEdit_ShowRecpList.Properties.AccessibleName = Nothing
            Me.CheckEdit_ShowRecpList.Properties.AutoHeight = CType(resources.GetObject("CheckEdit_ShowRecpList.Properties.AutoHeight"), Boolean)
            Me.CheckEdit_ShowRecpList.Properties.Caption = resources.GetString("CheckEdit_ShowRecpList.Properties.Caption")
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
            CTag2.ParentControl = Me.CheckEdit_ShowRecpList
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_ShowRecpList.Tag = CTag2
            '
            'Label_ConsignSituation
            '
            Me.Label_ConsignSituation.AccessibleDescription = Nothing
            Me.Label_ConsignSituation.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_ConsignSituation, "Label_ConsignSituation")
            Me.Label_ConsignSituation.BackColor = System.Drawing.Color.White
            Me.Label_ConsignSituation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_ConsignSituation.ForeColor = System.Drawing.Color.Black
            Me.Label_ConsignSituation.Name = "Label_ConsignSituation"
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
            CTag3.ParentControl = Me.Label_ConsignSituation
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_ConsignSituation.Tag = CTag3
            '
            'TextEdit_RecipientCode
            '
            resources.ApplyResources(Me.TextEdit_RecipientCode, "TextEdit_RecipientCode")
            Me.TextEdit_RecipientCode.BackgroundImage = Nothing
            Me.TextEdit_RecipientCode.Name = "TextEdit_RecipientCode"
            Me.TextEdit_RecipientCode.Properties.AccessibleDescription = Nothing
            Me.TextEdit_RecipientCode.Properties.AccessibleName = Nothing
            Me.TextEdit_RecipientCode.Properties.AutoHeight = CType(resources.GetObject("TextEdit_RecipientCode.Properties.AutoHeight"), Boolean)
            Me.TextEdit_RecipientCode.Properties.Mask.AutoComplete = CType(resources.GetObject("TextEdit_RecipientCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.TextEdit_RecipientCode.Properties.Mask.BeepOnError = CType(resources.GetObject("TextEdit_RecipientCode.Properties.Mask.BeepOnError"), Boolean)
            Me.TextEdit_RecipientCode.Properties.Mask.EditMask = resources.GetString("TextEdit_RecipientCode.Properties.Mask.EditMask")
            Me.TextEdit_RecipientCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TextEdit_RecipientCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.TextEdit_RecipientCode.Properties.Mask.MaskType = CType(resources.GetObject("TextEdit_RecipientCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.TextEdit_RecipientCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("TextEdit_RecipientCode.Properties.Mask.PlaceHolder"), Char)
            Me.TextEdit_RecipientCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("TextEdit_RecipientCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.TextEdit_RecipientCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TextEdit_RecipientCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.TextEdit_RecipientCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TextEdit_RecipientCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag4.ParentControl = Me.TextEdit_RecipientCode
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_RecipientCode.Tag = CTag4
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
            'GridControl_ConsignRecpWare
            '
            Me.GridControl_ConsignRecpWare.AccessibleDescription = Nothing
            Me.GridControl_ConsignRecpWare.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_ConsignRecpWare, "GridControl_ConsignRecpWare")
            Me.GridControl_ConsignRecpWare.BackgroundImage = Nothing
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_ConsignRecpWare.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_ConsignRecpWare.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_ConsignRecpWare.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.Name = ""
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
            CTag7.ParentControl = Me.GridControl_ConsignRecpWare.EmbeddedNavigator
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.Tag = CTag7
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_ConsignRecpWare.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_ConsignRecpWare.EmbeddedNavigator.ToolTip")
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_ConsignRecpWare.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_ConsignRecpWare.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_ConsignRecpWare.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_ConsignRecpWare.Font = Nothing
            Me.GridControl_ConsignRecpWare.MainView = Me.GridView_ConsignRecpWare
            Me.GridControl_ConsignRecpWare.Name = "GridControl_ConsignRecpWare"
            Me.GridControl_ConsignRecpWare.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select})
            Me.GridControl_ConsignRecpWare.TabStop = False
            Me.GridControl_ConsignRecpWare.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ConsignRecpWare})
            '
            'GridView_ConsignRecpWare
            '
            resources.ApplyResources(Me.GridView_ConsignRecpWare, "GridView_ConsignRecpWare")
            Me.GridView_ConsignRecpWare.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_RecipientBarcode, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_WareAmount, Me.GridColumn_UnitName, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_ConsignRecpWare.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_ConsignRecpWare.GridControl = Me.GridControl_ConsignRecpWare
            Me.GridView_ConsignRecpWare.Name = "GridView_ConsignRecpWare"
            Me.GridView_ConsignRecpWare.OptionsView.ColumnAutoWidth = False
            Me.GridView_ConsignRecpWare.OptionsView.ShowFooter = True
            Me.GridView_ConsignRecpWare.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_RecipientBarcode
            '
            resources.ApplyResources(Me.GridColumn_RecipientBarcode, "GridColumn_RecipientBarcode")
            Me.GridColumn_RecipientBarcode.FieldName = "RECP_BARCODE"
            Me.GridColumn_RecipientBarcode.Name = "GridColumn_RecipientBarcode"
            Me.GridColumn_RecipientBarcode.OptionsColumn.AllowFocus = False
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
            'GridColumn_WareAmount
            '
            resources.ApplyResources(Me.GridColumn_WareAmount, "GridColumn_WareAmount")
            Me.GridColumn_WareAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_WareAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_WareAmount.FieldName = "WARE_AMOUNT"
            Me.GridColumn_WareAmount.Name = "GridColumn_WareAmount"
            Me.GridColumn_WareAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_WareAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_WareAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_UnitName
            '
            resources.ApplyResources(Me.GridColumn_UnitName, "GridColumn_UnitName")
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
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
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AccessibleDescription = Nothing
            Me.RepositoryItemCheckEdit_Select.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCheckEdit_Select, "RepositoryItemCheckEdit_Select")
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'M_02_00110
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_ConsignRecpWare)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_00110"
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
            CType(Me.CheckEdit_ShowRecpList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_RecipientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_ConsignRecpWare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ConsignRecpWare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_RecipientCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents CheckEdit_ShowRecpList As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents Label_ConsignSituation As System.Windows.Forms.Label
        Friend WithEvents GridControl_ConsignRecpWare As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ConsignRecpWare As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
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
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RecipientBarcode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareAmount As DevExpress.XtraGrid.Columns.GridColumn

#End Region

    End Class

End Namespace
