using AutoMapper;
using Library.Data.Repositories;
using Library.Domain.DefaultImplementations;
using Library.Domain.Interfaces;
using Library.EF;
using Library.EF.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Library
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore(); 
            services.AddControllersWithViews();
            services.AddTransient<IBookService>(x =>
            {
                var projectPath = System.IO.Directory.GetCurrentDirectory();
                return new BookService(x.GetRequiredService<IFileMetaDataRepository>(),x.GetRequiredService<IBookRepository>(), x.GetRequiredService<IAuthorRepository>(), projectPath);
            });
            services.AddTransient<IFileMetaDataRepository, FileMetaDataRepository>();
            services.AddTransient<IAuthorRepository, AuthorRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IQuoteRepository, QuoteRepository>();
            services.AddTransient<IQuoteService, QuoteService>();
            services.AddDbContext<LibraryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LibraryContext")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
