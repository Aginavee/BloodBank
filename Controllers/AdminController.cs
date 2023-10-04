using System;
using System.Collections.Generic;
using System.Linq;
using Bloodbankapp.Models;
using System.Web;
using System.Web.Mvc;

namespace Bloodbankapp.Controllers
{
    public class AdminController : Controller
    {
        Admin admin = new Admin();
        LoginContext login = new LoginContext();
        public ActionResult Admin(Admin admin)
        {
            string email = admin.Email;
            string pass = admin.Password;
            string a = "navee@gmail.com";
            string b = "123";
            if (email == a)
            {
                if (pass == b)
                {
                    return RedirectToAction("Adminhome", "Admin");
                }
                else
                {
                    return View(admin);
                }

            }
            return View(admin);
        }
        public ActionResult Adminhome()
        {
            return View();
        }
        [Route("Register")]
        public ActionResult Userdetails()
        {
            return View(login.Registers.ToList());
        }
        public ActionResult Details(string id)
        {
            int uid = Convert.ToInt32(id);
            var emp = login.Registers.Find(uid);
            return View(emp);
        }
        public ActionResult Edit(string id)
        {
            int uid = Convert.ToInt32(id);
            var emp = login.Registers.Find(uid);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Register regis)
        {
            var data = login.Registers.Find(regis.Id);
            if (data != null)
            {
                data.BankName = regis.BankName;
                data.Email = regis.Email;
                data.Mobile = regis.Mobile;
                data.Address = regis.Address;
                data.City = regis.City;
            }
            login.SaveChanges();
            return View();
        }
        public ActionResult Delete(Register regis)
        {
                var emp = login.Registers.Find(regis.Id);
                if (emp != null)
                {
                    login.Registers.Remove(emp);
                    login.SaveChanges();
                }   
                return View(emp);
            }
           
        }
    }
