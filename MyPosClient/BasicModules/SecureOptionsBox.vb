Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils

Namespace Utils

    Public Class SecureOptionsBox   
        Inherits XL.Win.Component.OptionsBox    

        Public Const OPN_UTLD_0000 As String =""
        Public Const OPN_UTLD_0001 As String =""
        Public Const OPN_UTLD_0002 As String =""
        Public Const OPN_UTLD_0003 As String =""
        Public Const OPN_UTLD_0004 As String =""
        Public Const OPN_UTLD_0005 As String =""

#Region" Windows auto generated code" 

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
            Me.SuspendLayout()
            '
            'SecureOptionsBox
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
            Me.Name = "SecureOptionsBox"
            Me.Size = New System.Drawing.Size(368, 64)
            Me.ResumeLayout(False)

        End Sub

#End Region 

        Protected Overrides Sub DoLoadOptions() 

            'Me.Control_.EditValue = CommTK.FInteger(Me._options.Options(Me.OPN_UTLD))     

        End Sub   

        Protected Overrides Sub DoApplyOptions()

            'Me._options.Options(Me.OPN_UTLD) = CommTK.FString(Me.Control_.EditValue)

        End Sub   

        Protected Overrides Sub DoSetDefaultOptions() 

            'Me._options.Options(Me.OPN_UTLD_) = CommTK.FString(MyPosXAuto.Decls.CIVALUE_UTLD)

        End Sub   
        Public Overrides Sub SetAccessable()
  
        End Sub     
        Public Overrides Sub SetReadonly()

        End Sub   

    End Class

End Namespace
