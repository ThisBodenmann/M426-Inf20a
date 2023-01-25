using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public interface ISubscriber
    {
        public void Update(ParkingLot parkingLot, bool positive)
        {
            if (positive)
            {
                parkingLot.Enter();
            }
            else
            {
                parkingLot.Exit();
            }
        }
    }
}
