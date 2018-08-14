using Newtonsoft.Json;
using RestSharp;
using SensorMicroservice.Authentication;

namespace SensorMicroservice.Services
{
    public abstract class BaseRestRequestService<TPostModel, TUserModel>
    {
        public string GetJWToken(string baseUrl, string path, TUserModel user)
        {
            //TUser is a kind of user information like username and password
            var client = new RestSharp.RestClient(baseUrl);
            var request = new RestSharp.RestRequest(path, Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(user), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request); //response.Content includes JASON WEB TOKEN
            JWToken mytoken = JsonConvert.DeserializeObject<JWToken>(response.Content);

            return mytoken.Token;
        }

        public void PostToAnotherService(TPostModel model, string baseUrl, string path, string token)
        {
            var client = new RestSharp.RestClient(baseUrl); // base url is like http://localhost:40040
            var request = new RestSharp.RestRequest(path, Method.POST); //path is like "api/products"
            request.AddParameter("application/json", JsonConvert.SerializeObject(model), ParameterType.RequestBody);
            var authorization = request.AddHeader("Authorization", "Bearer " + token);
            IRestResponse response = client.Execute(request);
        }

        public void PostToAnotherService(TPostModel model, string baseUrl, string path)
        {
            var client = new RestSharp.RestClient(baseUrl); // base url is like http://localhost:40040
            var request = new RestSharp.RestRequest(path, Method.POST); //path is like "api/products"
            request.AddParameter("application/json", JsonConvert.SerializeObject(model), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }
    }
}