Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_01001
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
        Friend WithEvents ToolStripButton_Search As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_03_01001))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Search = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_SellDiscount = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.DateEdit_End = New DevExpress.XtraEditors.DateEdit
            Me.DateEdit_Begin = New DevExpress.XtraEditors.DateEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
            Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_ClientSalesReport = New DevExpress.XtraGrid.GridControl
            Me.GridView_ClientSalesReport = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_CustomerCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomerName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WorkPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Fax = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Linkman = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CellPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Email = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr6 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowSelected = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_RowSelected = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
            Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
            Me.GridControl_WareSalesReport = New DevExpress.XtraGrid.GridControl
            Me.GridView_WareSalesReport = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Unitcost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_End.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_Begin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_Begin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl1.SuspendLayout()
            Me.XtraTabPage1.SuspendLayout()
            CType(Me.GridControl_ClientSalesReport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ClientSalesReport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_RowSelected, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl2.SuspendLayout()
            CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage2.SuspendLayout()
            CType(Me.GridControl_WareSalesReport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_WareSalesReport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl3.SuspendLayout()
            CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Search, Me.ToolStripButton_Refresh, Me.ToolStripButton_SellDiscount, Me.ToolStripButton_Close})
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
            CTag1.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
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
            'ToolStripButton_Search
            '
            Me.ToolStripButton_Search.AccessibleDescription = Nothing
            Me.ToolStripButton_Search.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Search, "ToolStripButton_Search")
            Me.ToolStripButton_Search.BackgroundImage = Nothing
            Me.ToolStripButton_Search.Name = "ToolStripButton_Search"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.AccessibleDescription = Nothing
            Me.ToolStripButton_Refresh.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            Me.ToolStripButton_Refresh.BackgroundImage = Nothing
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            '
            'ToolStripButton_SellDiscount
            '
            Me.ToolStripButton_SellDiscount.AccessibleDescription = Nothing
            Me.ToolStripButton_SellDiscount.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_SellDiscount, "ToolStripButton_SellDiscount")
            Me.ToolStripButton_SellDiscount.BackgroundImage = Nothing
            Me.ToolStripButton_SellDiscount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_SellDiscount.Name = "ToolStripButton_SellDiscount"
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
            Me.PanelControl1.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl1.Controls.Add(Me.DateEdit_End)
            Me.PanelControl1.Controls.Add(Me.DateEdit_Begin)
            Me.PanelControl1.Controls.Add(Me.Label2)
            Me.PanelControl1.Controls.Add(Me.Label3)
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Name = "PanelControl1"
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
            CTag8.ParentControl = Me.PanelControl1
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag8
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.BackgroundImage = Nothing
            Me.TextEdit_Search.EditValue = Nothing
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
            'DateEdit_End
            '
            resources.ApplyResources(Me.DateEdit_End, "DateEdit_End")
            Me.DateEdit_End.BackgroundImage = Nothing
            Me.DateEdit_End.EditValue = Nothing
            Me.DateEdit_End.Name = "DateEdit_End"
            Me.DateEdit_End.Properties.AccessibleDescription = Nothing
            Me.DateEdit_End.Properties.AccessibleName = Nothing
            Me.DateEdit_End.Properties.AutoHeight = CType(resources.GetObject("DateEdit_End.Properties.AutoHeight"), Boolean)
            Me.DateEdit_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_End.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_End.Properties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_End.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_End.Properties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_End.Properties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_End.Properties.Mask.EditMask = resources.GetString("DateEdit_End.Properties.Mask.EditMask")
            Me.DateEdit_End.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_End.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_End.Properties.Mask.MaskType = CType(resources.GetObject("DateEdit_End.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_End.Properties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_End.Properties.Mask.PlaceHolder"), Char)
            Me.DateEdit_End.Properties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_End.Properties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_End.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_End.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_End.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_End.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.DateEdit_End.Properties.VistaTimeProperties.AccessibleDescription = Nothing
            Me.DateEdit_End.Properties.VistaTimeProperties.AccessibleName = Nothing
            Me.DateEdit_End.Properties.VistaTimeProperties.AutoHeight = CType(resources.GetObject("DateEdit_End.Properties.VistaTimeProperties.AutoHeight"), Boolean)
            Me.DateEdit_End.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_End.Properties.VistaTimeProperties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_End.Properties.VistaTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_End.Properties.VistaTimeProperties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_End.Properties.VistaTimeProperties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_End.Properties.VistaTimeProperties.Mask.EditMask = resources.GetString("DateEdit_End.Properties.VistaTimeProperties.Mask.EditMask")
            Me.DateEdit_End.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_End.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_End.Properties.VistaTimeProperties.Mask.MaskType = CType(resources.GetObject("DateEdit_End.Properties.VistaTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_End.Properties.VistaTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_End.Properties.VistaTimeProperties.Mask.PlaceHolder"), Char)
            Me.DateEdit_End.Properties.VistaTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_End.Properties.VistaTimeProperties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_End.Properties.VistaTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_End.Properties.VistaTimeProperties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_End.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_End.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag3.ParentControl = Me.DateEdit_End
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_End.Tag = CTag3
            '
            'DateEdit_Begin
            '
            resources.ApplyResources(Me.DateEdit_Begin, "DateEdit_Begin")
            Me.DateEdit_Begin.BackgroundImage = Nothing
            Me.DateEdit_Begin.EditValue = Nothing
            Me.DateEdit_Begin.Name = "DateEdit_Begin"
            Me.DateEdit_Begin.Properties.AccessibleDescription = Nothing
            Me.DateEdit_Begin.Properties.AccessibleName = Nothing
            Me.DateEdit_Begin.Properties.AutoHeight = CType(resources.GetObject("DateEdit_Begin.Properties.AutoHeight"), Boolean)
            Me.DateEdit_Begin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_Begin.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_Begin.Properties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_Begin.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_Begin.Properties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_Begin.Properties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_Begin.Properties.Mask.EditMask = resources.GetString("DateEdit_Begin.Properties.Mask.EditMask")
            Me.DateEdit_Begin.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_Begin.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_Begin.Properties.Mask.MaskType = CType(resources.GetObject("DateEdit_Begin.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_Begin.Properties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_Begin.Properties.Mask.PlaceHolder"), Char)
            Me.DateEdit_Begin.Properties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_Begin.Properties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_Begin.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_Begin.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_Begin.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_Begin.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.DateEdit_Begin.Properties.VistaTimeProperties.AccessibleDescription = Nothing
            Me.DateEdit_Begin.Properties.VistaTimeProperties.AccessibleName = Nothing
            Me.DateEdit_Begin.Properties.VistaTimeProperties.AutoHeight = CType(resources.GetObject("DateEdit_Begin.Properties.VistaTimeProperties.AutoHeight"), Boolean)
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_Begin.Properties.VistaTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_Begin.Properties.VistaTimeProperties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Mask.EditMask = resources.GetString("DateEdit_Begin.Properties.VistaTimeProperties.Mask.EditMask")
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_Begin.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Mask.MaskType = CType(resources.GetObject("DateEdit_Begin.Properties.VistaTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_Begin.Properties.VistaTimeProperties.Mask.PlaceHolder"), Char)
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_Begin.Properties.VistaTimeProperties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_Begin.Properties.VistaTimeProperties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_Begin.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag4.ParentControl = Me.DateEdit_Begin
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_Begin.Tag = CTag4
            '
            'Label2
            '
            Me.Label2.AccessibleDescription = Nothing
            Me.Label2.AccessibleName = Nothing
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.Font = Nothing
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
            Me.Label3.Font = Nothing
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
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.Font = Nothing
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
            Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
            Me.XtraTabControl1.TabStop = False
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
            CTag15.ParentControl = Me.XtraTabControl1
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabControl1.Tag = CTag15
            '
            'XtraTabPage1
            '
            Me.XtraTabPage1.AccessibleDescription = Nothing
            Me.XtraTabPage1.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabPage1, "XtraTabPage1")
            Me.XtraTabPage1.BackgroundImage = Nothing
            Me.XtraTabPage1.Controls.Add(Me.GridControl_ClientSalesReport)
            Me.XtraTabPage1.Controls.Add(Me.PanelControl2)
            Me.XtraTabPage1.Font = Nothing
            Me.XtraTabPage1.Name = "XtraTabPage1"
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
            CTag11.ParentControl = Me.XtraTabPage1
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage1.Tag = CTag11
            '
            'GridControl_ClientSalesReport
            '
            Me.GridControl_ClientSalesReport.AccessibleDescription = Nothing
            Me.GridControl_ClientSalesReport.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_ClientSalesReport, "GridControl_ClientSalesReport")
            Me.GridControl_ClientSalesReport.BackgroundImage = Nothing
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_ClientSalesReport.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_ClientSalesReport.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_ClientSalesReport.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.Name = ""
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_ClientSalesReport.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_ClientSalesReport.EmbeddedNavigator.ToolTip")
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_ClientSalesReport.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_ClientSalesReport.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_ClientSalesReport.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_ClientSalesReport.Font = Nothing
            Me.GridControl_ClientSalesReport.MainView = Me.GridView_ClientSalesReport
            Me.GridControl_ClientSalesReport.Name = "GridControl_ClientSalesReport"
            Me.GridControl_ClientSalesReport.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_RowSelected})
            Me.GridControl_ClientSalesReport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ClientSalesReport})
            '
            'GridView_ClientSalesReport
            '
            resources.ApplyResources(Me.GridView_ClientSalesReport, "GridView_ClientSalesReport")
            Me.GridView_ClientSalesReport.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_CustomerCode, Me.GridColumn_CustomerName, Me.GridColumn_WorkPhone, Me.GridColumn_Fax, Me.GridColumn_Linkman, Me.GridColumn_CellPhone, Me.GridColumn_Email, Me.GridColumn_RowHighlight, Me.GridColumn_SumPrice, Me.GridColumn_ClientAttr1, Me.GridColumn_ClientAttr2, Me.GridColumn_ClientAttr3, Me.GridColumn_ClientAttr4, Me.GridColumn_ClientAttr5, Me.GridColumn_ClientAttr6, Me.GridColumn_RowSelected})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_ClientSalesReport.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_ClientSalesReport.GridControl = Me.GridControl_ClientSalesReport
            Me.GridView_ClientSalesReport.Name = "GridView_ClientSalesReport"
            Me.GridView_ClientSalesReport.OptionsView.ColumnAutoWidth = False
            Me.GridView_ClientSalesReport.OptionsView.ShowFooter = True
            Me.GridView_ClientSalesReport.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_CustomerCode
            '
            resources.ApplyResources(Me.GridColumn_CustomerCode, "GridColumn_CustomerCode")
            Me.GridColumn_CustomerCode.FieldName = "CLIENT_CODE"
            Me.GridColumn_CustomerCode.Name = "GridColumn_CustomerCode"
            Me.GridColumn_CustomerCode.OptionsColumn.AllowEdit = False
            Me.GridColumn_CustomerCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomerCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_CustomerCode.SummaryItem.DisplayFormat")
            Me.GridColumn_CustomerCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_CustomerName
            '
            resources.ApplyResources(Me.GridColumn_CustomerName, "GridColumn_CustomerName")
            Me.GridColumn_CustomerName.FieldName = "CLIENT_NAME"
            Me.GridColumn_CustomerName.Name = "GridColumn_CustomerName"
            Me.GridColumn_CustomerName.OptionsColumn.AllowEdit = False
            Me.GridColumn_CustomerName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_WorkPhone
            '
            resources.ApplyResources(Me.GridColumn_WorkPhone, "GridColumn_WorkPhone")
            Me.GridColumn_WorkPhone.FieldName = "WORK_PHONE"
            Me.GridColumn_WorkPhone.Name = "GridColumn_WorkPhone"
            Me.GridColumn_WorkPhone.OptionsColumn.AllowEdit = False
            Me.GridColumn_WorkPhone.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Fax
            '
            resources.ApplyResources(Me.GridColumn_Fax, "GridColumn_Fax")
            Me.GridColumn_Fax.FieldName = "FAX"
            Me.GridColumn_Fax.Name = "GridColumn_Fax"
            Me.GridColumn_Fax.OptionsColumn.AllowEdit = False
            Me.GridColumn_Fax.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Linkman
            '
            resources.ApplyResources(Me.GridColumn_Linkman, "GridColumn_Linkman")
            Me.GridColumn_Linkman.FieldName = "LINKMAN"
            Me.GridColumn_Linkman.Name = "GridColumn_Linkman"
            Me.GridColumn_Linkman.OptionsColumn.AllowEdit = False
            Me.GridColumn_Linkman.OptionsColumn.AllowFocus = False
            '
            'GridColumn_CellPhone
            '
            resources.ApplyResources(Me.GridColumn_CellPhone, "GridColumn_CellPhone")
            Me.GridColumn_CellPhone.FieldName = "CELL_PHONE"
            Me.GridColumn_CellPhone.Name = "GridColumn_CellPhone"
            Me.GridColumn_CellPhone.OptionsColumn.AllowEdit = False
            Me.GridColumn_CellPhone.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Email
            '
            resources.ApplyResources(Me.GridColumn_Email, "GridColumn_Email")
            Me.GridColumn_Email.FieldName = "EMAIL"
            Me.GridColumn_Email.Name = "GridColumn_Email"
            Me.GridColumn_Email.OptionsColumn.AllowEdit = False
            Me.GridColumn_Email.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowHighlight
            '
            resources.ApplyResources(Me.GridColumn_RowHighlight, "GridColumn_RowHighlight")
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowEdit = False
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SumPrice
            '
            resources.ApplyResources(Me.GridColumn_SumPrice, "GridColumn_SumPrice")
            Me.GridColumn_SumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SumPrice.FieldName = "SUM_PRICE"
            Me.GridColumn_SumPrice.Name = "GridColumn_SumPrice"
            Me.GridColumn_SumPrice.OptionsColumn.AllowEdit = False
            Me.GridColumn_SumPrice.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr1
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr1, "GridColumn_ClientAttr1")
            Me.GridColumn_ClientAttr1.FieldName = "CLIENT_ATTR1"
            Me.GridColumn_ClientAttr1.Name = "GridColumn_ClientAttr1"
            Me.GridColumn_ClientAttr1.OptionsColumn.AllowEdit = False
            Me.GridColumn_ClientAttr1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr2
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr2, "GridColumn_ClientAttr2")
            Me.GridColumn_ClientAttr2.FieldName = "CLIENT_ATTR2"
            Me.GridColumn_ClientAttr2.Name = "GridColumn_ClientAttr2"
            Me.GridColumn_ClientAttr2.OptionsColumn.AllowEdit = False
            Me.GridColumn_ClientAttr2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr3
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr3, "GridColumn_ClientAttr3")
            Me.GridColumn_ClientAttr3.FieldName = "CLIENT_ATTR3"
            Me.GridColumn_ClientAttr3.Name = "GridColumn_ClientAttr3"
            Me.GridColumn_ClientAttr3.OptionsColumn.AllowEdit = False
            Me.GridColumn_ClientAttr3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr4
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr4, "GridColumn_ClientAttr4")
            Me.GridColumn_ClientAttr4.FieldName = "CLIENT_ATTR4"
            Me.GridColumn_ClientAttr4.Name = "GridColumn_ClientAttr4"
            Me.GridColumn_ClientAttr4.OptionsColumn.AllowEdit = False
            Me.GridColumn_ClientAttr4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr5
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr5, "GridColumn_ClientAttr5")
            Me.GridColumn_ClientAttr5.FieldName = "CLIENT_ATTR5"
            Me.GridColumn_ClientAttr5.Name = "GridColumn_ClientAttr5"
            Me.GridColumn_ClientAttr5.OptionsColumn.AllowEdit = False
            Me.GridColumn_ClientAttr5.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr6
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr6, "GridColumn_ClientAttr6")
            Me.GridColumn_ClientAttr6.FieldName = "CLIENT_ATTR6"
            Me.GridColumn_ClientAttr6.Name = "GridColumn_ClientAttr6"
            Me.GridColumn_ClientAttr6.OptionsColumn.AllowEdit = False
            Me.GridColumn_ClientAttr6.OptionsColumn.AllowFocus = False
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
            'PanelControl2
            '
            Me.PanelControl2.AccessibleDescription = Nothing
            Me.PanelControl2.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl2, "PanelControl2")
            Me.PanelControl2.Controls.Add(Me.CheckEdit1)
            Me.PanelControl2.Name = "PanelControl2"
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
            CTag10.ParentControl = Me.PanelControl2
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl2.Tag = CTag10
            '
            'CheckEdit1
            '
            resources.ApplyResources(Me.CheckEdit1, "CheckEdit1")
            Me.CheckEdit1.BackgroundImage = Nothing
            Me.CheckEdit1.Name = "CheckEdit1"
            Me.CheckEdit1.Properties.AccessibleDescription = Nothing
            Me.CheckEdit1.Properties.AccessibleName = Nothing
            Me.CheckEdit1.Properties.AutoHeight = CType(resources.GetObject("CheckEdit1.Properties.AutoHeight"), Boolean)
            Me.CheckEdit1.Properties.Caption = resources.GetString("CheckEdit1.Properties.Caption")
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
            CTag9.ParentControl = Me.CheckEdit1
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit1.Tag = CTag9
            '
            'XtraTabPage2
            '
            Me.XtraTabPage2.AccessibleDescription = Nothing
            Me.XtraTabPage2.AccessibleName = Nothing
            resources.ApplyResources(Me.XtraTabPage2, "XtraTabPage2")
            Me.XtraTabPage2.BackgroundImage = Nothing
            Me.XtraTabPage2.Controls.Add(Me.GridControl_WareSalesReport)
            Me.XtraTabPage2.Controls.Add(Me.PanelControl3)
            Me.XtraTabPage2.Font = Nothing
            Me.XtraTabPage2.Name = "XtraTabPage2"
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
            CTag14.ParentControl = Me.XtraTabPage2
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage2.Tag = CTag14
            '
            'GridControl_WareSalesReport
            '
            Me.GridControl_WareSalesReport.AccessibleDescription = Nothing
            Me.GridControl_WareSalesReport.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_WareSalesReport, "GridControl_WareSalesReport")
            Me.GridControl_WareSalesReport.BackgroundImage = Nothing
            Me.GridControl_WareSalesReport.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_WareSalesReport.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_WareSalesReport.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_WareSalesReport.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_WareSalesReport.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_WareSalesReport.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_WareSalesReport.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_WareSalesReport.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_WareSalesReport.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_WareSalesReport.EmbeddedNavigator.Name = ""
            Me.GridControl_WareSalesReport.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_WareSalesReport.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_WareSalesReport.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_WareSalesReport.EmbeddedNavigator.ToolTip")
            Me.GridControl_WareSalesReport.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_WareSalesReport.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_WareSalesReport.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_WareSalesReport.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_WareSalesReport.Font = Nothing
            Me.GridControl_WareSalesReport.MainView = Me.GridView_WareSalesReport
            Me.GridControl_WareSalesReport.Name = "GridControl_WareSalesReport"
            Me.GridControl_WareSalesReport.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select})
            Me.GridControl_WareSalesReport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_WareSalesReport})
            '
            'GridView_WareSalesReport
            '
            resources.ApplyResources(Me.GridView_WareSalesReport, "GridView_WareSalesReport")
            Me.GridView_WareSalesReport.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_UnitName, Me.GridColumn_UnitPrice, Me.GridColumn_Unitcost, Me.GridColumn_Remarks, Me.GridColumn1, Me.GridColumn_SumAmount})
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn1
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "SEARCH_MATCH"
            Me.GridView_WareSalesReport.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
            Me.GridView_WareSalesReport.GridControl = Me.GridControl_WareSalesReport
            Me.GridView_WareSalesReport.Name = "GridView_WareSalesReport"
            Me.GridView_WareSalesReport.OptionsView.ColumnAutoWidth = False
            Me.GridView_WareSalesReport.OptionsView.ShowFooter = True
            Me.GridView_WareSalesReport.OptionsView.ShowGroupPanel = False
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
            'GridColumn_UnitName
            '
            resources.ApplyResources(Me.GridColumn_UnitName, "GridColumn_UnitName")
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_UnitPrice
            '
            resources.ApplyResources(Me.GridColumn_UnitPrice, "GridColumn_UnitPrice")
            Me.GridColumn_UnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitPrice.FieldName = "UNIT_PRICE"
            Me.GridColumn_UnitPrice.Name = "GridColumn_UnitPrice"
            Me.GridColumn_UnitPrice.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Unitcost
            '
            resources.ApplyResources(Me.GridColumn_Unitcost, "GridColumn_Unitcost")
            Me.GridColumn_Unitcost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Unitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Unitcost.FieldName = "UNIT_COST"
            Me.GridColumn_Unitcost.Name = "GridColumn_Unitcost"
            Me.GridColumn_Unitcost.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Remarks
            '
            resources.ApplyResources(Me.GridColumn_Remarks, "GridColumn_Remarks")
            Me.GridColumn_Remarks.FieldName = "REMARK"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            '
            'GridColumn1
            '
            resources.ApplyResources(Me.GridColumn1, "GridColumn1")
            Me.GridColumn1.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn1.Name = "GridColumn1"
            Me.GridColumn1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SumAmount
            '
            resources.ApplyResources(Me.GridColumn_SumAmount, "GridColumn_SumAmount")
            Me.GridColumn_SumAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SumAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SumAmount.FieldName = "SUM_AMOUNT"
            Me.GridColumn_SumAmount.Name = "GridColumn_SumAmount"
            Me.GridColumn_SumAmount.OptionsColumn.AllowEdit = False
            Me.GridColumn_SumAmount.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AccessibleDescription = Nothing
            Me.RepositoryItemCheckEdit_Select.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCheckEdit_Select, "RepositoryItemCheckEdit_Select")
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'PanelControl3
            '
            Me.PanelControl3.AccessibleDescription = Nothing
            Me.PanelControl3.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl3, "PanelControl3")
            Me.PanelControl3.Controls.Add(Me.CheckEdit2)
            Me.PanelControl3.Name = "PanelControl3"
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
            CTag13.ParentControl = Me.PanelControl3
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl3.Tag = CTag13
            '
            'CheckEdit2
            '
            resources.ApplyResources(Me.CheckEdit2, "CheckEdit2")
            Me.CheckEdit2.BackgroundImage = Nothing
            Me.CheckEdit2.Name = "CheckEdit2"
            Me.CheckEdit2.Properties.AccessibleDescription = Nothing
            Me.CheckEdit2.Properties.AccessibleName = Nothing
            Me.CheckEdit2.Properties.AutoHeight = CType(resources.GetObject("CheckEdit2.Properties.AutoHeight"), Boolean)
            Me.CheckEdit2.Properties.Caption = resources.GetString("CheckEdit2.Properties.Caption")
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
            CTag12.ParentControl = Me.CheckEdit2
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit2.Tag = CTag12
            '
            'M_03_01001
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.XtraTabControl1)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_03_01001"
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
            CTag16.ParentControl = Me
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag16
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_End.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_Begin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_Begin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl1.ResumeLayout(False)
            Me.XtraTabPage1.ResumeLayout(False)
            CType(Me.GridControl_ClientSalesReport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ClientSalesReport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_RowSelected, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl2.ResumeLayout(False)
            CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage2.ResumeLayout(False)
            CType(Me.GridControl_WareSalesReport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_WareSalesReport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl3.ResumeLayout(False)
            CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents DateEdit_End As DevExpress.XtraEditors.DateEdit
        Friend WithEvents DateEdit_Begin As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents GridControl_ClientSalesReport As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ClientSalesReport As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_CustomerCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomerName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WorkPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Fax As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Linkman As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CellPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Email As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr5 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr6 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl_WareSalesReport As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_WareSalesReport As DevExpress.XtraGrid.Views.Grid.GridView
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
        Friend WithEvents GridColumn_UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Unitcost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SumAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents GridColumn_RowSelected As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_RowSelected As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents ToolStripButton_SellDiscount As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace
