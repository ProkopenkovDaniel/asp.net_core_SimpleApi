namespace SimpleAPI 
{
    using System.Text.RegularExpressions;

    public static class SimpleAPIClass
    {
        public static async Task AddPersonAPI(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;
            
            var path = request.Path;

            string rexForId = @"^$";
        }

        public static async Task GetAllPersons(){
        }

        public static async Task GetPersonById(string id){
            new NotImplementedException();
        }

        public static async Task AddPersonById(HttpContext context){
            new NotImplementedException();
        }

        public static async Task DeletePersonById(string id){
            new NotImplementedException();
        }

        public static async Task UpdatePersonById(HttpContext context){
            new NotImplementedException();
        }
    }
}