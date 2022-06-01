using System.ComponentModel.DataAnnotations;

namespace ChallengeComplain.Model
{
    public class Company
    {

        [Key]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        [Required(ErrorMessage = "This field it's required")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "This field it's required")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "This field it's required")]
        [MaxLength(50, ErrorMessage = "This field need to contain strings between 3 to 50")]
        [MinLength(3, ErrorMessage = "This field need to contain strings between 3 to 50")]
        public string Name { get; set; }

    }
}