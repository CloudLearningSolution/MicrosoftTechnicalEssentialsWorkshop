#Install Microsoft Azure PowerShell and required dependencies#
#Region Begin
<#
#$webClient = New-Object -TypeName System.Net.WebClient
#$webClient.Proxy.Credentials = [System.Net.CredentialCache]::DefaultNetworkCredentials

#[Net.ServicePointManager]::SecurityProtocol = [Net.ServicePointManager]::SecurityProtocol -bor [Net.SecurityProtocolType]::Tls12

#Register-PSRepository -Default -Verbose
#Set-PSRepository -Name "PSGallery" -InstallationPolicy Trusted

#Install-Module -Name PowerShellGet -Force

#Install-Module -Name Az -Repository PSGallery -Force

# Invoke-WebRequest -Uri https://aka.ms/installazurecliwindows -OutFile .\AzureCLI.msi; Start-Process msiexec.exe -Wait -ArgumentList '/I AzureCLI.msi /quiet'; rm .\AzureCLI.msi
#>
#Region End