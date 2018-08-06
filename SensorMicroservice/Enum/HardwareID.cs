using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Enum
{
    public class HardwareID
    {
        public enum GetRestRoomID : int
        {
            MaleRestRoom1 = 1,
            MaleRestRoom2 = 2,
            FemaleRestRoom1 = 3
        }

        public static int[] GetAllRestRoomID()
        {
            int[] idList = { 1, 2, 3, };
            return idList;
        }
    }
}
