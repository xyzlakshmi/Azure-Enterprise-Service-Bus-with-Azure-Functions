Install-Module AzureRM -Scope CurrentUser 
 $UserName = 'Manjunath_s07@infosys.com'
 $password = 'cd..'
 $subscriptionId = '02a0c632-86b4-4972-8b2a-c20752d297f8'
 #$credential = New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList ($UserName, $password)
 #Login-AzureRmAccount -Credential $credential
 #Select-AzureRmSubscription -SubscriptionId $subscriptionId

 Login-AzureRmAccount
 Select-AzureRmSubscription -SubscriptionId $subscriptionId

New-AzureRmResourceGroup -Name examplegroup -Location "South Central US"
New-AzureRmResourceGroupDeployment -ResourceGroupName examplegroup -TemplateFile D:\Architecture\azure\AzureResourceTemplates\azureservicebus.json 
