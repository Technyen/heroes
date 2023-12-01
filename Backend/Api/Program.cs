using Application.Services;
using Infrastructure.Interfaces.MarvelService;
using Infrastructure.Services;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            string frontEndUrl = "http://localhost:3000";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy =>
                                  {
                                      policy
                                      .WithOrigins(frontEndUrl)
                                      .AllowAnyHeader()
                                      .AllowAnyMethod();
                                  });
            });

            builder.Services.AddControllers();
            builder.Services.AddScoped<IMarvelService, MarvelService>();
            builder.Services.AddHttpClient<IMarvelService, MarvelService>(client =>
            {
                client.BaseAddress = new Uri("http://gateway.marvel.com/v1/public/");
            });

            builder.Services.AddScoped<CreatorService>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}