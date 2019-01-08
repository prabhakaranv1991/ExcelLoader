using CommonModule.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelLoaderRepository
{
    public class ExcelDataLoaderRepository : IExcelDataLoaderRepository
    {
        private string connectionString = "";
        public ExcelDataLoaderRepository()
        {
            connectionString = @"Data Source=DESKTOP-6CS8HG2\SQLEXPRESS;Initial Catalog=Test;User ID=admin;Password=admin";
        }

        public void SaveExcelToSQL(IList<ExcelDataLoader> excelData)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"INSERT INTO CommodityDetails (CommodityCode,DiminishingBalanceContract,ExpiryMonthLimit,AllMonthLimit,
                            AnyOneMonthLimit,ValidFrom) VALUES (@CommodityCode,@DiminishingBalanceContract,@ExpiryMonthLimit,@AllMonthLimit,
                            @AnyOneMonthLimit,@ValidFrom)";
                    foreach(ExcelDataLoader data in excelData)
                    {

                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@CommodityCode", "1");
                    cmd.Parameters.AddWithValue("@DiminishingBalanceContract", "1");
                    cmd.Parameters.AddWithValue("@ExpiryMonthLimit", 10);
                    cmd.Parameters.AddWithValue("@AllMonthLimit", 10);
                    cmd.Parameters.AddWithValue("@AnyOneMonthLimit", 10);
                    cmd.Parameters.AddWithValue("@ValidFrom", DateTime.Now);

                    cmd.ExecuteNonQuery();

                    //sqlQuery = @"select PolicyId FROM FMEA_DocumentGroup Where (GroupId = @documentGroupId)";
                    //SqlDataReader reader = cmd.ExecuteReader();

                    //lockParams.IsLocked = Convert.ToBoolean(GetByte(reader, "IsLocked"));
                    //lockParams.LockedByUser = reader.GetInt32("LockedBy");
                    //lockParams.LockAliveTimeStamp = reader.GetDateTime("LockAliveTimeStamp");
                    //while (reader.Read())
                    //{
                    //    //do something
                    //}
                    con.Close();
                }
            }
            catch (SqlException ex)
            {

            }
        }
    }
}
