Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00201
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
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00201))
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_BeginCheck = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Review = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_ShowFinish = New DevExpress.XtraEditors.CheckEdit
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.GridControl_InventoryList = New DevExpress.XtraGrid.GridControl
            Me.GridView_InventoryList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_InventoryCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PosName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EmployeeName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_InventoryStatus = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_InventoryStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_RowHighLight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CheckAllItem = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_CheckAllItem = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.CheckEdit_ShowFinish.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_InventoryList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_InventoryList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_InventoryStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_CheckAllItem, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Create, Me.ToolStripButton_BeginCheck, Me.ToolStripButton_Review, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_Refresh, Me.ToolStripButton_View, Me.ToolStripButton_Close})
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
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            resources.ApplyResources(Me.ToolStripButton_Create, "ToolStripButton_Create")
            '
            'ToolStripButton_BeginCheck
            '
            Me.ToolStripButton_BeginCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_BeginCheck, "ToolStripButton_BeginCheck")
            Me.ToolStripButton_BeginCheck.Name = "ToolStripButton_BeginCheck"
            '
            'ToolStripButton_Review
            '
            Me.ToolStripButton_Review.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_Review, "ToolStripButton_Review")
            Me.ToolStripButton_Review.Name = "ToolStripButton_Review"
            '
            'ToolStripButton_Revise
            '
            resources.ApplyResources(Me.ToolStripButton_Revise, "ToolStripButton_Revise")
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            '
            'ToolStripButton_Delete
            '
            resources.ApplyResources(Me.ToolStripButton_Delete, "ToolStripButton_Delete")
            Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            '
            'ToolStripButton_View
            '
            resources.ApplyResources(Me.ToolStripButton_View, "ToolStripButton_View")
            Me.ToolStripButton_View.Name = "ToolStripButton_View"
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
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_ShowFinish)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_ToDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label3)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_FromDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            'CheckEdit_ShowFinish
            '
            resources.ApplyResources(Me.CheckEdit_ShowFinish, "CheckEdit_ShowFinish")
            Me.CheckEdit_ShowFinish.Name = "CheckEdit_ShowFinish"
            Me.CheckEdit_ShowFinish.Properties.Caption = resources.GetString("CheckEdit_ShowFinish.Properties.Caption")
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
            CTag2.ParentControl = Me.CheckEdit_ShowFinish
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_ShowFinish.Tag = CTag2
            '
            'DateEdit_ToDate
            '
            Me.DateEdit_ToDate.EditValue = Nothing
            resources.ApplyResources(Me.DateEdit_ToDate, "DateEdit_ToDate")
            Me.DateEdit_ToDate.Name = "DateEdit_ToDate"
            Me.DateEdit_ToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_ToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_ToDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag3.ParentControl = Me.DateEdit_ToDate
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_ToDate.Tag = CTag3
            '
            'Label3
            '
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
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
            CTag4.ParentControl = Me.Label3
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag4
            '
            'DateEdit_FromDate
            '
            Me.DateEdit_FromDate.EditValue = Nothing
            resources.ApplyResources(Me.DateEdit_FromDate, "DateEdit_FromDate")
            Me.DateEdit_FromDate.Name = "DateEdit_FromDate"
            Me.DateEdit_FromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_FromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_FromDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag5.ParentControl = Me.DateEdit_FromDate
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_FromDate.Tag = CTag5
            '
            'Label2
            '
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
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
            CTag6.ParentControl = Me.Label2
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag6
            '
            'GridControl_InventoryList
            '
            resources.ApplyResources(Me.GridControl_InventoryList, "GridControl_InventoryList")
            Me.GridControl_InventoryList.EmbeddedNavigator.Name = ""
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
            CTag8.ParentControl = Me.GridControl_InventoryList.EmbeddedNavigator
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_InventoryList.EmbeddedNavigator.Tag = CTag8
            Me.GridControl_InventoryList.MainView = Me.GridView_InventoryList
            Me.GridControl_InventoryList.Name = "GridControl_InventoryList"
            Me.GridControl_InventoryList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_InventoryStatus, Me.RepositoryItemCheckEdit_CheckAllItem})
            Me.GridControl_InventoryList.TabStop = False
            Me.GridControl_InventoryList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_InventoryList})
            '
            'GridView_InventoryList
            '
            Me.GridView_InventoryList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_InventoryCode, Me.GridColumn_PosName, Me.GridColumn_CreateDate, Me.GridColumn_EmployeeName, Me.GridColumn_InventoryStatus, Me.GridColumn_RowHighLight, Me.GridColumn_CheckAllItem})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighLight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_InventoryList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_InventoryList.GridControl = Me.GridControl_InventoryList
            Me.GridView_InventoryList.Name = "GridView_InventoryList"
            Me.GridView_InventoryList.OptionsView.ColumnAutoWidth = False
            Me.GridView_InventoryList.OptionsView.ShowFooter = True
            Me.GridView_InventoryList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_InventoryCode
            '
            resources.ApplyResources(Me.GridColumn_InventoryCode, "GridColumn_InventoryCode")
            Me.GridColumn_InventoryCode.FieldName = "INVENTORY_CODE"
            Me.GridColumn_InventoryCode.Name = "GridColumn_InventoryCode"
            Me.GridColumn_InventoryCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_InventoryCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_PosName
            '
            resources.ApplyResources(Me.GridColumn_PosName, "GridColumn_PosName")
            Me.GridColumn_PosName.FieldName = "POS_NAME"
            Me.GridColumn_PosName.Name = "GridColumn_PosName"
            Me.GridColumn_PosName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_CreateDate
            '
            resources.ApplyResources(Me.GridColumn_CreateDate, "GridColumn_CreateDate")
            Me.GridColumn_CreateDate.FieldName = "CREATE_DATE"
            Me.GridColumn_CreateDate.Name = "GridColumn_CreateDate"
            Me.GridColumn_CreateDate.OptionsColumn.AllowFocus = False
            '
            'GridColumn_EmployeeName
            '
            resources.ApplyResources(Me.GridColumn_EmployeeName, "GridColumn_EmployeeName")
            Me.GridColumn_EmployeeName.FieldName = "CREATOR__STAFF_NAME"
            Me.GridColumn_EmployeeName.Name = "GridColumn_EmployeeName"
            Me.GridColumn_EmployeeName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_InventoryStatus
            '
            resources.ApplyResources(Me.GridColumn_InventoryStatus, "GridColumn_InventoryStatus")
            Me.GridColumn_InventoryStatus.ColumnEdit = Me.RepositoryItemLookUpEdit_InventoryStatus
            Me.GridColumn_InventoryStatus.FieldName = "INVENTORY_STATUS"
            Me.GridColumn_InventoryStatus.Name = "GridColumn_InventoryStatus"
            Me.GridColumn_InventoryStatus.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_InventoryStatus
            '
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_InventoryStatus, "RepositoryItemLookUpEdit_InventoryStatus")
            Me.RepositoryItemLookUpEdit_InventoryStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_InventoryStatus.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_InventoryStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_InventoryStatus.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_InventoryStatus.Name = "RepositoryItemLookUpEdit_InventoryStatus"
            Me.RepositoryItemLookUpEdit_InventoryStatus.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_RowHighLight
            '
            resources.ApplyResources(Me.GridColumn_RowHighLight, "GridColumn_RowHighLight")
            Me.GridColumn_RowHighLight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighLight.Name = "GridColumn_RowHighLight"
            Me.GridColumn_RowHighLight.OptionsColumn.AllowFocus = False
            '
            'GridColumn_CheckAllItem
            '
            resources.ApplyResources(Me.GridColumn_CheckAllItem, "GridColumn_CheckAllItem")
            Me.GridColumn_CheckAllItem.ColumnEdit = Me.RepositoryItemCheckEdit_CheckAllItem
            Me.GridColumn_CheckAllItem.FieldName = "CHECK_ALL_ITEM"
            Me.GridColumn_CheckAllItem.Name = "GridColumn_CheckAllItem"
            Me.GridColumn_CheckAllItem.OptionsColumn.AllowEdit = False
            Me.GridColumn_CheckAllItem.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemCheckEdit_CheckAllItem
            '
            resources.ApplyResources(Me.RepositoryItemCheckEdit_CheckAllItem, "RepositoryItemCheckEdit_CheckAllItem")
            Me.RepositoryItemCheckEdit_CheckAllItem.Name = "RepositoryItemCheckEdit_CheckAllItem"
            '
            'M_02_00201
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.GridControl_InventoryList)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_00201"
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
            CType(Me.CheckEdit_ShowFinish.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_InventoryList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_InventoryList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_InventoryStatus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_CheckAllItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents DateEdit_ToDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_FromDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents ToolStripButton_BeginCheck As System.Windows.Forms.ToolStripButton
        Friend WithEvents CheckEdit_ShowFinish As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents GridControl_InventoryList As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_InventoryList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_CreateDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_EmployeeName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_InventoryCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PosName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_InventoryStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_InventoryStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_RowHighLight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ToolStripButton_Review As System.Windows.Forms.ToolStripButton
        Friend WithEvents GridColumn_CheckAllItem As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_CheckAllItem As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

#End Region

    End Class

End Namespace
