Public Class frmFlagContentClass

    '
    'Author quexd 
    'Create date 2003-4-10
    '

    Private StrProjectCode As String
    Private StrCorporationName As String
    Private StrCorporationCode As String
    Private StrPhase As String
    Private StrSpace As String = "          " ' 制作文档是替换没有内容的变量

    '构造函数
    'Public Sub New()
    'End Sub
    Public Sub New(ByVal projectCode As String, ByVal corporationName As String, ByVal corporationCode As String, ByVal phase As String)
        Me.strProjectCode = projectCode
        Me.strCorporationName = corporationName
        Me.strCorporationCode = corporationCode
        Me.strPhase = phase
    End Sub
    '
    '查找vbCrLf,并以”回车符“替换之
    '
    Public Shared Function replaceExt(ByVal strContent As String, ByVal flag As String)
        'Chr(10) 代表换行符
        'Chr(13) 代表回车符
        Try
            flag = Chr(13).ToString
            strContent = Replace(strContent, Chr(10), flag)
            If InStr(strContent, Chr(10)) <> 0 Then
                replaceExt(strContent, flag)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return strContent
    End Function
    '
    '评审报告替换标记
    '有55个标记
    '根据业务品种不同,获取不同的替换标记
    '参数:由item_type + item_code 组成
    '
    Public Function getReviewDocFlag(ByVal cmbTypeText As String)

        If cmbTypeText = "45002" Then '流动资金贷款担保,添加评审报告简介
            Dim docFlag As String() = {"&#DateTime", "&#ADateTime", _
                    "&#ABCorporation_Name", "&#Attend_person", "&#AAttend_person1", _
                    "&#Bttend_person", "&#BAttend_person1", _
                    "&#Corporation_Name", "&#Business_Licence_Code", "&#Business_Start_Date", _
                    "&#Business_End_Date", "&#Distric_Name", "&#Register_Adress", _
                    "&#Register_Capital", "&#MoneyName", "&#Real_Capital", "&#Cash_Receive", _
                    "&#Invisible_Asset", "&#Legal_Representative", "&#Nationality", _
                    "&#ID_Card", "&#Loan_Card_ID", "&#Corp_Paper_ID", _
                    "&#Credit_Grad", "&#Evaluate_Institution", "&#Proprietorship_Type", _
                    "&#Technology_Type", "&#Employee_Amount", "&#College", _
                    "&#Bachelor", "&#Master", "&#Doctor", _
                    "&#Business_Scope", "&#Leading_Product" _
                    , _
                    "&#BfCorpName", "&#BfFoundDate", "&#BfAddress", _
                    "&BfCapital", "&#BfSalesSum", "&#BfGainSum", _
                    "&#BfProuduct", "&#BfTechnologyType", _
                    "&#BfApplySum", "&#BfApplyTerms", "&#BfApplyPurpose", _
                    "&#BfOpinionMA", "&#BfOpinionMB" _
                     , _
                    "&#Quantity_Score", "&#Quality_Score", "&#Total_Score", _
                    "&#AQuantity_Score", "&#AQuality_Score", "&#ATotal_Score" _
                     , _
                    "&#BeforeLastYear", "&#Lastyear", "&#Year", "&#Month", "&#BLSale", _
                    "&#BLProfit", "&#LSale", "&#LProfit", "&#YSale", "&#YProfit" _
                     , _
                     "&#APersonAsurer" _
                     , _
                    "&#ACorporation_Name1", "&#ABusiness_Licence_Code1", "&#ABusiness_Start_Date1", _
                    "&#ABusiness_End_Date", "&#ADistric_Name1", "&#ARegister_Adress1", _
                    "&#ARegister_Capital1", "&#AReal_Capital1", "&#ACash_Receive1", _
                    "&#AInvisible_Asset", "&#ALegal_Representative1", "&#ANationality1", _
                    "&#AID_Card1", "&#ALoan_Card_ID1", "&#ACorp_Paper_ID1", _
                    "&#ACredit_Grad1", "&#AProprietorship_Type1", "&#ATechnology_Type1", _
                    "&#ARelation" _
                    , _
                    "&#managerA_opinion", "&#managerB_opinion", "&#defectRecord" _
                     }
            Return docFlag
        End If

        If cmbTypeText = "45102" Then '保函,除一般的信息外,还有保函的的8个特有信息
            Dim docFlag As String() = {"&#DateTime", "&#ADateTime", _
                                 "&#ABCorporation_Name", "&#Attend_person", "&#AAttend_person1", _
                                 "&#Bttend_person", "&#BAttend_person1", _
                                 "&#Corporation_Name", "&#Business_Licence_Code", "&#Business_Start_Date", _
                                 "&#Business_End_Date", "&#Distric_Name", "&#Register_Adress", _
                                 "&#Register_Capital", "&#MoneyName", "&#Real_Capital", "&#Cash_Receive", _
                                 "&#Invisible_Asset", "&#Legal_Representative", "&#Nationality", _
                                 "&#ID_Card", "&#Loan_Card_ID", "&#Corp_Paper_ID", _
                                 "&#Credit_Grad", "&#Evaluate_Institution", "&#Proprietorship_Type", _
                                 "&#Technology_Type", "&#Employee_Amount", "&#College", _
                                 "&#Bachelor", "&#Master", "&#Doctor", _
                                 "&#Business_Scope", "&#Leading_Product" _
                                 , _
                                 "&#BfCorpName", "&#BfFoundDate", "&#BfAddress", _
                                 "&BfCapital", "&#BfSalesSum", "&#BfGainSum", _
                                 "&#BfProuduct", "&#BfTechnologyType", _
                                 "&#BfApplySum", "&#BfApplyTerms", "&#BfApplyPurpose", _
                                 "&#BfOpinionMA", "&#BfOpinionMB" _
                                 , _
                                 "&#AQuantity_Score", "&#AQuality_Score", "&#ATotal_Score" _
                                 , _
                                 "&#BeforeLastYear", "&#Lastyear", "&#Year", "&#Month", "&#BLSale", _
                                 "&#BLProfit", "&#LSale", "&#LProfit", "&#YSale", "&#YProfit" _
                                 , _
                                 "&#bh_purpose", "&#bh_project_name", "&#bh_project_content", _
                                 "&#bh_beneficiary_introduction", "&#bh_guarantee_letter_type", "&#bh_apply_sum", _
                                 "&#bh_apply_term", "&#bh_counterclaim_condition" _
                                  , _
                                 "&#APersonAsurer" _
                                 , _
                                 "&#ACorporation_Name1", "&#ABusiness_Licence_Code1", "&#ABusiness_Start_Date1", _
                                 "&#ABusiness_End_Date", "&#ADistric_Name1", "&#ARegister_Adress1", _
                                 "&#ARegister_Capital1", "&#AReal_Capital1", "&#ACash_Receive1", _
                                 "&#AInvisible_Asset", "&#ALegal_Representative1", "&#ANationality1", _
                                 "&#AID_Card1", "&#ALoan_Card_ID1", "&#ACorp_Paper_ID1", _
                                 "&#ACredit_Grad1", "&#AProprietorship_Type1", "&#ATechnology_Type1", _
                                 "&#ARelation" _
                                 , _
                                 "&#managerA_opinion", "&#managerB_opinion" _
                                  }
            Return docFlag
        End If

        If cmbTypeText = "45202" Then '小额委托评审报告
            Dim docFlag As String() = {"&#DateTime", "&#ADateTime", _
                    "&#ABCorporation_Name", "&#Attend_person", "&#AAttend_person1", _
                    "&#Bttend_person", "&#BAttend_person1", _
                    "&#Corporation_Name", "&#Business_Licence_Code", "&#Business_Start_Date", _
                    "&#Business_End_Date", "&#Distric_Name", "&#Register_Adress", _
                    "&#Register_Capital", "&#MoneyName", "&#Real_Capital", "&#Cash_Receive", _
                    "&#Invisible_Asset", "&#Legal_Representative", "&#Nationality", _
                    "&#ID_Card", "&#Loan_Card_ID", "&#Corp_Paper_ID", _
                    "&#Credit_Grad", "&#Evaluate_Institution", "&#Proprietorship_Type", _
                    "&#Technology_Type", "&#Employee_Amount", "&#College", _
                    "&#Bachelor", "&#Master", "&#Doctor", _
                    "&#Business_Scope", "&#Leading_Product" _
                    , _
                    "&#BfCorpName", "&#BfFoundDate", "&#BfAddress", _
                    "&BfCapital", "&#BfSalesSum", "&#BfGainSum", _
                    "&#BfProuduct", "&#BfTechnologyType", _
                    "&#BfApplySum", "&#BfApplyTerms", "&#BfApplyPurpose", _
                    "&#BfOpinionMA", "&#BfOpinionMB" _
                     , _
                    "&#Quantity_Score", "&#Quality_Score", "&#Total_Score", _
                    "&#AQuantity_Score", "&#AQuality_Score", "&#ATotal_Score" _
                     , _
                    "&#BeforeLastYear", "&#Lastyear", "&#Year", "&#Month", "&#BLSale", _
                    "&#BLProfit", "&#LSale", "&#LProfit", "&#YSale", "&#YProfit" _
                     , _
                    "&#ACorporation_Name1", "&#ABusiness_Licence_Code1", "&#ABusiness_Start_Date1", _
                    "&#ABusiness_End_Date", "&#ADistric_Name1", "&#ARegister_Adress1", _
                    "&#ARegister_Capital1", "&#AReal_Capital1", "&#ACash_Receive1", _
                    "&#AInvisible_Asset", "&#ALegal_Representative1", "&#ANationality1", _
                    "&#AID_Card1", "&#ALoan_Card_ID1", "&#ACorp_Paper_ID1", _
                    "&#ACredit_Grad1", "&#AProprietorship_Type1", "&#ATechnology_Type1", _
                    "&#ARelation" _
                    , _
                    "&#managerA_opinion", "&#managerB_opinion" _
                     }
            Return docFlag
        End If
    End Function
    '
    '初审报告替换标记
    '有51个标记
    '
    Public Function getFirstInstanceDocFlag()
        Dim docFlag As String() = {"&#DateTime", "&#ReviewPerson", "&#Minister", _
                "&#ACorporation_Name", "&#Corporation_Name", "&#Found_date", _
                "&#Register_Address", "&#Business_licence_code", "#Corp_Paper_id", _
                "&#loan_paper_id", "&#loan_card_id", "&#credit_grade", _
                "&#is_first_loan", "&#technology_type", "&#legal_representative", _
                "&#nationality", "&#Aattorney", "&#attorney_nationality ", _
                "&#contact_phone", "&#Fax ", "&#proprietorship_type", _
                "&#register_capital", "&#MoneyName", "&#real_capital", "&#cash_receive", _
                "&#employee_amount", "&#college", "&#bachelor", _
                "&#master", "&#docter", "&#business_scope", _
                "&#leading_product ", "&#technology_level" _
                 , _
                "&#BeforeLastYear", "&#Lastyear", "&#Year", "&#Month", "&#BLSale", _
                "&#BLProfit", "&#LSale", "&#LProfit", "&#YSale", "&#YProfit" _
                , _
                "&#market_status", "&#apply_sum", _
                "&#apply_term", "&#apply_bank", "&#purpose", "&#conclusion", _
                "&#content", "&#FirstTrialOpinion" _
                }
        Return docFlag
    End Function
    '
    '项目终止报告替换标记
    '12个标记
    '阙兴登 修改时间：2003－9－27 9：30
    '
    Public Function getTerminateReportDocFlag()
        Dim docFlag As String() = { _
                    "&#CorporationName", "&#ProjectCode", "&#Opposite_guarantee", _
                    "&#GuaranteeValue", "&#GuaranteeStartDate", "&#GuaranteeEndDate", _
                    "&#RefundDate", "&#Terminate_type", "&#Terminate_date", _
                    "&#Appraisement", "&#is_continue_support", _
                    "&#is_high_risk" _
                    }
        Return docFlag
    End Function
    '
    '反担保物评估作价意见书
    '6个标记
    '
    Public Function getEvaluateReportDocFlag()
        Dim docFlag As String() = { _
                    "&#A_ApplyCompany", "&#B_ApplyCompany", "&#C_ApplyCompany", _
                    "&#A_evaluate_person", _
                    "&#B_evaluate_person", _
                    "&#C_evaluate_person" _
                    }
        Return docFlag
    End Function
    '
    '反担保物评估作价意见书
    '
    Public Function getEvaluateReplace()
        Dim replaceList As New ArrayList()
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{project_code='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "'}"
        If Not gWs Is Nothing Then
            Try
                'ds = gWs.FetchProjectCorporation(strSql)
                ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "1", StrPhase)
                i = ds.Tables("TProjectCorporation").Rows.Count
                If i > 0 Then
                    dr = ds.Tables("TProjectCorporation").Rows(0)
                    With dr
                        '企业名称
                        If Not .Item("corporation_name") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corporation_name"))
                            replaceList.Add(.Item("corporation_name"))
                            replaceList.Add(.Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                strSql = "{project_code='" & StrProjectCode & "' and (guaranty_type='21' or guaranty_type='22' or guaranty_type='23')}"
                ds = gWs.GetGuarantyInfo(strSql, "null")
                i = ds.Tables("opposite_guarantee").Rows.Count
                If i > 0 Then
                    dr = ds.Tables("opposite_guarantee").Rows(0)
                    With dr
                        '资产评估人
                        If Not .Item("evaluate_person") Is System.DBNull.Value Then
                            replaceList.Add(.Item("evaluate_person"))
                            replaceList.Add(.Item("evaluate_person"))
                            replaceList.Add(.Item("evaluate_person"))
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
            Catch
            Finally
            End Try
        End If
        Return replaceList
    End Function
    '
    '初审报告
    '
    Public Function getFirstInstanceReplace()
        Dim replaceList As New ArrayList()
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim dsCorp As DataSet
        dsCorp = gWs.GetCommonQueryInfo("Select found_date from corporation where corporation_code='" & strCorporationCode & "'")
        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{project_code='" & StrProjectCode & "' and corporation_code='" & strCorporationCode & "' and phase='" & StrPhase & "' }"
        If Not gWs Is Nothing Then
            Try
                'ds = gWs.FetchProjectCorporation(strSql)
                ds = gWs.FetchProjectCorporation(StrProjectCode, strCorporationCode, "1", StrPhase)
                i = ds.Tables("TProjectCorporation").Rows.Count
                If i = 0 Then
                    Dim j As Integer
                    For j = 0 To 51 - 1
                        replaceList.Add(StrSpace)
                    Next
                End If
                If i > 0 Then
                    dr = ds.Tables("TProjectCorporation").Rows(0)
                    '日期
                    Try
                        replaceList.Add(gWs.GetSysTime().ToString("yyyy年MM月dd日"))
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    '经办人
                    replaceList.Add(UserName)
                    '签发人,12(资评部长)
                    replaceList.Add("")
                    'Dim dsMinister As DataSet = gWs.GetProjectInfoEx("{projectcode='" & strProjectCode & "'}")
                    'Dim strMinister As String = ""
                    'If Not dsMinister Is Nothing Then
                    '    If dsMinister.Tables(0).Rows.Count > 0 Then
                    '        strMinister = dsMinister.Tables(0).Rows(0).Item("12")
                    '        replaceList.Add(strMinister)
                    '    Else
                    '        replaceList.Add(strMinister)
                    '    End If
                    'Else
                    '    replaceList.Add(strMinister)
                    'End If
                    With dr
                        '企业名称
                        If Not .Item("corporation_name") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '企业名称(全称)_A
                        If Not .Item("corporation_name") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '成立时间
                        If Not dsCorp.Tables(0).Rows(0).Item("found_date") Is System.DBNull.Value Then
                            replaceList.Add(CType(dsCorp.Tables(0).Rows(0).Item("found_date"), Date).ToString("yyyy年MM月dd日"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '详细地址
                        'qxd add 2003-11-3
                        Dim strRegister As String = ""
                        If Not .Item("district_name") Is System.DBNull.Value Then
                            strRegister = .Item("district_name")
                        End If
                        ' qxd end
                        If Not .Item("register_address") Is System.DBNull.Value Then
                            'replaceList.Add(.Item("register_address"))
                            replaceList.Add(strRegister & .Item("register_address"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '营业执照号码
                        If Not .Item("business_licence_code") Is System.DBNull.Value Then
                            replaceList.Add(.Item("business_licence_code"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '法人代码证号码
                        If Not .Item("corp_paper_id") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corp_paper_id"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '贷款证号码
                        If Not .Item("loan_paper_id") Is System.DBNull.Value Then
                            replaceList.Add(.Item("loan_paper_id"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '贷款卡号码
                        If Not .Item("loan_card_id") Is System.DBNull.Value Then
                            replaceList.Add(.Item("loan_card_id"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '企业资信等级
                        If Not .Item("credit_grade") Is System.DBNull.Value Then
                            replaceList.Add(.Item("credit_grade"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '**********************请确定!!!************************
                        '是否第一次贷款
                        '从表consultation表取出数据
                        Dim dsConsultation As DataSet
                        Dim drConsultation As DataRow
                        Dim str As String
                        Dim strCorporationCode As String
                        strCorporationCode = .Item("corporation_code")
                        str = "{corporation_code='" & strCorporationCode & "' order by serial_num DESC}" '按serial_num 降序
                        dsConsultation = gWs.GetcorporationInfo("null", str)
                        If dsConsultation.Tables("consultation").Rows.Count > 0 Then
                            drConsultation = dsConsultation.Tables("consultation").Rows(0)
                            If Not drConsultation.Item("is_first_loan") Is System.DBNull.Value Then
                                If drConsultation.Item("is_first_loan") = "1" Then
                                    replaceList.Add("是")
                                Else
                                    replaceList.Add("否")
                                End If
                            Else
                                replaceList.Add(StrSpace)
                            End If
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '技术创新情况
                        If Not .Item("technology_type") Is System.DBNull.Value Then
                            replaceList.Add(getTechnologyType(.Item("technology_type")))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '法定代表人
                        If Not .Item("legal_representative") Is System.DBNull.Value Then
                            replaceList.Add(.Item("legal_representative"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '国籍
                        If Not .Item("nationality") Is System.DBNull.Value Then
                            replaceList.Add(.Item("nationality"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '授权代理或联系人(contact_person)
                        If Not .Item("contact_person") Is System.DBNull.Value Then
                            replaceList.Add(.Item("contact_person"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '国籍(授权代理或联系人)
                        If Not .Item("attorney_nationality") Is System.DBNull.Value Then
                            replaceList.Add(.Item("attorney_nationality"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '联系电话
                        If Not .Item("contact_phone") Is System.DBNull.Value Then
                            replaceList.Add(.Item("contact_phone"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '传真
                        If Not .Item("fax") Is System.DBNull.Value Then
                            replaceList.Add(.Item("fax"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '公司类别
                        If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                            replaceList.Add(.Item("proprietorship_type"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '注册资本
                        If Not .Item("register_capital") Is System.DBNull.Value Then
                            replaceList.Add(.Item("register_capital"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '注册资本的货币单位
                        If Not .Item("MoneyID") Is System.DBNull.Value Then
                            replaceList.Add(getMoneyName(.Item("MoneyID")))
                        Else
                            replaceList.Add("人民币")
                        End If
                        '实收资本
                        If Not .Item("real_capital") Is System.DBNull.Value Then
                            replaceList.Add(.Item("real_capital"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '其中现金到位
                        If Not .Item("cash_receive") Is System.DBNull.Value Then
                            replaceList.Add(.Item("cash_receive"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '员工总数
                        If Not .Item("employee_amount") Is System.DBNull.Value Then
                            replaceList.Add(.Item("employee_amount"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '大专
                        If Not .Item("college") Is System.DBNull.Value Then
                            replaceList.Add(.Item("college"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '本科
                        If Not .Item("bachelor") Is System.DBNull.Value Then
                            replaceList.Add(.Item("bachelor"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '硕士
                        If Not .Item("master") Is System.DBNull.Value Then
                            replaceList.Add(.Item("master"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '博士
                        If Not .Item("docter") Is System.DBNull.Value Then
                            replaceList.Add(.Item("docter"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '经营范围
                        If Not .Item("business_scope") Is System.DBNull.Value Then
                            replaceList.Add(replaceExt(.Item("business_scope"), ""))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '主营业务
                        If Not .Item("leading_product") Is System.DBNull.Value Then
                            replaceList.Add(replaceExt(.Item("leading_product"), ""))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '技术水平
                        If Not .Item("technology_level") Is System.DBNull.Value Then
                            replaceList.Add(.Item("technology_level"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '-------------------------
                        '---------销售额及利润总额----------2003-12-17 add
                        Dim strApplyDate As String
                        Dim strSQLIndex, strSystemID, strSQLSystem As String
                        Dim strMonth, strYear, strLastYear, strBeforeLastYear, strBBLastYear As String
                        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double

                        strApplyDate = GetApplyDate(StrProjectCode)

                        strYear = CType(strApplyDate, Date).Year '今年
                        strMonth = CType(strApplyDate, Date).Month '今年的月份

                        dYear = CType(strYear, Double)

                        lastYear = dYear - 1 '去年
                        strLastYear = lastYear.ToString

                        beforeLastYear = dYear - 2 '前年
                        strBeforeLastYear = beforeLastYear.ToString

                        replaceList.Add(strBeforeLastYear) '前年
                        replaceList.Add(strLastYear) '去年
                        replaceList.Add(strYear) '今年
                        replaceList.Add(strMonth) '今年的月份

                        'strSql = "{project_code='" & strProjectCode & "' and corporation_code='" & strCorporationCode & "' and phase='" & strPhase & "' }"
                        strSql = "{project_code='" & StrProjectCode & "' and phase='" & StrPhase & "' and corporation_code='" & strCorporationCode & _
                            "' and (month like '" & strYear & "%' or month like '" & strLastYear & _
                                "%' or month like '" & strBeforeLastYear & "%' or month like '" & strBBLastYear & "%') " & _
                                " and ((item_type='02' and item_code='b01') or (item_type='02' and item_code='b14'))}"

                        ds = gWs.FetchCorporationAccount(strSql)

                        If Not ds Is Nothing Then

                            Dim strValue As String
                            Dim strSort As String = "item_code asc"
                            Dim drTemp As DataRow

                            '上前年
                            strSql = "month like '" & strBeforeLastYear & "%' "
                            If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                                If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                                If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                            Else
                                replaceList.Add(StrSpace)
                                replaceList.Add(StrSpace)
                            End If
                            '去年
                            strSql = "month like '" & strLastYear & "%' "
                            If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                                If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                                If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                            Else
                                replaceList.Add(StrSpace)
                                replaceList.Add(StrSpace)
                            End If
                            '今年
                            strSql = "month like '" & strYear & "%' "
                            If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                                If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                                If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                            Else
                                replaceList.Add(StrSpace)
                                replaceList.Add(StrSpace)
                            End If
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                        '-----------------------------------
                        '市场情况
                        If Not .Item("market_status") Is System.DBNull.Value Then
                            replaceList.Add(replaceExt(.Item("market_status"), ""))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '******************************************************
                        Dim dsProject As DataSet
                        Dim drProject As DataRow
                        strSql = "{project_code='" & StrProjectCode & "'}"
                        dsProject = gWs.GetProjectInfo(strSql)
                        If dsProject.Tables(0).Rows.Count > 0 Then
                            drProject = dsProject.Tables(0).Rows(0)
                            '本次申请担保金额
                            If Not drProject.Item("apply_sum") Is System.DBNull.Value Then
                                replaceList.Add(drProject.Item("apply_sum"))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                            '期限
                            If Not drProject.Item("apply_term") Is System.DBNull.Value Then
                                replaceList.Add(drProject.Item("apply_term"))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                            '本次申请贷款银行
                            If Not drProject.Item("apply_bank") Is System.DBNull.Value Then
                                replaceList.Add(getBankName(drProject.Item("apply_bank")))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                            '本次申请贷款用途及还款来源
                            If Not drProject.Item("purpose") Is System.DBNull.Value Then
                                replaceList.Add(replaceExt(drProject.Item("purpose"), ""))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                        '**************从表:project_opinion中读取数据
                        '初审人员意见
                        '通过project_code ,item_type,item_code查找:51,002表示初审意见
                        Dim dsOpinion As DataSet
                        Dim drOpinion As DataRow
                        strSql = "{project_code='" & StrProjectCode & "' and item_type='51' and item_code='002'}"
                        dsOpinion = gWs.GetProjectOpinionByProjectNo(strSql)
                        If dsOpinion.Tables(0).Rows.Count > 0 Then
                            drOpinion = dsOpinion.Tables(0).Rows(0)
                            If Not drOpinion.Item("conclusion") Is System.DBNull.Value Then
                                replaceList.Add(replaceExt(drOpinion.Item("conclusion"), ""))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                            '理由
                            If Not drOpinion.Item("content") Is System.DBNull.Value Then
                                replaceList.Add(replaceExt(drOpinion.Item("content"), ""))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                        '初审审核意见
                        strSql = "{project_code='" & StrProjectCode & "' and item_type='51' and item_code='003'}"
                        dsOpinion = gWs.GetProjectOpinionByProjectNo(strSql)
                        If dsOpinion.Tables(0).Rows.Count > 0 Then
                            drOpinion = dsOpinion.Tables(0).Rows(0)
                            If Not drOpinion.Item("content") Is System.DBNull.Value Then
                                replaceList.Add(replaceExt(drOpinion.Item("content"), ""))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                End If
            Catch ex As Exception
            End Try
        End If
        Return replaceList
    End Function
    '
    '评审报告
    '
    '从数据库表:projectCorporation,获取数据
    'corporation_type='1'表示申请企业
    '
    Public Function getReviewReplace(ByVal cmbTypeText As String)

        Dim replaceList As New ArrayList()

        If cmbTypeText = "45002" Then '流动资金贷款担保
            Try
                Me.SetReviewProjectCorporation(replaceList) '33个企业替换标志
                Me.SetReviewBreif(replaceList) '13个评审报告简介替换标志
                Me.SetReviewAppraise(replaceList, cmbTypeText) '6个资信信息替换标志(保函为3个)
                Me.SetReviewCorporationAccout(replaceList) '10个利润总额替换标志
                'Me.SetReviewProject(replaceList, cmbTypeText) '8个保函替换标志
                Me.SetReviewAssurer(replaceList) '1个个人资产清单
                Me.SetReviewProjectCorporation2(replaceList) '19个担保企业替换标志
                Me.SetReviewManagerOpinion(replaceList) '项目经理AB角意见
                Me.SetDefectRecord(replaceList) '失信记录
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If

        If cmbTypeText = "45102" Then '保函业务品种
            Try
                Me.SetReviewProjectCorporation(replaceList) '33个企业替换标志
                Me.SetReviewBreif(replaceList) '13个评审报告简介替换标志
                Me.SetReviewAppraise(replaceList, cmbTypeText) '6个资信信息替换标志(保函为3个)
                Me.SetReviewCorporationAccout(replaceList) '10个利润总额替换标志
                Me.SetReviewProject(replaceList, cmbTypeText) '8个保函替换标志
                Me.SetReviewAssurer(replaceList) '1个个人资产清单
                Me.SetReviewProjectCorporation2(replaceList) '19个担保企业替换标志
                Me.SetReviewManagerOpinion(replaceList) '项目经理AB角意见
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If

        If cmbTypeText = "45202" Then '小额委托评审
            Try
                Me.SetReviewProjectCorporation(replaceList) '33个企业替换标志
                Me.SetReviewBreif(replaceList) '13个评审报告简介替换标志
                Me.SetReviewAppraise(replaceList, cmbTypeText) '6个资信信息替换标志(保函为3个)
                Me.SetReviewCorporationAccout(replaceList) '10个利润总额替换标志
                'Me.SetReviewProject(replaceList, cmbTypeText) '8个保函替换标志
                'Me.SetReviewAssurer(replaceList) '1个个人资产清单
                Me.SetReviewProjectCorporation2(replaceList) '19个担保企业替换标志
                Me.SetReviewManagerOpinion(replaceList) '项目经理AB角意见
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If


        Return replaceList
    End Function

    '
    '项目终止报告
    '
    Public Function getTerminateReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                'projectCorporation表
                strSql = "{project_code='" & StrProjectCode & "' and corporation_type='1' }"
                strSql = "{project_code='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "'}"
                'ds = gWs.FetchProjectCorporation(strSql)
                ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "1", StrPhase)
                i = ds.Tables("TProjectCorporation").Rows.Count
                If i > 0 Then
                    dr = ds.Tables("TProjectCorporation").Rows(0)
                    With dr
                        '企业名称
                        If Not .Item("corporation_name") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '编号
                        replaceList.Add(StrProjectCode)
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                'opposite_guarantee_form
                '反担保措施
                'qxd modify 2003-11-4
                'strSql = "{project_code='" & strProjectCode & "' }"
                strSql = "{project_code='" & StrProjectCode & "' and is_used='1'}"
                'ds = gWs.GetGuarantyInfo(strSql, "null")
                ds = gWs.GetProjectGuaranteeForm(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    Dim strForm As String = String.Empty
                    Dim strDescription As String = String.Empty
                    For i = 0 To i - 1
                        dr = ds.Tables(0).Rows(i)
                        With dr
                            strDescription = IIf(.Item("description") Is System.DBNull.Value, "(空)", .Item("description") & "")
                            strForm = strForm & (i + 1) & "、" & strDescription & Chr(13).ToString
                        End With
                    Next
                    replaceList.Add(strForm)
                Else
                    replaceList.Add(StrSpace)
                End If
                'loan_notice
                strSql = "{project_code='" & StrProjectCode & "'}"
                ds = gWs.GetLoanNoticeInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '担保金额

                        If Not .Item("sum") Is System.DBNull.Value Then
                            Dim strSum As String = .Item("sum")
                            'qxd 2003-10-30 modify
                            'replaceList.Add(Money2String.Money2String.GetScienceString(strSum))
                            replaceList.Add(strSum)
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '担保期限:开始
                        If Not .Item("start_date") Is System.DBNull.Value Then
                            replaceList.Add(CType(.Item("start_date"), Date).ToString("yyyy年MM月dd日"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '担保期限:截止
                        If Not .Item("end_date") Is System.DBNull.Value Then
                            replaceList.Add(CType(.Item("end_date"), Date).ToString("yyyy年MM月dd日"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                'refund_certificate
                strSql = "{project_code='" & StrProjectCode & "'}"
                ds = gWs.GetRefundCertificateInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '被担保企业还款日期
                        If Not .Item("refund_date") Is System.DBNull.Value Then
                            replaceList.Add(CType(.Item("refund_date"), Date).ToString("yyyy年MM月dd日"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                End If
                'project_terminate_report
                strSql = "{project_code='" & StrProjectCode & "'}"
                ds = gWs.GetTerminateReportInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '担保责任终止
                        If Not .Item("terminate_type") Is System.DBNull.Value Then
                            replaceList.Add(.Item("terminate_type"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '提前终止
                        If Not .Item("terminate_date") Is System.DBNull.Value Then
                            replaceList.Add(CType(.Item("terminate_date"), Date).ToString("yyyy年MM月dd日"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        ''逾期终止
                        'If Not .Item("terminate_date") Is System.DBNull.Value Then
                        '    replaceList.Add(CType(.Item("terminate_date"), Date).ToString("yyyy年MM月dd日"))
                        'Else
                        '    replaceList.Add(strSpace)
                        'End If
                        '评价
                        If Not .Item("appraisement") Is System.DBNull.Value Then
                            replaceList.Add(.Item("appraisement"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '是否值得我中心继续支持
                        If Not .Item("is_continue_support") Is System.DBNull.Value Then
                            If .Item("is_continue_support") = "1" Then
                                replaceList.Add("是")
                            Else
                                replaceList.Add("否")
                            End If
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '是否建议列入我中心高风险企业名单电脑库
                        If Not .Item("is_high_risk") Is System.DBNull.Value Then
                            If .Item("is_high_risk") = "1" Then
                                replaceList.Add("是")
                            Else
                                replaceList.Add("否")
                            End If
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    'replaceList.Add(strSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
        Return replaceList
    End Function
    '----------------------------qxd add 2003-5-30-----------------------------
    '1.**************************
    '合同制作
    '（存单）质押反担保合同
    Public Function getImpawnContractFlag()
        Dim contractFlag As String() = {"&#BankName", "&#ACompany", "&#BCompany", _
                "&#Alegal_representative" _
                         }
        Return contractFlag
    End Function
    '质押反担保合同
    Public Function getImpawnContractReplace()
        Dim replaceList As New ArrayList
        If Not gWs Is Nothing Then
            Try
                '银行及支行
                replaceList.Add(getBank())
                '企业名称
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '法人
                replaceList.Add(getFieldName("legal_representative", "1"))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '2.****************************
    '抵押反担保合同
    Public Function getPledgeContractFlag()
        Dim contractFlag As String() = {"&#BankName", "&#ACompany", "&#BCompany", _
                     "&#Alegal_representative" _
                    }
        '"&#OppGuarantee", "&#Guarantee_value" _
        Return contractFlag
    End Function
    '抵押反担保合同
    Public Function getPledgeContractReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                '银行及支行
                replaceList.Add(getBank())
                '企业名称
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '法人
                replaceList.Add(getFieldName("legal_representative", "1"))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '3.******************************
    '保证合同（银行）
    Public Function getAssureContractFlag()
        Dim contractFlag As String() = {"&#BankName", "&#CorporationName"}
        Return contractFlag
    End Function
    '保证合同（银行）
    Public Function getAssureContractReplace()
        Dim replaceList As New ArrayList
        If Not gWs Is Nothing Then
            Try
                '银行及支行
                replaceList.Add(getBank())
                '企业名称
                replaceList.Add(getFieldName("corporation_name", "1"))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '4.******************************
    '企业保证反担保合同
    Public Function getAssureOppContractFlag()
        Dim contractFlag As String() = {"&#ACompany_Opp", "&#CCompany_Opp", "&#BankName", "&#Address_Opp", "&#Alegal_representative_Opp", _
                    "&#BCompany", "&#DCompany", "&#BAddress", "&#Blegal_representative" _
                     }
        Return contractFlag
    End Function
    '企业保证反担保合同
    Public Function getAssureOppContractReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                '-------------------- '反担保企业，corporationType：2 -----------------
                '企业名称
                replaceList.Add(getFieldName("corporation_name", "2"))
                replaceList.Add(getFieldName("corporation_name", "2"))
                '银行及支行
                replaceList.Add(getBank())
                '注册地址
                replaceList.Add(getFieldName("district_name", "2") & getFieldName("register_address", "2"))
                '法人
                replaceList.Add(getFieldName("legal_representative", "2"))
                '-------------------- '担保企业，corporationType：1 -------------------
                '企业名称
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '注册地址
                replaceList.Add(getFieldName("district_name", "1") & getFieldName("register_address", "1"))
                '法人
                replaceList.Add(getFieldName("legal_representative", "1"))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '5.*********************************
    '.委托保证合同
    Public Function getDelegateContractFlag()
        Dim contractFlag As String() = {"&#BankName", "&#ACompany", "&#BCompany", _
                        "&#AGuaranteeSum", "&#BGuaranteeSum", "&#LoanTerms", _
                        "&#AReviewFee", "&#BReviewFee", "&#AGuaranteeFee", "&#BGuaranteeFee" _
                         }
        Return contractFlag
    End Function
    '.委托保证合同
    Public Function getDelegateContractReplace()
        Dim replaceList As New ArrayList
        If Not gWs Is Nothing Then
            Try
                '银行及支行
                replaceList.Add(getBank())
                '企业名称
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '金额
                Dim strSum As String = getConferenceTrial("guarantee_sum")
                If strSum.Trim = "" Then
                    strSum = "0"
                End If
                strSum = (CType(strSum, Double) * 10000.0).ToString
                replaceList.Add(Money2String.Money2String.GetCnString(strSum))
                replaceList.Add(Money2String.Money2String.GetScienceString(strSum))
                '期限
                replaceList.Add(getConferenceTrial("terms"))
                '评审费
                strSum = getProjectAccountDetail("31", "001")
                If strSum.Trim = "" Then
                    strSum = "0"
                End If
                replaceList.Add(Money2String.Money2String.GetCnString(strSum))
                replaceList.Add(Money2String.Money2String.GetScienceString(strSum))
                '担保费
                strSum = getProjectAccountDetail("31", "002")
                If strSum.Trim = "" Then
                    strSum = "0"
                End If
                replaceList.Add(Money2String.Money2String.GetCnString(strSum))
                replaceList.Add(Money2String.Money2String.GetScienceString(strSum))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '6*******************************
    '委托贷款合同
    Public Function getDelegateLoanContractFlag()
        Dim contractFlag As String() = {"&#ACompany", "&#BCompany", _
                                "&#AGuaranteeSum", "&#BGuaranteeSum", "&#LoanTerms", _
                                 "&#Alegal_representative" _
                                 }
        Return contractFlag
    End Function
    '委托贷款合同
    Public Function getDelegateLoanContractReplace()
        Dim replaceList As New ArrayList
        If Not gWs Is Nothing Then
            Try
                '企业名称
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '金额
                Dim strSum As String = getConferenceTrial("guarantee_sum")
                If strSum.Trim = "" Then
                    strSum = "0"
                End If
                strSum = (CType(strSum, Double) * 10000.0).ToString
                replaceList.Add(Money2String.Money2String.GetCnString(strSum))
                replaceList.Add(Money2String.Money2String.GetScienceString(strSum))
                '期限
                replaceList.Add(getConferenceTrial("terms"))
                '法人
                replaceList.Add(getFieldName("legal_representative", "1"))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '7 **************************
    '个人保证合同
    Public Function getPersonalOppContractFlag()
        Dim contractFlag As String() = {"&#BankName", "&#ACompany", "&#BCompany", _
                                "&#Legal_Representative", "&#Opp_persons", "&#Opp_Address", "&#PersonalAssetList" _
                                 }
        Return contractFlag
    End Function
    '个人保证合同
    Public Function getPersonalOppContractReplace()
        Dim replaceList As New ArrayList
        If Not gWs Is Nothing Then
            Try
                '银行及支行
                replaceList.Add(getBank())
                '企业名称
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '法定代表人
                replaceList.Add(getFieldName("legal_representative", "1") & getFieldName("legal_representative", "1"))
                '反担保保证人和地址,个人资产清单
                replaceList.Add(getOppGuaranteeAssureer("name"))
                replaceList.Add(getOppGuaranteeAssureer("address"))
                replaceList.Add(getOppGuaranteeAssureer("assets_bill"))
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
        Return replaceList
    End Function
    '获得银行及支行名称
    Private Function getBank()
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                'intent_letter
                strSql = "{project_code='" & StrProjectCode & "' order by intent_code desc}"
                ds = gWs.GetIntentLetterInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Dim strBankCode As String
                    Dim strBankName, strBranchName As String
                    With dr
                        '银行名称
                        If Not .Item("loan_bank") Is System.DBNull.Value Then
                            strBankCode = .Item("loan_bank")
                            strBankName = getBankName(strBankCode)
                        Else
                            strBankName = ""
                        End If
                        '支行名称
                        If Not .Item("loan_branch_bank") Is System.DBNull.Value Then
                            strBranchName = getBranchBankName(strBankCode, .Item("loan_branch_bank"))
                        Else
                            strBranchName = ""
                        End If
                        Return strBankName & strBranchName
                    End With
                Else
                    Return StrSpace
                End If
            Catch
                Return StrSpace
            End Try
        End If
    End Function
    '获得project_corporation中的字段值
    Private Function getFieldName(ByVal fieldName As String, ByVal corporationType As String)
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                'strSql = "{project_code='" & strProjectCode & "' and phase='评审' and corporation_type='1'}"
                'ds = gWs.FetchProjectCorporationEx(strSql)
                ds = gWs.FetchProjectCorporation(StrProjectCode, "%", corporationType, "评审")
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '企业名称
                        If Not .Item(fieldName) Is System.DBNull.Value Then
                            Return .Item(fieldName)
                        Else
                            Return StrSpace
                        End If
                    End With
                Else
                    Return StrSpace
                End If
            Catch ex As Exception
                Return StrSpace
            End Try
        End If
    End Function
    '获取conference_trial表中的字段值
    Private Function getConferenceTrial(ByVal fieldName As String)
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                strSql = "{project_code='" & StrProjectCode & "' order by trial_times }"
                ds = gWs.GetConfTrialInfo(strSql, "null")
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '企业名称
                        If Not .Item(fieldName) Is System.DBNull.Value Then
                            Return .Item(fieldName)
                        Else
                            Return StrSpace
                        End If
                    End With
                Else
                    Return StrSpace
                End If
            Catch ex As Exception
                Return StrSpace
            End Try
        End If
    End Function
    '获取project_account_detail
    Private Function getProjectAccountDetail(ByVal itemType As String, ByVal itemCode As String)
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strTemp As String
        Dim dTemp As Double
        Dim dSum As Double = 0.0
        If Not gWs Is Nothing Then
            Try
                strSql = "{project_code='" & StrProjectCode & "' and item_type='" _
                        & itemType & "' and item_code='" & itemCode & _
                        "' and income is null}"
                ds = gWs.GetProjectAccountDetailInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = ds.Tables(0).Rows(i)
                        With dr
                            If Not .Item("payout") Is System.DBNull.Value Then
                                strTemp = .Item("payout")
                            Else
                                strTemp = "0"
                            End If
                            dTemp = CType(strTemp, Double)
                            dSum = dSum + dTemp
                        End With
                    Next
                    Return dSum.ToString
                Else
                    Return StrSpace
                End If
            Catch ex As Exception
                Return StrSpace
            End Try
        End If
    End Function
    '获取opposite_guarantee_assurer
    Private Function getOppGuaranteeAssureer(ByVal fieldName As String)
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strName, strField As String
        If Not gWs Is Nothing Then
            Try
                strSql = "{project_code='" & StrProjectCode & "'}"
                ds = gWs.GetOppositeGuaranteeAssurerInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = ds.Tables(0).Rows(i)
                        With dr
                            If Not .Item(fieldName) Is System.DBNull.Value Then
                                strName = .Item(fieldName) & ";"
                            Else
                                strName = " "
                            End If
                            strField = strField & strName
                        End With
                    Next
                    Return strField
                Else
                    Return StrSpace
                End If
            Catch ex As Exception
                Return StrSpace
            End Try
        End If
    End Function
    '***************************保函合同************************************qxd 2003-12-9 start
    '开立额度保函协议书
    '标记
    Public Function getLetterProtocolFlag()
        Dim flag As String() = {"&#ACompany", "&#BCompany"}
        Return flag
    End Function
    '替换内容
    Public Function getLetterProtocolReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{project_code='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "'}"
        If Not gWs Is Nothing Then
            Try
                'ds = gWs.FetchProjectCorporation(strSql)
                ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "1", StrPhase)
                i = ds.Tables("TProjectCorporation").Rows.Count
                If i > 0 Then
                    dr = ds.Tables("TProjectCorporation").Rows(0)
                    With dr
                        '企业名称
                        If Not .Item("corporation_name") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corporation_name"))
                            replaceList.Add(.Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        Else
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
        End If
        Return replaceList
    End Function
    '开立保函确认书
    '标记
    Public Function getLetterAffirmFlag()
        Dim flag As String() = {"&#Company", "&#BankAndBranch", "&#AssureSum"}
        Return flag
    End Function
    '替换内容
    Public Function getLetterAffirmReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{projectcode='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "'}"
        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetProjectInfoEx(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '企业名称
                        If Not .Item("EnterpriseName") Is System.DBNull.Value Then
                            replaceList.Add(.Item("EnterpriseName"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '银行及支行
                        Dim strBank, strBranch As String
                        If Not .Item("BankName") Is System.DBNull.Value Then
                            If Not .Item("BranchBankName") Is System.DBNull.Value Then
                                strBranch = .Item("BranchBankName")
                            End If
                            strBank = .Item("BankName") & strBranch
                            replaceList.Add(strBank)
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                '保证金金额
                Try
                    Dim dsDetail As DataSet
                    strSql = "{project_code='" & StrProjectCode & "' and phase='" & StrPhase & "' and item_type='34' and item_code='009'}"
                    dsDetail = gWs.GetProjectAccountDetailInfo(strSql)
                    If Not dsDetail Is Nothing AndAlso dsDetail.Tables(0).Rows.Count = 1 Then
                        replaceList.Add(dsDetail.Tables(0).Rows(0).Item("payout"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                    replaceList.Add(StrSpace)
                End Try
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        Else
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
        End If
        Return replaceList
    End Function
    '自然人保证反担保合同
    '标记
    Public Function getLetterPledgeFlag()
        'Dim flag As String() = {"&#ACompany", "&#BCompany", "&#BankAndBranch"}
        Dim flag As String() = {"&#ACompany", "&#BCompany", "&#BankAndBranch", "&#Opp_persons", "&#PersonalAssetList"}
        Return flag
    End Function
    '替换内容
    Public Function getLetterPledgeReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{projectcode='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "'}"
        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetProjectInfoEx(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '企业名称
                        If Not .Item("EnterpriseName") Is System.DBNull.Value Then
                            replaceList.Add(.Item("EnterpriseName"))
                            replaceList.Add(.Item("EnterpriseName"))
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                        '银行及支行
                        Dim strBank, strBranch As String
                        If Not .Item("BankName") Is System.DBNull.Value Then
                            If Not .Item("BranchBankName") Is System.DBNull.Value Then
                                strBranch = .Item("BranchBankName")
                            End If
                            strBank = .Item("BankName") & strBranch
                            replaceList.Add(strBank)
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                replaceList.Add(getOppGuaranteeAssureer("name"))
                replaceList.Add(getOppGuaranteeAssureer("assets_bill"))
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        Else
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
        End If
        Return replaceList
    End Function
    '
    '***************************保函合同************************************qxd 2003-12-9 end 
    '8*************再担保合同************** xie 2004-2-24 add 
    Public Function getReGuaranteeFlag()
        Dim flag As String() = {"&#ReGurantee", "&#Bank_branch", "&#Creditee", "&#Bank_branch", "&#Creditee", " &#Bank_branch", _
        "&#Creditee", "&#Bank_branch", "&#ApplySum", " &#Bank_branch", " &#Bank_branch", "&#ReGuarantee"}
        Return flag
    End Function
    Public Function getReGuaranteeReplace()

        Dim replaceList As New ArrayList
        Dim bankAndBranch As String
        Dim corpName As String
        Dim creditee As String
        Dim reGuaranteeSum As String

        Dim dr As DataRow

        '赋值bankandbranch
        Dim dsLoanNotice As DataSet
        dsLoanNotice = gWs.GetLoanNoticeInfo("{project_code='" & Me.StrProjectCode & "'}")
        If dsLoanNotice.Tables(0).Rows.Count > 0 Then
            dr = dsLoanNotice.Tables(0).Rows(0)
            If Not dr.Item("bank") Is System.DBNull.Value Then
                Dim dsBanka As DataSet
                dsBanka = gWs.GetBankInfo("{bank_code='" & dr.Item("bank") & "'}", "{bank_code='" & dr.Item("bank") & "'}")
                Dim strBank As String = dsBanka.Tables("bank").Rows(0).Item("bank_name")
                Dim strBranch As String = dsBanka.Tables("bank_branch").Select("branch_bank_code='" & dr.Item("branch_bank") & "'")(0).Item("branch_bank_name")
                bankAndBranch = strBank & strBranch
            Else
                bankAndBranch = StrSpace
            End If
        Else
            bankAndBranch = StrSpace
        End If

        '赋值再担保机构名称corpname
        Dim dsProjectOrg As DataSet
        dsProjectOrg = gWs.GetProjectOrganization("{project_code='" & Me.StrProjectCode & "'}")
        If dsProjectOrg.Tables(0).Rows.Count > 0 Then
            dr = dsProjectOrg.Tables(0).Rows(0)
            If Not dr.Item("organno") Is System.DBNull.Value Then
                Dim dsTemp As DataSet = gWs.GetTOrganizationInfo("{organno='" & dr.Item("organno") & "'}")
                corpName = dsTemp.Tables(0).Rows(0).Item("name")
            Else
                corpName = StrSpace
            End If
        Else
            corpName = StrSpace
        End If

        '赋值向银行贷款企业名称creditee
        creditee = Me.StrCorporationName

        '再担保金额reguaranteesum
        Dim dsProjAccoutDetail As DataSet
        dsProjAccoutDetail = gWs.GetProjectAccountDetailInfo("{project_code='" & Me.StrProjectCode & "' and item_type='31' and item_code='002'}")
        If dsProjAccoutDetail.Tables(0).Rows.Count > 0 Then
            dr = dsProjAccoutDetail.Tables(0).Rows(0)
            If Not dr.Item("payout") Is System.DBNull.Value Then
                reGuaranteeSum = Money2String.Money2String.GetCnString(dr.Item("payout")) & "(" & Money2String.Money2String.GetScienceString(dr.Item("payout")) & ")"
            Else
                reGuaranteeSum = StrSpace
            End If
        Else
            reGuaranteeSum = StrSpace
        End If

        With replaceList
            .Add(corpName)
            .Add(bankAndBranch)
            .Add(creditee)
            .Add(bankAndBranch)
            .Add(creditee)
            .Add(bankAndBranch)
            .Add(creditee)
            .Add(bankAndBranch)
            .Add(reGuaranteeSum)
            .Add(bankAndBranch)
            .Add(bankAndBranch)
            .Add(corpName)
        End With

        Return replaceList
    End Function

    '****咨询企业信息采集表 start
    Public Function getCorpConsultInfoFlag() As String()
        Dim flag As String() = {"&#CorporationName", "&#FoundDate", "&#st", "&#ht", "&#ContactPerson1", "&#Job1", _
                        "&#ContactPerson2", "job2", "&#PhoneNUm", "&#Mobile", "&#Fax", "&#Email", "&#WebSite", _
                        "&#Sum", "&#Term", "&#CorporationDesc", "&#ProjectDesc", "&#ConsultPerson", "&#Date"}
        Return flag
    End Function
    Public Function replaceCorpConsultInfoFlag()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim dsConsult As DataSet
        Dim dr As DataRow
        Dim i As Int16
        Try
            strSql = "select top 1 * from consultation where corporation_code='" & StrCorporationCode & "' and corporation_name='" & Me.StrCorporationName & "' order by serial_num desc"
            dsConsult = gWs.GetCommonQueryInfo(strSql)
            i = dsConsult.Tables(0).Rows.Count
            If i > 0 Then
                dr = dsConsult.Tables("consult").Rows(0)
                With replaceList
                    .Add(StrCorporationCode)
                    .Add(dr.Item("found_date"))
                    .Add(dr.Item("proprietorship_type"))
                    .Add(dr.Item("industry_type"))
                    .Add(dr.Item("contact_person"))
                    .Add(dr.Item("job"))
                    .Add("")
                    .Add("")
                    .Add(dr.Item("phone_num"))
                    .Add(dr.Item("mobile"))
                    .Add(dr.Item("fax"))
                    .Add(dr.Item("e_mail"))
                    .Add(dr.Item("web_site"))
                    .Add(dr.Item("apply_guarantee_sum"))
                    .Add(dr.Item("apply_term"))
                    .Add(dr.Item("corporation_description"))
                    .Add(dr.Item("product_description"))
                    .Add(dr.Item("consult_person"))
                    .Add(dr.Item("consult_date"))
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return replaceList
    End Function
    '**** 咨询信息采集表 end
    '
    '通过ProjectCorporation表设置一部分评审报告的替换内容(33个企业替换标志)
    Private Sub SetReviewProjectCorporation(ByRef replaceList As ArrayList)

        Dim strSql As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow
        Dim dsCorp As DataSet

        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{project_code='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "' and phase='" & StrPhase & "' }"

        Try
            'ds = gWs.FetchProjectCorporation(strSql)
            ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "1", StrPhase)
            dsCorp = gWs.GetCommonQueryInfo("Select * from Corporation where corporation_code='" & StrCorporationCode & "'")
            i = ds.Tables("TProjectCorporation").Rows.Count
            If i = 0 Then
                Dim j As Integer
                'qxd 2003-12-17 modify
                '33 个申请企业替换标记+10个销售额及利润总额+8个保函添加的标记
                For j = 0 To 34 - 1
                    replaceList.Add(StrSpace)
                Next
            End If

            If i > 0 Then
                dr = ds.Tables("TProjectCorporation").Rows(0)
                '日期
                Try
                    replaceList.Add(gWs.GetSysTime().ToString("yyyy年MM月dd日"))
                    replaceList.Add(gWs.GetSysTime().ToString("yyyy年MM月dd日"))
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
                With dr
                    '企业名称_A
                    If Not .Item("corporation_name") Is System.DBNull.Value AndAlso .Item("corporation_name") <> "" Then
                        replaceList.Add(.Item("corporation_name"))
                    Else
                        '防止project_corporation表信息出错读不到corporation_name
                        If dsCorp.Tables(0).Rows.Count > 0 AndAlso Not dsCorp.Tables(0).Rows(0).Item("corporation_name") Is DBNull.Value Then
                            replaceList.Add(dsCorp.Tables(0).Rows(0).Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)

                        End If
                    End If
                    '*****************************调用project视图ViewProjectInfo中获取**************************
                    '项目经理A角
                    '项目经理B角
                    '表：project_task_attendee, role_id,“24”：A角；“25”：B角
                    Dim dsProjectTaskAttendee As DataSet
                    Dim drProjectTaskAttendee As DataRow
                    Dim k, nloop As Integer
                    Dim strManager_a, strManager_b As String
                    strSql = "role_id='24' or role_id='25'"
                    'qxd modify 2003-6-10
                    Dim strABManager As String
                    strABManager = "{projectcode='" & StrProjectCode & "'}"
                    dsProjectTaskAttendee = gWs.GetProjectInfoEx(strABManager)
                    k = dsProjectTaskAttendee.Tables(0).Rows.Count
                    If k > 0 Then
                        drProjectTaskAttendee = dsProjectTaskAttendee.Tables(0).Rows(0) '.Select(strSql, "role_id ASC")
                        For nloop = 0 To 1 '此循环是为添加两次,因为报告中有两处需要填写项目经理A,B角
                            With drProjectTaskAttendee
                                replaceList.Add(.Item("24"))
                                replaceList.Add(.Item("25"))
                            End With
                        Next
                    Else
                        replaceList.Add(StrSpace)
                        replaceList.Add(StrSpace)
                        replaceList.Add(StrSpace)
                        replaceList.Add(StrSpace)
                    End If
                    '*****************************

                    '企业名称
                    If Not .Item("corporation_name") Is System.DBNull.Value Then
                        replaceList.Add(.Item("corporation_name"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '企业法人营业执照号码
                    If Not .Item("business_licence_code") Is System.DBNull.Value Then
                        replaceList.Add(.Item("business_licence_code"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '营业期限开始
                    If Not .Item("business_start_date") Is System.DBNull.Value Then
                        replaceList.Add(CType(.Item("business_start_date"), Date).ToString("yyyy年MM月dd日"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '营业期限结束
                    If Not .Item("business_end_date") Is System.DBNull.Value Then
                        replaceList.Add(CType(.Item("business_end_date"), Date).ToString("yyyy年MM月dd日"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    If dsCorp.Tables(0).Rows.Count > 0 Then
                        '注册地址:描述
                        If Not dsCorp.Tables(0).Rows(0)("district_name") Is System.DBNull.Value Then
                            replaceList.Add(dsCorp.Tables(0).Rows(0)("district_name"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '注册地址:地址
                        If Not dsCorp.Tables(0).Rows(0)("register_address") Is System.DBNull.Value Then
                            replaceList.Add(dsCorp.Tables(0).Rows(0)("register_address"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    Else
                        replaceList.Add(StrSpace)
                        replaceList.Add(StrSpace)
                    End If
                    '注册资本
                    If Not .Item("register_capital") Is System.DBNull.Value Then
                        replaceList.Add(.Item("register_capital"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '注册资本的货币单位
                    If Not .Item("MoneyID") Is System.DBNull.Value Then
                        replaceList.Add(getMoneyName(.Item("MoneyID")))
                    Else
                        replaceList.Add("人民币")
                    End If
                    '实收资本
                    If Not .Item("real_capital") Is System.DBNull.Value Then
                        replaceList.Add(.Item("real_capital"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '其中现金到位
                    If Not .Item("cash_receive") Is System.DBNull.Value Then
                        replaceList.Add(.Item("cash_receive"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '无形资产
                    If Not .Item("invisible_assets") Is System.DBNull.Value Then
                        replaceList.Add(.Item("invisible_assets"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '法定代表人
                    If Not .Item("legal_representative") Is System.DBNull.Value Then
                        replaceList.Add(.Item("legal_representative"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '国籍
                    If Not .Item("nationality") Is System.DBNull.Value Then
                        replaceList.Add(.Item("nationality"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '身份证号码
                    If Not .Item("id_card") Is System.DBNull.Value Then
                        replaceList.Add(.Item("id_card"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '贷款卡号码
                    If Not .Item("loan_card_id") Is System.DBNull.Value Then
                        replaceList.Add(.Item("loan_card_id"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '企业法人代码证号码
                    If Not .Item("corp_paper_id") Is System.DBNull.Value Then
                        replaceList.Add(.Item("corp_paper_id"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '企业资信等级
                    If Not .Item("credit_grade") Is System.DBNull.Value Then
                        replaceList.Add(.Item("credit_grade"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '评定单位
                    If Not .Item("evaluate_institution") Is System.DBNull.Value Then
                        replaceList.Add(.Item("evaluate_institution"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '企业性质
                    If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                        replaceList.Add(.Item("proprietorship_type"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '技术创新情况
                    If Not .Item("technology_type") Is System.DBNull.Value Then
                        replaceList.Add(getTechnologyType(.Item("technology_type")))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '人员素质：员工总数
                    If Not .Item("employee_amount") Is System.DBNull.Value Then
                        replaceList.Add(.Item("employee_amount"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '大专
                    If Not .Item("college") Is System.DBNull.Value Then
                        replaceList.Add(.Item("college"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '本科
                    If Not .Item("bachelor") Is System.DBNull.Value Then
                        replaceList.Add(.Item("bachelor"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '硕士
                    If Not .Item("master") Is System.DBNull.Value Then
                        replaceList.Add(.Item("master"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '博士
                    If Not .Item("docter") Is System.DBNull.Value Then
                        replaceList.Add(.Item("docter"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '经营范围
                    If Not .Item("business_scope") Is System.DBNull.Value Then
                        replaceList.Add(.Item("business_scope"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '主导产品（或主业）
                    If Not .Item("leading_product") Is System.DBNull.Value Then
                        replaceList.Add(.Item("leading_product"))
                    Else
                        replaceList.Add(StrSpace)
                    End If

                End With
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    '
    '通过ProjectCorporation表设置一部分评审报告的替换内容(10个销售及利润总额)
    Private Sub SetReviewCorporationAccout(ByRef replaceList As ArrayList)

        Dim strSql As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow

        '---------销售额及利润总额----------2003-12-17 add
        Dim strApplyDate As String
        Dim strSQLIndex, strSystemID, strSQLSystem As String
        Dim strMonth, strYear, strLastYear, strBeforeLastYear, strBBLastYear As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double

        strApplyDate = GetApplyDate(StrProjectCode)

        strYear = CType(strApplyDate, Date).Year '今年
        strMonth = CType(strApplyDate, Date).Month '今年的月份

        dYear = CType(strYear, Double)

        lastYear = dYear - 1 '去年
        strLastYear = lastYear.ToString

        beforeLastYear = dYear - 2 '前年
        strBeforeLastYear = beforeLastYear.ToString

        replaceList.Add(strBeforeLastYear) '前年
        replaceList.Add(strLastYear) '去年
        replaceList.Add(strYear) '今年
        replaceList.Add(strMonth) '今年的月份

        'strSql = "{project_code='" & strProjectCode & "' and corporation_code='" & strCorporationCode & "' and phase='" & strPhase & "' }"
        strSql = "{project_code='" & StrProjectCode & "' and phase='" & StrPhase & "' and corporation_code='" & StrCorporationCode & _
            "' and (month like '" & strYear & "%' or month like '" & strLastYear & _
                "%' or month like '" & strBeforeLastYear & "%' or month like '" & strBBLastYear & "%') " & _
                " and ((item_type='02' and item_code='b01') or (item_type='02' and item_code='b14'))}"
        Try

            ds = gWs.FetchCorporationAccount(strSql)

            If Not ds Is Nothing Then

                Dim strValue As String
                Dim strSort As String = "item_code asc"
                Dim drTemp As DataRow

                '上前年
                strSql = "month like '" & strBeforeLastYear & "%' "
                If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                '去年
                strSql = "month like '" & strLastYear & "%' "
                If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                '今年
                strSql = "month like '" & strYear & "%' "
                If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
            Else
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    '
    '通过Project表设置一部分评审报告的替换内容(8个保函替换标志)
    Private Sub SetReviewProject(ByRef replaceList As ArrayList, ByVal cmbTypeText As String)

        '-----------------------------------
        '**********************************从project表中直接获取项目的信息************************************
        '------------------------保函----------------------qxd add 2003-12-4----------------------------------
        '如果业务品种是:保函
        If cmbTypeText = "45002" Then Exit Sub

        Try

            Dim dsProject As DataSet
            Dim drProject As DataRow
            Dim projectCount As Integer
            Dim strProjectSQL As String = "{project_code='" & StrProjectCode & "'}"
            dsProject = gWs.GetProjectInfo(strProjectSQL)
            If Not dsProject Is Nothing Then
                projectCount = dsProject.Tables(0).Rows.Count
            End If
            If projectCount = 0 Then
                Dim nloop As Int16
                For nloop = 0 To 7
                    replaceList.Add(StrSpace)
                Next
            End If
            If projectCount > 0 Then
                drProject = dsProject.Tables(0).Rows(0)
                With drProject
                    '履约担保额度需求分析及本次申请额度用途
                    If Not .Item("purpose") Is System.DBNull.Value Then
                        replaceList.Add(.Item("purpose"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '项目名称
                    If Not .Item("bh_project_name") Is System.DBNull.Value Then
                        replaceList.Add(.Item("bh_project_name"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '项目内容
                    If Not .Item("bh_project_content") Is System.DBNull.Value Then
                        replaceList.Add(.Item("bh_project_content"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '受益人情况介绍
                    If Not .Item("bh_beneficiary_introduction") Is System.DBNull.Value Then
                        replaceList.Add(.Item("bh_beneficiary_introduction"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '保函类型
                    If Not .Item("guarantee_letter_type") Is System.DBNull.Value Then

                        replaceList.Add(getGuaranteeLetterName(.Item("guarantee_letter_type")))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '保函金额
                    If Not .Item("apply_sum") Is System.DBNull.Value Then
                        replaceList.Add(.Item("apply_sum"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '保函期限
                    If Not .Item("apply_term") Is System.DBNull.Value Then
                        replaceList.Add(.Item("apply_term"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '受益人索赔条件
                    If Not .Item("bh_counterclaim_condition") Is System.DBNull.Value Then
                        replaceList.Add(.Item("bh_counterclaim_condition"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        '----------------------------------------qxd add 2003-12-4----------------------------------
    End Sub
    '通过ProjectCorporation表设置一部分评审报告的替换内容(19个担保企业替换标志)
    Private Sub SetReviewProjectCorporation2(ByRef replaceList As ArrayList)

        Dim strSql As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow

        ''''''''''''''''''''''''''''''''''''''''''''''''
        Dim count As Integer = 19  '有19个保证企业的信息
        strSql = "{project_code='" & StrProjectCode & "' and corporation_type='2' }"
        'strSql = "{project_code='" & StrProjectCode & "' and not corporation_code='" & StrCorporationCode & "' and phase='" & StrPhase & "' }"

        Try
            ds = gWs.FetchProjectCorporation(strSql)
            'ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "2", StrPhase)
            i = ds.Tables("TProjectCorporation").Rows.Count
            If i = 0 Then
                Dim j As Integer
                For j = 0 To count - 1
                    replaceList.Add(StrSpace)
                Next
            End If
            If i > 0 Then
                dr = ds.Tables("TProjectCorporation").Rows(0)
                With dr
                    '企业名称
                    If Not .Item("corporation_name") Is System.DBNull.Value Then
                        replaceList.Add(.Item("corporation_name"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '企业法人营业执照号码
                    If Not .Item("business_licence_code") Is System.DBNull.Value Then
                        replaceList.Add(.Item("business_licence_code"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '营业期限开始
                    If Not .Item("business_start_date") Is System.DBNull.Value Then
                        replaceList.Add(CType(.Item("business_start_date"), Date).ToString("yyyy年MM月dd日"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '营业期限结束
                    If Not .Item("business_end_date") Is System.DBNull.Value Then
                        replaceList.Add(CType(.Item("business_end_date"), Date).ToString("yyyy年MM月dd日"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '注册地址:描述
                    If Not .Item("district_name") Is System.DBNull.Value Then
                        replaceList.Add(.Item("district_name"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '注册地址:地址
                    If Not .Item("register_address") Is System.DBNull.Value Then
                        replaceList.Add(.Item("register_address"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '注册资本
                    If Not .Item("register_capital") Is System.DBNull.Value Then
                        replaceList.Add(.Item("register_capital"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '实收资本
                    If Not .Item("real_capital") Is System.DBNull.Value Then
                        replaceList.Add(.Item("real_capital"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '其中现金到位
                    If Not .Item("cash_receive") Is System.DBNull.Value Then
                        replaceList.Add(.Item("cash_receive"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '无形资产
                    If Not .Item("invisible_assets") Is System.DBNull.Value Then
                        replaceList.Add(.Item("invisible_assets"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '法定代表人
                    If Not .Item("legal_representative") Is System.DBNull.Value Then
                        replaceList.Add(.Item("legal_representative"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '国籍
                    If Not .Item("nationality") Is System.DBNull.Value Then
                        replaceList.Add(.Item("nationality"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '身份证号码
                    If Not .Item("id_card") Is System.DBNull.Value Then
                        replaceList.Add(.Item("id_card"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '贷款卡号码
                    If Not .Item("loan_card_id") Is System.DBNull.Value Then
                        replaceList.Add(.Item("loan_card_id"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '企业法人代码证号码
                    If Not .Item("corp_paper_id") Is System.DBNull.Value Then
                        replaceList.Add(.Item("corp_paper_id"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '企业资信等级
                    If Not .Item("credit_grade") Is System.DBNull.Value Then
                        replaceList.Add(.Item("credit_grade"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '企业性质
                    If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                        replaceList.Add(.Item("proprietorship_type"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '技术创新情况
                    If Not .Item("technology_type") Is System.DBNull.Value Then
                        replaceList.Add(getTechnologyType(.Item("technology_type")))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '与担保申请人关系
                    If Not .Item("relation") Is System.DBNull.Value Then
                        replaceList.Add(.Item("relation"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                End With
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '通过project_credit_appraise表设置一部分评审报告的替换内容(6个资信评分替换标志)
    Private Sub SetReviewAppraise(ByRef replaceList As ArrayList, ByVal strTypeText As String)

        Dim strSql As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow

        Try
            strSql = "{project_code='" & Me.StrProjectCode & "' and corporation_code='" & Me.StrCorporationCode _
                        & "' and phase='" & Me.StrPhase & "'order by month desc}"
            ds = gWs.FetchProjectCredit(strSql)
            Dim dblQuantity, dblQuality, dblTotal As Double
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                dblQuantity = IIf(dr.Item("quantity_score") Is System.DBNull.Value, 0, dr.Item("quantity_score"))
                dblQuality = IIf(dr.Item("quality_score") Is System.DBNull.Value, 0, dr.Item("quality_score"))
                dblTotal = IIf(dr.Item("total_score") Is System.DBNull.Value, 0, dr.Item("total_score"))
            End If

            If Not strTypeText = "45102" Then '保函的替换标志为3个
                replaceList.Add(Format(dblQuantity, "#,###.00").ToString)
                replaceList.Add(Format(dblQuality, "#,###.00").ToString)
                replaceList.Add(Format(dblTotal, "#,###.00").ToString)
            End If

            replaceList.Add(Format(dblQuantity, "#,###.00"))
            replaceList.Add(Format(dblQuality, "#,###.00"))
            replaceList.Add(Format(dblTotal, "#,###.00"))
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    '
    '从几个表中抽取一些数据设置一部分评审报告的替换内容(13个评审报告简介替换标志)
    Private Sub SetReviewBreif(ByRef replaceList As ArrayList)
        Dim strSql As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strReplace(11) As String

        For i = 0 To 10 '赋初值
            strReplace(i) = Me.StrSpace
        Next

        Try

            '1.从projectcorporation表中获取几个企业替换标志
            strSql = "{project_code='" & Me.StrProjectCode & "' and corporation_code='" & Me.StrCorporationCode & "'}"
            'ds = gWs.FetchProjectCorporation(strSql)
            ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "1", StrPhase)
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                strReplace(0) = dr.Item("corporation_name").ToString
                'strReplace(1) = dr.Item("found_date").ToString'这个表中的这个字段都是空
                strReplace(2) = dr.Item("register_address").ToString()
                strReplace(3) = dr.Item("register_capital").ToString()
                'strReplace(4) = dr.Item("").ToString()
                'strReplace(5) = dr.Item("").ToString()
                strReplace(6) = dr.Item("leading_product").ToString()
                If Not dr.Item("technology_type") Is System.DBNull.Value Then
                    strReplace(7) = Me.getTechName(dr.Item("technology_type"))
                End If

            End If

            '2.从corporation表获取成立时间
            Dim strCorpSql As String = "{corporation_code='" & Me.StrCorporationCode & " ' and corporation_type='1'}"
            ds = gWs.GetcorporationInfo(strCorpSql, "null")
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                If Not dr.Item("found_date") Is System.DBNull.Value Then
                    strReplace(1) = Format(dr.Item("found_date"), "yyyy-MM")
                Else
                    strReplace(1) = ""
                End If
            End If

            '3.从咨询表中获取企业上年的销售额与上年的利润总额
            Dim strConsult As String = "{corporation_code='" & Me.StrCorporationCode & "'}"
            ds = gWs.GetcorporationInfo("", strConsult)
            i = ds.Tables(1).Rows.Count
            If i > 0 Then
                dr = ds.Tables(1).Select("", "serial_num DESC")(0)
                strReplace(4) = dr.Item("lastyear_sales_income").ToString()
                strReplace(5) = dr.Item("lastyear_total_profit").ToString()
            End If

            '4.从project表获取申请的情况
            ds = gWs.GetProjectInfo(strSql)
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                strReplace(8) = dr.Item("apply_sum").ToString
                strReplace(9) = dr.Item("apply_term").ToString
                strReplace(10) = dr.Item("purpose").ToString
            End If

            For i = 0 To 10
                replaceList.Add(strReplace(i))
            Next

            '5设置项目经理意见(通过调用方法)
            Me.SetReviewManagerOpinion(replaceList)

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '通过ProjectOpinion表设置评审报告替换内容(2个项目经理的意见)
    Private Sub SetReviewManagerOpinion(ByRef replaceList As ArrayList)
        Try

            '*-------------qxd add 2003-12-4-------------
            '项目经理A,B角意见
            Dim strSql As String
            Dim dsOpinion As DataSet
            Dim drOpinion As DataRow

            '项目经理A角意见(52,002)
            strSql = "{project_code='" & StrProjectCode & "' and item_type='52' and item_code='002'}"
            dsOpinion = gWs.GetProjectOpinionByProjectNo(strSql)
            If dsOpinion.Tables(0).Rows.Count > 0 Then
                drOpinion = dsOpinion.Tables(0).Rows(0)
                If Not drOpinion.Item("content") Is System.DBNull.Value Then
                    replaceList.Add(replaceExt(drOpinion.Item("content"), ""))
                Else
                    replaceList.Add(StrSpace)
                End If
            Else
                replaceList.Add(StrSpace)
            End If

            '项目经理B角意见(52,005)
            strSql = "{project_code='" & StrProjectCode & "' and item_type='52' and item_code='005'}"
            dsOpinion = gWs.GetProjectOpinionByProjectNo(strSql)
            If dsOpinion.Tables(0).Rows.Count > 0 Then
                drOpinion = dsOpinion.Tables(0).Rows(0)
                If Not drOpinion.Item("content") Is System.DBNull.Value Then
                    replaceList.Add(replaceExt(drOpinion.Item("content"), ""))
                Else
                    replaceList.Add(StrSpace)
                End If
            Else
                replaceList.Add(StrSpace)
            End If
            '*-------------qxd end 2003-12-1-------------
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub SetDefectRecord(ByVal replacelist)
        '2007-12-24 yjf add 替换失信记录
        Dim dsDefectRecord As DataSet = gWs.GetCorpDefectInfo("{corporation_code='" & StrCorporationCode & "'}")
        If dsDefectRecord.Tables(0).Rows.Count <> 0 Then
            Dim strDefectRecord, strTemp, strTemp1, strTemp2, strTemp3 As String
            Dim x As Integer
            For x = 0 To dsDefectRecord.Tables(0).Rows.Count - 1
                strTemp1 = IIf(IsDBNull(dsDefectRecord.Tables(0).Rows(x).Item("DiscreditableDate")), "", dsDefectRecord.Tables(0).Rows(x).Item("DiscreditableDate"))
                strTemp2 = IIf(IsDBNull(dsDefectRecord.Tables(0).Rows(x).Item("source")), "", dsDefectRecord.Tables(0).Rows(x).Item("source"))
                strTemp3 = IIf(IsDBNull(dsDefectRecord.Tables(0).Rows(x).Item("description")), "", dsDefectRecord.Tables(0).Rows(x).Item("description"))
                strTemp = strTemp1 & "   " & strTemp2 & "   " & strTemp3
                strDefectRecord = strDefectRecord & vbCrLf & strTemp
            Next
            replacelist.Add(strDefectRecord)
        Else
            replacelist.Add(StrSpace)
        End If
    End Sub
    '
    '通过表opposite_guarantee_assurer设置个人资产清单
    Private Sub SetReviewAssurer(ByRef replaceList As ArrayList)

        Dim strSql As String
        Dim dsAssurer As DataSet
        Dim dr As DataRow
        Dim i As Int16
        Dim sbReplace As New System.Text.StringBuilder

        strSql = "{project_code='" & Me.StrProjectCode & "'}"
        Try
            dsAssurer = gWs.GetOppositeGuaranteeAssurerInfo(strSql)
            If Not dsAssurer Is Nothing And Not dsAssurer.Tables(0) Is Nothing AndAlso dsAssurer.Tables(0).Rows.Count > 0 Then
                i = dsAssurer.Tables(0).Rows.Count
                For i = 0 To i - 1
                    dr = dsAssurer.Tables(0).Rows(i)
                    sbReplace.Append("  保证人姓名：")
                    sbReplace.Append(dr.Item("name").ToString)
                    sbReplace.Append("  年龄：")
                    sbReplace.Append(dr.Item("age").ToString())
                    sbReplace.Append("  性别：")
                    sbReplace.Append(dr.Item("sex").ToString())
                    sbReplace.Append(ControlChars.Cr) ''
                    sbReplace.Append("  身份证号码：")
                    sbReplace.Append(dr.Item("ic_code").ToString())
                    sbReplace.Append("  住址：")
                    sbReplace.Append(dr.Item("address").ToString())
                    sbReplace.Append(ControlChars.Cr) ''
                    sbReplace.Append("  电话号码：")
                    sbReplace.Append(dr.Item("phone").ToString())
                    sbReplace.Append("  担保金额：")
                    sbReplace.Append(dr.Item("guarantee_sum").ToString())
                    sbReplace.Append(ControlChars.Cr) ''
                    sbReplace.Append("  个人资产清单：")
                    sbReplace.Append(crlfToCr(dr.Item("assets_bill").ToString()))
                    'sbReplace.Append(Me.replaceExt(dr.Item("assets_bill").ToString(), ""))
                    If Not i = dsAssurer.Tables(0).Rows.Count - 1 Then '不是最后一行时需要加上回车符
                        sbReplace.Append(ControlChars.Cr) ''
                    End If
                Next
                replaceList.Add(sbReplace.ToString())
            Else
                replaceList.Add(StrSpace)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    Private Function getTechName(ByVal code As Int16) As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strReturn As System.String

        Try
            ds = gWs.GetTechnologyType("%")
            i = ds.Tables(0).Rows.Count
            For i = 0 To i - 1
                dr = ds.Tables(0).Rows(i)
                If (dr.Item("technology_type_code") And code) = 0 Then
                    'strreturn.Append("□"c)
                    strReturn = strReturn + "□"
                Else
                    'strreturn.Append("■"c)
                    strReturn = strReturn + "■"
                End If
                'strreturn.Append(dr.Item("technology_type").ToString)
                strReturn = strReturn + dr.Item("technology_type").ToString + "   "
            Next
            Return strReturn.Trim
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '处理字符串,把其中的回车换行符替换成回车符
    Private Function crlfToCr(ByVal strReplace As String) As String
        Dim strReturn As String

        If strReplace = "" Then Return ""

        If Not strReplace.IndexOf(ControlChars.CrLf) = -1 Then
            strReturn = strReplace.Replace(ControlChars.CrLf, ControlChars.Cr)
            Return strReturn
        End If
    End Function

    '通过moneyID获得moneyName货币单位
    Private Function getMoneyName(ByVal moneyID As String)
        Dim strSql, strMoneyName As String
        Dim i, count As Integer
        Dim ds As DataSet
        Try
            ds = gWs.GetMoneyInfo(moneyID)
            If Not ds Is Nothing Then
                If ds.Tables(0).Rows.Count > 0 Then
                    strMoneyName = ds.Tables(0).Rows(0).Item("name")
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        Return strMoneyName
    End Function
End Class
