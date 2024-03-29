Imports XL.Common
Imports XL.Common.Utils

Public Class S_01_00804        
    Inherits MarshalByRefObject
    Public Shared Function GetInstance() As S_01_00804                                           
                                                                                                 
        Dim result As S_01_00804                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_01_00804), _
                                String.Format("tcp://{0}/S_01_00804.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_01_00804)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_01_00804
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


    Public Function ServLoadList( _
         ByVal valClientIds As String, _
         ByRef refClientList As MyPosXAuto.FTs.FT_M_MP_CLIENT _
         ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'clientIds 是传进来的clientID，字符串形式，用“，”隔开
        Dim clientIds() As String
        clientIds = valClientIds.Split(","c)

        Dim clientRow As MyPosXAuto.FTs.FT_M_MP_CLIENTRow

        Dim clientConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_CLIENT(XL.DB.Utils.Condition.LogicOperators.Logic_And)

        Dim getRow As MyPosXAuto.FTs.FT_M_MP_CLIENTRow

        '通过id取clientRow并加入refClientList
        For i As Integer = 0 To clientIds.Length - 2

            clientConditions.Clear()
            clientConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_CLIENTColumns.CLIENT_IDColumn, "=", clientIds(i))
            getRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_CLIENTRow(clientConditions)

            If IsNothing(getRow) = False Then

                clientRow = refClientList.NewM_MP_CLIENTRow
                refClientList.AddM_MP_CLIENTRow(clientRow)

                clientRow.CLIENT_ID = getRow.CLIENT_ID
                clientRow.ADDRESS = getRow.ADDRESS
                clientRow.CELL_PHONE = getRow.CELL_PHONE
                clientRow.CITY = getRow.CITY
                clientRow.CLIENT_ATTR1 = getRow.CLIENT_ATTR1
                clientRow.CLIENT_ATTR2 = getRow.CLIENT_ATTR2
                clientRow.CLIENT_ATTR3 = getRow.CLIENT_ATTR3
                clientRow.CLIENT_ATTR4 = getRow.CLIENT_ATTR4
                clientRow.CLIENT_ATTR5 = getRow.CLIENT_ATTR5
                clientRow.CLIENT_ATTR6 = getRow.CLIENT_ATTR6
                clientRow.CLIENT_CODE = getRow.CLIENT_CODE
                clientRow.CLIENT_NAME = getRow.CLIENT_NAME
                clientRow.COUNTRY = getRow.COUNTRY
                clientRow.DEPARTMENT = getRow.DEPARTMENT
                clientRow.EMAIL = getRow.EMAIL
                clientRow.FAX = getRow.FAX
                clientRow.HOME_PHONE = getRow.HOME_PHONE
                clientRow.LINKMAN = getRow.LINKMAN
                clientRow.POST_CODE = getRow.POST_CODE
                clientRow.SELL_DISCOUNT = getRow.SELL_DISCOUNT
                clientRow.STATE = getRow.STATE
                clientRow.TITLE = getRow.TITLE
                clientRow.WEB_SITE = getRow.WEB_SITE
                clientRow.WORK_PHONE = getRow.WORK_PHONE

            End If

        Next

        Return String.Empty

    End Function


    Public Function ServBizUtld0003( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0003(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0004( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0004(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0005( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0005(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0006( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0006(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0007( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0007(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0008( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0008(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0009( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0009(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0010( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0010(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0011( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0011(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0012( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0012(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0013( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0013(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0014( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0014(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0015( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0015(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0016( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0016(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0017( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0017(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0018( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0018(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0019( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0019(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0020( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0020(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    End Class
