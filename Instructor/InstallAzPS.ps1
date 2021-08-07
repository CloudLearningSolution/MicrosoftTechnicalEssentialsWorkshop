#Install Microsoft Azure PowerShell and required dependencies#
#Region Begin
<#
##https://dotnet.microsoft.com/download/dotnet/5.0

$webClient = New-Object -TypeName System.Net.WebClient
$webClient.Proxy.Credentials = [System.Net.CredentialCache]::DefaultNetworkCredentials
[Net.ServicePointManager]::SecurityProtocol = [Net.ServicePointManager]::SecurityProtocol -bor [Net.SecurityProtocolType]::Tls12

# Install IIS
##Install-WindowsFeature Web-Server,Web-Asp-Net45,NET-Framework-Features

Register-PSRepository -Default -Verbose
Set-PSRepository -Name "PSGallery" -InstallationPolicy Trusted

Install-Module -Name PowerShellGet -Force
Install-Module -Name Az -Repository PSGallery -Force

# Restart the web server so that system PATH updates take effect
Stop-Service was -Force
Start-Service w3svc

# Invoke-WebRequest -Uri https://aka.ms/installazurecliwindows -OutFile .\AzureCLI.msi; Start-Process msiexec.exe -Wait -ArgumentList '/I AzureCLI.msi /quiet'; rm .\AzureCLI.msi
#>
#Region End