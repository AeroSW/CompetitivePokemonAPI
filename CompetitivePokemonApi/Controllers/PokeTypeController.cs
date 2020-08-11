using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Logic.Enums;
using Logic.Repositories.PokeTypeRepository;

namespace PokemonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokeTypeController : ControllerBase
    {
        readonly private IPokeTypeRepository PokeTypeRepository;
        public PokeTypeController(IPokeTypeRepository pokeTypeRepository)
        {
            PokeTypeRepository = pokeTypeRepository;
        }
        [HttpGet]
        [Route("/[action]")]
        public IActionResult GetEffectiveness(PokeType attack)
        {
            try
            {
                var result = PokeTypeRepository.GetEffectiveness(attack);
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("/[action]")]
        public IActionResult GetWeaknesses(PokeType primary, PokeType? secondary)
        {
            try
            {
                var result = PokeTypeRepository.GetWeaknesses(primary, secondary);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("/[action]")]
        public IActionResult GetModifier(PokeType attack, PokeType primary, PokeType? secondary)
        {
            try
            {
                var result = PokeTypeRepository.GetModifier(attack, primary, secondary);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
