using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileDevicesManagement.Data.DBSets
{
    public class MobileDeviceType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<MobileDevice> MobileDevices { get; set; }
    }
}
