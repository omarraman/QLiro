using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QLiro.Interfaces;
using QLiro.Logic;

namespace QLiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class SimulatorController : ControllerBase
    {
        private readonly ISimulationGenerator _simulationGenerator;

        public SimulatorController(ISimulationGenerator simulationGenerator)
        {
            _simulationGenerator = simulationGenerator;
        }
        [HttpGet("{numberOfGames}/{doorSwitched}")]
        public decimal Get(int numberOfGames,bool doorSwitched)
        {
            var result = _simulationGenerator.GetPercentageCorrectChoice(numberOfGames,doorSwitched);
            return result;
        }

    }
}
