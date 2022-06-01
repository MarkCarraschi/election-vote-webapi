using System.ComponentModel.DataAnnotations;

namespace ChallengeComplain.Model
{
    public class Locale
    {

        [Key]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        [Required(ErrorMessage = "This field it's required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field it's required")]
        [MaxLength(255, ErrorMessage = "This field need to contain strings between 3 to 255")]
        [MinLength(3, ErrorMessage = "This field need to contain strings between 3 to 255")]
        public string City { get; set; }

        [Required(ErrorMessage = "This field it's required")]
        [MaxLength(255, ErrorMessage = "This field need to contain strings between 3 to 255")]
        [MinLength(3, ErrorMessage = "This field need to contain strings between 3 to 255")]
        public string State { get; set; }
    }
}