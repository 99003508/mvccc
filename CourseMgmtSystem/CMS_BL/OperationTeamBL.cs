using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using CMS_DAL;

namespace CMS_BL
{
    public class OperationTeamBL
    {
        public List<Batch> GetBatches()
        {
            List<Batch> BatchList = new List<Batch>();
            try
            {
                OperationTeamDAL OTObj = new OperationTeamDAL();
                BatchList = OTObj.GetBatchDetails();
                return BatchList;
            }
            catch (Exception ex)
            {
                return BatchList;
            }
        }

        public int AddBatch (Batch BatchObj)
        {
            try
            {
                OperationTeamDAL OTObj = new OperationTeamDAL();
                int lst = OTObj.AddNewBatch(BatchObj);
                return lst;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int UpdateBatchStatus(Batch BatchObj)
        {
            try
            {
                OperationTeamDAL OTObj = new OperationTeamDAL();
                int lst = OTObj.UpdateBatchStatus(BatchObj);
                return lst;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
