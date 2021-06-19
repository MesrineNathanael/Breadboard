using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadboard
{
    class Bread
    {
        int duration;
        string name, path;
        public Bread(string name, string path)
        {
            this.name = name;
            this.path = path;
        }
        public string getName()
        {
            return this.name;
        }
        public string getPath()
        {
            return this.path;
        }
    }
}
