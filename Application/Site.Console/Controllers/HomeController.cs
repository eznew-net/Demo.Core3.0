using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZNEW.Web.Security.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Site.Console.Controllers
{
    [AuthorizationGroup(Name = "ϵͳ���")]
    public class HomeController : WebBaseController
    {
        // GET: /<controller>/
        [AuthorizationAction(Name = "��ҳ")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
