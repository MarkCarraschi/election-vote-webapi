using Microsoft.AspNetCore.Mvc;
using ChallengeComplain.Model;
using System.Threading.Tasks;
using System.Collections.Generic;
using ChallengeComplain.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ChallengeComplain.Controllers
{
    [Route("complaints")]
    public class ComplainController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Complain>>> Get([FromServices] DataContext context)
        {
            var complaints = await context.Complaints.Include(x => x.Locale).Include(y => y.Company).AsNoTracking().ToListAsync();
            return complaints;
        }

        [HttpGet]
        [Route("complaints/{id:int}")]
        public async Task<ActionResult<List<Complain>>> GetQuantitieComplaintsFromCity([FromServices] DataContext context, int id)
        {
            var complaints = await context
            .Complaints
            .Include(x => x.Locale)
            .Include(y => y.Company)
            .AsNoTracking()
            .Where(x => x.LocaleId == id)
            .ToListAsync();

            return complaints;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Complain>> Post(
            [FromServices] DataContext context,
            [FromBody] Complain model
        )
        {
            if (ModelState.IsValid)
            {
                context.Complaints.Add(model);
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