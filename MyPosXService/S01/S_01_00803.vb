Imports XL.Common
Imports XL.Common.Utils



Public Class S_01_00803        
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_01_00803                                           
                                                                                                 
        Dim result As S_01_00803                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_01_00803), _
                                String.Format("tcp://{0}/S_01_00803.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_01_00803)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_01_00803
        End If

        Return result

    End Function

    Public Enum LCs
        None
        Utld0002
        Utld0003
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


    Public Function ServImport( _
        ByVal valAutoClientCode As Boolean, _
        ByVal valDistinguishBy As Integer, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_M_MP_CLIENT _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim clientRow As MyPosXAuto.FTs.FT_M_MP_CLIENTRow
        Dim clientCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_CLIENT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim clientCode As String
        Dim counter As Integer = 0
        Dim clientID As String

        Dim dbClientList As New MyPosXAuto.FTs.FT_M_MP_CLIENT
        MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_CLIENT(Nothing, dbClientList)

        clientCondition.Clear()
        For Each bindingRow As MyPosXAuto.FTs.FT_M_MP_CLIENTRow In refBindingList.FindRowsByCondition(clientCondition)

            If bindingRow.ROW_HIGHLIGHT <> MyPosXService.Decls.ROW_HIGHLIGHT_REPEAT_CONFLICT Then

                clientCode = bindingRow.CLIENT_CODE

                clientCondition.Clear()
                If valDistinguishBy = 1 Then
                    clientCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_CLIENTColumns.CLIENT_CODEColumn, "=", bindingRow.CLIENT_CODE)
                Else
                    clientCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_CLIENTColumns.CLIENT_NAMEColumn, "=", bindingRow.CLIENT_NAME)
                End If


                clientRow = dbClientList.FindRowByCondition(clientCondition)

                If IsNothing(clientRow) = True Then


                    If valAutoClientCode = True Then
                        clientCode = Facade.OpBizMaster.GetAutoCustomerCode(False)
                    End If
                    clientID = Guid.NewGuid.ToString
                    dbClientList.AddNewM_MP_CLIENTRow( _
                        bindingRow.ADDRESS, _
                        bindingRow.CELL_PHONE, _
                        bindingRow.CITY, _
                        bindingRow.CLIENT_ATTR1, _
                        bindingRow.CLIENT_ATTR2, _
                        bindingRow.CLIENT_ATTR3, _
                        bindingRow.CLIENT_ATTR4, _
                        bindingRow.CLIENT_ATTR5, _
                        bindingRow.CLIENT_ATTR6, _
                        clientCode, _
                        clientID, _
                        bindingRow.CLIENT_LEVEL, _
                        bindingRow.CLIENT_NAME, _
                        bindingRow.CLIENT_TYPE, _
                        bindingRow.COUNTRY, _
                        bindingRow.DEPARTMENT, _
                        bindingRow.EMAIL, _
                        bindingRow.FAX, _
                        bindingRow.HOME_PHONE, _
                        bindingRow.LINKMAN, _
                        bindingRow.POST_CODE, _
                        bindingRow.REMARKS, _
                        0, _
                        bindingRow.STATE, _
                        bindingRow.TITLE, _
                        bindingRow.WEB_SITE, _
                        bindingRow.WORK_PHONE)
                Else

                    Console.WriteLine(String.Format("{0} , {1}", clientRow.CLIENT_ID, bindingRow.CLIENT_CODE))
                    clientRow.CloneDataRow(bindingRow)
                    'MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_CLIENTInfo( _
                    '    clientRow.CLIENT_ID, _
                    '    bindingRow.ADDRESS, _
                    '    bindingRow.CELL_PHONE, _
                    '    bindingRow.CITY, _
                    '    bindingRow.CLIENT_ATTR1, _
                    '    bindingRow.CLIENT_ATTR2, _
                    '    bindingRow.CLIENT_ATTR3, _
                    '    bindingRow.CLIENT_ATTR4, _
                    '    bindingRow.CLIENT_ATTR5, _
                    '    bindingRow.CLIENT_ATTR6, _
                    '    clientCode, _
                    '    bindingRow.CLIENT_NAME, _
                    '    bindingRow.CLIENT_TYPE, _
                    '    bindingRow.COUNTRY, _
                    '    bindingRow.DEPARTMENT, _
                    '    bindingRow.EMAIL, _
                    '    bindingRow.FAX, _
                    '    bindingRow.HOME_PHONE, _
                    '    bindingRow.LINKMAN, _
                    '    bindingRow.POST_CODE, _
                    '    bindingRow.REMARKS, _
                    '    0, _
                    '    bindingRow.STATE, _
                    '    bindingRow.TITLE, _
                    '    bindingRow.WEB_SITE, _
                    '    bindingRow.WORK_PHONE)
                End If

                bindingRow.Delete()
            End If

            counter += 1

        Next


        MyPosXAuto.Facade.AfBizMaster.SaveBatchM_MP_CLIENTData(dbClientList)


        Return String.Empty

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
