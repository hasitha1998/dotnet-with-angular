﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace backend.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
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