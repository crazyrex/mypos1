Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00603
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
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_01_00603))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Import = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_AutoSupplierCode = New DevExpress.XtraEditors.CheckEdit
            Me.RadioGroup_DistinguishBy = New DevExpress.XtraEditors.RadioGroup
            Me.Label2 = New System.Windows.Forms.Label
            Me.ButtonEdit_FileName = New DevExpress.XtraEditors.ButtonEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_Supplier = New DevExpress.XtraGrid.GridControl
            Me.GridView_Supplier = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_RowSelected = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_RowSelected = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.GridColumn_SupplierCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Address = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WorkPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Fax = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Linkman = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CellPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Email = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Title = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Department = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PostCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_HomePhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_City = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_State = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Country = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WebSite = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighLight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.OpenFileDialog_ImportFile = New System.Windows.Forms.OpenFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.CheckEdit_AutoSupplierCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadioGroup_DistinguishBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_FileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_RowSelected, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Import, Me.ToolStripButton_Remove, Me.ToolStripButton_Close})
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
            'ToolStripButton_Import
            '
            Me.ToolStripButton_Import.AccessibleDescription = Nothing
            Me.ToolStripButton_Import.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Import, "ToolStripButton_Import")
            Me.ToolStripButton_Import.BackgroundImage = Nothing
            Me.ToolStripButton_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Import.Name = "ToolStripButton_Import"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.AccessibleDescription = Nothing
            Me.ToolStripButton_Remove.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Remove, "ToolStripButton_Remove")
            Me.ToolStripButton_Remove.BackgroundImage = Nothing
            Me.ToolStripButton_Remove.Name = "ToolStripButton_Remove"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.AccessibleDescription = Nothing
            Me.ToolStripButton_Close.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Close, "ToolStripButton_Close")
            Me.ToolStripButton_Close.BackgroundImage = Nothing
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            '
            'PanelControl1
            '
            Me.PanelControl1.AccessibleDescription = Nothing
            Me.PanelControl1.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl1, "PanelControl1")
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.BackgroundImage = Nothing
            Me.PanelControl1.Controls.Add(Me.CheckEdit_AutoSupplierCode)
            Me.PanelControl1.Controls.Add(Me.RadioGroup_DistinguishBy)
            Me.PanelControl1.Controls.Add(Me.Label2)
            Me.PanelControl1.Controls.Add(Me.ButtonEdit_FileName)
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Name = "PanelControl1"
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
            CTag7.ParentControl = Me.PanelControl1
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag7
            '
            'CheckEdit_AutoSupplierCode
            '
            resources.ApplyResources(Me.CheckEdit_AutoSupplierCode, "CheckEdit_AutoSupplierCode")
            Me.CheckEdit_AutoSupplierCode.BackgroundImage = Nothing
            Me.CheckEdit_AutoSupplierCode.Name = "CheckEdit_AutoSupplierCode"
            Me.CheckEdit_AutoSupplierCode.Properties.AccessibleDescription = Nothing
            Me.CheckEdit_AutoSupplierCode.Properties.AccessibleName = Nothing
            Me.CheckEdit_AutoSupplierCode.Properties.AutoHeight = CType(resources.GetObject("CheckEdit_AutoSupplierCode.Properties.AutoHeight"), Boolean)
            Me.CheckEdit_AutoSupplierCode.Properties.Caption = resources.GetString("CheckEdit_AutoSupplierCode.Properties.Caption")
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
            CTag2.ParentControl = Me.CheckEdit_AutoSupplierCode
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_AutoSupplierCode.Tag = CTag2
            '
            'RadioGroup_DistinguishBy
            '
            resources.ApplyResources(Me.RadioGroup_DistinguishBy, "RadioGroup_DistinguishBy")
            Me.RadioGroup_DistinguishBy.BackgroundImage = Nothing
            Me.RadioGroup_DistinguishBy.EditValue = Nothing
            Me.RadioGroup_DistinguishBy.Name = "RadioGroup_DistinguishBy"
            Me.RadioGroup_DistinguishBy.Properties.AccessibleDescription = Nothing
            Me.RadioGroup_DistinguishBy.Properties.AccessibleName = Nothing
            Me.RadioGroup_DistinguishBy.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "ID"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Name")})
            Me.RadioGroup_DistinguishBy.TabStop = False
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
            CTag3.ParentControl = Me.RadioGroup_DistinguishBy
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.RadioGroup_DistinguishBy.Tag = CTag3
            '
            'Label2
            '
            Me.Label2.AccessibleDescription = Nothing
            Me.Label2.AccessibleName = Nothing
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
            'ButtonEdit_FileName
            '
            resources.ApplyResources(Me.ButtonEdit_FileName, "ButtonEdit_FileName")
            Me.ButtonEdit_FileName.BackgroundImage = Nothing
            Me.ButtonEdit_FileName.EditValue = Nothing
            Me.ButtonEdit_FileName.Name = "ButtonEdit_FileName"
            Me.ButtonEdit_FileName.Properties.AccessibleDescription = Nothing
            Me.ButtonEdit_FileName.Properties.AccessibleName = Nothing
            Me.ButtonEdit_FileName.Properties.AutoHeight = CType(resources.GetObject("ButtonEdit_FileName.Properties.AutoHeight"), Boolean)
            Me.ButtonEdit_FileName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_FileName.Properties.Mask.AutoComplete = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.ButtonEdit_FileName.Properties.Mask.BeepOnError = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.BeepOnError"), Boolean)
            Me.ButtonEdit_FileName.Properties.Mask.EditMask = resources.GetString("ButtonEdit_FileName.Properties.Mask.EditMask")
            Me.ButtonEdit_FileName.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.ButtonEdit_FileName.Properties.Mask.MaskType = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.ButtonEdit_FileName.Properties.Mask.PlaceHolder = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.PlaceHolder"), Char)
            Me.ButtonEdit_FileName.Properties.Mask.SaveLiteral = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.SaveLiteral"), Boolean)
            Me.ButtonEdit_FileName.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.ButtonEdit_FileName.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ButtonEdit_FileName.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag5.ParentControl = Me.ButtonEdit_FileName
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_FileName.Tag = CTag5
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
            'GridControl_Supplier
            '
            Me.GridControl_Supplier.AccessibleDescription = Nothing
            Me.GridControl_Supplier.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_Supplier, "GridControl_Supplier")
            Me.GridControl_Supplier.BackgroundImage = Nothing
            Me.GridControl_Supplier.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_Supplier.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_Supplier.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_Supplier.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_Supplier.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_Supplier.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_Supplier.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_Supplier.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_Supplier.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_Supplier.EmbeddedNavigator.Name = ""
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
            CTag8.ParentControl = Me.GridControl_Supplier.EmbeddedNavigator
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Supplier.EmbeddedNavigator.Tag = CTag8
            Me.GridControl_Supplier.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_Supplier.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_Supplier.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_Supplier.EmbeddedNavigator.ToolTip")
            Me.GridControl_Supplier.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_Supplier.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_Supplier.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_Supplier.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_Supplier.Font = Nothing
            Me.GridControl_Supplier.MainView = Me.GridView_Supplier
            Me.GridControl_Supplier.Name = "GridControl_Supplier"
            Me.GridControl_Supplier.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_RowSelected})
            Me.GridControl_Supplier.TabStop = False
            Me.GridControl_Supplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Supplier})
            '
            'GridView_Supplier
            '
            resources.ApplyResources(Me.GridView_Supplier, "GridView_Supplier")
            Me.GridView_Supplier.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_RowSelected, Me.GridColumn_SupplierCode, Me.GridColumn_SupplierName, Me.GridColumn_Address, Me.GridColumn_WorkPhone, Me.GridColumn_Fax, Me.GridColumn_Linkman, Me.GridColumn_CellPhone, Me.GridColumn_Email, Me.GridColumn_Title, Me.GridColumn_Department, Me.GridColumn_PostCode, Me.GridColumn_HomePhone, Me.GridColumn_City, Me.GridColumn_State, Me.GridColumn_Country, Me.GridColumn_WebSite, Me.GridColumn_Remarks, Me.GridColumn_RowHighLight})
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighLight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_RowHighLight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "REPEAT_CONFLICT"
            StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition3.Appearance.Options.UseBackColor = True
            StyleFormatCondition3.ApplyToRow = True
            StyleFormatCondition3.Column = Me.GridColumn_RowHighLight
            StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition3.Value1 = "EXIST"
            Me.GridView_Supplier.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
            Me.GridView_Supplier.GridControl = Me.GridControl_Supplier
            Me.GridView_Supplier.Name = "GridView_Supplier"
            Me.GridView_Supplier.OptionsView.ColumnAutoWidth = False
            Me.GridView_Supplier.OptionsView.ShowFooter = True
            Me.GridView_Supplier.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_RowSelected
            '
            resources.ApplyResources(Me.GridColumn_RowSelected, "GridColumn_RowSelected")
            Me.GridColumn_RowSelected.ColumnEdit = Me.RepositoryItemCheckEdit_RowSelected
            Me.GridColumn_RowSelected.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_RowSelected.Name = "GridColumn_RowSelected"
            '
            'RepositoryItemCheckEdit_RowSelected
            '
            Me.RepositoryItemCheckEdit_RowSelected.AccessibleDescription = Nothing
            Me.RepositoryItemCheckEdit_RowSelected.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCheckEdit_RowSelected, "RepositoryItemCheckEdit_RowSelected")
            Me.RepositoryItemCheckEdit_RowSelected.Name = "RepositoryItemCheckEdit_RowSelected"
            '
            'GridColumn_SupplierCode
            '
            resources.ApplyResources(Me.GridColumn_SupplierCode, "GridColumn_SupplierCode")
            Me.GridColumn_SupplierCode.FieldName = "SUPPLIER_CODE"
            Me.GridColumn_SupplierCode.Name = "GridColumn_SupplierCode"
            Me.GridColumn_SupplierCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_SupplierCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_SupplierCode.SummaryItem.DisplayFormat")
            Me.GridColumn_SupplierCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_SupplierName
            '
            resources.ApplyResources(Me.GridColumn_SupplierName, "GridColumn_SupplierName")
            Me.GridColumn_SupplierName.FieldName = "SUPPLIER_NAME"
            Me.GridColumn_SupplierName.Name = "GridColumn_SupplierName"
            Me.GridColumn_SupplierName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Address
            '
            resources.ApplyResources(Me.GridColumn_Address, "GridColumn_Address")
            Me.GridColumn_Address.FieldName = "ADDRESS"
            Me.GridColumn_Address.Name = "GridColumn_Address"
            Me.GridColumn_Address.OptionsColumn.AllowFocus = False
            '
            'GridColumn_WorkPhone
            '
            resources.ApplyResources(Me.GridColumn_WorkPhone, "GridColumn_WorkPhone")
            Me.GridColumn_WorkPhone.FieldName = "WORK_PHONE"
            Me.GridColumn_WorkPhone.Name = "GridColumn_WorkPhone"
            Me.GridColumn_WorkPhone.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Fax
            '
            resources.ApplyResources(Me.GridColumn_Fax, "GridColumn_Fax")
            Me.GridColumn_Fax.FieldName = "FAX"
            Me.GridColumn_Fax.Name = "GridColumn_Fax"
            Me.GridColumn_Fax.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Linkman
            '
            resources.ApplyResources(Me.GridColumn_Linkman, "GridColumn_Linkman")
            Me.GridColumn_Linkman.FieldName = "LINKMAN"
            Me.GridColumn_Linkman.Name = "GridColumn_Linkman"
            Me.GridColumn_Linkman.OptionsColumn.AllowFocus = False
            '
            'GridColumn_CellPhone
            '
            resources.ApplyResources(Me.GridColumn_CellPhone, "GridColumn_CellPhone")
            Me.GridColumn_CellPhone.FieldName = "CELL_PHONE"
            Me.GridColumn_CellPhone.Name = "GridColumn_CellPhone"
            Me.GridColumn_CellPhone.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Email
            '
            resources.ApplyResources(Me.GridColumn_Email, "GridColumn_Email")
            Me.GridColumn_Email.FieldName = "EMAIL"
            Me.GridColumn_Email.Name = "GridColumn_Email"
            Me.GridColumn_Email.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Title
            '
            resources.ApplyResources(Me.GridColumn_Title, "GridColumn_Title")
            Me.GridColumn_Title.FieldName = "TITLE"
            Me.GridColumn_Title.Name = "GridColumn_Title"
            Me.GridColumn_Title.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Department
            '
            resources.ApplyResources(Me.GridColumn_Department, "GridColumn_Department")
            Me.GridColumn_Department.FieldName = "DEPARTMENT"
            Me.GridColumn_Department.Name = "GridColumn_Department"
            Me.GridColumn_Department.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PostCode
            '
            resources.ApplyResources(Me.GridColumn_PostCode, "GridColumn_PostCode")
            Me.GridColumn_PostCode.FieldName = "POST_CODE"
            Me.GridColumn_PostCode.Name = "GridColumn_PostCode"
            Me.GridColumn_PostCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_HomePhone
            '
            resources.ApplyResources(Me.GridColumn_HomePhone, "GridColumn_HomePhone")
            Me.GridColumn_HomePhone.FieldName = "HOME_PHONE"
            Me.GridColumn_HomePhone.Name = "GridColumn_HomePhone"
            Me.GridColumn_HomePhone.OptionsColumn.AllowFocus = False
            '
            'GridColumn_City
            '
            resources.ApplyResources(Me.GridColumn_City, "GridColumn_City")
            Me.GridColumn_City.FieldName = "CITY"
            Me.GridColumn_City.Name = "GridColumn_City"
            Me.GridColumn_City.OptionsColumn.AllowFocus = False
            '
            'GridColumn_State
            '
            resources.ApplyResources(Me.GridColumn_State, "GridColumn_State")
            Me.GridColumn_State.FieldName = "STATE"
            Me.GridColumn_State.Name = "GridColumn_State"
            Me.GridColumn_State.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Country
            '
            resources.ApplyResources(Me.GridColumn_Country, "GridColumn_Country")
            Me.GridColumn_Country.FieldName = "COUNTRY"
            Me.GridColumn_Country.Name = "GridColumn_Country"
            Me.GridColumn_Country.OptionsColumn.AllowFocus = False
            '
            'GridColumn_WebSite
            '
            resources.ApplyResources(Me.GridColumn_WebSite, "GridColumn_WebSite")
            Me.GridColumn_WebSite.FieldName = "WEB_SITE"
            Me.GridColumn_WebSite.Name = "GridColumn_WebSite"
            Me.GridColumn_WebSite.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Remarks
            '
            resources.ApplyResources(Me.GridColumn_Remarks, "GridColumn_Remarks")
            Me.GridColumn_Remarks.FieldName = "DSR_FT_ROW_REMARK"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowHighLight
            '
            resources.ApplyResources(Me.GridColumn_RowHighLight, "GridColumn_RowHighLight")
            Me.GridColumn_RowHighLight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighLight.Name = "GridColumn_RowHighLight"
            Me.GridColumn_RowHighLight.OptionsColumn.AllowFocus = False
            '
            'OpenFileDialog_ImportFile
            '
            resources.ApplyResources(Me.OpenFileDialog_ImportFile, "OpenFileDialog_ImportFile")
            '
            'M_01_00603
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_Supplier)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_01_00603"
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
            CTag9.ParentControl = Me
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag9
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.CheckEdit_AutoSupplierCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadioGroup_DistinguishBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_FileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_RowSelected, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents OpenFileDialog_ImportFile As System.Windows.Forms.OpenFileDialog
        Friend WithEvents ToolStripButton_Import As System.Windows.Forms.ToolStripButton
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents RadioGroup_DistinguishBy As DevExpress.XtraEditors.RadioGroup
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_FileName As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GridControl_Supplier As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Supplier As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_RowSelected As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SupplierCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WorkPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Fax As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Linkman As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CellPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Email As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Title As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Department As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PostCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_HomePhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_City As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_State As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Country As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WebSite As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighLight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_RowSelected As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents CheckEdit_AutoSupplierCode As DevExpress.XtraEditors.CheckEdit

#End Region

    End Class

End Namespace
