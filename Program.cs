using Microsoft.EntityFrameworkCore;
using student_list_backend.Contexts;
using student_list_backend.GraphQL;

var builder = WebApplication.CreateBuilder(args);

// CORS-Policy definieren
builder.Services.AddCors(options =>
{
    options.AddPolicy("frontend", p =>
        p.WithOrigins("http://localhost:5173", "http://localhost:3000") // Frontend-Dev-URLs
         .AllowAnyHeader()
         .AllowAnyMethod()
    //.AllowCredentials() // für Cookies/Auth 
    );
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentContext>(opts =>
    opts.UseSqlite(builder.Configuration.GetConnectionString("Default") ?? "Data Source=students.db"));
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting().ModifyRequestOptions(o => o.IncludeExceptionDetails = true);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// **WICHTIG: CORS vor MapGraphQL/MapControllers**
app.UseCors("frontend");

app.MapControllers();

app.MapGraphQL("/graphql");

app.Run();
