using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Delivery
    {

        public int DeliveryNumber { get; set; }
        public string DeliveryName { get; set; }

        public string DeliveryPickupPoint { get; set; }
        public string DeliveryPoint { get; set; }
        public decimal DeliveryDistance { get; set; }
        public decimal DeliveryPrice { get; set; }
        public int CustomerNumber { get; set; }
        public int VehicleNo { get; set; }

        public int StaffNumber { get; set; }
    }
}
