
using AdaTech.AdaShop.Infra.Ioc;

namespace AdaTech.AdaShop.ApresentationApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            InitializeRepositories.RegisterRepository(builder.Services);
            InitializeMediator.ResgisterMediator(builder.Services);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();



            app.MapControllers();

            app.Run();
        }
    }
}
