Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_00401
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
        Friend WithEvents ToolStripButton_View As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_00401))
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_ExportPictureToExcel = New DevExpress.XtraEditors.CheckEdit
            Me.LinkLabel_CancelAll = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_SelectAll = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_DeleteImage = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_SetImage = New System.Windows.Forms.LinkLabel
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_TotalList = New DevExpress.XtraGrid.GridControl
            Me.GridView_TotalList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_Select = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.GridColumn_WareClassifyName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CurrentAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CurrentCost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CurrentOrigionSumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareImage = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemPictureEdit_Image = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.OpenFileDialog_WareImage = New System.Windows.Forms.OpenFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.CheckEdit_ExportPictureToExcel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_TotalList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_TotalList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemPictureEdit_Image, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DefaultLookAndFeel_Form
            '
            Me.DefaultLookAndFeel_Form.LookAndFeel.SkinName = "The Asphalt World"
            '
            'Timer_Surveillant
            '
            '
            'ToolStrip_Form
            '
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Refresh, Me.ToolStripButton_View, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_Close})
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
            'ToolStripButton_View
            '
            resources.ApplyResources(Me.ToolStripButton_View, "ToolStripButton_View")
            Me.ToolStripButton_View.Name = "ToolStripButton_View"
            '
            'ToolStripButton_ExportExcel
            '
            Me.ToolStripButton_ExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_ExportExcel, "ToolStripButton_ExportExcel")
            Me.ToolStripButton_ExportExcel.Name = "ToolStripButton_ExportExcel"
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
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_ExportPictureToExcel)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_CancelAll)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_SelectAll)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_DeleteImage)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_SetImage)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            CTag9.ParentControl = Me.PanelControl_Filter
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag9
            '
            'CheckEdit_ExportPictureToExcel
            '
            resources.ApplyResources(Me.CheckEdit_ExportPictureToExcel, "CheckEdit_ExportPictureToExcel")
            Me.CheckEdit_ExportPictureToExcel.Name = "CheckEdit_ExportPictureToExcel"
            Me.CheckEdit_ExportPictureToExcel.Properties.Caption = resources.GetString("CheckEdit_ExportPictureToExcel.Properties.Caption")
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
            CTag2.ParentControl = Me.CheckEdit_ExportPictureToExcel
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_ExportPictureToExcel.Tag = CTag2
            '
            'LinkLabel_CancelAll
            '
            resources.ApplyResources(Me.LinkLabel_CancelAll, "LinkLabel_CancelAll")
            Me.LinkLabel_CancelAll.Name = "LinkLabel_CancelAll"
            Me.LinkLabel_CancelAll.TabStop = True
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
            CTag3.ParentControl = Me.LinkLabel_CancelAll
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_CancelAll.Tag = CTag3
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
            'LinkLabel_DeleteImage
            '
            resources.ApplyResources(Me.LinkLabel_DeleteImage, "LinkLabel_DeleteImage")
            Me.LinkLabel_DeleteImage.Name = "LinkLabel_DeleteImage"
            Me.LinkLabel_DeleteImage.TabStop = True
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
            CTag5.ParentControl = Me.LinkLabel_DeleteImage
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_DeleteImage.Tag = CTag5
            '
            'LinkLabel_SetImage
            '
            resources.ApplyResources(Me.LinkLabel_SetImage, "LinkLabel_SetImage")
            Me.LinkLabel_SetImage.Name = "LinkLabel_SetImage"
            Me.LinkLabel_SetImage.TabStop = True
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
            CTag6.ParentControl = Me.LinkLabel_SetImage
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_SetImage.Tag = CTag6
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.Name = "TextEdit_Search"
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
            CTag7.ParentControl = Me.TextEdit_Search
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag7
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
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
            '
            'GridControl_TotalList
            '
            resources.ApplyResources(Me.GridControl_TotalList, "GridControl_TotalList")
            Me.GridControl_TotalList.EmbeddedNavigator.Name = ""
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
            CTag10.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag10.IsButtonCustomed = False
            CTag10.IsTextValid = True
            CTag10.KeyValueAbsentable = False
            CTag10.LeagleText = ""
            CTag10.NumericButtonTextBox = Nothing
            CTag10.ParentControl = Me.GridControl_TotalList.EmbeddedNavigator
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_TotalList.EmbeddedNavigator.Tag = CTag10
            Me.GridControl_TotalList.MainView = Me.GridView_TotalList
            Me.GridControl_TotalList.Name = "GridControl_TotalList"
            Me.GridControl_TotalList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit_Image, Me.RepositoryItemCheckEdit_Select})
            Me.GridControl_TotalList.TabStop = False
            Me.GridControl_TotalList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_TotalList})
            '
            'GridView_TotalList
            '
            Me.GridView_TotalList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_Select, Me.GridColumn_WareClassifyName, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_CurrentAmount, Me.GridColumn_CurrentCost, Me.GridColumn_CurrentOrigionSumPrice, Me.GridColumn_UnitName, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight, Me.GridColumn_WareImage})
            Me.GridView_TotalList.DetailHeight = 420
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "CURRENT_AMOUNT"
            Me.GridView_TotalList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.GridView_TotalList.GridControl = Me.GridControl_TotalList
            Me.GridView_TotalList.Name = "GridView_TotalList"
            Me.GridView_TotalList.OptionsView.ColumnAutoWidth = False
            Me.GridView_TotalList.OptionsView.ShowFooter = True
            Me.GridView_TotalList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_Select
            '
            resources.ApplyResources(Me.GridColumn_Select, "GridColumn_Select")
            Me.GridColumn_Select.ColumnEdit = Me.RepositoryItemCheckEdit_Select
            Me.GridColumn_Select.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_Select.Name = "GridColumn_Select"
            '
            'RepositoryItemCheckEdit_Select
            '
            resources.ApplyResources(Me.RepositoryItemCheckEdit_Select, "RepositoryItemCheckEdit_Select")
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'GridColumn_WareClassifyName
            '
            resources.ApplyResources(Me.GridColumn_WareClassifyName, "GridColumn_WareClassifyName")
            Me.GridColumn_WareClassifyName.FieldName = "WARE_CLASSIFY_NAME"
            Me.GridColumn_WareClassifyName.Name = "GridColumn_WareClassifyName"
            Me.GridColumn_WareClassifyName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_WareCode
            '
            resources.ApplyResources(Me.GridColumn_WareCode, "GridColumn_WareCode")
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
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
            'GridColumn_CurrentAmount
            '
            resources.ApplyResources(Me.GridColumn_CurrentAmount, "GridColumn_CurrentAmount")
            Me.GridColumn_CurrentAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_CurrentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_CurrentAmount.FieldName = "CURRENT_AMOUNT"
            Me.GridColumn_CurrentAmount.Name = "GridColumn_CurrentAmount"
            Me.GridColumn_CurrentAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_CurrentAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_CurrentCost
            '
            resources.ApplyResources(Me.GridColumn_CurrentCost, "GridColumn_CurrentCost")
            Me.GridColumn_CurrentCost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_CurrentCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_CurrentCost.FieldName = "CURRENT_COST"
            Me.GridColumn_CurrentCost.Name = "GridColumn_CurrentCost"
            Me.GridColumn_CurrentCost.OptionsColumn.AllowFocus = False
            Me.GridColumn_CurrentCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_CurrentOrigionSumPrice
            '
            resources.ApplyResources(Me.GridColumn_CurrentOrigionSumPrice, "GridColumn_CurrentOrigionSumPrice")
            Me.GridColumn_CurrentOrigionSumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_CurrentOrigionSumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_CurrentOrigionSumPrice.FieldName = "CURRENT_ORIGION_SUM_PRICE"
            Me.GridColumn_CurrentOrigionSumPrice.Name = "GridColumn_CurrentOrigionSumPrice"
            Me.GridColumn_CurrentOrigionSumPrice.OptionsColumn.AllowFocus = False
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
            'GridColumn_WareImage
            '
            resources.ApplyResources(Me.GridColumn_WareImage, "GridColumn_WareImage")
            Me.GridColumn_WareImage.ColumnEdit = Me.RepositoryItemPictureEdit_Image
            Me.GridColumn_WareImage.FieldName = "WARE_IMAGE"
            Me.GridColumn_WareImage.Name = "GridColumn_WareImage"
            Me.GridColumn_WareImage.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareImage.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
            '
            'RepositoryItemPictureEdit_Image
            '
            Me.RepositoryItemPictureEdit_Image.Name = "RepositoryItemPictureEdit_Image"
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'OpenFileDialog_WareImage
            '
            resources.ApplyResources(Me.OpenFileDialog_WareImage, "OpenFileDialog_WareImage")
            '
            'M_03_00401
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.GridControl_TotalList)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_00401"
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
            CTag11.ParentControl = Me
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag11
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.CheckEdit_ExportPictureToExcel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_TotalList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_TotalList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemPictureEdit_Image, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GridControl_TotalList As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_TotalList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CurrentAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CurrentCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareClassifyName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents OpenFileDialog_WareImage As System.Windows.Forms.OpenFileDialog
        Friend WithEvents GridColumn_WareImage As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemPictureEdit_Image As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Friend WithEvents LinkLabel_DeleteImage As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel_SetImage As System.Windows.Forms.LinkLabel
        Friend WithEvents GridColumn_Select As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents LinkLabel_CancelAll As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel_SelectAll As System.Windows.Forms.LinkLabel
        Friend WithEvents CheckEdit_ExportPictureToExcel As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents GridColumn_CurrentOrigionSumPrice As DevExpress.XtraGrid.Columns.GridColumn

#End Region

    End Class

End Namespace
