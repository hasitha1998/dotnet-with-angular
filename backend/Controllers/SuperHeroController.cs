using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using backend.Data;

namespace backend.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {  
        private readonly DataContext _context;

        public SuperHeroController(DataContext context){
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes(){
            return new List<SuperHero>{
                new SuperHero
                {
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"

                }
            };
        }
    }
}
