using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KickOff.Models
{
    
        public class Author
        {
            [Key]
            public int AuthorId { get; set; }

            [Required]
            [MaxLength(100)]
            public string Name { get; set; }

            [MaxLength(250)]
            public string ProfilePhoto { get; set; }

            [Required]
            [MaxLength(100)]
            public string Email { get; set; }

            [Required]
            [MaxLength(100)]
            public string Password { get; set; }

            [Required]
            [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
            public DateTime CreatedAt { get; set; }

            public DateTime? UpdatedAt { get; set; }

            public ICollection<Post> Posts { get; set; }
        }
    }

