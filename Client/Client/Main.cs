using System;
using System.Data;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Lifetime;
using InRemote;

namespace Client
{
    public partial class Main : Form
    {
        Iremote helloObj;
        Iremote1 goodByObj;

        ILease leaseHi, leaseBy;

        string numberOfTable="Product";
        string busket = "";

        public Main()
        {
            
            InitializeComponent();
            groupBox1.Show();
            groupBox2.Hide();
            deliteLabel.Hide();
            deliteTexBox.Hide();
            deliteButton.Hide();
            listAdmin.Hide();

            CreateChannel();
            // просмотрть заказ

            string abc = $"SELECT * FROM [Product]";
            DataTable reader = goodByObj.DataDB(abc);


            listAdmin.Items.Clear();
            foreach (DataRow row in reader.Rows)
            {
                if (row["id"].ToString() != "")
                {
                    string addToList="";
                    
                    DataTable read = goodByObj.DataDB(abc);
                    for (int i = 0; i < 5; i++) {
                        addToList =addToList+" "+ row[i].ToString();
                    }
                    
                         
                        listAdmin.Items.Add(addToList);
                        

                    
                    
                }
            }



        }

        // авторизация как админа

        private void Busket(object sender, EventArgs e, string product, int i, Button btn)
        {
            if (i == 1)
            {
                busket += product + ",";
                btn.Text = btn.Text.Replace("+1", "");
                btn.Text = (Convert.ToInt32(btn.Text) + 1).ToString() + "+1";
            }
            else
            {
                busket = busket.Replace(product + ",", "");
                btn.Text = "0+1";
            }
        }

