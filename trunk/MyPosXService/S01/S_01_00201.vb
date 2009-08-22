Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade
Imports System.Collections


Public Class S_01_00201
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_01_00201

        Dim result As S_01_00201
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting Then


            result = CType(Activator.GetObject(GetType(S_01_00201), _
                           String.Format("tcp://{0}/S_01_00201.remote", _
                               SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                           S_01_00201)
        Else

            result = New S_01_00201
        End If

        Return result

    End Function

    Public Enum LCs
        None
        Choose
        Utld0003
        Utld0004
        Utld0005
    End Enum



    Public Function ServInitDisplay( _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByRef refSysHideFinancials As Boolean, _
        ByRef refSysShowCustomWareCode As Boolean, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        refSysWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_SPEC_MODEL_DISCARD))
        refSysHideFinancials = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_HIDE_FINANCIALS))


        refSysAttribute1 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1)
        refSysAttribute2 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2)
        refSysAttribute3 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3)
        refSysAttribute4 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4)

        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1_HIDDEN)) = True Then
            refSysAttribute1 = String.Empty
        End If
        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2_HIDDEN)) = True Then
            refSysAttribute2 = String.Empty
        End If
        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3_HIDDEN)) = True Then
            refSysAttribute3 = String.Empty
        End If
        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4_HIDDEN)) = True Then
            refSysAttribute4 = String.Empty
        End If

        refSysShowCustomWareCode = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE))

        Return result

    End Function


    Public Function ServAllWareExportExcel( _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByRef refSysHideFinancials As Boolean, _
        ByVal valLoginStaffID As String, _
        ByRef refStaffRowSE As MyPosXAuto.FTs.FT_M_STAFFRowSEntity, _
        ByRef refAllWareList As MyPosXAuto.FTs.FT_M_MP_WARE, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Try

            MyPosXAuto.Facade.AfBizMaster.FillM_STAFFRowSEntity(refStaffRowSE, valLoginStaffID)

            refSysWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_SPEC_MODEL_DISCARD))
            refSysHideFinancials = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_HIDE_FINANCIALS))

            refSysAttribute1 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1)
            refSysAttribute2 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2)
            refSysAttribute3 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3)
            refSysAttribute4 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4)

            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1_HIDDEN)) = True Then
                refSysAttribute1 = String.Empty
            End If
            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2_HIDDEN)) = True Then
                refSysAttribute2 = String.Empty
            End If
            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3_HIDDEN)) = True Then
                refSysAttribute3 = String.Empty
            End If
            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4_HIDDEN)) = True Then
                refSysAttribute4 = String.Empty
            End If

            MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_WARE(Nothing, refAllWareList)


        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServSingalClassifyExportExcel( _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByRef refSysHideFinancials As Boolean, _
        ByVal valLoginStaffID As String, _
        ByRef refStaffRowSE As MyPosXAuto.FTs.FT_M_STAFFRowSEntity, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Try

            MyPosXAuto.Facade.AfBizMaster.FillM_STAFFRowSEntity(refStaffRowSE, valLoginStaffID)

            refSysWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_SPEC_MODEL_DISCARD))
            refSysHideFinancials = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_HIDE_FINANCIALS))

            refSysAttribute1 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1)
            refSysAttribute2 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2)
            refSysAttribute3 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3)
            refSysAttribute4 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4)

            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1_HIDDEN)) = True Then
                refSysAttribute1 = String.Empty
            End If
            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2_HIDDEN)) = True Then
                refSysAttribute2 = String.Empty
            End If
            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3_HIDDEN)) = True Then
                refSysAttribute3 = String.Empty
            End If
            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4_HIDDEN)) = True Then
                refSysAttribute4 = String.Empty
            End If

            'Dim wareCondition As New MyPosXAuto.Facade.afbizmaster.ConditionOfM_MP_WARE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            'wareCondition.Clear()
            'wareCondition.Add( _
            '    afbizmaster.M_MP_WAREColumns.WARE_CLASSIFY_IDColumn, _
            '    "=", _
            '    valWareClassifyID)

            'refWareList.Clear()
            'MyPosXAuto.Facade.afbizmaster.FillFT_M_MP_WARE(wareCondition, refWareList)


        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty

    End Function


    Public Function ServSaveCostPriceModify( _
        ByVal valSaveWareList As MyPosXAuto.FTs.FT_M_MP_WARE _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)


        For Each wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow In valSaveWareList
            wareCondition.Clear()
            wareCondition.Add(AfBizMaster.M_MP_WAREColumns.WARE_IDColumn, "=", wareRow.WARE_ID)

            If MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARECount(wareCondition) = 0 Then
                wareRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_NOT_EXIST
                Continue For
            End If

            MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_WARERow(wareRow.WARE_ID, AfBizMaster.M_MP_WAREColumns.UNIT_COSTColumn, wareRow.UNIT_COST)
            MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_WARERow(wareRow.WARE_ID, AfBizMaster.M_MP_WAREColumns.UNIT_PRICEColumn, wareRow.UNIT_PRICE)
        Next

        Return String.Empty

    End Function


    Public Function ServUtld0005( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0006( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0007( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0008( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0009( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0010( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0011( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String


        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0012( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0013( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0014( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0015( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0016( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String


        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0017( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String


        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0018( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0019( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0020( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


End Class
