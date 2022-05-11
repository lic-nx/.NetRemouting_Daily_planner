using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Remoting.Lifetime;
using InRemote;

namespace RemoteHello
{
    public class Hello : MarshalByRefObject, Iremote
    {
        public Hello()
        {
            Console.WriteLine("Объект Hello создан.");
        }
        ~Hello()
        {
            Console.WriteLine("Объект Hello уничтожен.");
        }

       
        //чтение из бд
        public void InsertBD(string abc)
        {
            OleDbCommand cmd;
            Console.WriteLine("dim");
            String connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\nasty\\OneDrive\\Desktop\\magazin1\\Server\\Server\\bin\\Debug\\Shop_DB.mdb";
            OleDbConnection con = new OleDbConnection(connectionString);

            using (con)
            {
                con.Open();

                cmd = new OleDbCommand(abc, con);
                OleDbDataReader reader = cmd.ExecuteReader();
            }
            con.Close();
        }
        public override Object InitializeLifetimeService()
        {
            ILease lease = (ILease)base.InitializeLifetimeService();
            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime      = TimeSpan.FromSeconds(3);
                lease.SponsorshipTimeout    = TimeSpan.FromSeconds(10);
                lease.RenewOnCallTime       = TimeSpan.FromSeconds(2);
            }
            return lease;
        }
    }
}
