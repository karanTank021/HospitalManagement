using HospitalManagement.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement.Models
{
    public class Payment
    {
        [Key]
        [Column(TypeName = "uuid")]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "uuid")]
        public Guid InvoiceId { get; set; }

        [Required]
        [Column(TypeName = "numeric(12,2)")]
        public decimal Amount { get; set; }

        [Required]
        [Column(TypeName = "integer")]
        public PaymentMethod Method { get; set; }

        [Required]
        [Column(TypeName = "timestamp with time zone")]
        public DateTime PaymentDate { get; set; }

        public Invoice Invoice { get; set; }
    }
}
