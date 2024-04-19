using System.ComponentModel.DataAnnotations;

namespace UserNamespace
{
    public class User
    {
        [Key]
        public int BaseId { get; set; }

        [Required]
        public string BaseUsername { get; set; }
        [Required]
        public int Age { get; set; }

    }
}
