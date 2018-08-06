﻿using SensorMicroservice.Context;
using SensorMicroservice.Enum;
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
            DBSet.Add(model);
            SaveChanges();
        }

        public override void Update(RestRoom model)
        {
            model.OnUpdate();
            SaveChanges();
        }

        public void PostRequest(Converter converterModel)
        {
            if (converterModel.Value.Equals("1"))
            {
                RestRoom restRoomModel = new RestRoom();
                restRoomModel.FromConverterForAdding(converterModel);
                this.Add(restRoomModel);
            }
            if (converterModel.Value.Equals("0"))
            {
                RestRoom updatedRestRoom = DBSet.Where(model => model.HardwareId == Convert.ToInt32(converterModel.ID)).LastOrDefault();
                if (updatedRestRoom != null)
                    this.Update(updatedRestRoom);
            }
        }

        public List<Converter> GetRequest()
        {
            int[] restRoomHIdList = HardwareID.GetAllRestRoomID();
            List<Converter> restRoomList = new List<Converter>();
            foreach (int item in restRoomHIdList)
            {
                if (this.DBSet.Any(model => model.HardwareId == item))
                    restRoomList.Add(ToConverterFromRestRoom(LastRestRoomFromHId(item)));
            }
            return restRoomList;
        }

        public RestRoom LastRestRoomFromHId(int HId)
        {
            RestRoom restRoom = DBSet.Where(model => model.HardwareId == HId).LastOrDefault();
            return restRoom;
        }

        public Converter ToConverterFromRestRoom(RestRoom restRoom)
        {
            Converter converterModel = new Converter();
            converterModel.ID = restRoom.HardwareId.ToString();
            converterModel.Value = restRoom.Value.ToString();

            return converterModel;

        }
    }
}