        private void deliteButton_Click(object sender, EventArgs e)
        {
            if (deliteTexBox.Text != String.Empty)
            {
                int delete = int.Parse(deliteTexBox.Text);
                string abc = $"DELETE FROM [Product] WHERE Id={delete}";
                helloObj.InsertBD(abc);
                label1.Text = "задача удалена";
                

                 abc = $"SELECT * FROM [Product]";
                DataTable reader = goodByObj.DataDB(abc);


                listAdmin.Items.Clear();
                foreach (DataRow row in reader.Rows)
                {
                    if (row["id"].ToString() != "")
                    {
                        string addToList = "";

                        DataTable read = goodByObj.DataDB(abc);
                        for (int i = 0; i < 5; i++)
                        {
                            addToList = addToList + " " + row[i].ToString();
                        }


                        listAdmin.Items.Add(addToList);




                    }
                }



            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void addTask_Click(object sender, EventArgs e)
        {
            string beginTimeStr = "---", dateStr = "---", endTimeStr = "---", taskName = "---";
            if (timeStartPicker.Text != String.Empty)
            {
                beginTimeStr = timeStartPicker.Text;
            }
            if (timeEndPicker.Text != String.Empty)
            {
                endTimeStr = timeEndPicker.Text;
            }
            if (datePicker.Text != String.Empty) { dateStr = datePicker.Text; }
            if (taskText.Text != String.Empty) { taskName = taskText.Text; }

            if (endTimeStr != "---" && beginTimeStr != "---")
            {
                DateTime beginTime = DateTime.Parse(beginTimeStr);
                DateTime endTime = DateTime.Parse(endTimeStr);
                if (endTime < beginTime)
                {
                    label1.Text = "Время конца должно быть позже начала.";
                    return;
                }
            }
            string abc = $"INSERT INTO [Product] ([data], [timeStart], [timeEnd],[task]) VALUES('" + dateStr + "', '" + beginTimeStr + "', '" + endTimeStr + "', '" + taskName + "')";
            helloObj.InsertBD(abc);
            label1.Text = "задача добавлена";

            abc = "SELECT * FROM [Product]";
            DataTable reader = goodByObj.DataDB(abc);

            listAdmin.Items.Clear();
            foreach (DataRow row in reader.Rows)
            {
                if (row["id"].ToString() != "")
                {
                    string addToList = "";
                    DataTable read = goodByObj.DataDB(abc);
                    for (int i = 0; i < 5; i++)
                    {
                        addToList = addToList + " " + row[i].ToString();
                    }
                     listAdmin.Items.Add(addToList);
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (LoginTextbox.Text != String.Empty && PasswordTextbox.Text != String.Empty)
            {
                string password = PasswordTextbox.Text;
                string login = LoginTextbox.Text;
                string abc = $"SELECT [User.id] FROM [User] WHERE [User.login]='{login}' AND [User.password]='{password}' ;";
                DataTable reader = goodByObj.DataDB(abc);
                if (LoginTextbox.Text != "one" && PasswordTextbox.Text!="one")
                {
                    ErrorMessageLabel.Text = "Не правильный логин или пароль";
                }
                else {
                    ErrorMessageLabel.Text = "правильный логин и пароль";
                    numberOfTable =Convert.ToString(reader);
                    groupBox1.Hide();
                    groupBox2.Show();
                    deliteLabel.Show();
                    deliteTexBox.Show();
                    deliteButton.Show();
                    listAdmin.Show();
                }

            }
            else 
            {
                ErrorMessageLabel.Text = "вы не ввели логин или пароль.";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClientSponsor sponsorBy = new MyClientSponsor("By");

            leaseHi.Register(sponsorBy);

        }

        private void deliteTexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimerTomato_Tick(object sender, EventArgs e)
        {
           //label3.Text = "im end";
          // MessageBox.Show("Пора отдохнуть");
            
        }
    
        private void timerStartButton_Click(object sender, EventArgs e)
        {
           /* 
            DateTime number;
            int time;
            bool success = DateTime.TryParse(timeStartTextBox.Text, out number);
            if (success)
            {
                time = number.Hour * 60 * 60 * 1000 + number.Minute * 60 * 1000 + number.Second * 1000;
                TimerTomato.Interval = time;
                label3.Text = "im start " + TimerTomato.Interval * 1000;
                
            }
            else
            {
                MessageBox.Show("Вы ввели время в неправильном формате");
            }
            
            TimerTomato.Start();
           */
        }
        // подключение
        private void CreateChannel()
        {
            try
            {
                Dictionary<string, string> properties_1 = new Dictionary<string, string>();

                properties_1["port"] = "0";
                SoapServerFormatterSinkProvider srvPrvd_1 = new SoapServerFormatterSinkProvider();
                srvPrvd_1.TypeFilterLevel = TypeFilterLevel.Full;
                SoapClientFormatterSinkProvider clntPrvd_1 = new SoapClientFormatterSinkProvider();

                TcpChannel tcpChannel = new TcpChannel(properties_1, clntPrvd_1, srvPrvd_1);
                ChannelServices.RegisterChannel(tcpChannel, true);

                helloObj = (Iremote)RemotingServices.Connect(typeof(Iremote), "tcp://localhost:8085/Hi");
                leaseHi = (ILease)helloObj.GetLifetimeService();

                RemotingConfiguration.Configure(System.IO.Directory.GetCurrentDirectory() + @"\Client.config", false);

                goodByObj = (Iremote1)RemotingServices.Connect(typeof(Iremote1), "http://localhost:8087/By");
                leaseBy = (ILease)goodByObj.GetLifetimeService();

                MyClientSponsor sponsorHi = new MyClientSponsor("Hi");
                MyClientSponsor sponsorBy = new MyClientSponsor("By");

                leaseHi.Register(sponsorHi);
                leaseBy.Register(sponsorBy);
            }
            catch (Exception e)
            {
                MessageBox.Show("Упс, что-то пошло не так:\n " + e.Message);
            }
        }
    }
    public class MyClientSponsor : MarshalByRefObject, ISponsor
    {
        private string Name;
        private DateTime lastRenewal;
        int count = 0;
        public MyClientSponsor(string name)
        {
            Name = name;
            Console.WriteLine("\nСпонсор \"" + name + "\" создан ");
            lastRenewal = DateTime.Now;
        }
        public TimeSpan Renewal(ILease lease)
        {
            count++;
            Console.WriteLine("Вызван метод Renewal спонсора \"" + Name + "\" {0}-ый раз", count);
            Console.WriteLine("Время с момента последнего вызова:" + (DateTime.Now - lastRenewal).ToString());
            lastRenewal = DateTime.Now;
            return TimeSpan.FromSeconds(10);
        }
    }
}