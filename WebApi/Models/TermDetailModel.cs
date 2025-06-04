namespace WebApi.Models;

public class TermDetailModel
{
    public string TermDetailId { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string TermId { get; set; } = null!;
    public TermModel Term { get; set; } = null!;
}
