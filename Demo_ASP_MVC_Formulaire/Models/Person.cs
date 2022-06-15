using System.ComponentModel.DataAnnotations;

namespace Demo_ASP_MVC_Formulaire.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }

    public class PersonForm
    {
        [Required(ErrorMessage = "Le prénom est obligatoire !")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le prénom est invalid")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire !")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le nom est invalid")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Le email est obligatoire !")]
        [EmailAddress(ErrorMessage = "Le format de l'email est incorrect :o")]
        public string Email { get; set; }
    }

}
