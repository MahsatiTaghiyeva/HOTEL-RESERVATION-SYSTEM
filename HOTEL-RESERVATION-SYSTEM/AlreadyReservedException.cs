using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_RESERVATION_SYSTEM
{
    internal class AlreadyReservedException : Exception
    {
        public AlreadyReservedException(string message) : base(message)
        {
        }
    }
}
