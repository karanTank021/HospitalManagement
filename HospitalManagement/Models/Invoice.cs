using HospitalManagement.Enums;
using HospitalManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Invoice
{
    [Key]
    [Column(TypeName = "uuid")]
    public Guid Id { get; set; }

    [Required]
    [Column(TypeName = "uuid")]
    public Guid PatientId { get; set; }

    [Column(TypeName = "uuid")]
    public Guid? AppointmentId { get; set; }

    [Required]
    [Column(TypeName = "numeric(12,2)")]
    public decimal TotalAmount { get; set; }

    [Required]
    [Column(TypeName = "numeric(12,2)")]
    public decimal PaidAmount { get; set; }

    [Required]
    [StringLength(10)]
    [Column(TypeName = "varchar(10)")]
    public string Currency { get; set; }

    [Required]
    [Column(TypeName = "integer")]
    public PaymentStatus PaymentStatus { get; set; }

    [Required]
    [StringLength(50)]
    [Column(TypeName = "varchar(50)")]
    public string InvoiceNumber { get; set; }

    [Required]
    [Column(TypeName = "timestamp with time zone")]
    public DateTime InvoiceDate { get; set; }

    [Required]
    [Column(TypeName = "timestamp with time zone")]
    public DateTime? DueDate { get; set; }

    // Audit

    [Required]
    [Column(TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; }

    [Column(TypeName = "timestamp with time zone")]
    public DateTime? UpdatedAt { get; set; }

    // Soft delete

    [Required]
    [Column(TypeName = "boolean")]
    public bool IsDeleted { get; set; }

    [Column(TypeName = "timestamp with time zone")]
    public DateTime? DeletedAt { get; set; }

    public Patient Patient { get; set; }
    public Appointment Appointment { get; set; }

    public ICollection<Payment> Payments { get; set; }
}