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

# CREATE VMSS
#IMPORTANT: DO NOT EDIT THE COMMENTED SECTION BELOW. Developed by DAVID SANTANA.
#Region Start.. Implementing Fault Tolerant Virtual Machine Scaled Sets

#TODO: create a unique name value of type string
#TODO: Example 1: pharmakinematicsrg, pharmakinematicsvmss, ( eastus, centralus, westus ), pharmakinematicsvnet, private, pharmakinematicspublicip, pharmakinematicslb, pharmakinematicsnsgrule, pharmakinematicsnsg .

# Provide your own secure password for use with the VM instances
$cred = Get-Credential
$resourcegroupname = "<place holder>"
$vmscalesetname = "<place holder>"
$location = "<place holder>"
$virtualnetworkname = "<place holder>"
$subnetname = "<place holder>"
$publicipaddressname = "<place holder>"
$loadbalancername = "<place holder>"
$networksecuritygrouprulename = "<place holder>"
$networksecuritygroupname = "<place holder>"



# Create a virtual machine scale set and supporting resources
# A resource group, virtual network, load balancer, and NAT rules are automatically
# created if they do not already exist
New-AzVmss `
  -ResourceGroupName $resourcegroupname `
  -VMScaleSetName $vmscalesetname `
  -Location $location `
  -VirtualNetworkName $virtualnetworkname `
  -SubnetName $subnetname `
  -PublicIpAddressName $publicipaddressname `
  -LoadBalancerName $loadbalancername `
  -UpgradePolicyMode "Automatic" `
  -Credential $cred `
  -Zone "1", "2"

# Define the script for your Custom Script Extension to run
$publicSettings = @{
    "fileUris" = (,"https://<place holder>/automate-iis.ps1");
    "commandToExecute" = "powershell -ExecutionPolicy Unrestricted -File <place holder>.ps1"
}

# Get information about the scale set
$vmss = Get-AzVmss `
            -ResourceGroupName $resourcegroupname `
            -VMScaleSetName $vmscalesetname

# Use Custom Script Extension to install IIS and configure basic website
Add-AzVmssExtension -VirtualMachineScaleSet $vmss `
  -Name "customScript" `
  -Publisher "Microsoft.Compute" `
  -Type "CustomScriptExtension" `
  -TypeHandlerVersion 1.9 `
  -Setting $publicSettings

# Update the scale set and apply the Custom Script Extension to the VM instances
Update-AzVmss `
  -ResourceGroupName $resourcegroupname `
  -Name $vmscalesetname `
  -VirtualMachineScaleSet $vmss

#Create a rule to allow traffic over port 80
$nsgFrontendRule = New-AzNetworkSecurityRuleConfig `
  -Name $networksecuritygrouprulename `
  -Protocol Tcp `
  -Direction Inbound `
  -Priority 200 `
  -SourceAddressPrefix * `
  -SourcePortRange * `
  -DestinationAddressPrefix * `
  -DestinationPortRange 80, 3389, 443 `
  -Access Allow

#Create a network security group and associate it with the rule
$nsgFrontend = New-AzNetworkSecurityGroup `
  -ResourceGroupName  $resourcegroupname `
  -Location eastus `
  -Name $networksecuritygroupname `
  -SecurityRules $nsgFrontendRule

$vnet = Get-AzVirtualNetwork `
  -ResourceGroupName  $resourcegroupname `
  -Name $virtualnetworkname

$frontendSubnet = $vnet.Subnets[0]

$frontendSubnetConfig = Set-AzVirtualNetworkSubnetConfig `
  -VirtualNetwork $vnet `
  -Name $subnetname `
  -AddressPrefix $frontendSubnet.AddressPrefix `
  -NetworkSecurityGroup $nsgFrontend

Set-AzVirtualNetwork -VirtualNetwork $vnet

Get-AzPublicIpAddress -ResourceGroupName $resourcegroupname | Select IpAddress

#Region End...