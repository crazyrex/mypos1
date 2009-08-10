Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_01002
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
        Friend WithEvents ToolStripButton_ShowFilter As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Save As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Report As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_View As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ShowFilter = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Report = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.Label4 = New System.Windows.Forms.Label
            Me.LinkLabel_CancelAll = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_SelectAll = New System.Windows.Forms.LinkLabel
            Me.MemoEdit_Remark = New DevExpress.XtraEditors.MemoEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label5 = New System.Windows.Forms.Label
            Me.TextEdit_TemplateName = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.TextEdit_TemplateCode = New DevExpress.XtraEditors.TextEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.GridControl_SaleTemplateWare = New DevExpress.XtraGrid.GridControl
            Me.GridView_SaleTemplateWare = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_Select = New DevExpress.XtraGrid.Columns.GridColumn
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
            Me.GridColumn_DiscountType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_DiscountType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_DiscountAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemSpinEdit_DiscountAmount = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowRemark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_LowerLimit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.RepositoryItemCalcEdit_IndividualDiscount = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.RepositoryItemCalcEdit_UnitPrice = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.RepositoryItemCalcEdit_UnitCost = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.MemoEdit_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_TemplateName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_TemplateCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_SaleTemplateWare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_SaleTemplateWare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_DiscountType, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSpinEdit_DiscountAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_LowerLimit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_IndividualDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_UnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_UnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Add, Me.ToolStripButton_ShowFilter, Me.ToolStripButton_Save, Me.ToolStripButton_Remove, Me.ToolStripButton_Refresh, Me.ToolStripButton_Report, Me.ToolStripButton_View, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
            Me.ToolStrip_Form.Size = New System.Drawing.Size(741, 25)
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
            'ToolStripButton_Add
            '
            Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
            Me.ToolStripButton_Add.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Add.Text = "添加"
            '
            'ToolStripButton_ShowFilter
            '
            Me.ToolStripButton_ShowFilter.Name = "ToolStripButton_ShowFilter"
            Me.ToolStripButton_ShowFilter.Size = New System.Drawing.Size(57, 22)
            Me.ToolStripButton_ShowFilter.Text = "筛选条件"
            Me.ToolStripButton_ShowFilter.Visible = False
            '
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            Me.ToolStripButton_Save.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Save.Text = "保存"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.Name = "ToolStripButton_Remove"
            Me.ToolStripButton_Remove.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Remove.Text = "去除"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            Me.ToolStripButton_Refresh.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Refresh.Text = "刷新"
            Me.ToolStripButton_Refresh.Visible = False
            '
            'ToolStripButton_Report
            '
            Me.ToolStripButton_Report.Name = "ToolStripButton_Report"
            Me.ToolStripButton_Report.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Report.Text = "报表"
            Me.ToolStripButton_Report.Visible = False
            '
            'ToolStripButton_View
            '
            Me.ToolStripButton_View.Name = "ToolStripButton_View"
            Me.ToolStripButton_View.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_View.Text = "查看"
            Me.ToolStripButton_View.Visible = False
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Close.Text = "关闭"
            '
            'PanelControl1
            '
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.Controls.Add(Me.Label4)
            Me.PanelControl1.Controls.Add(Me.LinkLabel_CancelAll)
            Me.PanelControl1.Controls.Add(Me.LinkLabel_SelectAll)
            Me.PanelControl1.Controls.Add(Me.MemoEdit_Remark)
            Me.PanelControl1.Controls.Add(Me.Label3)
            Me.PanelControl1.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl1.Controls.Add(Me.Label5)
            Me.PanelControl1.Controls.Add(Me.TextEdit_TemplateName)
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Controls.Add(Me.TextEdit_TemplateCode)
            Me.PanelControl1.Controls.Add(Me.Label2)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl1.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(741, 128)
            Me.PanelControl1.TabIndex = 10002
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
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.ForeColor = System.Drawing.Color.Red
            Me.Label4.Location = New System.Drawing.Point(136, 78)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(478, 15)
            Me.Label4.TabIndex = 10010
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
            CTag2.ParentControl = Me.Label4
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag2
            Me.Label4.Text = "注:列表中的折扣量,为下降额度, 如果按比例则为下降百分比, 系统会在计算时自动除以100"
            '
            'LinkLabel_CancelAll
            '
            Me.LinkLabel_CancelAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LinkLabel_CancelAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.LinkLabel_CancelAll.Location = New System.Drawing.Point(683, 78)
            Me.LinkLabel_CancelAll.Name = "LinkLabel_CancelAll"
            Me.LinkLabel_CancelAll.Size = New System.Drawing.Size(50, 17)
            Me.LinkLabel_CancelAll.TabIndex = 10009
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
            Me.LinkLabel_CancelAll.Text = "全不选"
            '
            'LinkLabel_SelectAll
            '
            Me.LinkLabel_SelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LinkLabel_SelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.LinkLabel_SelectAll.Location = New System.Drawing.Point(645, 78)
            Me.LinkLabel_SelectAll.Name = "LinkLabel_SelectAll"
            Me.LinkLabel_SelectAll.Size = New System.Drawing.Size(41, 17)
            Me.LinkLabel_SelectAll.TabIndex = 10008
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
            Me.LinkLabel_SelectAll.Text = "全选"
            '
            'MemoEdit_Remark
            '
            Me.MemoEdit_Remark.Location = New System.Drawing.Point(371, 13)
            Me.MemoEdit_Remark.Name = "MemoEdit_Remark"
            Me.MemoEdit_Remark.Size = New System.Drawing.Size(365, 55)
            Me.MemoEdit_Remark.TabIndex = 10004
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
            CTag5.ParentControl = Me.MemoEdit_Remark
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.MemoEdit_Remark.Tag = CTag5
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label3.Location = New System.Drawing.Point(328, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(37, 20)
            Me.Label3.TabIndex = 10003
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
            CTag6.ParentControl = Me.Label3
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag6
            Me.Label3.Text = "备注"
            '
            'TextEdit_Search
            '
            Me.TextEdit_Search.EditValue = ""
            Me.TextEdit_Search.Location = New System.Drawing.Point(86, 98)
            Me.TextEdit_Search.Name = "TextEdit_Search"
            Me.TextEdit_Search.Size = New System.Drawing.Size(221, 21)
            Me.TextEdit_Search.TabIndex = 10002
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
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.White
            Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label5.Location = New System.Drawing.Point(17, 98)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(60, 20)
            Me.Label5.TabIndex = 10001
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
            CTag8.ParentControl = Me.Label5
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label5.Tag = CTag8
            Me.Label5.Text = "搜索"
            '
            'TextEdit_TemplateName
            '
            Me.TextEdit_TemplateName.EditValue = ""
            Me.TextEdit_TemplateName.Location = New System.Drawing.Point(86, 41)
            Me.TextEdit_TemplateName.Name = "TextEdit_TemplateName"
            Me.TextEdit_TemplateName.Size = New System.Drawing.Size(221, 21)
            Me.TextEdit_TemplateName.TabIndex = 10002
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
            CTag9.ParentControl = Me.TextEdit_TemplateName
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_TemplateName.Tag = CTag9
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(17, 41)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(60, 20)
            Me.Label1.TabIndex = 10001
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
            CTag10.ParentControl = Me.Label1
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag10
            Me.Label1.Text = "模板名称"
            '
            'TextEdit_TemplateCode
            '
            Me.TextEdit_TemplateCode.EditValue = ""
            Me.TextEdit_TemplateCode.Location = New System.Drawing.Point(86, 13)
            Me.TextEdit_TemplateCode.Name = "TextEdit_TemplateCode"
            Me.TextEdit_TemplateCode.Size = New System.Drawing.Size(221, 21)
            Me.TextEdit_TemplateCode.TabIndex = 10000
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
            CTag11.ParentControl = Me.TextEdit_TemplateCode
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_TemplateCode.Tag = CTag11
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label2.Location = New System.Drawing.Point(17, 13)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 20)
            Me.Label2.TabIndex = 10000
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
            CTag12.ParentControl = Me.Label2
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag12
            Me.Label2.Text = "模板编号"
            '
            'GridControl_SaleTemplateWare
            '
            Me.GridControl_SaleTemplateWare.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_SaleTemplateWare.EmbeddedNavigator.Name = ""
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
            CTag14.ParentControl = Me.GridControl_SaleTemplateWare.EmbeddedNavigator
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_SaleTemplateWare.EmbeddedNavigator.Tag = CTag14
            Me.GridControl_SaleTemplateWare.Location = New System.Drawing.Point(0, 153)
            Me.GridControl_SaleTemplateWare.MainView = Me.GridView_SaleTemplateWare
            Me.GridControl_SaleTemplateWare.Name = "GridControl_SaleTemplateWare"
            Me.GridControl_SaleTemplateWare.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit_LowerLimit, Me.RepositoryItemCalcEdit_IndividualDiscount, Me.RepositoryItemCalcEdit_UnitPrice, Me.RepositoryItemCalcEdit_UnitCost, Me.RepositoryItemCheckEdit_Select, Me.RepositoryItemLookUpEdit_DiscountType, Me.RepositoryItemSpinEdit_DiscountAmount})
            Me.GridControl_SaleTemplateWare.Size = New System.Drawing.Size(741, 347)
            Me.GridControl_SaleTemplateWare.TabIndex = 10003
            Me.GridControl_SaleTemplateWare.TabStop = False
            Me.GridControl_SaleTemplateWare.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_SaleTemplateWare})
            '
            'GridView_SaleTemplateWare
            '
            Me.GridView_SaleTemplateWare.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_Select, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_DiscountType, Me.GridColumn_DiscountAmount, Me.GridColumn_RowHighlight, Me.GridColumn_RowRemark})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.Red
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "ROW_HIGHLIGHT_ROW_DATA_MISSING"
            StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            StyleFormatCondition3.Appearance.Options.UseBackColor = True
            StyleFormatCondition3.Column = Me.GridColumn_DiscountType
            StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
            StyleFormatCondition3.Value1 = 0
            StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            StyleFormatCondition4.Appearance.Options.UseBackColor = True
            StyleFormatCondition4.Column = Me.GridColumn_DiscountAmount
            StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
            StyleFormatCondition4.Value1 = 0
            Me.GridView_SaleTemplateWare.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4})
            Me.GridView_SaleTemplateWare.GridControl = Me.GridControl_SaleTemplateWare
            Me.GridView_SaleTemplateWare.Name = "GridView_SaleTemplateWare"
            Me.GridView_SaleTemplateWare.OptionsView.ColumnAutoWidth = False
            Me.GridView_SaleTemplateWare.OptionsView.ShowFooter = True
            Me.GridView_SaleTemplateWare.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_Select
            '
            Me.GridColumn_Select.Caption = "选择"
            Me.GridColumn_Select.ColumnEdit = Me.RepositoryItemCheckEdit_Select
            Me.GridColumn_Select.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_Select.Name = "GridColumn_Select"
            Me.GridColumn_Select.Visible = True
            Me.GridColumn_Select.VisibleIndex = 0
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AutoHeight = False
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'GridColumn_WareCode
            '
            Me.GridColumn_WareCode.Caption = "货品代码"
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_WareCode.Visible = True
            Me.GridColumn_WareCode.VisibleIndex = 1
            '
            'GridColumn_CustomCode
            '
            Me.GridColumn_CustomCode.Caption = "自定货号"
            Me.GridColumn_CustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_CustomCode.Name = "GridColumn_CustomCode"
            Me.GridColumn_CustomCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomCode.Visible = True
            Me.GridColumn_CustomCode.VisibleIndex = 2
            '
            'GridColumn_WareName
            '
            Me.GridColumn_WareName.Caption = "货品名称"
            Me.GridColumn_WareName.FieldName = "WARE_NAME"
            Me.GridColumn_WareName.Name = "GridColumn_WareName"
            Me.GridColumn_WareName.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareName.Visible = True
            Me.GridColumn_WareName.VisibleIndex = 3
            '
            'GridColumn_Spec
            '
            Me.GridColumn_Spec.Caption = "货品规格"
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            Me.GridColumn_Spec.Visible = True
            Me.GridColumn_Spec.VisibleIndex = 4
            '
            'GridColumn_Model
            '
            Me.GridColumn_Model.Caption = "货品型号"
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            Me.GridColumn_Model.Visible = True
            Me.GridColumn_Model.VisibleIndex = 5
            '
            'GridColumn_Attribute1
            '
            Me.GridColumn_Attribute1.Caption = "属性1"
            Me.GridColumn_Attribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_Attribute1.Name = "GridColumn_Attribute1"
            Me.GridColumn_Attribute1.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute1.Visible = True
            Me.GridColumn_Attribute1.VisibleIndex = 6
            '
            'GridColumn_Attribute2
            '
            Me.GridColumn_Attribute2.Caption = "属性2"
            Me.GridColumn_Attribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_Attribute2.Name = "GridColumn_Attribute2"
            Me.GridColumn_Attribute2.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute2.Visible = True
            Me.GridColumn_Attribute2.VisibleIndex = 7
            '
            'GridColumn_Attribute3
            '
            Me.GridColumn_Attribute3.Caption = "属性3"
            Me.GridColumn_Attribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_Attribute3.Name = "GridColumn_Attribute3"
            Me.GridColumn_Attribute3.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute3.Visible = True
            Me.GridColumn_Attribute3.VisibleIndex = 8
            '
            'GridColumn_Attribute4
            '
            Me.GridColumn_Attribute4.Caption = "属性4"
            Me.GridColumn_Attribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_Attribute4.Name = "GridColumn_Attribute4"
            Me.GridColumn_Attribute4.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute4.Visible = True
            Me.GridColumn_Attribute4.VisibleIndex = 9
            '
            'GridColumn_DiscountType
            '
            Me.GridColumn_DiscountType.Caption = "折扣类型"
            Me.GridColumn_DiscountType.ColumnEdit = Me.RepositoryItemLookUpEdit_DiscountType
            Me.GridColumn_DiscountType.FieldName = "DISCOUNT_TYPE"
            Me.GridColumn_DiscountType.Name = "GridColumn_DiscountType"
            Me.GridColumn_DiscountType.Visible = True
            Me.GridColumn_DiscountType.VisibleIndex = 10
            '
            'RepositoryItemLookUpEdit_DiscountType
            '
            Me.RepositoryItemLookUpEdit_DiscountType.AutoHeight = False
            Me.RepositoryItemLookUpEdit_DiscountType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_DiscountType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", "折扣类型", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_DiscountType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_DiscountType.Name = "RepositoryItemLookUpEdit_DiscountType"
            Me.RepositoryItemLookUpEdit_DiscountType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_DiscountAmount
            '
            Me.GridColumn_DiscountAmount.Caption = "降价额度"
            Me.GridColumn_DiscountAmount.ColumnEdit = Me.RepositoryItemSpinEdit_DiscountAmount
            Me.GridColumn_DiscountAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_DiscountAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_DiscountAmount.FieldName = "DISCOUNT_AMOUNT"
            Me.GridColumn_DiscountAmount.Name = "GridColumn_DiscountAmount"
            Me.GridColumn_DiscountAmount.Visible = True
            Me.GridColumn_DiscountAmount.VisibleIndex = 11
            '
            'RepositoryItemSpinEdit_DiscountAmount
            '
            Me.RepositoryItemSpinEdit_DiscountAmount.AutoHeight = False
            Me.RepositoryItemSpinEdit_DiscountAmount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.RepositoryItemSpinEdit_DiscountAmount.Name = "RepositoryItemSpinEdit_DiscountAmount"
            '
            'GridColumn_RowHighlight
            '
            Me.GridColumn_RowHighlight.Caption = "高亮显示"
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowRemark
            '
            Me.GridColumn_RowRemark.Caption = "问题"
            Me.GridColumn_RowRemark.FieldName = "DSR_FT_ROW_REMARK"
            Me.GridColumn_RowRemark.Name = "GridColumn_RowRemark"
            Me.GridColumn_RowRemark.OptionsColumn.AllowFocus = False
            Me.GridColumn_RowRemark.Visible = True
            Me.GridColumn_RowRemark.VisibleIndex = 12
            '
            'RepositoryItemCalcEdit_LowerLimit
            '
            Me.RepositoryItemCalcEdit_LowerLimit.AutoHeight = False
            Me.RepositoryItemCalcEdit_LowerLimit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_LowerLimit.Name = "RepositoryItemCalcEdit_LowerLimit"
            '
            'RepositoryItemCalcEdit_IndividualDiscount
            '
            Me.RepositoryItemCalcEdit_IndividualDiscount.AutoHeight = False
            Me.RepositoryItemCalcEdit_IndividualDiscount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_IndividualDiscount.Name = "RepositoryItemCalcEdit_IndividualDiscount"
            '
            'RepositoryItemCalcEdit_UnitPrice
            '
            Me.RepositoryItemCalcEdit_UnitPrice.AutoHeight = False
            Me.RepositoryItemCalcEdit_UnitPrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_UnitPrice.Name = "RepositoryItemCalcEdit_UnitPrice"
            '
            'RepositoryItemCalcEdit_UnitCost
            '
            Me.RepositoryItemCalcEdit_UnitCost.AutoHeight = False
            Me.RepositoryItemCalcEdit_UnitCost.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_UnitCost.Name = "RepositoryItemCalcEdit_UnitCost"
            '
            'M_01_01002
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.GridControl_SaleTemplateWare)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_01_01002"
            Me.Size = New System.Drawing.Size(741, 500)
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
            CTag15.ParentControl = Me
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag15
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.MemoEdit_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_TemplateName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_TemplateCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_SaleTemplateWare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_SaleTemplateWare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_DiscountType, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSpinEdit_DiscountAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_LowerLimit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_IndividualDiscount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_UnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_UnitCost, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_TemplateCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents MemoEdit_Remark As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_TemplateName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GridControl_SaleTemplateWare As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_SaleTemplateWare As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_Select As DevExpress.XtraGrid.Columns.GridColumn
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
        Friend WithEvents RepositoryItemCalcEdit_UnitPrice As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents RepositoryItemCalcEdit_UnitCost As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents RepositoryItemCalcEdit_LowerLimit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents RepositoryItemCalcEdit_IndividualDiscount As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_DiscountType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_DiscountType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_DiscountAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemSpinEdit_DiscountAmount As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Friend WithEvents GridColumn_RowRemark As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents LinkLabel_CancelAll As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel_SelectAll As System.Windows.Forms.LinkLabel
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label5 As System.Windows.Forms.Label

#End Region

    End Class

End Namespace

