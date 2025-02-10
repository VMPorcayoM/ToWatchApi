using MongoDB.Driver;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar MongoDB
builder.Services.Configure<MongoDatabaseSettings>(
    builder.Configuration.GetSection("MongoDBSettings"));
builder.Services.AddSingleton<IMongoClient>(sp =>
    new MongoClient(builder.Configuration.GetValue<string>("MongoDBSettings:ConnectionString")));
builder.Services.AddScoped<IMongoDatabase>(sp =>
    sp.GetRequiredService<IMongoClient>().GetDatabase(
        builder.Configuration.GetValue<string>("MongoDBSettings:DatabaseName")));
builder.Services.AddScoped<IMongoCollection<MovieSerie>>(sp =>
    sp.GetRequiredService<IMongoDatabase>().GetCollection<MovieSerie>("movies_series"));
builder.Services.AddScoped<IMongoCollection<Genre>>(sp =>
    sp.GetRequiredService<IMongoDatabase>().GetCollection<Genre>("genres"));
builder.Services.AddScoped<IMongoCollection<Platform>>(sp =>
    sp.GetRequiredService<IMongoDatabase>().GetCollection<Platform>("platforms"));
builder.Services.AddScoped<IMongoCollection<Status>>(sp =>
    sp.GetRequiredService<IMongoDatabase>().GetCollection<Status>("status"));
builder.Services.AddControllers();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.Run();