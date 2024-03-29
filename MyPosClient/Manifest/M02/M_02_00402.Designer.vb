Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00402
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
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00402))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.Label_EmployeeID = New System.Windows.Forms.Label
            Me.Label_EmployeeName = New System.Windows.Forms.Label
            Me.ButtonEdit_EmployeeCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.CalcEdit_CommissionAmount = New DevExpress.XtraEditors.CalcEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.ButtonEdit_EmployeeCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CalcEdit_CommissionAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.AccessibleDescription = Nothing
            Me.ToolStrip_Form.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStrip_Form, "ToolStrip_Form")
            Me.ToolStrip_Form.BackgroundImage = Nothing
            Me.ToolStrip_Form.Font = Nothing
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Save, Me.ToolStripButton_Close})
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
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.AccessibleDescription = Nothing
            Me.ToolStripButton_Save.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Save, "ToolStripButton_Save")
            Me.ToolStripButton_Save.BackgroundImage = Nothing
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.AccessibleDescription = Nothing
            Me.ToolStripButton_Close.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Close, "ToolStripButton_Close")
            Me.ToolStripButton_Close.BackgroundImage = Nothing
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            '
            'Label_EmployeeID
            '
            Me.Label_EmployeeID.AccessibleDescription = Nothing
            Me.Label_EmployeeID.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_EmployeeID, "Label_EmployeeID")
            Me.Label_EmployeeID.BackColor = System.Drawing.Color.White
            Me.Label_EmployeeID.ForeColor = System.Drawing.Color.Black
            Me.Label_EmployeeID.Name = "Label_EmployeeID"
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
            CTag2.ParentControl = Me.Label_EmployeeID
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label_EmployeeID.Tag = CTag2
            '
            'Label_EmployeeName
            '
            Me.Label_EmployeeName.AccessibleDescription = Nothing
            Me.Label_EmployeeName.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_EmployeeName, "Label_EmployeeName")
            Me.Label_EmployeeName.BackColor = System.Drawing.Color.White
            Me.Label_EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_EmployeeName.ForeColor = System.Drawing.Color.Black
            Me.Label_EmployeeName.Name = "Label_EmployeeName"
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
            CTag3.ParentControl = Me.Label_EmployeeName
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_EmployeeName.Tag = CTag3
            '
            'ButtonEdit_EmployeeCode
            '
            resources.ApplyResources(Me.ButtonEdit_EmployeeCode, "ButtonEdit_EmployeeCode")
            Me.ButtonEdit_EmployeeCode.BackgroundImage = Nothing
            Me.ButtonEdit_EmployeeCode.EditValue = Nothing
            Me.ButtonEdit_EmployeeCode.Name = "ButtonEdit_EmployeeCode"
            Me.ButtonEdit_EmployeeCode.Properties.AccessibleDescription = Nothing
            Me.ButtonEdit_EmployeeCode.Properties.AccessibleName = Nothing
            Me.ButtonEdit_EmployeeCode.Properties.AutoHeight = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.AutoHeight"), Boolean)
            Me.ButtonEdit_EmployeeCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_EmployeeCode.Properties.Mask.AutoComplete = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.BeepOnError = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.BeepOnError"), Boolean)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.EditMask = resources.GetString("ButtonEdit_EmployeeCode.Properties.Mask.EditMask")
            Me.ButtonEdit_EmployeeCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.MaskType = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.PlaceHolder"), Char)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.ButtonEdit_EmployeeCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ButtonEdit_EmployeeCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag4.ParentControl = Me.ButtonEdit_EmployeeCode
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_EmployeeCode.Tag = CTag4
            '
            'Label4
            '
            Me.Label4.AccessibleDescription = Nothing
            Me.Label4.AccessibleName = Nothing
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.BackColor = System.Drawing.Color.White
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Name = "Label4"
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
            '
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
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
            'CalcEdit_CommissionAmount
            '
            resources.ApplyResources(Me.CalcEdit_CommissionAmount, "CalcEdit_CommissionAmount")
            Me.CalcEdit_CommissionAmount.BackgroundImage = Nothing
            Me.CalcEdit_CommissionAmount.EditValue = Nothing
            Me.CalcEdit_CommissionAmount.Name = "CalcEdit_CommissionAmount"
            Me.CalcEdit_CommissionAmount.Properties.AccessibleDescription = Nothing
            Me.CalcEdit_CommissionAmount.Properties.AccessibleName = Nothing
            Me.CalcEdit_CommissionAmount.Properties.AutoHeight = CType(resources.GetObject("CalcEdit_CommissionAmount.Properties.AutoHeight"), Boolean)
            Me.CalcEdit_CommissionAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.CalcEdit_CommissionAmount.Properties.Mask.AutoComplete = CType(resources.GetObject("CalcEdit_CommissionAmount.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.CalcEdit_CommissionAmount.Properties.Mask.BeepOnError = CType(resources.GetObject("CalcEdit_CommissionAmount.Properties.Mask.BeepOnError"), Boolean)
            Me.CalcEdit_CommissionAmount.Properties.Mask.EditMask = resources.GetString("CalcEdit_CommissionAmount.Properties.Mask.EditMask")
            Me.CalcEdit_CommissionAmount.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("CalcEdit_CommissionAmount.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.CalcEdit_CommissionAmount.Properties.Mask.MaskType = CType(resources.GetObject("CalcEdit_CommissionAmount.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.CalcEdit_CommissionAmount.Properties.Mask.PlaceHolder = CType(resources.GetObject("CalcEdit_CommissionAmount.Properties.Mask.PlaceHolder"), Char)
            Me.CalcEdit_CommissionAmount.Properties.Mask.SaveLiteral = CType(resources.GetObject("CalcEdit_CommissionAmount.Properties.Mask.SaveLiteral"), Boolean)
            Me.CalcEdit_CommissionAmount.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("CalcEdit_CommissionAmount.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.CalcEdit_CommissionAmount.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("CalcEdit_CommissionAmount.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag7.ParentControl = Me.CalcEdit_CommissionAmount
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.CalcEdit_CommissionAmount.Tag = CTag7
            '
            'M_02_00402
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.CalcEdit_CommissionAmount)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label_EmployeeID)
            Me.Controls.Add(Me.Label_EmployeeName)
            Me.Controls.Add(Me.ButtonEdit_EmployeeCode)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_00402"
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
            CTag8.ParentControl = Me
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag8
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.ButtonEdit_EmployeeCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CalcEdit_CommissionAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label_EmployeeID As System.Windows.Forms.Label
        Friend WithEvents Label_EmployeeName As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_EmployeeCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents CalcEdit_CommissionAmount As DevExpress.XtraEditors.CalcEdit

#End Region

    End Class

End Namespace
