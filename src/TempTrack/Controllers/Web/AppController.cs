using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempTrack.Models;
using TempTrack.Services;
using TempTrack.ViewModels;

namespace TempTrack.Controllers.Web
{
    public class AppController : Controller //controllers must be pub and inherit from Controller
    {
        private IRecordRepository _repo;

        public AppController(IRecordRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var data = _repo.GetAllRecords();

            return View(data); 
        }

        public IActionResult Settings()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Contact(ContactViewModel model)
        //{
        //    if (model.Email.ToLower().Contains("aol.com"))
        //    {
        //        ModelState.AddModelError("", "We don't support AOL address");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        _mailService.SendMail(_config["MailSettings:ToAddress"], model.Email, "From site", model.Message);
        //        ModelState.Clear();
        //        ViewBag.UserMessage = "Message Sent";

        //    }
        //    return View();
        //}

        //public IActionResult About()
        //{
        //    return View();
        //}
    }
}
