using System.Text;
using System.Text.Json.Serialization;
using dev_challenge_01.Interfaces;
using dev_challenge_01.Models;
using dev_challenge_01.Repository;
using dev_challenge_01.Services;
using dev_challenge_01.Utils.Middlewares;
using TinyCsvParser;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddControllers()
    .AddJsonOptions(options => { options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull; })
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
    });

// CSV data
var csvParserOptions = new CsvParserOptions(true, ',');
var csvMapper = new FacilityCsvMapper();
var csvParser = new CsvParser<Facility>(csvParserOptions, csvMapper);

var result = csvParser
    .ReadFromFile("./Data/Mobile_Food_Facility_Permit.csv", Encoding.ASCII)
    .ToList();
var facilities = result.Select(r => r.Result).ToList();

//TODO: ^^^ check if result has no errors ^^^

builder.Services.AddScoped<IFacilityService, FacilityService>();
builder.Services.AddSingleton<IFacilityRepository>(new FacilityRepository(facilities));

//-----------------------------------------------------------------------------
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Authentication & Authorization
//app.UseAuthorization();

// Middlewares
app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

app.Run();
