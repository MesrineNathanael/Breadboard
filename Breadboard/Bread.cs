using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Breadboard
{
    class Bread
    {
        int duration;
        string name, path;
        Macro macro;
        public Bread(string name, string path, Key key1, Key key2)
        {
            this.name = name;
            this.path = path;

            macro = new Macro(key1, key2);
        }
        public string getName()
        {
            return this.name;
        }
        public string getPath()
        {
            return this.path;
        }
        public Macro getMacro()
        {
            return this.macro;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
}
