using Newtonsoft.Json;
using RestSharp;
using RestSharpNunit.ClientSetUp;
using RestSharpNunit.JSON.DeserializeJSONResponse;
using System.Linq;
using System.Net;
using System.Web.Helpers;
using System.Collections.Generic;
using static RestSharpNunit.JSON.DeserializeJSONResponse.APIDetailsResponse;

namespace RestSharpNunit.RequestValidations
{
    public class RequestValidationsMethods : ClientRestSetUp
    {
        private APIDetailsResponse apidetailsResponse;
        
        internal void ValidateAPIResponseGET()
        {
            ExecuteGenericRequest("/mars-photos/api/v1/rovers/curiosity/photos?sol=1000&api_key=Q6ZYPKehC7aewf4qJ2KdkIxz7Xa0iYsdQbPx8OHt", Method.Get);//para correr esta modificar endpoint            
            apidetailsResponse = JsonConvert.DeserializeObject<APIDetailsResponse>(response.Content);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));//VALIDACION CODIGO 200 Assert.IsTrue(response.IsSuccessful);
                 

            for (int i = 1; i < 11; i++)
            {
                if(apidetailsResponse.photos[i].rover.name == "Curiosity")
                {
                    Console.WriteLine("Photo number :" + i + " " + apidetailsResponse.photos[i].img_src + "\n");
                    
                }                
              
            }    



        }
        
    }
}
