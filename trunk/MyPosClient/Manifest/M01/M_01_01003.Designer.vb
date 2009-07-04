Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_01003
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
        Friend WithEvents ToolStripButton_Save As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_ShowFilter As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Report As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_View As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
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
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ShowFilter = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Report = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label_WareName = New System.Windows.Forms.Label
            Me.Label_WareID = New System.Windows.Forms.Label
            Me.Label_TemplateName = New System.Windows.Forms.Label
            Me.Label_TemplateID = New System.Windows.Forms.Label
            Me.ButtonEdit_TemplateCode = New DevExpress.XtraEditors.ButtonEdit
            Me.ButtonEdit_WareCode = New DevExpress.XtraEditors.ButtonEdit
            Me.LookUpEdit_DiscountType = New DevExpress.XtraEditors.LookUpEdit
            Me.CalcEdit_DisCountAmount = New DevExpress.XtraEditors.CalcEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.ButtonEdit_TemplateCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_DiscountType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CalcEdit_DisCountAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Save, Me.ToolStripButton_ShowFilter, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_Report, Me.ToolStripButton_View, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
            Me.ToolStrip_Form.Size = New System.Drawing.Size(374, 25)
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
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            Me.ToolStripButton_Save.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Save.Text = "保存"
            '
            'ToolStripButton_ShowFilter
            '
            Me.ToolStripButton_ShowFilter.Name = "ToolStripButton_ShowFilter"
            Me.ToolStripButton_ShowFilter.Size = New System.Drawing.Size(57, 22)
            Me.ToolStripButton_ShowFilter.Text = "筛选条件"
            Me.ToolStripButton_ShowFilter.Visible = False
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            Me.ToolStripButton_Revise.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Revise.Text = "修改"
            Me.ToolStripButton_Revise.Visible = False
            '
            'ToolStripButton_Delete
            '
            Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
            Me.ToolStripButton_Delete.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Delete.Text = "删除"
            Me.ToolStripButton_Delete.Visible = False
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
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label2.Location = New System.Drawing.Point(16, 48)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 20)
            Me.Label2.TabIndex = 10001
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
            CTag2.ParentControl = Me.Label2
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag2
            Me.Label2.Text = "模板编号"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(16, 104)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(60, 20)
            Me.Label1.TabIndex = 10002
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
            CTag3.ParentControl = Me.Label1
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag3
            Me.Label1.Text = "折扣类型"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label3.Location = New System.Drawing.Point(16, 76)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(60, 20)
            Me.Label3.TabIndex = 10003
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
            Me.Label3.Text = "货品代码"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.White
            Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label4.Location = New System.Drawing.Point(16, 132)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(60, 20)
            Me.Label4.TabIndex = 10004
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
            CTag5.ParentControl = Me.Label4
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag5
            Me.Label4.Text = "折扣额度"
            '
            'Label_WareName
            '
            Me.Label_WareName.BackColor = System.Drawing.Color.White
            Me.Label_WareName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_WareName.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_WareName.ForeColor = System.Drawing.Color.Black
            Me.Label_WareName.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_WareName.Location = New System.Drawing.Point(215, 78)
            Me.Label_WareName.Name = "Label_WareName"
            Me.Label_WareName.Size = New System.Drawing.Size(141, 20)
            Me.Label_WareName.TabIndex = 10005
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
            CTag6.ParentControl = Me.Label_WareName
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareName.Tag = CTag6
            '
            'Label_WareID
            '
            Me.Label_WareID.BackColor = System.Drawing.Color.White
            Me.Label_WareID.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_WareID.ForeColor = System.Drawing.Color.Black
            Me.Label_WareID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_WareID.Location = New System.Drawing.Point(305, 98)
            Me.Label_WareID.Name = "Label_WareID"
            Me.Label_WareID.Size = New System.Drawing.Size(40, 20)
            Me.Label_WareID.TabIndex = 10006
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
            CTag7.ParentControl = Me.Label_WareID
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareID.Tag = CTag7
            Me.Label_WareID.Text = "W_ID"
            Me.Label_WareID.Visible = False
            '
            'Label_TemplateName
            '
            Me.Label_TemplateName.BackColor = System.Drawing.Color.White
            Me.Label_TemplateName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_TemplateName.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_TemplateName.ForeColor = System.Drawing.Color.Black
            Me.Label_TemplateName.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_TemplateName.Location = New System.Drawing.Point(215, 48)
            Me.Label_TemplateName.Name = "Label_TemplateName"
            Me.Label_TemplateName.Size = New System.Drawing.Size(141, 20)
            Me.Label_TemplateName.TabIndex = 10007
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
            CTag8.ParentControl = Me.Label_TemplateName
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label_TemplateName.Tag = CTag8
            '
            'Label_TemplateID
            '
            Me.Label_TemplateID.BackColor = System.Drawing.Color.White
            Me.Label_TemplateID.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_TemplateID.ForeColor = System.Drawing.Color.Black
            Me.Label_TemplateID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_TemplateID.Location = New System.Drawing.Point(257, 28)
            Me.Label_TemplateID.Name = "Label_TemplateID"
            Me.Label_TemplateID.Size = New System.Drawing.Size(34, 20)
            Me.Label_TemplateID.TabIndex = 10008
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
            CTag9.ParentControl = Me.Label_TemplateID
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label_TemplateID.Tag = CTag9
            Me.Label_TemplateID.Text = "T_ID"
            Me.Label_TemplateID.Visible = False
            '
            'ButtonEdit_TemplateCode
            '
            Me.ButtonEdit_TemplateCode.Location = New System.Drawing.Point(82, 47)
            Me.ButtonEdit_TemplateCode.Name = "ButtonEdit_TemplateCode"
            Me.ButtonEdit_TemplateCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_TemplateCode.Size = New System.Drawing.Size(127, 21)
            Me.ButtonEdit_TemplateCode.TabIndex = 10000
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
            CTag10.ParentControl = Me.ButtonEdit_TemplateCode
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_TemplateCode.Tag = CTag10
            '
            'ButtonEdit_WareCode
            '
            Me.ButtonEdit_WareCode.Location = New System.Drawing.Point(82, 75)
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_WareCode.Size = New System.Drawing.Size(127, 21)
            Me.ButtonEdit_WareCode.TabIndex = 10009
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
            CTag11.ParentControl = Me.ButtonEdit_WareCode
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_WareCode.Tag = CTag11
            '
            'LookUpEdit_DiscountType
            '
            Me.LookUpEdit_DiscountType.Location = New System.Drawing.Point(82, 103)
            Me.LookUpEdit_DiscountType.Name = "LookUpEdit_DiscountType"
            Me.LookUpEdit_DiscountType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LookUpEdit_DiscountType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", "Name4", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_DiscountType.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_DiscountType.Properties.NullText = ""
            Me.LookUpEdit_DiscountType.Properties.ValueMember = "ITEM_VALUE"
            Me.LookUpEdit_DiscountType.Size = New System.Drawing.Size(127, 21)
            Me.LookUpEdit_DiscountType.TabIndex = 10000
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
            CTag12.ParentControl = Me.LookUpEdit_DiscountType
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_DiscountType.Tag = CTag12
            '
            'CalcEdit_DisCountAmount
            '
            Me.CalcEdit_DisCountAmount.Location = New System.Drawing.Point(82, 131)
            Me.CalcEdit_DisCountAmount.Name = "CalcEdit_DisCountAmount"
            Me.CalcEdit_DisCountAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.CalcEdit_DisCountAmount.Size = New System.Drawing.Size(127, 21)
            Me.CalcEdit_DisCountAmount.TabIndex = 10000
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
            CTag13.ParentControl = Me.CalcEdit_DisCountAmount
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.CalcEdit_DisCountAmount.Tag = CTag13
            '
            'M_01_01003
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.CalcEdit_DisCountAmount)
            Me.Controls.Add(Me.LookUpEdit_DiscountType)
            Me.Controls.Add(Me.ButtonEdit_WareCode)
            Me.Controls.Add(Me.ButtonEdit_TemplateCode)
            Me.Controls.Add(Me.Label_TemplateID)
            Me.Controls.Add(Me.Label_TemplateName)
            Me.Controls.Add(Me.Label_WareID)
            Me.Controls.Add(Me.Label_WareName)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_01_01003"
            Me.Size = New System.Drawing.Size(374, 170)
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
            CType(Me.ButtonEdit_TemplateCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_DiscountType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CalcEdit_DisCountAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label_WareName As System.Windows.Forms.Label
        Friend WithEvents Label_WareID As System.Windows.Forms.Label
        Friend WithEvents Label_TemplateName As System.Windows.Forms.Label
        Friend WithEvents Label_TemplateID As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_TemplateCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents ButtonEdit_WareCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents LookUpEdit_DiscountType As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents CalcEdit_DisCountAmount As DevExpress.XtraEditors.CalcEdit

#End Region

    End Class

End Namespace

