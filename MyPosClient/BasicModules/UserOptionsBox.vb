Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils

Namespace Utils

    Public Class UserOptionsBox
        Inherits XL.Win.Component.OptionsBox

        Public Const OPN_STAFF_ID As String = "OPN_STAFF_ID"
        Public Const OPN_COST_HIDDEN As String = "OPN_COST_HIDDEN"
        Public Const OPN_PRICE_HIDDEN As String = "OPN_PRICE_HIDDEN"
        Public Const OPN_DELETE_WARE_ALLOWED As String = "OPN_DELETE_WARE_ALLOWED"
        Public Const OPN_FINANCIAL_FORBIDDENED As String = "OPN_FINANCIAL_FORBIDDENED"
        Public Const OPN_UTLD_0003 As String = ""
        Public Const OPN_UTLD_0004 As String = ""
        Public Const OPN_UTLD_0005 As String = ""

        Friend WithEvents LookUpEdit_Employee As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents CheckEdit_DeleteWareAllowed As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents CheckEdit_CostHidden As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents CheckEdit_PriceHidden As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents CheckEdit_FinancialForbiddened As DevExpress.XtraEditors.CheckEdit

        Private _bindingEmployeeList As New MyPosXAuto.FTs.FT_M_STAFF

#Region " Windows auto generated code"

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
        Friend WithEvents Label1 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserOptionsBox))
            Me.Label1 = New System.Windows.Forms.Label
            Me.LookUpEdit_Employee = New DevExpress.XtraEditors.LookUpEdit
            Me.CheckEdit_DeleteWareAllowed = New DevExpress.XtraEditors.CheckEdit
            Me.CheckEdit_CostHidden = New DevExpress.XtraEditors.CheckEdit
            Me.CheckEdit_PriceHidden = New DevExpress.XtraEditors.CheckEdit
            Me.CheckEdit_FinancialForbiddened = New DevExpress.XtraEditors.CheckEdit
            CType(Me.LookUpEdit_Employee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_DeleteWareAllowed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_CostHidden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_PriceHidden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_FinancialForbiddened.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.Name = "Label1"
            '
            'LookUpEdit_Employee
            '
            resources.ApplyResources(Me.LookUpEdit_Employee, "LookUpEdit_Employee")
            Me.LookUpEdit_Employee.Name = "LookUpEdit_Employee"
            Me.LookUpEdit_Employee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_Employee.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_Employee.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("STAFF_CODE", "STAFF_CODE", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("STAFF_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Employee.Properties.DisplayMember = "STAFF_NAME"
            Me.LookUpEdit_Employee.Properties.NullText = resources.GetString("LookUpEdit_Employee.Properties.NullText")
            Me.LookUpEdit_Employee.Properties.ValueMember = "STAFF_ID"
            '
            'CheckEdit_DeleteWareAllowed
            '
            resources.ApplyResources(Me.CheckEdit_DeleteWareAllowed, "CheckEdit_DeleteWareAllowed")
            Me.CheckEdit_DeleteWareAllowed.Name = "CheckEdit_DeleteWareAllowed"
            Me.CheckEdit_DeleteWareAllowed.Properties.Caption = resources.GetString("CheckEdit_DeleteWareAllowed.Properties.Caption")
            Me.CheckEdit_DeleteWareAllowed.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
            '
            'CheckEdit_CostHidden
            '
            resources.ApplyResources(Me.CheckEdit_CostHidden, "CheckEdit_CostHidden")
            Me.CheckEdit_CostHidden.Name = "CheckEdit_CostHidden"
            Me.CheckEdit_CostHidden.Properties.Caption = resources.GetString("CheckEdit_CostHidden.Properties.Caption")
            Me.CheckEdit_CostHidden.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
            '
            'CheckEdit_PriceHidden
            '
            resources.ApplyResources(Me.CheckEdit_PriceHidden, "CheckEdit_PriceHidden")
            Me.CheckEdit_PriceHidden.Name = "CheckEdit_PriceHidden"
            Me.CheckEdit_PriceHidden.Properties.Caption = resources.GetString("CheckEdit_PriceHidden.Properties.Caption")
            Me.CheckEdit_PriceHidden.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
            '
            'CheckEdit_FinancialForbiddened
            '
            resources.ApplyResources(Me.CheckEdit_FinancialForbiddened, "CheckEdit_FinancialForbiddened")
            Me.CheckEdit_FinancialForbiddened.Name = "CheckEdit_FinancialForbiddened"
            Me.CheckEdit_FinancialForbiddened.Properties.Caption = resources.GetString("CheckEdit_FinancialForbiddened.Properties.Caption")
            Me.CheckEdit_FinancialForbiddened.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
            '
            'UserOptionsBox
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.CheckEdit_FinancialForbiddened)
            Me.Controls.Add(Me.CheckEdit_PriceHidden)
            Me.Controls.Add(Me.CheckEdit_CostHidden)
            Me.Controls.Add(Me.CheckEdit_DeleteWareAllowed)
            Me.Controls.Add(Me.LookUpEdit_Employee)
            Me.Controls.Add(Me.Label1)
            Me.Name = "UserOptionsBox"
            CType(Me.LookUpEdit_Employee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_DeleteWareAllowed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_CostHidden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_PriceHidden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_FinancialForbiddened.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Protected Overrides Sub DoLoadOptions()
            Me.LookUpEdit_Employee.EditValue = Me._options.Options(UserOptionsBox.OPN_STAFF_ID)
            Me.CheckEdit_DeleteWareAllowed.Checked = CommTK.FBoolean(Me._options.Options(UserOptionsBox.OPN_DELETE_WARE_ALLOWED))
            Me.CheckEdit_CostHidden.Checked = CommTK.FBoolean(Me._options.Options(UserOptionsBox.OPN_COST_HIDDEN))
            Me.CheckEdit_PriceHidden.Checked = CommTK.FBoolean(Me._options.Options(UserOptionsBox.OPN_PRICE_HIDDEN))
            Me.CheckEdit_FinancialForbiddened.Checked = CommTK.FBoolean(Me._options.Options(UserOptionsBox.OPN_FINANCIAL_FORBIDDENED))
            'Me.Control_.EditValue = CommTK.FInteger(Me._options.Options(Me.OPN_UTLD))     

        End Sub

        Protected Overrides Sub DoApplyOptions()

            Me._options.Options(UserOptionsBox.OPN_FINANCIAL_FORBIDDENED) = CommTK.FString(Me.CheckEdit_FinancialForbiddened.Checked)
            Me._options.Options(UserOptionsBox.OPN_STAFF_ID) = CommTK.FString(Me.LookUpEdit_Employee.EditValue)
            Me._options.Options(UserOptionsBox.OPN_DELETE_WARE_ALLOWED) = CommTK.FString(Me.CheckEdit_DeleteWareAllowed.Checked)
            Me._options.Options(UserOptionsBox.OPN_COST_HIDDEN) = CommTK.FString(Me.CheckEdit_CostHidden.Checked)
            Me._options.Options(UserOptionsBox.OPN_PRICE_HIDDEN) = CommTK.FString(Me.CheckEdit_PriceHidden.Checked)
            Me._options.Options(UserOptionsBox.OPN_FINANCIAL_FORBIDDENED) = CommTK.FString(Me.CheckEdit_FinancialForbiddened.Checked)

        End Sub

        Protected Overrides Sub DoSetDefaultOptions()

            'Me._options.Options(Me.OPN_UTLD_) = CommTK.FString(MyPosXAuto.Decls.CIVALUE_UTLD)

        End Sub
        Public Overrides Sub SetAccessable()

        End Sub
        Public Overrides Sub SetReadonly()

        End Sub

        Public Sub UserOptionsBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me._bindingEmployeeList.Clear()
            MyPosXAuto.Facade.AfBizMaster.FillFT_M_STAFF(Nothing, Me._bindingEmployeeList)

            Me.LookUpEdit_Employee.Properties.DataSource = Me._bindingEmployeeList

        End Sub

        Private Sub LookUpEdit_Employee_ProcessNewValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs) Handles LookUpEdit_Employee.ProcessNewValue

            Dim newEmployee As String = CommTK.FString(e.DisplayValue)
            If newEmployee = String.Empty Then
                Return
            End If

            Dim staffConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_STAFF( _
                XL.DB.Utils.Condition.LogicOperators.Logic_And)
            staffConditions.Add( _
                 MyPosXAuto.Facade.AfBizMaster.M_STAFFColumns.STAFF_CODEColumn, _
                "=", _
                newEmployee)

            Dim staffRow As MyPosXAuto.FTs.FT_M_STAFFRow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_STAFFRow(staffConditions)

            If IsNothing(staffRow) = True Then
                Return
            End If

            Me.LookUpEdit_Employee.EditValue = staffRow.STAFF_ID

            Me.LookUpEdit_Employee.Update()

        End Sub

        'Private Sub CheckEdit_Edit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckEdit_Edit.CheckedChanged

        '    Dim poForm As New Manifest.M_02_00101
        '    Dim saForm As New Manifest.M_02_00201

        '    poForm.ToolStripButton_Edit.Enabled = Me.CheckEdit_Edit.Checked
        '    saForm.ToolStripButton_Edit.Enabled = Me.CheckEdit_Edit.Checked


        'End Sub


    End Class

End Namespace
