#Use this file to install Azure DevOps Deployment Group Agent prerequisites#
######################   Region Start   ####################################
############################################################################
<#Please explain the significance of each command.
#OPTIONAL, Install .NET Hosting Bundle
##https://dotnet.microsoft.com/download/dotnet/5.0

# Run these commands below before installing PowerShell Module AZ. On a seperate PowerShell.exe (Non-ISE), run these commands before using the deployment group script.
$webClient = New-Object -TypeName System.Net.WebClient
$webClient.Proxy.Credentials = [System.Net.CredentialCache]::DefaultNetworkCredentials
[Net.ServicePointManager]::SecurityProtocol = [Net.ServicePointManager]::SecurityProtocol -bor [Net.SecurityProtocolType]::Tls12

# Run these commands below seperately and select "Yes" when prompted.
Register-PSRepository -Default -Verbose

# Run these commands below seperately and select "Yes" when prompted.
Set-PSRepository -Name "PSGallery" -InstallationPolicy Trusted

# Run these commands below seperately and select "Yes" when prompted.
Install-Module -Name PowerShellGet -Force

# Run these commands below seperately and select "Yes" when prompted.
Install-Module -Name Az -Repository PSGallery -AllowClobber -Force

# Run these commands below seperately and select "Yes" when prompted.
Invoke-WebRequest -Uri https://aka.ms/installazurecliwindows -OutFile .\AzureCLI.msi; Start-Process msiexec.exe -Wait -ArgumentList '/I AzureCLI.msi /quiet'; rm .\AzureCLI.msi
#>
######################   Region End   #####################################