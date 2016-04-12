using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace JiffyOffLine.Controllers
{
    public class JIffyController : Controller
    {
        //
        // GET: /JIffy/

        public ActionResult Index()
        {
            return View();

            //added this comment for GitHub
        }
    
        [HttpGet]
        public ActionResult GetProjectActivities()
        {
            GetProjectList();
            GetActivityList(); 
            
            return View("JIffy");
        }
        private void GetActivityList()
        {
            StreamReader streamReader = null;
            try
            {
                string serviceUri = "http://localhost/JiffyService/JiffyService/GetActivityList";
                List<ActivityDO> actvities = null;
                string responseData = string.Empty;
                HttpWebRequest request = HttpWebRequest.Create(serviceUri) as HttpWebRequest;
                var httpResponse = (HttpWebResponse)request.GetResponse();
                streamReader = new StreamReader(httpResponse.GetResponseStream());
                responseData = streamReader.ReadToEnd();
                actvities = JsonConvert.DeserializeObject<List<ActivityDO>>(responseData);
                List<SelectListItem> ddActivities = new List<SelectListItem>();
                foreach (ActivityDO item in actvities)
                {
                    ddActivities.Add(new SelectListItem { Text = item.ACTIVITY_DESC, Value = item.ACTIVITY_ID.ToString() });
                }
                ViewBag.ddActivities = ddActivities;
            }
            catch (Exception exp)
            {

                throw;
            }
        }

        private void GetProjectList()
        {
            StreamReader streamReader = null;
            try
            {
                List<ProjectDetailsDO> projDetails = null;
                string serviceURI = "http://localhost/JiffyService/JiffyService/GetProjectList";
                string data = string.Empty;
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(serviceURI);
                var httpResponse = (HttpWebResponse)request.GetResponse();
                streamReader = new StreamReader(httpResponse.GetResponseStream());
                data = streamReader.ReadToEnd();
                projDetails = JsonConvert.DeserializeObject<List<ProjectDetailsDO>>(data); //JSON.NET objects
                List<SelectListItem> ddProjects = new List<SelectListItem>();
                foreach (ProjectDetailsDO item in projDetails)
                {
                    ddProjects.Add(new SelectListItem { Text = item.PROJECT_DESC, Value = item.PROJECT_ID.ToString() });

                }
                ViewBag.ddProjects = ddProjects;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
