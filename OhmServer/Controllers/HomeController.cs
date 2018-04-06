using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OhmServer.Models;

namespace OhmServer.Controllers
{
    public class HomeController : Controller
    {
        private IOhmValueCalculator _ohm;
        private List<ResistorTable> _rt;

        public HomeController(IOhmValueCalculator ohm)
        {
            _ohm = ohm;
            _rt = _ohm.CreateTable();
        }

        // GET api/home
        [Route("api/home/{colorA}/{colorB}/{multiplier}/{percent}")]
        [HttpGet]
        public string Get(string colorA, string colorB, string multiplier, string percent)
        {
            return _ohm.CalculateOhmValue(
                colorA, 
                colorB, 
                multiplier, 
                percent,
                _rt).ToString();
        }
    }
}
