Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_08_00301
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_08_00301))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.GridControl_List = New DevExpress.XtraGrid.GridControl
            Me.GridView_RateList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_CurrencyType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_CurrencyType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_Rate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_Rate = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.GridControl_List, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_RateList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_CurrencyType, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_Rate, System.ComponentModel.ISupportInitialize).BeginInit()
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
            'GridControl_List
            '
            Me.GridControl_List.AccessibleDescription = Nothing
            Me.GridControl_List.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_List, "GridControl_List")
            Me.GridControl_List.BackgroundImage = Nothing
            Me.GridControl_List.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_List.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_List.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_List.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_List.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_List.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_List.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_List.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_List.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_List.EmbeddedNavigator.Name = ""
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
            CTag2.ParentControl = Me.GridControl_List.EmbeddedNavigator
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_List.EmbeddedNavigator.Tag = CTag2
            Me.GridControl_List.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_List.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_List.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_List.EmbeddedNavigator.ToolTip")
            Me.GridControl_List.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_List.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_List.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_List.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_List.Font = Nothing
            Me.GridControl_List.MainView = Me.GridView_RateList
            Me.GridControl_List.Name = "GridControl_List"
            Me.GridControl_List.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_CurrencyType, Me.RepositoryItemCalcEdit_Rate})
            Me.GridControl_List.TabStop = False
            Me.GridControl_List.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_RateList})
            '
            'GridView_RateList
            '
            resources.ApplyResources(Me.GridView_RateList, "GridView_RateList")
            Me.GridView_RateList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_CurrencyType, Me.GridColumn_Rate})
            Me.GridView_RateList.GridControl = Me.GridControl_List
            Me.GridView_RateList.Name = "GridView_RateList"
            Me.GridView_RateList.OptionsView.ColumnAutoWidth = False
            Me.GridView_RateList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_CurrencyType
            '
            resources.ApplyResources(Me.GridColumn_CurrencyType, "GridColumn_CurrencyType")
            Me.GridColumn_CurrencyType.ColumnEdit = Me.RepositoryItemLookUpEdit_CurrencyType
            Me.GridColumn_CurrencyType.FieldName = "CURRENCY_TYPE"
            Me.GridColumn_CurrencyType.Name = "GridColumn_CurrencyType"
            Me.GridColumn_CurrencyType.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_CurrencyType
            '
            Me.RepositoryItemLookUpEdit_CurrencyType.AccessibleDescription = Nothing
            Me.RepositoryItemLookUpEdit_CurrencyType.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_CurrencyType, "RepositoryItemLookUpEdit_CurrencyType")
            Me.RepositoryItemLookUpEdit_CurrencyType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_CurrencyType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", "ITEM_MEANING", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_CurrencyType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_CurrencyType.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemLookUpEdit_CurrencyType.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemLookUpEdit_CurrencyType.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemLookUpEdit_CurrencyType.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemLookUpEdit_CurrencyType.Mask.EditMask = resources.GetString("RepositoryItemLookUpEdit_CurrencyType.Mask.EditMask")
            Me.RepositoryItemLookUpEdit_CurrencyType.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemLookUpEdit_CurrencyType.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemLookUpEdit_CurrencyType.Mask.MaskType = CType(resources.GetObject("RepositoryItemLookUpEdit_CurrencyType.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemLookUpEdit_CurrencyType.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemLookUpEdit_CurrencyType.Mask.PlaceHolder"), Char)
            Me.RepositoryItemLookUpEdit_CurrencyType.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemLookUpEdit_CurrencyType.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemLookUpEdit_CurrencyType.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemLookUpEdit_CurrencyType.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemLookUpEdit_CurrencyType.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemLookUpEdit_CurrencyType.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemLookUpEdit_CurrencyType.Name = "RepositoryItemLookUpEdit_CurrencyType"
            Me.RepositoryItemLookUpEdit_CurrencyType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_Rate
            '
            resources.ApplyResources(Me.GridColumn_Rate, "GridColumn_Rate")
            Me.GridColumn_Rate.ColumnEdit = Me.RepositoryItemCalcEdit_Rate
            Me.GridColumn_Rate.FieldName = "RATE"
            Me.GridColumn_Rate.Name = "GridColumn_Rate"
            '
            'RepositoryItemCalcEdit_Rate
            '
            Me.RepositoryItemCalcEdit_Rate.AccessibleDescription = Nothing
            Me.RepositoryItemCalcEdit_Rate.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemCalcEdit_Rate, "RepositoryItemCalcEdit_Rate")
            Me.RepositoryItemCalcEdit_Rate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_Rate.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemCalcEdit_Rate.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemCalcEdit_Rate.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemCalcEdit_Rate.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemCalcEdit_Rate.Mask.EditMask = resources.GetString("RepositoryItemCalcEdit_Rate.Mask.EditMask")
            Me.RepositoryItemCalcEdit_Rate.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemCalcEdit_Rate.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemCalcEdit_Rate.Mask.MaskType = CType(resources.GetObject("RepositoryItemCalcEdit_Rate.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemCalcEdit_Rate.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemCalcEdit_Rate.Mask.PlaceHolder"), Char)
            Me.RepositoryItemCalcEdit_Rate.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemCalcEdit_Rate.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemCalcEdit_Rate.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemCalcEdit_Rate.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemCalcEdit_Rate.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemCalcEdit_Rate.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemCalcEdit_Rate.Name = "RepositoryItemCalcEdit_Rate"
            '
            'M_08_00301
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_List)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_08_00301"
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
            CTag3.ParentControl = Me
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag3
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.GridControl_List, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_RateList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_CurrencyType, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_Rate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GridControl_List As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_RateList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_CurrencyType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_CurrencyType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_Rate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_Rate As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

#End Region

    End Class

End Namespace
