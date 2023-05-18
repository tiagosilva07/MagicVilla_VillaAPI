

using MagicVilla_VillaAPI.CustomLog;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Mappers;
using MagicVilla_VillaAPI.Repositories;
using MagicVilla_VillaAPI.Repositories.IRepositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MagicVilla_VillaAPI.Extensions;

namespace MagicVilla_VillaAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddApplicationServices(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json","Magic_VillaV1");
                    options.SwaggerEndpoint("/swagger/v2/swagger.json","Magic_VillaV2");
                });
            }
            else
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Magic_VillaV1");
                    options.SwaggerEndpoint("/swagger/v2/swagger.json", "Magic_VillaV2");
                    options.RoutePrefix = String.Empty;
                });
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}