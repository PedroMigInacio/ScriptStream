using ScriptStream.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptStream.IO
{
    interface MenuParser
    {
        MenuClass[] getMenus();
        void getSubMenus();
    }
}
