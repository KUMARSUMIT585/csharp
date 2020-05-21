using System;
using System.Linq;
using RestSharp;


namespace sampletest.RestApiUtilities
{
    class RestUtilities
    {
        private RestClient restClient;
        private RestRequest restRequest;
        private IRestResponse restResponse;
        private string response;
        /**This method will return status code for the paramter url & parameter GET request
         */
        public void ReturnResponseCode(String url, String request)
        {
            string uri = "";
            //sample line of code to fetch response from an API
            Console.WriteLine("****************ReturnResponseCode**********");
            Console.WriteLine("Method called- this method will return response code for an api");
            //http://restapi.demoqa.com/utilities/weather/city/
            //RestClient restClient = new RestClient(url);
            restClient = new RestClient(url);
            //RestRequest restRequest = new RestRequest("London", Method.GET);
            restRequest = new RestRequest(request, Method.GET);
            //IRestResponse restResponse = restClient.Execute(restRequest);
            restResponse = restClient.Execute(restRequest);
            //string response = restResponse.Content;
            response = restResponse.Content;
            Console.WriteLine("The URI called is- " + url + request);
            Console.WriteLine("The output of status code is as below");
            //Console.WriteLine(response);
            Console.WriteLine(restResponse.StatusCode);
        }
        /**This method validates presence of parameter text in the response body 
         */
        public Boolean ValidatePresenceOfText(String text)
        {
            Console.WriteLine("****************ValidatePresenceOfText**********");
            //Console.WriteLine("New method called");
            Console.WriteLine(response);
            if (response.Contains(text))
            {
                Console.WriteLine("The item searched for :'" + text + "'  is present in the response");
                return true;
            }
            else
            {
                Console.WriteLine("The item searched for :'" + text + "' is NOT present in the response");
                return false;
            }


        }
    }
}
