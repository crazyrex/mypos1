Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00801
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
        Friend WithEvents ToolStripButton_Choose As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_View As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_01_00801))
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
            Me.ToolStripButton_Choose = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_CurrentPoint = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Import = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_SellDiscount = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_DownloadDataByRefresh = New DevExpress.XtraEditors.CheckEdit
            Me.LinkLabel_UnselectAll = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_SelectAll = New System.Windows.Forms.LinkLabel
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_Customer = New DevExpress.XtraGrid.GridControl
            Me.GridView_Customer = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_CustomerCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomerName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Address = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WorkPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Fax = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Linkman = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CellPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Email = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Title = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Department = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PostCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_HomePhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_City = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_State = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Country = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WebSite = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr6 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighLight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowSelected = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_RowSelected = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.GridColumn_ClientType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_ClientType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_CurrentPoint = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientLevel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_ClientLevel = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.OpenFileDialog_ImportFile = New System.Windows.Forms.OpenFileDialog
            Me.ToolStripButton_ClientSMS = New System.Windows.Forms.ToolStripButton
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.CheckEdit_DownloadDataByRefresh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_RowSelected, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_ClientType, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_ClientLevel, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Choose, Me.ToolStripButton_Create, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_CurrentPoint, Me.ToolStripButton_Refresh, Me.ToolStripButton_View, Me.ToolStripButton_Import, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_SellDiscount, Me.ToolStripButton_ClientSMS, Me.ToolStripButton_Close})
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
            CTag1.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
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
            'ToolStripButton_Choose
            '
            Me.ToolStripButton_Choose.Name = "ToolStripButton_Choose"
            resources.ApplyResources(Me.ToolStripButton_Choose, "ToolStripButton_Choose")
            '
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            resources.ApplyResources(Me.ToolStripButton_Create, "ToolStripButton_Create")
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            resources.ApplyResources(Me.ToolStripButton_Revise, "ToolStripButton_Revise")
            '
            'ToolStripButton_Delete
            '
            Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
            resources.ApplyResources(Me.ToolStripButton_Delete, "ToolStripButton_Delete")
            '
            'ToolStripButton_CurrentPoint
            '
            Me.ToolStripButton_CurrentPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_CurrentPoint.Name = "ToolStripButton_CurrentPoint"
            resources.ApplyResources(Me.ToolStripButton_CurrentPoint, "ToolStripButton_CurrentPoint")
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            '
            'ToolStripButton_View
            '
            Me.ToolStripButton_View.Name = "ToolStripButton_View"
            resources.ApplyResources(Me.ToolStripButton_View, "ToolStripButton_View")
            '
            'ToolStripButton_Import
            '
            Me.ToolStripButton_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_Import, "ToolStripButton_Import")
            Me.ToolStripButton_Import.Name = "ToolStripButton_Import"
            '
            'ToolStripButton_ExportExcel
            '
            Me.ToolStripButton_ExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_ExportExcel, "ToolStripButton_ExportExcel")
            Me.ToolStripButton_ExportExcel.Name = "ToolStripButton_ExportExcel"
            '
            'ToolStripButton_SellDiscount
            '
            resources.ApplyResources(Me.ToolStripButton_SellDiscount, "ToolStripButton_SellDiscount")
            Me.ToolStripButton_SellDiscount.Name = "ToolStripButton_SellDiscount"
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
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_DownloadDataByRefresh)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_UnselectAll)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_SelectAll)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
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
            'CheckEdit_DownloadDataByRefresh
            '
            resources.ApplyResources(Me.CheckEdit_DownloadDataByRefresh, "CheckEdit_DownloadDataByRefresh")
            Me.CheckEdit_DownloadDataByRefresh.Name = "CheckEdit_DownloadDataByRefresh"
            Me.CheckEdit_DownloadDataByRefresh.Properties.Caption = resources.GetString("CheckEdit_DownloadDataByRefresh.Properties.Caption")
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
            CTag2.ParentControl = Me.CheckEdit_DownloadDataByRefresh
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_DownloadDataByRefresh.Tag = CTag2
            '
            'LinkLabel_UnselectAll
            '
            resources.ApplyResources(Me.LinkLabel_UnselectAll, "LinkLabel_UnselectAll")
            Me.LinkLabel_UnselectAll.Name = "LinkLabel_UnselectAll"
            Me.LinkLabel_UnselectAll.TabStop = True
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
            CTag3.ParentControl = Me.LinkLabel_UnselectAll
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_UnselectAll.Tag = CTag3
            '
            'LinkLabel_SelectAll
            '
            resources.ApplyResources(Me.LinkLabel_SelectAll, "LinkLabel_SelectAll")
            Me.LinkLabel_SelectAll.Name = "LinkLabel_SelectAll"
            Me.LinkLabel_SelectAll.TabStop = True
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
            CTag4.ParentControl = Me.LinkLabel_SelectAll
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_SelectAll.Tag = CTag4
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.Name = "TextEdit_Search"
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
            CTag5.ParentControl = Me.TextEdit_Search
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag5
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
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
            CTag6.ParentControl = Me.Label1
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag6
            '
            'GridControl_Customer
            '
            resources.ApplyResources(Me.GridControl_Customer, "GridControl_Customer")
            Me.GridControl_Customer.EmbeddedNavigator.Name = ""
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
            CTag8.ParentControl = Me.GridControl_Customer.EmbeddedNavigator
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Customer.EmbeddedNavigator.Tag = CTag8
            Me.GridControl_Customer.MainView = Me.GridView_Customer
            Me.GridControl_Customer.Name = "GridControl_Customer"
            Me.GridControl_Customer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_RowSelected, Me.RepositoryItemLookUpEdit_ClientType, Me.RepositoryItemLookUpEdit_ClientLevel})
            Me.GridControl_Customer.TabStop = False
            Me.GridControl_Customer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Customer})
            '
            'GridView_Customer
            '
            Me.GridView_Customer.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_CustomerCode, Me.GridColumn_CustomerName, Me.GridColumn_Address, Me.GridColumn_WorkPhone, Me.GridColumn_Fax, Me.GridColumn_Linkman, Me.GridColumn_CellPhone, Me.GridColumn_Email, Me.GridColumn_Title, Me.GridColumn_Department, Me.GridColumn_PostCode, Me.GridColumn_Remarks, Me.GridColumn_HomePhone, Me.GridColumn_City, Me.GridColumn_State, Me.GridColumn_Country, Me.GridColumn_WebSite, Me.GridColumn_ClientAttr1, Me.GridColumn_ClientAttr2, Me.GridColumn_ClientAttr3, Me.GridColumn_ClientAttr4, Me.GridColumn_ClientAttr5, Me.GridColumn_ClientAttr6, Me.GridColumn_RowHighLight, Me.GridColumn_RowSelected, Me.GridColumn_ClientType, Me.GridColumn_CurrentPoint, Me.GridColumn_ClientLevel})
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighLight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_Customer.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_Customer.GridControl = Me.GridControl_Customer
            Me.GridView_Customer.Name = "GridView_Customer"
            Me.GridView_Customer.OptionsView.ColumnAutoWidth = False
            Me.GridView_Customer.OptionsView.ShowFooter = True
            Me.GridView_Customer.OptionsView.ShowGroupPanel = False
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
            'GridColumn_Address
            '
            resources.ApplyResources(Me.GridColumn_Address, "GridColumn_Address")
            Me.GridColumn_Address.FieldName = "ADDRESS"
            Me.GridColumn_Address.Name = "GridColumn_Address"
            Me.GridColumn_Address.OptionsColumn.AllowFocus = False
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
            'GridColumn_Title
            '
            resources.ApplyResources(Me.GridColumn_Title, "GridColumn_Title")
            Me.GridColumn_Title.FieldName = "TITLE"
            Me.GridColumn_Title.Name = "GridColumn_Title"
            Me.GridColumn_Title.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Department
            '
            resources.ApplyResources(Me.GridColumn_Department, "GridColumn_Department")
            Me.GridColumn_Department.FieldName = "DEPARTMENT"
            Me.GridColumn_Department.Name = "GridColumn_Department"
            Me.GridColumn_Department.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PostCode
            '
            resources.ApplyResources(Me.GridColumn_PostCode, "GridColumn_PostCode")
            Me.GridColumn_PostCode.FieldName = "POST_CODE"
            Me.GridColumn_PostCode.Name = "GridColumn_PostCode"
            Me.GridColumn_PostCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Remarks
            '
            resources.ApplyResources(Me.GridColumn_Remarks, "GridColumn_Remarks")
            Me.GridColumn_Remarks.FieldName = "REMARKS"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            '
            'GridColumn_HomePhone
            '
            resources.ApplyResources(Me.GridColumn_HomePhone, "GridColumn_HomePhone")
            Me.GridColumn_HomePhone.FieldName = "HOME_PHONE"
            Me.GridColumn_HomePhone.Name = "GridColumn_HomePhone"
            Me.GridColumn_HomePhone.OptionsColumn.AllowFocus = False
            '
            'GridColumn_City
            '
            resources.ApplyResources(Me.GridColumn_City, "GridColumn_City")
            Me.GridColumn_City.FieldName = "CITY"
            Me.GridColumn_City.Name = "GridColumn_City"
            Me.GridColumn_City.OptionsColumn.AllowFocus = False
            '
            'GridColumn_State
            '
            resources.ApplyResources(Me.GridColumn_State, "GridColumn_State")
            Me.GridColumn_State.FieldName = "STATE"
            Me.GridColumn_State.Name = "GridColumn_State"
            Me.GridColumn_State.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Country
            '
            resources.ApplyResources(Me.GridColumn_Country, "GridColumn_Country")
            Me.GridColumn_Country.FieldName = "COUNTRY"
            Me.GridColumn_Country.Name = "GridColumn_Country"
            Me.GridColumn_Country.OptionsColumn.AllowFocus = False
            '
            'GridColumn_WebSite
            '
            resources.ApplyResources(Me.GridColumn_WebSite, "GridColumn_WebSite")
            Me.GridColumn_WebSite.FieldName = "WEB_SITE"
            Me.GridColumn_WebSite.Name = "GridColumn_WebSite"
            Me.GridColumn_WebSite.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr1
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr1, "GridColumn_ClientAttr1")
            Me.GridColumn_ClientAttr1.FieldName = "CLIENT_ATTR1"
            Me.GridColumn_ClientAttr1.Name = "GridColumn_ClientAttr1"
            Me.GridColumn_ClientAttr1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr2
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr2, "GridColumn_ClientAttr2")
            Me.GridColumn_ClientAttr2.FieldName = "CLIENT_ATTR2"
            Me.GridColumn_ClientAttr2.Name = "GridColumn_ClientAttr2"
            Me.GridColumn_ClientAttr2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr3
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr3, "GridColumn_ClientAttr3")
            Me.GridColumn_ClientAttr3.FieldName = "CLIENT_ATTR3"
            Me.GridColumn_ClientAttr3.Name = "GridColumn_ClientAttr3"
            Me.GridColumn_ClientAttr3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr4
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr4, "GridColumn_ClientAttr4")
            Me.GridColumn_ClientAttr4.FieldName = "CLIENT_ATTR4"
            Me.GridColumn_ClientAttr4.Name = "GridColumn_ClientAttr4"
            Me.GridColumn_ClientAttr4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr5
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr5, "GridColumn_ClientAttr5")
            Me.GridColumn_ClientAttr5.FieldName = "CLIENT_ATTR5"
            Me.GridColumn_ClientAttr5.Name = "GridColumn_ClientAttr5"
            Me.GridColumn_ClientAttr5.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr6
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr6, "GridColumn_ClientAttr6")
            Me.GridColumn_ClientAttr6.FieldName = "CLIENT_ATTR6"
            Me.GridColumn_ClientAttr6.Name = "GridColumn_ClientAttr6"
            Me.GridColumn_ClientAttr6.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowHighLight
            '
            resources.ApplyResources(Me.GridColumn_RowHighLight, "GridColumn_RowHighLight")
            Me.GridColumn_RowHighLight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighLight.Name = "GridColumn_RowHighLight"
            Me.GridColumn_RowHighLight.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowSelected
            '
            resources.ApplyResources(Me.GridColumn_RowSelected, "GridColumn_RowSelected")
            Me.GridColumn_RowSelected.ColumnEdit = Me.RepositoryItemCheckEdit_RowSelected
            Me.GridColumn_RowSelected.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_RowSelected.Name = "GridColumn_RowSelected"
            '
            'RepositoryItemCheckEdit_RowSelected
            '
            resources.ApplyResources(Me.RepositoryItemCheckEdit_RowSelected, "RepositoryItemCheckEdit_RowSelected")
            Me.RepositoryItemCheckEdit_RowSelected.Name = "RepositoryItemCheckEdit_RowSelected"
            '
            'GridColumn_ClientType
            '
            Me.GridColumn_ClientType.ColumnEdit = Me.RepositoryItemLookUpEdit_ClientType
            Me.GridColumn_ClientType.FieldName = "CLIENT_TYPE"
            Me.GridColumn_ClientType.Name = "GridColumn_ClientType"
            Me.GridColumn_ClientType.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_ClientType
            '
            Me.RepositoryItemLookUpEdit_ClientType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_ClientType.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_ClientType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", "Name3", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_ClientType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_ClientType.Name = "RepositoryItemLookUpEdit_ClientType"
            Me.RepositoryItemLookUpEdit_ClientType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_CurrentPoint
            '
            resources.ApplyResources(Me.GridColumn_CurrentPoint, "GridColumn_CurrentPoint")
            Me.GridColumn_CurrentPoint.FieldName = "CURRENT_POINT"
            Me.GridColumn_CurrentPoint.Name = "GridColumn_CurrentPoint"
            Me.GridColumn_CurrentPoint.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientLevel
            '
            Me.GridColumn_ClientLevel.ColumnEdit = Me.RepositoryItemLookUpEdit_ClientLevel
            Me.GridColumn_ClientLevel.FieldName = "CLIENT_LEVEL"
            Me.GridColumn_ClientLevel.Name = "GridColumn_ClientLevel"
            Me.GridColumn_ClientLevel.OptionsColumn.AllowEdit = False
            Me.GridColumn_ClientLevel.OptionsColumn.AllowFocus = False
            resources.ApplyResources(Me.GridColumn_ClientLevel, "GridColumn_ClientLevel")
            '
            'RepositoryItemLookUpEdit_ClientLevel
            '
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_ClientLevel, "RepositoryItemLookUpEdit_ClientLevel")
            Me.RepositoryItemLookUpEdit_ClientLevel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_ClientLevel.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_ClientLevel.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_ClientLevel.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_ClientLevel.Name = "RepositoryItemLookUpEdit_ClientLevel"
            Me.RepositoryItemLookUpEdit_ClientLevel.ValueMember = "ITEM_VALUE"
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'OpenFileDialog_ImportFile
            '
            resources.ApplyResources(Me.OpenFileDialog_ImportFile, "OpenFileDialog_ImportFile")
            '
            'ToolStripButton_ClientSMS
            '
            Me.ToolStripButton_ClientSMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_ClientSMS, "ToolStripButton_ClientSMS")
            Me.ToolStripButton_ClientSMS.Name = "ToolStripButton_ClientSMS"
            '
            'M_01_00801
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.GridControl_Customer)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_01_00801"
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
            CType(Me.CheckEdit_DownloadDataByRefresh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_Customer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Customer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_RowSelected, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_ClientType, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_ClientLevel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GridControl_Customer As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Customer As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_CustomerCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomerName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WorkPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Fax As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Linkman As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CellPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Email As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Title As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Department As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PostCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_HomePhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_City As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_State As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Country As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WebSite As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighLight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr5 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr6 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents OpenFileDialog_ImportFile As System.Windows.Forms.OpenFileDialog
        Friend WithEvents ToolStripButton_Import As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_SellDiscount As System.Windows.Forms.ToolStripButton
        Friend WithEvents GridColumn_RowSelected As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_RowSelected As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents GridColumn_ClientType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_ClientType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents ToolStripButton_CurrentPoint As System.Windows.Forms.ToolStripButton
        Friend WithEvents GridColumn_CurrentPoint As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents LinkLabel_SelectAll As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel_UnselectAll As System.Windows.Forms.LinkLabel
        Friend WithEvents CheckEdit_DownloadDataByRefresh As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents GridColumn_ClientLevel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_ClientLevel As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents ToolStripButton_ClientSMS As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace
