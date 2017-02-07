using Nancy;
using ToDoList.objects;
using System.Collections.Generic;

namespace ToDoList
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/form"] = _ =>
            {
                return View["form.cshtml"];
            };

            Post["/form"] = _ =>
            {
                Task newTask = new Task(Request.Form["task"]);
                newTask.Save();
                return View["/form"];
            };

            Get["/tasks"] = _ =>
            {
                return View["home.cshtml", Task.GetAll()];
            };
        }
    }
}