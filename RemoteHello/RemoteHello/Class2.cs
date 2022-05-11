using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Runtime.Remoting.Lifetime;
using System.IO;
using InRemote;

namespace RemoteHello
{
    public class GoodBy : MarshalByRefObject, Iremote1
    {
        public GoodBy()
        {
            Console.WriteLine("Объект BeyBey создан");
        }
        ~GoodBy()
        {
            Console.WriteLine("Объект BeyBey уничтожен");
        }

        //добавить задачу в бд
        public DataTable DataDB(string abc)
        {
            OleDbCommand cmd;

            String connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\nasty\OneDrive\Desktop\magazin1\Server\Server\bin\Debug\Shop_DB.mdb";
            OleDbConnection con = new OleDbConnection(connectionString);
            DataTable list = new DataTable();

            using (con)
            {
                con.Open();

                cmd = new OleDbCommand(abc, con);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

                adapter.Fill(list);
            }
            con.Close();
            return list;
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
