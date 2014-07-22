using SD.Asp.Net.Samples.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SD.Asp.Net.Samples.Controllers
{
    public class SampleController : AsyncController
    {
        private static readonly string _testFilePath;

        public static string GetBasePath()
        {
            if (System.Web.HttpContext.Current == null) return AppDomain.CurrentDomain.BaseDirectory;
            else return AppDomain.CurrentDomain.BaseDirectory;
        } 

        static SampleController()
        {
            _testFilePath = GetBasePath() + @"/Content/Uells_Voyna_mirov.fb2";  
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReadLine()
        {
            FileContainer file = FileContainer.Create(_testFilePath);
            file.ReadLine();
            return View("ReadList", file);
        }

        public async Task<ActionResult> AsyncReadLine()
        {
            FileContainer file = FileContainer.Create(_testFilePath);
            await file.ReadLineAsync();
            return View("ReadList", file);
        }

        public ActionResult Read()
        {
            FileContainer file = FileContainer.Create(_testFilePath);
            file.Read();
            return View("ReadList", file);
        }

        public async Task<ActionResult> AsyncRead()
        {
            FileContainer file = FileContainer.Create(_testFilePath);
            await file.ReadAsync();
            return View("ReadList", file);
        }

        public ActionResult ReadFromHttp()
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create("http://localhost/SD.Asp.Net.Samples/api/sampleapi");
            req.ContentType = "text/plain";
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            ViewBag.Text =  sr.ReadToEnd().Trim();

            return View("Index");
        }

        public async Task<ActionResult> AsyncReadFromHttp()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("http://localhost/SD.Asp.Net.Samples/api/sampleapi");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsAsync<IEnumerable<string>>();
                ViewBag.Text = String.Join(String.Empty, content.ToArray());
            }
            return View("Index");
        }

    }
}
