using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data.Entities;

public class TermDetailEntity
{
    [Key]
    [Column(TypeName = "nvarchar(36)")]
    public string TermDetailId { get; set; } = Guid.NewGuid().ToString();

    public string Description { get; set; } = null!;

    [Column(TypeName = "nvarchar(36)")]
    public string TermId { get; set; } = null!;

    [ForeignKey(nameof(TermId))]
    public TermEntity Term { get; set; } = null!;
}
