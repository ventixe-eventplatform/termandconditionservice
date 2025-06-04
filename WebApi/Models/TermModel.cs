namespace WebApi.Models;

public class TermModel
{
    public string TermId { get; set; } = null!;
    public string Title { get; set; } = null!;
    public IEnumerable<TermDetailModel> Details { get; set; } = new List<TermDetailModel>();
}
