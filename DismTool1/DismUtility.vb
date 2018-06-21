''''''*** ////  DISM GUI TOOL by Amit Haridas \\\\\ *** ''''''
' Functions list
' dismcommands() --- Function assigns whether the serviced image is offline or online
' OsBit() --- Assigns the OS enviornmet and correct WAIK path (amd64 or x86)

Imports System
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.ComponentModel
Imports System.Threading
Imports System.Console
Imports Microsoft.Win32.Registry
Imports System.Environment
Imports System.Management
Imports System.Collections
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports Microsoft.VisualBasic.Devices

Public Class DismUtility
    Dim apppath As String = IO.Directory.GetParent(Application.ExecutablePath).FullName
    Dim a As String = System.Environment.MachineName.ToString
    Dim b As String = My.Computer.Info.OSFullName.ToString
    Dim libpath, dismpath, imagexpath, bcdpath, oscdpath, Sysinfo, disminfo, dinfo, OS1, packagecmd, dsmargs, imageloc As String
    Dim p, dsmhlp As New ProcessStartInfo
    Dim pro, helppro As New Process
    Dim selfiledlg, ofdlg1 As New OpenFileDialog
    Dim mtfolder As New FolderBrowserDialog
    Dim tworker As BackgroundWorker
    Public WithEvents bgwWorker1 As BackgroundWorker



    Public Function add_driver()
        dismcommands()
        OsBit()

    End Function

    Public Function dismcommands()
        Dim mtpath As String = at2.Text
        ' *********** Imageloc variable returns whether the processing has to happen on online installation or offline image ***********'

        If rb1.Checked = True Then
            If at2.Text = "" Then
                MsgBox("Please mount or remount an WIM/VHS/ESD file, else paste mounted image path in the mounted image folder")
            Else mtpath = at2.Text
            End If
            imageloc = " /image:" & mtpath
        ElseIf rb2.Checked = True Then
            imageloc = " /online "
        End If
        Dim imgpath As String = at1.Text
        Dim imgindex As String = numupdn1.Value
        Dim pkddir As String = PT1.Text
        Dim rmpkg As String = pt3.Text
        Return imageloc
    End Function

    Public Function OsBit()
        Sysinfo = Environment.CurrentDirectory()
        '''' This command below processes the query whether WAIK is installed in local computer and then defined the path for further commands to work '''''

        Dim librarypath As String
        If System.Environment.Is64BitOperatingSystem = True Then
            librarypath = Path.GetFullPath("C:\Program Files (x86)\Windows Kits\10\Assessment And Deployment Kit\Deployment Tools\amd64\")
            OS1 = "64 Bit Operating system"
            If Directory.Exists(librarypath) Then
                ' This path is a directory.
                libpath = librarypath
            Else
                MsgBox("WAIK not Found, Please Install Image & Deployment Toolkit from WAIK")
                Exit Function
            End If
        Else
            librarypath = Path.GetFullPath("C:\Program Files (x86)\Windows Kits\10\Assessment And Deployment Kit\Deployment Tools\x86\")
            OS1 = "32 Bit Operating system"
            If Directory.Exists(librarypath) Then
                ' This path is a directory.
                libpath = librarypath
            Else
                MsgBox("WAIK not Found, Please Install Image & Deployment Toolkit from WAIK")
                Exit Function
            End If
        End If

        dismpath = libpath & "Dism\Dism.exe"
        imagexpath = libpath & "Dism\imagex.exe"
        bcdpath = libpath & "BCDboot\"
        oscdpath = libpath & "Oscdimg\"

        Dim di = FileVersionInfo.GetVersionInfo(dismpath)
        dinfo = di.ToString
        disminfo = di.FileDescription & " " & di.FileVersion
        Return Sysinfo
        Return libpath
        Return disminfo
        Return OS1
        Return dinfo
        Return dismpath
        Return imagexpath
        Return bcdpath
        Return oscdpath

    End Function

    Public Function apply1()
        If rb1.Checked = True Then
            tb1.AppendText("You have selected to use DISM tools on the mounted image")
            tb1.AppendText(vbNewLine)
        ElseIf rb2.Checked = True Then
            tb1.AppendText("You have selected to use DISM tools on installed windows")
            tb1.AppendText(vbNewLine)
        End If
    End Function

    Public Function Get_Packages()
        dismcommands()
        OsBit()
        Dim abc As Array
        Dim A, B, C, D
        With p
            .UseShellExecute = False
            .FileName = dismpath
            'Arguments = imageloc & " /loglevel:2 /Get-packages"
            .Arguments = imageloc & " /loglevel:2 /Get-packages /Format:table"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With

        pro.StartInfo = p
        pro.Start()
        While (pro.HasExited = False)
            Dim sLine As String = pro.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then
            End If
            ComboBox1.Items.Add(sLine)
            tb1.AppendText(sLine & vbNewLine)
            tb1.ScrollToCaret()
            'ListBox1.Items.AddRange(Split(sLine, "|", -1, StringSplitOptions.RemoveEmptyEntries))
            Application.DoEvents()
        End While
        ' ListBox1.Items.AddRange(Split(pro.StandardOutput.ReadToEnd, vbCrLf))


        pro.Close()

    End Function

    Private Sub ToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolsToolStripMenuItem.Click

    End Sub

    Private Sub OpenDismLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDismLogToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe", "c:\Windows\logs\Dism\dism.log")

    End Sub

    Private Sub DismUtility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        OsBit()
        tb1.Text = "Date: " & Now.ToLongDateString & vbNewLine & "Time: " & Now.ToLongTimeString & vbNewLine & "Computer name: " & a & vbNewLine & b & vbNewLine
        tb1.AppendText(Me.Name & " is running on a " & OS1 & ", Accordingly the corresponding version of DISM utility has been loaded" & vbNewLine & "DISM details" & vbNewLine & dinfo & vbNewLine)
        ' TextBox2.Text = "Date: " & Now.ToLongDateString & vbNewLine & "Time: " & Now.ToLongTimeString
        'MsgBox(a)
        tb1.ScrollToCaret()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = Now.ToLongDateString & ", "
        ToolStripStatusLabel2.Text = Now.ToLongTimeString & " " & System.TimeZoneInfo.Local.DisplayName
    End Sub

    Private Sub ab4_Click(sender As Object, e As EventArgs) Handles ab4.Click
        tb1.AppendText(vbNewLine)
        With mtfolder
            .ShowNewFolderButton = True
            .Description = "Select Folder for Mounting the Image"
            .ShowDialog()
        End With

        Dim mimgpath As String = mtfolder.SelectedPath
        at2.Text = mimgpath
        tb1.AppendText("The folder selected for mounting file is  " & at2.Text)
        tb1.ScrollToCaret()
    End Sub

    Private Sub at1_TextChanged(sender As Object, e As EventArgs) Handles at1.TextChanged

    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked = True Then
            tb1.AppendText("You have selected to use DISM tools on installed windows" & vbNewLine)
            tb1.AppendText(vbNewLine)
        End If
        tb1.ScrollToCaret()
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then
            tb1.AppendText("You have selected to use DISM tools on the mounted image" & vbNewLine)
            tb1.AppendText(vbNewLine)
        End If
        tb1.ScrollToCaret()
    End Sub

    Private Sub BCDBootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BCDBootToolStripMenuItem.Click
        OsBit()
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With
        With p
            .UseShellExecute = False
            .FileName = bcdpath & "bcdboot.exe"
            .Arguments = "/Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        Dim std_out1 As StreamReader = pro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        pro.Close()
    End Sub

    Private Sub ImageXHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageXHelpToolStripMenuItem.Click
        OsBit()
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With

        Dim p As New ProcessStartInfo
        With p
            .UseShellExecute = False
            .FileName = imagexpath
            .Arguments = "/Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With

        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()
        Dim std_out1 As StreamReader = pro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        pro.Dispose()
        pro.Close()
    End Sub

    Private Sub DISMHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DISMHelpToolStripMenuItem.Click
        OsBit()
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With
        With p
            .UseShellExecute = False
            .FileName = dismpath
            .Arguments = "/get-Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        Dim std_out1 As StreamReader = pro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        pro.Close()

    End Sub

    Private Sub BCDEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BCDEditToolStripMenuItem.Click
        OsBit()
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With
        With p
            .UseShellExecute = False
            .FileName = bcdpath & "BcdEdit.exe"
            .Arguments = "/Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        Dim std_out1 As StreamReader = pro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        pro.Close()
    End Sub

    Private Sub BootSectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BootSectToolStripMenuItem.Click
        OsBit()
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With


        With p
            .UseShellExecute = False
            .FileName = bcdpath & "BootSect.exe"
            .Arguments = "/Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With


        pro.StartInfo = p
        pro.Start()
        Dim std_out1 As StreamReader = pro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        pro.Dispose()
        pro.Close()
    End Sub

    Private Sub OscdImgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OscdImgToolStripMenuItem.Click
        OsBit()
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With


        With p
            .UseShellExecute = False
            .FileName = oscdpath & "Oscdimg.exe"
            .Arguments = "/Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With

        pro.StartInfo = p
        pro.Start()
        Dim std_out1 As StreamReader = pro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        pro.Dispose()
        pro.Close()

    End Sub

    Private Sub bb1_Click(sender As Object, e As EventArgs) Handles bb1.Click
        pkgworker1.RunWorkerAsync()



    End Sub


    Private Sub bb2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveOutputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveOutputToolStripMenuItem.Click
        tb1.SaveFile(apppath & "\Output.txt", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub pkgworker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles pkgworker1.DoWork
        Get_Packages()
    End Sub

    Private Sub Ab1_Click(sender As Object, e As EventArgs) Handles Ab1.Click
        With ofdlg1
            .Filter = "WIM files(*.wim)|*.wim|ESD Files(*.esd)|*.esd|VHD Files(*.vhd)|*.vhd"
            .Title = "Select WIM / ESD / VHD FIle"
        End With
        ofdlg1.ShowDialog()
        at1.Text = ofdlg1.FileName.ToString()
        tb1.AppendText(vbNewLine)
        tb1.AppendText("The Following file has been selected " & at1.Text)
        tb1.ScrollToCaret()
    End Sub

    Private Sub Ab3_Click(sender As Object, e As EventArgs) Handles Ab3.Click

        Dim ct = numupdn1.Value
        Dim filename As String = at1.Text
        tb1.AppendText(vbNewLine)
        With p
            .UseShellExecute = False
            .FileName = dismpath
            .Arguments = " /Get-WimInfo /WimFile:" & filename & " /Index:" & ct
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim ts As String = SROutput.ReadToEnd()
        tb1.AppendText(ts)
        tb1.ScrollToCaret()
        pro.WaitForExit()
        pro.Close()
        '  pro.Dispose()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub db4_Click(sender As Object, e As EventArgs) Handles db4.Click
        'Dism / Image: C : \test\offline /Add-Driver /driver:C : \test\drivers\
        'Dism / Image: C : \test\offline /Add-Driver /driver:C : \test\drivers /recurse
        'Dism / Image: C : \test\offline /Add-Driver /driver:C : \test\drivers\mydriver.inf
        'Dism / Image: C : \test\offline /Add-Driver /driver:C : \test\drivers\mydriver.inf /ForceUnsigned
        If DrvWorker2.IsBusy = True Then
            MsgBox("The program is processing your previous request, please try later", MsgBoxStyle.Critical)
            Exit Sub
        Else
            With mtfolder
                .ShowNewFolderButton = False
                .Description = "Select Folder where Drivers are stored"
                .ShowDialog()
            End With
            Dim drvpath As String = mtfolder.SelectedPath
            dt2.Text = drvpath
            tb1.AppendText(Environment.NewLine + Environment.NewLine)
            tb1.AppendText("The Driver folder selected is " & dt2.Text & vbNewLine)
            tb1.AppendText(vbNewLine)
            tb1.ScrollToCaret()
            DrvWorker2.RunWorkerAsync()
        End If


        With mtfolder
            .ShowNewFolderButton = False
            .Description = "Select Folder where Drivers are stored"
            .ShowDialog()
        End With
        Dim pkgpath As String = mtfolder.SelectedPath
        dt2.Text = pkgpath
        tb1.AppendText(Environment.NewLine + Environment.NewLine)
        tb1.AppendText("The Driver folder selected is " & dt2.Text & vbNewLine)

        tb1.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            '.Arguments = "/Mount-Image /ImageFile:" & filename & " /Index:" & ct & " /MountDir:" & mtpath
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()

        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim tmp As String
        Do While pro.HasExited = False
            tmp = SROutput.ReadLine
            If tmp <> "" Then
                Me.tb1.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        tb1.ScrollToCaret()
        pro.Close()


    End Sub

    Private Sub bb4_Click(sender As Object, e As EventArgs) Handles bb4.Click
        If pkgworker2.IsBusy = True Then
            MsgBox("The program is processing your previous request, please try later", MsgBoxStyle.Critical)
            Exit Sub
        Else
            With ofdlg1
                .Filter = "Windows Update Installer|*.msu|cab files|*.cab"
                .Title = "Select *.msu or *.cab file"
            End With
            ofdlg1.ShowDialog()
            PT1.Text = ofdlg1.FileName.ToString()
            tb1.AppendText(vbNewLine)
            tb1.AppendText("The Following file has been selected " & PT1.Text)
            tb1.AppendText(vbNewLine)
            tb1.ScrollToCaret()
            pkgworker2.RunWorkerAsync()
        End If
    End Sub

    Private Sub db5_Click(sender As Object, e As EventArgs) Handles db5.Click
        If DrvWorker2.IsBusy = True Then
            MsgBox("The program is processing your previous request, please try later", MsgBoxStyle.Critical)
            Exit Sub
        Else
            With ofdlg1
                .Filter = "Windows Driver Setup Files|*.inf"
                .Title = "Select *.inf file"
            End With
            ofdlg1.ShowDialog()
            PT1.Text = ofdlg1.FileName.ToString()
            tb1.AppendText(vbNewLine)
            tb1.AppendText("The Following file has been selected " & dt2.Text)
            tb1.AppendText(vbNewLine)
            tb1.ScrollToCaret()
            DrvWorker2.RunWorkerAsync()
        End If
    End Sub

    Private Sub DrvWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles DrvWorker2.DoWork
        'Dism / Image: C : \test\offline /Add-Driver /driver:C : \test\drivers\
        'Dism / Image: C : \test\offline /Add-Driver /driver:C : \test\drivers /recurse
        'Dism / Image: C : \test\offline /Add-Driver /driver:C : \test\drivers\mydriver.inf
        'Dism / Image: C : \test\offline /Add-Driver /driver:C : \test\drivers\mydriver.inf /ForceUnsigned
        dismcommands()
        OsBit()
        Dim filepath = dt2.Text
        With p
            .UseShellExecute = False
            .FileName = dismpath
            If cb1.Checked = False And cb2.Checked = False Then
                .Arguments = imageloc & "/Add-Driver /Driver:" & filepath
            ElseIf cb1.Checked = True And cb2.Checked = False Then
                .Arguments = imageloc & "/Add-Driver /Driver:" & filepath & " /recurse"
            ElseIf cb1.Checked = True And cb2.Checked = True Then
                .Arguments = imageloc & "/Add-Driver /Driver:" & filepath & " /recurse /ForceUnsigned"
            ElseIf cb1.Checked = False And cb2.Checked = True Then
                .Arguments = imageloc & "/Add-Driver /Driver:" & filepath & " /ForceUnsigned"
            Else
                MsgBox("I am confused")
                Exit Sub
            End If
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        While (pro.HasExited = False)
            Dim sLine As String = pro.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then
            End If
            tb1.AppendText(sLine & vbNewLine)
            tb1.ScrollToCaret()
            Application.DoEvents()
        End While
        pro.Close()
    End Sub

    Private Sub db6_Click(sender As Object, e As EventArgs) Handles db6.Click
        ' Dism /image:C:\test\offline /Remove-Driver /driver:oem1.inf
        dismcommands()
        OsBit()
        Dim filepath = dt4.Text
        With p
            .UseShellExecute = False
            .FileName = dismpath
            .Arguments = imageloc & " /Remove-Driver /driver:" & filepath
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        While (pro.HasExited = False)
            Dim sLine As String = pro.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then
            End If
            tb1.AppendText(sLine & vbNewLine)
            tb1.ScrollToCaret()
            Application.DoEvents()
        End While
        pro.Close()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub TabPage6_Click(sender As Object, e As EventArgs) Handles TabPage6.Click


    End Sub

    Private Sub ab5_Click(sender As Object, e As EventArgs) Handles ab5.Click
        Dim filename = at1.Text
        Dim mtpath = at2.Text
        Dim ct = numupdn1.Value
        tb1.AppendText(vbNewLine)
        With p
            .UseShellExecute = False
            .Arguments = "/Mount-Image /ImageFile:" & filename & " /Index:" & ct & " /MountDir:" & mtpath
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()

        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim tmp As String
        Do While pro.HasExited = False
            tmp = SROutput.ReadLine
            If tmp <> "" Then
                Me.tb1.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        tb1.ScrollToCaret()
        pro.Close()
    End Sub

    Private Sub ab6_Click(sender As Object, e As EventArgs) Handles ab6.Click
        tb1.AppendText(vbNewLine)
        With p
            .UseShellExecute = False
            .FileName = dismpath
            .Arguments = " /get-mountedwiminfo"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim ts As String = SROutput.ReadToEnd()
        tb1.AppendText(ts)
        tb1.ScrollToCaret()
        pro.WaitForExit()
        tb1.AppendText(vbNewLine & "Select the required mounted image path and paste in to the mount folder filepath for properfunctioning for alredy mounted folders " & vbNewLine)
        tb1.ScrollToCaret()
        pro.Close()
    End Sub

    Private Sub ab7_Click(sender As Object, e As EventArgs) Handles ab7.Click
        OsBit()
        With mtfolder
            .RootFolder = SpecialFolder.System.MyComputer
            .ShowNewFolderButton = True
            .Description = "Select Folder for re-Mounting the Image"
            .ShowDialog()
        End With
        Dim mimgpath As String = mtfolder.SelectedPath
        at2.Text = mimgpath
        tb1.AppendText("The folder selected for re-mounting file is  " & at2.Text)
        Dim filepath = at1.Text
        MsgBox(filepath)
        Dim mtpath = at2.Text
        Dim ct = numupdn1.Value
        tb1.AppendText(vbNewLine)
        ' Dism /Mount-Image /ImageFile:G:\WIN7Prox64\winpro.wim /index:1 /MountDir:G:\win7pro_mount
        With p
            .UseShellExecute = False
            .Arguments = " /Remount-Image /MountDir:" & mtfolder.SelectedPath
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim tmp As String
        Do While pro.HasExited = False
            tmp = SROutput.ReadLine
            If tmp <> "" Then
                Me.tb1.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        tb1.ScrollToCaret()
        pro.Close()
    End Sub

    Private Sub bb3_Click(sender As Object, e As EventArgs) Handles bb3.Click
        If pkgworker2.IsBusy = True Then
            MsgBox("The program is processing your previous request, please try later", MsgBoxStyle.Critical)
            Exit Sub
        Else
            With mtfolder
                .ShowNewFolderButton = False
                .Description = "Select Folder where packages are stored"
                .ShowDialog()
            End With
            Dim pkgpath As String = mtfolder.SelectedPath
            PT1.Text = pkgpath
            tb1.AppendText(Environment.NewLine + Environment.NewLine)
            tb1.AppendText("The folder selected for mounting file is  " & PT1.Text & vbNewLine)
            tb1.ScrollToCaret()
            pkgworker2.RunWorkerAsync()
        End If

    End Sub

    Private Sub pkgworker2_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles pkgworker2.DoWork
        dismcommands()
        OsBit()
        Dim filepath = PT1.Text
        With p
            .UseShellExecute = False
            .FileName = dismpath
            .Arguments = imageloc & " /add-package /packagepath:" & filepath
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With

        pro.StartInfo = p
        pro.Start()
        While (pro.HasExited = False)
            Dim sLine As String = pro.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then
            End If
            tb1.AppendText(sLine & vbNewLine)
            tb1.ScrollToCaret()
            Application.DoEvents()
        End While
        pro.Close()

    End Sub

    Private Sub bb11_Click(sender As Object, e As EventArgs) Handles bb5.Click
        ' DISM /Image:C:\test\offline /Remove-Package /PackageName:
        dismcommands()
        OsBit()
        Dim filepath = pt3.Text
        With p
            .UseShellExecute = False
            .FileName = dismpath
            .Arguments = imageloc & " /Remove-Package /PackageName:" & filepath
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        While (pro.HasExited = False)
            Dim sLine As String = pro.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then
            End If
            tb1.AppendText(sLine & vbNewLine)
            tb1.ScrollToCaret()
            Application.DoEvents()
        End While
        pro.Close()


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bb5_Click(sender As Object, e As EventArgs) Handles db1.Click
        If DrvWorker1.IsBusy = True Then
            MsgBox("The program is processing your previous request, please try later", MsgBoxStyle.Critical)
            Exit Sub
        Else
            DrvWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub DrvWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles DrvWorker1.DoWork
        dismcommands()
        OsBit()
        With p
            .UseShellExecute = False
            .FileName = dismpath
            If drb1.Checked = True Then
                .Arguments = imageloc & " /Get-Drivers /Format:Table"
            ElseIf drb2.Checked = True Then
                .Arguments = imageloc & " /Get-Drivers /All /Format:Table"
            End If
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        tb1.AppendText("Getting the list of Drivers. Please wait..... ")
        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim ts As String = SROutput.ReadToEnd()
        tb1.AppendText(ts)
        tb1.ScrollToCaret()
        pro.WaitForExit()
        pro.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub db2_Click(sender As Object, e As EventArgs) Handles db2.Click
        dismcommands()
        OsBit()
        ' Examples:
        ' DISM /Online /Export-Driver /Destination:C:\destpath
        ' DISM /Image:C\test\offline /Export-Driver /Destination:C:\destpath
        tb1.AppendText(vbNewLine)
        mtfolder.ShowNewFolderButton = True
        mtfolder.ShowDialog()
        Dim path As String = mtfolder.SelectedPath
        dt1.Text = path
        With p
            .UseShellExecute = False
            .FileName = dismpath
            .Arguments = imageloc & "/Export-Driver /Destination:" & path
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()
        tb1.AppendText("Exporting selected Drivers, Please wait for the program to finish")
        tb1.AppendText(vbNewLine)
        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim ts As String = SROutput.ReadToEnd()
        tb1.AppendText(ts)
        tb1.ScrollToCaret()
        pro.WaitForExit()
        pro.Close()
        'Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        'Dim tmp As String
        'Do While pro.HasExited = False
        '    tmp = SROutput.ReadLine
        '    If tmp <> "" Then
        '        Me.tb1.AppendText(tmp & vbNewLine)
        '        Application.DoEvents()
        '    End If
        '    Application.DoEvents()
        '    tb1.ScrollToCaret()
        'Loop
        'pro.Close()
    End Sub

    Private Sub db3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged

    End Sub

    Private Sub Ab2_Click(sender As Object, e As EventArgs) Handles Ab2.Click
        Dim filename As String = at1.Text
        tb1.AppendText(vbNewLine)
        With p
            .UseShellExecute = False
            .FileName = dismpath
            .Arguments = " /Get-WimInfo /WimFile:" & filename
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        pro.StartInfo = p
        pro.Start()
        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim ts As String = SROutput.ReadToEnd()
        tb1.AppendText(ts)
        tb1.ScrollToCaret()
        pro.WaitForExit()
        pro.Close()
        ' pro.Dispose()
    End Sub
End Class