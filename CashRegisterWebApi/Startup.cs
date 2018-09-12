using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CashRegisterWebApi.Data;
using Microsoft.EntityFrameworkCore;
using CashRegisterWebApi.Services;
using CashRegisterWebApi.Services.Discount;

namespace CashRegisterWebApi
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
            services.AddDbContext<CashRegisterDbContext>(
              options => options.UseSqlServer(Configuration.GetConnectionString("CashRegisterConnection")));
            services.AddScoped<ICashRegisterDataService, CashRegisterDataService>();
            services.AddSingleton<IOrderDiscountService, OrderDiscountService>();
            services.AddSingleton<IDiscountStrategyLocator, DiscountStrategyLocator>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
