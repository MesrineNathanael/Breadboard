using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breadboard
{
    class Debug
    {
        bool active;
        public Debug(bool active)
        {
            this.active = active;
        }
        public void msgbox(string text)
        {
            if (active)
            {
                MessageBox.Show(text);
            }
            
        }
        public void println(string text)
        {
            if (active)
            {
                Console.WriteLine(text);
            }
            
        }
    }
}
