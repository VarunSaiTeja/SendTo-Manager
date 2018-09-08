<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.refresh_srt = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.change_icon = New System.Windows.Forms.Button()
        Me.delete_srt = New System.Windows.Forms.Button()
        Me.add_folder = New System.Windows.Forms.Button()
        Me.add_app = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rename_srt = New System.Windows.Forms.Button()
        Me.SrtTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatsappToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TelegramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaytmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayPalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SrtIcon = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SrtIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 78)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(409, 229)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'refresh_srt
        '
        Me.refresh_srt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refresh_srt.Location = New System.Drawing.Point(333, 322)
        Me.refresh_srt.Name = "refresh_srt"
        Me.refresh_srt.Size = New System.Drawing.Size(75, 23)
        Me.refresh_srt.TabIndex = 1
        Me.refresh_srt.Text = "Refresh"
        Me.refresh_srt.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Title.Location = New System.Drawing.Point(125, 24)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(170, 28)
        Me.Title.TabIndex = 3
        Me.Title.Text = "SendTo Manager"
        '
        'change_icon
        '
        Me.change_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.change_icon.Location = New System.Drawing.Point(31, 400)
        Me.change_icon.Name = "change_icon"
        Me.change_icon.Size = New System.Drawing.Size(81, 23)
        Me.change_icon.TabIndex = 5
        Me.change_icon.Text = "Change Icon"
        Me.change_icon.UseVisualStyleBackColor = True
        Me.change_icon.Visible = False
        '
        'delete_srt
        '
        Me.delete_srt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_srt.Location = New System.Drawing.Point(31, 340)
        Me.delete_srt.Name = "delete_srt"
        Me.delete_srt.Size = New System.Drawing.Size(81, 23)
        Me.delete_srt.TabIndex = 6
        Me.delete_srt.Text = "Delete"
        Me.delete_srt.UseVisualStyleBackColor = True
        Me.delete_srt.Visible = False
        '
        'add_folder
        '
        Me.add_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_folder.Location = New System.Drawing.Point(333, 364)
        Me.add_folder.Name = "add_folder"
        Me.add_folder.Size = New System.Drawing.Size(75, 23)
        Me.add_folder.TabIndex = 10
        Me.add_folder.Text = "Add Folder"
        Me.add_folder.UseVisualStyleBackColor = True
        '
        'add_app
        '
        Me.add_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_app.Location = New System.Drawing.Point(333, 406)
        Me.add_app.Name = "add_app"
        Me.add_app.Size = New System.Drawing.Size(75, 23)
        Me.add_app.TabIndex = 11
        Me.add_app.Text = "Add App"
        Me.add_app.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'rename_srt
        '
        Me.rename_srt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rename_srt.Location = New System.Drawing.Point(31, 370)
        Me.rename_srt.Name = "rename_srt"
        Me.rename_srt.Size = New System.Drawing.Size(81, 23)
        Me.rename_srt.TabIndex = 12
        Me.rename_srt.Text = "Rename"
        Me.rename_srt.UseVisualStyleBackColor = True
        Me.rename_srt.Visible = False
        '
        'SrtTitle
        '
        Me.SrtTitle.AutoSize = True
        Me.SrtTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SrtTitle.Location = New System.Drawing.Point(27, 310)
        Me.SrtTitle.Name = "SrtTitle"
        Me.SrtTitle.Size = New System.Drawing.Size(73, 21)
        Me.SrtTitle.TabIndex = 13
        Me.SrtTitle.Text = "Shortcut"
        Me.SrtTitle.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactToolStripMenuItem, Me.DonateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(430, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhatsappToolStripMenuItem, Me.TelegramToolStripMenuItem, Me.YouTubeToolStripMenuItem})
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'WhatsappToolStripMenuItem
        '
        Me.WhatsappToolStripMenuItem.Image = Global.SendTo_Manager.My.Resources.Resources.whatsapp
        Me.WhatsappToolStripMenuItem.Name = "WhatsappToolStripMenuItem"
        Me.WhatsappToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WhatsappToolStripMenuItem.Text = "Whatsapp"
        '
        'TelegramToolStripMenuItem
        '
        Me.TelegramToolStripMenuItem.Image = Global.SendTo_Manager.My.Resources.Resources.telegram
        Me.TelegramToolStripMenuItem.Name = "TelegramToolStripMenuItem"
        Me.TelegramToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TelegramToolStripMenuItem.Text = "Telegram"
        '
        'YouTubeToolStripMenuItem
        '
        Me.YouTubeToolStripMenuItem.Image = Global.SendTo_Manager.My.Resources.Resources.youtube
        Me.YouTubeToolStripMenuItem.Name = "YouTubeToolStripMenuItem"
        Me.YouTubeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.YouTubeToolStripMenuItem.Text = "YouTube"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaytmToolStripMenuItem, Me.UPIToolStripMenuItem, Me.PayPalToolStripMenuItem})
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'PaytmToolStripMenuItem
        '
        Me.PaytmToolStripMenuItem.Image = Global.SendTo_Manager.My.Resources.Resources.paytm
        Me.PaytmToolStripMenuItem.Name = "PaytmToolStripMenuItem"
        Me.PaytmToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PaytmToolStripMenuItem.Text = "Paytm"
        '
        'UPIToolStripMenuItem
        '
        Me.UPIToolStripMenuItem.Image = Global.SendTo_Manager.My.Resources.Resources.upi
        Me.UPIToolStripMenuItem.Name = "UPIToolStripMenuItem"
        Me.UPIToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UPIToolStripMenuItem.Text = "UPI"
        '
        'PayPalToolStripMenuItem
        '
        Me.PayPalToolStripMenuItem.Image = Global.SendTo_Manager.My.Resources.Resources.paypal
        Me.PayPalToolStripMenuItem.Name = "PayPalToolStripMenuItem"
        Me.PayPalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PayPalToolStripMenuItem.Text = "PayPal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "By Varun"
        '
        'SrtIcon
        '
        Me.SrtIcon.Location = New System.Drawing.Point(140, 354)
        Me.SrtIcon.Name = "SrtIcon"
        Me.SrtIcon.Size = New System.Drawing.Size(55, 55)
        Me.SrtIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.SrtIcon.TabIndex = 2
        Me.SrtIcon.TabStop = False
        Me.SrtIcon.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(430, 440)
        Me.Controls.Add(Me.add_app)
        Me.Controls.Add(Me.add_folder)
        Me.Controls.Add(Me.refresh_srt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SrtTitle)
        Me.Controls.Add(Me.rename_srt)
        Me.Controls.Add(Me.delete_srt)
        Me.Controls.Add(Me.change_icon)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.SrtIcon)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SendTo Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SrtIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents refresh_srt As Button
    Friend WithEvents Title As Label
    Friend WithEvents SrtIcon As PictureBox
    Friend WithEvents change_icon As Button
    Friend WithEvents delete_srt As Button
    Friend WithEvents add_folder As Button
    Friend WithEvents add_app As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rename_srt As Button
    Friend WithEvents SrtTitle As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhatsappToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TelegramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaytmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayPalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YouTubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
