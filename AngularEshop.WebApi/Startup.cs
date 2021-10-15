using AngularEshop.Core.Services.Inplementation;
using AngularEshop.Core.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using AngularEshop.Core.Utilites.Extentions.Connection;
using AngularEshop.DataLayer.Repository;

namespace AngularEshop.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostEnvironment hostEnvironment)
        {
            Configuration = configuration;
            HostingEnvironment = hostEnvironment;
        }

        public IConfiguration Configuration { get; }
        public IHostEnvironment HostingEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            /*services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);*/


            /*   services.AddSingleton<IConfiguration>(
                   new ConfigurationBuilder()
                       .SetBasePath(Dictionary.GetCurrentDirectpry())
                       .AddJsonFile($"appsettings.json")
                       .Build()
                   );*/

            #region AddDbcontex

            services.AddApplicationDbContext(Configuration);
            
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            #endregion

            #region Application Service

            services.AddScoped<IUserService,UserService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<IProductService, ProductService>();


            #endregion



            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AngularEshop.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AngularEshop.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseStaticFiles();

/*            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{Controller=Users}/{action=Users}/{id?}"
                );
            });*/
        }
    }
}
