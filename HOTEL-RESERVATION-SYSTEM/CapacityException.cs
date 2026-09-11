using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_RESERVATION_SYSTEM
{
    internal class CapacityException : Exception
    {
        public CapacityException(string message): base(message)
        {

        }
    }
}
