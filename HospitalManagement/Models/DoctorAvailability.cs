using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class DoctorAvailability
{
    [Key]
    [Column(TypeName = "uuid")]
    public Guid Id { get; set; }

    [Required]
    [Column(TypeName = "uuid")]
    public Guid DoctorId { get; set; }

    [Column(TypeName = "integer")]
    public DayOfWeek? DayOfWeek { get; set; }

    [Column(TypeName = "date")]
    public DateTime? SpecificDate { get; set; }

    [Required]
    [Column(TypeName = "time")]
    public TimeSpan StartTime { get; set; }

    [Required]
    [Column(TypeName = "time")]
    public TimeSpan EndTime { get; set; }

    // Audit

    [Required]
    [Column(TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; }

    [Column(TypeName = "timestamp with time zone")]
    public DateTime? UpdatedAt { get; set; }

    public Doctor Doctor { get; set; }
}