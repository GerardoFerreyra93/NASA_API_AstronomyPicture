using Newtonsoft.Json;
using RestSharp;
using RestSharpNunit.ClientSetUp;
using RestSharpNunit.JSON.DeserializeJSONResponse;
using System.Linq;
using System.Net;
using System.Web.Helpers;
using System.Collections.Generic;


namespace RestSharpNunit.RequestValidations
{
    public class RequestValidationsMethods : ClientRestSetUp
    {
        private APIDetailsResponse apidetailsResponse;
        
        internal void ValidateAPIResponseGET()
        {
            ExecuteGenericRequest("/mars-photos/api/v1/rovers/curiosity/photos?sol=1000&api_key=Q6ZYPKehC7aewf4qJ2KdkIxz7Xa0iYsdQbPx8OHt", Method.Get);//para correr esta modificar endpoint
            apidetailsResponse = JsonConvert.DeserializeObject<APIDetailsResponse>(response.Content);

            //Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));//VALIDACION CODIGO 200 Assert.IsTrue(response.IsSuccessful);
            //Console.WriteLine(response.Content);

            //Assert.AreEqual(102693, apidetailsResponse.photos[0].id);
            //Console.WriteLine("102693" + "\n" + apidetailsResponse.photos[0].id);
            // falta el for para imprimri solo los 10 primero  apidetailsResponse.photos[i]
            
            
            Console.WriteLine(apidetailsResponse.rover.ToString());
            //como acceder a la lista rover.name == "Curiosity" para hacer la validacion tal vez con una lista
            

        }


    }
}
