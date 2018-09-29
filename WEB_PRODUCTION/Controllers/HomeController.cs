using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_PRODUCTION.Models;

namespace WEB_PRODUCTION.Controllers
{
    public class HomeController : Controller
    {
        private My_DBEntities mdb = new My_DBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult More(string departmentname)
        {
            var department = departmentname;

            //    var result = mdb.doctor.Include("Name")
            //.Single(g => g.Department == department);

            var data = mdb.Doctors.Where(g => g.Department == department);

            return View(data.ToList());

            //return View(mdb.Doctors.ToList());

        }
        public ActionResult Detail(string name, string department, string phone, decimal price, string address, float latitude, float longitude)
        {
            Doctor d = new Doctor();
            //var doctorname = Name;
            d.Name = name;
            d.Department = department;
            d.Phone = phone;
            d.Price = price;
            d.Address = address;
            d.Latitude = latitude;
            d.Longitude = longitude;

            return View(d);
        }

        public ActionResult Booking(string doctorname, string department, string doctoraddr)
        {
            Booking b = new Booking();
            if (User.Identity.IsAuthenticated)
            {
                b.DoctorName = doctorname;
                b.Department = department;
                b.DoctorAddress = doctoraddr;
            }
            else
            {
                Response.Redirect("../Account/login");
            }

            return View(b);
        }

        [HttpPost]
        public ActionResult Makeappointment()
        {
            Booking b = new Booking();
            b.UserName = User.Identity.Name;
            b.DoctorName = Request["docname"].ToString();
            b.Department = Request["department"].ToString();
            b.CustomerName = Request["customername"].ToString();
            b.Age = Convert.ToInt32(Request["age"].ToString());
            b.Address = Request["address"].ToString();
            b.PhoneNumber = Request["phno"].ToString();
            b.BookingDate = Request.Form["Select Day"].ToString();
            b.Bookingtime = Request.Form["Select Desire Time"].ToString();
            b.DoctorAddress = Request["docaddr"].ToString();
            b.Description = Request["desc"].ToString();

            mdb.Bookings.Add(b);
            mdb.SaveChanges();
            return View();
        }

        public ActionResult Token()
        {
            //var data = mdb.Bookings.Where(g => g.UserName == User.Identity.Name).Last();
            var data = mdb.Bookings.Where(x=> x.UserName == User.Identity.Name)
                             .OrderByDescending(x => x.ID)
                             .Take(1)
                             .ToList()
                             .FirstOrDefault();
            Booking b = new Booking();
            b.ID = data.ID;
            b.DoctorName = data.DoctorName;
            b.Department = data.Department;
            b.DoctorAddress = data.DoctorAddress;
            b.CustomerName = data.CustomerName;
            b.BookingDate = data.BookingDate;
            b.Bookingtime = data.Bookingtime;
            return View(b);
        }

        public ActionResult Finish()
        {
            return View("Index");
        }

    }
}