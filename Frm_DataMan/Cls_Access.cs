using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Frm_DataMan
{
    public class Cls_Access
    {
        #region 加载数据库路径
        //64bit
        public string db_strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\SPS.mdb;jet OleDb:DataBase Password=BETTERWAY520";//;Persist Security Info=True

        //32bit
        //public string strconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\SPS.mdb;jet OleDb:DataBase Password=BETTERWAY520";//;Persist Security Info=True
        public OleDbConnection db_oleconn = null;

        public OleDbCommand db_cmd = null;
        public OleDbDataReader db_reader = null;

        #endregion

        public void Open() 
        {
            if (db_oleconn == null)
            {
                db_oleconn = new OleDbConnection(db_strconn);
                db_oleconn.Open();
            }
        }

        public void Close()
        {
            if (db_oleconn != null)
            {
                db_oleconn.Close();
            }
        }

        public DataView RunSelectSQL(string sSQLString)
        {
            Open();
            DataSet OleDbDS = new DataSet();
            OleDbDataAdapter OleDbDA = new OleDbDataAdapter(sSQLString, db_oleconn);
            OleDbDA.Fill(OleDbDS);
            return OleDbDS.Tables[0].DefaultView;
        }

        public bool RunDelorInsSQL(string sSQLString)
        {
            try
            {
                Open();
                OleDbCommand OleDbComm = new OleDbCommand(sSQLString, db_oleconn);
                OleDbComm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }   
        }

        public string[,] GetColumnName()
        {
            string[,] AllColumnName = new string[10, 30];   //每行一个表，后面跟表中的字段名
            string[] ColumnName = new string[30];
            string[] TableName = new string[10];  //表名
            try
            {
                
                Open();
                DataTable shemaTable = db_oleconn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                int nnn = 0;
                int mmm = 0;
                foreach (DataRow dr in shemaTable.Rows)
                {
                    TableName[mmm] = dr["TABLE_NAME"].ToString();
                    AllColumnName[mmm,0] = dr["TABLE_NAME"].ToString();
                    nnn = 0;
                    DataTable columnTable = db_oleconn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, dr["TABLE_NAME"].ToString(), null });

                    foreach (DataRow dr2 in columnTable.Rows)
                    {
                        nnn = nnn + 1;
                        //ColumnName[nnn] = dr2["COLUMN_NAME"].ToString();
                        AllColumnName[mmm, nnn] = dr2["COLUMN_NAME"].ToString();
                        //Console.WriteLine(dr2["COLUMN_NAME"]);
                    }
                    mmm = mmm + 1;
                }
                return AllColumnName;
            }
            catch (Exception)
            {
                return AllColumnName;
            }
      
        }

        public string T_Users_Name = "Users";
        public string T_Alarm_Name = "Alarm_history";
        public string T_Standard_Name = "Standard_library";
        public string T_Setting_Name = "Config";
        public string T_Barcode_Name = "Barcode_history";
    }
}
