<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.frmLoginTextEditUsername = New DevExpress.XtraEditors.TextEdit()
        Me.frmLoginTextEditPassword = New DevExpress.XtraEditors.TextEdit()
        Me.frmLoginBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.checkEdit11 = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.frmLoginTextEditUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmLoginTextEditPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LayoutControl2)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(696, 64, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(292, 183)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.frmLoginTextEditUsername)
        Me.LayoutControl2.Controls.Add(Me.frmLoginTextEditPassword)
        Me.LayoutControl2.Controls.Add(Me.frmLoginBTN)
        Me.LayoutControl2.Controls.Add(Me.checkEdit11)
        Me.LayoutControl2.Location = New System.Drawing.Point(12, 12)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(439, 0, 650, 400)
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(268, 159)
        Me.LayoutControl2.TabIndex = 4
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'frmLoginTextEditUsername
        '
        Me.frmLoginTextEditUsername.Location = New System.Drawing.Point(12, 12)
        Me.frmLoginTextEditUsername.Name = "frmLoginTextEditUsername"
        Me.frmLoginTextEditUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmLoginTextEditUsername.Properties.Appearance.Options.UseFont = True
        Me.frmLoginTextEditUsername.Properties.Appearance.Options.UseTextOptions = True
        Me.frmLoginTextEditUsername.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.frmLoginTextEditUsername.Properties.ContextImageOptions.Image = CType(resources.GetObject("frmLoginTextEditUsername.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.frmLoginTextEditUsername.Properties.NullValuePrompt = "Username"
        Me.frmLoginTextEditUsername.Size = New System.Drawing.Size(244, 36)
        Me.frmLoginTextEditUsername.StyleController = Me.LayoutControl2
        Me.frmLoginTextEditUsername.TabIndex = 9
        '
        'frmLoginTextEditPassword
        '
        Me.frmLoginTextEditPassword.Location = New System.Drawing.Point(12, 52)
        Me.frmLoginTextEditPassword.Name = "frmLoginTextEditPassword"
        Me.frmLoginTextEditPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmLoginTextEditPassword.Properties.Appearance.Options.UseFont = True
        Me.frmLoginTextEditPassword.Properties.Appearance.Options.UseTextOptions = True
        Me.frmLoginTextEditPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.frmLoginTextEditPassword.Properties.ContextImageOptions.Image = CType(resources.GetObject("frmLoginTextEditPassword.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.frmLoginTextEditPassword.Properties.NullValuePrompt = "Password"
        Me.frmLoginTextEditPassword.Properties.UseSystemPasswordChar = True
        Me.frmLoginTextEditPassword.Size = New System.Drawing.Size(244, 36)
        Me.frmLoginTextEditPassword.StyleController = Me.LayoutControl2
        Me.frmLoginTextEditPassword.TabIndex = 8
        '
        'frmLoginBTN
        '
        Me.frmLoginBTN.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmLoginBTN.Appearance.Options.UseFont = True
        Me.frmLoginBTN.Location = New System.Drawing.Point(12, 116)
        Me.frmLoginBTN.Name = "frmLoginBTN"
        Me.frmLoginBTN.Size = New System.Drawing.Size(244, 31)
        Me.frmLoginBTN.StyleController = Me.LayoutControl2
        Me.frmLoginBTN.TabIndex = 7
        Me.frmLoginBTN.Text = "SIGN IN"
        '
        'checkEdit11
        '
        Me.checkEdit11.Location = New System.Drawing.Point(12, 92)
        Me.checkEdit11.Name = "checkEdit11"
        Me.checkEdit11.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkEdit11.Properties.Appearance.Options.UseFont = True
        Me.checkEdit11.Properties.Caption = "Keep me signed in"
        Me.checkEdit11.Size = New System.Drawing.Size(244, 20)
        Me.checkEdit11.StyleController = Me.LayoutControl2
        Me.checkEdit11.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem3, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(268, 159)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.checkEdit11
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "layoutControlItem3"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem4.Text = "layoutControlItem3"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.frmLoginBTN
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(79, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(248, 35)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.frmLoginTextEditPassword
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(248, 40)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.frmLoginTextEditUsername
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(248, 40)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(292, 183)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.LayoutControl2
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(272, 163)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 183)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.frmLoginTextEditUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmLoginTextEditPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents checkEdit11 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents frmLoginBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents frmLoginTextEditPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents frmLoginTextEditUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
