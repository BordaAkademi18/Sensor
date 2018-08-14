using SensorMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Services.NotificationService
{
    public class NotificationService : BaseRestRequestService<ModelNotification, ModelNotificationClient>
    {
        public ModelNotification ToModelNotificationFromConverter(Converter converterModel)
        {
            return new ModelNotification()
            {
                Id = Convert.ToInt32(converterModel.ID),
                Value = converterModel.Value.Equals("1") ? true : false
            };
        }
    }
}
