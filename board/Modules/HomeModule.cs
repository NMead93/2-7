using Nancy;
using System.Collections.Generic;
using board.Objects;

namespace board
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/form"] = _ =>
            {
                return View["form.cshtml"];
            };

            Post["/applications"] = _ =>
            {
                Contact newContact = new Contact(Request.Form["name"], Request.Form["email"], Request.Form["phone"]);
                Job newJob = new Job(Request.Form["title"], Request.Form["description"], newContact);
                newJob.Save();
                return View["board.cshtml", Job.GetApplications()];
            };
        }
    }
}