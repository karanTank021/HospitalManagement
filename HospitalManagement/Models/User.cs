using HospitalManagement.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    [Column(TypeName = "uuid")]
    public Guid Id { get; set; }

    [Required]
    [Column(TypeName = "uuid")]
    public Guid ClinicId { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "varchar(100)")]
    public string FirstName { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "varchar(100)")]
    public string LastName { get; set; }

    [Required]
    [StringLength(150)]
    [Column(TypeName = "varchar(150)")]
    public string Email { get; set; }

    [Required]
    [StringLength(500)]
    [Column(TypeName = "varchar(500)")]
    public string PasswordHash { get; set; }

    [Required]
    [Column(TypeName = "integer")]
    public UserRole Role { get; set; }

    [Required]
    [StringLength(20)]
    [Column(TypeName = "varchar(20)")]
    public string PhoneNumber { get; set; }

    [Required]
    [Column(TypeName = "boolean")]
    public bool IsActive { get; set; }

    [Column(TypeName = "timestamp with time zone")]
    public DateTime? LastLoginAt { get; set; }

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

    public Clinic Clinic { get; set; }
}