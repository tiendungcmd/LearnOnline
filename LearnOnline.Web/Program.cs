using LearnOnline.Web.Service;
using LearnOnline.Web.Services.AuthService;
using LearnOnline.Web.Services.NewService;
using LearnOnline.Web.Services.PartService;
using LearnOnline.Web.Services.Upload;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LearnOnline.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44330/") });
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<INewService, NewService>();
            builder.Services.AddScoped<IPartService, PartService>();
            builder.Services.AddScoped<IFileUpload, FileUpload>();
            await builder.Build().RunAsync();
        }
    }
}
