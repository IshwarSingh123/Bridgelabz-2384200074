using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using RepositoryLayer.Context;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IRegisterHelloBL,RegisterHelloBL>();
builder.Services.AddScoped<IRegistrationHelloRL,RegisterHelloRL>();

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionString));
//UseSqlServer = ye hamara database se connection banata hai
//IRegistrationHelloRL refrence=new RegisterHelloRL();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Logging.ClearProviders();
builder.Host.UseNLog();


var app = builder.Build();

app.UseSwagger();//json file create karta hai
app.UseSwaggerUI();// colourfull UI create krta.

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
//dependecy injection,
//ioc container
//add scoped
//add transient
//Add singleton 
//what are these