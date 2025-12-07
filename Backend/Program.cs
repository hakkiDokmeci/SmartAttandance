using Microsoft.EntityFrameworkCore;
using UniversityAttendance.Models;   // BURAYI DEÐÝÞTÝRECEKSÝN

var builder = WebApplication.CreateBuilder(args);

// 1) Controller'larý kaydet
builder.Services.AddControllers();

// 2) EF Core - AppDbContext'i kaydet
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

var app = builder.Build();

// 3) HTTP pipeline
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("/", () => "API is running"); //dsafdsfds

// 4) Controller endpoint'lerini aktif et
app.MapControllers();

// 5) Uygulamayý çalýþtýr
app.Run();
