using WebApi.Data.Entities;
using WebApi.Models;

namespace WebApi.Factories;

public static class TermFactory
{
    public static TermModel Create(TermEntity entity)
    {
        return new TermModel
        {
            TermId = entity.TermId,
            Title = entity.Title,
            Details = entity.Details.Select(t => new TermDetailModel
            {
                TermId = t.TermId,
                TermDetailId = t.TermDetailId,
                Description = t.Description
            }).ToList()
        };
    }
}
