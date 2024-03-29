Imports XL.Common
Imports XL.Common.Utils



Public Class S_01_00602        
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_01_00602                                           
                                                                                                 
        Dim result As S_01_00602                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then


            Try
                result = CType(Activator.GetObject(GetType(S_01_00602), _
                                String.Format("tcp://{0}/S_01_00602.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_01_00602)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_01_00602
        End If

        Return result

    End Function

    Public Enum LCs
        None
        View
        Edit
        Utld0004
        Utld0005
    End Enum



    Public Function ServSaveInfo( _
        ByRef refEditingSupplierID As String, _
        ByRef refSupplierCode As String, _
        ByVal valManualCode As Boolean, _
        ByVal valAddress As String, _
        ByVal valCellPhone As String, _
        ByVal valCity As String, _
        ByVal valCountry As String, _
        ByVal valDepartment As String, _
        ByVal valEmail As String, _
        ByVal valFax As String, _
        ByVal valHomePhone As String, _
        ByVal valContactPerson As String, _
        ByVal valPostCode As String, _
        ByVal valRemarks As String, _
        ByVal valState As String, _
        ByVal valSupplierName As String, _
        ByVal valTitle As String, _
        ByVal valWebSite As String, _
        ByVal valWorkPhone As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        If refEditingSupplierID = String.Empty Then

            If valManualCode = False Then
                refSupplierCode = Facade.OpBizMaster.GetAutoSupplierCode(False)
            End If
            refEditingSupplierID = Guid.NewGuid.ToString

            MyPosXAuto.Facade.AfBizMaster.CreateM_MP_SUPPLIERInfo( _
                 valAddress, _
                 valCellPhone, _
                 valCity, _
                valCountry, _
                valDepartment, _
                valEmail, _
                valFax, _
                valHomePhone, _
                valContactPerson, _
                valPostCode, _
                valRemarks, _
                valState, _
                refSupplierCode, _
                refEditingSupplierID, _
                valSupplierName, _
                valTitle, _
                valWebSite, _
                valWorkPhone)
            Return String.Empty
        End If

        MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_SUPPLIERInfo( _
            refEditingSupplierID, _
            valAddress, _
            valCellPhone, _
            valCity, _
            valCountry, _
            valDepartment, _
            valEmail, _
            valFax, _
            valHomePhone, _
            valContactPerson, _
            valPostCode, _
            valRemarks, _
            valState, _
            refSupplierCode, _
            valSupplierName, _
            valTitle, _
            valWebSite, _
            valWorkPhone)

        Return String.Empty

    End Function


    Public Function ServLoadInfo( _
        ByRef refSupplierCode As String, _
        ByVal valSupplierID As String, _
        ByRef refSupplierRowSE As MyPosXAuto.FTs.FT_M_MP_SUPPLIERRowSEntity) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        refSupplierCode = Facade.OpBizMaster.GetAutoSupplierCode(True)

        MyPosXAuto.Facade.AfBizMaster.FillM_MP_SUPPLIERRowSEntity(refSupplierRowSE, valSupplierID)

        Return result

    End Function


    Public Function ServUtld0003( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0004( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

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
