using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models.Models
{
    public class Staffs
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [DisplayName("Employee Name")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Employee name must be between 1 and 100 only!!")]

        public string? Code { get; set; }

        public int ContactNo { get; set; }

        public string Email { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? Description { get; set; }

        public string? CurStatus { get; set; }

        public string? IsActive { get; set; }

        public string? CreatedUser { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public string? LastUpdatedUser { get; set; }

        public DateTime? LastUpdatedOn { get; set; } = DateTime.Now;
    }
}
