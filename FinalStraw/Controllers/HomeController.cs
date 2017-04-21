﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mail;
using System.Web.Mvc;
using TheNorthernHandyman.Models;

namespace FinalStraw.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(ContactEmailModels e)
        {
            string ValidationMessage = String.Empty;

            ViewBag.Name = String.Empty;
            ViewBag.Email = String.Empty;
            ViewBag.Phone = String.Empty;
            ViewBag.Message = String.Empty;


            if (!String.IsNullOrEmpty(e.Name) && !String.IsNullOrEmpty(e.Message) && !String.IsNullOrEmpty(e.Phone) && !String.IsNullOrEmpty(e.Email))
            {
                var emailmessage = new System.Web.Mail.MailMessage()
                {
                    Subject = e.Name,
                    Body = "From: " + e.Name + "\n Phone Number: " + e.Phone + "\n Job Description: " + e.Message + "\n Email: " + e.Email,
                    From = "thenorthernhandyman@thenorthernhandyman.org",
                    To = "itismejody@gmail.com",
                    BodyFormat = MailFormat.Text,
                    Priority = System.Web.Mail.MailPriority.High
                };

                System.Web.Mail.SmtpMail.SmtpServer = "relay-hosting.secureserver.net";
                SmtpMail.Send(emailmessage);
                MessageBox("Email sent successfully!");
                //return RedirectToAction("Index", "Home", null);

            }

            return View(e);
        }
        public EmptyResult MessageBox(string s)
        {
            Response.Write("<script type=\"text/javascript\">alert('" + s + "');</script>");
            return null;
        }

        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Photos()
        {
            return View();
        }
        public ActionResult Videos()
        {
            return View();
        }
        public ActionResult Brush_Remvoal_Hogging()
        {
            return View();
        }
        public ActionResult Limb_Removal()
        {
            return View();
        }
        public ActionResult Mowing()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Stump_Grinding()
        {
            return View();
        }
        public ActionResult Tree_Removal()
        {
            return View();
        }
        public ActionResult Trimming()
        {
            return View();
        }
        public ActionResult AllPhotos()
        {
            return View();
        }
        public ActionResult AllPhotosPg2()
        {
            return View();
        }
        public ActionResult AllPhotosPg3()
        {
            return View();
        }
        public ActionResult AllPhotosPg4()
        {
            return View();
        }
        public ActionResult AllPhotosPg5()
        {
            return View();
        }
        public ActionResult AllPhotosPg6()
        {
            return View();
        }
        public ActionResult AllPhotosPg7()
        {
            return View();
        }
        public ActionResult AllPhotosPg8()
        {
            return View();
        }
        public ActionResult Portfolio_Modal1()
        {
            return View();
        }
      
    }
}