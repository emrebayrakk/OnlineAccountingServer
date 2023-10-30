using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

namespace OnlineAccountingServer.WebApi.Configurations
{
    public class PresentationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {

            services.AddControllers().AddApplicationPart(typeof(OnlineAccountingServer.Presentation.AssemblyReference).Assembly);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(setup =>
            {
                var jwtSecuritySheme = new OpenApiSecurityScheme
                {
                    BearerFormat = "JWT",
                    Name = "JWT Authentication",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Description = "Put **_Only_** your JWT Bearer token an textbox below!",

                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }

                };
                setup.AddSecurityDefinition(jwtSecuritySheme.Reference.Id, jwtSecuritySheme);
                setup.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecuritySheme,Array.Empty<string>() }
    });
            });
        }
    }
}
