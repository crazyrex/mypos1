Imports XL.Common
Imports XL.Common.Utils

Namespace Reports

    Public Class R_02_00801PractWareLabel01

        Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
            Me.Margins.Left += CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_PRINT_LABEL_OFFSET_X))
            Me.Margins.Top += CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_PRINT_LABEL_OFFSET_Y))

        End Sub

    End Class

End Namespace
