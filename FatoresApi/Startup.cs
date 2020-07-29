using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using Otc.AspNetCore.ApiBoot;
using Otc.Extensions.Configuration;


namespace fatoresapi
{
    public class Startup : ApiBootStartup
    {
        protected override ApiMetadata ApiMetadata => new ApiMetadata()
        {
            Name = "Calculo Fatores",
            Description = "{{webAPIDescription}}",
            DefaultApiVersion = "1.0"
        };

        public Startup(IConfiguration configuration)
            : base(configuration)
        {

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
