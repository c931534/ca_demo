using Application.Common;
using Application.UseCases;
using EFRepository;
using System.ComponentModel;
using ca_demo.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterUseCase();
builder.Services.RegisterRepository();

#region Test

//在 ASP.NET Core 中，你可以注入自己创建的 DI（依赖注入）容器实例，以下是一种常见的方式：

//首先，创建自己的 DI 容器实例。这可以是任何符合 DI 容器规范的容器，例如 Microsoft.Extensions.DependencyInjection 中的 ServiceCollection。

//var customContainer = new ServiceCollection();


//接下来，将自己的服务注册到容器中。

//customContainer.AddTransient<IService, MyService>();
//customContainer.AddSingleton<IRepository, MyRepository>();
//// 注册其他服务...


//然后，将自己的 DI 容器实例添加到 ASP.NET Core 的默认容器中。

//services.AddSingleton<IServiceProviderFactory<IServiceCollection>>(new CustomContainerServiceProviderFactory(customContainer));


//注意，CustomContainerServiceProviderFactory 是自定义的 IServiceProviderFactory 实现，用于创建自己的 DI 容器。

//最后，在 ConfigureServices 方法中，将默认的 DI 容器替换为自定义的 DI 容器。

//public void ConfigureServices(IServiceCollection services)
//{
//    // 移除默认的 DI 容器
//    services.Remove(services.SingleOrDefault(d => d.ServiceType == typeof(IServiceProviderFactory<IServiceCollection>)));

//    // 添加自定义的 DI 容器
//    services.Add(new ServiceDescriptor(typeof(IServiceProviderFactory<IServiceCollection>), serviceProviderFactoryImplementation));

//    // 注册其他服务...
//}


//通过以上步骤，你可以注入自己创建的 DI 容器实例，从而使用自定义的容器配置和管理依赖注入。

//请注意，这只是一种方式，你也可以考虑使用其他 DI 容器框架或扩展来实现相似的功能。

#endregion

//var customContainer = new ServiceCollection();
//customContainer.AddTransient<PlayerJoinGameUseCase>();
//customContainer.AddScoped<IRepository, GameRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
