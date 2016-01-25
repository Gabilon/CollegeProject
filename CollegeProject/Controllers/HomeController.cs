using System;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace CollegeProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string url = @"http://royalfortunews.azurewebsites.net/api/WN?token=xr9C2x3lhfChA6c01CAh98p85cd";
            string strLine = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "application/json";
            request.ContentType = "application/json; charset=utf-8";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    StreamReader st = new StreamReader(response.GetResponseStream());
                    strLine = st.ReadToEnd();
                }
            }

            ViewData["Test"] = strLine;
                return View();
        }
        //Como podemos alimentar en dos direcciones
        //


    }
}