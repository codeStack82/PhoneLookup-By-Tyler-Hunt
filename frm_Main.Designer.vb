<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_FriendsList = New System.Windows.Forms.Label()
        Me.grp_SearchGroupBox = New System.Windows.Forms.GroupBox()
        Me.lbl_Search = New System.Windows.Forms.Label()
        Me.cbo_FriendsList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_DisplayBox = New System.Windows.Forms.ListBox()
        Me.AddNewEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_SearchBox = New System.Windows.Forms.TextBox()
        Me.lbl_AddNew = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_Num = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.lbl_Num = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grp_SearchGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SearchToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 38)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchListToolStripMenuItem, Me.AddNewEntryToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(111, 36)
        Me.SearchToolStripMenuItem.Text = "&Options"
        '
        'SearchListToolStripMenuItem
        '
        Me.SearchListToolStripMenuItem.Name = "SearchListToolStripMenuItem"
        Me.SearchListToolStripMenuItem.Size = New System.Drawing.Size(271, 38)
        Me.SearchListToolStripMenuItem.Text = "&Search List"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMeToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(92, 36)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'AboutMeToolStripMenuItem
        '
        Me.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem"
        Me.AboutMeToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.AboutMeToolStripMenuItem.Text = "About &Me"
        '
        'lbl_FriendsList
        '
        Me.lbl_FriendsList.AutoSize = True
        Me.lbl_FriendsList.Location = New System.Drawing.Point(6, 34)
        Me.lbl_FriendsList.Name = "lbl_FriendsList"
        Me.lbl_FriendsList.Size = New System.Drawing.Size(246, 31)
        Me.lbl_FriendsList.TabIndex = 2
        Me.lbl_FriendsList.Text = "Select from the List"
        '
        'grp_SearchGroupBox
        '
        Me.grp_SearchGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_SearchGroupBox.Controls.Add(Me.lbl_Num)
        Me.grp_SearchGroupBox.Controls.Add(Me.lbl_Name)
        Me.grp_SearchGroupBox.Controls.Add(Me.txt_Num)
        Me.grp_SearchGroupBox.Controls.Add(Me.txt_Name)
        Me.grp_SearchGroupBox.Controls.Add(Me.lbl_AddNew)
        Me.grp_SearchGroupBox.Controls.Add(Me.lbl_Search)
        Me.grp_SearchGroupBox.Controls.Add(Me.txt_SearchBox)
        Me.grp_SearchGroupBox.Controls.Add(Me.cbo_FriendsList)
        Me.grp_SearchGroupBox.Controls.Add(Me.lbl_FriendsList)
        Me.grp_SearchGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_SearchGroupBox.Location = New System.Drawing.Point(12, 56)
        Me.grp_SearchGroupBox.Name = "grp_SearchGroupBox"
        Me.grp_SearchGroupBox.Size = New System.Drawing.Size(666, 430)
        Me.grp_SearchGroupBox.TabIndex = 3
        Me.grp_SearchGroupBox.TabStop = False
        Me.grp_SearchGroupBox.Text = "Search Information"
        '
        'lbl_Search
        '
        Me.lbl_Search.AutoSize = True
        Me.lbl_Search.Enabled = False
        Me.lbl_Search.Location = New System.Drawing.Point(6, 148)
        Me.lbl_Search.Name = "lbl_Search"
        Me.lbl_Search.Size = New System.Drawing.Size(215, 31)
        Me.lbl_Search.TabIndex = 5
        Me.lbl_Search.Text = "Search by Name"
        '
        'cbo_FriendsList
        '
        Me.cbo_FriendsList.FormattingEnabled = True
        Me.cbo_FriendsList.Location = New System.Drawing.Point(22, 68)
        Me.cbo_FriendsList.Name = "cbo_FriendsList"
        Me.cbo_FriendsList.Size = New System.Drawing.Size(342, 39)
        Me.cbo_FriendsList.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 4
        '
        'lst_DisplayBox
        '
        Me.lst_DisplayBox.Enabled = False
        Me.lst_DisplayBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_DisplayBox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lst_DisplayBox.FormattingEnabled = True
        Me.lst_DisplayBox.ItemHeight = 31
        Me.lst_DisplayBox.Location = New System.Drawing.Point(12, 492)
        Me.lst_DisplayBox.Name = "lst_DisplayBox"
        Me.lst_DisplayBox.Size = New System.Drawing.Size(665, 97)
        Me.lst_DisplayBox.TabIndex = 5
        '
        'AddNewEntryToolStripMenuItem
        '
        Me.AddNewEntryToolStripMenuItem.Name = "AddNewEntryToolStripMenuItem"
        Me.AddNewEntryToolStripMenuItem.Size = New System.Drawing.Size(271, 38)
        Me.AddNewEntryToolStripMenuItem.Text = "&Add new entry"
        '
        'txt_SearchBox
        '
        Me.txt_SearchBox.Enabled = False
        Me.txt_SearchBox.Location = New System.Drawing.Point(22, 182)
        Me.txt_SearchBox.Name = "txt_SearchBox"
        Me.txt_SearchBox.Size = New System.Drawing.Size(342, 38)
        Me.txt_SearchBox.TabIndex = 4
        '
        'lbl_AddNew
        '
        Me.lbl_AddNew.AutoSize = True
        Me.lbl_AddNew.Enabled = False
        Me.lbl_AddNew.Location = New System.Drawing.Point(6, 270)
        Me.lbl_AddNew.Name = "lbl_AddNew"
        Me.lbl_AddNew.Size = New System.Drawing.Size(221, 31)
        Me.lbl_AddNew.TabIndex = 6
        Me.lbl_AddNew.Text = "Add new Contact"
        '
        'txt_Name
        '
        Me.txt_Name.Enabled = False
        Me.txt_Name.Location = New System.Drawing.Point(112, 313)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(306, 38)
        Me.txt_Name.TabIndex = 7
        '
        'txt_Num
        '
        Me.txt_Num.Enabled = False
        Me.txt_Num.Location = New System.Drawing.Point(221, 377)
        Me.txt_Num.Name = "txt_Num"
        Me.txt_Num.Size = New System.Drawing.Size(306, 38)
        Me.txt_Num.TabIndex = 8
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Enabled = False
        Me.lbl_Name.Location = New System.Drawing.Point(6, 316)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(86, 31)
        Me.lbl_Name.TabIndex = 9
        Me.lbl_Name.Text = "Name"
        '
        'lbl_Num
        '
        Me.lbl_Num.AutoSize = True
        Me.lbl_Num.Enabled = False
        Me.lbl_Num.Location = New System.Drawing.Point(6, 380)
        Me.lbl_Num.Name = "lbl_Num"
        Me.lbl_Num.Size = New System.Drawing.Size(195, 31)
        Me.lbl_Num.TabIndex = 10
        Me.lbl_Num.Text = "Phone Number"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 615)
        Me.Controls.Add(Me.lst_DisplayBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grp_SearchGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phone Lookup By Tyler Hunt"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grp_SearchGroupBox.ResumeLayout(False)
        Me.grp_SearchGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutMeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_FriendsList As Label
    Friend WithEvents grp_SearchGroupBox As GroupBox
    Friend WithEvents lbl_Search As Label
    Friend WithEvents cbo_FriendsList As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lst_DisplayBox As ListBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_Num As Label
    Friend WithEvents lbl_Name As Label
    Friend WithEvents txt_Num As TextBox
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents lbl_AddNew As Label
    Friend WithEvents txt_SearchBox As TextBox
End Class
