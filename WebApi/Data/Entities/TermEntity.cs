using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data.Entities;

public class TermEntity
{
    [Key]
    [Column(TypeName = "nvarchar(36)")]
    public string TermId { get; set; } = Guid.NewGuid().ToString();

    [Column(TypeName = "nvarchar(50)")]
    public string Title { get; set; } = null!;

    public ICollection<TermDetailEntity> Details { get; set; } = new List<TermDetailEntity>();
}
