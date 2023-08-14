using Hospital_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Hospital_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            string connString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services
                .AddDbContext<HospitalDbContext>
            (opions => opions.UseSqlServer(connString));

            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()

                {
                    Title = "Hospital-System",
                    Version = "v1",


                }


                    );



            });


            var app = builder.Build();


            app.UseSwagger(options => {

                options.RouteTemplate = "/api/{documentName}/swagger.json";


            });


            app.UseSwaggerUI(options => {

                options.SwaggerEndpoint("/api/v1/swagger.json", "Hospital-System");
                options.RoutePrefix = "docs";


            });

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.MapRazorPages();

            app.Run();
        }
    }
}