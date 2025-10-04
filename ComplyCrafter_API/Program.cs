using ComplyCrafter_API;
using ComplyCrafter_API.Middleware;
using ComplyCrafter_API.Models;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

R.AppConfig = builder.Configuration;
Config.InitServices(builder.Services);

builder.Services.AddHttpClient();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenWithBearer();
//builder.Services.AddCors(ca => ca.AddPolicy("CORS", cp => cp.SetIsOriginAllowed(_ => true).AllowAnyMethod().AllowAnyHeader().AllowCredentials()));

// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("CORS", policy =>
//         policy
//             .WithOrigins(
//             "https://localhost:7161",
//             "https://dev.complycrafter.com")
//             .AllowAnyHeader()
//             .AllowAnyMethod()
//             .AllowCredentials()   
//     );
// });
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocal5029", policy => policy
        .WithOrigins("http://localhost:5029")
        .AllowAnyHeader()
        .AllowAnyMethod()
    // .AllowCredentials() // enable only if you send cookies/credentials
    );
});

// Custome Model Error Summary config Model Summary message
builder.Services.Configure<ApiBehaviorOptions>(options
=> options.InvalidModelStateResponseFactory =
(context) =>
{
    var errorMessages = string.Join(", ", context.ModelState
    .Where(x => x.Value?.Errors.Count > 0)
    .SelectMany(x => x.Value!.Errors.Select(e => $"{e.ErrorMessage}")));
    var result = new CustomErrorResponse(errorMessages);
    return new JsonResult(result);

});

var app = builder.Build();
app.UseMiddleware<LoggingMiddleware>();
if (R.AppSet<bool>("ShowSwagger") || app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (R.AppSet<bool>("ShowErrors") || app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

// app.UseCors("CORS");
app.UseCors("AllowLocal5029");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
