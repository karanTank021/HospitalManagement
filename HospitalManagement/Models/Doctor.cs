using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Doctor
{
    [Key]
    [Column(TypeName = "uuid")]
    public Guid Id { get; set; }

    [Required]
    [Column(TypeName = "uuid")]
    public Guid UserId { get; set; }

    [Required]
    [StringLength(150)]
    [Column(TypeName = "varchar(150)")]
    public string Specialization { get; set; }

    [Required]
    [StringLength(150)]
    [Column(TypeName = "varchar(150)")]
    public string Qualification { get; set; }

    [Required]
    [Column(TypeName = "date")]
    public DateTime PracticeStartDate { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ConsultationFee { get; set; }

    [Required]
    [Column(TypeName = "boolean")]
    public bool IsActive { get; set; }

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


    public User User { get; set; }

    public ICollection<DoctorAvailability> Availabilities { get; set; }
}