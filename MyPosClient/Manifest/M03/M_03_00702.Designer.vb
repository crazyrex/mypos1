Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_00702
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_00702))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Edit = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.Label_EmployeeInfo = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_TurnoverCommission = New DevExpress.XtraGrid.GridControl
            Me.GridView_TurnoverCommission = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_TurnoverCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverTime = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_DeliveryCharge = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ED = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShareEmployeeCount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EmployeeCommission = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.GridControl_TurnoverCommission, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_TurnoverCommission, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Refresh, Me.ToolStripButton_Edit, Me.ToolStripButton_Close})
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
            Me.ToolStripButton_Refresh.AccessibleDescription = Nothing
            Me.ToolStripButton_Refresh.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            Me.ToolStripButton_Refresh.BackgroundImage = Nothing
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            '
            'ToolStripButton_Edit
            '
            Me.ToolStripButton_Edit.AccessibleDescription = Nothing
            Me.ToolStripButton_Edit.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Edit, "ToolStripButton_Edit")
            Me.ToolStripButton_Edit.BackgroundImage = Nothing
            Me.ToolStripButton_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Edit.Name = "ToolStripButton_Edit"
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
            Me.PanelControl_Filter.Controls.Add(Me.Label_EmployeeInfo)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
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
            'Label_EmployeeInfo
            '
            Me.Label_EmployeeInfo.AccessibleDescription = Nothing
            Me.Label_EmployeeInfo.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_EmployeeInfo, "Label_EmployeeInfo")
            Me.Label_EmployeeInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_EmployeeInfo.Font = Nothing
            Me.Label_EmployeeInfo.Name = "Label_EmployeeInfo"
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
            CTag2.ParentControl = Me.Label_EmployeeInfo
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label_EmployeeInfo.Tag = CTag2
            '
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
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
            'GridControl_TurnoverCommission
            '
            Me.GridControl_TurnoverCommission.AccessibleDescription = Nothing
            Me.GridControl_TurnoverCommission.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_TurnoverCommission, "GridControl_TurnoverCommission")
            Me.GridControl_TurnoverCommission.BackgroundImage = Nothing
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_TurnoverCommission.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_TurnoverCommission.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_TurnoverCommission.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.Name = ""
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
            CTag5.ParentControl = Me.GridControl_TurnoverCommission.EmbeddedNavigator
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.Tag = CTag5
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_TurnoverCommission.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_TurnoverCommission.EmbeddedNavigator.ToolTip")
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_TurnoverCommission.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_TurnoverCommission.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_TurnoverCommission.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_TurnoverCommission.Font = Nothing
            Me.GridControl_TurnoverCommission.MainView = Me.GridView_TurnoverCommission
            Me.GridControl_TurnoverCommission.Name = "GridControl_TurnoverCommission"
            Me.GridControl_TurnoverCommission.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select})
            Me.GridControl_TurnoverCommission.TabStop = False
            Me.GridControl_TurnoverCommission.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_TurnoverCommission})
            '
            'GridView_TurnoverCommission
            '
            resources.ApplyResources(Me.GridView_TurnoverCommission, "GridView_TurnoverCommission")
            Me.GridView_TurnoverCommission.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_TurnoverCode, Me.GridColumn_TurnoverTime, Me.GridColumn_DeliveryCharge, Me.GridColumn_ED, Me.GridColumn_SumPrice, Me.GridColumn_ShareEmployeeCount, Me.GridColumn_EmployeeCommission, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_TurnoverCommission.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_TurnoverCommission.GridControl = Me.GridControl_TurnoverCommission
            Me.GridView_TurnoverCommission.Name = "GridView_TurnoverCommission"
            Me.GridView_TurnoverCommission.OptionsView.ColumnAutoWidth = False
            Me.GridView_TurnoverCommission.OptionsView.ShowFooter = True
            Me.GridView_TurnoverCommission.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_TurnoverCode
            '
            resources.ApplyResources(Me.GridColumn_TurnoverCode, "GridColumn_TurnoverCode")
            Me.GridColumn_TurnoverCode.FieldName = "TURNOVER_CODE"
            Me.GridColumn_TurnoverCode.Name = "GridColumn_TurnoverCode"
            Me.GridColumn_TurnoverCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TurnoverTime
            '
            resources.ApplyResources(Me.GridColumn_TurnoverTime, "GridColumn_TurnoverTime")
            Me.GridColumn_TurnoverTime.FieldName = "TURNOVER_TIME"
            Me.GridColumn_TurnoverTime.Name = "GridColumn_TurnoverTime"
            Me.GridColumn_TurnoverTime.OptionsColumn.AllowFocus = False
            '
            'GridColumn_DeliveryCharge
            '
            resources.ApplyResources(Me.GridColumn_DeliveryCharge, "GridColumn_DeliveryCharge")
            Me.GridColumn_DeliveryCharge.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_DeliveryCharge.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_DeliveryCharge.FieldName = "DELIVERY_CHARGE"
            Me.GridColumn_DeliveryCharge.Name = "GridColumn_DeliveryCharge"
            Me.GridColumn_DeliveryCharge.OptionsColumn.AllowFocus = False
            Me.GridColumn_DeliveryCharge.SummaryItem.DisplayFormat = resources.GetString("GridColumn_DeliveryCharge.SummaryItem.DisplayFormat")
            Me.GridColumn_DeliveryCharge.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_ED
            '
            resources.ApplyResources(Me.GridColumn_ED, "GridColumn_ED")
            Me.GridColumn_ED.FieldName = "EXTRA_DISCOUNT"
            Me.GridColumn_ED.Name = "GridColumn_ED"
            Me.GridColumn_ED.OptionsColumn.AllowFocus = False
            Me.GridColumn_ED.SummaryItem.DisplayFormat = resources.GetString("GridColumn_ED.SummaryItem.DisplayFormat")
            Me.GridColumn_ED.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_SumPrice
            '
            resources.ApplyResources(Me.GridColumn_SumPrice, "GridColumn_SumPrice")
            Me.GridColumn_SumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SumPrice.FieldName = "TOTAL_SUM_PRICE"
            Me.GridColumn_SumPrice.Name = "GridColumn_SumPrice"
            Me.GridColumn_SumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_SumPrice.SummaryItem.DisplayFormat = resources.GetString("GridColumn_SumPrice.SummaryItem.DisplayFormat")
            Me.GridColumn_SumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_ShareEmployeeCount
            '
            resources.ApplyResources(Me.GridColumn_ShareEmployeeCount, "GridColumn_ShareEmployeeCount")
            Me.GridColumn_ShareEmployeeCount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_ShareEmployeeCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_ShareEmployeeCount.FieldName = "SHARE_STAFF_COUNT"
            Me.GridColumn_ShareEmployeeCount.Name = "GridColumn_ShareEmployeeCount"
            Me.GridColumn_ShareEmployeeCount.OptionsColumn.AllowFocus = False
            Me.GridColumn_ShareEmployeeCount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_ShareEmployeeCount.SummaryItem.DisplayFormat")
            Me.GridColumn_ShareEmployeeCount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_EmployeeCommission
            '
            resources.ApplyResources(Me.GridColumn_EmployeeCommission, "GridColumn_EmployeeCommission")
            Me.GridColumn_EmployeeCommission.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_EmployeeCommission.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_EmployeeCommission.FieldName = "STAFF_COMMISSION"
            Me.GridColumn_EmployeeCommission.Name = "GridColumn_EmployeeCommission"
            Me.GridColumn_EmployeeCommission.OptionsColumn.AllowFocus = False
            Me.GridColumn_EmployeeCommission.SummaryItem.DisplayFormat = resources.GetString("GridColumn_EmployeeCommission.SummaryItem.DisplayFormat")
            Me.GridColumn_EmployeeCommission.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
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
            'M_03_00702
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_TurnoverCommission)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_00702"
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
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.GridControl_TurnoverCommission, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_TurnoverCommission, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label_EmployeeInfo As System.Windows.Forms.Label
        Friend WithEvents GridControl_TurnoverCommission As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_TurnoverCommission As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_TurnoverCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverTime As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_DeliveryCharge As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ED As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShareEmployeeCount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents GridColumn_EmployeeCommission As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ToolStripButton_Edit As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace
