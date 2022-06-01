using System.Threading.Tasks;
using ChallengeComplain.Data;
using Microsoft.AspNetCore.Mvc;

using ChallengeComplain.Model;

namespace ChallengeComplain.Controllers
{

    [Route("v1")]
    public class PopulateTestController : Controller
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<dynamic>> Get([FromServices] DataContext context)
        {

            var localSaoPaulo = new Locale { Id = 1, City = "Diadema", State = "São Paulo" };
            var localRioDeJaneiro = new Locale { Id = 2, City = "Rio de Janeiro", State = "Rio de Janeiro" };
            
            var companyOne = new Company { Id = 1, Cnpj = "18.365.758/0001-02", Name = "Company #1" };
            var companyTwo = new Company { Id = 2, Cnpj = "18.500.758/0001-02", Name = "Company #2" };
            
            var reclaimOne = new Complain{ Id = 1 , Company=companyOne, Locale = localSaoPaulo, Title = "Reclaim #01", Description = "Description #1"};
            var reclaimTwo = new Complain{ Id = 2 , Company=companyOne, Locale = localRioDeJaneiro, Title = "Reclaim #02", Description = "Description #2"};
            var reclaimThree = new Complain{ Id = 3 , Company=companyOne, Locale = localSaoPaulo, Title = "Reclaim #03", Description = "Description #3"};
            var reclaimFour = new Complain{ Id = 4 , Company=companyOne, Locale = localSaoPaulo, Title = "Reclaim #04", Description = "Description #4"};

            context.Locales.Add(localSaoPaulo);
            context.Locales.Add(localRioDeJaneiro);
            
            context.Companies.Add(companyOne);
            context.Companies.Add(companyTwo);
            
            context.Complaints.Add(reclaimOne);
            context.Complaints.Add(reclaimTwo);
            context.Complaints.Add(reclaimThree);
            context.Complaints.Add(reclaimFour);

            await context.SaveChangesAsync();        

            return Ok(new
            {
                message = "Config Data"
            });
        }


    }
}
