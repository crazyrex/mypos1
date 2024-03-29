Imports XL.Common
Imports XL.Common.Utils



Public Class S_01_00103        
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_01_00103                                           
                                                                                                 
        Dim result As S_01_00103                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_01_00103), _
                               String.Format("tcp://{0}/S_01_00103.remote", _
                                   SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                               S_01_00103)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_01_00103
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



    Public Function ServImport( _
        ByVal valDistinguishBy As Integer, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_M_STAFF _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim staffRow As MyPosXAuto.FTs.FT_M_STAFFRow
        Dim staffCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_STAFF(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim staffCode As String
        Dim counter As Integer = 0
        Dim staffID As String


        staffCondition.Clear()
        For Each bindingRow As MyPosXAuto.FTs.FT_M_STAFFRow In refBindingList.FindRowsByCondition(staffCondition)

            If bindingRow.ROW_HIGHLIGHT <> MyPosXService.Decls.ROW_HIGHLIGHT_REPEAT_CONFLICT Then

                staffCode = bindingRow.STAFF_CODE

                staffCondition.Clear()
                If valDistinguishBy = 1 Then
                    staffCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_STAFFColumns.STAFF_CODEColumn, "=", bindingRow.STAFF_CODE)
                Else
                    staffCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_STAFFColumns.STAFF_NAMEColumn, "=", bindingRow.STAFF_NAME)
                End If


                staffRow = MyPosXAuto.Facade.AfBizMaster.GetM_STAFFRow(staffCondition)

                If IsNothing(staffRow) = True Then
                    staffID = Guid.NewGuid.ToString
                    MyPosXAuto.Facade.AfBizMaster.CreateM_STAFFInfo( _
                        staffID, _
                        bindingRow.ADDRESS, _
                        bindingRow.CELL_PHONE, _
                        bindingRow.CITY, _
                        bindingRow.COUNTRY, _
                        bindingRow.DEPARTMENT, _
                        bindingRow.EMAIL, _
                        bindingRow.FAX, _
                        bindingRow.HOME_PHONE, _
                        bindingRow.POST_CODE, _
                        bindingRow.REMARKS, _
                        staffCode, _
                        bindingRow.STAFF_NAME, _
                        bindingRow.STATE, _
                        bindingRow.TITLE, _
                        bindingRow.WORK_PHONE)
                Else

                    MyPosXAuto.Facade.AfBizMaster.ReviseM_STAFFInfo( _
                        staffRow.STAFF_ID, _
                        bindingRow.ADDRESS, _
                        bindingRow.CELL_PHONE, _
                        bindingRow.CITY, _
                        bindingRow.COUNTRY, _
                        bindingRow.DEPARTMENT, _
                        bindingRow.EMAIL, _
                        bindingRow.FAX, _
                        bindingRow.HOME_PHONE, _
                        bindingRow.POST_CODE, _
                        bindingRow.REMARKS, _
                        staffCode, _
                        bindingRow.STAFF_NAME, _
                        bindingRow.STATE, _
                        bindingRow.TITLE, _
                        bindingRow.WORK_PHONE)
                End If

                bindingRow.Delete()
            End If

            counter += 1

        Next


        Return String.Empty

    End Function


    Public Function ServUtld0002( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String


        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

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
