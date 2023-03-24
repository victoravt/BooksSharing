using BooksSharing.Application.Repositories;
using BooksSharing.Application.Repositories.Common;
using BooksSharing.DataAccess.Context;
using BooksSharing.DataAccess.Repositories;
using BooksSharing.DataAccess.Repositories.Common;
using BooksSharing.Domain.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

string connectionString = builder.Configuration["Db:ConnectionString:Dev"];

//Inject repositories
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITagRepository, TagRepository>();
builder.Services.AddScoped<IGenereRepository, GenereRepository>();
builder.Services.AddScoped<ILoanHistoryRepository, LoanHistoryRepository>();
builder.Services.AddScoped<IReservationQueueRepository, ReservationQueueRepository>();


// Connection string
builder.Services.AddDbContext<AppDbContext>(options => 
            options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//db ensure created



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
