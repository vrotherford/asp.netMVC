using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Core;
using Interfaces;


namespace testWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ITournamentRepository _tournamentRepository;
        private IRoundRepository _roundRepository;

        public HomeController(ITournamentRepository tournamentRepository, IRoundRepository roundRepository)
        {
            _tournamentRepository = tournamentRepository;
            _roundRepository = roundRepository;
        }
        public ActionResult Index()
        {
            IEnumerable<Tournament> tournaments = _tournamentRepository.GetTournamentsList();
            return View(tournaments);
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
    }
}