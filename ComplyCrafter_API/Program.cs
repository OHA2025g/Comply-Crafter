// using ComplyCrafter_API;
// using ComplyCrafter_API.Middleware;
// using ComplyCrafter_API.Models;
// using ComplyCrafter_Data;
// using Microsoft.AspNetCore.Builder.Extensions;
// using Microsoft.AspNetCore.Mvc;

// var builder = WebApplication.CreateBuilder(args);

// R.AppConfig = builder.Configuration;
// Config.InitServices(builder.Services);

// builder.Services.AddHttpClient();
// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGenWithBearer();
// //builder.Services.AddCors(ca => ca.AddPolicy("CORS", cp => cp.SetIsOriginAllowed(_ => true).AllowAnyMethod().AllowAnyHeader().AllowCredentials()));

// // builder.Services.AddCors(options =>
// // {
// //     options.AddPolicy("CORS", policy =>
// //         policy
// //             .WithOrigins(
// //             "https://localhost:7161",
// //             "https://dev.complycrafter.com")
// //             .AllowAnyHeader()
// //             .AllowAnyMethod()
// //             .AllowCredentials()   
// //     );
// // });
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AllowUI", policy => policy
//         .WithOrigins(
//             "https://theinsightpartners.in",
//             "https://www.theinsightpartners.in"
//         )
//         .AllowAnyHeader()
//         .AllowAnyMethod()
//     // .AllowCredentials() // enable only if you send cookies/credentials
//     );
// });

// // Custome Model Error Summary config Model Summary message
// builder.Services.Configure<ApiBehaviorOptions>(options
// => options.InvalidModelStateResponseFactory =
// (context) =>
// {
//     var errorMessages = string.Join(", ", context.ModelState
//     .Where(x => x.Value?.Errors.Count > 0)
//     .SelectMany(x => x.Value!.Errors.Select(e => $"{e.ErrorMessage}")));
//     var result = new CustomErrorResponse(errorMessages);
//     return new JsonResult(result);

// });

// var app = builder.Build();
// app.UseMiddleware<LoggingMiddleware>();
// if (R.AppSet<bool>("ShowSwagger") || app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// if (R.AppSet<bool>("ShowErrors") || app.Environment.IsDevelopment())
// {
//     app.UseDeveloperExceptionPage();
// }

// app.UseHttpsRedirection();

// // app.UseCors("CORS");
// app.UseCors("AllowUI");

// app.UseAuthentication();

// app.UseAuthorization();

// app.MapControllers();

// app.Run();

using ComplyCrafter_API;
using ComplyCrafter_API.Middleware;
using ComplyCrafter_API.Models;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Load configuration
R.AppConfig = builder.Configuration;
Config.InitServices(builder.Services);

// 🔧 Add core services
builder.Services.AddHttpClient();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenWithBearer();

// ✅ Proper CORS setup (UI allowed domains)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowUI", policy => policy
        .WithOrigins(
            "https://theinsightpartners.in",
            "https://www.theinsightpartners.in",
            "http://localhost:3000", // optional: local UI dev
            "https://localhost:7161" // optional: dev API
        )
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials() // ✅ if frontend sends cookies/token with credentials
    );
});

// ✅ Model validation error customization
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        var errorMessages = string.Join(", ",
            context.ModelState
                .Where(x => x.Value?.Errors.Count > 0)
                .SelectMany(x => x.Value!.Errors.Select(e => e.ErrorMessage))
        );

        var result = new CustomErrorResponse(errorMessages);
        return new JsonResult(result);
    };
});

var app = builder.Build();

// 🔧 Middleware order is critical
app.UseMiddleware<LoggingMiddleware>();

// ✅ Swagger setup (only for Dev or when explicitly enabled)
if (R.AppSet<bool>("ShowSwagger") || app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ✅ Developer exception page for debugging
if (R.AppSet<bool>("ShowErrors") || app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// ✅ Make sure this comes before Authentication and Controllers
app.UseHttpsRedirection();

// ✅ CORS must come BEFORE Authentication
app.UseCors("AllowUI");

// ✅ Auth
app.UseAuthentication();
app.UseAuthorization();

// ✅ Map routes
app.MapControllers();

// ✅ Start
app.Run();
