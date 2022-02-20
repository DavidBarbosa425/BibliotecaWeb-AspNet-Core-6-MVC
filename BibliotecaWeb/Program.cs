using BibliotecaWeb.Models.Contexts;
using BibliotecaWeb.Models.Contracts.Contexts;
using BibliotecaWeb.Models.Contracts.Repositories;
using BibliotecaWeb.Models.Contracts.Services;
using BibliotecaWeb.Models.Repositories;
using BibliotecaWeb.Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddSingleton<IContextData, ContextDataFake>();
builder.Services.AddSingleton<IEmprestimoLivroService, EmprestimoLivroService>();
builder.Services.AddSingleton<IEmprestimoLivroRepository, EmprestimoLivroRepository>();
builder.Services.AddSingleton<IContextData, ContextDataSqlServer>();
builder.Services.AddSingleton<IConnectionManager, ConnectionManager>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<ILivroService, LivroService>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
