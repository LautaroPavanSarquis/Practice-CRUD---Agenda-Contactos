using System.ComponentModel.DataAnnotations;

namespace Practice_Crud___Agenda_Contactos.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }


    }
}
