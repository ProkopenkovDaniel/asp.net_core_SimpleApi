var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

public class Person
{
    public string Id {get; set;} = "";
    public string Name {get; set;} = "";
    public int Age {get; set;}
}

namespace SimpleAPI 
{
    using System.Text.RegularExpressions;

    public static class SimpleAPI 
    {
        public static async Task AddPersonAPI(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;
            
            var path = request.Path;

            string rexForId = @"^$";
        }

        public static async Task GetAllPersons(){
            new NotImplementedException();
        }

        public static async Task GetPersonById(string id){
            new NotImplementedException();
        }

        public static async Task AddPersonById(Person person){
            new NotImplementedException();
        }

        public static async Task DeletePersonById(string id){
            new NotImplementedException();
        }

        public static async Task UpdatePersonById(string id, Person updatedPerson){
            new NotImplementedException();
        }
    }

}