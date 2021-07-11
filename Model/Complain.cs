
using System.ComponentModel.DataAnnotations;

namespace ChallengeComplain.Model
{
    public class Complain
    {

        [Key]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        [Required(ErrorMessage = "This field it's required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field it's required")]
        [MaxLength(30, ErrorMessage = "This field need to contain strings between 3 to 30")]
        [MinLength(3, ErrorMessage = "This field need to contain strings between 3 to 30")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field it's required")]
        [MaxLength(255, ErrorMessage = "This field need to contain strings between 3 to 255")]
        [MinLength(3, ErrorMessage = "This field need to contain strings between 3 to 255")]
        public string Description { get; set; }


        public int LocaleId { get; set; }
        public Locale Locale { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}