using BigOn.Domain.AppCode.Extensions;
using BigOn.Domain.AppCode.Providers;
using BigOn.Domain.AppCode.Services;
using BigOn.Domain.Models.DataContexts;
using BigOn.Domain.Models.Entities.Membership;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigOn.Domain
{
  
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(cfg =>
            {
            var policy = new AuthorizationPolicyBuilder()
            .RequireAuthenticatedUser()
            .Build();
            cfg.Filters.Add(new AuthorizeFilter(policy));
                cfg.ModelBinderProviders.Insert(0, new BooleanBinderProvider());
            });

            services.AddDbContext<BigOnDbContext>(cfg =>
            {
                cfg.UseSqlServer(configuration["ConnectionStrings:cstring"]);
            });

            services.SetupIdentity();

            services.AddAuthentication();
            services.AddAuthorization(cfg => 
            {
                foreach (var item in Extension.policies)
                {
                    cfg.AddPolicy(item, p => {

                        // p.RequireClaim(item, "1");

                        p.RequireAssertion(ra =>
                        {
                            
                           return ra.User.HasAccess(item);
                        });
                    });
                }


            });

            services.AddRouting(cfg =>
            {
                cfg.LowercaseUrls = true;
            });
            services.Configure<CryptoServiceOption>(cfg =>
            {
                configuration.GetSection("cryptography").Bind(cfg);
            });

            services.AddSingleton<CryptoService>();
            services.Configure<EmailServiceOptions>(cfg =>
            {
                configuration.GetSection("emailAccount").Bind(cfg);
            });
            services.AddSingleton<EmailService>();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("BigOn."));
            services.AddMediatR(assemblies.ToArray());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.SeedData();
            app.SeedMembership();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
        
            app.UseEndpoints(cfg =>
            {
                cfg.MapAreaControllerRoute("default", "admin", "admin/{controller=dashboard}/{action=index}/{id?}");
                cfg.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
                
            });
        }
    }
} 
