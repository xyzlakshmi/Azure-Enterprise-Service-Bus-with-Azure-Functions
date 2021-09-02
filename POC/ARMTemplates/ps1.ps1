Install-Module AzureRM -Scope CurrentUser 
 $UserName = ''
 $password = 'cd..'
 $subscriptionId = ''
 #$credential = New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList ($UserName, $password)
 #Login-AzureRmAccount -Credential $credential
 #Select-AzureRmSubscription -SubscriptionId $subscriptionId

 Login-AzureRmAccount
 Select-AzureRmSubscription -SubscriptionId $subscriptionId

New-AzureRmResourceGroup -Name examplegroup -Location "South Central US"
New-AzureRmResourceGroupDeployment -ResourceGroupName examplegroup -TemplateFile D:\Architecture\azure\AzureResourceTemplates\azureservicebus.json 
