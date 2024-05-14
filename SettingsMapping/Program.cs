using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using WebApi.Helpers;

Console.WriteLine("Hello, Settings Mapping World!");

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false).Build();

var appSettings = config.GetSection("ApplicationSettings").Get<ApplicationSettings>();

Console.WriteLine($"App settings: secret = '{appSettings?.SecretKey}'");
