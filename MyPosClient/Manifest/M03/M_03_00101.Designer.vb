Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_00101
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
        Friend WithEvents ToolStripButton_PrintReport As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_00101))
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition8 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Choose = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_PrintReport = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ViewTurnoverDtl = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_SingleWareLocations = New DevExpress.XtraEditors.CheckEdit
            Me.LookUpEdit_Pos = New DevExpress.XtraEditors.LookUpEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.XtraTabControl_Lists = New DevExpress.XtraTab.XtraTabControl
            Me.XtraTabPage_NormalList = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_NormalList = New DevExpress.XtraGrid.GridControl
            Me.GridView_NormalList = New DevExpress.XtraGrid.Views.Grid.GridView
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
            Me.GridColumn_LowerLimit = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_LackAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ConsignOutRemains = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ConsignInRemains = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.XtraTabPage_ShelfPosDifference = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_ShelfStockDifference = New DevExpress.XtraGrid.GridControl
            Me.GridView_ShelfStockDifference = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_SWareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SCustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SWareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SSpec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SModel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SAttribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SAttribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SAttribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SAttribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SelfAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PosAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_DifferenceAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SUnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SRemark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SRowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.XtraTabPage_BatchList = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_BatchWareList = New DevExpress.XtraGrid.GridControl
            Me.GridView_BatchWareList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_BatchCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BWareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BCustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BWareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BSpec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BModel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BAtrribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BAtrribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BAtrribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BAtrribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BCurrentAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BUnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BRemark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BRowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.XtraTabPage_ShelfAmount = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_ShelfAmount = New DevExpress.XtraGrid.GridControl
            Me.GridView_ShelfList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_ShelfWareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfCustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfWareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfSpec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfModel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfAttribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfAttribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfAttribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfAttribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_LocationCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_LocationStockAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfUnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfRemark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfRowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.CheckEdit_SingleWareLocations.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl_Lists, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl_Lists.SuspendLayout()
            Me.XtraTabPage_NormalList.SuspendLayout()
            CType(Me.GridControl_NormalList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_NormalList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage_ShelfPosDifference.SuspendLayout()
            CType(Me.GridControl_ShelfStockDifference, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ShelfStockDifference, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage_BatchList.SuspendLayout()
            CType(Me.GridControl_BatchWareList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_BatchWareList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage_ShelfAmount.SuspendLayout()
            CType(Me.GridControl_ShelfAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ShelfList, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Choose, Me.ToolStripButton_Refresh, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_PrintReport, Me.ToolStripButton_ViewTurnoverDtl, Me.ToolStripButton_View, Me.ToolStripButton_Close})
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
            'ToolStripButton_Choose
            '
            Me.ToolStripButton_Choose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_Choose, "ToolStripButton_Choose")
            Me.ToolStripButton_Choose.Name = "ToolStripButton_Choose"
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
            'ToolStripButton_PrintReport
            '
            Me.ToolStripButton_PrintReport.Name = "ToolStripButton_PrintReport"
            resources.ApplyResources(Me.ToolStripButton_PrintReport, "ToolStripButton_PrintReport")
            '
            'ToolStripButton_ViewTurnoverDtl
            '
            Me.ToolStripButton_ViewTurnoverDtl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_ViewTurnoverDtl, "ToolStripButton_ViewTurnoverDtl")
            Me.ToolStripButton_ViewTurnoverDtl.Name = "ToolStripButton_ViewTurnoverDtl"
            '
            'ToolStripButton_View
            '
            Me.ToolStripButton_View.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
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
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_SingleWareLocations)
            Me.PanelControl_Filter.Controls.Add(Me.LookUpEdit_Pos)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
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
            'CheckEdit_SingleWareLocations
            '
            resources.ApplyResources(Me.CheckEdit_SingleWareLocations, "CheckEdit_SingleWareLocations")
            Me.CheckEdit_SingleWareLocations.Name = "CheckEdit_SingleWareLocations"
            Me.CheckEdit_SingleWareLocations.Properties.Caption = resources.GetString("CheckEdit_SingleWareLocations.Properties.Caption")
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
            CTag2.ParentControl = Me.CheckEdit_SingleWareLocations
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_SingleWareLocations.Tag = CTag2
            '
            'LookUpEdit_Pos
            '
            resources.ApplyResources(Me.LookUpEdit_Pos, "LookUpEdit_Pos")
            Me.LookUpEdit_Pos.Name = "LookUpEdit_Pos"
            Me.LookUpEdit_Pos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_Pos.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_Pos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Pos.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_Pos.Properties.ValueMember = "POS_ID"
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
            CTag3.ParentControl = Me.LookUpEdit_Pos
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_Pos.Tag = CTag3
            '
            'Label2
            '
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
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
            CTag4.ParentControl = Me.Label2
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag4
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
            'XtraTabControl_Lists
            '
            resources.ApplyResources(Me.XtraTabControl_Lists, "XtraTabControl_Lists")
            Me.XtraTabControl_Lists.Name = "XtraTabControl_Lists"
            Me.XtraTabControl_Lists.SelectedTabPage = Me.XtraTabPage_NormalList
            Me.XtraTabControl_Lists.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage_NormalList, Me.XtraTabPage_ShelfPosDifference, Me.XtraTabPage_BatchList, Me.XtraTabPage_ShelfAmount})
            Me.XtraTabControl_Lists.TabStop = False
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
            CTag12.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag12.IsButtonCustomed = False
            CTag12.IsTextValid = True
            CTag12.KeyValueAbsentable = False
            CTag12.LeagleText = ""
            CTag12.NumericButtonTextBox = Nothing
            CTag12.ParentControl = Me.XtraTabControl_Lists
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabControl_Lists.Tag = CTag12
            '
            'XtraTabPage_NormalList
            '
            Me.XtraTabPage_NormalList.Controls.Add(Me.GridControl_NormalList)
            Me.XtraTabPage_NormalList.Name = "XtraTabPage_NormalList"
            resources.ApplyResources(Me.XtraTabPage_NormalList, "XtraTabPage_NormalList")
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
            CTag8.ParentControl = Me.XtraTabPage_NormalList
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_NormalList.Tag = CTag8
            '
            'GridControl_NormalList
            '
            resources.ApplyResources(Me.GridControl_NormalList, "GridControl_NormalList")
            Me.GridControl_NormalList.EmbeddedNavigator.Name = ""
            Me.GridControl_NormalList.MainView = Me.GridView_NormalList
            Me.GridControl_NormalList.Name = "GridControl_NormalList"
            Me.GridControl_NormalList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_NormalList})
            '
            'GridView_NormalList
            '
            Me.GridView_NormalList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_CurrentAmount, Me.GridColumn_CurrentCost, Me.GridColumn_CurrentOrigionSumPrice, Me.GridColumn_LowerLimit, Me.GridColumn_LackAmount, Me.GridColumn_ConsignOutRemains, Me.GridColumn_ConsignInRemains, Me.GridColumn_UnitName, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
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
            Me.GridView_NormalList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.GridView_NormalList.GridControl = Me.GridControl_NormalList
            Me.GridView_NormalList.Name = "GridView_NormalList"
            Me.GridView_NormalList.OptionsView.ColumnAutoWidth = False
            Me.GridView_NormalList.OptionsView.ShowFooter = True
            Me.GridView_NormalList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_WareCode
            '
            resources.ApplyResources(Me.GridColumn_WareCode, "GridColumn_WareCode")
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowEdit = False
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
            Me.GridColumn_CurrentOrigionSumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_LowerLimit
            '
            resources.ApplyResources(Me.GridColumn_LowerLimit, "GridColumn_LowerLimit")
            Me.GridColumn_LowerLimit.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_LowerLimit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_LowerLimit.FieldName = "LOWER_LIMIT"
            Me.GridColumn_LowerLimit.Name = "GridColumn_LowerLimit"
            Me.GridColumn_LowerLimit.OptionsColumn.AllowFocus = False
            '
            'GridColumn_LackAmount
            '
            resources.ApplyResources(Me.GridColumn_LackAmount, "GridColumn_LackAmount")
            Me.GridColumn_LackAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_LackAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_LackAmount.FieldName = "LACK_AMOUNT"
            Me.GridColumn_LackAmount.Name = "GridColumn_LackAmount"
            Me.GridColumn_LackAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_LackAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_ConsignOutRemains
            '
            resources.ApplyResources(Me.GridColumn_ConsignOutRemains, "GridColumn_ConsignOutRemains")
            Me.GridColumn_ConsignOutRemains.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_ConsignOutRemains.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_ConsignOutRemains.FieldName = "CONSIGN_OUT_LACK_AMOUNT"
            Me.GridColumn_ConsignOutRemains.Name = "GridColumn_ConsignOutRemains"
            Me.GridColumn_ConsignOutRemains.OptionsColumn.AllowFocus = False
            Me.GridColumn_ConsignOutRemains.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_ConsignInRemains
            '
            resources.ApplyResources(Me.GridColumn_ConsignInRemains, "GridColumn_ConsignInRemains")
            Me.GridColumn_ConsignInRemains.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_ConsignInRemains.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_ConsignInRemains.FieldName = "CONSIGN_IN_LACK_AMOUNT"
            Me.GridColumn_ConsignInRemains.Name = "GridColumn_ConsignInRemains"
            Me.GridColumn_ConsignInRemains.OptionsColumn.AllowFocus = False
            Me.GridColumn_ConsignInRemains.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
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
            'XtraTabPage_ShelfPosDifference
            '
            Me.XtraTabPage_ShelfPosDifference.Controls.Add(Me.GridControl_ShelfStockDifference)
            Me.XtraTabPage_ShelfPosDifference.Name = "XtraTabPage_ShelfPosDifference"
            resources.ApplyResources(Me.XtraTabPage_ShelfPosDifference, "XtraTabPage_ShelfPosDifference")
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
            CTag9.ParentControl = Me.XtraTabPage_ShelfPosDifference
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_ShelfPosDifference.Tag = CTag9
            '
            'GridControl_ShelfStockDifference
            '
            resources.ApplyResources(Me.GridControl_ShelfStockDifference, "GridControl_ShelfStockDifference")
            Me.GridControl_ShelfStockDifference.EmbeddedNavigator.Name = ""
            Me.GridControl_ShelfStockDifference.MainView = Me.GridView_ShelfStockDifference
            Me.GridControl_ShelfStockDifference.Name = "GridControl_ShelfStockDifference"
            Me.GridControl_ShelfStockDifference.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ShelfStockDifference})
            '
            'GridView_ShelfStockDifference
            '
            Me.GridView_ShelfStockDifference.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_SWareCode, Me.GridColumn_SCustomCode, Me.GridColumn_SWareName, Me.GridColumn_SSpec, Me.GridColumn_SModel, Me.GridColumn_SAttribute1, Me.GridColumn_SAttribute2, Me.GridColumn_SAttribute3, Me.GridColumn_SAttribute4, Me.GridColumn_SelfAmount, Me.GridColumn_PosAmount, Me.GridColumn_DifferenceAmount, Me.GridColumn_SUnitName, Me.GridColumn_SRemark, Me.GridColumn_SRowHighlight})
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
            Me.GridColumn_SWareCode.OptionsColumn.AllowEdit = False
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
            'GridColumn_SSpec
            '
            resources.ApplyResources(Me.GridColumn_SSpec, "GridColumn_SSpec")
            Me.GridColumn_SSpec.FieldName = "SPEC"
            Me.GridColumn_SSpec.Name = "GridColumn_SSpec"
            Me.GridColumn_SSpec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SModel
            '
            resources.ApplyResources(Me.GridColumn_SModel, "GridColumn_SModel")
            Me.GridColumn_SModel.FieldName = "MODEL"
            Me.GridColumn_SModel.Name = "GridColumn_SModel"
            Me.GridColumn_SModel.OptionsColumn.AllowFocus = False
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
            Me.GridColumn_DifferenceAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_SUnitName
            '
            resources.ApplyResources(Me.GridColumn_SUnitName, "GridColumn_SUnitName")
            Me.GridColumn_SUnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_SUnitName.Name = "GridColumn_SUnitName"
            Me.GridColumn_SUnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SRemark
            '
            resources.ApplyResources(Me.GridColumn_SRemark, "GridColumn_SRemark")
            Me.GridColumn_SRemark.FieldName = "REMARK"
            Me.GridColumn_SRemark.Name = "GridColumn_SRemark"
            Me.GridColumn_SRemark.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SRowHighlight
            '
            resources.ApplyResources(Me.GridColumn_SRowHighlight, "GridColumn_SRowHighlight")
            Me.GridColumn_SRowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_SRowHighlight.Name = "GridColumn_SRowHighlight"
            Me.GridColumn_SRowHighlight.OptionsColumn.AllowFocus = False
            '
            'XtraTabPage_BatchList
            '
            Me.XtraTabPage_BatchList.Controls.Add(Me.GridControl_BatchWareList)
            Me.XtraTabPage_BatchList.Name = "XtraTabPage_BatchList"
            resources.ApplyResources(Me.XtraTabPage_BatchList, "XtraTabPage_BatchList")
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
            CTag10.ParentControl = Me.XtraTabPage_BatchList
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_BatchList.Tag = CTag10
            '
            'GridControl_BatchWareList
            '
            resources.ApplyResources(Me.GridControl_BatchWareList, "GridControl_BatchWareList")
            Me.GridControl_BatchWareList.EmbeddedNavigator.Name = ""
            Me.GridControl_BatchWareList.MainView = Me.GridView_BatchWareList
            Me.GridControl_BatchWareList.Name = "GridControl_BatchWareList"
            Me.GridControl_BatchWareList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_BatchWareList})
            '
            'GridView_BatchWareList
            '
            Me.GridView_BatchWareList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_BatchCode, Me.GridColumn_BWareCode, Me.GridColumn_BCustomCode, Me.GridColumn_BWareName, Me.GridColumn_BSpec, Me.GridColumn_BModel, Me.GridColumn_BAtrribute1, Me.GridColumn_BAtrribute2, Me.GridColumn_BAtrribute3, Me.GridColumn_BAtrribute4, Me.GridColumn_BCurrentAmount, Me.GridColumn_BUnitName, Me.GridColumn_BRemark, Me.GridColumn_BRowHighlight})
            StyleFormatCondition6.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition6.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition6.Appearance.Options.UseBackColor = True
            StyleFormatCondition6.ApplyToRow = True
            StyleFormatCondition6.Column = Me.GridColumn_BRowHighlight
            StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition6.Value1 = "SEARCH_MATCH"
            Me.GridView_BatchWareList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition6})
            Me.GridView_BatchWareList.GridControl = Me.GridControl_BatchWareList
            Me.GridView_BatchWareList.Name = "GridView_BatchWareList"
            Me.GridView_BatchWareList.OptionsView.ColumnAutoWidth = False
            Me.GridView_BatchWareList.OptionsView.ShowFooter = True
            Me.GridView_BatchWareList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_BatchCode
            '
            resources.ApplyResources(Me.GridColumn_BatchCode, "GridColumn_BatchCode")
            Me.GridColumn_BatchCode.FieldName = "BATCH_CODE"
            Me.GridColumn_BatchCode.Name = "GridColumn_BatchCode"
            Me.GridColumn_BatchCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BWareCode
            '
            resources.ApplyResources(Me.GridColumn_BWareCode, "GridColumn_BWareCode")
            Me.GridColumn_BWareCode.FieldName = "WARE_CODE"
            Me.GridColumn_BWareCode.Name = "GridColumn_BWareCode"
            Me.GridColumn_BWareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_BWareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_BCustomCode
            '
            resources.ApplyResources(Me.GridColumn_BCustomCode, "GridColumn_BCustomCode")
            Me.GridColumn_BCustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_BCustomCode.Name = "GridColumn_BCustomCode"
            Me.GridColumn_BCustomCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BWareName
            '
            resources.ApplyResources(Me.GridColumn_BWareName, "GridColumn_BWareName")
            Me.GridColumn_BWareName.FieldName = "WARE_NAME"
            Me.GridColumn_BWareName.Name = "GridColumn_BWareName"
            Me.GridColumn_BWareName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BSpec
            '
            resources.ApplyResources(Me.GridColumn_BSpec, "GridColumn_BSpec")
            Me.GridColumn_BSpec.FieldName = "SPEC"
            Me.GridColumn_BSpec.Name = "GridColumn_BSpec"
            Me.GridColumn_BSpec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BModel
            '
            resources.ApplyResources(Me.GridColumn_BModel, "GridColumn_BModel")
            Me.GridColumn_BModel.FieldName = "MODEL"
            Me.GridColumn_BModel.Name = "GridColumn_BModel"
            Me.GridColumn_BModel.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BAtrribute1
            '
            resources.ApplyResources(Me.GridColumn_BAtrribute1, "GridColumn_BAtrribute1")
            Me.GridColumn_BAtrribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_BAtrribute1.Name = "GridColumn_BAtrribute1"
            Me.GridColumn_BAtrribute1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BAtrribute2
            '
            resources.ApplyResources(Me.GridColumn_BAtrribute2, "GridColumn_BAtrribute2")
            Me.GridColumn_BAtrribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_BAtrribute2.Name = "GridColumn_BAtrribute2"
            Me.GridColumn_BAtrribute2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BAtrribute3
            '
            resources.ApplyResources(Me.GridColumn_BAtrribute3, "GridColumn_BAtrribute3")
            Me.GridColumn_BAtrribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_BAtrribute3.Name = "GridColumn_BAtrribute3"
            Me.GridColumn_BAtrribute3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BAtrribute4
            '
            resources.ApplyResources(Me.GridColumn_BAtrribute4, "GridColumn_BAtrribute4")
            Me.GridColumn_BAtrribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_BAtrribute4.Name = "GridColumn_BAtrribute4"
            Me.GridColumn_BAtrribute4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BCurrentAmount
            '
            resources.ApplyResources(Me.GridColumn_BCurrentAmount, "GridColumn_BCurrentAmount")
            Me.GridColumn_BCurrentAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_BCurrentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_BCurrentAmount.FieldName = "CURRENT_AMOUNT"
            Me.GridColumn_BCurrentAmount.Name = "GridColumn_BCurrentAmount"
            Me.GridColumn_BCurrentAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_BCurrentAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_BUnitName
            '
            resources.ApplyResources(Me.GridColumn_BUnitName, "GridColumn_BUnitName")
            Me.GridColumn_BUnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_BUnitName.Name = "GridColumn_BUnitName"
            Me.GridColumn_BUnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BRemark
            '
            resources.ApplyResources(Me.GridColumn_BRemark, "GridColumn_BRemark")
            Me.GridColumn_BRemark.FieldName = "REMARK"
            Me.GridColumn_BRemark.Name = "GridColumn_BRemark"
            Me.GridColumn_BRemark.OptionsColumn.AllowFocus = False
            '
            'GridColumn_BRowHighlight
            '
            resources.ApplyResources(Me.GridColumn_BRowHighlight, "GridColumn_BRowHighlight")
            Me.GridColumn_BRowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_BRowHighlight.Name = "GridColumn_BRowHighlight"
            Me.GridColumn_BRowHighlight.OptionsColumn.AllowFocus = False
            '
            'XtraTabPage_ShelfAmount
            '
            Me.XtraTabPage_ShelfAmount.Controls.Add(Me.GridControl_ShelfAmount)
            Me.XtraTabPage_ShelfAmount.Name = "XtraTabPage_ShelfAmount"
            resources.ApplyResources(Me.XtraTabPage_ShelfAmount, "XtraTabPage_ShelfAmount")
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
            CTag11.ParentControl = Me.XtraTabPage_ShelfAmount
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_ShelfAmount.Tag = CTag11
            '
            'GridControl_ShelfAmount
            '
            resources.ApplyResources(Me.GridControl_ShelfAmount, "GridControl_ShelfAmount")
            Me.GridControl_ShelfAmount.EmbeddedNavigator.Name = ""
            Me.GridControl_ShelfAmount.MainView = Me.GridView_ShelfList
            Me.GridControl_ShelfAmount.Name = "GridControl_ShelfAmount"
            Me.GridControl_ShelfAmount.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ShelfList})
            '
            'GridView_ShelfList
            '
            Me.GridView_ShelfList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_ShelfWareCode, Me.GridColumn_ShelfCustomCode, Me.GridColumn_ShelfWareName, Me.GridColumn_ShelfSpec, Me.GridColumn_ShelfModel, Me.GridColumn_ShelfAttribute1, Me.GridColumn_ShelfAttribute2, Me.GridColumn_ShelfAttribute3, Me.GridColumn_ShelfAttribute4, Me.GridColumn_ShelfCode, Me.GridColumn_LocationCode, Me.GridColumn_LocationStockAmount, Me.GridColumn_ShelfUnitName, Me.GridColumn_ShelfRemark, Me.GridColumn_ShelfRowHighlight})
            StyleFormatCondition7.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition7.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition7.Appearance.Options.UseBackColor = True
            StyleFormatCondition7.ApplyToRow = True
            StyleFormatCondition7.Column = Me.GridColumn_ShelfRowHighlight
            StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition7.Value1 = "SEARCH_MATCH"
            StyleFormatCondition8.Appearance.BackColor = System.Drawing.Color.Red
            StyleFormatCondition8.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition8.Appearance.Options.UseBackColor = True
            StyleFormatCondition8.ApplyToRow = True
            StyleFormatCondition8.Column = Me.GridColumn_ShelfRowHighlight
            StyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition8.Value1 = "CURRENT_AMOUNT"
            Me.GridView_ShelfList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition7, StyleFormatCondition8})
            Me.GridView_ShelfList.GridControl = Me.GridControl_ShelfAmount
            Me.GridView_ShelfList.Name = "GridView_ShelfList"
            Me.GridView_ShelfList.OptionsView.ColumnAutoWidth = False
            Me.GridView_ShelfList.OptionsView.ShowFooter = True
            Me.GridView_ShelfList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_ShelfWareCode
            '
            resources.ApplyResources(Me.GridColumn_ShelfWareCode, "GridColumn_ShelfWareCode")
            Me.GridColumn_ShelfWareCode.FieldName = "WARE_CODE"
            Me.GridColumn_ShelfWareCode.Name = "GridColumn_ShelfWareCode"
            Me.GridColumn_ShelfWareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_ShelfWareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_ShelfCustomCode
            '
            resources.ApplyResources(Me.GridColumn_ShelfCustomCode, "GridColumn_ShelfCustomCode")
            Me.GridColumn_ShelfCustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_ShelfCustomCode.Name = "GridColumn_ShelfCustomCode"
            Me.GridColumn_ShelfCustomCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfWareName
            '
            resources.ApplyResources(Me.GridColumn_ShelfWareName, "GridColumn_ShelfWareName")
            Me.GridColumn_ShelfWareName.FieldName = "WARE_NAME"
            Me.GridColumn_ShelfWareName.Name = "GridColumn_ShelfWareName"
            Me.GridColumn_ShelfWareName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfSpec
            '
            resources.ApplyResources(Me.GridColumn_ShelfSpec, "GridColumn_ShelfSpec")
            Me.GridColumn_ShelfSpec.FieldName = "SPEC"
            Me.GridColumn_ShelfSpec.Name = "GridColumn_ShelfSpec"
            Me.GridColumn_ShelfSpec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfModel
            '
            resources.ApplyResources(Me.GridColumn_ShelfModel, "GridColumn_ShelfModel")
            Me.GridColumn_ShelfModel.FieldName = "MODEL"
            Me.GridColumn_ShelfModel.Name = "GridColumn_ShelfModel"
            Me.GridColumn_ShelfModel.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfAttribute1
            '
            resources.ApplyResources(Me.GridColumn_ShelfAttribute1, "GridColumn_ShelfAttribute1")
            Me.GridColumn_ShelfAttribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_ShelfAttribute1.Name = "GridColumn_ShelfAttribute1"
            Me.GridColumn_ShelfAttribute1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfAttribute2
            '
            resources.ApplyResources(Me.GridColumn_ShelfAttribute2, "GridColumn_ShelfAttribute2")
            Me.GridColumn_ShelfAttribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_ShelfAttribute2.Name = "GridColumn_ShelfAttribute2"
            Me.GridColumn_ShelfAttribute2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfAttribute3
            '
            resources.ApplyResources(Me.GridColumn_ShelfAttribute3, "GridColumn_ShelfAttribute3")
            Me.GridColumn_ShelfAttribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_ShelfAttribute3.Name = "GridColumn_ShelfAttribute3"
            Me.GridColumn_ShelfAttribute3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfAttribute4
            '
            resources.ApplyResources(Me.GridColumn_ShelfAttribute4, "GridColumn_ShelfAttribute4")
            Me.GridColumn_ShelfAttribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_ShelfAttribute4.Name = "GridColumn_ShelfAttribute4"
            Me.GridColumn_ShelfAttribute4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfCode
            '
            resources.ApplyResources(Me.GridColumn_ShelfCode, "GridColumn_ShelfCode")
            Me.GridColumn_ShelfCode.FieldName = "SHELF_CODE"
            Me.GridColumn_ShelfCode.Name = "GridColumn_ShelfCode"
            Me.GridColumn_ShelfCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_LocationCode
            '
            resources.ApplyResources(Me.GridColumn_LocationCode, "GridColumn_LocationCode")
            Me.GridColumn_LocationCode.FieldName = "LOCATION_CODE"
            Me.GridColumn_LocationCode.Name = "GridColumn_LocationCode"
            Me.GridColumn_LocationCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_LocationStockAmount
            '
            resources.ApplyResources(Me.GridColumn_LocationStockAmount, "GridColumn_LocationStockAmount")
            Me.GridColumn_LocationStockAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_LocationStockAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_LocationStockAmount.FieldName = "LOCATION_STOCK_AMOUNT"
            Me.GridColumn_LocationStockAmount.Name = "GridColumn_LocationStockAmount"
            Me.GridColumn_LocationStockAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_LocationStockAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_ShelfUnitName
            '
            resources.ApplyResources(Me.GridColumn_ShelfUnitName, "GridColumn_ShelfUnitName")
            Me.GridColumn_ShelfUnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_ShelfUnitName.Name = "GridColumn_ShelfUnitName"
            Me.GridColumn_ShelfUnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfRemark
            '
            resources.ApplyResources(Me.GridColumn_ShelfRemark, "GridColumn_ShelfRemark")
            Me.GridColumn_ShelfRemark.FieldName = "REMARK"
            Me.GridColumn_ShelfRemark.Name = "GridColumn_ShelfRemark"
            Me.GridColumn_ShelfRemark.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfRowHighlight
            '
            resources.ApplyResources(Me.GridColumn_ShelfRowHighlight, "GridColumn_ShelfRowHighlight")
            Me.GridColumn_ShelfRowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_ShelfRowHighlight.Name = "GridColumn_ShelfRowHighlight"
            Me.GridColumn_ShelfRowHighlight.OptionsColumn.AllowFocus = False
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'M_03_00101
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.XtraTabControl_Lists)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_00101"
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
            CTag13.ParentControl = Me
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag13
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.CheckEdit_SingleWareLocations.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl_Lists, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl_Lists.ResumeLayout(False)
            Me.XtraTabPage_NormalList.ResumeLayout(False)
            CType(Me.GridControl_NormalList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_NormalList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage_ShelfPosDifference.ResumeLayout(False)
            CType(Me.GridControl_ShelfStockDifference, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ShelfStockDifference, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage_BatchList.ResumeLayout(False)
            CType(Me.GridControl_BatchWareList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_BatchWareList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage_ShelfAmount.ResumeLayout(False)
            CType(Me.GridControl_ShelfAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ShelfList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_Pos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents CheckEdit_SingleWareLocations As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ToolStripButton_ViewTurnoverDtl As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_View As System.Windows.Forms.ToolStripButton
        Friend WithEvents XtraTabControl_Lists As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage_NormalList As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage_ShelfPosDifference As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage_BatchList As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage_ShelfAmount As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents GridControl_NormalList As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_NormalList As DevExpress.XtraGrid.Views.Grid.GridView
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
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CurrentAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CurrentCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_LowerLimit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_LackAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ConsignOutRemains As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ConsignInRemains As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_ShelfStockDifference As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ShelfStockDifference As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_SWareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SCustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SWareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SSpec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SAttribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SAttribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SAttribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SAttribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SelfAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PosAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_DifferenceAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SUnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SRemark As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SRowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_BatchWareList As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_BatchWareList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_BWareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BCustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BWareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BSpec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BAtrribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BAtrribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BAtrribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BAtrribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BatchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BCurrentAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BUnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BRemark As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BRowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_ShelfAmount As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ShelfList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_ShelfWareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfCustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfWareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfSpec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfAttribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfAttribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfAttribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfAttribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_LocationCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_LocationStockAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfUnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfRemark As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfRowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ToolStripButton_Choose As System.Windows.Forms.ToolStripButton
        Friend WithEvents GridColumn_CurrentOrigionSumPrice As DevExpress.XtraGrid.Columns.GridColumn

#End Region

    End Class

End Namespace
