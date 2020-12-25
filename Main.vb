Imports System.IO
Imports System.Environment
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Text
Public Class Main

    Private Sub FileReplace(sender As Object, e As EventArgs) Handles FileReplace_btn.Click
        'ทับไฟล์ EasyAntiCheat จาก Resources ลงไปในตำแหน่งของ EasyAntiCheat ในเครื่อง
        Dim adtpath = GetFolderPath(SpecialFolder.ApplicationData)
        Dim pgfpath = GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
        Dim gamepath = Directory.GetCurrentDirectory
        If Directory.Exists(adtpath & "\EasyAntiCheat") Then
            Directory.Delete(adtpath & "\EasyAntiCheat", True)
            Directory.CreateDirectory(adtpath & "\EasyAntiCheat")
            Directory.CreateDirectory(adtpath & "\EasyAntiCheat\525")
            File.WriteAllText(adtpath & "\EasyAnticheat\gamelauncher.log", My.Resources.gamelauncher)
            File.WriteAllBytes(adtpath & "\EasyAnticheat\525\easyanticheat_wow64.eac", My.Resources.easyanticheat_wow64)
            File.WriteAllBytes(adtpath & "\EasyAnticheat\525\easyanticheat_wow64.eac.metadata", My.Resources.easyanticheat_wow64_eac)
            File.WriteAllText(adtpath & "\EasyAntiCheat\525\loader.log", My.Resources.loader)
            log.Items.Add(System.DateTime.Now & " - - [Log] File Replaced")
        Else
            Try
                Directory.CreateDirectory(adtpath & "\EasyAntiCheat")
                Directory.CreateDirectory(adtpath & "\EasyAntiCheat\525")
                File.WriteAllText(adtpath & "\EasyAnticheat\gamelauncher.log", My.Resources.gamelauncher)
                File.WriteAllBytes(adtpath & "\EasyAnticheat\525\easyanticheat_wow64.eac", My.Resources.easyanticheat_wow64)
                File.WriteAllBytes(adtpath & "\EasyAnticheat\525\easyanticheat_wow64.eac.metadata", My.Resources.easyanticheat_wow64_eac)
                File.WriteAllText(adtpath & "\EasyAntiCheat\525\loader.log", My.Resources.loader)
                log.Items.Add(System.DateTime.Now & " - - [Log] File Replaced")
            Catch ex As Exception
                log.Items.Add(System.DateTime.Now & " - - [Log] File Replace Error")
                log.Items.Add("[Error] " & ex.Message)
            End Try
        End If

        If Directory.Exists(pgfpath & "\EasyAntiCheat") Then
            Try
                Directory.Delete(pgfpath & "\EasyAntiCheat", True)
                Directory.CreateDirectory(pgfpath & "\EasyAntiCheat")
                File.WriteAllBytes(pgfpath + "\EasyAntiCheat\EasyAntiCheat.sys", My.Resources.EasyAntiCheatsys)
                File.WriteAllBytes(pgfpath + "\EasyAntiCheat\EasyAntiCheat.exe", My.Resources.EasyAntiCheat)
                log.Items.Add(System.DateTime.Now & " - - [Log] File Replaced 2")
            Catch ex As Exception
                log.Items.Add(System.DateTime.Now & " - - [Log] File Replace 2 Error")
                log.Items.Add("[Error] " & ex.Message)
            End Try
        Else
            Try
                Directory.CreateDirectory(pgfpath & "\EasyAntiCheat")
                File.WriteAllBytes(pgfpath + "\EasyAntiCheat\EasyAntiCheat.sys", My.Resources.EasyAntiCheatsys)
                File.WriteAllBytes(pgfpath + "\EasyAntiCheat\EasyAntiCheat.exe", My.Resources.EasyAntiCheat)
                log.Items.Add(System.DateTime.Now & " - - [Log] File Replaced 2")
            Catch ex As Exception
                log.Items.Add(System.DateTime.Now & " - - [Log] File Replace 2 Error")
                log.Items.Add("[Error] " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub StartRagnarok(sender As Object, e As EventArgs) Handles StartRO_btn.Click
        'เริ่มเกม Ragnarok โดยผ่านตัว EasyAntiCheat.exe เพื่อจะได้เข้าเกมโดยไม่ต้องผ่านตัว Launcher
        Try
            Dim arg As String = "/ Ragexe.exe' LaunchParameters: '1rag1 -eac_executablename ""Ragexe.exe"""
            Dim p As New ProcessStartInfo
            p.FileName = "EasyAntiCheat.exe"
            p.Arguments = arg
            Process.Start(p)
            log.Items.Add(System.DateTime.Now & " - - [Log] Start RO")
        Catch ex As Exception
            log.Items.Add(System.DateTime.Now & " - - [Log] Start RO Error")
            log.Items.Add("[Error] " & ex.Message)
        End Try

    End Sub

    Private Async Sub VerifyFile(sender As Object, e As EventArgs) Handles Verify_btn.Click
        'ปิด Firewall ของตัว EasyAntiCheat ไม่ให้มันโหลด EasyAntiCheat ตัวใหม่ เพื่อจะได้ใช้ EasyAntiCheat เวอร์ชั่นเก่าที่เรากำหนด
        'โดยการสร้าง .bat file ที่มีคำสั่งให้ไป block การดาวน์โหลด EasyAntiCheat ตัวใหม่
        Try
            progbar.Visible = True
            Dim gamepath = Directory.GetCurrentDirectory + "\EasyAntiCheat.exe"
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\verify.bat", "netsh firewall set opmode enable" & vbNewLine & "netsh advfirewall firewall add rule name=""ADS BLOCK"" dir=out action=block program=" + Chr(34) + gamepath + Chr(34) + " enable=yes" & vbNewLine & "netsh advfirewall firewall add rule name=""ADS BLOCK"" dir=in action=block program=" + Chr(34) + gamepath + Chr(34) + " enable=yes")
            progbar.Value = progbar.Value + 25
            Dim startVerify As New ProcessStartInfo(My.Computer.FileSystem.SpecialDirectories.Temp + "\verify.bat")
            startVerify.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(startVerify)
            progbar.Value = progbar.Value + 25
            Await Task.Delay(5000)
            progbar.Value = progbar.Value + 25
            File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp + "\verify.bat")
            progbar.Value = progbar.Value + 25
            log.Items.Add(System.DateTime.Now & " - - [Log] File Verified RO")
            Await Task.Delay(1000)
            progbar.Visible = False
        Catch ex As Exception
            log.Items.Add(System.DateTime.Now & " - - [Log] Verify File Error")
            log.Items.Add("[Error] " & ex.Message)
        End Try

    End Sub

    Private Sub ClearLog(sender As Object, e As EventArgs) Handles Clear_btn.Click
        log.Items.Clear()
    End Sub

    Private Async Sub Reset(sender As Object, e As EventArgs) Handles Reset_btn.Click
        'คืนค่า Firewall ทั้งหมดโดยการ Reset
        Try
            Dim reset_firewall As String = "netsh advfirewall reset"
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\fw_reset.bat", reset_firewall)
            Dim start_reset As New ProcessStartInfo(My.Computer.FileSystem.SpecialDirectories.Temp + "\fw_reset.bat")
            start_reset.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(start_reset)
            Await Task.Delay(3000)
            File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp + "\fw_reset.bat")
            log.Items.Add(System.DateTime.Now & " - - [Log] Reset")
        Catch ex As Exception
            log.Items.Add(System.DateTime.Now & " - - [Log] Reset Error")
            log.Items.Add("[Error] " & ex.Message)
        End Try
    End Sub
End Class
