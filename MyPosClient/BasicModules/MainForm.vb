Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils

Namespace Utils

    Public Class MainForm
        Inherits XL.Win.Window.BaseMainForm

        Private WithEvents _bizAgent As New MainformAgent(Me)
#Region " Windows Auto Generated Code"

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
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.Panel_TopImage.SuspendLayout()
            Me.SuspendLayout()
            '
            'Timer_CheckAlert
            '
            '
            'LabelControl_FormTitle
            '
            Me.LabelControl_FormTitle.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.LabelControl_FormTitle.Appearance.ForeColor = System.Drawing.Color.White
            Me.LabelControl_FormTitle.Appearance.Options.UseFont = True
            Me.LabelControl_FormTitle.Appearance.Options.UseForeColor = True
             '
            'LabelControl_SystemTitle
            '
            Me.LabelControl_SystemTitle.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.LabelControl_SystemTitle.Appearance.ForeColor = System.Drawing.Color.Black
            Me.LabelControl_SystemTitle.Appearance.Options.UseFont = True
            Me.LabelControl_SystemTitle.Appearance.Options.UseForeColor = True
            Me.LabelControl_SystemTitle.Location = New System.Drawing.Point(64, 24)
            Me.LabelControl_SystemTitle.Size = New System.Drawing.Size(216, 24)
            Me.LabelControl_SystemTitle.Text = ""
            Me.LabelControl_SystemTitle.Visible = False
            '
            'Label_Clock
            '
            Me.Label_Clock.Location = New System.Drawing.Point(806, 18)
            '
            'Timer_Clock
            '
            Me.Timer_Clock.Enabled = True
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
            Me.ClientSize = New System.Drawing.Size(1016, 696)
            Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.Text = ""
            Me.Panel_TopImage.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Protected Overrides ReadOnly Property GetFormByTypeName(ByVal formTypeName As String) As XL.Win.Component.BaseForm
            Get

                Try

                    If SysInfo.SysLMValid = False Then

                        XL.Win.Window.XLMessageBox.ShowMessage( _
                            MyPosXService.Decls.MSG_OK_00009, _
                            Window.XLMessageBox.MessageType.Wrong, _
                            MessageBoxButtons.OK)

                        Me.DoForbiddenOperations()
                        Return Nothing

                    End If

                Catch ex As Exception

                End Try


                'Window.XLMessageBox.ShowMessage(formTypeName, Window.XLMessageBox.MessageType.Information, MessageBoxButtons.OK)

                Dim appendFormType As Type = Type.GetType(formTypeName)
                Dim args As Object() = {Me.TransactRequestHandle, 0}
                Dim result As XL.Win.Component.BaseForm = CType(Activator.CreateInstance(appendFormType, args), XL.Win.Component.BaseForm)

                Return result

            End Get
        End Property

        Protected Overrides ReadOnly Property GetAlertForm() As System.Collections.Hashtable
            Get

                Dim result As New Hashtable

                'If MyPosXService.facade.OpCheck.GetCheckValue() = True Then  

                '    result.Add(Decls.ALERT_TITLE_UTLD,"MyPosClient.Manifest.M_04_00101")  

                'End If  

                'If MyPosXService.facade.OpCheck.GetCheckValue() = True Then   

                '    result.Add(Decls.ALERT_TITLE_UTLD,"MyPosClient.Manifest.M_04_00201")  

                'End If  

                'If MyPosXService.facade.OpCheck.GetCheckValue() = True Then 

                '    result.Add(Decls.ALERT_TITLE_UTLD,"MyPosClient.Manifest.M_04_00301")  

                'End If  

                'If MyPosXService.facade.OpCheck..GetCheckValue() = True Then

                '    result.Add(Decls.ALERT_TITLE_UTLD,"MyPosClient.Manifest.M_04_00401")  

                'End If  

                'If MyPosXService.facade.OpCheck..GetCheckValue() = True Then     

                '    result.Add(Decls.ALERT_TITLE_UTLD,"MyPosClient.Manifest.M_04_00501")  

                'End If  


                Return result
            End Get
        End Property


        Private Sub _bizAgent_Responded(ByVal responseResult As XL.Win.Component.BaseAgent.AgentResponse) Handles _bizAgent.Responded

            Dim operResult As String = CommTK.FString(responseResult.GetValue(WinDecl.RVN_SUCCEED))

            '    
            '操作不成功的情况下, 用出对话框报告操作不成功的原因  
            '-------------------------------------------------------------------   

            If operResult <> String.Empty Then
                XL.Win.Window.XLMessageBox.ShowMessage(operResult, Window.XLMessageBox.MessageType.Wrong, MessageBoxButtons.OK)


                Select Case Me._bizAgent.AffairOf(responseResult.ResponseTitle)              'transaction cases under error  



                End Select


                Return
            End If

            '    
            '操作成功的情况下, 继续下面的成功后处理  
            '-------------------------------------------------------------------   

            Select Case Me._bizAgent.AffairOf(responseResult.ResponseTitle)

                Case MainformAgent.Affairs.CheckAlerts

                    Me.DoPublicDisplayAlerts()

            End Select
        End Sub
        Private Sub Timer_CheckAlert_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_CheckAlert.Tick

            Me._bizAgent.DoRequest(MainformAgent.Affairs.CheckAlerts, False)

        End Sub


        Private Sub Timer_Clock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Clock.Tick
            Me._bizAgent.DoRequest(MainformAgent.Affairs.Clocking, False)
        End Sub


        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me._bizAgent.DoRequest(MainformAgent.Affairs.DisplayLoginAccountInfo, True)

        End Sub
    End Class

End Namespace
