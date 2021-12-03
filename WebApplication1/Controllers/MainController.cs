using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace WebTinTuc.Controllers
{
    public class MainController : Controller
    {
        private readonly IConfiguration configuration ;
        public MainController(IConfiguration config)
        {
            this.configuration = config;
        }
        
        public IActionResult ListPost()
        {
            string conn = configuration.GetConnectionString("AppCon");
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand com = new SqlCommand("select count(*) from post", con);
            var count = (int)com.ExecuteScalar();
            var ss = "udhfuhduf";
            ViewData["tt"] = ss;
            Console.WriteLine(ViewData["tt"]+"hihihihihihhi");
            con.Close();
               return View();
            
            
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DangNhap()
        {

            return View();
        }
        public ActionResult LienHe()
        {
            return View();
        }

        // GET: MainController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MainController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MainController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MainController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MainController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MainController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MainController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
