<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaymentForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentForm))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.frmPaymentFormBTNSave = New DevExpress.XtraEditors.SimpleButton()
        Me.frmPaymentFormPrintBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DateEdit5 = New DevExpress.XtraEditors.DateEdit()
        Me.frmPaymentFormDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.frmPaymentFormReceiptNo = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit5.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmPaymentFormDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmPaymentFormReceiptNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.LayoutControl1.Controls.Add(Me.DateEdit5)
        Me.LayoutControl1.Controls.Add(Me.frmPaymentFormBTNSave)
        Me.LayoutControl1.Controls.Add(Me.frmPaymentFormPrintBTN)
        Me.LayoutControl1.Controls.Add(Me.TextEdit2)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(324, 240)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'frmPaymentFormBTNSave
        '
        Me.frmPaymentFormBTNSave.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmPaymentFormBTNSave.Appearance.Options.UseFont = True
        Me.frmPaymentFormBTNSave.Location = New System.Drawing.Point(12, 182)
        Me.frmPaymentFormBTNSave.Name = "frmPaymentFormBTNSave"
        Me.frmPaymentFormBTNSave.Size = New System.Drawing.Size(300, 30)
        Me.frmPaymentFormBTNSave.StyleController = Me.LayoutControl1
        Me.frmPaymentFormBTNSave.TabIndex = 7
        Me.frmPaymentFormBTNSave.Text = "SAVE"
        '
        'frmPaymentFormPrintBTN
        '
        Me.frmPaymentFormPrintBTN.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmPaymentFormPrintBTN.Appearance.Options.UseFont = True
        Me.frmPaymentFormPrintBTN.ImageOptions.Image = CType(resources.GetObject("frmPaymentFormPrintBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.frmPaymentFormPrintBTN.Location = New System.Drawing.Point(184, 12)
        Me.frmPaymentFormPrintBTN.Name = "frmPaymentFormPrintBTN"
        Me.frmPaymentFormPrintBTN.Size = New System.Drawing.Size(128, 36)
        Me.frmPaymentFormPrintBTN.StyleController = Me.LayoutControl1
        Me.frmPaymentFormPrintBTN.TabIndex = 6
        Me.frmPaymentFormPrintBTN.Text = "PRINT"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(87, 94)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Size = New System.Drawing.Size(223, 32)
        Me.TextEdit2.StyleController = Me.LayoutControl1
        Me.TextEdit2.TabIndex = 5
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.frmPaymentFormDate, Me.LayoutControlItem13, Me.frmPaymentFormReceiptNo, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(324, 240)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TextEdit2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(304, 40)
        Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlItem2.Text = "DESCRIPTION"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(68, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.frmPaymentFormPrintBTN
        Me.LayoutControlItem3.Location = New System.Drawing.Point(172, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(132, 40)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.frmPaymentFormBTNSave
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 170)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(304, 34)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 160)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(304, 10)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'DateEdit5
        '
        Me.DateEdit5.EditValue = Nothing
        Me.DateEdit5.Location = New System.Drawing.Point(164, 134)
        Me.DateEdit5.Name = "DateEdit5"
        Me.DateEdit5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit5.Properties.Appearance.Options.UseFont = True
        Me.DateEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit5.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit5.Size = New System.Drawing.Size(146, 32)
        Me.DateEdit5.StyleController = Me.LayoutControl1
        Me.DateEdit5.TabIndex = 15
        '
        'frmPaymentFormDate
        '
        Me.frmPaymentFormDate.Control = Me.DateEdit5
        Me.frmPaymentFormDate.Location = New System.Drawing.Point(119, 120)
        Me.frmPaymentFormDate.Name = "frmPaymentFormDate"
        Me.frmPaymentFormDate.Size = New System.Drawing.Size(185, 40)
        Me.frmPaymentFormDate.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.frmPaymentFormDate.Text = "DATE"
        Me.frmPaymentFormDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.frmPaymentFormDate.TextSize = New System.Drawing.Size(26, 13)
        Me.frmPaymentFormDate.TextToControlDistance = 5
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(47, 54)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(263, 32)
        Me.ComboBoxEdit1.StyleController = Me.LayoutControl1
        Me.ComboBoxEdit1.TabIndex = 16
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.ComboBoxEdit1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(304, 40)
        Me.LayoutControlItem13.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlItem13.Text = "NAME"
        Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(28, 13)
        Me.LayoutControlItem13.TextToControlDistance = 5
        '
        'frmPaymentFormReceiptNo
        '
        Me.frmPaymentFormReceiptNo.AllowHotTrack = False
        Me.frmPaymentFormReceiptNo.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmPaymentFormReceiptNo.AppearanceItemCaption.Options.UseFont = True
        Me.frmPaymentFormReceiptNo.Location = New System.Drawing.Point(0, 0)
        Me.frmPaymentFormReceiptNo.Name = "frmPaymentFormReceiptNo"
        Me.frmPaymentFormReceiptNo.Size = New System.Drawing.Size(172, 40)
        Me.frmPaymentFormReceiptNo.Text = "JNET20240501"
        Me.frmPaymentFormReceiptNo.TextSize = New System.Drawing.Size(92, 16)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 120)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(119, 40)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 204)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(304, 16)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 240)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmPaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPaymentForm"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit5.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmPaymentFormDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmPaymentFormReceiptNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents frmPaymentFormBTNSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents frmPaymentFormPrintBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DateEdit5 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents frmPaymentFormDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents frmPaymentFormReceiptNo As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
End Class
