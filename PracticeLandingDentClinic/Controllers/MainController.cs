using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace PracticeLandingDentClinic.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendFeedback(string name, string email, string subject, string message)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("domo.ddr@gmail.com", "QazPlm3110weroiu"),
                    EnableSsl = true
                };

                client.Send("domo.ddr@gmail.com", email, subject, message);
            }
            catch (Exception ex)
            {
                string _ex = ex.Message;
            }

            return View("Index");
        }
    }
}