using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Breadboard
{
    class Macro
    {
        Key key1, key2;
        public Macro(Key k1, Key k2)
        {
            this.key1 = k1;
            this.key2 = k2;
        }
        public void setKey1(Key key)
        {
            this.key1 = key;
        }
        public void setKey2(Key key)
        {
            this.key2 = key;
        }
        public Key getKey1()
        {
            return this.key1;
        }
        public Key getKey2()
        {
            return this.key2;
        }
    }
}
