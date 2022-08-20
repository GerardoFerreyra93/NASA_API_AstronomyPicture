using RestSharpNunit.RequestValidations;

namespace NASA_API
{
    public class Tests : RequestValidationsMethods
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("ApiTest")]
        public void ValidateAPIResponse()
        {
            ValidateAPIResponseGET();
            

        }
    }
}