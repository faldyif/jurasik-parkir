<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListKendaraan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cari = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListKendaraanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahPetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(343, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(280, 190)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(75, 23)
        Me.Cari.TabIndex = 1
        Me.Cari.Text = "Cari"
        Me.Cari.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.UserToolStripMenuItem, Me.SettingToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(369, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListMemberToolStripMenuItem, Me.ListKendaraanToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ListMemberToolStripMenuItem
        '
        Me.ListMemberToolStripMenuItem.Name = "ListMemberToolStripMenuItem"
        Me.ListMemberToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListMemberToolStripMenuItem.Text = "List Member"
        '
        'ListKendaraanToolStripMenuItem
        '
        Me.ListKendaraanToolStripMenuItem.Name = "ListKendaraanToolStripMenuItem"
        Me.ListKendaraanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListKendaraanToolStripMenuItem.Text = "List Petugas"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'SettingToolStripMenuItem1
        '
        Me.SettingToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahPetugasToolStripMenuItem, Me.TambahMemberToolStripMenuItem})
        Me.SettingToolStripMenuItem1.Name = "SettingToolStripMenuItem1"
        Me.SettingToolStripMenuItem1.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem1.Text = "Setting"
        '
        'TambahPetugasToolStripMenuItem
        '
        Me.TambahPetugasToolStripMenuItem.Name = "TambahPetugasToolStripMenuItem"
        Me.TambahPetugasToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TambahPetugasToolStripMenuItem.Text = "Tambah Petugas"
        '
        'TambahMemberToolStripMenuItem
        '
        Me.TambahMemberToolStripMenuItem.Name = "TambahMemberToolStripMenuItem"
        Me.TambahMemberToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TambahMemberToolStripMenuItem.Text = "Tambah Member"
        '
        'FormListKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 223)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormListKendaraan"
        Me.Text = "FormListKendaraan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cari As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListKendaraanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TambahPetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahMemberToolStripMenuItem As ToolStripMenuItem
End Class
