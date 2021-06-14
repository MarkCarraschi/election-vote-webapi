using System.ComponentModel.DataAnnotations;

namespace ChallengeComplain.Model
{
    public class Locale
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field it's required")]
        public string City { get; set; }

        [Required(ErrorMessage = "This field it's required")]
        public string State { get; set; }
    }
}