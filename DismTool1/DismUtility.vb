Imports System.Diagnostics
Imports System.IO
Imports System.Console
Imports Microsoft.Win32.Registry
Imports System.Environment
Imports System
Imports System.Management
Imports Microsoft.VisualBasic.FileIO.FileSystem



Public Class DismUtility

    Dim apppath As String = IO.Directory.GetParent(Application.ExecutablePath).FullName
    Dim libpath32 As String = apppath & "\lib\x32\"
    Dim libpath64 As String = apppath & "\lib\x64\"
    Dim path2 As String = System.IO.Path.GetFullPath()


    Dim a As String = System.Environment.MachineName.ToString
    Dim libpath As String
    Dim Sysinfo As String
    Dim disminfo, dinfo As String
    Dim OS1 As String
    Dim p As New ProcessStartInfo
    Dim pro As New Process
    Dim helppro As New Process
    Dim dsmhlp As New ProcessStartInfo
    Dim Packagecmd As String
    Dim dsmargs As String
    Dim selfiledlg As New OpenFileDialog
    Dim imageloc As String
    Dim dismpth As String
    Dim ofdlg1 As New OpenFileDialog
    Dim mtfolder As New FolderBrowserDialog

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
        Dim sglpkg As String = pt2.Text
        Dim rmpkg As String = pt3.Text
        Return imageloc
    End Function

    Public Function OsBit()
        Sysinfo = Environment.CurrentDirectory()
        If System.Environment.Is64BitOperatingSystem = True Then
            ' MessageBox.Show("OS System : 64 Bit Operating System")
            libpath = libpath64
            OS1 = "64 Bit Operating system"
        Else
            ' MessageBox.Show("OS System : 32 Bit Operating System")
            libpath = libpath32
            OS1 = "32 Bit Operating system"
        End If
        Dim dismpath = "DISM.exe"
        dismpth = dismpath
        Dim di = FileVersionInfo.GetVersionInfo(dismpath)
        dinfo = di.ToString
        disminfo = di.FileDescription & " " & di.FileVersion
        Return Sysinfo
        Return libpath
        Return disminfo
        Return OS1
        Return dinfo
        Return dismpth
    End Function

    Public Function apply1()
        If rb1.Checked = True Then
            Tb1.AppendText("You have selected to use DISM tools on the mounted image")
            Tb1.AppendText(vbNewLine)
        ElseIf rb2.Checked = True Then
            Tb1.AppendText("You have selected to use DISM tools on installed windows")
            Tb1.AppendText(vbNewLine)
        End If
    End Function

    Public Function Packages()
        dismcommands()
        OsBit()
        Dim A, B, C, D
        With p
            .UseShellExecute = False
            .FileName = dismpth
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
            tb1.AppendText(sLine & vbNewLine)
            tb1.ScrollToCaret()
            ' ListBox1.Items.AddRange(Split(sLine, "|", -1, StringSplitOptions.RemoveEmptyEntries))
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
        Tb1.Text = "Date: " & Now.ToLongDateString & vbNewLine & "Time: " & Now.ToLongTimeString & vbNewLine & "Computer name: " & a & vbNewLine & vbNewLine
        Tb1.AppendText(Me.Name & " is running on a " & OS1 & ", Accordingly the corresponding version of DISM utility has been loaded" & vbNewLine & "DISM details" & vbNewLine & dinfo & vbNewLine)
        ' TextBox2.Text = "Date: " & Now.ToLongDateString & vbNewLine & "Time: " & Now.ToLongTimeString
        'MsgBox(a)
        tb1.ScrollToCaret()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = Now.ToLongDateString & ", "
        ToolStripStatusLabel2.Text = Now.ToLongTimeString & " " & System.TimeZoneInfo.Local.DisplayName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        OsBit()
        MsgBox(libpath & vbNewLine & Sysinfo)

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
            Tb1.AppendText("You have selected to use DISM tools on installed windows" & vbNewLine)
            Tb1.AppendText(vbNewLine)
        End If
        tb1.ScrollToCaret()
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then
            Tb1.AppendText("You have selected to use DISM tools on the mounted image" & vbNewLine)
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
            .FileName = libpath & "bcdboot.exe"
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
            .FileName = libpath & "imagex.exe"
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
            .FileName = libpath & "dism.exe"
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
            .FileName = libpath & "BcdEdit.exe"
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
            .FileName = libpath & "BootSect.exe"
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
            .FileName = libpath & "Oscdimg.exe"
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


    Private Sub bb2_Click(sender As Object, e As EventArgs) Handles bb2.Click
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
    End Sub

    Private Sub SaveOutputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveOutputToolStripMenuItem.Click
        tb1.SaveFile(apppath & "\Output.txt", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub pkgworker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles pkgworker1.DoWork
        Packages()
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
            .FileName = dismpth
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
            .FileName = dismpth
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
            pkgworker2.RunWorkerAsync()
        End If

    End Sub

    Private Sub pkgworker2_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles pkgworker2.DoWork
        dismcommands()
        OsBit()
        Dim filepath = PT1.Text
        With p
            .UseShellExecute = False
            .FileName = dismpth
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
            .FileName = dismpth
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
            .FileName = dismpth
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
            .FileName = dismpth
            .Arguments = imageloc & " /Export-Driver /Destination:" & path
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
            tb1.ScrollToCaret()
        Loop
        pro.Close()
    End Sub

    Private Sub db3_Click(sender As Object, e As EventArgs) Handles db3.Click
        With mtfolder
            .ShowNewFolderButton = False
            .Description = "Select Folder where Drivers are stored"
            .ShowDialog()
        End With
        Dim pkgpath As String = mtfolder.SelectedPath
        dt2.Text = pkgpath
        tb1.AppendText(Environment.NewLine + Environment.NewLine)
        tb1.AppendText("The Driver folder selected is " & dt2.Text & vbNewLine)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Ab2_Click(sender As Object, e As EventArgs) Handles Ab2.Click
        Dim filename As String = at1.Text
        tb1.AppendText(vbNewLine)
        With p
            .UseShellExecute = False
            .FileName = dismpth
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