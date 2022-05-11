using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRemote
{
    public interface Iremote1
    {
        DataTable DataDB(string abc);
        Object GetLifetimeService();
        Object InitializeLifetimeService();
    }
}
