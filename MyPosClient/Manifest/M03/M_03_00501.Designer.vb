Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_00501
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
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_00501))
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Details = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
            Me.XtraTabPage_Receivables = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_ReceivableList = New DevExpress.XtraGrid.GridControl
            Me.GridView_ReceivableList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_Receivable = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomerCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomerName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WorkPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Fax = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Linkman = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CellPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Email = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.XtraTabPage_Payables = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_PayableList = New DevExpress.XtraGrid.GridControl
            Me.GridView_PayableList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_Payable = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SupplierCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SWorkPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SFax = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SLinkman = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SCellPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SEmail = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SRowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl1.SuspendLayout()
            Me.XtraTabPage_Receivables.SuspendLayout()
            CType(Me.GridControl_ReceivableList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ReceivableList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage_Payables.SuspendLayout()
            CType(Me.GridControl_PayableList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_PayableList, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Refresh, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_Details, Me.ToolStripButton_Close})
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
            'ToolStripButton_Details
            '
            Me.ToolStripButton_Details.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_Details, "ToolStripButton_Details")
            Me.ToolStripButton_Details.Name = "ToolStripButton_Details"
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
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            CTag4.ParentControl = Me.PanelControl_Filter
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag4
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.Name = "TextEdit_Search"
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
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
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
            'XtraTabControl1
            '
            resources.ApplyResources(Me.XtraTabControl1, "XtraTabControl1")
            Me.XtraTabControl1.Name = "XtraTabControl1"
            Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage_Receivables
            Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage_Receivables, Me.XtraTabPage_Payables})
            Me.XtraTabControl1.TabStop = False
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
            CTag7.ParentControl = Me.XtraTabControl1
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabControl1.Tag = CTag7
            '
            'XtraTabPage_Receivables
            '
            Me.XtraTabPage_Receivables.Controls.Add(Me.GridControl_ReceivableList)
            Me.XtraTabPage_Receivables.Name = "XtraTabPage_Receivables"
            resources.ApplyResources(Me.XtraTabPage_Receivables, "XtraTabPage_Receivables")
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
            CTag5.ParentControl = Me.XtraTabPage_Receivables
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_Receivables.Tag = CTag5
            '
            'GridControl_ReceivableList
            '
            resources.ApplyResources(Me.GridControl_ReceivableList, "GridControl_ReceivableList")
            Me.GridControl_ReceivableList.EmbeddedNavigator.Name = ""
            Me.GridControl_ReceivableList.MainView = Me.GridView_ReceivableList
            Me.GridControl_ReceivableList.Name = "GridControl_ReceivableList"
            Me.GridControl_ReceivableList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ReceivableList})
            '
            'GridView_ReceivableList
            '
            Me.GridView_ReceivableList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_Receivable, Me.GridColumn_CustomerCode, Me.GridColumn_CustomerName, Me.GridColumn_WorkPhone, Me.GridColumn_Fax, Me.GridColumn_Linkman, Me.GridColumn_CellPhone, Me.GridColumn_Email, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_ReceivableList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_ReceivableList.GridControl = Me.GridControl_ReceivableList
            Me.GridView_ReceivableList.Name = "GridView_ReceivableList"
            Me.GridView_ReceivableList.OptionsView.ColumnAutoWidth = False
            Me.GridView_ReceivableList.OptionsView.ShowFooter = True
            Me.GridView_ReceivableList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_Receivable
            '
            resources.ApplyResources(Me.GridColumn_Receivable, "GridColumn_Receivable")
            Me.GridColumn_Receivable.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Receivable.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Receivable.FieldName = "RECEIVABLE"
            Me.GridColumn_Receivable.Name = "GridColumn_Receivable"
            Me.GridColumn_Receivable.OptionsColumn.AllowFocus = False
            Me.GridColumn_Receivable.SummaryItem.DisplayFormat = resources.GetString("GridColumn_Receivable.SummaryItem.DisplayFormat")
            Me.GridColumn_Receivable.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_CustomerCode
            '
            resources.ApplyResources(Me.GridColumn_CustomerCode, "GridColumn_CustomerCode")
            Me.GridColumn_CustomerCode.FieldName = "CLIENT_CODE"
            Me.GridColumn_CustomerCode.Name = "GridColumn_CustomerCode"
            Me.GridColumn_CustomerCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomerCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_CustomerName
            '
            resources.ApplyResources(Me.GridColumn_CustomerName, "GridColumn_CustomerName")
            Me.GridColumn_CustomerName.FieldName = "CLIENT_NAME"
            Me.GridColumn_CustomerName.Name = "GridColumn_CustomerName"
            Me.GridColumn_CustomerName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_WorkPhone
            '
            resources.ApplyResources(Me.GridColumn_WorkPhone, "GridColumn_WorkPhone")
            Me.GridColumn_WorkPhone.FieldName = "WORK_PHONE"
            Me.GridColumn_WorkPhone.Name = "GridColumn_WorkPhone"
            Me.GridColumn_WorkPhone.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Fax
            '
            resources.ApplyResources(Me.GridColumn_Fax, "GridColumn_Fax")
            Me.GridColumn_Fax.FieldName = "FAX"
            Me.GridColumn_Fax.Name = "GridColumn_Fax"
            Me.GridColumn_Fax.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Linkman
            '
            resources.ApplyResources(Me.GridColumn_Linkman, "GridColumn_Linkman")
            Me.GridColumn_Linkman.FieldName = "LINKMAN"
            Me.GridColumn_Linkman.Name = "GridColumn_Linkman"
            Me.GridColumn_Linkman.OptionsColumn.AllowFocus = False
            '
            'GridColumn_CellPhone
            '
            resources.ApplyResources(Me.GridColumn_CellPhone, "GridColumn_CellPhone")
            Me.GridColumn_CellPhone.FieldName = "CELL_PHONE"
            Me.GridColumn_CellPhone.Name = "GridColumn_CellPhone"
            Me.GridColumn_CellPhone.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Email
            '
            resources.ApplyResources(Me.GridColumn_Email, "GridColumn_Email")
            Me.GridColumn_Email.FieldName = "EMAIL"
            Me.GridColumn_Email.Name = "GridColumn_Email"
            Me.GridColumn_Email.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowHighlight
            '
            resources.ApplyResources(Me.GridColumn_RowHighlight, "GridColumn_RowHighlight")
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'XtraTabPage_Payables
            '
            Me.XtraTabPage_Payables.Controls.Add(Me.GridControl_PayableList)
            Me.XtraTabPage_Payables.Name = "XtraTabPage_Payables"
            resources.ApplyResources(Me.XtraTabPage_Payables, "XtraTabPage_Payables")
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
            CTag6.ParentControl = Me.XtraTabPage_Payables
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_Payables.Tag = CTag6
            '
            'GridControl_PayableList
            '
            resources.ApplyResources(Me.GridControl_PayableList, "GridControl_PayableList")
            Me.GridControl_PayableList.EmbeddedNavigator.Name = ""
            Me.GridControl_PayableList.MainView = Me.GridView_PayableList
            Me.GridControl_PayableList.Name = "GridControl_PayableList"
            Me.GridControl_PayableList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_PayableList})
            '
            'GridView_PayableList
            '
            Me.GridView_PayableList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_Payable, Me.GridColumn_SupplierCode, Me.GridColumn_SupplierName, Me.GridColumn_SWorkPhone, Me.GridColumn_SFax, Me.GridColumn_SLinkman, Me.GridColumn_SCellPhone, Me.GridColumn_SEmail, Me.GridColumn_SRowHighlight})
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_SRowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "SEARCH_MATCH"
            Me.GridView_PayableList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
            Me.GridView_PayableList.GridControl = Me.GridControl_PayableList
            Me.GridView_PayableList.Name = "GridView_PayableList"
            Me.GridView_PayableList.OptionsView.ColumnAutoWidth = False
            Me.GridView_PayableList.OptionsView.ShowFooter = True
            Me.GridView_PayableList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_Payable
            '
            resources.ApplyResources(Me.GridColumn_Payable, "GridColumn_Payable")
            Me.GridColumn_Payable.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Payable.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Payable.FieldName = "PAYABLE"
            Me.GridColumn_Payable.Name = "GridColumn_Payable"
            Me.GridColumn_Payable.OptionsColumn.AllowFocus = False
            Me.GridColumn_Payable.SummaryItem.DisplayFormat = resources.GetString("GridColumn_Payable.SummaryItem.DisplayFormat")
            Me.GridColumn_Payable.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_SupplierCode
            '
            resources.ApplyResources(Me.GridColumn_SupplierCode, "GridColumn_SupplierCode")
            Me.GridColumn_SupplierCode.FieldName = "SUPPLIER_CODE"
            Me.GridColumn_SupplierCode.Name = "GridColumn_SupplierCode"
            Me.GridColumn_SupplierCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_SupplierCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_SupplierName
            '
            resources.ApplyResources(Me.GridColumn_SupplierName, "GridColumn_SupplierName")
            Me.GridColumn_SupplierName.FieldName = "SUPPLIER_NAME"
            Me.GridColumn_SupplierName.Name = "GridColumn_SupplierName"
            Me.GridColumn_SupplierName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SWorkPhone
            '
            resources.ApplyResources(Me.GridColumn_SWorkPhone, "GridColumn_SWorkPhone")
            Me.GridColumn_SWorkPhone.FieldName = "WORK_PHONE"
            Me.GridColumn_SWorkPhone.Name = "GridColumn_SWorkPhone"
            Me.GridColumn_SWorkPhone.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SFax
            '
            resources.ApplyResources(Me.GridColumn_SFax, "GridColumn_SFax")
            Me.GridColumn_SFax.FieldName = "FAX"
            Me.GridColumn_SFax.Name = "GridColumn_SFax"
            Me.GridColumn_SFax.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SLinkman
            '
            resources.ApplyResources(Me.GridColumn_SLinkman, "GridColumn_SLinkman")
            Me.GridColumn_SLinkman.FieldName = "LINKMAN"
            Me.GridColumn_SLinkman.Name = "GridColumn_SLinkman"
            Me.GridColumn_SLinkman.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SCellPhone
            '
            resources.ApplyResources(Me.GridColumn_SCellPhone, "GridColumn_SCellPhone")
            Me.GridColumn_SCellPhone.FieldName = "CELL_PHONE"
            Me.GridColumn_SCellPhone.Name = "GridColumn_SCellPhone"
            Me.GridColumn_SCellPhone.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SEmail
            '
            resources.ApplyResources(Me.GridColumn_SEmail, "GridColumn_SEmail")
            Me.GridColumn_SEmail.FieldName = "EMAIL"
            Me.GridColumn_SEmail.Name = "GridColumn_SEmail"
            Me.GridColumn_SEmail.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SRowHighlight
            '
            resources.ApplyResources(Me.GridColumn_SRowHighlight, "GridColumn_SRowHighlight")
            Me.GridColumn_SRowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_SRowHighlight.Name = "GridColumn_SRowHighlight"
            Me.GridColumn_SRowHighlight.OptionsColumn.AllowFocus = False
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'M_03_00501
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.XtraTabControl1)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_00501"
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
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl1.ResumeLayout(False)
            Me.XtraTabPage_Receivables.ResumeLayout(False)
            CType(Me.GridControl_ReceivableList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ReceivableList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage_Payables.ResumeLayout(False)
            CType(Me.GridControl_PayableList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_PayableList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Details As System.Windows.Forms.ToolStripButton
        Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage_Receivables As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage_Payables As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents GridControl_ReceivableList As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ReceivableList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_CustomerCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomerName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WorkPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Fax As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Linkman As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CellPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Email As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Receivable As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_PayableList As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_PayableList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_SupplierCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SWorkPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SFax As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SLinkman As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SCellPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SEmail As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Payable As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SRowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog

#End Region

    End Class

End Namespace
