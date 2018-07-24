using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qstn3ofxml
{
    class readxml
    {
        List<information> plist = new List<information>();
        public readxml()
        {
            plist.Add(new information { Item = "keyboard", Manufacturer = "malgudi days", Category = "story", Price = 350 });
            plist.Add(new information { Item = "mouse", Manufacturer = "c programming", Category = "technlogy", Price = 550 });
            plist.Add(new information { Item = "joystick", Manufacturer = "harry potter", Category = "fiction", Price = 700 });
        }
    }
}
