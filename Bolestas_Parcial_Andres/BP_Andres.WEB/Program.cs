using BP_Andres.WEB;
using BP_Andres.WEB.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7282/") });
builder.Services.AddScoped<IRepository, Repository>(); //Me crea una instancia nueva del objeto cada que se realiza una inyección

await builder.Build().RunAsync();
