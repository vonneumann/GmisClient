'工作流公共处理类
Public Class Workflow

    '分配项目角色人员
    Public Shared Function AssignTaskAttendee(ByVal ProjectCode As String, ByVal RoleID As String, ByVal AttendeePerson As String) As String

        Dim dsStaffRole, dsConsignAttendee As DataSet
        Dim strSql As String
        Dim i As Integer
        Dim Consigner As String


        '获取指定角色、指定人员的受托人,判断是否办理委托
        dsStaffRole = gWs.GetStaffRole(RoleID, AttendeePerson)

        If dsStaffRole.Tables(0).Rows.Count > 0 Then
            Consigner = Trim(IIf(IsDBNull(dsStaffRole.Tables(0).Rows(0).Item("consigner")), "", dsStaffRole.Tables(0).Rows(0).Item("consigner")))
        End If


        '如果办理了委托,将受托人作为参与人员,并将原委托人填入参与人表
        strSql = "{project_code=" & "'" & ProjectCode & "'" & " and role_id=" & "'" & RoleID & "'}"
        dsConsignAttendee = gWs.GetProjectTaskAttendeeInfo(strSql)

        If Consigner <> "" Then

            For i = 0 To dsConsignAttendee.Tables(0).Rows.Count - 1
                dsConsignAttendee.Tables(0).Rows(i).Item("attend_person") = Consigner
                dsConsignAttendee.Tables(0).Rows(i).Item("Consigner") = AttendeePerson
            Next


        Else
            '否则,将指定人员作为参与人员

            For i = 0 To dsConsignAttendee.Tables(0).Rows.Count - 1
                dsConsignAttendee.Tables(0).Rows(i).Item("attend_person") = AttendeePerson
            Next

        End If

        Return gWs.UpdateProjectTaskAttendee(dsConsignAttendee)

    End Function

    '获取实际参与人
    Public Shared Function GetRealTaskAttendee(ByVal RoleID As String, ByVal AttendeePerson As String) As String
        Dim dsStaffRole, dsConsignAttendee As DataSet
        Dim strSql As String
        Dim i As Integer
        Dim Consigner As String


        '获取指定角色、指定人员的受托人,判断是否办理委托
        dsStaffRole = gWs.GetStaffRole(RoleID, AttendeePerson)

        If dsStaffRole.Tables(0).Rows.Count > 0 Then
            Consigner = Trim(IIf(IsDBNull(dsStaffRole.Tables(0).Rows(0).Item("consigner")), "", dsStaffRole.Tables(0).Rows(0).Item("consigner")))
        End If

        '如果办理了委托，返回受托人
        If Consigner <> "" Then
            Return Consigner

            '否则返回，指定人员
        Else
            Return AttendeePerson
        End If
    End Function

End Class
