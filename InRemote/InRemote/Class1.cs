using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InRemote
{
    public interface Iremote
    {
        void InsertBD(string abc);
        Object GetLifetimeService();
        Object InitializeLifetimeService();
    }
}
