using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedRoomScheduling
{
    internal class PartTimeException : Exception
    {
        public PartTimeException(string message) : base(message) 
        { 
        
        }

    }
}
