Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00107
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
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_View As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00107))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Confirm = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.GridControl_ConsignLog = New DevExpress.XtraGrid.GridControl
            Me.GridView_ConsignLog = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_ConsignCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ConsignDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Functionary = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Confirmed = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.GridControl_ConsignLog, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ConsignLog, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Create, Me.ToolStripButton_Confirm, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_Refresh, Me.ToolStripButton_View, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_Close})
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
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.AccessibleDescription = Nothing
            Me.ToolStripButton_Create.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Create, "ToolStripButton_Create")
            Me.ToolStripButton_Create.BackgroundImage = Nothing
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            '
            'ToolStripButton_Confirm
            '
            Me.ToolStripButton_Confirm.AccessibleDescription = Nothing
            Me.ToolStripButton_Confirm.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Confirm, "ToolStripButton_Confirm")
            Me.ToolStripButton_Confirm.BackgroundImage = Nothing
            Me.ToolStripButton_Confirm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Confirm.Name = "ToolStripButton_Confirm"
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.AccessibleDescription = Nothing
            Me.ToolStripButton_Revise.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Revise, "ToolStripButton_Revise")
            Me.ToolStripButton_Revise.BackgroundImage = Nothing
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            '
            'ToolStripButton_Delete
            '
            Me.ToolStripButton_Delete.AccessibleDescription = Nothing
            Me.ToolStripButton_Delete.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Delete, "ToolStripButton_Delete")
            Me.ToolStripButton_Delete.BackgroundImage = Nothing
            Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.AccessibleDescription = Nothing
            Me.ToolStripButton_Refresh.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            Me.ToolStripButton_Refresh.BackgroundImage = Nothing
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            '
            'ToolStripButton_View
            '
            Me.ToolStripButton_View.AccessibleDescription = Nothing
            Me.ToolStripButton_View.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_View, "ToolStripButton_View")
            Me.ToolStripButton_View.BackgroundImage = Nothing
            Me.ToolStripButton_View.Name = "ToolStripButton_View"
            '
            'ToolStripButton_ExportExcel
            '
            Me.ToolStripButton_ExportExcel.AccessibleDescription = Nothing
            Me.ToolStripButton_ExportExcel.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_ExportExcel, "ToolStripButton_ExportExcel")
            Me.ToolStripButton_ExportExcel.BackgroundImage = Nothing
            Me.ToolStripButton_ExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_ExportExcel.Name = "ToolStripButton_ExportExcel"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.AccessibleDescription = Nothing
            Me.ToolStripButton_Close.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Close, "ToolStripButton_Close")
            Me.ToolStripButton_Close.BackgroundImage = Nothing
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            '
            'GridControl_ConsignLog
            '
            Me.GridControl_ConsignLog.AccessibleDescription = Nothing
            Me.GridControl_ConsignLog.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_ConsignLog, "GridControl_ConsignLog")
            Me.GridControl_ConsignLog.BackgroundImage = Nothing
            Me.GridControl_ConsignLog.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_ConsignLog.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_ConsignLog.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_ConsignLog.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_ConsignLog.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_ConsignLog.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_ConsignLog.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_ConsignLog.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_ConsignLog.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_ConsignLog.EmbeddedNavigator.Name = ""
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
            CTag2.ParentControl = Me.GridControl_ConsignLog.EmbeddedNavigator
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_ConsignLog.EmbeddedNavigator.Tag = CTag2
            Me.GridControl_ConsignLog.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_ConsignLog.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_ConsignLog.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_ConsignLog.EmbeddedNavigator.ToolTip")
            Me.GridControl_ConsignLog.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_ConsignLog.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_ConsignLog.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_ConsignLog.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_ConsignLog.Font = Nothing
            Me.GridControl_ConsignLog.MainView = Me.GridView_ConsignLog
            Me.GridControl_ConsignLog.Name = "GridControl_ConsignLog"
            Me.GridControl_ConsignLog.TabStop = False
            Me.GridControl_ConsignLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ConsignLog})
            '
            'GridView_ConsignLog
            '
            resources.ApplyResources(Me.GridView_ConsignLog, "GridView_ConsignLog")
            Me.GridView_ConsignLog.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_ConsignCode, Me.GridColumn_ConsignDate, Me.GridColumn_Functionary, Me.GridColumn_Confirmed, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_ConsignLog.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_ConsignLog.GridControl = Me.GridControl_ConsignLog
            Me.GridView_ConsignLog.Name = "GridView_ConsignLog"
            Me.GridView_ConsignLog.OptionsView.ColumnAutoWidth = False
            Me.GridView_ConsignLog.OptionsView.ShowFooter = True
            Me.GridView_ConsignLog.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_ConsignCode
            '
            resources.ApplyResources(Me.GridColumn_ConsignCode, "GridColumn_ConsignCode")
            Me.GridColumn_ConsignCode.FieldName = "CONSIGN_CODE"
            Me.GridColumn_ConsignCode.Name = "GridColumn_ConsignCode"
            Me.GridColumn_ConsignCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_ConsignCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_ConsignCode.SummaryItem.DisplayFormat")
            Me.GridColumn_ConsignCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_ConsignDate
            '
            resources.ApplyResources(Me.GridColumn_ConsignDate, "GridColumn_ConsignDate")
            Me.GridColumn_ConsignDate.FieldName = "CONSIGN_DATE"
            Me.GridColumn_ConsignDate.Name = "GridColumn_ConsignDate"
            Me.GridColumn_ConsignDate.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Functionary
            '
            resources.ApplyResources(Me.GridColumn_Functionary, "GridColumn_Functionary")
            Me.GridColumn_Functionary.FieldName = "FUNCTIONARY__STAFF_NAME"
            Me.GridColumn_Functionary.Name = "GridColumn_Functionary"
            Me.GridColumn_Functionary.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Confirmed
            '
            resources.ApplyResources(Me.GridColumn_Confirmed, "GridColumn_Confirmed")
            Me.GridColumn_Confirmed.FieldName = "IS_CONFIRMED"
            Me.GridColumn_Confirmed.Name = "GridColumn_Confirmed"
            Me.GridColumn_Confirmed.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowHighlight
            '
            resources.ApplyResources(Me.GridColumn_RowHighlight, "GridColumn_RowHighlight")
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            '
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.AccessibleDescription = Nothing
            Me.PanelControl_Filter.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.BackgroundImage = Nothing
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            CTag5.ParentControl = Me.PanelControl_Filter
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag5
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
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
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
            CTag4.ParentControl = Me.Label1
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag4
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'M_02_00107
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_ConsignLog)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_00107"
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
            CType(Me.GridControl_ConsignLog, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ConsignLog, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GridControl_ConsignLog As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ConsignLog As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_ConsignCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ConsignDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Functionary As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Confirmed As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ToolStripButton_Confirm As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace
