using HospitalManagement.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement.Models
{
    public class Plan
    {
        [Key]
        [Column(TypeName = "uuid")]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "numeric(12,2)")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "integer")]
        public BillingCycle BillingCycle { get; set; }

        [StringLength(1000)]
        [Column(TypeName = "varchar(1000)")]
        public string Description { get; set; }
    }
}
