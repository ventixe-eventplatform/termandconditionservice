using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Data.Entities;
using WebApi.Factories;
using WebApi.Models;


namespace WebApi.Services;

public class TermAndConditionService(DataContext context) : ITermAndConditionService
{
    private readonly DataContext _context = context;

    public async Task<IEnumerable<TermModel>> GetTermsAsync()
    {
        var entities = await _context.Terms.Include(t => t.Details).ToListAsync();

        return entities.Select(TermFactory.Create);
    }
}
