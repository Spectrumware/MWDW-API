using Microsoft.EntityFrameworkCore;
using EFDAL;
using APIApp;

var builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MwdwtempContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

app.MapGet("/vision", (HttpRequest request, MwdwtempContext db) =>
{
    var data = request.Query["data"];
    var costCode = request.Query["costCode"];

    switch (data)
    {
        case "job-numbers":
            return db.TblJobMasterMcs.Where(j => j.CompanyCode == "MDC" && j.MasterJob.Contains("    ") && j.CustomerCode != "").Select(j => new {Job_Number = j.JobNumber, Job_Description = j.JobDescription}).ToList() is var jobs && jobs.Count > 0 ? Results.Ok(jobs) : Results.NotFound();
        case "customers":
            return db.TblCustomerMasterMcs.Where(c => c.CompanyCode == "MDC").Select(c => new {Name = c.Name, Customer_Code = c.CustomerCode}).ToList() is var customers && customers.Count > 0 ? Results.Ok(customers) : Results.NotFound();
        case "project-managers":
            if(costCode != "")
                return db.TblEmployeeMaster1Mcs.Where(e => e.CostCenter == costCode && e.CompanyCode == "MDC" && e.EmploymentStatus == "A" || (e.Title == "Project Manager" || e.Title == "Estimator")).Select(e => new {Employee_Code = e.EmployeeCode, Employee_Name = e.EmployeeName, Cost_Center = e.CostCenter}).ToList() is var employees1 && employees1.Count > 0 ? Results.Ok(employees1) : Results.NotFound();
            return db.TblEmployeeMaster1Mcs.Where(e => e.CompanyCode == "MDC" && e.EmploymentStatus == "A" || (e.Title == "Project Manager" || e.Title == "Estimator")).Select(e => new { Employee_Code = e.EmployeeCode, Employee_Name = e.EmployeeName, Cost_Center = e.CostCenter }).ToList() is var employees2 && employees2.Count > 0 ? Results.Ok(employees2) : Results.NotFound();
        case "divisions":
            return db.TblDepartmentCodeMcs.Where(d => d.CompanyCode == "MDC" && d.CostCenter != "9900").Select(d => new {Departement_Description = d.DepartmentDescription, Cost_Center = d.CostCenter}).ToList() is var divisions && divisions.Count > 0 ? Results.Ok(divisions) : Results.NotFound();
        case "rows":
            return db.Database.SqlQuery<VisionDataDisplay>($"EXEC [dbo].[spDisplayVisionData]").ToList() is var rows && rows.Count > 0 ? Results.Ok(rows) : Results.NotFound();
        default:
            return Results.NotFound();
    }
});

app.Run();
