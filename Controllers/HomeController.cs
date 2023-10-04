using bloodb.Entity;
using Bloodbankapp.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Bloodbankapp.Controllers
{
    public class HomeController : Controller
    {
        LoginContext context=new LoginContext();
        Bloodb.Entity.Entitycontext entity = new Bloodb.Entity.Entitycontext();
        bloodb.Models.Donate donate = new bloodb.Models.Donate();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        { 
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Look()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(Look look)
        {
                string find = look.Blood;
                var a = (from l in entity.Donates where l.Bloodgroup == find select l).ToList();
                return View("Search", a);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            else
            {
                string name = register.BankName;
                string email = register.Email;
                string mobile = register.Mobile;
                string address = register.Address;
                string city = register.City;

                Register regis = new Register { BankName = name, Email = email, Mobile = mobile, Address = address, City = city };
                context.Registers.Add(regis);
                context.SaveChanges();
                return RedirectToAction("Index","Home");
            }
        }
        public ActionResult Donarconfirm()
        {
            return View();
        }
        public ActionResult Donate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Donate(bloodb.Models.Donate donate)
        {
            if (!ModelState.IsValid)
            {
                return View(donate);
            }
            else
            {
                Donate donate1 = new bloodb.Entity.Donate();

                donate1.Name = donate.Name;
                donate1.Dob = donate.Dob;
                donate1.Mobile = donate.Mobile;
                donate1.Address = donate.Address;
                donate1.State = donate.State;
                donate1.Gender = donate.Gender;
                donate1.Bloodgroup = donate.Bloodgroup;
                donate1.Lastdate = donate.Lastdate;

                entity.Donates.Add(donate1);
                 entity.SaveChanges();

                return RedirectToAction("Donarconfirm");
            }
        }
        public ActionResult Bank()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Bloodavail(Bank bank)
        {
            string find = bank.City;
            var a = (from l in context.Registers where l.City == find select l).ToList();
            return View("Bloodavail", a);
        }
    }
}
