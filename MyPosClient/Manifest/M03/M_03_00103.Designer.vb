Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_00103
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_00103))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
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
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.Label_CustomCode = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.LookUpEdit_Pos = New DevExpress.XtraEditors.LookUpEdit
            Me.Label4 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.GridControl_ShelfAmount = New DevExpress.XtraGrid.GridControl
            Me.GridView_ShelfList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_IOTime = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_StaffName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_AreaCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_LocationCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_IOType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_IOType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_LocationStockAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ShelfRowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_ShelfAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ShelfList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_IOType, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Refresh, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_Close})
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
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.AccessibleDescription = Nothing
            Me.ToolStripButton_Refresh.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            Me.ToolStripButton_Refresh.BackgroundImage = Nothing
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            '
            'ToolStripButton_ExportExcel
            '
            Me.ToolStripButton_ExportExcel.AccessibleDescription = Nothing
            Me.ToolStripButton_ExportExcel.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_ExportExcel, "ToolStripButton_ExportExcel")
            Me.ToolStripButton_ExportExcel.BackgroundImage = Nothing
            Me.ToolStripButton_ExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_ExportExcel.Name = "ToolStripButton_ExportExcel"
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
            Me.PanelControl_Filter.Controls.Add(Me.Label_CustomCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label5)
            Me.PanelControl_Filter.Controls.Add(Me.LookUpEdit_Pos)
            Me.PanelControl_Filter.Controls.Add(Me.Label4)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_ToDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label3)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_FromDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            CTag12.ParentControl = Me.PanelControl_Filter
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag12
            '
            'Label_CustomCode
            '
            Me.Label_CustomCode.AccessibleDescription = Nothing
            Me.Label_CustomCode.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_CustomCode, "Label_CustomCode")
            Me.Label_CustomCode.BackColor = System.Drawing.Color.White
            Me.Label_CustomCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_CustomCode.ForeColor = System.Drawing.Color.Black
            Me.Label_CustomCode.Name = "Label_CustomCode"
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
            CTag2.ParentControl = Me.Label_CustomCode
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomCode.Tag = CTag2
            '
            'Label5
            '
            Me.Label5.AccessibleDescription = Nothing
            Me.Label5.AccessibleName = Nothing
            resources.ApplyResources(Me.Label5, "Label5")
            Me.Label5.BackColor = System.Drawing.Color.White
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.Name = "Label5"
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
            CTag3.ParentControl = Me.Label5
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label5.Tag = CTag3
            '
            'LookUpEdit_Pos
            '
            resources.ApplyResources(Me.LookUpEdit_Pos, "LookUpEdit_Pos")
            Me.LookUpEdit_Pos.BackgroundImage = Nothing
            Me.LookUpEdit_Pos.EditValue = Nothing
            Me.LookUpEdit_Pos.Name = "LookUpEdit_Pos"
            Me.LookUpEdit_Pos.Properties.AccessibleDescription = Nothing
            Me.LookUpEdit_Pos.Properties.AccessibleName = Nothing
            Me.LookUpEdit_Pos.Properties.AutoHeight = CType(resources.GetObject("LookUpEdit_Pos.Properties.AutoHeight"), Boolean)
            Me.LookUpEdit_Pos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_Pos.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_Pos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Pos.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_Pos.Properties.Mask.AutoComplete = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.LookUpEdit_Pos.Properties.Mask.BeepOnError = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.BeepOnError"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.EditMask = resources.GetString("LookUpEdit_Pos.Properties.Mask.EditMask")
            Me.LookUpEdit_Pos.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.MaskType = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.LookUpEdit_Pos.Properties.Mask.PlaceHolder = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.PlaceHolder"), Char)
            Me.LookUpEdit_Pos.Properties.Mask.SaveLiteral = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.SaveLiteral"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.LookUpEdit_Pos.Properties.NullText = resources.GetString("LookUpEdit_Pos.Properties.NullText")
            Me.LookUpEdit_Pos.Properties.ValueMember = "POS_ID"
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
            CTag4.ParentControl = Me.LookUpEdit_Pos
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_Pos.Tag = CTag4
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
            CTag6.ParentControl = Me.TextEdit_Search
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag6
            '
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
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
            CTag7.ParentControl = Me.Label1
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag7
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
            Me.DateEdit_ToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_ToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
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
            CTag8.ParentControl = Me.DateEdit_ToDate
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_ToDate.Tag = CTag8
            '
            'Label3
            '
            Me.Label3.AccessibleDescription = Nothing
            Me.Label3.AccessibleName = Nothing
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
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
            CTag9.ParentControl = Me.Label3
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag9
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
            Me.DateEdit_FromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_FromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
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
            CTag10.ParentControl = Me.DateEdit_FromDate
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_FromDate.Tag = CTag10
            '
            'Label2
            '
            Me.Label2.AccessibleDescription = Nothing
            Me.Label2.AccessibleName = Nothing
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
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
            CTag11.ParentControl = Me.Label2
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag11
            '
            'GridControl_ShelfAmount
            '
            Me.GridControl_ShelfAmount.AccessibleDescription = Nothing
            Me.GridControl_ShelfAmount.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_ShelfAmount, "GridControl_ShelfAmount")
            Me.GridControl_ShelfAmount.BackgroundImage = Nothing
            Me.GridControl_ShelfAmount.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_ShelfAmount.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_ShelfAmount.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_ShelfAmount.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_ShelfAmount.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_ShelfAmount.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_ShelfAmount.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_ShelfAmount.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_ShelfAmount.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_ShelfAmount.EmbeddedNavigator.Name = ""
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
            CTag13.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag13.IsButtonCustomed = False
            CTag13.IsTextValid = True
            CTag13.KeyValueAbsentable = False
            CTag13.LeagleText = ""
            CTag13.NumericButtonTextBox = Nothing
            CTag13.ParentControl = Me.GridControl_ShelfAmount.EmbeddedNavigator
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_ShelfAmount.EmbeddedNavigator.Tag = CTag13
            Me.GridControl_ShelfAmount.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_ShelfAmount.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_ShelfAmount.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_ShelfAmount.EmbeddedNavigator.ToolTip")
            Me.GridControl_ShelfAmount.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_ShelfAmount.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_ShelfAmount.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_ShelfAmount.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_ShelfAmount.Font = Nothing
            Me.GridControl_ShelfAmount.MainView = Me.GridView_ShelfList
            Me.GridControl_ShelfAmount.Name = "GridControl_ShelfAmount"
            Me.GridControl_ShelfAmount.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_IOType})
            Me.GridControl_ShelfAmount.TabStop = False
            Me.GridControl_ShelfAmount.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ShelfList})
            '
            'GridView_ShelfList
            '
            resources.ApplyResources(Me.GridView_ShelfList, "GridView_ShelfList")
            Me.GridView_ShelfList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_IOTime, Me.GridColumn_StaffName, Me.GridColumn_AreaCode, Me.GridColumn_ShelfCode, Me.GridColumn_LocationCode, Me.GridColumn_IOType, Me.GridColumn_LocationStockAmount, Me.GridColumn_ShelfRowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_ShelfRowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_ShelfList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_ShelfList.GridControl = Me.GridControl_ShelfAmount
            Me.GridView_ShelfList.Name = "GridView_ShelfList"
            Me.GridView_ShelfList.OptionsView.ColumnAutoWidth = False
            Me.GridView_ShelfList.OptionsView.ShowFooter = True
            Me.GridView_ShelfList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_IOTime
            '
            resources.ApplyResources(Me.GridColumn_IOTime, "GridColumn_IOTime")
            Me.GridColumn_IOTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm"
            Me.GridColumn_IOTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.GridColumn_IOTime.FieldName = "IO_TIME"
            Me.GridColumn_IOTime.Name = "GridColumn_IOTime"
            Me.GridColumn_IOTime.OptionsColumn.AllowFocus = False
            '
            'GridColumn_StaffName
            '
            resources.ApplyResources(Me.GridColumn_StaffName, "GridColumn_StaffName")
            Me.GridColumn_StaffName.FieldName = "STAFF_NAME"
            Me.GridColumn_StaffName.Name = "GridColumn_StaffName"
            Me.GridColumn_StaffName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_AreaCode
            '
            resources.ApplyResources(Me.GridColumn_AreaCode, "GridColumn_AreaCode")
            Me.GridColumn_AreaCode.FieldName = "AREA_CODE"
            Me.GridColumn_AreaCode.Name = "GridColumn_AreaCode"
            Me.GridColumn_AreaCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ShelfCode
            '
            resources.ApplyResources(Me.GridColumn_ShelfCode, "GridColumn_ShelfCode")
            Me.GridColumn_ShelfCode.FieldName = "SHELF_CODE"
            Me.GridColumn_ShelfCode.Name = "GridColumn_ShelfCode"
            Me.GridColumn_ShelfCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_LocationCode
            '
            resources.ApplyResources(Me.GridColumn_LocationCode, "GridColumn_LocationCode")
            Me.GridColumn_LocationCode.FieldName = "LOCATION_CODE"
            Me.GridColumn_LocationCode.Name = "GridColumn_LocationCode"
            Me.GridColumn_LocationCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_IOType
            '
            resources.ApplyResources(Me.GridColumn_IOType, "GridColumn_IOType")
            Me.GridColumn_IOType.ColumnEdit = Me.RepositoryItemLookUpEdit_IOType
            Me.GridColumn_IOType.FieldName = "IO_TYPE"
            Me.GridColumn_IOType.Name = "GridColumn_IOType"
            Me.GridColumn_IOType.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_IOType
            '
            Me.RepositoryItemLookUpEdit_IOType.AccessibleDescription = Nothing
            Me.RepositoryItemLookUpEdit_IOType.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_IOType, "RepositoryItemLookUpEdit_IOType")
            Me.RepositoryItemLookUpEdit_IOType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_IOType.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_IOType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_IOType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_IOType.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemLookUpEdit_IOType.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemLookUpEdit_IOType.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemLookUpEdit_IOType.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemLookUpEdit_IOType.Mask.EditMask = resources.GetString("RepositoryItemLookUpEdit_IOType.Mask.EditMask")
            Me.RepositoryItemLookUpEdit_IOType.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemLookUpEdit_IOType.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemLookUpEdit_IOType.Mask.MaskType = CType(resources.GetObject("RepositoryItemLookUpEdit_IOType.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemLookUpEdit_IOType.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemLookUpEdit_IOType.Mask.PlaceHolder"), Char)
            Me.RepositoryItemLookUpEdit_IOType.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemLookUpEdit_IOType.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemLookUpEdit_IOType.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemLookUpEdit_IOType.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemLookUpEdit_IOType.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemLookUpEdit_IOType.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemLookUpEdit_IOType.Name = "RepositoryItemLookUpEdit_IOType"
            Me.RepositoryItemLookUpEdit_IOType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_LocationStockAmount
            '
            resources.ApplyResources(Me.GridColumn_LocationStockAmount, "GridColumn_LocationStockAmount")
            Me.GridColumn_LocationStockAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_LocationStockAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_LocationStockAmount.FieldName = "IO_AMOUNT"
            Me.GridColumn_LocationStockAmount.Name = "GridColumn_LocationStockAmount"
            Me.GridColumn_LocationStockAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_LocationStockAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_LocationStockAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_LocationStockAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_ShelfRowHighlight
            '
            resources.ApplyResources(Me.GridColumn_ShelfRowHighlight, "GridColumn_ShelfRowHighlight")
            Me.GridColumn_ShelfRowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_ShelfRowHighlight.Name = "GridColumn_ShelfRowHighlight"
            Me.GridColumn_ShelfRowHighlight.OptionsColumn.AllowFocus = False
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'M_03_00103
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_ShelfAmount)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_00103"
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
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_ShelfAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ShelfList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_IOType, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents Label_CustomCode As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_Pos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_ToDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_FromDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GridControl_ShelfAmount As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ShelfList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_IOTime As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_StaffName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_AreaCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ShelfCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_IOType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_IOType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_ShelfRowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_LocationCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_LocationStockAmount As DevExpress.XtraGrid.Columns.GridColumn

#End Region

    End Class

End Namespace
