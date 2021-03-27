using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace CMS_DAL
{
    public class OperationTeamDAL
    {
        string conStr;
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;
        SqlDataAdapter sqlDaObj;

        public OperationTeamDAL()
        {
            conStr = ConfigurationManager.ConnectionStrings["GradingSystem"].ToString();
            sqlConObj = new SqlConnection(conStr);
            sqlCmdObj = new SqlCommand();
            sqlDaObj = new SqlDataAdapter();
        }

        public List<Batch> GetBatchDetails()
        {
            List<Batch> lstProduct = new List<Batch>();
            DataSet Batches = new DataSet();
            try
            {
                sqlCmdObj.CommandText = @"SELECT * FROM Batch";
                sqlCmdObj.Connection = sqlConObj;
                sqlConObj.Open();
                sqlDaObj.SelectCommand = sqlCmdObj;
                sqlDaObj.Fill(Batches, "Batches");
                lstProduct = (from DataRow row in Batches.Tables["Batches"].Rows
                              select new Model.Batch()
                              {
                                  BatchID = Convert.ToInt32(row["BatchID"]),
                                  BatchName = row["BatchName"].ToString(),
                                  BatchLocation = row["BatchLocation"].ToString(),
                                  BatchStatus = Convert.ToBoolean(row["BatchStatus"])
                              }
                            ).ToList();

                return lstProduct;
            }
            catch (Exception ex)
            {
                return lstProduct;
            }
            finally
            {
                sqlConObj.Close();
            }
        }

        public int AddNewBatch(Model.Batch BatchObj)
        {
            try
            {
                sqlCmdObj.CommandText = "usp_AddBatch";
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@Location", BatchObj.BatchLocation);
                var returnParameter = sqlCmdObj.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                sqlConObj.Open();
                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.ExecuteNonQuery();
                var result = returnParameter.Value;
                return (int)result;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                sqlConObj.Close();
            }
        }


        public int UpdateBatchStatus(Model.Batch BatchObj)
        {
            try
            {
                sqlCmdObj.CommandText = "usp_UpdateBatch";
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@BatchID", BatchObj.BatchID);
                var returnParameter = sqlCmdObj.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                sqlConObj.Open();
                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.ExecuteNonQuery();
                var result = returnParameter.Value;
                return (int)result;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                sqlConObj.Close();
            }
        }
    }
}
