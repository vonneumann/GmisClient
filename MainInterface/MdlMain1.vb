Module MdlMain
    'Private moSplash As SWDialogBox.SplashBox
    Private _system As String = "v2.0.1"

    Friend Sub LoginedProcess(ByVal sender As Object, ByVal e As SWDialogBox.LoginedEventArgs)
        'If Not moSplash Is Nothing Then
        '    moSplash.Show("", "", "")
        '    'moSplash.Refresh("系统正在登录，请稍候...", Color.DarkBlue)
        'End If

        sender = CType(sender, SWDialogBox.LoginBox)

        If wsPermission Is Nothing Then
            wsPermission = New htfServerPermission.Permission()
        End If

        If _authentication Is Nothing Then
            _authentication = New htfServerPermission.AuthenticationHeader()
        End If

        _authentication.UserName = sender.UserName
        _authentication.Password = sender.Password
        _authentication.System = _system

        wsPermission.AuthenticationHeaderValue = _authentication


        Try
            '获取权限控制的Webservice
            'wsPermission.Url = "http://" & sender.Server & "/SWPermission/Permission.asmx"
            wsPermission.Url = "http://" & sender.Server & "/WebService_CGMIS/Permission.asmx"
            If sender.Timeout <> 0 Then
                wsPermission.Timeout = sender.Timeout * 1000
            End If

            '验证用户权限
            If wsPermission.Login(sender.UserName, sender.Password) Then
                UserName = sender.UserName
                strPasswd = sender.Password
                strServer = sender.Server
                iTimeOut = sender.Timeout

                '写配置
                Try
                    SWConsole.Configuration.SetAppValue("LoginBox.UserName", sender.UserName, True)
                    SWConsole.Configuration.SetAppValue("LoginBox.Server", sender.Server, True)
                Catch
                End Try

                '获取业务Webservice引用
                strUrl = "http://" & sender.Server & "/WebService_CGMIS/Service1.asmx"
                If gWs Is Nothing Then
                    gWs = New htfServer.Service1()
                End If
                gWs.Url = strUrl
                If sender.Timeout <> 0 Then
                    gWs.Timeout = sender.Timeout * 1000
                End If

                '2008-08-11 yjf add 获取加密密钥
                encryptionKey = gWs.GetCommonQueryInfo("select top 1 encryption_key from encryption_key").Tables(0).Rows(0).Item("encryption_key")

                e.Result = SWDialogBox.LoginResult.Success
            End If
        Catch ex As System.Web.Services.Protocols.SoapException
            e.Result = SWDialogBox.LoginResult.Unknown

            Select Case ex.Actor
                Case "InvalidAccountException"
                    MessageBox.Show("无效的系统帐户！", "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Result = SWDialogBox.LoginResult.InvalidUserName
                Case "InvalidPasswordException"
                    MessageBox.Show("无效的用户口令！", "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Result = SWDialogBox.LoginResult.InvalidPassword
                Case "InvalidLoginException"
                    MessageBox.Show("尚未正确登录系统，请先登录！", "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Result = SWDialogBox.LoginResult.Unknown
                Case "InvalidPermissionException"
                    MessageBox.Show("无效的操作权限！", "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Result = SWDialogBox.LoginResult.InvalidPermission
                Case Else
                    MessageBox.Show("系统异常！" + Environment.NewLine + "网络服务(Web Service)返回未知的异常，请即时与您的系统管理员联系并反馈该信息。" + Environment.NewLine + Environment.NewLine + ex.Message, "网络服务异常", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Result = SWDialogBox.LoginResult.Unknown
            End Select
        Catch ex As Exception
            MsgBox("服务器连接错误,请重新登录或与系统管理员联系!" & "(" & ex.Message & ")", MsgBoxStyle.Critical, "错误")
            e.Result = SWDialogBox.LoginResult.Unknown
        End Try
    End Sub

    Sub Main()
        Try
            Try
                strRootPath = System.IO.Directory.GetCurrentDirectory  '获取当前目录
                'moSplash = New SWDialogBox.SplashBox()

                'If System.IO.File.Exists(strRootPath & "\image\Splash.gif") Then
                '    moSplash.BackgroundImage = System.Drawing.Image.FromFile(strRootPath & "\image\Splash.gif")
                'End If
                'moSplash.Show("", "", "")
                'System.Threading.Thread.CurrentThread.Sleep(2000)
            Catch ex As System.Exception
                'MessageBox.Show(ex.Message, ex.Source)
            End Try
            Dim frmLogin As New SWDialogBox.LoginBox()
            'Dim iCounter As Int16

            'wsPermission = New htfServerPermission.Permission()
            '_authentication = New htfServerPermission.AuthenticationHeader()
            'wsPermission.AuthenticationHeaderValue = _authentication

            AddHandler frmLogin.Logined, AddressOf LoginedProcess

            Try
                '读取配置
                frmLogin.UserName = SWConsole.Configuration.GetAppValue("LoginBox.UserName")
                frmLogin.Server = SWConsole.Configuration.GetAppValue("LoginBox.Server")
                Try
                    frmLogin.Timeout = Int32.Parse(SWConsole.Configuration.GetAppValue("LoginBox.Timeout"))
                Catch
                End Try
            Catch
            End Try

            'moSplash.Close()

            If frmLogin.Login() Then
                '打开主界面
                Dim frmMain As New FConsole     ' frmMainInterface()
                'Dim frmMain As New frmMainInterface     ' frmMainInterface()
                'setFormMenu(frmMain)

                'moSplash.Close()
                'moSplash.Dispose()
                'moSplash = Nothing
                Application.Run(frmMain)
            Else
                Return
            End If
        Finally
            'If Not moSplash Is Nothing Then
            '    moSplash.Dispose()
            '    moSplash = Nothing
            'End If
        End Try
    End Sub

    Friend Sub setFormMenu(ByVal frmMain As MainInterface.frmMainInterface)
        frmMain.mnuBaseGeneral.Enabled = False
        frmMain.MnItemOrganize.Enabled = False
        frmMain.MnItemCreditAppraise.Enabled = False
        frmMain.MnItemBranch.Enabled = False
        frmMain.MnItemRole.Enabled = False
        frmMain.MnItemTeam.Enabled = False
        frmMain.MnItemStaff.Enabled = False
        frmMain.MnItemStaffRole.Enabled = False
        frmMain.MnItemRight.Enabled = False
        frmMain.MnItemProPause.Enabled = False
        frmMain.MnItemProCancel.Enabled = False
        frmMain.MnItemProConsign.Enabled = False
        frmMain.MnItemProCancelCon.Enabled = False
        frmMain.MnItemProManual.Enabled = False
        frmMain.MnItemProAssign.Enabled = False
        frmMain.mnuProjectDelete.Enabled = False
        frmMain.MnItemMeetQuery.Enabled = False
        frmMain.MnItemMeetSet.Enabled = False
        frmMain.ToolBarBttnConsult.Enabled = False
        frmMain.MnItemConsult.Enabled = False
        frmMain.ToolBarBttnApply.Enabled = False
        frmMain.MnItemAccept.Enabled = False
        frmMain.mnuCreditProject.Enabled = False
        frmMain.mnuFinancialAnalysis.Enabled = False
        frmMain.mnuWorkFlowHoliday.Enabled = False
        frmMain.mnuWorkFlowTask.Enabled = False
        frmMain.mnuWorkLogEnter.Enabled = False
        frmMain.mnuWorkLogQuery.Enabled = False
        frmMain.mnuWorkLogStatistics.Enabled = False
        frmMain.MnItemDocQry.Enabled = False
        frmMain.MenuItem69.Enabled = False
        frmMain.mnuCompanyFileManage.Enabled = False
        frmMain.btnCredit.Enabled = False
        frmMain.mnuUpdateMeetRecord.Enabled = False
        frmMain.mnuChargeFee.Enabled = False
        frmMain.MnItemRemeet.Enabled = False
        frmMain.mnuItemClaim.Enabled = False
        frmMain.mnuItemUpdateGuarantee.Enabled = False
        frmMain.mnuItemEvaluate.Enabled = False
        frmMain.mnuItemFirReviewCancel.Enabled = False
        frmMain.mneItemUpdateProcess.Enabled = False


        '查询
        frmMain.MenuItem19.Enabled = False   '项目查询
        frmMain.MenuItem20.Enabled = False   '咨询企业查询
        'frmMain.MenuItem21.Enabled = False		 '申请企业查询
        frmMain.MenuItem28.Enabled = False   '初审项目查询
        'frmMain.MenuItem27.Enabled = False		 '正式受理企业查询
        'frmMain.MenuItem23.Enabled = False		 '申请上会项目一览表
        frmMain.MenuItem24.Enabled = False   '逾期项目一览表
        frmMain.MenuItem67.Enabled = False   '代偿项目一览表
        frmMain.MenuItem29.Enabled = False   '暂缓项目查询
        frmMain.MenuItem13.Enabled = False   '到期项目一览表
        'frmMain.MenuItem43.Enabled = False   '在保项目一览表
        frmMain.MenuItem49.Enabled = False   '终止项目一览表
        frmMain.MenuItem15.Enabled = False   '反担保物查询
        frmMain.MenuItem32.Enabled = False  '项目评价查询
        frmMain.mnuQueryFirstTrialProject.Enabled = False  '申请项目一览表
        frmMain.mnuQueryAcceptProject.Enabled = False   '正式受理项目一览表
        frmMain.mnuQueryAllocateProject.Enabled = False    '项目分配一览表
        frmMain.mnuQueryPresentingProject.Enabled = False    '提交评审会讨论项目一览表
        frmMain.mnuQuerySignProject.Enabled = False    '签约项目一览表
        frmMain.mnuQueryLoanProject.Enabled = False    '放款项目一览表
        frmMain.mnuQueryCreditProject.Enabled = False    '在保项目一览表
        frmMain.mnuQueryRequiteProject.Enabled = False    '还款项目一览表
        frmMain.mnuQueryRecantProject.Enabled = False    '撤保项目一览表
        frmMain.mnuQueryProcessingProject.Enabled = False    '各项目经理正在进行项目一览表
        frmMain.mnuQueryRegionProject.Enabled = False    '合作区项目管理一览表
        frmMain.mnuQueryChargeStatistics.Enabled = False    '收费统计
        frmMain.MnItemQrySignaturePlan.Enabled = False '签约安排查询
        frmMain.MnItemUnSignProject.Enabled = False '未签约项目查询
        frmMain.MnItemQueryGuaranteeForm.Enabled = False '反担保措施查询
        frmMain.mnuGuaranteeProject.Enabled = False '保函项目查询
        frmMain.mnuUnDealProject.Enabled = False '未处理项目查询
        frmMain.mnuAfterGuaranteeRecord.Enabled = False '保后检查一览表
        frmMain.mnuItemProjectRequite.Enabled = False '项目还款情况查询
        frmMain.mnuItemIntentLetter.Enabled = False '担保意向书发放一览表

        '统计
        frmMain.MenuItem35.Enabled = False    '担保业务统计
        'frmMain.MenuItem41.Enabled = False		  '担保业务合作银行统计
        'frmMain.MenuItem45.Enabled = False		  '担保业务行业统计
        frmMain.MenuItem46.Enabled = False    '担保业务区域统计
        'frmMain.MenuItem48.Enabled = False		  '担保业务业务品种统计
        frmMain.mnuQueryStatisticsMarketingA.Enabled = False    '经营情况统计（一）
        frmMain.mnuQueryStatisticsMarketingB.Enabled = False    '经营情况统计（二）
        frmMain.mnuQueryStatisticsMarketingC.Enabled = False    '经营情况统计（三）
        frmMain.mnuQueryStatisticsCompensation.Enabled = False    '代偿情况统计
        frmMain.MnItemStatisticsFee.Enabled = False '收费情况统计
        'frmMain.mnuQueryStatisticsGECraft.Enabled = False		  '担保企业技术状况统计
        'frmMain.mnuQueryStatisticsGEProprietorship.Enabled = False	   '担保企业所有制类型统计
        frmMain.MnItemStaticsFirstLoan.Enabled = False '首次贷款企业情况统计
        frmMain.mnuQueryStatisticsRegion.Enabled = False    '合作区情况统计
        frmMain.mnuQueryStatisticsCounterguarantee.Enabled = False  '反担保情况统计
        frmMain.mnuQueryStatisticsPMService.Enabled = False    '项目经理业务情况统计
        frmMain.MnItemStatisticsRecommendproject.Enabled = False '中心员工推荐项目统计
        frmMain.muiQueryGuarantingCorporation.Enabled = False
        frmMain.muiConferenceRoom.Enabled = False
        frmMain.mnuFinancialAnalysis.Enabled = False '财务分析
        frmMain.muiUpdateIntentLetter.Enabled = False
        frmMain.MenuCreditManager.Enabled = False
        frmMain.MenuDefectRecord.Enabled = False
        frmMain.MenuDefectRecordEdit.Enabled = False
        frmMain.MenuDefectRecordAdd.Enabled = False
        frmMain.MenuContractManage.Enabled = False
        frmMain.MenuProjectExp.Enabled = False
        frmMain.MenuQueryProjectExpandDate.Enabled = False
        frmMain.MenuReviewGuarantee.Enabled = False
        frmMain.mnuBackFee.Enabled = False


        Dim mitem As MenuItem '工作日志设置
        For Each mitem In frmMain.mnitemWorkLog.MenuItems
            mitem.Enabled = False
        Next

        Dim dsRights As New DataSet()
        dsRights = wsPermission.FetchPermission(UserName)
        Dim i As Integer
        For i = 0 To dsRights.Tables(0).Rows.Count - 1
            Select Case dsRights.Tables(0).Rows(i).Item("Formid")
                Case 1
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemBranch.Enabled = True
                Case 2
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemRole.Enabled = True
                Case 3
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemTeam.Enabled = True
                Case 4
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemStaff.Enabled = True
                Case 5
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemStaffRole.Enabled = True
                Case 7
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemRight.Enabled = True
                Case 8
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.mnuBaseGeneral.Enabled = True
                Case 9
                    frmMain.MnItemCreditAppraise.Enabled = True
                Case 10
                    frmMain.mnuBaseGeneral.Enabled = True
                Case 11 '业务流程同步
                    frmMain.mneItemUpdateProcess.Enabled = True

                    '工作流管理
                Case 20
                    frmMain.MnItemProPause.Enabled = True
                Case 21
                    frmMain.MnItemProCancel.Enabled = True
                Case 22
                    frmMain.MnItemProConsign.Enabled = True
                Case 23
                    frmMain.MnItemProCancelCon.Enabled = True
                Case 24
                    frmMain.MnItemProManual.Enabled = True
                Case 25
                    frmMain.MnItemProAssign.Enabled = True
                Case 26
                    frmMain.mnuProjectDelete.Enabled = True
                Case 27
                    frmMain.mnuWorkFlowHoliday.Enabled = True
                Case 28
                    frmMain.mnuWorkFlowTask.Enabled = True
                Case 29
                    frmMain.MnItemRemeet.Enabled = True

                Case 30
                    frmMain.MnItemMeetQuery.Enabled = True
                Case 31
                    frmMain.MnItemMeetSet.Enabled = True
                Case 32
                    frmMain.MnItemQrySignaturePlan.Enabled = True
                Case 33
                    frmMain.mnuUpdateMeetRecord.Enabled = True
                Case 34
                    frmMain.mnuItemClaim.Enabled = True
                Case 35
                    frmMain.mnuItemUpdateGuarantee.Enabled = True

                Case 40
                    frmMain.ToolBarBttnConsult.Enabled = True
                    frmMain.MnItemConsult.Enabled = True
                Case 41
                    frmMain.ToolBarBttnApply.Enabled = True
                    frmMain.MnItemAccept.Enabled = True
                Case 42
                    frmMain.mnuCreditProject.Enabled = True
                    frmMain.btnCredit.Enabled = True
                Case 43
                    frmMain.mnuChargeFee.Enabled = True
                Case 44 '员工岗位设置
                    For Each mitem In frmMain.mnitemWorkLog.MenuItems
                        mitem.Enabled = True
                    Next
                Case 51
                    frmMain.mnuWorkLogEnter.Enabled = True
                Case 52
                    frmMain.mnuWorkLogQuery.Enabled = True
                Case 53
                    frmMain.mnuWorkLogStatistics.Enabled = True
                Case 61
                    frmMain.MnItemDocQry.Enabled = True
                Case 62
                    frmMain.MenuItem69.Enabled = True
                Case 63
                    frmMain.mnuCompanyFileManage.Enabled = True

                Case 71      '项目查询
                    frmMain.MenuItem19.Enabled = True      '项目查询
                Case 72      '反担保物查询
                    frmMain.MenuItem15.Enabled = True      '反担保物查询
                Case 80      '咨询企业查询
                    frmMain.MenuItem20.Enabled = True      '咨询企业查询
                Case 81      '初审项目查询
                    frmMain.MenuItem28.Enabled = True      '初审项目查询
                Case 82      '逾期项目一览表
                    frmMain.MenuItem24.Enabled = True      '逾期项目一览表
                Case 83      '代偿项目一览表
                    frmMain.MenuItem67.Enabled = True      '代偿项目一览表
                Case 84      '暂缓项目查询
                    frmMain.MenuItem29.Enabled = True      '暂缓项目查询
                Case 85      '到期项目一览表
                    frmMain.MenuItem13.Enabled = True      '到期项目一览表
                Case 86      '终止项目一览表
                    frmMain.MenuItem49.Enabled = True      '终止项目一览表
                Case 87      '申请项目一览表
                    frmMain.mnuQueryFirstTrialProject.Enabled = True     '申请项目一览表
                Case 88      '正式受理项目一览表
                    frmMain.mnuQueryAcceptProject.Enabled = True      '正式受理项目一览表
                Case 89      '项目分配一览表
                    frmMain.mnuQueryAllocateProject.Enabled = True       '项目分配一览表
                Case 90      '提交评审会讨论项目一览表
                    frmMain.mnuQueryPresentingProject.Enabled = True       '提交评审会讨论项目一览表
                Case 91      '签约项目一览表
                    frmMain.mnuQuerySignProject.Enabled = True       '签约项目一览表
                Case 92      '放款项目一览表
                    frmMain.mnuQueryLoanProject.Enabled = True       '放款项目一览表
                Case 93      '在保项目一览表
                    frmMain.mnuQueryCreditProject.Enabled = True       '在保项目一览表
                Case 94      '还款项目一览表
                    frmMain.mnuQueryRequiteProject.Enabled = True       '还款项目一览表
                Case 95      '撤保项目一览表
                    frmMain.mnuQueryRecantProject.Enabled = True       '撤保项目一览表
                Case 96      '各项目经理正在进行项目一览表
                    frmMain.mnuQueryProcessingProject.Enabled = True       '各项目经理正在进行项目一览表
                Case 97      '合作区项目管理一览表
                    frmMain.mnuQueryRegionProject.Enabled = True       '合作区项目管理一览表
                Case 98      '收费查询
                    frmMain.mnuQueryChargeStatistics.Enabled = True       '收费查询
                Case 99      '未签约项目一览表
                    frmMain.MnItemUnSignProject.Enabled = True
                Case 100      '反担保措施查询
                    frmMain.MnItemQueryGuaranteeForm.Enabled = True
                Case 101
                    frmMain.MenuItem32.Enabled = True
                Case 102        '保函项目查询
                    frmMain.mnuGuaranteeProject.Enabled = True
                Case 103        '未处理项目查询
                    frmMain.mnuUnDealProject.Enabled = True
                Case 104
                    frmMain.mnuAfterGuaranteeRecord.Enabled = True
                Case 105        '项目还款情况查询
                    frmMain.mnuItemProjectRequite.Enabled = True
                Case 106        '担保意向书发放一览表
                    frmMain.mnuItemIntentLetter.Enabled = True
                Case 107        '资产评估一览表 
                    frmMain.mnuItemEvaluate.Enabled = True

                Case 121      '担保业务统计
                    frmMain.MenuItem35.Enabled = True       '担保业务统计
                    'Case 122      '担保业务合作银行统计
                    '    frmMain.MenuItem41.Enabled = True       '担保业务合作银行统计
                    'Case 123      '担保业务行业统计
                    '    frmMain.MenuItem45.Enabled = True       '担保业务行业统计
                Case 124      '担保业务分类统计
                    frmMain.MenuItem46.Enabled = True       '担保业务分类统计
                    'Case 125      '担保业务业务品种统计
                    'frmMain.MenuItem48.Enabled = True       '担保业务业务品种统计
                Case 126      '经营情况统计（一）
                    frmMain.mnuQueryStatisticsMarketingA.Enabled = True       '经营情况统计（一）
                Case 127      '经营情况统计（二）
                    frmMain.mnuQueryStatisticsMarketingB.Enabled = True       '经营情况统计（二）
                Case 128      '经营情况统计（三）
                    frmMain.mnuQueryStatisticsMarketingC.Enabled = True       '经营情况统计（三）
                Case 129      '代偿情况统计
                    frmMain.mnuQueryStatisticsCompensation.Enabled = True       '代偿情况统计
                Case 130      '中心员工推荐项目统计
                    frmMain.MnItemStatisticsRecommendproject.Enabled = True
                Case 131      '首次贷款企业统计
                    frmMain.MnItemStaticsFirstLoan.Enabled = True
                Case 132      '合作区情况统计
                    frmMain.mnuQueryStatisticsRegion.Enabled = True       '合作区情况统计
                Case 133      '反担保情况统计
                    frmMain.mnuQueryStatisticsCounterguarantee.Enabled = True     '反担保情况统计
                Case 134      '项目经理业务情况统计
                    frmMain.mnuQueryStatisticsPMService.Enabled = True       '项目经理业务情况统计
                Case 135      '收费情况统计
                    frmMain.MnItemStatisticsFee.Enabled = True       '收费情况统计

                Case 140 '初审暂缓
                    frmMain.mnuItemFirReviewCancel.Enabled = True
                Case 141
                    frmMain.muiQueryGuarantingCorporation.Enabled = True
                Case 142
                    frmMain.muiConferenceRoom.Enabled = True
                Case 143
                    frmMain.mnuFinancialAnalysis.Enabled = True
                Case 144
                    frmMain.muiUpdateIntentLetter.Enabled = True
                Case 145
                    frmMain.MenuCreditManager.Enabled = True
                Case 146
                    frmMain.MenuDefectRecord.Enabled = True
                Case 147
                    frmMain.MenuDefectRecordAdd.Enabled = True
                Case 148
                    frmMain.MenuDefectRecordEdit.Enabled = True
                Case 149
                    frmMain.MenuContractManage.Enabled = True
                Case 150
                    frmMain.MenuProjectExp.Enabled = True
                Case 151
                    frmMain.MenuQueryProjectExpandDate.Enabled = True
                Case 152
                    frmMain.MenuReviewGuarantee.Enabled = True
                Case 155
                    frmMain.mnuBackFee.Enabled = True
            End Select
        Next

        If wsPermission.IsFixed(UserName, htfServerPermission.FixedRoleEnum.Administrators, 0) Or _
           wsPermission.IsFixed(UserName, htfServerPermission.FixedRoleEnum.Security, 0) Then
            frmMain.MnItemRight.Enabled = True
        Else
            frmMain.MnItemRight.Enabled = False
        End If

        frmMain.StatusBarPanel3.Text = "操作员：" & UserName
        frmMain.StatusBarPanel4.Text = " 日期： " & gWs.GetSysTime.Date
    End Sub
End Module
