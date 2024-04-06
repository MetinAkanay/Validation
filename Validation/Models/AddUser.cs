using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
    public class AddUser
    {
        [Display(Name = "T.C. Kimlik No")]
        [StringLength(11, ErrorMessage = "T.C. Kimlik No 11 haneli olmalıdır.")]
        [RegularExpression("^[1-9]{1}[0-9]{9}[02468]{1}$", ErrorMessage = "Geçerli bir T.C. Kimlik No giriniz.")]
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
