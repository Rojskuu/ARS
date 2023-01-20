using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedRoomScheduling
{
    internal class Apos
    {
        public string Apostrophe(String txt)
        {
            int loc = txt.LastIndexOf("'");

            String apos = "''";

            String temp = txt.Insert(loc, apos);

            Console.WriteLine(temp);

            txt = temp;

            return txt;   
        }
    }
}
