Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_00201
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
        Friend WithEvents ToolStripButton_Print As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_00201))
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Print = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.LookUpEdit_Pos = New DevExpress.XtraEditors.LookUpEdit
            Me.Label4 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
            Me.XtraTabPage_WithdrawDtl = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_WithdrawDtl = New DevExpress.XtraGrid.GridControl
            Me.GridView_WithdrawDtl = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BeginAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_InAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_OutAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EndAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BeginOrigionSumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_BeginCost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_OutOrigionSumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_OutCost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_InOrigionSumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_InCost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EndOrigionSumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EndCost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.XtraTabPage_PosWare = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_PosWare = New DevExpress.XtraGrid.GridControl
            Me.GridView_PosWare = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_PTurnoverType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TurnoverType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_TurnoverStyle = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TurnoverStyle = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_PWareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PCustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PWareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PSpec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PModel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PAttribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PAttribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PAttribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PAttribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TotalAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TotalSumCost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TotalSumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PUnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PRemark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PRowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl1.SuspendLayout()
            Me.XtraTabPage_WithdrawDtl.SuspendLayout()
            CType(Me.GridControl_WithdrawDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_WithdrawDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage_PosWare.SuspendLayout()
            CType(Me.GridControl_PosWare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_PosWare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverType, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverStyle, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Refresh, Me.ToolStripButton_Print, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_Close})
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
            'ToolStripButton_Print
            '
            Me.ToolStripButton_Print.Name = "ToolStripButton_Print"
            resources.ApplyResources(Me.ToolStripButton_Print, "ToolStripButton_Print")
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
            Me.PanelControl_Filter.Controls.Add(Me.LookUpEdit_Pos)
            Me.PanelControl_Filter.Controls.Add(Me.Label4)
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
            Me.LookUpEdit_Pos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_Pos.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_Pos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Pos.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_Pos.Properties.NullText = resources.GetString("LookUpEdit_Pos.Properties.NullText")
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
            'Label4
            '
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.BackColor = System.Drawing.Color.White
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Name = "Label4"
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
            CTag3.ParentControl = Me.Label4
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag3
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
            Me.DateEdit_ToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_ToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
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
            Me.DateEdit_FromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_FromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
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
            'XtraTabControl1
            '
            resources.ApplyResources(Me.XtraTabControl1, "XtraTabControl1")
            Me.XtraTabControl1.Name = "XtraTabControl1"
            Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage_WithdrawDtl
            Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage_WithdrawDtl, Me.XtraTabPage_PosWare})
            Me.XtraTabControl1.TabStop = False
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
            CTag13.ParentControl = Me.XtraTabControl1
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabControl1.Tag = CTag13
            '
            'XtraTabPage_WithdrawDtl
            '
            Me.XtraTabPage_WithdrawDtl.Controls.Add(Me.GridControl_WithdrawDtl)
            Me.XtraTabPage_WithdrawDtl.Name = "XtraTabPage_WithdrawDtl"
            resources.ApplyResources(Me.XtraTabPage_WithdrawDtl, "XtraTabPage_WithdrawDtl")
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
            CTag11.ParentControl = Me.XtraTabPage_WithdrawDtl
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_WithdrawDtl.Tag = CTag11
            '
            'GridControl_WithdrawDtl
            '
            resources.ApplyResources(Me.GridControl_WithdrawDtl, "GridControl_WithdrawDtl")
            Me.GridControl_WithdrawDtl.EmbeddedNavigator.Name = ""
            Me.GridControl_WithdrawDtl.MainView = Me.GridView_WithdrawDtl
            Me.GridControl_WithdrawDtl.Name = "GridControl_WithdrawDtl"
            Me.GridControl_WithdrawDtl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_WithdrawDtl})
            '
            'GridView_WithdrawDtl
            '
            Me.GridView_WithdrawDtl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_BeginAmount, Me.GridColumn_InAmount, Me.GridColumn_OutAmount, Me.GridColumn_EndAmount, Me.GridColumn_BeginOrigionSumPrice, Me.GridColumn_BeginCost, Me.GridColumn_OutOrigionSumPrice, Me.GridColumn_OutCost, Me.GridColumn_InOrigionSumPrice, Me.GridColumn_InCost, Me.GridColumn_EndOrigionSumPrice, Me.GridColumn_EndCost, Me.GridColumn_UnitName, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_WithdrawDtl.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_WithdrawDtl.GridControl = Me.GridControl_WithdrawDtl
            Me.GridView_WithdrawDtl.Name = "GridView_WithdrawDtl"
            Me.GridView_WithdrawDtl.OptionsView.ColumnAutoWidth = False
            Me.GridView_WithdrawDtl.OptionsView.ShowFooter = True
            Me.GridView_WithdrawDtl.OptionsView.ShowGroupPanel = False
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
            'GridColumn_BeginAmount
            '
            resources.ApplyResources(Me.GridColumn_BeginAmount, "GridColumn_BeginAmount")
            Me.GridColumn_BeginAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_BeginAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_BeginAmount.FieldName = "BEGIN_AMOUNT"
            Me.GridColumn_BeginAmount.Name = "GridColumn_BeginAmount"
            Me.GridColumn_BeginAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_BeginAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_InAmount
            '
            resources.ApplyResources(Me.GridColumn_InAmount, "GridColumn_InAmount")
            Me.GridColumn_InAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_InAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_InAmount.FieldName = "IN_AMOUNT"
            Me.GridColumn_InAmount.Name = "GridColumn_InAmount"
            Me.GridColumn_InAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_InAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_OutAmount
            '
            resources.ApplyResources(Me.GridColumn_OutAmount, "GridColumn_OutAmount")
            Me.GridColumn_OutAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_OutAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_OutAmount.FieldName = "OUT_AMOUNT"
            Me.GridColumn_OutAmount.Name = "GridColumn_OutAmount"
            Me.GridColumn_OutAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_OutAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_EndAmount
            '
            resources.ApplyResources(Me.GridColumn_EndAmount, "GridColumn_EndAmount")
            Me.GridColumn_EndAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_EndAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_EndAmount.FieldName = "END_AMOUNT"
            Me.GridColumn_EndAmount.Name = "GridColumn_EndAmount"
            Me.GridColumn_EndAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_EndAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_BeginOrigionSumPrice
            '
            resources.ApplyResources(Me.GridColumn_BeginOrigionSumPrice, "GridColumn_BeginOrigionSumPrice")
            Me.GridColumn_BeginOrigionSumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_BeginOrigionSumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_BeginOrigionSumPrice.FieldName = "BEGIN_ORIGION_SUM_PRICE"
            Me.GridColumn_BeginOrigionSumPrice.Name = "GridColumn_BeginOrigionSumPrice"
            Me.GridColumn_BeginOrigionSumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_BeginOrigionSumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_BeginCost
            '
            resources.ApplyResources(Me.GridColumn_BeginCost, "GridColumn_BeginCost")
            Me.GridColumn_BeginCost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_BeginCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_BeginCost.FieldName = "BEGIN_COST"
            Me.GridColumn_BeginCost.Name = "GridColumn_BeginCost"
            Me.GridColumn_BeginCost.OptionsColumn.AllowFocus = False
            Me.GridColumn_BeginCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_OutOrigionSumPrice
            '
            resources.ApplyResources(Me.GridColumn_OutOrigionSumPrice, "GridColumn_OutOrigionSumPrice")
            Me.GridColumn_OutOrigionSumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_OutOrigionSumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_OutOrigionSumPrice.FieldName = "OUT_ORIGION_SUM_PRICE"
            Me.GridColumn_OutOrigionSumPrice.Name = "GridColumn_OutOrigionSumPrice"
            Me.GridColumn_OutOrigionSumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_OutOrigionSumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_OutCost
            '
            resources.ApplyResources(Me.GridColumn_OutCost, "GridColumn_OutCost")
            Me.GridColumn_OutCost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_OutCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_OutCost.FieldName = "OUT_COST"
            Me.GridColumn_OutCost.Name = "GridColumn_OutCost"
            Me.GridColumn_OutCost.OptionsColumn.AllowFocus = False
            Me.GridColumn_OutCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_InOrigionSumPrice
            '
            resources.ApplyResources(Me.GridColumn_InOrigionSumPrice, "GridColumn_InOrigionSumPrice")
            Me.GridColumn_InOrigionSumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_InOrigionSumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_InOrigionSumPrice.FieldName = "IN_ORIGION_SUM_PRICE"
            Me.GridColumn_InOrigionSumPrice.Name = "GridColumn_InOrigionSumPrice"
            Me.GridColumn_InOrigionSumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_InOrigionSumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_InCost
            '
            resources.ApplyResources(Me.GridColumn_InCost, "GridColumn_InCost")
            Me.GridColumn_InCost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_InCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_InCost.FieldName = "IN_COST"
            Me.GridColumn_InCost.Name = "GridColumn_InCost"
            Me.GridColumn_InCost.OptionsColumn.AllowFocus = False
            Me.GridColumn_InCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_EndOrigionSumPrice
            '
            resources.ApplyResources(Me.GridColumn_EndOrigionSumPrice, "GridColumn_EndOrigionSumPrice")
            Me.GridColumn_EndOrigionSumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_EndOrigionSumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_EndOrigionSumPrice.FieldName = "END_ORIGION_SUM_PRICE"
            Me.GridColumn_EndOrigionSumPrice.Name = "GridColumn_EndOrigionSumPrice"
            Me.GridColumn_EndOrigionSumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_EndOrigionSumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_EndCost
            '
            resources.ApplyResources(Me.GridColumn_EndCost, "GridColumn_EndCost")
            Me.GridColumn_EndCost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_EndCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_EndCost.FieldName = "END_COST"
            Me.GridColumn_EndCost.Name = "GridColumn_EndCost"
            Me.GridColumn_EndCost.OptionsColumn.AllowFocus = False
            Me.GridColumn_EndCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
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
            'XtraTabPage_PosWare
            '
            Me.XtraTabPage_PosWare.Controls.Add(Me.GridControl_PosWare)
            Me.XtraTabPage_PosWare.Name = "XtraTabPage_PosWare"
            resources.ApplyResources(Me.XtraTabPage_PosWare, "XtraTabPage_PosWare")
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
            CTag12.ParentControl = Me.XtraTabPage_PosWare
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_PosWare.Tag = CTag12
            '
            'GridControl_PosWare
            '
            resources.ApplyResources(Me.GridControl_PosWare, "GridControl_PosWare")
            Me.GridControl_PosWare.EmbeddedNavigator.Name = ""
            Me.GridControl_PosWare.MainView = Me.GridView_PosWare
            Me.GridControl_PosWare.Name = "GridControl_PosWare"
            Me.GridControl_PosWare.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_TurnoverType, Me.RepositoryItemLookUpEdit_TurnoverStyle})
            Me.GridControl_PosWare.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_PosWare})
            '
            'GridView_PosWare
            '
            Me.GridView_PosWare.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_PTurnoverType, Me.GridColumn_TurnoverStyle, Me.GridColumn_PWareCode, Me.GridColumn_PCustomCode, Me.GridColumn_PWareName, Me.GridColumn_PSpec, Me.GridColumn_PModel, Me.GridColumn_PAttribute1, Me.GridColumn_PAttribute2, Me.GridColumn_PAttribute3, Me.GridColumn_PAttribute4, Me.GridColumn_TotalAmount, Me.GridColumn_TotalSumCost, Me.GridColumn_TotalSumPrice, Me.GridColumn_PUnitName, Me.GridColumn_PRemark, Me.GridColumn_PRowHighlight})
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_PRowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "SEARCH_MATCH"
            Me.GridView_PosWare.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
            Me.GridView_PosWare.GridControl = Me.GridControl_PosWare
            Me.GridView_PosWare.GroupCount = 1
            Me.GridView_PosWare.Name = "GridView_PosWare"
            Me.GridView_PosWare.OptionsView.ColumnAutoWidth = False
            Me.GridView_PosWare.OptionsView.ShowFooter = True
            Me.GridView_PosWare.OptionsView.ShowGroupPanel = False
            Me.GridView_PosWare.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn_PTurnoverType, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'GridColumn_PTurnoverType
            '
            resources.ApplyResources(Me.GridColumn_PTurnoverType, "GridColumn_PTurnoverType")
            Me.GridColumn_PTurnoverType.ColumnEdit = Me.RepositoryItemLookUpEdit_TurnoverType
            Me.GridColumn_PTurnoverType.FieldName = "TURNOVER_TYPE"
            Me.GridColumn_PTurnoverType.Name = "GridColumn_PTurnoverType"
            Me.GridColumn_PTurnoverType.OptionsColumn.AllowFocus = False
            Me.GridColumn_PTurnoverType.SummaryItem.FieldName = "BEGIN_AMOUNT"
            Me.GridColumn_PTurnoverType.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'RepositoryItemLookUpEdit_TurnoverType
            '
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_TurnoverType, "RepositoryItemLookUpEdit_TurnoverType")
            Me.RepositoryItemLookUpEdit_TurnoverType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_TurnoverType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TurnoverType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_TurnoverType.Name = "RepositoryItemLookUpEdit_TurnoverType"
            Me.RepositoryItemLookUpEdit_TurnoverType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_TurnoverStyle
            '
            resources.ApplyResources(Me.GridColumn_TurnoverStyle, "GridColumn_TurnoverStyle")
            Me.GridColumn_TurnoverStyle.ColumnEdit = Me.RepositoryItemLookUpEdit_TurnoverStyle
            Me.GridColumn_TurnoverStyle.FieldName = "TURNOVER_STYLE"
            Me.GridColumn_TurnoverStyle.Name = "GridColumn_TurnoverStyle"
            Me.GridColumn_TurnoverStyle.OptionsColumn.AllowFocus = False
            Me.GridColumn_TurnoverStyle.SummaryItem.FieldName = "IN_AMOUNT"
            Me.GridColumn_TurnoverStyle.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'RepositoryItemLookUpEdit_TurnoverStyle
            '
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_TurnoverStyle, "RepositoryItemLookUpEdit_TurnoverStyle")
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TurnoverStyle.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Name = "RepositoryItemLookUpEdit_TurnoverStyle"
            Me.RepositoryItemLookUpEdit_TurnoverStyle.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_PWareCode
            '
            resources.ApplyResources(Me.GridColumn_PWareCode, "GridColumn_PWareCode")
            Me.GridColumn_PWareCode.FieldName = "WARE_CODE"
            Me.GridColumn_PWareCode.Name = "GridColumn_PWareCode"
            Me.GridColumn_PWareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_PWareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_PCustomCode
            '
            resources.ApplyResources(Me.GridColumn_PCustomCode, "GridColumn_PCustomCode")
            Me.GridColumn_PCustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_PCustomCode.Name = "GridColumn_PCustomCode"
            Me.GridColumn_PCustomCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PWareName
            '
            resources.ApplyResources(Me.GridColumn_PWareName, "GridColumn_PWareName")
            Me.GridColumn_PWareName.FieldName = "WARE_NAME"
            Me.GridColumn_PWareName.Name = "GridColumn_PWareName"
            Me.GridColumn_PWareName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PSpec
            '
            resources.ApplyResources(Me.GridColumn_PSpec, "GridColumn_PSpec")
            Me.GridColumn_PSpec.FieldName = "SPEC"
            Me.GridColumn_PSpec.Name = "GridColumn_PSpec"
            Me.GridColumn_PSpec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PModel
            '
            resources.ApplyResources(Me.GridColumn_PModel, "GridColumn_PModel")
            Me.GridColumn_PModel.FieldName = "MODEL"
            Me.GridColumn_PModel.Name = "GridColumn_PModel"
            Me.GridColumn_PModel.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PAttribute1
            '
            resources.ApplyResources(Me.GridColumn_PAttribute1, "GridColumn_PAttribute1")
            Me.GridColumn_PAttribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_PAttribute1.Name = "GridColumn_PAttribute1"
            Me.GridColumn_PAttribute1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PAttribute2
            '
            resources.ApplyResources(Me.GridColumn_PAttribute2, "GridColumn_PAttribute2")
            Me.GridColumn_PAttribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_PAttribute2.Name = "GridColumn_PAttribute2"
            Me.GridColumn_PAttribute2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PAttribute3
            '
            resources.ApplyResources(Me.GridColumn_PAttribute3, "GridColumn_PAttribute3")
            Me.GridColumn_PAttribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_PAttribute3.Name = "GridColumn_PAttribute3"
            Me.GridColumn_PAttribute3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PAttribute4
            '
            resources.ApplyResources(Me.GridColumn_PAttribute4, "GridColumn_PAttribute4")
            Me.GridColumn_PAttribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_PAttribute4.Name = "GridColumn_PAttribute4"
            Me.GridColumn_PAttribute4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TotalAmount
            '
            resources.ApplyResources(Me.GridColumn_TotalAmount, "GridColumn_TotalAmount")
            Me.GridColumn_TotalAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_TotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_TotalAmount.FieldName = "TOTAL_AMOUNT"
            Me.GridColumn_TotalAmount.Name = "GridColumn_TotalAmount"
            Me.GridColumn_TotalAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_TotalAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_TotalSumCost
            '
            resources.ApplyResources(Me.GridColumn_TotalSumCost, "GridColumn_TotalSumCost")
            Me.GridColumn_TotalSumCost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_TotalSumCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_TotalSumCost.FieldName = "TOTAL_SUM_COST"
            Me.GridColumn_TotalSumCost.Name = "GridColumn_TotalSumCost"
            Me.GridColumn_TotalSumCost.OptionsColumn.AllowFocus = False
            Me.GridColumn_TotalSumCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_TotalSumPrice
            '
            resources.ApplyResources(Me.GridColumn_TotalSumPrice, "GridColumn_TotalSumPrice")
            Me.GridColumn_TotalSumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_TotalSumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_TotalSumPrice.FieldName = "TOTAL_SUM_PRICE"
            Me.GridColumn_TotalSumPrice.Name = "GridColumn_TotalSumPrice"
            Me.GridColumn_TotalSumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_TotalSumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_PUnitName
            '
            resources.ApplyResources(Me.GridColumn_PUnitName, "GridColumn_PUnitName")
            Me.GridColumn_PUnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_PUnitName.Name = "GridColumn_PUnitName"
            Me.GridColumn_PUnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PRemark
            '
            resources.ApplyResources(Me.GridColumn_PRemark, "GridColumn_PRemark")
            Me.GridColumn_PRemark.FieldName = "REMARK"
            Me.GridColumn_PRemark.Name = "GridColumn_PRemark"
            Me.GridColumn_PRemark.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PRowHighlight
            '
            resources.ApplyResources(Me.GridColumn_PRowHighlight, "GridColumn_PRowHighlight")
            Me.GridColumn_PRowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_PRowHighlight.Name = "GridColumn_PRowHighlight"
            Me.GridColumn_PRowHighlight.OptionsColumn.AllowFocus = False
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'M_03_00201
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.XtraTabControl1)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_00201"
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
            CTag14.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag14.IsButtonCustomed = False
            CTag14.IsTextValid = True
            CTag14.KeyValueAbsentable = False
            CTag14.LeagleText = ""
            CTag14.NumericButtonTextBox = Nothing
            CTag14.ParentControl = Me
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag14
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
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl1.ResumeLayout(False)
            Me.XtraTabPage_WithdrawDtl.ResumeLayout(False)
            CType(Me.GridControl_WithdrawDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_WithdrawDtl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage_PosWare.ResumeLayout(False)
            CType(Me.GridControl_PosWare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_PosWare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverType, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverStyle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents LookUpEdit_Pos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_ToDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_FromDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage_WithdrawDtl As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage_PosWare As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents GridControl_WithdrawDtl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_WithdrawDtl As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BeginAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_InAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_OutAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_EndAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BeginCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_OutCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_InCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_EndCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_PosWare As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_PosWare As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_PWareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PCustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PWareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PSpec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PAttribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PAttribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PAttribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PAttribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PTurnoverType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverStyle As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TotalAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TotalSumCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TotalSumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PUnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PRemark As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PRowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverStyle As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_BeginOrigionSumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_OutOrigionSumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_InOrigionSumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_EndOrigionSumPrice As DevExpress.XtraGrid.Columns.GridColumn

#End Region

    End Class

End Namespace
