using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyQuanBanHangQuaMang.DTO;

namespace QuanLyBanHangQuaMang.DAO
{
    class ThanhToanDAO
    {
        static public SqlConnection _connection = null;
        static public SqlCommand _command = null;
        static String _connectionString = "";

        public static int Insert(ThanhToanDAO p)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();

                String procname = "";

                _command = new SqlCommand(procname);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;

                _command.Parameters.Add("@parameterName", SqlDbType.Int);

                int n = _command.ExecuteNonQuery();
                int maHoaDon = -1;

                return maHoaDon;
            }
            catch
            {
                return -1;
            }
        }
    }
}
