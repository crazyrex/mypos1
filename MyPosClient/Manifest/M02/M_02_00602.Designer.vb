Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00602
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
        Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00602))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_SingleIODtl = New DevExpress.XtraEditors.CheckEdit
            Me.Label_LocationID = New System.Windows.Forms.Label
            Me.Label_LocationInfo = New System.Windows.Forms.Label
            Me.ButtonEdit_LocationCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
            Me.XtraTabPage_WareTurnover = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_PosLocationIOList = New DevExpress.XtraGrid.GridControl
            Me.GridView_PosLocationIOList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_IODate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_IOTime1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_IOType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_IOType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_Operator = New DevExpress.XtraGrid.Columns.GridColumn
            Me.XtraTabPage_Detail = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_PosLocationIODtlList = New DevExpress.XtraGrid.GridControl
            Me.GridView_PosLocationIODtlList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_DtlIODate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_DtlIOTime = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_DtlIOType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_DtlIOType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_IOAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.CheckEdit_SingleIODtl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_LocationCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl1.SuspendLayout()
            Me.XtraTabPage_WareTurnover.SuspendLayout()
            CType(Me.GridControl_PosLocationIOList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_PosLocationIOList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_IOType, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage_Detail.SuspendLayout()
            CType(Me.GridControl_PosLocationIODtlList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_PosLocationIODtlList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_DtlIOType, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_Refresh, Me.ToolStripButton_Close})
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
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_SingleIODtl)
            Me.PanelControl_Filter.Controls.Add(Me.Label_LocationID)
            Me.PanelControl_Filter.Controls.Add(Me.Label_LocationInfo)
            Me.PanelControl_Filter.Controls.Add(Me.ButtonEdit_LocationCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_ToDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label3)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_FromDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            CTag11.ParentControl = Me.PanelControl_Filter
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag11
            '
            'CheckEdit_SingleIODtl
            '
            resources.ApplyResources(Me.CheckEdit_SingleIODtl, "CheckEdit_SingleIODtl")
            Me.CheckEdit_SingleIODtl.BackgroundImage = Nothing
            Me.CheckEdit_SingleIODtl.Name = "CheckEdit_SingleIODtl"
            Me.CheckEdit_SingleIODtl.Properties.AccessibleDescription = Nothing
            Me.CheckEdit_SingleIODtl.Properties.AccessibleName = Nothing
            Me.CheckEdit_SingleIODtl.Properties.AutoHeight = CType(resources.GetObject("CheckEdit_SingleIODtl.Properties.AutoHeight"), Boolean)
            Me.CheckEdit_SingleIODtl.Properties.Caption = resources.GetString("CheckEdit_SingleIODtl.Properties.Caption")
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
            CTag2.ParentControl = Me.CheckEdit_SingleIODtl
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_SingleIODtl.Tag = CTag2
            '
            'Label_LocationID
            '
            Me.Label_LocationID.AccessibleDescription = Nothing
            Me.Label_LocationID.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_LocationID, "Label_LocationID")
            Me.Label_LocationID.BackColor = System.Drawing.Color.White
            Me.Label_LocationID.ForeColor = System.Drawing.Color.Black
            Me.Label_LocationID.Name = "Label_LocationID"
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
            CTag3.ParentControl = Me.Label_LocationID
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_LocationID.Tag = CTag3
            '
            'Label_LocationInfo
            '
            Me.Label_LocationInfo.AccessibleDescription = Nothing
            Me.Label_LocationInfo.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_LocationInfo, "Label_LocationInfo")
            Me.Label_LocationInfo.BackColor = System.Drawing.Color.White
            Me.Label_LocationInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_LocationInfo.ForeColor = System.Drawing.Color.Black
            Me.Label_LocationInfo.Name = "Label_LocationInfo"
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
            CTag4.ParentControl = Me.Label_LocationInfo
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label_LocationInfo.Tag = CTag4
            '
            'ButtonEdit_LocationCode
            '
            resources.ApplyResources(Me.ButtonEdit_LocationCode, "ButtonEdit_LocationCode")
            Me.ButtonEdit_LocationCode.BackgroundImage = Nothing
            Me.ButtonEdit_LocationCode.EditValue = Nothing
            Me.ButtonEdit_LocationCode.Name = "ButtonEdit_LocationCode"
            Me.ButtonEdit_LocationCode.Properties.AccessibleDescription = Nothing
            Me.ButtonEdit_LocationCode.Properties.AccessibleName = Nothing
            Me.ButtonEdit_LocationCode.Properties.AutoHeight = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.AutoHeight"), Boolean)
            Me.ButtonEdit_LocationCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_LocationCode.Properties.Mask.AutoComplete = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.ButtonEdit_LocationCode.Properties.Mask.BeepOnError = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.BeepOnError"), Boolean)
            Me.ButtonEdit_LocationCode.Properties.Mask.EditMask = resources.GetString("ButtonEdit_LocationCode.Properties.Mask.EditMask")
            Me.ButtonEdit_LocationCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.ButtonEdit_LocationCode.Properties.Mask.MaskType = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.ButtonEdit_LocationCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.PlaceHolder"), Char)
            Me.ButtonEdit_LocationCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.ButtonEdit_LocationCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.ButtonEdit_LocationCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ButtonEdit_LocationCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag5.ParentControl = Me.ButtonEdit_LocationCode
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_LocationCode.Tag = CTag5
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
            CTag7.ParentControl = Me.DateEdit_ToDate
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_ToDate.Tag = CTag7
            '
            'Label3
            '
            Me.Label3.AccessibleDescription = Nothing
            Me.Label3.AccessibleName = Nothing
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
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
            CTag8.ParentControl = Me.Label3
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag8
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
            CTag9.ParentControl = Me.DateEdit_FromDate
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_FromDate.Tag = CTag9
            '
            'Label2
            '
            Me.Label2.AccessibleDescription = Nothing
            Me.Label2.AccessibleName = Nothing
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
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
            CTag10.ParentControl = Me.Label2
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag10
            '
            'XtraTabControl1
            '
            Me.XtraTabControl1.AccessibleDescription = Nothing
            Me.XtraTabControl1.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabControl1, "XtraTabControl1")
            Me.XtraTabControl1.BackgroundImage = Nothing
            Me.XtraTabControl1.Font = Nothing
            Me.XtraTabControl1.Images = Nothing
            Me.XtraTabControl1.Name = "XtraTabControl1"
            Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage_WareTurnover
            Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage_WareTurnover, Me.XtraTabPage_Detail})
            Me.XtraTabControl1.TabStop = False
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
            CTag14.ParentControl = Me.XtraTabControl1
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabControl1.Tag = CTag14
            '
            'XtraTabPage_WareTurnover
            '
            Me.XtraTabPage_WareTurnover.AccessibleDescription = Nothing
            Me.XtraTabPage_WareTurnover.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabPage_WareTurnover, "XtraTabPage_WareTurnover")
            Me.XtraTabPage_WareTurnover.BackgroundImage = Nothing
            Me.XtraTabPage_WareTurnover.Controls.Add(Me.GridControl_PosLocationIOList)
            Me.XtraTabPage_WareTurnover.Font = Nothing
            Me.XtraTabPage_WareTurnover.Name = "XtraTabPage_WareTurnover"
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
            CTag12.ParentControl = Me.XtraTabPage_WareTurnover
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_WareTurnover.Tag = CTag12
            '
            'GridControl_PosLocationIOList
            '
            Me.GridControl_PosLocationIOList.AccessibleDescription = Nothing
            Me.GridControl_PosLocationIOList.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_PosLocationIOList, "GridControl_PosLocationIOList")
            Me.GridControl_PosLocationIOList.BackgroundImage = Nothing
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_PosLocationIOList.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_PosLocationIOList.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_PosLocationIOList.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.Name = ""
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_PosLocationIOList.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_PosLocationIOList.EmbeddedNavigator.ToolTip")
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_PosLocationIOList.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_PosLocationIOList.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_PosLocationIOList.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_PosLocationIOList.Font = Nothing
            Me.GridControl_PosLocationIOList.MainView = Me.GridView_PosLocationIOList
            Me.GridControl_PosLocationIOList.Name = "GridControl_PosLocationIOList"
            Me.GridControl_PosLocationIOList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_IOType})
            Me.GridControl_PosLocationIOList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_PosLocationIOList})
            '
            'GridView_PosLocationIOList
            '
            resources.ApplyResources(Me.GridView_PosLocationIOList, "GridView_PosLocationIOList")
            Me.GridView_PosLocationIOList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_IODate, Me.GridColumn_IOTime1, Me.GridColumn_IOType, Me.GridColumn_Operator})
            Me.GridView_PosLocationIOList.GridControl = Me.GridControl_PosLocationIOList
            Me.GridView_PosLocationIOList.Name = "GridView_PosLocationIOList"
            Me.GridView_PosLocationIOList.OptionsView.ColumnAutoWidth = False
            Me.GridView_PosLocationIOList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_IODate
            '
            resources.ApplyResources(Me.GridColumn_IODate, "GridColumn_IODate")
            Me.GridColumn_IODate.FieldName = "IO_TIME"
            Me.GridColumn_IODate.Name = "GridColumn_IODate"
            Me.GridColumn_IODate.OptionsColumn.AllowFocus = False
            '
            'GridColumn_IOTime1
            '
            resources.ApplyResources(Me.GridColumn_IOTime1, "GridColumn_IOTime1")
            Me.GridColumn_IOTime1.DisplayFormat.FormatString = "{0:HH:mm}"
            Me.GridColumn_IOTime1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.GridColumn_IOTime1.FieldName = "IO_TIME"
            Me.GridColumn_IOTime1.Name = "GridColumn_IOTime1"
            Me.GridColumn_IOTime1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_IOType
            '
            resources.ApplyResources(Me.GridColumn_IOType, "GridColumn_IOType")
            Me.GridColumn_IOType.ColumnEdit = Me.RepositoryItemLookUpEdit_IOType
            Me.GridColumn_IOType.FieldName = "IO_TYPE"
            Me.GridColumn_IOType.Name = "GridColumn_IOType"
            Me.GridColumn_IOType.OptionsColumn.AllowEdit = False
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
            'GridColumn_Operator
            '
            resources.ApplyResources(Me.GridColumn_Operator, "GridColumn_Operator")
            Me.GridColumn_Operator.FieldName = "STAFF_NAME"
            Me.GridColumn_Operator.Name = "GridColumn_Operator"
            Me.GridColumn_Operator.OptionsColumn.AllowFocus = False
            '
            'XtraTabPage_Detail
            '
            Me.XtraTabPage_Detail.AccessibleDescription = Nothing
            Me.XtraTabPage_Detail.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabPage_Detail, "XtraTabPage_Detail")
            Me.XtraTabPage_Detail.BackgroundImage = Nothing
            Me.XtraTabPage_Detail.Controls.Add(Me.GridControl_PosLocationIODtlList)
            Me.XtraTabPage_Detail.Font = Nothing
            Me.XtraTabPage_Detail.Name = "XtraTabPage_Detail"
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
            CTag13.ParentControl = Me.XtraTabPage_Detail
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_Detail.Tag = CTag13
            '
            'GridControl_PosLocationIODtlList
            '
            Me.GridControl_PosLocationIODtlList.AccessibleDescription = Nothing
            Me.GridControl_PosLocationIODtlList.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_PosLocationIODtlList, "GridControl_PosLocationIODtlList")
            Me.GridControl_PosLocationIODtlList.BackgroundImage = Nothing
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_PosLocationIODtlList.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_PosLocationIODtlList.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_PosLocationIODtlList.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.Name = ""
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_PosLocationIODtlList.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_PosLocationIODtlList.EmbeddedNavigator.ToolTip")
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_PosLocationIODtlList.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_PosLocationIODtlList.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_PosLocationIODtlList.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_PosLocationIODtlList.Font = Nothing
            Me.GridControl_PosLocationIODtlList.MainView = Me.GridView_PosLocationIODtlList
            Me.GridControl_PosLocationIODtlList.Name = "GridControl_PosLocationIODtlList"
            Me.GridControl_PosLocationIODtlList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_DtlIOType})
            Me.GridControl_PosLocationIODtlList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_PosLocationIODtlList})
            '
            'GridView_PosLocationIODtlList
            '
            resources.ApplyResources(Me.GridView_PosLocationIODtlList, "GridView_PosLocationIODtlList")
            Me.GridView_PosLocationIODtlList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_WareCode, Me.GridColumn_DtlIODate, Me.GridColumn_DtlIOTime, Me.GridColumn_DtlIOType, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_IOAmount, Me.GridColumn_UnitName, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_PosLocationIODtlList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_PosLocationIODtlList.GridControl = Me.GridControl_PosLocationIODtlList
            Me.GridView_PosLocationIODtlList.Name = "GridView_PosLocationIODtlList"
            Me.GridView_PosLocationIODtlList.OptionsView.ColumnAutoWidth = False
            Me.GridView_PosLocationIODtlList.OptionsView.ShowFooter = True
            Me.GridView_PosLocationIODtlList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_WareCode
            '
            resources.ApplyResources(Me.GridColumn_WareCode, "GridColumn_WareCode")
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_WareCode.SummaryItem.DisplayFormat")
            Me.GridColumn_WareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_DtlIODate
            '
            resources.ApplyResources(Me.GridColumn_DtlIODate, "GridColumn_DtlIODate")
            Me.GridColumn_DtlIODate.DisplayFormat.FormatString = "{0:yyyy-MM-dd}"
            Me.GridColumn_DtlIODate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.GridColumn_DtlIODate.FieldName = "IO_TIME"
            Me.GridColumn_DtlIODate.Name = "GridColumn_DtlIODate"
            Me.GridColumn_DtlIODate.OptionsColumn.AllowFocus = False
            Me.GridColumn_DtlIODate.OptionsFilter.AllowFilter = False
            '
            'GridColumn_DtlIOTime
            '
            resources.ApplyResources(Me.GridColumn_DtlIOTime, "GridColumn_DtlIOTime")
            Me.GridColumn_DtlIOTime.DisplayFormat.FormatString = "{0:HH:mm}"
            Me.GridColumn_DtlIOTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.GridColumn_DtlIOTime.FieldName = "IO_TIME"
            Me.GridColumn_DtlIOTime.Name = "GridColumn_DtlIOTime"
            Me.GridColumn_DtlIOTime.OptionsColumn.AllowFocus = False
            Me.GridColumn_DtlIOTime.OptionsFilter.AllowFilter = False
            '
            'GridColumn_DtlIOType
            '
            resources.ApplyResources(Me.GridColumn_DtlIOType, "GridColumn_DtlIOType")
            Me.GridColumn_DtlIOType.ColumnEdit = Me.RepositoryItemLookUpEdit_DtlIOType
            Me.GridColumn_DtlIOType.FieldName = "IO_TYPE"
            Me.GridColumn_DtlIOType.Name = "GridColumn_DtlIOType"
            Me.GridColumn_DtlIOType.OptionsColumn.AllowFocus = False
            Me.GridColumn_DtlIOType.OptionsFilter.AllowFilter = False
            '
            'RepositoryItemLookUpEdit_DtlIOType
            '
            Me.RepositoryItemLookUpEdit_DtlIOType.AccessibleDescription = Nothing
            Me.RepositoryItemLookUpEdit_DtlIOType.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_DtlIOType, "RepositoryItemLookUpEdit_DtlIOType")
            Me.RepositoryItemLookUpEdit_DtlIOType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_DtlIOType.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_DtlIOType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_DtlIOType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_DtlIOType.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemLookUpEdit_DtlIOType.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemLookUpEdit_DtlIOType.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemLookUpEdit_DtlIOType.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemLookUpEdit_DtlIOType.Mask.EditMask = resources.GetString("RepositoryItemLookUpEdit_DtlIOType.Mask.EditMask")
            Me.RepositoryItemLookUpEdit_DtlIOType.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemLookUpEdit_DtlIOType.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemLookUpEdit_DtlIOType.Mask.MaskType = CType(resources.GetObject("RepositoryItemLookUpEdit_DtlIOType.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemLookUpEdit_DtlIOType.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemLookUpEdit_DtlIOType.Mask.PlaceHolder"), Char)
            Me.RepositoryItemLookUpEdit_DtlIOType.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemLookUpEdit_DtlIOType.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemLookUpEdit_DtlIOType.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemLookUpEdit_DtlIOType.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemLookUpEdit_DtlIOType.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemLookUpEdit_DtlIOType.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemLookUpEdit_DtlIOType.Name = "RepositoryItemLookUpEdit_DtlIOType"
            Me.RepositoryItemLookUpEdit_DtlIOType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_CustomCode
            '
            resources.ApplyResources(Me.GridColumn_CustomCode, "GridColumn_CustomCode")
            Me.GridColumn_CustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_CustomCode.Name = "GridColumn_CustomCode"
            Me.GridColumn_CustomCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_WareName
            '
            resources.ApplyResources(Me.GridColumn_WareName, "GridColumn_WareName")
            Me.GridColumn_WareName.FieldName = "WARE_NAME"
            Me.GridColumn_WareName.Name = "GridColumn_WareName"
            Me.GridColumn_WareName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Spec
            '
            resources.ApplyResources(Me.GridColumn_Spec, "GridColumn_Spec")
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Model
            '
            resources.ApplyResources(Me.GridColumn_Model, "GridColumn_Model")
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute1
            '
            resources.ApplyResources(Me.GridColumn_Attribute1, "GridColumn_Attribute1")
            Me.GridColumn_Attribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_Attribute1.Name = "GridColumn_Attribute1"
            Me.GridColumn_Attribute1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute2
            '
            resources.ApplyResources(Me.GridColumn_Attribute2, "GridColumn_Attribute2")
            Me.GridColumn_Attribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_Attribute2.Name = "GridColumn_Attribute2"
            Me.GridColumn_Attribute2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute3
            '
            resources.ApplyResources(Me.GridColumn_Attribute3, "GridColumn_Attribute3")
            Me.GridColumn_Attribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_Attribute3.Name = "GridColumn_Attribute3"
            Me.GridColumn_Attribute3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute4
            '
            resources.ApplyResources(Me.GridColumn_Attribute4, "GridColumn_Attribute4")
            Me.GridColumn_Attribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_Attribute4.Name = "GridColumn_Attribute4"
            Me.GridColumn_Attribute4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_IOAmount
            '
            resources.ApplyResources(Me.GridColumn_IOAmount, "GridColumn_IOAmount")
            Me.GridColumn_IOAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_IOAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_IOAmount.FieldName = "IO_AMOUNT"
            Me.GridColumn_IOAmount.Name = "GridColumn_IOAmount"
            Me.GridColumn_IOAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_IOAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_IOAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_IOAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_UnitName
            '
            resources.ApplyResources(Me.GridColumn_UnitName, "GridColumn_UnitName")
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Remarks
            '
            resources.ApplyResources(Me.GridColumn_Remarks, "GridColumn_Remarks")
            Me.GridColumn_Remarks.FieldName = "REMARK"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowHighlight
            '
            resources.ApplyResources(Me.GridColumn_RowHighlight, "GridColumn_RowHighlight")
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'M_02_00602
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.XtraTabControl1)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_00602"
            CTag15.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag15.CalculatorRequired = True
            CTag15.ComboValueTextBox = Nothing
            CTag15.ControlRelatedCode = Nothing
            CTag15.DateButtonTextBox = Nothing
            CTag15.DateTimeButtonTextBox = Nothing
            CTag15.DisplayLinkControl = Nothing
            CTag15.DisplayLinkDisplayFieldName = Nothing
            CTag15.DisplayLinkKeyFieldName = Nothing
            CTag15.DisplayLinkTable = Nothing
            CTag15.FlexgridEditItem = ""
            CTag15.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag15.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag15.IsButtonCustomed = False
            CTag15.IsTextValid = True
            CTag15.KeyValueAbsentable = False
            CTag15.LeagleText = ""
            CTag15.NumericButtonTextBox = Nothing
            CTag15.ParentControl = Me
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag15
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.CheckEdit_SingleIODtl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_LocationCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl1.ResumeLayout(False)
            Me.XtraTabPage_WareTurnover.ResumeLayout(False)
            CType(Me.GridControl_PosLocationIOList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_PosLocationIOList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_IOType, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage_Detail.ResumeLayout(False)
            CType(Me.GridControl_PosLocationIODtlList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_PosLocationIODtlList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_DtlIOType, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents DateEdit_ToDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_FromDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents CheckEdit_SingleIODtl As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents Label_LocationID As System.Windows.Forms.Label
        Friend WithEvents Label_LocationInfo As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_LocationCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage_WareTurnover As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents GridControl_PosLocationIOList As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_PosLocationIOList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents XtraTabPage_Detail As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents GridColumn_IODate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_IOTime1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_IOType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Operator As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_PosLocationIODtlList As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_PosLocationIODtlList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_IOAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_DtlIODate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_DtlIOTime As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_DtlIOType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_DtlIOType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_IOType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

#End Region

    End Class

End Namespace
