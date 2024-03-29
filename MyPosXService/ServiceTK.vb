﻿Imports XL.Common
Imports XL.Common.Utils


Public Class ServiceTK
    Inherits XL.DB.Utils.BaseService

    Public Shared Function GetInstance() As ServiceTK

        Dim result As ServiceTK
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting Then

            result = CType(Activator.GetObject(GetType(ServiceTK), _
                String.Format("tcp://{0}/ServiceTK.remote", _
                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                ServiceTK)

            If result.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED)
                Throw ex
            End If

        Else

            result = New ServiceTK
        End If

        Return result

    End Function

    Public Sub ServInitDefaultData( _
        ByRef refDEFAULT_CI_CURRENCY_TYPE_VALUE_RMB As Integer, _
        ByRef refDEFAULT_CI_VALUE_WARE_BOM_TYPE_NONE As Integer, _
        ByRef refDEFAULT_CI_TEXT_CLIENT_LEVEL_DEFAULT As Integer, _
        ByRef refRegisterVersionLevelString As String _
        )

        Dim itemID As String = Guid.NewGuid.ToString

        MyPosXService.Decls.DEFAULT_CI_VALUE_CURRENCY_TYPE_RMB = _
            MyPosXService.Facade.OpSysConfig.CreateCommonItem( _
                itemID, _
                MyPosXAuto.Decls.CICNAME_CURRENCY_TYPE, _
                MyPosXService.Decls.DEFAULT_CI_TEXT_CURRENCY_TYPE_RMB, _
                String.Empty, _
                True)

        MyPosXService.Decls.DEFAULT_CI_VALUE_CURRENCY_TYPE_RMB = refDEFAULT_CI_CURRENCY_TYPE_VALUE_RMB

        itemID = Guid.NewGuid.ToString

        MyPosXService.Decls.DEFAULT_CI_VALUE_WARE_BOM_TYPE_NONE = _
            MyPosXService.Facade.OpSysConfig.CreateCommonItem( _
                itemID, _
                MyPosXAuto.Decls.CICNAME_WARE_BOM_TYPE, _
                MyPosXService.Decls.DEFAULT_CI_TEXT_WARE_BOM_TYPE_NONE, _
                String.Empty, _
                True)

        MyPosXService.Decls.DEFAULT_CI_VALUE_WARE_BOM_TYPE_NONE = refDEFAULT_CI_VALUE_WARE_BOM_TYPE_NONE



        MyPosXService.Decls.DEFAULT_CI_VALUE_CLIENT_LEVEL_DEFAULT = _
            MyPosXService.Facade.OpSysConfig.CreateCommonItem( _
                Guid.NewGuid.ToString, _
                MyPosXAuto.Decls.CICNAME_CLIENT_LEVEL, _
                MyPosXService.Decls.DEFAULT_CI_TEXT_CLIENT_LEVEL_DEFAULT, _
                String.Empty, _
                True)

        MyPosXService.Decls.DEFAULT_CI_VALUE_CLIENT_LEVEL_DEFAULT = refDEFAULT_CI_TEXT_CLIENT_LEVEL_DEFAULT


        '=================================================================================================================
        refRegisterVersionLevelString = SysInfo.RegisterVersionLevel.ToString

    End Sub


End Class

