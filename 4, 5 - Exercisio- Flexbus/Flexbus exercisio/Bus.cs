using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexbus_exercisio
{
    public class Bus
    {

        //Constructors
        static int lastId = 0;
        public Bus()
        {   
            lastId++;
            this.Id = lastId;
        }

        //Properties
        public int Id { get; }

        public int NextId { get;}

        public string LicensePlate { get; set; }

        public string Maker { get; set; }

        public int Weight { get; set; }

        //metodos
        public static int GetLastId(Bus bus)
        {
            return lastId;
        }
        public static int GetNextId(Bus bus)
        {
            return lastId + 1;
        }
        public string InfoBus (Bus bus)
        {
            return $@"
LICENSE PLATE - {bus.LicensePlate}|  BUS ID - {bus.Id}  |  WEIGHT  - {bus.Weight}  | MAKER -{bus.Maker}";

        }
        public int GetWeight (Bus bus)
        {
            return Weight;
        }
    }
}
