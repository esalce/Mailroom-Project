<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEMail
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.rtbMessage = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblFrom, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSubject, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFrom, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTo, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSubject, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSend, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rtbMessage, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(586, 473)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFrom.Location = New System.Drawing.Point(103, 0)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(94, 26)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTo.Location = New System.Drawing.Point(103, 26)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(94, 26)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "To:"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubject.Location = New System.Drawing.Point(103, 52)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(94, 26)
        Me.lblSubject.TabIndex = 2
        Me.lblSubject.Text = "Subject:"
        Me.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFrom
        '
        Me.txtFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFrom.Enabled = False
        Me.txtFrom.Location = New System.Drawing.Point(203, 3)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(380, 20)
        Me.txtFrom.TabIndex = 3
        '
        'txtTo
        '
        Me.txtTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTo.Location = New System.Drawing.Point(203, 29)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(380, 20)
        Me.txtTo.TabIndex = 4
        '
        'txtSubject
        '
        Me.txtSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSubject.Location = New System.Drawing.Point(203, 55)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(380, 20)
        Me.txtSubject.TabIndex = 5
        '
        'btnSend
        '
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSend.Location = New System.Drawing.Point(3, 3)
        Me.btnSend.Name = "btnSend"
        Me.TableLayoutPanel1.SetRowSpan(Me.btnSend, 3)
        Me.btnSend.Size = New System.Drawing.Size(94, 72)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'rtbMessage
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.rtbMessage, 3)
        Me.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbMessage.Location = New System.Drawing.Point(3, 81)
        Me.rtbMessage.Name = "rtbMessage"
        Me.TableLayoutPanel1.SetRowSpan(Me.rtbMessage, 3)
        Me.rtbMessage.Size = New System.Drawing.Size(580, 389)
        Me.rtbMessage.TabIndex = 7
        Me.rtbMessage.Text = ""
        '
        'frmEMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 473)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmEMail"
        Me.ShowIcon = False
        Me.Text = "EMail Client"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents rtbMessage As System.Windows.Forms.RichTextBox
End Class
