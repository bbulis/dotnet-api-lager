using System.Text.Json;

namespace Lager.WebController
{
    
    public class Program
    {
        
        public static void Main()
        {
            var builder = WebApplication.CreateBuilder();
            var app =  builder.Build();
            app.UseHttpsRedirection();
            app.MapGet("/", () => {
                var response = new Response(true, "data test");
                var responseJson = JsonSerializer.Serialize(response);
                return responseJson;
            });
            app.Run();     
        }
    }

    public class Response
    {
        public bool successful {get; set;}
        public string data {get; set;}

        public Response(bool  successful, string data)
        {
            this.successful = successful;
            this.data = data;
        }
    }

}