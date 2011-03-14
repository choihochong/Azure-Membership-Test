using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MultiTenantAuthentication.Models
{
    [MetadataType(typeof(UserProfileMetaData))]
    public partial class UserProfile
    {


    }

    public class UserProfileMetaData
    {
        [Required]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
    }
}