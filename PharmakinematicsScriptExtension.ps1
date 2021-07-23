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

Add-WindowsFeature Web-Server

# Create directory and default page for Contoso
New-Item -Path "C:\Users\globaladministrator\Pharmakinematics\repo" -Type "Directory"
Set-Content -Path "C:\inetpub\wwwroot\Default.htm" -Value "Pharmakinematics Azure virtual machine host name: $($env:computername) !"
Set-Content -Path "C:\inetpub\wwwroot\iisstart.htm" -Value "Pharmakinematics Azure virtual machine host name: $($env:computername) !"

#################################################################################################################################
#Region Begin
<# Notes: configuring Virtual Machine Scale Sets
#
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
##END<body\>#>
#Region End

