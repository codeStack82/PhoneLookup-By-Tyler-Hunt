Public Class frm_Main

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Name As String



        'Add array contents to comboBox
        For Each Name In list_people
            cbo_FriendsList.Items.Add(Name)
        Next

        'Set Combo to -1
        Me.cbo_FriendsList.SelectedIndex = -1
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        frm_AboutBox.Show()
    End Sub

    Private Sub cbo_FriendsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_FriendsList.SelectedIndexChanged

        Dim index As Integer = cbo_FriendsList.SelectedIndex
        Dim outputName As String = String.Empty
        Dim outputNumber As String = String.Empty
        Dim outputInnerMessage As String = "'s phone number is "
        Dim outputMesssage As String = String.Empty

        'clear any previous text
        clearOutputDisplay()

        If index <> -1 Then
            'Get name and number
            outputName = str_People(index)
            outputNumber = str_PhoneNumbers(index)

            'build message
            outputMesssage = outputName + outputInnerMessage + outputNumber

            'add message to output
            lst_DisplayBox.Items.Add(outputMesssage)
        End If
    End Sub

    Sub clearOutputDisplay()
        lst_DisplayBox.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SearchListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchListToolStripMenuItem.Click
        With txt_SearchBox
            .Enabled = True
            .Focus()
        End With

        lbl_Search.Enabled = True
    End Sub

    Private Sub txt_SearchBox_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchBox.TextChanged
        MsgBox("tet")
    End Sub

    Private Sub AddNewEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewEntryToolStripMenuItem.Click
        With txt_Name
            .Enabled = True
        End With
        With txt_Num
            .Enabled = True
        End With
        With lbl_Name
            .Enabled = True
        End With
        With lbl_Num
            .Enabled = True
        End With
        With lbl_AddNew
            .Enabled = True
        End With
    End Sub
End Class
