using System.ComponentModel.DataAnnotations;

namespace ChallengeComplain.Model
{
    public class Company
    {

        [Key]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "This field it's required")]
        [MaxLength(50, ErrorMessage = "This field need to contain strings between 3 to 50")]
        [MinLength(3, ErrorMessage = "This field need to contain strings between 3 to 50")]
        public string Name { get; set; }

        public Locale Locale { get; set; }
    }
}