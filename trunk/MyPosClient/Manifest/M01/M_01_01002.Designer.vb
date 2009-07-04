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
        Friend WithEvents ToolStripButton_Choose As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Report As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_View As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ShowFilter = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Choose = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Report = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.MemoEdit_Remark = New DevExpress.XtraEditors.MemoEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.TextEdit_TemplateName = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.TextEdit_TemplateCode = New DevExpress.XtraEditors.TextEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.GridControl_SaleTemplateWare = New DevExpress.XtraGrid.GridControl
            Me.GridView_SaleTemplateWare = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_TemplateID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TemplateID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_WareID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_WareID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_DiscountType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_DiscountType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_DiscountAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.MemoEdit_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_TemplateName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_TemplateCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_SaleTemplateWare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_SaleTemplateWare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TemplateID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_WareID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_DiscountType, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Add, Me.ToolStripButton_ShowFilter, Me.ToolStripButton_Save, Me.ToolStripButton_Choose, Me.ToolStripButton_Revise, Me.ToolStripButton_Remove, Me.ToolStripButton_Refresh, Me.ToolStripButton_Report, Me.ToolStripButton_View, Me.ToolStripButton_Close})
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
            'ToolStripButton_Choose
            '
            Me.ToolStripButton_Choose.Name = "ToolStripButton_Choose"
            Me.ToolStripButton_Choose.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Choose.Text = "选择"
            Me.ToolStripButton_Choose.Visible = False
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            Me.ToolStripButton_Revise.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Revise.Text = "修改"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.Name = "ToolStripButton_Remove"
            Me.ToolStripButton_Remove.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Remove.Text = "除去"
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
            Me.PanelControl1.Controls.Add(Me.MemoEdit_Remark)
            Me.PanelControl1.Controls.Add(Me.Label3)
            Me.PanelControl1.Controls.Add(Me.TextEdit_TemplateName)
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Controls.Add(Me.TextEdit_TemplateCode)
            Me.PanelControl1.Controls.Add(Me.Label2)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl1.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(741, 102)
            Me.PanelControl1.TabIndex = 10002
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
            CTag8.ParentControl = Me.PanelControl1
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag8
            '
            'MemoEdit_Remark
            '
            Me.MemoEdit_Remark.Location = New System.Drawing.Point(73, 40)
            Me.MemoEdit_Remark.Name = "MemoEdit_Remark"
            Me.MemoEdit_Remark.Size = New System.Drawing.Size(509, 55)
            Me.MemoEdit_Remark.TabIndex = 10004
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
            CTag2.ParentControl = Me.MemoEdit_Remark
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.MemoEdit_Remark.Tag = CTag2
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label3.Location = New System.Drawing.Point(20, 40)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(37, 20)
            Me.Label3.TabIndex = 10003
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
            CTag3.ParentControl = Me.Label3
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag3
            Me.Label3.Text = "备注"
            '
            'TextEdit_TemplateName
            '
            Me.TextEdit_TemplateName.EditValue = ""
            Me.TextEdit_TemplateName.Location = New System.Drawing.Point(360, 13)
            Me.TextEdit_TemplateName.Name = "TextEdit_TemplateName"
            Me.TextEdit_TemplateName.Size = New System.Drawing.Size(221, 21)
            Me.TextEdit_TemplateName.TabIndex = 10002
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
            CTag4.ParentControl = Me.TextEdit_TemplateName
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_TemplateName.Tag = CTag4
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(301, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(60, 20)
            Me.Label1.TabIndex = 10001
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
            Me.Label1.Text = "模板名称"
            '
            'TextEdit_TemplateCode
            '
            Me.TextEdit_TemplateCode.EditValue = ""
            Me.TextEdit_TemplateCode.Location = New System.Drawing.Point(73, 13)
            Me.TextEdit_TemplateCode.Name = "TextEdit_TemplateCode"
            Me.TextEdit_TemplateCode.Size = New System.Drawing.Size(184, 21)
            Me.TextEdit_TemplateCode.TabIndex = 10000
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
            CTag6.ParentControl = Me.TextEdit_TemplateCode
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_TemplateCode.Tag = CTag6
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
            CTag7.ParentControl = Me.Label2
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag7
            Me.Label2.Text = "模板编号"
            '
            'GridControl_SaleTemplateWare
            '
            Me.GridControl_SaleTemplateWare.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_SaleTemplateWare.EmbeddedNavigator.Name = ""
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
            CTag9.ParentControl = Me.GridControl_SaleTemplateWare.EmbeddedNavigator
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_SaleTemplateWare.EmbeddedNavigator.Tag = CTag9
            Me.GridControl_SaleTemplateWare.Location = New System.Drawing.Point(0, 127)
            Me.GridControl_SaleTemplateWare.MainView = Me.GridView_SaleTemplateWare
            Me.GridControl_SaleTemplateWare.Name = "GridControl_SaleTemplateWare"
            Me.GridControl_SaleTemplateWare.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_TemplateID, Me.RepositoryItemLookUpEdit_WareID, Me.RepositoryItemLookUpEdit_DiscountType})
            Me.GridControl_SaleTemplateWare.Size = New System.Drawing.Size(741, 373)
            Me.GridControl_SaleTemplateWare.TabIndex = 10003
            Me.GridControl_SaleTemplateWare.TabStop = False
            Me.GridControl_SaleTemplateWare.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_SaleTemplateWare})
            '
            'GridView_SaleTemplateWare
            '
            Me.GridView_SaleTemplateWare.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_TemplateID, Me.GridColumn_WareID, Me.GridColumn_DiscountType, Me.GridColumn_DiscountAmount, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_SaleTemplateWare.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_SaleTemplateWare.GridControl = Me.GridControl_SaleTemplateWare
            Me.GridView_SaleTemplateWare.Name = "GridView_SaleTemplateWare"
            Me.GridView_SaleTemplateWare.OptionsView.ColumnAutoWidth = False
            Me.GridView_SaleTemplateWare.OptionsView.ShowFooter = True
            Me.GridView_SaleTemplateWare.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_TemplateID
            '
            Me.GridColumn_TemplateID.Caption = "模板编号"
            Me.GridColumn_TemplateID.ColumnEdit = Me.RepositoryItemLookUpEdit_TemplateID
            Me.GridColumn_TemplateID.FieldName = "TEMPLATE_ID"
            Me.GridColumn_TemplateID.Name = "GridColumn_TemplateID"
            Me.GridColumn_TemplateID.OptionsColumn.AllowFocus = False
            Me.GridColumn_TemplateID.SummaryItem.FieldName = "STAFF_CODE"
            Me.GridColumn_TemplateID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_TemplateID.Visible = True
            Me.GridColumn_TemplateID.VisibleIndex = 0
            '
            'RepositoryItemLookUpEdit_TemplateID
            '
            Me.RepositoryItemLookUpEdit_TemplateID.AutoHeight = False
            Me.RepositoryItemLookUpEdit_TemplateID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_TemplateID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEMPLATE_CODE", "Name1", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TemplateID.DisplayMember = "TEMPLATE_CODE"
            Me.RepositoryItemLookUpEdit_TemplateID.Name = "RepositoryItemLookUpEdit_TemplateID"
            Me.RepositoryItemLookUpEdit_TemplateID.ValueMember = "TEMPLATE_ID"
            '
            'GridColumn_WareID
            '
            Me.GridColumn_WareID.Caption = "货品名称"
            Me.GridColumn_WareID.ColumnEdit = Me.RepositoryItemLookUpEdit_WareID
            Me.GridColumn_WareID.FieldName = "WARE_ID"
            Me.GridColumn_WareID.Name = "GridColumn_WareID"
            Me.GridColumn_WareID.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareID.Visible = True
            Me.GridColumn_WareID.VisibleIndex = 1
            '
            'RepositoryItemLookUpEdit_WareID
            '
            Me.RepositoryItemLookUpEdit_WareID.AutoHeight = False
            Me.RepositoryItemLookUpEdit_WareID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_WareID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("WARE_NAME", "Name2", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_WareID.DisplayMember = "WARE_NAME"
            Me.RepositoryItemLookUpEdit_WareID.Name = "RepositoryItemLookUpEdit_WareID"
            Me.RepositoryItemLookUpEdit_WareID.ValueMember = "WARE_ID"
            '
            'GridColumn_DiscountType
            '
            Me.GridColumn_DiscountType.Caption = "折扣类型"
            Me.GridColumn_DiscountType.ColumnEdit = Me.RepositoryItemLookUpEdit_DiscountType
            Me.GridColumn_DiscountType.FieldName = "DISCOUNT_TYPE"
            Me.GridColumn_DiscountType.Name = "GridColumn_DiscountType"
            Me.GridColumn_DiscountType.OptionsColumn.AllowFocus = False
            Me.GridColumn_DiscountType.Visible = True
            Me.GridColumn_DiscountType.VisibleIndex = 2
            '
            'RepositoryItemLookUpEdit_DiscountType
            '
            Me.RepositoryItemLookUpEdit_DiscountType.AutoHeight = False
            Me.RepositoryItemLookUpEdit_DiscountType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_DiscountType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", "Name3", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_DiscountType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_DiscountType.Name = "RepositoryItemLookUpEdit_DiscountType"
            Me.RepositoryItemLookUpEdit_DiscountType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_DiscountAmount
            '
            Me.GridColumn_DiscountAmount.Caption = "折扣额度"
            Me.GridColumn_DiscountAmount.FieldName = "DISCOUNT_AMOUNT"
            Me.GridColumn_DiscountAmount.Name = "GridColumn_DiscountAmount"
            Me.GridColumn_DiscountAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_DiscountAmount.Visible = True
            Me.GridColumn_DiscountAmount.VisibleIndex = 3
            '
            'GridColumn_RowHighlight
            '
            Me.GridColumn_RowHighlight.Caption = "高亮显示"
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
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
            CTag10.ParentControl = Me
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag10
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            CType(Me.MemoEdit_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_TemplateName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_TemplateCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_SaleTemplateWare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_SaleTemplateWare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TemplateID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_WareID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_DiscountType, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_TemplateCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GridControl_SaleTemplateWare As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_SaleTemplateWare As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_TemplateID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_DiscountType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_DiscountAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_TemplateID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_WareID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_DiscountType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents MemoEdit_Remark As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_TemplateName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label

#End Region

    End Class

End Namespace

