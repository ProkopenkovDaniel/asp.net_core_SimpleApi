using SimpleAPI;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (context) => {
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("index.html");
    });
    
app.MapGet("/api/persons", SimpleAPIClass.GetAllPersons);
app.MapGet("/api/persons/{id}", async(string id)=> await SimpleAPIClass.GetPersonById(id));
app.MapPost("/api/persons", async(HttpContext context)=> await SimpleAPIClass.AddPersonById(context));
app.MapDelete("/api/persons/{id}", async (string id)=>await SimpleAPIClass.DeletePersonById(id));
app.MapPut("/api/persons", async(HttpContext context)=> await SimpleAPIClass.UpdatePersonById(context));

app.Run();

public class Person
{
    public string Id {get; set;} = "";
    public string Name {get; set;} = "";
    public int Age {get; set;}
}
