using System.ComponentModel.DataAnnotations;

namespace ContactWebEFCore6_New.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(250)]
        public string LastName { get; set; }

        [Display(Name = "Email address")]
        [Required]
        [StringLength(250)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Mobile Phone")]
        [Required]
        [StringLength(15)]
        public string PhonePrimary { get; set; }

        [Display(Name = "Home Phone")]
        [Required]
        [StringLength(15)]
        public string PhoneSecondary { get; set; }

        [Display(Name = "Address1")]
        [Required]
        [StringLength(250)]
        public string StreetAddress1 { get; set; }

        [Display(Name = "Address2")]
        [Required]
        [StringLength(250)]
        public string StreetAddress2 { get; set; }

        [Display(Name = "City")]
        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Display(Name = "Zip Code")]
        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string Zip { get; set; }

        [Display(Name = "State")]
        [Required]
        public int StateId { get; set; }

        public virtual State State { get; set; }

        [Required]
        public string UserId { get; set; }

        [Display(Name = "Full Name")]
        public string FriendlyName => $"{FirstName},{LastName}";

        [Display(Name = "Full Address")]
        public string FriendlyAddress => State is null ? "" : string.IsNullOrWhiteSpace(StreetAddress1) ? $"{City},{State.Abbreviation},{Zip}" :
                                         string.IsNullOrWhiteSpace(StreetAddress2) ?
                                                $"{StreetAddress1},{City},{State.Abbreviation},{Zip}" :
                                                $"{StreetAddress1},{StreetAddress2},{City},{State.Abbreviation},{Zip}";




    }
}
