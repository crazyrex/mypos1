Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00304
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_01_00304))
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
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.Label3 = New System.Windows.Forms.Label
            Me.TextEdit_LocationCode = New DevExpress.XtraEditors.TextEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.TextEdit_ShelfCode = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.TextEdit_AreaCode = New DevExpress.XtraEditors.TextEdit
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label_PosInfo = New System.Windows.Forms.Label
            Me.Label_PosID = New System.Windows.Forms.Label
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.TextEdit_LocationCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_ShelfCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_AreaCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            'Label3
            '
            Me.Label3.AccessibleDescription = Nothing
            Me.Label3.AccessibleName = Nothing
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
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
            CTag2.ParentControl = Me.Label3
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag2
            '
            'TextEdit_LocationCode
            '
            resources.ApplyResources(Me.TextEdit_LocationCode, "TextEdit_LocationCode")
            Me.TextEdit_LocationCode.BackgroundImage = Nothing
            Me.TextEdit_LocationCode.EditValue = Nothing
            Me.TextEdit_LocationCode.Name = "TextEdit_LocationCode"
            Me.TextEdit_LocationCode.Properties.AccessibleDescription = Nothing
            Me.TextEdit_LocationCode.Properties.AccessibleName = Nothing
            Me.TextEdit_LocationCode.Properties.AutoHeight = CType(resources.GetObject("TextEdit_LocationCode.Properties.AutoHeight"), Boolean)
            Me.TextEdit_LocationCode.Properties.Mask.AutoComplete = CType(resources.GetObject("TextEdit_LocationCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.TextEdit_LocationCode.Properties.Mask.BeepOnError = CType(resources.GetObject("TextEdit_LocationCode.Properties.Mask.BeepOnError"), Boolean)
            Me.TextEdit_LocationCode.Properties.Mask.EditMask = resources.GetString("TextEdit_LocationCode.Properties.Mask.EditMask")
            Me.TextEdit_LocationCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TextEdit_LocationCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.TextEdit_LocationCode.Properties.Mask.MaskType = CType(resources.GetObject("TextEdit_LocationCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.TextEdit_LocationCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("TextEdit_LocationCode.Properties.Mask.PlaceHolder"), Char)
            Me.TextEdit_LocationCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("TextEdit_LocationCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.TextEdit_LocationCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TextEdit_LocationCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.TextEdit_LocationCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TextEdit_LocationCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag3.ParentControl = Me.TextEdit_LocationCode
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_LocationCode.Tag = CTag3
            '
            'Label2
            '
            Me.Label2.AccessibleDescription = Nothing
            Me.Label2.AccessibleName = Nothing
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.Transparent
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
            'TextEdit_ShelfCode
            '
            resources.ApplyResources(Me.TextEdit_ShelfCode, "TextEdit_ShelfCode")
            Me.TextEdit_ShelfCode.BackgroundImage = Nothing
            Me.TextEdit_ShelfCode.EditValue = Nothing
            Me.TextEdit_ShelfCode.Name = "TextEdit_ShelfCode"
            Me.TextEdit_ShelfCode.Properties.AccessibleDescription = Nothing
            Me.TextEdit_ShelfCode.Properties.AccessibleName = Nothing
            Me.TextEdit_ShelfCode.Properties.AutoHeight = CType(resources.GetObject("TextEdit_ShelfCode.Properties.AutoHeight"), Boolean)
            Me.TextEdit_ShelfCode.Properties.Mask.AutoComplete = CType(resources.GetObject("TextEdit_ShelfCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.TextEdit_ShelfCode.Properties.Mask.BeepOnError = CType(resources.GetObject("TextEdit_ShelfCode.Properties.Mask.BeepOnError"), Boolean)
            Me.TextEdit_ShelfCode.Properties.Mask.EditMask = resources.GetString("TextEdit_ShelfCode.Properties.Mask.EditMask")
            Me.TextEdit_ShelfCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TextEdit_ShelfCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.TextEdit_ShelfCode.Properties.Mask.MaskType = CType(resources.GetObject("TextEdit_ShelfCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.TextEdit_ShelfCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("TextEdit_ShelfCode.Properties.Mask.PlaceHolder"), Char)
            Me.TextEdit_ShelfCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("TextEdit_ShelfCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.TextEdit_ShelfCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TextEdit_ShelfCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.TextEdit_ShelfCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TextEdit_ShelfCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag5.ParentControl = Me.TextEdit_ShelfCode
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_ShelfCode.Tag = CTag5
            '
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.Transparent
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
            'TextEdit_AreaCode
            '
            resources.ApplyResources(Me.TextEdit_AreaCode, "TextEdit_AreaCode")
            Me.TextEdit_AreaCode.BackgroundImage = Nothing
            Me.TextEdit_AreaCode.EditValue = Nothing
            Me.TextEdit_AreaCode.Name = "TextEdit_AreaCode"
            Me.TextEdit_AreaCode.Properties.AccessibleDescription = Nothing
            Me.TextEdit_AreaCode.Properties.AccessibleName = Nothing
            Me.TextEdit_AreaCode.Properties.AutoHeight = CType(resources.GetObject("TextEdit_AreaCode.Properties.AutoHeight"), Boolean)
            Me.TextEdit_AreaCode.Properties.Mask.AutoComplete = CType(resources.GetObject("TextEdit_AreaCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.TextEdit_AreaCode.Properties.Mask.BeepOnError = CType(resources.GetObject("TextEdit_AreaCode.Properties.Mask.BeepOnError"), Boolean)
            Me.TextEdit_AreaCode.Properties.Mask.EditMask = resources.GetString("TextEdit_AreaCode.Properties.Mask.EditMask")
            Me.TextEdit_AreaCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TextEdit_AreaCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.TextEdit_AreaCode.Properties.Mask.MaskType = CType(resources.GetObject("TextEdit_AreaCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.TextEdit_AreaCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("TextEdit_AreaCode.Properties.Mask.PlaceHolder"), Char)
            Me.TextEdit_AreaCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("TextEdit_AreaCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.TextEdit_AreaCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TextEdit_AreaCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.TextEdit_AreaCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TextEdit_AreaCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag7.ParentControl = Me.TextEdit_AreaCode
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_AreaCode.Tag = CTag7
            '
            'Label4
            '
            Me.Label4.AccessibleDescription = Nothing
            Me.Label4.AccessibleName = Nothing
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Name = "Label4"
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
            CTag8.ParentControl = Me.Label4
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag8
            '
            'Label_PosInfo
            '
            Me.Label_PosInfo.AccessibleDescription = Nothing
            Me.Label_PosInfo.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_PosInfo, "Label_PosInfo")
            Me.Label_PosInfo.BackColor = System.Drawing.Color.Transparent
            Me.Label_PosInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_PosInfo.ForeColor = System.Drawing.Color.Black
            Me.Label_PosInfo.Name = "Label_PosInfo"
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
            CTag9.ParentControl = Me.Label_PosInfo
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label_PosInfo.Tag = CTag9
            '
            'Label_PosID
            '
            Me.Label_PosID.AccessibleDescription = Nothing
            Me.Label_PosID.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_PosID, "Label_PosID")
            Me.Label_PosID.BackColor = System.Drawing.Color.Transparent
            Me.Label_PosID.ForeColor = System.Drawing.Color.Black
            Me.Label_PosID.Name = "Label_PosID"
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
            CTag10.ParentControl = Me.Label_PosID
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Label_PosID.Tag = CTag10
            '
            'M_01_00304
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.Label_PosID)
            Me.Controls.Add(Me.Label_PosInfo)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TextEdit_LocationCode)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TextEdit_ShelfCode)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TextEdit_AreaCode)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_01_00304"
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
            CType(Me.TextEdit_LocationCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_ShelfCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_AreaCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_LocationCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_ShelfCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_AreaCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label_PosInfo As System.Windows.Forms.Label
        Friend WithEvents Label_PosID As System.Windows.Forms.Label

#End Region

    End Class

End Namespace
