using System.Collections.Generic;
using System.Threading.Tasks;
using ChallengeComplain.Data;
using ChallengeComplain.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChallengeComplain.Controllers
{
    [Route("locales")]
    public class LocaleController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Locale>>> Get(
            [FromServices] DataContext context,
            [FromBody] Locale model
        )
        {
            var locales = await context.Locales.AsNoTracking().ToListAsync();
            return locales;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Locale>> Post(
            [FromServices] DataContext context,
            [FromBody] Locale model
        )
        {
            if (ModelState.IsValid)
            {
                context.Locales.Add(model);
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