using System;
using Azure.Identity;
using System.Threading.Tasks;

namespace azure_sdk_for_net_examples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Get all resources in a resource group
            var subscriptionId = "";
            var resourceGroupName = "";

            // Login with azure cli, azure psh, vscode, visual studio, before running locally.
            var cred = new DefaultAzureCredential();
            var client = new Azure.ResourceManager.Resources.ResourcesManagementClient(subscriptionId, cred);
            var resources = client.Resources.ListByResourceGroupAsync(resourceGroupName);
            await foreach (var resource in resources)
            {
                Console.WriteLine(resource.Name);
            }
        }
    }
}
