using HospitalManagement.Enums;
using HospitalManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Subscription
{
    [Key]
    [Column(TypeName = "uuid")]
    public Guid Id { get; set; }

    [Required]
    [Column(TypeName = "uuid")]
    public Guid ClinicId { get; set; }

    [Required]
    [Column(TypeName = "uuid")]
    public Guid PlanId { get; set; }

    [Required]
    [StringLength(10)]
    [Column(TypeName = "varchar(10)")]
    public string Currency { get; set; }

    [Required]
    [Column(TypeName = "timestamp with time zone")]
    public DateTime StartDate { get; set; }

    [Required]
    [Column(TypeName = "timestamp with time zone")]
    public DateTime EndDate { get; set; }

    [Required]
    [Column(TypeName = "integer")]
    public SubscriptionStatus Status { get; set; }

    [StringLength(200)]
    [Column(TypeName = "varchar(200)")]
    public string StripeCustomerId { get; set; }

    [StringLength(200)]
    [Column(TypeName = "varchar(200)")]
    public string StripeSubscriptionId { get; set; }

    [Column(TypeName = "timestamp with time zone")]
    public DateTime? CancelledAt { get; set; }

    // Audit

    [Required]
    [Column(TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; }

    [Column(TypeName = "timestamp with time zone")]
    public DateTime? UpdatedAt { get; set; }

    public Clinic Clinic { get; set; }
    public Plan Plan { get; set; }
}