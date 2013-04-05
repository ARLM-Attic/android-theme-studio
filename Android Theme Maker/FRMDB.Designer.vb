<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDB
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Brn_reload = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lst_apps = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SearchTextBox1 = New WindowsFormsAero.SearchTextBox()
        Me.Op_APP = New VIBlend.WinForms.Controls.vRadioButton()
        Me.OP_PACK = New VIBlend.WinForms.Controls.vRadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Brn_reload)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 402)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 40)
        Me.Panel1.TabIndex = 1
        '
        'Brn_reload
        '
        Me.Brn_reload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Brn_reload.BackgroundImage = Global.Android_Theme_Studio.My.Resources.Resources.reload
        Me.Brn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Brn_reload.Location = New System.Drawing.Point(73, 13)
        Me.Brn_reload.Name = "Brn_reload"
        Me.Brn_reload.Size = New System.Drawing.Size(24, 24)
        Me.Brn_reload.TabIndex = 3
        Me.Brn_reload.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(4, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(322, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lst_apps
        '
        Me.lst_apps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_apps.CheckBoxes = True
        Me.lst_apps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lst_apps.FullRowSelect = True
        Me.lst_apps.Location = New System.Drawing.Point(5, 51)
        Me.lst_apps.MultiSelect = False
        Me.lst_apps.Name = "lst_apps"
        Me.lst_apps.Size = New System.Drawing.Size(393, 345)
        Me.lst_apps.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lst_apps.TabIndex = 2
        Me.lst_apps.UseCompatibleStateImageBehavior = False
        Me.lst_apps.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Application Name"
        Me.ColumnHeader1.Width = 129
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Package Name"
        Me.ColumnHeader2.Width = 155
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Is in project?"
        Me.ColumnHeader3.Width = 81
        '
        'SearchTextBox1
        '
        Me.SearchTextBox1.ActiveFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SearchTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.SearchTextBox1.InactiveFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.SearchTextBox1.Location = New System.Drawing.Point(139, 3)
        Me.SearchTextBox1.Name = "SearchTextBox1"
        Me.SearchTextBox1.Size = New System.Drawing.Size(257, 21)
        Me.SearchTextBox1.TabIndex = 3
        '
        'Op_APP
        '
        Me.Op_APP.BackColor = System.Drawing.Color.Transparent
        Me.Op_APP.Checked = True
        Me.Op_APP.Flat = True
        Me.Op_APP.Image = Nothing
        Me.Op_APP.Location = New System.Drawing.Point(4, 25)
        Me.Op_APP.Name = "Op_APP"
        Me.Op_APP.Size = New System.Drawing.Size(156, 24)
        Me.Op_APP.TabIndex = 4
        Me.Op_APP.TabStop = True
        Me.Op_APP.Text = "Search Application Names"
        Me.Op_APP.UseVisualStyleBackColor = False
        Me.Op_APP.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        '
        'OP_PACK
        '
        Me.OP_PACK.BackColor = System.Drawing.Color.Transparent
        Me.OP_PACK.Flat = True
        Me.OP_PACK.Image = Nothing
        Me.OP_PACK.Location = New System.Drawing.Point(166, 25)
        Me.OP_PACK.Name = "OP_PACK"
        Me.OP_PACK.Size = New System.Drawing.Size(224, 24)
        Me.OP_PACK.TabIndex = 0
        Me.OP_PACK.Text = "Search Package Names"
        Me.OP_PACK.UseVisualStyleBackColor = False
        Me.OP_PACK.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        '
        'FRMDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(402, 442)
        Me.Controls.Add(Me.OP_PACK)
        Me.Controls.Add(Me.Op_APP)
        Me.Controls.Add(Me.SearchTextBox1)
        Me.Controls.Add(Me.lst_apps)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(330, 450)
        Me.Name = "FRMDB"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "applications in database"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lst_apps As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Brn_reload As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SearchTextBox1 As WindowsFormsAero.SearchTextBox
    Friend WithEvents Op_APP As VIBlend.WinForms.Controls.vRadioButton
    Friend WithEvents OP_PACK As VIBlend.WinForms.Controls.vRadioButton
End Class
