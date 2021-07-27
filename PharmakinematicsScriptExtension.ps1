#!/bin/bash

# The Fast Lane License ()
<#
# Copyright (c) 2021 Fast Lane
#
# Permission is hereby granted, free of charge, to any person obtaining a copy
# of this software and associated documentation files (the "Software"), to deal
# in the Software without restriction, including without limitation the rights
# to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
# copies of the Software, and to permit persons to whom the Software is
# furnished to do so, subject to the following conditions:
# 
# The above copyright notice and this permission notice shall be included in all
# copies or substantial portions of the Software.
# 
# THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
# IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
# FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
# AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
# LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
# OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
# SOFTWARE.
#>

# Fast Lane Custom Script Extension V2

# Execution Policy
Set-ExecutionPolicy -ExecutionPolicy Unrestricted -Force

# Windows Server Roles and Features
Add-WindowsFeature Web-Server
Add-WindowsFeature Web-Mgmt-Console
Add-WindowsFeature Web-Mgmt-Service

# Directory
New-Item -Path "C:\Users\globaladministrator\Pharmakinematics\repo" -Type "Directory"

# Internet Information Services root paths
Set-Content -Path "C:\inetpub\wwwroot\Default.htm" -Value "Pharmakinematics Azure virtual machine host name: $($env:computername) !"
Set-Content -Path "C:\inetpub\wwwroot\iisstart.htm" -Value "Pharmakinematics Azure virtual machine host name: $($env:computername) !"

# Visual Studio
$url = "https://download.visualstudio.microsoft.com/download/pr/acfc792d-506b-4868-9924-aeedc61ae654/2bd17dff1d520ad302d59b06f417097061d7e38a7dcac3099fef906e9c73a331/vs_Community.exe"
$downloadPath = "C:\Users\globaladministrator\Pharmakinematics\repo"
$filePath = "C:\Users\globaladministrator\Pharmakinematics\repo\vs_Community.exe"
Invoke-WebRequest -URI $url -OutFile $filePath

# Visual Studio Workload Component IDs
Start-Process -FilePath "vs_Community" -WorkingDirectory "C:\Users\globaladministrator\Pharmakinematics\repo" -ArgumentList "--passive", "--norestart", "--add Microsoft.VisualStudio.Workload.Azure", "--add Microsoft.VisualStudio.Workload.Data", "--add Microsoft.VisualStudio.Workload.ManagedDesktop", "--add Microsoft.VisualStudio.Workload.NetCoreTools", "--add Microsoft.VisualStudio.Workload.NetWeb", "--add Component.GitHub.VisualStudio", "--add Microsoft.Component.ClickOnce", "--add Microsoft.Net.Component.4.7.2.SDK", "--add Microsoft.VisualStudio.Component.Git", "--layout $downloadPath", "--includeRecommended" -Wait

# Verify Workload Layout
# Start-Process -FilePath "vs_Community" -WorkingDirectory "C:\Users\globaladministrator\Pharmakinematics\repo" -ArgumentList "--passive", "--layout $downloadPath"

# Execute Setup
Start-Process -FilePath "vs_setup.exe" -WorkingDirectory "C:\Users\globaladministrator\Pharmakinematics\repo" -ArgumentList "--passive" -Wait
