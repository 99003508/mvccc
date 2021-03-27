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
    public class FacultyDAL
    {
        string conStr;
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;
        SqlDataAdapter sqlDaObj;

        public FacultyDAL()
        {
            conStr = ConfigurationManager.ConnectionStrings["GradingSystem"].ToString();
            sqlConObj = new SqlConnection(conStr);
            sqlCmdObj = new SqlCommand();
            sqlDaObj = new SqlDataAdapter();
        }

        public List<Track> GetTrackDetails()
        {
            List<Track> lstProduct = new List<Track>();
            DataSet Tracks = new DataSet();
            try
            {
                sqlCmdObj.CommandText = @"SELECT * FROM Track";
                sqlCmdObj.Connection = sqlConObj;
                sqlConObj.Open();
                sqlDaObj.SelectCommand = sqlCmdObj;
                sqlDaObj.Fill(Tracks, "Track");
                lstProduct = (from DataRow row in Tracks.Tables["Track"].Rows
                              select new Model.Track()
                              {
                                  TrackID =Convert.ToInt32(row["TrackID"]),
                                  TrackName = row["TrackName"].ToString(),
                                  TrackDescription = row["TrackDescription"].ToString(),
                                  TrackDuration = row["TrackDuration"].ToString(),
                                  TrackStatus=Convert.ToBoolean(row["TrackStatus"]),
                                  BatchID = Convert.ToInt32(row["BatchID"])
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

        public int AddNewTrack(Model.Track TrackObj)
        {
            try
            {
                sqlCmdObj.CommandText = "usp_AddTrack";
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@Track_Name", TrackObj.TrackName);
                sqlCmdObj.Parameters.AddWithValue("@Track_Description", TrackObj.TrackDescription);
                sqlCmdObj.Parameters.AddWithValue("@Track_Duration", TrackObj.TrackDuration);
                sqlCmdObj.Parameters.AddWithValue("@Batch_ID", TrackObj.BatchID);
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

        public int UpdateModuleDuration(Model.Module ModuleObj)
        {
            try
            {
                sqlCmdObj.CommandText = "usp_UpdateModuleDuration";
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@ModuleID",ModuleObj.ModuleID);
                sqlCmdObj.Parameters.AddWithValue("@Module_Duration",ModuleObj.ModuleDuration);
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

        public int UpdateModuleName(Model.Module ModuleObj)
        {
            try
            {
                sqlCmdObj.CommandText = "usp_UpdateModuleName";
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@Module_ID", ModuleObj.ModuleID);
                sqlCmdObj.Parameters.AddWithValue("@Module_Name",ModuleObj.ModuleName);
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

        public int UpdateModuleStatus(Model.Module ModuleObj)
        {
            try
            {
                sqlCmdObj.CommandText = "usp_UpdateModuleStatus";
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@Module_ID", ModuleObj.ModuleID);
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


        public int UpdateTrackDescription(Model.Track TrackObj)
        {
            try
            {
                sqlCmdObj.CommandText = "usp_UpdateTrackDescription";
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@TrackID",TrackObj.TrackID);
                sqlCmdObj.Parameters.AddWithValue("@TrackDescription",TrackObj.TrackDescription);
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

        public int UpdateTrackDuration(Model.Track TrackObj)
        {
            try
            {
                sqlCmdObj.CommandText = "usp_UpdateTrackDuration";
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@TrackID", TrackObj.TrackID);
                sqlCmdObj.Parameters.AddWithValue("@TrackDuration", TrackObj.TrackDuration);
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

        public int UpdateTrackName(Model.Track TrackObj)
        {
            try
            {
                sqlCmdObj.CommandText = "usp_UpdateTrackName";
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@TrackID", TrackObj.TrackID);
                sqlCmdObj.Parameters.AddWithValue("@TrackName", TrackObj.TrackName);
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

        public int UpdateTrackStatus(Model.Track TrackObj)
        {
            try
            {
                sqlCmdObj.CommandText = "usp_UpdateTrackStatus";
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@TrackID", TrackObj.TrackID);
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
