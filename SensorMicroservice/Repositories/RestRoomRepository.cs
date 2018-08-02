using SensorMicroservice.Context;
using SensorMicroservice.Models;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SensorMicroservice.Repositories
{
    public class RestRoomRepository : BaseRepository<RestRoom>, IRestRoomRepository
    {
       
        
        public RestRoomRepository(SensorDbContext sensorDbContext) : base(sensorDbContext) { }

        public override void Add(RestRoom model)
        {
            model.OnAdd();
            sensorDbContext.RestRoom.Add(model);
            SaveChanges();
        }

        public override void Update(RestRoom model)
        {
            model.OnUpdate();
            SaveChanges();

        }

        public void GetRequest(Converter converterModel)
        {
            if (converterModel.Value.Equals("1"))
            {
                RestRoom restRoomModel = new RestRoom();
                restRoomModel.FromConverterForAdding(converterModel);
                this.Add(restRoomModel);
            }
            if (converterModel.Value.Equals("0"))
            {
                RestRoom updatedRestRoom = sensorDbContext.RestRoom.Where(model => model.HardwareId == Convert.ToInt32(converterModel.ID)).LastOrDefault();
                this.Update(updatedRestRoom);
            }


        }

    }
}
