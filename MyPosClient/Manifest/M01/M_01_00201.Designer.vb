Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00201
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
        Friend WithEvents ToolStripButton_CreateWareClassify As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Choose As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_PrintLabel As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_View As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_01_00201))
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag18 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
            Me.SplitContainerControl_Left = New DevExpress.XtraEditors.SplitContainerControl
            Me.TreeList_WareClassify = New DevExpress.XtraTreeList.TreeList
            Me.TreeListColumn_WareClassifyCode = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.TreeListColumn_WareClassifyName = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.TreeListColumn_Remark = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.TreeListColumn_WareClassifyID = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.LinkLabel_DeleteImage = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_SetImage = New System.Windows.Forms.LinkLabel
            Me.PictureBox_Item = New System.Windows.Forms.PictureBox
            Me.GridControl_Ware = New DevExpress.XtraGrid.GridControl
            Me.GridView_Ware = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_RowSelect = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_UnitPrice = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_Unitcost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_UnitCost = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_SupplierID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_SupplierID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Choose = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_CreateWareClassify = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_CreateWare = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_PrintLabel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_SetWareBOM = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ImportFromExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Report = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.ComboBoxEdit_DownloadImageMode = New DevExpress.XtraEditors.ComboBoxEdit
            Me.CheckEdit_ShowRetired = New DevExpress.XtraEditors.CheckEdit
            Me.CheckEdit_PriceCostModifiable = New DevExpress.XtraEditors.CheckEdit
            Me.CheckEdit_RemotingMode = New DevExpress.XtraEditors.CheckEdit
            Me.CheckEdit_ExportPictureToExcel = New DevExpress.XtraEditors.CheckEdit
            Me.LinkLabel_DownloadImages = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_SaveCostPriceModify = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_CancelAll = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_SelectAll = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_AllWareList = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_AllWareExportExcel = New System.Windows.Forms.LinkLabel
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.OpenFileDialog_ImportFile = New System.Windows.Forms.OpenFileDialog
            Me.OpenFileDialog_SetImage = New System.Windows.Forms.OpenFileDialog
            CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainerControl1.SuspendLayout()
            CType(Me.SplitContainerControl_Left, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainerControl_Left.SuspendLayout()
            CType(Me.TreeList_WareClassify, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox_Item, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_Ware, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Ware, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_UnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_UnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_SupplierID, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.ComboBoxEdit_DownloadImageMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_ShowRetired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_PriceCostModifiable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_RemotingMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_ExportPictureToExcel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DefaultLookAndFeel_Form
            '
            Me.DefaultLookAndFeel_Form.LookAndFeel.SkinName = ""
            '
            'Timer_Surveillant
            '
            '
            'SplitContainerControl1
            '
            Me.SplitContainerControl1.AccessibleDescription = Nothing
            Me.SplitContainerControl1.AccessibleName = Nothing
            resources.ApplyResources(Me.SplitContainerControl1, "SplitContainerControl1")
            Me.SplitContainerControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.SplitContainerControl1.Appearance.Options.UseBackColor = True
            Me.SplitContainerControl1.Name = "SplitContainerControl1"
            Me.SplitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.White
            Me.SplitContainerControl1.Panel1.Appearance.Options.UseBackColor = True
            Me.SplitContainerControl1.Panel1.Controls.Add(Me.SplitContainerControl_Left)
            resources.ApplyResources(Me.SplitContainerControl1.Panel1, "SplitContainerControl1.Panel1")
            Me.SplitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.Color.White
            Me.SplitContainerControl1.Panel2.Appearance.Options.UseBackColor = True
            Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl_Ware)
            resources.ApplyResources(Me.SplitContainerControl1.Panel2, "SplitContainerControl1.Panel2")
            Me.SplitContainerControl1.SplitterPosition = 263
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
            CTag2.ParentControl = Me.SplitContainerControl1
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.SplitContainerControl1.Tag = CTag2
            '
            'SplitContainerControl_Left
            '
            Me.SplitContainerControl_Left.AccessibleDescription = Nothing
            Me.SplitContainerControl_Left.AccessibleName = Nothing
            resources.ApplyResources(Me.SplitContainerControl_Left, "SplitContainerControl_Left")
            Me.SplitContainerControl_Left.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.SplitContainerControl_Left.Horizontal = False
            Me.SplitContainerControl_Left.Name = "SplitContainerControl_Left"
            Me.SplitContainerControl_Left.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.SplitContainerControl_Left.Panel1.Controls.Add(Me.TreeList_WareClassify)
            resources.ApplyResources(Me.SplitContainerControl_Left.Panel1, "SplitContainerControl_Left.Panel1")
            Me.SplitContainerControl_Left.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.SplitContainerControl_Left.Panel2.Controls.Add(Me.LinkLabel_DeleteImage)
            Me.SplitContainerControl_Left.Panel2.Controls.Add(Me.LinkLabel_SetImage)
            Me.SplitContainerControl_Left.Panel2.Controls.Add(Me.PictureBox_Item)
            resources.ApplyResources(Me.SplitContainerControl_Left.Panel2, "SplitContainerControl_Left.Panel2")
            Me.SplitContainerControl_Left.SplitterPosition = 159
            '
            'TreeList_WareClassify
            '
            Me.TreeList_WareClassify.AccessibleDescription = Nothing
            Me.TreeList_WareClassify.AccessibleName = Nothing
            resources.ApplyResources(Me.TreeList_WareClassify, "TreeList_WareClassify")
            Me.TreeList_WareClassify.BackgroundImage = Nothing
            Me.TreeList_WareClassify.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn_WareClassifyCode, Me.TreeListColumn_WareClassifyName, Me.TreeListColumn_Remark, Me.TreeListColumn_WareClassifyID})
            Me.TreeList_WareClassify.Font = Nothing
            Me.TreeList_WareClassify.KeyFieldName = "WARE_CLASSIFY_ID"
            Me.TreeList_WareClassify.Name = "TreeList_WareClassify"
            Me.TreeList_WareClassify.OptionsView.AutoWidth = False
            Me.TreeList_WareClassify.ParentFieldName = "PARENT_ID"
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
            CTag1.ParentControl = Me.TreeList_WareClassify
            CTag1.SkipValidate = False
            CTag1.TimeButtonTextBox = Nothing
            CTag1.ToolTip = ""
            CTag1.ValueType = XL.Common.ControlValueType.Character
            Me.TreeList_WareClassify.Tag = CTag1
            '
            'TreeListColumn_WareClassifyCode
            '
            resources.ApplyResources(Me.TreeListColumn_WareClassifyCode, "TreeListColumn_WareClassifyCode")
            Me.TreeListColumn_WareClassifyCode.FieldName = "WARE_CLASSIFY_CODE"
            Me.TreeListColumn_WareClassifyCode.Name = "TreeListColumn_WareClassifyCode"
            '
            'TreeListColumn_WareClassifyName
            '
            resources.ApplyResources(Me.TreeListColumn_WareClassifyName, "TreeListColumn_WareClassifyName")
            Me.TreeListColumn_WareClassifyName.FieldName = "WARE_CLASSIFY_NAME"
            Me.TreeListColumn_WareClassifyName.Name = "TreeListColumn_WareClassifyName"
            '
            'TreeListColumn_Remark
            '
            resources.ApplyResources(Me.TreeListColumn_Remark, "TreeListColumn_Remark")
            Me.TreeListColumn_Remark.FieldName = "REMARK"
            Me.TreeListColumn_Remark.Name = "TreeListColumn_Remark"
            '
            'TreeListColumn_WareClassifyID
            '
            resources.ApplyResources(Me.TreeListColumn_WareClassifyID, "TreeListColumn_WareClassifyID")
            Me.TreeListColumn_WareClassifyID.FieldName = "WARE_CLASSIFY_ID"
            Me.TreeListColumn_WareClassifyID.Name = "TreeListColumn_WareClassifyID"
            '
            'LinkLabel_DeleteImage
            '
            Me.LinkLabel_DeleteImage.AccessibleDescription = Nothing
            Me.LinkLabel_DeleteImage.AccessibleName = Nothing
            resources.ApplyResources(Me.LinkLabel_DeleteImage, "LinkLabel_DeleteImage")
            Me.LinkLabel_DeleteImage.Font = Nothing
            Me.LinkLabel_DeleteImage.Name = "LinkLabel_DeleteImage"
            Me.LinkLabel_DeleteImage.TabStop = True
            '
            'LinkLabel_SetImage
            '
            Me.LinkLabel_SetImage.AccessibleDescription = Nothing
            Me.LinkLabel_SetImage.AccessibleName = Nothing
            resources.ApplyResources(Me.LinkLabel_SetImage, "LinkLabel_SetImage")
            Me.LinkLabel_SetImage.Font = Nothing
            Me.LinkLabel_SetImage.Name = "LinkLabel_SetImage"
            Me.LinkLabel_SetImage.TabStop = True
            '
            'PictureBox_Item
            '
            Me.PictureBox_Item.AccessibleDescription = Nothing
            Me.PictureBox_Item.AccessibleName = Nothing
            resources.ApplyResources(Me.PictureBox_Item, "PictureBox_Item")
            Me.PictureBox_Item.BackgroundImage = Nothing
            Me.PictureBox_Item.Font = Nothing
            Me.PictureBox_Item.ImageLocation = Nothing
            Me.PictureBox_Item.Name = "PictureBox_Item"
            Me.PictureBox_Item.TabStop = False
            '
            'GridControl_Ware
            '
            Me.GridControl_Ware.AccessibleDescription = Nothing
            Me.GridControl_Ware.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_Ware, "GridControl_Ware")
            Me.GridControl_Ware.BackgroundImage = Nothing
            Me.GridControl_Ware.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_Ware.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_Ware.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_Ware.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_Ware.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_Ware.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_Ware.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_Ware.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_Ware.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_Ware.EmbeddedNavigator.Name = ""
            Me.GridControl_Ware.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_Ware.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_Ware.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_Ware.EmbeddedNavigator.ToolTip")
            Me.GridControl_Ware.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_Ware.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_Ware.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_Ware.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_Ware.Font = Nothing
            Me.GridControl_Ware.MainView = Me.GridView_Ware
            Me.GridControl_Ware.Name = "GridControl_Ware"
            Me.GridControl_Ware.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select, Me.RepositoryItemLookUpEdit_SupplierID, Me.RepositoryItemCalcEdit_UnitPrice, Me.RepositoryItemCalcEdit_UnitCost})
            Me.GridControl_Ware.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Ware})
            '
            'GridView_Ware
            '
            resources.ApplyResources(Me.GridView_Ware, "GridView_Ware")
            Me.GridView_Ware.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_RowSelect, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_UnitName, Me.GridColumn_UnitPrice, Me.GridColumn_Unitcost, Me.GridColumn_SupplierID, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_Ware.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_Ware.GridControl = Me.GridControl_Ware
            Me.GridView_Ware.Name = "GridView_Ware"
            Me.GridView_Ware.OptionsView.ColumnAutoWidth = False
            Me.GridView_Ware.OptionsView.ShowFooter = True
            Me.GridView_Ware.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_RowSelect
            '
            resources.ApplyResources(Me.GridColumn_RowSelect, "GridColumn_RowSelect")
            Me.GridColumn_RowSelect.ColumnEdit = Me.RepositoryItemCheckEdit_Select
            Me.GridColumn_RowSelect.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_RowSelect.Name = "GridColumn_RowSelect"
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AccessibleDescription = Nothing
            Me.RepositoryItemCheckEdit_Select.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCheckEdit_Select, "RepositoryItemCheckEdit_Select")
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'GridColumn_WareCode
            '
            resources.ApplyResources(Me.GridColumn_WareCode, "GridColumn_WareCode")
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.ReadOnly = True
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
            'GridColumn_UnitName
            '
            resources.ApplyResources(Me.GridColumn_UnitName, "GridColumn_UnitName")
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_UnitPrice
            '
            resources.ApplyResources(Me.GridColumn_UnitPrice, "GridColumn_UnitPrice")
            Me.GridColumn_UnitPrice.ColumnEdit = Me.RepositoryItemCalcEdit_UnitPrice
            Me.GridColumn_UnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitPrice.FieldName = "UNIT_PRICE"
            Me.GridColumn_UnitPrice.Name = "GridColumn_UnitPrice"
            Me.GridColumn_UnitPrice.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemCalcEdit_UnitPrice
            '
            Me.RepositoryItemCalcEdit_UnitPrice.AccessibleDescription = Nothing
            Me.RepositoryItemCalcEdit_UnitPrice.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCalcEdit_UnitPrice, "RepositoryItemCalcEdit_UnitPrice")
            Me.RepositoryItemCalcEdit_UnitPrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_UnitPrice.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_UnitPrice.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemCalcEdit_UnitPrice.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemCalcEdit_UnitPrice.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemCalcEdit_UnitPrice.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemCalcEdit_UnitPrice.Mask.EditMask = resources.GetString("RepositoryItemCalcEdit_UnitPrice.Mask.EditMask")
            Me.RepositoryItemCalcEdit_UnitPrice.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemCalcEdit_UnitPrice.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemCalcEdit_UnitPrice.Mask.MaskType = CType(resources.GetObject("RepositoryItemCalcEdit_UnitPrice.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemCalcEdit_UnitPrice.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemCalcEdit_UnitPrice.Mask.PlaceHolder"), Char)
            Me.RepositoryItemCalcEdit_UnitPrice.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemCalcEdit_UnitPrice.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemCalcEdit_UnitPrice.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemCalcEdit_UnitPrice.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemCalcEdit_UnitPrice.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemCalcEdit_UnitPrice.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemCalcEdit_UnitPrice.Name = "RepositoryItemCalcEdit_UnitPrice"
            '
            'GridColumn_Unitcost
            '
            resources.ApplyResources(Me.GridColumn_Unitcost, "GridColumn_Unitcost")
            Me.GridColumn_Unitcost.ColumnEdit = Me.RepositoryItemCalcEdit_UnitCost
            Me.GridColumn_Unitcost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Unitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Unitcost.FieldName = "UNIT_COST"
            Me.GridColumn_Unitcost.Name = "GridColumn_Unitcost"
            Me.GridColumn_Unitcost.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemCalcEdit_UnitCost
            '
            Me.RepositoryItemCalcEdit_UnitCost.AccessibleDescription = Nothing
            Me.RepositoryItemCalcEdit_UnitCost.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCalcEdit_UnitCost, "RepositoryItemCalcEdit_UnitCost")
            Me.RepositoryItemCalcEdit_UnitCost.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_UnitCost.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_UnitCost.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemCalcEdit_UnitCost.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemCalcEdit_UnitCost.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemCalcEdit_UnitCost.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemCalcEdit_UnitCost.Mask.EditMask = resources.GetString("RepositoryItemCalcEdit_UnitCost.Mask.EditMask")
            Me.RepositoryItemCalcEdit_UnitCost.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemCalcEdit_UnitCost.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemCalcEdit_UnitCost.Mask.MaskType = CType(resources.GetObject("RepositoryItemCalcEdit_UnitCost.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemCalcEdit_UnitCost.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemCalcEdit_UnitCost.Mask.PlaceHolder"), Char)
            Me.RepositoryItemCalcEdit_UnitCost.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemCalcEdit_UnitCost.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemCalcEdit_UnitCost.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemCalcEdit_UnitCost.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemCalcEdit_UnitCost.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemCalcEdit_UnitCost.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemCalcEdit_UnitCost.Name = "RepositoryItemCalcEdit_UnitCost"
            '
            'GridColumn_SupplierID
            '
            resources.ApplyResources(Me.GridColumn_SupplierID, "GridColumn_SupplierID")
            Me.GridColumn_SupplierID.ColumnEdit = Me.RepositoryItemLookUpEdit_SupplierID
            Me.GridColumn_SupplierID.FieldName = "SUPPLIER_ID"
            Me.GridColumn_SupplierID.Name = "GridColumn_SupplierID"
            Me.GridColumn_SupplierID.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_SupplierID
            '
            Me.RepositoryItemLookUpEdit_SupplierID.AccessibleDescription = Nothing
            Me.RepositoryItemLookUpEdit_SupplierID.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_SupplierID, "RepositoryItemLookUpEdit_SupplierID")
            Me.RepositoryItemLookUpEdit_SupplierID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_SupplierID.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_SupplierID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIER_NAME", "Name1", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_SupplierID.DisplayMember = "SUPPLIER_NAME"
            Me.RepositoryItemLookUpEdit_SupplierID.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemLookUpEdit_SupplierID.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemLookUpEdit_SupplierID.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemLookUpEdit_SupplierID.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemLookUpEdit_SupplierID.Mask.EditMask = resources.GetString("RepositoryItemLookUpEdit_SupplierID.Mask.EditMask")
            Me.RepositoryItemLookUpEdit_SupplierID.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemLookUpEdit_SupplierID.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemLookUpEdit_SupplierID.Mask.MaskType = CType(resources.GetObject("RepositoryItemLookUpEdit_SupplierID.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemLookUpEdit_SupplierID.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemLookUpEdit_SupplierID.Mask.PlaceHolder"), Char)
            Me.RepositoryItemLookUpEdit_SupplierID.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemLookUpEdit_SupplierID.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemLookUpEdit_SupplierID.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemLookUpEdit_SupplierID.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemLookUpEdit_SupplierID.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemLookUpEdit_SupplierID.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemLookUpEdit_SupplierID.Name = "RepositoryItemLookUpEdit_SupplierID"
            Me.RepositoryItemLookUpEdit_SupplierID.ValueMember = "SUPPLIER_ID"
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
            'ToolStrip_Form
            '
            Me.ToolStrip_Form.AccessibleDescription = Nothing
            Me.ToolStrip_Form.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStrip_Form, "ToolStrip_Form")
            Me.ToolStrip_Form.BackgroundImage = Nothing
            Me.ToolStrip_Form.Font = Nothing
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Choose, Me.ToolStripButton_CreateWareClassify, Me.ToolStripButton_CreateWare, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_Refresh, Me.ToolStripButton_PrintLabel, Me.ToolStripButton_SetWareBOM, Me.ToolStripButton_View, Me.ToolStripButton_ImportFromExcel, Me.ToolStripButton_Report, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
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
            CTag3.ParentControl = Me.ToolStrip_Form
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.ToolStrip_Form.Tag = CTag3
            '
            'ToolStripButton_Choose
            '
            Me.ToolStripButton_Choose.AccessibleDescription = Nothing
            Me.ToolStripButton_Choose.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Choose, "ToolStripButton_Choose")
            Me.ToolStripButton_Choose.BackgroundImage = Nothing
            Me.ToolStripButton_Choose.Name = "ToolStripButton_Choose"
            '
            'ToolStripButton_CreateWareClassify
            '
            Me.ToolStripButton_CreateWareClassify.AccessibleDescription = Nothing
            Me.ToolStripButton_CreateWareClassify.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_CreateWareClassify, "ToolStripButton_CreateWareClassify")
            Me.ToolStripButton_CreateWareClassify.BackgroundImage = Nothing
            Me.ToolStripButton_CreateWareClassify.Name = "ToolStripButton_CreateWareClassify"
            '
            'ToolStripButton_CreateWare
            '
            Me.ToolStripButton_CreateWare.AccessibleDescription = Nothing
            Me.ToolStripButton_CreateWare.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_CreateWare, "ToolStripButton_CreateWare")
            Me.ToolStripButton_CreateWare.BackgroundImage = Nothing
            Me.ToolStripButton_CreateWare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_CreateWare.Name = "ToolStripButton_CreateWare"
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
            'ToolStripButton_PrintLabel
            '
            Me.ToolStripButton_PrintLabel.AccessibleDescription = Nothing
            Me.ToolStripButton_PrintLabel.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_PrintLabel, "ToolStripButton_PrintLabel")
            Me.ToolStripButton_PrintLabel.BackgroundImage = Nothing
            Me.ToolStripButton_PrintLabel.Name = "ToolStripButton_PrintLabel"
            '
            'ToolStripButton_SetWareBOM
            '
            Me.ToolStripButton_SetWareBOM.AccessibleDescription = Nothing
            Me.ToolStripButton_SetWareBOM.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_SetWareBOM, "ToolStripButton_SetWareBOM")
            Me.ToolStripButton_SetWareBOM.BackgroundImage = Nothing
            Me.ToolStripButton_SetWareBOM.Name = "ToolStripButton_SetWareBOM"
            '
            'ToolStripButton_View
            '
            Me.ToolStripButton_View.AccessibleDescription = Nothing
            Me.ToolStripButton_View.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_View, "ToolStripButton_View")
            Me.ToolStripButton_View.BackgroundImage = Nothing
            Me.ToolStripButton_View.Name = "ToolStripButton_View"
            '
            'ToolStripButton_ImportFromExcel
            '
            Me.ToolStripButton_ImportFromExcel.AccessibleDescription = Nothing
            Me.ToolStripButton_ImportFromExcel.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_ImportFromExcel, "ToolStripButton_ImportFromExcel")
            Me.ToolStripButton_ImportFromExcel.BackgroundImage = Nothing
            Me.ToolStripButton_ImportFromExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_ImportFromExcel.Name = "ToolStripButton_ImportFromExcel"
            '
            'ToolStripButton_Report
            '
            Me.ToolStripButton_Report.AccessibleDescription = Nothing
            Me.ToolStripButton_Report.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Report, "ToolStripButton_Report")
            Me.ToolStripButton_Report.BackgroundImage = Nothing
            Me.ToolStripButton_Report.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Report.Name = "ToolStripButton_Report"
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
            Me.PanelControl_Filter.Controls.Add(Me.ComboBoxEdit_DownloadImageMode)
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_ShowRetired)
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_PriceCostModifiable)
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_RemotingMode)
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_ExportPictureToExcel)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_DownloadImages)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_SaveCostPriceModify)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_CancelAll)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_SelectAll)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_AllWareList)
            Me.PanelControl_Filter.Controls.Add(Me.LinkLabel_AllWareExportExcel)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
            CTag17.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag17.CalculatorRequired = True
            CTag17.ComboValueTextBox = Nothing
            CTag17.ControlRelatedCode = Nothing
            CTag17.DateButtonTextBox = Nothing
            CTag17.DateTimeButtonTextBox = Nothing
            CTag17.DisplayLinkControl = Nothing
            CTag17.DisplayLinkDisplayFieldName = Nothing
            CTag17.DisplayLinkKeyFieldName = Nothing
            CTag17.DisplayLinkTable = Nothing
            CTag17.FlexgridEditItem = ""
            CTag17.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag17.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag17.IsButtonCustomed = False
            CTag17.IsTextValid = True
            CTag17.KeyValueAbsentable = False
            CTag17.LeagleText = ""
            CTag17.NumericButtonTextBox = Nothing
            CTag17.ParentControl = Me.PanelControl_Filter
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag17
            '
            'ComboBoxEdit_DownloadImageMode
            '
            resources.ApplyResources(Me.ComboBoxEdit_DownloadImageMode, "ComboBoxEdit_DownloadImageMode")
            Me.ComboBoxEdit_DownloadImageMode.BackgroundImage = Nothing
            Me.ComboBoxEdit_DownloadImageMode.Name = "ComboBoxEdit_DownloadImageMode"
            Me.ComboBoxEdit_DownloadImageMode.Properties.AccessibleDescription = Nothing
            Me.ComboBoxEdit_DownloadImageMode.Properties.AccessibleName = Nothing
            Me.ComboBoxEdit_DownloadImageMode.Properties.AutoHeight = CType(resources.GetObject("ComboBoxEdit_DownloadImageMode.Properties.AutoHeight"), Boolean)
            Me.ComboBoxEdit_DownloadImageMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ComboBoxEdit_DownloadImageMode.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.ComboBoxEdit_DownloadImageMode.Properties.Items.AddRange(New Object() {resources.GetString("ComboBoxEdit_DownloadImageMode.Properties.Items"), resources.GetString("ComboBoxEdit_DownloadImageMode.Properties.Items1"), resources.GetString("ComboBoxEdit_DownloadImageMode.Properties.Items2")})
            Me.ComboBoxEdit_DownloadImageMode.Properties.Mask.AutoComplete = CType(resources.GetObject("ComboBoxEdit_DownloadImageMode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.ComboBoxEdit_DownloadImageMode.Properties.Mask.BeepOnError = CType(resources.GetObject("ComboBoxEdit_DownloadImageMode.Properties.Mask.BeepOnError"), Boolean)
            Me.ComboBoxEdit_DownloadImageMode.Properties.Mask.EditMask = resources.GetString("ComboBoxEdit_DownloadImageMode.Properties.Mask.EditMask")
            Me.ComboBoxEdit_DownloadImageMode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ComboBoxEdit_DownloadImageMode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.ComboBoxEdit_DownloadImageMode.Properties.Mask.MaskType = CType(resources.GetObject("ComboBoxEdit_DownloadImageMode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.ComboBoxEdit_DownloadImageMode.Properties.Mask.PlaceHolder = CType(resources.GetObject("ComboBoxEdit_DownloadImageMode.Properties.Mask.PlaceHolder"), Char)
            Me.ComboBoxEdit_DownloadImageMode.Properties.Mask.SaveLiteral = CType(resources.GetObject("ComboBoxEdit_DownloadImageMode.Properties.Mask.SaveLiteral"), Boolean)
            Me.ComboBoxEdit_DownloadImageMode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ComboBoxEdit_DownloadImageMode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.ComboBoxEdit_DownloadImageMode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ComboBoxEdit_DownloadImageMode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.ComboBoxEdit_DownloadImageMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
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
            CTag4.ParentControl = Me.ComboBoxEdit_DownloadImageMode
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.ComboBoxEdit_DownloadImageMode.Tag = CTag4
            '
            'CheckEdit_ShowRetired
            '
            resources.ApplyResources(Me.CheckEdit_ShowRetired, "CheckEdit_ShowRetired")
            Me.CheckEdit_ShowRetired.BackgroundImage = Nothing
            Me.CheckEdit_ShowRetired.Name = "CheckEdit_ShowRetired"
            Me.CheckEdit_ShowRetired.Properties.AccessibleDescription = Nothing
            Me.CheckEdit_ShowRetired.Properties.AccessibleName = Nothing
            Me.CheckEdit_ShowRetired.Properties.AutoHeight = CType(resources.GetObject("CheckEdit_ShowRetired.Properties.AutoHeight"), Boolean)
            Me.CheckEdit_ShowRetired.Properties.Caption = resources.GetString("CheckEdit_ShowRetired.Properties.Caption")
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
            CTag5.ParentControl = Me.CheckEdit_ShowRetired
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_ShowRetired.Tag = CTag5
            '
            'CheckEdit_PriceCostModifiable
            '
            resources.ApplyResources(Me.CheckEdit_PriceCostModifiable, "CheckEdit_PriceCostModifiable")
            Me.CheckEdit_PriceCostModifiable.BackgroundImage = Nothing
            Me.CheckEdit_PriceCostModifiable.Name = "CheckEdit_PriceCostModifiable"
            Me.CheckEdit_PriceCostModifiable.Properties.AccessibleDescription = Nothing
            Me.CheckEdit_PriceCostModifiable.Properties.AccessibleName = Nothing
            Me.CheckEdit_PriceCostModifiable.Properties.AutoHeight = CType(resources.GetObject("CheckEdit_PriceCostModifiable.Properties.AutoHeight"), Boolean)
            Me.CheckEdit_PriceCostModifiable.Properties.Caption = resources.GetString("CheckEdit_PriceCostModifiable.Properties.Caption")
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
            CTag6.ParentControl = Me.CheckEdit_PriceCostModifiable
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_PriceCostModifiable.Tag = CTag6
            '
            'CheckEdit_RemotingMode
            '
            resources.ApplyResources(Me.CheckEdit_RemotingMode, "CheckEdit_RemotingMode")
            Me.CheckEdit_RemotingMode.BackgroundImage = Nothing
            Me.CheckEdit_RemotingMode.Name = "CheckEdit_RemotingMode"
            Me.CheckEdit_RemotingMode.Properties.AccessibleDescription = Nothing
            Me.CheckEdit_RemotingMode.Properties.AccessibleName = Nothing
            Me.CheckEdit_RemotingMode.Properties.AutoHeight = CType(resources.GetObject("CheckEdit_RemotingMode.Properties.AutoHeight"), Boolean)
            Me.CheckEdit_RemotingMode.Properties.Caption = resources.GetString("CheckEdit_RemotingMode.Properties.Caption")
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
            CTag7.ParentControl = Me.CheckEdit_RemotingMode
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_RemotingMode.Tag = CTag7
            '
            'CheckEdit_ExportPictureToExcel
            '
            resources.ApplyResources(Me.CheckEdit_ExportPictureToExcel, "CheckEdit_ExportPictureToExcel")
            Me.CheckEdit_ExportPictureToExcel.BackgroundImage = Nothing
            Me.CheckEdit_ExportPictureToExcel.Name = "CheckEdit_ExportPictureToExcel"
            Me.CheckEdit_ExportPictureToExcel.Properties.AccessibleDescription = Nothing
            Me.CheckEdit_ExportPictureToExcel.Properties.AccessibleName = Nothing
            Me.CheckEdit_ExportPictureToExcel.Properties.AutoHeight = CType(resources.GetObject("CheckEdit_ExportPictureToExcel.Properties.AutoHeight"), Boolean)
            Me.CheckEdit_ExportPictureToExcel.Properties.Caption = resources.GetString("CheckEdit_ExportPictureToExcel.Properties.Caption")
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
            CTag8.ParentControl = Me.CheckEdit_ExportPictureToExcel
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_ExportPictureToExcel.Tag = CTag8
            '
            'LinkLabel_DownloadImages
            '
            Me.LinkLabel_DownloadImages.AccessibleDescription = Nothing
            Me.LinkLabel_DownloadImages.AccessibleName = Nothing
            resources.ApplyResources(Me.LinkLabel_DownloadImages, "LinkLabel_DownloadImages")
            Me.LinkLabel_DownloadImages.Font = Nothing
            Me.LinkLabel_DownloadImages.Name = "LinkLabel_DownloadImages"
            Me.LinkLabel_DownloadImages.TabStop = True
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
            CTag9.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag9.IsButtonCustomed = False
            CTag9.IsTextValid = True
            CTag9.KeyValueAbsentable = False
            CTag9.LeagleText = ""
            CTag9.NumericButtonTextBox = Nothing
            CTag9.ParentControl = Me.LinkLabel_DownloadImages
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_DownloadImages.Tag = CTag9
            '
            'LinkLabel_SaveCostPriceModify
            '
            Me.LinkLabel_SaveCostPriceModify.AccessibleDescription = Nothing
            Me.LinkLabel_SaveCostPriceModify.AccessibleName = Nothing
            resources.ApplyResources(Me.LinkLabel_SaveCostPriceModify, "LinkLabel_SaveCostPriceModify")
            Me.LinkLabel_SaveCostPriceModify.Font = Nothing
            Me.LinkLabel_SaveCostPriceModify.Name = "LinkLabel_SaveCostPriceModify"
            Me.LinkLabel_SaveCostPriceModify.TabStop = True
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
            CTag10.ParentControl = Me.LinkLabel_SaveCostPriceModify
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_SaveCostPriceModify.Tag = CTag10
            '
            'LinkLabel_CancelAll
            '
            Me.LinkLabel_CancelAll.AccessibleDescription = Nothing
            Me.LinkLabel_CancelAll.AccessibleName = Nothing
            resources.ApplyResources(Me.LinkLabel_CancelAll, "LinkLabel_CancelAll")
            Me.LinkLabel_CancelAll.Font = Nothing
            Me.LinkLabel_CancelAll.Name = "LinkLabel_CancelAll"
            Me.LinkLabel_CancelAll.TabStop = True
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
            CTag11.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag11.IsButtonCustomed = False
            CTag11.IsTextValid = True
            CTag11.KeyValueAbsentable = False
            CTag11.LeagleText = ""
            CTag11.NumericButtonTextBox = Nothing
            CTag11.ParentControl = Me.LinkLabel_CancelAll
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_CancelAll.Tag = CTag11
            '
            'LinkLabel_SelectAll
            '
            Me.LinkLabel_SelectAll.AccessibleDescription = Nothing
            Me.LinkLabel_SelectAll.AccessibleName = Nothing
            resources.ApplyResources(Me.LinkLabel_SelectAll, "LinkLabel_SelectAll")
            Me.LinkLabel_SelectAll.Font = Nothing
            Me.LinkLabel_SelectAll.Name = "LinkLabel_SelectAll"
            Me.LinkLabel_SelectAll.TabStop = True
            CTag12.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag12.CalculatorRequired = True
            CTag12.ComboValueTextBox = Nothing
            CTag12.ControlRelatedCode = Nothing
            CTag12.DateButtonTextBox = Nothing
            CTag12.DateTimeButtonTextBox = Nothing
            CTag12.DisplayLinkControl = Nothing
            CTag12.DisplayLinkDisplayFieldName = Nothing
            CTag12.DisplayLinkKeyFieldName = Nothing
            CTag12.DisplayLinkTable = Nothing
            CTag12.FlexgridEditItem = ""
            CTag12.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag12.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag12.IsButtonCustomed = False
            CTag12.IsTextValid = True
            CTag12.KeyValueAbsentable = False
            CTag12.LeagleText = ""
            CTag12.NumericButtonTextBox = Nothing
            CTag12.ParentControl = Me.LinkLabel_SelectAll
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_SelectAll.Tag = CTag12
            '
            'LinkLabel_AllWareList
            '
            Me.LinkLabel_AllWareList.AccessibleDescription = Nothing
            Me.LinkLabel_AllWareList.AccessibleName = Nothing
            resources.ApplyResources(Me.LinkLabel_AllWareList, "LinkLabel_AllWareList")
            Me.LinkLabel_AllWareList.Font = Nothing
            Me.LinkLabel_AllWareList.Name = "LinkLabel_AllWareList"
            Me.LinkLabel_AllWareList.TabStop = True
            CTag13.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag13.CalculatorRequired = True
            CTag13.ComboValueTextBox = Nothing
            CTag13.ControlRelatedCode = Nothing
            CTag13.DateButtonTextBox = Nothing
            CTag13.DateTimeButtonTextBox = Nothing
            CTag13.DisplayLinkControl = Nothing
            CTag13.DisplayLinkDisplayFieldName = Nothing
            CTag13.DisplayLinkKeyFieldName = Nothing
            CTag13.DisplayLinkTable = Nothing
            CTag13.FlexgridEditItem = ""
            CTag13.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag13.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag13.IsButtonCustomed = False
            CTag13.IsTextValid = True
            CTag13.KeyValueAbsentable = False
            CTag13.LeagleText = ""
            CTag13.NumericButtonTextBox = Nothing
            CTag13.ParentControl = Me.LinkLabel_AllWareList
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_AllWareList.Tag = CTag13
            '
            'LinkLabel_AllWareExportExcel
            '
            Me.LinkLabel_AllWareExportExcel.AccessibleDescription = Nothing
            Me.LinkLabel_AllWareExportExcel.AccessibleName = Nothing
            resources.ApplyResources(Me.LinkLabel_AllWareExportExcel, "LinkLabel_AllWareExportExcel")
            Me.LinkLabel_AllWareExportExcel.Font = Nothing
            Me.LinkLabel_AllWareExportExcel.Name = "LinkLabel_AllWareExportExcel"
            Me.LinkLabel_AllWareExportExcel.TabStop = True
            CTag14.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag14.CalculatorRequired = True
            CTag14.ComboValueTextBox = Nothing
            CTag14.ControlRelatedCode = Nothing
            CTag14.DateButtonTextBox = Nothing
            CTag14.DateTimeButtonTextBox = Nothing
            CTag14.DisplayLinkControl = Nothing
            CTag14.DisplayLinkDisplayFieldName = Nothing
            CTag14.DisplayLinkKeyFieldName = Nothing
            CTag14.DisplayLinkTable = Nothing
            CTag14.FlexgridEditItem = ""
            CTag14.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag14.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag14.IsButtonCustomed = False
            CTag14.IsTextValid = True
            CTag14.KeyValueAbsentable = False
            CTag14.LeagleText = ""
            CTag14.NumericButtonTextBox = Nothing
            CTag14.ParentControl = Me.LinkLabel_AllWareExportExcel
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_AllWareExportExcel.Tag = CTag14
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
            CTag15.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag15.CalculatorRequired = True
            CTag15.ComboValueTextBox = Nothing
            CTag15.ControlRelatedCode = Nothing
            CTag15.DateButtonTextBox = Nothing
            CTag15.DateTimeButtonTextBox = Nothing
            CTag15.DisplayLinkControl = Nothing
            CTag15.DisplayLinkDisplayFieldName = Nothing
            CTag15.DisplayLinkKeyFieldName = Nothing
            CTag15.DisplayLinkTable = Nothing
            CTag15.FlexgridEditItem = ""
            CTag15.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag15.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag15.IsButtonCustomed = False
            CTag15.IsTextValid = True
            CTag15.KeyValueAbsentable = False
            CTag15.LeagleText = ""
            CTag15.NumericButtonTextBox = Nothing
            CTag15.ParentControl = Me.TextEdit_Search
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag15
            '
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
            CTag16.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag16.CalculatorRequired = True
            CTag16.ComboValueTextBox = Nothing
            CTag16.ControlRelatedCode = Nothing
            CTag16.DateButtonTextBox = Nothing
            CTag16.DateTimeButtonTextBox = Nothing
            CTag16.DisplayLinkControl = Nothing
            CTag16.DisplayLinkDisplayFieldName = Nothing
            CTag16.DisplayLinkKeyFieldName = Nothing
            CTag16.DisplayLinkTable = Nothing
            CTag16.FlexgridEditItem = ""
            CTag16.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag16.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag16.IsButtonCustomed = False
            CTag16.IsTextValid = True
            CTag16.KeyValueAbsentable = False
            CTag16.LeagleText = ""
            CTag16.NumericButtonTextBox = Nothing
            CTag16.ParentControl = Me.Label1
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag16
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'OpenFileDialog_ImportFile
            '
            resources.ApplyResources(Me.OpenFileDialog_ImportFile, "OpenFileDialog_ImportFile")
            '
            'OpenFileDialog_SetImage
            '
            resources.ApplyResources(Me.OpenFileDialog_SetImage, "OpenFileDialog_SetImage")
            '
            'M_01_00201
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.SplitContainerControl1)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_01_00201"
            CTag18.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag18.CalculatorRequired = True
            CTag18.ComboValueTextBox = Nothing
            CTag18.ControlRelatedCode = Nothing
            CTag18.DateButtonTextBox = Nothing
            CTag18.DateTimeButtonTextBox = Nothing
            CTag18.DisplayLinkControl = Nothing
            CTag18.DisplayLinkDisplayFieldName = Nothing
            CTag18.DisplayLinkKeyFieldName = Nothing
            CTag18.DisplayLinkTable = Nothing
            CTag18.FlexgridEditItem = ""
            CTag18.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag18.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag18.IsButtonCustomed = False
            CTag18.IsTextValid = True
            CTag18.KeyValueAbsentable = False
            CTag18.LeagleText = ""
            CTag18.NumericButtonTextBox = Nothing
            CTag18.ParentControl = Me
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag18
            CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainerControl1.ResumeLayout(False)
            CType(Me.SplitContainerControl_Left, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainerControl_Left.ResumeLayout(False)
            CType(Me.TreeList_WareClassify, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox_Item, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_Ware, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Ware, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_UnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_UnitCost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_SupplierID, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.ComboBoxEdit_DownloadImageMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_ShowRetired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_PriceCostModifiable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_RemotingMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_ExportPictureToExcel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Friend WithEvents TreeList_WareClassify As DevExpress.XtraTreeList.TreeList
        Friend WithEvents GridControl_Ware As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Ware As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents ToolStripButton_CreateWare As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_ImportFromExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Report As System.Windows.Forms.ToolStripButton
        Friend WithEvents TreeListColumn_WareClassifyCode As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents TreeListColumn_WareClassifyName As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents TreeListColumn_Remark As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents GridColumn_RowSelect As DevExpress.XtraGrid.Columns.GridColumn
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
        Friend WithEvents GridColumn_UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Unitcost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents LinkLabel_SelectAll As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel_AllWareList As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel_AllWareExportExcel As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel_CancelAll As System.Windows.Forms.LinkLabel
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents OpenFileDialog_ImportFile As System.Windows.Forms.OpenFileDialog
        Friend WithEvents OpenFileDialog_SetImage As System.Windows.Forms.OpenFileDialog
        Friend WithEvents TreeListColumn_WareClassifyID As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents SplitContainerControl_Left As DevExpress.XtraEditors.SplitContainerControl
        Friend WithEvents PictureBox_Item As System.Windows.Forms.PictureBox
        Friend WithEvents LinkLabel_SetImage As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel_DeleteImage As System.Windows.Forms.LinkLabel
        Friend WithEvents GridColumn_SupplierID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_SupplierID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents CheckEdit_ExportPictureToExcel As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents CheckEdit_ShowRetired As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents RepositoryItemCalcEdit_UnitPrice As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents RepositoryItemCalcEdit_UnitCost As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents CheckEdit_RemotingMode As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents CheckEdit_PriceCostModifiable As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LinkLabel_SaveCostPriceModify As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel_DownloadImages As System.Windows.Forms.LinkLabel
        Friend WithEvents ComboBoxEdit_DownloadImageMode As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents ToolStripButton_SetWareBOM As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace
