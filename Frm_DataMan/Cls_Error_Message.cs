using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Frm_DataMan
{
    public class Cls_Error_Message
    {
        public void Save_ErrorMess_Log(string str_ErrorMess)
        {
            try
            {
                string Path_Mess = "C:\\Betterway_Data_Save";

                FileStream fs_Mess = null;

                if (!Directory.Exists(Path_Mess))
                {
                    Directory.CreateDirectory(Path_Mess);
                }
                if (!File.Exists(Path_Mess + "\\" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "ErrorMess_Log.log"))
                {
                    fs_Mess = new FileStream(Path_Mess + "\\" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "ErrorMess_Log.log", FileMode.OpenOrCreate);
                    fs_Mess.Close();
                }

                StreamWriter sw_Mess = new StreamWriter(Path_Mess + "\\" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "ErrorMess_Log.log", true, Encoding.UTF8);

                sw_Mess.WriteLine(DateTime.Now.ToString() + " " + "错误原因：" + str_ErrorMess + "\r\n");//错误信息
 
                sw_Mess.Close();
                sw_Mess.Dispose();
                sw_Mess = null;
            }
            catch (Exception ex)
            {

            }
        }
      
    }
}
