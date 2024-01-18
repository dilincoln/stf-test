using Microsoft.EntityFrameworkCore;
using STFTest.Data;

namespace STFTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<STFTestDBContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("STFTestDBContext")
                        ?? throw new InvalidOperationException(
                            "Connection String not found"
                        ))
                );

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Apply migrations
            using (var scope = app.Services.CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<STFTestDBContext>().Database.Migrate();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
