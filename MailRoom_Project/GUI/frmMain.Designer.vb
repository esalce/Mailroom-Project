<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim CarrierLabel As System.Windows.Forms.Label
        Dim RecieverInitialLabel As System.Windows.Forms.Label
        Dim OversizeLabel As System.Windows.Forms.Label
        Dim RecieveDateLabel As System.Windows.Forms.Label
        Dim PickedUpLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.chkPickedUp = New System.Windows.Forms.CheckBox()
        Me.PackageInfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MailRoomMainDataSet = New MailRoom_Project.MailRoomMainDataSet()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.ckOversize = New System.Windows.Forms.CheckBox()
        Me.txtHandler = New System.Windows.Forms.TextBox()
        Me.txtDelivCompany = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEMail = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.lblDorm = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvLog = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PackageInfoTableAdapter1 = New MailRoom_Project.MailRoomMainDataSetTableAdapters.PackageInfoTableAdapter()
        Me.TableAdapterManager1 = New MailRoom_Project.MailRoomMainDataSetTableAdapters.TableAdapterManager()
        Me.btnExp = New System.Windows.Forms.Button()
        CarrierLabel = New System.Windows.Forms.Label()
        RecieverInitialLabel = New System.Windows.Forms.Label()
        OversizeLabel = New System.Windows.Forms.Label()
        RecieveDateLabel = New System.Windows.Forms.Label()
        PickedUpLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PackageInfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MailRoomMainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarrierLabel
        '
        CarrierLabel.AutoSize = True
        CarrierLabel.Location = New System.Drawing.Point(12, 42)
        CarrierLabel.Name = "CarrierLabel"
        CarrierLabel.Size = New System.Drawing.Size(40, 13)
        CarrierLabel.TabIndex = 60
        CarrierLabel.Text = "Carrier:"
        '
        'RecieverInitialLabel
        '
        RecieverInitialLabel.AutoSize = True
        RecieverInitialLabel.Location = New System.Drawing.Point(12, 98)
        RecieverInitialLabel.Name = "RecieverInitialLabel"
        RecieverInitialLabel.Size = New System.Drawing.Size(80, 13)
        RecieverInitialLabel.TabIndex = 61
        RecieverInitialLabel.Text = "Reciever Initial:"
        '
        'OversizeLabel
        '
        OversizeLabel.AutoSize = True
        OversizeLabel.Location = New System.Drawing.Point(12, 162)
        OversizeLabel.Name = "OversizeLabel"
        OversizeLabel.Size = New System.Drawing.Size(97, 13)
        OversizeLabel.TabIndex = 62
        OversizeLabel.Text = "Oversize Package:"
        '
        'RecieveDateLabel
        '
        RecieveDateLabel.AutoSize = True
        RecieveDateLabel.Location = New System.Drawing.Point(9, 261)
        RecieveDateLabel.Name = "RecieveDateLabel"
        RecieveDateLabel.Size = New System.Drawing.Size(76, 13)
        RecieveDateLabel.TabIndex = 63
        RecieveDateLabel.Text = "Recieve Date:"
        '
        'PickedUpLabel
        '
        PickedUpLabel.AutoSize = True
        PickedUpLabel.Location = New System.Drawing.Point(12, 203)
        PickedUpLabel.Name = "PickedUpLabel"
        PickedUpLabel.Size = New System.Drawing.Size(60, 13)
        PickedUpLabel.TabIndex = 64
        PickedUpLabel.Text = "Picked Up:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExp)
        Me.SplitContainer1.Panel1.Controls.Add(PickedUpLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkPickedUp)
        Me.SplitContainer1.Panel1.Controls.Add(RecieveDateLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDate)
        Me.SplitContainer1.Panel1.Controls.Add(OversizeLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ckOversize)
        Me.SplitContainer1.Panel1.Controls.Add(RecieverInitialLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHandler)
        Me.SplitContainer1.Panel1.Controls.Add(CarrierLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDelivCompany)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSend)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvLog)
        Me.SplitContainer1.Size = New System.Drawing.Size(1436, 374)
        Me.SplitContainer1.SplitterDistance = 333
        Me.SplitContainer1.TabIndex = 0
        '
        'chkPickedUp
        '
        Me.chkPickedUp.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PackageInfoBindingSource1, "PickedUp", True))
        Me.chkPickedUp.Location = New System.Drawing.Point(76, 198)
        Me.chkPickedUp.Name = "chkPickedUp"
        Me.chkPickedUp.Size = New System.Drawing.Size(29, 24)
        Me.chkPickedUp.TabIndex = 65
        Me.chkPickedUp.UseVisualStyleBackColor = True
        '
        'PackageInfoBindingSource1
        '
        Me.PackageInfoBindingSource1.DataMember = "PackageInfo"
        Me.PackageInfoBindingSource1.DataSource = Me.MailRoomMainDataSet
        '
        'MailRoomMainDataSet
        '
        Me.MailRoomMainDataSet.DataSetName = "MailRoomMainDataSet"
        Me.MailRoomMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpDate
        '
        Me.dtpDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PackageInfoBindingSource1, "RecieveDate", True))
        Me.dtpDate.Location = New System.Drawing.Point(12, 280)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 64
        '
        'ckOversize
        '
        Me.ckOversize.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PackageInfoBindingSource1, "Oversize", True))
        Me.ckOversize.Location = New System.Drawing.Point(109, 157)
        Me.ckOversize.Name = "ckOversize"
        Me.ckOversize.Size = New System.Drawing.Size(21, 24)
        Me.ckOversize.TabIndex = 63
        Me.ckOversize.UseVisualStyleBackColor = True
        '
        'txtHandler
        '
        Me.txtHandler.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageInfoBindingSource1, "RecieverInitial", True))
        Me.txtHandler.Location = New System.Drawing.Point(12, 122)
        Me.txtHandler.Name = "txtHandler"
        Me.txtHandler.Size = New System.Drawing.Size(100, 20)
        Me.txtHandler.TabIndex = 62
        '
        'txtDelivCompany
        '
        Me.txtDelivCompany.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageInfoBindingSource1, "Carrier", True))
        Me.txtDelivCompany.Location = New System.Drawing.Point(12, 67)
        Me.txtDelivCompany.Name = "txtDelivCompany"
        Me.txtDelivCompany.Size = New System.Drawing.Size(100, 20)
        Me.txtDelivCompany.TabIndex = 61
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(241, 341)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 22)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(156, 341)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(79, 22)
        Me.btnSend.TabIndex = 57
        Me.btnSend.Text = "Send &Email"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblEMail)
        Me.GroupBox1.Controls.Add(Me.lblRoom)
        Me.GroupBox1.Controls.Add(Me.lblDorm)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(156, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 250)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.Color.LightGray
        Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageInfoBindingSource1, "Phone", True))
        Me.lblPhone.Location = New System.Drawing.Point(20, 209)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(125, 23)
        Me.lblPhone.TabIndex = 18
        '
        'lblEMail
        '
        Me.lblEMail.BackColor = System.Drawing.Color.LightGray
        Me.lblEMail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageInfoBindingSource1, "EMail", True))
        Me.lblEMail.Location = New System.Drawing.Point(20, 174)
        Me.lblEMail.Name = "lblEMail"
        Me.lblEMail.Size = New System.Drawing.Size(125, 23)
        Me.lblEMail.TabIndex = 17
        '
        'lblRoom
        '
        Me.lblRoom.BackColor = System.Drawing.Color.LightGray
        Me.lblRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageInfoBindingSource1, "Room", True))
        Me.lblRoom.Location = New System.Drawing.Point(20, 140)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(125, 23)
        Me.lblRoom.TabIndex = 16
        '
        'lblDorm
        '
        Me.lblDorm.BackColor = System.Drawing.Color.LightGray
        Me.lblDorm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDorm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageInfoBindingSource1, "Dorm", True))
        Me.lblDorm.Location = New System.Drawing.Point(20, 106)
        Me.lblDorm.Name = "lblDorm"
        Me.lblDorm.Size = New System.Drawing.Size(125, 23)
        Me.lblDorm.TabIndex = 15
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.LightGray
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageInfoBindingSource1, "StudentName", True))
        Me.lblName.Location = New System.Drawing.Point(20, 72)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(125, 23)
        Me.lblName.TabIndex = 14
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.LightGray
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageInfoBindingSource1, "StudentID", True))
        Me.lblID.Location = New System.Drawing.Point(20, 40)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(125, 23)
        Me.lblID.TabIndex = 13
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(20, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(91, 20)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Se&ach Students"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(333, 24)
        Me.MenuStrip1.TabIndex = 66
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogout})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(112, 22)
        Me.mnuLogout.Text = "Logout"
        '
        'dgvLog
        '
        Me.dgvLog.AutoGenerateColumns = False
        Me.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2})
        Me.dgvLog.DataSource = Me.PackageInfoBindingSource1
        Me.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLog.Location = New System.Drawing.Point(0, 0)
        Me.dgvLog.Name = "dgvLog"
        Me.dgvLog.Size = New System.Drawing.Size(1099, 374)
        Me.dgvLog.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PackageID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PackageID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StudentName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StudentName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Dorm"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dorm"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Room"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Room"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "EMail"
        Me.DataGridViewTextBoxColumn6.HeaderText = "EMail"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Carrier"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Carrier"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "RecieverInitial"
        Me.DataGridViewTextBoxColumn9.HeaderText = "RecieverInitial"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "RecieveDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "RecieveDate"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Oversize"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Oversize"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "PickedUp"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "PickedUp"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(194, 249)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 22)
        Me.btnAdd.TabIndex = 58
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'PackageInfoTableAdapter1
        '
        Me.PackageInfoTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PackageInfoTableAdapter = Me.PackageInfoTableAdapter1
        Me.TableAdapterManager1.tblConfirm_localTableAdapter = Nothing
        Me.TableAdapterManager1.tblConfirmTableAdapter = Nothing
        Me.TableAdapterManager1.tblPackageTableAdapter = Nothing
        Me.TableAdapterManager1.tblRole_localTableAdapter = Nothing
        Me.TableAdapterManager1.tblRoleTableAdapter = Nothing
        Me.TableAdapterManager1.tblStudentTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = MailRoom_Project.MailRoomMainDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnExp
        '
        Me.btnExp.Location = New System.Drawing.Point(76, 341)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(75, 23)
        Me.btnExp.TabIndex = 67
        Me.btnExp.Text = "Ex&port"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 374)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PackageInfoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MailRoomMainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents PackageIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DormDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarrierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiverInitialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OversizeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PickedUpDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MailRoomMainDataSet As MailRoom_Project.MailRoomMainDataSet
    Friend WithEvents PackageInfoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PackageInfoTableAdapter1 As MailRoom_Project.MailRoomMainDataSetTableAdapters.PackageInfoTableAdapter
    Friend WithEvents TableAdapterManager1 As MailRoom_Project.MailRoomMainDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvLog As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents chkPickedUp As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckOversize As System.Windows.Forms.CheckBox
    Friend WithEvents txtHandler As System.Windows.Forms.TextBox
    Friend WithEvents txtDelivCompany As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblEMail As System.Windows.Forms.Label
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents lblDorm As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExp As System.Windows.Forms.Button
End Class
