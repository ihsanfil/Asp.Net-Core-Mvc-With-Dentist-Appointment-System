using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using DentistCalendar.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DentistCalendar.Data.Entity;

namespace DentistCalendar
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

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<AppUser, AppRole>(options => {
                options.User.RequireUniqueEmail = true;
                //options.User.AllowedUserNameCharacters = "abc" //diye izin verilen karakterleri belirtebiliriz.
                options.SignIn.RequireConfirmedEmail = false; //E-Mail Do�rulamas� olsun mu?
                options.SignIn.RequireConfirmedPhoneNumber = false; //Telefon Do�rulamas� olsun mu?
                options.Password.RequireDigit = false; //i�inde rakam olmas� zorunlu olsun mu?
                options.Password.RequiredLength = 6; // En az 6 Karakter olsun
                options.Password.RequireLowercase = false; //en az bir k���k karakter olsun mu?
                options.Password.RequireUppercase = false; //en az bir b�y�k karakter olsun mu?
                options.Password.RequireNonAlphanumeric = false; //Alphanumeric karakter olsun mu?
            }). // Default olan� de�ilde bizim olu�turdu�umuz class'lar� kullan dedik
            AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders(); // Bu bizim i�in cookie ile bir token a sahip olmas�n� sa�layacak

            //***** Cookie Ayarlar� ****

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login"; //oturum a�mad�ysa kullan�c�y� buraya y�nlendir
                options.LogoutPath = "/Account/Logout"; //oturumu kapat�nca kullan�c�y� buraya y�nlendir
                options.AccessDeniedPath = "/Account/Denied"; //eri�im engeli varsa buraya y�nlendir
                options.Cookie.Name = "Dentist.Cookie"; // olu�acak cookie'nin ismi Dentist.Cookie olsun
                options.SlidingExpiration = true; //kullan�c� giri� yapt���nda token s�resini uzat�r/yeniler.
            });

            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation(); //runtime an�nda(proje �al���rken f5) derleme yapmas� i�in ekledik.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Profile}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
