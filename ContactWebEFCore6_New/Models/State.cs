using System.ComponentModel.DataAnnotations;

namespace ContactWebEFCore6_New.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "State")]
        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(2)]
        public string Abbreviation { get; set; }

    }
}
