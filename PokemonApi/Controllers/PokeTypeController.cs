using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Logic.Enums;

namespace PokemonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokeTypeController : ControllerBase
    {
        readonly private IPokeTypeRepository PokeTypeRepository
        [HttpGet]
        public IActionResult GetEffectiveness(PokeType attack, PokeType primary, PokeType secondary)
        {

        } 
    }
}
