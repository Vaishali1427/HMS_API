using Business_Logic_Layer.Services.Patients;
using Business_Logic_Layer.Services.PatientDiagnosisDetails;
using Business_Logic_Layer.Services.Physician;
using Business_Logic_Layer.Services.PhysicianSearch;
using Business_Logic_Layer.Services.ViewPatientHistory;
using Data_Access_Layer.Contracts;
using Data_Access_Layer.DataAccess;
using Business_Logic_Layer.Services.Login;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Business_Logic_Layer.Services.PhysiciansSearch;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
       .AddJwtBearer(options =>
       {
           options.TokenValidationParameters = new TokenValidationParameters
           {
               ValidateIssuer = true,
               ValidateAudience = true,
               ValidateLifetime = true,
               ValidIssuer = builder.Configuration["Jwt:Issuer"],
               ValidAudience = builder.Configuration["Jwt:Audience"],
               IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
           };
       });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Add the services

builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IPatientDiagnosisDetailsRepository, PatientDiagnosisDetailsRepository>();
builder.Services.AddScoped<IPhysicianRepository, PhysicianRepository>();
builder.Services.AddScoped<IPhysicianSearchRepository, PhysicianSearchRepository>();
builder.Services.AddScoped<IViewPatientHistoryRepository, ViewPatientHistoryRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();



builder.Services.AddScoped<IServicePatient, ServicePatient>();
builder.Services.AddScoped<IServicePatientDiagnosisDetails, ServicePatientDiagnosisDetails>();
builder.Services.AddScoped<IServicePhysician, ServicePhysician>();
builder.Services.AddScoped<IServicePhysicianSearch, ServicePhysicianSearch>();
builder.Services.AddScoped<IServiceViewPatientHistory, ServiceViewPatientHistory>();
builder.Services.AddScoped<IServiceLogin, ServiceLogin>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
