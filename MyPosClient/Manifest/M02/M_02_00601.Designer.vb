Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00601
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
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00601))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag26 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag21 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag20 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag18 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag19 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag23 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag22 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag25 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag24 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag27 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.GridControl_Operation = New DevExpress.XtraGrid.GridControl
            Me.GridView_Operation = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareNameEn = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SpecEn = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ModelEn = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_IOAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowRemark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ViewHistory = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ImportMobile = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.Label_LocationID = New System.Windows.Forms.Label
            Me.Panel_LocationIO = New DevExpress.XtraEditors.PanelControl
            Me.LookUpEdit_IOType = New DevExpress.XtraEditors.LookUpEdit
            Me.Label_InOutMode = New System.Windows.Forms.Label
            Me.Label_EmployeeID = New System.Windows.Forms.Label
            Me.Label_StoringPlaceInfo = New System.Windows.Forms.Label
            Me.ButtonEdit_LocationCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label4 = New System.Windows.Forms.Label
            Me.LookUpEdit_Pos = New DevExpress.XtraEditors.LookUpEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.XtraTabControl_Lists = New DevExpress.XtraTab.XtraTabControl
            Me.XtraTabPage_Operations = New DevExpress.XtraTab.XtraTabPage
            Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_AutoSaveAlteringLot = New DevExpress.XtraEditors.CheckEdit
            Me.CheckEdit_ShowDetailInput = New DevExpress.XtraEditors.CheckEdit
            Me.Label_WareID = New System.Windows.Forms.Label
            Me.Label_CustomCode = New System.Windows.Forms.Label
            Me.ButtonEdit_WareCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label18 = New System.Windows.Forms.Label
            Me.XtraTabPage_StoringPlaceDtl = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_ViewCurrentStock = New DevExpress.XtraGrid.GridControl
            Me.GridView_ViewCurrentStock = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_VWareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VCustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VWareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VWareNameEn = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VSpec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VSpecEn = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VModel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VModelEn = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VAttribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VAttribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VAttribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VAttribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VIOAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VUnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VRemarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_VRowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.XtraTabPage_InventoryDifference = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_ShelfStockDifference = New DevExpress.XtraGrid.GridControl
            Me.GridView_ShelfStockDifference = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_SWareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SCustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SWareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SWareNameEn = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SSpec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SSpecEn = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SModel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SModelEn = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SAttribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SAttribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SAttribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SAttribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SelfAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PosAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_DifferenceAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SUnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SRemarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SRowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            CType(Me.GridControl_Operation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Operation, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.Panel_LocationIO, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel_LocationIO.SuspendLayout()
            CType(Me.LookUpEdit_IOType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_LocationCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl_Lists, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl_Lists.SuspendLayout()
            Me.XtraTabPage_Operations.SuspendLayout()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl2.SuspendLayout()
            CType(Me.CheckEdit_AutoSaveAlteringLot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_ShowDetailInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage_StoringPlaceDtl.SuspendLayout()
            CType(Me.GridControl_ViewCurrentStock, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ViewCurrentStock, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage_InventoryDifference.SuspendLayout()
            CType(Me.GridControl_ShelfStockDifference, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ShelfStockDifference, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DefaultLookAndFeel_Form
            '
            Me.DefaultLookAndFeel_Form.LookAndFeel.SkinName = ""
            '
            'Timer_Surveillant
            '
            '
            'GridControl_Operation
            '
            Me.GridControl_Operation.AccessibleDescription = Nothing
            Me.GridControl_Operation.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_Operation, "GridControl_Operation")
            Me.GridControl_Operation.BackgroundImage = Nothing
            Me.GridControl_Operation.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_Operation.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_Operation.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_Operation.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_Operation.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_Operation.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_Operation.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_Operation.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_Operation.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_Operation.EmbeddedNavigator.Name = ""
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
            CTag1.ParentControl = Me.GridControl_Operation.EmbeddedNavigator
            CTag1.SkipValidate = False
            CTag1.TimeButtonTextBox = Nothing
            CTag1.ToolTip = ""
            CTag1.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Operation.EmbeddedNavigator.Tag = CTag1
            Me.GridControl_Operation.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_Operation.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_Operation.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_Operation.EmbeddedNavigator.ToolTip")
            Me.GridControl_Operation.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_Operation.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_Operation.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_Operation.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_Operation.Font = Nothing
            Me.GridControl_Operation.MainView = Me.GridView_Operation
            Me.GridControl_Operation.Name = "GridControl_Operation"
            Me.GridControl_Operation.TabStop = False
            Me.GridControl_Operation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Operation})
            '
            'GridView_Operation
            '
            resources.ApplyResources(Me.GridView_Operation, "GridView_Operation")
            Me.GridView_Operation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_WareNameEn, Me.GridColumn_Spec, Me.GridColumn_SpecEn, Me.GridColumn_Model, Me.GridColumn_ModelEn, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_IOAmount, Me.GridColumn_UnitName, Me.GridColumn_Remarks, Me.GridColumn_RowRemark, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_Operation.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_Operation.GridControl = Me.GridControl_Operation
            Me.GridView_Operation.Name = "GridView_Operation"
            Me.GridView_Operation.OptionsView.ColumnAutoWidth = False
            Me.GridView_Operation.OptionsView.ShowFooter = True
            Me.GridView_Operation.OptionsView.ShowGroupPanel = False
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
            'GridColumn_WareNameEn
            '
            resources.ApplyResources(Me.GridColumn_WareNameEn, "GridColumn_WareNameEn")
            Me.GridColumn_WareNameEn.FieldName = "WARE_NAME_EN"
            Me.GridColumn_WareNameEn.Name = "GridColumn_WareNameEn"
            Me.GridColumn_WareNameEn.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Spec
            '
            resources.ApplyResources(Me.GridColumn_Spec, "GridColumn_Spec")
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SpecEn
            '
            resources.ApplyResources(Me.GridColumn_SpecEn, "GridColumn_SpecEn")
            Me.GridColumn_SpecEn.FieldName = "SPEC_EN"
            Me.GridColumn_SpecEn.Name = "GridColumn_SpecEn"
            Me.GridColumn_SpecEn.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Model
            '
            resources.ApplyResources(Me.GridColumn_Model, "GridColumn_Model")
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ModelEn
            '
            resources.ApplyResources(Me.GridColumn_ModelEn, "GridColumn_ModelEn")
            Me.GridColumn_ModelEn.FieldName = "MODEL_EN"
            Me.GridColumn_ModelEn.Name = "GridColumn_ModelEn"
            Me.GridColumn_ModelEn.OptionsColumn.AllowFocus = False
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
            'GridColumn_IOAmount
            '
            resources.ApplyResources(Me.GridColumn_IOAmount, "GridColumn_IOAmount")
            Me.GridColumn_IOAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_IOAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_IOAmount.FieldName = "IO_AMOUNT"
            Me.GridColumn_IOAmount.Name = "GridColumn_IOAmount"
            Me.GridColumn_IOAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_IOAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_IOAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_IOAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
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
            'GridColumn_RowRemark
            '
            resources.ApplyResources(Me.GridColumn_RowRemark, "GridColumn_RowRemark")
            Me.GridColumn_RowRemark.FieldName = "DSR_FT_ROW_REMARK"
            Me.GridColumn_RowRemark.Name = "GridColumn_RowRemark"
            Me.GridColumn_RowRemark.OptionsColumn.AllowFocus = False
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Save, Me.ToolStripButton_Add, Me.ToolStripButton_Revise, Me.ToolStripButton_Remove, Me.ToolStripButton_ViewHistory, Me.ToolStripButton_ImportMobile, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_Refresh, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
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
            CTag2.ParentControl = Me.ToolStrip_Form
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.ToolStrip_Form.Tag = CTag2
            '
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.AccessibleDescription = Nothing
            Me.ToolStripButton_Save.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Save, "ToolStripButton_Save")
            Me.ToolStripButton_Save.BackgroundImage = Nothing
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            '
            'ToolStripButton_Add
            '
            Me.ToolStripButton_Add.AccessibleDescription = Nothing
            Me.ToolStripButton_Add.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Add, "ToolStripButton_Add")
            Me.ToolStripButton_Add.BackgroundImage = Nothing
            Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.AccessibleDescription = Nothing
            Me.ToolStripButton_Revise.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Revise, "ToolStripButton_Revise")
            Me.ToolStripButton_Revise.BackgroundImage = Nothing
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.AccessibleDescription = Nothing
            Me.ToolStripButton_Remove.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Remove, "ToolStripButton_Remove")
            Me.ToolStripButton_Remove.BackgroundImage = Nothing
            Me.ToolStripButton_Remove.Name = "ToolStripButton_Remove"
            '
            'ToolStripButton_ViewHistory
            '
            Me.ToolStripButton_ViewHistory.AccessibleDescription = Nothing
            Me.ToolStripButton_ViewHistory.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_ViewHistory, "ToolStripButton_ViewHistory")
            Me.ToolStripButton_ViewHistory.BackgroundImage = Nothing
            Me.ToolStripButton_ViewHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_ViewHistory.Name = "ToolStripButton_ViewHistory"
            '
            'ToolStripButton_ImportMobile
            '
            Me.ToolStripButton_ImportMobile.AccessibleDescription = Nothing
            Me.ToolStripButton_ImportMobile.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_ImportMobile, "ToolStripButton_ImportMobile")
            Me.ToolStripButton_ImportMobile.BackgroundImage = Nothing
            Me.ToolStripButton_ImportMobile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_ImportMobile.Name = "ToolStripButton_ImportMobile"
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
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.AccessibleDescription = Nothing
            Me.ToolStripButton_Refresh.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            Me.ToolStripButton_Refresh.BackgroundImage = Nothing
            Me.ToolStripButton_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.AccessibleDescription = Nothing
            Me.ToolStripButton_Close.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Close, "ToolStripButton_Close")
            Me.ToolStripButton_Close.BackgroundImage = Nothing
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            '
            'PanelControl1
            '
            Me.PanelControl1.AccessibleDescription = Nothing
            Me.PanelControl1.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl1, "PanelControl1")
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.Controls.Add(Me.Label_LocationID)
            Me.PanelControl1.Controls.Add(Me.Panel_LocationIO)
            Me.PanelControl1.Controls.Add(Me.LookUpEdit_Pos)
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Name = "PanelControl1"
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
            CTag13.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag13.IsButtonCustomed = False
            CTag13.IsTextValid = True
            CTag13.KeyValueAbsentable = False
            CTag13.LeagleText = ""
            CTag13.NumericButtonTextBox = Nothing
            CTag13.ParentControl = Me.PanelControl1
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag13
            '
            'Label_LocationID
            '
            Me.Label_LocationID.AccessibleDescription = Nothing
            Me.Label_LocationID.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_LocationID, "Label_LocationID")
            Me.Label_LocationID.Font = Nothing
            Me.Label_LocationID.Name = "Label_LocationID"
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
            CTag3.ParentControl = Me.Label_LocationID
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_LocationID.Tag = CTag3
            '
            'Panel_LocationIO
            '
            Me.Panel_LocationIO.AccessibleDescription = Nothing
            Me.Panel_LocationIO.AccessibleName = Nothing
            resources.ApplyResources(Me.Panel_LocationIO, "Panel_LocationIO")
            Me.Panel_LocationIO.Controls.Add(Me.LookUpEdit_IOType)
            Me.Panel_LocationIO.Controls.Add(Me.Label_InOutMode)
            Me.Panel_LocationIO.Controls.Add(Me.Label_EmployeeID)
            Me.Panel_LocationIO.Controls.Add(Me.Label_StoringPlaceInfo)
            Me.Panel_LocationIO.Controls.Add(Me.ButtonEdit_LocationCode)
            Me.Panel_LocationIO.Controls.Add(Me.Label4)
            Me.Panel_LocationIO.Name = "Panel_LocationIO"
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
            CTag10.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag10.IsButtonCustomed = False
            CTag10.IsTextValid = True
            CTag10.KeyValueAbsentable = False
            CTag10.LeagleText = ""
            CTag10.NumericButtonTextBox = Nothing
            CTag10.ParentControl = Me.Panel_LocationIO
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Panel_LocationIO.Tag = CTag10
            '
            'LookUpEdit_IOType
            '
            resources.ApplyResources(Me.LookUpEdit_IOType, "LookUpEdit_IOType")
            Me.LookUpEdit_IOType.BackgroundImage = Nothing
            Me.LookUpEdit_IOType.EditValue = Nothing
            Me.LookUpEdit_IOType.Name = "LookUpEdit_IOType"
            Me.LookUpEdit_IOType.Properties.AccessibleDescription = Nothing
            Me.LookUpEdit_IOType.Properties.AccessibleName = Nothing
            Me.LookUpEdit_IOType.Properties.AutoHeight = CType(resources.GetObject("LookUpEdit_IOType.Properties.AutoHeight"), Boolean)
            Me.LookUpEdit_IOType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_IOType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_IOType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_IOType.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_IOType.Properties.Mask.AutoComplete = CType(resources.GetObject("LookUpEdit_IOType.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.LookUpEdit_IOType.Properties.Mask.BeepOnError = CType(resources.GetObject("LookUpEdit_IOType.Properties.Mask.BeepOnError"), Boolean)
            Me.LookUpEdit_IOType.Properties.Mask.EditMask = resources.GetString("LookUpEdit_IOType.Properties.Mask.EditMask")
            Me.LookUpEdit_IOType.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("LookUpEdit_IOType.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.LookUpEdit_IOType.Properties.Mask.MaskType = CType(resources.GetObject("LookUpEdit_IOType.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.LookUpEdit_IOType.Properties.Mask.PlaceHolder = CType(resources.GetObject("LookUpEdit_IOType.Properties.Mask.PlaceHolder"), Char)
            Me.LookUpEdit_IOType.Properties.Mask.SaveLiteral = CType(resources.GetObject("LookUpEdit_IOType.Properties.Mask.SaveLiteral"), Boolean)
            Me.LookUpEdit_IOType.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("LookUpEdit_IOType.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.LookUpEdit_IOType.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("LookUpEdit_IOType.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.LookUpEdit_IOType.Properties.ValueMember = "ITEM_VALUE"
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
            CTag4.ParentControl = Me.LookUpEdit_IOType
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_IOType.Tag = CTag4
            '
            'Label_InOutMode
            '
            Me.Label_InOutMode.AccessibleDescription = Nothing
            Me.Label_InOutMode.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_InOutMode, "Label_InOutMode")
            Me.Label_InOutMode.Font = Nothing
            Me.Label_InOutMode.Name = "Label_InOutMode"
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
            CTag5.ParentControl = Me.Label_InOutMode
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label_InOutMode.Tag = CTag5
            '
            'Label_EmployeeID
            '
            Me.Label_EmployeeID.AccessibleDescription = Nothing
            Me.Label_EmployeeID.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_EmployeeID, "Label_EmployeeID")
            Me.Label_EmployeeID.Font = Nothing
            Me.Label_EmployeeID.Name = "Label_EmployeeID"
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
            CTag6.ParentControl = Me.Label_EmployeeID
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label_EmployeeID.Tag = CTag6
            '
            'Label_StoringPlaceInfo
            '
            Me.Label_StoringPlaceInfo.AccessibleDescription = Nothing
            Me.Label_StoringPlaceInfo.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_StoringPlaceInfo, "Label_StoringPlaceInfo")
            Me.Label_StoringPlaceInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_StoringPlaceInfo.Font = Nothing
            Me.Label_StoringPlaceInfo.Name = "Label_StoringPlaceInfo"
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
            CTag7.ParentControl = Me.Label_StoringPlaceInfo
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label_StoringPlaceInfo.Tag = CTag7
            '
            'ButtonEdit_LocationCode
            '
            resources.ApplyResources(Me.ButtonEdit_LocationCode, "ButtonEdit_LocationCode")
            Me.ButtonEdit_LocationCode.BackgroundImage = Nothing
            Me.ButtonEdit_LocationCode.EditValue = Nothing
            Me.ButtonEdit_LocationCode.Name = "ButtonEdit_LocationCode"
            Me.ButtonEdit_LocationCode.Properties.AccessibleDescription = Nothing
            Me.ButtonEdit_LocationCode.Properties.AccessibleName = Nothing
            Me.ButtonEdit_LocationCode.Properties.AutoHeight = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.AutoHeight"), Boolean)
            Me.ButtonEdit_LocationCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_LocationCode.Properties.Mask.AutoComplete = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.ButtonEdit_LocationCode.Properties.Mask.BeepOnError = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.BeepOnError"), Boolean)
            Me.ButtonEdit_LocationCode.Properties.Mask.EditMask = resources.GetString("ButtonEdit_LocationCode.Properties.Mask.EditMask")
            Me.ButtonEdit_LocationCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.ButtonEdit_LocationCode.Properties.Mask.MaskType = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.ButtonEdit_LocationCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.PlaceHolder"), Char)
            Me.ButtonEdit_LocationCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.ButtonEdit_LocationCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.ButtonEdit_LocationCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag8.ParentControl = Me.ButtonEdit_LocationCode
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_LocationCode.Tag = CTag8
            '
            'Label4
            '
            Me.Label4.AccessibleDescription = Nothing
            Me.Label4.AccessibleName = Nothing
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.Font = Nothing
            Me.Label4.Name = "Label4"
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
            CTag9.ParentControl = Me.Label4
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag9
            '
            'LookUpEdit_Pos
            '
            resources.ApplyResources(Me.LookUpEdit_Pos, "LookUpEdit_Pos")
            Me.LookUpEdit_Pos.BackgroundImage = Nothing
            Me.LookUpEdit_Pos.EditValue = Nothing
            Me.LookUpEdit_Pos.Name = "LookUpEdit_Pos"
            Me.LookUpEdit_Pos.Properties.AccessibleDescription = Nothing
            Me.LookUpEdit_Pos.Properties.AccessibleName = Nothing
            Me.LookUpEdit_Pos.Properties.AutoHeight = CType(resources.GetObject("LookUpEdit_Pos.Properties.AutoHeight"), Boolean)
            Me.LookUpEdit_Pos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_Pos.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_Pos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Pos.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_Pos.Properties.Mask.AutoComplete = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.LookUpEdit_Pos.Properties.Mask.BeepOnError = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.BeepOnError"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.EditMask = resources.GetString("LookUpEdit_Pos.Properties.Mask.EditMask")
            Me.LookUpEdit_Pos.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.MaskType = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.LookUpEdit_Pos.Properties.Mask.PlaceHolder = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.PlaceHolder"), Char)
            Me.LookUpEdit_Pos.Properties.Mask.SaveLiteral = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.SaveLiteral"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.LookUpEdit_Pos.Properties.ValueMember = "POS_ID"
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
            CTag11.ParentControl = Me.LookUpEdit_Pos
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_Pos.Tag = CTag11
            '
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.Font = Nothing
            Me.Label1.Name = "Label1"
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
            CTag12.ParentControl = Me.Label1
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag12
            '
            'XtraTabControl_Lists
            '
            Me.XtraTabControl_Lists.AccessibleDescription = Nothing
            Me.XtraTabControl_Lists.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabControl_Lists, "XtraTabControl_Lists")
            Me.XtraTabControl_Lists.BackgroundImage = Nothing
            Me.XtraTabControl_Lists.Font = Nothing
            Me.XtraTabControl_Lists.Images = Nothing
            Me.XtraTabControl_Lists.Name = "XtraTabControl_Lists"
            Me.XtraTabControl_Lists.SelectedTabPage = Me.XtraTabPage_Operations
            Me.XtraTabControl_Lists.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage_Operations, Me.XtraTabPage_StoringPlaceDtl, Me.XtraTabPage_InventoryDifference})
            Me.XtraTabControl_Lists.TabStop = False
            CTag26.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag26.CalculatorRequired = True
            CTag26.ComboValueTextBox = Nothing
            CTag26.ControlRelatedCode = Nothing
            CTag26.DateButtonTextBox = Nothing
            CTag26.DateTimeButtonTextBox = Nothing
            CTag26.DisplayLinkControl = Nothing
            CTag26.DisplayLinkDisplayFieldName = Nothing
            CTag26.DisplayLinkKeyFieldName = Nothing
            CTag26.DisplayLinkTable = Nothing
            CTag26.FlexgridEditItem = ""
            CTag26.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag26.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag26.IsButtonCustomed = False
            CTag26.IsTextValid = True
            CTag26.KeyValueAbsentable = False
            CTag26.LeagleText = ""
            CTag26.NumericButtonTextBox = Nothing
            CTag26.ParentControl = Me.XtraTabControl_Lists
            CTag26.SkipValidate = False
            CTag26.TimeButtonTextBox = Nothing
            CTag26.ToolTip = ""
            CTag26.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabControl_Lists.Tag = CTag26
            '
            'XtraTabPage_Operations
            '
            Me.XtraTabPage_Operations.AccessibleDescription = Nothing
            Me.XtraTabPage_Operations.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabPage_Operations, "XtraTabPage_Operations")
            Me.XtraTabPage_Operations.BackgroundImage = Nothing
            Me.XtraTabPage_Operations.Controls.Add(Me.GridControl_Operation)
            Me.XtraTabPage_Operations.Controls.Add(Me.PanelControl2)
            Me.XtraTabPage_Operations.Font = Nothing
            Me.XtraTabPage_Operations.Name = "XtraTabPage_Operations"
            CTag21.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag21.CalculatorRequired = True
            CTag21.ComboValueTextBox = Nothing
            CTag21.ControlRelatedCode = Nothing
            CTag21.DateButtonTextBox = Nothing
            CTag21.DateTimeButtonTextBox = Nothing
            CTag21.DisplayLinkControl = Nothing
            CTag21.DisplayLinkDisplayFieldName = Nothing
            CTag21.DisplayLinkKeyFieldName = Nothing
            CTag21.DisplayLinkTable = Nothing
            CTag21.FlexgridEditItem = ""
            CTag21.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag21.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag21.IsButtonCustomed = False
            CTag21.IsTextValid = True
            CTag21.KeyValueAbsentable = False
            CTag21.LeagleText = ""
            CTag21.NumericButtonTextBox = Nothing
            CTag21.ParentControl = Me.XtraTabPage_Operations
            CTag21.SkipValidate = False
            CTag21.TimeButtonTextBox = Nothing
            CTag21.ToolTip = ""
            CTag21.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_Operations.Tag = CTag21
            '
            'PanelControl2
            '
            Me.PanelControl2.AccessibleDescription = Nothing
            Me.PanelControl2.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl2, "PanelControl2")
            Me.PanelControl2.Controls.Add(Me.CheckEdit_AutoSaveAlteringLot)
            Me.PanelControl2.Controls.Add(Me.CheckEdit_ShowDetailInput)
            Me.PanelControl2.Controls.Add(Me.Label_WareID)
            Me.PanelControl2.Controls.Add(Me.Label_CustomCode)
            Me.PanelControl2.Controls.Add(Me.ButtonEdit_WareCode)
            Me.PanelControl2.Controls.Add(Me.Label18)
            Me.PanelControl2.Name = "PanelControl2"
            CTag20.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag20.CalculatorRequired = True
            CTag20.ComboValueTextBox = Nothing
            CTag20.ControlRelatedCode = Nothing
            CTag20.DateButtonTextBox = Nothing
            CTag20.DateTimeButtonTextBox = Nothing
            CTag20.DisplayLinkControl = Nothing
            CTag20.DisplayLinkDisplayFieldName = Nothing
            CTag20.DisplayLinkKeyFieldName = Nothing
            CTag20.DisplayLinkTable = Nothing
            CTag20.FlexgridEditItem = ""
            CTag20.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag20.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag20.IsButtonCustomed = False
            CTag20.IsTextValid = True
            CTag20.KeyValueAbsentable = False
            CTag20.LeagleText = ""
            CTag20.NumericButtonTextBox = Nothing
            CTag20.ParentControl = Me.PanelControl2
            CTag20.SkipValidate = False
            CTag20.TimeButtonTextBox = Nothing
            CTag20.ToolTip = ""
            CTag20.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl2.Tag = CTag20
            '
            'CheckEdit_AutoSaveAlteringLot
            '
            resources.ApplyResources(Me.CheckEdit_AutoSaveAlteringLot, "CheckEdit_AutoSaveAlteringLot")
            Me.CheckEdit_AutoSaveAlteringLot.BackgroundImage = Nothing
            Me.CheckEdit_AutoSaveAlteringLot.Name = "CheckEdit_AutoSaveAlteringLot"
            Me.CheckEdit_AutoSaveAlteringLot.Properties.AccessibleDescription = Nothing
            Me.CheckEdit_AutoSaveAlteringLot.Properties.AccessibleName = Nothing
            Me.CheckEdit_AutoSaveAlteringLot.Properties.AutoHeight = CType(resources.GetObject("CheckEdit_AutoSaveAlteringLot.Properties.AutoHeight"), Boolean)
            Me.CheckEdit_AutoSaveAlteringLot.Properties.Caption = resources.GetString("CheckEdit_AutoSaveAlteringLot.Properties.Caption")
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
            CTag14.ParentControl = Me.CheckEdit_AutoSaveAlteringLot
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_AutoSaveAlteringLot.Tag = CTag14
            '
            'CheckEdit_ShowDetailInput
            '
            resources.ApplyResources(Me.CheckEdit_ShowDetailInput, "CheckEdit_ShowDetailInput")
            Me.CheckEdit_ShowDetailInput.BackgroundImage = Nothing
            Me.CheckEdit_ShowDetailInput.Name = "CheckEdit_ShowDetailInput"
            Me.CheckEdit_ShowDetailInput.Properties.AccessibleDescription = Nothing
            Me.CheckEdit_ShowDetailInput.Properties.AccessibleName = Nothing
            Me.CheckEdit_ShowDetailInput.Properties.AutoHeight = CType(resources.GetObject("CheckEdit_ShowDetailInput.Properties.AutoHeight"), Boolean)
            Me.CheckEdit_ShowDetailInput.Properties.Caption = resources.GetString("CheckEdit_ShowDetailInput.Properties.Caption")
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
            CTag15.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag15.IsButtonCustomed = False
            CTag15.IsTextValid = True
            CTag15.KeyValueAbsentable = False
            CTag15.LeagleText = ""
            CTag15.NumericButtonTextBox = Nothing
            CTag15.ParentControl = Me.CheckEdit_ShowDetailInput
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_ShowDetailInput.Tag = CTag15
            '
            'Label_WareID
            '
            Me.Label_WareID.AccessibleDescription = Nothing
            Me.Label_WareID.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_WareID, "Label_WareID")
            Me.Label_WareID.Font = Nothing
            Me.Label_WareID.Name = "Label_WareID"
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
            CTag16.ParentControl = Me.Label_WareID
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareID.Tag = CTag16
            '
            'Label_CustomCode
            '
            Me.Label_CustomCode.AccessibleDescription = Nothing
            Me.Label_CustomCode.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_CustomCode, "Label_CustomCode")
            Me.Label_CustomCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_CustomCode.Font = Nothing
            Me.Label_CustomCode.Name = "Label_CustomCode"
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
            CTag17.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag17.IsButtonCustomed = False
            CTag17.IsTextValid = True
            CTag17.KeyValueAbsentable = False
            CTag17.LeagleText = ""
            CTag17.NumericButtonTextBox = Nothing
            CTag17.ParentControl = Me.Label_CustomCode
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomCode.Tag = CTag17
            '
            'ButtonEdit_WareCode
            '
            resources.ApplyResources(Me.ButtonEdit_WareCode, "ButtonEdit_WareCode")
            Me.ButtonEdit_WareCode.BackgroundImage = Nothing
            Me.ButtonEdit_WareCode.EditValue = Nothing
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.AccessibleDescription = Nothing
            Me.ButtonEdit_WareCode.Properties.AccessibleName = Nothing
            Me.ButtonEdit_WareCode.Properties.AutoHeight = CType(resources.GetObject("ButtonEdit_WareCode.Properties.AutoHeight"), Boolean)
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_WareCode.Properties.Mask.AutoComplete = CType(resources.GetObject("ButtonEdit_WareCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.ButtonEdit_WareCode.Properties.Mask.BeepOnError = CType(resources.GetObject("ButtonEdit_WareCode.Properties.Mask.BeepOnError"), Boolean)
            Me.ButtonEdit_WareCode.Properties.Mask.EditMask = resources.GetString("ButtonEdit_WareCode.Properties.Mask.EditMask")
            Me.ButtonEdit_WareCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ButtonEdit_WareCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.ButtonEdit_WareCode.Properties.Mask.MaskType = CType(resources.GetObject("ButtonEdit_WareCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.ButtonEdit_WareCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("ButtonEdit_WareCode.Properties.Mask.PlaceHolder"), Char)
            Me.ButtonEdit_WareCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("ButtonEdit_WareCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.ButtonEdit_WareCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ButtonEdit_WareCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.ButtonEdit_WareCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ButtonEdit_WareCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag18.ParentControl = Me.ButtonEdit_WareCode
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_WareCode.Tag = CTag18
            '
            'Label18
            '
            Me.Label18.AccessibleDescription = Nothing
            Me.Label18.AccessibleName = Nothing
            resources.ApplyResources(Me.Label18, "Label18")
            Me.Label18.Font = Nothing
            Me.Label18.Name = "Label18"
            CTag19.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag19.CalculatorRequired = True
            CTag19.ComboValueTextBox = Nothing
            CTag19.ControlRelatedCode = Nothing
            CTag19.DateButtonTextBox = Nothing
            CTag19.DateTimeButtonTextBox = Nothing
            CTag19.DisplayLinkControl = Nothing
            CTag19.DisplayLinkDisplayFieldName = Nothing
            CTag19.DisplayLinkKeyFieldName = Nothing
            CTag19.DisplayLinkTable = Nothing
            CTag19.FlexgridEditItem = ""
            CTag19.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag19.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag19.IsButtonCustomed = False
            CTag19.IsTextValid = True
            CTag19.KeyValueAbsentable = False
            CTag19.LeagleText = ""
            CTag19.NumericButtonTextBox = Nothing
            CTag19.ParentControl = Me.Label18
            CTag19.SkipValidate = False
            CTag19.TimeButtonTextBox = Nothing
            CTag19.ToolTip = ""
            CTag19.ValueType = XL.Common.ControlValueType.Character
            Me.Label18.Tag = CTag19
            '
            'XtraTabPage_StoringPlaceDtl
            '
            Me.XtraTabPage_StoringPlaceDtl.AccessibleDescription = Nothing
            Me.XtraTabPage_StoringPlaceDtl.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabPage_StoringPlaceDtl, "XtraTabPage_StoringPlaceDtl")
            Me.XtraTabPage_StoringPlaceDtl.BackgroundImage = Nothing
            Me.XtraTabPage_StoringPlaceDtl.Controls.Add(Me.GridControl_ViewCurrentStock)
            Me.XtraTabPage_StoringPlaceDtl.Font = Nothing
            Me.XtraTabPage_StoringPlaceDtl.Name = "XtraTabPage_StoringPlaceDtl"
            CTag23.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag23.CalculatorRequired = True
            CTag23.ComboValueTextBox = Nothing
            CTag23.ControlRelatedCode = Nothing
            CTag23.DateButtonTextBox = Nothing
            CTag23.DateTimeButtonTextBox = Nothing
            CTag23.DisplayLinkControl = Nothing
            CTag23.DisplayLinkDisplayFieldName = Nothing
            CTag23.DisplayLinkKeyFieldName = Nothing
            CTag23.DisplayLinkTable = Nothing
            CTag23.FlexgridEditItem = ""
            CTag23.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag23.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag23.IsButtonCustomed = False
            CTag23.IsTextValid = True
            CTag23.KeyValueAbsentable = False
            CTag23.LeagleText = ""
            CTag23.NumericButtonTextBox = Nothing
            CTag23.ParentControl = Me.XtraTabPage_StoringPlaceDtl
            CTag23.SkipValidate = False
            CTag23.TimeButtonTextBox = Nothing
            CTag23.ToolTip = ""
            CTag23.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_StoringPlaceDtl.Tag = CTag23
            '
            'GridControl_ViewCurrentStock
            '
            Me.GridControl_ViewCurrentStock.AccessibleDescription = Nothing
            Me.GridControl_ViewCurrentStock.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_ViewCurrentStock, "GridControl_ViewCurrentStock")
            Me.GridControl_ViewCurrentStock.BackgroundImage = Nothing
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_ViewCurrentStock.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_ViewCurrentStock.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_ViewCurrentStock.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.Name = ""
            CTag22.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag22.CalculatorRequired = True
            CTag22.ComboValueTextBox = Nothing
            CTag22.ControlRelatedCode = Nothing
            CTag22.DateButtonTextBox = Nothing
            CTag22.DateTimeButtonTextBox = Nothing
            CTag22.DisplayLinkControl = Nothing
            CTag22.DisplayLinkDisplayFieldName = Nothing
            CTag22.DisplayLinkKeyFieldName = Nothing
            CTag22.DisplayLinkTable = Nothing
            CTag22.FlexgridEditItem = ""
            CTag22.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag22.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag22.IsButtonCustomed = False
            CTag22.IsTextValid = True
            CTag22.KeyValueAbsentable = False
            CTag22.LeagleText = ""
            CTag22.NumericButtonTextBox = Nothing
            CTag22.ParentControl = Me.GridControl_ViewCurrentStock.EmbeddedNavigator
            CTag22.SkipValidate = False
            CTag22.TimeButtonTextBox = Nothing
            CTag22.ToolTip = ""
            CTag22.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.Tag = CTag22
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_ViewCurrentStock.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_ViewCurrentStock.EmbeddedNavigator.ToolTip")
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_ViewCurrentStock.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_ViewCurrentStock.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_ViewCurrentStock.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_ViewCurrentStock.Font = Nothing
            Me.GridControl_ViewCurrentStock.MainView = Me.GridView_ViewCurrentStock
            Me.GridControl_ViewCurrentStock.Name = "GridControl_ViewCurrentStock"
            Me.GridControl_ViewCurrentStock.TabStop = False
            Me.GridControl_ViewCurrentStock.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ViewCurrentStock})
            '
            'GridView_ViewCurrentStock
            '
            resources.ApplyResources(Me.GridView_ViewCurrentStock, "GridView_ViewCurrentStock")
            Me.GridView_ViewCurrentStock.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_VWareCode, Me.GridColumn_VCustomCode, Me.GridColumn_VWareName, Me.GridColumn_VWareNameEn, Me.GridColumn_VSpec, Me.GridColumn_VSpecEn, Me.GridColumn_VModel, Me.GridColumn_VModelEn, Me.GridColumn_VAttribute1, Me.GridColumn_VAttribute2, Me.GridColumn_VAttribute3, Me.GridColumn_VAttribute4, Me.GridColumn_VIOAmount, Me.GridColumn_VUnitName, Me.GridColumn_VRemarks, Me.GridColumn_VRowHighlight})
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_VRowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "SEARCH_MATCH"
            Me.GridView_ViewCurrentStock.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
            Me.GridView_ViewCurrentStock.GridControl = Me.GridControl_ViewCurrentStock
            Me.GridView_ViewCurrentStock.Name = "GridView_ViewCurrentStock"
            Me.GridView_ViewCurrentStock.OptionsView.ColumnAutoWidth = False
            Me.GridView_ViewCurrentStock.OptionsView.ShowFooter = True
            Me.GridView_ViewCurrentStock.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_VWareCode
            '
            resources.ApplyResources(Me.GridColumn_VWareCode, "GridColumn_VWareCode")
            Me.GridColumn_VWareCode.FieldName = "WARE_CODE"
            Me.GridColumn_VWareCode.Name = "GridColumn_VWareCode"
            Me.GridColumn_VWareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_VWareCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_VWareCode.SummaryItem.DisplayFormat")
            Me.GridColumn_VWareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_VCustomCode
            '
            resources.ApplyResources(Me.GridColumn_VCustomCode, "GridColumn_VCustomCode")
            Me.GridColumn_VCustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_VCustomCode.Name = "GridColumn_VCustomCode"
            Me.GridColumn_VCustomCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VWareName
            '
            resources.ApplyResources(Me.GridColumn_VWareName, "GridColumn_VWareName")
            Me.GridColumn_VWareName.FieldName = "WARE_NAME"
            Me.GridColumn_VWareName.Name = "GridColumn_VWareName"
            Me.GridColumn_VWareName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VWareNameEn
            '
            resources.ApplyResources(Me.GridColumn_VWareNameEn, "GridColumn_VWareNameEn")
            Me.GridColumn_VWareNameEn.FieldName = "WARE_NAME_EN"
            Me.GridColumn_VWareNameEn.Name = "GridColumn_VWareNameEn"
            Me.GridColumn_VWareNameEn.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VSpec
            '
            resources.ApplyResources(Me.GridColumn_VSpec, "GridColumn_VSpec")
            Me.GridColumn_VSpec.FieldName = "SPEC"
            Me.GridColumn_VSpec.Name = "GridColumn_VSpec"
            Me.GridColumn_VSpec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VSpecEn
            '
            resources.ApplyResources(Me.GridColumn_VSpecEn, "GridColumn_VSpecEn")
            Me.GridColumn_VSpecEn.FieldName = "SPEC_EN"
            Me.GridColumn_VSpecEn.Name = "GridColumn_VSpecEn"
            Me.GridColumn_VSpecEn.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VModel
            '
            resources.ApplyResources(Me.GridColumn_VModel, "GridColumn_VModel")
            Me.GridColumn_VModel.FieldName = "MODEL"
            Me.GridColumn_VModel.Name = "GridColumn_VModel"
            Me.GridColumn_VModel.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VModelEn
            '
            resources.ApplyResources(Me.GridColumn_VModelEn, "GridColumn_VModelEn")
            Me.GridColumn_VModelEn.FieldName = "MODEL_EN"
            Me.GridColumn_VModelEn.Name = "GridColumn_VModelEn"
            Me.GridColumn_VModelEn.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VAttribute1
            '
            resources.ApplyResources(Me.GridColumn_VAttribute1, "GridColumn_VAttribute1")
            Me.GridColumn_VAttribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_VAttribute1.Name = "GridColumn_VAttribute1"
            Me.GridColumn_VAttribute1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VAttribute2
            '
            resources.ApplyResources(Me.GridColumn_VAttribute2, "GridColumn_VAttribute2")
            Me.GridColumn_VAttribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_VAttribute2.Name = "GridColumn_VAttribute2"
            Me.GridColumn_VAttribute2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VAttribute3
            '
            resources.ApplyResources(Me.GridColumn_VAttribute3, "GridColumn_VAttribute3")
            Me.GridColumn_VAttribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_VAttribute3.Name = "GridColumn_VAttribute3"
            Me.GridColumn_VAttribute3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VAttribute4
            '
            resources.ApplyResources(Me.GridColumn_VAttribute4, "GridColumn_VAttribute4")
            Me.GridColumn_VAttribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_VAttribute4.Name = "GridColumn_VAttribute4"
            Me.GridColumn_VAttribute4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VIOAmount
            '
            resources.ApplyResources(Me.GridColumn_VIOAmount, "GridColumn_VIOAmount")
            Me.GridColumn_VIOAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_VIOAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_VIOAmount.FieldName = "LOCATION_STOCK_AMOUNT"
            Me.GridColumn_VIOAmount.Name = "GridColumn_VIOAmount"
            Me.GridColumn_VIOAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_VIOAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_VIOAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_VIOAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_VUnitName
            '
            resources.ApplyResources(Me.GridColumn_VUnitName, "GridColumn_VUnitName")
            Me.GridColumn_VUnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_VUnitName.Name = "GridColumn_VUnitName"
            Me.GridColumn_VUnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VRemarks
            '
            resources.ApplyResources(Me.GridColumn_VRemarks, "GridColumn_VRemarks")
            Me.GridColumn_VRemarks.FieldName = "REMARK"
            Me.GridColumn_VRemarks.Name = "GridColumn_VRemarks"
            Me.GridColumn_VRemarks.OptionsColumn.AllowFocus = False
            '
            'GridColumn_VRowHighlight
            '
            resources.ApplyResources(Me.GridColumn_VRowHighlight, "GridColumn_VRowHighlight")
            Me.GridColumn_VRowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_VRowHighlight.Name = "GridColumn_VRowHighlight"
            Me.GridColumn_VRowHighlight.OptionsColumn.AllowFocus = False
            '
            'XtraTabPage_InventoryDifference
            '
            Me.XtraTabPage_InventoryDifference.AccessibleDescription = Nothing
            Me.XtraTabPage_InventoryDifference.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabPage_InventoryDifference, "XtraTabPage_InventoryDifference")
            Me.XtraTabPage_InventoryDifference.BackgroundImage = Nothing
            Me.XtraTabPage_InventoryDifference.Controls.Add(Me.GridControl_ShelfStockDifference)
            Me.XtraTabPage_InventoryDifference.Font = Nothing
            Me.XtraTabPage_InventoryDifference.Name = "XtraTabPage_InventoryDifference"
            Me.XtraTabPage_InventoryDifference.PageVisible = False
            CTag25.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag25.CalculatorRequired = True
            CTag25.ComboValueTextBox = Nothing
            CTag25.ControlRelatedCode = Nothing
            CTag25.DateButtonTextBox = Nothing
            CTag25.DateTimeButtonTextBox = Nothing
            CTag25.DisplayLinkControl = Nothing
            CTag25.DisplayLinkDisplayFieldName = Nothing
            CTag25.DisplayLinkKeyFieldName = Nothing
            CTag25.DisplayLinkTable = Nothing
            CTag25.FlexgridEditItem = ""
            CTag25.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag25.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag25.IsButtonCustomed = False
            CTag25.IsTextValid = True
            CTag25.KeyValueAbsentable = False
            CTag25.LeagleText = ""
            CTag25.NumericButtonTextBox = Nothing
            CTag25.ParentControl = Me.XtraTabPage_InventoryDifference
            CTag25.SkipValidate = False
            CTag25.TimeButtonTextBox = Nothing
            CTag25.ToolTip = ""
            CTag25.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_InventoryDifference.Tag = CTag25
            '
            'GridControl_ShelfStockDifference
            '
            Me.GridControl_ShelfStockDifference.AccessibleDescription = Nothing
            Me.GridControl_ShelfStockDifference.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_ShelfStockDifference, "GridControl_ShelfStockDifference")
            Me.GridControl_ShelfStockDifference.BackgroundImage = Nothing
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_ShelfStockDifference.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_ShelfStockDifference.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_ShelfStockDifference.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.Name = ""
            CTag24.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag24.CalculatorRequired = True
            CTag24.ComboValueTextBox = Nothing
            CTag24.ControlRelatedCode = Nothing
            CTag24.DateButtonTextBox = Nothing
            CTag24.DateTimeButtonTextBox = Nothing
            CTag24.DisplayLinkControl = Nothing
            CTag24.DisplayLinkDisplayFieldName = Nothing
            CTag24.DisplayLinkKeyFieldName = Nothing
            CTag24.DisplayLinkTable = Nothing
            CTag24.FlexgridEditItem = ""
            CTag24.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag24.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag24.IsButtonCustomed = False
            CTag24.IsTextValid = True
            CTag24.KeyValueAbsentable = False
            CTag24.LeagleText = ""
            CTag24.NumericButtonTextBox = Nothing
            CTag24.ParentControl = Me.GridControl_ShelfStockDifference.EmbeddedNavigator
            CTag24.SkipValidate = False
            CTag24.TimeButtonTextBox = Nothing
            CTag24.ToolTip = ""
            CTag24.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.Tag = CTag24
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_ShelfStockDifference.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_ShelfStockDifference.EmbeddedNavigator.ToolTip")
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_ShelfStockDifference.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_ShelfStockDifference.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_ShelfStockDifference.Font = Nothing
            Me.GridControl_ShelfStockDifference.MainView = Me.GridView_ShelfStockDifference
            Me.GridControl_ShelfStockDifference.Name = "GridControl_ShelfStockDifference"
            Me.GridControl_ShelfStockDifference.TabStop = False
            Me.GridControl_ShelfStockDifference.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ShelfStockDifference})
            '
            'GridView_ShelfStockDifference
            '
            resources.ApplyResources(Me.GridView_ShelfStockDifference, "GridView_ShelfStockDifference")
            Me.GridView_ShelfStockDifference.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_SWareCode, Me.GridColumn_SCustomCode, Me.GridColumn_SWareName, Me.GridColumn_SWareNameEn, Me.GridColumn_SSpec, Me.GridColumn_SSpecEn, Me.GridColumn_SModel, Me.GridColumn_SModelEn, Me.GridColumn_SAttribute1, Me.GridColumn_SAttribute2, Me.GridColumn_SAttribute3, Me.GridColumn_SAttribute4, Me.GridColumn_SelfAmount, Me.GridColumn_PosAmount, Me.GridColumn_DifferenceAmount, Me.GridColumn_SUnitName, Me.GridColumn_SRemarks, Me.GridColumn_SRowHighlight})
            StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition3.Appearance.Options.UseBackColor = True
            StyleFormatCondition3.ApplyToRow = True
            StyleFormatCondition3.Column = Me.GridColumn_SRowHighlight
            StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition3.Value1 = "SEARCH_MATCH"
            StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Blue
            StyleFormatCondition4.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition4.Appearance.Options.UseBackColor = True
            StyleFormatCondition4.ApplyToRow = True
            StyleFormatCondition4.Column = Me.GridColumn_DifferenceAmount
            StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
            StyleFormatCondition4.Value1 = 0
            StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.Red
            StyleFormatCondition5.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition5.Appearance.Options.UseBackColor = True
            StyleFormatCondition5.ApplyToRow = True
            StyleFormatCondition5.Column = Me.GridColumn_DifferenceAmount
            StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
            StyleFormatCondition5.Value1 = 0
            Me.GridView_ShelfStockDifference.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5})
            Me.GridView_ShelfStockDifference.GridControl = Me.GridControl_ShelfStockDifference
            Me.GridView_ShelfStockDifference.Name = "GridView_ShelfStockDifference"
            Me.GridView_ShelfStockDifference.OptionsView.ColumnAutoWidth = False
            Me.GridView_ShelfStockDifference.OptionsView.ShowFooter = True
            Me.GridView_ShelfStockDifference.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_SWareCode
            '
            resources.ApplyResources(Me.GridColumn_SWareCode, "GridColumn_SWareCode")
            Me.GridColumn_SWareCode.FieldName = "WARE_CODE"
            Me.GridColumn_SWareCode.Name = "GridColumn_SWareCode"
            Me.GridColumn_SWareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_SWareCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_SWareCode.SummaryItem.DisplayFormat")
            Me.GridColumn_SWareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_SCustomCode
            '
            resources.ApplyResources(Me.GridColumn_SCustomCode, "GridColumn_SCustomCode")
            Me.GridColumn_SCustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_SCustomCode.Name = "GridColumn_SCustomCode"
            Me.GridColumn_SCustomCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SWareName
            '
            resources.ApplyResources(Me.GridColumn_SWareName, "GridColumn_SWareName")
            Me.GridColumn_SWareName.FieldName = "WARE_NAME"
            Me.GridColumn_SWareName.Name = "GridColumn_SWareName"
            Me.GridColumn_SWareName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SWareNameEn
            '
            resources.ApplyResources(Me.GridColumn_SWareNameEn, "GridColumn_SWareNameEn")
            Me.GridColumn_SWareNameEn.FieldName = "WARE_NAME_EN"
            Me.GridColumn_SWareNameEn.Name = "GridColumn_SWareNameEn"
            Me.GridColumn_SWareNameEn.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SSpec
            '
            resources.ApplyResources(Me.GridColumn_SSpec, "GridColumn_SSpec")
            Me.GridColumn_SSpec.FieldName = "SPEC"
            Me.GridColumn_SSpec.Name = "GridColumn_SSpec"
            Me.GridColumn_SSpec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SSpecEn
            '
            resources.ApplyResources(Me.GridColumn_SSpecEn, "GridColumn_SSpecEn")
            Me.GridColumn_SSpecEn.FieldName = "SPEC_EN"
            Me.GridColumn_SSpecEn.Name = "GridColumn_SSpecEn"
            Me.GridColumn_SSpecEn.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SModel
            '
            resources.ApplyResources(Me.GridColumn_SModel, "GridColumn_SModel")
            Me.GridColumn_SModel.FieldName = "MODEL"
            Me.GridColumn_SModel.Name = "GridColumn_SModel"
            Me.GridColumn_SModel.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SModelEn
            '
            resources.ApplyResources(Me.GridColumn_SModelEn, "GridColumn_SModelEn")
            Me.GridColumn_SModelEn.FieldName = "MODEL_EN"
            Me.GridColumn_SModelEn.Name = "GridColumn_SModelEn"
            Me.GridColumn_SModelEn.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SAttribute1
            '
            resources.ApplyResources(Me.GridColumn_SAttribute1, "GridColumn_SAttribute1")
            Me.GridColumn_SAttribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_SAttribute1.Name = "GridColumn_SAttribute1"
            Me.GridColumn_SAttribute1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SAttribute2
            '
            resources.ApplyResources(Me.GridColumn_SAttribute2, "GridColumn_SAttribute2")
            Me.GridColumn_SAttribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_SAttribute2.Name = "GridColumn_SAttribute2"
            Me.GridColumn_SAttribute2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SAttribute3
            '
            resources.ApplyResources(Me.GridColumn_SAttribute3, "GridColumn_SAttribute3")
            Me.GridColumn_SAttribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_SAttribute3.Name = "GridColumn_SAttribute3"
            Me.GridColumn_SAttribute3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SAttribute4
            '
            resources.ApplyResources(Me.GridColumn_SAttribute4, "GridColumn_SAttribute4")
            Me.GridColumn_SAttribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_SAttribute4.Name = "GridColumn_SAttribute4"
            Me.GridColumn_SAttribute4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SelfAmount
            '
            resources.ApplyResources(Me.GridColumn_SelfAmount, "GridColumn_SelfAmount")
            Me.GridColumn_SelfAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SelfAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SelfAmount.FieldName = "SHELF_AMOUNT"
            Me.GridColumn_SelfAmount.Name = "GridColumn_SelfAmount"
            Me.GridColumn_SelfAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_SelfAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_SelfAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_SelfAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_PosAmount
            '
            resources.ApplyResources(Me.GridColumn_PosAmount, "GridColumn_PosAmount")
            Me.GridColumn_PosAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_PosAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_PosAmount.FieldName = "POS_AMOUNT"
            Me.GridColumn_PosAmount.Name = "GridColumn_PosAmount"
            Me.GridColumn_PosAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_PosAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_PosAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_PosAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_DifferenceAmount
            '
            resources.ApplyResources(Me.GridColumn_DifferenceAmount, "GridColumn_DifferenceAmount")
            Me.GridColumn_DifferenceAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_DifferenceAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_DifferenceAmount.FieldName = "DIFFERENCE_AMOUNT"
            Me.GridColumn_DifferenceAmount.Name = "GridColumn_DifferenceAmount"
            Me.GridColumn_DifferenceAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_DifferenceAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_DifferenceAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_DifferenceAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_SUnitName
            '
            resources.ApplyResources(Me.GridColumn_SUnitName, "GridColumn_SUnitName")
            Me.GridColumn_SUnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_SUnitName.Name = "GridColumn_SUnitName"
            Me.GridColumn_SUnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SRemarks
            '
            resources.ApplyResources(Me.GridColumn_SRemarks, "GridColumn_SRemarks")
            Me.GridColumn_SRemarks.FieldName = "REMARK"
            Me.GridColumn_SRemarks.Name = "GridColumn_SRemarks"
            Me.GridColumn_SRemarks.OptionsColumn.AllowFocus = False
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
            'M_02_00601
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.XtraTabControl_Lists)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_00601"
            CTag27.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag27.CalculatorRequired = True
            CTag27.ComboValueTextBox = Nothing
            CTag27.ControlRelatedCode = Nothing
            CTag27.DateButtonTextBox = Nothing
            CTag27.DateTimeButtonTextBox = Nothing
            CTag27.DisplayLinkControl = Nothing
            CTag27.DisplayLinkDisplayFieldName = Nothing
            CTag27.DisplayLinkKeyFieldName = Nothing
            CTag27.DisplayLinkTable = Nothing
            CTag27.FlexgridEditItem = ""
            CTag27.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag27.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag27.IsButtonCustomed = False
            CTag27.IsTextValid = True
            CTag27.KeyValueAbsentable = False
            CTag27.LeagleText = ""
            CTag27.NumericButtonTextBox = Nothing
            CTag27.ParentControl = Me
            CTag27.SkipValidate = False
            CTag27.TimeButtonTextBox = Nothing
            CTag27.ToolTip = ""
            CTag27.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag27
            CType(Me.GridControl_Operation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Operation, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.Panel_LocationIO, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel_LocationIO.ResumeLayout(False)
            Me.Panel_LocationIO.PerformLayout()
            CType(Me.LookUpEdit_IOType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_LocationCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl_Lists, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl_Lists.ResumeLayout(False)
            Me.XtraTabPage_Operations.ResumeLayout(False)
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl2.ResumeLayout(False)
            Me.PanelControl2.PerformLayout()
            CType(Me.CheckEdit_AutoSaveAlteringLot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_ShowDetailInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage_StoringPlaceDtl.ResumeLayout(False)
            CType(Me.GridControl_ViewCurrentStock, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ViewCurrentStock, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage_InventoryDifference.ResumeLayout(False)
            CType(Me.GridControl_ShelfStockDifference, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ShelfStockDifference, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents Panel_LocationIO As DevExpress.XtraEditors.PanelControl
        Friend WithEvents LookUpEdit_Pos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label_EmployeeID As System.Windows.Forms.Label
        Friend WithEvents Label_StoringPlaceInfo As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_LocationCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_IOType As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label_InOutMode As System.Windows.Forms.Label
        Friend WithEvents XtraTabControl_Lists As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage_Operations As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage_StoringPlaceDtl As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage_InventoryDifference As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents CheckEdit_ShowDetailInput As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents Label_WareID As System.Windows.Forms.Label
        Friend WithEvents Label_CustomCode As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_WareCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents GridControl_Operation As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Operation As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareNameEn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SpecEn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ModelEn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_IOAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowRemark As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_ViewCurrentStock As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ViewCurrentStock As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_VWareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VCustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VWareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VWareNameEn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VSpec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VSpecEn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VModelEn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VAttribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VAttribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VAttribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VAttribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VIOAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VUnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VRowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_ShelfStockDifference As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ShelfStockDifference As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_SWareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SCustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SWareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SWareNameEn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SSpec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SSpecEn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SModelEn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SAttribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SAttribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SAttribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SAttribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SelfAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SUnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SRowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PosAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_DifferenceAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ToolStripButton_ViewHistory As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_ImportMobile As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents Label_LocationID As System.Windows.Forms.Label
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents CheckEdit_AutoSaveAlteringLot As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_VRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SRemarks As DevExpress.XtraGrid.Columns.GridColumn

#End Region

    End Class

End Namespace
