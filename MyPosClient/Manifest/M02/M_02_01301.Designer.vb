Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_01301
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
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_01301))
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label6 = New System.Windows.Forms.Label
            Me.GridControl_Quotation = New DevExpress.XtraGrid.GridControl
            Me.GridView_Quotation = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_QuotationCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_QuotationType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowSelect = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_Quotation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Quotation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverBookStatus, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Create, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_Refresh, Me.ToolStripButton_Close})
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
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(33, 22)
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
            'GridControl_Quotation
            '
            Me.GridControl_Quotation.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_Quotation.EmbeddedNavigator.Name = ""
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
            CTag5.ParentControl = Me.GridControl_Quotation.EmbeddedNavigator
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Quotation.EmbeddedNavigator.Tag = CTag5
            Me.GridControl_Quotation.Location = New System.Drawing.Point(0, 78)
            Me.GridControl_Quotation.MainView = Me.GridView_Quotation
            Me.GridControl_Quotation.Name = "GridControl_Quotation"
            Me.GridControl_Quotation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_TurnoverBookStatus, Me.RepositoryItemCheckEdit_Select})
            Me.GridControl_Quotation.Size = New System.Drawing.Size(700, 422)
            Me.GridControl_Quotation.TabIndex = 10002
            Me.GridControl_Quotation.TabStop = False
            Me.GridControl_Quotation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Quotation})
            '
            'GridView_Quotation
            '
            Me.GridView_Quotation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_QuotationCode, Me.GridColumn_CreateDate, Me.GridColumn_QuotationType, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight, Me.GridColumn_RowSelect})
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
            Me.GridView_Quotation.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.GridView_Quotation.GridControl = Me.GridControl_Quotation
            Me.GridView_Quotation.Name = "GridView_Quotation"
            Me.GridView_Quotation.OptionsView.ColumnAutoWidth = False
            Me.GridView_Quotation.OptionsView.ShowFooter = True
            Me.GridView_Quotation.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_QuotationCode
            '
            Me.GridColumn_QuotationCode.Caption = "报价编号"
            Me.GridColumn_QuotationCode.FieldName = "QUOTATION_CODE"
            Me.GridColumn_QuotationCode.Name = "GridColumn_QuotationCode"
            Me.GridColumn_QuotationCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_QuotationCode.SummaryItem.FieldName = "WARE_CODE"
            Me.GridColumn_QuotationCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_QuotationCode.Visible = True
            Me.GridColumn_QuotationCode.VisibleIndex = 1
            Me.GridColumn_QuotationCode.Width = 60
            '
            'GridColumn_CreateDate
            '
            Me.GridColumn_CreateDate.Caption = "创建日期"
            Me.GridColumn_CreateDate.DisplayFormat.FormatString = "yyyy-MM-dd"
            Me.GridColumn_CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.GridColumn_CreateDate.FieldName = "CREATE_DATE"
            Me.GridColumn_CreateDate.Name = "GridColumn_CreateDate"
            Me.GridColumn_CreateDate.OptionsColumn.AllowFocus = False
            Me.GridColumn_CreateDate.Visible = True
            Me.GridColumn_CreateDate.VisibleIndex = 2
            Me.GridColumn_CreateDate.Width = 60
            '
            'GridColumn_QuotationType
            '
            Me.GridColumn_QuotationType.Caption = "报价类型"
            Me.GridColumn_QuotationType.FieldName = "QUOTATION_TYPE"
            Me.GridColumn_QuotationType.Name = "GridColumn_QuotationType"
            Me.GridColumn_QuotationType.OptionsColumn.AllowFocus = False
            Me.GridColumn_QuotationType.Visible = True
            Me.GridColumn_QuotationType.VisibleIndex = 3
            Me.GridColumn_QuotationType.Width = 60
            '
            'GridColumn_Remarks
            '
            Me.GridColumn_Remarks.Caption = "备注"
            Me.GridColumn_Remarks.FieldName = "REMARKS"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            Me.GridColumn_Remarks.Visible = True
            Me.GridColumn_Remarks.VisibleIndex = 4
            Me.GridColumn_Remarks.Width = 60
            '
            'GridColumn_RowHighlight
            '
            Me.GridColumn_RowHighlight.Caption = "高亮显示"
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            Me.GridColumn_RowHighlight.Width = 60
            '
            'GridColumn_RowSelect
            '
            Me.GridColumn_RowSelect.Caption = "选择"
            Me.GridColumn_RowSelect.ColumnEdit = Me.RepositoryItemCheckEdit_Select
            Me.GridColumn_RowSelect.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_RowSelect.Name = "GridColumn_RowSelect"
            Me.GridColumn_RowSelect.Visible = True
            Me.GridColumn_RowSelect.VisibleIndex = 0
            Me.GridColumn_RowSelect.Width = 36
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
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Create.Image = CType(resources.GetObject("ToolStripButton_Create.Image"), System.Drawing.Image)
            Me.ToolStripButton_Create.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            Me.ToolStripButton_Create.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Create.Text = "新建"
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Revise.Image = CType(resources.GetObject("ToolStripButton_Revise.Image"), System.Drawing.Image)
            Me.ToolStripButton_Revise.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            Me.ToolStripButton_Revise.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Revise.Text = "修改"
            '
            'ToolStripButton_Delete
            '
            Me.ToolStripButton_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Delete.Image = CType(resources.GetObject("ToolStripButton_Delete.Image"), System.Drawing.Image)
            Me.ToolStripButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
            Me.ToolStripButton_Delete.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Delete.Text = "删除"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Refresh.Image = CType(resources.GetObject("ToolStripButton_Refresh.Image"), System.Drawing.Image)
            Me.ToolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            Me.ToolStripButton_Refresh.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Refresh.Text = "刷新"
            '
            'M_02_01301
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.GridControl_Quotation)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_02_01301"
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
            CType(Me.GridControl_Quotation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Quotation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverBookStatus, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents GridControl_Quotation As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Quotation As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_QuotationCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CreateDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_QuotationType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowSelect As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverBookStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents ToolStripButton_Create As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace

