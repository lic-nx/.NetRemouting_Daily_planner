using System;
using System.Collections;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization.Formatters;
using RemoteHello;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                RegisterTCP();

                RemotingConfiguration.Configure(System.IO.Directory.GetCurrentDirectory() + @"\Server.config", false);
                Console.WriteLine("Http работает.");
                Console.WriteLine("TCP работает.");
                Console.WriteLine("Сервер работает.");
                Console.WriteLine("Нажмите Enter для выхода...");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка в запуске Http сервера.");
                Console.ReadLine();
            }
        }

        static void RegisterTCP()
        {
            try
            {
                IDictionary properties = new Hashtable();
properties.Add("secure", true);
properties.Add("protectionLevel", "EncryptAndSign");
properties.Add("port", "8085");
              //  properties_1["port"] = "8085";
                SoapServerFormatterSinkProvider srvPrvd_1 = new SoapServerFormatterSinkProvider();
                srvPrvd_1.TypeFilterLevel = TypeFilterLevel.Full;
                
                SoapClientFormatterSinkProvider clntPrvd_1 = new SoapClientFormatterSinkProvider();
                TcpChannel tcpChannel = new TcpChannel(properties, clntPrvd_1, srvPrvd_1);//защита
                ChannelServices.RegisterChannel(tcpChannel, true);//защита ьру 
                
                
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Hello), "Hi", WellKnownObjectMode.Singleton);

                RemotingConfiguration.RegisterWellKnownServiceType(typeof(GoodBy), "By", WellKnownObjectMode.Singleton);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка в запуске TCP сервера."+e.Message);
                Console.ReadLine();
            }
        }
    }
}