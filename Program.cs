using Microsoft.AspNetCore.Hosting;
using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Azure.Security.KeyVault.Secrets;
using Azure.Extensions.AspNetCore.Configuration.Secrets;

namespace TFTEC.Web.Ecommerce;
public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureAppConfiguration((context, config) =>
        {
            //var buildConfig = config.Build();

            //string kvURL = buildConfig["KeyVaultTFTEC:KVUrl"];
            //string tenantId = buildConfig["KeyVaultTFTEC:TenantId"];
            //string clientId = buildConfig["KeyVaultTFTEC:ClientId"];
            //string clientSecret = buildConfig["KeyVaultTFTEC:ClientSecretId"];

            //var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);  

            //var keyVaultEndpoint = new SecretClient(new Uri(kvURL), credential);
            //config.AddAzureKeyVault(keyVaultEndpoint, new AzureKeyVaultConfigurationOptions());
        })
        .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
