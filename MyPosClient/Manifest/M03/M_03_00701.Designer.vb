Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_00701
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_00701))
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
            Me.ToolStripButton_ViewDetail = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.GridControl_CommissionTotal = New DevExpress.XtraGrid.GridControl
            Me.GridView_CommissionTotal = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_EmployeeCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EmployeeName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CommissionGiven = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CommissionTillNow = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumEmployeeCommission = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EmployeeCommissionOwning = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_CommissionTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_CommissionTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.AccessibleDescription = Nothing
            Me.ToolStrip_Form.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStrip_Form, "ToolStrip_Form")
            Me.ToolStrip_Form.BackgroundImage = Nothing
            Me.ToolStrip_Form.Font = Nothing
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_ViewDetail, Me.ToolStripButton_Refresh, Me.ToolStripButton_Close})
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
            'ToolStripButton_ViewDetail
            '
            Me.ToolStripButton_ViewDetail.AccessibleDescription = Nothing
            Me.ToolStripButton_ViewDetail.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_ViewDetail, "ToolStripButton_ViewDetail")
            Me.ToolStripButton_ViewDetail.BackgroundImage = Nothing
            Me.ToolStripButton_ViewDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_ViewDetail.Name = "ToolStripButton_ViewDetail"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.AccessibleDescription = Nothing
            Me.ToolStripButton_Refresh.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            Me.ToolStripButton_Refresh.BackgroundImage = Nothing
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.AccessibleDescription = Nothing
            Me.ToolStripButton_Close.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Close, "ToolStripButton_Close")
            Me.ToolStripButton_Close.BackgroundImage = Nothing
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            '
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.AccessibleDescription = Nothing
            Me.PanelControl_Filter.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.BackgroundImage = Nothing
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_ToDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label3)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_FromDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            CTag8.ParentControl = Me.PanelControl_Filter
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag8
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.BackgroundImage = Nothing
            Me.TextEdit_Search.Name = "TextEdit_Search"
            Me.TextEdit_Search.Properties.AccessibleDescription = Nothing
            Me.TextEdit_Search.Properties.AccessibleName = Nothing
            Me.TextEdit_Search.Properties.AutoHeight = CType(resources.GetObject("TextEdit_Search.Properties.AutoHeight"), Boolean)
            Me.TextEdit_Search.Properties.Mask.AutoComplete = CType(resources.GetObject("TextEdit_Search.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.TextEdit_Search.Properties.Mask.BeepOnError = CType(resources.GetObject("TextEdit_Search.Properties.Mask.BeepOnError"), Boolean)
            Me.TextEdit_Search.Properties.Mask.EditMask = resources.GetString("TextEdit_Search.Properties.Mask.EditMask")
            Me.TextEdit_Search.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TextEdit_Search.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.TextEdit_Search.Properties.Mask.MaskType = CType(resources.GetObject("TextEdit_Search.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.TextEdit_Search.Properties.Mask.PlaceHolder = CType(resources.GetObject("TextEdit_Search.Properties.Mask.PlaceHolder"), Char)
            Me.TextEdit_Search.Properties.Mask.SaveLiteral = CType(resources.GetObject("TextEdit_Search.Properties.Mask.SaveLiteral"), Boolean)
            Me.TextEdit_Search.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TextEdit_Search.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.TextEdit_Search.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TextEdit_Search.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag2.ParentControl = Me.TextEdit_Search
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag2
            '
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
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
            '
            'DateEdit_ToDate
            '
            resources.ApplyResources(Me.DateEdit_ToDate, "DateEdit_ToDate")
            Me.DateEdit_ToDate.BackgroundImage = Nothing
            Me.DateEdit_ToDate.EditValue = Nothing
            Me.DateEdit_ToDate.Name = "DateEdit_ToDate"
            Me.DateEdit_ToDate.Properties.AccessibleDescription = Nothing
            Me.DateEdit_ToDate.Properties.AccessibleName = Nothing
            Me.DateEdit_ToDate.Properties.AutoHeight = CType(resources.GetObject("DateEdit_ToDate.Properties.AutoHeight"), Boolean)
            Me.DateEdit_ToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit_ToDate.Properties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_ToDate.Properties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_ToDate.Properties.Mask.EditMask = resources.GetString("DateEdit_ToDate.Properties.Mask.EditMask")
            Me.DateEdit_ToDate.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_ToDate.Properties.Mask.MaskType = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_ToDate.Properties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.PlaceHolder"), Char)
            Me.DateEdit_ToDate.Properties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_ToDate.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_ToDate.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.DateEdit_ToDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.AccessibleDescription = Nothing
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.AccessibleName = Nothing
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.AutoHeight = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.AutoHeight"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.EditMask = resources.GetString("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.EditMask")
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.MaskType = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.PlaceHolder"), Char)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag4.ParentControl = Me.DateEdit_ToDate
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_ToDate.Tag = CTag4
            '
            'Label3
            '
            Me.Label3.AccessibleDescription = Nothing
            Me.Label3.AccessibleName = Nothing
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
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
            CTag5.ParentControl = Me.Label3
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag5
            '
            'DateEdit_FromDate
            '
            resources.ApplyResources(Me.DateEdit_FromDate, "DateEdit_FromDate")
            Me.DateEdit_FromDate.BackgroundImage = Nothing
            Me.DateEdit_FromDate.EditValue = Nothing
            Me.DateEdit_FromDate.Name = "DateEdit_FromDate"
            Me.DateEdit_FromDate.Properties.AccessibleDescription = Nothing
            Me.DateEdit_FromDate.Properties.AccessibleName = Nothing
            Me.DateEdit_FromDate.Properties.AutoHeight = CType(resources.GetObject("DateEdit_FromDate.Properties.AutoHeight"), Boolean)
            Me.DateEdit_FromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit_FromDate.Properties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_FromDate.Properties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_FromDate.Properties.Mask.EditMask = resources.GetString("DateEdit_FromDate.Properties.Mask.EditMask")
            Me.DateEdit_FromDate.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_FromDate.Properties.Mask.MaskType = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_FromDate.Properties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.PlaceHolder"), Char)
            Me.DateEdit_FromDate.Properties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_FromDate.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_FromDate.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.DateEdit_FromDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.AccessibleDescription = Nothing
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.AccessibleName = Nothing
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.AutoHeight = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.AutoHeight"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.EditMask = resources.GetString("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.EditMask")
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.MaskType = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.PlaceHolder"), Char)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag6.ParentControl = Me.DateEdit_FromDate
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_FromDate.Tag = CTag6
            '
            'Label2
            '
            Me.Label2.AccessibleDescription = Nothing
            Me.Label2.AccessibleName = Nothing
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
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
            '
            'GridControl_CommissionTotal
            '
            Me.GridControl_CommissionTotal.AccessibleDescription = Nothing
            Me.GridControl_CommissionTotal.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_CommissionTotal, "GridControl_CommissionTotal")
            Me.GridControl_CommissionTotal.BackgroundImage = Nothing
            Me.GridControl_CommissionTotal.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_CommissionTotal.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_CommissionTotal.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_CommissionTotal.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_CommissionTotal.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_CommissionTotal.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_CommissionTotal.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_CommissionTotal.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_CommissionTotal.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_CommissionTotal.EmbeddedNavigator.Name = ""
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
            CTag9.ParentControl = Me.GridControl_CommissionTotal.EmbeddedNavigator
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_CommissionTotal.EmbeddedNavigator.Tag = CTag9
            Me.GridControl_CommissionTotal.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_CommissionTotal.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_CommissionTotal.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_CommissionTotal.EmbeddedNavigator.ToolTip")
            Me.GridControl_CommissionTotal.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_CommissionTotal.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_CommissionTotal.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_CommissionTotal.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_CommissionTotal.Font = Nothing
            Me.GridControl_CommissionTotal.MainView = Me.GridView_CommissionTotal
            Me.GridControl_CommissionTotal.Name = "GridControl_CommissionTotal"
            Me.GridControl_CommissionTotal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select})
            Me.GridControl_CommissionTotal.TabStop = False
            Me.GridControl_CommissionTotal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_CommissionTotal})
            '
            'GridView_CommissionTotal
            '
            resources.ApplyResources(Me.GridView_CommissionTotal, "GridView_CommissionTotal")
            Me.GridView_CommissionTotal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_EmployeeCode, Me.GridColumn_EmployeeName, Me.GridColumn_CommissionGiven, Me.GridColumn_CommissionTillNow, Me.GridColumn_SumEmployeeCommission, Me.GridColumn_EmployeeCommissionOwning, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_CommissionTotal.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_CommissionTotal.GridControl = Me.GridControl_CommissionTotal
            Me.GridView_CommissionTotal.Name = "GridView_CommissionTotal"
            Me.GridView_CommissionTotal.OptionsView.ColumnAutoWidth = False
            Me.GridView_CommissionTotal.OptionsView.ShowFooter = True
            Me.GridView_CommissionTotal.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_EmployeeCode
            '
            resources.ApplyResources(Me.GridColumn_EmployeeCode, "GridColumn_EmployeeCode")
            Me.GridColumn_EmployeeCode.FieldName = "STAFF_CODE"
            Me.GridColumn_EmployeeCode.Name = "GridColumn_EmployeeCode"
            Me.GridColumn_EmployeeCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_EmployeeCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_EmployeeCode.SummaryItem.DisplayFormat")
            Me.GridColumn_EmployeeCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_EmployeeName
            '
            resources.ApplyResources(Me.GridColumn_EmployeeName, "GridColumn_EmployeeName")
            Me.GridColumn_EmployeeName.FieldName = "STAFF_NAME"
            Me.GridColumn_EmployeeName.Name = "GridColumn_EmployeeName"
            Me.GridColumn_EmployeeName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_CommissionGiven
            '
            resources.ApplyResources(Me.GridColumn_CommissionGiven, "GridColumn_CommissionGiven")
            Me.GridColumn_CommissionGiven.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_CommissionGiven.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_CommissionGiven.FieldName = "STAFF_COMMISSION_GIVEN"
            Me.GridColumn_CommissionGiven.Name = "GridColumn_CommissionGiven"
            Me.GridColumn_CommissionGiven.OptionsColumn.AllowFocus = False
            Me.GridColumn_CommissionGiven.SummaryItem.DisplayFormat = resources.GetString("GridColumn_CommissionGiven.SummaryItem.DisplayFormat")
            Me.GridColumn_CommissionGiven.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_CommissionTillNow
            '
            resources.ApplyResources(Me.GridColumn_CommissionTillNow, "GridColumn_CommissionTillNow")
            Me.GridColumn_CommissionTillNow.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_CommissionTillNow.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_CommissionTillNow.FieldName = "STAFF_COMMISSION_TILL_NOW"
            Me.GridColumn_CommissionTillNow.Name = "GridColumn_CommissionTillNow"
            Me.GridColumn_CommissionTillNow.OptionsColumn.AllowFocus = False
            Me.GridColumn_CommissionTillNow.SummaryItem.DisplayFormat = resources.GetString("GridColumn_CommissionTillNow.SummaryItem.DisplayFormat")
            Me.GridColumn_CommissionTillNow.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_SumEmployeeCommission
            '
            resources.ApplyResources(Me.GridColumn_SumEmployeeCommission, "GridColumn_SumEmployeeCommission")
            Me.GridColumn_SumEmployeeCommission.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SumEmployeeCommission.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SumEmployeeCommission.FieldName = "SUM_STAFF_COMMISSION"
            Me.GridColumn_SumEmployeeCommission.Name = "GridColumn_SumEmployeeCommission"
            Me.GridColumn_SumEmployeeCommission.OptionsColumn.AllowFocus = False
            Me.GridColumn_SumEmployeeCommission.SummaryItem.DisplayFormat = resources.GetString("GridColumn_SumEmployeeCommission.SummaryItem.DisplayFormat")
            Me.GridColumn_SumEmployeeCommission.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_EmployeeCommissionOwning
            '
            resources.ApplyResources(Me.GridColumn_EmployeeCommissionOwning, "GridColumn_EmployeeCommissionOwning")
            Me.GridColumn_EmployeeCommissionOwning.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_EmployeeCommissionOwning.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_EmployeeCommissionOwning.FieldName = "STAFF_COMMISSION_OWING"
            Me.GridColumn_EmployeeCommissionOwning.Name = "GridColumn_EmployeeCommissionOwning"
            Me.GridColumn_EmployeeCommissionOwning.OptionsColumn.AllowFocus = False
            Me.GridColumn_EmployeeCommissionOwning.SummaryItem.DisplayFormat = resources.GetString("GridColumn_EmployeeCommissionOwning.SummaryItem.DisplayFormat")
            Me.GridColumn_EmployeeCommissionOwning.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_RowHighlight
            '
            resources.ApplyResources(Me.GridColumn_RowHighlight, "GridColumn_RowHighlight")
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AccessibleDescription = Nothing
            Me.RepositoryItemCheckEdit_Select.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCheckEdit_Select, "RepositoryItemCheckEdit_Select")
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'M_03_00701
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_CommissionTotal)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_00701"
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
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_CommissionTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_CommissionTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_ToDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_FromDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents ToolStripButton_ViewDetail As System.Windows.Forms.ToolStripButton
        Friend WithEvents GridControl_CommissionTotal As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_CommissionTotal As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_EmployeeCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_EmployeeName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CommissionGiven As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CommissionTillNow As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SumEmployeeCommission As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_EmployeeCommissionOwning As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

#End Region

    End Class

End Namespace
