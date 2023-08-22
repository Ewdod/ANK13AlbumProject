using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ANK13AlbumProject.Entities
{
    public class Admin
    {
        [Key]
        public string UserName { get; set; }

        public string Password { get; set; }

        [NotMapped]
        public string PasswordConfirmation { get; set; }
    }
}
