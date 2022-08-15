using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPIRawabi.Models;

namespace RawabiAPI.Controllers
{
    [Route("[controller]")]
    public class RawabiController : Controller
    {
        private readonly ILogger<RawabiController> _logger;

        public RawabiController(ILogger<RawabiController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpPost]
        public ActionResult CreateTransaction(Transaction tran)
        {
            DataAccess dat =  new DataAccess();
            bool res = dat.CreateTransaction(tran);
            if(res)
                return Ok();
            else
                return BadRequest();
        }
    }
}