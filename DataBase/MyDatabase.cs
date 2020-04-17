using System;
using System.Data;
using System.Data.SqlClient;

namespace HomeCafe.DataBase
{
    public class MyDatabase : IMyDataBase
    {
        public string UserError;//khata baraye namayesh be karbar
        public string DetailedError;//baraye baresiye fani
        public string SqlCommandError;//khataye dastorat sql
        // private static string currentDirectory;
        public SqlConnection Conn;
        public SqlConnection Restoreconn;
        public SqlCommand Command;



        public MyDatabase()
        {

            Conn = new SqlConnection
            {
                ConnectionString = @"Data Source=.;Initial Catalog=Cafe ;User ID=sa;password=qwert12345"
            };



        }
        




        /*    public Database(string ip)
            {
             
              
                Conn = new SqlConnection();
                Conn.ConnectionString = @"server=" + ip + ",1433;initial catalog = mehr; user=sa;password=123";

            }
            */


        private bool SqlConnect()
        {
            try
            {

                Conn.Open();
                return true;
            }

            catch (Exception mb)
            {
                UserError = "خطا در برقراری ارتباط با بانک اطلاعاتی";
                DetailedError = mb.Message;
                return false;
            }
        }



   
        public void SqlClose()
        {
            Conn.Close();

        }
      


        public bool Backup(string sqlBackupCommand)
        {
            // Backup Command= "BACKUP DATABASE databasename TO DISK=filelocation+filename.bak";
            if (SqlConnect())
                Command = new SqlCommand(sqlBackupCommand, Conn);
            else
                return false;
            try
            {
                Command.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception kk)
            {

                SqlCommandError = kk.Message;

                return false;

            }

            return true;

        }

        public bool Restore(string sqlRestoreCommand)
        {
            // RESTORE Command=" Alter Database databasename Set SINGLE_USER WITH ROLLBACK IMMEDIATE; Restore Database databasename 
            // + FROM DISK= .bakfilelocation WITH REPLACE;"
            if (SqlConnect())
                Command = new SqlCommand(sqlRestoreCommand, Restoreconn);
            else
                return false;
            try
            {
                Command.ExecuteNonQuery();
                Restoreconn.Close();

            }
            catch (Exception kk)
            {

                SqlCommandError = kk.Message;

                return false;

            }
            return true;
        }

        public bool Insert(string sqlInsertCommand)
        {
            if (SqlConnect())
                Command = new SqlCommand(sqlInsertCommand, Conn);
            else

                return false;

            try
            {
                Command.ExecuteNonQuery();//tedad radif haye tahte tasir gharar gerefte
                Conn.Close();
            }

            catch (Exception kk)
            {

                SqlCommandError = kk.Message;

                return false;

            }

            return true;

        }
        public bool Delete(string sqlDeleteCommand)
        {
            if (SqlConnect())

                Command = new SqlCommand(sqlDeleteCommand, Conn);
            else

                return false;

            try
            {
                Command.ExecuteNonQuery();//tedad radif haye tahte tasir gharar gerefte
                Conn.Close();
            }

            catch (Exception kk)
            {

                SqlCommandError = kk.Message;
                return false;
            }

            return true;

        }
        public bool Update(string sqlUpdateCommand)
        {
            if (SqlConnect())

                Command = new SqlCommand(sqlUpdateCommand, Conn);
            else

                return false;

            try
            {
                Command.ExecuteNonQuery();//tedad radif haye tahte tasir gharar gerefte
                Conn.Close();
            }

            catch (Exception kk)
            {

                SqlCommandError = kk.Message;
                return false;
            }

            return true;

        }

        //in tabe yek dataset ke mitavand shamel yek jadval ya chnad jadval bashad baste be 
        //select bargardanad

        public DataTable SelectDataTable(string sqlSelectCommand)
        {
            if (!SqlConnect())


                return null;

            try
            {
                var da = new SqlDataAdapter(sqlSelectCommand, Conn);
                var mb = new DataTable();
                da.Fill(mb);
                Conn.Close();
                return mb;
            }

            catch (Exception kk)
            {

                SqlCommandError = kk.Message;
                return null;
             
                                            
             }

        }

        public DataSet SelectDataSet(string sqlSelectCommand)
        {
            if (!SqlConnect())


                return null;

            try
            {
                var da = new SqlDataAdapter(sqlSelectCommand, Conn);
                var mb = new DataSet();
                da.Fill(mb);
                Conn.Close();
                return mb;
            }

            catch (Exception kk)
            {

                SqlCommandError = kk.Message;
                return null;
            }



        }


        public SqlDataReader Select(string sqlSelectCommand)
        {
            if (!SqlConnect())


                return null;

            try
            {

                Command = new SqlCommand(sqlSelectCommand, Conn);
                var temp = Command.ExecuteReader();
                //Conn.Close();
                return temp;

            }

            catch (Exception kk)
            {

                SqlCommandError = kk.Message;
                return null;
            }



        }



    }

}

