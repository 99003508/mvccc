using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CourseMgmtSysMVC.Controllers
{
    public class FacultyController : Controller
    {

        string Baseurl = "http://localhost:55709/";
        // GET: Faculty
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Track()
        {
            return View();
        }
        public ActionResult Batch()
        {
            return View();
        }
        public ActionResult Module()
        {
            return View();
        }
        public ActionResult Updatetrack()
        {
            return View();
        }

        public async Task<ActionResult> GetTrackDetails()
        {
            List<Models.Track> TrackInfo = new List<Models.Track>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Faculty/GetTrackDetails");
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    TrackInfo = JsonConvert.DeserializeObject<List<Models.Track>>(EmpResponse);

                }
                return View(TrackInfo);
            }
        }

        public async Task<ActionResult> GetBatchDetails()
        {
            List<Models.Batch> BatchInfo = new List<Models.Batch>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Resl = await client.GetAsync("api/Faculty/GetBatchDetails");
                if (Resl.IsSuccessStatusCode)
                {
                    var EmpResponse = Resl.Content.ReadAsStringAsync().Result;
                    BatchInfo = JsonConvert.DeserializeObject<List<Models.Batch>>(EmpResponse);

                }
                return View(BatchInfo);
            }
        }
        
       
        public ActionResult AddNewTrack()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewTrack(Models.Track trackObj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55709/api/Faculty/AddNewTrack");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Models.Track>("AddNewTrack", trackObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("AddNewTrack");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(trackObj);
        }

            

        public ActionResult UpdateModuleDuration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateModuleDuration(Models.Module moduleObj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55709/api/Faculty/UpdateModuleDuration");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Models.Module>("UpdateModuleDuration", moduleObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("UpdateModuleDuration");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(moduleObj);
        }





        public ActionResult UpdateModuleName()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateModuleName(Models.Module moduleObj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55709/api/Faculty/UpdateModuleName");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Models.Module>("UpdateModuleDuration", moduleObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("UpdateModuleName");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(moduleObj);
        }







        public ActionResult UpdateModuleStatus()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateModuleStatus(Models.Module moduleObj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55709/api/Faculty/UpdateModuleStatus");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Models.Module>("UpdateModuleStatus", moduleObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("UpdateModuleStatus");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(moduleObj);
        }
        

        public ActionResult UpdateTrackDescription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateTrackDescription(Models.Track moduleObj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55709/api/Faculty/UpdateTrackDescription");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Models.Track>("UpdateTrackDescription", moduleObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("UpdateTrackDescription");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(moduleObj);
        }

        

        public ActionResult UpdateTrackDuration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateTrackDuration(Models.Track moduleObj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55709/api/Faculty/UpdateTrackDuration");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Models.Track>("UpdateTrackDuration", moduleObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("UpdateTrackDuration");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(moduleObj);
        }
        

        public ActionResult UpdateTrackName()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateTrackName(Models.Track moduleObj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55709/api/Faculty/UpdateTrackName");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Models.Track>("UpdateTrackName", moduleObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("UpdateTrackName");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(moduleObj);
        }


        public ActionResult UpdateTrackStatus()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateTrackStatus(Models.Track moduleObj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55709/api/Faculty/UpdateTrackStatus");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Models.Track>("UpdateTrackStatus", moduleObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("UpdateTrackStatus");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(moduleObj);
        }





    }
}