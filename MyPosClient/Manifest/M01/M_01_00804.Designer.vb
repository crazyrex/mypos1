Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00804
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_01_00804))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.GridControl_Customer = New DevExpress.XtraGrid.GridControl
            Me.GridView_Customer = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_CustomerCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomerName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Address = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WorkPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Fax = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Linkman = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CellPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Email = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Title = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Department = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PostCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_HomePhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_City = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_State = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Country = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WebSite = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr6 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighLight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SellDiscount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemSpinEdit_SellDiscount = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.LinkLabel_ApplySellDiscount = New System.Windows.Forms.LinkLabel
            Me.SpinEdit_SellDiscount = New DevExpress.XtraEditors.SpinEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.GridControl_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSpinEdit_SellDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.SpinEdit_SellDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            'GridControl_Customer
            '
            Me.GridControl_Customer.AccessibleDescription = Nothing
            Me.GridControl_Customer.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_Customer, "GridControl_Customer")
            Me.GridControl_Customer.BackgroundImage = Nothing
            Me.GridControl_Customer.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_Customer.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_Customer.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_Customer.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_Customer.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_Customer.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_Customer.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_Customer.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_Customer.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_Customer.EmbeddedNavigator.Name = ""
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
            CTag2.ParentControl = Me.GridControl_Customer.EmbeddedNavigator
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Customer.EmbeddedNavigator.Tag = CTag2
            Me.GridControl_Customer.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_Customer.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_Customer.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_Customer.EmbeddedNavigator.ToolTip")
            Me.GridControl_Customer.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_Customer.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_Customer.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_Customer.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_Customer.Font = Nothing
            Me.GridControl_Customer.MainView = Me.GridView_Customer
            Me.GridControl_Customer.Name = "GridControl_Customer"
            Me.GridControl_Customer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit_SellDiscount})
            Me.GridControl_Customer.TabStop = False
            Me.GridControl_Customer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Customer})
            '
            'GridView_Customer
            '
            resources.ApplyResources(Me.GridView_Customer, "GridView_Customer")
            Me.GridView_Customer.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_CustomerCode, Me.GridColumn_CustomerName, Me.GridColumn_Address, Me.GridColumn_WorkPhone, Me.GridColumn_Fax, Me.GridColumn_Linkman, Me.GridColumn_CellPhone, Me.GridColumn_Email, Me.GridColumn_Title, Me.GridColumn_Department, Me.GridColumn_PostCode, Me.GridColumn_Remarks, Me.GridColumn_HomePhone, Me.GridColumn_City, Me.GridColumn_State, Me.GridColumn_Country, Me.GridColumn_WebSite, Me.GridColumn_ClientAttr1, Me.GridColumn_ClientAttr2, Me.GridColumn_ClientAttr3, Me.GridColumn_ClientAttr4, Me.GridColumn_ClientAttr5, Me.GridColumn_ClientAttr6, Me.GridColumn_RowHighLight, Me.GridColumn_SellDiscount})
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighLight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_Customer.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_Customer.GridControl = Me.GridControl_Customer
            Me.GridView_Customer.Name = "GridView_Customer"
            Me.GridView_Customer.OptionsView.ColumnAutoWidth = False
            Me.GridView_Customer.OptionsView.ShowFooter = True
            Me.GridView_Customer.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_CustomerCode
            '
            resources.ApplyResources(Me.GridColumn_CustomerCode, "GridColumn_CustomerCode")
            Me.GridColumn_CustomerCode.FieldName = "CLIENT_CODE"
            Me.GridColumn_CustomerCode.Name = "GridColumn_CustomerCode"
            Me.GridColumn_CustomerCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomerCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_CustomerCode.SummaryItem.DisplayFormat")
            Me.GridColumn_CustomerCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_CustomerName
            '
            resources.ApplyResources(Me.GridColumn_CustomerName, "GridColumn_CustomerName")
            Me.GridColumn_CustomerName.FieldName = "CLIENT_NAME"
            Me.GridColumn_CustomerName.Name = "GridColumn_CustomerName"
            Me.GridColumn_CustomerName.OptionsColumn.AllowFocus = False
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
            'GridColumn_Remarks
            '
            resources.ApplyResources(Me.GridColumn_Remarks, "GridColumn_Remarks")
            Me.GridColumn_Remarks.FieldName = "REMARKS"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
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
            'GridColumn_ClientAttr1
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr1, "GridColumn_ClientAttr1")
            Me.GridColumn_ClientAttr1.FieldName = "CLIENT_ATTR1"
            Me.GridColumn_ClientAttr1.Name = "GridColumn_ClientAttr1"
            Me.GridColumn_ClientAttr1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr2
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr2, "GridColumn_ClientAttr2")
            Me.GridColumn_ClientAttr2.FieldName = "CLIENT_ATTR2"
            Me.GridColumn_ClientAttr2.Name = "GridColumn_ClientAttr2"
            Me.GridColumn_ClientAttr2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr3
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr3, "GridColumn_ClientAttr3")
            Me.GridColumn_ClientAttr3.FieldName = "CLIENT_ATTR3"
            Me.GridColumn_ClientAttr3.Name = "GridColumn_ClientAttr3"
            Me.GridColumn_ClientAttr3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr4
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr4, "GridColumn_ClientAttr4")
            Me.GridColumn_ClientAttr4.FieldName = "CLIENT_ATTR4"
            Me.GridColumn_ClientAttr4.Name = "GridColumn_ClientAttr4"
            Me.GridColumn_ClientAttr4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr5
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr5, "GridColumn_ClientAttr5")
            Me.GridColumn_ClientAttr5.FieldName = "CLIENT_ATTR5"
            Me.GridColumn_ClientAttr5.Name = "GridColumn_ClientAttr5"
            Me.GridColumn_ClientAttr5.OptionsColumn.AllowFocus = False
            '
            'GridColumn_ClientAttr6
            '
            resources.ApplyResources(Me.GridColumn_ClientAttr6, "GridColumn_ClientAttr6")
            Me.GridColumn_ClientAttr6.FieldName = "CLIENT_ATTR6"
            Me.GridColumn_ClientAttr6.Name = "GridColumn_ClientAttr6"
            Me.GridColumn_ClientAttr6.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowHighLight
            '
            resources.ApplyResources(Me.GridColumn_RowHighLight, "GridColumn_RowHighLight")
            Me.GridColumn_RowHighLight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighLight.Name = "GridColumn_RowHighLight"
            Me.GridColumn_RowHighLight.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SellDiscount
            '
            resources.ApplyResources(Me.GridColumn_SellDiscount, "GridColumn_SellDiscount")
            Me.GridColumn_SellDiscount.ColumnEdit = Me.RepositoryItemSpinEdit_SellDiscount
            Me.GridColumn_SellDiscount.FieldName = "SELL_DISCOUNT"
            Me.GridColumn_SellDiscount.Name = "GridColumn_SellDiscount"
            '
            'RepositoryItemSpinEdit_SellDiscount
            '
            Me.RepositoryItemSpinEdit_SellDiscount.AccessibleDescription = Nothing
            Me.RepositoryItemSpinEdit_SellDiscount.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemSpinEdit_SellDiscount, "RepositoryItemSpinEdit_SellDiscount")
            Me.RepositoryItemSpinEdit_SellDiscount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.RepositoryItemSpinEdit_SellDiscount.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemSpinEdit_SellDiscount.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemSpinEdit_SellDiscount.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemSpinEdit_SellDiscount.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemSpinEdit_SellDiscount.Mask.EditMask = resources.GetString("RepositoryItemSpinEdit_SellDiscount.Mask.EditMask")
            Me.RepositoryItemSpinEdit_SellDiscount.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemSpinEdit_SellDiscount.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemSpinEdit_SellDiscount.Mask.MaskType = CType(resources.GetObject("RepositoryItemSpinEdit_SellDiscount.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemSpinEdit_SellDiscount.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemSpinEdit_SellDiscount.Mask.PlaceHolder"), Char)
            Me.RepositoryItemSpinEdit_SellDiscount.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemSpinEdit_SellDiscount.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemSpinEdit_SellDiscount.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemSpinEdit_SellDiscount.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemSpinEdit_SellDiscount.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemSpinEdit_SellDiscount.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemSpinEdit_SellDiscount.Name = "RepositoryItemSpinEdit_SellDiscount"
            '
            'PanelControl1
            '
            Me.PanelControl1.AccessibleDescription = Nothing
            Me.PanelControl1.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl1, "PanelControl1")
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.BackgroundImage = Nothing
            Me.PanelControl1.Controls.Add(Me.LinkLabel_ApplySellDiscount)
            Me.PanelControl1.Controls.Add(Me.SpinEdit_SellDiscount)
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Name = "PanelControl1"
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
            CTag6.ParentControl = Me.PanelControl1
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag6
            '
            'LinkLabel_ApplySellDiscount
            '
            Me.LinkLabel_ApplySellDiscount.AccessibleDescription = Nothing
            Me.LinkLabel_ApplySellDiscount.AccessibleName = Nothing
            resources.ApplyResources(Me.LinkLabel_ApplySellDiscount, "LinkLabel_ApplySellDiscount")
            Me.LinkLabel_ApplySellDiscount.BackColor = System.Drawing.Color.White
            Me.LinkLabel_ApplySellDiscount.ForeColor = System.Drawing.Color.Black
            Me.LinkLabel_ApplySellDiscount.Name = "LinkLabel_ApplySellDiscount"
            Me.LinkLabel_ApplySellDiscount.TabStop = True
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
            CTag3.ParentControl = Me.LinkLabel_ApplySellDiscount
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_ApplySellDiscount.Tag = CTag3
            '
            'SpinEdit_SellDiscount
            '
            resources.ApplyResources(Me.SpinEdit_SellDiscount, "SpinEdit_SellDiscount")
            Me.SpinEdit_SellDiscount.BackgroundImage = Nothing
            Me.SpinEdit_SellDiscount.Name = "SpinEdit_SellDiscount"
            Me.SpinEdit_SellDiscount.Properties.AccessibleDescription = Nothing
            Me.SpinEdit_SellDiscount.Properties.AccessibleName = Nothing
            Me.SpinEdit_SellDiscount.Properties.AutoHeight = CType(resources.GetObject("SpinEdit_SellDiscount.Properties.AutoHeight"), Boolean)
            Me.SpinEdit_SellDiscount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.SpinEdit_SellDiscount.Properties.Mask.AutoComplete = CType(resources.GetObject("SpinEdit_SellDiscount.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.SpinEdit_SellDiscount.Properties.Mask.BeepOnError = CType(resources.GetObject("SpinEdit_SellDiscount.Properties.Mask.BeepOnError"), Boolean)
            Me.SpinEdit_SellDiscount.Properties.Mask.EditMask = resources.GetString("SpinEdit_SellDiscount.Properties.Mask.EditMask")
            Me.SpinEdit_SellDiscount.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("SpinEdit_SellDiscount.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.SpinEdit_SellDiscount.Properties.Mask.MaskType = CType(resources.GetObject("SpinEdit_SellDiscount.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.SpinEdit_SellDiscount.Properties.Mask.PlaceHolder = CType(resources.GetObject("SpinEdit_SellDiscount.Properties.Mask.PlaceHolder"), Char)
            Me.SpinEdit_SellDiscount.Properties.Mask.SaveLiteral = CType(resources.GetObject("SpinEdit_SellDiscount.Properties.Mask.SaveLiteral"), Boolean)
            Me.SpinEdit_SellDiscount.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("SpinEdit_SellDiscount.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.SpinEdit_SellDiscount.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("SpinEdit_SellDiscount.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag4.ParentControl = Me.SpinEdit_SellDiscount
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.SpinEdit_SellDiscount.Tag = CTag4
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
            'M_01_00804
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_Customer)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_01_00804"
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
            CTag7.ParentControl = Me
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag7
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.GridControl_Customer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Customer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSpinEdit_SellDiscount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.SpinEdit_SellDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GridControl_Customer As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Customer As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_CustomerCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomerName As DevExpress.XtraGrid.Columns.GridColumn
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
        Friend WithEvents GridColumn_ClientAttr1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr5 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr6 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighLight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SellDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemSpinEdit_SellDiscount As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents LinkLabel_ApplySellDiscount As System.Windows.Forms.LinkLabel
        Friend WithEvents SpinEdit_SellDiscount As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label

#End Region

    End Class

End Namespace
