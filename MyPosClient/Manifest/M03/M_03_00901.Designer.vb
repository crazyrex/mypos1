Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_00901
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
        Friend WithEvents ToolStripButton_Create As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_00901))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.LookUpEdit_RecipientType = New DevExpress.XtraEditors.LookUpEdit
            Me.Label4 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.GridControl_RecipientList = New DevExpress.XtraGrid.GridControl
            Me.GridView_RecipientList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_RecpBarcode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RecipientType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_RecipientType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_CreateDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Creator = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.LookUpEdit_RecipientType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_RecipientList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_RecipientList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_RecipientType, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Create, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_Refresh, Me.ToolStripButton_Close})
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
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.AccessibleDescription = Nothing
            Me.ToolStripButton_Create.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Create, "ToolStripButton_Create")
            Me.ToolStripButton_Create.BackgroundImage = Nothing
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.AccessibleDescription = Nothing
            Me.ToolStripButton_Revise.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Revise, "ToolStripButton_Revise")
            Me.ToolStripButton_Revise.BackgroundImage = Nothing
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            '
            'ToolStripButton_Delete
            '
            Me.ToolStripButton_Delete.AccessibleDescription = Nothing
            Me.ToolStripButton_Delete.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Delete, "ToolStripButton_Delete")
            Me.ToolStripButton_Delete.BackgroundImage = Nothing
            Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
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
            Me.PanelControl_Filter.Controls.Add(Me.LookUpEdit_RecipientType)
            Me.PanelControl_Filter.Controls.Add(Me.Label4)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_ToDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label3)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_FromDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
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
            'LookUpEdit_RecipientType
            '
            resources.ApplyResources(Me.LookUpEdit_RecipientType, "LookUpEdit_RecipientType")
            Me.LookUpEdit_RecipientType.BackgroundImage = Nothing
            Me.LookUpEdit_RecipientType.EditValue = Nothing
            Me.LookUpEdit_RecipientType.Name = "LookUpEdit_RecipientType"
            Me.LookUpEdit_RecipientType.Properties.AccessibleDescription = Nothing
            Me.LookUpEdit_RecipientType.Properties.AccessibleName = Nothing
            Me.LookUpEdit_RecipientType.Properties.AutoHeight = CType(resources.GetObject("LookUpEdit_RecipientType.Properties.AutoHeight"), Boolean)
            Me.LookUpEdit_RecipientType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LookUpEdit_RecipientType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_RecipientType.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_RecipientType.Properties.Mask.AutoComplete = CType(resources.GetObject("LookUpEdit_RecipientType.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.LookUpEdit_RecipientType.Properties.Mask.BeepOnError = CType(resources.GetObject("LookUpEdit_RecipientType.Properties.Mask.BeepOnError"), Boolean)
            Me.LookUpEdit_RecipientType.Properties.Mask.EditMask = resources.GetString("LookUpEdit_RecipientType.Properties.Mask.EditMask")
            Me.LookUpEdit_RecipientType.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("LookUpEdit_RecipientType.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.LookUpEdit_RecipientType.Properties.Mask.MaskType = CType(resources.GetObject("LookUpEdit_RecipientType.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.LookUpEdit_RecipientType.Properties.Mask.PlaceHolder = CType(resources.GetObject("LookUpEdit_RecipientType.Properties.Mask.PlaceHolder"), Char)
            Me.LookUpEdit_RecipientType.Properties.Mask.SaveLiteral = CType(resources.GetObject("LookUpEdit_RecipientType.Properties.Mask.SaveLiteral"), Boolean)
            Me.LookUpEdit_RecipientType.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("LookUpEdit_RecipientType.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.LookUpEdit_RecipientType.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("LookUpEdit_RecipientType.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.LookUpEdit_RecipientType.Properties.ValueMember = "ITEM_VALUE"
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
            CTag2.ParentControl = Me.LookUpEdit_RecipientType
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_RecipientType.Tag = CTag2
            '
            'Label4
            '
            Me.Label4.AccessibleDescription = Nothing
            Me.Label4.AccessibleName = Nothing
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
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
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
            Me.Label3.AccessibleDescription = Nothing
            Me.Label3.AccessibleName = Nothing
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
            Me.Label2.AccessibleDescription = Nothing
            Me.Label2.AccessibleName = Nothing
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
            'GridControl_RecipientList
            '
            Me.GridControl_RecipientList.AccessibleDescription = Nothing
            Me.GridControl_RecipientList.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_RecipientList, "GridControl_RecipientList")
            Me.GridControl_RecipientList.BackgroundImage = Nothing
            Me.GridControl_RecipientList.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_RecipientList.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_RecipientList.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_RecipientList.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_RecipientList.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_RecipientList.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_RecipientList.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_RecipientList.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_RecipientList.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_RecipientList.EmbeddedNavigator.Name = ""
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
            CTag11.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag11.IsButtonCustomed = False
            CTag11.IsTextValid = True
            CTag11.KeyValueAbsentable = False
            CTag11.LeagleText = ""
            CTag11.NumericButtonTextBox = Nothing
            CTag11.ParentControl = Me.GridControl_RecipientList.EmbeddedNavigator
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_RecipientList.EmbeddedNavigator.Tag = CTag11
            Me.GridControl_RecipientList.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_RecipientList.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_RecipientList.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_RecipientList.EmbeddedNavigator.ToolTip")
            Me.GridControl_RecipientList.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_RecipientList.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_RecipientList.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_RecipientList.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_RecipientList.Font = Nothing
            Me.GridControl_RecipientList.MainView = Me.GridView_RecipientList
            Me.GridControl_RecipientList.Name = "GridControl_RecipientList"
            Me.GridControl_RecipientList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select, Me.RepositoryItemLookUpEdit_RecipientType})
            Me.GridControl_RecipientList.TabStop = False
            Me.GridControl_RecipientList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_RecipientList})
            '
            'GridView_RecipientList
            '
            resources.ApplyResources(Me.GridView_RecipientList, "GridView_RecipientList")
            Me.GridView_RecipientList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_RecpBarcode, Me.GridColumn_RecipientType, Me.GridColumn_CreateDate, Me.GridColumn_Creator, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_RecipientList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_RecipientList.GridControl = Me.GridControl_RecipientList
            Me.GridView_RecipientList.Name = "GridView_RecipientList"
            Me.GridView_RecipientList.OptionsView.ColumnAutoWidth = False
            Me.GridView_RecipientList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_RecpBarcode
            '
            resources.ApplyResources(Me.GridColumn_RecpBarcode, "GridColumn_RecpBarcode")
            Me.GridColumn_RecpBarcode.FieldName = "RECP_BARCODE"
            Me.GridColumn_RecpBarcode.Name = "GridColumn_RecpBarcode"
            Me.GridColumn_RecpBarcode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RecipientType
            '
            resources.ApplyResources(Me.GridColumn_RecipientType, "GridColumn_RecipientType")
            Me.GridColumn_RecipientType.ColumnEdit = Me.RepositoryItemLookUpEdit_RecipientType
            Me.GridColumn_RecipientType.FieldName = "RECIPIENT_TYPE"
            Me.GridColumn_RecipientType.Name = "GridColumn_RecipientType"
            Me.GridColumn_RecipientType.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_RecipientType
            '
            Me.RepositoryItemLookUpEdit_RecipientType.AccessibleDescription = Nothing
            Me.RepositoryItemLookUpEdit_RecipientType.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_RecipientType, "RepositoryItemLookUpEdit_RecipientType")
            Me.RepositoryItemLookUpEdit_RecipientType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_RecipientType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_RecipientType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_RecipientType.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemLookUpEdit_RecipientType.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemLookUpEdit_RecipientType.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemLookUpEdit_RecipientType.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemLookUpEdit_RecipientType.Mask.EditMask = resources.GetString("RepositoryItemLookUpEdit_RecipientType.Mask.EditMask")
            Me.RepositoryItemLookUpEdit_RecipientType.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemLookUpEdit_RecipientType.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemLookUpEdit_RecipientType.Mask.MaskType = CType(resources.GetObject("RepositoryItemLookUpEdit_RecipientType.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemLookUpEdit_RecipientType.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemLookUpEdit_RecipientType.Mask.PlaceHolder"), Char)
            Me.RepositoryItemLookUpEdit_RecipientType.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemLookUpEdit_RecipientType.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemLookUpEdit_RecipientType.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemLookUpEdit_RecipientType.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemLookUpEdit_RecipientType.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemLookUpEdit_RecipientType.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemLookUpEdit_RecipientType.Name = "RepositoryItemLookUpEdit_RecipientType"
            Me.RepositoryItemLookUpEdit_RecipientType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_CreateDate
            '
            resources.ApplyResources(Me.GridColumn_CreateDate, "GridColumn_CreateDate")
            Me.GridColumn_CreateDate.FieldName = "CREATE_DATE"
            Me.GridColumn_CreateDate.Name = "GridColumn_CreateDate"
            Me.GridColumn_CreateDate.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Creator
            '
            resources.ApplyResources(Me.GridColumn_Creator, "GridColumn_Creator")
            Me.GridColumn_Creator.FieldName = "CREATOR__STAFF_NAME"
            Me.GridColumn_Creator.Name = "GridColumn_Creator"
            Me.GridColumn_Creator.OptionsColumn.AllowFocus = False
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
            'M_03_00901
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_RecipientList)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_00901"
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
            CTag12.ParentControl = Me
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag12
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.LookUpEdit_RecipientType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_RecipientList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_RecipientList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_RecipientType, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents LookUpEdit_RecipientType As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GridControl_RecipientList As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_RecipientList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_RecpBarcode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RecipientType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CreateDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Creator As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents RepositoryItemLookUpEdit_RecipientType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

#End Region

    End Class

End Namespace
