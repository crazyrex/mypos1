Imports XL.Common
Imports XL.Common.Utils



Public Class S_01_00802        
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_01_00802                                           
                                                                                                 
        Dim result As S_01_00802                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_01_00802), _
                                String.Format("tcp://{0}/S_01_00802.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_01_00802)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_01_00802
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



    Public Function ServInitDisplay( _
        ByRef refClientAttr1 As String, _
        ByRef refClientAttr2 As String, _
        ByRef refClientAttr3 As String, _
        ByRef refClientAttr4 As String, _
        ByRef refClientAttr5 As String, _
        ByRef refClientAttr6 As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        refClientAttr1 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR1)
        refClientAttr2 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR2)
        refClientAttr3 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR3)
        refClientAttr4 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR4)
        refClientAttr5 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR5)
        refClientAttr6 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CLIENT_ATTR6)


        Return result

    End Function


    Public Function ServLoadInfo( _
        ByRef valEditingClientID As String, _
        ByRef refclientRowSEntity As MyPosXAuto.FTs.FT_M_MP_CLIENTRowSEntity _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        MyPosXAuto.Facade.AfBizMaster.FillM_MP_CLIENTRowSEntity(refclientRowSEntity, valEditingClientID)

        Return String.Empty

    End Function


    Public Function ServSaveInfo( _
        ByVal valManualCode As Boolean, _
        ByRef refEditingClientID As String, _
        ByRef refCustomCode As String, _
        ByVal valAddress As String, _
        ByVal valCellPhone As String, _
        ByVal valCity As String, _
        ByVal valClientAttr1 As String, _
        ByVal valClientAttr2 As String, _
        ByVal valClientAttr3 As String, _
        ByVal valClientAttr4 As String, _
        ByVal valClientAttr5 As String, _
        ByVal valClientAttr6 As String, _
        ByVal valClientType As Integer, _
        ByVal valCustomerName As String, _
        ByVal valCountry As String, _
        ByVal valDepartment As String, _
        ByVal valEmail As String, _
        ByVal valFax As String, _
        ByVal valHomePhone As String, _
        ByVal valContractPerson As String, _
        ByVal valPostCode As String, _
        ByVal valRemarks As String, _
        ByVal valState As String, _
        ByVal valTitle As String, _
        ByVal valWebSite As String, _
        ByVal valWorkPhone As String, _
        ByVal valClientLevel As Integer _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Try
            If refEditingClientID = String.Empty Then


                If valManualCode = False Then
                    refCustomCode = Facade.OpBizMaster.GetAutoCustomerCode(False)
                End If

                Dim clientID = Guid.NewGuid.ToString

                MyPosXAuto.Facade.AfBizMaster.CreateM_MP_CLIENTInfo( _
                    valAddress, _
                    valCellPhone, _
                    valCity, _
                    valClientAttr1, _
                    valClientAttr2, _
                    valClientAttr3, _
                    valClientAttr4, _
                    valClientAttr5, _
                    valClientAttr6, _
                    refCustomCode, _
                    clientID, _
                    valClientLevel, _
                    valCustomerName, _
                    valClientType, _
                    valCountry, _
                    valDepartment, _
                    valEmail, _
                    valFax, _
                    valHomePhone, _
                    valContractPerson, _
                    valPostCode, _
                    valRemarks, _
                    0, _
                    valState, _
                    valTitle, _
                    valWebSite, _
                    valWorkPhone)

                Return String.Empty
            End If

            MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_CLIENTInfo( _
                refEditingClientID, _
                    valAddress, _
                    valCellPhone, _
                    valCity, _
                    valClientAttr1, _
                    valClientAttr2, _
                    valClientAttr3, _
                    valClientAttr4, _
                    valClientAttr5, _
                    valClientAttr6, _
                    refCustomCode, _
                    valClientLevel, _
                    valCustomerName, _
                    valClientType, _
                    valCountry, _
                    valDepartment, _
                    valEmail, _
                    valFax, _
                    valHomePhone, _
                    valContractPerson, _
                    valPostCode, _
                    valRemarks, _
                    0, _
                    valState, _
                    valTitle, _
                    valWebSite, _
                    valWorkPhone)


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
