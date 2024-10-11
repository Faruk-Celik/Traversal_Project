using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserSignInViewModel
    {

   
        [Required(ErrorMessage = "Lütfen soyadını giriniz!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz!")]
        public string Usurname { get; set; }


    }
}
