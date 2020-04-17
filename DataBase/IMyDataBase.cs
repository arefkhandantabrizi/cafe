using System.Data;
using System.Data.SqlClient;

namespace HomeCafe.DataBase
{
    public interface IMyDataBase
    {
        bool Backup(string sqlBackupCommand);
        bool Restore(string sqlRestoreCommand);
        bool Insert(string sqlInsertCommand);
        bool Delete(string sqlDeleteCommand);
        bool Update(string sqlUpdateCommand);
        DataTable SelectDataTable(string sqlSelectCommand);
        DataSet SelectDataSet(string sqlSelectCommand);
        SqlDataReader Select(string sqlSelectCommand);
        void SqlClose();
    }
}