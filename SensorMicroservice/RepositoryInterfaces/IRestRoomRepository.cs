using SensorMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.RepositoryInterfaces
{
    public interface IRestRoomRepository:IBaseRepository<RestRoom> 
    {
        void PostRequest(Converter converterModel);
        List<Converter> GetRequest();
        string GetJWToken(string baseUrl, string path, object userModel);
        void PostToAnotherService(Converter model, string baseUrl, string path, string token);
        void PostToAnotherService(Converter model, string baseUrl, string path);
    }
}
