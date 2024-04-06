using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
    public class AddUser
    {
        [Display(Name = "T.C. Kimlik No")]
        
        public string IdentityNo { get; set; }

        [Display(Name = "İsim")]
        [StringLength(20,MinimumLength = 3, ErrorMessage ="Ad alanı belirlenen kurallar dahilinde değil.")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        public string Name { get; set; }

        [Display(Name = "Soyisim")]
        [StringLength(60,MinimumLength = 2, ErrorMessage ="Soy ad alanı belirlenen kurallar dahilinde değil.")]
        [Required(ErrorMessage = "Soy ad alanı boş geçilemez.")]
        public string LastName { get; set; }

        [Display(Name = "E-posta")]
        [Required(ErrorMessage = "E-posta alanı boş geçilemez.")]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public int Email { get; set; }

        [Display(Name = "Yaş")]
        [Required(ErrorMessage = "Yaş alanı boş geçilemez.")]
        [Range(18, 65, ErrorMessage = "Yaş aralığı 18-65 olmalıdır.")]
        public int Age { get; set; }

    }
}
