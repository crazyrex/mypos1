Imports XL.Common
Imports XL.Common.Utils

Public Class S_02_00701        
    Inherits MarshalByRefObject
    Public Shared Function GetInstance() As S_02_00701                                           
                                                                                                 
        Dim result As S_02_00701                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try

                result = CType(Activator.GetObject(GetType(S_02_00701), _
                                String.Format("tcp://{0}/S_02_00701.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_02_00701)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_02_00701
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


    Public Function ServBizUtld0001( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0001(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0002( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0002(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
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
