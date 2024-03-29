Imports XL.Common
Imports XL.Common.Utils



Public Class S_02_00202        
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_02_00202                                           
                                                                                                 
        Dim result As S_02_00202                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_02_00202), _
                                String.Format("tcp://{0}/S_02_00202.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_02_00202)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_02_00202
        End If

        Return result

    End Function

    Public Enum LCs
        None
        Edit
        View
        Utld0004
        Utld0005
    End Enum


    Public Function ServInitDisplay( _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByVal valLoginStaffID As String, _
        ByRef refStaffRowSE As MyPosXAuto.FTs.FT_M_STAFFRowSEntity, _
        ByRef refWareList As MyPosXAuto.FTs.FT_M_MP_POS, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        MyPosXAuto.Facade.AfBizMaster.FillM_STAFFRowSEntity(refStaffRowSE, valLoginStaffID)

        refSysWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_SPEC_MODEL_DISCARD))

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

        Dim wareCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_M_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)

        MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_POS(Nothing, refWareList)

        Return result

    End Function

    Public Function ServExportExcel( _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByVal valLoginStaffID As String, _
        ByRef refStaffRowSE As MyPosXAuto.FTs.FT_M_STAFFRowSEntity, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        MyPosXAuto.Facade.AfBizMaster.FillM_STAFFRowSEntity(refStaffRowSE, valLoginStaffID)

        refSysWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_SPEC_MODEL_DISCARD))

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

        Return result

    End Function

    Public Function ServImportFromMobile( _
        ByVal valPosID As String, _
        ByVal valReadTurnoverList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_T_MP_INVENTORY_DRAFT _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
                  MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(valPosID)

        If IsNothing(posRow) = True Then
            Return MyPosXService.Decls.MSG_ALERT_00027
        End If

        Dim bindingRow As MyPosXAuto.FTs.FT_XV_T_MP_INVENTORY_DRAFTRow
        Dim wareRow As MyPosXAuto.FTs.FT_XV_M_MP_WARERow
        Dim wareCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_M_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim inventoryDraftConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_INVENTORY_DRAFT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim origionPrice As Decimal




        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        For Each turnoverDtlRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTLRow In valReadTurnoverList

            inventoryDraftConditions.Clear()
            inventoryDraftConditions.Add(MyPosXAuto.Facade.AfXV.XV_T_MP_INVENTORY_DRAFTColumns.WARE_CODEColumn, "=", turnoverDtlRow.WARE_CODE)
            bindingRow = refBindingList.FindRowByCondition(inventoryDraftConditions)

            If IsNothing(bindingRow) = True Then


                wareCondition.Clear()
                wareCondition.Add(MyPosXAuto.Facade.AfXV.XV_M_MP_WAREColumns.WARE_CODEColumn, "=", turnoverDtlRow.WARE_CODE)
                wareRow = MyPosXAuto.Facade.AfXV.GetXV_M_MP_WARERow(wareCondition)
                If IsNothing(wareRow) = False Then

                    bindingRow = refBindingList.NewXV_T_MP_INVENTORY_DRAFTRow
                    refBindingList.AddXV_T_MP_INVENTORY_DRAFTRow(bindingRow)
                    bindingRow.WARE_ID = wareRow.WARE_ID
                    bindingRow.WARE_NAME = wareRow.WARE_NAME
                    bindingRow.SPEC = wareRow.SPEC
                    bindingRow.MODEL = wareRow.MODEL
                    bindingRow.UNIT_NAME = wareRow.UNIT_NAME
                    bindingRow.ATTRIBUTE1 = wareRow.ATTRIBUTE1
                    bindingRow.ATTRIBUTE2 = wareRow.ATTRIBUTE2
                    bindingRow.ATTRIBUTE3 = wareRow.ATTRIBUTE3
                    bindingRow.ATTRIBUTE4 = wareRow.ATTRIBUTE4
                    bindingRow.REMARK = wareRow.REMARK
                    bindingRow.WARE_CODE = wareRow.WARE_CODE
                    bindingRow.CUSTOM_CODE = wareRow.CUSTOM_CODE
                    bindingRow.UNIT_COST = Facade.OpBizMaster.GetPosWareCost(wareRow.WARE_ID, posRow.POS_ID)
                    bindingRow.UNIT_PRICE = Facade.OpBizMaster.GetPosWarePrice(wareRow.WARE_ID, posRow.POS_ID, origionPrice)
                    bindingRow.INVENTORY_AMOUNT = turnoverDtlRow.WARE_AMOUNT
                End If
            Else
                bindingRow.INVENTORY_AMOUNT += turnoverDtlRow.WARE_AMOUNT
            End If

        Next




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


    Public Function ServLoadInfo( _
        ByVal valInventoryID As String, _
        ByRef refInventoryRowSE As MyPosXAuto.FTs.FT_XV_T_MP_INVENTORYRowSEntity, _
        ByRef refInventoryDraftList As MyPosXAuto.FTs.FT_XV_T_MP_INVENTORY_DRAFT) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        Dim inventoryConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_INVENTORY(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        inventoryConditions.Add(MyPosXAuto.Facade.AfXV.XV_T_MP_INVENTORYColumns.INVENTORY_IDColumn, "=", valInventoryID)

        MyPosXAuto.Facade.AfXV.FillXV_T_MP_INVENTORYRowSEntity(refInventoryRowSE, inventoryConditions)

        Dim draftConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_INVENTORY_DRAFT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        draftConditions.Add(MyPosXAuto.Facade.AfXV.XV_T_MP_INVENTORY_DRAFTColumns.INVENTORY_IDColumn, "=", valInventoryID)

        MyPosXAuto.Facade.AfXV.FillFT_XV_T_MP_INVENTORY_DRAFT(draftConditions, refInventoryDraftList)

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

