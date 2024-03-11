using ExamBlazorApp1.Client.Services;
using ExamBlazorApp1.Components;
using ExamBlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ExamBlazorApp1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddDbContext<ProductDb>(opt =>
			opt.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProductsDBExam2;Trusted_Connection=True")
			);


			builder.Services.AddControllers().AddJsonOptions(options =>
			{
				options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
			});

			//builder.Services.AddScoped(sp => new HttpClient());


			//builder.Services.AddScoped<ProductSevice>();


			builder.Services.AddHttpClient<ProductSevice>();


			builder.Services.AddRazorComponents()
				.AddInteractiveServerComponents()
				.AddInteractiveWebAssemblyComponents();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseWebAssemblyDebugging();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();

			app.UseStaticFiles();
			app.UseAntiforgery();


			app.MapControllers();

			app.MapRazorComponents<App>()
				.AddInteractiveServerRenderMode()
				.AddInteractiveWebAssemblyRenderMode()
				.AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

			app.Run();
		}
	}
}
