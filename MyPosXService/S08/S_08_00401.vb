Imports XL.Common
Imports XL.Common.Utils
Imports System.Collections



Public Class S_08_00401
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_08_00401

        Dim result As S_08_00401
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_08_00401), _
                                String.Format("tcp://{0}/S_08_00401.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_08_00401)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_08_00401
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



    Public Function ServUtld0001( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

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


    Public Function ServImportSolution( _
        ByVal valHeadPosRowSEntity As MyPosXAuto.FTs.FT_XV_M_MP_POSRowSEntity, _
        ByVal valPosRowSEntity As MyPosXAuto.FTs.FT_XV_M_MP_POSRowSEntity, _
        ByVal valPriceSetRowSEntity As MyPosXAuto.FTs.FT_S_MP_POS_SETRowSEntity, _
        ByVal valWareClassifyList As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFY, _
        ByVal valPriceSetList As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARE _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim wareClassifyCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE_CLASSIFY(XL.DB.Utils.Condition.LogicOperators.Logic_And)

        wareClassifyCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WARE_CLASSIFYColumns.PARENT_IDColumn, "<=", 0)

        Dim classifyRows = valWareClassifyList.FindRowsByCondition(wareClassifyCondition)
        Dim involvedClassifyCodes As New ArrayList
        Facade.OpBizMaster.ImportClassifyList( _
            String.Empty, _
            valWareClassifyList, _
            classifyRows, _
            involvedClassifyCodes)

        Dim dbWareClassifyList As New MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFY
        MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_WARE_CLASSIFY(Nothing, dbWareClassifyList)

        For Each dbWareClassifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow In dbWareClassifyList
            If involvedClassifyCodes.Contains(dbWareClassifyRow.WARE_CLASSIFY_CODE) = False Then
                MyPosXAuto.Facade.AfBizMaster.DeleteM_MP_WARE_CLASSIFYInfo(dbWareClassifyRow.WARE_CLASSIFY_ID)
            End If
        Next




        Dim solutionCondition As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_POS_SET(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        solutionCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SETColumns.SET_CODEColumn, "=", valPriceSetRowSEntity.SET_CODE)
        Dim solutionRow As MyPosXAuto.FTs.FT_S_MP_POS_SETRow = MyPosXAuto.Facade.AfBizConfig.GetS_MP_POS_SETRow(solutionCondition)

        Dim toSolutionID As String = Guid.NewGuid.ToString
        If IsNothing(solutionRow) = True Then
            MyPosXAuto.Facade.AfBizConfig.CreateS_MP_POS_SETInfo( _
                 valPriceSetRowSEntity.POS_TYPE, _
                 valPriceSetRowSEntity.PRICE_SCALE, _
                 valPriceSetRowSEntity.REMARK, _
                 valPriceSetRowSEntity.RETAIL_OPERATOR_SALES_SHARE, _
                 valPriceSetRowSEntity.SET_CODE, _
                 toSolutionID, _
                 valPriceSetRowSEntity.STAFF_SHARE_RATE)
        Else
            toSolutionID = solutionRow.SET_ID
            MyPosXAuto.Facade.AfBizConfig.ReviseS_MP_POS_SETInfo( _
                 toSolutionID, _
                 valPriceSetRowSEntity.POS_TYPE, _
                 valPriceSetRowSEntity.PRICE_SCALE, _
                 valPriceSetRowSEntity.REMARK, _
                 valPriceSetRowSEntity.RETAIL_OPERATOR_SALES_SHARE, _
                 valPriceSetRowSEntity.SET_CODE, _
                 valPriceSetRowSEntity.STAFF_SHARE_RATE)
        End If


        Dim wareConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow
        Dim wareID As String

        Dim wareClassifyConditions As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE_CLASSIFY(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim wareClassifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow
        Dim reviseSolutionDtlRow As MyPosXAuto.FTs.FT_S_MP_POS_SET_WARERow
        Dim detailID As String = String.Empty
        Dim involvedDetailIDs As New ArrayList

        Dim solutionDtlConditions As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_POS_SET_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)

        For Each solutionDtlRow As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERow In valPriceSetList

            wareConditions.Clear()
            wareConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", solutionDtlRow.WARE_CODE)
            wareRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareConditions)

            If IsNothing(wareRow) = True Then

                wareClassifyConditions.Clear()
                wareClassifyConditions.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WARE_CLASSIFYColumns.WARE_CLASSIFY_CODEColumn, "=", solutionDtlRow.WARE_CLASSIFY_CODE)
                wareClassifyRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARE_CLASSIFYRow(wareClassifyConditions)

                If IsNothing(wareClassifyRow) = False Then

                    wareID = Guid.NewGuid.ToString

                    MyPosXAuto.Facade.AfBizMaster.CreateM_MP_WAREInfo( _
                        solutionDtlRow.ATTRIBUTE1, _
                        solutionDtlRow.ATTRIBUTE2, _
                        solutionDtlRow.ATTRIBUTE3, _
                        solutionDtlRow.ATTRIBUTE4, _
                        solutionDtlRow.CUSTOM_CODE, _
                        solutionDtlRow.GUARANTEE_DAYS, _
                        False, _
                        0, _
                        solutionDtlRow.MODEL, _
                        solutionDtlRow.MODEL_EN, _
                        solutionDtlRow.PRACT_CODE_REQUIRED, _
                        solutionDtlRow.REMARK, _
                        solutionDtlRow.SPEC, _
                        solutionDtlRow.SPEC_EN, _
                        solutionDtlRow.SUPPLIER_ID, _
                        solutionDtlRow.UNIT_COST, _
                        solutionDtlRow.UNIT_NAME, _
                        solutionDtlRow.UNIT_PRICE, _
                        wareClassifyRow.WARE_CLASSIFY_ID, _
                        solutionDtlRow.WARE_CODE, _
                        wareID, _
                        Nothing, _
                        solutionDtlRow.WARE_NAME, _
                        solutionDtlRow.WARE_NAME_EN)
                End If


            Else
                wareID = wareRow.WARE_ID
            End If


            If wareID.Length > 0 Then

                solutionDtlConditions.Clear()
                solutionDtlConditions.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", toSolutionID)
                solutionDtlConditions.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SET_WAREColumns.WARE_IDColumn, "=", wareID)
                reviseSolutionDtlRow = MyPosXAuto.Facade.AfBizConfig.GetS_MP_POS_SET_WARERow(solutionDtlConditions)

                If IsNothing(reviseSolutionDtlRow) = True Then

                    detailID = Guid.NewGuid.ToString

                    MyPosXAuto.Facade.AfBizConfig.CreateS_MP_POS_SET_WAREInfo( _
                        detailID, _
                        solutionDtlRow.INDIVIDUAL_DISCOUNT, _
                        solutionDtlRow.LOWER_LIMIT, _
                        toSolutionID, _
                        solutionDtlRow.UNIT_COST, _
                        solutionDtlRow.UNIT_PRICE, _
                         wareID)

                Else
                    MyPosXAuto.Facade.AfBizConfig.ReviseS_MP_POS_SET_WAREInfo( _
                        reviseSolutionDtlRow.DETAIL_ID, _
                        solutionDtlRow.INDIVIDUAL_DISCOUNT, _
                        solutionDtlRow.LOWER_LIMIT, _
                        toSolutionID, _
                        solutionDtlRow.UNIT_COST, _
                        solutionDtlRow.UNIT_PRICE, _
                        wareID)

                    detailID = reviseSolutionDtlRow.DETAIL_ID

                End If

                involvedDetailIDs.Add(detailID)

            End If
        Next

        Dim deleteDtlList As New MyPosXAuto.FTs.FT_S_MP_POS_SET_WARE
        Dim deleteDtlRow As MyPosXAuto.FTs.FT_S_MP_POS_SET_WARERow

        solutionDtlConditions.Clear()
        solutionDtlConditions.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", toSolutionID)
        MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_POS_SET_WARE(solutionDtlConditions, deleteDtlList)

        For Each deleteDtlRow In deleteDtlList

            If involvedDetailIDs.Contains(deleteDtlRow.DETAIL_ID) = False Then

                MyPosXAuto.Facade.AfBizConfig.DeleteS_MP_POS_SET_WAREInfo(deleteDtlRow.DETAIL_ID)
            End If

        Next



        Dim posCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_POS(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        posCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_POSColumns.POS_CODEColumn, "=", valPosRowSEntity.POS_CODE)
        Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(posCondition)
        Dim posID As String

        If IsNothing(posRow) = True Then

            posID = Guid.NewGuid.ToString

            MyPosXAuto.Facade.AfBizMaster.CreateM_MP_POSInfo( _
                posID, _
                valHeadPosRowSEntity.POS_CODE, _
                valPosRowSEntity.EMAIL, _
                valPosRowSEntity.POS_ADDRESS, _
                valPosRowSEntity.POS_CODE, _
                valPosRowSEntity.POS_NAME, _
                toSolutionID)
        Else
            posID = posRow.POS_ID
            MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_POSInfo( _
                valPosRowSEntity.POS_ID, _
                valHeadPosRowSEntity.POS_CODE, _
                valPosRowSEntity.EMAIL, _
                valPosRowSEntity.POS_ADDRESS, _
                valPosRowSEntity.POS_CODE, _
                valPosRowSEntity.POS_NAME, _
                toSolutionID)
        End If

        Return String.Empty

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
