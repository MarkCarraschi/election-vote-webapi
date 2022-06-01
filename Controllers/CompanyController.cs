using Microsoft.AspNetCore.Mvc;
using ChallengeComplain.Model;
using System.Threading.Tasks;
using System.Collections.Generic;
using ChallengeComplain.Data;
using Microsoft.EntityFrameworkCore;

namespace ChallengeComplain.Controllers
{
    [Route("companies")]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Company>>> Get([FromServices] DataContext context)
        {
            //var companies = await context.Companies.Include(x => x.Cnpj).AsNoTracking().ToListAsync();
            var companies = await context.Companies.AsNoTracking().ToListAsync();
            return companies;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Company>> Post(
            [FromServices] DataContext context,
            [FromBody] Company model
        )
        {
            if (ModelState.IsValid)
            {
                context.Companies.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}