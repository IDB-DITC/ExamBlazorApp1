using ExamBlazorApp1.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace ExamBlazorApp1.Client
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);

			builder.Services.AddScoped(sp => new HttpClient());


			builder.Services.AddScoped<ProductSevice>();

			//builder.Services.AddHttpClient<ProductSevice>();



			await builder.Build().RunAsync();
		}
	}
}
