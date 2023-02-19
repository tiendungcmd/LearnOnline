using Blazored.LocalStorage;
using Blazored.SessionStorage;
using LearnOnline.Web.Service;
using LearnOnline.Web.Services;
using LearnOnline.Web.Services.AuthService;
using LearnOnline.Web.Services.CategoryService;
using LearnOnline.Web.Services.NewService;
using LearnOnline.Web.Services.PartService;
using LearnOnline.Web.Services.Upload;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
//using Syncfusion.Blazor;
namespace LearnOnline.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjA0NzI4QDMyMzAyZTMxMmUzMElnd0owNjFveXpldXBBVW9aQ3BkR2VGQUZRK2doVFZPak92T2VzNm5MR1k9");
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44330/") });
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<INewService, NewService>();
            builder.Services.AddScoped<IPartService, PartService>();
            builder.Services.AddScoped<UploadFile>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddBlazoredSessionStorage();
            builder.Services.AddBlazoredLocalStorage();
            //  builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
