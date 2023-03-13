using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptStream.Interface
{
    interface IMenu
    {
        public String getID();
        public String getTitle();
        public MenuClass[] getSubMenus();
        public int getType();
    }
}
