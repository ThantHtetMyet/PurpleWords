using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PW.Modules.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PW.Modules.Course.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ParentController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ParentController> _logger;

        public ParentController(ILogger<ParentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Parent> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Parent
            {
                FName = "Cho Cho",
                LName = "Maw"
            })
            .ToArray();
        }
    }
}
