Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_00601
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_00601))
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportSalesReport = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.LookUpEdit_Pos = New DevExpress.XtraEditors.LookUpEdit
            Me.Label_TurnoverPos = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.GridControl_Sales = New DevExpress.XtraGrid.GridControl
            Me.GridView_Sales = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_TurnoverCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverTime = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitDiscount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ExtraDiscount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TotalSumCost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Unitcost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_GrossProfit = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_DeliveryCharge = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Total = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CC = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CashAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TT = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_OtherAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remaining = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Invoice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Sales = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Commission = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.SaveFileDialog_ExportToExcel = New System.Windows.Forms.SaveFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_Sales, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Sales, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Refresh, Me.ToolStripButton_ExportSalesReport, Me.ToolStripButton_Close})
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
            'ToolStripButton_ExportSalesReport
            '
            Me.ToolStripButton_ExportSalesReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_ExportSalesReport, "ToolStripButton_ExportSalesReport")
            Me.ToolStripButton_ExportSalesReport.Name = "ToolStripButton_ExportSalesReport"
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
            Me.PanelControl_Filter.Controls.Add(Me.LookUpEdit_Pos)
            Me.PanelControl_Filter.Controls.Add(Me.Label_TurnoverPos)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_ToDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label3)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_FromDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            CTag10.ParentControl = Me.PanelControl_Filter
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag10
            '
            'LookUpEdit_Pos
            '
            resources.ApplyResources(Me.LookUpEdit_Pos, "LookUpEdit_Pos")
            Me.LookUpEdit_Pos.Name = "LookUpEdit_Pos"
            Me.LookUpEdit_Pos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LookUpEdit_Pos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Pos.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_Pos.Properties.ValueMember = "POS_ID"
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
            CTag2.ParentControl = Me.LookUpEdit_Pos
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_Pos.Tag = CTag2
            '
            'Label_TurnoverPos
            '
            resources.ApplyResources(Me.Label_TurnoverPos, "Label_TurnoverPos")
            Me.Label_TurnoverPos.Name = "Label_TurnoverPos"
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
            CTag3.ParentControl = Me.Label_TurnoverPos
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_TurnoverPos.Tag = CTag3
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.Name = "TextEdit_Search"
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
            CTag4.ParentControl = Me.TextEdit_Search
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag4
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
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
            CTag5.ParentControl = Me.Label1
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag5
            '
            'DateEdit_ToDate
            '
            Me.DateEdit_ToDate.EditValue = Nothing
            resources.ApplyResources(Me.DateEdit_ToDate, "DateEdit_ToDate")
            Me.DateEdit_ToDate.Name = "DateEdit_ToDate"
            Me.DateEdit_ToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit_ToDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag6.ParentControl = Me.DateEdit_ToDate
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_ToDate.Tag = CTag6
            '
            'Label3
            '
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
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
            CTag7.ParentControl = Me.Label3
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag7
            '
            'DateEdit_FromDate
            '
            Me.DateEdit_FromDate.EditValue = Nothing
            resources.ApplyResources(Me.DateEdit_FromDate, "DateEdit_FromDate")
            Me.DateEdit_FromDate.Name = "DateEdit_FromDate"
            Me.DateEdit_FromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit_FromDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag8.ParentControl = Me.DateEdit_FromDate
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_FromDate.Tag = CTag8
            '
            'Label2
            '
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
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
            CTag9.ParentControl = Me.Label2
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag9
            '
            'GridControl_Sales
            '
            resources.ApplyResources(Me.GridControl_Sales, "GridControl_Sales")
            Me.GridControl_Sales.EmbeddedNavigator.Name = ""
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
            CTag11.ParentControl = Me.GridControl_Sales.EmbeddedNavigator
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Sales.EmbeddedNavigator.Tag = CTag11
            Me.GridControl_Sales.MainView = Me.GridView_Sales
            Me.GridControl_Sales.Name = "GridControl_Sales"
            Me.GridControl_Sales.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select})
            Me.GridControl_Sales.TabStop = False
            Me.GridControl_Sales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Sales})
            '
            'GridView_Sales
            '
            Me.GridView_Sales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_TurnoverCode, Me.GridColumn_TurnoverTime, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_WareAmount, Me.GridColumn_UnitPrice, Me.GridColumn_UnitDiscount, Me.GridColumn_ExtraDiscount, Me.GridColumn_TotalSumCost, Me.GridColumn_Unitcost, Me.GridColumn_GrossProfit, Me.GridColumn_DeliveryCharge, Me.GridColumn_Total, Me.GridColumn_CC, Me.GridColumn_CashAmount, Me.GridColumn_TT, Me.GridColumn_OtherAmount, Me.GridColumn_Remaining, Me.GridColumn_Invoice, Me.GridColumn_Sales, Me.GridColumn_Commission, Me.GridColumn_UnitName, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight, Me.GridColumn_TurnoverID})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_Sales.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_Sales.GridControl = Me.GridControl_Sales
            Me.GridView_Sales.Name = "GridView_Sales"
            Me.GridView_Sales.OptionsView.ColumnAutoWidth = False
            Me.GridView_Sales.OptionsView.EnableAppearanceEvenRow = True
            Me.GridView_Sales.OptionsView.EnableAppearanceOddRow = True
            Me.GridView_Sales.OptionsView.ShowFooter = True
            Me.GridView_Sales.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_TurnoverCode
            '
            resources.ApplyResources(Me.GridColumn_TurnoverCode, "GridColumn_TurnoverCode")
            Me.GridColumn_TurnoverCode.FieldName = "TURNOVER_CODE"
            Me.GridColumn_TurnoverCode.Name = "GridColumn_TurnoverCode"
            Me.GridColumn_TurnoverCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_TurnoverCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_TurnoverTime
            '
            resources.ApplyResources(Me.GridColumn_TurnoverTime, "GridColumn_TurnoverTime")
            Me.GridColumn_TurnoverTime.FieldName = "TURNOVER_TIME"
            Me.GridColumn_TurnoverTime.Name = "GridColumn_TurnoverTime"
            Me.GridColumn_TurnoverTime.OptionsColumn.AllowFocus = False
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
            'GridColumn_WareAmount
            '
            resources.ApplyResources(Me.GridColumn_WareAmount, "GridColumn_WareAmount")
            Me.GridColumn_WareAmount.FieldName = "WARE_AMOUNT"
            Me.GridColumn_WareAmount.Name = "GridColumn_WareAmount"
            Me.GridColumn_WareAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_UnitPrice
            '
            resources.ApplyResources(Me.GridColumn_UnitPrice, "GridColumn_UnitPrice")
            Me.GridColumn_UnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitPrice.FieldName = "UNIT_PRICE"
            Me.GridColumn_UnitPrice.Name = "GridColumn_UnitPrice"
            Me.GridColumn_UnitPrice.OptionsColumn.AllowFocus = False
            '
            'GridColumn_UnitDiscount
            '
            resources.ApplyResources(Me.GridColumn_UnitDiscount, "GridColumn_UnitDiscount")
            Me.GridColumn_UnitDiscount.DisplayFormat.FormatString = "{0:0}%"
            Me.GridColumn_UnitDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitDiscount.FieldName = "UNIT_DISCOUNT_PERCENT"
            Me.GridColumn_UnitDiscount.Name = "GridColumn_UnitDiscount"
            Me.GridColumn_UnitDiscount.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitDiscount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_ExtraDiscount
            '
            resources.ApplyResources(Me.GridColumn_ExtraDiscount, "GridColumn_ExtraDiscount")
            Me.GridColumn_ExtraDiscount.FieldName = "EXTRA_DISCOUNT"
            Me.GridColumn_ExtraDiscount.Name = "GridColumn_ExtraDiscount"
            Me.GridColumn_ExtraDiscount.OptionsColumn.AllowFocus = False
            Me.GridColumn_ExtraDiscount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_TotalSumCost
            '
            resources.ApplyResources(Me.GridColumn_TotalSumCost, "GridColumn_TotalSumCost")
            Me.GridColumn_TotalSumCost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_TotalSumCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_TotalSumCost.FieldName = "TOTAL_SUM_COST"
            Me.GridColumn_TotalSumCost.Name = "GridColumn_TotalSumCost"
            Me.GridColumn_TotalSumCost.OptionsColumn.AllowFocus = False
            Me.GridColumn_TotalSumCost.SummaryItem.DisplayFormat = resources.GetString("GridColumn_TotalSumCost.SummaryItem.DisplayFormat")
            Me.GridColumn_TotalSumCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_Unitcost
            '
            resources.ApplyResources(Me.GridColumn_Unitcost, "GridColumn_Unitcost")
            Me.GridColumn_Unitcost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Unitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Unitcost.FieldName = "UNIT_COST"
            Me.GridColumn_Unitcost.Name = "GridColumn_Unitcost"
            Me.GridColumn_Unitcost.OptionsColumn.AllowFocus = False
            Me.GridColumn_Unitcost.SummaryItem.DisplayFormat = resources.GetString("GridColumn_Unitcost.SummaryItem.DisplayFormat")
            Me.GridColumn_Unitcost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_GrossProfit
            '
            resources.ApplyResources(Me.GridColumn_GrossProfit, "GridColumn_GrossProfit")
            Me.GridColumn_GrossProfit.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_GrossProfit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_GrossProfit.FieldName = "GROSS_PROFIT"
            Me.GridColumn_GrossProfit.Name = "GridColumn_GrossProfit"
            Me.GridColumn_GrossProfit.OptionsColumn.AllowFocus = False
            Me.GridColumn_GrossProfit.SummaryItem.DisplayFormat = resources.GetString("GridColumn_GrossProfit.SummaryItem.DisplayFormat")
            Me.GridColumn_GrossProfit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
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
            'GridColumn_Total
            '
            resources.ApplyResources(Me.GridColumn_Total, "GridColumn_Total")
            Me.GridColumn_Total.FieldName = "TOTAL"
            Me.GridColumn_Total.Name = "GridColumn_Total"
            Me.GridColumn_Total.OptionsColumn.AllowFocus = False
            Me.GridColumn_Total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_CC
            '
            resources.ApplyResources(Me.GridColumn_CC, "GridColumn_CC")
            Me.GridColumn_CC.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_CC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_CC.FieldName = "CREDIT_CARD_AMOUNT"
            Me.GridColumn_CC.Name = "GridColumn_CC"
            Me.GridColumn_CC.OptionsColumn.AllowFocus = False
            Me.GridColumn_CC.SummaryItem.DisplayFormat = resources.GetString("GridColumn_CC.SummaryItem.DisplayFormat")
            Me.GridColumn_CC.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_CashAmount
            '
            resources.ApplyResources(Me.GridColumn_CashAmount, "GridColumn_CashAmount")
            Me.GridColumn_CashAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_CashAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_CashAmount.FieldName = "CASH_AMOUNT"
            Me.GridColumn_CashAmount.Name = "GridColumn_CashAmount"
            Me.GridColumn_CashAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_CashAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_CashAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_CashAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_TT
            '
            resources.ApplyResources(Me.GridColumn_TT, "GridColumn_TT")
            Me.GridColumn_TT.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_TT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_TT.FieldName = "TELE_TRANSPORT_AMOUNT"
            Me.GridColumn_TT.Name = "GridColumn_TT"
            Me.GridColumn_TT.OptionsColumn.AllowFocus = False
            Me.GridColumn_TT.SummaryItem.DisplayFormat = resources.GetString("GridColumn_TT.SummaryItem.DisplayFormat")
            Me.GridColumn_TT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Min
            '
            'GridColumn_OtherAmount
            '
            resources.ApplyResources(Me.GridColumn_OtherAmount, "GridColumn_OtherAmount")
            Me.GridColumn_OtherAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_OtherAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_OtherAmount.FieldName = "OTHER_AMOUNT"
            Me.GridColumn_OtherAmount.Name = "GridColumn_OtherAmount"
            Me.GridColumn_OtherAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_OtherAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_OtherAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_OtherAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_Remaining
            '
            resources.ApplyResources(Me.GridColumn_Remaining, "GridColumn_Remaining")
            Me.GridColumn_Remaining.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Remaining.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Remaining.FieldName = "REMAINING"
            Me.GridColumn_Remaining.Name = "GridColumn_Remaining"
            Me.GridColumn_Remaining.OptionsColumn.AllowFocus = False
            Me.GridColumn_Remaining.SummaryItem.DisplayFormat = resources.GetString("GridColumn_Remaining.SummaryItem.DisplayFormat")
            Me.GridColumn_Remaining.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_Invoice
            '
            resources.ApplyResources(Me.GridColumn_Invoice, "GridColumn_Invoice")
            Me.GridColumn_Invoice.FieldName = "INVOICE"
            Me.GridColumn_Invoice.Name = "GridColumn_Invoice"
            Me.GridColumn_Invoice.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Sales
            '
            resources.ApplyResources(Me.GridColumn_Sales, "GridColumn_Sales")
            Me.GridColumn_Sales.FieldName = "SALES"
            Me.GridColumn_Sales.Name = "GridColumn_Sales"
            Me.GridColumn_Sales.OptionsColumn.AllowFocus = False
            Me.GridColumn_Sales.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_Commission
            '
            resources.ApplyResources(Me.GridColumn_Commission, "GridColumn_Commission")
            Me.GridColumn_Commission.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Commission.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Commission.FieldName = "COMMISSION"
            Me.GridColumn_Commission.Name = "GridColumn_Commission"
            Me.GridColumn_Commission.OptionsColumn.AllowFocus = False
            Me.GridColumn_Commission.SummaryItem.DisplayFormat = resources.GetString("GridColumn_Commission.SummaryItem.DisplayFormat")
            Me.GridColumn_Commission.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
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
            'GridColumn_TurnoverID
            '
            resources.ApplyResources(Me.GridColumn_TurnoverID, "GridColumn_TurnoverID")
            Me.GridColumn_TurnoverID.FieldName = "TURNOVER_ID"
            Me.GridColumn_TurnoverID.Name = "GridColumn_TurnoverID"
            '
            'RepositoryItemCheckEdit_Select
            '
            resources.ApplyResources(Me.RepositoryItemCheckEdit_Select, "RepositoryItemCheckEdit_Select")
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'SaveFileDialog_ExportToExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportToExcel, "SaveFileDialog_ExportToExcel")
            '
            'M_03_00601
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.GridControl_Sales)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_00601"
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
            CTag12.ParentControl = Me
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag12
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_Sales, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Sales, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ToolStripButton_ExportSalesReport As System.Windows.Forms.ToolStripButton
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_ToDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_FromDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GridControl_Sales As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Sales As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverTime As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ExtraDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_DeliveryCharge As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Unitcost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents GridColumn_TotalSumCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_GrossProfit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Total As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CC As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CashAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_OtherAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remaining As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Invoice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Sales As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Commission As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents SaveFileDialog_ExportToExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents GridColumn_TurnoverID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents LookUpEdit_Pos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label_TurnoverPos As System.Windows.Forms.Label

#End Region

    End Class

End Namespace
