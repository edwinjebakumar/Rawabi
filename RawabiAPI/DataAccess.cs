using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WebAPIRawabi.Models;
using System.Data;

namespace RawabiAPI
{
    public class DataAccess
    {
        public bool CreateTransaction(Transaction tran)
        {
            string connString = "Data Source=LP-DELL-EDWIN;Initial Catalog=Rawabi;User Id=commanderapi;Password=abc@123;";
            int ret = 0;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TransactionProduct",connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@ProductId", tran.ProductId);
                    cmd.Parameters.AddWithValue("@Quantity", tran.Quantity);
                    cmd.Parameters.AddWithValue("@TranType", tran.TranType);
                    cmd.Parameters.AddWithValue("@TranDt", tran.TranDt==DateTime.MinValue?DateTime.Now:tran.TranDt);
                    cmd.CommandType = CommandType.StoredProcedure;
                    ret = cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            if (ret == 1)
                return true;
            else
                return false;
        }
    }
}