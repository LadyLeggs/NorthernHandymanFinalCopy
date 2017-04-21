using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet;
using Facebook;
//using ASPSnippets.FaceBookAPI;
using System.Web.Script.Serialization;



namespace FinalStraw.Controllers
{
    [RequireHttps]
    public class ImagesController : Controller
    {
        FacebookClient _faceBookConnection = new FacebookClient();
        public ActionResult FacebookAutoAdd()
        {
            
            _faceBookConnection.AppId = "208019169694498";
            _faceBookConnection.AppSecret = "223f0001eaa9dd5c20453c3d2d0da9ba";
            string code = Request.QueryString["code"];
            if (!string.IsNullOrEmpty(code))
            {
                //string data = _faceBookConnection.TryParseOAuthCallbackUrl()
            }
            // string param = this.Request.QueryString[]



            
            return View();
        }
        protected void Fetch(object sender, EventArgs e)
        {

            

            //FaceBookConnect.Authorize("user_photos", Request.Url.AbsoluteUri.Split('?')[0]);
        }

    }
}