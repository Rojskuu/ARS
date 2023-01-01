using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedRoomScheduling
{
    internal interface ICRUD
    {
        
        void Create();
        void Retrieve();
        void Update();
        void Delete();
    }
}
