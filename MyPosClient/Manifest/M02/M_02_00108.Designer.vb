Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00108
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
        Friend WithEvents ToolStripButton_Add As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Save As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00108))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
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
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag18 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Recipient = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_ConfirmOnSave = New DevExpress.XtraEditors.CheckEdit
            Me.Label_EmployeeID = New System.Windows.Forms.Label
            Me.Label_EmployeeName = New System.Windows.Forms.Label
            Me.ButtonEdit_EmployeeCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label_ConsignCode = New System.Windows.Forms.Label
            Me.Label_TurnoverCode = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.DateEdit_ConsignDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
            Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_ConsignDtl = New DevExpress.XtraGrid.GridControl
            Me.GridView_ConsignDtl = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_WareAmount = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_RecpConsign = New DevExpress.XtraGrid.GridControl
            Me.GridView_RecpConsign = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_PWareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PCustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PWareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PSpec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PModel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PAttribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PAttribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PAttribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PAttribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PWareAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_PAmount = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_PUnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PRemarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PRowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_TotalConsign = New DevExpress.XtraGrid.GridControl
            Me.GridView_TotalConsign = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_TWareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TCustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TWareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TSpec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TModel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TAttribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TAttribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TAttribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TAttribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TWareAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_TAmount = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_TUnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TRemarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TRowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.CheckEdit_ConfirmOnSave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_EmployeeCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ConsignDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ConsignDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl1.SuspendLayout()
            Me.XtraTabPage1.SuspendLayout()
            CType(Me.GridControl_ConsignDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ConsignDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_WareAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage2.SuspendLayout()
            CType(Me.GridControl_RecpConsign, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_RecpConsign, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_PAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage3.SuspendLayout()
            CType(Me.GridControl_TotalConsign, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_TotalConsign, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_TAmount, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Save, Me.ToolStripButton_Recipient, Me.ToolStripButton_Add, Me.ToolStripButton_Remove, Me.ToolStripButton_Close})
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
            'ToolStripButton_Recipient
            '
            Me.ToolStripButton_Recipient.AccessibleDescription = Nothing
            Me.ToolStripButton_Recipient.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Recipient, "ToolStripButton_Recipient")
            Me.ToolStripButton_Recipient.BackgroundImage = Nothing
            Me.ToolStripButton_Recipient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Recipient.Name = "ToolStripButton_Recipient"
            '
            'ToolStripButton_Add
            '
            Me.ToolStripButton_Add.AccessibleDescription = Nothing
            Me.ToolStripButton_Add.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Add, "ToolStripButton_Add")
            Me.ToolStripButton_Add.BackgroundImage = Nothing
            Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
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
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.AccessibleDescription = Nothing
            Me.PanelControl_Filter.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_ConfirmOnSave)
            Me.PanelControl_Filter.Controls.Add(Me.Label_EmployeeID)
            Me.PanelControl_Filter.Controls.Add(Me.Label_EmployeeName)
            Me.PanelControl_Filter.Controls.Add(Me.ButtonEdit_EmployeeCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label4)
            Me.PanelControl_Filter.Controls.Add(Me.Label_ConsignCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label_TurnoverCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label7)
            Me.PanelControl_Filter.Controls.Add(Me.Label8)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_ConsignDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label3)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            CTag13.ParentControl = Me.PanelControl_Filter
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag13
            '
            'CheckEdit_ConfirmOnSave
            '
            resources.ApplyResources(Me.CheckEdit_ConfirmOnSave, "CheckEdit_ConfirmOnSave")
            Me.CheckEdit_ConfirmOnSave.BackgroundImage = Nothing
            Me.CheckEdit_ConfirmOnSave.Name = "CheckEdit_ConfirmOnSave"
            Me.CheckEdit_ConfirmOnSave.Properties.AccessibleDescription = Nothing
            Me.CheckEdit_ConfirmOnSave.Properties.AccessibleName = Nothing
            Me.CheckEdit_ConfirmOnSave.Properties.AutoHeight = CType(resources.GetObject("CheckEdit_ConfirmOnSave.Properties.AutoHeight"), Boolean)
            Me.CheckEdit_ConfirmOnSave.Properties.Caption = resources.GetString("CheckEdit_ConfirmOnSave.Properties.Caption")
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
            CTag2.ParentControl = Me.CheckEdit_ConfirmOnSave
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_ConfirmOnSave.Tag = CTag2
            '
            'Label_EmployeeID
            '
            Me.Label_EmployeeID.AccessibleDescription = Nothing
            Me.Label_EmployeeID.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_EmployeeID, "Label_EmployeeID")
            Me.Label_EmployeeID.Font = Nothing
            Me.Label_EmployeeID.Name = "Label_EmployeeID"
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
            CTag3.ParentControl = Me.Label_EmployeeID
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_EmployeeID.Tag = CTag3
            '
            'Label_EmployeeName
            '
            Me.Label_EmployeeName.AccessibleDescription = Nothing
            Me.Label_EmployeeName.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_EmployeeName, "Label_EmployeeName")
            Me.Label_EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_EmployeeName.Font = Nothing
            Me.Label_EmployeeName.Name = "Label_EmployeeName"
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
            CTag4.ParentControl = Me.Label_EmployeeName
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label_EmployeeName.Tag = CTag4
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
            CTag5.ParentControl = Me.ButtonEdit_EmployeeCode
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_EmployeeCode.Tag = CTag5
            '
            'Label4
            '
            Me.Label4.AccessibleDescription = Nothing
            Me.Label4.AccessibleName = Nothing
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.Font = Nothing
            Me.Label4.Name = "Label4"
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
            '
            'Label_ConsignCode
            '
            Me.Label_ConsignCode.AccessibleDescription = Nothing
            Me.Label_ConsignCode.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_ConsignCode, "Label_ConsignCode")
            Me.Label_ConsignCode.BackColor = System.Drawing.Color.White
            Me.Label_ConsignCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_ConsignCode.ForeColor = System.Drawing.Color.Black
            Me.Label_ConsignCode.Name = "Label_ConsignCode"
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
            CTag7.ParentControl = Me.Label_ConsignCode
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label_ConsignCode.Tag = CTag7
            '
            'Label_TurnoverCode
            '
            Me.Label_TurnoverCode.AccessibleDescription = Nothing
            Me.Label_TurnoverCode.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_TurnoverCode, "Label_TurnoverCode")
            Me.Label_TurnoverCode.BackColor = System.Drawing.Color.White
            Me.Label_TurnoverCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_TurnoverCode.ForeColor = System.Drawing.Color.Black
            Me.Label_TurnoverCode.Name = "Label_TurnoverCode"
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
            CTag8.ParentControl = Me.Label_TurnoverCode
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label_TurnoverCode.Tag = CTag8
            '
            'Label7
            '
            Me.Label7.AccessibleDescription = Nothing
            Me.Label7.AccessibleName = Nothing
            resources.ApplyResources(Me.Label7, "Label7")
            Me.Label7.BackColor = System.Drawing.Color.White
            Me.Label7.ForeColor = System.Drawing.Color.Black
            Me.Label7.Name = "Label7"
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
            CTag9.ParentControl = Me.Label7
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label7.Tag = CTag9
            '
            'Label8
            '
            Me.Label8.AccessibleDescription = Nothing
            Me.Label8.AccessibleName = Nothing
            resources.ApplyResources(Me.Label8, "Label8")
            Me.Label8.BackColor = System.Drawing.Color.White
            Me.Label8.ForeColor = System.Drawing.Color.Black
            Me.Label8.Name = "Label8"
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
            CTag10.ParentControl = Me.Label8
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Label8.Tag = CTag10
            '
            'DateEdit_ConsignDate
            '
            resources.ApplyResources(Me.DateEdit_ConsignDate, "DateEdit_ConsignDate")
            Me.DateEdit_ConsignDate.BackgroundImage = Nothing
            Me.DateEdit_ConsignDate.EditValue = Nothing
            Me.DateEdit_ConsignDate.Name = "DateEdit_ConsignDate"
            Me.DateEdit_ConsignDate.Properties.AccessibleDescription = Nothing
            Me.DateEdit_ConsignDate.Properties.AccessibleName = Nothing
            Me.DateEdit_ConsignDate.Properties.AutoHeight = CType(resources.GetObject("DateEdit_ConsignDate.Properties.AutoHeight"), Boolean)
            Me.DateEdit_ConsignDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_ConsignDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_ConsignDate.Properties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_ConsignDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_ConsignDate.Properties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_ConsignDate.Properties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_ConsignDate.Properties.Mask.EditMask = resources.GetString("DateEdit_ConsignDate.Properties.Mask.EditMask")
            Me.DateEdit_ConsignDate.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_ConsignDate.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_ConsignDate.Properties.Mask.MaskType = CType(resources.GetObject("DateEdit_ConsignDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_ConsignDate.Properties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_ConsignDate.Properties.Mask.PlaceHolder"), Char)
            Me.DateEdit_ConsignDate.Properties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_ConsignDate.Properties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_ConsignDate.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_ConsignDate.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_ConsignDate.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_ConsignDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.DateEdit_ConsignDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.AccessibleDescription = Nothing
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.AccessibleName = Nothing
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.AutoHeight = CType(resources.GetObject("DateEdit_ConsignDate.Properties.VistaTimeProperties.AutoHeight"), Boolean)
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.EditMask = resources.GetString("DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.EditMask")
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.MaskType = CType(resources.GetObject("DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.PlaceHolder"), Char)
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_ConsignDate.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag11.ParentControl = Me.DateEdit_ConsignDate
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_ConsignDate.Tag = CTag11
            '
            'Label3
            '
            Me.Label3.AccessibleDescription = Nothing
            Me.Label3.AccessibleName = Nothing
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
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
            CTag12.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag12.IsButtonCustomed = False
            CTag12.IsTextValid = True
            CTag12.KeyValueAbsentable = False
            CTag12.LeagleText = ""
            CTag12.NumericButtonTextBox = Nothing
            CTag12.ParentControl = Me.Label3
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag12
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
            Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
            Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
            Me.XtraTabControl1.TabStop = False
            CTag17.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag17.CalculatorRequired = True
            CTag17.ComboValueTextBox = Nothing
            CTag17.ControlRelatedCode = Nothing
            CTag17.DateButtonTextBox = Nothing
            CTag17.DateTimeButtonTextBox = Nothing
            CTag17.DisplayLinkControl = Nothing
            CTag17.DisplayLinkDisplayFieldName = Nothing
            CTag17.DisplayLinkKeyFieldName = Nothing
            CTag17.DisplayLinkTable = Nothing
            CTag17.FlexgridEditItem = ""
            CTag17.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag17.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag17.IsButtonCustomed = False
            CTag17.IsTextValid = True
            CTag17.KeyValueAbsentable = False
            CTag17.LeagleText = ""
            CTag17.NumericButtonTextBox = Nothing
            CTag17.ParentControl = Me.XtraTabControl1
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabControl1.Tag = CTag17
            '
            'XtraTabPage1
            '
            Me.XtraTabPage1.AccessibleDescription = Nothing
            Me.XtraTabPage1.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabPage1, "XtraTabPage1")
            Me.XtraTabPage1.BackgroundImage = Nothing
            Me.XtraTabPage1.Controls.Add(Me.GridControl_ConsignDtl)
            Me.XtraTabPage1.Font = Nothing
            Me.XtraTabPage1.Name = "XtraTabPage1"
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
            CTag14.ParentControl = Me.XtraTabPage1
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage1.Tag = CTag14
            '
            'GridControl_ConsignDtl
            '
            Me.GridControl_ConsignDtl.AccessibleDescription = Nothing
            Me.GridControl_ConsignDtl.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_ConsignDtl, "GridControl_ConsignDtl")
            Me.GridControl_ConsignDtl.BackgroundImage = Nothing
            Me.GridControl_ConsignDtl.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_ConsignDtl.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_ConsignDtl.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_ConsignDtl.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_ConsignDtl.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_ConsignDtl.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_ConsignDtl.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_ConsignDtl.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_ConsignDtl.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_ConsignDtl.EmbeddedNavigator.Name = ""
            Me.GridControl_ConsignDtl.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_ConsignDtl.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_ConsignDtl.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_ConsignDtl.EmbeddedNavigator.ToolTip")
            Me.GridControl_ConsignDtl.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_ConsignDtl.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_ConsignDtl.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_ConsignDtl.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_ConsignDtl.Font = Nothing
            Me.GridControl_ConsignDtl.MainView = Me.GridView_ConsignDtl
            Me.GridControl_ConsignDtl.Name = "GridControl_ConsignDtl"
            Me.GridControl_ConsignDtl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit_WareAmount})
            Me.GridControl_ConsignDtl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ConsignDtl})
            '
            'GridView_ConsignDtl
            '
            resources.ApplyResources(Me.GridView_ConsignDtl, "GridView_ConsignDtl")
            Me.GridView_ConsignDtl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_WareAmount, Me.GridColumn_UnitName, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_ConsignDtl.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_ConsignDtl.GridControl = Me.GridControl_ConsignDtl
            Me.GridView_ConsignDtl.Name = "GridView_ConsignDtl"
            Me.GridView_ConsignDtl.OptionsView.ColumnAutoWidth = False
            Me.GridView_ConsignDtl.OptionsView.ShowFooter = True
            Me.GridView_ConsignDtl.OptionsView.ShowGroupPanel = False
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
            'GridColumn_WareAmount
            '
            resources.ApplyResources(Me.GridColumn_WareAmount, "GridColumn_WareAmount")
            Me.GridColumn_WareAmount.ColumnEdit = Me.RepositoryItemCalcEdit_WareAmount
            Me.GridColumn_WareAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_WareAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_WareAmount.FieldName = "WARE_AMOUNT"
            Me.GridColumn_WareAmount.Name = "GridColumn_WareAmount"
            Me.GridColumn_WareAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_WareAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_WareAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'RepositoryItemCalcEdit_WareAmount
            '
            Me.RepositoryItemCalcEdit_WareAmount.AccessibleDescription = Nothing
            Me.RepositoryItemCalcEdit_WareAmount.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCalcEdit_WareAmount, "RepositoryItemCalcEdit_WareAmount")
            Me.RepositoryItemCalcEdit_WareAmount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_WareAmount.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_WareAmount.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemCalcEdit_WareAmount.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemCalcEdit_WareAmount.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemCalcEdit_WareAmount.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemCalcEdit_WareAmount.Mask.EditMask = resources.GetString("RepositoryItemCalcEdit_WareAmount.Mask.EditMask")
            Me.RepositoryItemCalcEdit_WareAmount.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemCalcEdit_WareAmount.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemCalcEdit_WareAmount.Mask.MaskType = CType(resources.GetObject("RepositoryItemCalcEdit_WareAmount.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemCalcEdit_WareAmount.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemCalcEdit_WareAmount.Mask.PlaceHolder"), Char)
            Me.RepositoryItemCalcEdit_WareAmount.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemCalcEdit_WareAmount.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemCalcEdit_WareAmount.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemCalcEdit_WareAmount.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemCalcEdit_WareAmount.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemCalcEdit_WareAmount.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemCalcEdit_WareAmount.Name = "RepositoryItemCalcEdit_WareAmount"
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
            'XtraTabPage2
            '
            Me.XtraTabPage2.AccessibleDescription = Nothing
            Me.XtraTabPage2.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabPage2, "XtraTabPage2")
            Me.XtraTabPage2.BackgroundImage = Nothing
            Me.XtraTabPage2.Controls.Add(Me.GridControl_RecpConsign)
            Me.XtraTabPage2.Font = Nothing
            Me.XtraTabPage2.Name = "XtraTabPage2"
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
            CTag15.ParentControl = Me.XtraTabPage2
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage2.Tag = CTag15
            '
            'GridControl_RecpConsign
            '
            Me.GridControl_RecpConsign.AccessibleDescription = Nothing
            Me.GridControl_RecpConsign.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_RecpConsign, "GridControl_RecpConsign")
            Me.GridControl_RecpConsign.BackgroundImage = Nothing
            Me.GridControl_RecpConsign.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_RecpConsign.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_RecpConsign.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_RecpConsign.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_RecpConsign.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_RecpConsign.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_RecpConsign.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_RecpConsign.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_RecpConsign.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_RecpConsign.EmbeddedNavigator.Name = ""
            Me.GridControl_RecpConsign.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_RecpConsign.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_RecpConsign.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_RecpConsign.EmbeddedNavigator.ToolTip")
            Me.GridControl_RecpConsign.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_RecpConsign.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_RecpConsign.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_RecpConsign.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_RecpConsign.Font = Nothing
            Me.GridControl_RecpConsign.MainView = Me.GridView_RecpConsign
            Me.GridControl_RecpConsign.Name = "GridControl_RecpConsign"
            Me.GridControl_RecpConsign.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit_PAmount})
            Me.GridControl_RecpConsign.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_RecpConsign})
            '
            'GridView_RecpConsign
            '
            resources.ApplyResources(Me.GridView_RecpConsign, "GridView_RecpConsign")
            Me.GridView_RecpConsign.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_PWareCode, Me.GridColumn_PCustomCode, Me.GridColumn_PWareName, Me.GridColumn_PSpec, Me.GridColumn_PModel, Me.GridColumn_PAttribute1, Me.GridColumn_PAttribute2, Me.GridColumn_PAttribute3, Me.GridColumn_PAttribute4, Me.GridColumn_PWareAmount, Me.GridColumn_PUnitName, Me.GridColumn_PRemarks, Me.GridColumn_PRowHighlight})
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_PRowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "SEARCH_MATCH"
            Me.GridView_RecpConsign.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
            Me.GridView_RecpConsign.GridControl = Me.GridControl_RecpConsign
            Me.GridView_RecpConsign.Name = "GridView_RecpConsign"
            Me.GridView_RecpConsign.OptionsView.ColumnAutoWidth = False
            Me.GridView_RecpConsign.OptionsView.ShowFooter = True
            Me.GridView_RecpConsign.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_PWareCode
            '
            resources.ApplyResources(Me.GridColumn_PWareCode, "GridColumn_PWareCode")
            Me.GridColumn_PWareCode.FieldName = "WARE_CODE"
            Me.GridColumn_PWareCode.Name = "GridColumn_PWareCode"
            Me.GridColumn_PWareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_PWareCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_PWareCode.SummaryItem.DisplayFormat")
            Me.GridColumn_PWareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_PCustomCode
            '
            resources.ApplyResources(Me.GridColumn_PCustomCode, "GridColumn_PCustomCode")
            Me.GridColumn_PCustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_PCustomCode.Name = "GridColumn_PCustomCode"
            Me.GridColumn_PCustomCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PWareName
            '
            resources.ApplyResources(Me.GridColumn_PWareName, "GridColumn_PWareName")
            Me.GridColumn_PWareName.FieldName = "WARE_NAME"
            Me.GridColumn_PWareName.Name = "GridColumn_PWareName"
            Me.GridColumn_PWareName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PSpec
            '
            resources.ApplyResources(Me.GridColumn_PSpec, "GridColumn_PSpec")
            Me.GridColumn_PSpec.FieldName = "SPEC"
            Me.GridColumn_PSpec.Name = "GridColumn_PSpec"
            Me.GridColumn_PSpec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PModel
            '
            resources.ApplyResources(Me.GridColumn_PModel, "GridColumn_PModel")
            Me.GridColumn_PModel.FieldName = "MODEL"
            Me.GridColumn_PModel.Name = "GridColumn_PModel"
            Me.GridColumn_PModel.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PAttribute1
            '
            resources.ApplyResources(Me.GridColumn_PAttribute1, "GridColumn_PAttribute1")
            Me.GridColumn_PAttribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_PAttribute1.Name = "GridColumn_PAttribute1"
            Me.GridColumn_PAttribute1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PAttribute2
            '
            resources.ApplyResources(Me.GridColumn_PAttribute2, "GridColumn_PAttribute2")
            Me.GridColumn_PAttribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_PAttribute2.Name = "GridColumn_PAttribute2"
            Me.GridColumn_PAttribute2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PAttribute3
            '
            resources.ApplyResources(Me.GridColumn_PAttribute3, "GridColumn_PAttribute3")
            Me.GridColumn_PAttribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_PAttribute3.Name = "GridColumn_PAttribute3"
            Me.GridColumn_PAttribute3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PAttribute4
            '
            resources.ApplyResources(Me.GridColumn_PAttribute4, "GridColumn_PAttribute4")
            Me.GridColumn_PAttribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_PAttribute4.Name = "GridColumn_PAttribute4"
            Me.GridColumn_PAttribute4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PWareAmount
            '
            resources.ApplyResources(Me.GridColumn_PWareAmount, "GridColumn_PWareAmount")
            Me.GridColumn_PWareAmount.ColumnEdit = Me.RepositoryItemCalcEdit_PAmount
            Me.GridColumn_PWareAmount.FieldName = "WARE_AMOUNT"
            Me.GridColumn_PWareAmount.Name = "GridColumn_PWareAmount"
            Me.GridColumn_PWareAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_PWareAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_PWareAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'RepositoryItemCalcEdit_PAmount
            '
            Me.RepositoryItemCalcEdit_PAmount.AccessibleDescription = Nothing
            Me.RepositoryItemCalcEdit_PAmount.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCalcEdit_PAmount, "RepositoryItemCalcEdit_PAmount")
            Me.RepositoryItemCalcEdit_PAmount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_PAmount.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_PAmount.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemCalcEdit_PAmount.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemCalcEdit_PAmount.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemCalcEdit_PAmount.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemCalcEdit_PAmount.Mask.EditMask = resources.GetString("RepositoryItemCalcEdit_PAmount.Mask.EditMask")
            Me.RepositoryItemCalcEdit_PAmount.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemCalcEdit_PAmount.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemCalcEdit_PAmount.Mask.MaskType = CType(resources.GetObject("RepositoryItemCalcEdit_PAmount.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemCalcEdit_PAmount.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemCalcEdit_PAmount.Mask.PlaceHolder"), Char)
            Me.RepositoryItemCalcEdit_PAmount.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemCalcEdit_PAmount.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemCalcEdit_PAmount.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemCalcEdit_PAmount.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemCalcEdit_PAmount.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemCalcEdit_PAmount.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemCalcEdit_PAmount.Name = "RepositoryItemCalcEdit_PAmount"
            '
            'GridColumn_PUnitName
            '
            resources.ApplyResources(Me.GridColumn_PUnitName, "GridColumn_PUnitName")
            Me.GridColumn_PUnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_PUnitName.Name = "GridColumn_PUnitName"
            Me.GridColumn_PUnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PRemarks
            '
            resources.ApplyResources(Me.GridColumn_PRemarks, "GridColumn_PRemarks")
            Me.GridColumn_PRemarks.FieldName = "REMARK"
            Me.GridColumn_PRemarks.Name = "GridColumn_PRemarks"
            Me.GridColumn_PRemarks.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PRowHighlight
            '
            resources.ApplyResources(Me.GridColumn_PRowHighlight, "GridColumn_PRowHighlight")
            Me.GridColumn_PRowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_PRowHighlight.Name = "GridColumn_PRowHighlight"
            Me.GridColumn_PRowHighlight.OptionsColumn.AllowFocus = False
            '
            'XtraTabPage3
            '
            Me.XtraTabPage3.AccessibleDescription = Nothing
            Me.XtraTabPage3.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabPage3, "XtraTabPage3")
            Me.XtraTabPage3.BackgroundImage = Nothing
            Me.XtraTabPage3.Controls.Add(Me.GridControl_TotalConsign)
            Me.XtraTabPage3.Font = Nothing
            Me.XtraTabPage3.Name = "XtraTabPage3"
            CTag16.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag16.CalculatorRequired = True
            CTag16.ComboValueTextBox = Nothing
            CTag16.ControlRelatedCode = Nothing
            CTag16.DateButtonTextBox = Nothing
            CTag16.DateTimeButtonTextBox = Nothing
            CTag16.DisplayLinkControl = Nothing
            CTag16.DisplayLinkDisplayFieldName = Nothing
            CTag16.DisplayLinkKeyFieldName = Nothing
            CTag16.DisplayLinkTable = Nothing
            CTag16.FlexgridEditItem = ""
            CTag16.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag16.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag16.IsButtonCustomed = False
            CTag16.IsTextValid = True
            CTag16.KeyValueAbsentable = False
            CTag16.LeagleText = ""
            CTag16.NumericButtonTextBox = Nothing
            CTag16.ParentControl = Me.XtraTabPage3
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage3.Tag = CTag16
            '
            'GridControl_TotalConsign
            '
            Me.GridControl_TotalConsign.AccessibleDescription = Nothing
            Me.GridControl_TotalConsign.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_TotalConsign, "GridControl_TotalConsign")
            Me.GridControl_TotalConsign.BackgroundImage = Nothing
            Me.GridControl_TotalConsign.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_TotalConsign.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_TotalConsign.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_TotalConsign.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_TotalConsign.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_TotalConsign.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_TotalConsign.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_TotalConsign.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_TotalConsign.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_TotalConsign.EmbeddedNavigator.Name = ""
            Me.GridControl_TotalConsign.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_TotalConsign.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_TotalConsign.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_TotalConsign.EmbeddedNavigator.ToolTip")
            Me.GridControl_TotalConsign.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_TotalConsign.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_TotalConsign.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_TotalConsign.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_TotalConsign.Font = Nothing
            Me.GridControl_TotalConsign.MainView = Me.GridView_TotalConsign
            Me.GridControl_TotalConsign.Name = "GridControl_TotalConsign"
            Me.GridControl_TotalConsign.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit_TAmount})
            Me.GridControl_TotalConsign.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_TotalConsign})
            '
            'GridView_TotalConsign
            '
            resources.ApplyResources(Me.GridView_TotalConsign, "GridView_TotalConsign")
            Me.GridView_TotalConsign.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_TWareCode, Me.GridColumn_TCustomCode, Me.GridColumn_TWareName, Me.GridColumn_TSpec, Me.GridColumn_TModel, Me.GridColumn_TAttribute1, Me.GridColumn_TAttribute2, Me.GridColumn_TAttribute3, Me.GridColumn_TAttribute4, Me.GridColumn_TWareAmount, Me.GridColumn_TUnitName, Me.GridColumn_TRemarks, Me.GridColumn_TRowHighlight})
            StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition3.Appearance.Options.UseBackColor = True
            StyleFormatCondition3.ApplyToRow = True
            StyleFormatCondition3.Column = Me.GridColumn_TRowHighlight
            StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition3.Value1 = "SEARCH_MATCH"
            Me.GridView_TotalConsign.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3})
            Me.GridView_TotalConsign.GridControl = Me.GridControl_TotalConsign
            Me.GridView_TotalConsign.Name = "GridView_TotalConsign"
            Me.GridView_TotalConsign.OptionsView.ColumnAutoWidth = False
            Me.GridView_TotalConsign.OptionsView.ShowFooter = True
            Me.GridView_TotalConsign.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_TWareCode
            '
            resources.ApplyResources(Me.GridColumn_TWareCode, "GridColumn_TWareCode")
            Me.GridColumn_TWareCode.FieldName = "WARE_CODE"
            Me.GridColumn_TWareCode.Name = "GridColumn_TWareCode"
            Me.GridColumn_TWareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_TWareCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_TWareCode.SummaryItem.DisplayFormat")
            Me.GridColumn_TWareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_TCustomCode
            '
            resources.ApplyResources(Me.GridColumn_TCustomCode, "GridColumn_TCustomCode")
            Me.GridColumn_TCustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_TCustomCode.Name = "GridColumn_TCustomCode"
            Me.GridColumn_TCustomCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TWareName
            '
            resources.ApplyResources(Me.GridColumn_TWareName, "GridColumn_TWareName")
            Me.GridColumn_TWareName.FieldName = "WARE_NAME"
            Me.GridColumn_TWareName.Name = "GridColumn_TWareName"
            Me.GridColumn_TWareName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TSpec
            '
            resources.ApplyResources(Me.GridColumn_TSpec, "GridColumn_TSpec")
            Me.GridColumn_TSpec.FieldName = "SPEC"
            Me.GridColumn_TSpec.Name = "GridColumn_TSpec"
            Me.GridColumn_TSpec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TModel
            '
            resources.ApplyResources(Me.GridColumn_TModel, "GridColumn_TModel")
            Me.GridColumn_TModel.FieldName = "MODEL"
            Me.GridColumn_TModel.Name = "GridColumn_TModel"
            Me.GridColumn_TModel.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TAttribute1
            '
            resources.ApplyResources(Me.GridColumn_TAttribute1, "GridColumn_TAttribute1")
            Me.GridColumn_TAttribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_TAttribute1.Name = "GridColumn_TAttribute1"
            Me.GridColumn_TAttribute1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TAttribute2
            '
            resources.ApplyResources(Me.GridColumn_TAttribute2, "GridColumn_TAttribute2")
            Me.GridColumn_TAttribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_TAttribute2.Name = "GridColumn_TAttribute2"
            Me.GridColumn_TAttribute2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TAttribute3
            '
            resources.ApplyResources(Me.GridColumn_TAttribute3, "GridColumn_TAttribute3")
            Me.GridColumn_TAttribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_TAttribute3.Name = "GridColumn_TAttribute3"
            Me.GridColumn_TAttribute3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TAttribute4
            '
            resources.ApplyResources(Me.GridColumn_TAttribute4, "GridColumn_TAttribute4")
            Me.GridColumn_TAttribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_TAttribute4.Name = "GridColumn_TAttribute4"
            Me.GridColumn_TAttribute4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TWareAmount
            '
            resources.ApplyResources(Me.GridColumn_TWareAmount, "GridColumn_TWareAmount")
            Me.GridColumn_TWareAmount.ColumnEdit = Me.RepositoryItemCalcEdit_TAmount
            Me.GridColumn_TWareAmount.FieldName = "WARE_AMOUNT"
            Me.GridColumn_TWareAmount.Name = "GridColumn_TWareAmount"
            Me.GridColumn_TWareAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_TWareAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_TWareAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'RepositoryItemCalcEdit_TAmount
            '
            Me.RepositoryItemCalcEdit_TAmount.AccessibleDescription = Nothing
            Me.RepositoryItemCalcEdit_TAmount.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCalcEdit_TAmount, "RepositoryItemCalcEdit_TAmount")
            Me.RepositoryItemCalcEdit_TAmount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_TAmount.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_TAmount.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemCalcEdit_TAmount.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemCalcEdit_TAmount.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemCalcEdit_TAmount.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemCalcEdit_TAmount.Mask.EditMask = resources.GetString("RepositoryItemCalcEdit_TAmount.Mask.EditMask")
            Me.RepositoryItemCalcEdit_TAmount.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemCalcEdit_TAmount.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemCalcEdit_TAmount.Mask.MaskType = CType(resources.GetObject("RepositoryItemCalcEdit_TAmount.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemCalcEdit_TAmount.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemCalcEdit_TAmount.Mask.PlaceHolder"), Char)
            Me.RepositoryItemCalcEdit_TAmount.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemCalcEdit_TAmount.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemCalcEdit_TAmount.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemCalcEdit_TAmount.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemCalcEdit_TAmount.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemCalcEdit_TAmount.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemCalcEdit_TAmount.Name = "RepositoryItemCalcEdit_TAmount"
            '
            'GridColumn_TUnitName
            '
            resources.ApplyResources(Me.GridColumn_TUnitName, "GridColumn_TUnitName")
            Me.GridColumn_TUnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_TUnitName.Name = "GridColumn_TUnitName"
            Me.GridColumn_TUnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TRemarks
            '
            resources.ApplyResources(Me.GridColumn_TRemarks, "GridColumn_TRemarks")
            Me.GridColumn_TRemarks.FieldName = "REMARK"
            Me.GridColumn_TRemarks.Name = "GridColumn_TRemarks"
            Me.GridColumn_TRemarks.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TRowHighlight
            '
            resources.ApplyResources(Me.GridColumn_TRowHighlight, "GridColumn_TRowHighlight")
            Me.GridColumn_TRowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_TRowHighlight.Name = "GridColumn_TRowHighlight"
            Me.GridColumn_TRowHighlight.OptionsColumn.AllowFocus = False
            '
            'M_02_00108
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
            Me.Name = "M_02_00108"
            CTag18.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag18.CalculatorRequired = True
            CTag18.ComboValueTextBox = Nothing
            CTag18.ControlRelatedCode = Nothing
            CTag18.DateButtonTextBox = Nothing
            CTag18.DateTimeButtonTextBox = Nothing
            CTag18.DisplayLinkControl = Nothing
            CTag18.DisplayLinkDisplayFieldName = Nothing
            CTag18.DisplayLinkKeyFieldName = Nothing
            CTag18.DisplayLinkTable = Nothing
            CTag18.FlexgridEditItem = ""
            CTag18.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag18.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag18.IsButtonCustomed = False
            CTag18.IsTextValid = True
            CTag18.KeyValueAbsentable = False
            CTag18.LeagleText = ""
            CTag18.NumericButtonTextBox = Nothing
            CTag18.ParentControl = Me
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag18
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.CheckEdit_ConfirmOnSave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_EmployeeCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ConsignDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ConsignDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl1.ResumeLayout(False)
            Me.XtraTabPage1.ResumeLayout(False)
            CType(Me.GridControl_ConsignDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ConsignDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_WareAmount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage2.ResumeLayout(False)
            CType(Me.GridControl_RecpConsign, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_RecpConsign, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_PAmount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage3.ResumeLayout(False)
            CType(Me.GridControl_TotalConsign, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_TotalConsign, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_TAmount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ToolStripButton_Recipient As System.Windows.Forms.ToolStripButton
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents DateEdit_ConsignDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label_ConsignCode As System.Windows.Forms.Label
        Friend WithEvents Label_TurnoverCode As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents CheckEdit_ConfirmOnSave As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents Label_EmployeeID As System.Windows.Forms.Label
        Friend WithEvents Label_EmployeeName As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_EmployeeCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents GridControl_ConsignDtl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ConsignDtl As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_WareAmount As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_RecpConsign As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_RecpConsign As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_PWareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PCustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PWareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PSpec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PAttribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PAttribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PAttribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PAttribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PUnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PWareAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_PAmount As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_PRowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_TotalConsign As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_TotalConsign As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_TWareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TCustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TWareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TSpec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TAttribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TAttribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TAttribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TAttribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TUnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TWareAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_TAmount As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_TRowHighlight As DevExpress.XtraGrid.Columns.GridColumn

#End Region

    End Class

End Namespace
