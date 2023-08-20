using System.ComponentModel.DataAnnotations;
namespace Reminders.Client.Models;

public class Reminder
{
    public int Number { get; set; }
    [Required]
    [StringLength(20)]
    public required string Name { get; set; }

    [Required]
    [StringLength(20)]
    public required string Description { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public decimal Time { get; set; }
    
    public DateTime DueDate { get; set; }
}