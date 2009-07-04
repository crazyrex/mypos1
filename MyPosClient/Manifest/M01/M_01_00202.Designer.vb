Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00202
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_01_00202))
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
            Me.Label1 = New System.Windows.Forms.Label
            Me.TextEdit_WareClassifyCode = New DevExpress.XtraEditors.TextEdit
            Me.TextEdit_WareClassifyName = New DevExpress.XtraEditors.TextEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.MemoEdit_Remark = New DevExpress.XtraEditors.MemoEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.TextEdit_WareClassifyCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_WareClassifyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MemoEdit_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
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
            '
            'TextEdit_WareClassifyCode
            '
            resources.ApplyResources(Me.TextEdit_WareClassifyCode, "TextEdit_WareClassifyCode")
            Me.TextEdit_WareClassifyCode.BackgroundImage = Nothing
            Me.TextEdit_WareClassifyCode.EditValue = Nothing
            Me.TextEdit_WareClassifyCode.Name = "TextEdit_WareClassifyCode"
            Me.TextEdit_WareClassifyCode.Properties.AccessibleDescription = Nothing
            Me.TextEdit_WareClassifyCode.Properties.AccessibleName = Nothing
            Me.TextEdit_WareClassifyCode.Properties.AutoHeight = CType(resources.GetObject("TextEdit_WareClassifyCode.Properties.AutoHeight"), Boolean)
            Me.TextEdit_WareClassifyCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextEdit_WareClassifyCode.Properties.Mask.AutoComplete = CType(resources.GetObject("TextEdit_WareClassifyCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.TextEdit_WareClassifyCode.Properties.Mask.BeepOnError = CType(resources.GetObject("TextEdit_WareClassifyCode.Properties.Mask.BeepOnError"), Boolean)
            Me.TextEdit_WareClassifyCode.Properties.Mask.EditMask = resources.GetString("TextEdit_WareClassifyCode.Properties.Mask.EditMask")
            Me.TextEdit_WareClassifyCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TextEdit_WareClassifyCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.TextEdit_WareClassifyCode.Properties.Mask.MaskType = CType(resources.GetObject("TextEdit_WareClassifyCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.TextEdit_WareClassifyCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("TextEdit_WareClassifyCode.Properties.Mask.PlaceHolder"), Char)
            Me.TextEdit_WareClassifyCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("TextEdit_WareClassifyCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.TextEdit_WareClassifyCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TextEdit_WareClassifyCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.TextEdit_WareClassifyCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TextEdit_WareClassifyCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag3.ParentControl = Me.TextEdit_WareClassifyCode
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_WareClassifyCode.Tag = CTag3
            '
            'TextEdit_WareClassifyName
            '
            resources.ApplyResources(Me.TextEdit_WareClassifyName, "TextEdit_WareClassifyName")
            Me.TextEdit_WareClassifyName.BackgroundImage = Nothing
            Me.TextEdit_WareClassifyName.EditValue = Nothing
            Me.TextEdit_WareClassifyName.Name = "TextEdit_WareClassifyName"
            Me.TextEdit_WareClassifyName.Properties.AccessibleDescription = Nothing
            Me.TextEdit_WareClassifyName.Properties.AccessibleName = Nothing
            Me.TextEdit_WareClassifyName.Properties.AutoHeight = CType(resources.GetObject("TextEdit_WareClassifyName.Properties.AutoHeight"), Boolean)
            Me.TextEdit_WareClassifyName.Properties.Mask.AutoComplete = CType(resources.GetObject("TextEdit_WareClassifyName.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.TextEdit_WareClassifyName.Properties.Mask.BeepOnError = CType(resources.GetObject("TextEdit_WareClassifyName.Properties.Mask.BeepOnError"), Boolean)
            Me.TextEdit_WareClassifyName.Properties.Mask.EditMask = resources.GetString("TextEdit_WareClassifyName.Properties.Mask.EditMask")
            Me.TextEdit_WareClassifyName.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TextEdit_WareClassifyName.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.TextEdit_WareClassifyName.Properties.Mask.MaskType = CType(resources.GetObject("TextEdit_WareClassifyName.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.TextEdit_WareClassifyName.Properties.Mask.PlaceHolder = CType(resources.GetObject("TextEdit_WareClassifyName.Properties.Mask.PlaceHolder"), Char)
            Me.TextEdit_WareClassifyName.Properties.Mask.SaveLiteral = CType(resources.GetObject("TextEdit_WareClassifyName.Properties.Mask.SaveLiteral"), Boolean)
            Me.TextEdit_WareClassifyName.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TextEdit_WareClassifyName.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.TextEdit_WareClassifyName.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TextEdit_WareClassifyName.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag4.ParentControl = Me.TextEdit_WareClassifyName
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_WareClassifyName.Tag = CTag4
            '
            'Label2
            '
            Me.Label2.AccessibleDescription = Nothing
            Me.Label2.AccessibleName = Nothing
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
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
            CTag5.ParentControl = Me.Label2
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag5
            '
            'Label3
            '
            Me.Label3.AccessibleDescription = Nothing
            Me.Label3.AccessibleName = Nothing
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
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
            '
            'MemoEdit_Remark
            '
            resources.ApplyResources(Me.MemoEdit_Remark, "MemoEdit_Remark")
            Me.MemoEdit_Remark.BackgroundImage = Nothing
            Me.MemoEdit_Remark.EditValue = Nothing
            Me.MemoEdit_Remark.Name = "MemoEdit_Remark"
            Me.MemoEdit_Remark.Properties.AccessibleDescription = Nothing
            Me.MemoEdit_Remark.Properties.AccessibleName = Nothing
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
            CTag7.ParentControl = Me.MemoEdit_Remark
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.MemoEdit_Remark.Tag = CTag7
            '
            'M_01_00202
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.MemoEdit_Remark)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TextEdit_WareClassifyName)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TextEdit_WareClassifyCode)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_01_00202"
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
            CType(Me.TextEdit_WareClassifyCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_WareClassifyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MemoEdit_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_WareClassifyCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TextEdit_WareClassifyName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents MemoEdit_Remark As DevExpress.XtraEditors.MemoEdit

#End Region

    End Class

End Namespace
