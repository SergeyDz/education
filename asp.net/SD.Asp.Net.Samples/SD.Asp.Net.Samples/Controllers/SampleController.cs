using SD.Asp.Net.Samples.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    }
}
