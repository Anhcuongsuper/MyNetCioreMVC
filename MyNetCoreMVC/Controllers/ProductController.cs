using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyNetCoreMVC
{
    public class ProductController : Controller
    {

        //[Route("NgoLyCuong/Index/{id:int}")]
        //public IActionResul IndexActionResul(int id)
        //{
        //    return new JsonResult(new MyCustomer()
        //    {
        //        Name = id + ""
        //    });
        //}

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetList()
        {
            return View();
        }
        public IActionResult Create(string name, string price)
        {
            ViewData["name"] = name;
            ViewData["price"] = name;

            return View();
        }
        public IActionResult Update()
        {
            return View();

        }
        public IActionResult Delete(int id)
        {


            return new JsonResult(new Product()
            {

                _id = id
            });
        }
    }
}

