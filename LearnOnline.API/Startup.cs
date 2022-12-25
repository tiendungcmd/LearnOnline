using LearnOnline.API.Data;
using LearnOnline.API.Services.AuthService;
using LearnOnline.API.Services.NewsService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;

namespace LearnOnline.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LearnOnline.API", Version = "v1" });
            });
            services.AddDbContextPool<LearnOnlineDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("LearnOnlineConnection"))
            );
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<INewService, NewService>();
            services.AddHttpContextAccessor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LearnOnline.API v1"));
            }
            app.UseCors(policy =>
                policy.WithOrigins("http://localhost:44323", "https://localhost:44323")
                .AllowAnyMethod()
                .WithHeaders(HeaderNames.ContentType)
            );
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
