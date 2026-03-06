using Repository;
using UI.Components;

var builder = WebApplication.CreateBuilder(args);

// Servicios de Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// ✅ REGISTRAR AQUÍ
builder.Services.AddScoped<Repository.MateriaRepository>();
builder.Services.AddScoped<Services.MateriaService>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();