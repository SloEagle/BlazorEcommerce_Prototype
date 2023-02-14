global using BlazorEcommerce_Prototype.Shared;
global using BlazorEcommerce_Prototype.Client.Services.ProductService;
global using BlazorEcommerce_Prototype.Client.Services.CategoryService;
global using BlazorEcommerce_Prototype.Client.Services.CartService;
global using BlazorEcommerce_Prototype.Client.Services.AuthService;
global using Blazored.LocalStorage;
global using System.Net.Http.Json;

using BlazorEcommerce_Prototype.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();

await builder.Build().RunAsync();
