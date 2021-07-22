#!/bin/bash

# The Fast Lane License ()
#
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

# Option 1: Custom script extension to install a webserver
# Notes: Use this if you are creating individual Virtual Machines during virtual machine creation tasks
Add-WindowsFeature Web-Server

# Create directory and default page for Contoso
New-Item -Path "C:\inetpub\wwwroot\Pharmakinematics" -Type "Directory"
Set-Content -Path "C:\inetpub\wwwroot\Pharmakinematics\Default.htm" -Value "Pharmakinematics website on host $($env:computername) !"

# Create IIS app pool and web site for Contoso
New-WebAppPool -Name "PharmakinematicsAppPool"
New-WebSite -Name "Pharmakinematics Web Site" -IPAddress "*" -Port 80 -HostHeader "Pharmakinematics" -PhysicalPath "C:\inetpub\Pharmakinematics" -ApplicationPool "PharmakinematicsAppPool"

# Alternatively you can define multiple directories and default pages for Pharmakinematics by copying the previous lines of code.


#################################################################################################################################
# Option 2: Custom script extension to install a webserver
# Option 2: Clone files from github or any URI and then run the command to execute powershell using custom script extensions.
# Notes: This section for configuring Virtual Machine Scale Sets
# Begining<body>
#
# Use Azure CloudShell IDE and Azure PowerShell Module. TODO:
# Show the resource groups
##Get-AzResourceGroup
# Get all Vmss in a resource group
##Get-AzVmss -ResourceGroupName "<place holder>"
# Notes: retrieve Virtual Machine Scale Set name value from output
# 
#$customConfig = @{
##"fileUris" = (,"https://raw.githubusercontent.com/<place holder>/<place holder>/main/<replace place holder with directory path including file name>");
##"commandToExecute" = "powershell -ExecutionPolicy Unrestricted -File PharmakinematicsScriptExtension.ps1"
#}
#
#
#$vmss = Get-AzVmss `
##        -ResourceGroupName "<place holder>" `
##        -VMScaleSetName "<place holder>"
#
# Add the Custom Script Extension to install IIS and configure basic website
#$vmss = Add-AzVmssExtension `
##-VirtualMachineScaleSet $vmss `
##-Name "customScript" `
##-Publisher "Microsoft.Compute" `
##-Type "CustomScriptExtension" `
##-TypeHandlerVersion 1.9 `
##-Setting $customConfig
##
# Update the scale set and apply the Custom Script Extension to the VM instances
#Update-AzVmss `
##-ResourceGroupName "<place holder>" `
##-Name "<place holder>" `
##-VirtualMachineScaleSet $vmss
#
##END<body\>

