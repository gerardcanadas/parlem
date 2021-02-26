using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using parlem.application.UseCases.Customer;
using parlem.application.UseCases.Product;
using parlem.domain.Models.Customer.Interfaces;
using parlem.domain.Models.Product.Interfaces;
using parlem.infrastructure.Repositories.InMemory.Customer;
using parlem.infrastructure.Repositories.InMemory.Product;

namespace parlem.api
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
            services.AddScoped<ICustomerRepository, CustomerRepositoryInMemory>();
            services.AddScoped<IProductRepository, ProductRepositoryInMemory>();
            services.AddScoped(typeof(GetCustomerByIdUseCase));
            services.AddScoped(typeof(GetCustomersListUseCase));
            services.AddScoped(typeof(GetProductUseCase));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            // global cors policy
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
