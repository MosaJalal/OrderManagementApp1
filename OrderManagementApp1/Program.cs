using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OrderManagementApp1;
using MudBlazor.Services;
using OrderManagementApp1.CQRS.Commands;
using OrderManagementApp1.CQRS.Queries;
using OrderManagementApp1.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();
builder.Services.AddSingleton<OrderService>();
builder.Services.AddTransient<AddOrderCommandHandler>();
builder.Services.AddTransient<PayOrderCommandHandler>();
builder.Services.AddTransient<GetAllOrdersQueryHandler>();


await builder.Build().RunAsync();
