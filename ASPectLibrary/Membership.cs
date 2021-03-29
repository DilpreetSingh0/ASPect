using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ASPectLibrary
{
    public class Membership
    {
        public string StudentId { get; set; }

        [ForeignKey("StudentId")]
        public ApplicationUser Student { get; set; }

        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
    }
    
}