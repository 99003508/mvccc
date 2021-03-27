using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CMS_BL;

namespace CourseMgmtSystem.Controllers
{
    public class OperationTeamController : ApiController
    {
        [ActionName("GetBatchDetails")]
        [HttpGet]
        public HttpResponseMessage GetBatchDetails()
        {
            try
            {
                OperationTeamBL operationTeamObj = new OperationTeamBL();
                var result = operationTeamObj.GetBatches();
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }

        [ActionName("AddNewBatch")]
        [HttpPost]
        public HttpResponseMessage AddNewBatch(Model.Batch BatchObj)
        {
            try
            {
                OperationTeamBL operationTeamObj = new OperationTeamBL();
                int result = operationTeamObj.AddBatch(BatchObj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }

        [ActionName("UpdateBatch")]
        [HttpPost]
        public HttpResponseMessage UpdateBatch(Model.Batch BatchObj)
        {
            try
            {
                OperationTeamBL operationTeamObj = new OperationTeamBL();
                int result = operationTeamObj.UpdateBatch(BatchObj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }
    }
}
