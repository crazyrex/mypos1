﻿Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00901
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
        Friend WithEvents ToolStripButton_Report As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Report = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_SaleAffair = New DevExpress.XtraGrid.GridControl
            Me.GridView_SaleAffair = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_AffairName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BeginDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_AffairDays = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TemplateID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TemplateID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EndDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_SaleAffair, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_SaleAffair, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TemplateID, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Timer_Surveillant
            '
            '
            'ToolStrip_Form
            '
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Create, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_Report, Me.ToolStripButton_Refresh, Me.ToolStripButton_Close})
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
            Me.ToolStripButton_Create.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Create.Text = "新建"
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            Me.ToolStripButton_Revise.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Revise.Text = "修改"
            '
            'ToolStripButton_Delete
            '
            Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
            Me.ToolStripButton_Delete.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Delete.Text = "删除"
            '
            'ToolStripButton_Report
            '
            Me.ToolStripButton_Report.Name = "ToolStripButton_Report"
            Me.ToolStripButton_Report.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Report.Text = "报表"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            Me.ToolStripButton_Refresh.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Refresh.Text = "刷新"
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
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl_Filter.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
            Me.PanelControl_Filter.Size = New System.Drawing.Size(700, 47)
            Me.PanelControl_Filter.TabIndex = 10001
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
            Me.TextEdit_Search.EditValue = ""
            Me.TextEdit_Search.Location = New System.Drawing.Point(67, 13)
            Me.TextEdit_Search.Name = "TextEdit_Search"
            Me.TextEdit_Search.Size = New System.Drawing.Size(184, 21)
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
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(17, 14)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(44, 20)
            Me.Label1.TabIndex = 10000
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
            Me.Label1.Text = "搜索"
            '
            'GridControl_SaleAffair
            '
            Me.GridControl_SaleAffair.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_SaleAffair.EmbeddedNavigator.Name = ""
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
            CTag5.ParentControl = Me.GridControl_SaleAffair.EmbeddedNavigator
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_SaleAffair.EmbeddedNavigator.Tag = CTag5
            Me.GridControl_SaleAffair.Location = New System.Drawing.Point(0, 72)
            Me.GridControl_SaleAffair.MainView = Me.GridView_SaleAffair
            Me.GridControl_SaleAffair.Name = "GridControl_SaleAffair"
            Me.GridControl_SaleAffair.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_TemplateID})
            Me.GridControl_SaleAffair.Size = New System.Drawing.Size(700, 428)
            Me.GridControl_SaleAffair.TabIndex = 10002
            Me.GridControl_SaleAffair.TabStop = False
            Me.GridControl_SaleAffair.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_SaleAffair})
            '
            'GridView_SaleAffair
            '
            Me.GridView_SaleAffair.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_AffairName, Me.GridColumn_BeginDate, Me.GridColumn_AffairDays, Me.GridColumn_EndDate, Me.GridColumn_TemplateID, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.OrangeRed
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "ROW_HIGHLIGHT_ACTIVE_AFFAIR"
            Me.GridView_SaleAffair.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.GridView_SaleAffair.GridControl = Me.GridControl_SaleAffair
            Me.GridView_SaleAffair.Name = "GridView_SaleAffair"
            Me.GridView_SaleAffair.OptionsView.ColumnAutoWidth = False
            Me.GridView_SaleAffair.OptionsView.ShowFooter = True
            Me.GridView_SaleAffair.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_AffairName
            '
            Me.GridColumn_AffairName.Caption = "活动名称"
            Me.GridColumn_AffairName.FieldName = "AFFAIR_NAME"
            Me.GridColumn_AffairName.Name = "GridColumn_AffairName"
            Me.GridColumn_AffairName.OptionsColumn.AllowFocus = False
            Me.GridColumn_AffairName.SummaryItem.FieldName = "STAFF_CODE"
            Me.GridColumn_AffairName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_AffairName.Visible = True
            Me.GridColumn_AffairName.VisibleIndex = 0
            '
            'GridColumn_BeginDate
            '
            Me.GridColumn_BeginDate.Caption = "开始日期"
            Me.GridColumn_BeginDate.FieldName = "BEGIN_DATE"
            Me.GridColumn_BeginDate.Name = "GridColumn_BeginDate"
            Me.GridColumn_BeginDate.OptionsColumn.AllowFocus = False
            Me.GridColumn_BeginDate.Visible = True
            Me.GridColumn_BeginDate.VisibleIndex = 1
            '
            'GridColumn_AffairDays
            '
            Me.GridColumn_AffairDays.Caption = "持续天数"
            Me.GridColumn_AffairDays.FieldName = "AFFAIR_DAYS"
            Me.GridColumn_AffairDays.Name = "GridColumn_AffairDays"
            Me.GridColumn_AffairDays.OptionsColumn.AllowFocus = False
            Me.GridColumn_AffairDays.Visible = True
            Me.GridColumn_AffairDays.VisibleIndex = 2
            '
            'GridColumn_TemplateID
            '
            Me.GridColumn_TemplateID.Caption = "模板编号"
            Me.GridColumn_TemplateID.ColumnEdit = Me.RepositoryItemLookUpEdit_TemplateID
            Me.GridColumn_TemplateID.FieldName = "TEMPLATE_ID"
            Me.GridColumn_TemplateID.Name = "GridColumn_TemplateID"
            Me.GridColumn_TemplateID.OptionsColumn.AllowFocus = False
            Me.GridColumn_TemplateID.Visible = True
            Me.GridColumn_TemplateID.VisibleIndex = 4
            '
            'RepositoryItemLookUpEdit_TemplateID
            '
            Me.RepositoryItemLookUpEdit_TemplateID.AutoHeight = False
            Me.RepositoryItemLookUpEdit_TemplateID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_TemplateID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEMPLATE_CODE", "Name1", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TemplateID.DisplayMember = "TEMPLATE_CODE"
            Me.RepositoryItemLookUpEdit_TemplateID.Name = "RepositoryItemLookUpEdit_TemplateID"
            Me.RepositoryItemLookUpEdit_TemplateID.ValueMember = "TEMPLATE_ID"
            '
            'GridColumn_RowHighlight
            '
            Me.GridColumn_RowHighlight.Caption = "高亮显示"
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'GridColumn_EndDate
            '
            Me.GridColumn_EndDate.Caption = "结束日期"
            Me.GridColumn_EndDate.FieldName = "END_DATE"
            Me.GridColumn_EndDate.Name = "GridColumn_EndDate"
            Me.GridColumn_EndDate.OptionsColumn.AllowFocus = False
            Me.GridColumn_EndDate.Visible = True
            Me.GridColumn_EndDate.VisibleIndex = 3
            '
            'M_01_00901
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.GridControl_SaleAffair)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_01_00901"
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
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_SaleAffair, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_SaleAffair, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TemplateID, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GridControl_SaleAffair As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_SaleAffair As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_AffairName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BeginDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_AffairDays As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TemplateID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_TemplateID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_EndDate As DevExpress.XtraGrid.Columns.GridColumn

#End Region

    End Class

End Namespace

