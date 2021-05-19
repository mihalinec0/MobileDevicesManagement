using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileDevicesManagement.Data.DBSets
{
    public class MobileDevice
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string IMEI { get; set; }
        public string InventoryNumber { get; set; }
        public MobileDeviceType Type { get; set; }
        public MobileDeviceModel Model { get; set; }
        public MobileDeviceMake Make { get; set; }
    }
}
