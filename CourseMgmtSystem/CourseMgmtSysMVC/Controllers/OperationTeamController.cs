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
    public class OperationTeamController : Controller
    {
        string Baseurl = "http://localhost:55709/";
        // GET: Faculty
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetBatchDetails()
        {
            List<Models.Batch> batchLst = new List<Models.Batch>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/OperationTeam/GetBatchDetails");
                if (Res.IsSuccessStatusCode)
                {
                    var res = Res.Content.ReadAsStringAsync().Result;
                    batchLst = JsonConvert.DeserializeObject<List<Models.Batch>>(res);

                }
                return View(batchLst);
            }
        }


        public ActionResult AddNewBatch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewBatch(Models.Batch batchObj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55709/api/OperationTeam/AddNewBatch");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Models.Batch>("AddNewBatch", batchObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("AddNewBatch");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(batchObj);
        }

        public ActionResult UpdateBatchStatus()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateBatchStatus(Models.Batch batchObj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55709/api/OperationTeam/UpdateBatchStatus");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Models.Batch>("UpdateBatchStatus", batchObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("UpdateBatchStatus");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(batchObj);
        }






    }
}