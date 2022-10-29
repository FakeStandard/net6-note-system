using net6_note_system;
using net6_note_system.DAL.IRepository;
using net6_note_system.DAL.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// register db connect
builder.Services.AddDbContext<NoteContext>();

// register note repository
builder.Services.AddScoped<INoteRepository, NoteRepository>();

// register mvc
builder.Services.AddControllersWithViews();

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