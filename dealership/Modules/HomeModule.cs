using Nancy;
using System.Collections.Generic;
using dealership.Objects;

namespace dealership
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/form"] = _ =>
            {
                return View["form.cshtml"];
            };

            Post["/list"] = _ =>
            {
                Car newCar = new Car(Request.Form["makemodel"], Request.Form["cost"], Request.Form["miles"]);
                newCar.Save();
                return View["list.cshtml", Car.GetCars()];
            };


        }
    }
}
