using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PairingMatrix.ServiceClient.Interfaces;
using PairingMatrix.ServiceClient.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PairingMatrix.Web.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ICRUD<Team> _teamService;

        public TeamsController(ICRUD<Team> teamService)
        {
            _teamService = teamService;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var data = await _teamService.GetPagedAsync(0, 100);
            return View(data);
        }
    }
}
