using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
    public class AddUser
    {
        public string IdentityNo { get; set; }

        [StringLength(20,MinimumLength = 3, ErrorMessage ="Ad alanı belirlenen kurallar dahilinde değil.")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        public string Name { get; set; }

        [StringLength(60,MinimumLength = 2, ErrorMessage ="Soy ad alanı belirlenen kurallar dahilinde değil.")]
        [Required(ErrorMessage = "Soy ad alanı boş geçilemez.")]
        public string LastName { get; set; }
        public int Email { get; set; }
        public int Age { get; set; }

    }
}
