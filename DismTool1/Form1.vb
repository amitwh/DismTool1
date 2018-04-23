Imports System.Diagnostics
Imports System.IO
Imports System.Console
Imports Microsoft.Win32.Registry

Public Class Form1
    Dim apppath As String = IO.Directory.GetParent(Application.ExecutablePath).FullName
    

    Private Property fmt As String
    ' Dim w16D As String = IO.Path.Combine(Path, "\lib\W10\x64\Dism.exe")

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = My.Application.Info.DirectoryPath
        Timer1.Start()
        With Me
            .StartPosition = FormStartPosition.CenterScreen
            .WindowState = FormWindowState.Maximized

        End With
        '  Dim p As String = IO.Directory.GetParent(Application.ExecutablePath).FullName
        Dim w16D As String = IO.Path.Combine(path, "\lib\W10\x64\Dism.exe")

        Dim q As String = IO.Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName, "\lib\W10\x64\Dism.exe")
        Dim m As String = apppath & "\lib\W10\x64\Dism.exe"
        '   MsgBox(apppath)
        '    MsgBox(q)
        '  MsgBox(m)
        RadioButton3.Checked = True
        RadioButton9.Checked = True
        RadioButton5.Checked = True
        TextBox2.Text = "Date: " & Now.ToLongDateString & vbNewLine & "Time: " & Now.ToLongTimeString
        TextBox2.ScrollBars = ScrollBars.Both
        TextBox2.AllowDrop = False
        TextBox2.ReadOnly = True
 
        TextBox2.AppendText(vbNewLine)
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectToolStripMenuItem.Click

    End Sub

    Private Sub ImageXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageXToolStripMenuItem.Click
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With

        Dim dsmhlp As New ProcessStartInfo
        With dsmhlp
            .UseShellExecute = False

            .FileName = apppath & "\lib\w10\x64\imagex.exe"
            .Arguments = "/Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With

        Dim helppro As New Process
        helppro.StartInfo = dsmhlp
        helppro.Start()
        Dim std_out1 As StreamReader = helppro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "ImageX Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        helppro.Close()

    End Sub

    Private Sub BcdBootToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BcdBootToolStripMenuItem1.Click
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With

        Dim dsmhlp As New ProcessStartInfo
        With dsmhlp
            .UseShellExecute = False

            .FileName = apppath & "\lib\w10\x64\bcdboot.exe"
            .Arguments = "/Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim helppro As New Process
        helppro.StartInfo = dsmhlp
        helppro.Start()
        Dim std_out1 As StreamReader = helppro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "BcdBoot Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        helppro.Close()
    End Sub

    Private Sub BcdEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BcdEditToolStripMenuItem.Click
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With

        Dim dsmhlp As New ProcessStartInfo
        With dsmhlp
            .UseShellExecute = False

            .FileName = apppath & "\lib\w10\x64\bcdedit.exe"
            .Arguments = "/Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim helppro As New Process
        helppro.StartInfo = dsmhlp
        helppro.Start()
        Dim std_out1 As StreamReader = helppro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "BcdEdit Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        helppro.Close()
    End Sub

    Private Sub BootSectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BootSectToolStripMenuItem.Click
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With

        Dim dsmhlp As New ProcessStartInfo
        With dsmhlp
            .UseShellExecute = False

            .FileName = apppath & "\lib\w10\x64\bootsect.exe"
            .Arguments = "/Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim helppro As New Process
        helppro.StartInfo = dsmhlp
        helppro.Start()
        Dim std_out1 As StreamReader = helppro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "BootSect Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        helppro.Close()
    End Sub

    Private Sub DismToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DismToolStripMenuItem1.Click
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With

        Dim dsmhlp As New ProcessStartInfo
        With dsmhlp
            .UseShellExecute = False

            .FileName = apppath & "\lib\w10\x64\DISm.exe"
            .Arguments = "/get-Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim helppro As New Process
        helppro.StartInfo = dsmhlp
        helppro.Start()
        Dim std_out1 As StreamReader = helppro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "DISM Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        helppro.Close()
    End Sub

    Private Sub OscdImgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OscdImgToolStripMenuItem.Click
        Dim a As New Form
        Dim b As New TextBox
        b.Parent = a
        With b
            .Dock = DockStyle.Fill
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New System.Drawing.Font("Courier New", 10)
        End With

        Dim dsmhlp As New ProcessStartInfo
        With dsmhlp
            .UseShellExecute = False

            .FileName = apppath & "\lib\w10\x64\oscdimg.exe"
            .Arguments = "/Help"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim helppro As New Process
        helppro.StartInfo = dsmhlp
        helppro.Start()
        Dim std_out1 As StreamReader = helppro.StandardOutput()
        b.Text = std_out1.ReadToEnd()
        std_out1.Close()
        With a
            .Text = "OscdImg Help"
            .Size = New System.Drawing.Size(700, 400)
            .Show()
        End With
        helppro.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = Now.ToLongDateString
        ToolStripStatusLabel2.Text = Now.ToLongTimeString & " " & System.TimeZoneInfo.Local.DisplayName
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles bb1.Click
        BackgroundWorker2.RunWorkerAsync()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Ab2.Click
        Dim p As New ProcessStartInfo
        Dim filepath = at1.Text
        TextBox2.AppendText(vbNewLine)

        With p
            .UseShellExecute = False
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If
            .Arguments = "/Get-WimInfo /WimFile:" & filepath
            .CreateNoWindow = True

        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()
        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim ts As String = SROutput.ReadToEnd()
        TextBox2.AppendText(ts)
        pro.WaitForExit()
        pro.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ab1.Click
        Dim ofdlg1 As New OpenFileDialog
        With ofdlg1
            .Filter = "WIM files(*.wim)|*.wim|ESD Files(*.esd)|*.esd|VHD Files(*.vhd)|*.vhd"
            .Title = "Select WIM / ESD / VHD FIle"
        End With
        ' TextBox1.Text = ofdlg1.FileName.ToString()
        ofdlg1.ShowDialog()
        at1.Text = ofdlg1.FileName.ToString()
        TextBox2.AppendText(vbNewLine)
        TextBox2.AppendText("The Following file has been selected " & at1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ab4.Click
        Dim mtfolder As New FolderBrowserDialog
        With mtfolder
            .ShowNewFolderButton = True
            .Description = "Select Folder for Mounting the Image"
            .ShowDialog()
        End With

        Dim mimgpath As String = mtfolder.SelectedPath
        at2.Text = mimgpath
        TextBox2.AppendText("The folder selected for mounting file is  " & at2.Text)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ab5.Click
        Dim p As New ProcessStartInfo
        Dim filepath = at1.Text
        MsgBox(filepath)
        Dim mtpath = at2.Text
        Dim ct = NumericUpDown1.Value
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If
            ' Dism /Mount-Image /ImageFile:G:\WIN7Prox64\winpro.wim /index:1 /MountDir:G:\win7pro_mount

            .Arguments = "/Mount-Image /ImageFile:" & filepath & " /Index:" & ct & " /MountDir:" & mtpath
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
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        pro.Close()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles at2.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Ab3.Click
        Dim p As New ProcessStartInfo
        Dim filepath = at1.Text
        MsgBox(filepath)
        Dim ct = NumericUpDown1.Value
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If

            .Arguments = "/Get-WimInfo /WimFile:" & filepath & " /Index:" & ct
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()


        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim ts As String = SROutput.ReadToEnd()
        TextBox2.AppendText(ts)
        pro.WaitForExit()
        pro.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles bb2.Click

        Dim pkgfld As New FolderBrowserDialog
        With pkgfld
            .ShowNewFolderButton = False
            .Description = "Select Folder where packages are stored"
            .ShowDialog()
        End With

        Dim pkgpath As String = pkgfld.SelectedPath
        TextBox4.Text = pkgpath
        TextBox2.AppendText(Environment.NewLine + Environment.NewLine)
        TextBox2.AppendText("The folder selected for mounting file is  " & TextBox4.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles bb3.Click
        pkginstaller.RunWorkerAsync()
       
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged, TextBox6.TextChanged

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Dim p As New ProcessStartInfo
        Dim filepath = TextBox4.Text
        MsgBox(filepath)
        Dim mtpath = at2.Text
        MsgBox(mtpath)
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If
            ' dism /image:E:\WIN7x64\mount /add-package /packagepath:E:\WIN7x64\updates\msu /loglevel:1 /logpath:E:\WIN7x64\tools

            .Arguments = " /cleanup-wim"""
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
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        pro.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles ab6.Click
        Dim p As New ProcessStartInfo
        Dim filepath = TextBox4.Text
        TextBox2.AppendText(vbNewLine)
        Dim mtpath = at2.Text

        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If
            ' dism /image:E:\WIN7x64\mount /add-package /packagepath:E:\WIN7x64\updates\msu /loglevel:1 /logpath:E:\WIN7x64\tools

            .Arguments = " /get-mountedwiminfo"
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()

        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        'Dim tmp As String
        'Do While pro.HasExited = False
        '    tmp = SROutput.ReadLine
        '    If tmp <> "" Then
        '        Me.TextBox2.AppendText(tmp & vbNewLine)
        '        Application.DoEvents()
        '    End If
        '    Application.DoEvents()
        'Loop
        Dim ts As String = SROutput.ReadToEnd()
        TextBox2.AppendText(ts)
        pro.WaitForExit()
        TextBox2.AppendText(vbNewLine & "Select the required mounted image path and paste in to the mount folder filepath for properfunctioning for alredy mounted folders ")
        pro.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles bb5.Click
        BackgroundWorker1.RunWorkerAsync()

        'Dim p As New ProcessStartInfo
        'Dim filepath = TextBox4.Text
        'Dim mtpath = TextBox3.Text
        'TextBox2.AppendText(vbNewLine)
        'With p
        '    .UseShellExecute = False

        '    If RadioButton1.Checked = True Then
        '        Dim filever As String = "\lib\w10\x64\DISm.exe"
        '        .FileName = apppath & filever
        '    ElseIf RadioButton2.Checked = True Then
        '        Dim filever As String = "\lib\w10\x86\DISm.exe"
        '        .FileName = apppath & filever
        '    ElseIf RadioButton3.Checked = True Then
        '        Dim filever As String = "\lib\w8\x64\DISm.exe"
        '        .FileName = apppath & filever
        '    ElseIf RadioButton4.Checked = True Then
        '        Dim filever As String = "\lib\w8\x86\DISm.exe"
        '        .FileName = apppath & filever
        '    End If

        '    'Example:
        '    'Dism /image:C:\test\offline /Get-Drivers
        '    'Dism /online /Get-Drivers

        '    If RadioButton5.Checked = True Then
        '        If RadioButton9.Checked = True Then
        '            .Arguments = " /online /Logpath:3rdPartyDriverlistWindows.log /Loglevel:2 /Get-Drivers /Format:Table"
        '        ElseIf RadioButton10.Checked = True Then
        '            .Arguments = " /Image:" & mtpath & " /Logpath:3rdPartyDriverlistImage.log /Loglevel:2 /Get-Drivers /Format:Table"
        '        End If
        '    ElseIf RadioButton6.Checked = True Then
        '        If RadioButton9.Checked = True Then
        '            .Arguments = " /online /Logpath:DriverlistWindows.log /Loglevel:2 /Get-Drivers /All /Format:Table"
        '        ElseIf RadioButton10.Checked = True Then
        '            .Arguments = " /Image:" & mtpath & " /Logpath:DriverlistImage.log /Loglevel:2 /Get-Drivers /All /Format:Table"
        '        End If
        '    End If
        '    .CreateNoWindow = True
        '    .RedirectStandardOutput = True
        '    .RedirectStandardError = True
        'End With
        'Dim pro As New Process

        'pro.StartInfo = p
        'pro.Start()
        'While (pro.HasExited = False)
        '    Dim sLine As String = pro.StandardOutput.ReadLine
        '    If (Not String.IsNullOrEmpty(sLine)) Then
        '    End If
        '    Me.TextBox2.AppendText(sLine & vbNewLine)
        '    Application.DoEvents()
        'End While

        ' ''Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        ' '' Dim tmp As String
        ' ''  Do While pro.HasExited = False
        ' ''tmp = SROutput.ReadLine
        ' ''  Application.DoEvents()
        ' ''  If tmp <> "" Then
        ' ''      Me.TextBox2.AppendText(tmp & vbNewLine)
        ' ''Application.DoEvents()
        ' ''  End If
        ' ''  Application.DoEvents()
        ' '' Loop

        ''Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        ''Dim ts As String = SROutput.ReadToEnd()
        ''TextBox2.AppendText(ts)
        ''pro.WaitForExit()

        ''Dim std_out As StreamReader = pro.StandardOutput()
        ' '' Dim Driverlist As File
        'pro.Dispose()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles bb4.Click
        Dim p As New ProcessStartInfo
        Dim pacsel As New OpenFileDialog
        With pacsel
            .Filter = "MSU files(*.msu)|*.msu|CAB Files(*.cab)|*.cab"
            .Title = "Select MSU / CAB File"
        End With
        ' TextBox1.Text = ofdlg1.FileName.ToString()
        pacsel.ShowDialog()
        Dim filesel = pacsel.FileName
        TextBox6.Text = pacsel.FileName
        'MsgBox(filepath)
        Dim mtpath = at2.Text
        MsgBox(mtpath)
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If
            ' Dism /Image:C:\test\offline /LogPath:AddPackage.log /Add-Package /PackagePath:C:\packages\package.msu



            If RadioButton9.Checked = True Then
                .Arguments = " /online /add-package /packagepath:" & TextBox6.Text
            ElseIf RadioButton10.Checked = True Then
                .Arguments = " /image:" & mtpath & " /Loglevel:3 /LogPath:AddPackage.log /add-package /packagepath:" & TextBox6.Text ' & " /loglevel:3 /logpath:" & apppath & "\packaginglog.txt"
            End If
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()

        ' Dim myStreamReader As StreamReader = pro.StandardOutput
        ' Read the standard output of the spawned process.
        'Dim myString As String = myStreamReader.ReadLine()
        Dim std_out As StreamReader = pro.StandardOutput()
        Dim std_err As StreamReader = pro.StandardError()

        While (pro.HasExited = False)
            Dim sLine As String = pro.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then
            End If
            Me.TextBox2.Text &= sLine & vbCrLf & vbNewLine
            Application.DoEvents()
        End While
        Me.TextBox2.Text += "Completed"
        pro.Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim p As New ProcessStartInfo
        Dim filepath = TextBox4.Text
        Dim mtpath = at2.Text
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If

            'Example:
            'Dism /image:C:\test\offline /Get-Drivers
            'Dism /online /Get-Drivers

            If RadioButton5.Checked = True Then
                If RadioButton9.Checked = True Then
                    .Arguments = " /online /Logpath:3rdPartyDriverlistWindows.log /Loglevel:2 /Get-Drivers /Format:Table"
                ElseIf RadioButton10.Checked = True Then
                    .Arguments = " /Image:" & mtpath & " /Logpath:3rdPartyDriverlistImage.log /Loglevel:2 /Get-Drivers /Format:Table"
                End If
            ElseIf RadioButton6.Checked = True Then
                If RadioButton9.Checked = True Then
                    .Arguments = " /online /Logpath:DriverlistWindows.log /Loglevel:2 /Get-Drivers /All /Format:Table"
                ElseIf RadioButton10.Checked = True Then
                    .Arguments = " /Image:" & mtpath & " /Logpath:DriverlistImage.log /Loglevel:2 /Get-Drivers /All /Format:Table"
                End If
            End If
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim pro As New Process

        pro.StartInfo = p
        pro.Start()
        While (pro.HasExited = False)
            Dim sLine As String = pro.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then
            End If
            Me.TextBox2.AppendText(sLine & vbNewLine)
            Application.DoEvents()
        End While

        ''Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        '' Dim tmp As String
        ''  Do While pro.HasExited = False
        ''tmp = SROutput.ReadLine
        ''  Application.DoEvents()
        ''  If tmp <> "" Then
        ''      Me.TextBox2.AppendText(tmp & vbNewLine)
        ''Application.DoEvents()
        ''  End If
        ''  Application.DoEvents()
        '' Loop

        'Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        'Dim ts As String = SROutput.ReadToEnd()
        'TextBox2.AppendText(ts)
        'pro.WaitForExit()

        'Dim std_out As StreamReader = pro.StandardOutput()
        '' Dim Driverlist As File
        pro.Dispose()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles bb7.Click
        Dim drvfld As New FolderBrowserDialog
        With drvfld
            .ShowNewFolderButton = False
            .Description = "Select Folder where Drivers are stored"
            .ShowDialog()
        End With

        Dim pkgpath As String = drvfld.SelectedPath
        TextBox5.Text = pkgpath
        TextBox2.AppendText(Environment.NewLine + Environment.NewLine)
        TextBox2.AppendText("The Driver folder selected is " & TextBox5.Text & vbNewLine)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles bb8.Click
        DriverWorker.RunWorkerAsync()
        
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles bb9.Click
        Dim p As New ProcessStartInfo
        Dim pacsel As New OpenFileDialog
        With pacsel
            .Filter = "INF Files(*.inf)|*.inf|All Files(*.*)|*.*"
            .Title = "Select Driver"
        End With
        ' TextBox1.Text = ofdlg1.FileName.ToString()
        pacsel.ShowDialog()
        Dim filesel = pacsel.FileName
        TextBox7.Text = pacsel.FileName
        'MsgBox(filepath)
        Dim mtpath = at2.Text
        MsgBox(mtpath)
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If

            ' Examples:
            ' Dism /image:C:\test\offline /Add-Driver /driver:C:\test\drivers\
            ' Dism /image:C:\test\offline /Add-Driver /driver:C:\test\drivers /recurse
            ' Dism /image:C:\test\offline /Add-Driver /driver:C:\test\drivers\mydriver.inf
            ' Dism /image:C:\test\offline /Add-Driver /driver:C:\test\drivers\mydriver.inf /ForceUnsigned
            If CheckBox11.Checked = True Then
                .Arguments = " /image:" & mtpath & " /add-Driver /Driver:" & filesel & " /ForceUnsigned" ' & " /loglevel:3 /logpath:" & apppath & "\packaginglog.txt"
            ElseIf CheckBox11.Checked = False Then
                .Arguments = " /image:" & mtpath & " /add-Driver /Driver:" & filesel
            End If
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()

        ' Dim myStreamReader As StreamReader = pro.StandardOutput
        ' Read the standard output of the spawned process.
        'Dim myString As String = myStreamReader.ReadLine()
        Dim std_out As StreamReader = pro.StandardOutput()
        Dim std_err As StreamReader = pro.StandardError()

        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim tmp As String
        Do While pro.HasExited = False
            tmp = SROutput.ReadLine
            If tmp <> "" Then
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        pro.Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles bb10.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        Form2.ShowDialog()
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles Rb1.CheckedChanged
        If Rb1.Checked = True Then
            cb1.Enabled = False
            cb1.CheckState = CheckState.Unchecked
            cb2.Enabled = False
            cb2.CheckState = CheckState.Unchecked
            cb3.Enabled = False
            cb3.CheckState = CheckState.Unchecked
            Button14.Enabled = False
            TB10.Enabled = False

        End If
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked = True Then
            cb1.Enabled = True
            cb2.CheckState = CheckState.Unchecked
            cb2.Enabled = False
            cb3.Enabled = False
            cb3.CheckState = CheckState.Unchecked
            Button14.Enabled = False
            TB10.Enabled = False
        End If
    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked = True Then
            cb1.Enabled = False
            cb1.CheckState = CheckState.Unchecked
            cb2.Enabled = True
            cb3.Enabled = False
            cb3.CheckState = CheckState.Unchecked
            Button14.Enabled = False
            TB10.Enabled = False

        End If
    End Sub

    Private Sub rb7_CheckedChanged(sender As Object, e As EventArgs) Handles rb7.CheckedChanged
        If rb7.Checked = True Then
            cb1.Enabled = False
            cb2.Enabled = False
            cb3.Enabled = True
            Button14.Enabled = True
            TB10.Enabled = True

        End If
    End Sub

    Private Sub rb4_CheckedChanged(sender As Object, e As EventArgs) Handles rb4.CheckedChanged
        If rb4.Checked = True Then
            cb1.Enabled = False
            cb1.CheckState = CheckState.Unchecked
            cb2.Enabled = False
            cb2.CheckState = CheckState.Unchecked
            cb3.Enabled = False
            cb3.CheckState = CheckState.Unchecked
            Button14.Enabled = False
            TB10.Enabled = False

        End If
    End Sub

    Private Sub rb5_CheckedChanged(sender As Object, e As EventArgs) Handles rb5.CheckedChanged
        If rb5.Checked = True Then
            cb1.Enabled = False
            cb1.CheckState = CheckState.Unchecked
            cb2.Enabled = False
            cb2.CheckState = CheckState.Unchecked
            cb3.Enabled = False
            cb3.CheckState = CheckState.Unchecked
            Button14.Enabled = False
            TB10.Enabled = False

        End If
    End Sub

    Private Sub rb6_CheckedChanged(sender As Object, e As EventArgs) Handles rb6.CheckedChanged
        If rb6.Checked = True Then
            cb1.Enabled = False
            cb1.CheckState = CheckState.Unchecked
            cb2.Enabled = False
            cb2.CheckState = CheckState.Unchecked
            cb3.Enabled = False
            cb3.CheckState = CheckState.Unchecked
            Button14.Enabled = False
            TB10.Enabled = False

        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        'Dism /Unmount-WIM /MountDir:E:\WIN7x64\mount /commit

        Dim p As New ProcessStartInfo
        Dim filepath = TextBox4.Text
        MsgBox(filepath)
        Dim mtpath = at2.Text
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If

            'Dism /Unmount-WIM /MountDir:E:\WIN7x64\mount /commit
            If RadioButton7.Checked = True And CheckBox1.Checked = True Then
                .Arguments = " /Unmount-WIM /MountDir:" & mtpath & " /commit /CheckIntegrity"
            ElseIf RadioButton7.Checked = True And CheckBox1.Checked = False Then
                .Arguments = " /Unmount-WIM /MountDir:" & mtpath & " /commit"
            ElseIf RadioButton8.Checked = True And CheckBox1.Checked = True Then
                .Arguments = " /Unmount-WIM /MountDir:" & mtpath & " /Discard /CheckIntegrity"
            ElseIf RadioButton8.Checked = True And CheckBox1.Checked = False Then
                .Arguments = " /Unmount-WIM /MountDir:" & mtpath & " /Discard"
            End If
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
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        pro.Dispose()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim rb1v As String = Rb1.Text
        Dim rb2v As String = Rb1.Text
        Dim cb1v As String = cb1.Text
        Dim rb3v As String = rb3.Text
        Dim cb2v As String = cb2.Text
        Dim rb4v As String = rb4.Text
        Dim rb5v As String = rb5.Text
        Dim rb6v As String = rb6.Text
        Dim rb7v As String = rb7.Text
        Dim cb3v As String = cb3.Text
        Dim p As New ProcessStartInfo
        Dim filepath = TextBox4.Text
        Dim mtpath = at2.Text
        TextBox2.AppendText(vbNewLine)


        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If

            If RadioButton9.Checked = True Then
                If rb2.Checked = True And cb1.Checked = True Then
                    .Arguments = " /online /Cleanup-Image /SPSuperseded /HideSP"
                ElseIf rb2.Checked = True And cb1.Checked = False Then
                    .Arguments = " /online /Cleanup-Image /SPSuperseded"
                ElseIf rb3.Checked = True And cb2.Checked = True Then
                    .Arguments = " /online /StartComponentCleanup  /ResetBase"
                ElseIf rb3.Checked = True And cb2.Checked = False Then
                    .Arguments = " /online /StartComponentCleanup"
                    'Dism.exe /Online /Cleanup-Image /AnalyzeComponentStore
                ElseIf rb4.Checked = True Then
                    .Arguments = " /online /Cleanup-Image /AnalyzeComponentStore"
                ElseIf rb5.Checked = True Then
                    .Arguments = " /online /Cleanup-Image /CheckHealth"
                ElseIf rb6.Checked = True Then
                    .Arguments = " /online /Cleanup-Image /ScanHealth"
                ElseIf rb7.Checked = True And cb3.Checked = True Then
                    Dim fl As New FolderBrowserDialog
                    With fl
                        .Description = "Select the Windows installation source folder"
                        .ShowDialog()
                    End With
                    TB10.Text = fl.SelectedPath.ToString
                    '/Online /Cleanup-Image /RestoreHealth /Source: /LimitAccess
                    .Arguments = " /online /Cleanup-Image /RestoreHealth /Source:" & fl.SelectedPath & " /LimitAccess"
                ElseIf rb7.Checked = True And cb3.Checked = False Then
                    Dim fl As New FolderBrowserDialog
                    With fl
                        .Description = "Select the Windows installation source folder"
                        .ShowDialog()
                    End With
                    TB10.Text = fl.SelectedPath.ToString
                    '/Online /Cleanup-Image /RestoreHealth /Source: /LimitAccess
                    .Arguments = " /online /Cleanup-Image /RestoreHealth /Source:" & fl.SelectedPath
                End If
            ElseIf RadioButton10.Checked = True Then
                If rb2.Checked = True Then
                    .Arguments = " /image:" & mtpath & " /Cleanup-Image /SPSuperseded /HideSP"
                ElseIf rb2.Checked = True And cb1.Checked = True Then
                    .Arguments = " /image:" & mtpath & " /Cleanup-Image /SPSuperseded /HideSP"
                ElseIf rb2.Checked = True And cb1.Checked = False Then
                    .Arguments = " /image:" & mtpath & " /Cleanup-Image /SPSuperseded"
                ElseIf rb3.Checked = True And cb2.Checked = True Then
                    .Arguments = " /image:" & mtpath & " /StartComponentCleanup  /ResetBase"
                ElseIf rb3.Checked = True And cb2.Checked = False Then
                    .Arguments = " /image:" & mtpath & " /StartComponentCleanup"
                    'Dism.exe /Online /Cleanup-Image /AnalyzeComponentStore
                ElseIf rb4.Checked = True Then
                    .Arguments = " /image:" & mtpath & " /Cleanup-Image /AnalyzeComponentStore"
                ElseIf rb5.Checked = True Then
                    .Arguments = " /image:" & mtpath & " /Cleanup-Image /CheckHealth"
                ElseIf rb6.Checked = True Then
                    .Arguments = " /image:" & mtpath & " /Cleanup-Image /ScanHealth"
                ElseIf rb7.Checked = True And cb3.Checked = True Then
                    Dim fl As New FolderBrowserDialog
                    With fl
                        .Description = "Select the Windows installation source folder"
                        .ShowDialog()
                    End With
                    TB10.Text = fl.SelectedPath.ToString
                    '/Online /Cleanup-Image /RestoreHealth /Source: /LimitAccess
                    .Arguments = " /image:" & mtpath & " /Cleanup-Image /RestoreHealth /Source:" & fl.SelectedPath & " /LimitAccess"
                ElseIf rb7.Checked = True And cb3.Checked = False Then
                    Dim fl As New FolderBrowserDialog
                    With fl
                        .Description = "Select the Windows installation source folder"
                        .ShowDialog()
                    End With
                    TB10.Text = fl.SelectedPath.ToString
                    '/Online /Cleanup-Image /RestoreHealth /Source: /LimitAccess
                    .Arguments = " /image:" & mtpath & " /Cleanup-Image /RestoreHealth /Source:" & fl.SelectedPath
                End If
            End If
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With

        Dim pro As New Process
        pro.StartInfo = p
        Application.DoEvents()
        pro.Start()

        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim tmp As String
        Do While pro.HasExited = False
            tmp = SROutput.ReadLine
            If tmp <> "" Then
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        pro.Dispose()






    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            Rb1.Enabled = False
        ElseIf RadioButton9.Checked = False Then
            Rb1.Enabled = True
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        'Dism /Cleanup-Mountpoints
        Dim p As New ProcessStartInfo
        Dim filepath = TextBox4.Text
        MsgBox(filepath)
        Dim mtpath = at2.Text
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If


            .Arguments = " /Cleanup-Mountpoints"
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
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        pro.Dispose()
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles ab7.Click
        'Dism /Remount-Image /MountDir:C:\test\offline
        Dim mtfolder As New FolderBrowserDialog
        With mtfolder
            .ShowNewFolderButton = True
            .Description = "Select Folder for re-Mounting the Image"
            .ShowDialog()
        End With

        Dim mimgpath As String = mtfolder.SelectedPath
        at2.Text = mimgpath
        TextBox2.AppendText("The folder selected for re-mounting file is  " & at2.Text)

        Dim p As New ProcessStartInfo
        Dim filepath = at1.Text
        MsgBox(filepath)
        Dim mtpath = at2.Text
        Dim ct = NumericUpDown1.Value
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If
            ' Dism /Mount-Image /ImageFile:G:\WIN7Prox64\winpro.wim /index:1 /MountDir:G:\win7pro_mount

            .Arguments = " /Remount-Image /MountDir:" & mtfolder.SelectedPath
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
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        pro.Close()


    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim p As New ProcessStartInfo
        Dim filepath = TextBox4.Text
        TextBox2.AppendText(vbNewLine)
        Dim mtpath = at2.Text

        With p
            .UseShellExecute = False
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If
            ' Dism /Image:C:\test\offline /Get-Packages /Format:Table
            If RadioButton9.Checked = True Then
                .Arguments = " /Online /Get-Features /Format:Table"
            ElseIf RadioButton10.Checked = True Then
                .Arguments = " /Image:" & mtpath & " /Get-Features /Format:Table"
            End If
            .CreateNoWindow = True

        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()

        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim tmp As String
        Do While pro.HasExited = False
            tmp = SROutput.ReadLine
            If tmp <> "" Then
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop

        ' Dim myStreamReader As StreamReader = pro.StandardOutput
        ' Read the standard output of the spawned process.
        'Dim myString As String = myStreamReader.ReadLine()
        ' Dim std_out As StreamReader = pro.StandardOutput()
        '   Dim std_err As StreamReader = pro.StandardError()

        ' Display the results.
        ' TextBox2.Text = std_out.ReadToEndAsync.ToString
        ' TextBox3.Text = std_err.ReadToEnd()

        ' Clean up.
        'std_out.Close()
        ' std_err.Close()
        pro.Dispose()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles bb6.Click
        Dim p As New ProcessStartInfo
        Dim pacsel As New FolderBrowserDialog
        pacsel.ShowNewFolderButton = True
        pacsel.ShowDialog()

        Dim path = pacsel.SelectedPath
        TextBox9.Text = pacsel.SelectedPath
        'MsgBox(filepath)
        Dim mtpath = at2.Text

        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If

            ' Examples:
            ' DISM /Online /Export-Driver /Destination:C:\destpath
            ' DISM /Image:C\test\offline /Export-Driver /Destination:C:\destpath
            If RadioButton9.Checked = True Then
                .Arguments = " /Online /Export-Driver /Loglevel:2 /LogPath:ExportSystemDriver.log /Destination:" & path
            ElseIf RadioButton10.Checked = True Then
                .Arguments = " /image:" & mtpath & " /Export-Driver /Loglevel:2 /LogPath:ExportImageDriver.log /Destination:" & path
            End If
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()

        ' Dim myStreamReader As StreamReader = pro.StandardOutput
        ' Read the standard output of the spawned process.
        'Dim myString As String = myStreamReader.ReadLine()
        Dim std_out As StreamReader = pro.StandardOutput()
        Dim std_err As StreamReader = pro.StandardError()

        Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        Dim tmp As String
        Do While pro.HasExited = False
            tmp = SROutput.ReadLine
            If tmp <> "" Then
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        pro.Dispose()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Dim p As New ProcessStartInfo
        Dim filepath = TextBox4.Text
        TextBox2.AppendText(vbNewLine)
        Dim mtpath = at2.Text

        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If
            ' Dism /Image:C:\test\offline /Get-Packages /Format:Table
            If RadioButton9.Checked = True Then
                .Arguments = " /Online /Get-Packages /Format:Table"
            ElseIf RadioButton10.Checked = True Then
                .Arguments = " /Image:" & mtpath & " /get-packages /Format:Table"
            End If
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
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        pro.Close()
        ' Me.TextBox2.Text += "Completed"
        ' Dim SROutput As System.IO.StreamReader = pro.StandardOutput
        '  Dim ts As String = SROutput.ReadToEnd()
        'TextBox2.AppendText(ts)
        ' Application.DoEvents()
        '  pro.WaitForExit()

        ' Dim myStreamReader As StreamReader = pro.StandardOutput
        ' Read the standard output of the spawned process.
        'Dim myString As String = myStreamReader.ReadLine()
        ' Dim std_out As StreamReader = pro.StandardOutput()
        '   Dim std_err As StreamReader = pro.StandardError()

        ' Display the results.
        ' TextBox2.Text = std_out.ReadToEndAsync.ToString
        ' TextBox3.Text = std_err.ReadToEnd()

        ' Clean up.
        'std_out.Close()
        ' std_err.Close()

    End Sub

    Private Sub pkginstaller_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles pkginstaller.DoWork
        Dim p As New ProcessStartInfo
        Dim filepath = TextBox4.Text
        MsgBox(filepath)
        Dim mtpath = at2.Text
        MsgBox(mtpath)
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False

            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If
            ' dism /image:E:\WIN7x64\mount /add-package /packagepath:E:\WIN7x64\updates\msu /loglevel:1 /logpath:E:\WIN7x64\tools


            If RadioButton9.Checked = True Then
                .Arguments = " /online /add-package /packagepath:" & filepath
            ElseIf RadioButton10.Checked = True Then
                .Arguments = " /image:" & mtpath & " /add-package /packagepath:" & filepath ' & " /loglevel:3 /logpath:" & apppath & "\packaginglog.txt"
            End If

            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        Dim pro As New Process
        pro.StartInfo = p
        pro.Start()

        ' Dim myStreamReader As StreamReader = pro.StandardOutput
        ' Read the standard output of the spawned process.
        'Dim myString As String = myStreamReader.ReadLine()
        Dim std_out As StreamReader = pro.StandardOutput()
        Dim std_err As StreamReader = pro.StandardError()



        'While (pro.HasExited = False)
        '    Dim sLine As String = pro.StandardOutput.ReadLine
        '    If (Not String.IsNullOrEmpty(sLine)) Then
        '    End If
        '    Me.TextBox2.Text &= sLine & vbCrLf & vbNewLine
        '    Application.DoEvents()
        'End While
        'Me.TextBox2.Text += "Completed"
        While (pro.HasExited = False)
            Dim sLine As String = pro.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then
            End If
            Me.TextBox2.AppendText(sLine & vbNewLine)
            Application.DoEvents()
            Dim fom As New Form
            Dim pg As New ProgressBar
            pg.Parent = fom
            pg.Show()
        End While

        pro.Close()
    End Sub

    Private Sub DriverWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DriverWorker.DoWork
        Dim p As New ProcessStartInfo
        Dim filepath = TextBox5.Text
        MsgBox(filepath)
        Dim mtpath = at2.Text
        MsgBox(mtpath)
        TextBox2.AppendText(vbNewLine)
        With p
            .UseShellExecute = False
            If RadioButton1.Checked = True Then
                Dim filever As String = "\lib\w10\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton2.Checked = True Then
                Dim filever As String = "\lib\w10\x86\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton3.Checked = True Then
                Dim filever As String = "\lib\w8\x64\DISm.exe"
                .FileName = apppath & filever
            ElseIf RadioButton4.Checked = True Then
                Dim filever As String = "\lib\w8\x86\DISm.exe"
                .FileName = apppath & filever
            End If
            ' The following driver servicing options are available for an offline image.
            ' DISM.exe /image:<path_to_image_directory> [/Get-Drivers | /Get-DriverInfo | /Add-Driver | /Remove-Driver | /Export-Driver]
            ' The following driver servicing options are available for a running operating system.
            ' DISM.exe /Online [/Get-Drivers | /Get-DriverInfo | /Export-Driver]

            ' Examples:
            ' Dism /image:C:\test\offline /Add-Driver /driver:C:\test\drivers\
            ' Dism /image:C:\test\offline /Add-Driver /driver:C:\test\drivers /recurse
            ' Dism /image:C:\test\offline /Add-Driver /driver:C:\test\drivers\mydriver.inf
            ' Dism /image:C:\test\offline /Add-Driver /driver:C:\test\drivers\mydriver.inf /ForceUnsigned
            If CheckBox11.Checked = True Then
                .Arguments = " /image:" & mtpath & " /add-Driver /Driver:" & filepath & " /Recurse /ForceUnsigned" ' & " /loglevel:3 /logpath:" & apppath & "\packaginglog.txt"
            ElseIf CheckBox11.Checked = False Then
                .Arguments = " /image:" & mtpath & " /add-Driver /Driver:" & filepath & " /Recurse"
            End If

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
                Me.TextBox2.AppendText(tmp & vbNewLine)
                Application.DoEvents()
            End If
            Application.DoEvents()
        Loop
        pro.Dispose()
    End Sub

    Private Sub bb11_Click(sender As Object, e As EventArgs) Handles bb11.Click

    End Sub
End Class