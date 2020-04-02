using Microsoft.AspNetCore.Http;

namespace ASPNETCoreAngular.API.Helpers
{
    public static class Extensions
    {
        public static void AddAplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error",message);

            //to display error (Angular)
            response.Headers.Add("Access-Control-Expopse-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin","*");
        }
    }
}