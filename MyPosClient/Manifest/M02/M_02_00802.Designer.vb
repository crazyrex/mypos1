Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00802
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
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00802))
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
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.Label1 = New System.Windows.Forms.Label
            Me.TextEdit_PractWareCode = New DevExpress.XtraEditors.TextEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label_CodePrefiew = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label_WareID = New System.Windows.Forms.Label
            Me.Label_CustomCode = New System.Windows.Forms.Label
            Me.ButtonEdit_WareCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label18 = New System.Windows.Forms.Label
            Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
            Me.CheckEdit_PrintLabel = New DevExpress.XtraEditors.CheckEdit
            Me.SpinEdit_CreateAmount = New DevExpress.XtraEditors.SpinEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.TextEdit_PractWareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl1.SuspendLayout()
            CType(Me.CheckEdit_PrintLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SpinEdit_CreateAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Create, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
            Me.ToolStrip_Form.Size = New System.Drawing.Size(356, 25)
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
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Create.Image = CType(resources.GetObject("ToolStripButton_Create.Image"), System.Drawing.Image)
            Me.ToolStripButton_Create.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            Me.ToolStripButton_Create.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Create.Text = "创建"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Close.Text = "关闭"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(3, 59)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(67, 15)
            Me.Label1.TabIndex = 10002
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
            CTag2.ParentControl = Me.Label1
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag2
            Me.Label1.Text = "登记序列号"
            '
            'TextEdit_PractWareCode
            '
            Me.TextEdit_PractWareCode.Location = New System.Drawing.Point(76, 56)
            Me.TextEdit_PractWareCode.Name = "TextEdit_PractWareCode"
            Me.TextEdit_PractWareCode.Size = New System.Drawing.Size(260, 21)
            Me.TextEdit_PractWareCode.TabIndex = 10001
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
            CTag3.ParentControl = Me.TextEdit_PractWareCode
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_PractWareCode.Tag = CTag3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Location = New System.Drawing.Point(15, 27)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(31, 15)
            Me.Label2.TabIndex = 10000
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
            Me.Label2.Text = "预览"
            '
            'Label_CodePrefiew
            '
            Me.Label_CodePrefiew.BackColor = System.Drawing.Color.White
            Me.Label_CodePrefiew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_CodePrefiew.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_CodePrefiew.ForeColor = System.Drawing.Color.Black
            Me.Label_CodePrefiew.Location = New System.Drawing.Point(76, 27)
            Me.Label_CodePrefiew.Name = "Label_CodePrefiew"
            Me.Label_CodePrefiew.Size = New System.Drawing.Size(260, 22)
            Me.Label_CodePrefiew.TabIndex = 10000
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
            CTag5.ParentControl = Me.Label_CodePrefiew
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CodePrefiew.Tag = CTag5
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.White
            Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(14, 58)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(31, 15)
            Me.Label4.TabIndex = 10000
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
            CTag6.ParentControl = Me.Label4
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag6
            Me.Label4.Text = "数量"
            '
            'Label_WareID
            '
            Me.Label_WareID.BackColor = System.Drawing.Color.White
            Me.Label_WareID.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_WareID.ForeColor = System.Drawing.Color.Black
            Me.Label_WareID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_WareID.Location = New System.Drawing.Point(341, 30)
            Me.Label_WareID.Name = "Label_WareID"
            Me.Label_WareID.Size = New System.Drawing.Size(25, 18)
            Me.Label_WareID.TabIndex = 10005
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
            Me.Label_WareID.Text = "ID"
            Me.Label_WareID.Visible = False
            '
            'Label_CustomCode
            '
            Me.Label_CustomCode.BackColor = System.Drawing.Color.White
            Me.Label_CustomCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_CustomCode.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_CustomCode.ForeColor = System.Drawing.Color.Black
            Me.Label_CustomCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_CustomCode.Location = New System.Drawing.Point(198, 30)
            Me.Label_CustomCode.Name = "Label_CustomCode"
            Me.Label_CustomCode.Size = New System.Drawing.Size(137, 18)
            Me.Label_CustomCode.TabIndex = 10006
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
            CTag8.ParentControl = Me.Label_CustomCode
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomCode.Tag = CTag8
            '
            'ButtonEdit_WareCode
            '
            Me.ButtonEdit_WareCode.Location = New System.Drawing.Point(76, 28)
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_WareCode.Size = New System.Drawing.Size(116, 21)
            Me.ButtonEdit_WareCode.TabIndex = 10003
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
            CTag9.ParentControl = Me.ButtonEdit_WareCode
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_WareCode.Tag = CTag9
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.BackColor = System.Drawing.Color.White
            Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label18.ForeColor = System.Drawing.Color.Black
            Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label18.Location = New System.Drawing.Point(3, 30)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(55, 15)
            Me.Label18.TabIndex = 10004
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
            CTag10.ParentControl = Me.Label18
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Label18.Tag = CTag10
            Me.Label18.Text = "货品代码"
            '
            'GroupControl1
            '
            Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.GroupControl1.Appearance.Options.UseBackColor = True
            Me.GroupControl1.Controls.Add(Me.CheckEdit_PrintLabel)
            Me.GroupControl1.Controls.Add(Me.SpinEdit_CreateAmount)
            Me.GroupControl1.Controls.Add(Me.Label_CodePrefiew)
            Me.GroupControl1.Controls.Add(Me.Label4)
            Me.GroupControl1.Controls.Add(Me.Label2)
            Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.GroupControl1.Location = New System.Drawing.Point(0, 83)
            Me.GroupControl1.Name = "GroupControl1"
            Me.GroupControl1.Size = New System.Drawing.Size(356, 81)
            Me.GroupControl1.TabIndex = 10000
            Me.GroupControl1.Text = "自动新建"
            '
            'CheckEdit_PrintLabel
            '
            Me.CheckEdit_PrintLabel.Location = New System.Drawing.Point(143, 52)
            Me.CheckEdit_PrintLabel.Name = "CheckEdit_PrintLabel"
            Me.CheckEdit_PrintLabel.Properties.Caption = "打印标签"
            Me.CheckEdit_PrintLabel.Size = New System.Drawing.Size(88, 19)
            Me.CheckEdit_PrintLabel.TabIndex = 10002
            '
            'SpinEdit_CreateAmount
            '
            Me.SpinEdit_CreateAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.SpinEdit_CreateAmount.Location = New System.Drawing.Point(75, 52)
            Me.SpinEdit_CreateAmount.Name = "SpinEdit_CreateAmount"
            Me.SpinEdit_CreateAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.SpinEdit_CreateAmount.Size = New System.Drawing.Size(53, 21)
            Me.SpinEdit_CreateAmount.TabIndex = 10001
            '
            'M_02_00802
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.Label_WareID)
            Me.Controls.Add(Me.Label_CustomCode)
            Me.Controls.Add(Me.ButtonEdit_WareCode)
            Me.Controls.Add(Me.Label18)
            Me.Controls.Add(Me.GroupControl1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TextEdit_PractWareCode)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_02_00802"
            Me.Size = New System.Drawing.Size(356, 164)
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
            CType(Me.TextEdit_PractWareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl1.ResumeLayout(False)
            Me.GroupControl1.PerformLayout()
            CType(Me.CheckEdit_PrintLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SpinEdit_CreateAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_PractWareCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label_CodePrefiew As System.Windows.Forms.Label
        Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents SpinEdit_CreateAmount As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents ToolStripButton_Create As System.Windows.Forms.ToolStripButton
        Friend WithEvents CheckEdit_PrintLabel As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents Label_WareID As System.Windows.Forms.Label
        Friend WithEvents Label_CustomCode As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_WareCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label18 As System.Windows.Forms.Label

#End Region

    End Class

End Namespace
