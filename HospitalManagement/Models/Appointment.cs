using HospitalManagement.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Appointment
{
    [Key]
    [Column(TypeName = "uuid")]
    public Guid Id { get; set; }

    [Required]
    [Column(TypeName = "uuid")]
    public Guid PatientId { get; set; }

    [Required]
    [Column(TypeName = "uuid")]
    public Guid DoctorId { get; set; }

    [Required]
    [Column(TypeName = "timestamp with time zone")]
    public DateTime StartDateTime { get; set; }

    [Required]
    [Column(TypeName = "timestamp with time zone")]
    public DateTime EndDateTime { get; set; }

    [Required]
    [Column(TypeName = "integer")]
    public AppointmentStatus Status { get; set; }

    [Column(TypeName = "uuid")]
    public Guid? CreatedByUserId { get; set; }

    [Timestamp]
    [Column(TypeName = "bytea")]
    public byte[] RowVersion { get; set; }

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

    public Doctor Doctor { get; set; }
    public Patient Patient { get; set; }
    public User CreatedByUser { get; set; }
}