Install-Module AzureRM -Scope CurrentUser 
 $UserName = 'Manjunath_s07@infosys.com'
 $pass = 'Infy$123'
 $subscriptionId = '02a0c632-86b4-4972-8b2a-c20752d297f8'

Login-AzureRmAccount
Select-AzureRmSubscription -SubscriptionId $subscriptionId

New-AzureRmResourceGroup -Name testgroup -Location "Central India"
New-AzureRmResourceGroupDeployment -ResourceGroupName testgroup -TemplateFile D:\Architecture\azure\AzureResourceTemplates\AzureServiceBus_ARM.json  -TemplateParameterFile D:\Architecture\azure\AzureResourceTemplates\AzureServiceBus_ARM.Parameters.json
