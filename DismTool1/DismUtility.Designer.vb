<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DismUtility
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DismUtility))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDismLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveOutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DISMHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageXHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BCDToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BCDBootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BCDEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BootSectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OscdImgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numupdn1 = New System.Windows.Forms.NumericUpDown()
        Me.ab6 = New System.Windows.Forms.Button()
        Me.ab7 = New System.Windows.Forms.Button()
        Me.ab5 = New System.Windows.Forms.Button()
        Me.ab4 = New System.Windows.Forms.Button()
        Me.Ab3 = New System.Windows.Forms.Button()
        Me.Ab2 = New System.Windows.Forms.Button()
        Me.Ab1 = New System.Windows.Forms.Button()
        Me.at2 = New System.Windows.Forms.TextBox()
        Me.at1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bb5 = New System.Windows.Forms.Button()
        Me.pt3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bb4 = New System.Windows.Forms.Button()
        Me.bb3 = New System.Windows.Forms.Button()
        Me.bb1 = New System.Windows.Forms.Button()
        Me.PT1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gb3 = New System.Windows.Forms.GroupBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.db4 = New System.Windows.Forms.Button()
        Me.db2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.drb2 = New System.Windows.Forms.RadioButton()
        Me.drb1 = New System.Windows.Forms.RadioButton()
        Me.dt2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.db6 = New System.Windows.Forms.Button()
        Me.dt4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.db5 = New System.Windows.Forms.Button()
        Me.db1 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.RichTextBox()
        Me.pkgworker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pkgworker2 = New System.ComponentModel.BackgroundWorker()
        Me.DrvWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DrvWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.numupdn1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GB1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gb3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(741, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDismLogToolStripMenuItem, Me.SaveOutputToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(47, 20)
        Me.ToolStripMenuItem1.Text = "&Tools"
        '
        'OpenDismLogToolStripMenuItem
        '
        Me.OpenDismLogToolStripMenuItem.Name = "OpenDismLogToolStripMenuItem"
        Me.OpenDismLogToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.OpenDismLogToolStripMenuItem.Text = "Open &Dism Log"
        '
        'SaveOutputToolStripMenuItem
        '
        Me.SaveOutputToolStripMenuItem.Name = "SaveOutputToolStripMenuItem"
        Me.SaveOutputToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SaveOutputToolStripMenuItem.Text = "Save Output"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DISMHelpToolStripMenuItem, Me.ImageXHelpToolStripMenuItem, Me.BCDToolsToolStripMenuItem, Me.OscdImgToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Help"
        '
        'DISMHelpToolStripMenuItem
        '
        Me.DISMHelpToolStripMenuItem.Name = "DISMHelpToolStripMenuItem"
        Me.DISMHelpToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DISMHelpToolStripMenuItem.Text = "DISM Help"
        '
        'ImageXHelpToolStripMenuItem
        '
        Me.ImageXHelpToolStripMenuItem.Name = "ImageXHelpToolStripMenuItem"
        Me.ImageXHelpToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ImageXHelpToolStripMenuItem.Text = "ImageX Help"
        '
        'BCDToolsToolStripMenuItem
        '
        Me.BCDToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BCDBootToolStripMenuItem, Me.BCDEditToolStripMenuItem, Me.BootSectToolStripMenuItem})
        Me.BCDToolsToolStripMenuItem.Name = "BCDToolsToolStripMenuItem"
        Me.BCDToolsToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.BCDToolsToolStripMenuItem.Text = "Boot Tools"
        '
        'BCDBootToolStripMenuItem
        '
        Me.BCDBootToolStripMenuItem.Name = "BCDBootToolStripMenuItem"
        Me.BCDBootToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.BCDBootToolStripMenuItem.Text = "BCDBoot Help"
        '
        'BCDEditToolStripMenuItem
        '
        Me.BCDEditToolStripMenuItem.Name = "BCDEditToolStripMenuItem"
        Me.BCDEditToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.BCDEditToolStripMenuItem.Text = "BCDEdit Help"
        '
        'BootSectToolStripMenuItem
        '
        Me.BootSectToolStripMenuItem.Name = "BootSectToolStripMenuItem"
        Me.BootSectToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.BootSectToolStripMenuItem.Text = "BootSect Help"
        '
        'OscdImgToolStripMenuItem
        '
        Me.OscdImgToolStripMenuItem.Name = "OscdImgToolStripMenuItem"
        Me.OscdImgToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.OscdImgToolStripMenuItem.Text = "OscdImg Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(741, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(31, 17)
        Me.ToolStripStatusLabel1.Text = "Date"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel2.Text = "Time"
        '
        'Timer1
        '
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rb2)
        Me.GroupBox5.Controls.Add(Me.rb1)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(237, 51)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Command : Source / Target"
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Checked = True
        Me.rb2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(112, 21)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(112, 17)
        Me.rb2.TabIndex = 5
        Me.rb2.TabStop = True
        Me.rb2.Text = "Installed Windows"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(6, 21)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(100, 17)
        Me.rb1.TabIndex = 6
        Me.rb1.Text = "Mounted Image"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Location = New System.Drawing.Point(12, 82)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(717, 292)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.numupdn1)
        Me.TabPage1.Controls.Add(Me.ab6)
        Me.TabPage1.Controls.Add(Me.ab7)
        Me.TabPage1.Controls.Add(Me.ab5)
        Me.TabPage1.Controls.Add(Me.ab4)
        Me.TabPage1.Controls.Add(Me.Ab3)
        Me.TabPage1.Controls.Add(Me.Ab2)
        Me.TabPage1.Controls.Add(Me.Ab1)
        Me.TabPage1.Controls.Add(Me.at2)
        Me.TabPage1.Controls.Add(Me.at1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(709, 266)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ImageMount"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Select The Image Index"
        '
        'numupdn1
        '
        Me.numupdn1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numupdn1.Location = New System.Drawing.Point(447, 104)
        Me.numupdn1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numupdn1.Name = "numupdn1"
        Me.numupdn1.Size = New System.Drawing.Size(99, 21)
        Me.numupdn1.TabIndex = 13
        Me.numupdn1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ab6
        '
        Me.ab6.Location = New System.Drawing.Point(552, 205)
        Me.ab6.Name = "ab6"
        Me.ab6.Size = New System.Drawing.Size(126, 23)
        Me.ab6.TabIndex = 6
        Me.ab6.Text = "Mounted Image Info"
        Me.ab6.UseVisualStyleBackColor = True
        '
        'ab7
        '
        Me.ab7.Location = New System.Drawing.Point(552, 172)
        Me.ab7.Name = "ab7"
        Me.ab7.Size = New System.Drawing.Size(126, 23)
        Me.ab7.TabIndex = 7
        Me.ab7.Text = "Re-Mount Image"
        Me.ab7.UseVisualStyleBackColor = True
        '
        'ab5
        '
        Me.ab5.Location = New System.Drawing.Point(420, 172)
        Me.ab5.Name = "ab5"
        Me.ab5.Size = New System.Drawing.Size(126, 23)
        Me.ab5.TabIndex = 8
        Me.ab5.Text = "Mount Image"
        Me.ab5.UseVisualStyleBackColor = True
        '
        'ab4
        '
        Me.ab4.Location = New System.Drawing.Point(22, 143)
        Me.ab4.Name = "ab4"
        Me.ab4.Size = New System.Drawing.Size(126, 23)
        Me.ab4.TabIndex = 9
        Me.ab4.Text = "Select Mount Folder"
        Me.ab4.UseVisualStyleBackColor = True
        '
        'Ab3
        '
        Me.Ab3.Location = New System.Drawing.Point(552, 104)
        Me.Ab3.Name = "Ab3"
        Me.Ab3.Size = New System.Drawing.Size(126, 23)
        Me.Ab3.TabIndex = 10
        Me.Ab3.Text = "Get Index Info"
        Me.Ab3.UseVisualStyleBackColor = True
        '
        'Ab2
        '
        Me.Ab2.Location = New System.Drawing.Point(552, 64)
        Me.Ab2.Name = "Ab2"
        Me.Ab2.Size = New System.Drawing.Size(126, 23)
        Me.Ab2.TabIndex = 11
        Me.Ab2.Text = "Get File Info"
        Me.Ab2.UseVisualStyleBackColor = True
        '
        'Ab1
        '
        Me.Ab1.Location = New System.Drawing.Point(22, 35)
        Me.Ab1.Name = "Ab1"
        Me.Ab1.Size = New System.Drawing.Size(126, 23)
        Me.Ab1.TabIndex = 12
        Me.Ab1.Text = "Browse WIM/ESD/VHD Files"
        Me.Ab1.UseVisualStyleBackColor = True
        '
        'at2
        '
        Me.at2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.at2.Location = New System.Drawing.Point(170, 145)
        Me.at2.Name = "at2"
        Me.at2.Size = New System.Drawing.Size(508, 21)
        Me.at2.TabIndex = 4
        '
        'at1
        '
        Me.at1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.at1.Location = New System.Drawing.Point(170, 37)
        Me.at1.Name = "at1"
        Me.at1.Size = New System.Drawing.Size(508, 21)
        Me.at1.TabIndex = 5
        Me.at1.Text = "The file path will be visble here"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GB1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(709, 266)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Packages"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GB1
        '
        Me.GB1.AutoSize = True
        Me.GB1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GB1.Controls.Add(Me.ComboBox1)
        Me.GB1.Controls.Add(Me.Label9)
        Me.GB1.Controls.Add(Me.bb5)
        Me.GB1.Controls.Add(Me.pt3)
        Me.GB1.Controls.Add(Me.Label7)
        Me.GB1.Controls.Add(Me.Label3)
        Me.GB1.Controls.Add(Me.bb4)
        Me.GB1.Controls.Add(Me.bb3)
        Me.GB1.Controls.Add(Me.bb1)
        Me.GB1.Controls.Add(Me.PT1)
        Me.GB1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB1.Location = New System.Drawing.Point(3, 3)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(703, 260)
        Me.GB1.TabIndex = 0
        Me.GB1.TabStop = False
        Me.GB1.Text = "Packages Changes"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(28, 220)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(648, 21)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(522, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "or"
        '
        'bb5
        '
        Me.bb5.Location = New System.Drawing.Point(549, 159)
        Me.bb5.Name = "bb5"
        Me.bb5.Size = New System.Drawing.Size(127, 23)
        Me.bb5.TabIndex = 23
        Me.bb5.Text = "Remove Package"
        Me.bb5.UseVisualStyleBackColor = True
        '
        'pt3
        '
        Me.pt3.Location = New System.Drawing.Point(179, 132)
        Me.pt3.Name = "pt3"
        Me.pt3.Size = New System.Drawing.Size(497, 21)
        Me.pt3.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.pt3, resources.GetString("pt3.ToolTip"))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Remove Package"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Add Packages"
        '
        'bb4
        '
        Me.bb4.Location = New System.Drawing.Point(383, 86)
        Me.bb4.Name = "bb4"
        Me.bb4.Size = New System.Drawing.Size(127, 23)
        Me.bb4.TabIndex = 16
        Me.bb4.Text = "Add Single Package"
        Me.bb4.UseVisualStyleBackColor = True
        '
        'bb3
        '
        Me.bb3.Location = New System.Drawing.Point(549, 86)
        Me.bb3.Name = "bb3"
        Me.bb3.Size = New System.Drawing.Size(127, 23)
        Me.bb3.TabIndex = 17
        Me.bb3.Text = "Add Multiple packages"
        Me.bb3.UseVisualStyleBackColor = True
        '
        'bb1
        '
        Me.bb1.Location = New System.Drawing.Point(549, 20)
        Me.bb1.Name = "bb1"
        Me.bb1.Size = New System.Drawing.Size(127, 23)
        Me.bb1.TabIndex = 18
        Me.bb1.Text = "Get Installed packages"
        Me.ToolTip1.SetToolTip(Me.bb1, "Get List of installed packages added or installed")
        Me.bb1.UseVisualStyleBackColor = True
        '
        'PT1
        '
        Me.PT1.Location = New System.Drawing.Point(179, 59)
        Me.PT1.Name = "PT1"
        Me.PT1.Size = New System.Drawing.Size(497, 21)
        Me.PT1.TabIndex = 15
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gb3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(709, 266)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Drivers"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gb3
        '
        Me.gb3.AutoSize = True
        Me.gb3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gb3.Controls.Add(Me.cb2)
        Me.gb3.Controls.Add(Me.cb1)
        Me.gb3.Controls.Add(Me.db4)
        Me.gb3.Controls.Add(Me.db2)
        Me.gb3.Controls.Add(Me.Panel2)
        Me.gb3.Controls.Add(Me.dt2)
        Me.gb3.Controls.Add(Me.Label8)
        Me.gb3.Controls.Add(Me.Label6)
        Me.gb3.Controls.Add(Me.db6)
        Me.gb3.Controls.Add(Me.dt4)
        Me.gb3.Controls.Add(Me.Label4)
        Me.gb3.Controls.Add(Me.dt1)
        Me.gb3.Controls.Add(Me.Label5)
        Me.gb3.Controls.Add(Me.db5)
        Me.gb3.Controls.Add(Me.db1)
        Me.gb3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb3.Location = New System.Drawing.Point(0, 0)
        Me.gb3.Name = "gb3"
        Me.gb3.Size = New System.Drawing.Size(709, 266)
        Me.gb3.TabIndex = 0
        Me.gb3.TabStop = False
        Me.gb3.Text = "Drivers"
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(333, 157)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(71, 17)
        Me.cb2.TabIndex = 57
        Me.cb2.Text = "UnSigned"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(235, 157)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(73, 17)
        Me.cb1.TabIndex = 57
        Me.cb1.Text = "Recursive"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'db4
        '
        Me.db4.Location = New System.Drawing.Point(557, 149)
        Me.db4.Name = "db4"
        Me.db4.Size = New System.Drawing.Size(126, 23)
        Me.db4.TabIndex = 47
        Me.db4.Text = "Add Multiple Drivers"
        Me.db4.UseVisualStyleBackColor = True
        '
        'db2
        '
        Me.db2.Location = New System.Drawing.Point(557, 84)
        Me.db2.Name = "db2"
        Me.db2.Size = New System.Drawing.Size(127, 23)
        Me.db2.TabIndex = 53
        Me.db2.Text = "Export Driver"
        Me.ToolTip1.SetToolTip(Me.db2, " ")
        Me.db2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.drb2)
        Me.Panel2.Controls.Add(Me.drb1)
        Me.Panel2.Location = New System.Drawing.Point(346, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 24)
        Me.Panel2.TabIndex = 56
        '
        'drb2
        '
        Me.drb2.AutoSize = True
        Me.drb2.Checked = True
        Me.drb2.Location = New System.Drawing.Point(122, 3)
        Me.drb2.Name = "drb2"
        Me.drb2.Size = New System.Drawing.Size(73, 17)
        Me.drb2.TabIndex = 4
        Me.drb2.TabStop = True
        Me.drb2.Text = "All Drivers"
        Me.drb2.UseVisualStyleBackColor = True
        '
        'drb1
        '
        Me.drb1.AutoSize = True
        Me.drb1.Location = New System.Drawing.Point(3, 3)
        Me.drb1.Name = "drb1"
        Me.drb1.Size = New System.Drawing.Size(70, 17)
        Me.drb1.TabIndex = 4
        Me.drb1.Text = "3rd Party"
        Me.drb1.UseVisualStyleBackColor = True
        '
        'dt2
        '
        Me.dt2.Location = New System.Drawing.Point(178, 121)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(505, 21)
        Me.dt2.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Installed Driver Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Export Image Drivers"
        Me.ToolTip1.SetToolTip(Me.Label6, " ")
        '
        'db6
        '
        Me.db6.Location = New System.Drawing.Point(556, 215)
        Me.db6.Name = "db6"
        Me.db6.Size = New System.Drawing.Size(127, 23)
        Me.db6.TabIndex = 54
        Me.db6.Text = "Remove Driver"
        Me.ToolTip1.SetToolTip(Me.db6, "Copy the name of oem.inf file of the Driver to be removed (You can get the requir" &
        "ed oem.inf name by running ""Get Installed Drivers"" Command")
        Me.db6.UseVisualStyleBackColor = True
        '
        'dt4
        '
        Me.dt4.Location = New System.Drawing.Point(178, 188)
        Me.dt4.Name = "dt4"
        Me.dt4.Size = New System.Drawing.Size(505, 21)
        Me.dt4.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Add Drivers"
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(178, 59)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(505, 21)
        Me.dt1.TabIndex = 52
        Me.dt1.Text = "Enter Path or Click ""Export Driver"" Button to select Driver export path"
        Me.ToolTip1.SetToolTip(Me.dt1, " ")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Remove Drivers"
        '
        'db5
        '
        Me.db5.Location = New System.Drawing.Point(424, 151)
        Me.db5.Name = "db5"
        Me.db5.Size = New System.Drawing.Size(127, 23)
        Me.db5.TabIndex = 50
        Me.db5.Text = "Add Single Driver"
        Me.ToolTip1.SetToolTip(Me.db5, "Select the Driver Inf File to be added to the image")
        Me.db5.UseVisualStyleBackColor = True
        '
        'db1
        '
        Me.db1.Location = New System.Drawing.Point(557, 22)
        Me.db1.Name = "db1"
        Me.db1.Size = New System.Drawing.Size(126, 23)
        Me.db1.TabIndex = 45
        Me.db1.Text = "Get Installed Drivers"
        Me.db1.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(709, 266)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Features"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(709, 266)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "ImageFinalisation"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(709, 266)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "OtherImageCommands"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(709, 266)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "SetupWindows"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(709, 266)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "OscdImgTools"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(709, 266)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "BootRelatedTools"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Utility Command Output"
        '
        'tb1
        '
        Me.tb1.AcceptsTab = True
        Me.tb1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb1.AutoWordSelection = True
        Me.tb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb1.Cursor = System.Windows.Forms.Cursors.Default
        Me.tb1.EnableAutoDragDrop = True
        Me.tb1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1.Location = New System.Drawing.Point(12, 394)
        Me.tb1.Name = "tb1"
        Me.tb1.ReadOnly = True
        Me.tb1.ShowSelectionMargin = True
        Me.tb1.Size = New System.Drawing.Size(713, 142)
        Me.tb1.TabIndex = 12
        Me.tb1.Text = ""
        '
        'pkgworker1
        '
        Me.pkgworker1.WorkerReportsProgress = True
        Me.pkgworker1.WorkerSupportsCancellation = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Help"
        '
        'pkgworker2
        '
        Me.pkgworker2.WorkerReportsProgress = True
        Me.pkgworker2.WorkerSupportsCancellation = True
        '
        'DrvWorker1
        '
        Me.DrvWorker1.WorkerReportsProgress = True
        Me.DrvWorker1.WorkerSupportsCancellation = True
        '
        'DrvWorker2
        '
        Me.DrvWorker2.WorkerReportsProgress = True
        Me.DrvWorker2.WorkerSupportsCancellation = True
        '
        'DismUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(741, 561)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DismUtility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deployment and Imaging Tools GUI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.numupdn1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.gb3.ResumeLayout(False)
        Me.gb3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenDismLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents numupdn1 As NumericUpDown
    Friend WithEvents ab6 As Button
    Friend WithEvents ab7 As Button
    Friend WithEvents ab5 As Button
    Friend WithEvents ab4 As Button
    Friend WithEvents Ab3 As Button
    Friend WithEvents Ab2 As Button
    Friend WithEvents Ab1 As Button
    Friend WithEvents at2 As TextBox
    Friend WithEvents at1 As TextBox
    Friend WithEvents DISMHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageXHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BCDToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BCDBootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BCDEditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BootSectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OscdImgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GB1 As GroupBox
    Friend WithEvents bb5 As Button
    Friend WithEvents pt3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bb4 As Button
    Friend WithEvents bb3 As Button
    Friend WithEvents bb1 As Button
    Friend WithEvents PT1 As TextBox
    Friend WithEvents tb1 As System.Windows.Forms.RichTextBox
    Friend WithEvents SaveOutputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pkgworker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pkgworker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DrvWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DrvWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gb3 As GroupBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents db4 As Button
    Friend WithEvents db2 As Button
    Friend WithEvents drb2 As RadioButton
    Friend WithEvents drb1 As RadioButton
    Friend WithEvents dt2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents db6 As Button
    Friend WithEvents dt4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dt1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents db5 As Button
    Friend WithEvents db1 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
