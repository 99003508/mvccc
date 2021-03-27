using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CMS_BL;

namespace CourseMgmtSystem.Controllers
{
    public class FacultyController : ApiController
    {
        [ActionName("GetTrackDetails")]
        [HttpGet]
        public HttpResponseMessage GetTrackDetails()
        {
            try
            {
                FacultyBL FacultyObj = new FacultyBL();
                var result = FacultyObj.GetTracks();
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }

        [ActionName("GetBatchDetails")]
        [HttpGet]
        public HttpResponseMessage GetBatchDetails()
        {
            try
            {
                FacultyBL FacultyObj = new FacultyBL();
                var result = FacultyObj.GetBatches();
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }

        [ActionName("AddNewTrack")]
        [HttpPost]
        public HttpResponseMessage AddNewTrack(Model.Track TObj)
        {
            try
            {
                FacultyBL FacultyObj = new FacultyBL();
                int result = FacultyObj.AddTrack(TObj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }

        [ActionName("UpdateModuleDuration")]
        [HttpPost]
        public HttpResponseMessage UpdateModuleDuration(Model.Module ModuleObj)
        {
            try
            {
                FacultyBL FacultyObj = new FacultyBL();
                int result = FacultyObj.UpdateModuleDuration(ModuleObj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }

        [ActionName("UpdateModuleName")]
        [HttpPost]
        public HttpResponseMessage UpdateModuleName(Model.Module ModuleObj)
        {
            try
            {
                FacultyBL FacultyObj = new FacultyBL();
                int result = FacultyObj.UpdateModuleName(ModuleObj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }

        [ActionName("UpdateModuleStatus")]
        [HttpPost]
        public HttpResponseMessage UpdateModuleStatus(Model.Module ModuleObj)
        {
            try
            {
                FacultyBL FacultyObj = new FacultyBL();
                int result = FacultyObj.UpdateModuleStatus(ModuleObj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }

        [ActionName("UpdateTrackDescription")]
        [HttpPost]
        public HttpResponseMessage UpdateTrackDescription(Model.Track TrackObj)
        {
            try
            {
                FacultyBL FacultyObj = new FacultyBL();
                int result = FacultyObj.UpdateTrackDescription(TrackObj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }


        [ActionName("UpdateTrackDuration")]
        [HttpPost]
        public HttpResponseMessage UpdateTrackDuration(Model.Track TrackObj)
        {
            try
            {
                FacultyBL FacultyObj = new FacultyBL();
                int result = FacultyObj.UpdateTrackDuration(TrackObj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }

        [ActionName("UpdateTrackName")]
        [HttpPost]
        public HttpResponseMessage UpdateTrackName(Model.Track TrackObj)
        {
            try
            {
                FacultyBL FacultyObj = new FacultyBL();
                int result = FacultyObj.UpdateTrackName(TrackObj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }

        [ActionName("UpdateTrackStatus")]
        [HttpPost]
        public HttpResponseMessage UpdateTrackStatus(Model.Track TrackObj)
        {
            try
            {
                FacultyBL FacultyObj = new FacultyBL();
                int result = FacultyObj.UpdateTrackStatus(TrackObj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }
    }
}
