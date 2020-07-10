using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using Cognex.DataMan.SDK;
using Cognex.DataMan.Discovery;
using System.Runtime.InteropServices;
using System.IO;

namespace Frm_DataMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 全局变量
        public Cls_Error_Message cls_ErrorMessage = new Cls_Error_Message();
        frm_Wait Frm_Wait;

        int Times_withoutdata = 0;

        string SettingSavePath = "";
        string SettingPath_DataMan = "";
        string SettingPath_Comm = "";
        string SettingPath_SavePath = "";
        string Result_SavePath = "";
        string CommMode = "";

        #region 读码器通信变量
        //EthSystemDiscoverer ethSystemDiscoverer = new EthSystemDiscoverer();

        EthSystemConnector myConn;
        public DataManSystem myDataMan;

        string recStr_DataMan = "";
        int i_ConnNum_DataMan = 0;
        bool b_ConnDataMan = false;
        string str_ex_DataMan = "";     //读码器连接异常时的详细信息
        Socket clientSocket_DataMan = null;
        IPAddress ip_DataMan = null;
        IPEndPoint ipe_DataMan = null;
        bool b_reCon_DataMan = false;
        public string DataMan_Ip = "";
        public int DataMan_Port = 0;
        DateTime starttime;
        DateTime endtime;
        #endregion

        #region TCP发送结果变量
        //服务器
        Socket sSocket;
        Socket serverSocket;
        int Port_Server;
        String IP_Server;
        //客户端
        int Port_Client;
        String IP_Client;
        Socket ClientSocket;
        bool b_ConnClient = false;

        #endregion
        #endregion

        //隐藏光标
        [DllImport("user32", EntryPoint = "HideCaret")]
        private static extern bool HideCaret(IntPtr hWnd);

        #region 界面委托
        #region 委托：更改控件文字
        protected delegate void ChangeTextHandler(Control labelCtrl, string Txt);
        void InvokeChangeText(Control labelCtrl, string Txt)
        {
            labelCtrl.Invoke((ChangeTextHandler)ChangeText, labelCtrl, Txt);
        }
        void ChangeText(Control labelCtrl, string Txt)
        {
            labelCtrl.Text = Txt;
        }
        #endregion

        #region 委托：更改控件颜色
        protected delegate void ChangeColorHandler(Control labelCtrl, System.Drawing.Color Color);
        void InvokeChangeColor(Control labelCtrl, System.Drawing.Color Color)
        {
            labelCtrl.Invoke((ChangeColorHandler)ChangeColor, labelCtrl, Color);
        }
        void ChangeColor(Control labelCtrl, System.Drawing.Color Color)
        {
            labelCtrl.BackColor = Color;
        }
        #endregion

        #region 委托：更改控件图片
        protected delegate void ChangeImageHandler(Panel PanelCtrl, System.Drawing.Image img);
        void InvokeChangeImage(Panel PanelCtrl, System.Drawing.Image img)
        {
            PanelCtrl.Invoke((ChangeImageHandler)ChangeImage, PanelCtrl, img);
        }
        void ChangeImage(Panel PanelCtrl, System.Drawing.Image img)
        {
            PanelCtrl.BackgroundImage = img;
        }
        #endregion 
        #endregion

        public bool InitializeDataMan()
        {
            try
            {
                using (StreamReader sReader = File.OpenText(SettingPath_DataMan))
                {
                    DataMan_Ip = sReader.ReadLine();
                    DataMan_Port = Convert.ToInt32(sReader.ReadLine());
                }
                txt_IP_DataMan.Text = DataMan_Ip;
                txt_Port_DataMan.Text = DataMan_Port.ToString();
                myConn = new EthSystemConnector(IPAddress.Parse(DataMan_Ip));
                myDataMan = new DataManSystem(myConn);
                AddEventHandlers();
                myConn.UserName = "admin";
                myConn.Password = "";
                myDataMan.DefaultTimeout = 5000;
                try
                {
                    myDataMan.Connect();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void bgw_DataMan_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            #region 客户端
            try
            {
                recStr_DataMan = "";
                #region 从注册表读取机器人IP和Port
                //DataMan_Ip = get_ConfigValue("DataMan_Ip");
                //DataMan_Port = Convert.ToInt32(get_ConfigValue("DataMan_Port"));
                #endregion
                if (clientSocket_DataMan == null)
                {
                  
                    ip_DataMan = IPAddress.Parse(DataMan_Ip);
                    ipe_DataMan = new IPEndPoint(ip_DataMan, DataMan_Port);

                    clientSocket_DataMan = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    clientSocket_DataMan.Connect(ipe_DataMan);
                    try
                    {
                        myDataMan.Connect();
                    }
                    catch (Exception)
                    {
                    }
                }
                if (b_reCon_DataMan == true)
                {
                    b_reCon_DataMan = false;
                    cls_ErrorMessage.Save_ErrorMess_Log(i_ConnNum_DataMan + "重连成功!");
                    txt_DataMan_Mess.Text = i_ConnNum_DataMan + "重连成功!" + "\r\n" + txt_DataMan_Mess.Text;
                    i_ConnNum_DataMan = 0;
                    lbl_DataMan_Mess.Text = "读码器连接正常";
                    lbl_DataMan_Mess.BackColor = Color.Green;
                }

                b_ConnDataMan = true;
                lbl_DataMan_Mess.Text = "读码器连接正常";
                lbl_DataMan_Mess.BackColor = Color.Green;
                str_ex_DataMan = "";
                int i_Size = clientSocket_DataMan.ReceiveBufferSize;
                byte[] recBytes = new byte[i_Size];
                int bytes = clientSocket_DataMan.Receive(recBytes, recBytes.Length, 0);
                recStr_DataMan += Encoding.Default.GetString(recBytes, 0, bytes);
                Times_withoutdata = 0;
                if (recStr_DataMan == "")
                {
                    b_ConnDataMan = false;
                }
            }
            catch (Exception ex)
            {
                str_ex_DataMan = ex.Message;
                i_ConnNum_DataMan++;
                b_ConnDataMan = false;
                b_reCon_DataMan = true;
            }
            #endregion
        }

        private void bgw_DataMan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (b_ConnDataMan == false)
            {
                clientSocket_DataMan = null;
                ip_DataMan = null;
                ipe_DataMan = null;
                if (myDataMan!=null)
                {
                    if (myDataMan.IsConnected)
                    {
                        myDataMan.Disconnect();

                    }
                }
               
                //cls_ErrorMessage.Save_ErrorMess_Log(i_ConnNum_DataMan + " Reconnect Fail!" + "Detail：" + str_ex_DataMan);
                txt_DataMan_Mess.Text = i_ConnNum_DataMan + "重连失败!" + "\r\n" + txt_DataMan_Mess.Text;
                lbl_DataMan_Mess.Text = "连接失败";
                lbl_DataMan_Mess.BackColor = Color.Red;
            }
            else
            {
                i_ConnNum_DataMan = 0;
                //if (waitForProtocol != null)
                //    waitForProtocol.Enabled = false;
                Log(recStr_DataMan);
                ////if (myDataMan.IsConnected)
                ////{
                ////    panel_Result.BackgroundImage = myDataMan.GetLastReadImage();                   
                ////}
                ////try
                ////{
                ////    string[] str_ReadSC = recStr_DataMan.Split(':');
                ////    lbl_Code.Text = "解码内容：" + str_ReadSC[0].Replace("SC", "");

                ////    string[] str_Read_D = recStr_DataMan.Split('(');
                ////    lbl_Grade.Text = "评码等级：" + str_Read_D[1].Substring(0, 1);
                ////}
                ////catch (Exception)
                ////{
                    
                ////}
                ////string[] a = new string[1];
                ////a[0] = lbl_Code.Text;
                ////string[] b = new string[1];
                ////b[0] = lbl_Grade.Text;
                ////Sub_WriteEXCEL(a, b);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!bgw_DataMan.IsBusy)
            {
                bgw_DataMan.RunWorkerAsync();
            }
            //if (!bgw_TCP.IsBusy)
            //{
            //    bgw_TCP.RunWorkerAsync();
            //}
            //Times_withoutdata++;
            //if (Times_withoutdata>60)
            //{
            //    b_ConnDataMan = false;
            //    bgw_DataMan.CancelAsync();
              
            //    clientSocket_DataMan = null;
            //    ip_DataMan = null;
            //    ipe_DataMan = null;
            //    if (myDataMan != null)
            //    {
            //        if (myDataMan.IsConnected)
            //        {
            //            myDataMan.Disconnect();

            //        }
            //    }
              
            //    Times_withoutdata = 0;
            //}
          
        }

        private void splitContainer2_Panel2_DoubleClick(object sender, EventArgs e)
        {
            splitContainer_Show.Visible = false;
            splitContainer_Setting.Visible = true;
        }

        private void btn_SaveSetting_Click(object sender, EventArgs e)
        {
            

            using (StreamWriter sWriter = new StreamWriter(SettingPath_DataMan, false, Encoding.Default))
            {
                //if (txt_IP_DataMan.Text!="")
                //{
                //}
                //else
                //{

                //}
                sWriter.WriteLine(txt_IP_DataMan.Text);
                sWriter.WriteLine(txt_Port_DataMan.Text);
            }
            using (StreamWriter sWriter = new StreamWriter(SettingPath_Comm, false, Encoding.Default))
            {
                if (rb_Client.Checked)
                {
                    sWriter.WriteLine("Client");
                }
                else
                {
                    sWriter.WriteLine("Server");
                }
                sWriter.WriteLine(txt_IP_Comm.Text);
                sWriter.WriteLine(txt_Port_Comm.Text);
            }
            using (StreamWriter sWriter = new StreamWriter(SettingPath_SavePath, false, Encoding.Default))
            {
                
                sWriter.WriteLine(txt_SavePath.Text);
            }
            DialogResult result = MessageBox.Show("保存成功,必须重启程序才能是配置生效,是否重启?", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
            this.Close();
           
            splitContainer_Show.Visible = true;
            splitContainer_Setting.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
            timer1.Enabled = false;
            //Application.DoEvents();
            //this.Hide();
            //Frm_Wait = new frm_Wait();
            //Frm_Wait.Show();
            SettingSavePath = System.Windows.Forms.Application.StartupPath + "\\Settings";
            try
            {
                if (!Directory.Exists(SettingSavePath))
                {
                    Directory.CreateDirectory(SettingSavePath);
                }
            }
            catch (Exception ex)
            {
            }
            SettingPath_DataMan = SettingSavePath + "\\DataMan" + ".ini";
            SettingPath_Comm = SettingSavePath + "\\Comm" + ".ini";
            SettingPath_SavePath = SettingSavePath + "\\SavePath" + ".ini";
            using (StreamReader sReader = File.OpenText(SettingPath_Comm))
            {
                CommMode = sReader.ReadLine();
                if (CommMode=="Client")
                {
                    rb_Client.Checked = true;
                    txt_IP_Comm.Text = sReader.ReadLine();
                    txt_Port_Comm.Text = sReader.ReadLine();
                    IP_Client = txt_IP_Comm.Text;
                    try
                    {
                        Port_Client = Convert.ToInt32(txt_Port_Comm.Text);
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                }
                else
                {
                    rb_Server.Checked = true;
                    txt_IP_Comm.Text = sReader.ReadLine();
                    txt_Port_Comm.Text = sReader.ReadLine();
                    IP_Server = txt_IP_Comm.Text;
                    try
                    {
                        Port_Server = Convert.ToInt32(txt_Port_Comm.Text);
                    }
                    catch (Exception ex)
                    {
                        
                        throw;
                    }
                   
                }
            }
            using (StreamReader sReader = File.OpenText(SettingPath_SavePath))
            {
                Result_SavePath = sReader.ReadLine();
                txt_SavePath.Text = Result_SavePath;
            }
            #region 初始化读码器IP
            InitializeDataMan();
            #endregion
            #region 为了让textbox里面没有光标跳动
            panel_Result.Focus();
            lbl_Code.SelectionStart = 0;
            lbl_Code.SelectionLength = 0;
            lbl_Code.GotFocus += textBox_GotFocus;  
            #endregion
            //waitForProtocol.Enabled = true;
            //Frm_Wait.Close();
            //this.Show();
            timer1.Enabled = true;
        }

        //void ethSystemDiscoverer_SystemDiscovered(EthSystemDiscoverer.SystemInfo systemInfo) 
        //{
        //    str_ex_DataMan = "";
        //}

        private void Log(string logString, params object[] logStringFormatArgs)
        {
            txt_Error_Message.AppendText(String.Format(logString, logStringFormatArgs));
            txt_Error_Message.AppendText(Environment.NewLine + Environment.NewLine);
        }

        private void AddEventHandlers()
        {
            myDataMan.StatusEventArrived +=new StatusEventArrivedHandler(myDataMan_StatusEventArrived);
            myDataMan.SystemWentOffline+=new SystemWentOfflineHandler(myDataMan_SystemWentOffline);
            myDataMan.SystemWentOnline+=new SystemWentOnlineHandler(myDataMan_SystemWentOnline);
            myDataMan.SystemConnected += new SystemConnectedHandler(myDataMan_SystemConnected);
            myDataMan.SystemDisconnected+=new SystemDisconnectedHandler(myDataMan_SystemDisconnected);
            myDataMan.ReadStringArrived += new ReadStringArrivedHandler(myDataMan_ReadStringArrived);
            myDataMan.ImageArrived += new ImageArrivedHandler(myDataMan_ImageArrived);
            myDataMan.ImageGraphicsArrived += new ImageGraphicsArrivedHandler(myDataMan_ImageGraphicsArrived);
            myDataMan.CodeQualityDataArrived+=new CodeQualityDataArrivedHandler(myDataMan_CodeQualityDataArrived);
        }

        void myDataMan_StatusEventArrived(string xml)
        {
            // The event is raised from a non-GUI thread.
            // Invoke this function on the GUI thread.
            if (InvokeRequired)
            {
                Invoke(new StatusEventArrivedHandler(myDataMan_StatusEventArrived), new Object[] { xml });
                return;
            }

            Log("StatusEventArrived");
        }

        void myDataMan_SystemWentOffline()
        {
            // The event is raised from a non-GUI thread.
            // Invoke this function on the GUI thread.
            if (InvokeRequired)
            {
                Invoke(new SystemWentOfflineHandler(myDataMan_SystemWentOffline));
                return;
            }

            Log("SystemWentOffline");
        }

        void myDataMan_SystemWentOnline()
        {
            // The event is raised from a non-GUI thread.
            // Invoke this function on the GUI thread.
            if (InvokeRequired)
            {
                Invoke(new SystemWentOnlineHandler(myDataMan_SystemWentOnline));
                return;
            }

            Log("SystemWentOnline");
        }

        void myDataMan_SystemConnected()
        {
            // The event is raised from a non-GUI thread.
            // Invoke this function on the GUI thread.
            if (InvokeRequired)
            {
                Invoke(new SystemConnectedHandler(myDataMan_SystemConnected));
                return;
            }

            Log("SystemConnected");
            InvokeChangeColor(lbl_DataMan_Mess, Color.Green);
            InvokeChangeText(lbl_DataMan_Mess, "读码器连接正常");
        }

        void myDataMan_SystemDisconnected()
        {
            // The event is raised from a non-GUI thread.
            // Invoke this function on the GUI thread.
            if (InvokeRequired)
            {
                Invoke(new SystemDisconnectedHandler(myDataMan_SystemDisconnected));
                return;
            }

            Log("SystemDisconnected");
            InvokeChangeColor(lbl_DataMan_Mess, Color.Red);
            InvokeChangeText(lbl_DataMan_Mess, "读码器连接异常");
        }

        void myDataMan_ReadStringArrived(int resultId, string readString)
        {
            // The event is raised from a non-GUI thread.
            // Invoke this function on the GUI thread.
            if (InvokeRequired)
            {
                Invoke(new ReadStringArrivedHandler(myDataMan_ReadStringArrived), new Object[] { resultId, readString });
                return;
            }
            string[] str_ReadSC = readString.Split(':');
            string now_Code = "";
            string now_Grade = "";
            InvokeChangeText(lbl_Code, "解码内容：" + str_ReadSC[0].Replace("SC", ""));
            now_Code = str_ReadSC[0].Replace("SC", "");
            try
            {
                string[] str_Read_D = readString.Split('(');
                InvokeChangeText(lbl_Grade, "评码等级：" + str_Read_D[1].Substring(0, 1));
                now_Grade = str_Read_D[1].Substring(0, 1);
            }
            catch (Exception)
            {
                InvokeChangeText(lbl_Grade, "");
            }
            string Path_ResultToCSV = Result_SavePath + "\\"+DateTime.Today.ToString("yyyyMMdd") + ".csv";
            string Msg;
            using (StreamWriter sWriter = new StreamWriter(Path_ResultToCSV, true, Encoding.Default))
            {
                Msg = String.Format("{0}:{1}:{2}:{3},{4},{5}", DateTime.Now.Hour, DateTime.Now.Minute,
                    DateTime.Now.Second, DateTime.Now.Millisecond, now_Code, now_Grade);
                //if (txt_IP_DataMan.Text!="")
                //{
                //}
                //else
                //{

                //}
                sWriter.WriteLine(Msg);
            }
            byte[] sendByte = Encoding.Default.GetBytes(Msg);

            if (CommMode == "Client")
            {
                try
                {
                    if (ClientSocket != null)
                    {
                        ClientSocket.Send(sendByte);
                    }
                
                }
                catch (Exception)
                {
                    
                }
               
            }
            else
            {
                try
                {
                    if (serverSocket != null)
                    {
                        serverSocket.Send(sendByte);
                    }

                }
                catch (Exception)
                {

                }
            }
            Log("ReadStringArrived");
          
        }

        void myDataMan_ImageArrived(int resultId, Image image)
        {
            // The event is raised from a non-GUI thread.
            // Invoke this function on the GUI thread.
            if (InvokeRequired)
            {
                Invoke(new ImageArrivedHandler(myDataMan_ImageArrived), new Object[] { resultId, image });
                return;
            }
            Log("ImageArrived");
            InvokeChangeImage(panel_Result, image);
        }

        void myDataMan_ImageGraphicsArrived(int resultId, string xml)
        {
            // The event is raised from a non-GUI thread.
            // Invoke this function on the GUI thread.
            if (InvokeRequired)
            {
                Invoke(new ImageGraphicsArrivedHandler(myDataMan_ImageGraphicsArrived), new Object[] { resultId, xml });
                return;
            }

            Log("ImageGraphicsArrived");
        }

        void myDataMan_CodeQualityDataArrived(string data) 
        {
            // The event is raised from a non-GUI thread.
            // Invoke this function on the GUI thread.
            if (InvokeRequired)
            {
                Invoke(new CodeQualityDataArrivedHandler(myDataMan_CodeQualityDataArrived), new Object[] { data });
                return;
            }
            Log("CodeQualityDataArrived");
            InvokeChangeText(lbl_Grade, data);
        }

        void textBox_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        } 

        private void panel_Result_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemoveEventHandlers();
            if (myDataMan != null)
            {
                try
                {
                    myDataMan.Disconnect();
                }
                catch (Exception)
                {

                }
            }
        }

        private void RemoveEventHandlers()
        {
            myDataMan.StatusEventArrived -= new StatusEventArrivedHandler(myDataMan_StatusEventArrived);
            myDataMan.SystemWentOffline -= new SystemWentOfflineHandler(myDataMan_SystemWentOffline);
            myDataMan.SystemWentOnline -= new SystemWentOnlineHandler(myDataMan_SystemWentOnline);
            myDataMan.SystemConnected -= new SystemConnectedHandler(myDataMan_SystemConnected);
            myDataMan.SystemDisconnected -= new SystemDisconnectedHandler(myDataMan_SystemDisconnected);
            myDataMan.ReadStringArrived -= new ReadStringArrivedHandler(myDataMan_ReadStringArrived);
            myDataMan.ImageArrived -= new ImageArrivedHandler(myDataMan_ImageArrived);
            myDataMan.ImageGraphicsArrived -= new ImageGraphicsArrivedHandler(myDataMan_ImageGraphicsArrived);
        }

        private void rb_Client_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Client.Checked)
            {
                txt_IP_Comm.Enabled = true;
            }
            else
            {
                txt_IP_Comm.Enabled = true;
                txt_IP_Comm.Text = "127.0.0.1";
            }
        }

        private void rb_Server_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Client.Checked)
            {
                txt_IP_Comm.Enabled = true;
            }
            else
            {
                txt_IP_Comm.Enabled = true;
                txt_IP_Comm.Text = "127.0.0.1";
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {           
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) { txt_SavePath.Text = folderBrowserDialog1.SelectedPath; }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            splitContainer_Show.Visible = true;
            splitContainer_Setting.Visible = false;
        }

        private void bgw_TCP_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                if (CommMode == "Client")
                {
                    IPAddress ip = IPAddress.Parse(IP_Client);
                    IPEndPoint ipe = new IPEndPoint(ip, Port_Client);
                    if (ClientSocket == null)
                    {
                        ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        ClientSocket.Connect(ipe);                       
                    }
                    if (IsConnected(ClientSocket))
                    {
                        InvokeChangeColor(lbl_TCP_Mess, Color.Green);
                        InvokeChangeText(lbl_TCP_Mess, "TCP连接已建立");
                        b_ConnClient = true;
                    }
                    else
                    {
                        InvokeChangeColor(lbl_TCP_Mess, Color.Red);
                        InvokeChangeText(lbl_TCP_Mess, "TCP连接已断开");
                        b_ConnClient = false;
                    }
                }
                else
                {
                    IPAddress ip = IPAddress.Parse(IP_Server);
                    IPEndPoint ipe = new IPEndPoint(ip, Port_Server);
                    if (sSocket==null)
                    {
                        sSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        sSocket.Bind(ipe);
                        sSocket.Listen(0);
                    }
                    InvokeChangeColor(lbl_TCP_Mess, Color.Yellow);
                    InvokeChangeText(lbl_TCP_Mess, "监听已经打开，请等待");
                    if (serverSocket==null)
                    {
                        serverSocket = sSocket.Accept();
                    }
                    bool b = serverSocket.Poll(10, SelectMode.SelectError);
                    InvokeChangeColor(lbl_TCP_Mess, Color.Green);
                    InvokeChangeText(lbl_TCP_Mess, "TCP连接已建立");
                    string recStr = "";
                    byte[] recByte = new byte[4096];
                    int bytes = serverSocket.Receive(recByte, recByte.Length, 0);
                    recStr += Encoding.Default.GetString(recByte, 0, bytes);
                    if (recStr=="")
                    {
                         InvokeChangeColor(lbl_TCP_Mess, Color.Red);
                         InvokeChangeText(lbl_TCP_Mess, "客户端已掉线");
                         serverSocket = null;
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {
                if (CommMode == "Client")
                {
                    InvokeChangeColor(lbl_TCP_Mess, Color.Red);
                    InvokeChangeText(lbl_TCP_Mess, "服务器已关闭");
                }
                else
                {
                    InvokeChangeColor(lbl_TCP_Mess, Color.Red);
                    InvokeChangeText(lbl_TCP_Mess, "客户端已掉线");
                }
               
            }
        }

        public bool IsConnected(Socket TCPSocket)
        {


            if (TCPSocket == null)
                 return false;
             // 另外说明：tcpc.Connected同tcpc.Client.Connected；
             // tcpc.Client.Connected只能表示Socket上次操作(send,recieve,connect等)时是否能正确连接到资源,
             // 不能用来表示Socket的实时连接状态。
             try
             {
                 if ((TCPSocket.Poll(20, SelectMode.SelectRead)) && (TCPSocket.Available == 0))
                     return false;
             }
             //catch (SocketException e)
             //{
             //    if (e.NativeErrorCode != 10035)
             //        return false;
             //}
             catch
             {
                 return false;
             }
             return true;
            
        }

        private void bgw_TCP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (CommMode == "Client")
            {
                if (!b_ConnClient)
                {
                     ClientSocket = null;
              
                }
            }
        }  
 

    }
}
